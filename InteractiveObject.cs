using UnityEngine;
namespace Deobfuscated
{
    public class InteractiveObject : MonoBehaviour
    {




        public virtual void HitBy(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
        }





        public virtual void UngrabBy(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
        }

        public virtual void OECKCIOIPMH(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
        }


        internal void JFBIAIILOPE(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
            this.HLDOOGCEOMB().OECKCIOIPMH(FIEIKODBHOP, ODHNPNCFGPA);
        }

        internal void GJPHEIJFPMK(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
            this.HLDOOGCEOMB().DEIGJBPPLBP(FIEIKODBHOP, ODHNPNCFGPA);
        }




        internal void FMIABHHKAOD(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
            this.RootObject.UngrabBy(FIEIKODBHOP, ODHNPNCFGPA);
        }

        public virtual void Awake()
        {
            PGNNPNAAFLP.EFAJMCPOLOE.Add(base.gameObject, this);
            Transform parent = base.transform.parent;
            if (parent != null)
            {
                if (PGNNPNAAFLP.EFAJMCPOLOE.ContainsKey(parent.gameObject))
                {
                    this.RootObject = PGNNPNAAFLP.EFAJMCPOLOE[parent.gameObject].RootObject;
                }
                else
                {
                    this.RootObject = this;
                }
            }
            else
            {
                this.RootObject = this;
            }
            for (int i = 0; i < base.transform.childCount; i++)
            {
                base.transform.GetChild(i).gameObject.AddComponent<InteractiveObject>();
            }
        }

        internal void NIBBJHNPHPE(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
            this.RootObject.LBDEALOCOFN(FIEIKODBHOP, ODHNPNCFGPA);
        }

        public virtual void DEIGJBPPLBP(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
        }





        internal void DNAFBBMDEJK(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
            this.RootObject.GrabBy(FIEIKODBHOP, ODHNPNCFGPA);
        }



        internal void NFICMGIMHOK(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
            this.RootObject.DEIGJBPPLBP(FIEIKODBHOP, ODHNPNCFGPA);
        }

        public virtual void LBDEALOCOFN(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
        }




        public InteractiveObject HLDOOGCEOMB()
        {
            return this;//.< PHJJOLDOIFO > k__BackingField;
        }





        public virtual void OnDestroy()
        {
            PGNNPNAAFLP.EFAJMCPOLOE.Remove(base.gameObject);
        }



        public InteractiveObject RootObject { get; set; }

        internal void JACHNHEPJJG(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
            this.RootObject.LBDEALOCOFN(FIEIKODBHOP, ODHNPNCFGPA);
        }



        public virtual void GrabBy(GameObject FIEIKODBHOP, InteractiveObject.Side ODHNPNCFGPA)
        {
        }




        public enum Side
        {
            LeftHand,
            RightHand
        }
    }
}