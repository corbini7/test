using System.Collections;
using UnityEngine;
namespace Deobfuscated
{
    public class WeaponNunchucks : WeaponMelee
    {
        internal override void CKNIMEIJEGN()
        {
            if (this.isPart0)
            {
                base.LGLOPGKONLO.velocity = Vector3.zero;
                this.jointRigidbody.velocity = Vector3.zero;
                this.theOtherNunchuks.LGLOPGKONLO.velocity = Vector3.zero;
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
            if (!base.IsAttacking)
            {
                this.EGGKCIBAAFA += Time.fixedDeltaTime;
            }
            else
            {
                this.EGGKCIBAAFA = 0f;
            }
            if (this.EGGKCIBAAFA > 2f)
            {
                if (this.FKIELAEFBOA > 0f)
                {
                    this.FKIELAEFBOA -= Time.fixedDeltaTime * 0.05f;
                    return;
                }
                this.FKIELAEFBOA = 0f;
            }
        }


        internal override void GIKCPEIMJFO()
        {
            base.GIKCPEIMJFO();
            this.IJKKFNGAHFG();
            this.ALFHAGOINHB = false;
            this.theOtherNunchuks.Owner = null;
            base.LGLOPGKONLO.maxAngularVelocity = 15f;
            this.theOtherNunchuks.LGLOPGKONLO.maxAngularVelocity = 15f;
            this.theOtherNunchuks.LGLOPGKONLO.mass = this.theOtherNunchuks.NormalWeight;
            this.GHLMAPJNNND();
        }







        internal override void FCPOCNFEKCJ(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG)
        {
            if (this.LKOIGOGJDGG)
            {
                this.JACDOONBPMN(MCFOLNMFCPN.NLEHLJPKLCH, this.LNCEKEKPIIK, this.OGNIDODGHNE);
                this.JACDOONBPMN(MCFOLNMFCPN.CDBGCHHHPFL, this.MKGGMEENJKD, this.MDIGAEGPEMC);
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


        private void NPGPPIPPLNB(GameObject JMPJCIJDMMK, Vector3 NMECPDILLCH, Vector3 APGCJMPOBCE)
        {
            this.DDOHGJPCFNF = JMPJCIJDMMK.AddComponent<WeaponJoint>();
            this.DDOHGJPCFNF.KOFJBKAKBNL.connectedBody = base.LGLOPGKONLO;
            this.LMHCBLABLCK = Quaternion.Inverse(JMPJCIJDMMK.transform.rotation) * base.JCGCLLMLCLH.rotation;
            this.DDOHGJPCFNF.KOFJBKAKBNL.targetRotation = Quaternion.LookRotation(Vector3.down, Vector3.back) * Quaternion.Inverse(this.LMHCBLABLCK);
            this.DDOHGJPCFNF.KOFJBKAKBNL.anchor = NMECPDILLCH;
            this.DDOHGJPCFNF.KOFJBKAKBNL.autoConfigureConnectedAnchor = false;
            this.DDOHGJPCFNF.KOFJBKAKBNL.connectedAnchor = APGCJMPOBCE;
            this.DDOHGJPCFNF.KOFJBKAKBNL.xMotion = ConfigurableJointMotion.Locked;
            this.DDOHGJPCFNF.KOFJBKAKBNL.yMotion = ConfigurableJointMotion.Locked;
            this.DDOHGJPCFNF.KOFJBKAKBNL.zMotion = ConfigurableJointMotion.Locked;
            this.DDOHGJPCFNF.KOFJBKAKBNL.angularXMotion = ConfigurableJointMotion.Free;
            this.DDOHGJPCFNF.KOFJBKAKBNL.angularYMotion = ConfigurableJointMotion.Free;
            this.DDOHGJPCFNF.KOFJBKAKBNL.angularZMotion = ConfigurableJointMotion.Free;
            this.EOJOOCHKJGJ.positionSpring = 0f;
            base.StartCoroutine(this.GDNGNIDGPCK());
        }

        protected override void GCAPLNOJOFM(GameObject MAKHHGBKEKA)
        {
            base.Owner = MAKHHGBKEKA;
            this.theOtherNunchuks.Owner = MAKHHGBKEKA;
        }


        private void EBAOFPGLAJJ()
        {
            PhysicMaterial material = this.IIEFNHCDIEN.material;
            material.dynamicFriction = 0f;
            material.staticFriction = 0f;
            PhysicMaterial material2 = this.theOtherNunchuks.IIEFNHCDIEN.material;
            material2.dynamicFriction = 0f;
            material2.staticFriction = 0f;
        }


        private IEnumerator PMGJMAMIAHE()
        {
            base.LGLOPGKONLO.maxAngularVelocity = 80f;
            this.theOtherNunchuks.LGLOPGKONLO.maxAngularVelocity = 80f;
            this.theOtherNunchuks.OHIAODBCHHM = this.IEDNGFIDBBL.characterStates.Power * 0.5f + 0.5f;
            this.LKOIGOGJDGG = true;
            base.IsAttacking = true;
            this.theOtherNunchuks.IsAttacking = true;
            this.theOtherNunchuks.LMOPCBGKBID = true;
            this.theOtherNunchuks.LGLOPGKONLO.mass = 0.1f;
            this.KHDFBBADOIL.massScale = 4f;
            this.theOtherNunchuks.KHDFBBADOIL.massScale = 0.25f;
            Quaternion targetRotation = this.IEDNGFIDBBL.NLEHLJPKLCH.targetRotation;
            Quaternion targetRotation2 = this.IEDNGFIDBBL.CDBGCHHHPFL.targetRotation;
            Quaternion targetRotation3 = this.IEDNGFIDBBL.GDPPIFIJPMF.targetRotation;
            Quaternion targetRotation4 = this.IEDNGFIDBBL.BBMLJFHODAL.targetRotation;
            Quaternion targetRotation5 = this.IEDNGFIDBBL.AKFKHFBDPBI.targetRotation;
            Quaternion targetRotation6 = this.IEDNGFIDBBL.GIGHLANHALH.targetRotation;
            float num = 0.25f;
            float num2 = num;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                    float t = 1f - num2 / num;
                    this.OGNIDODGHNE = Quaternion.Slerp(targetRotation, this.DCCPCBOMNLE, t);
                    this.MDIGAEGPEMC = Quaternion.Slerp(targetRotation2, this.FGEMKHAMNBO, t);
                    this.NLHJIPDINBC = Quaternion.Slerp(targetRotation3, this.IKPGDPOLOLI, t);
                    this.AHLLJNLFCFP = Quaternion.Slerp(targetRotation4, this.HLKJEPCDFKF, t);
                    this.IMLKFAOMBED = Quaternion.Slerp(targetRotation5, this.GAHKJMJJIOE, t);
                    this.DIJCCKNLFHG = Quaternion.Slerp(targetRotation6, this.AOAFBMEOKMN, t);
                    Transform transform = this.IEDNGFIDBBL.GreenChest.transform;
                    Transform transform2 = this.IEDNGFIDBBL.GreenFistR.transform;
                    Vector3 position = this.AddForcePos.position;
                    base.LGLOPGKONLO.AddForceAtPosition(Vector3.Slerp(Vector3.Cross(transform2.right, position - transform2.position).normalized, transform.right, 0.3f) * 300f, position, ForceMode.Acceleration);
                }
                yield return this.MJOFAKABBGM;
            }
            num2 = 0.07f;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            num = 0.13f;
            num2 = num;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                    float t2 = 1f - num2 / num;
                    this.OGNIDODGHNE = Quaternion.Slerp(this.DCCPCBOMNLE, this.JICCCPJLJOH, t2);
                    this.MDIGAEGPEMC = Quaternion.Slerp(this.FGEMKHAMNBO, this.OMGBOFJONMH, t2);
                    this.NLHJIPDINBC = Quaternion.Slerp(this.IKPGDPOLOLI, this.KAIFKOIAJMC, t2);
                    this.AHLLJNLFCFP = Quaternion.Slerp(this.HLKJEPCDFKF, this.KCNGKGOFGJC, t2);
                    this.IMLKFAOMBED = Quaternion.Slerp(this.GAHKJMJJIOE, this.CPEKPGDPPMF, t2);
                    this.DIJCCKNLFHG = Quaternion.Slerp(this.AOAFBMEOKMN, this.IFGKKDNGALJ, t2);
                    Transform transform3 = this.IEDNGFIDBBL.GreenChest.transform;
                    Vector3 position2 = this.AddForcePos.position;
                    base.LGLOPGKONLO.AddForceAtPosition(Vector3.Cross(position2 - this.IEDNGFIDBBL.GreenUpperArmR.transform.position, transform3.right).normalized * 500f, position2, ForceMode.Acceleration);
                }
                yield return this.MJOFAKABBGM;
            }
            num2 = 0.1f;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            num = 0.13f;
            num2 = num;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                    float t3 = 1f - num2 / num;
                    this.OGNIDODGHNE = Quaternion.Slerp(this.JICCCPJLJOH, this.DCCPCBOMNLE, t3);
                    this.MDIGAEGPEMC = Quaternion.Slerp(this.OMGBOFJONMH, this.FGEMKHAMNBO, t3);
                    this.NLHJIPDINBC = Quaternion.Slerp(this.KAIFKOIAJMC, this.IKPGDPOLOLI, t3);
                    this.AHLLJNLFCFP = Quaternion.Slerp(this.KCNGKGOFGJC, this.HLKJEPCDFKF, t3);
                    this.IMLKFAOMBED = Quaternion.Slerp(this.CPEKPGDPPMF, this.GAHKJMJJIOE, t3);
                    this.DIJCCKNLFHG = Quaternion.Slerp(this.IFGKKDNGALJ, this.AOAFBMEOKMN, t3);
                    Transform transform4 = this.IEDNGFIDBBL.GreenFistR.transform;
                    Vector3 position3 = this.AddForcePos.position;
                    base.LGLOPGKONLO.AddForceAtPosition(Vector3.Cross(transform4.right, position3 - transform4.position).normalized * 400f, position3, ForceMode.Acceleration);
                }
                yield return this.MJOFAKABBGM;
            }
            num2 = 0.1f;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            num = 0.13f;
            num2 = num;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                    float t4 = 1f - num2 / num;
                    this.OGNIDODGHNE = Quaternion.Slerp(this.DCCPCBOMNLE, this.JICCCPJLJOH, t4);
                    this.MDIGAEGPEMC = Quaternion.Slerp(this.FGEMKHAMNBO, this.OMGBOFJONMH, t4);
                    this.NLHJIPDINBC = Quaternion.Slerp(this.IKPGDPOLOLI, this.KAIFKOIAJMC, t4);
                    this.AHLLJNLFCFP = Quaternion.Slerp(this.HLKJEPCDFKF, this.KCNGKGOFGJC, t4);
                    this.IMLKFAOMBED = Quaternion.Slerp(this.GAHKJMJJIOE, this.CPEKPGDPPMF, t4);
                    this.DIJCCKNLFHG = Quaternion.Slerp(this.AOAFBMEOKMN, this.IFGKKDNGALJ, t4);
                    Transform transform5 = this.IEDNGFIDBBL.GreenChest.transform;
                    Vector3 position4 = this.AddForcePos.position;
                    base.LGLOPGKONLO.AddForceAtPosition(Vector3.Cross(position4 - this.IEDNGFIDBBL.GreenUpperArmR.transform.position, transform5.right).normalized * 500f, position4, ForceMode.Acceleration);
                }
                yield return this.MJOFAKABBGM;
            }
            num2 = 0.05f;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            base.IsAttacking = false;
            this.theOtherNunchuks.IsAttacking = false;
            this.theOtherNunchuks.LMOPCBGKBID = false;
            this.theOtherNunchuks.LGLOPGKONLO.mass = this.theOtherNunchuks.GrabbedWeight;
            this.KHDFBBADOIL.massScale = 1f;
            this.theOtherNunchuks.KHDFBBADOIL.massScale = 1f;
            base.LGLOPGKONLO.maxAngularVelocity = 15f;
            this.theOtherNunchuks.LGLOPGKONLO.maxAngularVelocity = 15f;
            if (base.Owner == null)
            {
                this.theOtherNunchuks.LGLOPGKONLO.velocity *= 0.125f;
                this.theOtherNunchuks.LGLOPGKONLO.angularVelocity *= 0.125f;
            }
            this.ELKGPHKKJBF = true;
            num = 0.3f;
            num2 = num;
            while (num2 > 0f && base.Owner != null && !base.IsAttacking)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                    float t5 = 1f - num2 / num;
                    this.NLHJIPDINBC = Quaternion.Slerp(this.KAIFKOIAJMC, this.PELEICHHALC, t5);
                    this.AHLLJNLFCFP = Quaternion.Slerp(this.KCNGKGOFGJC, this.ECIMPFANDPP, t5);
                    this.IMLKFAOMBED = Quaternion.Slerp(this.CPEKPGDPPMF, this.CBEFGDJCCNC, t5);
                    this.DIJCCKNLFHG = Quaternion.Slerp(this.IFGKKDNGALJ, this.NKBNHINDAIE, t5);
                }
                yield return this.MJOFAKABBGM;
            }
            this.ELKGPHKKJBF = false;
            if (!base.IsAttacking)
            {
                this.LKOIGOGJDGG = false;
            }
            yield break;
        }

        internal override void CFFDMBHGHFE(Quaternion OBBHADEMJNK)
        {
            if (this.isPart0)
            {
                base.JCGCLLMLCLH.rotation = OBBHADEMJNK;
                this.theOtherNunchuks.JCGCLLMLCLH.rotation = OBBHADEMJNK * this.JAKFEMPEPEF;
                this.jointRigidbody.transform.rotation = OBBHADEMJNK * this.LOBPLPFJILD;
                Matrix4x4 localToWorldMatrix = base.JCGCLLMLCLH.localToWorldMatrix;
                this.theOtherNunchuks.LGLOPGKONLO.transform.position = localToWorldMatrix.MultiplyPoint3x4(this.GODMMBJPNLB);
                this.jointRigidbody.transform.position = localToWorldMatrix.MultiplyPoint3x4(this.HBONAEOPMCA);
            }
        }



        private IEnumerator NNAINJLOMFL()
        {
            base.LGLOPGKONLO.maxAngularVelocity = 80f;
            this.theOtherNunchuks.LGLOPGKONLO.maxAngularVelocity = 80f;
            this.theOtherNunchuks.OHIAODBCHHM = this.IEDNGFIDBBL.characterStates.Power * 0.5f + 0.5f;
            this.LKOIGOGJDGG = true;
            base.IsAttacking = true;
            this.theOtherNunchuks.IsAttacking = true;
            this.theOtherNunchuks.LMOPCBGKBID = true;
            this.theOtherNunchuks.LGLOPGKONLO.mass = 0.1f;
            this.KHDFBBADOIL.massScale = 4f;
            this.theOtherNunchuks.KHDFBBADOIL.massScale = 0.25f;
            Quaternion targetRotation = this.IEDNGFIDBBL.NLEHLJPKLCH.targetRotation;
            Quaternion targetRotation2 = this.IEDNGFIDBBL.CDBGCHHHPFL.targetRotation;
            Quaternion targetRotation3 = this.IEDNGFIDBBL.GDPPIFIJPMF.targetRotation;
            Quaternion targetRotation4 = this.IEDNGFIDBBL.BBMLJFHODAL.targetRotation;
            Quaternion targetRotation5 = this.IEDNGFIDBBL.AKFKHFBDPBI.targetRotation;
            Quaternion targetRotation6 = this.IEDNGFIDBBL.GIGHLANHALH.targetRotation;
            float num = 0.13f;
            float num2 = num;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                    float t = 1f - num2 / num;
                    this.OGNIDODGHNE = Quaternion.Slerp(targetRotation, this.BEBGFBJKJNE, t);
                    this.MDIGAEGPEMC = Quaternion.Slerp(targetRotation2, this.GAALLMILMBH, t);
                    this.NLHJIPDINBC = Quaternion.Slerp(targetRotation3, this.ANMCNCDDIML, t);
                    this.AHLLJNLFCFP = Quaternion.Slerp(targetRotation4, this.CDENLMOFOEE, t);
                    this.IMLKFAOMBED = Quaternion.Slerp(targetRotation5, this.EEPIODHDBEP, t);
                    this.DIJCCKNLFHG = Quaternion.Slerp(targetRotation6, this.KJJNFBFMEHI, t);
                    Transform transform = this.IEDNGFIDBBL.GreenFistR.transform;
                    Vector3 position = this.AddForcePos.position;
                    Vector3 right = transform.right;
                    base.LGLOPGKONLO.AddForceAtPosition(Vector3.Slerp(Vector3.Cross(right, position - transform.position).normalized, right, 0.8f) * 500f, position, ForceMode.Acceleration);
                }
                yield return this.MJOFAKABBGM;
            }
            num2 = 0.15f;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            num = 0.13f;
            num2 = num;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                    float t2 = 1f - num2 / num;
                    this.OGNIDODGHNE = Quaternion.Slerp(this.BEBGFBJKJNE, this.KFMHKLPIBFB, t2);
                    this.MDIGAEGPEMC = Quaternion.Slerp(this.GAALLMILMBH, this.EINOGCHHOIK, t2);
                    this.NLHJIPDINBC = Quaternion.Slerp(this.ANMCNCDDIML, this.PFKGCLLLJGM, t2);
                    this.AHLLJNLFCFP = Quaternion.Slerp(this.CDENLMOFOEE, this.CPOCINNJHAA, t2);
                    this.IMLKFAOMBED = Quaternion.Slerp(this.EEPIODHDBEP, this.IECGCMIFHPG, t2);
                    this.DIJCCKNLFHG = Quaternion.Slerp(this.KJJNFBFMEHI, this.ACMHLDMDAJN, t2);
                    Transform transform2 = this.IEDNGFIDBBL.GreenChest.transform;
                    Vector3 position2 = this.AddForcePos.position;
                    base.LGLOPGKONLO.AddForceAtPosition(Vector3.Cross(transform2.forward, position2 - transform2.position).normalized * -600f, position2, ForceMode.Acceleration);
                }
                yield return this.MJOFAKABBGM;
            }
            num2 = 0.15f;
            while (num2 > 0f && base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            base.IsAttacking = false;
            this.theOtherNunchuks.IsAttacking = false;
            this.theOtherNunchuks.LMOPCBGKBID = false;
            this.theOtherNunchuks.LGLOPGKONLO.mass = this.theOtherNunchuks.GrabbedWeight;
            this.KHDFBBADOIL.massScale = 1f;
            this.theOtherNunchuks.KHDFBBADOIL.massScale = 1f;
            base.LGLOPGKONLO.maxAngularVelocity = 15f;
            this.theOtherNunchuks.LGLOPGKONLO.maxAngularVelocity = 15f;
            if (base.Owner == null)
            {
                this.theOtherNunchuks.LGLOPGKONLO.velocity *= 0.125f;
                this.theOtherNunchuks.LGLOPGKONLO.angularVelocity *= 0.125f;
            }
            this.FKBGMCPNCEO = true;
            num = 0.5f;
            num2 = num;
            while (num2 > 0f && base.Owner != null && !base.IsAttacking)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num2 -= Time.fixedDeltaTime;
                    float t3 = 1f - num2 / num;
                    if (num2 < 0.2f)
                    {
                        this.FKBGMCPNCEO = false;
                    }
                    this.OGNIDODGHNE = Quaternion.Slerp(this.KFMHKLPIBFB, Quaternion.identity, t3);
                    this.MDIGAEGPEMC = Quaternion.Slerp(this.EINOGCHHOIK, Quaternion.identity, t3);
                    this.NLHJIPDINBC = Quaternion.Slerp(this.PFKGCLLLJGM, this.PELEICHHALC, t3);
                    this.AHLLJNLFCFP = Quaternion.Slerp(this.CPOCINNJHAA, this.ECIMPFANDPP, t3);
                    this.IMLKFAOMBED = Quaternion.Slerp(this.IECGCMIFHPG, this.CBEFGDJCCNC, t3);
                    this.DIJCCKNLFHG = Quaternion.Slerp(this.ACMHLDMDAJN, this.NKBNHINDAIE, t3);
                }
                yield return this.MJOFAKABBGM;
            }
            this.FKBGMCPNCEO = false;
            if (!base.IsAttacking)
            {
                this.LKOIGOGJDGG = false;
            }
            yield break;
        }

        internal override void GDENHBKDDGO()
        {
            base.GDENHBKDDGO();
            if (this.DDOHGJPCFNF != null)
            {
                this.DDOHGJPCFNF.OnDestroy();
            }
        }

        internal override void LDCAMGLJFJG()
        {
            if (this.isPart0)
            {
                base.LGLOPGKONLO.angularVelocity = Vector3.zero;
                this.jointRigidbody.angularVelocity = Vector3.zero;
                this.theOtherNunchuks.LGLOPGKONLO.angularVelocity = Vector3.zero;
            }
        }


        private IEnumerator JADECKCKANJ()
        {
            base.LGLOPGKONLO.maxAngularVelocity = 80f;
            this.theOtherNunchuks.LGLOPGKONLO.maxAngularVelocity = 80f;
            this.theOtherNunchuks.OHIAODBCHHM = this.IEDNGFIDBBL.characterStates.Power * 0.5f + 0.5f;
            this.LKOIGOGJDGG = true;
            base.IsAttacking = true;
            this.theOtherNunchuks.IsAttacking = true;
            this.theOtherNunchuks.LMOPCBGKBID = true;
            this.theOtherNunchuks.LGLOPGKONLO.mass = 0.1f;
            this.KHDFBBADOIL.massScale = 4f;
            this.theOtherNunchuks.KHDFBBADOIL.massScale = 0.25f;
            //targetRotation = this.IEDNGFIDBBL.NLEHLJPKLCH.targetRotation;
            //targetRotation2 = this.IEDNGFIDBBL.CDBGCHHHPFL.targetRotation;
            //targetRotation3 = this.IEDNGFIDBBL.GDPPIFIJPMF.targetRotation;
            //targetRotation4 = this.IEDNGFIDBBL.BBMLJFHODAL.targetRotation;
            //targetRotation5 = this.IEDNGFIDBBL.AKFKHFBDPBI.targetRotation;
            //targetRotation6 = this.IEDNGFIDBBL.GIGHLANHALH.targetRotation;
            //num = 0.25f;
            //num2 = num;
            while (/*num2 > 0f &&*/ base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num2 -= Time.fixedDeltaTime;
                    float t = 1f /*- num2 / num*/;
                    //this.OGNIDODGHNE = Quaternion.Slerp(targetRotation, this.KFMHKLPIBFB, t);
                    //this.MDIGAEGPEMC = Quaternion.Slerp(targetRotation2, this.EINOGCHHOIK, t);
                    //this.NLHJIPDINBC = Quaternion.Slerp(targetRotation3, this.PFKGCLLLJGM, t);
                    //this.AHLLJNLFCFP = Quaternion.Slerp(targetRotation4, this.CPOCINNJHAA, t);
                    //this.IMLKFAOMBED = Quaternion.Slerp(targetRotation5, this.IECGCMIFHPG, t);
                    //this.DIJCCKNLFHG = Quaternion.Slerp(targetRotation6, this.ACMHLDMDAJN, t);
                    Transform transform = this.IEDNGFIDBBL.GreenChest.transform;
                    Vector3 position = this.AddForcePos.position;
                    base.LGLOPGKONLO.AddForceAtPosition(Vector3.Cross(transform.forward, position - this.IEDNGFIDBBL.GreenUpperArmR.transform.position).normalized * -200f, position, ForceMode.Acceleration);
                }
                yield return this.MJOFAKABBGM;
            }
            //num2 = 0.07f;
            while (/*num2 > 0f &&*/ base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num2 -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            //num = 0.13f;
            //num2 = num;
            while (/*num2 > 0f &&*/ base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num2 -= Time.fixedDeltaTime;
                    float t2 = 1f /*- num2 / num*/;
                    this.OGNIDODGHNE = Quaternion.Slerp(this.KFMHKLPIBFB, this.BEBGFBJKJNE, t2);
                    this.MDIGAEGPEMC = Quaternion.Slerp(this.EINOGCHHOIK, this.GAALLMILMBH, t2);
                    this.NLHJIPDINBC = Quaternion.Slerp(this.PFKGCLLLJGM, this.ANMCNCDDIML, t2);
                    this.AHLLJNLFCFP = Quaternion.Slerp(this.CPOCINNJHAA, this.CDENLMOFOEE, t2);
                    this.IMLKFAOMBED = Quaternion.Slerp(this.IECGCMIFHPG, this.EEPIODHDBEP, t2);
                    this.DIJCCKNLFHG = Quaternion.Slerp(this.ACMHLDMDAJN, this.KJJNFBFMEHI, t2);
                    Transform transform2 = this.IEDNGFIDBBL.GreenFistR.transform;
                    Vector3 position2 = this.AddForcePos.position;
                    Vector3 right = transform2.right;
                    base.LGLOPGKONLO.AddForceAtPosition(Vector3.Slerp(Vector3.Cross(right, position2 - transform2.position).normalized, right, 0.8f) * 500f, position2, ForceMode.Acceleration);
                }
                yield return this.MJOFAKABBGM;
            }
            //num2 = 0.15f;
            while (/*num2 > 0f &&*/ base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num2 -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            //num = 0.13f;
            //num2 = num;
            while (/*num2 > 0f && */base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num2 -= Time.fixedDeltaTime;
                    float t3 = 1f /*- num2 / num*/;
                    this.OGNIDODGHNE = Quaternion.Slerp(this.BEBGFBJKJNE, this.KFMHKLPIBFB, t3);
                    this.MDIGAEGPEMC = Quaternion.Slerp(this.GAALLMILMBH, this.EINOGCHHOIK, t3);
                    this.NLHJIPDINBC = Quaternion.Slerp(this.ANMCNCDDIML, this.PFKGCLLLJGM, t3);
                    this.AHLLJNLFCFP = Quaternion.Slerp(this.CDENLMOFOEE, this.CPOCINNJHAA, t3);
                    this.IMLKFAOMBED = Quaternion.Slerp(this.EEPIODHDBEP, this.IECGCMIFHPG, t3);
                    this.DIJCCKNLFHG = Quaternion.Slerp(this.KJJNFBFMEHI, this.ACMHLDMDAJN, t3);
                    Transform transform3 = this.IEDNGFIDBBL.GreenChest.transform;
                    Vector3 position3 = this.AddForcePos.position;
                    base.LGLOPGKONLO.AddForceAtPosition(Vector3.Cross(transform3.forward, position3 - transform3.position).normalized * -600f, position3, ForceMode.Acceleration);
                }
                yield return this.MJOFAKABBGM;
            }
            //num2 = 0.15f;
            while (/*num2 > 0f &&*/ base.Owner != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num2 -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            base.IsAttacking = false;
            this.theOtherNunchuks.IsAttacking = false;
            this.theOtherNunchuks.LMOPCBGKBID = false;
            this.theOtherNunchuks.LGLOPGKONLO.mass = this.theOtherNunchuks.GrabbedWeight;
            this.KHDFBBADOIL.massScale = 1f;
            this.theOtherNunchuks.KHDFBBADOIL.massScale = 1f;
            base.LGLOPGKONLO.maxAngularVelocity = 15f;
            this.theOtherNunchuks.LGLOPGKONLO.maxAngularVelocity = 15f;
            if (base.Owner == null)
            {
                this.theOtherNunchuks.LGLOPGKONLO.velocity *= 0.125f;
                this.theOtherNunchuks.LGLOPGKONLO.angularVelocity *= 0.125f;
            }
            this.FKBGMCPNCEO = true;
            //num = 0.5f;
            //num2 = num;
            while (/*num2 > 0f &&*/ base.Owner != null && !base.IsAttacking)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num2 -= Time.fixedDeltaTime;
                    float t4 = 1f /*- num2 / num*/;
                    //if (num2 < 0.2f)
                    //{
                    //    this.FKBGMCPNCEO = false;
                    //}
                    this.OGNIDODGHNE = Quaternion.Slerp(this.KFMHKLPIBFB, Quaternion.identity, t4);
                    this.MDIGAEGPEMC = Quaternion.Slerp(this.EINOGCHHOIK, Quaternion.identity, t4);
                    this.NLHJIPDINBC = Quaternion.Slerp(this.PFKGCLLLJGM, this.PELEICHHALC, t4);
                    this.AHLLJNLFCFP = Quaternion.Slerp(this.CPOCINNJHAA, this.ECIMPFANDPP, t4);
                    this.IMLKFAOMBED = Quaternion.Slerp(this.IECGCMIFHPG, this.CBEFGDJCCNC, t4);
                    this.DIJCCKNLFHG = Quaternion.Slerp(this.ACMHLDMDAJN, this.NKBNHINDAIE, t4);
                }
                yield return this.MJOFAKABBGM;
            }
            this.FKBGMCPNCEO = false;
            if (!base.IsAttacking)
            {
                this.LKOIGOGJDGG = false;
            }
            yield break;
        }


        internal override void IKIJBENLEFE()
        {
            base.LGLOPGKONLO.mass = this.GrabbedWeight;
            this.theOtherNunchuks.LGLOPGKONLO.mass = this.theOtherNunchuks.GrabbedWeight;
            base.LGLOPGKONLO.useGravity = false;
            this.GIMLHCAFDDG();
            base.LGLOPGKONLO.maxAngularVelocity = 15f;
            this.theOtherNunchuks.LGLOPGKONLO.maxAngularVelocity = 15f;
            this.ALFHAGOINHB = true;
            this.EBAOFPGLAJJ();
            this.theOtherNunchuks.FKIELAEFBOA = 0f;
        }




        internal override void AGIKMKKNICC()
        {
            this.weaponController.JGBLPPKMAMA();
            if (this.FKBGMCPNCEO)
            {
                base.StartCoroutine(this.NNAINJLOMFL());
                this.theOtherNunchuks.FKIELAEFBOA += 0.01f;
                return;
            }
            if (this.ELKGPHKKJBF)
            {
                base.StartCoroutine(this.JADECKCKANJ());
                this.theOtherNunchuks.FKIELAEFBOA += 0.005f;
                return;
            }
            base.StartCoroutine(this.PMGJMAMIAHE());
            this.theOtherNunchuks.FKIELAEFBOA += 0.003f;
        }

        internal override void PDCFAMMLLCG(Vector3 LPDJIJPIHBC)
        {
            if (this.isPart0)
            {
                base.JCGCLLMLCLH.position = LPDJIJPIHBC;
                Matrix4x4 localToWorldMatrix = base.JCGCLLMLCLH.localToWorldMatrix;
                this.theOtherNunchuks.LGLOPGKONLO.transform.position = localToWorldMatrix.MultiplyPoint3x4(this.GODMMBJPNLB);
                this.jointRigidbody.transform.position = localToWorldMatrix.MultiplyPoint3x4(this.HBONAEOPMCA);
            }
        }



        private void IJKKFNGAHFG()
        {
            this.IIEFNHCDIEN.center = this.IDAOBJAHIGG;
            this.IIEFNHCDIEN.height = this.GKBMMLAKNFK;
        }


        private void JACDOONBPMN(ConfigurableJoint DEIMKLMOEKJ, JointDrive LBNMFIJGHFG, Quaternion BMHBHBBGFMC)
        {
            DEIMKLMOEKJ.angularXDrive = LBNMFIJGHFG;
            DEIMKLMOEKJ.angularYZDrive = LBNMFIJGHFG;
            DEIMKLMOEKJ.targetRotation = BMHBHBBGFMC;
        }




        private IEnumerator GDNGNIDGPCK()
        {
            while (this.EOJOOCHKJGJ.positionSpring < 100f && this.DDOHGJPCFNF != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    this.EOJOOCHKJGJ.positionSpring = this.EOJOOCHKJGJ.positionSpring + Time.fixedDeltaTime * 100f;
                    this.DDOHGJPCFNF.KOFJBKAKBNL.angularXDrive = this.EOJOOCHKJGJ;
                    this.DDOHGJPCFNF.KOFJBKAKBNL.angularYZDrive = this.EOJOOCHKJGJ;
                }
                yield return this.MJOFAKABBGM;
            }
            yield break;
        }






        private void GHLMAPJNNND()
        {
            PhysicMaterial material = this.IIEFNHCDIEN.material;
            material.dynamicFriction = 0.6f;
            material.staticFriction = 0.6f;
            PhysicMaterial material2 = this.theOtherNunchuks.IIEFNHCDIEN.material;
            material2.dynamicFriction = 0.6f;
            material2.staticFriction = 0.6f;
        }


        internal override void GHGLMNMONHK(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, bool DOLMJFFJFBH, bool PKGLIMPDIIP)
        {
            if (this.LKOIGOGJDGG)
            {
                MCFOLNMFCPN.AJBEMNONLMC.targetRotation = this.MEFDCAMLLIP;
                return;
            }
            MCFOLNMFCPN.AJBEMNONLMC.targetRotation = this.INBCNJNLOIB;
        }



        private void GIMLHCAFDDG()
        {
            this.IIEFNHCDIEN.center = this.equippedColliderCenter;
            this.IIEFNHCDIEN.height = this.equippedColliderHeight;
        }









        internal override void DPMCHIFEGKO(PhysicCharacterController MCFOLNMFCPN, ref bool OGMMABHJCNI)
        {
            if (MCFOLNMFCPN.WeaponGrabbed)
            {
                return;
            }
            if (base.Owner != null && base.Owner != MCFOLNMFCPN.gameObject)
            {
                MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                OGMMABHJCNI = false;
                return;
            }
            this.LIFGGMBLIBC = 0.2f;
            Vector3 b = MCFOLNMFCPN.GreenFistR.transform.localToWorldMatrix.MultiplyPoint3x4(this.GFOEBGAGIEI);
            if (this.DDOHGJPCFNF == null)
            {
                Vector3 from = this.grabPositions[0].position - MCFOLNMFCPN.GreenHip.transform.position;
                if (Vector3.Angle(from, -MCFOLNMFCPN.GreenHip.transform.up) > 100f)
                {
                    MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                    OGMMABHJCNI = false;
                    return;
                }
                if (from.magnitude > 1.4f)
                {
                    MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                    OGMMABHJCNI = false;
                    return;
                }
                ConfigurableJoint configurableJoint = MCFOLNMFCPN.NLEHLJPKLCH;
                configurableJoint.angularXDrive = this.MBIIDHPNNMB;
                configurableJoint.angularYZDrive = this.MBIIDHPNNMB;
                MCFOLNMFCPN.FIIKBADHOJH.AddForce(-MCFOLNMFCPN.GreenChest.transform.up * 5f, ForceMode.Acceleration);
                Vector3 a = this.grabPositions[0].position - b;
                MCFOLNMFCPN.PIMHHNKOCBE.velocity = Vector3.ClampMagnitude(a * 200f, 8f);
                MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = true;
                if (a.magnitude < 0.15f)
                {
                    this.NPGPPIPPLNB(MCFOLNMFCPN.GreenFistR, this.GFOEBGAGIEI, this.grabPositions[0].localPosition);
                    MCFOLNMFCPN.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon;
                    MCFOLNMFCPN.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon;
                    this.GCAPLNOJOFM(MCFOLNMFCPN.gameObject);
                    base.weaponIsEquipped = true;
                    MCFOLNMFCPN.grabbedWeaponGo = base.gameObject;
                    MCFOLNMFCPN.WeaponGrabbed = true;
                    MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                }
            }
        }


        internal override void DMJOIPHGHEB(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
            if (this.LKOIGOGJDGG)
            {
                this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.DFPPLFCNLKA, this.NLHJIPDINBC);
                this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.KNALMMLKGKD, this.AHLLJNLFCFP);
                return;
            }
            if (PKGLIMPDIIP)
            {
                if ((BNLPAPMFDLL < 0.3f && !DOLMJFFJFBH) || (BNLPAPMFDLL < 0.15f && DOLMJFFJFBH))
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.BIEMKFMCKIK, this.PELEICHHALC);
                    this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.FOAFEJJLLOD, this.ECIMPFANDPP);
                    return;
                }
                float num = (Mathf.Sin(AGCJDIFCAKA + 0.5f) + 1f) * 0.5f;
                if (GHMBNLHGMHG)
                {
                    num = -num + 1f;
                }
                Quaternion bmhbhbbgfmc = Quaternion.Slerp(this.PNDFCBCNNKB, this.LNCCGKJDALM, num);
                Quaternion bmhbhbbgfmc2 = Quaternion.Slerp(this.LKAOACEIJKP, this.KMDNGHCOIDC, num);
                if (DOLMJFFJFBH)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.IEHMKECLCHB, bmhbhbbgfmc);
                    this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.HMOLGLHMABM, bmhbhbbgfmc2);
                    return;
                }
                this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.LONEFNPNIIM, bmhbhbbgfmc);
                this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.IMIKGCOGHMH, bmhbhbbgfmc2);
                return;
            }
            else
            {
                if (DPKCPMHPAAJ < 0.8f)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.KGHNAIMAMAL, this.MAKLLFFDJBD);
                    this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.EIDOLGBABMO, this.KIKEBPPDADI);
                    return;
                }
                if (AGCJDIFCAKA <= 0f)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.KGHNAIMAMAL, this.PELEICHHALC);
                    this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.EIDOLGBABMO, this.ECIMPFANDPP);
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
                this.JACDOONBPMN(MCFOLNMFCPN.GDPPIFIJPMF, this.AOCCMBICIEG, Quaternion.Euler(zero));
                this.JACDOONBPMN(MCFOLNMFCPN.BBMLJFHODAL, this.DIDCGKAFLOI, this.ECIMPFANDPP);
                return;
            }
        }





        internal override void HPMGJPMEFED(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
            if (this.LKOIGOGJDGG)
            {
                this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.NNBDMMHAIPO, this.IMLKFAOMBED);
                this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.DMFJODOLBAM, this.DIJCCKNLFHG);
                return;
            }
            if (PKGLIMPDIIP)
            {
                if ((BNLPAPMFDLL < 0.3f && !DOLMJFFJFBH) || (BNLPAPMFDLL < 0.15f && DOLMJFFJFBH))
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.OJIPDAGFBPC, this.CBEFGDJCCNC);
                    this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.ICLFAJOONAM, this.NKBNHINDAIE);
                    return;
                }
                float num = (Mathf.Sin(AGCJDIFCAKA + 3.14159f + 0.5f) + 1f) * 0.5f;
                if (GHMBNLHGMHG)
                {
                    num = -num + 1f;
                }
                Quaternion bmhbhbbgfmc = Quaternion.Slerp(this.GKOAAPJNHKG, this.ALEHILLCEIM, num);
                Quaternion bmhbhbbgfmc2 = Quaternion.Slerp(this.KDCJLFPGMNL, this.FMEKMHFADIP, num);
                if (DOLMJFFJFBH)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.LJIFNFPEFPN, bmhbhbbgfmc);
                    this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.BFJFJGCFGAE, bmhbhbbgfmc2);
                    return;
                }
                this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.PNPFJAODMMN, bmhbhbbgfmc);
                this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.LGGLCGFHLDB, bmhbhbbgfmc2);
                return;
            }
            else
            {
                if (DPKCPMHPAAJ < 0.8f)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.LIBMABDFJBO, this.CAKGDLJNPFK);
                    this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.EBCNAINPJFB, this.JCDAGNIALPB);
                    return;
                }
                if (AGCJDIFCAKA <= 0f)
                {
                    this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.LIBMABDFJBO, this.CBEFGDJCCNC);
                    this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.EBCNAINPJFB, this.NKBNHINDAIE);
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
                this.JACDOONBPMN(MCFOLNMFCPN.AKFKHFBDPBI, this.OPEFEAAAPGF, Quaternion.Euler(zero));
                this.JACDOONBPMN(MCFOLNMFCPN.GIGHLANHALH, this.IMBFPOEPGEB, this.NKBNHINDAIE);
                return;
            }
        }


        private void OnCollisionEnter(Collision NLJBANLOGGI)
        {
            if (NLJBANLOGGI.gameObject.layer == base.gameObject.layer)
            {
                return;
            }
            if (this.ALFHAGOINHB)
            {
                return;
            }
            if (!(base.Owner != null) || !this.IEDNGFIDBBL.IINJFJOIHMK.Contains(NLJBANLOGGI.gameObject))
            {
                base.KOPJDFGNKLE(NLJBANLOGGI, ref this.LMOPCBGKBID, this.OHIAODBCHHM, 0.54f, true, 40f, 18f);
                return;
            }
            if (!this.LMOPCBGKBID)
            {
                return;
            }
            if (UnityEngine.Random.Range(0f, 1f) < this.FKIELAEFBOA)
            {
                base.KOPJDFGNKLE(NLJBANLOGGI, ref this.LMOPCBGKBID, this.OHIAODBCHHM, 0.54f, false, 40f, 7f);
                return;
            }
        }

        protected override void Awake()
        {
            this.IDAOBJAHIGG = this.IIEFNHCDIEN.center;
            this.GKBMMLAKNFK = this.IIEFNHCDIEN.height;
            PhysicMaterial material = new PhysicMaterial
            {
                dynamicFriction = 0.6f,
                staticFriction = 0.6f,
                frictionCombine = PhysicMaterialCombine.Minimum
            };
            this.IIEFNHCDIEN.material = material;
            this.jointRigidbody.maxAngularVelocity = 80f;
            foreach (ConfigurableJoint configurableJoint in this.jointRigidbody.gameObject.GetComponents<ConfigurableJoint>())
            {
                if (configurableJoint.connectedBody == base.LGLOPGKONLO)
                {
                    this.KHDFBBADOIL = configurableJoint;
                }
            }
            base.Awake();
            base.PowerConsume = 0.04f;
            base.NoPowerRecoverCD = 1.5f;
            if (this.isPart0)
            {
                Matrix4x4 worldToLocalMatrix = base.JCGCLLMLCLH.worldToLocalMatrix;
                Quaternion rotation = base.JCGCLLMLCLH.rotation;
                this.GODMMBJPNLB = worldToLocalMatrix.MultiplyPoint3x4(this.theOtherNunchuks.JCGCLLMLCLH.position);
                this.JAKFEMPEPEF = Quaternion.Inverse(rotation) * this.theOtherNunchuks.JCGCLLMLCLH.rotation;
                this.HBONAEOPMCA = worldToLocalMatrix.MultiplyPoint3x4(this.jointRigidbody.transform.position);
                this.LOBPLPFJILD = Quaternion.Inverse(rotation) * this.jointRigidbody.transform.rotation;
            }
        }


        private CapsuleCollider IIEFNHCDIEN
        {
            get
            {
                if (this.FBFPGFDOJCG == null)
                {
                    this.FBFPGFDOJCG = base.GetComponent<CapsuleCollider>();
                }
                return this.FBFPGFDOJCG;
            }
        }

        public WeaponNunchucks theOtherNunchuks;

        public Rigidbody jointRigidbody;

        private ConfigurableJoint KHDFBBADOIL;

        public Transform AddForcePos;

        private float OHIAODBCHHM;

        private bool ALFHAGOINHB;

        private WeaponJoint DDOHGJPCFNF;

        private Vector3 GFOEBGAGIEI = new Vector3(-0.0485f, 0f, 0.1326f);

        private bool LKOIGOGJDGG;

        public bool isPart0;

        private Vector3 GODMMBJPNLB;

        private Quaternion JAKFEMPEPEF;

        private Vector3 HBONAEOPMCA;

        private Quaternion LOBPLPFJILD;

        private readonly JointDrive MBIIDHPNNMB = new JointDrive
        {
            positionSpring = 10f,
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

        private readonly Quaternion PNDFCBCNNKB = Quaternion.Euler(new Vector3(0f, 63.5f, 30f));

        private readonly Quaternion LNCCGKJDALM = Quaternion.Euler(new Vector3(0f, 63.5f, -30f));

        private readonly Quaternion KDCJLFPGMNL = Quaternion.Euler(new Quaternion(1.3f, 0f, 0f, 1f).eulerAngles);

        private readonly Quaternion FMEKMHFADIP = Quaternion.Euler(new Quaternion(0f, 0f, 0f, 1f).eulerAngles);

        private readonly Quaternion LKAOACEIJKP = Quaternion.Euler(new Vector3(85f, 0f, 0f));

        private readonly Quaternion KMDNGHCOIDC = Quaternion.Euler(new Vector3(85f, 0f, 0f));

        private readonly Quaternion CBEFGDJCCNC = Quaternion.Euler(new Quaternion(0f, -0.65f, 0f, 1f).eulerAngles);

        private readonly Quaternion PELEICHHALC = Quaternion.Euler(new Vector3(0f, 63.5f, 24f));

        private readonly Quaternion NKBNHINDAIE = Quaternion.Euler(new Quaternion(0.17f, 0f, 0f, 1f).eulerAngles);

        private readonly Quaternion ECIMPFANDPP = Quaternion.Euler(new Vector3(85f, 0f, 0f));

        private readonly Quaternion INBCNJNLOIB = new Quaternion(-0.04f, 0f, 0f, 1f).normalized;

        private readonly Quaternion CAKGDLJNPFK = Quaternion.Euler(new Vector3(-57.8f, 21.66f, 0f));

        private readonly Quaternion MAKLLFFDJBD = Quaternion.Euler(new Vector3(0f, 63.5f, 24f));

        private readonly Quaternion JCDAGNIALPB = Quaternion.Euler(new Vector3(160f, 0f, 0f));

        private readonly Quaternion KIKEBPPDADI = Quaternion.Euler(new Vector3(85f, 0f, 0f));

        private readonly Quaternion IECGCMIFHPG = Quaternion.Euler(0f, -58.2f, 15f);

        private readonly Quaternion ACMHLDMDAJN = Quaternion.Euler(31.8f, 0f, 0f);

        private readonly Quaternion EEPIODHDBEP = Quaternion.Euler(0f, -58.2f, 90f);

        private readonly Quaternion KJJNFBFMEHI = Quaternion.Euler(90f, 0f, 0f);

        private readonly Quaternion GAHKJMJJIOE = Quaternion.Euler(20f, -75f, -30f);

        private readonly Quaternion AOAFBMEOKMN = Quaternion.Euler(30f, 0f, 0f);

        private readonly Quaternion CPEKPGDPPMF = Quaternion.Euler(0f, -53f, 70f);

        private readonly Quaternion IFGKKDNGALJ = Quaternion.Euler(30f, 0f, 0f);

        private readonly Quaternion MEFDCAMLLIP = Quaternion.Euler(0f, 10f, 20f);


        private readonly Quaternion KFMHKLPIBFB = Quaternion.Euler(0f, 20f, 20f);

        private readonly Quaternion EINOGCHHOIK = Quaternion.Euler(0f, 0f, 20f);

        private readonly Quaternion BEBGFBJKJNE = Quaternion.Euler(0f, 10f, -20f);

        private readonly Quaternion GAALLMILMBH = Quaternion.Euler(0f, 0f, -20f);

        private readonly Quaternion DCCPCBOMNLE = Quaternion.Euler(0f, 0f, 10f);

        private readonly Quaternion FGEMKHAMNBO = Quaternion.Euler(0f, 0f, 10f);

        private readonly Quaternion JICCCPJLJOH = Quaternion.Euler(0f, 0f, -10f);

        private readonly Quaternion OMGBOFJONMH = Quaternion.Euler(0f, 0f, -10f);

        private Quaternion OGNIDODGHNE;

        private Quaternion MDIGAEGPEMC;

        private readonly Quaternion PFKGCLLLJGM = Quaternion.Euler(89.3f, 10f, 7.7f);

        private readonly Quaternion CPOCINNJHAA = Quaternion.Euler(35f, 0f, 0f);

        private readonly Quaternion ANMCNCDDIML = Quaternion.Euler(-35f, -10f, -15f);

        private readonly Quaternion CDENLMOFOEE = Quaternion.Euler(0f, 0f, 0f);

        private readonly Quaternion IKPGDPOLOLI = Quaternion.Euler(0f, 85f, 60f);

        private readonly Quaternion HLKJEPCDFKF = Quaternion.Euler(10f, 0f, 0f);

        private readonly Quaternion KAIFKOIAJMC = Quaternion.Euler(0f, 70f, 71f);

        private readonly Quaternion KCNGKGOFGJC = Quaternion.Euler(120f, 0f, 0f);

        private Quaternion IMLKFAOMBED;

        private Quaternion DIJCCKNLFHG;

        private Quaternion NLHJIPDINBC;

        private Quaternion AHLLJNLFCFP;


        private float FKIELAEFBOA;

        private float EGGKCIBAAFA;

        private bool FKBGMCPNCEO;

        private bool ELKGPHKKJBF;

        private JointDrive EOJOOCHKJGJ = new JointDrive
        {
            positionSpring = 0f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private Quaternion LMHCBLABLCK;

        private Vector3 IDAOBJAHIGG;

        private float GKBMMLAKNFK;

        public Vector3 equippedColliderCenter = new Vector3(0f, 0f, 0.407f);

        public float equippedColliderHeight = 0.375f;

        private CapsuleCollider FBFPGFDOJCG;

        private enum CAKLCILHFDL
        {
            Up,
            Down
        }
    }
}