using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    public class WeaponPlunger : WeaponMelee
    {
        private IEnumerator JKPMCJGNICJ()
        {
            Transform transform = null;
            Transform transform2 = null;
            if (base.Owner != null)
            {
                transform = this.IEDNGFIDBBL.GreenChest.transform;
            }
            float num = 1.1f;
            while (num > 0f && base.Owner != null && !base.IsAttacking && !this.isAttachedToSth)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    Vector3 normalized;
                    if (transform2 != null)
                    {
                        if (Vector3.Distance(transform2.position, transform.position) >= 2.5f)
                        {
                            transform2 = null;
                            if (this.BNAIODFPIBA(transform.position + transform.up * -0.5f, this.IEDNGFIDBBL.FacingDirection, out transform2))
                            {
                                normalized = (transform2.position - base.JCGCLLMLCLH.position).normalized;
                            }
                            else
                            {
                                normalized = (Vector3.ProjectOnPlane(this.IEDNGFIDBBL.FacingDirection, Vector3.up) + Vector3.up * 0.2f).normalized;
                            }
                        }
                        else
                        {
                            normalized = (transform2.position - base.JCGCLLMLCLH.position).normalized;
                        }
                    }
                    else if (this.BNAIODFPIBA(transform.position + transform.up * -0.5f, this.IEDNGFIDBBL.FacingDirection, out transform2))
                    {
                        normalized = (transform2.position - base.JCGCLLMLCLH.position).normalized;
                    }
                    else
                    {
                        normalized = (Vector3.ProjectOnPlane(this.IEDNGFIDBBL.FacingDirection, Vector3.up) + Vector3.up * 0.2f).normalized;
                    }
                    this.FBHOANFFGGK(normalized);
                }
                yield return this.MJOFAKABBGM;
            }
            Quaternion a = Quaternion.identity;
            if (base.Owner != null && !base.IsAttacking && !this.isAttachedToSth)
            {
                this.HHIPJDMCDMF.positionSpring = 200f;
                this.HHIPJDMCDMF.positionDamper = 1f;
                this.DDOHGJPCFNF.KOFJBKAKBNL.angularXDrive = this.HHIPJDMCDMF;
                this.DDOHGJPCFNF.KOFJBKAKBNL.angularYZDrive = this.HHIPJDMCDMF;
                Quaternion rhs = base.JCGCLLMLCLH.rotation * Quaternion.Inverse(this.ELDFLIBCGCG);
                a = Quaternion.Inverse(this.IEDNGFIDBBL.GreenFistR.transform.rotation) * rhs;
            }
            float num2 = 0.35f;
            num = num2;
            while (num > 0f && base.Owner != null && !base.IsAttacking && !this.isAttachedToSth)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    float t = 1f - num / num2;
                    this.DDOHGJPCFNF.KOFJBKAKBNL.targetRotation = Quaternion.Slerp(a, this.KGNJGIEKHEB, t);
                }
                yield return this.MJOFAKABBGM;
            }
            int num3 = 1;
            while (num3 > 0 && base.Owner != null && !base.IsAttacking && !this.isAttachedToSth)
            {
                num3--;
                this.DDOHGJPCFNF.KOFJBKAKBNL.targetRotation = this.KGNJGIEKHEB;
                yield return this.MJOFAKABBGM;
            }
            yield break;
        }

        private void DGMFPGPMLHI()
        {
            int num = Physics.OverlapSphereNonAlloc(this.detectPos.position, 0.08f, this.FFCGJOHLBKC, 256);
            Vector3 up = base.JCGCLLMLCLH.up;
            Vector3 position = base.JCGCLLMLCLH.position;
            for (int i = 0; i < num; i++)
            {
                GameObject gameObject = this.FFCGJOHLBKC[i].gameObject;
                if (PccManager.rigidbodyCharacterControllerMap[gameObject] != this.IEDNGFIDBBL)
                {
                    string name = gameObject.name;
                    if (name == "GreenWaist" || name == "GreenChest" || name == "GreenHead" || name == "GreenHip")
                    {
                        Ray ray = new Ray(position, up);
                        Collider collider = this.FFCGJOHLBKC[i];
                        if (collider.Raycast(ray, out this.IPDDKMOODLB, 5f) && Vector3.Angle(-this.IPDDKMOODLB.normal, up) < 50f)
                        {
                            Rigidbody attachedRigidbody = collider.attachedRigidbody;
                            this.BJJNMENLFMD(attachedRigidbody, gameObject.transform.InverseTransformPoint(this.IPDDKMOODLB.point));
                            base.StartCoroutine(this.OMFFKDNOEFC());
                            this.JHJHBDAKOKO = PccManager.rigidbodyCharacterControllerMap[gameObject];
                            this.OEPDLFGGKLD();
                            return;
                        }
                    }
                }
            }
        }

        internal override float FBJDPKDEJNP
        {
            get
            {
                return this.OHHJPIDOCOD;
            }
        }


        private ConfigurableJoint INHPJJKNOAE
        {
            get
            {
                return this.OLNNBDCBHCJ;
            }
            set
            {
                if (value != this.OLNNBDCBHCJ)
                {
                    if (value != null)
                    {
                        this.isAttachedToSth = true;
                    }
                    else
                    {
                        this.isAttachedToSth = false;
                    }
                    this.OLNNBDCBHCJ = value;
                }
            }
        }


        internal override void GDENHBKDDGO()
        {
            base.GDENHBKDDGO();
            if (this.DDOHGJPCFNF != null)
            {
                this.DDOHGJPCFNF.OnDestroy();
            }
        }

        public bool isAttachedToSth { get; private set; }


        private void ANLKLODPIGE()
        {
            foreach (Collider collider in this.NOOFBDHGCJI)
            {
                PhysicMaterial sharedMaterial = collider.sharedMaterial;
                sharedMaterial.dynamicFriction = 0.3f;
                sharedMaterial.staticFriction = 0.3f;
            }
        }

        private void BMHHDPFBMCH(ConfigurableJoint DEIMKLMOEKJ, JointDrive OOOABHLNKLE, Quaternion POCKJJPHIJF)
        {
            DEIMKLMOEKJ.angularXDrive = OOOABHLNKLE;
            DEIMKLMOEKJ.angularYZDrive = OOOABHLNKLE;
            DEIMKLMOEKJ.targetRotation = POCKJJPHIJF;
        }

        private void DEJMOJPEINL()
        {
            foreach (Collider collider in this.NOOFBDHGCJI)
            {
                PhysicMaterial sharedMaterial = collider.sharedMaterial;
                sharedMaterial.dynamicFriction = 0.6f;
                sharedMaterial.staticFriction = 0.6f;
            }
        }

        internal override void DMJOIPHGHEB(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
            if (this.LKOIGOGJDGG)
            {
                this.BMHHDPFBMCH(MCFOLNMFCPN.GDPPIFIJPMF, this.DFPPLFCNLKA, this.NLHJIPDINBC);
                this.BMHHDPFBMCH(MCFOLNMFCPN.BBMLJFHODAL, this.KNALMMLKGKD, this.AHLLJNLFCFP);
                return;
            }
            if (PKGLIMPDIIP)
            {
                if ((BNLPAPMFDLL < 0.3f && !DOLMJFFJFBH) || (BNLPAPMFDLL < 0.15f && DOLMJFFJFBH))
                {
                    this.BMHHDPFBMCH(MCFOLNMFCPN.GDPPIFIJPMF, this.BIEMKFMCKIK, this.PELEICHHALC);
                    this.BMHHDPFBMCH(MCFOLNMFCPN.BBMLJFHODAL, this.FOAFEJJLLOD, this.ECIMPFANDPP);
                    return;
                }
                float num = (Mathf.Sin(AGCJDIFCAKA + 0.5f) + 1f) * 0.5f;
                if (GHMBNLHGMHG)
                {
                    num = -num + 1f;
                }
                Quaternion pockjjphijf = Quaternion.Slerp(this.PNDFCBCNNKB, this.LNCCGKJDALM, num);
                Quaternion pockjjphijf2 = Quaternion.Slerp(this.LKAOACEIJKP, this.KMDNGHCOIDC, num);
                if (DOLMJFFJFBH)
                {
                    this.BMHHDPFBMCH(MCFOLNMFCPN.GDPPIFIJPMF, this.IEHMKECLCHB, pockjjphijf);
                    this.BMHHDPFBMCH(MCFOLNMFCPN.BBMLJFHODAL, this.HMOLGLHMABM, pockjjphijf2);
                    return;
                }
                this.BMHHDPFBMCH(MCFOLNMFCPN.GDPPIFIJPMF, this.LONEFNPNIIM, pockjjphijf);
                this.BMHHDPFBMCH(MCFOLNMFCPN.BBMLJFHODAL, this.IMIKGCOGHMH, pockjjphijf2);
                return;
            }
            else
            {
                if (DPKCPMHPAAJ < 0.8f)
                {
                    this.BMHHDPFBMCH(MCFOLNMFCPN.GDPPIFIJPMF, this.KGHNAIMAMAL, this.MAKLLFFDJBD);
                    this.BMHHDPFBMCH(MCFOLNMFCPN.BBMLJFHODAL, this.EIDOLGBABMO, this.KIKEBPPDADI);
                    return;
                }
                if (AGCJDIFCAKA <= 0f)
                {
                    this.BMHHDPFBMCH(MCFOLNMFCPN.GDPPIFIJPMF, this.KGHNAIMAMAL, this.PELEICHHALC);
                    this.BMHHDPFBMCH(MCFOLNMFCPN.BBMLJFHODAL, this.EIDOLGBABMO, this.ECIMPFANDPP);
                    return;
                }
                float f;
                if (GHMBNLHGMHG)
                {
                    f = -AGCJDIFCAKA - 1.5707964f - 2.15f;
                }
                else
                {
                    f = -AGCJDIFCAKA + 1.5707964f - 2.15f;
                }
                Vector3 zero = Vector3.zero;
                zero.x = Mathf.Sin(f) * 85f;
                zero.y = Mathf.Cos(f) * 85f;
                this.BMHHDPFBMCH(MCFOLNMFCPN.GDPPIFIJPMF, this.AOCCMBICIEG, Quaternion.Euler(zero));
                this.BMHHDPFBMCH(MCFOLNMFCPN.BBMLJFHODAL, this.DIDCGKAFLOI, this.ECIMPFANDPP);
                return;
            }
        }


        private IEnumerator OMFFKDNOEFC()
        {
            float num = 0f;
            while (this.isAttachedToSth && num < this.attachDuration)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num += Time.fixedDeltaTime;
                    if (this.INHPJJKNOAE.currentForce.sqrMagnitude > 2.5E+09f)
                    {
                        this.GHDKNCAPPIN();
                    }
                }
                yield return this.MJOFAKABBGM;
            }
            num = 0f;
            while (this.isAttachedToSth)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num += Time.fixedDeltaTime;
                    float num2 = Mathf.Max(14000f - num * 300f, 0f);
                    if (this.INHPJJKNOAE.currentForce.sqrMagnitude > num2 * num2)
                    {
                        this.GHDKNCAPPIN();
                    }
                }
                yield return this.MJOFAKABBGM;
            }
            yield break;
        }



        internal override void GHGLMNMONHK(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, bool DOLMJFFJFBH, bool PKGLIMPDIIP)
        {
            if (this.LKOIGOGJDGG)
            {
                MCFOLNMFCPN.AJBEMNONLMC.targetRotation = this.KGHHLDAHKJH;
                return;
            }
            MCFOLNMFCPN.AJBEMNONLMC.targetRotation = this.INBCNJNLOIB;
        }


        private PhysicCharacterController JHJHBDAKOKO
        {
            get
            {
                return this.CPJFKHBNFBN;
            }
            set
            {
                if (value != this.CPJFKHBNFBN)
                {
                    if (value != null)
                    {
                        value.MCLLMKNDGMA.Add(this);
                    }
                    else if (this.CPJFKHBNFBN != null)
                    {
                        this.CPJFKHBNFBN.MCLLMKNDGMA.Remove(this);
                    }
                    this.CPJFKHBNFBN = value;
                }
            }
        }


        internal override void HPMGJPMEFED(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
            if (this.LKOIGOGJDGG)
            {
                this.BMHHDPFBMCH(MCFOLNMFCPN.AKFKHFBDPBI, this.NNBDMMHAIPO, this.IMLKFAOMBED);
                this.BMHHDPFBMCH(MCFOLNMFCPN.GIGHLANHALH, this.DMFJODOLBAM, this.DIJCCKNLFHG);
                return;
            }
            if (PKGLIMPDIIP)
            {
                if ((BNLPAPMFDLL < 0.3f && !DOLMJFFJFBH) || (BNLPAPMFDLL < 0.15f && DOLMJFFJFBH))
                {
                    this.BMHHDPFBMCH(MCFOLNMFCPN.AKFKHFBDPBI, this.OJIPDAGFBPC, this.CBEFGDJCCNC);
                    this.BMHHDPFBMCH(MCFOLNMFCPN.GIGHLANHALH, this.ICLFAJOONAM, this.NKBNHINDAIE);
                    return;
                }
                float num = (Mathf.Sin(AGCJDIFCAKA + 3.14159f + 0.5f) + 1f) * 0.5f;
                if (GHMBNLHGMHG)
                {
                    num = -num + 1f;
                }
                Quaternion pockjjphijf = Quaternion.Slerp(this.GKOAAPJNHKG, this.ALEHILLCEIM, num);
                Quaternion pockjjphijf2 = Quaternion.Slerp(this.KDCJLFPGMNL, this.FMEKMHFADIP, num);
                if (DOLMJFFJFBH)
                {
                    this.BMHHDPFBMCH(MCFOLNMFCPN.AKFKHFBDPBI, this.LJIFNFPEFPN, pockjjphijf);
                    this.BMHHDPFBMCH(MCFOLNMFCPN.GIGHLANHALH, this.BFJFJGCFGAE, pockjjphijf2);
                    return;
                }
                this.BMHHDPFBMCH(MCFOLNMFCPN.AKFKHFBDPBI, this.PNPFJAODMMN, pockjjphijf);
                this.BMHHDPFBMCH(MCFOLNMFCPN.GIGHLANHALH, this.LGGLCGFHLDB, pockjjphijf2);
                return;
            }
            else
            {
                if (DPKCPMHPAAJ < 0.8f)
                {
                    this.BMHHDPFBMCH(MCFOLNMFCPN.AKFKHFBDPBI, this.LIBMABDFJBO, this.CAKGDLJNPFK);
                    this.BMHHDPFBMCH(MCFOLNMFCPN.GIGHLANHALH, this.EBCNAINPJFB, this.JCDAGNIALPB);
                    return;
                }
                if (AGCJDIFCAKA <= 0f)
                {
                    this.BMHHDPFBMCH(MCFOLNMFCPN.AKFKHFBDPBI, this.LIBMABDFJBO, this.CBEFGDJCCNC);
                    this.BMHHDPFBMCH(MCFOLNMFCPN.GIGHLANHALH, this.EBCNAINPJFB, this.NKBNHINDAIE);
                    return;
                }
                float f;
                if (GHMBNLHGMHG)
                {
                    f = -AGCJDIFCAKA + 1.5707964f + 4.05f;
                }
                else
                {
                    f = -AGCJDIFCAKA - 1.5707964f + 4.05f;
                }
                Vector3 zero = Vector3.zero;
                zero.x = Mathf.Sin(f) * 85f;
                zero.y = Mathf.Cos(f) * 85f;
                this.BMHHDPFBMCH(MCFOLNMFCPN.AKFKHFBDPBI, this.OPEFEAAAPGF, Quaternion.Euler(zero));
                this.BMHHDPFBMCH(MCFOLNMFCPN.GIGHLANHALH, this.IMBFPOEPGEB, this.NKBNHINDAIE);
                return;
            }
        }



        protected override void Awake()
        {
            PhysicMaterial material = new PhysicMaterial
            {
                dynamicFriction = 0.6f,
                staticFriction = 0.6f,
                bounciness = 0.1f,
                bounceCombine = PhysicMaterialCombine.Minimum
            };
            foreach (Collider item in base.GetComponents<Collider>())
            {
                this.NOOFBDHGCJI.Add(item);
            }
            foreach (Collider collider in this.NOOFBDHGCJI)
            {
                collider.material = material;
            }
            this.CHAKCFPODPO = this.myCapsuleCollider.center;
            this.HODNIDCHBIL = this.myCapsuleCollider.height;
            base.Awake();
        }

        internal override void DPMCHIFEGKO(PhysicCharacterController MCFOLNMFCPN, ref bool OGMMABHJCNI)
        {
            if (!MCFOLNMFCPN.WeaponGrabbed)
            {
                if (base.Owner != null && base.Owner != MCFOLNMFCPN.gameObject)
                {
                    MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                    OGMMABHJCNI = false;
                    return;
                }
                if (MCFOLNMFCPN.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon && MCFOLNMFCPN.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon)
                {
                    MCFOLNMFCPN.WeaponGrabbed = true;
                    MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                    return;
                }
                this.LIFGGMBLIBC = 0.2f;
                Transform transform = MCFOLNMFCPN.GreenFistR.transform;
                Vector3 vector = transform.position + transform.forward * 0.1f;
                if (this.DDOHGJPCFNF == null)
                {
                    if (Vector3.Distance(this.grabPositions[0].position, MCFOLNMFCPN.GreenHip.transform.position) > 1.2f)
                    {
                        MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                        OGMMABHJCNI = false;
                        return;
                    }
                    ConfigurableJoint configurableJoint = MCFOLNMFCPN.NLEHLJPKLCH;
                    configurableJoint.angularXDrive = this.BCGMNMJFMLD;
                    configurableJoint.angularYZDrive = this.BCGMNMJFMLD;
                    CFOGGNCCHCO.EFNEGHJPJFN(MCFOLNMFCPN.FIIKBADHOJH, -MCFOLNMFCPN.GreenChest.transform.up * 50f, ForceMode.Acceleration);
                    MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = true;
                    Vector3 a = this.grabPositions[0].position - vector;
                    CFOGGNCCHCO.IPIGMALBAKG(MCFOLNMFCPN.PIMHHNKOCBE, Vector3.ClampMagnitude(a * 200f, 8f));
                    if (Vector3.Distance(vector, this.grabPositions[0].position) < 0.08f)
                    {
                        this.PILHFCLPOEN(MCFOLNMFCPN.GreenFistR, Vector3.forward * 0.15f + Vector3.right * -0.07f, this.grabPositions[0].localPosition);
                        MCFOLNMFCPN.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon;
                        MCFOLNMFCPN.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon;
                        MCFOLNMFCPN.grabbedWeaponGo = base.gameObject;
                        this.GCAPLNOJOFM(MCFOLNMFCPN.gameObject);
                        base.weaponIsEquipped = true;
                        MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                    }
                }
            }
        }

        internal override void GIKCPEIMJFO()
        {
            base.GIKCPEIMJFO();
            this.IJKKFNGAHFG();
            this.DEJMOJPEINL();
        }

        private void OEPDLFGGKLD()
        {
            this.myBoxCollider.isTrigger = true;
        }

        private bool BNAIODFPIBA(Vector3 BHPOOGHFDFA, Vector3 BKBJDBJKBGK, out Transform LBHPIDINCLO)
        {
            this.HBKMECLJMPC.Clear();
            Rigidbody rigidbody = null;
            bool flag = false;
            int num = Physics.SphereCastNonAlloc(BHPOOGHFDFA, 2f, BKBJDBJKBGK, this.MJGHGJDNKFP, 3.5f, 256);
            if (num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    GameObject gameObject = this.MJGHGJDNKFP[i].collider.gameObject;
                    if (PccManager.rigidbodyCharacterControllerMap.ContainsKey(gameObject))
                    {
                        PhysicCharacterController physicCharacterController = PccManager.rigidbodyCharacterControllerMap[gameObject];
                        if (physicCharacterController != this.IEDNGFIDBBL)
                        {
                            this.HBKMECLJMPC.Add(physicCharacterController.FIIKBADHOJH);
                        }
                    }
                }
                float num2 = 9999f;
                Vector3 position = this.IEDNGFIDBBL.FIIKBADHOJH.transform.position;
                foreach (Rigidbody rigidbody2 in this.HBKMECLJMPC)
                {
                    float num3 = Vector3.Distance(rigidbody2.position, position);
                    if (num3 < num2 && Vector3.Angle(rigidbody2.position - position, BKBJDBJKBGK) <= 50f)
                    {
                        flag = true;
                        num2 = num3;
                        rigidbody = rigidbody2;
                    }
                }
            }
            if (flag)
            {
                LBHPIDINCLO = rigidbody.transform;
                return true;
            }
            LBHPIDINCLO = null;
            return false;
        }

        internal override void FCPOCNFEKCJ(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG)
        {
            if (this.LKOIGOGJDGG)
            {
                this.BMHHDPFBMCH(MCFOLNMFCPN.NLEHLJPKLCH, this.LNCEKEKPIIK, this.OGNIDODGHNE);
                this.BMHHDPFBMCH(MCFOLNMFCPN.CDBGCHHHPFL, this.MKGGMEENJKD, this.MDIGAEGPEMC);
                return;
            }
            if (BNLPAPMFDLL < 0.3f && !DOLMJFFJFBH)
            {
                return;
            }
            float num = Mathf.Sin(AGCJDIFCAKA - 1.5708f + 0.5f);
            if (GHMBNLHGMHG)
            {
                num = -num;
            }
            if (!DOLMJFFJFBH)
            {
                MCFOLNMFCPN.FIIKBADHOJH.AddTorque(-num * 8500f * MCFOLNMFCPN.GreenChest.transform.forward, ForceMode.Acceleration);
                MCFOLNMFCPN.PNGENFLDJAG.AddTorque(-num * -1100f * 1.65f * MCFOLNMFCPN.GreenHip.transform.forward, ForceMode.Acceleration);
                return;
            }
            MCFOLNMFCPN.FIIKBADHOJH.AddTorque(-num * 1200f * 20f * MCFOLNMFCPN.GreenChest.transform.forward, ForceMode.Acceleration);
            MCFOLNMFCPN.PNGENFLDJAG.AddTorque(-num * 100f * 1.65f * MCFOLNMFCPN.GreenHip.transform.forward, ForceMode.Acceleration);
        }

        internal override void AGIKMKKNICC()
        {
            this.weaponController.JGBLPPKMAMA();
            if (!this.isAttachedToSth)
            {
                base.StartCoroutine(this.AGGCPCLOKFP());
                return;
            }
            base.StartCoroutine(this.MHGDNMAOOFD());
        }

        private IEnumerator MHGDNMAOOFD()
        {
            yield return this.MJOFAKABBGM;
            yield break;
        }

        private IEnumerator LKFNPFBMFKP()
        {
            while (this.HHIPJDMCDMF.positionSpring < 200f && this.DDOHGJPCFNF != null && !this.isAttachedToSth && !base.IsAttacking)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    this.HHIPJDMCDMF.positionSpring = this.HHIPJDMCDMF.positionSpring + Time.fixedDeltaTime * 200f;
                    this.DDOHGJPCFNF.KOFJBKAKBNL.angularXDrive = this.HHIPJDMCDMF;
                    this.DDOHGJPCFNF.KOFJBKAKBNL.angularYZDrive = this.HHIPJDMCDMF;
                }
                yield return this.MJOFAKABBGM;
            }
            yield break;
        }



        private void GIMLHCAFDDG()
        {
            this.myCapsuleCollider.center = this.FDPMNFGEMLN;
            this.myCapsuleCollider.height = 0.6341f;
        }

        private IEnumerator AGGCPCLOKFP()
        {
            base.IsAttacking = true;
            this.LKOIGOGJDGG = true;
            this.ECPGAOFDCKC = true;
            base.LGLOPGKONLO.maxAngularVelocity = 80f;
            base.LGLOPGKONLO.mass = 1.4f;
            Quaternion targetRotation = this.IEDNGFIDBBL.AJBEMNONLMC.targetRotation;
            Quaternion targetRotation2 = this.IEDNGFIDBBL.NLEHLJPKLCH.targetRotation;
            Quaternion targetRotation3 = this.IEDNGFIDBBL.CDBGCHHHPFL.targetRotation;
            Quaternion targetRotation4 = this.IEDNGFIDBBL.AKFKHFBDPBI.targetRotation;
            Quaternion targetRotation5 = this.IEDNGFIDBBL.GIGHLANHALH.targetRotation;
            Quaternion targetRotation6 = this.IEDNGFIDBBL.GDPPIFIJPMF.targetRotation;
            Quaternion targetRotation7 = this.IEDNGFIDBBL.BBMLJFHODAL.targetRotation;
            Transform transform = this.IEDNGFIDBBL.GreenChest.transform;
            Transform transform2;
            this.BNAIODFPIBA(transform.position + transform.up * -0.5f, this.IEDNGFIDBBL.FacingDirection, out transform2);
            float num = 0.2f;
            float num2 = num;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                    float t = 1f - num2 / num;
                    this.KGHHLDAHKJH = Quaternion.Slerp(targetRotation, this.JOGHPHCKEMF, t);
                    this.OGNIDODGHNE = Quaternion.Slerp(targetRotation2, this.KHHNNGCFBDJ, t);
                    this.MDIGAEGPEMC = Quaternion.Slerp(targetRotation3, this.BINJPIABDNJ, t);
                    this.IMLKFAOMBED = Quaternion.Slerp(targetRotation4, this.ENAJILKDEJC, t);
                    this.DIJCCKNLFHG = Quaternion.Slerp(targetRotation5, this.JFKFOPKAODH, t);
                    this.NLHJIPDINBC = Quaternion.Slerp(targetRotation6, this.FCAKNGCNFON, t);
                    this.AHLLJNLFCFP = Quaternion.Slerp(targetRotation7, this.NGDPMCHJLIB, t);
                    this.OHHJPIDOCOD = Mathf.Lerp(0f, 30f, t);
                    Vector3 normalized;
                    if (transform2 != null)
                    {
                        if (Vector3.Distance(transform2.position, transform.position) >= 2.5f)
                        {
                            transform2 = null;
                            if (this.BNAIODFPIBA(transform.position + transform.up * -0.5f, this.IEDNGFIDBBL.FacingDirection, out transform2))
                            {
                                normalized = (transform2.position - base.JCGCLLMLCLH.position).normalized;
                            }
                            else
                            {
                                normalized = (Vector3.ProjectOnPlane(this.IEDNGFIDBBL.FacingDirection, Vector3.up) + Vector3.up * 0.2f).normalized;
                            }
                        }
                        else
                        {
                            normalized = (transform2.position - base.JCGCLLMLCLH.position).normalized;
                        }
                    }
                    else if (this.BNAIODFPIBA(transform.position + transform.up * -0.5f, this.IEDNGFIDBBL.FacingDirection, out transform2))
                    {
                        normalized = (transform2.position - base.JCGCLLMLCLH.position).normalized;
                    }
                    else
                    {
                        normalized = (Vector3.ProjectOnPlane(this.IEDNGFIDBBL.FacingDirection, Vector3.up) + Vector3.up * 0.2f).normalized;
                    }
                    this.FBHOANFFGGK(normalized);
                    base.LGLOPGKONLO.AddForce(-base.JCGCLLMLCLH.up * 350f, ForceMode.Force);
                }
                yield return this.MJOFAKABBGM;
            }
            num2 = 0.01f;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            this.HHIPJDMCDMF.positionSpring = 0f;
            this.HHIPJDMCDMF.positionDamper = 0f;
            this.DDOHGJPCFNF.KOFJBKAKBNL.angularXDrive = this.HHIPJDMCDMF;
            this.DDOHGJPCFNF.KOFJBKAKBNL.angularYZDrive = this.HHIPJDMCDMF;
            num = 0.15f;
            num2 = num;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                    float t2 = 1f - num2 / num;
                    this.KGHHLDAHKJH = Quaternion.Slerp(this.JOGHPHCKEMF, this.NFMGMMKCFLC, t2);
                    this.OGNIDODGHNE = Quaternion.Slerp(this.KHHNNGCFBDJ, this.LOCKJIDGHOA, t2);
                    this.MDIGAEGPEMC = Quaternion.Slerp(this.BINJPIABDNJ, this.MKOJDAONPIN, t2);
                    this.IMLKFAOMBED = Quaternion.Slerp(this.ENAJILKDEJC, this.IBKMINAHGHD, t2);
                    this.DIJCCKNLFHG = Quaternion.Slerp(this.JFKFOPKAODH, this.KONLJLFLIKK, t2);
                    this.NLHJIPDINBC = Quaternion.Slerp(this.FCAKNGCNFON, this.CNNCKHMCPPN, t2);
                    this.AHLLJNLFCFP = Quaternion.Slerp(this.NGDPMCHJLIB, this.KBCBDGNFJCN, t2);
                    this.OHHJPIDOCOD = Mathf.Lerp(30f, -36f, t2);
                    Vector3 normalized2;
                    if (transform2 != null)
                    {
                        if (Vector3.Distance(transform2.position, transform.position) >= 2.5f)
                        {
                            transform2 = null;
                            if (this.BNAIODFPIBA(transform.position + transform.up * -0.5f, this.IEDNGFIDBBL.FacingDirection, out transform2))
                            {
                                normalized2 = (transform2.position - base.JCGCLLMLCLH.position).normalized;
                            }
                            else
                            {
                                normalized2 = (Vector3.ProjectOnPlane(this.IEDNGFIDBBL.FacingDirection, Vector3.up) + Vector3.up * 0.2f).normalized;
                            }
                        }
                        else
                        {
                            normalized2 = (transform2.position - base.JCGCLLMLCLH.position).normalized;
                        }
                    }
                    else if (this.BNAIODFPIBA(transform.position + transform.up * -0.5f, this.IEDNGFIDBBL.FacingDirection, out transform2))
                    {
                        normalized2 = (transform2.position - base.JCGCLLMLCLH.position).normalized;
                    }
                    else
                    {
                        normalized2 = (Vector3.ProjectOnPlane(this.IEDNGFIDBBL.FacingDirection, Vector3.up) + Vector3.up * 0.2f).normalized;
                    }
                    if (num - num2 < 0.07f)
                    {
                        Vector3 vector = normalized2 * this.nnn;
                        base.LGLOPGKONLO.AddForceAtPosition(vector, this.addForcePos.position, ForceMode.Force);
                        this.IEDNGFIDBBL.PNGENFLDJAG.AddForce(-vector * 0.65f, ForceMode.Force);
                    }
                    this.FBHOANFFGGK(normalized2);
                    if (!this.isAttachedToSth)
                    {
                        this.DGMFPGPMLHI();
                    }
                }
                yield return this.MJOFAKABBGM;
            }
            Vector3 normalized3 = (Vector3.ProjectOnPlane(this.IEDNGFIDBBL.FacingDirection, Vector3.up) + Vector3.up * 0.2f).normalized;
            num2 = 0.1f;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                    this.FBHOANFFGGK(normalized3);
                    if (!this.isAttachedToSth)
                    {
                        this.DGMFPGPMLHI();
                    }
                }
                yield return this.MJOFAKABBGM;
            }
            base.LGLOPGKONLO.mass = this.GrabbedWeight;
            num = 0.25f;
            num2 = num;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                    float t3 = 1f - num2 / num;
                    this.KGHHLDAHKJH = Quaternion.Slerp(this.NFMGMMKCFLC, this.INBCNJNLOIB, t3);
                    this.OGNIDODGHNE = Quaternion.Slerp(this.LOCKJIDGHOA, Quaternion.identity, t3);
                    this.MDIGAEGPEMC = Quaternion.Slerp(this.MKOJDAONPIN, Quaternion.identity, t3);
                    this.IMLKFAOMBED = Quaternion.Slerp(this.IBKMINAHGHD, this.CBEFGDJCCNC, t3);
                    this.DIJCCKNLFHG = Quaternion.Slerp(this.KONLJLFLIKK, this.NKBNHINDAIE, t3);
                    this.NLHJIPDINBC = Quaternion.Slerp(this.CNNCKHMCPPN, this.PELEICHHALC, t3);
                    this.AHLLJNLFCFP = Quaternion.Slerp(this.KBCBDGNFJCN, this.ECIMPFANDPP, t3);
                    this.OHHJPIDOCOD = Mathf.Lerp(-36f, 0f, t3);
                    Vector3 normalized4;
                    if (transform2 != null)
                    {
                        if (Vector3.Distance(transform2.position, transform.position) >= 2.5f)
                        {
                            transform2 = null;
                            if (this.BNAIODFPIBA(transform.position + transform.up * -0.5f, this.IEDNGFIDBBL.FacingDirection, out transform2))
                            {
                                normalized4 = (transform2.position - base.JCGCLLMLCLH.position).normalized;
                            }
                            else
                            {
                                normalized4 = (Vector3.ProjectOnPlane(this.IEDNGFIDBBL.FacingDirection, Vector3.up) + Vector3.up * 0.2f).normalized;
                            }
                        }
                        else
                        {
                            normalized4 = (transform2.position - base.JCGCLLMLCLH.position).normalized;
                        }
                    }
                    else if (this.BNAIODFPIBA(transform.position + transform.up * -0.5f, this.IEDNGFIDBBL.FacingDirection, out transform2))
                    {
                        normalized4 = (transform2.position - base.JCGCLLMLCLH.position).normalized;
                    }
                    else
                    {
                        normalized4 = (Vector3.ProjectOnPlane(this.IEDNGFIDBBL.FacingDirection, Vector3.up) + Vector3.up * 0.2f).normalized;
                    }
                    this.FBHOANFFGGK(normalized4);
                }
                yield return this.MJOFAKABBGM;
            }
            base.LGLOPGKONLO.maxAngularVelocity = 8f;
            this.OHHJPIDOCOD = 0f;
            this.ECPGAOFDCKC = false;
            base.IsAttacking = false;
            this.LKOIGOGJDGG = false;
            base.StartCoroutine(this.JKPMCJGNICJ());
            yield break;
        }

        private void PILHFCLPOEN(GameObject JMPJCIJDMMK, Vector3 NMECPDILLCH, Vector3 APGCJMPOBCE)
        {
            this.DDOHGJPCFNF = JMPJCIJDMMK.AddComponent<WeaponJoint>();
            this.DDOHGJPCFNF.KOFJBKAKBNL.connectedBody = base.LGLOPGKONLO;
            Quaternion rotation = JMPJCIJDMMK.transform.rotation;
            Quaternion rotation2 = base.JCGCLLMLCLH.rotation;
            this.ELDFLIBCGCG = Quaternion.Inverse(rotation) * rotation2;
            this.KGNJGIEKHEB = Quaternion.LookRotation(Vector3.back, Vector3.down) * Quaternion.Inverse(this.ELDFLIBCGCG);
            this.DDOHGJPCFNF.KOFJBKAKBNL.targetRotation = this.KGNJGIEKHEB;
            this.DDOHGJPCFNF.KOFJBKAKBNL.anchor = NMECPDILLCH;
            this.DDOHGJPCFNF.KOFJBKAKBNL.autoConfigureConnectedAnchor = false;
            this.DDOHGJPCFNF.KOFJBKAKBNL.connectedAnchor = APGCJMPOBCE;
            this.DDOHGJPCFNF.KOFJBKAKBNL.xMotion = ConfigurableJointMotion.Locked;
            this.DDOHGJPCFNF.KOFJBKAKBNL.yMotion = ConfigurableJointMotion.Locked;
            this.DDOHGJPCFNF.KOFJBKAKBNL.zMotion = ConfigurableJointMotion.Locked;
            this.DDOHGJPCFNF.KOFJBKAKBNL.angularXMotion = ConfigurableJointMotion.Free;
            this.DDOHGJPCFNF.KOFJBKAKBNL.angularYMotion = ConfigurableJointMotion.Free;
            this.DDOHGJPCFNF.KOFJBKAKBNL.angularZMotion = ConfigurableJointMotion.Free;
            this.HHIPJDMCDMF.positionSpring = 0f;
            this.DDOHGJPCFNF.KOFJBKAKBNL.angularXDrive = this.HHIPJDMCDMF;
            this.DDOHGJPCFNF.KOFJBKAKBNL.angularYZDrive = this.HHIPJDMCDMF;
            base.StartCoroutine(this.LKFNPFBMFKP());
        }



        private void BJJNMENLFMD(Rigidbody HNMALBNOMNJ, Vector3 APGCJMPOBCE)
        {
            this.INHPJJKNOAE = base.gameObject.AddComponent<ConfigurableJoint>();
            this.INHPJJKNOAE.connectedBody = HNMALBNOMNJ;
            this.INHPJJKNOAE.angularXDrive = this.LOPHGAIPKGC;
            this.INHPJJKNOAE.angularYZDrive = this.LOPHGAIPKGC;
            this.INHPJJKNOAE.xMotion = ConfigurableJointMotion.Locked;
            this.INHPJJKNOAE.yMotion = ConfigurableJointMotion.Locked;
            this.INHPJJKNOAE.zMotion = ConfigurableJointMotion.Locked;
            this.INHPJJKNOAE.anchor = this.detectPos.localPosition;
            this.INHPJJKNOAE.connectedAnchor = APGCJMPOBCE;
        }

        internal override void IKIJBENLEFE()
        {
            base.LGLOPGKONLO.mass = this.GrabbedWeight;
            base.LGLOPGKONLO.useGravity = false;
            this.GIMLHCAFDDG();
            this.ANLKLODPIGE();
        }

        private void BBJPIONDNFF()
        {
            this.myBoxCollider.isTrigger = false;
        }




        private void IJKKFNGAHFG()
        {
            this.myCapsuleCollider.center = this.CHAKCFPODPO;
            this.myCapsuleCollider.height = this.HODNIDCHBIL;
        }

        private void GHDKNCAPPIN()
        {
            //Object.Destroy(this.INHPJJKNOAE);
            Destroy(this.INHPJJKNOAE);
            this.INHPJJKNOAE = null;
            this.JHJHBDAKOKO = null;
            this.BBJPIONDNFF();
        }

        private void FBHOANFFGGK(Vector3 PEPCMOOMKBG)
        {
            Vector3 up = base.JCGCLLMLCLH.up;
            Vector3 angularVelocity = base.LGLOPGKONLO.angularVelocity;
            Vector3 normalized = Vector3.Cross(PEPCMOOMKBG, up).normalized;
            Vector3 a = Vector3.SignedAngle(up, PEPCMOOMKBG, normalized) * 0.017453292f * 100f * normalized;
            base.LGLOPGKONLO.AddTorque((a - angularVelocity) * (base.LGLOPGKONLO.mass * 5f), ForceMode.Impulse);
        }

        internal override void MPKJPGBHBNK()
        {
            base.MPKJPGBHBNK();
            this.GHDKNCAPPIN();
        }

        private WeaponJoint DDOHGJPCFNF;

        private bool LKOIGOGJDGG;

        private readonly JointDrive BCGMNMJFMLD = new JointDrive
        {
            positionSpring = 10f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private JointDrive HHIPJDMCDMF = new JointDrive
        {
            positionSpring = 0f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive OJIPDAGFBPC = new JointDrive
        {
            positionSpring = 50f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive ICLFAJOONAM = new JointDrive
        {
            positionSpring = 0f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive BIEMKFMCKIK = new JointDrive
        {
            positionSpring = 400f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive FOAFEJJLLOD = new JointDrive
        {
            positionSpring = 50f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive PNPFJAODMMN = new JointDrive
        {
            positionSpring = 80f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive LGGLCGFHLDB = new JointDrive
        {
            positionSpring = 1f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive LONEFNPNIIM = new JointDrive
        {
            positionSpring = 400f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive IMIKGCOGHMH = new JointDrive
        {
            positionSpring = 50f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive LJIFNFPEFPN = new JointDrive
        {
            positionSpring = 600f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive BFJFJGCFGAE = new JointDrive
        {
            positionSpring = 400f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive IEHMKECLCHB = new JointDrive
        {
            positionSpring = 400f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive HMOLGLHMABM = new JointDrive
        {
            positionSpring = 200f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive OPEFEAAAPGF = new JointDrive
        {
            positionSpring = 200f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive IMBFPOEPGEB = new JointDrive
        {
            positionSpring = 1f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive AOCCMBICIEG = new JointDrive
        {
            positionSpring = 200f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive DIDCGKAFLOI = new JointDrive
        {
            positionSpring = 1f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive LIBMABDFJBO = new JointDrive
        {
            positionSpring = 30f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive EBCNAINPJFB = new JointDrive
        {
            positionSpring = 20f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive KGHNAIMAMAL = new JointDrive
        {
            positionSpring = 30f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive EIDOLGBABMO = new JointDrive
        {
            positionSpring = 20f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive NNBDMMHAIPO = new JointDrive
        {
            positionSpring = 600f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive DMFJODOLBAM = new JointDrive
        {
            positionSpring = 10f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive DFPPLFCNLKA = new JointDrive
        {
            positionSpring = 800f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive KNALMMLKGKD = new JointDrive
        {
            positionSpring = 200f,
            positionDamper = 0.5f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive LNCEKEKPIIK = new JointDrive
        {
            positionSpring = 500f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive MKGGMEENJKD = new JointDrive
        {
            positionSpring = 800f,
            positionDamper = 0.5f,
            maximumForce = float.MaxValue
        };

        private readonly Quaternion GKOAAPJNHKG = Quaternion.Euler(new Quaternion(0.8f, -0.7f, 0f, 1f).eulerAngles);

        private readonly Quaternion ALEHILLCEIM = Quaternion.Euler(new Quaternion(-0.4f, -0.7f, 0f, 1f).eulerAngles);

        private readonly Quaternion PNDFCBCNNKB = Quaternion.Euler(new Vector3(-22.5f, 65f, -18f));

        private readonly Quaternion LNCCGKJDALM = Quaternion.Euler(new Vector3(-22.5f, 65f, -18f));

        private readonly Quaternion KDCJLFPGMNL = Quaternion.Euler(new Quaternion(1.3f, 0f, 0f, 1f).eulerAngles);

        private readonly Quaternion FMEKMHFADIP = Quaternion.Euler(new Quaternion(0f, 0f, 0f, 1f).eulerAngles);

        private readonly Quaternion LKAOACEIJKP = Quaternion.Euler(new Vector3(80f, -7f, 0f));

        private readonly Quaternion KMDNGHCOIDC = Quaternion.Euler(new Vector3(80f, -7f, 0f));

        private readonly Quaternion CBEFGDJCCNC = Quaternion.Euler(new Quaternion(0f, -0.65f, 0f, 1f).eulerAngles);

        private readonly Quaternion PELEICHHALC = Quaternion.Euler(new Vector3(-22.5f, 65f, -18f));

        private readonly Quaternion NKBNHINDAIE = Quaternion.Euler(new Quaternion(0.17f, 0f, 0f, 1f).eulerAngles);

        private readonly Quaternion ECIMPFANDPP = Quaternion.Euler(new Vector3(70f, -7f, 0f));

        private readonly Quaternion INBCNJNLOIB = new Quaternion(-0.04f, 0f, 0f, 1f).normalized;

        private readonly Quaternion CAKGDLJNPFK = Quaternion.Euler(new Vector3(-57.8f, 21.66f, 0f));

        private readonly Quaternion MAKLLFFDJBD = Quaternion.Euler(new Vector3(0f, 63.5f, 24f));

        private readonly Quaternion JCDAGNIALPB = Quaternion.Euler(new Vector3(160f, 0f, 0f));

        private readonly Quaternion KIKEBPPDADI = Quaternion.Euler(new Vector3(85f, 0f, 0f));

        private readonly Quaternion JOGHPHCKEMF = Quaternion.Euler(-7f, 0f, 30f);

        private readonly Quaternion KHHNNGCFBDJ = Quaternion.Euler(0f, 0f, -15f);

        private readonly Quaternion BINJPIABDNJ = Quaternion.Euler(0f, 0f, -15f);

        private readonly Quaternion ENAJILKDEJC = Quaternion.Euler(0f, -54.2f, -9.4f);

        private readonly Quaternion JFKFOPKAODH = Quaternion.Euler(64f, 0f, 0f);

        private readonly Quaternion FCAKNGCNFON = Quaternion.Euler(4f, 51.96f, -68f);

        private readonly Quaternion NGDPMCHJLIB = Quaternion.Euler(46.7f, 0f, 0f);

        private readonly Quaternion NFMGMMKCFLC = Quaternion.Euler(0f, 0f, -36f);

        private readonly Quaternion LOCKJIDGHOA = Quaternion.Euler(0f, 0f, 18f);

        private readonly Quaternion MKOJDAONPIN = Quaternion.Euler(0f, 0f, 18f);

        private readonly Quaternion IBKMINAHGHD = Quaternion.Euler(0f, -51.6f, -4f);

        private readonly Quaternion KONLJLFLIKK = Quaternion.Euler(41f, 0f, 0f);

        private readonly Quaternion CNNCKHMCPPN = Quaternion.Euler(-20f, 49f, 60f);

        private readonly Quaternion KBCBDGNFJCN = Quaternion.Euler(0f, 0f, 0f);

        private Quaternion KGHHLDAHKJH;

        private Quaternion OGNIDODGHNE;

        private Quaternion MDIGAEGPEMC;

        private Quaternion IMLKFAOMBED;

        private Quaternion DIJCCKNLFHG;

        private Quaternion NLHJIPDINBC;

        private Quaternion AHLLJNLFCFP;

        private readonly Vector3 FDPMNFGEMLN = new Vector3(0f, 0.623f, 0f);


        private Vector3 CHAKCFPODPO;

        private float HODNIDCHBIL;

        public CapsuleCollider myCapsuleCollider;

        public BoxCollider myBoxCollider;

        public Transform addForcePos;

        public Transform detectPos;


        private float OHHJPIDOCOD;

        private ConfigurableJoint OLNNBDCBHCJ;

        public float nnn = 300f;

        private RaycastHit[] MJGHGJDNKFP = new RaycastHit[42];

        private HashSet<Rigidbody> HBKMECLJMPC = new HashSet<Rigidbody>();

        private Quaternion ELDFLIBCGCG;

        private Quaternion KGNJGIEKHEB;

        private Collider[] FFCGJOHLBKC = new Collider[10];

        private RaycastHit IPDDKMOODLB;



        public float averageAngle;

        private PhysicCharacterController CPJFKHBNFBN;

        private JointDrive LOPHGAIPKGC = new JointDrive
        {
            positionSpring = 250f,
            positionDamper = 0.5f,
            maximumForce = float.MaxValue
        };

        public float attachDuration = 5f;

        private List<Collider> NOOFBDHGCJI = new List<Collider>();
    }
}