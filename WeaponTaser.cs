using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

namespace Deobfuscated
{
    public class WeaponTaser : WeaponRange
    {
        private void ADCAJKLNLLI()
        {
            if (!this.isWeaponActive)
            {
                float maxDegreesDelta = Time.fixedDeltaTime * 150f;
                this.IHLIFPPFKND.KOFJBKAKBNL.angularXDrive = this.AEHIJMDOKAL;
                this.IHLIFPPFKND.KOFJBKAKBNL.angularYZDrive = this.AEHIJMDOKAL;
                Quaternion rhs = this.BBBHJBLFOPH * this.BNDPBBLFKFM;
                Quaternion to = Quaternion.Inverse(Quaternion.Inverse(this.MFNGCCFFNCJ) * rhs);
                this.IHLIFPPFKND.KOFJBKAKBNL.targetRotation = Quaternion.RotateTowards(this.IHLIFPPFKND.KOFJBKAKBNL.targetRotation, to, maxDegreesDelta);
                this.FKGGOGEHBMP = this.EKFJGKKDKPG;
                this.FELDMAPNNIO = Quaternion.RotateTowards(this.FELDMAPNNIO, this.FPPBFFACFDO, maxDegreesDelta);
                this.KGINCHFJKJM = Quaternion.RotateTowards(this.KGINCHFJKJM, this.NLJCAHDNBKH, maxDegreesDelta);
                this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.CAKGNEHPJDO, maxDegreesDelta);
                this.CKPDIFPIAHG = this.BKLOELGDAAD;
                return;
            }
            this.IHLIFPPFKND.KOFJBKAKBNL.angularXDrive = this.LPHCBHOMDHG;
            this.IHLIFPPFKND.KOFJBKAKBNL.angularYZDrive = this.LPHCBHOMDHG;
            Transform transform = this.IEDNGFIDBBL.GreenChest.transform;
            Transform transform2 = this.IEDNGFIDBBL.GreenHip.transform;
            Vector3 forward = transform2.forward;
            Vector3 up = transform.up;
            Quaternion rotation = Quaternion.LookRotation(-up, transform.forward);
            float num = Vector3.Angle(-up, forward);
            Vector3 vector = new Vector3(Mathf.Clamp(90f - num, -60f, 60f), -14f, 0f);
            Vector3 forward2;
            float num2;
            if (this.AICJBMPCNEA(-transform2.up, out forward2, out num2))
            {
                Quaternion rhs2 = Quaternion.LookRotation(forward2, forward);
                Vector3 eulerAngles = (Quaternion.Inverse(rotation) * rhs2).eulerAngles;
                float x = (eulerAngles.x > 180f) ? (eulerAngles.x - 360f) : eulerAngles.x;
                float y = (eulerAngles.y > 180f) ? (eulerAngles.y - 360f) : eulerAngles.y;
                float z = (eulerAngles.z > 180f) ? (eulerAngles.z - 360f) : eulerAngles.z;
                eulerAngles = new Vector3(x, y, z);
                this.BFDACDKEMLM = Quaternion.Euler(eulerAngles.x + (-2f * num2 - 1f), eulerAngles.y, eulerAngles.z);
            }
            else
            {
                this.BFDACDKEMLM = Quaternion.RotateTowards(this.BFDACDKEMLM, Quaternion.Euler(vector.x - 11f, vector.y, vector.z), Time.fixedDeltaTime * 40f);
            }
            Quaternion rhs3 = this.BBBHJBLFOPH * this.BFDACDKEMLM;
            Quaternion targetRotation = Quaternion.Inverse(Quaternion.Inverse(this.MFNGCCFFNCJ) * rhs3);
            this.IHLIFPPFKND.KOFJBKAKBNL.targetRotation = targetRotation;
            this.FKGGOGEHBMP = this.LNCEKEKPIIK;
            this.FELDMAPNNIO = this.OBACDBNDOHF;
            this.KGINCHFJKJM = this.OHLMDAJNFLG;
            if (this.attackDuration > 0.15f)
            {
                this.NOHFEBPOKIN = this.CDJLBHIINAK;
                this.CKPDIFPIAHG = this.EIJAILBJGOK;
                return;
            }
            this.NOHFEBPOKIN = this.CAKGNEHPJDO;
            this.CKPDIFPIAHG = this.BKLOELGDAAD;
        }



