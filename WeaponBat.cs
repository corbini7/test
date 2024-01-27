using System.Collections;
using UnityEngine;
namespace Deobfuscated
{
    public class WeaponBat : WeaponMelee
    {
        internal override void AGIKMKKNICC()
        {
            this.weaponController.JGBLPPKMAMA();
            GameObject greenChest = this.IEDNGFIDBBL.GreenChest;
            Matrix4x4 worldToLocalMatrix = greenChest.transform.worldToLocalMatrix;
            Vector3 position = this.AddForcePos.position;
            Vector3 vector = worldToLocalMatrix.MultiplyPoint3x4(this.grabPositions[0].position);
            Vector3 vector2 = worldToLocalMatrix.MultiplyPoint3x4(position);
            float num = Vector3.Angle(position - this.grabPositions[0].position, greenChest.transform.up);
            if ((this.CDIPAMKBAGG && vector2.x > 0.4f) || (vector.x > 0.2f && vector.y > -0.03f && num < 120f))
            {
                base.StartCoroutine(this.LLKGJFJDBGL());
                return;
            }
            base.StartCoroutine(this.LMHNCEJLPFB());
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
                Vector3 b = MCFOLNMFCPN.GreenFistR.transform.TransformPoint(this.GFOEBGAGIEI);
                if (this.DDOHGJPCFNF == null)
                {
                    Vector3 from = this.grabPositions[0].position - MCFOLNMFCPN.GreenHip.transform.position;
                    if (from.magnitude > 1.2f)
                    {
                        MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                        OGMMABHJCNI = false;
                        return;
                    }
                    if (Vector3.Angle(from, -MCFOLNMFCPN.GreenHip.transform.up) > 100f)
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
                    Vector3 a = this.grabPositions[0].position - b;
                    CFOGGNCCHCO.IPIGMALBAKG(MCFOLNMFCPN.PIMHHNKOCBE, Vector3.ClampMagnitude(a * 200f, 8f));
                    if (a.magnitude < 0.08f)
                    {
                        this.PILHFCLPOEN(MCFOLNMFCPN.GreenFistR, this.GFOEBGAGIEI, this.grabPositions[0].localPosition);
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




        private void IJKKFNGAHFG()
        {
            this.batHandleCollider.center = this.HMGGBIFMHDE;
            this.batHandleCollider.height = this.MHNKAHGIMNC;
        }


        private void OnCollisionEnter(Collision NLJBANLOGGI)
        {
            if (NLJBANLOGGI.gameObject.layer == base.gameObject.layer)
            {
                return;
            }
            if (base.Owner != null && this.IEDNGFIDBBL.IINJFJOIHMK.Contains(NLJBANLOGGI.gameObject))
            {
                return;
            }
            base.KOPJDFGNKLE(NLJBANLOGGI, ref this.LMOPCBGKBID, this.OHIAODBCHHM, 0.00021f, true, 40f, 0.6f);
        }


        private IEnumerator LLKGJFJDBGL()
        {
            base.LGLOPGKONLO.maxAngularVelocity = 80f;
            base.IsAttacking = true;
            this.OHIAODBCHHM = this.IEDNGFIDBBL.characterStates.Power * 0.7f + 0.3f;
            Transform transform = this.IEDNGFIDBBL.GreenChest.transform;
            this.LMOPCBGKBID = true;
            this.EMACMDKGJKA = true;
            float num = 0.08f;
            while (num >= 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    Vector3 position = this.AddForcePos.transform.position;
                    CFOGGNCCHCO.OEODACNOHCD(base.LGLOPGKONLO, Vector3.Cross(transform.forward + transform.right * 0.6f, position - transform.position).normalized * -350f, position, ForceMode.Acceleration);
                }
                yield return this.MJOFAKABBGM;
            }
            this.EMACMDKGJKA = false;
            num = 0.25f;
            while (num >= 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            base.IsAttacking = false;
            this.LMOPCBGKBID = false;
            base.LGLOPGKONLO.maxAngularVelocity = 7f;
            base.StartCoroutine(this.GBIJIFBNNOA());
            yield break;
        }


        internal override void IKIJBENLEFE()
        {
            base.LGLOPGKONLO.useGravity = false;
            base.LGLOPGKONLO.mass = this.GrabbedWeight;
            this.GIMLHCAFDDG();
        }

        private void JACDOONBPMN(ConfigurableJoint DEIMKLMOEKJ, JointDrive LBNMFIJGHFG, Quaternion BMHBHBBGFMC)
        {
            DEIMKLMOEKJ.angularXDrive = LBNMFIJGHFG;
            DEIMKLMOEKJ.angularYZDrive = LBNMFIJGHFG;
            DEIMKLMOEKJ.targetRotation = BMHBHBBGFMC;
        }

        private IEnumerator AHLPDIDFHHI()
        {
            this.CDIPAMKBAGG = true;
            //num = 0.25f;
            //while (num >= 0f)
            //{
            //    if (!PhysicsDummyModeManager.IsPaused)
            //    {
            //        num -= Time.fixedDeltaTime;
            //    }
            //    yield return this.MJOFAKABBGM;
            //}
            this.CDIPAMKBAGG = false;
            yield break;
        }


        private void GIMLHCAFDDG()
        {
            this.batHandleCollider.center = this.GIKMNLMANPM;
            this.batHandleCollider.height = this.FFNOBCOFFKM;
        }

        internal override void GDENHBKDDGO()
        {
            base.GDENHBKDDGO();
            if (this.DDOHGJPCFNF != null)
            {
                this.DDOHGJPCFNF.OnDestroy();
            }
        }


        internal override void GIKCPEIMJFO()
        {
            base.GIKCPEIMJFO();
            this.IJKKFNGAHFG();
        }


        internal override void DMJOIPHGHEB(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
            if (base.IsAttacking)
            {
                if (this.BOICMCLPGEP || this.EMACMDKGJKA)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.JLHAPBPILNI, this.JMFHNNPADKD);
                    this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.GKHDJGKMGKA, this.LPGJJEJCJNF);
                }
                if (this.KEFADBHCOKL || this.AMHAGALOOAL)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.DGFMCFCOLBI, this.DFDNJODCNOG);
                    this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.DLIFKEGEAGL, this.DKHKAANPHIH);
                    return;
                }
            }
            else if (PKGLIMPDIIP)
            {
                if ((BNLPAPMFDLL < 0.3f && !DOLMJFFJFBH) || (BNLPAPMFDLL < 0.15f && DOLMJFFJFBH))
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.EANHMFPNEID, this.EEKLONBGEAE);
                    this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.DGAFLNLHLHA, this.KACDIGJGPAO);
                    return;
                }
                float num = (Mathf.Sin(AGCJDIFCAKA + 0.5f) + 1f) * 0.5f;
                if (GHMBNLHGMHG)
                {
                    num = -num + 1f;
                }
                Quaternion bmhbhbbgfmc = Quaternion.Slerp(this.JCHADCKFOEP, this.DGDNAOCLIBF, num);
                Quaternion bmhbhbbgfmc2 = Quaternion.Slerp(this.ALCMJAOAGCI, this.JGPIOIOLCAE, num);
                this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.KOBCMGDHCCC, bmhbhbbgfmc);
                this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.FKDLGAHOJGF, bmhbhbbgfmc2);
                return;
            }
            else
            {
                if (DPKCPMHPAAJ < 0.8f)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.MEANECHJPNM, this.KAMFJKFLNJC);
                    this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.JGLAHHCKCBK, this.BJOBEKHDMMK);
                    return;
                }
                if (AGCJDIFCAKA <= 0f)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.MEANECHJPNM, this.EEKLONBGEAE);
                    this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.JGLAHHCKCBK, this.KACDIGJGPAO);
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
                this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.PEANKGCLEJC, Quaternion.Euler(zero));
                this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.AFJMJLCLHNN, this.KACDIGJGPAO);
            }
        }




        internal override void GHGLMNMONHK(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, bool DOLMJFFJFBH, bool PKGLIMPDIIP)
        {
            if (base.IsAttacking)
            {
                MCFOLNMFCPN.AJBEMNONLMC.targetRotation = this.FLDKJHLEHLP;
                return;
            }
            MCFOLNMFCPN.AJBEMNONLMC.targetRotation = this.IJHPAHILFAD;
        }

        protected override void Awake()
        {
            this.HMGGBIFMHDE = this.batHandleCollider.center;
            this.MHNKAHGIMNC = this.batHandleCollider.height;
            base.Awake();
            PhysicMaterial physicMaterial = new PhysicMaterial();
            physicMaterial.bounciness = 0.4f;
            physicMaterial.dynamicFriction = 0.5f;
            physicMaterial.staticFriction = 0.5f;
            Collider[] components = base.GetComponents<Collider>();
            for (int i = 0; i < components.Length; i++)
            {
                components[i].material = physicMaterial;
            }
            base.PowerConsume = 0.04f;
            base.NoPowerRecoverCD = 1.5f;
            this.BCGMNMJFMLD.positionSpring = 10f;
            this.BCGMNMJFMLD.positionDamper = 1f;
            this.BCGMNMJFMLD.maximumForce = float.PositiveInfinity;
            this.POKCGGKKGAN = this.grabPositions[0].localPosition;
            this.FIMGPEKBFAA.positionSpring = 50f;
            this.FIMGPEKBFAA.positionDamper = 1f;
            this.FIMGPEKBFAA.maximumForce = float.PositiveInfinity;
            this.OHDNALPKKJN.positionSpring = 0f;
            this.OHDNALPKKJN.positionDamper = 0.05f;
            this.OHDNALPKKJN.maximumForce = float.PositiveInfinity;
            this.EANHMFPNEID.positionSpring = 400f;
            this.EANHMFPNEID.positionDamper = 1f;
            this.EANHMFPNEID.maximumForce = float.PositiveInfinity;
            this.DGAFLNLHLHA.positionSpring = 50f;
            this.DGAFLNLHLHA.positionDamper = 0.1f;
            this.DGAFLNLHLHA.maximumForce = float.PositiveInfinity;
            this.NGCGDJKBBCG.positionSpring = 80f;
            this.NGCGDJKBBCG.positionDamper = 0.05f;
            this.NGCGDJKBBCG.maximumForce = float.PositiveInfinity;
            this.HGEFDNMOIKK.positionSpring = 1f;
            this.HGEFDNMOIKK.positionDamper = 0.05f;
            this.HGEFDNMOIKK.maximumForce = float.PositiveInfinity;
            this.KOBCMGDHCCC.positionSpring = 600f;
            this.KOBCMGDHCCC.positionDamper = 1f;
            this.KOBCMGDHCCC.maximumForce = float.PositiveInfinity;
            this.FKDLGAHOJGF.positionSpring = 200f;
            this.FKDLGAHOJGF.positionDamper = 0.1f;
            this.FKDLGAHOJGF.maximumForce = float.PositiveInfinity;
            this.FGKADLGPOAN.positionSpring = 600f;
            this.FGKADLGPOAN.positionDamper = 0.05f;
            this.FGKADLGPOAN.maximumForce = float.PositiveInfinity;
            this.ONOHIMJIHHE.positionSpring = 400f;
            this.ONOHIMJIHHE.positionDamper = 0.05f;
            this.ONOHIMJIHHE.maximumForce = float.PositiveInfinity;
            this.NJHLLLMCKJA.positionSpring = 30f;
            this.NJHLLLMCKJA.positionDamper = 1f;
            this.NJHLLLMCKJA.maximumForce = float.PositiveInfinity;
            this.AABJDLDACJI.positionSpring = 20f;
            this.AABJDLDACJI.positionDamper = 1f;
            this.AABJDLDACJI.maximumForce = float.PositiveInfinity;
            this.MEANECHJPNM.positionSpring = 30f;
            this.MEANECHJPNM.positionDamper = 1f;
            this.MEANECHJPNM.maximumForce = float.PositiveInfinity;
            this.JGLAHHCKCBK.positionSpring = 20f;
            this.JGLAHHCKCBK.positionDamper = 1f;
            this.JGLAHHCKCBK.maximumForce = float.PositiveInfinity;
            this.JLHAPBPILNI.positionSpring = 800f;
            this.JLHAPBPILNI.positionDamper = 0.5f;
            this.JLHAPBPILNI.maximumForce = float.PositiveInfinity;
            this.GKHDJGKMGKA.positionSpring = 50f;
            this.GKHDJGKMGKA.positionDamper = 0.2f;
            this.GKHDJGKMGKA.maximumForce = float.PositiveInfinity;
            this.DGFMCFCOLBI.positionSpring = 150f;
            this.DGFMCFCOLBI.positionDamper = 0.2f;
            this.DGFMCFCOLBI.maximumForce = float.PositiveInfinity;
            this.DLIFKEGEAGL.positionSpring = 300f;
            this.DLIFKEGEAGL.positionDamper = 0.2f;
            this.DLIFKEGEAGL.maximumForce = float.PositiveInfinity;
        }

        private void PILHFCLPOEN(GameObject JMPJCIJDMMK, Vector3 NMECPDILLCH, Vector3 APGCJMPOBCE)
        {
            this.DDOHGJPCFNF = JMPJCIJDMMK.AddComponent<WeaponJoint>();
            this.DDOHGJPCFNF.KOFJBKAKBNL.connectedBody = base.LGLOPGKONLO;
            this.HHJHJAGCOKK = Quaternion.Inverse(JMPJCIJDMMK.transform.rotation) * base.JCGCLLMLCLH.rotation;
            this.DDOHGJPCFNF.KOFJBKAKBNL.targetRotation = Quaternion.LookRotation(Vector3.down, Vector3.back) * Quaternion.Inverse(this.HHJHJAGCOKK);
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


        internal override void FCPOCNFEKCJ(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG)
        {
            if (base.IsAttacking)
            {
                if (this.BOICMCLPGEP || this.EMACMDKGJKA)
                {
                    MCFOLNMFCPN.NLEHLJPKLCH.targetRotation = this.NINIFAANCOM;
                }
                if (this.KEFADBHCOKL || this.AMHAGALOOAL)
                {
                    MCFOLNMFCPN.NLEHLJPKLCH.targetRotation = this.LIKELMCKMDA;
                    return;
                }
            }
            else
            {
                if (BNLPAPMFDLL <= 0.3f)
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
        }

        internal override void HPMGJPMEFED(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
            if (base.IsAttacking)
            {
                if (this.BOICMCLPGEP || this.EMACMDKGJKA)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.JLHAPBPILNI, this.OLIAOOMGOCE);
                    this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.GKHDJGKMGKA, this.HFICCPBAKLK);
                }
                if (this.KEFADBHCOKL || this.AMHAGALOOAL)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.DGFMCFCOLBI, this.LKOODILHDEK);
                    this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.DLIFKEGEAGL, this.GIPAMDCBCAO);
                    return;
                }
            }
            else if (PKGLIMPDIIP)
            {
                if ((BNLPAPMFDLL < 0.3f && !DOLMJFFJFBH) || (BNLPAPMFDLL < 0.15f && DOLMJFFJFBH))
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.FIMGPEKBFAA, this.CKJINGHGJCH);
                    this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.OHDNALPKKJN, this.HEKGAEECIJM);
                    return;
                }
                float num = (Mathf.Sin(AGCJDIFCAKA + 3.14159f + 0.5f) + 1f) * 0.5f;
                if (GHMBNLHGMHG)
                {
                    num = -num + 1f;
                }
                Quaternion bmhbhbbgfmc = Quaternion.Slerp(this.LJKEGHDHPGM, this.NKOLEJNJPPC, num);
                Quaternion bmhbhbbgfmc2 = Quaternion.Slerp(this.FINHKIMECEF, this.LDOCJLAECJN, num);
                if (DOLMJFFJFBH)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.FGKADLGPOAN, bmhbhbbgfmc);
                    this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.ONOHIMJIHHE, bmhbhbbgfmc2);
                    return;
                }
                this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.NGCGDJKBBCG, bmhbhbbgfmc);
                this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.HGEFDNMOIKK, bmhbhbbgfmc2);
                return;
            }
            else
            {
                if (DPKCPMHPAAJ < 0.8f)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.NJHLLLMCKJA, this.JNHMNOPHAKF);
                    this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.AABJDLDACJI, this.IPGCPNBOBIG);
                    return;
                }
                if (AGCJDIFCAKA <= 0f)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.NJHLLLMCKJA, this.CKJINGHGJCH);
                    this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.AABJDLDACJI, this.HEKGAEECIJM);
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
                this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.HFPDEDOOIPI, Quaternion.Euler(zero));
                this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.IEEHEIJJHFL, this.HEKGAEECIJM);
            }
        }


        private void FixedUpdate()
        {
            if (PhysicsDummyModeManager.IsPaused)
            {
                return;
            }
            if (this.LIFGGMBLIBC > 0f)
            {
                this.LIFGGMBLIBC -= Time.fixedDeltaTime;
            }
        }


        private IEnumerator GBIJIFBNNOA()
        {
            this.KGMJKGNAION = true;
            float num = 0.25f;
            while (num >= 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            this.KGMJKGNAION = false;
            yield break;
        }


        private IEnumerator LKFNPFBMFKP()
        {
            while (this.HHIPJDMCDMF.positionSpring < 100f && this.DDOHGJPCFNF != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    this.HHIPJDMCDMF.positionSpring = this.HHIPJDMCDMF.positionSpring + Time.fixedDeltaTime * 100f;
                    this.DDOHGJPCFNF.KOFJBKAKBNL.angularXDrive = this.HHIPJDMCDMF;
                    this.DDOHGJPCFNF.KOFJBKAKBNL.angularYZDrive = this.HHIPJDMCDMF;
                }
                yield return this.MJOFAKABBGM;
            }
            yield break;
        }





        private IEnumerator LMHNCEJLPFB()
        {
            base.LGLOPGKONLO.maxAngularVelocity = 80f;
            base.IsAttacking = true;
            this.OHIAODBCHHM = this.IEDNGFIDBBL.characterStates.Power * 0.7f + 0.3f;
            // transform = this.IEDNGFIDBBL.GreenChest.transform;
            this.BOICMCLPGEP = true;
            this.LMOPCBGKBID = true;
            //num = 0.3f;
            if (this.KGMJKGNAION)
            {
                //num = -1f;
            }
            while (/*num >= 0f &&*/ base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                    CFOGGNCCHCO.OEODACNOHCD(base.LGLOPGKONLO, -(base.JCGCLLMLCLH.up + base.JCGCLLMLCLH.right * 0f).normalized * 20f, this.AddForcePos.position, ForceMode.Acceleration);
                }
                yield return this.MJOFAKABBGM;
            }
            //num = 0.02f;
            while (/*num >= 0f && */base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            this.BOICMCLPGEP = false;
            this.KEFADBHCOKL = true;
            //num = 0.13f;
            while (/*num >= 0f &&*/ base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                    Transform transform2 = this.IEDNGFIDBBL.GreenFistR.transform;
                    Vector3 position = this.AddForcePos.position;
                    CFOGGNCCHCO.OEODACNOHCD(base.LGLOPGKONLO, Vector3.Cross(transform.forward + transform.right * 0.2f, position - transform.position).normalized * 800f, position, ForceMode.Acceleration);
                }
                yield return this.MJOFAKABBGM;
            }
            this.KEFADBHCOKL = false;
            //num = 0.15f;
            while (/*num >= 0f &&*/ base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    // num -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            base.IsAttacking = false;
            base.StartCoroutine(this.AHLPDIDFHHI());
            //num = 0.25f;
            while (/*num >= 0f &&*/ base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            if (!base.IsAttacking)
            {
                this.LMOPCBGKBID = false;
                base.LGLOPGKONLO.maxAngularVelocity = 7f;
            }
            yield break;
        }

        public Transform AddForcePos;

        private Vector3 POKCGGKKGAN;

        private float OHIAODBCHHM;

        private WeaponJoint DDOHGJPCFNF;

        private JointDrive HHIPJDMCDMF = new JointDrive
        {
            positionSpring = 0f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private JointDrive BCGMNMJFMLD;

        private Quaternion HHJHJAGCOKK = Quaternion.identity;

        private Quaternion LJKEGHDHPGM = Quaternion.Euler(new Quaternion(0.8f, -0.7f, 0f, 1f).eulerAngles);

        private Quaternion NKOLEJNJPPC = Quaternion.Euler(new Quaternion(-0.4f, -0.7f, 0f, 1f).eulerAngles);

        private Quaternion JCHADCKFOEP = Quaternion.Euler(new Quaternion(-0.16f, 0.65f, 0f, 1f).eulerAngles);

        private Quaternion DGDNAOCLIBF = Quaternion.Euler(new Quaternion(-0.2f, 0.65f, 0f, 1f).eulerAngles);

        private Quaternion FINHKIMECEF = Quaternion.Euler(new Quaternion(1.3f, 0f, 0f, 1f).eulerAngles);

        private Quaternion LDOCJLAECJN = Quaternion.Euler(new Quaternion(0f, 0f, 0f, 1f).eulerAngles);

        private Quaternion ALCMJAOAGCI = Quaternion.Euler(new Quaternion(0.7f, 0f, 0f, 1f).eulerAngles);

        private Quaternion JGPIOIOLCAE = Quaternion.Euler(new Quaternion(0.7f, 0f, 0f, 1f).eulerAngles);

        private Quaternion CKJINGHGJCH = Quaternion.Euler(new Quaternion(0f, -0.65f, 0f, 1f).eulerAngles);

        private Quaternion EEKLONBGEAE = Quaternion.Euler(new Quaternion(0f, 0.65f, 0f, 1f).eulerAngles);

        private Quaternion HEKGAEECIJM = Quaternion.Euler(new Quaternion(0.17f, 0f, 0f, 1f).eulerAngles);

        private Quaternion KACDIGJGPAO = Quaternion.Euler(new Quaternion(0.7f, 0f, 0f, 1f).eulerAngles);

        private JointDrive FIMGPEKBFAA;

        private JointDrive EANHMFPNEID;

        private JointDrive OHDNALPKKJN;

        private JointDrive DGAFLNLHLHA;

        private JointDrive NGCGDJKBBCG;

        private JointDrive KOBCMGDHCCC;

        private JointDrive HGEFDNMOIKK;

        private JointDrive FKDLGAHOJGF;

        private JointDrive FGKADLGPOAN;

        private JointDrive ONOHIMJIHHE;

        private JointDrive NJHLLLMCKJA;

        private JointDrive AABJDLDACJI;

        private JointDrive MEANECHJPNM;

        private JointDrive JGLAHHCKCBK;

        private JointDrive HFPDEDOOIPI = new JointDrive
        {
            positionSpring = 200f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private JointDrive IEEHEIJJHFL = new JointDrive
        {
            positionSpring = 1f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private JointDrive PEANKGCLEJC = new JointDrive
        {
            positionSpring = 200f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private JointDrive AFJMJLCLHNN = new JointDrive
        {
            positionSpring = 1f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private Quaternion JNHMNOPHAKF = Quaternion.Euler(new Vector3(-57.8f, 21.66f, 0f));

        private Quaternion KAMFJKFLNJC = Quaternion.Euler(new Vector3(0f, 62.95f, -1.8f));

        private Quaternion IPGCPNBOBIG = Quaternion.Euler(new Vector3(160f, 0f, 0f));

        private Quaternion BJOBEKHDMMK = Quaternion.Euler(new Vector3(120f, 0f, 0f));

        private Quaternion OLIAOOMGOCE = new Quaternion(-0.31f, -0.66f, 0f, 1f);

        private Quaternion JMFHNNPADKD = new Quaternion(1.59f, 0.49f, 0f, 1f);

        private Quaternion HFICCPBAKLK = new Quaternion(0.34f, 0f, 0f, 1f);

        private Quaternion LPGJJEJCJNF = new Quaternion(0.2f, 0f, -0.16f, 1f);

        private JointDrive JLHAPBPILNI;

        private JointDrive GKHDJGKMGKA;

        private Quaternion LKOODILHDEK = new Quaternion(-0.31f, -0.66f, 0f, 1f);

        private Quaternion DFDNJODCNOG = new Quaternion(-0.41f, 0.25f, 0.37f, 1f);

        private Quaternion GIPAMDCBCAO = new Quaternion(0.34f, 0f, 0f, 1f);

        private Quaternion DKHKAANPHIH = new Quaternion(0.16f, 0f, 0f, 1f);

        private JointDrive DGFMCFCOLBI;

        private JointDrive DLIFKEGEAGL;

        private bool BOICMCLPGEP;

        private bool KEFADBHCOKL;

        private bool AMHAGALOOAL;

        private bool EMACMDKGJKA;

        private Quaternion NINIFAANCOM = new Quaternion(0f, 0f, 0.2f, 1f);

        private Quaternion LIKELMCKMDA = new Quaternion(0f, 0f, -0.3f, 1f);

        private Quaternion FLDKJHLEHLP = Quaternion.Euler(20f, 0f, 0f);

        private Quaternion IJHPAHILFAD = new Quaternion(-0.04f, 0f, 0f, 1f).normalized;

        private bool CDIPAMKBAGG;

        private bool KGMJKGNAION;

        private Vector3 GFOEBGAGIEI = new Vector3(-0.07f, 0f, 0.15f);

        public CapsuleCollider batHandleCollider;

        private Vector3 HMGGBIFMHDE;

        private float MHNKAHGIMNC;

        private readonly Vector3 GIKMNLMANPM = new Vector3(0f, 0f, 0.4727f);

        private float FFNOBCOFFKM = 0.4799f;
    }
}