using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

namespace Deobfuscated
{
    public class WeaponCrossBow : WeaponRange
    {
        protected override void Awake()
        {
            base.Awake();
            foreach (Collider item in base.GetComponents<Collider>())
            {
                this.MKLELJIAOGN.Add(item);
            }
        }




        internal override void FCPOCNFEKCJ(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG)
        {
            ConfigurableJoint configurableJoint = MCFOLNMFCPN.NLEHLJPKLCH;
            configurableJoint.angularXDrive = this.EOBEFLGECHN;
            configurableJoint.angularYZDrive = this.EOBEFLGECHN;
            configurableJoint.targetRotation = this.OKIILCKBODA;
            ConfigurableJoint configurableJoint2 = MCFOLNMFCPN.CDBGCHHHPFL;
            configurableJoint2.angularXDrive = this.ODKAIGGOHDD;
            configurableJoint2.angularYZDrive = this.ODKAIGGOHDD;
            configurableJoint2.targetRotation = this.MAHKCNPLMON;
            this.LDKIGNCMFNO = (AGCJDIFCAKA > 0f);
            if (!this.ALDHHJNCNFA && (BNLPAPMFDLL >= 0.3f || DOLMJFFJFBH))
            {
                float num = Mathf.Sin(AGCJDIFCAKA - 1.5708f + 0.5f);
                if (GHMBNLHGMHG)
                {
                    num = -num;
                }
                if (!DOLMJFFJFBH)
                {
                    MCFOLNMFCPN.FIIKBADHOJH.AddTorque(-num * 8500f * 0.05f * MCFOLNMFCPN.GreenChest.transform.forward, ForceMode.Acceleration);
                    MCFOLNMFCPN.PNGENFLDJAG.AddTorque(-num * -1100f * 1.65f * 0.7f * MCFOLNMFCPN.GreenHip.transform.forward, ForceMode.Acceleration);
                    return;
                }
                MCFOLNMFCPN.FIIKBADHOJH.AddTorque(-num * 1200f * 20f * 0.01f * MCFOLNMFCPN.GreenChest.transform.forward, ForceMode.Acceleration);
                MCFOLNMFCPN.PNGENFLDJAG.AddTorque(-num * 100f * 1.65f * 0.5f * MCFOLNMFCPN.GreenHip.transform.forward, ForceMode.Acceleration);
            }
        }

        private IEnumerator IJCEBPICJGM()
        {
            this.arrowOnBow0Mesh.enabled = false;
            float num = this.OMPMMEPKLAJ;
            while (num > 0f)
            {
                num -= Time.fixedDeltaTime;
                yield return this.MJOFAKABBGM;
            }
            this.arrowOnBow0Mesh.enabled = true;
            yield break;
        }

        private void EGPCIMDLBBH(bool MKFJCKGJAKJ)
        {
            foreach (Collider collider in this.CollidersDisableWhenEquipped)
            {
                collider.isTrigger = MKFJCKGJAKJ;
            }
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
            this.AFEDDMHGBFM = 1f;
        }

        internal override void HPMGJPMEFED(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
            ConfigurableJoint configurableJoint = MCFOLNMFCPN.AKFKHFBDPBI;
            configurableJoint.angularXDrive = this.MNMEHKNPODF;
            configurableJoint.angularYZDrive = this.MNMEHKNPODF;
            configurableJoint.targetRotation = this.KPKCHBEOICA;
            ConfigurableJoint configurableJoint2 = MCFOLNMFCPN.GIGHLANHALH;
            configurableJoint2.angularXDrive = this.KAAMDJODELG;
            configurableJoint2.angularYZDrive = this.KAAMDJODELG;
            configurableJoint2.targetRotation = this.BGCMKPLBJEA;
        }


