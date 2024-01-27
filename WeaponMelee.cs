using System.Collections;
using UnityEngine;
namespace Deobfuscated
{
    public class WeaponMelee : Weapon
    {


        protected override void ECNADICBAEI()
        {
            base.ECNADICBAEI();
            this.CPBFCPHBCOC = base.transform.position;
            base.StartCoroutine(this.NDPGDDGGAEI());
        }



        protected void KOPJDFGNKLE(Collision NLJBANLOGGI, ref bool LMOPCBGKBID, float OHIAODBCHHM, float IAOCLBGJJBO, bool BPLNCODNLJI, float LGJEGBGGIHE, float BAHEDDDCKKC)
        {
            if (!LMOPCBGKBID || PhysicsDummyModeManager.IsPaused)
            {
                return;
            }
            this.EIMDFKLKJKP = NLJBANLOGGI.rigidbody;
            if (this.EIMDFKLKJKP != null)
            {
                this.LCFEPFBBLMO = this.MGKKKLFIGCL(NLJBANLOGGI);
                this.CAPJKAOBHPJ = this.NLBIFNELNCL(NLJBANLOGGI);
                this.ELAFJPPMAEH = Vector3.Distance(this.CPBFCPHBCOC, base.transform.position) / Time.fixedDeltaTime;
                this.FDJKPPOPJDC = Mathf.Min(1f, this.ELAFJPPMAEH / LGJEGBGGIHE);
                this.PLGKGDIJLHH = this.EIMDFKLKJKP.mass * 300f;
                OHIAODBCHHM = Mathf.Pow(Mathf.Clamp(OHIAODBCHHM, 0.1f, 999f), 0.7f);
                if (Vector3.Angle(this.LCFEPFBBLMO, NLJBANLOGGI.impulse) < 90f)
                {
                    this.IIJJBFDNBNG = -1f;
                }
                else
                {
                    this.IIJJBFDNBNG = 1f;
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
                    this.AKONMOICGCB = NLJBANLOGGI.impulse.magnitude * OHIAODBCHHM * IAOCLBGJJBO * this.TotalDamgeScale * this.FDJKPPOPJDC * this.KNPHGMJCPME;
                    if (this.ALNODBFGJPJ.Health > 0f && !this.ALNODBFGJPJ.IsInvincible)
                    {
                        base.BLKCAIGLNMJ(this.ALNODBFGJPJ.physicCharacterController);
                    }
                    this.IOJMNCBBAMJ = this.AKONMOICGCB * (1f - this.HealthRate) * this.ALNODBFGJPJ.AntiDizzy * this.ALNODBFGJPJ.AntiDizzyByEquip;
                    this.ALNODBFGJPJ.DBHFPLBJGKH(this.IOJMNCBBAMJ);
                    if (BPLNCODNLJI)
                    {
                        this.CBCJBHPLHOO = this.AKONMOICGCB * this.HealthRate * this.ALNODBFGJPJ.AntiHealthLose * this.ALNODBFGJPJ.AntiHealthLoseByEquip;
                    }
                    else
                    {
                        this.CBCJBHPLHOO = 0f;
                    }
                    if (this.ALNODBFGJPJ.Health - this.CBCJBHPLHOO <= 0f && this.ALNODBFGJPJ.Health > 0f && !this.ALNODBFGJPJ.IsInvincible)
                    {
                        base.JJMPJGKNCFK(this.ALNODBFGJPJ.physicCharacterController);
                    }
                    this.ALNODBFGJPJ.Health -= this.CBCJBHPLHOO;
                    this.ALNODBFGJPJ.KilledByWhat = CharacterStates.KilledBy.KilledByHammer;
                    if (this.IEDNGFIDBBL != null)
                    {
                        this.IEDNGFIDBBL.NDIMOOAHIKA += this.IOJMNCBBAMJ;
                        this.IEDNGFIDBBL.ILJCKDPPIHP += this.CBCJBHPLHOO;
                    }
                    this.ADFKEKDCGBG(NLJBANLOGGI, 4f, OHIAODBCHHM, BAHEDDDCKKC);
                    return;
                }
                this.ADFKEKDCGBG(NLJBANLOGGI, 2f, OHIAODBCHHM, BAHEDDDCKKC);
            }
        }








        protected Vector3 NLBIFNELNCL(Collision NLJBANLOGGI)
        {
            Vector3 a = Vector3.zero;
            foreach (ContactPoint contactPoint in NLJBANLOGGI.contacts)
            {
                a += contactPoint.point;
            }
            return a / (float)NLJBANLOGGI.contacts.Length;
        }













        protected Vector3 MGKKKLFIGCL(Collision NLJBANLOGGI)
        {
            Vector3 a = Vector3.zero;
            foreach (ContactPoint contactPoint in NLJBANLOGGI.contacts)
            {
                a += contactPoint.normal;
            }
            return a.normalized;
        }









        private void ADFKEKDCGBG(Collision NLJBANLOGGI, float LDHHKNOAGMF, float OHIAODBCHHM, float BAHEDDDCKKC)
        {
            Vector3 vector = BAHEDDDCKKC * this.IIJJBFDNBNG * OHIAODBCHHM * this.FDJKPPOPJDC * LDHHKNOAGMF * NLJBANLOGGI.impulse;
            this.EIMDFKLKJKP.AddForceAtPosition(Vector3.ClampMagnitude(vector, this.PLGKGDIJLHH), this.CAPJKAOBHPJ, ForceMode.Impulse);
        }







        private IEnumerator NDPGDDGGAEI()
        {
            while (base.IsAttacking && this.LMOPCBGKBID)
            {
                this.CPBFCPHBCOC = base.transform.position;
                yield return this.MJOFAKABBGM;
            }
            yield break;
        }






        protected bool LMOPCBGKBID;

        private Vector3 LCFEPFBBLMO;

        private Vector3 CAPJKAOBHPJ;

        private Vector3 CPBFCPHBCOC;

        private float ELAFJPPMAEH;

        private float FDJKPPOPJDC;

        private float PLGKGDIJLHH;


        private float IIJJBFDNBNG;

        private float KNPHGMJCPME;

        private float AKONMOICGCB;

        private Rigidbody EIMDFKLKJKP;

        private CharacterStates ALNODBFGJPJ;

        private float IOJMNCBBAMJ;

        private float CBCJBHPLHOO;
    }
}