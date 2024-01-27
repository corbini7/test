using System;
using System.Collections;
using UnityEngine;
namespace Deobfuscated
{
    internal class JOCBIJDFNNC
    {
        private void BGDKHJNNFNC()
        {
            this.HLMAFBJHHMK = (Vector3.Dot(this.LOPOHMCKMKL.angularVelocity, -this.EAEJDHJFBCB) + Vector3.Dot(this.FIIKBADHOJH.angularVelocity, -this.EAEJDHJFBCB) + Vector3.Dot(this.IHEELAEEPHA.angularVelocity, -this.EAEJDHJFBCB) + Vector3.Dot(this.PNGENFLDJAG.angularVelocity, -this.EAEJDHJFBCB) + Vector3.Dot(this.BBKJLDINBOD.angularVelocity, -this.EAEJDHJFBCB) + Vector3.Dot(this.CCLJLDLECLG.angularVelocity, -this.EAEJDHJFBCB) + Vector3.Dot(this.CBHMDFLJEFC.angularVelocity, -this.EAEJDHJFBCB) + Vector3.Dot(this.AIHMBIHLPHK.angularVelocity, -this.EAEJDHJFBCB)) / 8f;
        }




        private void BBHGOBKPAID(JOCBIJDFNNC.EAHMCFHBMNP OOOOOOBFEAO)
        {
            OOOOOOBFEAO.BodyPartJoint.angularXDrive = OOOOOOBFEAO.BodyPartXJointDrive;
            OOOOOOBFEAO.BodyPartJoint.angularYZDrive = OOOOOOBFEAO.BodyPartYZJointDrive;
            OOOOOOBFEAO.BodyPartJoint.targetRotation = OOOOOOBFEAO.BodyPartJointRollingRotation;
        }



        public void CharacterRoll()
        {
            this.IsRolling = true;
            if (Vector3.Angle(this.PNGENFLDJAG.transform.forward, Vector3.up) < 30f)
            {
                this.KPLKMDDKCML.StartCoroutine(this.BFFKCPPCDMD());
                return;
            }
            this.KPLKMDDKCML.StartCoroutine(this.FCEJFLMAKKF());
        }




        private void HCGGGEOLADN(out bool BNPKFKHAPMG, out RaycastHit AMNHJKFJIOL, out float CHFKFIGAGGB)
        {
            if (!Physics.SphereCast(this.PNGENFLDJAG.transform.position, 0.02f, Vector3.down, out AMNHJKFJIOL, 1.4f, this.FEPNDJPCAJB))
            {
                BNPKFKHAPMG = false;
                CHFKFIGAGGB = 0.6f;
                return;
            }
            BNPKFKHAPMG = true;
            this.MCBBMCALPHC = this.MMJMBGACACC.collider.sharedMaterial;
            if (this.MCBBMCALPHC != null)
            {
                CHFKFIGAGGB = this.MCBBMCALPHC.dynamicFriction;
                return;
            }
            CHFKFIGAGGB = 0.6f;
        }





        private Vector3 NHLECGHADAJ
        {
            get
            {
                this.MNKOJLLBLDD = (this.LOPOHMCKMKL.mass * this.LOPOHMCKMKL.worldCenterOfMass + this.FIIKBADHOJH.mass * this.FIIKBADHOJH.worldCenterOfMass + this.IHEELAEEPHA.mass * this.IHEELAEEPHA.worldCenterOfMass + this.PNGENFLDJAG.mass * this.PNGENFLDJAG.worldCenterOfMass + this.BBKJLDINBOD.mass * this.BBKJLDINBOD.worldCenterOfMass + this.CCLJLDLECLG.mass * this.CCLJLDLECLG.worldCenterOfMass + this.CBHMDFLJEFC.mass * this.CBHMDFLJEFC.worldCenterOfMass + this.AIHMBIHLPHK.mass * this.AIHMBIHLPHK.worldCenterOfMass) / (this.LOPOHMCKMKL.mass + this.FIIKBADHOJH.mass + this.IHEELAEEPHA.mass + this.PNGENFLDJAG.mass + this.BBKJLDINBOD.mass + this.CCLJLDLECLG.mass + this.CBHMDFLJEFC.mass + this.AIHMBIHLPHK.mass);
                return this.MNKOJLLBLDD;
            }
        }