        internal override float FBJDPKDEJNP
        {
            get
            {
                return 14f;
            }
        }








        private void FixedUpdate()
        {
            if (PhysicsDummyModeManager.IsPaused)
            {
                return;
            }
            if (base.IsAttacking || this.LIFGGMBLIBC > 0f)
            {
                this.attackCooldownTimer = 4f;
                this.isWeaponActive = true;
                this.ECPGAOFDCKC = true;
                this.attackDuration += Time.fixedDeltaTime;
            }
            else if (this.attackCooldownTimer <= 0f)
            {
                this.isWeaponActive = false;
                this.ECPGAOFDCKC = false;
                this.attackDuration = 0f;
            }
            else
            {
                this.attackCooldownTimer -= Time.fixedDeltaTime;
            }
            if (this.LIFGGMBLIBC > 0f)
            {
                this.LIFGGMBLIBC -= Time.fixedDeltaTime;
            }
            if (this.IHLIFPPFKND != null)
            {
                this.ADCAJKLNLLI();
            }
        }


        internal override void HPMGJPMEFED(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
            ConfigurableJoint configurableJoint = MCFOLNMFCPN.AKFKHFBDPBI;
            configurableJoint.angularXDrive = this.LEGDJAHBMFP;
            configurableJoint.angularYZDrive = this.LEGDJAHBMFP;
            configurableJoint.targetRotation = this.FELDMAPNNIO;
            ConfigurableJoint configurableJoint2 = MCFOLNMFCPN.GIGHLANHALH;
            configurableJoint2.angularXDrive = this.GGCFMKPPFKH;
            configurableJoint2.angularYZDrive = this.GGCFMKPPFKH;
            configurableJoint2.targetRotation = this.KGINCHFJKJM;
        }














        private void PILHFCLPOEN(GameObject JMPJCIJDMMK, Vector3 NMECPDILLCH, Vector3 APGCJMPOBCE)
        {
            this.OKHEGFHKFGH = JMPJCIJDMMK.AddComponent<WeaponJoint>();
            this.OKHEGFHKFGH.KOFJBKAKBNL.connectedBody = base.LGLOPGKONLO;
            this.OKHEGFHKFGH.KOFJBKAKBNL.anchor = NMECPDILLCH;
            this.OKHEGFHKFGH.KOFJBKAKBNL.autoConfigureConnectedAnchor = false;
            this.OKHEGFHKFGH.KOFJBKAKBNL.connectedAnchor = APGCJMPOBCE;
            this.OKHEGFHKFGH.KOFJBKAKBNL.angularXDrive = this.HDPHGMLGHOI;
            this.OKHEGFHKFGH.KOFJBKAKBNL.angularYZDrive = this.HDPHGMLGHOI;
            this.OKHEGFHKFGH.KOFJBKAKBNL.xMotion = ConfigurableJointMotion.Locked;
            this.OKHEGFHKFGH.KOFJBKAKBNL.yMotion = ConfigurableJointMotion.Locked;
            this.OKHEGFHKFGH.KOFJBKAKBNL.zMotion = ConfigurableJointMotion.Locked;
            this.OKHEGFHKFGH.KOFJBKAKBNL.projectionMode = JointProjectionMode.PositionAndRotation;
        }

        private void EGPCIMDLBBH(bool MKFJCKGJAKJ)
        {
            foreach (Collider collider in this.CollidersDisableWhenEquipped)
            {
                collider.isTrigger = MKFJCKGJAKJ;
            }
        }






        internal override void GHGLMNMONHK(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, bool DOLMJFFJFBH, bool PKGLIMPDIIP)
        {
            ConfigurableJoint configurableJoint = MCFOLNMFCPN.AJBEMNONLMC;
            configurableJoint.angularXDrive = this.CKPDIFPIAHG;
            configurableJoint.angularYZDrive = this.CKPDIFPIAHG;
            configurableJoint.targetRotation = this.NOHFEBPOKIN;
        }