        private void FixedUpdate()
        {
            if (PhysicsDummyModeManager.IsPaused)
            {
                return;
            }
            if (base.IsAttacking || this.LIFGGMBLIBC > 0f)
            {
                this.JPKEECADDBE = 5f;
                this.ALDHHJNCNFA = true;
                this.ECPGAOFDCKC = true;
                this.NEFMOMEMHHB += Time.fixedDeltaTime;
            }
            else if (this.JPKEECADDBE <= 0f)
            {
                this.ALDHHJNCNFA = false;
                this.ECPGAOFDCKC = false;
                this.NEFMOMEMHHB = 0f;
            }
            else
            {
                this.JPKEECADDBE -= Time.fixedDeltaTime;
            }
            if (this.LIFGGMBLIBC > 0f)
            {
                this.LIFGGMBLIBC -= Time.fixedDeltaTime;
            }
            if (this.IHLIFPPFKND != null)
            {
                this.PDAOPHBGDJN(this.ALDHHJNCNFA);
            }
        }

        private void OJOFFGCOLFK(bool MKFJCKGJAKJ)
        {
            foreach (Collider collider in this.MKLELJIAOGN)
            {
                collider.isTrigger = MKFJCKGJAKJ;
            }
        }

        internal override void GHGLMNMONHK(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, bool DOLMJFFJFBH, bool PKGLIMPDIIP)
        {
            ConfigurableJoint configurableJoint = MCFOLNMFCPN.AJBEMNONLMC;
            configurableJoint.angularXDrive = this.OJMIMEHALDD;
            configurableJoint.angularYZDrive = this.OJMIMEHALDD;
            configurableJoint.targetRotation = this.NOHFEBPOKIN;
        }

        // Shoot? Runner.Spawn
        private IEnumerator HDFOBGFHLLM()
        {
            base.IsAttacking = true;
            while (this.NEFMOMEMHHB < 0.5f)
            {
                yield return this.MJOFAKABBGM;
            }
            this.weaponController.JGBLPPKMAMA();
            if (this.weaponController.MGMBJIJPMNN.Count == 0)
            {
                // TODO Change to Runner.Spawn()
                //GameObject key = Object.Instantiate<GameObject>(this.arrowPrefab);
                NetworkObject key = Runner.Spawn(this.arrowPrefab);
                this.PJHLCELOAHP(NetworkWeaponMapping.NetworkObjectToProjectileMap[key]);
                this.IncreaseAttackCount();
            }
            yield return this.MJOFAKABBGM;
            base.LGLOPGKONLO.AddForce(base.JCGCLLMLCLH.forward * -35f, ForceMode.Impulse);
            //num = this.OMPMMEPKLAJ;
            //while (num > 0f)
            //{
            if (!PhysicsDummyModeManager.IsPaused)
            {
                // num -= Time.fixedDeltaTime;
            }
            yield return this.MJOFAKABBGM;
            // }
            base.IsAttacking = false;
            yield break;
        }

        internal override void GIKCPEIMJFO()
        {
            base.GIKCPEIMJFO();
            this.OJOFFGCOLFK(false);
            this.EGPCIMDLBBH(false);
            WeaponJoint[] components = base.GetComponents<WeaponJoint>();
            for (int i = 0; i < components.Length; i++)
            {
                components[i].OnDestroy();
            }
        }

