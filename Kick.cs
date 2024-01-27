using System;
using System.Collections;
using UnityEngine;
namespace Deobfuscated
{
    internal class Kick : MonoBehaviour
    {

        private IEnumerator FIFGFJHNIHI()
        {
            this.EGMDKOIAGFM.angularDrag = 50f;
            this.KHABJLNHGKO.FIEKPFBMNIC(0.01f);
            this.KHABJLNHGKO.HKHHJCILJGO(1.56f);
            this.IsKickingOnGround = true;
            this.ICDGMGJKAGN();
            Kick.KickSide dkgolmdclkl = this.DKGOLMDCLKL;
            if (dkgolmdclkl != Kick.KickSide.LeftKick)
            {
                if (dkgolmdclkl == Kick.KickSide.RightKick)
                {
                    this.JJEDOBGAIHP.CanKickBoost = true;
                }
            }
            else
            {
                this.PCCHFCGEJCJ.CanKickBoost = true;
            }
            //num = 0.08f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    float t = Mathf.SmoothStep(0f, 1f, 1f - /*num / */0.08f);
                    Vector3 euler = new Vector3(Mathf.Lerp(5.72f, 70f, t), 0f, 0f);
                    Vector3 euler2 = new Vector3(Mathf.Lerp(-11.42f, -2f, t), 0f, 0f);
                    dkgolmdclkl = this.DKGOLMDCLKL;
                    if (dkgolmdclkl != Kick.KickSide.LeftKick)
                    {
                        if (dkgolmdclkl == Kick.KickSide.RightKick)
                        {
                            this.HBMPBJECDLK.targetRotation = Quaternion.Euler(euler);
                            this.PAFKOHDPMPM.targetRotation = Quaternion.Euler(euler2);
                            Vector3 vector = -this.EGMDKOIAGFM.transform.up * 800f + -this.NJGPEMDFMEC.transform.up * 200f;
                            this.NJGPEMDFMEC.AddForce(vector, ForceMode.Acceleration);
                            this.EGMDKOIAGFM.AddForceAtPosition(-vector * 0.6f, this.EGMDKOIAGFM.transform.TransformPoint(new Vector3(0.22f, 0f, 0f)), ForceMode.Acceleration);
                        }
                    }
                    else
                    {
                        this.AENJEOOOADA.targetRotation = Quaternion.Euler(euler);
                        this.PBHCEDBOLHH.targetRotation = Quaternion.Euler(euler2);
                        Vector3 vector2 = -this.EGMDKOIAGFM.transform.up * 600f + -this.KGMCAHGALON.transform.up * 200f;
                        this.KGMCAHGALON.AddForce(vector2, ForceMode.Acceleration);
                        this.EGMDKOIAGFM.AddForceAtPosition(-vector2 * 0.6f, this.EGMDKOIAGFM.transform.TransformPoint(new Vector3(-0.22f, 0f, 0f)), ForceMode.Acceleration);
                    }
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            dkgolmdclkl = this.DKGOLMDCLKL;
            if (dkgolmdclkl != Kick.KickSide.LeftKick)
            {
                if (dkgolmdclkl == Kick.KickSide.RightKick)
                {
                    this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.RightKick, this.NJGPEMDFMEC);
                }
            }
            else
            {
                this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.LeftKick, this.KGMCAHGALON);
            }
            //num = 0.1f;
            while (/*num >= 0f && */this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    float t2 = 1f - /*num / */0.1f;
                    Vector3 euler3 = new Vector3(Mathf.Lerp(70f, 5.72f, t2), 0f, 0f);
                    Vector3 euler4 = new Vector3(Mathf.Lerp(-2f, -11.42f, t2), 0f, 0f);
                    dkgolmdclkl = this.DKGOLMDCLKL;
                    if (dkgolmdclkl != Kick.KickSide.LeftKick)
                    {
                        if (dkgolmdclkl == Kick.KickSide.RightKick)
                        {
                            this.HBMPBJECDLK.targetRotation = Quaternion.Euler(euler3);
                            this.PAFKOHDPMPM.targetRotation = Quaternion.Euler(euler4);
                        }
                    }
                    else
                    {
                        this.AENJEOOOADA.targetRotation = Quaternion.Euler(euler3);
                        this.PBHCEDBOLHH.targetRotation = Quaternion.Euler(euler4);
                    }
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            dkgolmdclkl = this.DKGOLMDCLKL;
            if (dkgolmdclkl != Kick.KickSide.LeftKick)
            {
                if (dkgolmdclkl == Kick.KickSide.RightKick)
                {
                    this.JJEDOBGAIHP.CanKickBoost = false;
                    this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.RightKick, this.NJGPEMDFMEC);
                }
            }
            else
            {
                this.PCCHFCGEJCJ.CanKickBoost = false;
                this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.LeftKick, this.KGMCAHGALON);
            }
            // num = 0.11f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.IsKicking = false;
            this.IsKickingOnGround = false;
            this.EGMDKOIAGFM.angularDrag = 0.05f;
            this.JPELDONHMPO = true;
            yield break;
        }





        private IEnumerator FCHBNGJNLJM()
        {
            this.KHABJLNHGKO.FIEKPFBMNIC(0.06f);
            this.KHABJLNHGKO.HKHHJCILJGO(2.18f);
            this.PCCHFCGEJCJ.CanKickBoost = true;
            this.JJEDOBGAIHP.CanKickBoost = true;
            this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.LeftFlyKick, this.KGMCAHGALON);
            this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.RightFlyKick, this.NJGPEMDFMEC);
            this.PLOLLPLDPLH();
            float num = 0.04f;
            while (num >= 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    this.NHHHJPABIJH();
                }
                yield return this.LGJIFPAHACH;
            }
            num = 0.05f;
            while (num >= 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.EGMDKOIAGFM.constraints = RigidbodyConstraints.None;
            num = 3f;
            while (!this.KPLKMDDKCML.MJAFJDDBMHN && num > 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.KPLKMDDKCML.CharacterFootHasFriction();
            base.StartCoroutine(this.MakeKickBoostFalse());
            num = 0.6f;
            while (num >= 0f && this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.LeftFlyKick, this.KGMCAHGALON);
            this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.RightFlyKick, this.NJGPEMDFMEC);
            this.IsKicking = false;
            yield break;
        }



        public void CharacterKick(Vector3 OAFIFPPACGO)
        {
            if (this.EGMDKOIAGFM.constraints == RigidbodyConstraints.None)
            {
                this.IsKicking = true;
                base.StartCoroutine(this.GBLNJBOHPHI());
                return;
            }
            if (!this.IsOnGroundBeforeKick)
            {
                this.IsKicking = true;
                base.StartCoroutine(this.FCHBNGJNLJM());
                return;
            }
            if (this.IsMoving)
            {
                bool flag = this.isRunning;
                return;
            }
            this.IsKicking = true;
            if (this.JPELDONHMPO)
            {
                base.StartCoroutine(this.FIFGFJHNIHI());
                return;
            }
            base.StartCoroutine(this.FKHDMCBNMPO());
        }



        private IEnumerator JBLKMIHACCC()
        {
            //num = 0.25f;
            while (/*num >= 0f &&*/ !this.IsKickingOnGround)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    // num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.JPELDONHMPO = false;
            yield break;
        }





        private void AOMCLHHFLGG(ConfigurableJoint LEJHEGJJLHI, JointDrive JMFNAELEMKC, Quaternion GONDJLNEANP)
        {
            LEJHEGJJLHI.angularXDrive = JMFNAELEMKC;
            LEJHEGJJLHI.angularYZDrive = JMFNAELEMKC;
            LEJHEGJJLHI.targetRotation = GONDJLNEANP;
        }

        private bool JPELDONHMPO
        {
            get
            {
                return this.IDMFEFIFEOO;
            }
            set
            {
                if (this.IDMFEFIFEOO != value)
                {
                    this.IDMFEFIFEOO = value;
                    if (value)
                    {
                        base.StartCoroutine(this.JBLKMIHACCC());
                    }
                }
            }
        }





        private void NHHHJPABIJH()
        {
            Vector3 up = this.Hip.transform.up;
            CFOGGNCCHCO.OEODACNOHCD(this.KGMCAHGALON, -up * 2000f, this.KGMCAHGALON.transform.position, ForceMode.Acceleration);
            CFOGGNCCHCO.OEODACNOHCD(this.NJGPEMDFMEC, -up * 2000f, this.NJGPEMDFMEC.transform.position, ForceMode.Acceleration);
            CFOGGNCCHCO.EFNEGHJPJFN(this.PPIDNAOBLHE, -up * -2050f, ForceMode.Acceleration);
        }




        private void Start()
        {
            this.KHABJLNHGKO = base.GetComponent<CharacterStates>();
            this.EGMDKOIAGFM = this.Hip.GetComponent<Rigidbody>();
            this.KGMCAHGALON = this.LeftLeg2.GetComponent<Rigidbody>();
            this.PBHCEDBOLHH = this.LeftLeg2.GetComponent<ConfigurableJoint>();
            this.NJGPEMDFMEC = this.RightLeg2.GetComponent<Rigidbody>();
            this.PAFKOHDPMPM = this.RightLeg2.GetComponent<ConfigurableJoint>();
            this.AENJEOOOADA = this.LeftLeg1.GetComponent<ConfigurableJoint>();
            this.HBMPBJECDLK = this.RightLeg1.GetComponent<ConfigurableJoint>();
            this.PPIDNAOBLHE = this.Chest.GetComponent<Rigidbody>();
            this.PCCHFCGEJCJ = this.LeftLeg2.GetComponent<KickBoost>();
            this.JJEDOBGAIHP = this.RightLeg2.GetComponent<KickBoost>();
            this.KPLKMDDKCML = base.GetComponent<PhysicCharacterController>();
            this.OPPPCPALFPE.positionSpring = 40f;
            this.OPPPCPALFPE.positionDamper = 5f;
            this.OPPPCPALFPE.maximumForce = float.PositiveInfinity;
            this.KIBJBEAHGML.positionSpring = 35f;
            this.KIBJBEAHGML.positionDamper = 5f;
            this.KIBJBEAHGML.maximumForce = float.PositiveInfinity;
            this.GLOGOOKMKJA.positionSpring = 600f;
            this.GLOGOOKMKJA.positionDamper = 5f;
            this.GLOGOOKMKJA.maximumForce = float.PositiveInfinity;
            this.JOAOGCPOCJK.positionSpring = 200f;
            this.JOAOGCPOCJK.positionDamper = 5f;
            this.JOAOGCPOCJK.maximumForce = float.PositiveInfinity;
            this.IBCHDKILLLN = this.OPPPCPALFPE;
            this.PFHIIGIAHON = this.KIBJBEAHGML;
            this.ODCDGGHEHOP = this.OPPPCPALFPE;
            this.NHKLFNNOGCP = this.KIBJBEAHGML;
        }


        private void JHIKPMLCGCN()
        {
            Kick.KickSide dkgolmdclkl = this.DKGOLMDCLKL;
            if (dkgolmdclkl == Kick.KickSide.LeftKick)
            {
                this.DKGOLMDCLKL = Kick.KickSide.RightKick;
                return;
            }
            if (dkgolmdclkl != Kick.KickSide.RightKick)
            {
                return;
            }
            this.DKGOLMDCLKL = Kick.KickSide.LeftKick;
        }


        private IEnumerator GBLNJBOHPHI()
        {
            this.KHABJLNHGKO.FIEKPFBMNIC(0.005f);
            this.KHABJLNHGKO.HKHHJCILJGO(1f);
            Kick.KickSide dkgolmdclkl = this.DKGOLMDCLKL;
            if (dkgolmdclkl != Kick.KickSide.LeftKick)
            {
                if (dkgolmdclkl == Kick.KickSide.RightKick)
                {
                    this.JJEDOBGAIHP.CanKickBoost = true;
                    this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.RightKick, this.NJGPEMDFMEC);
                }
            }
            else
            {
                this.PCCHFCGEJCJ.CanKickBoost = true;
                this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.LeftKick, this.KGMCAHGALON);
            }
            this.AJBPPJMLFFF();
            //num = 0.19f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                    this.FNFODOKHGNH();
                }
                yield return this.LGJIFPAHACH;
            }
            // num = 0.19f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    // num -= Time.fixedDeltaTime;
                    this.FPBHJLFPAIO();
                }
                yield return this.LGJIFPAHACH;
            }
            dkgolmdclkl = this.DKGOLMDCLKL;
            if (dkgolmdclkl != Kick.KickSide.LeftKick)
            {
                if (dkgolmdclkl == Kick.KickSide.RightKick)
                {
                    this.JJEDOBGAIHP.CanKickBoost = false;
                    this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.RightKick, this.NJGPEMDFMEC);
                }
            }
            else
            {
                this.PCCHFCGEJCJ.CanKickBoost = false;
                this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.LeftKick, this.KGMCAHGALON);
            }
            //num = 0.1f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.IsKicking = false;
            this.JHIKPMLCGCN();
            yield break;
        }

        private void PLOLLPLDPLH()
        {
            this.AOMCLHHFLGG(this.AENJEOOOADA, this.OPPPCPALFPE, this.AMPDAEHGIII);
            this.AOMCLHHFLGG(this.HBMPBJECDLK, this.OPPPCPALFPE, this.AMPDAEHGIII);
            this.AOMCLHHFLGG(this.PBHCEDBOLHH, this.KIBJBEAHGML, this.FPADCBCFIAI);
            this.AOMCLHHFLGG(this.PAFKOHDPMPM, this.KIBJBEAHGML, this.FPADCBCFIAI);
        }





        private void FNFODOKHGNH()
        {
            Kick.KickSide dkgolmdclkl = this.DKGOLMDCLKL;
            if (dkgolmdclkl == Kick.KickSide.LeftKick)
            {
                Vector3 up = this.LeftLeg2.transform.up;
                CFOGGNCCHCO.EFNEGHJPJFN(this.KGMCAHGALON, up * 1100f, ForceMode.Force);
                CFOGGNCCHCO.EFNEGHJPJFN(this.PPIDNAOBLHE, up * -1100f, ForceMode.Force);
                return;
            }
            if (dkgolmdclkl != Kick.KickSide.RightKick)
            {
                return;
            }
            Vector3 up2 = this.RightLeg2.transform.up;
            CFOGGNCCHCO.EFNEGHJPJFN(this.NJGPEMDFMEC, up2 * 1100f, ForceMode.Force);
            CFOGGNCCHCO.EFNEGHJPJFN(this.PPIDNAOBLHE, up2 * -1100f, ForceMode.Force);
        }





        private void FPBHJLFPAIO()
        {
            Kick.KickSide dkgolmdclkl = this.DKGOLMDCLKL;
            if (dkgolmdclkl == Kick.KickSide.LeftKick)
            {
                Vector3 up = this.LeftLeg2.transform.up;
                CFOGGNCCHCO.EFNEGHJPJFN(this.KGMCAHGALON, up * -1300f, ForceMode.Force);
                CFOGGNCCHCO.EFNEGHJPJFN(this.PPIDNAOBLHE, up * 1300f, ForceMode.Force);
                return;
            }
            if (dkgolmdclkl != Kick.KickSide.RightKick)
            {
                return;
            }
            Vector3 up2 = this.RightLeg2.transform.up;
            CFOGGNCCHCO.EFNEGHJPJFN(this.NJGPEMDFMEC, up2 * -1300f, ForceMode.Force);
            CFOGGNCCHCO.EFNEGHJPJFN(this.PPIDNAOBLHE, up2 * 1300f, ForceMode.Force);
        }


        private void AJBPPJMLFFF()
        {
            this.AOMCLHHFLGG(this.AENJEOOOADA, this.GLOGOOKMKJA, this.LBAKBDKGGKA);
            this.AOMCLHHFLGG(this.HBMPBJECDLK, this.GLOGOOKMKJA, this.LBAKBDKGGKA);
            this.AOMCLHHFLGG(this.PBHCEDBOLHH, this.JOAOGCPOCJK, this.NGCOBMAGCPA);
            this.AOMCLHHFLGG(this.PAFKOHDPMPM, this.JOAOGCPOCJK, this.NGCOBMAGCPA);
        }




        private void ICDGMGJKAGN()
        {
            this.AOMCLHHFLGG(this.AENJEOOOADA, this.GLOGOOKMKJA, this.LBAKBDKGGKA);
            this.AOMCLHHFLGG(this.HBMPBJECDLK, this.GLOGOOKMKJA, this.LBAKBDKGGKA);
            this.AOMCLHHFLGG(this.PBHCEDBOLHH, this.JOAOGCPOCJK, this.NGCOBMAGCPA);
            this.AOMCLHHFLGG(this.PAFKOHDPMPM, this.JOAOGCPOCJK, this.NGCOBMAGCPA);
        }


        public IEnumerator MakeKickBoostFalse()
        {
            //num = 0.1f;
            //while (num >= 0f)
            //{
            //    if (!PhysicsDummyModeManager.IsPaused)
            //    {
            //        num -= Time.fixedDeltaTime;
            //    }
            yield return this.LGJIFPAHACH;
            //}
            this.PCCHFCGEJCJ.CanKickBoost = false;
            this.JJEDOBGAIHP.CanKickBoost = false;
            yield break;
        }


        private IEnumerator FKHDMCBNMPO()
        {
            this.EGMDKOIAGFM.angularDrag = 50f;
            this.KHABJLNHGKO.FIEKPFBMNIC(0.01f);
            this.KHABJLNHGKO.HKHHJCILJGO(1.56f);
            this.IsKickingOnGround = true;
            this.ICDGMGJKAGN();
            this.JHIKPMLCGCN();
            Kick.KickSide dkgolmdclkl = this.DKGOLMDCLKL;
            if (dkgolmdclkl != Kick.KickSide.LeftKick)
            {
                if (dkgolmdclkl == Kick.KickSide.RightKick)
                {
                    this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.RightKick, this.NJGPEMDFMEC);
                }
            }
            else
            {
                this.KPLKMDDKCML.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.LeftKick, this.KGMCAHGALON);
            }
            // num = 0.16f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    float t = 1f - /*num / */0.16f;
                    Vector3 euler = new Vector3(Mathf.Lerp(5.72f, -50f, t), 0f, 0f);
                    Vector3 euler2 = new Vector3(Mathf.Lerp(-11.42f, -50f, t), 0f, 0f);
                    dkgolmdclkl = this.DKGOLMDCLKL;
                    if (dkgolmdclkl != Kick.KickSide.LeftKick)
                    {
                        if (dkgolmdclkl == Kick.KickSide.RightKick)
                        {
                            this.HBMPBJECDLK.targetRotation = Quaternion.Euler(euler);
                            this.PAFKOHDPMPM.targetRotation = Quaternion.Euler(euler2);
                        }
                    }
                    else
                    {
                        this.AENJEOOOADA.targetRotation = Quaternion.Euler(euler);
                        this.PBHCEDBOLHH.targetRotation = Quaternion.Euler(euler2);
                    }
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            dkgolmdclkl = this.DKGOLMDCLKL;
            if (dkgolmdclkl != Kick.KickSide.LeftKick)
            {
                if (dkgolmdclkl == Kick.KickSide.RightKick)
                {
                    this.JJEDOBGAIHP.CanKickBoost = true;
                }
            }
            else
            {
                this.PCCHFCGEJCJ.CanKickBoost = true;
            }
            //num = 0.12f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    float t2 = 1f - /*num / */0.12f;
                    float num2 = 1f - Mathf.Clamp01(/*num /*/ 0.04f);
                    Vector3 euler3 = new Vector3(Mathf.Lerp(-50f, 100f, t2), 0f, 0f);
                    Vector3 euler4 = new Vector3(Mathf.Lerp(-50f, -3f, num2), 0f, 0f);
                    Vector3 euler5 = new Vector3(Mathf.Lerp(5.72f, -10f, num2), 0f, 0f);
                    dkgolmdclkl = this.DKGOLMDCLKL;
                    if (dkgolmdclkl != Kick.KickSide.LeftKick)
                    {
                        if (dkgolmdclkl == Kick.KickSide.RightKick)
                        {
                            this.HBMPBJECDLK.targetRotation = Quaternion.Euler(euler3);
                            this.PAFKOHDPMPM.targetRotation = Quaternion.Euler(euler4);
                            this.AENJEOOOADA.targetRotation = Quaternion.Euler(euler5);
                            if (num2 > 0.01f && num2 < 0.75f)
                            {
                                Vector3 vector = -this.EGMDKOIAGFM.transform.up * 650f + -this.NJGPEMDFMEC.transform.up * 600f;
                                this.NJGPEMDFMEC.AddForce(vector, ForceMode.Acceleration);
                                this.EGMDKOIAGFM.AddForceAtPosition(-vector * 0.2f, this.EGMDKOIAGFM.transform.TransformPoint(new Vector3(0.22f, 0f, 0f)), ForceMode.Acceleration);
                            }
                        }
                    }
                    else
                    {
                        this.AENJEOOOADA.targetRotation = Quaternion.Euler(euler3);
                        this.PBHCEDBOLHH.targetRotation = Quaternion.Euler(euler4);
                        this.HBMPBJECDLK.targetRotation = Quaternion.Euler(euler5);
                        if (num2 > 0.01f && num2 < 0.75f)
                        {
                            Vector3 vector2 = -this.EGMDKOIAGFM.transform.up * 650f + -this.KGMCAHGALON.transform.up * 600f;
                            this.KGMCAHGALON.AddForce(vector2, ForceMode.Acceleration);
                            this.EGMDKOIAGFM.AddForceAtPosition(-vector2 * 0.2f, this.EGMDKOIAGFM.transform.TransformPoint(new Vector3(-0.22f, 0f, 0f)), ForceMode.Acceleration);
                        }
                    }
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            // num = 0.15f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            dkgolmdclkl = this.DKGOLMDCLKL;
            if (dkgolmdclkl != Kick.KickSide.LeftKick)
            {
                if (dkgolmdclkl == Kick.KickSide.RightKick)
                {
                    this.JJEDOBGAIHP.CanKickBoost = false;
                    this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.RightKick, this.NJGPEMDFMEC);
                }
            }
            else
            {
                this.PCCHFCGEJCJ.CanKickBoost = false;
                this.KPLKMDDKCML.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.LeftKick, this.KGMCAHGALON);
            }
            // num = 0.25f;
            while (/*num >= 0f && */this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    float t3 = Mathf.SmoothStep(0f, 1f, 1f - /*num /*/ 0.25f);
                    Vector3 euler6 = new Vector3(Mathf.Lerp(100f, 5.72f, t3), 0f, 0f);
                    Vector3 euler7 = new Vector3(Mathf.Lerp(-3f, -30f, t3), 0f, 0f);
                    Vector3 euler8 = new Vector3(Mathf.Lerp(-10f, 5.72f, t3), 0f, 0f);
                    dkgolmdclkl = this.DKGOLMDCLKL;
                    if (dkgolmdclkl != Kick.KickSide.LeftKick)
                    {
                        if (dkgolmdclkl == Kick.KickSide.RightKick)
                        {
                            this.HBMPBJECDLK.targetRotation = Quaternion.Euler(euler6);
                            this.PAFKOHDPMPM.targetRotation = Quaternion.Euler(euler7);
                            this.AENJEOOOADA.targetRotation = Quaternion.Euler(euler8);
                            Vector3 force = this.EGMDKOIAGFM.transform.up * 50f;
                            this.EGMDKOIAGFM.AddForceAtPosition(force, this.EGMDKOIAGFM.transform.TransformPoint(new Vector3(0.22f, 0f, 0f)), ForceMode.Acceleration);
                        }
                    }
                    else
                    {
                        this.AENJEOOOADA.targetRotation = Quaternion.Euler(euler6);
                        this.PBHCEDBOLHH.targetRotation = Quaternion.Euler(euler7);
                        this.HBMPBJECDLK.targetRotation = Quaternion.Euler(euler8);
                        Vector3 force2 = this.EGMDKOIAGFM.transform.up * 50f;
                        this.EGMDKOIAGFM.AddForceAtPosition(force2, this.EGMDKOIAGFM.transform.TransformPoint(new Vector3(-0.22f, 0f, 0f)), ForceMode.Acceleration);
                    }
                    //num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            // num = 0.1f;
            while (/*num >= 0f &&*/ this.KPLKMDDKCML.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    // num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.IsKicking = false;
            this.IsKickingOnGround = false;
            this.EGMDKOIAGFM.angularDrag = 0.05f;
            this.JPELDONHMPO = true;
            yield break;
        }


        public GameObject Hip;

        private Rigidbody EGMDKOIAGFM;


        public bool IsOnGroundBeforeKick;

        private WaitForFixedUpdate LGJIFPAHACH = new WaitForFixedUpdate();

        public bool IsKicking;

        public bool IsKickingOnGround;

        public bool IsMoving = true;

        public bool IsBeingCaught;

        public bool CanStruggleKickStepOneRun;

        public bool CanStruggleKickStepTwoRun;

        public GameObject LeftLeg2;

        private Rigidbody KGMCAHGALON;

        private ConfigurableJoint PBHCEDBOLHH;

        public GameObject RightLeg2;

        private Rigidbody NJGPEMDFMEC;

        private ConfigurableJoint PAFKOHDPMPM;

        public GameObject LeftLeg1;

        private ConfigurableJoint AENJEOOOADA;

        public GameObject RightLeg1;

        private ConfigurableJoint HBMPBJECDLK;

        public GameObject Chest;

        private CharacterStates KHABJLNHGKO;

        private Rigidbody PPIDNAOBLHE;

        private KickBoost PCCHFCGEJCJ;

        private KickBoost JJEDOBGAIHP;

        private PhysicCharacterController KPLKMDDKCML;

        public bool isRunning;

        private Kick.KickSide DKGOLMDCLKL;

        private JointDrive OPPPCPALFPE;

        private Quaternion AMPDAEHGIII = new Quaternion(0.05f, 0f, 0f, 1f);

        private JointDrive KIBJBEAHGML;

        private Quaternion FPADCBCFIAI = new Quaternion(-0.1f, 0f, 0f, 1f);

        private JointDrive GLOGOOKMKJA;

        private Quaternion LBAKBDKGGKA = new Quaternion(0.05f, 0f, 0f, 1f);

        private JointDrive JOAOGCPOCJK;

        private Quaternion NGCOBMAGCPA = new Quaternion(-0.1f, 0f, 0f, 1f);

        private JointDrive IBCHDKILLLN;


        private JointDrive PFHIIGIAHON;


        private JointDrive ODCDGGHEHOP;


        private JointDrive NHKLFNNOGCP;


        private bool IDMFEFIFEOO;

        public enum KickSide
        {
            LeftKick,
            RightKick
        }
    }
}