        internal override void DPMCHIFEGKO(PhysicCharacterController MCFOLNMFCPN, ref bool OGMMABHJCNI)
        {
            if (MCFOLNMFCPN.WeaponGrabbed)
            {
                return;
            }
            if (base.Owner != null && base.Owner != MCFOLNMFCPN.gameObject)
            {
                OGMMABHJCNI = false;
                return;
            }
            if (this.OKHEGFHKFGH == null)
            {
                this.LIFGGMBLIBC = 0.2f;
                Transform transform = MCFOLNMFCPN.GreenHip.transform;
                Vector3 from = this.grabPositions[0].position - transform.position;
                if (Vector3.Angle(from, -transform.up) > 100f)
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
                CFOGGNCCHCO.EFNEGHJPJFN(MCFOLNMFCPN.FIIKBADHOJH, -MCFOLNMFCPN.GreenChest.transform.up * 5f, ForceMode.Acceleration);
                Vector3 a = this.grabPositions[0].position - MCFOLNMFCPN.AHJCDPHHOFM.transform.position;
                CFOGGNCCHCO.IPIGMALBAKG(MCFOLNMFCPN.PIMHHNKOCBE, Vector3.ClampMagnitude(a * 200f, 8f));
                if (a.magnitude < 0.2f)
                {
                    this.PILHFCLPOEN(MCFOLNMFCPN.GreenFistR, Vector3.zero, this.grabPositions[0].localPosition);
                    MCFOLNMFCPN.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon;
                    this.CLKNJDJPAHJ(MCFOLNMFCPN.GreenChest, MCFOLNMFCPN.FIIKBADHOJH);
                    this.OJOFFGCOLFK(true);
                    this.GCAPLNOJOFM(MCFOLNMFCPN.gameObject);
                    base.weaponIsEquipped = true;
                    MCFOLNMFCPN.grabbedWeaponGo = base.gameObject;
                    return;
                }
            }
            else if (this.KJCMIFBBEKG == null && this.IHLIFPPFKND != null)
            {
                this.LIFGGMBLIBC = 0.2f;
                Transform transform2 = MCFOLNMFCPN.GreenChest.transform;
                Vector3 b = transform2.position + transform2.up * this.jointAnchorOffset.y + transform2.right * this.jointAnchorOffset.x + transform2.forward * this.jointAnchorOffset.z;
                if (Vector3.Distance(base.LGLOPGKONLO.position, b) < 0.05f)
                {
                    this.IHLIFPPFKND.KOFJBKAKBNL.xMotion = ConfigurableJointMotion.Locked;
                    this.IHLIFPPFKND.KOFJBKAKBNL.yMotion = ConfigurableJointMotion.Locked;
                    this.IHLIFPPFKND.KOFJBKAKBNL.zMotion = ConfigurableJointMotion.Locked;
                    this.jointStiffnessFactor = 1f;
                }
                else
                {
                    this.KEMEFGEEONC.positionSpring = Mathf.Lerp(4000f, 0f, this.jointStiffnessFactor);
                    this.IHLIFPPFKND.KOFJBKAKBNL.xDrive = this.KEMEFGEEONC;
                    this.IHLIFPPFKND.KOFJBKAKBNL.yDrive = this.KEMEFGEEONC;
                    this.IHLIFPPFKND.KOFJBKAKBNL.zDrive = this.KEMEFGEEONC;
                    this.jointStiffnessFactor -= Time.fixedDeltaTime * 0.6f;
                    if (this.jointStiffnessFactor <= 0f)
                    {
                        this.jointStiffnessFactor = 0f;
                    }
                }
                if (this.IHLIFPPFKND.KOFJBKAKBNL.xMotion == ConfigurableJointMotion.Locked)
                {
                    this.OJOFFGCOLFK(false);
                    this.EGPCIMDLBBH(true);
                    this.FJDGKJNCAOD(MCFOLNMFCPN.GreenFistL, MCFOLNMFCPN.LNDDLJMNLBD);
                    MCFOLNMFCPN.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon;
                    MCFOLNMFCPN.WeaponGrabbed = true;
                }
            }
        }


