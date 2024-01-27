using System;
using UnityEngine;

namespace Deobfuscated
{
    internal class PunchBoost : Boost
    {





        private void OnCollisionEnter(Collision NLJBANLOGGI)
        {
            if (!this.ShouldBoostPunch || PhysicsDummyModeManager.IsPaused)
            {
                return;
            }
            if (NLJBANLOGGI.gameObject.name == "GreenFistL" || NLJBANLOGGI.gameObject.name == "GreenFistR")
            {
                return;
            }
            if (this.KPLKMDDKCML.IINJFJOIHMK.Contains(NLJBANLOGGI.gameObject))
            {
                return;
            }
            this.EIMDFKLKJKP = NLJBANLOGGI.rigidbody;
            if (!(this.EIMDFKLKJKP != null))
            {
                this.CDEKHCKJFLK = Mathf.Clamp(this.KHABJLNHGKO.Power, 0.1f, 999f);
                this.JIDHHBAGEOM = Mathf.Max(0.7f, Mathf.Pow(this.CDEKHCKJFLK, 0.5f));
                this.CJBMNHFBDOH = NLJBANLOGGI.impulse.magnitude;
                this.KPLKMDDKCML.LANKEBGAODO(this.CJBMNHFBDOH * this.JIDHHBAGEOM, false, this.KBEMHDPMNLA ? PhysicCharacterController.AttackType.LeftPunch : PhysicCharacterController.AttackType.RightPunch, NLJBANLOGGI.gameObject);
                return;
            }
            this.LCFEPFBBLMO = base.MGKKKLFIGCL(NLJBANLOGGI);
            this.CJBMNHFBDOH = NLJBANLOGGI.impulse.magnitude;
            this.COHCKBNINEN = 0f;
            this.MJCEGMDGOOK = this.CJBMNHFBDOH / this.EIMDFKLKJKP.mass * 8f;
            this.CDEKHCKJFLK = Mathf.Clamp(this.KHABJLNHGKO.Power, 0.1f, 999f);
            this.JIDHHBAGEOM = Mathf.Max(0.7f, Mathf.Pow(this.CDEKHCKJFLK, 0.5f));
            this.PEIEMFKGDGD = Mathf.Max(0.77f, Mathf.Pow(this.CDEKHCKJFLK, 0.5f));
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
                this.COHCKBNINEN = this.CJBMNHFBDOH * 8f;
                this.PBBELOKFOBK -= this.COHCKBNINEN;
                if (this.PBBELOKFOBK <= 0f)
                {
                    this.COHCKBNINEN = this.IINPALLFEOC;
                }
            }
            if (this.COJGHMEFLGP <= 0f || this.PBBELOKFOBK <= 0f)
            {
                this.ShouldBoostPunch = false;
            }
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
                this.IOJMNCBBAMJ = this.CJBMNHFBDOH * 0.03f * this.JIDHHBAGEOM * this.ALNODBFGJPJ.AntiDizzy * this.ALNODBFGJPJ.AntiDizzyByEquip * this.KNPHGMJCPME;
                this.ALNODBFGJPJ.DBHFPLBJGKH(this.IOJMNCBBAMJ);
                bool ohgdfndfjba = dizzy > 0f && this.ALNODBFGJPJ.dizzy <= 0f;
                this.KPLKMDDKCML.LANKEBGAODO(this.CJBMNHFBDOH * this.JIDHHBAGEOM, ohgdfndfjba, this.KBEMHDPMNLA ? PhysicCharacterController.AttackType.LeftPunch : PhysicCharacterController.AttackType.RightPunch, NLJBANLOGGI.gameObject);
                this.CBCJBHPLHOO = this.CJBMNHFBDOH * 0.002f * this.JIDHHBAGEOM * this.ALNODBFGJPJ.AntiHealthLose * this.ALNODBFGJPJ.AntiHealthLoseByEquip * this.KNPHGMJCPME;
                if (this.ALNODBFGJPJ.Health - this.CBCJBHPLHOO <= 0f && this.ALNODBFGJPJ.Health > 0f && !this.ALNODBFGJPJ.IsInvincible)
                {
                    base.JJMPJGKNCFK(this.ALNODBFGJPJ.physicCharacterController);
                }
                this.ALNODBFGJPJ.Health -= this.CBCJBHPLHOO;
                if (this.KBEMHDPMNLA)
                {
                    this.KPLKMDDKCML.FBNFDJGNAMF += this.IOJMNCBBAMJ;
                    this.KPLKMDDKCML.MPACCGNKHFM += this.CBCJBHPLHOO;
                }
                else
                {
                    this.KPLKMDDKCML.LMAENCDEEFE += this.IOJMNCBBAMJ;
                    this.KPLKMDDKCML.CGHHBLBAAOJ += this.CBCJBHPLHOO;
                }
                this.ADFKEKDCGBG(NLJBANLOGGI, 1f);
                return;
            }
            this.ADFKEKDCGBG(NLJBANLOGGI, 0.2f);
            this.KPLKMDDKCML.LANKEBGAODO(this.CJBMNHFBDOH * this.JIDHHBAGEOM, false, this.KBEMHDPMNLA ? PhysicCharacterController.AttackType.LeftPunch : PhysicCharacterController.AttackType.RightPunch, NLJBANLOGGI.gameObject);
        }







        public bool ShouldBoostPunch
        {
            get
            {
                return this.KPMOGEGLAJO;
            }
            set
            {
                if (this.KPMOGEGLAJO != value)
                {
                    this.KPMOGEGLAJO = value;
                    if (value)
                    {
                        this.AECMLPOOFEI();
                    }
                }
            }
        }



        private void AECMLPOOFEI()
        {
            this.COJGHMEFLGP = 80f;
            this.PBBELOKFOBK = 250f;
        }




        private void Start()
        {
            this.KBEMHDPMNLA = (this.KPLKMDDKCML.GreenFistL == base.gameObject);
        }














        private void ADFKEKDCGBG(Collision NLJBANLOGGI, float LDHHKNOAGMF)
        {
            this.OJIFEAKMHJD = 1f;
            if (Vector3.Angle(this.LCFEPFBBLMO, NLJBANLOGGI.impulse) < 90f)
            {
                this.OJIFEAKMHJD = -1f;
            }
            CFOGGNCCHCO.OEODACNOHCD(this.EIMDFKLKJKP, LDHHKNOAGMF * this.COHCKBNINEN * this.OJIFEAKMHJD * this.PEIEMFKGDGD * NLJBANLOGGI.impulse.normalized, base.NLBIFNELNCL(NLJBANLOGGI), ForceMode.Impulse);
        }








        private bool KPMOGEGLAJO;

        private float COJGHMEFLGP;

        private float PBBELOKFOBK;

        private Rigidbody EIMDFKLKJKP;

        private CharacterStates ALNODBFGJPJ;

        private Vector3 LCFEPFBBLMO;

        private float KNPHGMJCPME;

        private float IOJMNCBBAMJ;

        private float CBCJBHPLHOO;

        private float CJBMNHFBDOH;

        private float COHCKBNINEN;

        private float MJCEGMDGOOK;

        private float CDEKHCKJFLK;

        private float JIDHHBAGEOM;

        private float PEIEMFKGDGD;

        private float ABLFEPGBNMP;

        private float IINPALLFEOC;

        private float OJIFEAKMHJD;

        private bool KBEMHDPMNLA;
    }
}