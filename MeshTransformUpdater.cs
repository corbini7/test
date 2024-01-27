using System;
using System.Collections.Generic;
using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    public class MeshTransformUpdater : MonoBehaviour
    {
        // Reference to the GameObject part that this script follows.
        public GameObject PartToFollow;

        // Flag to indicate if teleportation is going to happen.
        public bool willTeleport;

        /// Private fields for internal state management.
        private bool isTeleportationDetected;

        private Vector3 previousLocalPosition;

        private Vector3 currentLocalPosition;

        private Quaternion previousLocalRotation;

        private Quaternion currentLocalRotation;

        private float positionUpdateDelay;

        private int fixedUpdateCount;

        private int updateCycleCount;

        private bool isPositionAndRotationForced;

        private Vector3 forcedLocalPosition;

        private Quaternion forcedLocalRotation;

        private bool isFirstUpdateCycle = true;

        private List<Vector3> slowMotionPositions;

        private List<Quaternion> slowMotionRotations;

        private bool isFrozen;

        private Queue<Vector3> positionQueue;

        private Queue<Quaternion> rotationQueue;

        private Vector3 lastRecordedPosition;

        private Quaternion lastRecordedRotation;

        private Vector3 interpolatedPosition;

        private Quaternion interpolatedRotation;

        private bool isBufferingActive;

        private Transform cachedTransform;

        private DejitterManager dejitterManager;
        ///

        // Property to get cached transform for optimization.
        private Transform CachedTransform
        {
            get
            {
                if (this.cachedTransform == null)
                {
                    this.cachedTransform = base.transform;
                }
                return this.cachedTransform;
            }
        }

        // Method to reset forced position and rotation state.
        public void ResetPositionAndRotation()
        {
            this.isPositionAndRotationForced = false;
        }

        private void Awake()
        {
            this.dejitterManager = DejitterManager.Singleton;
            this.slowMotionPositions = new List<Vector3>();
            this.slowMotionRotations = new List<Quaternion>();
            this.positionQueue = new Queue<Vector3>();
            this.rotationQueue = new Queue<Quaternion>();
            this.isBufferingActive = true;
        }

        // Method to enable freezing the object's position and rotation.
        public void Freeze()
        {
            this.isFrozen = true;
        }

        // Method to disable freezing, allowing object to move again.
        public void Unfreeze()
        {
            this.isFrozen = false;
        }

        // Method to detect significant movement between two positions.
        private bool IsSignificantMovementDetected(Vector3 position1, Vector3 position2)
        {
            return Vector3.SqrMagnitude(new Vector3(position1.x - position2.x, position1.y - position2.y, position1.z - position2.z)) > 4f;
        }

        // Method to forcibly set the object's position and rotation.
        public void ForcePositionAndRotation(Vector3 newPosition, Quaternion newRotation)
        {
            this.isPositionAndRotationForced = true;
            this.forcedLocalPosition = newPosition;
            this.forcedLocalRotation = newRotation;
        }

        // Method to initialize slow motion state.
        private void InitializeSlowMotionState()
        {
            if (SlowMotionManager.Singleton.isSlowMotion && !SlowMotionManager.Singleton.IsUsingTimeScale)
            {
                this.slowMotionPositions.Clear();
                this.slowMotionRotations.Clear();
                this.slowMotionPositions.Add(this.currentLocalPosition);
                this.slowMotionRotations.Add(this.currentLocalRotation);
            }
            this.isTeleportationDetected = false;
        }

        private void Update()
        {
            // If position and rotation are forced, apply them and return.
            if (this.isPositionAndRotationForced)
            {
                this.CachedTransform.position = this.forcedLocalPosition;
                this.CachedTransform.rotation = this.forcedLocalRotation;
                return;
            }
            // If the object is frozen, do not update its position or rotation.
            if (this.isFrozen)
            {
                return;
            }
            // Manage update delay for position changes.
            this.positionUpdateDelay = (float)this.fixedUpdateCount * Time.fixedDeltaTime + this.positionUpdateDelay - Time.deltaTime;
            if (this.positionUpdateDelay > Time.fixedDeltaTime)
            {
                this.positionUpdateDelay = Time.fixedDeltaTime;
            }
            else if (this.positionUpdateDelay < 0f)
            {
                this.positionUpdateDelay = 0f;
            }
            if (this.isFirstUpdateCycle)
            {
                this.isFirstUpdateCycle = false;
            }
            else if (Vector3.Distance(this.currentLocalPosition, this.previousLocalPosition) > 2f)
            {
                this.CachedTransform.localPosition = this.previousLocalPosition;
                this.CachedTransform.localRotation = this.previousLocalRotation;
            }
            else
            {
                float num = (Time.fixedDeltaTime - this.positionUpdateDelay) / Time.fixedDeltaTime;
                this.CachedTransform.localPosition = num * (this.currentLocalPosition - this.previousLocalPosition) + this.previousLocalPosition;
                this.CachedTransform.localRotation = Quaternion.Slerp(this.previousLocalRotation, this.currentLocalRotation, num);
            }
            // Reset the update count for the next cycle.
            this.fixedUpdateCount = 0;
        }

        private void FixedUpdate()
        {
            // If there is no part to follow, return.
            if (this.PartToFollow == null)
            {
                return;
            }
            // Update counters for each physics step.
            this.fixedUpdateCount++;
            this.updateCycleCount++;
            if (this.updateCycleCount == 1)
            {
                this.currentLocalPosition = this.PartToFollow.transform.localPosition;
                this.currentLocalRotation = this.PartToFollow.transform.localRotation;
                this.previousLocalPosition = this.currentLocalPosition;
                this.previousLocalRotation = this.currentLocalRotation;
                this.lastRecordedPosition = this.currentLocalPosition;
                this.lastRecordedRotation = this.currentLocalRotation;
                this.interpolatedPosition = this.lastRecordedPosition;
                this.interpolatedRotation = this.lastRecordedRotation;
            }
            this.previousLocalPosition = this.currentLocalPosition;
            this.previousLocalRotation = this.currentLocalRotation;
            Vector3 localPosition = this.PartToFollow.transform.localPosition;
            Quaternion localRotation = this.PartToFollow.transform.localRotation;
            if (this.dejitterManager.interpolationCount > 0)
            {
                this.positionQueue.Enqueue(this.lastRecordedPosition);
                this.rotationQueue.Enqueue(this.lastRecordedRotation);
                bool flag = this.IsSignificantMovementDetected(this.lastRecordedPosition, localPosition);
                for (int i = 1; i < this.dejitterManager.interpolationCount; i++)
                {
                    float t = flag ? 1f : ((float)i / (float)this.dejitterManager.interpolationCount);
                    Vector3 item = Vector3.Lerp(this.lastRecordedPosition, localPosition, t);
                    this.positionQueue.Enqueue(item);
                    Quaternion item2 = Quaternion.Slerp(this.lastRecordedRotation, localRotation, t);
                    this.rotationQueue.Enqueue(item2);
                }
                this.lastRecordedPosition = localPosition;
                this.lastRecordedRotation = localRotation;
            }
            if (this.isBufferingActive && (float)this.positionQueue.Count < this.dejitterManager.bufTargetSize)
            {
                return;
            }
            this.isBufferingActive = false;
            float num = (float)this.positionQueue.Count - this.dejitterManager.bufTargetSize;
            num = ((num < 0f) ? 0f : num);
            while (num >= 1f && this.positionQueue.Count >= 1)
            {
                this.interpolatedPosition = this.positionQueue.Dequeue();
                this.interpolatedRotation = this.rotationQueue.Dequeue();
                num -= 1f;
            }
            if (num > 0f && this.positionQueue.Count <= 0 && "Body_hip".Equals(base.name))
            {
                Debug.LogErrorFormat("[MeshTransformUpdater] No data is available in position queue of {0}", new object[]
                {
                base.transform.parent.name
                });
            }
            if (this.positionQueue.Count > 0 && !this.IsSignificantMovementDetected(this.interpolatedPosition, this.positionQueue.Peek()))
            {
                this.currentLocalPosition = Vector3.Lerp(this.interpolatedPosition, this.positionQueue.Peek(), num);
                this.currentLocalRotation = Quaternion.Slerp(this.interpolatedRotation, this.rotationQueue.Peek(), num);
            }
            else
            {
                this.currentLocalPosition = this.interpolatedPosition;
                this.currentLocalRotation = this.interpolatedRotation;
            }
            if (SlowMotionManager.Singleton != null && SlowMotionManager.Singleton.isJustSwitched)
            {
                this.InitializeSlowMotionState();
            }
            if (SlowMotionManager.Singleton != null && SlowMotionManager.Singleton.isSlowMotion && !SlowMotionManager.Singleton.IsUsingTimeScale)
            {
                this.HandleSlowMotionUpdate();
            }
            this.willTeleport = this.IsSignificantMovementDetected(this.currentLocalPosition, this.previousLocalPosition);
            if (!this.isPositionAndRotationForced && !this.isFrozen && !this.willTeleport)
            {
                this.CachedTransform.localPosition = this.currentLocalPosition;
                this.CachedTransform.localRotation = this.currentLocalRotation;
            }
        }

        private void HandleSlowMotionUpdate()
        {
            if (this.slowMotionPositions.Count == 0)
            {
                Debug.LogFormat("[MeshTransformUpdater] add fake slow motion data on {0}", new object[]
                {
                base.name
                });
                int num = 0;
                while ((float)num <= SlowMotionManager.Singleton.smPlayCount)
                {
                    this.slowMotionPositions.Add(new Vector3(10000f, 10000f, 0f));
                    this.slowMotionRotations.Add(Quaternion.identity);
                    num++;
                }
            }
            this.slowMotionPositions.Add(this.currentLocalPosition);
            this.slowMotionRotations.Add(this.currentLocalRotation);
            int playIdx = SlowMotionManager.Singleton.playIdx;
            float percent = SlowMotionManager.Singleton.percent;
            float nextStep = SlowMotionManager.Singleton.nextStep;
            if (playIdx < this.slowMotionPositions.Count - 1)
            {
                int num2 = 0;
                while ((double)num2 < Math.Ceiling((double)nextStep))
                {
                    if (this.isTeleportationDetected)
                    {
                        this.willTeleport = false;
                        break;
                    }
                    if (playIdx + num2 + 1 >= this.slowMotionPositions.Count)
                    {
                        this.willTeleport = false;
                        break;
                    }
                    if (this.IsSignificantMovementDetected(this.slowMotionPositions[playIdx + num2 + 1], this.slowMotionPositions[playIdx + num2]))
                    {
                        if ("Body_hip".Equals(base.name) && base.transform.parent != null)
                        {
                            Debug.LogFormat("[MeshTransformUpdater] {0} will teleport in next frame, current position {1}, next position {2}, playIdx = {3}, nextStep = {4}", new object[]
                            {
                            base.transform.parent.name,
                            this.slowMotionPositions[playIdx + num2],
                            this.slowMotionPositions[playIdx + num2 + 1],
                            playIdx,
                            nextStep
                            });
                        }
                        this.willTeleport = true;
                        this.isTeleportationDetected = true;
                        break;
                    }
                    num2++;
                }
                if (Vector3.Distance(this.slowMotionPositions[playIdx + 1], this.slowMotionPositions[playIdx]) > 2f)
                {
                    this.currentLocalPosition = this.slowMotionPositions[playIdx + 1];
                    this.currentLocalRotation = this.slowMotionRotations[playIdx + 1];
                    return;
                }
                this.currentLocalPosition = percent * (this.slowMotionPositions[playIdx + 1] - this.slowMotionPositions[playIdx]) + this.slowMotionPositions[playIdx];
                this.currentLocalRotation = Quaternion.Slerp(this.slowMotionRotations[playIdx], this.slowMotionRotations[playIdx + 1], percent);
            }
        }
    }
}