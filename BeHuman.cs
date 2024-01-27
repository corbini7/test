using System;
using UnityEngine;
namespace Deobfuscated
{
    internal class BeHuman : MonoBehaviour
    {

        private void CJBPDJLJBDG()
        {
            if (this.EKHNAAIKLDE > 0f)
            {
                this.EKHNAAIKLDE -= Time.fixedDeltaTime;
                return;
            }
            base.enabled = false;
        }


        private void OnEnable()
        {
            this.CMHMLLBJNNE = BeHuman.CharacterMovement.Nothing;
        }

        public void OverrideMovement(int PIECFKDOJLD)
        {
            if (PIECFKDOJLD < Enum.GetNames(typeof(BeHuman.CharacterMovement)).Length)
            {
                switch (this.CMHMLLBJNNE)
                {
                    case BeHuman.CharacterMovement.Nothing:
                        this.IKIANECMJEL.AJBGECAEPKA = false;
                        break;
                    case BeHuman.CharacterMovement.ScratchAss:
                        this.HEPNGGHIEBP.AJBGECAEPKA = false;
                        break;
                    case BeHuman.CharacterMovement.LookAround:
                        this.DGGFMHMAEIA.AJBGECAEPKA = false;
                        break;
                    case BeHuman.CharacterMovement.LookUp:
                        this.PDJLMEPLNKF.AJBGECAEPKA = false;
                        break;
                    case BeHuman.CharacterMovement.WarmUp:
                        this.MNALOADOLMA.AJBGECAEPKA = false;
                        break;
                }
                this.CMHMLLBJNNE = (BeHuman.CharacterMovement)PIECFKDOJLD;
            }
        }


        private void FixedUpdate()
        {
            if (PhysicsDummyModeManager.IsPaused)
            {
                return;
            }
            this.DGGFMHMAEIA.APIMEIBKOEH();
            this.HEPNGGHIEBP.APIMEIBKOEH();
            this.JCEEKNPCMFJ.APIMEIBKOEH();
            this.IKIANECMJEL.APIMEIBKOEH();
            this.PDJLMEPLNKF.APIMEIBKOEH();
            this.MNALOADOLMA.APIMEIBKOEH();
            this.CJBPDJLJBDG();
        }


        private void OnDisable()
        {
            this.CMHMLLBJNNE = BeHuman.CharacterMovement.Nothing;
            this.DGGFMHMAEIA.AJBGECAEPKA = false;
            this.HEPNGGHIEBP.AJBGECAEPKA = false;
            this.IKIANECMJEL.AJBGECAEPKA = false;
            this.PDJLMEPLNKF.AJBGECAEPKA = false;
            this.HEPNGGHIEBP.AJBGECAEPKA = false;
        }