        private IEnumerator BFFKCPPCDMD()
        {
            if (this.PNGENFLDJAG.constraints == RigidbodyConstraints.None)
            {
                this.DIIEFNKHKIG = false;
            }
            else
            {
                this.DIIEFNKHKIG = true;
            }
            this.PNGENFLDJAG.constraints = RigidbodyConstraints.None;
            this.KPLKMDDKCML.characterStates.KOFBMHLDMPF(0.2f);
            this.KHEPKIPMKKF.NBFMOKBNBGP = false;
            this.BBHGOBKPAID(this.GFJMEJNINGF);
            this.BBHGOBKPAID(this.MKMEKJDJNBC);
            this.BBHGOBKPAID(this.EPKOAOHGCIM);
            this.BBHGOBKPAID(this.HPEFHPPHEMK);
            this.BBHGOBKPAID(this.GEBIKMNIIPE);
            this.BBHGOBKPAID(this.BFKKIOJOMNN);
            this.BBHGOBKPAID(this.LJDDAINPPOJ);
            this.BBHGOBKPAID(this.HCOGGJKNIBI);
            this.BBHGOBKPAID(this.LLBEMLHPFAN);
            this.BBHGOBKPAID(this.DJIDLLCPMNN);
            this.BBHGOBKPAID(this.CHCMAFBEAJC);
            float num = 0.06f;
            while (num > 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    this.ICHOMNELKGK = this.PMPMDCJNNFD;
                    if (Vector3.Dot(this.LOPOHMCKMKL.velocity, this.ICHOMNELKGK) <= 20f)
                    {
                        this.LOPOHMCKMKL.AddForce(this.ICHOMNELKGK * 650f, ForceMode.Acceleration);
                    }
                }
                yield return this.MJOFAKABBGM;
            }
            if (this.DIIEFNKHKIG)
            {
                this.PNGENFLDJAG.AddForce(Vector3.up * 2000f, ForceMode.Acceleration);
            }
            num = 0.16f;
            while (num > 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    this.ICHOMNELKGK = this.PMPMDCJNNFD;
                    this.LNKIOLDOEJC(this.ICHOMNELKGK);
                    this.HMEMDJNIGNM = this.NHLECGHADAJ;
                    this.HCGGGEOLADN(out this.HFGCKICBPHP, out this.MMJMBGACACC, out this.CHFKFIGAGGB);
                    this.OIJJFLDCHOL(this.HFGCKICBPHP, this.MMJMBGACACC);
                    this.PCDBCFNOJMK = Mathf.Clamp01(this.CHFKFIGAGGB / 0.6f);
                    if (this.CKHLGFPJCNK < 140f)
                    {
                        float aenlbjgfoip = 60f * this.PCDBCFNOJMK;
                        this.HONACAHIAEC(this.LOPOHMCKMKL, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.FIIKBADHOJH, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.IHEELAEEPHA, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.PNGENFLDJAG, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.BBKJLDINBOD, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.CCLJLDLECLG, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.CBHMDFLJEFC, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.AIHMBIHLPHK, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                    }
                }
                yield return this.MJOFAKABBGM;
            }
            num = 0.3f;
            while (num > 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    this.ICHOMNELKGK = this.PMPMDCJNNFD;
                    this.LNKIOLDOEJC(this.ICHOMNELKGK);
                    this.HMEMDJNIGNM = this.NHLECGHADAJ;
                    this.HODOEKDMJLN(this.LOPOHMCKMKL, 10f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.FIIKBADHOJH, 10f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.IHEELAEEPHA, 10f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.PNGENFLDJAG, 10f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.BBKJLDINBOD, 10f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.CCLJLDLECLG, 10f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.CBHMDFLJEFC, 10f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.AIHMBIHLPHK, 10f, this.HMEMDJNIGNM);
                }
                yield return this.MJOFAKABBGM;
            }
            this.IsRolling = false;
            this.KHEPKIPMKKF.NBFMOKBNBGP = true;
            yield break;
        }




        private void HODOEKDMJLN(Rigidbody OGPOHCEKFCE, float AENLBJGFOIP, Vector3 FEOPHBMKKOP)
        {
            OGPOHCEKFCE.AddForceAtPosition(Vector3.Cross(OGPOHCEKFCE.worldCenterOfMass - this.HMEMDJNIGNM, this.EAEJDHJFBCB).normalized * AENLBJGFOIP, OGPOHCEKFCE.worldCenterOfMass, ForceMode.Acceleration);
        }

        private void NCNECMOIPKP()
        {
            this.NOBEGHMOJFD = 1f;
            this.ICHOMNELKGK = this.PMPMDCJNNFD;
            float num = Vector3.Angle(-this.LOPOHMCKMKL.transform.up, Vector3.up);
            if (num < 80f)
            {
                float num2 = Vector3.Angle(this.ICHOMNELKGK, this.LOPOHMCKMKL.transform.position - this.PNGENFLDJAG.transform.position);
                if (num2 < 60f)
                {
                    this.NOBEGHMOJFD = 0.8f;
                }
                if (num2 > 120f)
                {
                    this.NOBEGHMOJFD = 1.15f;
                }
            }
            if (num > 100f)
            {
                float num3 = Vector3.Angle(this.ICHOMNELKGK, this.LOPOHMCKMKL.transform.position - this.PNGENFLDJAG.transform.position);
                if (num3 < 60f)
                {
                    this.NOBEGHMOJFD = 0.9f;
                }
                if (num3 > 120f)
                {
                    this.NOBEGHMOJFD = 1.1f;
                }
            }
        }


        private IEnumerator FCEJFLMAKKF()
        {
            this.PNGENFLDJAG.constraints = RigidbodyConstraints.None;
            this.KPLKMDDKCML.characterStates.KOFBMHLDMPF(0.2f);
            this.KHEPKIPMKKF.NBFMOKBNBGP = false;
            this.BBHGOBKPAID(this.GFJMEJNINGF);
            this.BBHGOBKPAID(this.MKMEKJDJNBC);
            this.BBHGOBKPAID(this.EPKOAOHGCIM);
            this.BBHGOBKPAID(this.HPEFHPPHEMK);
            this.BBHGOBKPAID(this.GEBIKMNIIPE);
            this.BBHGOBKPAID(this.BFKKIOJOMNN);
            this.BBHGOBKPAID(this.LJDDAINPPOJ);
            this.BBHGOBKPAID(this.HCOGGJKNIBI);
            this.BBHGOBKPAID(this.LLBEMLHPFAN);
            this.BBHGOBKPAID(this.DJIDLLCPMNN);
            this.BBHGOBKPAID(this.CHCMAFBEAJC);
            this.NCNECMOIPKP();
            float num = 0.16f * this.NOBEGHMOJFD;
            while (num > 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    this.ICHOMNELKGK = this.PMPMDCJNNFD;
                    this.LNKIOLDOEJC(this.ICHOMNELKGK);
                    this.HMEMDJNIGNM = this.NHLECGHADAJ;
                    this.BGDKHJNNFNC();
                    if (this.HLMAFBJHHMK < 10f)
                    {
                        this.HODOEKDMJLN(this.LOPOHMCKMKL, 50f, this.HMEMDJNIGNM);
                        this.HODOEKDMJLN(this.FIIKBADHOJH, 50f, this.HMEMDJNIGNM);
                        this.HODOEKDMJLN(this.IHEELAEEPHA, 50f, this.HMEMDJNIGNM);
                        this.HODOEKDMJLN(this.PNGENFLDJAG, 50f, this.HMEMDJNIGNM);
                        this.HODOEKDMJLN(this.BBKJLDINBOD, 50f, this.HMEMDJNIGNM);
                        this.HODOEKDMJLN(this.CCLJLDLECLG, 50f, this.HMEMDJNIGNM);
                        this.HODOEKDMJLN(this.CBHMDFLJEFC, 50f, this.HMEMDJNIGNM);
                        this.HODOEKDMJLN(this.AIHMBIHLPHK, 50f, this.HMEMDJNIGNM);
                    }
                    this.HCGGGEOLADN(out this.HFGCKICBPHP, out this.MMJMBGACACC, out this.CHFKFIGAGGB);
                    this.OIJJFLDCHOL(this.HFGCKICBPHP, this.MMJMBGACACC);
                    this.PCDBCFNOJMK = Mathf.Clamp01(this.CHFKFIGAGGB / 0.6f);
                    if (this.CKHLGFPJCNK < 140f)
                    {
                        float aenlbjgfoip = 150f * this.PCDBCFNOJMK;
                        this.HONACAHIAEC(this.LOPOHMCKMKL, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.FIIKBADHOJH, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.IHEELAEEPHA, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.PNGENFLDJAG, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.BBKJLDINBOD, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.CCLJLDLECLG, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.CBHMDFLJEFC, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                        this.HONACAHIAEC(this.AIHMBIHLPHK, aenlbjgfoip, this.HMEMDJNIGNM, this.ICHOMNELKGK);
                    }
                }
                yield return this.MJOFAKABBGM;
            }
            num = 0.3f;
            while (num > 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    this.ICHOMNELKGK = this.PMPMDCJNNFD;
                    this.LNKIOLDOEJC(this.ICHOMNELKGK);
                    this.HMEMDJNIGNM = this.NHLECGHADAJ;
                    this.HODOEKDMJLN(this.LOPOHMCKMKL, 20f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.FIIKBADHOJH, 20f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.IHEELAEEPHA, 20f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.PNGENFLDJAG, 20f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.BBKJLDINBOD, 20f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.CCLJLDLECLG, 20f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.CBHMDFLJEFC, 20f, this.HMEMDJNIGNM);
                    this.HODOEKDMJLN(this.AIHMBIHLPHK, 20f, this.HMEMDJNIGNM);
                }
                yield return this.MJOFAKABBGM;
            }
            this.IsRolling = false;
            this.KHEPKIPMKKF.NBFMOKBNBGP = true;
            yield break;
        }




        private Vector3 PMPMDCJNNFD
        {
            get
            {
                return new Vector3(this.KPLKMDDKCML.MoveX, 0f, this.KPLKMDDKCML.MoveY).normalized;
            }
        }


        public bool IsRolling
        {
            get
            {
                return this.FFFEODMGAOK;
            }
            private set
            {
                if (this.FFFEODMGAOK != value)
                {
                    this.FFFEODMGAOK = value;
                    this.KPLKMDDKCML.HDNBENIBAPH = value;
                }
            }
        }

        private void LNKIOLDOEJC(Vector3 IEMJACIAHJA)
        {
            this.EAEJDHJFBCB = Vector3.Cross(IEMJACIAHJA, Vector3.up);
        }


        private void HONACAHIAEC(Rigidbody OGPOHCEKFCE, float AENLBJGFOIP, Vector3 FEOPHBMKKOP, Vector3 MEHLJHIEPKB)
        {
            if (OGPOHCEKFCE.worldCenterOfMass.y > FEOPHBMKKOP.y)
            {
                OGPOHCEKFCE.AddForce(this.ICHOMNELKGK * AENLBJGFOIP, ForceMode.Acceleration);
            }
        }

        internal JOCBIJDFNNC(PhysicCharacterController MCFOLNMFCPN)
        {
            this.KPLKMDDKCML = MCFOLNMFCPN;
            this.PNGENFLDJAG = this.KPLKMDDKCML.GreenHip.GetComponent<Rigidbody>();
            this.LOPOHMCKMKL = this.KPLKMDDKCML.GreenHead.GetComponent<Rigidbody>();
            this.FIIKBADHOJH = this.KPLKMDDKCML.GreenChest.GetComponent<Rigidbody>();
            this.IHEELAEEPHA = this.KPLKMDDKCML.GreenWaist.GetComponent<Rigidbody>();
            this.BBKJLDINBOD = this.KPLKMDDKCML.GreenLegL1.GetComponent<Rigidbody>();
            this.CCLJLDLECLG = this.KPLKMDDKCML.GreenLegR1.GetComponent<Rigidbody>();
            this.CBHMDFLJEFC = this.KPLKMDDKCML.GreenLegL2.GetComponent<Rigidbody>();
            this.AIHMBIHLPHK = this.KPLKMDDKCML.GreenLegR2.GetComponent<Rigidbody>();
            this.KHEPKIPMKKF = this.PNGENFLDJAG.gameObject.GetComponent<CharacterDamage>();
            this.AJBEMNONLMC = this.KPLKMDDKCML.GreenHead.GetComponent<ConfigurableJoint>();
            this.NLEHLJPKLCH = this.KPLKMDDKCML.GreenChest.GetComponent<ConfigurableJoint>();
            this.CDBGCHHHPFL = this.KPLKMDDKCML.GreenWaist.GetComponent<ConfigurableJoint>();
            this.IMIIFNONDDM = this.KPLKMDDKCML.GreenLegL1.GetComponent<ConfigurableJoint>();
            this.NELDBBMLJLH = this.KPLKMDDKCML.GreenLegR1.GetComponent<ConfigurableJoint>();
            this.BGMAHMGFAOO = this.KPLKMDDKCML.GreenLegL2.GetComponent<ConfigurableJoint>();
            this.EMDJIGOAPAI = this.KPLKMDDKCML.GreenLegR2.GetComponent<ConfigurableJoint>();
            this.ALLICKLAKDB = this.KPLKMDDKCML.GreenUpperArmL.GetComponent<ConfigurableJoint>();
            this.NHNILCHENEH = this.KPLKMDDKCML.GreenUpperArmR.GetComponent<ConfigurableJoint>();
            this.ALEGOOOGBOJ = this.KPLKMDDKCML.GreenForeArmL.GetComponent<ConfigurableJoint>();
            this.POCAHMPKOOK = this.KPLKMDDKCML.GreenForeArmR.GetComponent<ConfigurableJoint>();
            this.MAJBKAIBGGJ.positionSpring = 300f;
            this.MAJBKAIBGGJ.positionDamper = 0.1f;
            this.MAJBKAIBGGJ.maximumForce = float.PositiveInfinity;
            this.LELHDIBAPGK.positionSpring = 200f;
            this.LELHDIBAPGK.positionDamper = 0.1f;
            this.LELHDIBAPGK.maximumForce = float.PositiveInfinity;
            this.GPCLMNLLEIF.positionSpring = 550f;
            this.GPCLMNLLEIF.positionDamper = 0.1f;
            this.GPCLMNLLEIF.maximumForce = float.PositiveInfinity;
            this.FMMOGKEHMJB.positionSpring = 650f;
            this.FMMOGKEHMJB.positionDamper = 0.1f;
            this.FMMOGKEHMJB.maximumForce = float.PositiveInfinity;
            this.MPAEMLEOHAM.positionSpring = 300f;
            this.MPAEMLEOHAM.positionDamper = 0.1f;
            this.MPAEMLEOHAM.maximumForce = float.PositiveInfinity;
            this.CJNOOPCMPNI.positionSpring = 300f;
            this.CJNOOPCMPNI.positionDamper = 0.1f;
            this.CJNOOPCMPNI.maximumForce = float.PositiveInfinity;
            this.JCEMCJDDJPA.positionSpring = 100f;
            this.JCEMCJDDJPA.positionDamper = 0.1f;
            this.JCEMCJDDJPA.maximumForce = float.PositiveInfinity;
            this.EIBMGGNJNEK.positionSpring = 100f;
            this.EIBMGGNJNEK.positionDamper = 0.1f;
            this.EIBMGGNJNEK.maximumForce = float.PositiveInfinity;
            this.NGGGGGANBMK.positionSpring = 30f;
            this.NGGGGGANBMK.positionDamper = 0.1f;
            this.NGGGGGANBMK.maximumForce = float.PositiveInfinity;
            this.LMNNNDOGANI.positionSpring = 30f;
            this.LMNNNDOGANI.positionDamper = 0.1f;
            this.LMNNNDOGANI.maximumForce = float.PositiveInfinity;
            this.LLOIGAEPIBK.positionSpring = 10f;
            this.LLOIGAEPIBK.positionDamper = 0.1f;
            this.LLOIGAEPIBK.maximumForce = float.PositiveInfinity;
            this.PEIPCHHGAOP.positionSpring = 10f;
            this.PEIPCHHGAOP.positionDamper = 0.1f;
            this.PEIPCHHGAOP.maximumForce = float.PositiveInfinity;
            this.GFJMEJNINGF.BodyPartJoint = this.AJBEMNONLMC;
            this.GFJMEJNINGF.BodyPartJointRollingRotation = this.DDEPMPICOGB;
            this.GFJMEJNINGF.BodyPartXJointDrive = this.MAJBKAIBGGJ;
            this.GFJMEJNINGF.BodyPartYZJointDrive = this.LELHDIBAPGK;
            this.MKMEKJDJNBC.BodyPartJoint = this.NLEHLJPKLCH;
            this.MKMEKJDJNBC.BodyPartJointRollingRotation = this.DCEPKDPCFGB;
            this.MKMEKJDJNBC.BodyPartXJointDrive = this.GPCLMNLLEIF;
            this.MKMEKJDJNBC.BodyPartYZJointDrive = this.GPCLMNLLEIF;
            this.EPKOAOHGCIM.BodyPartJoint = this.CDBGCHHHPFL;
            this.EPKOAOHGCIM.BodyPartJointRollingRotation = this.DPFLNFEEAJH;
            this.EPKOAOHGCIM.BodyPartXJointDrive = this.FMMOGKEHMJB;
            this.EPKOAOHGCIM.BodyPartYZJointDrive = this.FMMOGKEHMJB;
            this.HPEFHPPHEMK.BodyPartJoint = this.IMIIFNONDDM;
            this.HPEFHPPHEMK.BodyPartJointRollingRotation = this.OOCMDGOAIGN;
            this.HPEFHPPHEMK.BodyPartXJointDrive = this.MPAEMLEOHAM;
            this.HPEFHPPHEMK.BodyPartYZJointDrive = this.MPAEMLEOHAM;
            this.GEBIKMNIIPE.BodyPartJoint = this.NELDBBMLJLH;
            this.GEBIKMNIIPE.BodyPartJointRollingRotation = this.NHPMHFIMLCF;
            this.GEBIKMNIIPE.BodyPartXJointDrive = this.CJNOOPCMPNI;
            this.GEBIKMNIIPE.BodyPartYZJointDrive = this.CJNOOPCMPNI;
            this.BFKKIOJOMNN.BodyPartJoint = this.BGMAHMGFAOO;
            this.BFKKIOJOMNN.BodyPartJointRollingRotation = this.JFOMNBKHNEA;
            this.BFKKIOJOMNN.BodyPartXJointDrive = this.JCEMCJDDJPA;
            this.BFKKIOJOMNN.BodyPartYZJointDrive = this.JCEMCJDDJPA;
            this.LJDDAINPPOJ.BodyPartJoint = this.EMDJIGOAPAI;
            this.LJDDAINPPOJ.BodyPartJointRollingRotation = this.MIFLIDFHANC;
            this.LJDDAINPPOJ.BodyPartXJointDrive = this.EIBMGGNJNEK;
            this.LJDDAINPPOJ.BodyPartYZJointDrive = this.EIBMGGNJNEK;
            this.HCOGGJKNIBI.BodyPartJoint = this.ALLICKLAKDB;
            this.HCOGGJKNIBI.BodyPartJointRollingRotation = this.LJEPMOEOHDK;
            this.HCOGGJKNIBI.BodyPartXJointDrive = this.NGGGGGANBMK;
            this.HCOGGJKNIBI.BodyPartYZJointDrive = this.NGGGGGANBMK;
            this.LLBEMLHPFAN.BodyPartJoint = this.NHNILCHENEH;
            this.LLBEMLHPFAN.BodyPartJointRollingRotation = this.NFLEEPBMNFE;
            this.LLBEMLHPFAN.BodyPartXJointDrive = this.LMNNNDOGANI;
            this.LLBEMLHPFAN.BodyPartYZJointDrive = this.LMNNNDOGANI;
            this.DJIDLLCPMNN.BodyPartJoint = this.ALEGOOOGBOJ;
            this.DJIDLLCPMNN.BodyPartJointRollingRotation = this.IGBOKCGKIIA;
            this.DJIDLLCPMNN.BodyPartXJointDrive = this.LLOIGAEPIBK;
            this.DJIDLLCPMNN.BodyPartYZJointDrive = this.LLOIGAEPIBK;
            this.CHCMAFBEAJC.BodyPartJoint = this.POCAHMPKOOK;
            this.CHCMAFBEAJC.BodyPartJointRollingRotation = this.HOGGGMDJMNP;
            this.CHCMAFBEAJC.BodyPartXJointDrive = this.PEIPCHHGAOP;
            this.CHCMAFBEAJC.BodyPartYZJointDrive = this.PEIPCHHGAOP;
        }




        private void OIJJFLDCHOL(bool HFGCKICBPHP, RaycastHit MMJMBGACACC)
        {
            if (HFGCKICBPHP && MMJMBGACACC.rigidbody != null)
            {
                this.EDOPEIJDJAF = MMJMBGACACC.rigidbody.GetPointVelocity(MMJMBGACACC.point);
                this.CKHLGFPJCNK = (this.LOPOHMCKMKL.mass * Vector3.Dot(this.LOPOHMCKMKL.velocity - this.EDOPEIJDJAF, this.ICHOMNELKGK) + this.FIIKBADHOJH.mass * Vector3.Dot(this.FIIKBADHOJH.velocity - this.EDOPEIJDJAF, this.ICHOMNELKGK) + this.IHEELAEEPHA.mass * Vector3.Dot(this.IHEELAEEPHA.velocity - this.EDOPEIJDJAF, this.ICHOMNELKGK) + this.BBKJLDINBOD.mass * Vector3.Dot(this.BBKJLDINBOD.velocity - this.EDOPEIJDJAF, this.ICHOMNELKGK) + this.CCLJLDLECLG.mass * Vector3.Dot(this.CCLJLDLECLG.velocity - this.EDOPEIJDJAF, this.ICHOMNELKGK) + this.CBHMDFLJEFC.mass * Vector3.Dot(this.CBHMDFLJEFC.velocity - this.EDOPEIJDJAF, this.ICHOMNELKGK) + this.AIHMBIHLPHK.mass * Vector3.Dot(this.AIHMBIHLPHK.velocity - this.EDOPEIJDJAF, this.ICHOMNELKGK) + this.PNGENFLDJAG.mass * Vector3.Dot(this.PNGENFLDJAG.velocity - this.EDOPEIJDJAF, this.ICHOMNELKGK)) * 0.5f;
                return;
            }
            this.CKHLGFPJCNK = (this.LOPOHMCKMKL.mass * Vector3.Dot(this.LOPOHMCKMKL.velocity, this.ICHOMNELKGK) + this.FIIKBADHOJH.mass * Vector3.Dot(this.FIIKBADHOJH.velocity, this.ICHOMNELKGK) + this.IHEELAEEPHA.mass * Vector3.Dot(this.IHEELAEEPHA.velocity, this.ICHOMNELKGK) + this.BBKJLDINBOD.mass * Vector3.Dot(this.BBKJLDINBOD.velocity, this.ICHOMNELKGK) + this.CCLJLDLECLG.mass * Vector3.Dot(this.CCLJLDLECLG.velocity, this.ICHOMNELKGK) + this.CBHMDFLJEFC.mass * Vector3.Dot(this.CBHMDFLJEFC.velocity, this.ICHOMNELKGK) + this.AIHMBIHLPHK.mass * Vector3.Dot(this.AIHMBIHLPHK.velocity, this.ICHOMNELKGK) + this.PNGENFLDJAG.mass * Vector3.Dot(this.PNGENFLDJAG.velocity, this.ICHOMNELKGK)) * 0.5f;
        }


        private PhysicCharacterController KPLKMDDKCML;

        private WaitForFixedUpdate MJOFAKABBGM = new WaitForFixedUpdate();

        private bool FFFEODMGAOK;

        private Rigidbody PNGENFLDJAG;

        private Rigidbody LOPOHMCKMKL;

        private Rigidbody FIIKBADHOJH;

        private Rigidbody IHEELAEEPHA;

        private Rigidbody BBKJLDINBOD;

        private Rigidbody CCLJLDLECLG;

        private Rigidbody CBHMDFLJEFC;

        private Rigidbody AIHMBIHLPHK;

        private CharacterDamage KHEPKIPMKKF;

        private ConfigurableJoint AJBEMNONLMC;

        private ConfigurableJoint NLEHLJPKLCH;

        private ConfigurableJoint CDBGCHHHPFL;

        private ConfigurableJoint IMIIFNONDDM;

        private ConfigurableJoint NELDBBMLJLH;

        private ConfigurableJoint BGMAHMGFAOO;

        private ConfigurableJoint EMDJIGOAPAI;

        private ConfigurableJoint ALLICKLAKDB;

        private ConfigurableJoint NHNILCHENEH;

        private ConfigurableJoint ALEGOOOGBOJ;

        private ConfigurableJoint POCAHMPKOOK;

        private JointDrive MAJBKAIBGGJ;

        private JointDrive LELHDIBAPGK;

        private JointDrive GPCLMNLLEIF;

        private JointDrive FMMOGKEHMJB;

        private JointDrive MPAEMLEOHAM;

        private JointDrive CJNOOPCMPNI;

        private JointDrive JCEMCJDDJPA;

        private JointDrive EIBMGGNJNEK;

        private JointDrive NGGGGGANBMK;

        private JointDrive LMNNNDOGANI;

        private JointDrive LLOIGAEPIBK;

        private JointDrive PEIPCHHGAOP;

        private Quaternion DDEPMPICOGB = Quaternion.Euler(new Quaternion(-0.55f, 0f, 0f, 1f).eulerAngles);

        private Quaternion DCEPKDPCFGB = Quaternion.Euler(new Quaternion(-0.54f, 0f, 0f, 1f).eulerAngles);

        private Quaternion DPFLNFEEAJH = Quaternion.Euler(new Quaternion(-0.85f, 0f, 0f, 1f).eulerAngles);

        private Quaternion OOCMDGOAIGN = Quaternion.Euler(new Quaternion(0.17f, 0f, 0f, 1f).eulerAngles);

        private Quaternion NHPMHFIMLCF = Quaternion.Euler(new Quaternion(0.17f, 0f, 0f, 1f).eulerAngles);

        private Quaternion JFOMNBKHNEA = Quaternion.Euler(new Quaternion(-0.16f, 0f, 0f, 1f).eulerAngles);

        private Quaternion MIFLIDFHANC = Quaternion.Euler(new Quaternion(-0.16f, 0f, 0f, 1f).eulerAngles);

        private Quaternion LJEPMOEOHDK = Quaternion.Euler(new Quaternion(0.77f, 0f, 0f, 1f).eulerAngles);

        private Quaternion NFLEEPBMNFE = Quaternion.Euler(new Quaternion(0.77f, 0f, 0f, 1f).eulerAngles);

        private Quaternion IGBOKCGKIIA = Quaternion.Euler(new Quaternion(0.2f, 0f, 0f, 1f).eulerAngles);

        private Quaternion HOGGGMDJMNP = Quaternion.Euler(new Quaternion(0.2f, 0f, 0f, 1f).eulerAngles);

        private JOCBIJDFNNC.EAHMCFHBMNP GFJMEJNINGF;

        private JOCBIJDFNNC.EAHMCFHBMNP MKMEKJDJNBC;

        private JOCBIJDFNNC.EAHMCFHBMNP EPKOAOHGCIM;

        private JOCBIJDFNNC.EAHMCFHBMNP HPEFHPPHEMK;

        private JOCBIJDFNNC.EAHMCFHBMNP GEBIKMNIIPE;

        private JOCBIJDFNNC.EAHMCFHBMNP BFKKIOJOMNN;

        private JOCBIJDFNNC.EAHMCFHBMNP LJDDAINPPOJ;

        private JOCBIJDFNNC.EAHMCFHBMNP HCOGGJKNIBI;

        private JOCBIJDFNNC.EAHMCFHBMNP LLBEMLHPFAN;

        private JOCBIJDFNNC.EAHMCFHBMNP DJIDLLCPMNN;

        private JOCBIJDFNNC.EAHMCFHBMNP CHCMAFBEAJC;

        private Vector3 EAEJDHJFBCB;

        private float NOBEGHMOJFD;

        private bool DIIEFNKHKIG;

        internal LayerMask FEPNDJPCAJB;

        private float PCDBCFNOJMK;

        private float HLMAFBJHHMK;

        private float CKHLGFPJCNK;

        private bool HFGCKICBPHP;

        private RaycastHit MMJMBGACACC;

        private Vector3 EDOPEIJDJAF;

        private float CHFKFIGAGGB;

        private PhysicMaterial MCBBMCALPHC;

        private Vector3 MNKOJLLBLDD;

        private Vector3 HMEMDJNIGNM;

        private Vector3 ICHOMNELKGK;

        private struct EAHMCFHBMNP
        {
            public ConfigurableJoint BodyPartJoint;

            public JointDrive BodyPartXJointDrive;

            public JointDrive BodyPartYZJointDrive;

            public Quaternion BodyPartJointRollingRotation;
        }
    }
}