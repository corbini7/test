using System.Collections;
using UnityEngine;
namespace Deobfuscated
{
    internal class Punch : MonoBehaviour
    {
        private PhysicCharacterController KPLKMDDKCML
        {
            get
            {
                if (this.FKDODJMPGMI == null)
                {
                    this.FKDODJMPGMI = base.GetComponent<PhysicCharacterController>();
                }
                return this.FKDODJMPGMI;
            }
        }




        public void Punching()
        {
            CFOGGNCCHCO.GDBFNBFNMMB(this.KPOIJIACCAC, this.IMMDAMLBNBD, this.IMMDAMLBNBD, this.JOPEEPBBFKH);
            CFOGGNCCHCO.GDBFNBFNMMB(this.HJNNBOHCPEK, this.GFJGKOPPJEJ, this.GFJGKOPPJEJ, this.DDCKJHPHFOP);
        }






        protected virtual void NKGOAHKJPKC()
        {
            this.KPOIJIACCAC = this.UpperArm.GetComponent<ConfigurableJoint>();
            this.HJNNBOHCPEK = this.ForeArm.GetComponent<ConfigurableJoint>();
            this.KFLGEJIDPMG = this.Fist.GetComponent<Rigidbody>();
        }




        private PunchBoost GOGJKKBKDIE
        {
            get
            {
                if (this.MMDFPADDAGL == null)
                {
                    this.MMDFPADDAGL = this.Fist.GetComponent<PunchBoost>();
                }
                return this.MMDFPADDAGL;
            }
        }



        protected virtual void CIFMIILDPPL()
        {
            this.KPOIJIACCAC = this.UpperArm.GetComponent<ConfigurableJoint>();
            this.HJNNBOHCPEK = this.ForeArm.GetComponent<ConfigurableJoint>();
            this.KFLGEJIDPMG = this.Fist.GetComponent<Rigidbody>();
        }







        private Rigidbody PDLLKEJMBGC
        {
            get
            {
                if (this.PNGFPCPBAKB == null)
                {
                    this.PNGFPCPBAKB = this.GreenHip.GetComponent<Rigidbody>();
                }
                return this.PNGFPCPBAKB;
            }
        }





        public void PunchReady()
        {
            CFOGGNCCHCO.GDBFNBFNMMB(this.KPOIJIACCAC, this.GDBJHAMEJKA, this.GDBJHAMEJKA, this.KMIOKAANMEA);
            CFOGGNCCHCO.GDBFNBFNMMB(this.HJNNBOHCPEK, this.HHPEOMJMDAP, this.HHPEOMJMDAP, this.POKCBELEMBL);
        }

        public IEnumerator RunPunch(PhysicCharacterController.CNOEKKHHKDN LPKOGPMFAFG)
        {
            if (LPKOGPMFAFG == PhysicCharacterController.CNOEKKHHKDN.LeftPunch)
            {
                this.KPLKMDDKCML.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.Punching;
            }
            else
            {
                this.KPLKMDDKCML.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.Punching;
            }
            this.OPECPLDFAJK = Random.onUnitSphere * 0f;
            while (this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    this.PunchReady();
                }
                yield return this.MJOFAKABBGM;
            }
            this.GOGJKKBKDIE.ShouldBoostPunch = true;
            if (LPKOGPMFAFG == PhysicCharacterController.CNOEKKHHKDN.LeftPunch)
            {
                this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.LeftPunch, this.KFLGEJIDPMG);
            }
            else
            {
                this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.RightPunch, this.KFLGEJIDPMG);
            }
            this.PINMLABKHDN = (-this.PDLLKEJMBGC.transform.up + this.GreenHip.transform.localToWorldMatrix.MultiplyVector(this.OPECPLDFAJK)).normalized;

            while (this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    this.KFLGEJIDPMG.AddForce(this.DJDKEEHENBJ * Mathf.Pow(this.GKMPCLBBIMJ, 2f) * this.PINMLABKHDN, ForceMode.Force);
                    this.PDLLKEJMBGC.AddForce(-this.DJDKEEHENBJ * Mathf.Pow(this.GKMPCLBBIMJ, 2f) * this.PINMLABKHDN, ForceMode.Force);
                    this.Punching();
                }
                yield return this.MJOFAKABBGM;
            }
            if (LPKOGPMFAFG == PhysicCharacterController.CNOEKKHHKDN.LeftPunch)
            {
                this.KPLKMDDKCML.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
                this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.LeftPunch, this.KFLGEJIDPMG);
            }
            else
            {
                this.KPLKMDDKCML.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
                this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.RightPunch, this.KFLGEJIDPMG);
            }
            this.GOGJKKBKDIE.ShouldBoostPunch = false;
            yield break;
        }








        protected virtual void Start()
        {
            this.KPOIJIACCAC = this.UpperArm.GetComponent<ConfigurableJoint>();
            this.HJNNBOHCPEK = this.ForeArm.GetComponent<ConfigurableJoint>();
            this.KFLGEJIDPMG = this.Fist.GetComponent<Rigidbody>();
        }


        public GameObject UpperArm;

        protected Quaternion KMIOKAANMEA;

        private JointDrive GDBJHAMEJKA = new JointDrive
        {
            positionSpring = 400f,
            positionDamper = 2f,
            maximumForce = float.MaxValue
        };

        private Quaternion JOPEEPBBFKH = Quaternion.identity;

        private JointDrive IMMDAMLBNBD = new JointDrive
        {
            positionSpring = 0f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private ConfigurableJoint KPOIJIACCAC;

        public GameObject ForeArm;

        private Quaternion POKCBELEMBL = Quaternion.Euler(120f, 0f, 0f);

        private JointDrive HHPEOMJMDAP = new JointDrive
        {
            positionSpring = 20f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private Quaternion DDCKJHPHFOP = Quaternion.identity;

        private JointDrive GFJGKOPPJEJ = new JointDrive
        {
            positionSpring = 0f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        public GameObject Fist;

        public GameObject GreenHip;

        private ConfigurableJoint HJNNBOHCPEK;

        private Rigidbody KFLGEJIDPMG;

        private WaitForFixedUpdate MJOFAKABBGM = new WaitForFixedUpdate();

        private Vector3 PINMLABKHDN;

        private Vector3 OPECPLDFAJK;


        private PhysicCharacterController FKDODJMPGMI;

        private Rigidbody PNGFPCPBAKB;

        private PunchBoost MMDFPADDAGL;

        private float DJDKEEHENBJ = 1400f;

        private float GKMPCLBBIMJ = 0.15f;

    }
}