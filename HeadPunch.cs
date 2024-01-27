using System;
using System.Collections;
using UnityEngine;
namespace Deobfuscated
{
    internal class HeadPunch : MonoBehaviour
    {

        public IEnumerator FlyingHeadPunchProcess()
        {
            this.LBAILHKBMLF = true;
            this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.Headbutt, this.LOPOHMCKMKL);
            this.JIOCKJDCPMM.CanHeadPunchBoost = true;
            float num = 0.015f;
            while (num >= 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    this.JMIDJLNPEFG();
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            num = 0.42f;
            while (num >= 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.JIOCKJDCPMM.CanHeadPunchBoost = false;
            num = 0.03f;
            while (num >= 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.LBAILHKBMLF = false;
            this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.Headbutt, this.LOPOHMCKMKL);
            yield break;
        }


        private void DIABCAACKHC(float FJGNCLNJGHK, float OLFNJPJKOEF)
        {
            float t = FJGNCLNJGHK / OLFNJPJKOEF;
            this.AJBEMNONLMC.targetRotation = Quaternion.Slerp(this.EJNBLKGNLLD.NormalRotation, this.JAKGGMDJPAO.normalized, t);
            this.NLEHLJPKLCH.targetRotation = this.JKLPJAIHEKA;
            this.FIIKBADHOJH.AddRelativeForce(Vector3.up * 36f, ForceMode.Acceleration);
            this.PNGENFLDJAG.AddRelativeForce(Vector3.down * 20f, ForceMode.Acceleration);
        }

        private void Start()
        {
            this.KPLKMDDKCML = base.GetComponent<PhysicCharacterController>();
            this.NADPFBICIKC = this.KPLKMDDKCML.GreenHead;
            this.NPFAMIKCKBO = this.KPLKMDDKCML.GreenChest;
            this.IIDKFHMPMHI = this.KPLKMDDKCML.GreenHip;
            this.AJBEMNONLMC = this.NADPFBICIKC.GetComponent<ConfigurableJoint>();
            this.NLEHLJPKLCH = this.NPFAMIKCKBO.GetComponent<ConfigurableJoint>();
            this.EJNBLKGNLLD = this.NADPFBICIKC.GetComponent<JointStateManager2>();
            this.MOJONFOIABN = this.NPFAMIKCKBO.GetComponent<JointStateManager2>();
            this.LOPOHMCKMKL = this.NADPFBICIKC.GetComponent<Rigidbody>();
            this.FIIKBADHOJH = this.NPFAMIKCKBO.GetComponent<Rigidbody>();
            this.PNGENFLDJAG = this.IIDKFHMPMHI.GetComponent<Rigidbody>();
            this.JIOCKJDCPMM = this.NADPFBICIKC.GetComponent<HeadPunchBoost>();
            this.MDJPEGFLNKG = this.NADPFBICIKC.transform;
            this.EIJAPLDDFEM = this.IIDKFHMPMHI.transform;
            this.ALLICKLAKDB = this.KPLKMDDKCML.GreenUpperArmL.GetComponent<ConfigurableJoint>();
            this.NHNILCHENEH = this.KPLKMDDKCML.GreenUpperArmR.GetComponent<ConfigurableJoint>();
            this.ALEGOOOGBOJ = this.KPLKMDDKCML.GreenForeArmL.GetComponent<ConfigurableJoint>();
            this.POCAHMPKOOK = this.KPLKMDDKCML.GreenForeArmR.GetComponent<ConfigurableJoint>();
            this.LNDDLJMNLBD = this.KPLKMDDKCML.GreenFistL.GetComponent<Rigidbody>();
            this.PIMHHNKOCBE = this.KPLKMDDKCML.GreenFistR.GetComponent<Rigidbody>();
        }




        public IEnumerator GrabbingHeadPunchProcess()
        {
            this.KPLKMDDKCML.ACIJFJIKKNL = true;
            this.LBAILHKBMLF = true;
            //positionSpring = this.ALLICKLAKDB.angularXDrive.positionSpring;
            //positionSpring2 = this.NHNILCHENEH.angularXDrive.positionSpring;
            //positionSpring3 = this.ALEGOOOGBOJ.angularXDrive.positionSpring;
            //positionSpring4 = this.POCAHMPKOOK.angularXDrive.positionSpring;
            //olfnjpjkoef = 0.31f;
            //num = 0.31f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //this.DIABCAACKHC(num, olfnjpjkoef);
                    //num -= Time.fixedDeltaTime;
                    Matrix4x4 worldToLocalMatrix = this.EIJAPLDDFEM.worldToLocalMatrix;
                    Vector3 vector = worldToLocalMatrix.MultiplyPoint(this.LNDDLJMNLBD.position);
                    Vector3 vector2 = worldToLocalMatrix.MultiplyPoint(this.PIMHHNKOCBE.position);
                    if (this.KPLKMDDKCML.NICPPDJPMAM && this.KPLKMDDKCML.NHNKGGEGGEJ && vector.y < 0f && vector2.y < 0f)
                    {
                        this.KPLKMDDKCML.BFCMBNKBFAF = true;
                        //this.HMJCLIMABDC(num, olfnjpjkoef, positionSpring, positionSpring2, positionSpring3, positionSpring4, 800f, 600f);
                    }
                    else
                    {
                        this.KPLKMDDKCML.BFCMBNKBFAF = false;
                    }
                }
                yield return this.LGJIFPAHACH;
            }
            this.KPLKMDDKCML.BFCMBNKBFAF = false;
            this.JIOCKJDCPMM.CanHeadPunchBoost = true;
            this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.Headbutt, this.LOPOHMCKMKL);
            //num = 0.03f;
            while (/*num > 0f && */this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                    this.CMOACHACICF();
                    Matrix4x4 worldToLocalMatrix2 = this.EIJAPLDDFEM.worldToLocalMatrix;
                    Vector3 vector3 = worldToLocalMatrix2.MultiplyPoint(this.LNDDLJMNLBD.position);
                    Vector3 vector4 = worldToLocalMatrix2.MultiplyPoint(this.PIMHHNKOCBE.position);
                    if (this.KPLKMDDKCML.NICPPDJPMAM && this.KPLKMDDKCML.NHNKGGEGGEJ && vector3.y < 0f && vector4.y < 0f)
                    {
                        this.KPLKMDDKCML.BFCMBNKBFAF = true;
                        this.HIBAANJBPNA();
                    }
                    else
                    {
                        this.KPLKMDDKCML.BFCMBNKBFAF = false;
                    }
                }
                yield return this.LGJIFPAHACH;
            }
            this.KPLKMDDKCML.BFCMBNKBFAF = false;
            //num = 0.4f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    // num -= Time.fixedDeltaTime;
                    Matrix4x4 worldToLocalMatrix3 = this.EIJAPLDDFEM.worldToLocalMatrix;
                    Vector3 vector5 = worldToLocalMatrix3.MultiplyPoint(this.LNDDLJMNLBD.position);
                    Vector3 vector6 = worldToLocalMatrix3.MultiplyPoint(this.PIMHHNKOCBE.position);
                    if (this.KPLKMDDKCML.NICPPDJPMAM && this.KPLKMDDKCML.NHNKGGEGGEJ && vector5.y < 0f && vector6.y < 0f)
                    {
                        this.KPLKMDDKCML.BFCMBNKBFAF = true;
                        this.HIBAANJBPNA();
                    }
                    else
                    {
                        this.KPLKMDDKCML.BFCMBNKBFAF = false;
                    }
                }
                yield return this.LGJIFPAHACH;
            }
            this.KPLKMDDKCML.BFCMBNKBFAF = false;
            this.JIOCKJDCPMM.CanHeadPunchBoost = false;
            //num = 0.03f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.LBAILHKBMLF = false;
            this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.Headbutt, this.LOPOHMCKMKL);
            this.KPLKMDDKCML.ACIJFJIKKNL = false;
            yield break;
        }


        public IEnumerator NormalHeadPunchProcess()
        {
            this.LBAILHKBMLF = true;
            //olfnjpjkoef = 0.14f;
            //num = 0.14f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //this.DIABCAACKHC(num, olfnjpjkoef);
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.JIOCKJDCPMM.CanHeadPunchBoost = true;
            this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.Headbutt, this.LOPOHMCKMKL);
            //num = 0.02f;
            while (/*num > 0f && */this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                    this.CMOACHACICF();
                }
                yield return this.LGJIFPAHACH;
            }
            //num = 0.4f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.JIOCKJDCPMM.CanHeadPunchBoost = false;
            // num = 0.03f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.LBAILHKBMLF = false;
            this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.Headbutt, this.LOPOHMCKMKL);
            yield break;
        }




        private void HIBAANJBPNA()
        {
            this.BNONMJFMMHM.positionSpring = 800f;
            this.ALLICKLAKDB.angularXDrive = this.BNONMJFMMHM;
            this.ALLICKLAKDB.angularYZDrive = this.BNONMJFMMHM;
            this.ALLICKLAKDB.targetRotation = this.IEPKOMMBJDI;
            this.ALLLMBOCLJA.positionSpring = 800f;
            this.NHNILCHENEH.angularXDrive = this.ALLLMBOCLJA;
            this.NHNILCHENEH.angularYZDrive = this.ALLLMBOCLJA;
            this.NHNILCHENEH.targetRotation = this.PBBOINKJHCA;
            this.KCBCNNJFAEC.positionSpring = 600f;
            this.ALEGOOOGBOJ.angularXDrive = this.KCBCNNJFAEC;
            this.ALEGOOOGBOJ.angularYZDrive = this.KCBCNNJFAEC;
            this.ALEGOOOGBOJ.targetRotation = this.OKJFKIPEENK;
            this.IMOAIGJODBB.positionSpring = 600f;
            this.POCAHMPKOOK.angularXDrive = this.IMOAIGJODBB;
            this.POCAHMPKOOK.angularYZDrive = this.IMOAIGJODBB;
            this.POCAHMPKOOK.targetRotation = this.PHAHHDLMMFN;
        }


        private void CMOACHACICF()
        {
            this.AJBEMNONLMC.targetRotation = this.EJNBLKGNLLD.NormalRotation;
            this.NLEHLJPKLCH.targetRotation = this.MOJONFOIABN.NormalRotation;
            Vector3 up = this.MDJPEGFLNKG.up;
            CFOGGNCCHCO.EFNEGHJPJFN(this.LOPOHMCKMKL, -up * 49f, ForceMode.Impulse);
            CFOGGNCCHCO.EFNEGHJPJFN(this.PNGENFLDJAG, up * 34f, ForceMode.Impulse);
        }


        private void JMIDJLNPEFG()
        {
            this.AJBEMNONLMC.targetRotation = this.EJNBLKGNLLD.NormalRotation;
            this.NLEHLJPKLCH.targetRotation = this.MOJONFOIABN.NormalRotation;
            this.AJBEMNONLMC.angularXDrive = this.EJNBLKGNLLD.NormalJointDrive;
            this.NLEHLJPKLCH.angularXDrive = this.MOJONFOIABN.NormalJointDrive;
            this.AJBEMNONLMC.angularYZDrive = this.EJNBLKGNLLD.NormalJointDrive;
            this.NLEHLJPKLCH.angularYZDrive = this.MOJONFOIABN.NormalJointDrive;
            Vector3 up = this.MDJPEGFLNKG.up;
            CFOGGNCCHCO.EFNEGHJPJFN(this.LOPOHMCKMKL, -up * 60f, ForceMode.Impulse);
            CFOGGNCCHCO.EFNEGHJPJFN(this.FIIKBADHOJH, -up * 20f, ForceMode.Impulse);
            CFOGGNCCHCO.EFNEGHJPJFN(this.PNGENFLDJAG, up * 40.8f, ForceMode.Impulse);
        }



        private GameObject NADPFBICIKC;

        private GameObject NPFAMIKCKBO;

        private GameObject IIDKFHMPMHI;

        private Quaternion JAKGGMDJPAO = Quaternion.Euler(30f, 0f, 0f);

        private Quaternion JKLPJAIHEKA = Quaternion.Euler(30f, 0f, 0f);





        private Quaternion IEPKOMMBJDI = Quaternion.Euler(21f, -80f, -25f);

        private Quaternion PBBOINKJHCA = Quaternion.Euler(21f, 80f, 25f);

        private Quaternion OKJFKIPEENK = Quaternion.Euler(120f, 0f, 0f);

        private Quaternion PHAHHDLMMFN = Quaternion.Euler(120f, 0f, 0f);

        private Transform MDJPEGFLNKG;

        private Transform EIJAPLDDFEM;

        private WaitForFixedUpdate LGJIFPAHACH = new WaitForFixedUpdate();

        private PhysicCharacterController KPLKMDDKCML;

        private HeadPunchBoost JIOCKJDCPMM;

        private ConfigurableJoint AJBEMNONLMC;

        private ConfigurableJoint NLEHLJPKLCH;

        private JointStateManager2 EJNBLKGNLLD;

        private JointStateManager2 MOJONFOIABN;

        private Rigidbody LOPOHMCKMKL;

        private Rigidbody FIIKBADHOJH;

        private Rigidbody PNGENFLDJAG;

        private Rigidbody LNDDLJMNLBD;

        private Rigidbody PIMHHNKOCBE;

        private ConfigurableJoint ALLICKLAKDB;

        private ConfigurableJoint NHNILCHENEH;

        private ConfigurableJoint ALEGOOOGBOJ;

        private ConfigurableJoint POCAHMPKOOK;

        internal bool LBAILHKBMLF;

        private JointDrive BNONMJFMMHM = new JointDrive
        {
            positionSpring = 800f,
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive ALLLMBOCLJA = new JointDrive
        {
            positionSpring = 800f,
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive KCBCNNJFAEC = new JointDrive
        {
            positionSpring = 600f,
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive IMOAIGJODBB = new JointDrive
        {
            positionSpring = 600f,
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };
    }
}