        protected override void Awake()
        {
            base.Awake();
            foreach (Collider item in base.GetComponents<Collider>())
            {
                this.weaponColliders.Add(item);
            }
        }






        internal override void PJHLCELOAHP(WeaponProjectile LMKANGLMDPO)
        {
            base.PJHLCELOAHP(LMKANGLMDPO);
            Transform transform = LMKANGLMDPO.transform;
            Vector3 position = this.pinOnGunTransform.position;
            Quaternion rotation = this.pinOnGunTransform.rotation;
            transform.position = position;
            transform.rotation = rotation;
            LMKANGLMDPO.ShelfRigidbody.position = position;
            LMKANGLMDPO.ShelfRigidbody.rotation = rotation;
            LMKANGLMDPO.ShelfRigidbody.velocity = base.LGLOPGKONLO.GetPointVelocity(LMKANGLMDPO.ShelfRigidbody.position) + this.pinOnGunTransform.forward * 15f;
            LMKANGLMDPO.RelatedGameObject = base.Owner;
            ((Pin)LMKANGLMDPO).ActivatePin();
        }


        private IEnumerator GMFNJIMPOFG()
        {
            base.IsAttacking = true;
            while (this.attackDuration < 0.25f)
            {
                yield return this.MJOFAKABBGM;
            }
            this.weaponController.JGBLPPKMAMA();
            if (this.weaponController.MGMBJIJPMNN.Count == 0)
            {
                // TODO
                //GameObject key = Instantiate<GameObject>(this.pinPrefab);
                NetworkObject key = Runner.Spawn(this.pinPrefab);
                this.PJHLCELOAHP(NetworkWeaponMapping.NetworkObjectToProjectileMap[key]);
                this.IncreaseAttackCount();
            }
            yield return this.MJOFAKABBGM;
            base.LGLOPGKONLO.AddForce(base.JCGCLLMLCLH.forward * -50f, ForceMode.Impulse);
            //num = this.OMPMMEPKLAJ;
            //while (num > 0f)
            //{
            //    if (!PhysicsDummyModeManager.IsPaused)
            //    {
            //        num -= Time.fixedDeltaTime;
            //    }
            //    yield return this.MJOFAKABBGM;
            //}
            base.IsAttacking = false;
            yield break;
        }

        internal override void DMJOIPHGHEB(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
            ConfigurableJoint configurableJoint = MCFOLNMFCPN.GDPPIFIJPMF;
            configurableJoint.angularXDrive = this.MGHBINPMHHJ;
            configurableJoint.angularYZDrive = this.MGHBINPMHHJ;
            configurableJoint.targetRotation = this.ONJECBDGOIB;
            ConfigurableJoint configurableJoint2 = MCFOLNMFCPN.BBMLJFHODAL;
            configurableJoint2.angularXDrive = this.GBJFNIBABMI;
            configurableJoint2.angularYZDrive = this.GBJFNIBABMI;
            configurableJoint2.targetRotation = this.DPIGNDMAFCE;
        }

