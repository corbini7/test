using UnityEngine;
namespace Deobfuscated
{
    internal class HeadPunchBoost : Boost
    {












        public bool CanHeadPunchBoost
        {
            get
            {
                return this.ODHJEBKAMBA;
            }
            set
            {
                if (this.ODHJEBKAMBA != value)
                {
                    this.ODHJEBKAMBA = value;
                    if (value)
                    {
                        this.AECMLPOOFEI();
                    }
                }
            }
        }










        private void OnCollisionEnter(Collision NLJBANLOGGI)
        {
            if (!this.CanHeadPunchBoost || PhysicsDummyModeManager.IsPaused)
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
                this.NKHGBEENEHF = NLJBANLOGGI.impulse.magnitude;
                this.CDEKHCKJFLK = Mathf.Clamp(this.KHABJLNHGKO.Power, 0.1f, 999f);
                this.JIDHHBAGEOM = Mathf.Max(0f, Mathf.Pow(this.CDEKHCKJFLK, 0.5f));
                this.KPLKMDDKCML.LANKEBGAODO(this.NKHGBEENEHF * this.JIDHHBAGEOM, false, PhysicCharacterController.AttackType.Headbutt, NLJBANLOGGI.gameObject);
                return;
            }
            this.NKHGBEENEHF = NLJBANLOGGI.impulse.magnitude;
            this.COHCKBNINEN = 0f;
            this.MJCEGMDGOOK = this.NKHGBEENEHF / this.EIMDFKLKJKP.mass * 5f;
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
                this.COHCKBNINEN = this.NKHGBEENEHF * 5f;
                this.PBBELOKFOBK -= this.COHCKBNINEN;
                if (this.PBBELOKFOBK <= 0f)
                {
                    this.COHCKBNINEN = this.IINPALLFEOC;
                }
            }
            if (this.COJGHMEFLGP <= 0f || this.PBBELOKFOBK <= 0f)
            {
                this.CanHeadPunchBoost = false;
            }
            this.COHCKBNINEN *= Random.Range(1.1f, 1.2f);
            this.CDEKHCKJFLK = Mathf.Clamp(this.KHABJLNHGKO.Power, 0.1f, 999f);
            this.JIDHHBAGEOM = Mathf.Max(0f, Mathf.Pow(this.CDEKHCKJFLK, 0.5f));
            this.LDGKBHOHNLL = Mathf.Max(0f, Mathf.Pow(this.CDEKHCKJFLK, 0.7f));
            Transform parent = NLJBANLOGGI.gameObject.transform.parent;
            if (parent != null && PccManager.gameObjectToCharacterControllerMap.ContainsKey(parent.gameObject))
            {
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
                this.IOJMNCBBAMJ = this.NKHGBEENEHF * 0.012f * this.JIDHHBAGEOM * this.ALNODBFGJPJ.AntiDizzy * this.ALNODBFGJPJ.AntiDizzyByEquip * this.KNPHGMJCPME;
                this.ALNODBFGJPJ.DBHFPLBJGKH(this.IOJMNCBBAMJ);
                bool ohgdfndfjba = dizzy > 0f && this.ALNODBFGJPJ.dizzy <= 0f;
                this.KPLKMDDKCML.LANKEBGAODO(this.NKHGBEENEHF * this.JIDHHBAGEOM, ohgdfndfjba, PhysicCharacterController.AttackType.Headbutt, NLJBANLOGGI.gameObject);
                this.CBCJBHPLHOO = this.NKHGBEENEHF * 0.002f * this.JIDHHBAGEOM * this.ALNODBFGJPJ.AntiHealthLose * this.ALNODBFGJPJ.AntiHealthLoseByEquip * this.KNPHGMJCPME;
                if (this.ALNODBFGJPJ.Health - this.CBCJBHPLHOO <= 0f && this.ALNODBFGJPJ.Health > 0f && !this.ALNODBFGJPJ.IsInvincible)
                {
                    base.JJMPJGKNCFK(this.ALNODBFGJPJ.physicCharacterController);
                }
                this.ALNODBFGJPJ.Health -= this.CBCJBHPLHOO;
                this.KPLKMDDKCML.ALFFKLCLFJE += this.IOJMNCBBAMJ;
                this.KPLKMDDKCML.ADLMIBPOPDP += this.CBCJBHPLHOO;
                this.ADFKEKDCGBG(NLJBANLOGGI, 1f);
                return;
            }
            this.ADFKEKDCGBG(NLJBANLOGGI, 1f);
            this.KPLKMDDKCML.LANKEBGAODO(this.NKHGBEENEHF * this.JIDHHBAGEOM, false, PhysicCharacterController.AttackType.Headbutt, NLJBANLOGGI.gameObject);
        }








        protected override void LMAFNAGDFCK()
        {
            base.LMAFNAGDFCK();
            this.FINFKGBMNKK = base.GetComponent<Rigidbody>();
        }





        private void AECMLPOOFEI()
        {
            this.COJGHMEFLGP = 50f;
            this.PBBELOKFOBK = 220f;
        }









        protected override void DFAEKBNBAIC()
        {
            base.LCNIDMKPCKE();
            this.FINFKGBMNKK = base.GetComponent<Rigidbody>();
        }




        protected override void Awake()
        {
            base.Awake();
            this.FINFKGBMNKK = base.GetComponent<Rigidbody>();
        }




        private void ADFKEKDCGBG(Collision NLJBANLOGGI, float LDHHKNOAGMF)
        {
            Vector3 vector = base.NLBIFNELNCL(NLJBANLOGGI);
            CFOGGNCCHCO.OEODACNOHCD(this.EIMDFKLKJKP, this.COHCKBNINEN * LDHHKNOAGMF * this.LDGKBHOHNLL * (vector - this.FINFKGBMNKK.worldCenterOfMass).normalized, vector, ForceMode.Impulse);
        }









        private bool ODHJEBKAMBA;

        private float COJGHMEFLGP;

        private float PBBELOKFOBK;

        private Rigidbody FINFKGBMNKK;

        private Rigidbody EIMDFKLKJKP;

        private CharacterStates ALNODBFGJPJ;

        private float KNPHGMJCPME;

        private float IOJMNCBBAMJ;

        private float CBCJBHPLHOO;

        private float NKHGBEENEHF;

        private float COHCKBNINEN;

        private float MJCEGMDGOOK;

        private float ABLFEPGBNMP;

        private float IINPALLFEOC;

        private float CDEKHCKJFLK;

        private float JIDHHBAGEOM;

        private float LDGKBHOHNLL;
    }
}