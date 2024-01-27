using System;
using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    public class TopBoneTransform : MonoBehaviour
    {







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


















        private void FixedUpdate()
        {
            if (this.HHDBPPNPJLG == null)
            {
                this.HHDBPPNPJLG = new List<BonesTransforms>();
                int childCount = base.transform.childCount;
                for (int i = 0; i < childCount; i++)
                {
                    BonesTransforms component = base.transform.GetChild(i).GetComponent<BonesTransforms>();
                    if (component != null)
                    {
                        this.HHDBPPNPJLG.Add(component);
                    }
                }
            }
            foreach (BonesTransforms bonesTransforms in this.HHDBPPNPJLG)
            {
                bonesTransforms.UpdateTrans(this.syncRigidbodyTransform);
            }
        }








        private List<BonesTransforms> HHDBPPNPJLG;

        private bool FMNEFKODEGJ = true;
    }
}