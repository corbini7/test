using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    internal class ArmBoneTransForm : BonesTransforms
    {
        public GameObject UpperArmRigidbody;

        public Transform UpperArmBoneTransform;

        private Vector3 initialArmPosition;

        private Quaternion initialArmRotation;

        public Transform ChestBoneTransform;

        private GameObject followedGameObject;

        private Vector3 chestToArmOffset;

        private Vector3 armOffset;

        private Matrix4x4 inverseArmMatrix;

        private Matrix4x4 armMatrix;

        private Vector3 chestJointPosition;

        private Vector4 chestJointVector;

        private Vector3 armJointPosition;

        private Vector3 crossProductVector;

        private Vector3 planeNormalVector;

        private Vector3 armDirectionVector;


        protected override void Awake()
        {
            base.Awake();
            this.followedGameObject = this.PartToFollow;
            Vector3 anchor = this.UpperArmRigidbody.GetComponent<ConfigurableJoint>().anchor;
            Vector3 anchor2 = this.followedGameObject.GetComponent<ConfigurableJoint>().anchor;
            this.chestJointPosition = this.UpperArmRigidbody.transform.localToWorldMatrix.MultiplyPoint3x4(anchor);
            this.chestToArmOffset = this.ChestBoneTransform.worldToLocalMatrix.MultiplyPoint3x4(this.chestJointPosition);
            this.armJointPosition = this.followedGameObject.transform.localToWorldMatrix.MultiplyPoint3x4(anchor2);
            this.armOffset = base.transform.worldToLocalMatrix.MultiplyPoint3x4(this.armJointPosition);
            this.armDirectionVector = (this.armJointPosition - this.chestJointPosition).normalized;
            this.planeNormalVector = Vector3.ProjectOnPlane(base.transform.up, this.armDirectionVector).normalized;
            this.crossProductVector = Vector3.Cross(this.planeNormalVector, this.armDirectionVector).normalized;
            this.chestJointVector.x = this.chestJointPosition.x;
            this.chestJointVector.y = this.chestJointPosition.y;
            this.chestJointVector.z = this.chestJointPosition.z;
            this.chestJointVector.w = 1f;
            this.armMatrix = new Matrix4x4(this.crossProductVector, this.planeNormalVector, this.armDirectionVector, this.chestJointVector);
            this.inverseArmMatrix = Matrix4x4.Inverse(this.armMatrix);
            this.initialArmPosition = this.inverseArmMatrix.MultiplyPoint3x4(this.UpperArmBoneTransform.position);
            this.initialArmRotation = Quaternion.Inverse(Quaternion.LookRotation(this.armDirectionVector, this.planeNormalVector)) * this.UpperArmBoneTransform.rotation;
        }

        public override void UpdateTrans(bool GEFIPEMHHMF)
        {
            if (GEFIPEMHHMF)
            {
                base.transform.position = this.PartToFollow.transform.localToWorldMatrix.MultiplyPoint3x4(this.relativePositionOffset);
                base.transform.rotation = this.PartToFollow.transform.rotation * this.relativeRotationOffset;
            }
            this.chestJointPosition = this.ChestBoneTransform.localToWorldMatrix.MultiplyPoint3x4(this.chestToArmOffset);
            this.armJointPosition = base.transform.localToWorldMatrix.MultiplyPoint3x4(this.armOffset);
            this.armDirectionVector = (this.armJointPosition - this.chestJointPosition).normalized;
            this.planeNormalVector = Vector3.ProjectOnPlane(base.transform.up, this.armDirectionVector).normalized;
            this.crossProductVector = Vector3.Cross(this.planeNormalVector, this.armDirectionVector).normalized;
            this.chestJointVector.x = this.chestJointPosition.x;
            this.chestJointVector.y = this.chestJointPosition.y;
            this.chestJointVector.z = this.chestJointPosition.z;
            this.chestJointVector.w = 1f;
            this.armMatrix = new Matrix4x4(this.crossProductVector, this.planeNormalVector, this.armDirectionVector, this.chestJointVector);
            this.UpperArmBoneTransform.position = this.armMatrix.MultiplyPoint3x4(this.initialArmPosition);
            this.UpperArmBoneTransform.rotation = Quaternion.LookRotation(this.armDirectionVector, this.planeNormalVector) * this.initialArmRotation;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.chestJointPosition, 0.06f);
            Gizmos.DrawWireSphere(this.armJointPosition, 0.06f);
            Gizmos.color = Color.red;
            Gizmos.DrawRay(this.chestJointPosition, this.crossProductVector * 0.5f);
            Gizmos.color = Color.green;
            Gizmos.DrawRay(this.chestJointPosition, this.planeNormalVector * 0.5f);
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(this.chestJointPosition, this.armDirectionVector * 0.5f);
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(this.chestJointPosition, this.armJointPosition);
        }
    }
}