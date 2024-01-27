using System.Collections;
using UnityEngine;
namespace Deobfuscated
{
    public class WeaponHammer : WeaponMelee
    {

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



        internal override void HPMGJPMEFED(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
            ConfigurableJoint configurableJoint = MCFOLNMFCPN.AKFKHFBDPBI;
            configurableJoint.angularXDrive = this.AGKMLPMJIOM;
            configurableJoint.angularYZDrive = this.AGKMLPMJIOM;
            configurableJoint.targetRotation = this.GNCDFMINDFE;
            ConfigurableJoint configurableJoint2 = MCFOLNMFCPN.GIGHLANHALH;
            configurableJoint2.angularXDrive = this.GNKGIPKGODJ;
            configurableJoint2.angularYZDrive = this.GNKGIPKGODJ;
            configurableJoint2.targetRotation = this.BCIFFIAIHOD;
            if (!base.IsAttacking)
            {
                float num = (Mathf.Sin(AGCJDIFCAKA * 2f + 3.14159f + 0.2f) + 1f) * 0.5f;
                if (GHMBNLHGMHG)
                {
                    num = -num + 1f;
                }
                this.BCIFFIAIHOD = Quaternion.Slerp(this.DNFNPOGLDFD, this.FJNGMDGDNGN, num);
            }
        }


        internal override void IKIJBENLEFE()
        {
            base.LGLOPGKONLO.useGravity = false;
            base.LGLOPGKONLO.mass = this.GrabbedWeight;
            base.LGLOPGKONLO.maxAngularVelocity = 7f;
            Collider[] components = base.GetComponents<Collider>();
            for (int i = 0; i < components.Length; i++)
            {
                PhysicMaterial material = components[i].material;
                material.staticFriction = 0f;
                material.dynamicFriction = 0f;
            }
            this.PNGENFLDJAG = PccManager.gameObjectToCharacterControllerMap[base.Owner].GreenHip.GetComponent<Rigidbody>();
        }


