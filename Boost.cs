using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    public class Boost : MonoBehaviour
    {











        protected virtual void GACNHLOLNPM()
        {
            this.EHJEBAMAANF = base.gameObject.transform.parent.gameObject;
            this.KPLKMDDKCML = this.EHJEBAMAANF.GetComponent<PhysicCharacterController>();
            this.KHABJLNHGKO = this.EHJEBAMAANF.GetComponent<CharacterStates>();
            this.LHECENDMAOJ(this.KPLKMDDKCML);
            this.GHBMFFMFJIC(this.KPLKMDDKCML);
        }





        protected void JJMPJGKNCFK(PhysicCharacterController FLPIPBCIIHB)
        {
            foreach (Boost.IKillSomeoneCallback killSomeoneCallback in this.PKOEBJAKICC)
            {
                killSomeoneCallback.OnKillSomeone(FLPIPBCIIHB);
            }
        }


        protected void BDHEIPDCPOP(Boost.IKillSomeoneCallback KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Add(KOMCGCIBLEP);
        }

        protected virtual void HFAPPKOONOF()
        {
            this.EHJEBAMAANF = base.gameObject.transform.parent.gameObject;
            this.KPLKMDDKCML = this.EHJEBAMAANF.GetComponent<PhysicCharacterController>();
            this.KHABJLNHGKO = this.EHJEBAMAANF.GetComponent<CharacterStates>();
            this.PJNFKMLNCBG(this.KPLKMDDKCML);
            this.IBJPPLILPFO(this.KPLKMDDKCML);
        }







        protected void ELIGPBNCLIG(Boost.IKillSomeoneCallback KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Add(KOMCGCIBLEP);
        }





        protected virtual void LMAFNAGDFCK()
        {
            this.EHJEBAMAANF = base.gameObject.transform.parent.gameObject;
            this.KPLKMDDKCML = this.EHJEBAMAANF.GetComponent<PhysicCharacterController>();
            this.KHABJLNHGKO = this.EHJEBAMAANF.GetComponent<CharacterStates>();
            this.PNNDAOHFHBE(this.KPLKMDDKCML);
            this.IGCOGFNONLP(this.KPLKMDDKCML);
        }

        protected void EHMAHJAIJFK(Boost.IAttackSomeoneCallback KOMCGCIBLEP)
        {
            this.PNHPNMEJBKB.Add(KOMCGCIBLEP);
        }

        protected virtual void FJJKFAGMJBA()
        {
            this.EHJEBAMAANF = base.gameObject.transform.parent.gameObject;
            this.KPLKMDDKCML = this.EHJEBAMAANF.GetComponent<PhysicCharacterController>();
            this.KHABJLNHGKO = this.EHJEBAMAANF.GetComponent<CharacterStates>();
            this.GCCLGPOHDOA(this.KPLKMDDKCML);
            this.BDHEIPDCPOP(this.KPLKMDDKCML);
        }





        protected void AIKLHFHPGOL(Boost.IKillSomeoneCallback KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Add(KOMCGCIBLEP);
        }



        protected void DPGCFABEHPE(Boost.IKillSomeoneCallback KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Add(KOMCGCIBLEP);
        }


        protected void GCCLGPOHDOA(Boost.IAttackSomeoneCallback KOMCGCIBLEP)
        {
            this.PNHPNMEJBKB.Add(KOMCGCIBLEP);
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



        protected void OMCANMBABCP(Boost.IAttackSomeoneCallback KOMCGCIBLEP)
        {
            this.PNHPNMEJBKB.Remove(KOMCGCIBLEP);
        }
















        protected void CCMPHOFMBBC(Boost.IKillSomeoneCallback KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Add(KOMCGCIBLEP);
        }



        protected void LHECENDMAOJ(Boost.IAttackSomeoneCallback KOMCGCIBLEP)
        {
            this.PNHPNMEJBKB.Add(KOMCGCIBLEP);
        }



        protected void PNNDAOHFHBE(Boost.IAttackSomeoneCallback KOMCGCIBLEP)
        {
            this.PNHPNMEJBKB.Add(KOMCGCIBLEP);
        }



        protected void PJNFKMLNCBG(Boost.IAttackSomeoneCallback KOMCGCIBLEP)
        {
            this.PNHPNMEJBKB.Add(KOMCGCIBLEP);
        }




        protected void OLCKGGDPGCE(Boost.IAttackSomeoneCallback KOMCGCIBLEP)
        {
            this.PNHPNMEJBKB.Add(KOMCGCIBLEP);
        }








        protected void IGCOGFNONLP(Boost.IKillSomeoneCallback KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Add(KOMCGCIBLEP);
        }













        protected void AKEMHCNFHPJ(Boost.IAttackSomeoneCallback KOMCGCIBLEP)
        {
            this.PNHPNMEJBKB.Add(KOMCGCIBLEP);
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





        protected virtual void KMBKLAOKHOE()
        {
            this.EHJEBAMAANF = base.gameObject.transform.parent.gameObject;
            this.KPLKMDDKCML = this.EHJEBAMAANF.GetComponent<PhysicCharacterController>();
            this.KHABJLNHGKO = this.EHJEBAMAANF.GetComponent<CharacterStates>();
            this.OLCKGGDPGCE(this.KPLKMDDKCML);
            this.DPGCFABEHPE(this.KPLKMDDKCML);
        }



        protected virtual void DFAEKBNBAIC()
        {
            this.EHJEBAMAANF = base.gameObject.transform.parent.gameObject;
            this.KPLKMDDKCML = this.EHJEBAMAANF.GetComponent<PhysicCharacterController>();
            this.KHABJLNHGKO = this.EHJEBAMAANF.GetComponent<CharacterStates>();
            this.AKEMHCNFHPJ(this.KPLKMDDKCML);
            this.CCMPHOFMBBC(this.KPLKMDDKCML);
        }



        protected virtual void LCNIDMKPCKE()
        {
            this.EHJEBAMAANF = base.gameObject.transform.parent.gameObject;
            this.KPLKMDDKCML = this.EHJEBAMAANF.GetComponent<PhysicCharacterController>();
            this.KHABJLNHGKO = this.EHJEBAMAANF.GetComponent<CharacterStates>();
            this.PNNDAOHFHBE(this.KPLKMDDKCML);
            this.AIKLHFHPGOL(this.KPLKMDDKCML);
        }






















        protected void IBJPPLILPFO(Boost.IKillSomeoneCallback KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Add(KOMCGCIBLEP);
        }





        protected void CALDKFGBIFH(PhysicCharacterController MCFOLNMFCPN)
        {
            foreach (Boost.IAttackSomeoneCallback attackSomeoneCallback in this.PNHPNMEJBKB)
            {
                attackSomeoneCallback.OnAttackingSomeone(MCFOLNMFCPN);
            }
        }

        protected void GHBMFFMFJIC(Boost.IKillSomeoneCallback KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Add(KOMCGCIBLEP);
        }





        protected void MOFNCDKJBED(Boost.IKillSomeoneCallback KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Remove(KOMCGCIBLEP);
        }







        protected virtual void Awake()
        {
            this.EHJEBAMAANF = base.gameObject.transform.parent.gameObject;
            this.KPLKMDDKCML = this.EHJEBAMAANF.GetComponent<PhysicCharacterController>();
            this.KHABJLNHGKO = this.EHJEBAMAANF.GetComponent<CharacterStates>();
            this.EHMAHJAIJFK(this.KPLKMDDKCML);
            this.ELIGPBNCLIG(this.KPLKMDDKCML);
        }






        private readonly HashSet<Boost.IAttackSomeoneCallback> PNHPNMEJBKB = new HashSet<Boost.IAttackSomeoneCallback>();

        protected GameObject EHJEBAMAANF;

        protected PhysicCharacterController KPLKMDDKCML;

        protected CharacterStates KHABJLNHGKO;

        private readonly HashSet<Boost.IKillSomeoneCallback> PKOEBJAKICC = new HashSet<Boost.IKillSomeoneCallback>();

        public interface IAttackSomeoneCallback
        {
            void OnAttackingSomeone(PhysicCharacterController MCFOLNMFCPN);
        }

        public interface IKillSomeoneCallback
        {
            void OnKillSomeone(PhysicCharacterController PKBFLBHFLBN);
        }
    }
}