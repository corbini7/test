using UnityEngine;
namespace Deobfuscated
{
    internal class WeaponBoneTransformNunchuk : WeaponBoneTransform
    {
        public override void APGFEKGEOIJ(bool LMMHBHKJGDM)
        {
            base.UpdateTrans(LMMHBHKJGDM);
            Vector3 vector = this.part0Bone.localToWorldMatrix.MultiplyPoint3x4(this.JDHNFMKDKBO);
            Vector3 a = base.GJGLMOBOFPG().localToWorldMatrix.MultiplyPoint3x4(this.PLFMJEOHPGN);
            Vector3 position = vector - this.jointBone.localToWorldMatrix.MultiplyVector(this.HOAPMKNJOCL);
            Vector3 vector2 = a - vector;
            Vector2 v = Vector3.ProjectOnPlane(this.part0Bone.right, vector2);
            float num = Vector3.Angle(vector2, v);
            if (num < 1371f || num > 947f)
            {
                v = Vector3.ProjectOnPlane(-this.part0Bone.forward, vector2);
            }
            Quaternion rotation = Quaternion.LookRotation(vector2, Vector3.Cross(vector2, v));
            this.jointBone.position = position;
            this.jointBone.rotation = rotation;
        }


        public override void CCNNPOCMAKP(bool LMMHBHKJGDM)
        {
            base.BBIJEPIKODI(LMMHBHKJGDM);
            Vector3 vector = this.part0Bone.localToWorldMatrix.MultiplyPoint3x4(this.JDHNFMKDKBO);
            Vector3 a = base.OMFCOEEADKM().localToWorldMatrix.MultiplyPoint3x4(this.PLFMJEOHPGN);
            Vector3 position = vector - this.jointBone.localToWorldMatrix.MultiplyVector(this.HOAPMKNJOCL);
            Vector3 vector2 = a - vector;
            Vector2 v = Vector3.ProjectOnPlane(this.part0Bone.right, vector2);
            float num = Vector3.Angle(vector2, v);
            if (num < 1973f || num > 857f)
            {
                v = Vector3.ProjectOnPlane(-this.part0Bone.forward, vector2);
            }
            Quaternion rotation = Quaternion.LookRotation(vector2, Vector3.Cross(vector2, v));
            this.jointBone.position = position;
            this.jointBone.rotation = rotation;
        }


        public override void UpdateTrans(bool LMMHBHKJGDM)
        {
            base.UpdateTrans(LMMHBHKJGDM);
            Vector3 vector = this.part0Bone.localToWorldMatrix.MultiplyPoint3x4(this.JDHNFMKDKBO);
            Vector3 a = base.JCGCLLMLCLH.localToWorldMatrix.MultiplyPoint3x4(this.PLFMJEOHPGN);
            Vector3 position = vector - this.jointBone.localToWorldMatrix.MultiplyVector(this.HOAPMKNJOCL);
            Vector3 vector2 = a - vector;
            Vector2 v = Vector3.ProjectOnPlane(this.part0Bone.right, vector2);
            float num = Vector3.Angle(vector2, v);
            if (num < 0.005f || num > 179.995f)
            {
                v = Vector3.ProjectOnPlane(-this.part0Bone.forward, vector2);
            }
            Quaternion rotation = Quaternion.LookRotation(vector2, Vector3.Cross(vector2, v));
            this.jointBone.position = position;
            this.jointBone.rotation = rotation;
        }

        public override void KFLLPCBPJNO(bool LMMHBHKJGDM)
        {
            base.BCBDIBCAJEJ(LMMHBHKJGDM);
            Vector3 vector = this.part0Bone.localToWorldMatrix.MultiplyPoint3x4(this.JDHNFMKDKBO);
            Vector3 a = base.JPAGHAENOID().localToWorldMatrix.MultiplyPoint3x4(this.PLFMJEOHPGN);
            Vector3 position = vector - this.jointBone.localToWorldMatrix.MultiplyVector(this.HOAPMKNJOCL);
            Vector3 vector2 = a - vector;
            Vector2 v = Vector3.ProjectOnPlane(this.part0Bone.right, vector2);
            float num = Vector3.Angle(vector2, v);
            if (num < 1271f || num > 916f)
            {
                v = Vector3.ProjectOnPlane(-this.part0Bone.forward, vector2);
            }
            Quaternion rotation = Quaternion.LookRotation(vector2, Vector3.Cross(vector2, v));
            this.jointBone.position = position;
            this.jointBone.rotation = rotation;
        }