        public void BecomeHuman(ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH, ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, float PAKNGDIDFGK, ref bool DJIDPOADDKN, ref bool ODJGOKPPCII)
        {
            if (!base.enabled)
            {
                base.enabled = true;
            }
            switch (this.CMHMLLBJNNE)
            {
                case BeHuman.CharacterMovement.Nothing:
                    this.IKIANECMJEL.PlayDoNothing(AJBEMNONLMC, ref this.HOKLDLDENLI);
                    this.FMKMJOCELLP.CharacterBreath(CDBGCHHHPFL, ALLICKLAKDB, NHNILCHENEH, PAKNGDIDFGK);
                    ODJGOKPPCII = true;
                    if (this.HOKLDLDENLI <= 0f)
                    {
                        float num = UnityEngine.Random.Range(0f, 100f);
                        if (num < 25f)
                        {
                            this.CMHMLLBJNNE = BeHuman.CharacterMovement.ScratchAss;
                        }
                        if (num >= 25f && num < 65f)
                        {
                            this.CMHMLLBJNNE = BeHuman.CharacterMovement.LookAround;
                        }
                        if (num >= 65f && num < 85f)
                        {
                            this.CMHMLLBJNNE = BeHuman.CharacterMovement.LookUp;
                        }
                        if (num >= 85f)
                        {
                            this.CMHMLLBJNNE = BeHuman.CharacterMovement.WarmUp;
                        }
                        ODJGOKPPCII = false;
                    }
                    break;
                case BeHuman.CharacterMovement.ScratchAss:
                    if (this.KPLKMDDKCML.WeaponGrabbed)
                    {
                        this.KPLKMDDKCML.CharacterDropWeapon();
                    }
                    this.HEPNGGHIEBP.PlayScratchAss(NLEHLJPKLCH, AJBEMNONLMC, ALLICKLAKDB, NHNILCHENEH, ref this.HOKLDLDENLI);
                    if (this.HOKLDLDENLI <= 0f)
                    {
                        this.CMHMLLBJNNE = BeHuman.CharacterMovement.Nothing;
                    }
                    break;
                case BeHuman.CharacterMovement.LookAround:
                    this.DGGFMHMAEIA.PlayLookAround(AJBEMNONLMC, ref this.HOKLDLDENLI);
                    if (this.HOKLDLDENLI <= 0f)
                    {
                        this.CMHMLLBJNNE = BeHuman.CharacterMovement.Nothing;
                    }
                    break;
                case BeHuman.CharacterMovement.LookUp:
                    this.PDJLMEPLNKF.PlayLookUp(AJBEMNONLMC, ref this.HOKLDLDENLI);
                    if (this.HOKLDLDENLI <= 0f)
                    {
                        this.CMHMLLBJNNE = BeHuman.CharacterMovement.Nothing;
                    }
                    break;
                case BeHuman.CharacterMovement.WarmUp:
                    if (this.KPLKMDDKCML.WeaponGrabbed)
                    {
                        this.KPLKMDDKCML.CharacterDropWeapon();
                    }
                    this.MNALOADOLMA.GEJONINFEPE(ALLICKLAKDB, NHNILCHENEH, CDBGCHHHPFL, ALEGOOOGBOJ, POCAHMPKOOK, AJBEMNONLMC, NLEHLJPKLCH, ref this.HOKLDLDENLI);
                    DJIDPOADDKN = false;
                    if (this.HOKLDLDENLI <= 0f)
                    {
                        this.CMHMLLBJNNE = BeHuman.CharacterMovement.Nothing;
                    }
                    break;
            }
            this.EKHNAAIKLDE = 0.02f;
        }


        private void Awake()
        {
            this.KPLKMDDKCML = PccManager.gameObjectToCharacterControllerMap[base.gameObject];
            this.DGGFMHMAEIA = new BOBENKDILNN();
            this.DGGFMHMAEIA.NPFAMIKCKBO = this.KPLKMDDKCML.GreenChest.transform;
            this.DGGFMHMAEIA.NADPFBICIKC = this.KPLKMDDKCML.GreenHead.transform;
            this.HEPNGGHIEBP = new PKICGJNAHGK();
            this.HEPNGGHIEBP.LNDDLJMNLBD = this.KPLKMDDKCML.LNDDLJMNLBD;
            this.HEPNGGHIEBP.PIMHHNKOCBE = this.KPLKMDDKCML.PIMHHNKOCBE;
            this.HEPNGGHIEBP.IIDKFHMPMHI = this.KPLKMDDKCML.GreenHip;
            this.JCEEKNPCMFJ = new PBIAOCBJEME();
            this.IKIANECMJEL = new IPFHJPEOOEA();
            this.PDJLMEPLNKF = new JCFCLMMNALB();
            this.FMKMJOCELLP = new DICBDBEIGEP();
            this.MNALOADOLMA = new OGHBLLAFJID();
            base.enabled = false;
        }



        private BeHuman.CharacterMovement CMHMLLBJNNE;

        private float HOKLDLDENLI;

        private float EKHNAAIKLDE;


        private BOBENKDILNN DGGFMHMAEIA;

        private PKICGJNAHGK HEPNGGHIEBP;

        private PBIAOCBJEME JCEEKNPCMFJ;

        private IPFHJPEOOEA IKIANECMJEL;

        private JCFCLMMNALB PDJLMEPLNKF;

        private DICBDBEIGEP FMKMJOCELLP;

        private OGHBLLAFJID MNALOADOLMA;

        private PhysicCharacterController KPLKMDDKCML;


        public enum CharacterMovement
        {
            Nothing,
            ScratchAss,
            LookAround,
            LookUp,
            WarmUp
        }
    }
}