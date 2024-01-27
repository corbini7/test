using UnityEngine;
namespace Deobfuscated
{
    internal class GrabObj : MonoBehaviour
    {



        public void Reaching(Vector3 NABKGGEKEKH)
        {
            if (!this.KMPBEHPMJAP.ThisHandIsGrabbingObj)
            {
                this.HEADNGIGGID.angularXDrive = this.BFOPNKHJKKA;
                this.HEADNGIGGID.angularYZDrive = this.BFOPNKHJKKA;
                this.HEADNGIGGID.targetRotation = Quaternion.identity;
                this.JAKAJALDLBF.angularXDrive = this.AIANEOIMDHF;
                this.JAKAJALDLBF.angularYZDrive = this.AIANEOIMDHF;
                this.JAKAJALDLBF.targetRotation = Quaternion.identity;
                this.MKCGNFAKHIO = NABKGGEKEKH - this.NAEABOAIPKD.worldCenterOfMass;
                CFOGGNCCHCO.IPIGMALBAKG(this.NAEABOAIPKD, this.MKCGNFAKHIO.normalized * Mathf.Clamp(this.MKCGNFAKHIO.magnitude * 1000f, 0f, 10f));
                this.KMPBEHPMJAP.isReaching = true;
            }
        }



        private GrabCollisionDetect KMPBEHPMJAP
        {
            get
            {
                if (this.JBKIIKOFNNC == null)
                {
                    this.JBKIIKOFNNC = this.Fist.GetComponent<GrabCollisionDetect>();
                }
                return this.JBKIIKOFNNC;
            }
        }





        private ConfigurableJoint HEADNGIGGID
        {
            get
            {
                if (this.PHICFCMMIOP == null)
                {
                    this.PHICFCMMIOP = this.UpperArm.GetComponent<ConfigurableJoint>();
                }
                return this.PHICFCMMIOP;
            }
        }




        public void Ungrab(PhysicCharacterController MCFOLNMFCPN, bool KBEMHDPMNLA)
        {
            this.KMPBEHPMJAP.ThisHandIsGrabbingObj = false;
            this.KMPBEHPMJAP.GrabbedObjectGO = null;
            this.StopReaching();
            if (KBEMHDPMNLA)
            {
                if (MCFOLNMFCPN.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.Grabbing)
                {
                    MCFOLNMFCPN.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
                    return;
                }
            }
            else if (MCFOLNMFCPN.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.Grabbing)
            {
                MCFOLNMFCPN.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
            }
        }



        protected virtual void FixedUpdate()
        {
            if (PhysicsDummyModeManager.IsPaused)
            {
                return;
            }
            if (this.KMPBEHPMJAP.GrabbedObjectGO == null && !this.PIIMKCNGMIB && !this.KMPBEHPMJAP.GrabbingStaticObject)
            {
                this.KMPBEHPMJAP.UngrabObjDetail();
            }
            this.PIIMKCNGMIB = (this.KMPBEHPMJAP.GrabbedObjectGO == null);
        }










        private Rigidbody NAEABOAIPKD
        {
            get
            {
                if (this.IJDLJEHNDOH == null)
                {
                    this.IJDLJEHNDOH = this.Fist.GetComponent<Rigidbody>();
                }
                return this.IJDLJEHNDOH;
            }
        }



        private ConfigurableJoint JAKAJALDLBF
        {
            get
            {
                if (this.JBCFIKAPELK == null)
                {
                    this.JBCFIKAPELK = this.ForeArm.GetComponent<ConfigurableJoint>();
                }
                return this.JBCFIKAPELK;
            }
        }










        public void StopReaching()
        {
            this.KMPBEHPMJAP.isReaching = false;
        }



        protected virtual void Start()
        {
            this.BFOPNKHJKKA.positionSpring = this.EGHDLKJIFCJ;
            this.BFOPNKHJKKA.positionDamper = this.NAFPFAGFOOE;
            this.BFOPNKHJKKA.maximumForce = float.PositiveInfinity;
            this.AIANEOIMDHF.positionSpring = this.PGILLOCGEBN;
            this.AIANEOIMDHF.positionDamper = this.EDIEAABBJFP;
            this.AIANEOIMDHF.maximumForce = float.PositiveInfinity;
        }








        public GameObject UpperArm;

        private JointDrive BFOPNKHJKKA;

        private float EGHDLKJIFCJ;

        private float NAFPFAGFOOE = 1f;

        private ConfigurableJoint PHICFCMMIOP;

        public GameObject ForeArm;

        private JointDrive AIANEOIMDHF;

        private float PGILLOCGEBN;

        private float EDIEAABBJFP = 1f;

        public GameObject Fist;

        public GameObject GreenHip;

        private Vector3 MKCGNFAKHIO;

        private ConfigurableJoint JBCFIKAPELK;

        private Rigidbody IJDLJEHNDOH;

        private GrabCollisionDetect JBKIIKOFNNC;

        private bool PIIMKCNGMIB;
    }
}