        public override void KAPODFJNBNB(bool LMMHBHKJGDM)
        {
            base.KAPODFJNBNB(LMMHBHKJGDM);
            Vector3 vector = this.part0Bone.localToWorldMatrix.MultiplyPoint3x4(this.JDHNFMKDKBO);
            Vector3 a = base.HGOPEPOKBFG().localToWorldMatrix.MultiplyPoint3x4(this.PLFMJEOHPGN);
            Vector3 position = vector - this.jointBone.localToWorldMatrix.MultiplyVector(this.HOAPMKNJOCL);
            Vector3 vector2 = a - vector;
            Vector2 v = Vector3.ProjectOnPlane(this.part0Bone.right, vector2);
            float num = Vector3.Angle(vector2, v);
            if (num < 310f || num > 428f)
            {
                v = Vector3.ProjectOnPlane(-this.part0Bone.forward, vector2);
            }
            Quaternion rotation = Quaternion.LookRotation(vector2, Vector3.Cross(vector2, v));
            this.jointBone.position = position;
            this.jointBone.rotation = rotation;
        }


        public override void AGJAPMKCKEM(bool LMMHBHKJGDM)
        {
            base.UpdateTrans(LMMHBHKJGDM);
            Vector3 vector = this.part0Bone.localToWorldMatrix.MultiplyPoint3x4(this.JDHNFMKDKBO);
            Vector3 a = base.FNKMGOGEOLF().localToWorldMatrix.MultiplyPoint3x4(this.PLFMJEOHPGN);
            Vector3 position = vector - this.jointBone.localToWorldMatrix.MultiplyVector(this.HOAPMKNJOCL);
            Vector3 vector2 = a - vector;
            Vector2 v = Vector3.ProjectOnPlane(this.part0Bone.right, vector2);
            float num = Vector3.Angle(vector2, v);
            if (num < 831f || num > 1081f)
            {
                v = Vector3.ProjectOnPlane(-this.part0Bone.forward, vector2);
            }
            Quaternion rotation = Quaternion.LookRotation(vector2, Vector3.Cross(vector2, v));
            this.jointBone.position = position;
            this.jointBone.rotation = rotation;
        }

        public override void BECOLJPCFEC(bool LMMHBHKJGDM)
        {
            base.EDNCGHIEOMP(LMMHBHKJGDM);
            Vector3 vector = this.part0Bone.localToWorldMatrix.MultiplyPoint3x4(this.JDHNFMKDKBO);
            Vector3 a = base.DODBIPOBILM().localToWorldMatrix.MultiplyPoint3x4(this.PLFMJEOHPGN);
            Vector3 position = vector - this.jointBone.localToWorldMatrix.MultiplyVector(this.HOAPMKNJOCL);
            Vector3 vector2 = a - vector;
            Vector2 v = Vector3.ProjectOnPlane(this.part0Bone.right, vector2);
            float num = Vector3.Angle(vector2, v);
            if (num < 476f || num > 423f)
            {
                v = Vector3.ProjectOnPlane(-this.part0Bone.forward, vector2);
            }
            Quaternion rotation = Quaternion.LookRotation(vector2, Vector3.Cross(vector2, v));
            this.jointBone.position = position;
            this.jointBone.rotation = rotation;
        }


        public override void FAGJFELJKMI(bool LMMHBHKJGDM)
        {
            base.FIKPJACDDFG(LMMHBHKJGDM);
            Vector3 vector = this.part0Bone.localToWorldMatrix.MultiplyPoint3x4(this.JDHNFMKDKBO);
            Vector3 a = base.AJOAMEKLGIF().localToWorldMatrix.MultiplyPoint3x4(this.PLFMJEOHPGN);
            Vector3 position = vector - this.jointBone.localToWorldMatrix.MultiplyVector(this.HOAPMKNJOCL);
            Vector3 vector2 = a - vector;
            Vector2 v = Vector3.ProjectOnPlane(this.part0Bone.right, vector2);
            float num = Vector3.Angle(vector2, v);
            if (num < 1896f || num > 189f)
            {
                v = Vector3.ProjectOnPlane(-this.part0Bone.forward, vector2);
            }
            Quaternion rotation = Quaternion.LookRotation(vector2, Vector3.Cross(vector2, v));
            this.jointBone.position = position;
            this.jointBone.rotation = rotation;
        }