        internal override void FCPOCNFEKCJ(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG)
        {
            if (!base.IsAttacking)
            {
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
        }





        internal override void GDENHBKDDGO()
        {
            base.GDENHBKDDGO();
            if (this.IENEBFKFMPP != null)
            {
                this.IENEBFKFMPP.OnDestroy();
            }
            if (this.BAPBKJIHLLJ != null)
            {
                this.BAPBKJIHLLJ.OnDestroy();
            }
        }


        internal override void GIKCPEIMJFO()
        {
            base.GIKCPEIMJFO();
            Collider[] components = base.GetComponents<Collider>();
            for (int i = 0; i < components.Length; i++)
            {
                PhysicMaterial material = components[i].material;
                material.staticFriction = 0.6f;
                material.dynamicFriction = 0.6f;
            }
            base.LGLOPGKONLO.maxAngularVelocity = 7f;
            this.PNGENFLDJAG = null;
        }


        internal override void DPMCHIFEGKO(PhysicCharacterController MCFOLNMFCPN, ref bool OGMMABHJCNI)
        {
            if (!MCFOLNMFCPN.WeaponGrabbed)
            {
                if (base.Owner != null && base.Owner != MCFOLNMFCPN.gameObject)
                {
                    MCFOLNMFCPN.HFNILGPPPGH.isTrigger = false;
                    MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                    OGMMABHJCNI = false;
                    return;
                }
                if (MCFOLNMFCPN.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon && MCFOLNMFCPN.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon)
                {
                    MCFOLNMFCPN.WeaponGrabbed = true;
                    MCFOLNMFCPN.HFNILGPPPGH.isTrigger = false;
                    MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                    base.weaponIsEquipped = true;
                    return;
                }
                Vector3 position = MCFOLNMFCPN.GreenFistL.transform.position;
                Vector3 position2 = MCFOLNMFCPN.GreenFistR.transform.position;
                Vector3 position3 = this.grabPositions[0].position;
                Vector3 position4 = this.grabPositions[1].position;
                float num = Vector3.Distance(position, position3);
                float num2 = Vector3.Distance(position2, position3);
                if (num > 1f && num2 > 1f)
                {
                    MCFOLNMFCPN.HFNILGPPPGH.isTrigger = false;
                    MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                    OGMMABHJCNI = false;
                    return;
                }
                if (this.IENEBFKFMPP == null)
                {
                    if (Vector3.Angle(position3 - MCFOLNMFCPN.GreenHip.transform.position, -MCFOLNMFCPN.GreenHip.transform.up) > 100f)
                    {
                        MCFOLNMFCPN.HFNILGPPPGH.isTrigger = false;
                        MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                        OGMMABHJCNI = false;
                        return;
                    }
                    this.LIFGGMBLIBC = 0.2f;
                    ConfigurableJoint configurableJoint = MCFOLNMFCPN.NLEHLJPKLCH;
                    configurableJoint.angularXDrive = this.BCGMNMJFMLD;
                    configurableJoint.angularYZDrive = this.BCGMNMJFMLD;
                    CFOGGNCCHCO.EFNEGHJPJFN(MCFOLNMFCPN.FIIKBADHOJH, -MCFOLNMFCPN.GreenChest.transform.up * 50f, ForceMode.Acceleration);
                    if (num < num2)
                    {
                        MCFOLNMFCPN.HFNILGPPPGH.isTrigger = true;
                        Vector3 a = position3 - position;
                        CFOGGNCCHCO.IPIGMALBAKG(MCFOLNMFCPN.LNDDLJMNLBD, Vector3.ClampMagnitude(a * 200f, 8f));
                        if (a.magnitude < 0.08f)
                        {
                            this.MJAGOCPLGMH(MCFOLNMFCPN.LNDDLJMNLBD, MCFOLNMFCPN.HFNILGPPPGH, 1f, this.grabPositions[0], -Vector3.forward * 0f, ref this.IENEBFKFMPP, ConfigurableJointMotion.Locked);
                            MCFOLNMFCPN.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon;
                            MCFOLNMFCPN.grabbedWeaponGo = base.gameObject;
                            this.GCAPLNOJOFM(MCFOLNMFCPN.gameObject);
                            return;
                        }
                    }
                    else
                    {
                        MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = true;
                        Vector3 a2 = position3 - position2;
                        CFOGGNCCHCO.IPIGMALBAKG(MCFOLNMFCPN.PIMHHNKOCBE, Vector3.ClampMagnitude(a2 * 200f, 8f));
                        if (a2.magnitude < 0.08f)
                        {
                            this.MJAGOCPLGMH(MCFOLNMFCPN.PIMHHNKOCBE, MCFOLNMFCPN.AHJCDPHHOFM, 1f, this.grabPositions[0], Vector3.forward * 0f, ref this.IENEBFKFMPP, ConfigurableJointMotion.Locked);
                            MCFOLNMFCPN.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon;
                            MCFOLNMFCPN.grabbedWeaponGo = base.gameObject;
                            this.GCAPLNOJOFM(MCFOLNMFCPN.gameObject);
                            return;
                        }
                    }
                }
                else if (this.BAPBKJIHLLJ == null)
                {
                    this.LIFGGMBLIBC = 0.2f;
                    if (MCFOLNMFCPN.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon)
                    {
                        if ((double)Vector3.Distance(position4, position2) > 0.8)
                        {
                            MCFOLNMFCPN.HFNILGPPPGH.isTrigger = false;
                            MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                            return;
                        }
                        MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = true;
                        Vector3 a3 = position4 - position2;
                        CFOGGNCCHCO.IPIGMALBAKG(MCFOLNMFCPN.PIMHHNKOCBE, Vector3.ClampMagnitude(a3 * 200f, 8f));
                        if (a3.magnitude < 0.04f)
                        {
                            this.MJAGOCPLGMH(MCFOLNMFCPN.PIMHHNKOCBE, MCFOLNMFCPN.AHJCDPHHOFM, 1f, this.grabPositions[1], Vector3.forward * 0f, ref this.BAPBKJIHLLJ, ConfigurableJointMotion.Locked);
                            this.HammerAttackSide = WeaponHammer.AttackSide.Right;
                            MCFOLNMFCPN.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon;
                            this.GCAPLNOJOFM(MCFOLNMFCPN.gameObject);
                        }
                    }
                    if (MCFOLNMFCPN.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon)
                    {
                        if ((double)Vector3.Distance(position4, position) > 0.8)
                        {
                            MCFOLNMFCPN.HFNILGPPPGH.isTrigger = false;
                            MCFOLNMFCPN.AHJCDPHHOFM.isTrigger = false;
                            return;
                        }
                        MCFOLNMFCPN.HFNILGPPPGH.isTrigger = true;
                        Vector3 a4 = position4 - position;
                        CFOGGNCCHCO.IPIGMALBAKG(MCFOLNMFCPN.LNDDLJMNLBD, Vector3.ClampMagnitude(a4 * 200f, 8f));
                        if (a4.magnitude < 0.04f)
                        {
                            this.MJAGOCPLGMH(MCFOLNMFCPN.LNDDLJMNLBD, MCFOLNMFCPN.HFNILGPPPGH, 1f, this.grabPositions[1], -Vector3.forward * 0f, ref this.BAPBKJIHLLJ, ConfigurableJointMotion.Locked);
                            this.HammerAttackSide = WeaponHammer.AttackSide.Left;
                            MCFOLNMFCPN.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon;
                            this.GCAPLNOJOFM(MCFOLNMFCPN.gameObject);
                        }
                    }
                }
            }
        }

        private void DPIFPAMAMHI()
        {
            if (this.PNGENFLDJAG == null)
            {
                return;
            }
            WeaponHammer.AttackSide hammerAttackSide = this.HammerAttackSide;
            if (hammerAttackSide == WeaponHammer.AttackSide.Left)
            {
                base.LGLOPGKONLO.AddTorque(this.OHIAODBCHHM * this.WavingForce * this.PNGENFLDJAG.transform.forward, ForceMode.Force);
                return;
            }
            if (hammerAttackSide != WeaponHammer.AttackSide.Right)
            {
                return;
            }
            base.LGLOPGKONLO.AddTorque(this.OHIAODBCHHM * -this.WavingForce * this.PNGENFLDJAG.transform.forward, ForceMode.Force);
        }


        private void JPNFHJJIMID()
        {
            this.AGKMLPMJIOM = this.NFDHMEDNOJE;
            this.GNCDFMINDFE = this.EELMPAGBCDD;
            this.CKCKKJLNJAJ = this.NFDHMEDNOJE;
            this.GEKLOCOKAGF = this.KJEBKBBGGAK;
            this.GNKGIPKGODJ = this.NLABLAPEDMD;
            this.BCIFFIAIHOD = this.CFFNHCEDODD;
            this.KKBPLDJIMIL = this.NLABLAPEDMD;
            this.PLPGAPIAFAI = this.CFFNHCEDODD;
        }





        private void JHKFGMGHFJN()
        {
            this.AGKMLPMJIOM = this.AMCKDLMMMOA;
            this.GNCDFMINDFE = this.NCMFECIANCF;
            this.CKCKKJLNJAJ = this.AMCKDLMMMOA;
            this.GEKLOCOKAGF = this.FLAOFENOPOK;
            this.GNKGIPKGODJ = this.JHGFCIOAFND;
            this.BCIFFIAIHOD = this.ALPEGBAHDAM;
            this.KKBPLDJIMIL = this.JHGFCIOAFND;
            this.PLPGAPIAFAI = this.ALPEGBAHDAM;
        }





        private void DEPEALCFAFP()
        {
            if (this.PNGENFLDJAG == null)
            {
                return;
            }
            WeaponHammer.AttackSide hammerAttackSide = this.HammerAttackSide;
            if (hammerAttackSide == WeaponHammer.AttackSide.Left)
            {
                Vector3 forward = this.PNGENFLDJAG.transform.forward;
                base.LGLOPGKONLO.AddTorque(Mathf.Clamp01(this.OHIAODBCHHM) * -170f * forward, ForceMode.Force);
                CFOGGNCCHCO.OEODACNOHCD(base.LGLOPGKONLO, forward * 10f, this.AddForcePos.position, ForceMode.Force);
                return;
            }
            if (hammerAttackSide != WeaponHammer.AttackSide.Right)
            {
                return;
            }
            Vector3 forward2 = this.PNGENFLDJAG.transform.forward;
            base.LGLOPGKONLO.AddTorque(Mathf.Clamp01(this.OHIAODBCHHM) * 170f * forward2, ForceMode.Force);
            CFOGGNCCHCO.OEODACNOHCD(base.LGLOPGKONLO, forward2 * 10f, this.AddForcePos.position, ForceMode.Force);
        }


        protected override void Awake()
        {
            base.Awake();
            PhysicMaterial material = new PhysicMaterial
            {
                bounciness = 0.4f,
                frictionCombine = PhysicMaterialCombine.Minimum
            };
            base.GetComponent<Collider>().material = material;
            base.GetComponent<Collider>().material = material;
            base.PowerConsume = 0.1f;
            base.NoPowerRecoverCD = 2.68f;
            this.AMCKDLMMMOA.positionSpring = 500f;
            this.AMCKDLMMMOA.positionDamper = 10f;
            this.AMCKDLMMMOA.maximumForce = float.PositiveInfinity;
            this.JHGFCIOAFND.positionSpring = 300f;
            this.JHGFCIOAFND.positionDamper = 5f;
            this.JHGFCIOAFND.maximumForce = float.PositiveInfinity;
            this.NFDHMEDNOJE.positionSpring = 50f;
            this.NFDHMEDNOJE.positionDamper = 10f;
            this.NFDHMEDNOJE.maximumForce = float.PositiveInfinity;
            this.NLABLAPEDMD.positionSpring = 40f;
            this.NLABLAPEDMD.positionDamper = 5f;
            this.NLABLAPEDMD.maximumForce = float.PositiveInfinity;
            this.JHKFGMGHFJN();
            this.BCGMNMJFMLD.positionSpring = 10f;
            this.BCGMNMJFMLD.positionDamper = 1f;
            this.BCGMNMJFMLD.maximumForce = float.PositiveInfinity;
            this.JOLAOHLFJPP.positionSpring = 40f;
            this.JOLAOHLFJPP.positionDamper = 1.5f;
            this.JOLAOHLFJPP.maximumForce = float.PositiveInfinity;
        }


        internal override void GHGLMNMONHK(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, bool DOLMJFFJFBH, bool PKGLIMPDIIP)
        {
            ConfigurableJoint configurableJoint = MCFOLNMFCPN.AJBEMNONLMC;
            configurableJoint.angularXDrive = this.JOLAOHLFJPP;
            configurableJoint.angularYZDrive = this.JOLAOHLFJPP;
            configurableJoint.targetRotation = this.KNBEMABEAII;
        }

        internal override void AGIKMKKNICC()
        {
            this.weaponController.JGBLPPKMAMA();
            base.StartCoroutine(this.JEBEPPGMJIB());
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
            base.KOPJDFGNKLE(NLJBANLOGGI, ref this.LMOPCBGKBID, this.OHIAODBCHHM, 0.00024f, true, 25f, 1f);
        }


        private IEnumerator JEBEPPGMJIB()
        {
            base.LGLOPGKONLO.maxAngularVelocity = 80f;
            if (base.Owner != null)
            {
                this.OHIAODBCHHM = this.IEDNGFIDBBL.characterStates.Power * 0.3f + 0.7f;
            }
            else
            {
                this.OHIAODBCHHM = 1f;
            }
            base.IsAttacking = true;
            this.JPNFHJJIMID();
            float num = 0.39f;
            while (num > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    if (base.Owner != null)
                    {
                        this.DEPEALCFAFP();
                    }
                }
                yield return this.MJOFAKABBGM;
            }
            num = 0.4f;
            while (num > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            this.LMOPCBGKBID = true;
            this.JHKFGMGHFJN();
            base.LGLOPGKONLO.angularDrag = 20f;
            num = 0.37f;
            while (num > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    if (base.Owner != null)
                    {
                        this.DPIFPAMAMHI();
                    }
                }
                yield return this.MJOFAKABBGM;
            }
            base.LGLOPGKONLO.angularDrag = 0.05f;
            num = 0.5f;
            while (num > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.MJOFAKABBGM;
            }
            base.LGLOPGKONLO.maxAngularVelocity = 7f;
            base.IsAttacking = false;
            this.LMOPCBGKBID = false;
            yield break;
        }







