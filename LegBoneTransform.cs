using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    internal class LegBoneTransform : BonesTransforms
    {
        public GameObject Leg1Rigidbody;

        public Transform Leg1BoneTransform;

        private Vector3 initialLegPosition;

        private Quaternion initialLegRotation;

        public Transform HipBoneTransform;

        private GameObject followedGameObject;

        private Vector3 hipBoneOffset;

        private Vector3 legOffset;

        private Matrix4x4 inverseBaseMatrix;

        private Matrix4x4 baseMatrix;

        private Vector3 hipJointPosition;

        private Vector4 hipJointVector;

        private Vector3 legJointPosition;

        private Vector3 planeNormalVector;

        private Vector3 crossProductVector;

        private Vector3 legDirectionVector;


        protected override void Awake()
        {
            base.Awake();
            this.followedGameObject = this.PartToFollow;
            Vector3 anchor = this.Leg1Rigidbody.GetComponent<ConfigurableJoint>().anchor;
            Vector3 anchor2 = this.followedGameObject.GetComponent<ConfigurableJoint>().anchor;
            this.hipJointPosition = this.Leg1Rigidbody.transform.localToWorldMatrix.MultiplyPoint3x4(anchor);
            this.hipBoneOffset = this.HipBoneTransform.transform.worldToLocalMatrix.MultiplyPoint3x4(this.hipJointPosition);
            this.legJointPosition = this.followedGameObject.transform.localToWorldMatrix.MultiplyPoint3x4(anchor2);
            this.legOffset = base.transform.worldToLocalMatrix.MultiplyPoint3x4(this.legJointPosition);
            this.legDirectionVector = (this.legJointPosition - this.hipJointPosition).normalized;
            this.planeNormalVector = Vector3.ProjectOnPlane(-base.transform.up, this.legDirectionVector).normalized;
            this.crossProductVector = Vector3.Cross(this.legDirectionVector, this.planeNormalVector).normalized;
            this.hipJointVector.x = this.hipJointPosition.x;
            this.hipJointVector.y = this.hipJointPosition.y;
            this.hipJointVector.z = this.hipJointPosition.z;
            this.hipJointVector.w = 1f;
            this.baseMatrix = new Matrix4x4(this.planeNormalVector, this.crossProductVector, this.legDirectionVector, this.hipJointVector);
            this.inverseBaseMatrix = Matrix4x4.Inverse(this.baseMatrix);
            this.initialLegPosition = this.inverseBaseMatrix.MultiplyPoint3x4(this.Leg1BoneTransform.position);
            this.initialLegRotation = Quaternion.Inverse(Quaternion.LookRotation(this.legDirectionVector, this.crossProductVector)) * this.Leg1BoneTransform.rotation;
        }

        public override void UpdateTrans(bool GEFIPEMHHMF)
        {
            if (GEFIPEMHHMF)
            {
                base.transform.position = this.PartToFollow.transform.localToWorldMatrix.MultiplyPoint3x4(this.relativePositionOffset);
                base.transform.rotation = this.PartToFollow.transform.rotation * this.relativeRotationOffset;
            }
            this.hipJointPosition = this.HipBoneTransform.localToWorldMatrix.MultiplyPoint3x4(this.hipBoneOffset);
            this.legJointPosition = base.transform.localToWorldMatrix.MultiplyPoint3x4(this.legOffset);
            this.legDirectionVector = (this.legJointPosition - this.hipJointPosition).normalized;
            this.planeNormalVector = Vector3.ProjectOnPlane(-base.transform.up, this.legDirectionVector).normalized;
            this.crossProductVector = Vector3.Cross(this.legDirectionVector, this.planeNormalVector).normalized;
            this.hipJointVector.x = this.hipJointPosition.x;
            this.hipJointVector.y = this.hipJointPosition.y;
            this.hipJointVector.z = this.hipJointPosition.z;
            this.hipJointVector.w = 1f;
            this.baseMatrix = new Matrix4x4(this.planeNormalVector, this.crossProductVector, this.legDirectionVector, this.hipJointVector);
            this.Leg1BoneTransform.position = this.baseMatrix.MultiplyPoint3x4(this.initialLegPosition);
            this.Leg1BoneTransform.rotation = Quaternion.LookRotation(this.legDirectionVector, this.crossProductVector) * this.initialLegRotation;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.hipJointPosition, 0.06f);
            Gizmos.DrawWireSphere(this.legJointPosition, 0.06f);
            Gizmos.color = Color.red;
            Gizmos.DrawRay(this.hipJointPosition, this.planeNormalVector * 0.5f);
            Gizmos.color = Color.green;
            Gizmos.DrawRay(this.hipJointPosition, this.crossProductVector * 0.5f);
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(this.hipJointPosition, this.legDirectionVector * 0.5f);
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(this.hipJointPosition, this.legJointPosition);
        }
    }
}