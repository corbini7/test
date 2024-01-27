using System.Collections;
using UnityEngine;
namespace Deobfuscated
{
    internal class PowerPunch : MonoBehaviour
    {
        private void JNPHGCHKOHG()
        {
            this.ACLFECOOBHB.GFGIJKOKKOL(5f, 5f, PhysicMaterialCombine.Average);
            this.ACLFECOOBHB.JFFGEAGPKFA(5f, 5f, PhysicMaterialCombine.Average);
            this.ACLFECOOBHB.FIICDLLMMBC(0f, 0f, PhysicMaterialCombine.Average);
        }





        public IEnumerator RunPowerPunch()
        {
            this.EGMDKOIAGFM.angularDrag = 100f;
            this.FOEFIIDLDNA();
            float num = 0.25f;
            while (num >= 0f && this.KPLKMDDKCML.MJAFJDDBMHN && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    Transform transform = this.EGMDKOIAGFM.transform;
                    this.PINMLABKHDN = (this.PINMLABKHDN * 0.5f + transform.position + -transform.up * 2f + transform.forward * 0.1f + transform.right * 0.3f - this.KEOJEDPGPJP.position).normalized;
                    num -= Time.fixedDeltaTime;
                    this.BMHHDPFBMCH(this.AJBEMNONLMC, this.GKIKAIONNJD, this.DAHFLGDOBBA);
                    this.BMHHDPFBMCH(this.NLEHLJPKLCH, this.CFOFGPIINCC, this.LKFCAJPJIGM);
                    this.BMHHDPFBMCH(this.CDBGCHHHPFL, this.CFOFGPIINCC, this.LKFCAJPJIGM);
                    this.BMHHDPFBMCH(this.ALLICKLAKDB, this.LFLHFLEBFHG, this.BBKGKOOLJEI);
                    this.BMHHDPFBMCH(this.NHNILCHENEH, this.JALAMJLAGMC, this.IEMMPBHHLLB);
                    this.BMHHDPFBMCH(this.ALEGOOOGBOJ, this.GHBHPPPJHHG, this.NLPNHNNELEA);
                    this.BMHHDPFBMCH(this.POCAHMPKOOK, this.BOEDEMHKHPH, this.LIHANCFPAOE);
                }
                yield return this.LGJIFPAHACH;
            }
            num = 0.065f;
            this.DGLKFAPJDBP();
            this.KOEEAHBLIEM.ShouldBoostPunch = true;
            this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.HeavyPunch, this.KEOJEDPGPJP);
            this.PINMLABKHDN = Vector3.ProjectOnPlane(this.PINMLABKHDN, Vector3.up).normalized;
            while (num >= 0f && this.KPLKMDDKCML.MJAFJDDBMHN && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    this.BMHHDPFBMCH(this.AJBEMNONLMC, this.HPKJDBOOEHK, this.EAJAAIKMDJN);
                    this.BMHHDPFBMCH(this.NLEHLJPKLCH, this.AGFBDMPMFNA, this.KPDFFEFPMFD);
                    this.BMHHDPFBMCH(this.CDBGCHHHPFL, this.AGFBDMPMFNA, this.KPDFFEFPMFD);
                    this.BMHHDPFBMCH(this.ALLICKLAKDB, this.CHPBOGDOPOK, this.LFBKEGILLOH);
                    this.BMHHDPFBMCH(this.NHNILCHENEH, this.BFFNKCEHNFF, this.EADCEACFAAP);
                    this.BMHHDPFBMCH(this.ALEGOOOGBOJ, this.HNGNMGOIECH, this.AJHMIKLNHBP);
                    this.BMHHDPFBMCH(this.POCAHMPKOOK, this.GKIHIENCCJA, this.MMJOFKFFLPP);
                    CFOGGNCCHCO.OEODACNOHCD(this.IIAODANAAOL, this.PINMLABKHDN * 69f, this.KEOJEDPGPJP.transform.position, ForceMode.Impulse);
                    CFOGGNCCHCO.EFNEGHJPJFN(this.EOBJGMAHAPA, this.EGMDKOIAGFM.transform.up.normalized * 40f, ForceMode.Impulse);
                }
                yield return this.LGJIFPAHACH;
            }
            this.PINMLABKHDN = Vector3.zero;
            num = 0.25f;
            while (num >= 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.MMHMEAGKGNN();
            num = 0.15f;
            while (num >= 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.JNPHGCHKOHG();
            this.KOEEAHBLIEM.ShouldBoostPunch = false;
            this.KPLKMDDKCML.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
            this.KPLKMDDKCML.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
            this.EGMDKOIAGFM.angularDrag = 0.05f;
            this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.HeavyPunch, this.KEOJEDPGPJP);
            yield break;
        }


        private void BMHHDPFBMCH(ConfigurableJoint DEIMKLMOEKJ, JointDrive KLGCLNGCCLA, Quaternion OCPNKBHILPJ)
        {
            DEIMKLMOEKJ.angularXDrive = KLGCLNGCCLA;
            DEIMKLMOEKJ.angularYZDrive = KLGCLNGCCLA;
            DEIMKLMOEKJ.targetRotation = OCPNKBHILPJ;
        }


        private void Start()
        {
            this.GKIKAIONNJD.positionSpring = 100f;
            this.GKIKAIONNJD.positionDamper = 1f;
            this.GKIKAIONNJD.maximumForce = float.PositiveInfinity;
            this.CFOFGPIINCC.positionSpring = 500f;
            this.CFOFGPIINCC.positionDamper = 1f;
            this.CFOFGPIINCC.maximumForce = float.PositiveInfinity;
            this.MJJBGFPADNH.positionSpring = 1000f;
            this.MJJBGFPADNH.positionDamper = 1f;
            this.MJJBGFPADNH.maximumForce = float.PositiveInfinity;
            this.LFLHFLEBFHG.positionSpring = 200f;
            this.LFLHFLEBFHG.positionDamper = 1f;
            this.LFLHFLEBFHG.maximumForce = float.PositiveInfinity;
            this.JALAMJLAGMC.positionSpring = 300f;
            this.JALAMJLAGMC.positionDamper = 1f;
            this.JALAMJLAGMC.maximumForce = float.PositiveInfinity;
            this.GHBHPPPJHHG.positionSpring = 100f;
            this.GHBHPPPJHHG.positionDamper = 1f;
            this.GHBHPPPJHHG.maximumForce = float.PositiveInfinity;
            this.BOEDEMHKHPH.positionSpring = 100f;
            this.BOEDEMHKHPH.positionDamper = 1f;
            this.BOEDEMHKHPH.maximumForce = float.PositiveInfinity;
            this.HPKJDBOOEHK.positionSpring = 100f;
            this.HPKJDBOOEHK.positionDamper = 1f;
            this.HPKJDBOOEHK.maximumForce = float.PositiveInfinity;
            this.AGFBDMPMFNA.positionSpring = 800f;
            this.AGFBDMPMFNA.positionDamper = 1f;
            this.AGFBDMPMFNA.maximumForce = float.PositiveInfinity;
            this.GJFKDBBAHAF.positionSpring = 1300f;
            this.GJFKDBBAHAF.positionDamper = 1f;
            this.GJFKDBBAHAF.maximumForce = float.PositiveInfinity;
            this.CHPBOGDOPOK.positionSpring = 300f;
            this.CHPBOGDOPOK.positionDamper = 4f;
            this.CHPBOGDOPOK.maximumForce = float.PositiveInfinity;
            this.BFFNKCEHNFF.positionSpring = 10f;
            this.BFFNKCEHNFF.positionDamper = 4f;
            this.BFFNKCEHNFF.maximumForce = float.PositiveInfinity;
            this.HNGNMGOIECH.positionSpring = 150f;
            this.HNGNMGOIECH.positionDamper = 4f;
            this.HNGNMGOIECH.maximumForce = float.PositiveInfinity;
            this.GKIHIENCCJA.positionSpring = 0f;
            this.GKIHIENCCJA.positionDamper = 4f;
            this.GKIHIENCCJA.maximumForce = float.PositiveInfinity;
        }


        private void MMHMEAGKGNN()
        {
            this.KEOJEDPGPJP.mass = 0.5f;
            this.IIAODANAAOL.mass = 1f;
            this.BJIFGLBBLCP.mass = 1f;
            this.HLADJPLPMAO.mass = 0.5f;
            this.EOBJGMAHAPA.mass = 1f;
            this.MAMNNDNBPGE.mass = 1f;
        }

        public void SetRigAndJoint(GameObject NADPFBICIKC, GameObject NPFAMIKCKBO, GameObject KACEFIJPKOF, GameObject CAKMCOBNHJJ, GameObject MOLGCICHGJL, GameObject NLJCAAOKOPP, GameObject JHBONEJGOAH, GameObject IIDKFHMPMHI, GameObject LNMMHIJMKAD, GameObject NGLLMMLFIBD, GameObject OEHKIFLBCIC)
        {
            this.AJBEMNONLMC = NADPFBICIKC.GetComponent<ConfigurableJoint>();
            this.NLEHLJPKLCH = NPFAMIKCKBO.GetComponent<ConfigurableJoint>();
            this.CDBGCHHHPFL = KACEFIJPKOF.GetComponent<ConfigurableJoint>();
            this.MAMNNDNBPGE = CAKMCOBNHJJ.GetComponent<Rigidbody>();
            this.ALLICKLAKDB = CAKMCOBNHJJ.GetComponent<ConfigurableJoint>();
            this.BJIFGLBBLCP = MOLGCICHGJL.GetComponent<Rigidbody>();
            this.NHNILCHENEH = MOLGCICHGJL.GetComponent<ConfigurableJoint>();
            this.EOBJGMAHAPA = NLJCAAOKOPP.GetComponent<Rigidbody>();
            this.ALEGOOOGBOJ = NLJCAAOKOPP.GetComponent<ConfigurableJoint>();
            this.IIAODANAAOL = JHBONEJGOAH.GetComponent<Rigidbody>();
            this.POCAHMPKOOK = JHBONEJGOAH.GetComponent<ConfigurableJoint>();
            this.EGMDKOIAGFM = IIDKFHMPMHI.GetComponent<Rigidbody>();
            this.HLADJPLPMAO = LNMMHIJMKAD.GetComponent<Rigidbody>();
            this.KEOJEDPGPJP = NGLLMMLFIBD.GetComponent<Rigidbody>();
            this.KPLKMDDKCML = OEHKIFLBCIC.GetComponent<PhysicCharacterController>();
            this.KOEEAHBLIEM = NGLLMMLFIBD.GetComponent<PunchBoost>();
            this.CHHMCBBFNJP = MOLGCICHGJL.GetComponent<Collider>();
            this.LJOLECMFJDD = JHBONEJGOAH.GetComponent<Collider>();
            this.AHJCDPHHOFM = NGLLMMLFIBD.GetComponent<Collider>();
        }


        private void FOEFIIDLDNA()
        {
            this.ACLFECOOBHB.GFGIJKOKKOL(0f, 0f, PhysicMaterialCombine.Minimum);
            this.ACLFECOOBHB.JFFGEAGPKFA(0f, 0f, PhysicMaterialCombine.Minimum);
            this.ACLFECOOBHB.FIICDLLMMBC(0f, 0f, PhysicMaterialCombine.Minimum);
        }

        private void DGLKFAPJDBP()
        {
            this.KEOJEDPGPJP.mass = 2.3f;
            this.IIAODANAAOL.mass = 2.3f;
            this.BJIFGLBBLCP.mass = 2.3f;
            this.HLADJPLPMAO.mass = 2.3f;
            this.EOBJGMAHAPA.mass = 2.3f;
            this.MAMNNDNBPGE.mass = 2.3f;
        }


        private Quaternion DAHFLGDOBBA = new Quaternion(0f, 0.19f, 0f, 1f);

        private JointDrive GKIKAIONNJD;

        private Quaternion LKFCAJPJIGM = new Quaternion(-0.05f, -0.13f, -0.2f, 1f);

        private JointDrive CFOFGPIINCC;

        private JointDrive MJJBGFPADNH;

        private Quaternion BBKGKOOLJEI = new Quaternion(0.26f, -0.62f, -0.16f, 1f);

        private JointDrive LFLHFLEBFHG;

        private Quaternion IEMMPBHHLLB = new Quaternion(0.22f, 0.34f, 0f, 1f);

        private JointDrive JALAMJLAGMC;

        private Quaternion NLPNHNNELEA = new Quaternion(1.5f, 0f, 0f, 1f);

        private JointDrive GHBHPPPJHHG;

        private Quaternion LIHANCFPAOE = new Quaternion(1.49f, 0f, 0f, 1f);

        private JointDrive BOEDEMHKHPH;

        private Quaternion EAJAAIKMDJN = new Quaternion(0f, 0f, 0f, 1f);

        private JointDrive HPKJDBOOEHK;

        private Quaternion KPDFFEFPMFD = new Quaternion(-0.25f, 0f, 0.2f, 1f);

        private JointDrive AGFBDMPMFNA;

        private JointDrive GJFKDBBAHAF;

        private Quaternion LFBKEGILLOH = new Quaternion(-0.32f, -0.57f, 0f, 1f);

        private JointDrive CHPBOGDOPOK;

        private Quaternion EADCEACFAAP = new Quaternion(0f, 0f, 0f, 1f);

        private JointDrive BFFNKCEHNFF;

        private Quaternion AJHMIKLNHBP = new Quaternion(1.29f, 0f, 0f, 1f);

        private JointDrive HNGNMGOIECH;

        private Quaternion MMJOFKFFLPP = new Quaternion(0f, 0f, 0f, 1f);

        private JointDrive GKIHIENCCJA;

        private WaitForFixedUpdate LGJIFPAHACH = new WaitForFixedUpdate();

        private Rigidbody MAMNNDNBPGE;

        private Rigidbody BJIFGLBBLCP;

        private Rigidbody EOBJGMAHAPA;

        private Rigidbody IIAODANAAOL;

        private Rigidbody EGMDKOIAGFM;

        private Rigidbody HLADJPLPMAO;

        private Rigidbody KEOJEDPGPJP;

        private ConfigurableJoint AJBEMNONLMC;

        private ConfigurableJoint NLEHLJPKLCH;

        private ConfigurableJoint CDBGCHHHPFL;

        private ConfigurableJoint ALLICKLAKDB;

        private ConfigurableJoint NHNILCHENEH;

        private ConfigurableJoint ALEGOOOGBOJ;

        private ConfigurableJoint POCAHMPKOOK;

        private Collider CHHMCBBFNJP;

        private Collider LJOLECMFJDD;

        private Collider AHJCDPHHOFM;

        private PunchBoost KOEEAHBLIEM;

        private PhysicCharacterController KPLKMDDKCML;

        private Vector3 PINMLABKHDN;

        internal OFMNKKOBIKG ACLFECOOBHB;
    }
}