        private void MJAGOCPLGMH(Rigidbody FIDJLMHHENM, Collider KMKNCMCNEGD, float PBCAIPOKMDO, Transform FECEPHDPPPO, Vector3 APGCJMPOBCE, ref WeaponJoint OOMHLAIKENN, ConfigurableJointMotion KPEAENHBLJL)
        {
            WeaponJoint weaponJoint = base.gameObject.AddComponent<WeaponJoint>();
            OOMHLAIKENN = weaponJoint;
            weaponJoint.KOFJBKAKBNL.connectedBody = FIDJLMHHENM;
            weaponJoint.KOFJBKAKBNL.anchor = FECEPHDPPPO.localPosition;
            weaponJoint.KOFJBKAKBNL.autoConfigureConnectedAnchor = false;
            weaponJoint.KOFJBKAKBNL.connectedAnchor = APGCJMPOBCE;
            weaponJoint.KOFJBKAKBNL.connectedMassScale = PBCAIPOKMDO;
            weaponJoint.KOFJBKAKBNL.xMotion = KPEAENHBLJL;
            weaponJoint.KOFJBKAKBNL.yMotion = KPEAENHBLJL;
            weaponJoint.KOFJBKAKBNL.zMotion = KPEAENHBLJL;
            weaponJoint.KOFJBKAKBNL.projectionMode = JointProjectionMode.PositionAndRotation;
            weaponJoint.KOFJBKAKBNL.angularXDrive = this.FAGCNGAPDID;
            weaponJoint.KOFJBKAKBNL.angularYZDrive = this.FAGCNGAPDID;
            KMKNCMCNEGD.isTrigger = false;
        }