        // Token: 0x06002BBD RID: 11197 RVA: 0x0013915C File Offset: 0x0013735C
        internal virtual void PAJIFLHNBBI(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG)
        {
            this.isPrimaryAttack = (AGCJDIFCAKA > 540f);
            if (!this.isWeaponActive && (BNLPAPMFDLL < 995f || DOLMJFFJFBH))
            {
                float num = Mathf.Sin(AGCJDIFCAKA - 43f + 795f);
                if (GHMBNLHGMHG)
                {
                    num = -num;
                }
                if (!DOLMJFFJFBH)
                {
                    MCFOLNMFCPN.FIIKBADHOJH.AddTorque(-num * 1378f * 637f * MCFOLNMFCPN.GreenChest.transform.forward, ForceMode.Impulse);
                    MCFOLNMFCPN.PNGENFLDJAG.AddTorque(-num * 537f * 1594f * 407f * MCFOLNMFCPN.GreenHip.transform.forward, ForceMode.Impulse);
                }
                else
                {
                    MCFOLNMFCPN.FIIKBADHOJH.AddTorque(-num * 477f * 1796f * 184f * MCFOLNMFCPN.GreenChest.transform.forward, (ForceMode)7);
                    MCFOLNMFCPN.PNGENFLDJAG.AddTorque(-num * 1711f * 955f * 628f * MCFOLNMFCPN.GreenHip.transform.forward, (ForceMode)6);
                }
            }
            ConfigurableJoint configurableJoint = MCFOLNMFCPN.NLEHLJPKLCH;
            configurableJoint.angularXDrive = this.FKGGOGEHBMP;
            configurableJoint.angularYZDrive = this.FKGGOGEHBMP;
            configurableJoint.targetRotation = this.OKIILCKBODA;
            ConfigurableJoint configurableJoint2 = MCFOLNMFCPN.CDBGCHHHPFL;
            configurableJoint2.angularXDrive = this.FKONDLMIOKO;
            configurableJoint2.angularYZDrive = this.FKONDLMIOKO;
            configurableJoint2.targetRotation = this.MAHKCNPLMON;
        }









        private void CLKNJDJPAHJ(GameObject NPFAMIKCKBO, Rigidbody PPIDNAOBLHE)
        {
            this.MFNGCCFFNCJ = base.LGLOPGKONLO.rotation;
            this.BBBHJBLFOPH = Quaternion.LookRotation(-NPFAMIKCKBO.transform.up, NPFAMIKCKBO.transform.forward);
            this.IHLIFPPFKND = base.gameObject.AddComponent<WeaponJoint>();
            this.IHLIFPPFKND.KOFJBKAKBNL.connectedBody = PPIDNAOBLHE;
            this.IHLIFPPFKND.KOFJBKAKBNL.anchor = Vector3.zero;
            this.IHLIFPPFKND.KOFJBKAKBNL.autoConfigureConnectedAnchor = false;
            this.IHLIFPPFKND.KOFJBKAKBNL.connectedAnchor = this.jointAnchorOffset;
            this.IHLIFPPFKND.KOFJBKAKBNL.xMotion = ConfigurableJointMotion.Free;
            this.IHLIFPPFKND.KOFJBKAKBNL.yMotion = ConfigurableJointMotion.Free;
            this.IHLIFPPFKND.KOFJBKAKBNL.zMotion = ConfigurableJointMotion.Free;
            this.IHLIFPPFKND.KOFJBKAKBNL.angularXMotion = ConfigurableJointMotion.Free;
            this.IHLIFPPFKND.KOFJBKAKBNL.angularYMotion = ConfigurableJointMotion.Free;
            this.IHLIFPPFKND.KOFJBKAKBNL.angularZMotion = ConfigurableJointMotion.Free;
        }


        internal override void AHKAOLIBCON()
        {
            base.OFBBDAJGDHN();
            if (this.IHLIFPPFKND != null)
            {
                this.IHLIFPPFKND.HCLJKKMHNLH();
            }
            if (this.KJCMIFBBEKG != null)
            {
                this.KJCMIFBBEKG.MEBDIOJGGEM();
            }
            if (this.OKHEGFHKFGH != null)
            {
                this.OKHEGFHKFGH.LPEDHCEDJAH();
            }
            this.jointStiffnessFactor = 1638f;
        }

