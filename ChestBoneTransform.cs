using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    internal class ChestBoneTransform : BonesTransforms
    {
        public GameObject WaistRigidbody;

        public Transform WaistBoneTranform;

        private Vector3 initialWaistPosition;

        private Quaternion initialWaistRotation;

        public Transform HipBoneTransform;

        private GameObject followedGameObject;

        private Vector3 hipToWaistOffset;

        private Vector3 chestOffset;

        private Matrix4x4 inverseTransformationMatrix;

        private Matrix4x4 transformationMatrix;

        private Vector3 waistJointPosition;

        private Vector4 waistJointVector;

        private Vector3 chestJointPosition;

        private Vector3 crossProductDirection;

        private Vector3 projectedPlaneDirection;

        private Vector3 waistToChestDirection;


        protected override void Awake()
        {
            base.Awake();
            this.followedGameObject = this.PartToFollow;
            Vector3 anchor = this.WaistRigidbody.GetComponent<ConfigurableJoint>().anchor;
            Vector3 anchor2 = this.followedGameObject.GetComponent<ConfigurableJoint>().anchor;
            this.waistJointPosition = this.WaistRigidbody.transform.localToWorldMatrix.MultiplyPoint3x4(anchor);
            this.hipToWaistOffset = this.HipBoneTransform.worldToLocalMatrix.MultiplyPoint3x4(this.waistJointPosition);
            this.chestJointPosition = this.followedGameObject.transform.localToWorldMatrix.MultiplyPoint3x4(anchor2);
            this.chestOffset = base.transform.worldToLocalMatrix.MultiplyPoint3x4(this.chestJointPosition);
            this.waistToChestDirection = (this.waistJointPosition - this.chestJointPosition).normalized;
            this.projectedPlaneDirection = Vector3.ProjectOnPlane(this.HipBoneTransform.forward + base.transform.forward, this.waistToChestDirection).normalized;
            this.crossProductDirection = Vector3.Cross(this.projectedPlaneDirection, this.waistToChestDirection).normalized;
            this.waistJointVector.x = this.waistJointPosition.x;
            this.waistJointVector.y = this.waistJointPosition.y;
            this.waistJointVector.z = this.waistJointPosition.z;
            this.waistJointVector.w = 1f;
            this.transformationMatrix = new Matrix4x4(this.crossProductDirection, this.projectedPlaneDirection, this.waistToChestDirection, this.waistJointVector);
            this.inverseTransformationMatrix = Matrix4x4.Inverse(this.transformationMatrix);
            this.initialWaistPosition = this.inverseTransformationMatrix.MultiplyPoint3x4(this.WaistBoneTranform.position);
            this.initialWaistRotation = Quaternion.Inverse(Quaternion.LookRotation(this.waistToChestDirection, this.projectedPlaneDirection)) * this.WaistBoneTranform.rotation;
        }

        public override void UpdateTrans(bool GEFIPEMHHMF)
        {
            base.UpdateTrans(GEFIPEMHHMF);
            this.waistJointPosition = this.HipBoneTransform.localToWorldMatrix.MultiplyPoint3x4(this.hipToWaistOffset);
            this.chestJointPosition = base.transform.localToWorldMatrix.MultiplyPoint3x4(this.chestOffset);
            this.waistToChestDirection = (this.waistJointPosition - this.chestJointPosition).normalized;
            this.projectedPlaneDirection = Vector3.ProjectOnPlane(this.HipBoneTransform.forward + base.transform.forward, this.waistToChestDirection).normalized;
            this.crossProductDirection = Vector3.Cross(this.projectedPlaneDirection, this.waistToChestDirection).normalized;
            this.waistJointVector.x = this.waistJointPosition.x;
            this.waistJointVector.y = this.waistJointPosition.y;
            this.waistJointVector.z = this.waistJointPosition.z;
            this.waistJointVector.w = 1f;
            this.transformationMatrix = new Matrix4x4(this.crossProductDirection, this.projectedPlaneDirection, this.waistToChestDirection, this.waistJointVector);
            this.WaistBoneTranform.position = this.transformationMatrix.MultiplyPoint3x4(this.initialWaistPosition);
            this.WaistBoneTranform.rotation = Quaternion.LookRotation(this.waistToChestDirection, this.projectedPlaneDirection) * this.initialWaistRotation;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.waistJointPosition, 0.06f);
            Gizmos.DrawWireSphere(this.chestJointPosition, 0.06f);
            Gizmos.color = Color.red;
            Gizmos.DrawRay(this.waistJointPosition, this.crossProductDirection * 0.5f);
            Gizmos.color = Color.green;
            Gizmos.DrawRay(this.waistJointPosition, this.projectedPlaneDirection * 0.5f);
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(this.waistJointPosition, this.waistToChestDirection * 0.5f);
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(this.waistJointPosition, this.chestJointPosition);
        }
    }
}