        internal override void DMJOIPHGHEB(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
            ConfigurableJoint configurableJoint = MCFOLNMFCPN.GDPPIFIJPMF;
            configurableJoint.angularXDrive = this.CKCKKJLNJAJ;
            configurableJoint.angularYZDrive = this.CKCKKJLNJAJ;
            configurableJoint.targetRotation = this.GEKLOCOKAGF;
            ConfigurableJoint configurableJoint2 = MCFOLNMFCPN.BBMLJFHODAL;
            configurableJoint2.angularXDrive = this.KKBPLDJIMIL;
            configurableJoint2.angularYZDrive = this.KKBPLDJIMIL;
            configurableJoint2.targetRotation = this.PLPGAPIAFAI;
            if (!base.IsAttacking)
            {
                float num = (Mathf.Sin(AGCJDIFCAKA * 2f + 3.14159f + 0.2f) + 1f) * 0.5f;
                if (GHMBNLHGMHG)
                {
                    num += -num + 1f;
                }
                this.PLPGAPIAFAI = Quaternion.Slerp(this.DNFNPOGLDFD, this.FJNGMDGDNGN, num);
            }
        }




        public Transform AddForcePos;

        public WeaponHammer.AttackSide HammerAttackSide;

        private float OHIAODBCHHM;

