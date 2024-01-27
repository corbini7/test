using System.Collections;
using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    public class Arrow : WeaponProjectile
    {











        private ConfigurableJoint ArrowConfigurableJoint
        {
            get
            {
                return this.ArrowJoint;
            }
            set
            {
                if (this.ArrowJoint != value)
                {
                    if (value == null)
                    {
                        this.ResetBoxColliderToOriginal();
                        if (this.attachedCharacterController != null)
                        {
                            this.attachedCharacterController.PFBHDFNHIDA.Remove(this);
                            this.attachedCharacterController = null;
                        }
                    }
                    this.ArrowJoint = value;
                }
            }
        }

        protected override void Awake()
        {
            base.Awake();
            this.ShelfRigidbody.maxDepenetrationVelocity = 1f;
            this.isAttachedToStaticObj = false;
            this.RotationFrequency = UnityEngine.Random.Range(-10f, 10f);
            this.OriginalBoxColliderCenter = this.selfBoxCollider.center;
            this.OriginalBoxColliderSize = this.selfBoxCollider.size;
            this.AdjustedColliderCenter = this.OriginalBoxColliderCenter - this.OriginalBoxColliderSize.z * 0.5f * Vector3.forward;
        }

        private void OnJointBreak(float breakForce)
        {
            this.ResetBoxColliderToOriginal();
        }















        private void CheckCollisionAndRaycast(int colliderCount, Collider[] colliders, out bool isHit, out RaycastHit hitInfo)
        {
            hitInfo = default(RaycastHit);
            isHit = false;
            if (colliderCount == 0)
            {
                return;
            }
            Ray ray = new Ray(this.DetectPointB.position, this.DetectPointB.forward);
            isHit = colliders[0].Raycast(ray, out hitInfo, 0.7f);
        }












        public bool isAttachedToStaticObj { get; private set; }















        public void DestroyJoint()
        {
            Object.Destroy(this.ArrowConfigurableJoint);
            this.ResetBoxColliderToOriginal();
        }










        protected override void OnDestroy()
        {
            base.OnDestroy();
            this.ResetBoxColliderToOriginal();
        }




        private void SetupJointAndApplyForces(float jointBreakForce, JointDrive jointDriveSettings, Vector3 jointAnchor, Rigidbody connectedRigidbody)
        {
            this.ArrowConfigurableJoint = base.gameObject.AddComponent<ConfigurableJoint>();
            this.ArrowConfigurableJoint.xMotion = ConfigurableJointMotion.Locked;
            this.ArrowConfigurableJoint.yMotion = ConfigurableJointMotion.Locked;
            this.ArrowConfigurableJoint.zMotion = ConfigurableJointMotion.Locked;
            this.ArrowConfigurableJoint.angularXMotion = ConfigurableJointMotion.Free;
            this.ArrowConfigurableJoint.angularYMotion = ConfigurableJointMotion.Free;
            this.ArrowConfigurableJoint.angularZMotion = ConfigurableJointMotion.Free;
            this.ArrowConfigurableJoint.breakForce = float.MaxValue;
            this.ArrowConfigurableJoint.breakTorque = float.MaxValue;
            // Fake or real?
            base.StartCoroutine(this.CoroutineSetJointBreakingThreshold(this.ArrowConfigurableJoint, jointBreakForce));
            this.ArrowConfigurableJoint.angularXDrive = jointDriveSettings;
            this.ArrowConfigurableJoint.angularYZDrive = jointDriveSettings;
            this.ArrowConfigurableJoint.anchor = jointAnchor;
            this.ArrowConfigurableJoint.connectedBody = connectedRigidbody;
        }


        // REAL
        internal override void UpdateProjectilePhysics()
        {
            if (PhysicsDummyModeManager.IsPaused)
            {
                return;
            }
            if (this.ShelfRigidbody.IsSleeping())
            {
                return;
            }
            this.PreviousVelocity = this.ShelfRigidbody.velocity;
            if (this.ArrowConfigurableJoint == null)
            {
                int detectedColliderCount;
                this.GetOverlappingColliders(out detectedColliderCount, this.DetectedColliders);
                bool flag;
                RaycastHit raycastHit;
                this.CheckCollisionAndRaycast(detectedColliderCount, this.DetectedColliders, out flag, out raycastHit);
                Collider collider = raycastHit.collider;
                if (flag && collider.gameObject.layer != this.originalLayer && collider.gameObject.layer != 10 && (PhysicsIgnoredList.ArrowCantAttachObjects == null || !PhysicsIgnoredList.ArrowCantAttachObjects.Contains(collider.gameObject)))
                {
                    Rigidbody rigidbody = raycastHit.rigidbody;
                    this.HandleCollisionResponse(rigidbody, raycastHit.normal, raycastHit.point, (this.PreviousVelocity.magnitude > this.LastFrameVelocity.magnitude) ? this.PreviousVelocity : this.LastFrameVelocity, raycastHit.distance);
                }
                this.ApplyOscillationForces();
            }
            else
            {
                this.CheckAndAdjustJointForces();
            }
            this.LastFrameVelocity = this.PreviousVelocity;
        }







        private void CheckAndAdjustJointForces()
        {
            float magnitude = this.ArrowConfigurableJoint.currentForce.magnitude;
            float magnitude2 = this.ArrowConfigurableJoint.currentTorque.magnitude;
            if (magnitude > 50f)
            {
                this.ArrowConfigurableJoint.breakForce = this.ArrowConfigurableJoint.breakForce - magnitude * 0.006f;
            }
            if (magnitude2 > 10f)
            {
                this.ArrowConfigurableJoint.breakTorque = this.ArrowConfigurableJoint.breakTorque - magnitude2 * 0.006f;
            }
        }







        private void HandleCollisionResponse(Rigidbody hitRigidbody, Vector3 hitNormal, Vector3 hitPoint, Vector3 arrowVelocity, float hitDistance)
        {
            if (Vector3.Angle(arrowVelocity, -hitNormal) > 60f)
            {
                return;
            }
            Vector3 point = this.DetectPointB.position + this.DetectPointB.forward * hitDistance;
            Vector3 vector = this.ShelfTransform.worldToLocalMatrix.MultiplyPoint3x4(point);
            if (hitRigidbody == null)
            {
                Vector3 vector2 = arrowVelocity;
                float calculatedForceValue = Mathf.Clamp(350f * vector2.magnitude - 1500f, 0f, 14000f);
                if (Vector3.Project(vector2, -hitNormal).magnitude > 4f)
                {
                    this.IsJointCreated = true;
                    this.SetupJointAndApplyForces(calculatedForceValue, this.JointDriveSettings, vector + 0.02f * Vector3.forward, null);
                    this.isAttachedToStaticObj = true;
                    float num = vector.z - this.AdjustedColliderCenter.z;
                    this.selfBoxCollider.size = new Vector3(this.OriginalBoxColliderSize.x, this.OriginalBoxColliderSize.y, num);
                    this.selfBoxCollider.center = this.AdjustedColliderCenter + num * 0.5f * Vector3.forward;
                    return;
                }
            }
            else
            {
                Vector3 vector2 = arrowVelocity - hitRigidbody.GetPointVelocity(hitPoint);
                float calculatedForceValue2 = Mathf.Clamp(300f * vector2.magnitude - 3300f, 0f, 14000f);
                if (Vector3.Project(vector2, -hitNormal).magnitude > 4f)
                {
                    this.IsJointCreated = true;
                    this.SetupJointAndApplyForces(calculatedForceValue2, this.JointDriveSettings, vector + 0.02f * Vector3.forward, hitRigidbody);
                    this.isAttachedToStaticObj = false;
                    this.ApplyImpactForceToRigidbody(vector2, hitRigidbody, hitPoint);
                }
                if (PccManager.rigidbodyCharacterControllerMap.ContainsKey(hitRigidbody.gameObject))
                {
                    this.attachedCharacterController = PccManager.rigidbodyCharacterControllerMap[hitRigidbody.gameObject];
                    CharacterStates characterStates = this.attachedCharacterController.characterStates;
                    this.attachedCharacterController.PFBHDFNHIDA.Add(this);
                    float num2 = 1f;
                    if (this.attachedCharacterController.IFEGFIOLHFC.ContainsKey(hitRigidbody.gameObject))
                    {
                        num2 = this.attachedCharacterController.IFEGFIOLHFC[hitRigidbody.gameObject].DamageTweak;
                    }
                    if (characterStates.Health > 0f && !characterStates.IsInvincible)
                    {
                        base.NotifyAttackListeners(this.attachedCharacterController);
                    }
                    float num3 = this.DizzyDamageOnHit * 0.01f * characterStates.AntiDizzy * characterStates.AntiDizzyByEquip * num2;
                    characterStates.DBHFPLBJGKH(num3);
                    float num4 = this.HealthDamageOnHit * 0.005f * characterStates.AntiHealthLose * characterStates.AntiHealthLoseByEquip * num2;
                    if (characterStates.Health - num4 <= 0f && characterStates.Health > 0f && !characterStates.IsInvincible)
                    {
                        base.NotifyKillListeners(this.attachedCharacterController);
                    }
                    characterStates.Health -= num4;
                    if (this.physicCharacterController != null)
                    {
                        this.physicCharacterController.KAAHJGOJOMI += num3;
                        this.physicCharacterController.NBJBDBJDKFG += num4;
                    }
                }
            }
        }




        private void ApplyOscillationForces()
        {
            Vector3 vector = this.ShelfTransform.position - this.ShelfTransform.forward * 0.9f;
            Vector3 pointVelocity = this.ShelfRigidbody.GetPointVelocity(vector);
            float magnitude = pointVelocity.magnitude;
            this.RotationFrequency += Time.fixedDeltaTime * Mathf.Pow(magnitude, 2f) * 0.008f;
            this.RandomOscillationVector.x = Mathf.Cos(this.RotationFrequency);
            this.RandomOscillationVector.y = Mathf.Sin(this.RotationFrequency);
            this.RandomOscillationVector.z = 0f;
            Vector3 a = this.ShelfTransform.localToWorldMatrix.MultiplyVector(this.RandomOscillationVector);
            float f = Mathf.Max(magnitude - 0.3f, 0f);
            Vector3 force = (-pointVelocity.normalized + a * 0.05f) * Mathf.Pow(f, 2f) * 0.03f;
            this.ShelfRigidbody.AddForceAtPosition(force, vector);
        }













        private void ApplyImpactForceToRigidbody(Vector3 impactForce, Rigidbody targetRigidbody, Vector3 impactPoint)
        {
            targetRigidbody.AddForceAtPosition(impactForce.magnitude * this.ShelfTransform.forward * 6f, impactPoint, ForceMode.Impulse);
        }








        private void GetOverlappingColliders(out int colliderCount, Collider[] colliders)
        {
            colliderCount = Physics.OverlapCapsuleNonAlloc(this.DetectPointA.position, this.DetectPointB.position, this.DetectRadius, colliders, this.rayCastLayer);
        }











        public bool isAttachedToSomething
        {
            get
            {
                return this.ArrowConfigurableJoint != null;
            }
        }






        // Fake or real?
        private IEnumerator CoroutineSetJointBreakingThreshold(ConfigurableJoint targetJoint, float thresholdForce)
        {
            //num = 0;
            while (/*num < 5 && */targetJoint != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num++;
                }
                yield return this.waitForFixedUpdate;
            }
            if (targetJoint != null)
            {
                targetJoint.breakForce = thresholdForce;
                targetJoint.breakTorque = thresholdForce;
            }
            yield break;
        }



        private void ResetBoxColliderToOriginal()
        {
            if (this.selfBoxCollider == null)
            {
                return;
            }
            this.selfBoxCollider.center = this.OriginalBoxColliderCenter;
            this.selfBoxCollider.size = this.OriginalBoxColliderSize;
            this.isAttachedToStaticObj = false;
        }


        public Transform DetectPointA;

        public Transform DetectPointB;

        public LayerMask rayCastLayer;

        public float DetectRadius = 0.1f;

        private Collider[] DetectedColliders = new Collider[1];

        private ConfigurableJoint ArrowJoint;

        private float RotationFrequency;

        private Vector3 PreviousVelocity;

        private Vector3 LastFrameVelocity;

        private bool IsJointCreated;

        private readonly JointDrive JointDriveSettings = new JointDrive
        {
            positionSpring = 600f,
            positionDamper = 2f,
            maximumForce = float.MaxValue
        };

        private Vector3 OriginalBoxColliderCenter;

        private Vector3 OriginalBoxColliderSize;

        private Vector3 AdjustedColliderCenter;

        public BoxCollider selfBoxCollider;

        private PhysicCharacterController attachedCharacterController;

        public float HealthDamageOnHit;

        public float DizzyDamageOnHit;

        private Vector3 RandomOscillationVector = Vector3.zero;
    }
}