        private IEnumerator BEAHJHKKKPP(WeaponJoint AMCPFNHLLKJ)
        {
            float num = 0f;
            while (num < 1800f && AMCPFNHLLKJ != null)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num += 2000f * Time.fixedDeltaTime;
                    this.IPCFPMKCBGI.positionSpring = num;
                    AMCPFNHLLKJ.KOFJBKAKBNL.xDrive = this.IPCFPMKCBGI;
                    AMCPFNHLLKJ.KOFJBKAKBNL.yDrive = this.IPCFPMKCBGI;
                    AMCPFNHLLKJ.KOFJBKAKBNL.zDrive = this.IPCFPMKCBGI;
                }
                yield return new WaitForFixedUpdate();
            }
            yield break;
        }



        internal override void IncreaseAttackCount()
        {
            base.IncreaseAttackCount();
            base.StartCoroutine(this.IJCEBPICJGM());
        }

        internal override void PJHLCELOAHP(WeaponProjectile LMKANGLMDPO)
        {
            base.PJHLCELOAHP(LMKANGLMDPO);
            Transform transform = LMKANGLMDPO.transform;
            Vector3 position = this.arrowOnBow0Transform.position;
            Quaternion rotation = this.arrowOnBow0Transform.rotation;
            transform.position = position;
            transform.rotation = rotation;
            LMKANGLMDPO.ShelfRigidbody.position = position;
            LMKANGLMDPO.ShelfRigidbody.rotation = rotation;
            LMKANGLMDPO.ShelfRigidbody.velocity = base.LGLOPGKONLO.GetPointVelocity(LMKANGLMDPO.ShelfRigidbody.position) + this.arrowOnBow0Transform.forward * 40f;
            LMKANGLMDPO.RelatedGameObject = base.Owner;
        }





        private bool AICJBMPCNEA(Vector3 BKBJDBJKBGK, out Vector3 OCCDHBDLDAN, out float CLNGDPKOCDP)
        {
            this.detectedRigidbodies.Clear();
            Rigidbody rigidbody = null;
            bool flag = false;
            int num = Physics.SphereCastNonAlloc(base.JCGCLLMLCLH.position + BKBJDBJKBGK * 2.7f, 2f, BKBJDBJKBGK, this.raycastHits, 6f, 256);
            if (num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    GameObject gameObject = this.raycastHits[i].collider.gameObject;
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
                    float num3 = Vector3.Distance(rigidbody2.position, this.IEDNGFIDBBL.FIIKBADHOJH.transform.position);
                    if (num3 < num2 && Vector3.Angle(rigidbody2.transform.position - base.JCGCLLMLCLH.position, BKBJDBJKBGK) <= 30f)
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

        private void PDAOPHBGDJN(bool FLHKDNJCKEI)
        {
            if (!FLHKDNJCKEI)
            {
                float maxDegreesDelta = Time.fixedDeltaTime * 150f;
                this.IHLIFPPFKND.KOFJBKAKBNL.angularXDrive = this.BOMBACKCHLM;
                this.IHLIFPPFKND.KOFJBKAKBNL.angularYZDrive = this.BOMBACKCHLM;
                Quaternion rhs = this.BBBHJBLFOPH * this.CNLANCDLJBB;
                Quaternion to = Quaternion.Inverse(Quaternion.Inverse(this.MFNGCCFFNCJ) * rhs);
                this.IHLIFPPFKND.KOFJBKAKBNL.targetRotation = Quaternion.RotateTowards(this.IHLIFPPFKND.KOFJBKAKBNL.targetRotation, to, maxDegreesDelta);
                this.EOBEFLGECHN = this.NEMFAOGGHFP;
                this.KPKCHBEOICA = Quaternion.RotateTowards(this.KPKCHBEOICA, this.EELMPAGBCDD, maxDegreesDelta);
                this.BGCMKPLBJEA = Quaternion.RotateTowards(this.BGCMKPLBJEA, this.FBAGNMHAGOO, maxDegreesDelta);
                this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.CAKGNEHPJDO, maxDegreesDelta);
                this.OJMIMEHALDD = this.PFCNBLFBGDB;
                return;
            }
            this.IHLIFPPFKND.KOFJBKAKBNL.angularXDrive = this.CMKDIIJMCNJ;
            this.IHLIFPPFKND.KOFJBKAKBNL.angularYZDrive = this.CMKDIIJMCNJ;
            Transform transform = this.IEDNGFIDBBL.GreenChest.transform;
            Transform transform2 = this.IEDNGFIDBBL.GreenHip.transform;
            Vector3 forward = transform2.forward;
            Vector3 up = transform.up;
            Quaternion rotation = Quaternion.LookRotation(-up, transform.forward);
            float num = Vector3.Angle(-up, forward);
            Vector3 vector = new Vector3(Mathf.Clamp(90f - num, -60f, 60f), -30f, 0f);
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
                this.calculatedRotation = Quaternion.Euler(eulerAngles.x + (-0.5f * num2 - 1f), eulerAngles.y, eulerAngles.z);
            }
            else
            {
                this.calculatedRotation = Quaternion.RotateTowards(this.calculatedRotation, Quaternion.Euler(vector.x - 6f, vector.y, vector.z), Time.fixedDeltaTime * 120f);
            }
            Quaternion rhs3 = this.BBBHJBLFOPH * this.calculatedRotation;
            Quaternion targetRotation = Quaternion.Inverse(Quaternion.Inverse(this.MFNGCCFFNCJ) * rhs3);
            this.IHLIFPPFKND.KOFJBKAKBNL.targetRotation = targetRotation;
            this.EOBEFLGECHN = this.MBEOBKIHFOA;
            this.KPKCHBEOICA = this.NCMFECIANCF;
            this.BGCMKPLBJEA = this.HDDCMHJCALG;
            if (this.NEFMOMEMHHB > 0.15f)
            {
                this.NOHFEBPOKIN = this.CDJLBHIINAK;
                this.OJMIMEHALDD = this.EGDDHMFFNCJ;
                return;
            }
            this.NOHFEBPOKIN = this.CAKGNEHPJDO;
            this.OJMIMEHALDD = this.PFCNBLFBGDB;
        }

        // CROSSBOW ATTACK
        internal override void AGIKMKKNICC()
        {
            if (this.isWeaponReady)
            {
                return;
            }
            base.StartCoroutine(this.HDFOBGFHLLM());
        }

        internal override float FBJDPKDEJNP
        {
            get
            {
                return 30f;
            }
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
                configurableJoint.angularXDrive = this.BCGMNMJFMLD;
                configurableJoint.angularYZDrive = this.BCGMNMJFMLD;
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
                    this.AFEDDMHGBFM = 1f;
                }
                else
                {
                    this.KEMEFGEEONC.positionSpring = Mathf.Lerp(4000f, 0f, this.AFEDDMHGBFM);
                    this.IHLIFPPFKND.KOFJBKAKBNL.xDrive = this.KEMEFGEEONC;
                    this.IHLIFPPFKND.KOFJBKAKBNL.yDrive = this.KEMEFGEEONC;
                    this.IHLIFPPFKND.KOFJBKAKBNL.zDrive = this.KEMEFGEEONC;
                    this.AFEDDMHGBFM -= Time.fixedDeltaTime * 0.8f;
                    if (this.AFEDDMHGBFM <= 0f)
                    {
                        this.AFEDDMHGBFM = 0f;
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

        internal override void DMJOIPHGHEB(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
            ConfigurableJoint configurableJoint = MCFOLNMFCPN.GDPPIFIJPMF;
            configurableJoint.angularXDrive = this.INAPNABBABE;
            configurableJoint.angularYZDrive = this.INAPNABBABE;
            configurableJoint.targetRotation = this.POAINJFAIKA;
            ConfigurableJoint configurableJoint2 = MCFOLNMFCPN.BBMLJFHODAL;
            configurableJoint2.angularXDrive = this.ECGJEDHPFFM;
            configurableJoint2.angularYZDrive = this.ECGJEDHPFFM;
            configurableJoint2.targetRotation = this.IPDJKJELJFI;
        }

        internal override void IKIJBENLEFE()
        {
            base.LGLOPGKONLO.useGravity = false;
            base.LGLOPGKONLO.mass = this.GrabbedWeight;
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

        //public GameObject arrowPrefab;
        public NetworkObject arrowPrefab;

        public MeshRenderer arrowOnBow0Mesh;

        public Transform arrowOnBow0Transform;

        private WeaponJoint OKHEGFHKFGH;

        private WeaponJoint KJCMIFBBEKG;

        private WeaponJoint IHLIFPPFKND;

        private readonly JointDrive BCGMNMJFMLD = new JointDrive
        {
            positionSpring = 10f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private JointDrive IPCFPMKCBGI = new JointDrive
        {
            positionSpring = 0f,
            positionDamper = 3f,
            maximumForce = float.MaxValue
        };

        private List<Collider> MKLELJIAOGN = new List<Collider>();

        public List<Collider> CollidersDisableWhenEquipped;

        private float AFEDDMHGBFM = 1f;

        private bool ALDHHJNCNFA;

        private float JPKEECADDBE;

        private float NEFMOMEMHHB;

        private bool LDKIGNCMFNO;

        private float OMPMMEPKLAJ = 0.3f;

        private JointDrive MNMEHKNPODF = new JointDrive
        {
            positionSpring = 30f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private JointDrive KAAMDJODELG = new JointDrive
        {
            positionSpring = 5f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private JointDrive INAPNABBABE = new JointDrive
        {
            positionSpring = 100f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private JointDrive ECGJEDHPFFM = new JointDrive
        {
            positionSpring = 50f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private JointDrive ODKAIGGOHDD = new JointDrive
        {
            positionSpring = 500f,
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive NEMFAOGGHFP = new JointDrive
        {
            positionSpring = 200f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private JointDrive MBEOBKIHFOA = new JointDrive
        {
            positionSpring = 300f,
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive PFCNBLFBGDB = new JointDrive
        {
            positionSpring = 50f,
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive EGDDHMFFNCJ = new JointDrive
        {
            positionSpring = 150f,
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive EOBEFLGECHN;

        private JointDrive OJMIMEHALDD;

        private JointDrive BOMBACKCHLM = new JointDrive
        {
            positionSpring = 100f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private JointDrive CMKDIIJMCNJ = new JointDrive
        {
            positionSpring = 250f,
            positionDamper = 0.2f,
            maximumForce = float.MaxValue
        };

        private Quaternion NCMFECIANCF = new Quaternion(1.61f, -1.5f, -0.27f, 1f).normalized;

        private Quaternion EELMPAGBCDD = new Quaternion(0.78f, -0.39f, 0.04f, 1f).normalized;

        private Quaternion KPKCHBEOICA = Quaternion.identity;

        private Quaternion HDDCMHJCALG = new Quaternion(0.26f, 0f, 0f, 1f).normalized;

        private Quaternion FBAGNMHAGOO = new Quaternion(1.7f, 0f, 0f, 1f).normalized;

        private Quaternion BGCMKPLBJEA = Quaternion.identity;

        private Quaternion POAINJFAIKA = new Quaternion(0.28f, 0.56f, -0.01f, 1f).normalized;

        private Quaternion IPDJKJELJFI = new Quaternion(0.86f, 0f, 0f, 1f).normalized;

        private Quaternion MAHKCNPLMON = Quaternion.Euler(0f, 0f, -15f);

        private Quaternion OKIILCKBODA = Quaternion.Euler(6f, 2.5f, -15f);

        private Quaternion CAKGNEHPJDO = Quaternion.Euler(-4.6f, -0.2f, 30f);

        private Quaternion CDJLBHIINAK = Quaternion.Euler(0.67f, -11.4f, 30f);

        private Quaternion NOHFEBPOKIN = Quaternion.identity;

        private Quaternion CNLANCDLJBB = Quaternion.Euler(31f, -54.8f, -45f);


        private Quaternion calculatedRotation = Quaternion.identity;

        private RaycastHit[] raycastHits = new RaycastHit[42];

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

        private Vector3 jointAnchorOffset = new Vector3(0.23f, -0.3f, -0.03f);
    }
}