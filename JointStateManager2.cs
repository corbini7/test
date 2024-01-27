using System;
using UnityEngine;
namespace Deobfuscated
{
    internal class JointStateManager2 : MonoBehaviour
    {

        private void Awake()
        {
            this.NormalJointDrive.positionSpring = this.NormalSpring;
            this.NormalJointDrive.positionDamper = this.NormalDamper;
            this.NormalJointDrive.maximumForce = float.PositiveInfinity;
            this.WalkJointDrive.positionSpring = this.WalkSpring;
            this.WalkJointDrive.positionDamper = this.WalkDamper;
            this.WalkJointDrive.maximumForce = float.PositiveInfinity;
            this.RunJointDrive.positionSpring = this.RunSpring;
            this.RunJointDrive.positionDamper = this.RunDamper;
            this.RunJointDrive.maximumForce = float.PositiveInfinity;
            this.JumpJointDrive.positionSpring = this.JumpSpring;
            this.JumpJointDrive.positionDamper = this.JumpDamper;
            this.JumpJointDrive.maximumForce = float.PositiveInfinity;
            this.GrabbedJointDrive.positionSpring = this.GrabbedSpring;
            this.GrabbedJointDrive.positionDamper = this.GrabbedDamper;
            this.GrabbedJointDrive.maximumForce = float.PositiveInfinity;
            this.NormalRotation = this.NormalRotation.normalized;
            this.WalkRotation = this.WalkRotation.normalized;
            this.JumpRotation = this.JumpRotation.normalized;
            this.GrabbedRotation = this.GrabbedRotation.normalized;
        }


        public float NormalSpring;

        public float NormalDamper;

        public JointDrive NormalJointDrive;

        public Quaternion NormalRotation;

        public float WalkSpring;

        public float WalkDamper;

        public JointDrive WalkJointDrive;

        public Quaternion WalkRotation;

        public float RunSpring;

        public float RunDamper;

        public JointDrive RunJointDrive;

        public float JumpSpring;

        public float JumpDamper;

        public JointDrive JumpJointDrive;

        public Quaternion JumpRotation;

        public float GrabbedSpring;

        public float GrabbedDamper;

        public JointDrive GrabbedJointDrive;

        public Quaternion GrabbedRotation;
    }
}