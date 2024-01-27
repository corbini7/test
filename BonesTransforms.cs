using System.Collections.Generic;
using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    internal class BonesTransforms : MonoBehaviour
    {
        public GameObject PartToFollow;

        protected Vector3 relativePositionOffset;

        protected Quaternion relativeRotationOffset;

        private List<BonesTransforms> childBonesTransforms;

        private Transform cachedTransform;

        private Transform CachedTransform
        {
            get
            {
                if (this.cachedTransform == null)
                {
                    this.cachedTransform = base.transform;
                }
                return this.cachedTransform;
            }
        }


        protected virtual void Awake()
        {
            this.relativePositionOffset = this.PartToFollow.transform.worldToLocalMatrix.MultiplyPoint3x4(base.transform.position);
            this.relativeRotationOffset = Quaternion.Inverse(this.PartToFollow.transform.rotation) * base.transform.rotation;
        }

        public virtual void UpdateTrans(bool GEFIPEMHHMF)
        {
            if (GEFIPEMHHMF)
            {
                this.CachedTransform.position = this.PartToFollow.transform.localToWorldMatrix.MultiplyPoint3x4(this.relativePositionOffset);
                this.CachedTransform.rotation = this.PartToFollow.transform.rotation * this.relativeRotationOffset;
            }
            if (this.childBonesTransforms == null)
            {
                this.childBonesTransforms = new List<BonesTransforms>();
                int childCount = base.transform.childCount;
                for (int i = 0; i < childCount; i++)
                {
                    BonesTransforms component = base.transform.GetChild(i).GetComponent<BonesTransforms>();
                    if (component != null)
                    {
                        this.childBonesTransforms.Add(component);
                    }
                }
            }
            foreach (BonesTransforms bonesTransforms in this.childBonesTransforms)
            {
                bonesTransforms.UpdateTrans(GEFIPEMHHMF);
            }
        }
    }
}