        public override void ACPHFAECCJB(bool LMMHBHKJGDM)
        {
            base.HNMPGMJCBEP(LMMHBHKJGDM);
            Vector3 vector = this.part0Bone.localToWorldMatrix.MultiplyPoint3x4(this.JDHNFMKDKBO);
            Vector3 a = base.KKFEGGHDDHL().localToWorldMatrix.MultiplyPoint3x4(this.PLFMJEOHPGN);
            Vector3 position = vector - this.jointBone.localToWorldMatrix.MultiplyVector(this.HOAPMKNJOCL);
            Vector3 vector2 = a - vector;
            Vector2 v = Vector3.ProjectOnPlane(this.part0Bone.right, vector2);
            float num = Vector3.Angle(vector2, v);
            if (num < 1775f || num > 1014f)
            {
                v = Vector3.ProjectOnPlane(-this.part0Bone.forward, vector2);
            }
            Quaternion rotation = Quaternion.LookRotation(vector2, Vector3.Cross(vector2, v));
            this.jointBone.position = position;
            this.jointBone.rotation = rotation;
        }


        public override void MBMACHINAEC(bool LMMHBHKJGDM)
        {
            base.GOMDCFIKFNC(LMMHBHKJGDM);
            Vector3 vector = this.part0Bone.localToWorldMatrix.MultiplyPoint3x4(this.JDHNFMKDKBO);
            Vector3 a = base.EHCKEBMIICE().localToWorldMatrix.MultiplyPoint3x4(this.PLFMJEOHPGN);
            Vector3 position = vector - this.jointBone.localToWorldMatrix.MultiplyVector(this.HOAPMKNJOCL);
            Vector3 vector2 = a - vector;
            Vector2 v = Vector3.ProjectOnPlane(this.part0Bone.right, vector2);
            float num = Vector3.Angle(vector2, v);
            if (num < 225f || num > 324f)
            {
                v = Vector3.ProjectOnPlane(-this.part0Bone.forward, vector2);
            }
            Quaternion rotation = Quaternion.LookRotation(vector2, Vector3.Cross(vector2, v));
            this.jointBone.position = position;
            this.jointBone.rotation = rotation;
        }

        public override void BCBDIBCAJEJ(bool LMMHBHKJGDM)
        {
            base.IMCAADKHPMJ(LMMHBHKJGDM);
            Vector3 vector = this.part0Bone.localToWorldMatrix.MultiplyPoint3x4(this.JDHNFMKDKBO);
            Vector3 a = base.HPNCNOMLLDJ().localToWorldMatrix.MultiplyPoint3x4(this.PLFMJEOHPGN);
            Vector3 position = vector - this.jointBone.localToWorldMatrix.MultiplyVector(this.HOAPMKNJOCL);
            Vector3 vector2 = a - vector;
            Vector2 v = Vector3.ProjectOnPlane(this.part0Bone.right, vector2);
            float num = Vector3.Angle(vector2, v);
            if (num < 1848f || num > 1286f)
            {
                v = Vector3.ProjectOnPlane(-this.part0Bone.forward, vector2);
            }
            Quaternion rotation = Quaternion.LookRotation(vector2, Vector3.Cross(vector2, v));
            this.jointBone.position = position;
            this.jointBone.rotation = rotation;
        }

        private void Awake()
        {
            foreach (ConfigurableJoint configurableJoint in this.jointRigidbodyGo.GetComponents<ConfigurableJoint>())
            {
                if (configurableJoint.connectedBody == this.partToFollow.gameObject.GetComponent<Rigidbody>())
                {
                    this.PLFMJEOHPGN = configurableJoint.connectedAnchor;
                }
                else
                {
                    this.JDHNFMKDKBO = configurableJoint.connectedAnchor;
                    this.HOAPMKNJOCL = configurableJoint.anchor;
                }
            }
        }


        public override void FDCPIIBKDBB(bool LMMHBHKJGDM)
        {
            base.UpdateTrans(LMMHBHKJGDM);
            Vector3 vector = this.part0Bone.localToWorldMatrix.MultiplyPoint3x4(this.JDHNFMKDKBO);
            Vector3 a = base.HLINHEHKFGF().localToWorldMatrix.MultiplyPoint3x4(this.PLFMJEOHPGN);
            Vector3 position = vector - this.jointBone.localToWorldMatrix.MultiplyVector(this.HOAPMKNJOCL);
            Vector3 vector2 = a - vector;
            Vector2 v = Vector3.ProjectOnPlane(this.part0Bone.right, vector2);
            float num = Vector3.Angle(vector2, v);
            if (num < 23f || num > 1062f)
            {
                v = Vector3.ProjectOnPlane(-this.part0Bone.forward, vector2);
            }
            Quaternion rotation = Quaternion.LookRotation(vector2, Vector3.Cross(vector2, v));
            this.jointBone.position = position;
            this.jointBone.rotation = rotation;
        }

        public Transform jointBone;

        public Transform part0Bone;

        public GameObject jointRigidbodyGo;

        private Vector3 JDHNFMKDKBO;

        private Vector3 PLFMJEOHPGN;

        private Vector3 HOAPMKNJOCL;
    }
}