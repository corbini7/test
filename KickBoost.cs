using UnityEngine;
namespace Deobfuscated
{
    internal class KickBoost : Boost
    {












        public bool CanKickBoost
        {
            get
            {
                return this.BDFIPOILKFM;
            }
            set
            {
                if (this.BDFIPOILKFM != value)
                {
                    this.BDFIPOILKFM = value;
                    if (value)
                    {
                        this.AECMLPOOFEI();
                    }
                }
            }
        }

        private void OnCollisionEnter(Collision NLJBANLOGGI)
        {
            if (!this.CanKickBoost || PhysicsDummyModeManager.IsPaused)
            {
                return;
            }
            if (this.KPLKMDDKCML.IINJFJOIHMK.Contains(NLJBANLOGGI.gameObject))
            {
                return;
            }
            if (GameObjectToWeaponMapper.gameObjectToWeaponMap.ContainsKey(NLJBANLOGGI.gameObject))
            {
                return;
            }
            this.EIMDFKLKJKP = NLJBANLOGGI.rigidbody;
            if (!(this.EIMDFKLKJKP != null))
            {
                this.CJBMNHFBDOH = NLJBANLOGGI.impulse.magnitude;
                this.CDEKHCKJFLK = Mathf.Clamp(this.KHABJLNHGKO.Power, 0.1f, 999f);
                this.JIDHHBAGEOM = Mathf.Max(0f, Mathf.Pow(this.CDEKHCKJFLK, 0.5f));
                this.KPLKMDDKCML.LANKEBGAODO(this.CJBMNHFBDOH * this.JIDHHBAGEOM, false, this.KBEMHDPMNLA ? PhysicCharacterController.AttackType.LeftKick : PhysicCharacterController.AttackType.RightKick, NLJBANLOGGI.gameObject);
                return;
            }
            this.CJBMNHFBDOH = NLJBANLOGGI.impulse.magnitude;
            this.COHCKBNINEN = 0f;
            this.MJCEGMDGOOK = this.CJBMNHFBDOH / this.EIMDFKLKJKP.mass * 13f;
            this.ABLFEPGBNMP = this.COJGHMEFLGP;
            this.IINPALLFEOC = this.PBBELOKFOBK;
            this.COJGHMEFLGP -= this.MJCEGMDGOOK;
            if (this.COJGHMEFLGP <= 0f)
            {
                this.COHCKBNINEN = this.EIMDFKLKJKP.mass * this.ABLFEPGBNMP;
                this.PBBELOKFOBK -= this.COHCKBNINEN;
                if (this.PBBELOKFOBK <= 0f)
                {
                    this.COHCKBNINEN = this.IINPALLFEOC;
                }
            }
            else
            {
                this.COHCKBNINEN = this.CJBMNHFBDOH * 13f;
                this.PBBELOKFOBK -= this.COHCKBNINEN;
                if (this.PBBELOKFOBK <= 0f)
                {
                    this.COHCKBNINEN = this.IINPALLFEOC;
                }
            }
            if (this.COJGHMEFLGP <= 0f || this.PBBELOKFOBK <= 0f)
            {
                this.CanKickBoost = false;
            }
            this.COHCKBNINEN *= Random.Range(1.1f, 1.2f);
            this.CDEKHCKJFLK = Mathf.Clamp(this.KHABJLNHGKO.Power, 0.1f, 999f);
            this.JIDHHBAGEOM = Mathf.Max(0f, Mathf.Pow(this.CDEKHCKJFLK, 0.5f));
            this.LDGKBHOHNLL = Mathf.Max(0f, Mathf.Pow(this.CDEKHCKJFLK, 0.7f));
            Transform parent = NLJBANLOGGI.gameObject.transform.parent;
            if (!(parent != null) || !PccManager.gameObjectToCharacterControllerMap.ContainsKey(parent.gameObject))
            {
                this.ADFKEKDCGBG(NLJBANLOGGI, 0.3f);
                this.KPLKMDDKCML.LANKEBGAODO(this.CJBMNHFBDOH * this.JIDHHBAGEOM, false, this.KBEMHDPMNLA ? PhysicCharacterController.AttackType.LeftKick : PhysicCharacterController.AttackType.RightKick, NLJBANLOGGI.gameObject);
                return;
            }
            this.ALNODBFGJPJ = PccManager.gameObjectToCharacterControllerMap[parent.gameObject].characterStates;
            this.KNPHGMJCPME = 1f;
            if (PccManager.gameObjectToCharacterControllerMap[parent.gameObject].IFEGFIOLHFC.ContainsKey(NLJBANLOGGI.gameObject))
            {
                this.KNPHGMJCPME = PccManager.gameObjectToCharacterControllerMap[parent.gameObject].IFEGFIOLHFC[NLJBANLOGGI.gameObject].DamageTweak;
            }
            if (this.ALNODBFGJPJ.Health > 0f && !this.ALNODBFGJPJ.IsInvincible)
            {
                base.CALDKFGBIFH(this.ALNODBFGJPJ.physicCharacterController);
            }
            float dizzy = this.ALNODBFGJPJ.dizzy;
            this.IOJMNCBBAMJ = this.CJBMNHFBDOH * 0.035f * this.JIDHHBAGEOM * this.ALNODBFGJPJ.AntiDizzy * this.ALNODBFGJPJ.AntiDizzyByEquip * this.KNPHGMJCPME;
            this.ALNODBFGJPJ.DBHFPLBJGKH(this.IOJMNCBBAMJ);
            bool ohgdfndfjba = dizzy > 0f && this.ALNODBFGJPJ.dizzy <= 0f;
            this.KPLKMDDKCML.LANKEBGAODO(this.CJBMNHFBDOH * this.JIDHHBAGEOM, ohgdfndfjba, this.KBEMHDPMNLA ? PhysicCharacterController.AttackType.LeftKick : PhysicCharacterController.AttackType.RightKick, NLJBANLOGGI.gameObject);
            if (this.ALNODBFGJPJ.physicCharacterController.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                this.ADFKEKDCGBG(NLJBANLOGGI, 1f);
            }
            else
            {
                this.ADFKEKDCGBG(NLJBANLOGGI, 0.45f);
            }
            this.CBCJBHPLHOO = this.CJBMNHFBDOH * 0.005f * this.JIDHHBAGEOM * this.ALNODBFGJPJ.AntiHealthLose * this.ALNODBFGJPJ.AntiHealthLoseByEquip * this.KNPHGMJCPME;
            if (this.ALNODBFGJPJ.Health - this.CBCJBHPLHOO <= 0f && this.ALNODBFGJPJ.Health > 0f && !this.ALNODBFGJPJ.IsInvincible)
            {
                base.JJMPJGKNCFK(this.ALNODBFGJPJ.physicCharacterController);
            }
            this.ALNODBFGJPJ.Health -= this.CBCJBHPLHOO;
            if (this.KBEMHDPMNLA)
            {
                this.KPLKMDDKCML.NMFIPKMKICJ += this.IOJMNCBBAMJ;
                this.KPLKMDDKCML.BGKCNODEJLE += this.CBCJBHPLHOO;
                return;
            }
            this.KPLKMDDKCML.ILGFHALPNJB += this.IOJMNCBBAMJ;
            this.KPLKMDDKCML.DNOODOFCLCG += this.CBCJBHPLHOO;
        }

