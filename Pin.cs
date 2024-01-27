using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    public class Pin : WeaponProjectile
    {




        internal override void UpdateProjectilePhysics()
        {
            if (PhysicsDummyModeManager.IsPaused)
            {
                return;
            }
            if (!this.isPinActive)
            {
                return;
            }
            if (this.PinConfigurableJoint == null)
            {
                if (this.attachAttemptDuration > 10f)
                {
                    this.isPinActive = false;
                    this.attachAttemptDuration = 0f;
                }
                this.attachAttemptDuration += Time.fixedDeltaTime;
                Collider collider = null;
                int num = Physics.OverlapCapsuleNonAlloc(this.DetectPointA.position, this.DetectPointB.position, 0.055f, this.detectedColliders, this.raycastLayer);
                for (int i = 0; i < num; i++)
                {
                    if (PhysicsIgnoredList.PinCantAttachObjects == null || !PhysicsIgnoredList.PinCantAttachObjects.Contains(this.detectedColliders[i].gameObject))
                    {
                        collider = this.detectedColliders[i];
                        if (ElectricStatesManager.gameObjectToElectricStateMap.ContainsKey(collider.gameObject))
                        {
                            this.attachedElectricState = ElectricStatesManager.gameObjectToElectricStateMap[collider.gameObject];
                            break;
                        }
                    }
                }
                if (collider != null)
                {
                    this.PinConfigurableJoint = base.gameObject.AddComponent<ConfigurableJoint>();
                    this.PinConfigurableJoint.connectedBody = collider.gameObject.GetComponent<Rigidbody>();
                    this.PinConfigurableJoint.anchor = this.jointAnchorPoint;
                    this.PinConfigurableJoint.xMotion = ConfigurableJointMotion.Locked;
                    this.PinConfigurableJoint.yMotion = ConfigurableJointMotion.Locked;
                    this.PinConfigurableJoint.zMotion = ConfigurableJointMotion.Locked;
                    this.PinConfigurableJoint.angularXDrive = this.jointDriveSettings;
                    this.PinConfigurableJoint.angularYZDrive = this.jointDriveSettings;
                    if (PccManager.rigidbodyCharacterControllerMap.ContainsKey(collider.gameObject))
                    {
                        this.attachedCharacterController = PccManager.rigidbodyCharacterControllerMap[collider.gameObject];
                        this.attachedCharacterController.FIFLMFGANEM.Add(this);
                        return;
                    }
                }
            }
            else if (this.remainingElectricDuration > 0f)
            {
                this.remainingElectricDuration -= Time.fixedDeltaTime;
                if (this.attachedElectricState != null)
                {
                    this.attachedElectricState.ConductElectricity(this.electricUnit);
                    CharacterElectricStates characterElectricStates = this.attachedElectricState as CharacterElectricStates;
                    if (characterElectricStates != null)
                    {
                        base.NotifyAttackListeners(characterElectricStates.physicCharacterController);
                        return;
                    }
                }
            }
            else
            {
                this.DestroyJoint();
            }
        }










        internal override void ActivatePin()
        {
            this.isPinActive = true;
            this.remainingElectricDuration = this.targetElectricDuration;
        }





        protected override void Awake()
        {
            base.Awake();
            this.jointAnchorPoint = (this.DetectPointA.localPosition + this.DetectPointB.localPosition) * 0.5f;
        }


        public void DestroyJoint()
        {
            Object.Destroy(this.PinConfigurableJoint);
            this.PinConfigurableJoint = null;
            this.attachedElectricState = null;
            this.isPinActive = false;
        }










        private ConfigurableJoint PinConfigurableJoint
        {
            get
            {
                return this.configurableJointField;
            }
            set
            {
                if (this.configurableJointField != value)
                {
                    if (value == null && this.attachedCharacterController != null)
                    {
                        this.attachedCharacterController.FIFLMFGANEM.Remove(this);
                        this.attachedCharacterController = null;
                    }
                    this.configurableJointField = value;
                }
            }
        }

        public bool isAttachedToSomething
        {
            get
            {
                return this.PinConfigurableJoint != null;
            }
        }








        private ConfigurableJoint configurableJointField;

        public Transform DetectPointA;

        public Transform DetectPointB;

        private bool isPinActive;

        public LayerMask raycastLayer;

        private Collider[] detectedColliders = new Collider[10];

        private ElectricStates attachedElectricState;

        public float targetElectricDuration = 6f;

        private float remainingElectricDuration;

        private float attachAttemptDuration;

        private Vector3 jointAnchorPoint;

        private JointDrive jointDriveSettings = new JointDrive
        {
            positionSpring = 100f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private ElectricUnit electricUnit = new ElectricUnit();

        private PhysicCharacterController attachedCharacterController;
    }
}