        internal override void FCPOCNFEKCJ(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG)
        {
            this.isPrimaryAttack = (AGCJDIFCAKA > 0f);
            if (!this.isWeaponActive && (BNLPAPMFDLL >= 0.3f || DOLMJFFJFBH))
            {
                float num = Mathf.Sin(AGCJDIFCAKA - 1.5708f + 0.5f);
                if (GHMBNLHGMHG)
                {
                    num = -num;
                }
                if (!DOLMJFFJFBH)
                {
                    MCFOLNMFCPN.FIIKBADHOJH.AddTorque(-num * 8500f * 0.03f * MCFOLNMFCPN.GreenChest.transform.forward, ForceMode.Acceleration);
                    MCFOLNMFCPN.PNGENFLDJAG.AddTorque(-num * -1100f * 1.65f * 0.7f * MCFOLNMFCPN.GreenHip.transform.forward, ForceMode.Acceleration);
                }
                else
                {
                    MCFOLNMFCPN.FIIKBADHOJH.AddTorque(-num * 1200f * 20f * 0.05f * MCFOLNMFCPN.GreenChest.transform.forward, ForceMode.Acceleration);
                    MCFOLNMFCPN.PNGENFLDJAG.AddTorque(-num * 100f * 1.65f * 0.5f * MCFOLNMFCPN.GreenHip.transform.forward, ForceMode.Acceleration);
                }
            }
            ConfigurableJoint configurableJoint = MCFOLNMFCPN.NLEHLJPKLCH;
            configurableJoint.angularXDrive = this.FKGGOGEHBMP;
            configurableJoint.angularYZDrive = this.FKGGOGEHBMP;
            configurableJoint.targetRotation = this.OKIILCKBODA;
            ConfigurableJoint configurableJoint2 = MCFOLNMFCPN.CDBGCHHHPFL;
            configurableJoint2.angularXDrive = this.FKONDLMIOKO;
            configurableJoint2.angularYZDrive = this.FKONDLMIOKO;
            configurableJoint2.targetRotation = this.MAHKCNPLMON;
        }


        private void FJDGKJNCAOD(GameObject JMPJCIJDMMK, Rigidbody FIDJLMHHENM)
        {
            this.KJCMIFBBEKG = base.gameObject.AddComponent<WeaponJoint>();
            this.KJCMIFBBEKG.KOFJBKAKBNL.connectedBody = FIDJLMHHENM;
            this.KJCMIFBBEKG.KOFJBKAKBNL.anchor = this.grabPositions[1].localPosition;
            this.KJCMIFBBEKG.KOFJBKAKBNL.autoConfigureConnectedAnchor = false;
            this.KJCMIFBBEKG.KOFJBKAKBNL.connectedAnchor = new Vector3(-0.051f, 0f, -0.0397f);
            base.StartCoroutine(this.BEAHJHKKKPP(this.KJCMIFBBEKG));
            this.KJCMIFBBEKG.KOFJBKAKBNL.projectionMode = JointProjectionMode.PositionAndRotation;
        }

        private void OJOFFGCOLFK(bool MKFJCKGJAKJ)
        {
            foreach (Collider collider in this.weaponColliders)
            {
                collider.isTrigger = MKFJCKGJAKJ;
            }
        }


        internal override void IncreaseAttackCount()
        {
            base.IncreaseAttackCount();
            base.StartCoroutine(this.IPIMNHNEJCL());
        }


