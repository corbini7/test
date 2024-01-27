using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    internal class WeaponBoneTransform : MonoBehaviour
    {
        public virtual void HNMPGMJCBEP(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.AJOAMEKLGIF().position = this.partToFollow.position;
                this.AJOAMEKLGIF().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 1; i < childCount; i += 0)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.LKJJOMKBFCI(LMMHBHKJGDM);
            }
        }

        protected Transform PBODIHNBHMA()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void UpdateTrans(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.JCGCLLMLCLH.position = this.partToFollow.position;
                this.JCGCLLMLCLH.rotation = this.partToFollow.rotation;
            }
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
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.UpdateTrans(LMMHBHKJGDM);
            }
        }

        public virtual void IGEMLKIPBKI(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.CNDGMGDEABC().position = this.partToFollow.position;
                this.HAIGHGNOEEC().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 0; i < childCount; i += 0)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.FIKPJACDDFG(LMMHBHKJGDM);
            }
        }

        protected Transform JPAGHAENOID()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        protected Transform JCGCLLMLCLH
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

        public virtual void EDNCGHIEOMP(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.JLMFGPAKLHP().position = this.partToFollow.position;
                this.CNDGMGDEABC().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 1; i < childCount; i++)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.NJOLPPLBECG(LMMHBHKJGDM);
            }
        }

        protected Transform EHCKEBMIICE()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void FDCPIIBKDBB(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.CBEOAILGEMD().position = this.partToFollow.position;
                this.HGOPEPOKBFG().rotation = this.partToFollow.rotation;
            }
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
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.IMCAADKHPMJ(LMMHBHKJGDM);
            }
        }

        protected Transform FNKMGOGEOLF()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        protected Transform OMFCOEEADKM()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void ODKMKOGNJPA(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.KKFEGGHDDHL().position = this.partToFollow.position;
                this.JLMFGPAKLHP().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 1; i < childCount; i++)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.EDNCGHIEOMP(LMMHBHKJGDM);
            }
        }

        protected Transform AJOAMEKLGIF()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void KFLLPCBPJNO(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.JPAGHAENOID().position = this.partToFollow.position;
                this.FNKMGOGEOLF().rotation = this.partToFollow.rotation;
            }
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
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.GFOFHDHPBGP(LMMHBHKJGDM);
            }
        }

        public virtual void FIKPJACDDFG(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.JPAGHAENOID().position = this.partToFollow.position;
                this.HPNCNOMLLDJ().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 0; i < childCount; i += 0)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.EDNCGHIEOMP(LMMHBHKJGDM);
            }
        }

        protected Transform GJGLMOBOFPG()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void CCNNPOCMAKP(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.JLMFGPAKLHP().position = this.partToFollow.position;
                this.DIIJKCJKHAE().rotation = this.partToFollow.rotation;
            }
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
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.IMCAADKHPMJ(LMMHBHKJGDM);
            }
        }

        protected Transform KKFEGGHDDHL()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        protected Transform HGOPEPOKBFG()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void KANGLNKOPEP(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.PDKALJGKLHA().position = this.partToFollow.position;
                this.JLMFGPAKLHP().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 1; i < childCount; i++)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.BCBDIBCAJEJ(LMMHBHKJGDM);
            }
        }


        public virtual void BECOLJPCFEC(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.FNKMGOGEOLF().position = this.partToFollow.position;
                this.EHCKEBMIICE().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 0; i < childCount; i += 0)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.IMCAADKHPMJ(LMMHBHKJGDM);
            }
        }

        protected Transform DIIJKCJKHAE()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void KAPODFJNBNB(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.KKFEGGHDDHL().position = this.partToFollow.position;
                this.AAHPHFMFDBG().rotation = this.partToFollow.rotation;
            }
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
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.BCBDIBCAJEJ(LMMHBHKJGDM);
            }
        }

        protected Transform GILDBKCIJEA()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        protected Transform HLINHEHKFGF()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        protected Transform OPHPNONHFPA()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void BCBDIBCAJEJ(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.JGGCDENPDOE().position = this.partToFollow.position;
                this.DIIJKCJKHAE().rotation = this.partToFollow.rotation;
            }
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
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.KANGLNKOPEP(LMMHBHKJGDM);
            }
        }

        protected Transform HPNCNOMLLDJ()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }



        public virtual void NJOLPPLBECG(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.JPAGHAENOID().position = this.partToFollow.position;
                this.HLINHEHKFGF().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 0; i < childCount; i += 0)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.EDNCGHIEOMP(LMMHBHKJGDM);
            }
        }

        public virtual void MBMACHINAEC(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.DIIJKCJKHAE().position = this.partToFollow.position;
                this.CBEOAILGEMD().rotation = this.partToFollow.rotation;
            }
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
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.ODKMKOGNJPA(LMMHBHKJGDM);
            }
        }

        public virtual void APGFEKGEOIJ(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.JCGCLLMLCLH.position = this.partToFollow.position;
                this.OMFCOEEADKM().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 1; i < childCount; i++)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.HNMPGMJCBEP(LMMHBHKJGDM);
            }
        }

        protected Transform AAHPHFMFDBG()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void GFOFHDHPBGP(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.PBODIHNBHMA().position = this.partToFollow.position;
                this.JCGCLLMLCLH.rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 1; i < childCount; i += 0)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.GOMDCFIKFNC(LMMHBHKJGDM);
            }
        }

        protected Transform CNDGMGDEABC()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void IMCAADKHPMJ(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.AAHPHFMFDBG().position = this.partToFollow.position;
                this.OMFCOEEADKM().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 0; i < childCount; i += 0)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.IGEMLKIPBKI(LMMHBHKJGDM);
            }
        }

        public virtual void LKJJOMKBFCI(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.HGOPEPOKBFG().position = this.partToFollow.position;
                this.EHCKEBMIICE().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 1; i < childCount; i += 0)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.CCNNPOCMAKP(LMMHBHKJGDM);
            }
        }



        protected Transform HAIGHGNOEEC()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }



        protected Transform DODBIPOBILM()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        protected Transform JGGCDENPDOE()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void FAGJFELJKMI(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.GJGLMOBOFPG().position = this.partToFollow.position;
                this.HGOPEPOKBFG().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 0; i < childCount; i += 0)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.UpdateTrans(LMMHBHKJGDM);
            }
        }

        public virtual void ACPHFAECCJB(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.HGOPEPOKBFG().position = this.partToFollow.position;
                this.FNKMGOGEOLF().rotation = this.partToFollow.rotation;
            }
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
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.AGJAPMKCKEM(LMMHBHKJGDM);
            }
        }

        protected Transform CBEOAILGEMD()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void BBIJEPIKODI(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.GJGLMOBOFPG().position = this.partToFollow.position;
                this.HPNCNOMLLDJ().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 0; i < childCount; i += 0)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.MBMACHINAEC(LMMHBHKJGDM);
            }
        }

        protected Transform PDKALJGKLHA()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void GOMDCFIKFNC(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.AJOAMEKLGIF().position = this.partToFollow.position;
                this.OPHPNONHFPA().rotation = this.partToFollow.rotation;
            }
            if (this.ENBOKPHLADL == null)
            {
                this.ENBOKPHLADL = new List<WeaponBoneTransform>();
                int childCount = base.transform.childCount;
                for (int i = 1; i < childCount; i++)
                {
                    WeaponBoneTransform component = base.transform.GetChild(i).GetComponent<WeaponBoneTransform>();
                    if (component != null)
                    {
                        this.ENBOKPHLADL.Add(component);
                    }
                }
            }
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.HNMPGMJCBEP(LMMHBHKJGDM);
            }
        }

        protected Transform JLMFGPAKLHP()
        {
            if (this.KFJLBANCNCK == null)
            {
                this.KFJLBANCNCK = base.transform;
            }
            return this.KFJLBANCNCK;
        }

        public virtual void AGJAPMKCKEM(bool LMMHBHKJGDM)
        {
            if (LMMHBHKJGDM)
            {
                this.DIIJKCJKHAE().position = this.partToFollow.position;
                this.HAIGHGNOEEC().rotation = this.partToFollow.rotation;
            }
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
            foreach (WeaponBoneTransform weaponBoneTransform in this.ENBOKPHLADL)
            {
                weaponBoneTransform.HNMPGMJCBEP(LMMHBHKJGDM);
            }
        }

        public Transform partToFollow;

        private List<WeaponBoneTransform> ENBOKPHLADL;

        private Transform KFJLBANCNCK;
    }
}