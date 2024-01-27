using System;
using UnityEngine;
namespace Deobfuscated
{
    internal class ObjectBoost : Boost
    {




        protected override void KMBKLAOKHOE()
        {
            PBLPJECHFPJ.GBDKOCFFFDD.Add(base.gameObject, this);
        }




        protected override void FJJKFAGMJBA()
        {
            PBLPJECHFPJ.GBDKOCFFFDD.Add(base.gameObject, this);
        }



















        internal PhysicCharacterController MAKHHGBKEKA
        {
            get
            {
                return this.IILPJMAEHAO;
            }
            set
            {
                base.OMCANMBABCP(this.IILPJMAEHAO);
                base.MOFNCDKJBED(this.IILPJMAEHAO);
                base.EHMAHJAIJFK(value);
                base.ELIGPBNCLIG(value);
                this.IILPJMAEHAO = value;
                this.BJIOEFAECPF = Time.fixedTime;
            }
        }




        protected override void Awake()
        {
            PBLPJECHFPJ.GBDKOCFFFDD.Add(base.gameObject, this);
        }


        private void OnCollisionEnter(Collision NLJBANLOGGI)
        {
            if (this.MAKHHGBKEKA == null || NLJBANLOGGI.rigidbody == null || Time.fixedTime - this.BJIOEFAECPF > 4f)
            {
                return;
            }
            if (NLJBANLOGGI.gameObject.layer != 8 || this.MAKHHGBKEKA.IINJFJOIHMK.Contains(NLJBANLOGGI.gameObject))
            {
                return;
            }
            Vector3 vector = NLJBANLOGGI.impulse;
            if (NLJBANLOGGI.gameObject.name == "GreenHead")
            {
                Transform parent = NLJBANLOGGI.gameObject.transform.parent;
                PhysicCharacterController physicCharacterController = PccManager.gameObjectToCharacterControllerMap[parent.gameObject];
                base.CALDKFGBIFH(physicCharacterController);
                physicCharacterController.characterStates.DBHFPLBJGKH(vector.magnitude * 0.06f);
            }
            if (Vector3.Angle(vector, base.MGKKKLFIGCL(NLJBANLOGGI)) < 90f)
            {
                vector = -vector;
            }
            Vector3 position = base.NLBIFNELNCL(NLJBANLOGGI);
            NLJBANLOGGI.rigidbody.AddForceAtPosition(vector * 2f, position, ForceMode.Impulse);
            this.DPIJEBPBDMM.AddForceAtPosition(vector * -2f, position, ForceMode.Impulse);
            this.MAKHHGBKEKA = null;
        }












        protected override void HFAPPKOONOF()
        {
            PBLPJECHFPJ.GBDKOCFFFDD.Add(base.gameObject, this);
        }


        private Rigidbody DPIJEBPBDMM
        {
            get
            {
                if (this.BPDMPCHPIAH == null)
                {
                    this.BPDMPCHPIAH = base.GetComponent<Rigidbody>();
                }
                return this.BPDMPCHPIAH;
            }
        }


        protected override void DFAEKBNBAIC()
        {
            PBLPJECHFPJ.GBDKOCFFFDD.Add(base.gameObject, this);
        }




        private void OnDestroy()
        {
            PBLPJECHFPJ.GBDKOCFFFDD.Remove(base.gameObject);
        }



        private PhysicCharacterController IILPJMAEHAO;

        private float BJIOEFAECPF;

        private Rigidbody BPDMPCHPIAH;
    }
}