        private bool AICJBMPCNEA(Vector3 BKBJDBJKBGK, out Vector3 OCCDHBDLDAN, out float CLNGDPKOCDP)
        {
            this.detectedRigidbodies.Clear();
            Rigidbody rigidbody = null;
            bool flag = false;
            int num = Physics.SphereCastNonAlloc(base.JCGCLLMLCLH.position + BKBJDBJKBGK * 2.7f, 2f, BKBJDBJKBGK, this.raycastResults, 6f, 256);
            if (num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    GameObject gameObject = this.raycastResults[i].collider.gameObject;
                    if (PccManager.rigidbodyCharacterControllerMap.ContainsKey(gameObject))
                    {
                        PhysicCharacterController physicCharacterController = PccManager.rigidbodyCharacterControllerMap[gameObject];
                        if (physicCharacterController != this.IEDNGFIDBBL)
                        {
                            this.detectedRigidbodies.Add(physicCharacterController.FIIKBADHOJH);
                        }
                    }
                }
                float num2 = 9999f;
                foreach (Rigidbody rigidbody2 in this.detectedRigidbodies)
                {
                    float num3 = Vector3.Distance(rigidbody2.position, this.IEDNGFIDBBL.FIIKBADHOJH.position);
                    if (num3 < num2 && Vector3.Angle(rigidbody2.position - base.JCGCLLMLCLH.position, BKBJDBJKBGK) <= 30f)
                    {
                        flag = true;
                        num2 = num3;
                        rigidbody = rigidbody2;
                    }
                }
            }
            if (flag)
            {
                Vector3 position = rigidbody.position;
                Vector3 position2 = base.JCGCLLMLCLH.position;
                OCCDHBDLDAN = (position - position2).normalized;
                CLNGDPKOCDP = Vector3.Distance(position, position2);
                return true;
            }
            OCCDHBDLDAN = Vector3.zero;
            CLNGDPKOCDP = 0f;
            return false;
        }

        internal override void AGIKMKKNICC()
        {
            if (this.isWeaponReady)
            {
                return;
            }
            base.StartCoroutine(this.GMFNJIMPOFG());
        }


        private IEnumerator BEAHJHKKKPP(WeaponJoint AMCPFNHLLKJ)
        {
            //num = 0f;
            while (/*num < 1800f &&*/ AMCPFNHLLKJ != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num += 2000f * Time.fixedDeltaTime;
                    //this.IPCFPMKCBGI.positionSpring = num;
                    AMCPFNHLLKJ.KOFJBKAKBNL.xDrive = this.IPCFPMKCBGI;
                    AMCPFNHLLKJ.KOFJBKAKBNL.yDrive = this.IPCFPMKCBGI;
                    AMCPFNHLLKJ.KOFJBKAKBNL.zDrive = this.IPCFPMKCBGI;
                }
                yield return new WaitForFixedUpdate();
            }
            yield break;
        }




        internal override void GIKCPEIMJFO()
        {
            base.GIKCPEIMJFO();
            this.OJOFFGCOLFK(false);
            this.EGPCIMDLBBH(false);
            if (this.IHLIFPPFKND != null)
            {
                this.IHLIFPPFKND.OnDestroy();
            }
            if (this.KJCMIFBBEKG != null)
            {
                this.KJCMIFBBEKG.OnDestroy();
            }
            if (this.OKHEGFHKFGH != null)
            {
                this.OKHEGFHKFGH.OnDestroy();
            }
        }






        internal override void GDENHBKDDGO()
        {
            base.GDENHBKDDGO();
            if (this.IHLIFPPFKND != null)
            {
                this.IHLIFPPFKND.OnDestroy();
            }
            if (this.KJCMIFBBEKG != null)
            {
                this.KJCMIFBBEKG.OnDestroy();
            }
            if (this.OKHEGFHKFGH != null)
            {
                this.OKHEGFHKFGH.OnDestroy();
            }
            this.jointStiffnessFactor = 1f;
        }


        private IEnumerator IPIMNHNEJCL()
        {
            this.pinOnGunMesh.enabled = false;
            //num = this.OMPMMEPKLAJ - 0.3f;
            //while (num > 0f)
            //{
            //    num -= Time.fixedDeltaTime;
            //    yield return this.MJOFAKABBGM;
            //}
            this.pinOnGunMesh.enabled = true;
            this.pinOnGunTransform.localScale = Vector3.one * 0.005f;
            //num = 0.3f;
            //while (num > 0f)
            //{
            //    num -= Time.fixedDeltaTime;
            //    this.pinOnGunTransform.localScale = Vector3.one * Mathf.SmoothStep(1f, 0.005f, num / 0.3f);
            //    yield return this.MJOFAKABBGM;
            //}
            this.pinOnGunTransform.localScale = Vector3.one;
            yield break;
        }

        internal override void IKIJBENLEFE()
        {
            base.LGLOPGKONLO.useGravity = false;
            base.LGLOPGKONLO.mass = this.GrabbedWeight;
        }


        public GameObject pinPrefab;

        public MeshRenderer pinOnGunMesh;

        public Transform pinOnGunTransform;

        private float jointStiffnessFactor = 1f;

        private bool isWeaponActive;

        private float attackCooldownTimer;

        private float attackDuration;

        private bool isPrimaryAttack;


        private List<Collider> weaponColliders = new List<Collider>();

        public List<Collider> CollidersDisableWhenEquipped = new List<Collider>();

        private readonly JointDrive MBIIDHPNNMB = new JointDrive
        {
            positionSpring = 10f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };



        private JointDrive LEGDJAHBMFP = new JointDrive
        {
            positionSpring = 30f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private JointDrive GGCFMKPPFKH = new JointDrive
        {
            positionSpring = 5f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private JointDrive MGHBINPMHHJ = new JointDrive
        {
            positionSpring = 100f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private JointDrive GBJFNIBABMI = new JointDrive
        {
            positionSpring = 50f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private JointDrive FKONDLMIOKO = new JointDrive
        {
            positionSpring = 500f,
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive EKFJGKKDKPG = new JointDrive
        {
            positionSpring = 200f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private JointDrive LNCEKEKPIIK = new JointDrive
        {
            positionSpring = 300f,
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive BKLOELGDAAD = new JointDrive
        {
            positionSpring = 50f,
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive EIJAILBJGOK = new JointDrive
        {
            positionSpring = 150f,
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive FKGGOGEHBMP;

        private JointDrive CKPDIFPIAHG;

        private JointDrive AEHIJMDOKAL = new JointDrive
        {
            positionSpring = 50f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private JointDrive LPHCBHOMDHG = new JointDrive
        {
            positionSpring = 250f,
            positionDamper = 0.2f,
            maximumForce = float.MaxValue
        };

        private Quaternion OBACDBNDOHF = new Quaternion(1.61f, -1.5f, -0.27f, 1f).normalized;

        private Quaternion FPPBFFACFDO = new Quaternion(0.78f, -0.39f, 0.04f, 1f).normalized;

        private Quaternion FELDMAPNNIO = Quaternion.identity;

        private Quaternion OHLMDAJNFLG = new Quaternion(0.26f, 0f, 0f, 1f).normalized;

        private Quaternion NLJCAHDNBKH = new Quaternion(1.7f, 0f, 0f, 1f).normalized;

        private Quaternion KGINCHFJKJM = Quaternion.identity;

        private Quaternion ONJECBDGOIB = new Quaternion(0.28f, 0.56f, -0.01f, 1f).normalized;

        private Quaternion DPIGNDMAFCE = new Quaternion(0.86f, 0f, 0f, 1f).normalized;

        private Quaternion MAHKCNPLMON = Quaternion.Euler(0f, 0f, -7f);

        private Quaternion OKIILCKBODA = Quaternion.Euler(6f, 2.5f, -7f);

        private Quaternion CAKGNEHPJDO = Quaternion.Euler(0f, 0f, 14f);

        private Quaternion CDJLBHIINAK = Quaternion.Euler(0f, 0f, 14f);

        private Quaternion NOHFEBPOKIN = Quaternion.identity;

        private Quaternion BNDPBBLFKFM = Quaternion.Euler(-31f, -55f, 25f);

        private WeaponJoint OKHEGFHKFGH;

        private WeaponJoint KJCMIFBBEKG;

        private WeaponJoint IHLIFPPFKND;

        private Quaternion BFDACDKEMLM = Quaternion.identity;

        private RaycastHit[] raycastResults = new RaycastHit[42];

        private HashSet<Rigidbody> detectedRigidbodies = new HashSet<Rigidbody>();

        private readonly JointDrive HDPHGMLGHOI = new JointDrive
        {
            positionSpring = 0f,
            positionDamper = 0f,
            maximumForce = float.PositiveInfinity
        };

        private JointDrive KEMEFGEEONC = new JointDrive
        {
            positionSpring = 1200f,
            positionDamper = 50f,
            maximumForce = 99999f
        };

        private Quaternion MFNGCCFFNCJ;

        private Quaternion BBBHJBLFOPH;

        private Vector3 jointAnchorOffset = new Vector3(0.15f, -0.3f, -0.094f);

        private JointDrive IPCFPMKCBGI = new JointDrive
        {
            positionSpring = 0f,
            positionDamper = 3f,
            maximumForce = float.MaxValue
        };
    }
}