        public float WavingForce = 3500f;

        private JointDrive AMCKDLMMMOA;

        private JointDrive JHGFCIOAFND;

        private JointDrive NFDHMEDNOJE;

        private JointDrive NLABLAPEDMD;

        private Quaternion NCMFECIANCF = Quaternion.Euler(new Quaternion(0.15f, -0.65f, 0f, 1f).eulerAngles);

        private Quaternion EELMPAGBCDD = Quaternion.Euler(new Quaternion(0f, -0.9f, 0f, 1f).eulerAngles);

        private Quaternion FLAOFENOPOK = Quaternion.Euler(new Quaternion(0.15f, 0.65f, 0f, 1f).eulerAngles);

        private Quaternion KJEBKBBGGAK = Quaternion.Euler(new Quaternion(0f, 0.9f, 0f, 1f).eulerAngles);

        private Quaternion ALPEGBAHDAM = Quaternion.Euler(new Quaternion(0.63f, 0f, 0f, 1f).eulerAngles);

        private Quaternion CFFNHCEDODD = Quaternion.Euler(new Quaternion(1f, 0f, 0f, 1f).eulerAngles);

        private Quaternion DNFNPOGLDFD = Quaternion.Euler(new Quaternion(0.86f, 0f, 0f, 1f).eulerAngles);

        private Quaternion FJNGMDGDNGN = Quaternion.Euler(new Quaternion(0.63f, 0f, 0f, 1f).eulerAngles);

        private JointDrive AGKMLPMJIOM;

        private Quaternion GNCDFMINDFE;

        private JointDrive CKCKKJLNJAJ;

        private Quaternion GEKLOCOKAGF;

        private JointDrive GNKGIPKGODJ;

        private Quaternion BCIFFIAIHOD;

        private JointDrive KKBPLDJIMIL;

        private Quaternion PLPGAPIAFAI;

        private JointDrive BCGMNMJFMLD;

        private JointDrive JOLAOHLFJPP;

        private Quaternion KNBEMABEAII = new Quaternion(-0.06f, 0f, 0f, 1f);

        private WeaponJoint IENEBFKFMPP;

        private WeaponJoint BAPBKJIHLLJ;

        private Rigidbody PNGENFLDJAG;

        private readonly JointDrive FAGCNGAPDID = new JointDrive
        {
            positionSpring = 0f,
            positionDamper = 5f,
            maximumForce = 999999f
        };

        public enum AttackSide
        {
            Left,
            Right
        }
    }
}