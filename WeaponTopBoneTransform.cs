using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    public class WeaponTopBoneTransform : MonoBehaviour
    {



        private void NAODANMLMEG(bool GIGGKFPKKNF)
        {
            if (GIGGKFPKKNF)
            {
                this.JCGCLLMLCLH.position = this.partToFollow.position;
                this.JCGCLLMLCLH.rotation = this.partToFollow.rotation;
            }
        }

        public bool AAMABBJBECM()
        {
            return this.FMNEFKODEGJ;
        }





        public bool IJCOANEHIFF()
        {
            return this.FMNEFKODEGJ;
        }




        public bool GNGKPOOOACO()
        {
            return this.FMNEFKODEGJ;
        }

        public bool KFJIPBIDFFH()
        {
            return this.FMNEFKODEGJ;
        }

        public bool IHFEBPHIAEH()
        {
            return this.FMNEFKODEGJ;
        }




        public bool HOFPGMKOBBJ()
        {
            return this.FMNEFKODEGJ;
        }




        public bool FKNBPKDCDKB()
        {
            return this.FMNEFKODEGJ;
        }




        public bool AFIDILLKKAO()
        {
            return this.FMNEFKODEGJ;
        }










        private void Update()
        {
            if (this.ENBOKPHLADL == null)
            {
                return;
            }
            this.NAODANMLMEG(this.syncRigidbodyTransform);
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.UpdateTrans(this.syncRigidbodyTransform);
            }
        }

        public bool KNAHEEDLPFO()
        {
            return this.FMNEFKODEGJ;
        }

        private Transform JCGCLLMLCLH
        {
            get
            {
                if (this.KFJLBANCNCK == null)
                {
                    this.KFJLBANCNCK = base.transform;
                }
                return this.KFJLBANCNCK;
            }
        }

        public bool JJPBJKBINGH()
        {
            return this.FMNEFKODEGJ;
        }





        public bool syncRigidbodyTransform
        {
            get
            {
                return this.FMNEFKODEGJ;
            }
            set
            {
                this.FMNEFKODEGJ = value;
            }
        }

        public bool CANEIAAAADF()
        {
            return this.FMNEFKODEGJ;
        }












        public bool MMPEDAPFKFO()
        {
            return this.FMNEFKODEGJ;
        }







        private void FixedUpdate()
        {
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 0; i < childCount; i++)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            this.NAODANMLMEG(this.syncRigidbodyTransform);
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.UpdateTrans(this.syncRigidbodyTransform);
            }
        }





        public Transform partToFollow;

        private List<WeaponBoneTransform> ENBOKPHLADL;

        private Transform KFJLBANCNCK;

        private bool FMNEFKODEGJ = true;
    }
}