        private void AECMLPOOFEI()
        {
            this.COJGHMEFLGP = 80f;
            this.PBBELOKFOBK = 260f;
        }











        protected override void DFAEKBNBAIC()
        {
            base.Awake();
            this.KBEMHDPMNLA = (this.KPLKMDDKCML.GreenLegL2 == base.gameObject);
        }






















        protected override void GACNHLOLNPM()
        {
            base.DFAEKBNBAIC();
            this.KBEMHDPMNLA = (this.KPLKMDDKCML.GreenLegL2 == base.gameObject);
        }








        protected override void Awake()
        {
            base.Awake();
            this.KBEMHDPMNLA = (this.KPLKMDDKCML.GreenLegL2 == base.gameObject);
        }


        private void ADFKEKDCGBG(Collision NLJBANLOGGI, float LDHHKNOAGMF)
        {
            CFOGGNCCHCO.OEODACNOHCD(this.EIMDFKLKJKP, LDHHKNOAGMF * this.COHCKBNINEN * this.LDGKBHOHNLL * -this.theHip.transform.up, base.NLBIFNELNCL(NLJBANLOGGI), ForceMode.Impulse);
        }






        private bool BDFIPOILKFM;

        public GameObject theHip;

        private float COJGHMEFLGP;

        private float PBBELOKFOBK;

        private Rigidbody EIMDFKLKJKP;

        private CharacterStates ALNODBFGJPJ;

        private float KNPHGMJCPME;

        private float IOJMNCBBAMJ;

        private float CBCJBHPLHOO;

        private float CJBMNHFBDOH;

        private float COHCKBNINEN;

        private float MJCEGMDGOOK;

        private float ABLFEPGBNMP;

        private float IINPALLFEOC;

        private float CDEKHCKJFLK;

        private float JIDHHBAGEOM;

        private float LDGKBHOHNLL;

        private bool KBEMHDPMNLA;
    }
}