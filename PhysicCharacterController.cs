using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace Deobfuscated
{
    public class PhysicCharacterController : MonoBehaviour, Weapon.JLCPDFFPDCF, Boost.IAttackSomeoneCallback, WeaponProjectile.IAttackListener, Weapon.IIDPMLDBKFM, WeaponProjectile.IKillListener, Boost.IKillSomeoneCallback
    {


        private JointStateManager2 DFBGOJLGHKL
        {
            get
            {
                if (this.EMGEKLHOGAF == null)
                {
                    this.EMGEKLHOGAF = this.GreenLegR2.GetComponent<JointStateManager2>();
                }
                return this.EMGEKLHOGAF;
            }
        }



        private JointStateManager2 ADAKFMNLAAD
        {
            get
            {
                if (this.PFGIIFIFDBL == null)
                {
                    this.PFGIIFIFDBL = this.GreenWaist.GetComponent<JointStateManager2>();
                }
                return this.PFGIIFIFDBL;
            }
        }

        // TODO FAKE?
        public void RemoveLeftHandReleaseCallback(PhysicCharacterController.IOnLeftHandReleaseCallback KOMCGCIBLEP)
        {
            this.IOJAKCMCGBC.Remove(KOMCGCIBLEP);
        }

        // TODO FAKE?
        public void AddRightHandGrabSomeoneCallback(PhysicCharacterController.IRightHandGrabSomeoneCallback KOMCGCIBLEP)
        {
            this.KKJPOOOIPMD.Add(KOMCGCIBLEP);
        }

        public string grabbedWeaponProperty
        {
            get
            {
                return this.NIOCJDPHNIE;
            }
            set
            {
                if (this.NIOCJDPHNIE != value)
                {
                    foreach (PhysicCharacterController.IWeaponStateChangeCallbacks weaponStateChangeCallbacks in this.IODFBCIAHDD)
                    {
                        weaponStateChangeCallbacks.OnWeaponPropertyChanged(this.NIOCJDPHNIE, value);
                    }
                    this.NIOCJDPHNIE = value;
                }
            }
        }

        private void LOEFMFEFKFF(Vector3 OJIFEAKMHJD)
        {
            this.KDHFDFDAJDF = this.JLBGHMEINHD.TheHitGameobject;
            this.BLBGODNMLAM = this.PDBOMFMLIAJ.TheHitGameobject;
            if (this.KDHFDFDAJDF != null)
            {
                CFOGGNCCHCO.OEODACNOHCD(this.KDHFDFDAJDF, Vector3.ClampMagnitude(OJIFEAKMHJD * (this.KECDGNLMHLK * 0.5f), this.KDHFDFDAJDF.mass * 30f), this.JLBGHMEINHD.TheHitPos, ForceMode.Impulse);
            }
            if (this.BLBGODNMLAM != null)
            {
                CFOGGNCCHCO.OEODACNOHCD(this.BLBGODNMLAM, Vector3.ClampMagnitude(OJIFEAKMHJD * (this.KECDGNLMHLK * 0.5f), this.BLBGODNMLAM.mass * 30f), this.PDBOMFMLIAJ.TheHitPos, ForceMode.Impulse);
            }
        }



        public void ForceToUngrab()
        {
            this.DJNHNJJKHDL.Ungrab(this, true);
            this.NKDPNMHDKLO.Ungrab(this, false);
        }



        private void BDGFCPABJNC(float IPIDMOCBOFJ, float BNAFACEFKHK, bool GHMBNLHGMHG, bool DOLMJFFJFBH, bool BAFNIPAACNC, float HAIKFONFBPO, Vector3 PAMCJMFLEDD, float DPKCPMHPAAJ)
        {
            if (BAFNIPAACNC)
            {
                float num = (Mathf.Sin(IPIDMOCBOFJ + this.AFICADMEOBP + 0.5f) + 1f) * 0.5f;
                if (GHMBNLHGMHG)
                {
                    num = -num + 1f;
                }
                Quaternion piahakolhjm = Quaternion.Slerp(this.FDCKKKMCEGF, this.FCBJCCNPCOJ, num);
                Quaternion kgoeokpoion = Quaternion.Slerp(this.LMPOEBCFPKK, this.NEHJDIKMCLM, num);
                this.EGBBGIIGKPC(this.AKFKHFBDPBI, this.GIGHLANHALH, this.ICMMLGLKHEJ, this.HIEFGMMNJKM, piahakolhjm, kgoeokpoion, BNAFACEFKHK, DOLMJFFJFBH);
                return;
            }
            if (IPIDMOCBOFJ < 0.03f)
            {
                return;
            }
            if (DPKCPMHPAAJ < 0.2f)
            {
                float t = Mathf.SmoothStep(0f, 1f, HAIKFONFBPO / 80f);
                float num2 = Mathf.Lerp(25f, 85f, t);
                float num3 = num2;
                float num4 = Vector3.Angle(PAMCJMFLEDD, Vector3.up);
                float f;
                float num5;
                if (num4 > 90f)
                {
                    if (GHMBNLHGMHG)
                    {
                        f = IPIDMOCBOFJ + this.AFICADMEOBP * 0.5f + 2.15f;
                    }
                    else
                    {
                        f = IPIDMOCBOFJ - this.AFICADMEOBP * 0.5f + 2.15f;
                    }
                    float t2 = Mathf.SmoothStep(0f, 1f, (num4 - 90f) / 80f);
                    num2 = Mathf.Lerp(num2, 45f, t2);
                    num5 = Mathf.Lerp(0f, 80f, t2);
                }
                else
                {
                    if (GHMBNLHGMHG)
                    {
                        f = -IPIDMOCBOFJ + this.AFICADMEOBP * 0.5f + 4.05f;
                    }
                    else
                    {
                        f = -IPIDMOCBOFJ - this.AFICADMEOBP * 0.5f + 4.05f;
                    }
                    float t3 = Mathf.SmoothStep(0f, 1f, num4 / 80f);
                    num2 = Mathf.Lerp(60f, num2, t3);
                    num5 = Mathf.Lerp(-45f, 0f, t3);
                }
                this.ANFLGMAIJHA.x = Mathf.Sin(f) * num2 + num5;
                this.ANFLGMAIJHA.y = Mathf.Cos(f) * num3;
            }
            else
            {
                float f2;
                if (Vector3.Angle(PAMCJMFLEDD, Vector3.up) > 90f)
                {
                    if (GHMBNLHGMHG)
                    {
                        f2 = IPIDMOCBOFJ + this.AFICADMEOBP * 0.5f + 2.15f;
                    }
                    else
                    {
                        f2 = IPIDMOCBOFJ - this.AFICADMEOBP * 0.5f + 2.15f;
                    }
                }
                else if (GHMBNLHGMHG)
                {
                    f2 = -IPIDMOCBOFJ + this.AFICADMEOBP * 0.5f + 4.05f;
                }
                else
                {
                    f2 = -IPIDMOCBOFJ - this.AFICADMEOBP * 0.5f + 4.05f;
                }
                this.ANFLGMAIJHA.x = Mathf.Sin(f2) * 85f;
                this.ANFLGMAIJHA.y = Mathf.Cos(f2) * 85f;
            }
            this.LNFPIFJNFDI(this.AKFKHFBDPBI, this.GIGHLANHALH, Quaternion.Euler(this.ANFLGMAIJHA), this.HNBKMCDLJID);
        }





        private IEnumerator PGJCAIIFJFL()
        {
            yield return this.LGJIFPAHACH;
            this.MCMLHECLGIA = false;
            yield break;
        }

        private void IHGBKKKCFDM(float BNNFLLJFIAN)
        {
            this.OALKKLFABKF = false;
            this.CharacterFootHasFriction();
            this.APDAHKJEAEI();
            if (this.KGLGJIEGFHN <= 120f && this.KGLGJIEGFHN >= 2f)
            {
                float num = Mathf.SmoothStep(0f, 1f, BNNFLLJFIAN);
                float d = (-2f * this.KGLGJIEGFHN + 300f) * num;
                float d2 = (-3.33f * this.KGLGJIEGFHN + 500f) * num;
                Vector3 position = this.PDLEJPNAIIB.position;
                Vector3 forward = this.PDLEJPNAIIB.forward;
                CFOGGNCCHCO.OEODACNOHCD(this.PNGENFLDJAG, Vector3.up * d, position + forward * 2f, ForceMode.Acceleration);
                CFOGGNCCHCO.OEODACNOHCD(this.PNGENFLDJAG, Vector3.down * d, position - forward, ForceMode.Acceleration);
                if (this.MJAFJDDBMHN)
                {
                    CFOGGNCCHCO.EFNEGHJPJFN(this.FIIKBADHOJH, Vector3.up * d2, ForceMode.Force);
                    CFOGGNCCHCO.EFNEGHJPJFN(this.PNGENFLDJAG, Vector3.down * d2, ForceMode.Force);
                }
            }
            if (this.KGLGJIEGFHN < 2f)
            {
                this.JAJBFJEHDND();
                this.EOANGLDJKHM = false;
                this.OALKKLFABKF = true;
                this.PPPPOHGKPJD();
            }
        }

        internal float LMAENCDEEFE { get; set; }

        public PhysicCharacterController.CharacterBasicState CBasicState
        {
            get
            {
                return this.DPHHOCBFDPC;
            }
            set
            {
                if (this.DPHHOCBFDPC != value)
                {
                    this.DPHHOCBFDPC = value;
                    if (value == PhysicCharacterController.CharacterBasicState.Normal)
                    {
                        this.characterStates.isConscious = true;
                        using (HashSet<PhysicCharacterController.ICharacterBasicStateChangedCallback>.Enumerator enumerator = this.BFJKIGGHGBM.GetEnumerator())
                        {
                            while (enumerator.MoveNext())
                            {
                                PhysicCharacterController.ICharacterBasicStateChangedCallback characterBasicStateChangedCallback = enumerator.Current;
                                characterBasicStateChangedCallback.OnCharacterBasicStateChanged(value);
                            }
                            return;
                        }
                    }
                    this.characterStates.isConscious = false;
                    foreach (PhysicCharacterController.ICharacterBasicStateChangedCallback characterBasicStateChangedCallback2 in this.BFJKIGGHGBM)
                    {
                        characterBasicStateChangedCallback2.OnCharacterBasicStateChanged(value);
                    }
                }
            }
        }

        internal ConfigurableJoint NELDBBMLJLH
        {
            get
            {
                if (this.BAKLJKPPMPL == null)
                {
                    this.BAKLJKPPMPL = this.GreenLegR1.GetComponent<ConfigurableJoint>();
                }
                return this.BAKLJKPPMPL;
            }
        }



        private void NIECFEHMBNG(float HPOGKPNKHJC)
        {
            if (this.GMLKAKDJHPC == PhysicCharacterController.MEPJPNCLOFD.Rolling)
            {
                return;
            }
            if (this.CLJAOHHONIB.isReadyToThrowSth)
            {
                this.CLJAOHHONIB.isReadyToThrowSth = false;
                Vector3 normalized = (-this.PDLEJPNAIIB.up + this.PDLEJPNAIIB.forward * 1.7f).normalized;
                if (this.PDLEJPNAIIB.worldToLocalMatrix.MultiplyPoint(this.LNDDLJMNLBD.position).y > -0.05f && this.PDLEJPNAIIB.worldToLocalMatrix.MultiplyPoint(this.PIMHHNKOCBE.position).y > -0.05f)
                {
                    normalized = (-this.PDLEJPNAIIB.up + this.PDLEJPNAIIB.forward * 10f).normalized;
                }
                this.CLJAOHHONIB.CharacterThrowing(this.EACLPKFKCGE.JIIIHLGDFFN, this.AEIDNHLPPEB.JIIIHLGDFFN, normalized, this.CLJAOHHONIB.readyToThrowDuration);
                this.DJNHNJJKHDL.Ungrab(this, true);
                this.NKDPNMHDKLO.Ungrab(this, false);
                this.CLJAOHHONIB.readyToThrowDuration = 0f;
                return;
            }
            if (HPOGKPNKHJC > 0f && HPOGKPNKHJC <= 0.25f)
            {
                if (this.WeaponGrabbed)
                {
                    this.DCKMAPMEJOJ();
                    return;
                }
                if (this.characterStates.Power > 0f && !this.characterStates.IsTooTired)
                {
                    this.EKMEAOKDCJM();
                }
                if (this.characterStates.Power > 0f)
                {
                    this.KIAEHKLDFLI();
                }
            }
        }

        private void BBFLKCCJIOL(float AGCJDIFCAKA, bool KLCJOFLBFOB, bool GHMBNLHGMHG)
        {
            if (AGCJDIFCAKA < this.AFICADMEOBP && !KLCJOFLBFOB)
            {
                this.IMIIFNONDDM.angularXDrive = this.MPNODMMENFE;
                this.BGMAHMGFAOO.angularXDrive = this.NBAKBFNGPKO;
                this.NELDBBMLJLH.angularXDrive = this.MPNODMMENFE;
                this.EMDJIGOAPAI.angularXDrive = this.NBAKBFNGPKO;
                this.IMIIFNONDDM.angularYZDrive = this.MPNODMMENFE;
                this.BGMAHMGFAOO.angularYZDrive = this.NBAKBFNGPKO;
                this.NELDBBMLJLH.angularYZDrive = this.MPNODMMENFE;
                this.EMDJIGOAPAI.angularYZDrive = this.NBAKBFNGPKO;
                float t = Mathf.Sin(AGCJDIFCAKA);
                Quaternion targetRotation;
                Quaternion targetRotation2;
                Quaternion targetRotation3;
                Quaternion targetRotation4;
                if (GHMBNLHGMHG)
                {
                    targetRotation = Quaternion.SlerpUnclamped(this.MNKIJJECKDI, this.LIOFJHOJKDO, t);
                    targetRotation2 = Quaternion.SlerpUnclamped(this.ABAGFMMDFIO, this.OJHJBONHDMD, t);
                    targetRotation3 = Quaternion.SlerpUnclamped(this.MNKIJJECKDI, this.IOFIHBBBGPF, t);
                    targetRotation4 = Quaternion.SlerpUnclamped(this.ABAGFMMDFIO, this.OKJFOJNEBOH, t);
                }
                else
                {
                    targetRotation = Quaternion.SlerpUnclamped(this.MNKIJJECKDI, this.IOFIHBBBGPF, t);
                    targetRotation2 = Quaternion.SlerpUnclamped(this.ABAGFMMDFIO, this.OKJFOJNEBOH, t);
                    targetRotation3 = Quaternion.SlerpUnclamped(this.MNKIJJECKDI, this.LIOFJHOJKDO, t);
                    targetRotation4 = Quaternion.SlerpUnclamped(this.ABAGFMMDFIO, this.OJHJBONHDMD, t);
                }
                this.IMIIFNONDDM.targetRotation = targetRotation;
                this.BGMAHMGFAOO.targetRotation = targetRotation2;
                this.NELDBBMLJLH.targetRotation = targetRotation3;
                this.EMDJIGOAPAI.targetRotation = targetRotation4;
                return;
            }
            this.IMIIFNONDDM.angularXDrive = this.IKEKGAMGHGJ.WalkJointDrive;
            this.BGMAHMGFAOO.angularXDrive = this.CJECNBIPOHG.WalkJointDrive;
            this.NELDBBMLJLH.angularXDrive = this.PLPLLMMJFAD.WalkJointDrive;
            this.EMDJIGOAPAI.angularXDrive = this.DFBGOJLGHKL.WalkJointDrive;
            this.IMIIFNONDDM.angularYZDrive = this.IKEKGAMGHGJ.WalkJointDrive;
            this.BGMAHMGFAOO.angularYZDrive = this.CJECNBIPOHG.WalkJointDrive;
            this.NELDBBMLJLH.angularYZDrive = this.PLPLLMMJFAD.WalkJointDrive;
            this.EMDJIGOAPAI.angularYZDrive = this.DFBGOJLGHKL.WalkJointDrive;
            float num = Mathf.Sin(AGCJDIFCAKA);
            float t2;
            float t3;
            if (GHMBNLHGMHG)
            {
                t2 = (-num + 1f) * 0.5f;
                t3 = (num + 1f) * 0.5f;
            }
            else
            {
                t2 = (num + 1f) * 0.5f;
                t3 = (-num + 1f) * 0.5f;
            }
            Quaternion targetRotation5 = Quaternion.Slerp(this.BPAIMJJCMCF, this.BJLBKIEDGDL, t2);
            Quaternion targetRotation6 = Quaternion.Slerp(this.BPAIMJJCMCF, this.BJLBKIEDGDL, t3);
            this.IMIIFNONDDM.targetRotation = targetRotation5;
            this.NELDBBMLJLH.targetRotation = targetRotation6;
            this.EMDJIGOAPAI.targetRotation = this.ABAGFMMDFIO;
            this.BGMAHMGFAOO.targetRotation = this.ABAGFMMDFIO;
        }



        private void NPEKDHAHNDD(float AGCJDIFCAKA)
        {
            this.IMIIFNONDDM.angularXDrive = this.IKEKGAMGHGJ.WalkJointDrive;
            this.BGMAHMGFAOO.angularXDrive = this.CJECNBIPOHG.WalkJointDrive;
            this.NELDBBMLJLH.angularXDrive = this.PLPLLMMJFAD.WalkJointDrive;
            this.EMDJIGOAPAI.angularXDrive = this.DFBGOJLGHKL.WalkJointDrive;
            this.IMIIFNONDDM.angularYZDrive = this.IKEKGAMGHGJ.WalkJointDrive;
            this.BGMAHMGFAOO.angularYZDrive = this.CJECNBIPOHG.WalkJointDrive;
            this.NELDBBMLJLH.angularYZDrive = this.PLPLLMMJFAD.WalkJointDrive;
            this.EMDJIGOAPAI.angularYZDrive = this.DFBGOJLGHKL.WalkJointDrive;
            this.EMDJIGOAPAI.targetRotation = this.ABAGFMMDFIO;
            this.BGMAHMGFAOO.targetRotation = this.ABAGFMMDFIO;
            float t = (Mathf.Sin(AGCJDIFCAKA * 1.3f) + 1f) * 0.5f;
            float t2 = (Mathf.Sin(AGCJDIFCAKA * 1.3f + this.AFICADMEOBP) + 1f) * 0.5f;
            Quaternion targetRotation = Quaternion.Lerp(this.JHKEOJMHMKM, this.LEFJHPEALOK, t);
            Quaternion targetRotation2 = Quaternion.Lerp(this.JHKEOJMHMKM, this.LEFJHPEALOK, t2);
            this.IMIIFNONDDM.targetRotation = targetRotation;
            this.NELDBBMLJLH.targetRotation = targetRotation2;
            Quaternion targetRotation3 = Quaternion.Slerp(this.CFMEFNKNILK, this.ABAGFMMDFIO, t);
            Quaternion targetRotation4 = Quaternion.Slerp(this.CFMEFNKNILK, this.ABAGFMMDFIO, t2);
            this.BGMAHMGFAOO.targetRotation = targetRotation3;
            this.EMDJIGOAPAI.targetRotation = targetRotation4;
        }

        public WeaponType grabbedWeaponType
        {
            get
            {
                return this.EEPEJFBMHKE;
            }
            set
            {
                if (this.EEPEJFBMHKE != value)
                {
                    foreach (PhysicCharacterController.IWeaponStateChangeCallbacks weaponStateChangeCallbacks in this.IODFBCIAHDD)
                    {
                        weaponStateChangeCallbacks.OnWeaponTypeChanged(this.EEPEJFBMHKE, value);
                    }
                    this.EEPEJFBMHKE = value;
                }
            }
        }

        internal bool ILPCNDKKCHO { get; set; }

        public void MakeCharacterComeBackToLife()
        {
            this.HCCIJMAMMEC();
            this.characterStates.Health = this.characterStates.MaxHealth;
            this.characterStates.High = this.characterStates.MaxHigh;
            this.characterStates.LPPGHONKBDJ();
            this.characterStates.Power = this.characterStates.MaxPower;
            this.characterStates.HLGCLBMAHLO = 1f;
        }



        private IEnumerator CLOPCBJKFND()
        {
            float num = 0.1f;
            while (num >= 0f)
            {
                num -= Time.fixedDeltaTime;
                yield return this.LGJIFPAHACH;
            }
            this.DBBEBMMNNEB();
            yield break;
        }

        private JointStateManager2 PLPLLMMJFAD
        {
            get
            {
                if (this.GGIGFFAKHMP == null)
                {
                    this.GGIGFFAKHMP = this.GreenLegR1.GetComponent<JointStateManager2>();
                }
                return this.GGIGFFAKHMP;
            }
        }

        private void FixedUpdate()
        {
            if (PhysicsDummyModeManager.IsPaused)
            {
                return;
            }
            this.JLKGOJOFFBK();
            this.LBNIOFADCCG();
            this.IJOCNCFAGEI.CalculateForwardDir(ref this.HKGBHCGOOKE, this.OKBJDGHGCIK, this.KMMNIGMMEAG, this.PDLEJPNAIIB);
            this.ODGICNHJICA.CalculateHipVelocity(this.PNGENFLDJAG, ref this.LOHHEFLPHEG);
            this.JKEKKHKGEFO.CalculateAcceleration(out this.CIPJGGBEMGL);
            this.FAJMFJHDLFK.CalculateAcceleration(out this.BKPILGAPIGH);
            this.CFKIOPKGFEJ.CalculateAcceleration(out this.DJAOAGKKACH);
            this.AIPMEMPGKKP.CalculateAcceleration(out this.NDNICBAIOAF);
            this.OJPPKAKAKNL.CalculateAcceleration(out this.NHHMJOMLGHK);
            PhysicCharacterController.CharacterBasicState cbasicState = this.CBasicState;
            if (cbasicState != PhysicCharacterController.CharacterBasicState.Unconcious)
            {
                if (cbasicState != PhysicCharacterController.CharacterBasicState.Normal)
                {
                    return;
                }
                if (this.characterStates.isElectrified && this.characterStates.JMLCCAOHNAM > this.characterStates.INFDILKFHLD)
                {
                    this.characterStates.LDCHGNBONJN(Mathf.Max(this.characterStates.dizzy - -0.2f, 0f) + 0.02f);
                }
                if (this.characterStates.dizzy <= 0f || this.characterStates.Health <= 0f)
                {
                    this.CharacterFootHasFriction();
                    this.CBasicState = PhysicCharacterController.CharacterBasicState.Unconcious;
                    if (this.characterStates.isElectrified)
                    {
                        this.GBGABKDCFAH();
                    }
                    else
                    {
                        this.DJNHNJJKHDL.Ungrab(this, true);
                        this.NKDPNMHDKLO.Ungrab(this, false);
                        this.HBBHGELKGEC();
                        this.CharacterDropWeapon();
                    }
                    if (this.characterStates.Health <= 0f)
                    {
                        this.characterStates.Power = 0f;
                    }
                    this.EOANGLDJKHM = false;
                    this.OALKKLFABKF = false;
                    this.OKKJNOCLIEE = 0f;
                    this.MDJOFGBFCJE = Vector3.zero;
                    return;
                }
                this.KGLGJIEGFHN = Vector3.Angle(this.PDLEJPNAIIB.forward, Vector3.up);
                this.BPFGCBCOLLJ(ref this.GAAABCJJPLA, ref this.OKKJNOCLIEE);
                if (this.OKKJNOCLIEE > 0f)
                {
                    this.OKKJNOCLIEE -= Time.fixedDeltaTime;
                    this.MJAFJDDBMHN = true;
                }
                else
                {
                    this.MJAFJDDBMHN = false;
                }
                if (this.MJAFJDDBMHN)
                {
                    this.JDCIBMAFDBP += Time.fixedDeltaTime;
                    this.AGCOOKPELPB = 0f;
                }
                else
                {
                    this.AGCOOKPELPB += Time.fixedDeltaTime;
                    this.JDCIBMAFDBP = 0f;
                }
                this.HCGGGEOLADN(out this.OGPMMDHONON, out this.FLIHOPJMBPC);
                this.HMCNICLAPFH(this.OGPMMDHONON, this.FLIHOPJMBPC, out this.MDJOFGBFCJE, out this.IAMNFCFJPIG);
                if (this.MJAFJDDBMHN && this.BMFBMAMHGKG != PhysicCharacterController.AKDGAGJFAOJ.PowerPunching)
                {
                    if (this.GMLKAKDJHPC == PhysicCharacterController.MEPJPNCLOFD.Walking && this.MDJOFGBFCJE.magnitude >= 10f)
                    {
                        this.APDAHKJEAEI();
                    }
                    if (this.GMLKAKDJHPC == PhysicCharacterController.MEPJPNCLOFD.Standing && this.MDJOFGBFCJE.magnitude >= 7f)
                    {
                        this.APDAHKJEAEI();
                    }
                }
                float magnitude = this.NDNICBAIOAF.magnitude;
                float magnitude2 = this.NHHMJOMLGHK.magnitude;
                float magnitude3 = this.CIPJGGBEMGL.magnitude;
                float magnitude4 = this.BKPILGAPIGH.magnitude;
                float magnitude5 = this.DJAOAGKKACH.magnitude;
                this.FMAHCHOJMDG(this.characterStates, magnitude, magnitude2, magnitude3, magnitude4, magnitude5, this.LDMNBPBABCH, this.JOHBNEIKLFL.IsKicking, this.EFOPJOCPODJ, this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.PowerPunching, this.KGLGJIEGFHN, this.OGPMMDHONON, this.MDJOFGBFCJE);
                if (this.characterStates.HLGCLBMAHLO <= 0f)
                {
                    this.APDAHKJEAEI();
                }
                this.KHCPFEKLBDE(this.CIPJGGBEMGL, this.BKPILGAPIGH, this.DJAOAGKKACH, this.LDMNBPBABCH, this.JOHBNEIKLFL.IsKicking, this.GMLKAKDJHPC == PhysicCharacterController.MEPJPNCLOFD.Rolling, this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.PowerPunching, this.OGPMMDHONON, this.DENOIHACJHE.LBAILHKBMLF, this.CLJAOHHONIB.isThrowingSth, this.MDJOFGBFCJE, this.MJAFJDDBMHN);
                if (this.KGLGJIEGFHN > 4f && this.MDJOFGBFCJE.magnitude <= 6f && !this.GAAABCJJPLA && !this.JOHBNEIKLFL.IsKicking && !this.DENOIHACJHE.LBAILHKBMLF && this.BMFBMAMHGKG != PhysicCharacterController.AKDGAGJFAOJ.PowerPunching)
                {
                    this.EOANGLDJKHM = true;
                }
                if (this.EOANGLDJKHM && this.characterStates.HLGCLBMAHLO > 0.2f)
                {
                    if (!this.GDJNMJBCMMB && this.GMLKAKDJHPC != PhysicCharacterController.MEPJPNCLOFD.Rolling)
                    {
                        this.FPEOKBDFNJK = true;
                        this.IHGBKKKCFDM(this.characterStates.HLGCLBMAHLO);
                    }
                    else
                    {
                        this.FPEOKBDFNJK = false;
                    }
                }
                else
                {
                    this.FPEOKBDFNJK = false;
                }
                if (this.OALKKLFABKF && this.characterStates.HLGCLBMAHLO > 0.2f)
                {
                    if (!this.JOHBNEIKLFL.IsKicking && !this.DENOIHACJHE.LBAILHKBMLF && !this.GDJNMJBCMMB && this.MoveX == 0f && this.MoveY == 0f && this.GMLKAKDJHPC != PhysicCharacterController.MEPJPNCLOFD.Rolling)
                    {
                        this.KJCJPIKABAE = true;
                        this.AJKHPLDIPAK();
                    }
                    else
                    {
                        this.KJCJPIKABAE = false;
                    }
                }
                else
                {
                    this.KJCJPIKABAE = false;
                }
                if (this.GDJNMJBCMMB && (this.GAAABCJJPLA || !this.MJAFJDDBMHN))
                {
                    this.APDAHKJEAEI();
                }
                if (this.IKGLJMCPAJA <= 0f)
                {
                    this.GDJNMJBCMMB = false;
                    this.IKGLJMCPAJA = 0f;
                }
                else
                {
                    this.IKGLJMCPAJA -= Time.fixedDeltaTime;
                }
                this.MOPPNJLNOJM();
                if (this.PBBDEBBIHDA.IsRolling)
                {
                    this.GMLKAKDJHPC = PhysicCharacterController.MEPJPNCLOFD.Rolling;
                }
                else if (this.GMLKAKDJHPC == PhysicCharacterController.MEPJPNCLOFD.Rolling)
                {
                    this.GMLKAKDJHPC = PhysicCharacterController.MEPJPNCLOFD.Standing;
                }
                switch (this.GMLKAKDJHPC)
                {
                    case PhysicCharacterController.MEPJPNCLOFD.Standing:
                        if (!this.JOHBNEIKLFL.IsKicking && !this.GFBJCPDAAKJ)
                        {
                            this.IJOKHEILPGJ();
                        }
                        break;
                    case PhysicCharacterController.MEPJPNCLOFD.Walking:
                        if (!this.JOHBNEIKLFL.IsKicking)
                        {
                            if (this.PNGENFLDJAG.constraints == RigidbodyConstraints.None || this.KGLGJIEGFHN > 60f)
                            {
                                this.NPEKDHAHNDD(this.JGHLFHJLKCC);
                            }
                            else
                            {
                                this.BBFLKCCJIOL(this.JGHLFHJLKCC, this.DOLMJFFJFBH, this.LLNDLPJHINF);
                            }
                        }
                        break;
                    case PhysicCharacterController.MEPJPNCLOFD.Jumping:
                        if (!this.JOHBNEIKLFL.IsKicking)
                        {
                            if (this.PNGENFLDJAG.constraints != RigidbodyConstraints.None)
                            {
                                this.GEDPNCMIEAM();
                            }
                            else
                            {
                                this.NPEKDHAHNDD(this.JGHLFHJLKCC);
                            }
                        }
                        break;
                }
                switch (this.GMLKAKDJHPC)
                {
                    case PhysicCharacterController.MEPJPNCLOFD.Standing:
                        {
                            PhysicCharacterController.AKDGAGJFAOJ akdgagjfaoj = this.BMFBMAMHGKG;
                            if (akdgagjfaoj != PhysicCharacterController.AKDGAGJFAOJ.PowerPunching)
                            {
                                this.EIJMGPIIAJH(this.PNGENFLDJAG.constraints > RigidbodyConstraints.None);
                                if (this.KMILBNNIHJG != null)
                                {
                                    this.KMILBNNIHJG.FCPOCNFEKCJ(this, this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.DOLMJFFJFBH, this.MJAFJDDBMHN, this.LLNDLPJHINF);
                                }
                            }
                            break;
                        }
                    case PhysicCharacterController.MEPJPNCLOFD.Walking:
                        {
                            PhysicCharacterController.AKDGAGJFAOJ akdgagjfaoj = this.BMFBMAMHGKG;
                            if (akdgagjfaoj != PhysicCharacterController.AKDGAGJFAOJ.PowerPunching)
                            {
                                this.HJBDOKHICHL(this.DOLMJFFJFBH, Vector3.ProjectOnPlane(this.HKGBHCGOOKE, Vector3.up).normalized, this.CNOFPKHKEBH, this.MCPOAGEENGA);
                                if (this.KMILBNNIHJG != null)
                                {
                                    this.KMILBNNIHJG.FCPOCNFEKCJ(this, this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.DOLMJFFJFBH, this.MJAFJDDBMHN, this.LLNDLPJHINF);
                                }
                                else if (this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.Nothing && this.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.Nothing)
                                {
                                    this.AMEOIIBNMDG(this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.LLNDLPJHINF);
                                }
                                else
                                {
                                    this.DCPEKNKCMKN(this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.LLNDLPJHINF);
                                }
                            }
                            break;
                        }
                }
                switch (this.BMFBMAMHGKG)
                {
                    case PhysicCharacterController.AKDGAGJFAOJ.Nothing:
                        switch (this.GMLKAKDJHPC)
                        {
                            case PhysicCharacterController.MEPJPNCLOFD.Standing:
                                if (!this.CLJAOHHONIB.isThrowingSth)
                                {
                                    this.BNDLACDMDED(this.AKFKHFBDPBI, this.GIGHLANHALH, this.ICMMLGLKHEJ, this.HIEFGMMNJKM, this.AGCOOKPELPB);
                                }
                                break;
                            case PhysicCharacterController.MEPJPNCLOFD.Walking:
                                if (!this.LAHKPENBLEN && !this.CLJAOHHONIB.isThrowingSth)
                                {
                                    this.BDGFCPABJNC(this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.LLNDLPJHINF, this.DOLMJFFJFBH, this.PNGENFLDJAG.constraints > RigidbodyConstraints.None, this.KGLGJIEGFHN, -this.PDLEJPNAIIB.up, this.AGCOOKPELPB);
                                }
                                break;
                            case PhysicCharacterController.MEPJPNCLOFD.Jumping:
                                if (!this.DENOIHACJHE.LBAILHKBMLF && (this.PNGENFLDJAG.constraints != RigidbodyConstraints.None || this.JOHBNEIKLFL.IsKicking))
                                {
                                    this.JCFOCNCJPIJ(this.AKFKHFBDPBI, this.GIGHLANHALH, this.ICMMLGLKHEJ, this.HIEFGMMNJKM);
                                }
                                else
                                {
                                    this.BDGFCPABJNC(this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.LLNDLPJHINF, this.DOLMJFFJFBH, this.PNGENFLDJAG.constraints > RigidbodyConstraints.None, this.KGLGJIEGFHN, -this.PDLEJPNAIIB.up, this.AGCOOKPELPB);
                                }
                                break;
                        }
                        break;
                    case PhysicCharacterController.AKDGAGJFAOJ.Grabbing:
                        if (this.EACLPKFKCGE.ThisHandIsGrabbingObj && !this.BFCMBNKBFAF && !this.CLJAOHHONIB.isReadyToThrowSth && !this.CLJAOHHONIB.isThrowingSth)
                        {
                            this.IMKNKLFLKPI(this.AKFKHFBDPBI, this.GIGHLANHALH, this.ICMMLGLKHEJ, this.HIEFGMMNJKM);
                        }
                        break;
                    case PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon:
                        if (this.KMILBNNIHJG != null)
                        {
                            this.KMILBNNIHJG.HPMGJPMEFED(this, this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.DOLMJFFJFBH, this.MJAFJDDBMHN, this.LLNDLPJHINF, this.AGCOOKPELPB);
                        }
                        break;
                }
                switch (this.EHGLGFNALGH)
                {
                    case PhysicCharacterController.AKDGAGJFAOJ.Nothing:
                        switch (this.GMLKAKDJHPC)
                        {
                            case PhysicCharacterController.MEPJPNCLOFD.Standing:
                                if (!this.CLJAOHHONIB.isThrowingSth)
                                {
                                    this.BNDLACDMDED(this.GDPPIFIJPMF, this.BBMLJFHODAL, this.LMCPDIKPBHG, this.ALHOJAPIOOM, this.AGCOOKPELPB);
                                }
                                break;
                            case PhysicCharacterController.MEPJPNCLOFD.Walking:
                                if (!this.LAHKPENBLEN && !this.CLJAOHHONIB.isThrowingSth)
                                {
                                    this.KFFLEBCIDAO(this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.LLNDLPJHINF, this.DOLMJFFJFBH, this.PNGENFLDJAG.constraints > RigidbodyConstraints.None, this.KGLGJIEGFHN, -this.PDLEJPNAIIB.up, this.AGCOOKPELPB);
                                }
                                break;
                            case PhysicCharacterController.MEPJPNCLOFD.Jumping:
                                if (!this.DENOIHACJHE.LBAILHKBMLF && (this.PNGENFLDJAG.constraints != RigidbodyConstraints.None || this.JOHBNEIKLFL.IsKicking))
                                {
                                    this.JCFOCNCJPIJ(this.GDPPIFIJPMF, this.BBMLJFHODAL, this.LMCPDIKPBHG, this.ALHOJAPIOOM);
                                }
                                else
                                {
                                    this.KFFLEBCIDAO(this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.LLNDLPJHINF, this.DOLMJFFJFBH, this.PNGENFLDJAG.constraints > RigidbodyConstraints.None, this.KGLGJIEGFHN, -this.PDLEJPNAIIB.up, this.AGCOOKPELPB);
                                }
                                break;
                        }
                        break;
                    case PhysicCharacterController.AKDGAGJFAOJ.Grabbing:
                        if (this.AEIDNHLPPEB.ThisHandIsGrabbingObj && !this.BFCMBNKBFAF && !this.CLJAOHHONIB.isReadyToThrowSth && !this.CLJAOHHONIB.isThrowingSth)
                        {
                            this.IMKNKLFLKPI(this.GDPPIFIJPMF, this.BBMLJFHODAL, this.LMCPDIKPBHG, this.ALHOJAPIOOM);
                        }
                        break;
                    case PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon:
                        if (this.KMILBNNIHJG != null)
                        {
                            this.KMILBNNIHJG.DMJOIPHGHEB(this, this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.DOLMJFFJFBH, this.MJAFJDDBMHN, this.LLNDLPJHINF, this.AGCOOKPELPB);
                        }
                        break;
                }
                PhysicCharacterController.MEPJPNCLOFD gmlkakdjhpc = this.GMLKAKDJHPC;
                if (gmlkakdjhpc != PhysicCharacterController.MEPJPNCLOFD.Jumping && gmlkakdjhpc != PhysicCharacterController.MEPJPNCLOFD.Rolling)
                {
                    PhysicCharacterController.AKDGAGJFAOJ akdgagjfaoj = this.BMFBMAMHGKG;
                    if (akdgagjfaoj != PhysicCharacterController.AKDGAGJFAOJ.PowerPunching)
                    {
                        if (!this.DENOIHACJHE.LBAILHKBMLF)
                        {
                            if (this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.Punching || this.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.Punching)
                            {
                                this.FBGDLKJEPJP();
                            }
                            else if (!this.CLJAOHHONIB.isReadyToThrowSth)
                            {
                                this.PLFDDJNANOM();
                            }
                        }
                        if (this.KMILBNNIHJG != null)
                        {
                            this.KMILBNNIHJG.GHGLMNMONHK(this, this.JGHLFHJLKCC, this.DOLMJFFJFBH, this.MJAFJDDBMHN);
                        }
                    }
                }
                if (!this.EFOPJOCPODJ)
                {
                    if (this.MoveX * this.MoveX + this.MoveY * this.MoveY >= 0.08f)
                    {
                        if (!this.JOHBNEIKLFL.IsKicking && this.GMLKAKDJHPC != PhysicCharacterController.MEPJPNCLOFD.Rolling)
                        {
                            if (Math.Abs(this.JGHLFHJLKCC) < 0.005f)
                            {
                                this.FOFBLLOPELE(ref this.LLNDLPJHINF);
                            }
                            if (this.Run && this.characterStates.Power > 0f && !this.characterStates.IsTooTired)
                            {
                                this.JGHLFHJLKCC += Time.fixedDeltaTime * 11f * (this.KPFCLKBGMCD + 0.8f);
                                this.MCPOAGEENGA += Time.fixedDeltaTime;
                                this.DOLMJFFJFBH = true;
                            }
                            else
                            {
                                if (this.KMFDIFCHDLJ < 0.5f)
                                {
                                    this.JGHLFHJLKCC += Time.fixedDeltaTime * 11f * this.KPFCLKBGMCD * 0.6f;
                                }
                                else
                                {
                                    this.JGHLFHJLKCC += Time.fixedDeltaTime * 11f * this.KPFCLKBGMCD;
                                }
                                this.MCPOAGEENGA = 0f;
                                this.DOLMJFFJFBH = false;
                            }
                            this.KMFDIFCHDLJ += Time.fixedDeltaTime;
                            if (this.GMLKAKDJHPC == PhysicCharacterController.MEPJPNCLOFD.Standing)
                            {
                                this.GMLKAKDJHPC = PhysicCharacterController.MEPJPNCLOFD.Walking;
                            }
                            if (!this.KJCJPIKABAE && this.BMFBMAMHGKG != PhysicCharacterController.AKDGAGJFAOJ.PowerPunching)
                            {
                                this.PNGENFLDJAG.angularDrag = 0.05f;
                            }
                            this.HDPAFOLKHCE(this.MoveX, this.MoveY, this.DOLMJFFJFBH, this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.EFOPJOCPODJ, ref this.CNOFPKHKEBH, this.KGLGJIEGFHN, this.OGPMMDHONON, this.FLIHOPJMBPC, this.IILAPAPDGCL, this.MDJOFGBFCJE, this.IAMNFCFJPIG);
                            this.NCKFENCNIJP.AddVector(new Vector3(this.MoveX, 0f, this.MoveY));
                            this.IGALMHPOGDH = 0f;
                            this.GFBJKJCFBBA = false;
                            if (this.MHCJMOEMBOC != null)
                            {
                                base.StopCoroutine(this.MHCJMOEMBOC);
                                this.GFBJCPDAAKJ = false;
                            }
                        }
                    }
                    else
                    {
                        this.CharacterFootHasFriction();
                        if (this.JGHLFHJLKCC % this.AFICADMEOBP >= 0.23f && !this.GFBJCPDAAKJ)
                        {
                            if ((Mathf.Cos(this.JGHLFHJLKCC) > 0f && Mathf.Sin(this.JGHLFHJLKCC) > 0f) || (Mathf.Cos(this.JGHLFHJLKCC) < 0f && Mathf.Sin(this.JGHLFHJLKCC) < 0f))
                            {
                                this.JGHLFHJLKCC = (float)Mathf.CeilToInt(this.JGHLFHJLKCC / this.AFICADMEOBP) * this.AFICADMEOBP - this.JGHLFHJLKCC % this.AFICADMEOBP;
                            }
                            this.JGHLFHJLKCC += Time.fixedDeltaTime * 6f * this.KPFCLKBGMCD;
                            this.PEFOGDAIDBK(this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.CNOFPKHKEBH, this.OGPMMDHONON, this.FLIHOPJMBPC, this.MDJOFGBFCJE, this.IAMNFCFJPIG);
                        }
                        else
                        {
                            this.IGALMHPOGDH += Time.fixedDeltaTime;
                            this.KMFDIFCHDLJ = 0f;
                            this.JGHLFHJLKCC = 0f;
                            if (this.GMLKAKDJHPC == PhysicCharacterController.MEPJPNCLOFD.Walking)
                            {
                                this.GMLKAKDJHPC = PhysicCharacterController.MEPJPNCLOFD.Standing;
                            }
                        }
                        if (this.PNGENFLDJAG.constraints != RigidbodyConstraints.None && this.IGALMHPOGDH < 40f && this.GMLKAKDJHPC != PhysicCharacterController.MEPJPNCLOFD.Rolling && !this.GFBJKJCFBBA)
                        {
                            Vector3 vector = this.NCKFENCNIJP.GetFilteredVector();
                            if (this.KMILBNNIHJG != null)
                            {
                                vector = Quaternion.Euler(0f, this.KMILBNNIHJG.FBJDPKDEJNP, 0f) * vector;
                            }
                            Vector2 vector2 = new Vector2(vector.x, vector.z);
                            if (this.DJIDPOADDKN)
                            {
                                this.IGCKGDIFPHN(vector2);
                            }
                            if (!this.GFBJCPDAAKJ && this.MJAFJDDBMHN && !this.LDMNBPBABCH && !this.GAAABCJJPLA && vector2.magnitude > 0.1f && Vector3.Angle(-this.OKBJDGHGCIK.up, new Vector3(vector2.x, 0f, vector2.y)) > 30f && !this.JOHBNEIKLFL.IsKicking && this.ENKDAEMMGNE)
                            {
                                this.GFBJCPDAAKJ = true;
                                base.StartCoroutine(this.MHCJMOEMBOC);
                            }
                        }
                        this.MCPOAGEENGA = 0f;
                        this.DOLMJFFJFBH = false;
                    }
                }
                else
                {
                    this.FACBAHFCGGK(this.MoveX, this.MoveY, this.MJAFJDDBMHN, this.GAAABCJJPLA, this.KGLGJIEGFHN);
                }
                if (this.KMFDIFCHDLJ > 0.01f)
                {
                    this.AGEABAJABPD += Time.fixedDeltaTime;
                    if (this.AGEABAJABPD >= 2f)
                    {
                        this.AGEABAJABPD = 2f;
                    }
                }
                else if (this.AGEABAJABPD > 0f)
                {
                    this.AGEABAJABPD -= Time.fixedDeltaTime;
                }
                else
                {
                    this.AGEABAJABPD = 0f;
                }
                this.IILAPAPDGCL = (this.AGEABAJABPD >= 1f);
                if (this.KHEKDCLAPKO)
                {
                    this.AJHFKPHJKMP();
                }
                if (this.MCMLHECLGIA)
                {
                    this.NIECFEHMBNG(this.MHBBNONAKGP);
                }
                if (this.Punch)
                {
                    this.MHBBNONAKGP += Time.fixedDeltaTime;
                    this.LAJPBLECHKO();
                }
                else
                {
                    this.MHBBNONAKGP = 0f;
                }
                if (this.BGFBPIHFGEH)
                {
                    if (Time.fixedTime - this.FLMOKMDGMPB < 0.25f && !this.AELMKKAPJNG)
                    {
                        this.CharacterDropWeapon();
                    }
                    this.FLMOKMDGMPB = Time.fixedTime;
                }
                if (this.Grab)
                {
                    if (!this.WeaponGrabbed)
                    {
                        if ((!this.EACLPKFKCGE.ThisHandIsGrabbingObj || !this.AEIDNHLPPEB.ThisHandIsGrabbingObj) && !this.AELMKKAPJNG)
                        {
                            this.ILPCNDKKCHO = (this.HHJLJLPJBOO > 0.25f);
                            if (!this.EACLPKFKCGE.ThisHandIsGrabbingObj && !this.AEIDNHLPPEB.ThisHandIsGrabbingObj)
                            {
                                this.PEPMKBNFPEC.EAAKPIIBAIL(this.ILPCNDKKCHO);
                            }
                            else if (this.EACLPKFKCGE.ThisHandIsGrabbingObj && !this.AEIDNHLPPEB.ThisHandIsGrabbingObj)
                            {
                                this.PEPMKBNFPEC.AIOKPBPGIBI(this.EACLPKFKCGE.GrabbingStaticObject, this.EACLPKFKCGE.JIIIHLGDFFN, this.ILPCNDKKCHO);
                            }
                            else
                            {
                                this.PEPMKBNFPEC.LMIHMJILEBP(this.AEIDNHLPPEB.GrabbingStaticObject, this.AEIDNHLPPEB.JIIIHLGDFFN, this.ILPCNDKKCHO);
                            }
                        }
                        if (this.DPMGIOOBPAH >= 0.02f && !this.GBKFKAIOCBN && this.GMLKAKDJHPC != PhysicCharacterController.MEPJPNCLOFD.Rolling && !this.GFAHFDEOPCJ && !this.CLJAOHHONIB.cannotGrab)
                        {
                            if ((this.PEPMKBNFPEC.LKIEHLMCJCM == null || this.EACLPKFKCGE.ThisHandIsGrabbingObj || this.AEIDNHLPPEB.ThisHandIsGrabbingObj) && !this.AELMKKAPJNG)
                            {
                                if (this.characterStates.Power >= 0.05f)
                                {
                                    this.BDCHENHEHKE();
                                }
                                this.EACLPKFKCGE.FixedUpdateOfThis();
                                this.AEIDNHLPPEB.FixedUpdateOfThis();
                            }
                            else
                            {
                                this.DJNHNJJKHDL.Ungrab(this, true);
                                this.NKDPNMHDKLO.Ungrab(this, false);
                                this.BJFAMDKDLKJ(ref this.AELMKKAPJNG);
                            }
                        }
                    }
                    this.DPMGIOOBPAH += Time.fixedDeltaTime;
                }
                else
                {
                    this.GBKFKAIOCBN = false;
                    this.AELMKKAPJNG = false;
                    this.DJNHNJJKHDL.Ungrab(this, true);
                    this.NKDPNMHDKLO.Ungrab(this, false);
                    if (!this.WeaponGrabbed)
                    {
                        this.CharacterDropWeapon();
                    }
                    this.DPMGIOOBPAH = 0f;
                }
                if (this.Jump)
                {
                    this.HHJLJLPJBOO += Time.fixedDeltaTime;
                }
                else
                {
                    this.HHJLJLPJBOO = 0f;
                    this.HBBHGFFPFPC = false;
                }
                if (this.KPPMGBBENED && !this.LDMNBPBABCH && !this.EAAAAFMPKKN && !this.MKBCAPJLPGK && !this.JOHBNEIKLFL.IsKicking && this.GMLKAKDJHPC != PhysicCharacterController.MEPJPNCLOFD.Rolling && !this.EFOPJOCPODJ)
                {
                    if (this.PNGENFLDJAG.constraints != RigidbodyConstraints.None && this.MJAFJDDBMHN && (!this.GDJNMJBCMMB || !this.GAAABCJJPLA))
                    {
                        this.CharacterFootNoFriction(0.05f);
                        this.NCJCCDPCKAD();
                    }
                    else if ((this.GDJNMJBCMMB || this.PNGENFLDJAG.constraints == RigidbodyConstraints.None) && this.KGLGJIEGFHN > 70f)
                    {
                        this.PLKLOCGBNHP();
                    }
                }
                if (this.HHJLJLPJBOO > 0.25f && !this.EFOPJOCPODJ)
                {
                    bool thisHandIsGrabbingObj = this.EACLPKFKCGE.ThisHandIsGrabbingObj;
                    bool thisHandIsGrabbingObj2 = this.AEIDNHLPPEB.ThisHandIsGrabbingObj;
                    this.MMPGLJIJBPM(thisHandIsGrabbingObj, thisHandIsGrabbingObj2);
                }
                if (this.Headbutt && this.NDNGALHPINI && !this.CIMGMKJHJHH && this.DOLMJFFJFBH && this.MJAFJDDBMHN && !this.LDMNBPBABCH && !this.JOHBNEIKLFL.IsKicking && this.characterStates.Power > 0f && !this.characterStates.IsTooTired && this.GMLKAKDJHPC != PhysicCharacterController.MEPJPNCLOFD.Rolling && this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.Nothing && this.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.Nothing && !this.DENOIHACJHE.LBAILHKBMLF && !this.EFOPJOCPODJ)
                {
                    this.GMLKAKDJHPC = PhysicCharacterController.MEPJPNCLOFD.Rolling;
                    this.CharacterFootHasFriction();
                    this.characterStates.Power -= 0.23f * this.characterStates.AntiPowerLose * this.characterStates.AntiPowerLoseByEquip;
                    this.characterStates.HKHHJCILJGO(0.52f);
                    this.PBBDEBBIHDA.CharacterRoll();
                    this.NDNGALHPINI = false;
                }
                if (!this.Headbutt && this.EHLHFPDKIJA <= 0.25f && this.EHLHFPDKIJA > 0f && !this.DENOIHACJHE.LBAILHKBMLF && this.characterStates.Power > 0f && !this.characterStates.IsTooTired && !this.JOHBNEIKLFL.IsKicking && this.GMLKAKDJHPC != PhysicCharacterController.MEPJPNCLOFD.Rolling && !this.CIMGMKJHJHH && !this.EFOPJOCPODJ)
                {
                    this.JBHFOJGMOPA();
                }
                if (this.Headbutt)
                {
                    this.EHLHFPDKIJA += Time.fixedDeltaTime;
                }
                if (!this.Headbutt)
                {
                    this.EHLHFPDKIJA = 0f;
                    this.NDNGALHPINI = true;
                }
                if (this.CHBCNLCPMKD && !this.DENOIHACJHE.LBAILHKBMLF && !this.JOHBNEIKLFL.IsKicking && this.characterStates.Power > 0f && !this.characterStates.IsTooTired && this.GMLKAKDJHPC != PhysicCharacterController.MEPJPNCLOFD.Rolling && !this.EFOPJOCPODJ)
                {
                    this.JOHBNEIKLFL.IsOnGroundBeforeKick = this.MJAFJDDBMHN;
                    this.JOHBNEIKLFL.IsMoving = (this.MoveX != 0f || this.MoveY != 0f);
                    this.JOHBNEIKLFL.IsBeingCaught = this.GDJNMJBCMMB;
                    this.JOHBNEIKLFL.isRunning = (this.MCPOAGEENGA > 0.2f);
                    this.CharacterFootNoFriction(0.25f);
                    this.JOHBNEIKLFL.CharacterKick(this.CNOFPKHKEBH);
                    if (this.MHCJMOEMBOC != null)
                    {
                        base.StopCoroutine(this.MHCJMOEMBOC);
                        this.GFBJCPDAAKJ = false;
                    }
                }
                this.DJIDPOADDKN = true;
                if (this.MoveX != 0f || this.MoveY != 0f || this.Punch || this.Headbutt || this.Kick || this.Jump || this.Grab || this.EFOPJOCPODJ)
                {
                    this.PAKNGDIDFGK = 0f;
                }
                else
                {
                    this.PAKNGDIDFGK += Time.fixedDeltaTime;
                }
                bool flag = false;
                if (this.KMILBNNIHJG != null)
                {
                    flag = this.KMILBNNIHJG.ECPGAOFDCKC;
                }
                if (this.PAKNGDIDFGK >= 2f && this.PNGENFLDJAG.constraints != RigidbodyConstraints.None && !flag)
                {
                    this.CIHJEJLGEAD.BecomeHuman(this.AJBEMNONLMC, this.NLEHLJPKLCH, this.AKFKHFBDPBI, this.GDPPIFIJPMF, this.CDBGCHHHPFL, this.GIGHLANHALH, this.BBMLJFHODAL, this.PAKNGDIDFGK, ref this.DJIDPOADDKN, ref this.ENKDAEMMGNE);
                    return;
                }
                this.ENKDAEMMGNE = true;
            }
            else
            {
                if ((this.Jump || this.Headbutt || this.Punch || this.MoveX != 0f || this.MoveY != 0f || this.Kick || this.Grab) && (this.characterStates.dizzy >= 1f || Mathf.Approximately(this.characterStates.dizzy, 1f)) && this.characterStates.Health > 0f)
                {
                    this.HCCIJMAMMEC();
                    Debug.Log(base.gameObject.name + " just woke up");
                    return;
                }
                if (this.IKGLJMCPAJA <= 0f)
                {
                    this.GDJNMJBCMMB = false;
                    this.IKGLJMCPAJA = 0f;
                }
                else
                {
                    this.IKGLJMCPAJA -= Time.fixedDeltaTime;
                }
                if (this.characterStates.isElectrified)
                {
                    if (this.characterStates.isElectrified != this.HBHKAGANHHM)
                    {
                        this.HCMMBKCHDOM();
                        this.GBGABKDCFAH();
                        this.HBHKAGANHHM = this.characterStates.isElectrified;
                    }
                    this.HKDEEIENBIN();
                    return;
                }
                if (this.characterStates.isElectrified != this.HBHKAGANHHM)
                {
                    this.DJNHNJJKHDL.Ungrab(this, true);
                    this.NKDPNMHDKLO.Ungrab(this, false);
                    this.HBBHGELKGEC();
                    this.CharacterDropWeapon();
                    this.HBHKAGANHHM = this.characterStates.isElectrified;
                    return;
                }
            }
        }

        private void JFDPJNACNFM(bool NMNHCICDCOB)
        {
            if (NMNHCICDCOB)
            {
                this.IMIIFNONDDM.angularXDrive = this.DHPMMAFKPMH;
                this.IMIIFNONDDM.angularYZDrive = this.DHPMMAFKPMH;
                this.IMIIFNONDDM.targetRotation = this.ACPCHEEHMDH;
                this.BGMAHMGFAOO.angularXDrive = this.DHPMMAFKPMH;
                this.BGMAHMGFAOO.angularYZDrive = this.DHPMMAFKPMH;
                this.BGMAHMGFAOO.targetRotation = this.EEKPPPJLCEO;
                this.NELDBBMLJLH.angularXDrive = this.DHPMMAFKPMH;
                this.NELDBBMLJLH.angularYZDrive = this.DHPMMAFKPMH;
                this.NELDBBMLJLH.targetRotation = this.ECCFHINAFOH;
                this.EMDJIGOAPAI.angularXDrive = this.DHPMMAFKPMH;
                this.EMDJIGOAPAI.angularYZDrive = this.DHPMMAFKPMH;
                this.EMDJIGOAPAI.targetRotation = this.KBKLKLAGDDP;
                return;
            }
            this.IMIIFNONDDM.angularXDrive = this.DHPMMAFKPMH;
            this.IMIIFNONDDM.angularYZDrive = this.DHPMMAFKPMH;
            this.IMIIFNONDDM.targetRotation = this.ECCFHINAFOH;
            this.BGMAHMGFAOO.angularXDrive = this.DHPMMAFKPMH;
            this.BGMAHMGFAOO.angularYZDrive = this.DHPMMAFKPMH;
            this.BGMAHMGFAOO.targetRotation = this.KBKLKLAGDDP;
            this.NELDBBMLJLH.angularXDrive = this.DHPMMAFKPMH;
            this.NELDBBMLJLH.angularYZDrive = this.DHPMMAFKPMH;
            this.NELDBBMLJLH.targetRotation = this.ACPCHEEHMDH;
            this.EMDJIGOAPAI.angularXDrive = this.DHPMMAFKPMH;
            this.EMDJIGOAPAI.angularYZDrive = this.DHPMMAFKPMH;
            this.EMDJIGOAPAI.targetRotation = this.EEKPPPJLCEO;
        }



        private IEnumerator FDHBCDKEFFH()
        {
            yield return this.LGJIFPAHACH;
            this.NPEGKOAANIO = false;
            yield break;
        }

        private JointStateManager2 ALHOJAPIOOM
        {
            get
            {
                if (this.BIPFJPMKAFE == null)
                {
                    this.BIPFJPMKAFE = this.GreenForeArmR.GetComponent<JointStateManager2>();
                }
                return this.BIPFJPMKAFE;
            }
        }

        private void AJKHPLDIPAK()
        {
            Quaternion rot = Quaternion.LookRotation(Vector3.up, -Vector3.ProjectOnPlane(-this.PDLEJPNAIIB.up, Vector3.up));
            this.PNGENFLDJAG.MoveRotation(rot);
            this.PNGENFLDJAG.angularDrag = 20f;
            if (this.KGLGJIEGFHN < 0.1f || this.KGLGJIEGFHN > 4f || this.EOANGLDJKHM)
            {
                this.OALKKLFABKF = false;
            }
        }

        internal bool ACIJFJIKKNL
        {
            get
            {
                return this.HFDKBIJBEPD;
            }
            set
            {
                if (this.HFDKBIJBEPD != value)
                {
                    if (value)
                    {
                        this.DIFAOOPOMDL = true;
                    }
                    else if (this.AJGFBOPEMML > 0f)
                    {
                        this.AJGFBOPEMML = 0.3f;
                    }
                    else
                    {
                        base.StartCoroutine(this.BOMMJGGOGFK());
                    }
                    this.HFDKBIJBEPD = value;
                }
            }
        }



        private void HBBHGELKGEC()
        {
            this.AJBEMNONLMC.angularXDrive = this.KILOKABBDKH;
            this.AJBEMNONLMC.angularYZDrive = this.KILOKABBDKH;
            this.NLEHLJPKLCH.angularXDrive = this.FPLHHMPMIMJ;
            this.NLEHLJPKLCH.angularYZDrive = this.FPLHHMPMIMJ;
            this.CDBGCHHHPFL.angularXDrive = this.KEADHDBLMLG;
            this.CDBGCHHHPFL.angularYZDrive = this.KEADHDBLMLG;
            this.AKFKHFBDPBI.angularXDrive = this.IABAHICNNPO;
            this.AKFKHFBDPBI.angularYZDrive = this.IABAHICNNPO;
            this.GIGHLANHALH.angularXDrive = this.NLAAEAKMEFD;
            this.GIGHLANHALH.angularYZDrive = this.NLAAEAKMEFD;
            this.GDPPIFIJPMF.angularXDrive = this.IABAHICNNPO;
            this.GDPPIFIJPMF.angularYZDrive = this.IABAHICNNPO;
            this.BBMLJFHODAL.angularXDrive = this.NLAAEAKMEFD;
            this.BBMLJFHODAL.angularYZDrive = this.NLAAEAKMEFD;
            this.IMIIFNONDDM.angularXDrive = this.OGMCJCEAOEM;
            this.IMIIFNONDDM.angularYZDrive = this.OGMCJCEAOEM;
            this.BGMAHMGFAOO.angularXDrive = this.CCHEBKBMNPH;
            this.BGMAHMGFAOO.angularYZDrive = this.CCHEBKBMNPH;
            this.NELDBBMLJLH.angularXDrive = this.OGMCJCEAOEM;
            this.NELDBBMLJLH.angularYZDrive = this.OGMCJCEAOEM;
            this.EMDJIGOAPAI.angularXDrive = this.CCHEBKBMNPH;
            this.EMDJIGOAPAI.angularYZDrive = this.CCHEBKBMNPH;
            for (int i = 0; i < this.rigidbodies.Count; i++)
            {
                this.rigidbodies[i].maxAngularVelocity = 90f;
            }
            this.APDAHKJEAEI();
            this.PNGENFLDJAG.angularDrag = 0.05f;
        }

        internal bool MJAFJDDBMHN { get; private set; }




        internal ConfigurableJoint BBMLJFHODAL
        {
            get
            {
                if (this.DHKMNFLKPFE == null)
                {
                    this.DHKMNFLKPFE = this.GreenForeArmR.GetComponent<ConfigurableJoint>();
                }
                return this.DHKMNFLKPFE;
            }
        }




        private bool EFOPJOCPODJ
        {
            get
            {
                return this.BDAGGEGBLBL;
            }
            set
            {
                if (this.BDAGGEGBLBL != value)
                {
                    this.BDAGGEGBLBL = value;
                    if (value)
                    {
                        this.GLLIOEGCJLA();
                    }
                }
            }
        }

        private void LBNIOFADCCG()
        {
            this.ALFFKLCLFJE = 0f;
            this.ADLMIBPOPDP = 0f;
            this.FBNFDJGNAMF = 0f;
            this.MPACCGNKHFM = 0f;
            this.LMAENCDEEFE = 0f;
            this.CGHHBLBAAOJ = 0f;
            this.NMFIPKMKICJ = 0f;
            this.BGKCNODEJLE = 0f;
            this.ILGFHALPNJB = 0f;
            this.DNOODOFCLCG = 0f;
            this.NDIMOOAHIKA = 0f;
            this.ILJCKDPPIHP = 0f;
            this.KAAHJGOJOMI = 0f;
            this.NBJBDBJDKFG = 0f;
        }

        public bool IsKicking
        {
            get
            {
                return this.JOHBNEIKLFL.IsKicking;
            }
        }

        void WeaponProjectile.IKillListener.OnKillSomeone(PhysicCharacterController MCFOLNMFCPN)
        {
            this.NDDCNKFDAOB(MCFOLNMFCPN);
        }

        void WeaponProjectile.IAttackListener.OnAttackingSomeone(PhysicCharacterController MCFOLNMFCPN)
        {
            this.JDEMFDFOOBM(MCFOLNMFCPN);
        }

        public bool IsThrowingSth
        {
            get
            {
                return this.CLJAOHHONIB.isThrowingSth;
            }
        }


        internal Rigidbody PNGENFLDJAG
        {
            get
            {
                if (this.PNGFPCPBAKB == null)
                {
                    this.PNGFPCPBAKB = this.GreenHip.GetComponent<Rigidbody>();
                }
                return this.PNGFPCPBAKB;
            }
        }

        public bool IsRolling
        {
            get
            {
                return this.HDNBENIBAPH;
            }
        }



        public Vector3 FacingDirection
        {
            get
            {
                return this.HKGBHCGOOKE;
            }
        }



        private void FACBAHFCGGK(float KHKDFAJPIAB, float INBPCIGDEPI, bool PDFHCCNMHAB, bool MBCPLHLDELF, float LHMLHAPCCGJ)
        {
            if (!PDFHCCNMHAB || MBCPLHLDELF || LHMLHAPCCGJ > 95f)
            {
                return;
            }
            Vector3 vector = new Vector3(KHKDFAJPIAB, 0f, INBPCIGDEPI).normalized;
            if (LHMLHAPCCGJ < 45f)
            {
                vector *= this.PMMCAMIHJGB * 0.5f;
            }
            else
            {
                vector *= this.PMMCAMIHJGB * 0.25f;
            }
            this.PNGENFLDJAG.AddForce(vector, ForceMode.Force);
        }

        private void Start()
        {
            this.FDKLJLCPDDK();
            this.ELHAIPPBOAH.positionSpring = 3000f;
            this.ELHAIPPBOAH.positionDamper = 10f;
            this.ELHAIPPBOAH.maximumForce = 99999f;
            this.NDNHNADJLEK.positionSpring = 2000f;
            this.NDNHNADJLEK.positionDamper = 10f;
            this.NDNHNADJLEK.maximumForce = 99999f;
            if (LiftObjectManager.LiftObjectManagerController == null)
            {
                LiftObjectManager.LiftObjectManagerController = new GameObject
                {
                    name = "LiftObjectsManagerController"
                }.AddComponent<LiftObjectManagerController>();
            }
            if (this.layerCanWalkOn == 0)
            {
                Debug.LogError(base.gameObject.name + " layerCanWalkOn is not Valid!!!!!!!!!");
            }
        }

        public void CharacterFootNoFriction(float OKJDJMODMOF)
        {
            this.DLNNLIAMBEP = OKJDJMODMOF;
            this.ACLFECOOBHB.AOKMBPLCGHI(0f, 0f, PhysicMaterialCombine.Average);
            this.ACLFECOOBHB.MDADOFMGFAP(0f, 0f, PhysicMaterialCombine.Average);
        }

        private void NDDCNKFDAOB(PhysicCharacterController MKMAIKGAOGP)
        {
            foreach (PhysicCharacterController.IKillSomeoneCallback killSomeoneCallback in this.PKOEBJAKICC)
            {
                killSomeoneCallback.OnKillSomeone(MKMAIKGAOGP);
            }
        }

        public bool IsChinning
        {
            get
            {
                return this.HBBHGFFPFPC;
            }
        }

        internal Rigidbody IHEELAEEPHA
        {
            get
            {
                if (this.OOOEMIJHBPP == null)
                {
                    this.OOOEMIJHBPP = this.GreenWaist.GetComponent<Rigidbody>();
                }
                return this.OOOEMIJHBPP;
            }
        }


        public bool Kick
        {
            get
            {
                return this.GJHPMOCCOBJ;
            }
            set
            {
                if (this.GJHPMOCCOBJ != value)
                {
                    if (value)
                    {
                        this.CHBCNLCPMKD = true;
                        base.StartCoroutine(this.PBEOHMCMPMC());
                    }
                    else
                    {
                        this.NPEGKOAANIO = true;
                        base.StartCoroutine(this.FDHBCDKEFFH());
                    }
                    this.GJHPMOCCOBJ = value;
                }
            }
        }


        public void PlayRandomMovement(int EGHNINBLFBJ)
        {
            if (this.PAKNGDIDFGK >= 2f && this.PNGENFLDJAG.constraints != RigidbodyConstraints.None)
            {
                this.ENKDAEMMGNE = false;
                this.CIHJEJLGEAD.OverrideMovement(EGHNINBLFBJ + 1);
            }
        }

        internal float NMFIPKMKICJ { get; set; }

        private void HCMMBKCHDOM()
        {
            for (int i = 0; i < this.LAJOGOOAKNM.Count; i++)
            {
                ConfigurableJoint key = this.LAJOGOOAKNM[i];
                Quaternion rotation = this.OAKFIKADEBH[key].connectedTransform.rotation * this.OAKFIKADEBH[key].virtualCoordLocalRot2ConnectedTranform;
                Quaternion rhs = this.OAKFIKADEBH[key].myTransform.rotation * this.OAKFIKADEBH[key].myTransformLocalRot2VirtualObj;
                Quaternion quaternion = Quaternion.Inverse(Quaternion.Inverse(rotation) * rhs);
                this.FNMCFJPOCHN[i] = quaternion.eulerAngles;
            }
        }

        private void DHPDCKJICPK(Quaternion OKIILCKBODA, Quaternion MAHKCNPLMON, Quaternion PEPFPJIELGB)
        {
            this.NLEHLJPKLCH.angularXDrive = this.LAKFKLDLCGH;
            this.NLEHLJPKLCH.angularYZDrive = this.LAKFKLDLCGH;
            this.NLEHLJPKLCH.targetRotation = OKIILCKBODA;
            this.CDBGCHHHPFL.angularXDrive = this.BDHCJONLELO;
            this.CDBGCHHHPFL.angularYZDrive = this.BDHCJONLELO;
            this.CDBGCHHHPFL.targetRotation = MAHKCNPLMON;
            this.AJBEMNONLMC.angularXDrive = this.MMLBGFBJBLK;
            this.AJBEMNONLMC.angularYZDrive = this.MMLBGFBJBLK;
            this.AJBEMNONLMC.targetRotation = PEPFPJIELGB;
        }

        public bool IsGrabbed
        {
            get
            {
                return this.GDJNMJBCMMB;
            }
        }

        private void JCFOCNCJPIJ(ConfigurableJoint KPOIJIACCAC, ConfigurableJoint HJNNBOHCPEK, JointStateManager2 KGDEGOEOBJF, JointStateManager2 IGFFEOBPBAP)
        {
            KPOIJIACCAC.angularXDrive = KGDEGOEOBJF.JumpJointDrive;
            HJNNBOHCPEK.angularXDrive = IGFFEOBPBAP.JumpJointDrive;
            KPOIJIACCAC.angularYZDrive = KGDEGOEOBJF.JumpJointDrive;
            HJNNBOHCPEK.angularYZDrive = IGFFEOBPBAP.JumpJointDrive;
            KPOIJIACCAC.targetRotation = KGDEGOEOBJF.JumpRotation;
            HJNNBOHCPEK.targetRotation = IGFFEOBPBAP.JumpRotation;
        }



        public Vector3 CharacterVelocity
        {
            get
            {
                return this.LOHHEFLPHEG;
            }
        }

        private void KFFLEBCIDAO(float IPIDMOCBOFJ, float BNAFACEFKHK, bool GHMBNLHGMHG, bool DOLMJFFJFBH, bool BAFNIPAACNC, float HAIKFONFBPO, Vector3 PAMCJMFLEDD, float DPKCPMHPAAJ)
        {
            if (BAFNIPAACNC)
            {
                float num = (Mathf.Sin(IPIDMOCBOFJ + 0.5f) + 1f) * 0.5f;
                if (GHMBNLHGMHG)
                {
                    num = -num + 1f;
                }
                Quaternion piahakolhjm = Quaternion.Slerp(this.OPPCPPBDILA, this.GNLKHCGBJGM, num);
                Quaternion kgoeokpoion = Quaternion.Slerp(this.LMPOEBCFPKK, this.NEHJDIKMCLM, num);
                this.EGBBGIIGKPC(this.GDPPIFIJPMF, this.BBMLJFHODAL, this.LMCPDIKPBHG, this.ALHOJAPIOOM, piahakolhjm, kgoeokpoion, BNAFACEFKHK, DOLMJFFJFBH);
                return;
            }
            if (IPIDMOCBOFJ < 0.03f)
            {
                return;
            }
            if (DPKCPMHPAAJ < 0.2f)
            {
                float t = Mathf.SmoothStep(0f, 1f, HAIKFONFBPO / 80f);
                float num2 = Mathf.Lerp(25f, 85f, t);
                float num3 = num2;
                float num4 = Vector3.Angle(PAMCJMFLEDD, Vector3.up);
                float f;
                float num5;
                if (num4 > 90f)
                {
                    if (GHMBNLHGMHG)
                    {
                        f = -IPIDMOCBOFJ - this.AFICADMEOBP * 0.5f - 2.15f;
                    }
                    else
                    {
                        f = -IPIDMOCBOFJ + this.AFICADMEOBP * 0.5f - 2.15f;
                    }
                    float t2 = Mathf.SmoothStep(0f, 1f, (num4 - 90f) / 80f);
                    num2 = Mathf.Lerp(num2, 45f, t2);
                    num5 = Mathf.Lerp(0f, 80f, t2);
                }
                else
                {
                    if (GHMBNLHGMHG)
                    {
                        f = IPIDMOCBOFJ - this.AFICADMEOBP * 0.5f - 4.05f;
                    }
                    else
                    {
                        f = IPIDMOCBOFJ + this.AFICADMEOBP * 0.5f - 4.05f;
                    }
                    float t3 = Mathf.SmoothStep(0f, 1f, num4 / 80f);
                    num2 = Mathf.Lerp(60f, num2, t3);
                    num5 = Mathf.Lerp(-45f, 0f, t3);
                }
                this.EDMNPCAFABI.x = Mathf.Sin(f) * num2 + num5;
                this.EDMNPCAFABI.y = Mathf.Cos(f) * num3;
            }
            else
            {
                float f2;
                if (Vector3.Angle(PAMCJMFLEDD, Vector3.up) > 90f)
                {
                    if (GHMBNLHGMHG)
                    {
                        f2 = -IPIDMOCBOFJ - this.AFICADMEOBP * 0.5f - 2.15f;
                    }
                    else
                    {
                        f2 = -IPIDMOCBOFJ + this.AFICADMEOBP * 0.5f - 2.15f;
                    }
                }
                else if (GHMBNLHGMHG)
                {
                    f2 = IPIDMOCBOFJ - this.AFICADMEOBP * 0.5f - 4.05f;
                }
                else
                {
                    f2 = IPIDMOCBOFJ + this.AFICADMEOBP * 0.5f - 4.05f;
                }
                this.EDMNPCAFABI.x = Mathf.Sin(f2) * 85f;
                this.EDMNPCAFABI.y = Mathf.Cos(f2) * 85f;
            }
            this.LNFPIFJNFDI(this.GDPPIFIJPMF, this.BBMLJFHODAL, Quaternion.Euler(this.EDMNPCAFABI), this.NBOOCEDLMCC);
        }

        private IEnumerator GKPEHMEAIPK()
        {
            float num = 0.4f;
            while (num >= 0f && this.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.LDMNBPBABCH = false;
            yield break;
        }

        public bool IsHeadButting
        {
            get
            {
                return this.DENOIHACJHE.LBAILHKBMLF;
            }
        }




        private bool EAAAAFMPKKN
        {
            get
            {
                return this.LHOEFHMKFMG;
            }
            set
            {
                if (this.LHOEFHMKFMG != value)
                {
                    this.LHOEFHMKFMG = value;
                    if (value)
                    {
                        base.StartCoroutine(this.ENIBNEMNGLP());
                    }
                }
            }
        }

        private void KHCPFEKLBDE(Vector3 JHEPNGCDIFK, Vector3 APIDNIEKDNM, Vector3 PLBFAIMKEDH, bool LDMNBPBABCH, bool OIMHGDJIOLD, bool HDNBENIBAPH, bool GPENIBKPLFL, bool PJFPPEMKLPF, bool EKFLHKMNKCF, bool DAEHELJOFNM, Vector3 OPDGKOBENID, bool DEKABKJLMGI)
        {
            if (!this.EFOPJOCPODJ && !this.BONLNLPKFPD && !LDMNBPBABCH && !OIMHGDJIOLD && !HDNBENIBAPH && !GPENIBKPLFL && !EKFLHKMNKCF && !DAEHELJOFNM)
            {
                Vector3 vector = Vector3.ProjectOnPlane(JHEPNGCDIFK, Vector3.up);
                Vector3 vector2 = Vector3.ProjectOnPlane(APIDNIEKDNM, Vector3.up);
                Vector3 vector3 = Vector3.ProjectOnPlane(PLBFAIMKEDH, Vector3.up);
                float magnitude = vector.magnitude;
                float magnitude2 = vector2.magnitude;
                float magnitude3 = vector3.magnitude;
                if (magnitude < 800f && magnitude2 < 800f && magnitude3 < 800f)
                {
                    return;
                }
                Vector3 blkipkenfgb = Vector3.zero;
                if (magnitude > magnitude2 && magnitude > magnitude3)
                {
                    blkipkenfgb = vector;
                }
                else if (magnitude2 > magnitude && magnitude2 > magnitude3)
                {
                    blkipkenfgb = vector2;
                }
                else if (PJFPPEMKLPF)
                {
                    if (Vector3.Angle(OPDGKOBENID, vector3) < 90f)
                    {
                        blkipkenfgb = vector3;
                    }
                    else
                    {
                        blkipkenfgb = -vector3.normalized * 500f;
                    }
                }
                else
                {
                    blkipkenfgb = vector3;
                }
                base.StartCoroutine(this.NHNOKFCACAF(blkipkenfgb, DEKABKJLMGI));
            }
        }

        public bool Jump
        {
            get
            {
                return this.PLFNFLEEDNB;
            }
            set
            {
                if (this.PLFNFLEEDNB != value)
                {
                    if (value)
                    {
                        this.KPPMGBBENED = true;
                        base.StartCoroutine(this.BMINNODBDFK());
                    }
                    else
                    {
                        this.GLNAOGJDNMA = true;
                        base.StartCoroutine(this.BFNABNGEFMD());
                    }
                    this.PLFNFLEEDNB = value;
                }
            }
        }

        private IEnumerator JAAPFMFFGED()
        {
            float num = 0.6f;
            while (num > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.CCMKLOMOBOH = false;
            yield break;
        }

        public bool IsAirBorne
        {
            get
            {
                return !this.MJAFJDDBMHN;
            }
        }

        internal Rigidbody FIIKBADHOJH
        {
            get
            {
                if (this.FNLAAOKDOGM == null)
                {
                    this.FNLAAOKDOGM = this.GreenChest.GetComponent<Rigidbody>();
                }
                return this.FNLAAOKDOGM;
            }
        }

        private JointStateManager2 MOJONFOIABN
        {
            get
            {
                if (this.EHOJIFOMIKE == null)
                {
                    this.EHOJIFOMIKE = this.GreenChest.GetComponent<JointStateManager2>();
                }
                return this.EHOJIFOMIKE;
            }
        }

        private JointStateManager2 CJECNBIPOHG
        {
            get
            {
                if (this.DHGOLBICAMF == null)
                {
                    this.DHGOLBICAMF = this.GreenLegL2.GetComponent<JointStateManager2>();
                }
                return this.DHGOLBICAMF;
            }
        }

        public float MoveX { get; set; }

        internal float MPACCGNKHFM { get; set; }

        private void HMCNICLAPFH(bool PJFPPEMKLPF, RaycastHit OLKKKDDAJJM, out Vector3 OPDGKOBENID, out Vector3 MHGGDOKFODC)
        {
            MHGGDOKFODC = Vector3.zero;
            OPDGKOBENID = Vector3.zero;
            if (PJFPPEMKLPF)
            {
                Rigidbody rigidbody = OLKKKDDAJJM.rigidbody;
                if (rigidbody != null)
                {
                    MHGGDOKFODC = rigidbody.GetPointVelocity(OLKKKDDAJJM.point);
                    OPDGKOBENID = Vector3.ProjectOnPlane(this.PNGENFLDJAG.velocity - MHGGDOKFODC, Vector3.up);
                    return;
                }
                OPDGKOBENID = Vector3.ProjectOnPlane(this.PNGENFLDJAG.velocity, Vector3.up);
            }
        }

        private IEnumerator GKDCOAACELP()
        {
            this.GMLKAKDJHPC = PhysicCharacterController.MEPJPNCLOFD.Jumping;
            float num = 0.252f;
            float num2 = 0f;
            float num3 = UnityEngine.Random.Range(-1f, 1f);
            float num4;
            if (num3 < 0f)
            {
                num4 = Mathf.Pow(-num3, 0.3f) * 30f;
            }
            else
            {
                num4 = Mathf.Pow(num3, 0.3f) * 30f;
            }
            Quaternion a;
            Quaternion b;
            Quaternion a2;
            Quaternion b2;
            Quaternion a3;
            Quaternion b3;
            if (Vector3.Angle(Vector3.up, -this.OKBJDGHGCIK.up + -this.PDLEJPNAIIB.up) < 90f)
            {
                a = Quaternion.Euler(new Vector3(30f, num4, 0f));
                b = Quaternion.Euler(new Vector3(-50f, -num4, 0f));
                a2 = Quaternion.Euler(new Vector3(40f, num4, 0f));
                b2 = Quaternion.Euler(new Vector3(-40f, -num4, 0f));
                a3 = Quaternion.Euler(new Vector3(40f, num4, 0f));
                b3 = Quaternion.Euler(new Vector3(-60f, -num4, 0f));
            }
            else
            {
                b = Quaternion.Euler(new Vector3(30f, num4, 0f));
                a = Quaternion.Euler(new Vector3(-50f, -num4, 0f));
                b2 = Quaternion.Euler(new Vector3(40f, num4, 0f));
                a2 = Quaternion.Euler(new Vector3(-40f, -num4, 0f));
                b3 = Quaternion.Euler(new Vector3(40f, num4, 0f));
                a3 = Quaternion.Euler(new Vector3(-60f, -num4, 0f));
            }
            while (num >= 0f && this.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    float t = (Mathf.Sin(25f * num2) + 1f) * 0.5f;
                    Quaternion okiilckboda = Quaternion.Slerp(a2, b2, t);
                    Quaternion mahkcnplmon = Quaternion.Slerp(a3, b3, t);
                    Quaternion pepfpjielgb = Quaternion.Slerp(a, b, t);
                    this.DHPDCKJICPK(okiilckboda, mahkcnplmon, pepfpjielgb);
                    num2 += Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            if (this.GMLKAKDJHPC == PhysicCharacterController.MEPJPNCLOFD.Jumping)
            {
                this.GMLKAKDJHPC = PhysicCharacterController.MEPJPNCLOFD.Standing;
            }
            yield break;
        }

        private IEnumerator PHLIKOKJGIL()
        {
            yield return this.LGJIFPAHACH;
            this.KHEKDCLAPKO = false;
            yield break;
        }

        public void RemoveJumpCallback(PhysicCharacterController.IJumpCallback JIOAEMPKPOK)
        {
            if (this.BMJPOHNPEIC.Contains(JIOAEMPKPOK))
            {
                this.BMJPOHNPEIC.Remove(JIOAEMPKPOK);
            }
        }

        private JointStateManager2 IKEKGAMGHGJ
        {
            get
            {
                if (this.PPGIDOADPIG == null)
                {
                    this.PPGIDOADPIG = this.GreenLegL1.GetComponent<JointStateManager2>();
                }
                return this.PPGIDOADPIG;
            }
        }

        public void AddHitSomeoneCallBack(PhysicCharacterController.IHitSomeoneCallback KOMCGCIBLEP)
        {
            this.MLPBPDOFCJG.Add(KOMCGCIBLEP);
        }

        private IEnumerator JJMJBMEOHMC()
        {
            this.LAHKPENBLEN = true;
            this.IFDHPAHDEJO = 0.5f;
            while (this.IFDHPAHDEJO > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    this.IFDHPAHDEJO -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.LAHKPENBLEN = false;
            yield break;
        }



        private IEnumerator BOMMJGGOGFK()
        {
            this.AJGFBOPEMML = 0.3f;
            while (this.AJGFBOPEMML > 0f || this.ACIJFJIKKNL)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    this.AJGFBOPEMML -= Time.fixedDeltaTime;
                    yield return this.LGJIFPAHACH;
                }
            }
            this.AJGFBOPEMML = 0f;
            this.DIFAOOPOMDL = false;
            yield break;
        }

        private void AMEOIIBNMDG(float IPIDMOCBOFJ, float BNAFACEFKHK, bool GHMBNLHGMHG)
        {
            if (BNAFACEFKHK < 0.3f && !this.DOLMJFFJFBH)
            {
                return;
            }
            float num = Mathf.Sin(IPIDMOCBOFJ - 1.5708f + 0.5f);
            if (GHMBNLHGMHG)
            {
                num = -num;
            }
            if (!this.DOLMJFFJFBH)
            {
                this.FIIKBADHOJH.AddTorque(-num * 8500f * this.OKBJDGHGCIK.forward, ForceMode.Acceleration);
                this.PNGENFLDJAG.AddTorque(-num * -1100f * 1.65f * this.PDLEJPNAIIB.forward, ForceMode.Acceleration);
                return;
            }
            this.FIIKBADHOJH.AddTorque(-num * 1200f * 20f * this.OKBJDGHGCIK.forward, ForceMode.Acceleration);
            this.PNGENFLDJAG.AddTorque(-num * 100f * 1.65f * this.PDLEJPNAIIB.forward, ForceMode.Acceleration);
        }

        // TODO
        //public void LGLFMDEELAH(PhysicCharacterController.IOnLeftHandReleaseCallback KOMCGCIBLEP)
        //{
        //    this.IOJAKCMCGBC.Remove(KOMCGCIBLEP);
        //}

        internal bool NICPPDJPMAM
        {
            get
            {
                return this.EACLPKFKCGE.ThisHandIsGrabbingObj;
            }
        }



        private void DCKMAPMEJOJ()
        {
            if (this.grabbedWeaponGo == null)
            {
                this.CharacterDropWeapon();
                return;
            }
            if (!this.KMILBNNIHJG.IsAttacking)
            {
                this.characterStates.FIEKPFBMNIC(this.KMILBNNIHJG.PowerConsume);
                this.characterStates.HKHHJCILJGO(this.KMILBNNIHJG.NoPowerRecoverCD);
                this.KMILBNNIHJG.AGIKMKKNICC();
            }
        }



        internal float ALFFKLCLFJE { get; set; }

        internal float BGKCNODEJLE { get; set; }

        private IEnumerator DMPCODIDGGJ()
        {
            float num = 0.4f;
            while (num > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.CIMGMKJHJHH = false;
            yield break;
        }

        public void AddWeaponStatChangeCallback(PhysicCharacterController.IWeaponStateChangeCallbacks KPBOFOIEJLE)
        {
            this.IODFBCIAHDD.Add(KPBOFOIEJLE);
        }

        private void GEEPMHEEBEF(RaycastHit AMNHJKFJIOL, Rigidbody PNGENFLDJAG, Vector3 IAMNFCFJPIG)
        {
            if (AMNHJKFJIOL.distance <= 0.415f && AMNHJKFJIOL.distance != 0f)
            {
                float num = Mathf.Lerp(0f, 1f, Mathf.Clamp01((0.415f - AMNHJKFJIOL.distance) / 0.05f)) * 0.1f + IAMNFCFJPIG.y;
                float y = PNGENFLDJAG.velocity.y;
                Vector3 vector = Mathf.Clamp(num - y, 0f, 0.6f) * 33f * Vector3.up;
                PNGENFLDJAG.AddForce(vector, ForceMode.Impulse);
                if (AMNHJKFJIOL.rigidbody != null)
                {
                    AMNHJKFJIOL.rigidbody.AddForce(-vector, ForceMode.Impulse);
                }
            }
        }

        internal float ILGFHALPNJB { get; set; }



        private Weapon KMILBNNIHJG
        {
            get
            {
                return this.HIHEJAFGJEL;
            }
            set
            {
                if (this.HIHEJAFGJEL != value)
                {
                    if (value != null)
                    {
                        this.characterStates.WeaponWeight = value.NormalWeight;
                        this.grabbedWeaponType = value.weaponType;
                    }
                    else
                    {
                        this.characterStates.WeaponWeight = 0f;
                        this.grabbedWeaponType = WeaponType.Unknown;
                        CFOGGNCCHCO.EFNEGHJPJFN(this.KMILBNNIHJG.LGLOPGKONLO, -this.PDLEJPNAIIB.up * 2f, ForceMode.VelocityChange);
                        this.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
                        this.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
                        this.WeaponGrabbed = false;
                        this.GBKFKAIOCBN = true;
                        this.KMILBNNIHJG.GDENHBKDDGO();
                    }
                    this.HIHEJAFGJEL = value;
                }
            }
        }

        public bool IsReadyToThrow
        {
            get
            {
                return this.CLJAOHHONIB.isReadyToThrowSth;
            }
        }

        private IEnumerator BEPCLJNCDPA()
        {
            yield return this.LGJIFPAHACH;
            this.KOGAIPHBFPN = false;
            yield break;
        }

        public void SetCharacterPosition(Vector3 FJCCBCEAALN)
        {
            Vector3 b = FJCCBCEAALN - this.PDLEJPNAIIB.position + this.CAKDHBMGDFK;
            foreach (Rigidbody rigidbody in this.rigidbodies)
            {
                rigidbody.position += b;
                rigidbody.transform.position = rigidbody.position;
                CFOGGNCCHCO.IPIGMALBAKG(rigidbody, Vector3.zero);
                rigidbody.angularVelocity = Vector3.zero;
                rigidbody.ResetCenterOfMass();
                rigidbody.ResetInertiaTensor();
            }
        }

        public GameObject ObjectGrabbedByRightHand
        {
            get
            {
                return this.AEIDNHLPPEB.LKCGBILOJJI;
            }
        }



        private void HCGGGEOLADN(out bool BNPKFKHAPMG, out RaycastHit NELJECJPNGF)
        {
            NELJECJPNGF = default(RaycastHit);
            RaycastHit raycastHit;
            if (Physics.SphereCast(this.PNGENFLDJAG.position, 0.2f, Vector3.down, out raycastHit, 0.33f, this.layerCanWalkOn))
            {
                BNPKFKHAPMG = true;
                raycastHit.distance = Mathf.Abs(Vector3.Dot(raycastHit.point - this.PNGENFLDJAG.position, Vector3.down));
                NELJECJPNGF = raycastHit;
                return;
            }
            BNPKFKHAPMG = false;
        }

        private void Awake()
        {
            PccManager.gameObjectToCharacterControllerMap.Add(base.gameObject, this);
            PccManager.trackedTransforms.Add(this.GreenHead.transform);
            for (int i = 0; i < base.transform.childCount; i++)
            {
                GameObject gameObject = base.transform.GetChild(i).gameObject;
                if (gameObject.name.StartsWith("Green"))
                {
                    Rigidbody component = gameObject.GetComponent<Rigidbody>();
                    component.maxDepenetrationVelocity = 8f;
                    component.maxAngularVelocity = 9.5f;
                    this.IINJFJOIHMK.Add(gameObject);
                    this.rigidbodies.Add(component);
                    if (gameObject.GetComponent<JointStateManager2>() != null)
                    {
                        PhysicCharacterController.ConfigurableJointAndJointStateManager item = new PhysicCharacterController.ConfigurableJointAndJointStateManager
                        {
                            configurableJoint = gameObject.GetComponent<ConfigurableJoint>(),
                            JointStateManager = gameObject.GetComponent<JointStateManager2>()
                        };
                        this.DGLIFFPIBCD.Add(item);
                    }
                    CharacterDamage component2 = gameObject.GetComponent<CharacterDamage>();
                    if (component2 != null)
                    {
                        this.OBJGECLGOBH.Add(component2);
                        this.IFEGFIOLHFC.Add(gameObject, component2);
                    }
                }
            }
            foreach (GameObject key in this.IINJFJOIHMK)
            {
                PccManager.rigidbodyCharacterControllerMap.Add(key, this);
            }
            this.OCKHHOAKGCJ = EffectIdManager.JumpID;
            this.ACLFECOOBHB = new OFMNKKOBIKG(this);
            this.JLBGHMEINHD = this.GreenLegL2.AddComponent<WhatFootHitting>();
            this.PDBOMFMLIAJ = this.GreenLegR2.AddComponent<WhatFootHitting>();
            this.GreenLegL2.AddComponent<KickBoost>();
            this.GreenLegL2.GetComponent<KickBoost>().theHip = this.GreenHip;
            this.GreenLegR2.AddComponent<KickBoost>();
            this.GreenLegR2.GetComponent<KickBoost>().theHip = this.GreenHip;
            this.GreenHead.AddComponent<HeadPunchBoost>();
            this.JOHBNEIKLFL = base.gameObject.AddComponent<Kick>();
            this.JOHBNEIKLFL.Hip = this.GreenHip;
            this.JOHBNEIKLFL.LeftLeg2 = this.GreenLegL2;
            this.JOHBNEIKLFL.RightLeg2 = this.GreenLegR2;
            this.JOHBNEIKLFL.LeftLeg1 = this.GreenLegL1;
            this.JOHBNEIKLFL.RightLeg1 = this.GreenLegR1;
            this.JOHBNEIKLFL.Chest = this.GreenChest;
            this.EACLPKFKCGE = this.GreenFistL.AddComponent<GrabCollisionDetectL>();
            this.AEIDNHLPPEB = this.GreenFistR.AddComponent<GrabCollisionDetectR>();
            this.EACLPKFKCGE.Parent = base.gameObject;
            this.EACLPKFKCGE.TheOtherFistGO = this.GreenFistR;
            this.AEIDNHLPPEB.Parent = base.gameObject;
            this.AEIDNHLPPEB.TheOtherFistGO = this.GreenFistL;
            this.GreenFistL.AddComponent<PunchBoost>();
            this.GreenFistR.AddComponent<PunchBoost>();
            this.APAOALLFAMH = base.gameObject.AddComponent<PowerPunch>();
            this.APAOALLFAMH.ACLFECOOBHB = this.ACLFECOOBHB;
            this.APAOALLFAMH.SetRigAndJoint(this.GreenHead, this.GreenChest, this.GreenWaist, this.GreenUpperArmL, this.GreenUpperArmR, this.GreenForeArmL, this.GreenForeArmR, this.GreenHip, this.GreenFistL, this.GreenFistR, base.gameObject);
            this.CIHJEJLGEAD = base.gameObject.AddComponent<BeHuman>();
            this.PBBDEBBIHDA = new JOCBIJDFNNC(this)
            {
                FEPNDJPCAJB = this.layerCanWalkOn
            };
            this.CAKDHBMGDFK = this.PDLEJPNAIIB.localPosition;
            this.PEPMKBNFPEC = this.GreenChest.AddComponent<GrabDetector>();
            this.PEPMKBNFPEC.KPLKMDDKCML = this;
            this.PEPMKBNFPEC.EIJAPLDDFEM = this.PDLEJPNAIIB;
            this.PEPMKBNFPEC.GHKDFNOINDC = this.KMMNIGMMEAG;
            this.PEPMKBNFPEC.ADICJILOOEJ = this.IINJFJOIHMK;
            this.PEPMKBNFPEC.ELDPMCGDHKJ = this.OKBJDGHGCIK;
            this.JKEKKHKGEFO = new PhysicCharacterController.AccelerationCalculator(this.FIIKBADHOJH);
            this.FAJMFJHDLFK = new PhysicCharacterController.AccelerationCalculator(this.IHEELAEEPHA);
            this.CFKIOPKGFEJ = new PhysicCharacterController.AccelerationCalculator(this.PNGENFLDJAG);
            this.AIPMEMPGKKP = new PhysicCharacterController.AccelerationCalculator(this.LNDDLJMNLBD);
            this.OJPPKAKAKNL = new PhysicCharacterController.AccelerationCalculator(this.PIMHHNKOCBE);
            this.MHCJMOEMBOC = this.JKHJPCKPAGC();
            this.CLJAOHHONIB = new PhysicCharacterController.EIALLPOGAFB(this.AKFKHFBDPBI, this.GDPPIFIJPMF, this.GIGHLANHALH, this.BBMLJFHODAL, this.AJBEMNONLMC, this);
            this.PHPIHFKHCIA = this.GreenLegL2.AddComponent<FootCollision>();
            this.MIGGIEAPHHC = this.GreenLegR2.AddComponent<FootCollision>();
            foreach (GameObject gameObject2 in this.IINJFJOIHMK)
            {
                CharacterElectricStates characterElectricStates = gameObject2.AddComponent<CharacterElectricStates>();
                characterElectricStates.physicCharacterController = this;
                this.IPLKGBDHFPP.Add(characterElectricStates);
            }
            this.characterStates.JILIJFCKEKM = this.IPLKGBDHFPP[0];
            this.DBNFHBMHGGA();
            this.MIBMJMCGFLN();
        }

        private IEnumerator BFNABNGEFMD()
        {
            yield return this.LGJIFPAHACH;
            this.GLNAOGJDNMA = false;
            yield break;
        }



        private IEnumerator PBEOHMCMPMC()
        {
            yield return this.LGJIFPAHACH;
            this.CHBCNLCPMKD = false;
            yield break;
        }

        internal bool GLFNLPJFGEM
        {
            get
            {
                return this.CLJAOHHONIB.isThrowingSth;
            }
        }

        internal float KAAHJGOJOMI { get; set; }

        internal void OBLGBHHMHPC()
        {
            this.GDJNMJBCMMB = true;
            this.IKGLJMCPAJA = 0.08f;
        }

        public void RemoveCharacterBasicStateChangedCallback(PhysicCharacterController.ICharacterBasicStateChangedCallback KOMCGCIBLEP)
        {
            this.BFJKIGGHGBM.Remove(KOMCGCIBLEP);
        }

        internal float ILJCKDPPIHP { get; set; }

        internal void GAOJKIAHDOP(PhysicCharacterController MCFOLNMFCPN)
        {
            foreach (PhysicCharacterController.ILeftHandGrabSomeoneCallback leftHandGrabSomeoneCallback in this.ILEGJAAEACJ)
            {
                leftHandGrabSomeoneCallback.OnLeftHandGrabSomeone(MCFOLNMFCPN);
            }
        }

        internal ConfigurableJoint CDBGCHHHPFL
        {
            get
            {
                if (this.COMMNEFOBBK == null)
                {
                    this.COMMNEFOBBK = this.GreenWaist.GetComponent<ConfigurableJoint>();
                }
                return this.COMMNEFOBBK;
            }
        }

        private void EEJMGHPHPDN(out float AMGHJCIMMFD)
        {
            AMGHJCIMMFD = 0f;
            foreach (Rigidbody rigidbody in this.rigidbodies)
            {
                AMGHJCIMMFD += rigidbody.mass * Vector3.Dot(rigidbody.velocity, Vector3.up);
            }
        }



        public bool IsIdle
        {
            get
            {
                return this.PAKNGDIDFGK > 2f && this.CBasicState == PhysicCharacterController.CharacterBasicState.Normal;
            }
        }


        private IEnumerator JFNOBCFCPDI()
        {
            yield return this.LGJIFPAHACH;
            this.BGFBPIHFGEH = false;
            yield break;
        }

        private void JBHFOJGMOPA()
        {
            this.characterStates.FIEKPFBMNIC(0.05f);
            this.characterStates.HKHHJCILJGO(1.6f);
            if (this.EACLPKFKCGE.ThisHandIsGrabbingObj && this.AEIDNHLPPEB.ThisHandIsGrabbingObj)
            {
                base.StartCoroutine(this.DENOIHACJHE.GrabbingHeadPunchProcess());
                return;
            }
            if (this.MJAFJDDBMHN && !this.LDMNBPBABCH)
            {
                base.StartCoroutine(this.DENOIHACJHE.NormalHeadPunchProcess());
                return;
            }
            base.StartCoroutine(this.DENOIHACJHE.FlyingHeadPunchProcess());
        }

        public bool IsPowerPunching
        {
            get
            {
                return this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.PowerPunching;
            }
        }


        internal void OKKJDMDHOFO(PhysicCharacterController MCFOLNMFCPN)
        {
            foreach (PhysicCharacterController.IBothHandsReleaseCharacterCallback bothHandsReleaseCharacterCallback in this.CLOKNACLBHP)
            {
                bothHandsReleaseCharacterCallback.OnBothHandsReleaseCharacter(MCFOLNMFCPN);
            }
        }

        public void CharacterFootHasFriction()
        {
            this.DLNNLIAMBEP = 0f;
            this.ACLFECOOBHB.AOKMBPLCGHI(4f, 4f, PhysicMaterialCombine.Average);
            this.ACLFECOOBHB.MDADOFMGFAP(4f, 4f, PhysicMaterialCombine.Average);
        }



        void Weapon.JLCPDFFPDCF.OnAttackingSomeone(PhysicCharacterController MCFOLNMFCPN)
        {
            this.JDEMFDFOOBM(MCFOLNMFCPN);
        }



        public void AddCharacterBasicStateChangedCallback(PhysicCharacterController.ICharacterBasicStateChangedCallback KOMCGCIBLEP)
        {
            this.BFJKIGGHGBM.Add(KOMCGCIBLEP);
        }

        private Transform PDLEJPNAIIB
        {
            get
            {
                if (this.DCCNLCABAGP == null)
                {
                    this.DCCNLCABAGP = this.GreenHip.transform;
                }
                return this.DCCNLCABAGP;
            }
        }


        public bool Punch
        {
            get
            {
                return this.LKHJNCCIEMI;
            }
            set
            {
                if (this.LKHJNCCIEMI != value)
                {
                    if (value)
                    {
                        this.KHEKDCLAPKO = true;
                        base.StartCoroutine(this.PHLIKOKJGIL());
                    }
                    else
                    {
                        this.MCMLHECLGIA = true;
                        base.StartCoroutine(this.PGJCAIIFJFL());
                    }
                    this.LKHJNCCIEMI = value;
                }
            }
        }

        public void RemoveBothHandsReleaseCharacterCallback(PhysicCharacterController.IBothHandsReleaseCharacterCallback KOMCGCIBLEP)
        {
            this.CLOKNACLBHP.Remove(KOMCGCIBLEP);
        }

        private void GBGABKDCFAH()
        {
            this.AJBEMNONLMC.angularXDrive = this.MOLMFCJEFAB;
            this.AJBEMNONLMC.angularYZDrive = this.MOLMFCJEFAB;
            this.NLEHLJPKLCH.angularXDrive = this.BGGDADPHDGG;
            this.NLEHLJPKLCH.angularYZDrive = this.BGGDADPHDGG;
            this.CDBGCHHHPFL.angularXDrive = this.KJFLMGDEDEJ;
            this.CDBGCHHHPFL.angularYZDrive = this.KJFLMGDEDEJ;
            this.AKFKHFBDPBI.angularXDrive = this.KCGNIOMNMEL;
            this.AKFKHFBDPBI.angularYZDrive = this.KCGNIOMNMEL;
            this.GIGHLANHALH.angularXDrive = this.KCGNIOMNMEL;
            this.GIGHLANHALH.angularYZDrive = this.KCGNIOMNMEL;
            this.GDPPIFIJPMF.angularXDrive = this.KCGNIOMNMEL;
            this.GDPPIFIJPMF.angularYZDrive = this.KCGNIOMNMEL;
            this.BBMLJFHODAL.angularXDrive = this.KCGNIOMNMEL;
            this.BBMLJFHODAL.angularYZDrive = this.KCGNIOMNMEL;
            this.IMIIFNONDDM.angularXDrive = this.DAHADNIGFDE;
            this.IMIIFNONDDM.angularYZDrive = this.DAHADNIGFDE;
            this.BGMAHMGFAOO.angularXDrive = this.DAHADNIGFDE;
            this.BGMAHMGFAOO.angularYZDrive = this.DAHADNIGFDE;
            this.NELDBBMLJLH.angularXDrive = this.DAHADNIGFDE;
            this.NELDBBMLJLH.angularYZDrive = this.DAHADNIGFDE;
            this.EMDJIGOAPAI.angularXDrive = this.DAHADNIGFDE;
            this.EMDJIGOAPAI.angularYZDrive = this.DAHADNIGFDE;
            for (int i = 0; i < this.rigidbodies.Count; i++)
            {
                this.rigidbodies[i].maxAngularVelocity = 90f;
            }
            this.APDAHKJEAEI();
            this.PNGENFLDJAG.angularDrag = 0.05f;
        }

        public void RemoveHitSomeoneCallBack(PhysicCharacterController.IHitSomeoneCallback KOMCGCIBLEP)
        {
            this.MLPBPDOFCJG.Remove(KOMCGCIBLEP);
        }

        internal float FBNFDJGNAMF { get; set; }

        private bool GFAHFDEOPCJ
        {
            get
            {
                return this.OGMGDHLILIH;
            }
            set
            {
                if (this.OGMGDHLILIH != value)
                {
                    this.OGMGDHLILIH = value;
                    if (value)
                    {
                        base.StartCoroutine(this.DBGKFDDDGBE());
                    }
                }
            }
        }



        private void GEDPNCMIEAM()
        {
            this.IMIIFNONDDM.angularXDrive = this.IKEKGAMGHGJ.JumpJointDrive;
            this.BGMAHMGFAOO.angularXDrive = this.CJECNBIPOHG.JumpJointDrive;
            this.NELDBBMLJLH.angularXDrive = this.PLPLLMMJFAD.JumpJointDrive;
            this.EMDJIGOAPAI.angularXDrive = this.DFBGOJLGHKL.JumpJointDrive;
            this.IMIIFNONDDM.angularYZDrive = this.IKEKGAMGHGJ.JumpJointDrive;
            this.BGMAHMGFAOO.angularYZDrive = this.CJECNBIPOHG.JumpJointDrive;
            this.NELDBBMLJLH.angularYZDrive = this.PLPLLMMJFAD.JumpJointDrive;
            this.EMDJIGOAPAI.angularYZDrive = this.DFBGOJLGHKL.JumpJointDrive;
            this.IMIIFNONDDM.targetRotation = this.IKEKGAMGHGJ.JumpRotation;
            this.BGMAHMGFAOO.targetRotation = this.CJECNBIPOHG.JumpRotation;
            this.NELDBBMLJLH.targetRotation = this.PLPLLMMJFAD.JumpRotation;
            this.EMDJIGOAPAI.targetRotation = this.DFBGOJLGHKL.JumpRotation;
        }

        private PhysicCharacterController.NCIFEHEBIAE NCKFENCNIJP
        {
            get
            {
                if (this.IHBPLAMNFNK == null)
                {
                    this.IHBPLAMNFNK = new PhysicCharacterController.NCIFEHEBIAE();
                }
                return this.IHBPLAMNFNK;
            }
        }

        private void NCJCCDPCKAD()
        {
            this.LDMNBPBABCH = true;
            this.OKKJNOCLIEE = 0f;
            base.StartCoroutine(this.FCJJLGFCPBA());
            Vector3 forward = this.PDLEJPNAIIB.forward;
            if (this.GAAABCJJPLA)
            {
                float num = Mathf.Sqrt(33f / (33f + this.characterStates.WeaponWeight));
                CFOGGNCCHCO.EFNEGHJPJFN(this.PNGENFLDJAG, forward * (this.KECDGNLMHLK * num), ForceMode.Impulse);
                CFOGGNCCHCO.EFNEGHJPJFN(this.FIIKBADHOJH, -forward * (this.KECDGNLMHLK * 0.15f * num), ForceMode.Impulse);
            }
            else
            {
                float num2 = Mathf.Sqrt(33f / (33f + this.characterStates.WeaponWeight));
                float num3;
                this.EEJMGHPHPDN(out num3);
                if (num3 < 0f)
                {
                    CFOGGNCCHCO.EFNEGHJPJFN(this.PNGENFLDJAG, -forward * Mathf.Max(num3, -50f), ForceMode.Impulse);
                }
                else
                {
                    CFOGGNCCHCO.EFNEGHJPJFN(this.PNGENFLDJAG, -forward * Mathf.Min(num3, 8f), ForceMode.Impulse);
                }
                CFOGGNCCHCO.EFNEGHJPJFN(this.PNGENFLDJAG, forward * (this.KECDGNLMHLK * num2), ForceMode.Impulse);
                CFOGGNCCHCO.EFNEGHJPJFN(this.FIIKBADHOJH, -forward * (this.KECDGNLMHLK * 0.15f * num2), ForceMode.Impulse);
            }
            this.LOEFMFEFKFF(-forward);
            foreach (PhysicCharacterController.IJumpCallback jumpCallback in this.BMJPOHNPEIC)
            {
                jumpCallback.OnJump(this);
            }
        }




        public void RemoveWeaponStatChangeCallback(PhysicCharacterController.IWeaponStateChangeCallbacks KPBOFOIEJLE)
        {
            this.IODFBCIAHDD.Remove(KPBOFOIEJLE);
        }

        private JointStateManager2 EJNBLKGNLLD
        {
            get
            {
                if (this.OAINLMNMIPB == null)
                {
                    this.OAINLMNMIPB = this.GreenHead.GetComponent<JointStateManager2>();
                }
                return this.OAINLMNMIPB;
            }
        }

        private void KIAEHKLDFLI()
        {
            if (this.LDMNBPBABCH || this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon || this.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon)
            {
                return;
            }
            if (this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.Nothing && this.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.Grabbing)
            {
                base.StartCoroutine(this.KKAHGMHMOCH.RunPunch(PhysicCharacterController.CNOEKKHHKDN.LeftPunch));
                return;
            }
            if (this.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.Nothing && this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.Grabbing)
            {
                base.StartCoroutine(this.NPOGMNGGCMC.RunPunch(PhysicCharacterController.CNOEKKHHKDN.RightPunch));
                return;
            }
            PhysicCharacterController.CNOEKKHHKDN imepjagpjcf = this.IMEPJAGPJCF;
            if (imepjagpjcf != PhysicCharacterController.CNOEKKHHKDN.LeftPunch)
            {
                if (imepjagpjcf != PhysicCharacterController.CNOEKKHHKDN.RightPunch)
                {
                    return;
                }
                if (this.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.Nothing)
                {
                    base.StartCoroutine(this.NPOGMNGGCMC.RunPunch(this.IMEPJAGPJCF));
                    this.IMEPJAGPJCF = PhysicCharacterController.CNOEKKHHKDN.LeftPunch;
                }
            }
            else if (this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.Nothing)
            {
                base.StartCoroutine(this.KKAHGMHMOCH.RunPunch(this.IMEPJAGPJCF));
                this.IMEPJAGPJCF = PhysicCharacterController.CNOEKKHHKDN.RightPunch;
                return;
            }
        }

        public void RemoveRightHandReleaseCallback(PhysicCharacterController.IOnRightHandReleaseCallback KOMCGCIBLEP)
        {
            this.PHIKEEMKPOK.Remove(KOMCGCIBLEP);
        }

        private void JLKGOJOFFBK()
        {
            foreach (Rigidbody rigidbody in this.rigidbodies)
            {
                rigidbody.WakeUp();
            }
        }

        public void RemoveAllProjectileOnThisCharacter()
        {
            List<Arrow> list = this.PFBHDFNHIDA.ToList<Arrow>();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].DestroyJoint();
            }
            List<Pin> list2 = this.FIFLMFGANEM.ToList<Pin>();
            for (int j = 0; j < list2.Count; j++)
            {
                list2[j].DestroyJoint();
            }
            List<Weapon> list3 = this.MCLLMKNDGMA.ToList<Weapon>();
            for (int k = 0; k < list3.Count; k++)
            {
                list3[k].MPKJPGBHBNK();
            }
        }

        internal ConfigurableJoint AKFKHFBDPBI
        {
            get
            {
                if (this.GDHLIECNHCO == null)
                {
                    this.GDHLIECNHCO = this.GreenUpperArmL.GetComponent<ConfigurableJoint>();
                }
                return this.GDHLIECNHCO;
            }
        }

        public void AddAttackStateChangeCallback(PhysicCharacterController.IAttackStateChangeCallback JIOAEMPKPOK)
        {
            this.ACNBMIMLKKD.Add(JIOAEMPKPOK);
        }

        internal float NBJBDBJDKFG { get; set; }

        private IEnumerator BMINNODBDFK()
        {
            yield return this.LGJIFPAHACH;
            this.KPPMGBBENED = false;
            yield break;
        }

        public void AddLeftHandReleaseCallback(PhysicCharacterController.IOnLeftHandReleaseCallback KOMCGCIBLEP)
        {
            this.IOJAKCMCGBC.Add(KOMCGCIBLEP);
        }


        private bool GFBJCPDAAKJ
        {
            get
            {
                return this.AHPFHMOPIIG;
            }
            set
            {
                if (this.AHPFHMOPIIG != value)
                {
                    this.AHPFHMOPIIG = value;
                    if (!value)
                    {
                        this.MHCJMOEMBOC = this.JKHJPCKPAGC();
                    }
                }
            }
        }





        private LGrabObj DJNHNJJKHDL
        {
            get
            {
                if (this.LHAGKEBFCJB == null)
                {
                    this.LHAGKEBFCJB = base.GetComponent<LGrabObj>();
                }
                return this.LHAGKEBFCJB;
            }
        }

        internal PhysicCharacterController.AKDGAGJFAOJ BMFBMAMHGKG
        {
            get
            {
                return this.COEEMGNLJNG;
            }
            set
            {
                if (this.COEEMGNLJNG != value)
                {
                    this.COEEMGNLJNG = value;
                    if (value == PhysicCharacterController.AKDGAGJFAOJ.Punching)
                    {
                        if (this.IFDHPAHDEJO > 0f)
                        {
                            this.IFDHPAHDEJO = 0.5f;
                            return;
                        }
                        base.StartCoroutine(this.JJMJBMEOHMC());
                    }
                }
            }
        }

        internal bool HBBHGFFPFPC
        {
            get
            {
                return this.NJDCACDNBEG;
            }
            set
            {
                if (this.NJDCACDNBEG != value)
                {
                    this.NJDCACDNBEG = value;
                    this.EDJLBHKJCHH = 0f;
                }
            }
        }


        public bool Headbutt { get; set; }


        public bool IsCharacterBalanced
        {
            get
            {
                return this.PNGENFLDJAG.constraints > RigidbodyConstraints.None;
            }
        }

        private void IJOKHEILPGJ()
        {
            if (this.IGALMHPOGDH < 2f)
            {
                this.IMIIFNONDDM.angularXDrive = this.IKEKGAMGHGJ.NormalJointDrive;
                this.IMIIFNONDDM.angularYZDrive = this.IKEKGAMGHGJ.NormalJointDrive;
                this.BGMAHMGFAOO.angularXDrive = this.CJECNBIPOHG.NormalJointDrive;
                this.BGMAHMGFAOO.angularYZDrive = this.CJECNBIPOHG.NormalJointDrive;
                this.NELDBBMLJLH.angularXDrive = this.PLPLLMMJFAD.NormalJointDrive;
                this.NELDBBMLJLH.angularYZDrive = this.PLPLLMMJFAD.NormalJointDrive;
                this.EMDJIGOAPAI.angularXDrive = this.DFBGOJLGHKL.NormalJointDrive;
                this.EMDJIGOAPAI.angularYZDrive = this.DFBGOJLGHKL.NormalJointDrive;
                this.HNMHPFNKMCH = 0f;
                this.GANGDOANODH = 0f;
            }
            else
            {
                bool flag = false;
                if (this.PHPIHFKHCIA.ANLOJKFEJIF.Count > 0)
                {
                    foreach (GameObject item in this.PHPIHFKHCIA.ANLOJKFEJIF)
                    {
                        if (!this.IINJFJOIHMK.Contains(item))
                        {
                            flag = true;
                        }
                    }
                }
                bool flag2 = false;
                if (this.MIGGIEAPHHC.ANLOJKFEJIF.Count > 0)
                {
                    foreach (GameObject item2 in this.MIGGIEAPHHC.ANLOJKFEJIF)
                    {
                        if (!this.IINJFJOIHMK.Contains(item2))
                        {
                            flag2 = true;
                        }
                    }
                }
                if (!flag && !flag2)
                {
                    this.IMIIFNONDDM.angularXDrive = this.CBNJEHGMMKB;
                    this.IMIIFNONDDM.angularYZDrive = this.CBNJEHGMMKB;
                    this.BGMAHMGFAOO.angularXDrive = this.CBNJEHGMMKB;
                    this.BGMAHMGFAOO.angularYZDrive = this.CBNJEHGMMKB;
                    this.NELDBBMLJLH.angularXDrive = this.CBNJEHGMMKB;
                    this.NELDBBMLJLH.angularYZDrive = this.CBNJEHGMMKB;
                    this.EMDJIGOAPAI.angularXDrive = this.CBNJEHGMMKB;
                    this.EMDJIGOAPAI.angularYZDrive = this.CBNJEHGMMKB;
                    this.HNMHPFNKMCH = 0f;
                    this.GANGDOANODH = 0f;
                }
                else
                {
                    if (!flag)
                    {
                        this.HNMHPFNKMCH = Mathf.Clamp01(this.HNMHPFNKMCH - Time.fixedDeltaTime);
                        this.GANGDOANODH = Mathf.Clamp01(this.GANGDOANODH + Time.fixedDeltaTime);
                    }
                    else if (!flag2)
                    {
                        this.HNMHPFNKMCH = Mathf.Clamp01(this.HNMHPFNKMCH + Time.fixedDeltaTime);
                        this.GANGDOANODH = Mathf.Clamp01(this.GANGDOANODH - Time.fixedDeltaTime);
                    }
                    else if (Mathf.Abs(this.HNMHPFNKMCH - this.GANGDOANODH) < 0.2f)
                    {
                        this.HNMHPFNKMCH = Mathf.Clamp01(this.HNMHPFNKMCH - Time.fixedDeltaTime);
                        this.GANGDOANODH = Mathf.Clamp01(this.GANGDOANODH - Time.fixedDeltaTime);
                    }
                    this.HJDAKIBFMEF.positionSpring = Mathf.Lerp(this.IKEKGAMGHGJ.NormalJointDrive.positionSpring, 0f, this.HNMHPFNKMCH);
                    this.IIEGJJOBMII.positionSpring = Mathf.Lerp(this.CJECNBIPOHG.NormalJointDrive.positionSpring, 0f, this.HNMHPFNKMCH);
                    this.IOADMBKOGKJ.positionSpring = Mathf.Lerp(this.PLPLLMMJFAD.NormalJointDrive.positionSpring, 0f, this.GANGDOANODH);
                    this.JMKHOADKIFA.positionSpring = Mathf.Lerp(this.DFBGOJLGHKL.NormalJointDrive.positionSpring, 0f, this.GANGDOANODH);
                    this.IMIIFNONDDM.angularXDrive = this.HJDAKIBFMEF;
                    this.IMIIFNONDDM.angularYZDrive = this.HJDAKIBFMEF;
                    this.BGMAHMGFAOO.angularXDrive = this.IIEGJJOBMII;
                    this.BGMAHMGFAOO.angularYZDrive = this.IIEGJJOBMII;
                    this.NELDBBMLJLH.angularXDrive = this.IOADMBKOGKJ;
                    this.NELDBBMLJLH.angularYZDrive = this.IOADMBKOGKJ;
                    this.EMDJIGOAPAI.angularXDrive = this.JMKHOADKIFA;
                    this.EMDJIGOAPAI.angularYZDrive = this.JMKHOADKIFA;
                }
            }
            this.IMIIFNONDDM.targetRotation = this.MNKIJJECKDI;
            this.NELDBBMLJLH.targetRotation = this.MNKIJJECKDI;
            this.EMDJIGOAPAI.targetRotation = this.ABAGFMMDFIO;
            this.BGMAHMGFAOO.targetRotation = this.ABAGFMMDFIO;
        }

        private void MMPGLJIJBPM(bool EBHGJLDKFAM, bool CEEOMKKOEFB)
        {
            if (!EBHGJLDKFAM && !CEEOMKKOEFB)
            {
                this.HBBHGFFPFPC = false;
                return;
            }
            if (this.CCMKLOMOBOH)
            {
                return;
            }
            if (((EBHGJLDKFAM && this.GreenFistL.transform.position.y - this.PDLEJPNAIIB.position.y < 0.2f) || (CEEOMKKOEFB && this.GreenFistR.transform.position.y - this.PDLEJPNAIIB.position.y < 0.2f)) && !this.MKBCAPJLPGK && !this.LDMNBPBABCH && this.EDJLBHKJCHH > 0.5f && this.PNGENFLDJAG.constraints != RigidbodyConstraints.None)
            {
                this.DJNHNJJKHDL.Ungrab(this, true);
                this.NKDPNMHDKLO.Ungrab(this, false);
                this.GFAHFDEOPCJ = true;
                this.HBBHGFFPFPC = false;
                this.CCMKLOMOBOH = true;
                this.DBBEBMMNNEB();
                this.ODFOMAGLCFG(EBHGJLDKFAM, CEEOMKKOEFB);
                return;
            }
            if (this.EDJLBHKJCHH > 1f)
            {
                this.DJNHNJJKHDL.Ungrab(this, true);
                this.NKDPNMHDKLO.Ungrab(this, false);
                this.HBBHGFFPFPC = false;
                return;
            }
            this.HBBHGFFPFPC = true;
            this.EDJLBHKJCHH += Time.fixedDeltaTime;
            float num = Mathf.Clamp01(this.EDJLBHKJCHH * 0.7f);
            this.ELHAIPPBOAH.positionSpring = 3000f * num;
            this.NDNHNADJLEK.positionSpring = 5000f * num;
            this.NLEHLJPKLCH.angularXDrive = this.ELHAIPPBOAH;
            this.NLEHLJPKLCH.angularYZDrive = this.ELHAIPPBOAH;
            this.NLEHLJPKLCH.targetRotation = this.KPNJEECKIFM;
            this.CDBGCHHHPFL.angularXDrive = this.ELHAIPPBOAH;
            this.CDBGCHHHPFL.targetRotation = this.CHBNEPHDEGJ;
            if (EBHGJLDKFAM)
            {
                this.AKFKHFBDPBI.angularXDrive = this.NDNHNADJLEK;
                this.AKFKHFBDPBI.angularYZDrive = this.NDNHNADJLEK;
                this.AKFKHFBDPBI.targetRotation = this.JMHOGMFBHJP;
                this.GIGHLANHALH.angularXDrive = this.NDNHNADJLEK;
                this.GIGHLANHALH.angularYZDrive = this.NDNHNADJLEK;
                this.GIGHLANHALH.targetRotation = this.KOOMLBOIBJH;
            }
            if (CEEOMKKOEFB)
            {
                this.GDPPIFIJPMF.angularXDrive = this.NDNHNADJLEK;
                this.GDPPIFIJPMF.angularYZDrive = this.NDNHNADJLEK;
                this.GDPPIFIJPMF.targetRotation = this.OHFFDMLPLEM;
                this.BBMLJFHODAL.angularXDrive = this.NDNHNADJLEK;
                this.BBMLJFHODAL.angularYZDrive = this.NDNHNADJLEK;
                this.BBMLJFHODAL.targetRotation = this.KOOMLBOIBJH;
            }
        }

        private void EGBBGIIGKPC(ConfigurableJoint KPOIJIACCAC, ConfigurableJoint HJNNBOHCPEK, JointStateManager2 KGDEGOEOBJF, JointStateManager2 IGFFEOBPBAP, Quaternion PIAHAKOLHJM, Quaternion KGOEOKPOION, float BNAFACEFKHK, bool DOLMJFFJFBH)
        {
            if (!DOLMJFFJFBH)
            {
                if (BNAFACEFKHK < 0.3f)
                {
                    return;
                }
                KPOIJIACCAC.angularXDrive = KGDEGOEOBJF.WalkJointDrive;
                HJNNBOHCPEK.angularXDrive = IGFFEOBPBAP.WalkJointDrive;
                KPOIJIACCAC.angularYZDrive = KGDEGOEOBJF.WalkJointDrive;
                HJNNBOHCPEK.angularYZDrive = IGFFEOBPBAP.WalkJointDrive;
                KPOIJIACCAC.targetRotation = PIAHAKOLHJM;
                HJNNBOHCPEK.targetRotation = KGOEOKPOION;
                return;
            }
            else
            {
                if (BNAFACEFKHK < 0.15f)
                {
                    return;
                }
                KPOIJIACCAC.angularXDrive = KGDEGOEOBJF.RunJointDrive;
                HJNNBOHCPEK.angularXDrive = IGFFEOBPBAP.RunJointDrive;
                KPOIJIACCAC.angularYZDrive = KGDEGOEOBJF.RunJointDrive;
                HJNNBOHCPEK.angularYZDrive = IGFFEOBPBAP.RunJointDrive;
                KPOIJIACCAC.targetRotation = PIAHAKOLHJM;
                HJNNBOHCPEK.targetRotation = KGOEOKPOION;
                return;
            }
        }

        public void AddBothHandsReleaseCharacterCallback(PhysicCharacterController.IBothHandsReleaseCharacterCallback KOMCGCIBLEP)
        {
            this.CLOKNACLBHP.Add(KOMCGCIBLEP);
        }

        internal float CGHHBLBAAOJ { get; set; }

        private IEnumerator ENIBNEMNGLP()
        {
            float num = 0.4f;
            while (num >= 0f && this.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.EAAAAFMPKKN = false;
            yield break;
        }

        internal void LANKEBGAODO(float LHJCHOCJAKD, bool OHGDFNDFJBA, PhysicCharacterController.AttackType IPIBJLOCJIF, GameObject CMBGAIKCLNA)
        {
            foreach (PhysicCharacterController.IBareHandHitCallback bareHandHitCallback in this.FJJEIJOMPGG)
            {
                bareHandHitCallback.BareHandAttack(LHJCHOCJAKD, OHGDFNDFJBA, IPIBJLOCJIF, CMBGAIKCLNA);
            }
        }

        void Weapon.IIDPMLDBKFM.OnKillSomeone(PhysicCharacterController MCFOLNMFCPN)
        {
            this.NDDCNKFDAOB(MCFOLNMFCPN);
        }


        internal ConfigurableJoint AJBEMNONLMC
        {
            get
            {
                if (this.OLPJPLDCHJH == null)
                {
                    this.OLPJPLDCHJH = this.GreenHead.GetComponent<ConfigurableJoint>();
                }
                return this.OLPJPLDCHJH;
            }
        }

        internal float ADLMIBPOPDP { get; set; }

        public void RemoveLeftHandGrabSomeoneCallback(PhysicCharacterController.ILeftHandGrabSomeoneCallback KOMCGCIBLEP)
        {
            this.ILEGJAAEACJ.Remove(KOMCGCIBLEP);
        }


        private void FMAHCHOJMDG(CharacterStates KPOGLNBAHDF, float DAGOJDEEFDM, float HHMDFJOICJH, float JHEPNGCDIFK, float APIDNIEKDNM, float PLBFAIMKEDH, bool LDMNBPBABCH, bool OIMHGDJIOLD, bool EFOPJOCPODJ, bool GPENIBKPLFL, float PGKLKANBAHM, bool PJFPPEMKLPF, Vector3 OPDGKOBENID)
        {
            float num = 0f;
            if (this.MJAFJDDBMHN)
            {
                if (!this.GAAABCJJPLA)
                {
                    num += Time.fixedDeltaTime;
                }
            }
            else
            {
                num -= Time.fixedDeltaTime * 0.5f;
            }
            if (this.EACLPKFKCGE.ThisHandIsGrabbingObj)
            {
                num += Time.fixedDeltaTime * Mathf.Max(-DAGOJDEEFDM * 1f + 8f, 0f);
            }
            if (this.AEIDNHLPPEB.ThisHandIsGrabbingObj)
            {
                num += Time.fixedDeltaTime * Mathf.Max(-HHMDFJOICJH * 1f + 8f, 0f);
            }
            if (!LDMNBPBABCH && !OIMHGDJIOLD && !EFOPJOCPODJ && !GPENIBKPLFL)
            {
                float num2 = Mathf.Max(Mathf.Max(JHEPNGCDIFK, APIDNIEKDNM), PLBFAIMKEDH);
                num -= Mathf.Max((num2 - 600f) * 0.075f, 0f) * Time.fixedDeltaTime;
            }
            if (EFOPJOCPODJ)
            {
                num -= Time.fixedDeltaTime * Mathf.Pow(PGKLKANBAHM / 45f, 1.5f);
                if (PJFPPEMKLPF)
                {
                    num -= Mathf.Min(Mathf.Pow(OPDGKOBENID.magnitude / 10f, 4f) * Time.fixedDeltaTime, 0.3f);
                }
            }
            KPOGLNBAHDF.HLGCLBMAHLO += num;
            if (num > 0f || KPOGLNBAHDF.HLGCLBMAHLO > 0.98f)
            {
                this.APHMJJFHIOH = 0f;
            }
            else
            {
                this.APHMJJFHIOH += Time.fixedDeltaTime;
            }
            if (this.APHMJJFHIOH > 0.8f)
            {
                KPOGLNBAHDF.HLGCLBMAHLO = Mathf.Min(0f, KPOGLNBAHDF.HLGCLBMAHLO);
            }
        }

        private bool CCMKLOMOBOH
        {
            get
            {
                return this.ELHCIONLLJD;
            }
            set
            {
                if (this.ELHCIONLLJD != value)
                {
                    this.ELHCIONLLJD = value;
                    if (value)
                    {
                        base.StartCoroutine(this.JAAPFMFFGED());
                    }
                }
            }
        }

        private void OnDestroy()
        {
            this.CharacterDropWeapon();
            this.ForceToUngrab();
            this.BFJKIGGHGBM.Clear();
            this.ForceCharacterGrabbingMeToUngrab();
            PccManager.gameObjectToCharacterControllerMap.Remove(base.gameObject);
            PccManager.trackedTransforms.Remove(this.GreenHead.transform);
            foreach (GameObject key in this.IINJFJOIHMK)
            {
                PccManager.rigidbodyCharacterControllerMap.Remove(key);
            }
            this.RemoveAllProjectileOnThisCharacter();
        }

        private void JDEMFDFOOBM(PhysicCharacterController OMMLAAKHFPC)
        {
            foreach (PhysicCharacterController.IHitSomeoneCallback hitSomeoneCallback in this.MLPBPDOFCJG)
            {
                hitSomeoneCallback.OnHitSomeone(OMMLAAKHFPC);
            }
        }

        public GameObject ObjectGrabbedByLeftHand
        {
            get
            {
                return this.EACLPKFKCGE.LKCGBILOJJI;
            }
        }

        private RGrabObj NKDPNMHDKLO
        {
            get
            {
                if (this.CANDPOAFKJE == null)
                {
                    this.CANDPOAFKJE = base.GetComponent<RGrabObj>();
                }
                return this.CANDPOAFKJE;
            }
        }







        private void EKMEAOKDCJM()
        {
            if (!this.MJAFJDDBMHN || !this.DOLMJFFJFBH || this.NJIDGLOLDJE != 0f || this.PNGENFLDJAG.constraints == RigidbodyConstraints.None || this.LDMNBPBABCH)
            {
                return;
            }
            if (this.BMFBMAMHGKG != PhysicCharacterController.AKDGAGJFAOJ.Nothing || this.EHGLGFNALGH != PhysicCharacterController.AKDGAGJFAOJ.Nothing)
            {
                return;
            }
            this.characterStates.FIEKPFBMNIC(0.025f);
            this.characterStates.HKHHJCILJGO(0.3f);
            this.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.PowerPunching;
            this.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.PowerPunching;
            this.NJIDGLOLDJE = 1f;
            base.StartCoroutine(this.APAOALLFAMH.RunPowerPunch());
            base.StartCoroutine(this.CHCFCOPIHCI());
        }



        private void DBNFHBMHGGA()
        {
            this.LAJOGOOAKNM.Add(this.AJBEMNONLMC);
            this.LAJOGOOAKNM.Add(this.NLEHLJPKLCH);
            this.LAJOGOOAKNM.Add(this.AKFKHFBDPBI);
            this.LAJOGOOAKNM.Add(this.GIGHLANHALH);
            this.LAJOGOOAKNM.Add(this.GDPPIFIJPMF);
            this.LAJOGOOAKNM.Add(this.BBMLJFHODAL);
            this.LAJOGOOAKNM.Add(this.CDBGCHHHPFL);
            this.LAJOGOOAKNM.Add(this.IMIIFNONDDM);
            this.LAJOGOOAKNM.Add(this.BGMAHMGFAOO);
            this.LAJOGOOAKNM.Add(this.NELDBBMLJLH);
            this.LAJOGOOAKNM.Add(this.EMDJIGOAPAI);
        }

        public bool Grab
        {
            get
            {
                return this.AFOLPMHFOKE;
            }
            set
            {
                if (this.AFOLPMHFOKE != value)
                {
                    if (value)
                    {
                        this.BGFBPIHFGEH = true;
                        base.StartCoroutine(this.JFNOBCFCPDI());
                    }
                    else
                    {
                        this.KOGAIPHBFPN = true;
                        base.StartCoroutine(this.BEPCLJNCDPA());
                    }
                    this.AFOLPMHFOKE = value;
                }
            }
        }

        public CharacterStates characterStates
        {
            get
            {
                if (this.OGIKHBGBMFI == null)
                {
                    this.OGIKHBGBMFI = base.GetComponent<CharacterStates>();
                }
                return this.OGIKHBGBMFI;
            }
        }

        private void FOFBLLOPELE(ref bool LENEMLOKDCB)
        {
            Vector3 position = this.PDLEJPNAIIB.position;
            Vector3 lhs = this.GreenLegL2.transform.position - position;
            Vector3 lhs2 = this.GreenLegR2.transform.position - position;
            Vector3 rhs = -this.PDLEJPNAIIB.up;
            float num = Vector3.Dot(lhs, rhs);
            float num2 = Vector3.Dot(lhs2, rhs);
            LENEMLOKDCB = (num < num2);
        }

        private void HKDEEIENBIN()
        {
            for (int i = 0; i < this.LAJOGOOAKNM.Count; i++)
            {
                this.LAJOGOOAKNM[i].targetRotation = Quaternion.Euler(this.FNMCFJPOCHN[i] + UnityEngine.Random.onUnitSphere * 30f);
            }
        }



        private void FDKLJLCPDDK()
        {
            this.GMLKAKDJHPC = PhysicCharacterController.MEPJPNCLOFD.Standing;
            this.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
            this.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
            this.characterStates.LPPGHONKBDJ();
            base.StartCoroutine(this.CLOPCBJKFND());
        }

        internal Rigidbody LNDDLJMNLBD
        {
            get
            {
                if (this.PBJPAOCMCOB == null)
                {
                    this.PBJPAOCMCOB = this.GreenFistL.GetComponent<Rigidbody>();
                }
                return this.PBJPAOCMCOB;
            }
        }

        internal float NDIMOOAHIKA { get; set; }

        public Vector3 CharacterVelocityRelativeToSteppedObj
        {
            get
            {
                return this.MDJOFGBFCJE;
            }
        }



        void Boost.IKillSomeoneCallback.OnKillSomeone(PhysicCharacterController MCFOLNMFCPN)
        {
            this.NDDCNKFDAOB(MCFOLNMFCPN);
        }

        internal ConfigurableJoint EMDJIGOAPAI
        {
            get
            {
                if (this.GFEIBKNKFKE == null)
                {
                    this.GFEIBKNKFKE = this.GreenLegR2.GetComponent<ConfigurableJoint>();
                }
                return this.GFEIBKNKFKE;
            }
        }

        internal void MKEOCJIIKKB()
        {
            foreach (PhysicCharacterController.IOnLeftHandReleaseCallback onLeftHandReleaseCallback in this.IOJAKCMCGBC)
            {
                onLeftHandReleaseCallback.OnLeftHandRelease();
            }
        }



        private void BJFAMDKDLKJ(ref bool OGMMABHJCNI)
        {
            if ((this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.Nothing || this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon) && (this.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.Nothing || this.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon))
            {
                this.AELMKKAPJNG = true;
                this.PEPMKBNFPEC.LKIEHLMCJCM.DPMCHIFEGKO(this, ref OGMMABHJCNI);
            }
        }

        internal void FMDDLCJBGKF(bool LLNINKHMPPK, PhysicCharacterController.AttackType GFELIAPGPGA, Rigidbody HNMALBNOMNJ)
        {
            foreach (PhysicCharacterController.IAttackStateChangeCallback attackStateChangeCallback in this.ACNBMIMLKKD)
            {
                attackStateChangeCallback.OnAttackStateChange(LLNINKHMPPK, GFELIAPGPGA, HNMALBNOMNJ);
            }
        }

        private void DBBEBMMNNEB()
        {
            for (int i = 0; i < this.DGLIFFPIBCD.Count; i++)
            {
                this.DGLIFFPIBCD[i].configurableJoint.angularXDrive = this.DGLIFFPIBCD[i].JointStateManager.NormalJointDrive;
                this.DGLIFFPIBCD[i].configurableJoint.angularYZDrive = this.DGLIFFPIBCD[i].JointStateManager.NormalJointDrive;
                this.DGLIFFPIBCD[i].configurableJoint.targetRotation = this.DGLIFFPIBCD[i].JointStateManager.NormalRotation;
            }
            for (int j = 0; j < this.rigidbodies.Count; j++)
            {
                this.rigidbodies[j].maxAngularVelocity = 9.5f;
            }
            this.PNGENFLDJAG.maxAngularVelocity = this.EHJKLECHHEC;
        }

        public float MoveY { get; set; }

        internal void BDPCMGOLPCC(PhysicCharacterController MCFOLNMFCPN)
        {
            foreach (PhysicCharacterController.IRightHandGrabSomeoneCallback rightHandGrabSomeoneCallback in this.KKJPOOOIPMD)
            {
                rightHandGrabSomeoneCallback.OnRightHandGrabSomeone(MCFOLNMFCPN);
            }
        }

        internal ConfigurableJoint GIGHLANHALH
        {
            get
            {
                if (this.FGKEDENNKHC == null)
                {
                    this.FGKEDENNKHC = this.GreenForeArmL.GetComponent<ConfigurableJoint>();
                }
                return this.FGKEDENNKHC;
            }
        }

        private void OJABMJLPACM()
        {
            this.IJOKHEILPGJ();
        }



        public void CharacterDropWeapon()
        {
            this.grabbedWeaponGo = null;
            this.HFNILGPPPGH.isTrigger = false;
            this.AHJCDPHHOFM.isTrigger = false;
        }

        private IEnumerator JKHJPCKPAGC()
        {
            this.GFBJCPDAAKJ = true;
            float num = 0.2f;
            while (num > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    this.OJABMJLPACM();
                }
                yield return this.LGJIFPAHACH;
            }
            Vector3 lhs = this.GreenLegL2.transform.position - this.PDLEJPNAIIB.position;
            Vector3 lhs2 = this.GreenLegR2.transform.position - this.PDLEJPNAIIB.position;
            float num2 = Vector3.Dot(lhs, -this.PDLEJPNAIIB.up);
            float num3 = Vector3.Dot(lhs2, -this.PDLEJPNAIIB.up);
            bool flag = num2 < num3;
            float num4 = 0.15f;
            while (num4 > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num4 -= Time.fixedDeltaTime;
                    this.JFDPJNACNFM(!flag);
                }
                yield return this.LGJIFPAHACH;
            }
            num4 = 0.3f;
            while (num4 > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num4 -= Time.fixedDeltaTime;
                    this.OJABMJLPACM();
                }
                yield return this.LGJIFPAHACH;
            }
            num4 = 0.2f;
            while (num4 > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num4 -= Time.fixedDeltaTime;
                    this.JFDPJNACNFM(flag);
                }
                yield return this.LGJIFPAHACH;
            }
            this.GFBJCPDAAKJ = false;
            yield break;
        }

        public void RemoveRightHandGrabSomeoneCallback(PhysicCharacterController.IRightHandGrabSomeoneCallback KOMCGCIBLEP)
        {
            this.KKJPOOOIPMD.Remove(KOMCGCIBLEP);
        }

        private void LAJPBLECHKO()
        {
            if (this.EACLPKFKCGE.ThisHandIsGrabbingObj && this.AEIDNHLPPEB.ThisHandIsGrabbingObj && !this.HBBHGFFPFPC && !this.BFCMBNKBFAF)
            {
                if (!this.CLJAOHHONIB.isReadyToThrowSth)
                {
                    this.CLJAOHHONIB.readyToThrowStartTime = Time.fixedTime;
                    this.CLJAOHHONIB.SetThrowInitialRotationsAndSprings();
                }
                float num = Time.fixedTime - this.CLJAOHHONIB.readyToThrowStartTime;
                this.CLJAOHHONIB.readyToThrowDuration = num;
                this.CLJAOHHONIB.CharacterReadyToThrow(num);
                this.CLJAOHHONIB.isReadyToThrowSth = true;
                return;
            }
            this.CLJAOHHONIB.isReadyToThrowSth = false;
        }

        internal Rigidbody PIMHHNKOCBE
        {
            get
            {
                if (this.OHNPHEMHCIK == null)
                {
                    this.OHNPHEMHCIK = this.GreenFistR.GetComponent<Rigidbody>();
                }
                return this.OHNPHEMHCIK;
            }
        }


        internal ConfigurableJoint BGMAHMGFAOO
        {
            get
            {
                if (this.IHGJBNOCBCJ == null)
                {
                    this.IHGJBNOCBCJ = this.GreenLegL2.GetComponent<ConfigurableJoint>();
                }
                return this.IHGJBNOCBCJ;
            }
        }

        public void AddLeftHandGrabSomeoneCallback(PhysicCharacterController.ILeftHandGrabSomeoneCallback KOMCGCIBLEP)
        {
            this.ILEGJAAEACJ.Add(KOMCGCIBLEP);
        }

        private IEnumerator DBGKFDDDGBE()
        {
            float num = 0.25f;
            while (num > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.GFAHFDEOPCJ = false;
            yield break;
        }

        internal Collider AHJCDPHHOFM
        {
            get
            {
                if (this.DPJMKKCKPOH == null)
                {
                    this.DPJMKKCKPOH = this.GreenFistR.GetComponent<Collider>();
                }
                return this.DPJMKKCKPOH;
            }
        }

        internal ConfigurableJoint IMIIFNONDDM
        {
            get
            {
                if (this.DOJODLHGFMG == null)
                {
                    this.DOJODLHGFMG = this.GreenLegL1.GetComponent<ConfigurableJoint>();
                }
                return this.DOJODLHGFMG;
            }
        }

        private void FEOCCPBGIDD()
        {
            this.NLEHLJPKLCH.angularXDrive = this.MOJEILEBGGO;
            this.NLEHLJPKLCH.angularYZDrive = this.MOJEILEBGGO;
            this.CDBGCHHHPFL.angularXDrive = this.ANJACNADFBJ;
            this.CDBGCHHHPFL.angularYZDrive = this.ANJACNADFBJ;
            this.AJBEMNONLMC.angularXDrive = this.OJEFBNIKEBI;
            this.AJBEMNONLMC.angularYZDrive = this.OJEFBNIKEBI;
            Vector3 eulerAngles = this.NLEHLJPKLCH.targetRotation.eulerAngles;
            Vector3 eulerAngles2 = this.CDBGCHHHPFL.targetRotation.eulerAngles;
            Vector3 eulerAngles3 = this.AJBEMNONLMC.targetRotation.eulerAngles;
            this.NLEHLJPKLCH.targetRotation = Quaternion.Euler(this.KEGHEKHOBKK.x, this.KEGHEKHOBKK.y, eulerAngles.z);
            this.CDBGCHHHPFL.targetRotation = Quaternion.Euler(this.DAKDIPJJGID.x, this.DAKDIPJJGID.y, eulerAngles2.z);
            this.AJBEMNONLMC.targetRotation = Quaternion.Euler(this.LNAEKEHFNDD.x, this.LNAEKEHFNDD.y, eulerAngles3.z);
        }




        private HeadPunch DENOIHACJHE
        {
            get
            {
                if (this.NBBOKPILIEA == null)
                {
                    this.NBBOKPILIEA = base.GetComponent<HeadPunch>();
                }
                return this.NBBOKPILIEA;
            }
        }

        internal bool HDNBENIBAPH
        {
            get
            {
                return this.FFFEODMGAOK;
            }
            set
            {
                if (this.FFFEODMGAOK != value)
                {
                    this.FFFEODMGAOK = value;
                    if (!value)
                    {
                        this.CIMGMKJHJHH = true;
                        base.StartCoroutine(this.DMPCODIDGGJ());
                        this.FMDDLCJBGKF(false, PhysicCharacterController.AttackType.Roll, this.IHEELAEEPHA);
                        return;
                    }
                    this.FMDDLCJBGKF(true, PhysicCharacterController.AttackType.Roll, this.IHEELAEEPHA);
                }
            }
        }

        private void MIBMJMCGFLN()
        {
            foreach (ConfigurableJoint configurableJoint in this.LAJOGOOAKNM)
            {
                Transform transform = configurableJoint.gameObject.transform;
                Transform transform2 = configurableJoint.connectedBody.gameObject.transform;
                Matrix4x4 localToWorldMatrix = transform.localToWorldMatrix;
                Vector3 lhs = localToWorldMatrix.MultiplyVector(configurableJoint.axis);
                Vector3 vector = localToWorldMatrix.MultiplyVector(configurableJoint.secondaryAxis);
                Quaternion quaternion = Quaternion.LookRotation(Vector3.Cross(lhs, vector), vector);
                Quaternion virtualCoordLocalRot2ConnectedTranform = Quaternion.Inverse(transform2.rotation) * quaternion;
                Quaternion myTransformLocalRot2VirtualObj = Quaternion.Inverse(quaternion) * transform.rotation;
                this.OAKFIKADEBH.Add(configurableJoint, new PhysicCharacterController.GIPGCNNPFLG
                {
                    myTransform = transform,
                    connectedTransform = transform2,
                    virtualCoordLocalRot2ConnectedTranform = virtualCoordLocalRot2ConnectedTranform,
                    myTransformLocalRot2VirtualObj = myTransformLocalRot2VirtualObj
                });
            }
        }

        public void ResetCharacterPose(Vector3 JEFFDBDGDFK, Vector3 HCEIKHOPMDK)
        {
            this.GFBJKJCFBBA = true;
            Quaternion quaternion = Quaternion.LookRotation(HCEIKHOPMDK, -JEFFDBDGDFK);
            this.PNGENFLDJAG.rotation = quaternion;
            this.PDLEJPNAIIB.rotation = quaternion;
            Matrix4x4 localToWorldMatrix = this.PDLEJPNAIIB.localToWorldMatrix;
            for (int i = 0; i < this.rigidbodies.Count; i++)
            {
                this.rigidbodies[i].position = localToWorldMatrix.MultiplyPoint3x4(this.BIBOMEKOKPO[i]);
                this.rigidbodies[i].rotation = quaternion * this.LGLBILCBALG[i];
            }
        }

        private void BNDLACDMDED(ConfigurableJoint IHFKHAGOEBP, ConfigurableJoint ANLGCGHHNCE, JointStateManager2 KGDEGOEOBJF, JointStateManager2 IGFFEOBPBAP, float BLBLKAMNGKD)
        {
            if (BLBLKAMNGKD < 0.2f)
            {
                IHFKHAGOEBP.angularXDrive = KGDEGOEOBJF.NormalJointDrive;
                ANLGCGHHNCE.angularXDrive = IGFFEOBPBAP.NormalJointDrive;
                IHFKHAGOEBP.angularYZDrive = KGDEGOEOBJF.NormalJointDrive;
                ANLGCGHHNCE.angularYZDrive = IGFFEOBPBAP.NormalJointDrive;
                IHFKHAGOEBP.targetRotation = KGDEGOEOBJF.NormalRotation;
                ANLGCGHHNCE.targetRotation = IGFFEOBPBAP.NormalRotation;
                return;
            }
            IHFKHAGOEBP.angularXDrive = this.HLIMINHPIFI;
            ANLGCGHHNCE.angularXDrive = this.HLIMINHPIFI;
            IHFKHAGOEBP.angularYZDrive = this.HLIMINHPIFI;
            ANLGCGHHNCE.angularYZDrive = this.HLIMINHPIFI;
            IHFKHAGOEBP.targetRotation = KGDEGOEOBJF.NormalRotation;
            ANLGCGHHNCE.targetRotation = IGFFEOBPBAP.NormalRotation;
        }

        public void AddBareHandHitCallback(PhysicCharacterController.IBareHandHitCallback JIOAEMPKPOK)
        {
            this.FJJEIJOMPGG.Add(JIOAEMPKPOK);
        }

        internal float DNOODOFCLCG { get; set; }

        private Transform OKBJDGHGCIK
        {
            get
            {
                if (this.MEEJIEJLBGN == null)
                {
                    this.MEEJIEJLBGN = this.GreenChest.transform;
                }
                return this.MEEJIEJLBGN;
            }
        }

        private void FBGDLKJEPJP()
        {
            this.AJBEMNONLMC.angularXDrive = this.EJNBLKGNLLD.NormalJointDrive;
            this.AJBEMNONLMC.angularYZDrive = this.EJNBLKGNLLD.NormalJointDrive;
            this.AJBEMNONLMC.targetRotation = this.ONFPEEHDCLH;
        }

        private JointStateManager2 LMCPDIKPBHG
        {
            get
            {
                if (this.CAMBJHKGBEJ == null)
                {
                    this.CAMBJHKGBEJ = this.GreenUpperArmR.GetComponent<JointStateManager2>();
                }
                return this.CAMBJHKGBEJ;
            }
        }

        private bool LDMNBPBABCH
        {
            get
            {
                return this.BGIFGNJGKPO;
            }
            set
            {
                if (this.BGIFGNJGKPO != value)
                {
                    this.BGIFGNJGKPO = value;
                    if (value)
                    {
                        base.StartCoroutine(this.GKPEHMEAIPK());
                    }
                }
            }
        }

        private JointStateManager2 ICMMLGLKHEJ
        {
            get
            {
                if (this.NEKJANOOPMC == null)
                {
                    this.NEKJANOOPMC = this.GreenUpperArmL.GetComponent<JointStateManager2>();
                }
                return this.NEKJANOOPMC;
            }
        }


        internal void OMOKCIKGEBN(PhysicCharacterController MCFOLNMFCPN)
        {
            foreach (PhysicCharacterController.IGrabSomeoneCallback grabSomeoneCallback in this.GFPAOHJMKKP)
            {
                grabSomeoneCallback.OnGrabSomeone(MCFOLNMFCPN);
            }
        }

        private void LNFPIFJNFDI(ConfigurableJoint KPOIJIACCAC, ConfigurableJoint HJNNBOHCPEK, Quaternion PIAHAKOLHJM, Quaternion KGOEOKPOION)
        {
            KPOIJIACCAC.angularXDrive = this.GPIOMABKHCE;
            HJNNBOHCPEK.angularXDrive = this.CICEEOCCJPA;
            KPOIJIACCAC.angularYZDrive = this.GPIOMABKHCE;
            HJNNBOHCPEK.angularYZDrive = this.CICEEOCCJPA;
            KPOIJIACCAC.targetRotation = PIAHAKOLHJM;
            HJNNBOHCPEK.targetRotation = KGOEOKPOION;
        }



        private void PLKLOCGBNHP()
        {
            this.EAAAAFMPKKN = true;
            base.StartCoroutine(this.GKDCOAACELP());
        }

        internal void OPIJAEDLIKG()
        {
            foreach (PhysicCharacterController.IOnRightHandReleaseCallback onRightHandReleaseCallback in this.PHIKEEMKPOK)
            {
                onRightHandReleaseCallback.OnRightHandRelease();
            }
        }

        private void BDCHENHEHKE()
        {
            Matrix4x4 localToWorldMatrix = this.OKBJDGHGCIK.localToWorldMatrix;
            switch (this.BMFBMAMHGKG)
            {
                case PhysicCharacterController.AKDGAGJFAOJ.Nothing:
                    {
                        PhysicCharacterController.AKDGAGJFAOJ akdgagjfaoj = this.EHGLGFNALGH;
                        if (akdgagjfaoj != PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon && this.PEPMKBNFPEC.AMGIBPCJAMN)
                        {
                            this.DJNHNJJKHDL.Reaching(localToWorldMatrix.MultiplyPoint3x4(this.PEPMKBNFPEC.LCAFMAOFKAM));
                            this.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.Grabbing;
                        }
                        break;
                    }
                case PhysicCharacterController.AKDGAGJFAOJ.Grabbing:
                    if (!this.EACLPKFKCGE.ThisHandIsGrabbingObj)
                    {
                        if (this.PEPMKBNFPEC.AMGIBPCJAMN)
                        {
                            this.DJNHNJJKHDL.Reaching(localToWorldMatrix.MultiplyPoint3x4(this.PEPMKBNFPEC.LCAFMAOFKAM));
                        }
                        else
                        {
                            this.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
                            this.DJNHNJJKHDL.StopReaching();
                        }
                    }
                    break;
            }
            switch (this.EHGLGFNALGH)
            {
                case PhysicCharacterController.AKDGAGJFAOJ.Nothing:
                    {
                        PhysicCharacterController.AKDGAGJFAOJ akdgagjfaoj = this.BMFBMAMHGKG;
                        if (akdgagjfaoj != PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon && this.PEPMKBNFPEC.IKLPPDPJFJC)
                        {
                            this.NKDPNMHDKLO.Reaching(localToWorldMatrix.MultiplyPoint3x4(this.PEPMKBNFPEC.NOIJNEBKNOO));
                            this.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.Grabbing;
                            return;
                        }
                        break;
                    }
                case PhysicCharacterController.AKDGAGJFAOJ.Punching:
                case PhysicCharacterController.AKDGAGJFAOJ.GrabbingWeapon:
                    break;
                case PhysicCharacterController.AKDGAGJFAOJ.Grabbing:
                    if (!this.AEIDNHLPPEB.ThisHandIsGrabbingObj)
                    {
                        if (this.PEPMKBNFPEC.IKLPPDPJFJC)
                        {
                            this.NKDPNMHDKLO.Reaching(localToWorldMatrix.MultiplyPoint3x4(this.PEPMKBNFPEC.NOIJNEBKNOO));
                            return;
                        }
                        this.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
                        this.NKDPNMHDKLO.StopReaching();
                    }
                    break;
                default:
                    return;
            }
        }

        public GameObject grabbedWeaponGo
        {
            get
            {
                return this.IFIPELILPDN;
            }
            set
            {
                if (this.IFIPELILPDN != value)
                {
                    if (value != null)
                    {
                        Weapon eepacgjdmjm = GameObjectToWeaponMapper.gameObjectToWeaponMap[value];
                        this.KMILBNNIHJG = eepacgjdmjm;
                    }
                    else
                    {
                        this.KMILBNNIHJG = null;
                    }
                    this.IFIPELILPDN = value;
                }
            }
        }

        public void AddJumpCallback(PhysicCharacterController.IJumpCallback JIOAEMPKPOK)
        {
            this.BMJPOHNPEIC.Add(JIOAEMPKPOK);
        }

        private IEnumerator GLLIOEGCJLA()
        {
            this.BONLNLPKFPD = true;
            float num = 0.7f;
            while (num > 0f)
            {
                if (PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.BONLNLPKFPD = false;
            yield break;
        }

        public bool Run { get; set; }



        private void ODFOMAGLCFG(bool EBHGJLDKFAM, bool CEEOMKKOEFB)
        {
            this.MKBCAPJLPGK = true;
            this.LDMNBPBABCH = true;
            float num = 0.6f;
            if (!EBHGJLDKFAM || !CEEOMKKOEFB)
            {
                num = 0.3f;
            }
            CFOGGNCCHCO.EFNEGHJPJFN(this.PNGENFLDJAG, this.PDLEJPNAIIB.forward * (this.KECDGNLMHLK * num), ForceMode.Impulse);
            this.OKKJNOCLIEE = 0f;
            base.StartCoroutine(this.FCJJLGFCPBA());
            base.StartCoroutine(this.FKODDKGPDDD());
        }





        internal Collider HFNILGPPPGH
        {
            get
            {
                if (this.IGDAFDFAAEB == null)
                {
                    this.IGDAFDFAAEB = this.GreenFistL.GetComponent<Collider>();
                }
                return this.IGDAFDFAAEB;
            }
        }

        private IEnumerator FKODDKGPDDD()
        {
            float num = 0.3f;
            while (num >= 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.MKBCAPJLPGK = false;
            yield break;
        }

        public bool IsGrabbing
        {
            get
            {
                return this.EACLPKFKCGE.ThisHandIsGrabbingObj || this.AEIDNHLPPEB.ThisHandIsGrabbingObj;
            }
        }


        internal PhysicCharacterController.AKDGAGJFAOJ EHGLGFNALGH
        {
            get
            {
                return this.GAIFKJPEPLB;
            }
            set
            {
                if (this.GAIFKJPEPLB != value)
                {
                    this.GAIFKJPEPLB = value;
                    if (value == PhysicCharacterController.AKDGAGJFAOJ.Punching)
                    {
                        if (this.IFDHPAHDEJO > 0f)
                        {
                            this.IFDHPAHDEJO = 0.5f;
                            return;
                        }
                        base.StartCoroutine(this.JJMJBMEOHMC());
                    }
                }
            }
        }





        private void IMKNKLFLKPI(ConfigurableJoint KPOIJIACCAC, ConfigurableJoint HJNNBOHCPEK, JointStateManager2 KGDEGOEOBJF, JointStateManager2 IGFFEOBPBAP)
        {
            KPOIJIACCAC.angularXDrive = KGDEGOEOBJF.GrabbedJointDrive;
            KPOIJIACCAC.angularYZDrive = KGDEGOEOBJF.GrabbedJointDrive;
            HJNNBOHCPEK.angularXDrive = IGFFEOBPBAP.GrabbedJointDrive;
            HJNNBOHCPEK.angularYZDrive = IGFFEOBPBAP.GrabbedJointDrive;
            KPOIJIACCAC.targetRotation = KGDEGOEOBJF.GrabbedRotation;
            HJNNBOHCPEK.targetRotation = IGFFEOBPBAP.GrabbedRotation;
        }

        public bool IsPunching
        {
            get
            {
                return this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.Punching || this.EHGLGFNALGH == PhysicCharacterController.AKDGAGJFAOJ.Punching;
            }
        }

        public void RemoveKillSomeoneCallback(PhysicCharacterController.IKillSomeoneCallback KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Remove(KOMCGCIBLEP);
        }



        internal void APDAHKJEAEI()
        {
            this.PNGENFLDJAG.constraints = RigidbodyConstraints.None;
        }

        internal ConfigurableJoint NLEHLJPKLCH
        {
            get
            {
                if (this.NFNBPODLMEM == null)
                {
                    this.NFNBPODLMEM = this.GreenChest.GetComponent<ConfigurableJoint>();
                }
                return this.NFNBPODLMEM;
            }
        }

        public bool IsWeaponAttacking
        {
            get
            {
                return !(this.KMILBNNIHJG == null) && this.KMILBNNIHJG.IsAttacking;
            }
        }

        public void AddGrabSomeoneCallback(PhysicCharacterController.IGrabSomeoneCallback KOMCGCIBLEP)
        {
            this.GFPAOHJMKKP.Add(KOMCGCIBLEP);
        }

        private void PEFOGDAIDBK(float IPIDMOCBOFJ, float BNAFACEFKHK, Vector3 CNOFPKHKEBH, bool PJFPPEMKLPF, RaycastHit OLKKKDDAJJM, Vector3 OPDGKOBENID, Vector3 MHGGDOKFODC)
        {
            Vector3 up = this.PDLEJPNAIIB.up;
            float num = Vector2.SignedAngle(new Vector2(CNOFPKHKEBH.x, CNOFPKHKEBH.z), new Vector2(-up.x, -up.z).normalized);
            float num2;
            if (num > 0f)
            {
                num2 = 1f;
            }
            else
            {
                num2 = -1f;
            }
            float num3 = Mathf.Min(this.characterStates.WeaponWeight + this.characterStates.liftObjectWeight, 45f);
            float num4 = 0.6f;
            Rigidbody rigidbody = null;
            Vector3 position = Vector3.zero;
            if (PJFPPEMKLPF)
            {
                position = OLKKKDDAJJM.point;
                rigidbody = OLKKKDDAJJM.rigidbody;
                PhysicMaterial sharedMaterial = OLKKKDDAJJM.collider.sharedMaterial;
                if (sharedMaterial != null)
                {
                    num4 = sharedMaterial.dynamicFriction;
                }
            }
            if (PJFPPEMKLPF && this.MJAFJDDBMHN && !this.LDMNBPBABCH && (!this.GAAABCJJPLA || !this.GDJNMJBCMMB) && this.KGLGJIEGFHN < 75f && !this.HBBHGFFPFPC)
            {
                float num5 = Mathf.Clamp01(num4 / 0.6f);
                if (OPDGKOBENID.magnitude < 10f || this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.PowerPunching)
                {
                    if (this.JDCIBMAFDBP > 0.4f)
                    {
                        this.GEEPMHEEBEF(OLKKKDDAJJM, this.PNGENFLDJAG, MHGGDOKFODC);
                        this.CharacterFootNoFriction(0.05f);
                    }
                }
                else
                {
                    this.DLNNLIAMBEP = 0f;
                    this.CharacterFootHasFriction();
                }
                Vector3 vector = this.PNGENFLDJAG.velocity - this.IAMNFCFJPIG;
                float num6 = Mathf.SmoothStep(0.1f, 1f, BNAFACEFKHK / 0.8f);
                float num7 = (Mathf.Sin(2f * IPIDMOCBOFJ + this.ILOLBDAFLIG) + 1f) * this.DGCOKMPGMID + this.HOIPBBIDICL;
                Vector3 vector2 = Vector3.ClampMagnitude((num6 * Mathf.Max((106f - 1.12f * (33f + num3)) * 0.05f, 0f) * num7 * CNOFPKHKEBH - Vector3.ProjectOnPlane(vector, Vector3.up)) * 3300f, 900f * num5);
                this.PNGENFLDJAG.AddForce(vector2, ForceMode.Force);
                if (rigidbody != null)
                {
                    rigidbody.AddForceAtPosition(-vector2, position, ForceMode.Force);
                }
                if (!this.FPEOKBDFNJK && BNAFACEFKHK >= 0.3f)
                {
                    this.PNGENFLDJAG.AddTorque(Mathf.Pow(Mathf.Abs(num), 0.3f) * 100f * num2 * Vector3.up, ForceMode.Force);
                }
            }
        }


        public void RemoveBareHandHitCallback(PhysicCharacterController.IBareHandHitCallback JIOAEMPKPOK)
        {
            if (this.FJJEIJOMPGG.Contains(JIOAEMPKPOK))
            {
                this.FJJEIJOMPGG.Remove(JIOAEMPKPOK);
            }
        }





        // TODO Could be Fake
        private void AJHFKPHJKMP()
        {
        }

        private void HCCIJMAMMEC()
        {
            this.DBBEBMMNNEB();
            this.CBasicState = PhysicCharacterController.CharacterBasicState.Normal;
            this.characterStates.LPPGHONKBDJ();
        }



        private void HJBDOKHICHL(bool DOLMJFFJFBH, Vector3 HKGBHCGOOKE, Vector3 OAFIFPPACGO, float MCPOAGEENGA)
        {
            this.NLEHLJPKLCH.angularXDrive = this.MOJONFOIABN.WalkJointDrive;
            this.NLEHLJPKLCH.angularYZDrive = this.MOJONFOIABN.WalkJointDrive;
            this.CDBGCHHHPFL.angularXDrive = this.ADAKFMNLAAD.WalkJointDrive;
            this.CDBGCHHHPFL.angularYZDrive = this.ADAKFMNLAAD.WalkJointDrive;
            if (!DOLMJFFJFBH)
            {
                this.NLEHLJPKLCH.targetRotation = this.MOJONFOIABN.WalkRotation;
                this.CDBGCHHHPFL.targetRotation = this.ADAKFMNLAAD.WalkRotation;
                return;
            }
            float num = Mathf.Clamp(Vector3.SignedAngle(HKGBHCGOOKE, OAFIFPPACGO, Vector3.up) * 0.03f, -1f, 1f);
            float t = (num + 1f) * 0.5f;
            this.EGFHFCABBBF.y = Mathf.Lerp(5f, -5f, t);
            this.MFPCEDHLBNC.y = Mathf.Lerp(20f, -20f, t);
            if (MCPOAGEENGA < 2f)
            {
                float t2 = (Mathf.Cos(Mathf.Pow(MCPOAGEENGA * 0.5f, 0.4f) * 2f * this.AFICADMEOBP) + 1f) * 0.5f;
                this.EGFHFCABBBF.x = Mathf.Lerp(-16f, 0f, t2);
                this.MFPCEDHLBNC.x = Mathf.Lerp(-15f, 0f, t2);
            }
            else
            {
                float t3 = Mathf.Abs(num);
                this.EGFHFCABBBF.x = 0f;
                this.MFPCEDHLBNC.x = Mathf.Lerp(0f, -10f, t3);
            }
            this.NLEHLJPKLCH.targetRotation = Quaternion.Euler(this.EGFHFCABBBF);
            this.CDBGCHHHPFL.targetRotation = Quaternion.Euler(this.MFPCEDHLBNC);
        }



        private RightPunch NPOGMNGGCMC
        {
            get
            {
                if (this.MBDFCIEMOEL == null)
                {
                    this.MBDFCIEMOEL = base.GetComponent<RightPunch>();
                }
                return this.MBDFCIEMOEL;
            }
        }



        private void EIJMGPIIAJH(bool BAFNIPAACNC)
        {
            if (BAFNIPAACNC)
            {
                this.NLEHLJPKLCH.angularXDrive = this.MOJONFOIABN.NormalJointDrive;
                this.NLEHLJPKLCH.angularYZDrive = this.MOJONFOIABN.NormalJointDrive;
                this.CDBGCHHHPFL.angularXDrive = this.ADAKFMNLAAD.NormalJointDrive;
                this.CDBGCHHHPFL.angularYZDrive = this.ADAKFMNLAAD.NormalJointDrive;
            }
            else
            {
                this.NLEHLJPKLCH.angularXDrive = this.EJFBHPHMPJB;
                this.NLEHLJPKLCH.angularYZDrive = this.EJFBHPHMPJB;
                this.CDBGCHHHPFL.angularXDrive = this.MNBGCMDNLON;
                this.CDBGCHHHPFL.angularYZDrive = this.MNBGCMDNLON;
            }
            this.NLEHLJPKLCH.targetRotation = this.MOJONFOIABN.NormalRotation;
            this.CDBGCHHHPFL.targetRotation = this.ADAKFMNLAAD.NormalRotation;
        }

        private void DCPEKNKCMKN(float IPIDMOCBOFJ, float BNAFACEFKHK, bool GHMBNLHGMHG)
        {
            if (BNAFACEFKHK < 0.3f && !this.DOLMJFFJFBH)
            {
                return;
            }
            float num = Mathf.Sin(IPIDMOCBOFJ - 1.5708f + 0.5f);
            if (GHMBNLHGMHG)
            {
                num = -num;
            }
            if (!this.DOLMJFFJFBH)
            {
                this.FIIKBADHOJH.AddTorque(-num * 8500f * this.OKBJDGHGCIK.forward, ForceMode.Acceleration);
                this.PNGENFLDJAG.AddTorque(-num * -1100f * 1.3f * this.PDLEJPNAIIB.forward, ForceMode.Acceleration);
                return;
            }
            this.FIIKBADHOJH.AddTorque(-num * 400f * 20f * this.OKBJDGHGCIK.forward, ForceMode.Acceleration);
            this.PNGENFLDJAG.AddTorque(-num * 100f * 1.65f * this.PDLEJPNAIIB.forward, ForceMode.Acceleration);
        }



        private void HDPAFOLKHCE(float GMGGCHIOBAF, float EOOLMJINFHE, bool KLCJOFLBFOB, float IPIDMOCBOFJ, float BNAFACEFKHK, bool ODOMKKMMFHI, ref Vector3 OHNILIJAEPF, float LHMLHAPCCGJ, bool PJFPPEMKLPF, RaycastHit OLKKKDDAJJM, bool OAOKLDGMECO, Vector3 OPDGKOBENID, Vector3 MHGGDOKFODC)
        {
            Vector3 normalized = new Vector3(GMGGCHIOBAF, 0f, EOOLMJINFHE).normalized;
            if (!ODOMKKMMFHI)
            {
                OHNILIJAEPF = normalized;
            }
            Vector3 up = this.PDLEJPNAIIB.up;
            float num = Vector2.SignedAngle(new Vector2(normalized.x, normalized.z), new Vector2(-up.x, -up.z).normalized);
            float num2;
            if (num > 0f)
            {
                num2 = 1f;
            }
            else
            {
                num2 = -1f;
            }
            float num3 = Mathf.Min(this.characterStates.WeaponWeight + this.characterStates.liftObjectWeight, 45f);
            float num4 = 0.6f;
            Rigidbody rigidbody = null;
            Vector3 position = Vector3.zero;
            if (PJFPPEMKLPF)
            {
                position = OLKKKDDAJJM.point;
                rigidbody = OLKKKDDAJJM.rigidbody;
                PhysicMaterial sharedMaterial = OLKKKDDAJJM.collider.sharedMaterial;
                if (sharedMaterial != null)
                {
                    num4 = sharedMaterial.dynamicFriction;
                }
            }
            if (PJFPPEMKLPF && this.MJAFJDDBMHN && !this.LDMNBPBABCH && (!this.GAAABCJJPLA || !this.GDJNMJBCMMB) && LHMLHAPCCGJ < 95f && !this.HBBHGFFPFPC)
            {
                float num5 = Mathf.Clamp01(num4 / 0.6f);
                if (OPDGKOBENID.magnitude < 10f || this.BMFBMAMHGKG == PhysicCharacterController.AKDGAGJFAOJ.PowerPunching)
                {
                    if (this.JDCIBMAFDBP > 0.4f)
                    {
                        this.GEEPMHEEBEF(OLKKKDDAJJM, this.PNGENFLDJAG, MHGGDOKFODC);
                        this.CharacterFootNoFriction(0.05f);
                    }
                }
                else
                {
                    this.DLNNLIAMBEP = 0f;
                    this.CharacterFootHasFriction();
                }
                Vector3 vector = this.PNGENFLDJAG.velocity - MHGGDOKFODC;
                Vector3 vector2;
                if (KLCJOFLBFOB && LHMLHAPCCGJ < 45f)
                {
                    this.characterStates.FIEKPFBMNIC(Time.fixedDeltaTime * 0.1f * (1f + num3 / 33f));
                    this.characterStates.HKHHJCILJGO(1f);
                    vector2 = Vector3.ClampMagnitude((normalized * Mathf.Max((142f - 1.12f * (33f + num3)) * 0.05f, 0f) - Vector3.ProjectOnPlane(vector, Vector3.up)) * 3300f, 1200f * num5);
                    this.PNGENFLDJAG.AddForce(vector2, ForceMode.Force);
                }
                else
                {
                    float num6;
                    if (BNAFACEFKHK >= 0.4f)
                    {
                        num6 = 1f;
                    }
                    else
                    {
                        num6 = Mathf.SmoothStep(0.1f, 1f, BNAFACEFKHK / 0.6f);
                    }
                    float num7 = (Mathf.Sin(2f * IPIDMOCBOFJ - 0.1f) + 1f) * 0.2f + 0.8f;
                    vector2 = Vector3.ClampMagnitude((num6 * Mathf.Max((106f - 1.12f * (33f + num3)) * 0.05f, 0f) * num7 * normalized - Vector3.ProjectOnPlane(vector, Vector3.up)) * 3300f, 900f * num5);
                    this.PNGENFLDJAG.AddForce(vector2, ForceMode.Force);
                }
                if (rigidbody != null)
                {
                    rigidbody.AddForceAtPosition(Vector3.ClampMagnitude(-vector2, rigidbody.mass * 30f * 100f), position, ForceMode.Force);
                }
                if (!this.FPEOKBDFNJK && (BNAFACEFKHK >= 0.2f || KLCJOFLBFOB || OAOKLDGMECO) && !ODOMKKMMFHI)
                {
                    this.PNGENFLDJAG.AddTorque(Mathf.Pow(Mathf.Abs(num), 0.3f) * 100f * num2 * Vector3.up, ForceMode.Force);
                    return;
                }
            }
            else
            {
                if (KLCJOFLBFOB)
                {
                    CFOGGNCCHCO.EFNEGHJPJFN(this.PNGENFLDJAG, (this.PMMCAMIHJGB + 1050f) * 0.024f * Mathf.Pow(33f / (33f + num3), 0.65f) * normalized, ForceMode.Force);
                    this.characterStates.FIEKPFBMNIC(Time.fixedDeltaTime * 0.1f * (1f + num3 / 33f));
                    this.characterStates.HKHHJCILJGO(1f);
                }
                else
                {
                    CFOGGNCCHCO.EFNEGHJPJFN(this.PNGENFLDJAG, this.PMMCAMIHJGB * 0.024f * Mathf.Pow(33f / (33f + num3), 0.65f) * normalized, ForceMode.Force);
                }
                if (!this.FPEOKBDFNJK)
                {
                    this.PNGENFLDJAG.AddTorque(Mathf.Pow(Mathf.Abs(num), 0.3f) * 100f * num2 * Vector3.up, ForceMode.Force);
                }
            }
        }

        private Transform KMMNIGMMEAG
        {
            get
            {
                if (this.AACALIJGEID == null)
                {
                    this.AACALIJGEID = this.GreenWaist.transform;
                }
                return this.AACALIJGEID;
            }
        }

        internal void JAJBFJEHDND()
        {
            this.PNGENFLDJAG.constraints = (RigidbodyConstraints)48;
        }

        public void RemoveGrabSomeoneCallback(PhysicCharacterController.IGrabSomeoneCallback KOMCGCIBLEP)
        {
            this.GFPAOHJMKKP.Remove(KOMCGCIBLEP);
        }

        private JointStateManager2 HIEFGMMNJKM
        {
            get
            {
                if (this.PKDFPFCFDAC == null)
                {
                    this.PKDFPFCFDAC = this.GreenForeArmL.GetComponent<JointStateManager2>();
                }
                return this.PKDFPFCFDAC;
            }
        }

        private void MOPPNJLNOJM()
        {
            if (this.DLNNLIAMBEP <= 0f)
            {
                this.DLNNLIAMBEP = 0f;
                this.CharacterFootHasFriction();
                return;
            }
            this.DLNNLIAMBEP -= Time.fixedDeltaTime;
        }

        internal bool NHNKGGEGGEJ
        {
            get
            {
                return this.AEIDNHLPPEB.ThisHandIsGrabbingObj;
            }
        }

        public void RemoveAttackStateChangeCallback(PhysicCharacterController.IAttackStateChangeCallback JIOAEMPKPOK)
        {
            if (this.ACNBMIMLKKD.Contains(JIOAEMPKPOK))
            {
                this.ACNBMIMLKKD.Remove(JIOAEMPKPOK);
            }
        }

        private IEnumerator FCJJLGFCPBA()
        {
            this.GMLKAKDJHPC = PhysicCharacterController.MEPJPNCLOFD.Jumping;
            float num = 1f;
            while (num >= 0f && (!this.MJAFJDDBMHN || this.LDMNBPBABCH) && this.CBasicState == PhysicCharacterController.CharacterBasicState.Normal)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num -= Time.fixedDeltaTime;
                    this.FEOCCPBGIDD();
                }
                yield return this.LGJIFPAHACH;
            }
            if (this.GMLKAKDJHPC == PhysicCharacterController.MEPJPNCLOFD.Jumping)
            {
                this.GMLKAKDJHPC = PhysicCharacterController.MEPJPNCLOFD.Standing;
            }
            yield break;
        }

        private void IGCKGDIFPHN(Vector2 GFMPCKBDLOG)
        {
            if (GFMPCKBDLOG.magnitude < 0.01f)
            {
                return;
            }
            Vector3 up = this.OKBJDGHGCIK.up;
            float num = Vector2.SignedAngle(GFMPCKBDLOG, new Vector2(-up.x, -up.z).normalized);
            float num2;
            if (num > 0f)
            {
                num2 = 1f;
            }
            else
            {
                num2 = -1f;
            }
            this.FIIKBADHOJH.AddTorque(num2 * Mathf.Clamp(Mathf.Pow(Mathf.Abs(num), 0.9f) * 120f, 0f, 60f) * Vector3.up, ForceMode.Force);
        }

        public void MakeCharacterDead()
        {
            this.characterStates.IPIJHLEFEPL();
        }

        void Boost.IAttackSomeoneCallback.OnAttackingSomeone(PhysicCharacterController MCFOLNMFCPN)
        {
            this.JDEMFDFOOBM(MCFOLNMFCPN);
        }

        public void AddKillSomeoneCallback(PhysicCharacterController.IKillSomeoneCallback KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Add(KOMCGCIBLEP);
        }

        private void BPFGCBCOLLJ(ref bool EGMNECLJBOE, ref float NLAHAAOHPJB)
        {
            if (FixedUpdateCounter.frameCount % 3 != this.OCKHHOAKGCJ)
            {
                return;
            }
            EGMNECLJBOE = false;
            if (this.LDMNBPBABCH)
            {
                return;
            }
            Vector3 position = this.PDLEJPNAIIB.position;
            Vector3 right = this.PDLEJPNAIIB.right;
            int num = Physics.SphereCastNonAlloc(position + right * 0.21f, 0.12f, Vector3.down, this.AIJPCFMOEGH, 0.432f);
            int num2 = Physics.SphereCastNonAlloc(position + right * -0.21f, 0.12f, Vector3.down, this.MIKDPIDKDPK, 0.432f);
            for (int i = 0; i < num; i++)
            {
                GameObject gameObject = this.AIJPCFMOEGH[i].collider.gameObject;
                if (!this.IINJFJOIHMK.Contains(gameObject) && gameObject != this.grabbedWeaponGo)
                {
                    NLAHAAOHPJB = 0.1f;
                    if (gameObject.layer != 8)
                    {
                        EGMNECLJBOE = false;
                        return;
                    }
                    EGMNECLJBOE = true;
                }
            }
            for (int j = 0; j < num2; j++)
            {
                GameObject gameObject2 = this.MIKDPIDKDPK[j].collider.gameObject;
                if (!this.IINJFJOIHMK.Contains(gameObject2) && gameObject2 != this.grabbedWeaponGo)
                {
                    NLAHAAOHPJB = 0.1f;
                    if (gameObject2.layer != 8)
                    {
                        EGMNECLJBOE = false;
                        return;
                    }
                    EGMNECLJBOE = true;
                }
            }
        }

        internal ConfigurableJoint GDPPIFIJPMF
        {
            get
            {
                if (this.IAIPIJEPFHA == null)
                {
                    this.IAIPIJEPFHA = this.GreenUpperArmR.GetComponent<ConfigurableJoint>();
                }
                return this.IAIPIJEPFHA;
            }
        }





        public void ForceCharacterGrabbingMeToUngrab()
        {
            foreach (PhysicCharacterController physicCharacterController in this.EOPMJOGMMNI.ToList<PhysicCharacterController>())
            {
                if (physicCharacterController != null)
                {
                    physicCharacterController.ForceToUngrab();
                }
            }
        }

        private LeftPunch KKAHGMHMOCH
        {
            get
            {
                if (this.BMPMKKLJNAE == null)
                {
                    this.BMPMKKLJNAE = base.GetComponent<LeftPunch>();
                }
                return this.BMPMKKLJNAE;
            }
        }

        private void PLFDDJNANOM()
        {
            this.AJBEMNONLMC.angularXDrive = this.EJNBLKGNLLD.NormalJointDrive;
            this.AJBEMNONLMC.angularYZDrive = this.EJNBLKGNLLD.NormalJointDrive;
            this.AJBEMNONLMC.targetRotation = this.EJNBLKGNLLD.NormalRotation;
        }

        private IEnumerator NHNOKFCACAF(Vector3 BLKIPKENFGB, bool DEKABKJLMGI)
        {
            this.EFOPJOCPODJ = true;
            Vector3 normalized = BLKIPKENFGB.normalized;
            if (DEKABKJLMGI)
            {
                this.PNGENFLDJAG.AddForce(Vector3.ClampMagnitude(BLKIPKENFGB * 2f, 3500f), ForceMode.Acceleration);
            }
            this.APDAHKJEAEI();
            float num = 0f;
            float num2 = Mathf.Clamp(0.45f + Mathf.Max(0f, BLKIPKENFGB.magnitude - 1700f) * 0.0005f, 0f, 4f);
            while (num < num2 && this.CBasicState == PhysicCharacterController.CharacterBasicState.Normal && (this.PNGENFLDJAG.constraints == RigidbodyConstraints.None || num < 0.2f))
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    num += Time.fixedDeltaTime;
                    if (this.characterStates.HLGCLBMAHLO <= 0f && num >= 0.2f)
                    {
                        break;
                    }
                    if (Math.Abs(this.JGHLFHJLKCC) < 0.005f)
                    {
                        this.FOFBLLOPELE(ref this.LLNDLPJHINF);
                    }
                    this.JGHLFHJLKCC += Time.fixedDeltaTime * 11f * (this.KPFCLKBGMCD + 0.8f);
                    this.MCPOAGEENGA += Time.fixedDeltaTime;
                    this.KMFDIFCHDLJ += Time.fixedDeltaTime;
                    if (this.GMLKAKDJHPC == PhysicCharacterController.MEPJPNCLOFD.Standing)
                    {
                        this.GMLKAKDJHPC = PhysicCharacterController.MEPJPNCLOFD.Walking;
                    }
                    if (!this.KJCJPIKABAE && this.BMFBMAMHGKG != PhysicCharacterController.AKDGAGJFAOJ.PowerPunching)
                    {
                        this.PNGENFLDJAG.angularDrag = 0.05f;
                    }
                    this.HDPAFOLKHCE(normalized.x, normalized.z, true, this.JGHLFHJLKCC, this.KMFDIFCHDLJ, this.EFOPJOCPODJ, ref this.CNOFPKHKEBH, this.KGLGJIEGFHN, this.OGPMMDHONON, this.FLIHOPJMBPC, this.IILAPAPDGCL, this.MDJOFGBFCJE, this.IAMNFCFJPIG);
                    this.IGALMHPOGDH = 0f;
                    if (this.MHCJMOEMBOC != null)
                    {
                        base.StopCoroutine(this.MHCJMOEMBOC);
                        this.GFBJCPDAAKJ = false;
                    }
                }
                yield return this.LGJIFPAHACH;
            }
            this.EFOPJOCPODJ = false;
            yield break;
        }






        public void AddRightHandReleaseCallback(PhysicCharacterController.IOnRightHandReleaseCallback KOMCGCIBLEP)
        {
            this.PHIKEEMKPOK.Add(KOMCGCIBLEP);
        }

        private void PPPPOHGKPJD()
        {
            Vector3 b = Vector3.up * 0.0025f;
            foreach (Rigidbody rigidbody in this.rigidbodies)
            {
                rigidbody.transform.position += b;
            }
        }

        private IEnumerator CHCFCOPIHCI()
        {
            while (this.NJIDGLOLDJE > 0f)
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    this.NJIDGLOLDJE -= Time.fixedDeltaTime;
                }
                yield return this.LGJIFPAHACH;
            }
            this.NJIDGLOLDJE = 0f;
            yield break;
        }



        private HashSet<PhysicCharacterController.IWeaponStateChangeCallbacks> IODFBCIAHDD = new HashSet<PhysicCharacterController.IWeaponStateChangeCallbacks>();

        private readonly HashSet<PhysicCharacterController.IHitSomeoneCallback> MLPBPDOFCJG = new HashSet<PhysicCharacterController.IHitSomeoneCallback>();

        private readonly HashSet<PhysicCharacterController.IKillSomeoneCallback> PKOEBJAKICC = new HashSet<PhysicCharacterController.IKillSomeoneCallback>();

        private readonly HashSet<PhysicCharacterController.ILeftHandGrabSomeoneCallback> ILEGJAAEACJ = new HashSet<PhysicCharacterController.ILeftHandGrabSomeoneCallback>();

        private readonly HashSet<PhysicCharacterController.IRightHandGrabSomeoneCallback> KKJPOOOIPMD = new HashSet<PhysicCharacterController.IRightHandGrabSomeoneCallback>();

        private readonly HashSet<PhysicCharacterController.IGrabSomeoneCallback> GFPAOHJMKKP = new HashSet<PhysicCharacterController.IGrabSomeoneCallback>();

        private readonly HashSet<PhysicCharacterController.IBothHandsReleaseCharacterCallback> CLOKNACLBHP = new HashSet<PhysicCharacterController.IBothHandsReleaseCharacterCallback>();

        private readonly HashSet<PhysicCharacterController.IOnLeftHandReleaseCallback> IOJAKCMCGBC = new HashSet<PhysicCharacterController.IOnLeftHandReleaseCallback>();

        private readonly HashSet<PhysicCharacterController.IOnRightHandReleaseCallback> PHIKEEMKPOK = new HashSet<PhysicCharacterController.IOnRightHandReleaseCallback>();

        public GameObject GreenHead;

        public GameObject GreenChest;

        public GameObject GreenWaist;

        public GameObject GreenHip;

        public GameObject GreenLegL1;

        public GameObject GreenLegL2;

        public GameObject GreenLegR1;

        public GameObject GreenLegR2;

        public GameObject GreenUpperArmL;

        public GameObject GreenUpperArmR;

        public GameObject GreenForeArmL;

        public GameObject GreenForeArmR;

        public GameObject GreenFistL;

        public GameObject GreenFistR;

        internal HashSet<GameObject> IINJFJOIHMK = new HashSet<GameObject>();

        public List<Rigidbody> rigidbodies = new List<Rigidbody>();

        private List<PhysicCharacterController.ConfigurableJointAndJointStateManager> DGLIFFPIBCD = new List<PhysicCharacterController.ConfigurableJointAndJointStateManager>();

        private PhysicCharacterController.CharacterBasicState DPHHOCBFDPC = PhysicCharacterController.CharacterBasicState.Normal;

        private HashSet<PhysicCharacterController.ICharacterBasicStateChangedCallback> BFJKIGGHGBM = new HashSet<PhysicCharacterController.ICharacterBasicStateChangedCallback>();

        private PhysicCharacterController.MEPJPNCLOFD GMLKAKDJHPC;

        private PhysicCharacterController.AKDGAGJFAOJ COEEMGNLJNG;

        private PhysicCharacterController.AKDGAGJFAOJ GAIFKJPEPLB;

        private float IFDHPAHDEJO;

        private bool LAHKPENBLEN;

        internal bool GAAABCJJPLA;

        private bool BGIFGNJGKPO;

        private bool LHOEFHMKFMG;

        private float JGHLFHJLKCC;

        private float KMFDIFCHDLJ;

        private float IGALMHPOGDH;

        private float OKKJNOCLIEE = 0.08f;

        private float JDCIBMAFDBP;

        private float AGCOOKPELPB;

        private float DLNNLIAMBEP = 0.1f;

        private PhysicCharacterController.CNOEKKHHKDN IMEPJAGPJCF;


        private bool EOANGLDJKHM;

        private bool OALKKLFABKF;

        internal bool GDJNMJBCMMB;

        private float IKGLJMCPAJA = 0.08f;

        private float PMMCAMIHJGB = 2100f;


        private float KPFCLKBGMCD = 1f;

        private float KECDGNLMHLK = 235f;

        public LayerMask layerCanWalkOn;

        private Quaternion BPAIMJJCMCF = Quaternion.Euler(new Vector3(57.6f, 0f, 0f));

        private Quaternion BJLBKIEDGDL = Quaternion.Euler(new Vector3(-48.5f, 0f, 0f));

        private Quaternion JHKEOJMHMKM = Quaternion.Euler(new Quaternion(1f, 0f, 0f, 1f).eulerAngles);

        private Quaternion LEFJHPEALOK = Quaternion.Euler(new Quaternion(-0.7f, 0f, 0f, 1f).eulerAngles);

        private Quaternion CFMEFNKNILK = Quaternion.Euler(new Quaternion(-1f, 0f, 0f, 1f).eulerAngles);

        private Quaternion MNKIJJECKDI = Quaternion.Euler(new Quaternion(0.08f, 0f, 0f, 1f).eulerAngles);

        private Quaternion ABAGFMMDFIO = Quaternion.Euler(new Quaternion(-0.16f, 0f, 0f, 1f).eulerAngles);

        private Quaternion FDCKKKMCEGF = Quaternion.Euler(new Quaternion(0.8f, -0.7f, 0f, 1f).eulerAngles);

        private Quaternion FCBJCCNPCOJ = Quaternion.Euler(new Quaternion(-0.4f, -0.7f, 0f, 1f).eulerAngles);

        private Quaternion OPPCPPBDILA = Quaternion.Euler(new Quaternion(0.8f, 0.7f, 0f, 1f).eulerAngles);

        private Quaternion GNLKHCGBJGM = Quaternion.Euler(new Quaternion(-0.4f, 0.7f, 0f, 1f).eulerAngles);

        private Quaternion LMPOEBCFPKK = Quaternion.Euler(new Quaternion(1.3f, 0f, 0f, 1f).eulerAngles);

        private Quaternion NEHJDIKMCLM = Quaternion.Euler(new Quaternion(0f, 0f, 0f, 1f).eulerAngles);


        private bool PLFNFLEEDNB;

        private bool KPPMGBBENED;

        private bool GLNAOGJDNMA;

        private float HHJLJLPJBOO;

        private bool LKHJNCCIEMI;

        private bool KHEKDCLAPKO;

        private bool MCMLHECLGIA;

        private bool GJHPMOCCOBJ;

        private bool CHBCNLCPMKD;

        private bool NPEGKOAANIO;

        private bool AFOLPMHFOKE;

        private bool BGFBPIHFGEH;

        private bool KOGAIPHBFPN;

        private float MHBBNONAKGP;

        private float EHLHFPDKIJA;


        private float FLMOKMDGMPB;

        private Vector3 CNOFPKHKEBH = Vector3.forward;

        private float DPMGIOOBPAH;

        private float AFICADMEOBP = 3.1415927f;

        private float MCPOAGEENGA;

        private bool IILAPAPDGCL;

        private float AGEABAJABPD;

        private float NJIDGLOLDJE;

        private bool DOLMJFFJFBH;

        private float KGLGJIEGFHN;

        private float PAKNGDIDFGK;


        private bool AHPFHMOPIIG;

        private IEnumerator MHCJMOEMBOC;

        private int OCKHHOAKGCJ;


        private Rigidbody KDHFDFDAJDF;

        private Rigidbody BLBGODNMLAM;

        private List<CharacterDamage> OBJGECLGOBH = new List<CharacterDamage>();


        private Vector3 CAKDHBMGDFK;

        private float EHJKLECHHEC = 15f;

        private bool CIMGMKJHJHH;

        private bool FFFEODMGAOK;

        private Vector3[] FNMCFJPOCHN = new Vector3[11];

        private bool HBHKAGANHHM;

        private bool NDNGALHPINI = true;



        private bool DJIDPOADDKN;

        private bool ENKDAEMMGNE;

        private Vector3 CIPJGGBEMGL;

        private Vector3 BKPILGAPIGH;

        private Vector3 DJAOAGKKACH;

        private Vector3 NDNICBAIOAF;

        private Vector3 NHHMJOMLGHK;

        private bool OGPMMDHONON;

        private RaycastHit FLIHOPJMBPC;

        private Vector3 MDJOFGBFCJE = Vector3.zero;

        private Vector3 IAMNFCFJPIG = Vector3.zero;

        internal readonly HashSet<PhysicCharacterController> EOPMJOGMMNI = new HashSet<PhysicCharacterController>();

        internal readonly HashSet<Arrow> PFBHDFNHIDA = new HashSet<Arrow>();

        internal readonly HashSet<Pin> FIFLMFGANEM = new HashSet<Pin>();

        internal readonly HashSet<Weapon> MCLLMKNDGMA = new HashSet<Weapon>();

        private bool HFDKBIJBEPD;

        internal bool BFCMBNKBFAF;

        internal bool DIFAOOPOMDL;

        private float AJGFBOPEMML;

        private Transform DCCNLCABAGP;

        private Transform MEEJIEJLBGN;

        private Transform AACALIJGEID;

        private WaitForFixedUpdate LGJIFPAHACH = new WaitForFixedUpdate();

        private PowerPunch APAOALLFAMH;

        private Kick JOHBNEIKLFL;

        private JointStateManager2 OAINLMNMIPB;

        private JointStateManager2 EHOJIFOMIKE;

        private JointStateManager2 PFGIIFIFDBL;

        private LGrabObj LHAGKEBFCJB;

        private RGrabObj CANDPOAFKJE;

        private GrabDetector PEPMKBNFPEC;

        private JointStateManager2 NEKJANOOPMC;

        private JointStateManager2 CAMBJHKGBEJ;

        private JointStateManager2 PKDFPFCFDAC;

        private JointStateManager2 BIPFJPMKAFE;

        private JointStateManager2 PPGIDOADPIG;

        private JointStateManager2 DHGOLBICAMF;

        private JointStateManager2 GGIGFFAKHMP;

        private JointStateManager2 EMGEKLHOGAF;

        private GrabCollisionDetectL EACLPKFKCGE;

        private GrabCollisionDetectR AEIDNHLPPEB;

        private BeHuman CIHJEJLGEAD;

        private CharacterStates OGIKHBGBMFI;

        private LeftPunch BMPMKKLJNAE;

        private RightPunch MBDFCIEMOEL;

        private WhatFootHitting JLBGHMEINHD;

        private WhatFootHitting PDBOMFMLIAJ;

        private HeadPunch NBBOKPILIEA;

        internal readonly Dictionary<GameObject, CharacterDamage> IFEGFIOLHFC = new Dictionary<GameObject, CharacterDamage>();

        private JOCBIJDFNNC PBBDEBBIHDA;

        private HitEffectController EAKKGECDBMD;

        private PhysicCharacterController.AccelerationCalculator JKEKKHKGEFO;

        private PhysicCharacterController.AccelerationCalculator FAJMFJHDLFK;

        private PhysicCharacterController.AccelerationCalculator CFKIOPKGFEJ;

        private PhysicCharacterController.AccelerationCalculator AIPMEMPGKKP;

        private PhysicCharacterController.AccelerationCalculator OJPPKAKAKNL;

        internal OFMNKKOBIKG ACLFECOOBHB;

        private PhysicCharacterController.EIALLPOGAFB CLJAOHHONIB;

        private FootCollision PHPIHFKHCIA;

        private FootCollision MIGGIEAPHHC;

        internal readonly List<CharacterElectricStates> IPLKGBDHFPP = new List<CharacterElectricStates>();


        private Rigidbody PNGFPCPBAKB;

        private Rigidbody PBJPAOCMCOB;

        private Rigidbody OHNPHEMHCIK;



        private Rigidbody FNLAAOKDOGM;

        private Rigidbody OOOEMIJHBPP;



        private Collider IGDAFDFAAEB;

        private Collider DPJMKKCKPOH;



        private PhysicCharacterController.ForwardDirCalculator IJOCNCFAGEI = new PhysicCharacterController.ForwardDirCalculator();

        private PhysicCharacterController.HipVelocityCalculator ODGICNHJICA = new PhysicCharacterController.HipVelocityCalculator();

        private ConfigurableJoint DOJODLHGFMG;

        private ConfigurableJoint IHGJBNOCBCJ;

        private ConfigurableJoint BAKLJKPPMPL;

        private ConfigurableJoint GFEIBKNKFKE;

        private ConfigurableJoint OLPJPLDCHJH;

        private ConfigurableJoint NFNBPODLMEM;

        private ConfigurableJoint COMMNEFOBBK;

        private ConfigurableJoint GDHLIECNHCO;

        private ConfigurableJoint IAIPIJEPFHA;

        private ConfigurableJoint FGKEDENNKHC;

        private ConfigurableJoint DHKMNFLKPFE;

        private List<ConfigurableJoint> LAJOGOOAKNM = new List<ConfigurableJoint>();

        private readonly Dictionary<ConfigurableJoint, PhysicCharacterController.GIPGCNNPFLG> OAKFIKADEBH = new Dictionary<ConfigurableJoint, PhysicCharacterController.GIPGCNNPFLG>();

        private RaycastHit[] AIJPCFMOEGH = new RaycastHit[10];

        private RaycastHit[] MIKDPIDKDPK = new RaycastHit[10];

        public bool WeaponGrabbed;

        private WeaponType EEPEJFBMHKE;

        private string NIOCJDPHNIE;

        private GameObject IFIPELILPDN;

        private Weapon HIHEJAFGJEL;

        private bool AELMKKAPJNG;

        private bool GBKFKAIOCBN;

        private readonly JointDrive KILOKABBDKH = new JointDrive
        {
            positionSpring = 10f,
            positionDamper = 1.5f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive FPLHHMPMIMJ = new JointDrive
        {
            positionSpring = 40f,
            positionDamper = 1.5f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive KEADHDBLMLG = new JointDrive
        {
            positionSpring = 40f,
            positionDamper = 1.5f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive IABAHICNNPO = new JointDrive
        {
            positionSpring = 5f,
            positionDamper = 1.5f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive NLAAEAKMEFD = new JointDrive
        {
            positionSpring = 0f,
            positionDamper = 1.5f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive OGMCJCEAOEM = new JointDrive
        {
            positionSpring = 20f,
            positionDamper = 1.5f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive CCHEBKBMNPH = new JointDrive
        {
            positionSpring = 10f,
            positionDamper = 1.5f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive MOLMFCJEFAB = new JointDrive
        {
            positionSpring = 1500f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive DAHADNIGFDE = new JointDrive
        {
            positionSpring = 1500f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive BGGDADPHDGG = new JointDrive
        {
            positionSpring = 200f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive KJFLMGDEDEJ = new JointDrive
        {
            positionSpring = 200f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive KCGNIOMNMEL = new JointDrive
        {
            positionSpring = 800f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private bool FPEOKBDFNJK;

        private bool KJCJPIKABAE;

        private bool OGMGDHLILIH;

        private bool NJDCACDNBEG;

        private float EDJLBHKJCHH;

        private bool MKBCAPJLPGK;

        private readonly Quaternion KPNJEECKIFM = new Quaternion(-0.19f, 0f, 0f, 1f).normalized;

        private readonly Quaternion CHBNEPHDEGJ = new Quaternion(-0.23f, 0f, 0f, 1f).normalized;

        private readonly Quaternion JMHOGMFBHJP = new Quaternion(0.8f, -1f, 0f, 1f).normalized;

        private readonly Quaternion OHFFDMLPLEM = new Quaternion(0.8f, 1f, 0f, 1f).normalized;

        private readonly Quaternion KOOMLBOIBJH = new Quaternion(0.38f, 0f, 0f, 1f).normalized;

        private JointDrive ELHAIPPBOAH;

        private JointDrive NDNHNADJLEK;

        private bool ELHCIONLLJD;

        private PhysicCharacterController.NCIFEHEBIAE IHBPLAMNFNK;

        private bool BDAGGEGBLBL;

        private bool BONLNLPKFPD;

        private bool LLNDLPJHINF;

        private float ILOLBDAFLIG = -0.1f;

        private float DGCOKMPGMID = 0.25f;

        private float HOIPBBIDICL = 0.75f;

        private readonly Quaternion ACPCHEEHMDH = new Quaternion(0.6f, 0f, 0f, 1f).normalized;

        private readonly Quaternion ECCFHINAFOH = new Quaternion(0.08f, 0f, 0f, 1f).normalized;

        private readonly Quaternion EEKPPPJLCEO = new Quaternion(-0.9f, 0f, 0f, 1f).normalized;

        private readonly Quaternion KBKLKLAGDDP = new Quaternion(-0.16f, 0f, 0f, 1f).normalized;

        private readonly JointDrive DHPMMAFKPMH = new JointDrive
        {
            positionSpring = 400f,
            positionDamper = 10f,
            maximumForce = 99999f
        };


        private readonly JointDrive MPNODMMENFE = new JointDrive
        {
            positionSpring = 400f,
            positionDamper = 10f,
            maximumForce = 99999f
        };

        private readonly JointDrive NBAKBFNGPKO = new JointDrive
        {
            positionSpring = 300f,
            positionDamper = 5f,
            maximumForce = 99999f
        };

        private readonly Quaternion LIOFJHOJKDO = new Quaternion(0.5f, 0f, 0f, 1f).normalized;

        private readonly Quaternion OJHJBONHDMD = new Quaternion(-0.5f, 0f, 0f, 1f).normalized;

        private readonly Quaternion IOFIHBBBGPF = new Quaternion(-0.2f, 0f, 0f, 1f).normalized;

        private readonly Quaternion OKJFOJNEBOH = new Quaternion(-0.16f, 0f, 0f, 1f).normalized;

        private readonly JointDrive CBNJEHGMMKB = new JointDrive
        {
            positionSpring = 5f,
            positionDamper = 0.2f,
            maximumForce = float.MaxValue
        };

        private float HNMHPFNKMCH;

        private float GANGDOANODH;

        private JointDrive HJDAKIBFMEF = new JointDrive
        {
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive IIEGJJOBMII = new JointDrive
        {
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive IOADMBKOGKJ = new JointDrive
        {
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private JointDrive JMKHOADKIFA = new JointDrive
        {
            positionDamper = 5f,
            maximumForce = float.MaxValue
        };

        private readonly Vector3 LNAEKEHFNDD = new Vector3(-10f, 0f, 0f);

        private readonly JointDrive OJEFBNIKEBI = new JointDrive
        {
            positionSpring = 50f,
            positionDamper = 2f,
            maximumForce = float.MaxValue
        };

        private readonly Vector3 KEGHEKHOBKK = new Vector3(-22.62f, 0f, 0f);

        private readonly JointDrive MOJEILEBGGO = new JointDrive
        {
            positionSpring = 200f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private readonly Vector3 DAKDIPJJGID = new Vector3(-5.73f, 0f, 0f);

        private readonly JointDrive ANJACNADFBJ = new JointDrive
        {
            positionSpring = 200f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive EJFBHPHMPJB = new JointDrive
        {
            positionSpring = 30f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive MNBGCMDNLON = new JointDrive
        {
            positionSpring = 20f,
            positionDamper = 0.05f,
            maximumForce = float.MaxValue
        };

        private Vector3 EGFHFCABBBF = Vector3.zero;

        private Vector3 MFPCEDHLBNC = Vector3.zero;

        private Vector3 ANFLGMAIJHA = Vector3.zero;

        private readonly Quaternion HNBKMCDLJID = new Quaternion(0.6f, 0f, 0f, 1f).normalized;

        private Vector3 EDMNPCAFABI = Vector3.zero;

        private readonly Quaternion NBOOCEDLMCC = new Quaternion(0.6f, 0f, 0f, 1f).normalized;

        private readonly JointDrive GPIOMABKHCE = new JointDrive
        {
            positionSpring = 160f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive CICEEOCCJPA = new JointDrive
        {
            positionSpring = 1f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private JointDrive HLIMINHPIFI = new JointDrive
        {
            positionSpring = 0.25f,
            positionDamper = 1f,
            maximumForce = float.MaxValue
        };

        private readonly Quaternion ONFPEEHDCLH = Quaternion.Euler(30f, 0f, 0f);

        private readonly JointDrive LAKFKLDLCGH = new JointDrive
        {
            positionSpring = 1200f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive BDHCJONLELO = new JointDrive
        {
            positionSpring = 1200f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private readonly JointDrive MMLBGFBJBLK = new JointDrive
        {
            positionSpring = 300f,
            positionDamper = 0.1f,
            maximumForce = float.MaxValue
        };

        private Vector3 HKGBHCGOOKE = Vector3.left;

        private Vector3 LOHHEFLPHEG;

        private float APHMJJFHIOH;

        private readonly List<Vector3> BIBOMEKOKPO = new List<Vector3>
    {
        new Vector3(0f, -0.03f, 0.73f),
        new Vector3(0f, -0.01f, 0.57f),
        new Vector3(0f, 0f, 0.26f),
        new Vector3(0f, 0f, 0f),
        new Vector3(-0.21f, -0.03f, -0.25f),
        new Vector3(-0.21f, 0.01f, -0.41f),
        new Vector3(0.21f, -0.04f, -0.25f),
        new Vector3(0.22f, -0.02f, -0.42f),
        new Vector3(-0.32f, -0.02f, 0.45f),
        new Vector3(0.32f, 0f, 0.45f),
        new Vector3(-0.4f, -0.01f, 0.19f),
        new Vector3(0.4f, 0.02f, 0.19f),
        new Vector3(-0.52f, -0.02f, -0.2f),
        new Vector3(0.52f, 0.02f, -0.2f)
    };

        private readonly List<Quaternion> LGLBILCBALG = new List<Quaternion>
    {
        new Quaternion(0.1427201f, 0.003053008f, 0.01808788f, 0.9895931f),
        new Quaternion(0.03101331f, 0.001024894f, 0.01909814f, 0.9993361f),
        new Quaternion(0.009882429f, 0.000390083f, 0.005223359f, 0.9999375f),
        new Quaternion(0f, 0f, 0f, 1f),
        new Quaternion(-0.07280553f, 0.01050945f, 0.0006612034f, 0.9972907f),
        new Quaternion(0.1238042f, 0.01254806f, -0.001471769f, 0.9922263f),
        new Quaternion(-0.0992854f, -0.01180073f, -0.0003829877f, 0.9949891f),
        new Quaternion(0.06299008f, -0.01377635f, 0.001474335f, 0.9979181f),
        new Quaternion(0.0215707f, 0.1512487f, 0.02532194f, 0.987936f),
        new Quaternion(0.02558275f, -0.1496424f, 0.01160839f, 0.9883411f),
        new Quaternion(-0.009916108f, 0.1503485f, -0.006669835f, 0.9885609f),
        new Quaternion(-0.01736495f, -0.1489534f, 0.1281585f, 0.9803504f),
        new Quaternion(-0.006669835f, -0.9885609f, 0.009916108f, 0.1503485f),
        new Quaternion(-0.01736495f, -0.1489534f, 0.1281585f, 0.9803504f)
    };

        private bool GFBJKJCFBBA;

        private readonly HashSet<PhysicCharacterController.IJumpCallback> BMJPOHNPEIC = new HashSet<PhysicCharacterController.IJumpCallback>();

        private readonly HashSet<PhysicCharacterController.IBareHandHitCallback> FJJEIJOMPGG = new HashSet<PhysicCharacterController.IBareHandHitCallback>();

        private HashSet<PhysicCharacterController.IAttackStateChangeCallback> ACNBMIMLKKD = new HashSet<PhysicCharacterController.IAttackStateChangeCallback>();

        public interface IWeaponStateChangeCallbacks
        {
            void OnWeaponTypeChanged(WeaponType AMENLCHAJKB, WeaponType BLIPKEIJECP);

            void OnWeaponPropertyChanged(string JONBNNGDFMN, string KPEDFIGEBKO);
        }

        public interface IHitSomeoneCallback
        {
            void OnHitSomeone(PhysicCharacterController FLPIPBCIIHB);
        }

        public interface IKillSomeoneCallback
        {
            void OnKillSomeone(PhysicCharacterController BMNCBLHAOJK);
        }

        public interface ILeftHandGrabSomeoneCallback
        {
            void OnLeftHandGrabSomeone(PhysicCharacterController IIMKKJJAFMA);
        }

        public interface IRightHandGrabSomeoneCallback
        {
            void OnRightHandGrabSomeone(PhysicCharacterController IIMKKJJAFMA);
        }

        public interface IGrabSomeoneCallback
        {
            void OnGrabSomeone(PhysicCharacterController IIMKKJJAFMA);
        }

        public interface IBothHandsReleaseCharacterCallback
        {
            void OnBothHandsReleaseCharacter(PhysicCharacterController MCFOLNMFCPN);
        }

        public interface IOnLeftHandReleaseCallback
        {
            void OnLeftHandRelease();
        }

        public interface IOnRightHandReleaseCallback
        {
            void OnRightHandRelease();
        }

        [Serializable]
        private struct ConfigurableJointAndJointStateManager
        {
            public ConfigurableJoint configurableJoint;

            [HideInInspector]
            public JointStateManager2 JointStateManager;
        }

        public enum CharacterBasicState
        {
            Unconcious,
            Normal
        }

        internal enum MEPJPNCLOFD
        {
            Standing,
            Walking,
            Jumping,
            Rolling
        }

        internal enum AKDGAGJFAOJ
        {
            Nothing,
            Punching,
            Grabbing,
            GrabbingWeapon,
            PowerPunching
        }

        public interface ICharacterBasicStateChangedCallback
        {
            void OnCharacterBasicStateChanged(PhysicCharacterController.CharacterBasicState HABLGBGBIPB);
        }

        internal enum CNOEKKHHKDN
        {
            LeftPunch,
            RightPunch
        }

        internal enum JJOGBBDFHDL
        {
            LeftKick,
            RightKick
        }

        private class GIPGCNNPFLG
        {
            public Transform myTransform;

            public Transform connectedTransform;

            public Quaternion virtualCoordLocalRot2ConnectedTranform;

            public Quaternion myTransformLocalRot2VirtualObj;
        }

        private class NCIFEHEBIAE
        {
            public void AddVector(Vector3 IEHMEJGAFHJ)
            {
                this.PLMGJIBHGPN = true;
                this.BJKJNOOEGKF[this.EIHPGBINDEN] = IEHMEJGAFHJ;
                this.DHMIKPPMGFL = this.EIHPGBINDEN;
                if (this.EIHPGBINDEN < this.BJKJNOOEGKF.Length - 1)
                {
                    this.EIHPGBINDEN++;
                    return;
                }
                this.EIHPGBINDEN = 0;
            }



            public Vector3 GetFilteredVector()
            {
                if (this.PLMGJIBHGPN)
                {
                    this.PLMGJIBHGPN = false;
                    int num = this.DHMIKPPMGFL;
                    int num2 = num - 1;
                    if (num2 < 0)
                    {
                        num2 = this.BJKJNOOEGKF.Length - 1;
                    }
                    for (int i = 0; i < this.BJKJNOOEGKF.Length; i++)
                    {
                        this.IKLMBKNDJMF = this.BJKJNOOEGKF[num];
                        if (this.BJKJNOOEGKF[num].magnitude > this.BJKJNOOEGKF[num2].magnitude)
                        {
                            break;
                        }
                        num--;
                        if (num < 0)
                        {
                            num = this.BJKJNOOEGKF.Length - 1;
                        }
                        num2 = num - 1;
                        if (num2 < 0)
                        {
                            num2 = this.BJKJNOOEGKF.Length - 1;
                        }
                    }
                    for (int j = 0; j < this.BJKJNOOEGKF.Length; j++)
                    {
                        this.BJKJNOOEGKF[j] = Vector3.zero;
                    }
                }
                return this.IKLMBKNDJMF;
            }


            private Vector3[] BJKJNOOEGKF = new Vector3[5];

            private int EIHPGBINDEN;

            private int DHMIKPPMGFL;

            private bool PLMGJIBHGPN;

            private Vector3 IKLMBKNDJMF = Vector3.zero;
        }

        private class EIALLPOGAFB
        {
            public void CharacterThrowing(Rigidbody NFCEAANBJPK, Rigidbody BAJDDIDAFPN, Vector3 FGOAFPMJOLN, float IPJNFOFMGAG)
            {
                if (this.isThrowingSth || NFCEAANBJPK == null || BAJDDIDAFPN == null)
                {
                    return;
                }
                this.MCFOLNMFCPN.StartCoroutine(this.HCNMAELBDPA(IPJNFOFMGAG));
                float num = Mathf.Lerp(0.3f, 1f, Mathf.Clamp01(IPJNFOFMGAG));
                if (NFCEAANBJPK.gameObject.layer == 8 && BAJDDIDAFPN.gameObject.layer == 8)
                {
                    Vector3 vector = num * 73f * FGOAFPMJOLN;
                    NFCEAANBJPK.AddForceAtPosition(vector, this.MCFOLNMFCPN.LNDDLJMNLBD.transform.position, ForceMode.Impulse);
                    BAJDDIDAFPN.AddForceAtPosition(vector, this.MCFOLNMFCPN.PIMHHNKOCBE.transform.position, ForceMode.Impulse);
                    this.MCFOLNMFCPN.PNGENFLDJAG.AddForce(-vector * 2f, ForceMode.Impulse);
                    return;
                }
                if (NFCEAANBJPK != BAJDDIDAFPN && !BFNMKMBJKJO.POMKGJDAIBO(NFCEAANBJPK, BAJDDIDAFPN))
                {
                    Vector3 vector2 = Vector3.ClampMagnitude(11f * NFCEAANBJPK.mass * FGOAFPMJOLN, 80f) * num;
                    Vector3 vector3 = Vector3.ClampMagnitude(11f * BAJDDIDAFPN.mass * FGOAFPMJOLN, 80f) * num;
                    NFCEAANBJPK.AddForceAtPosition(vector2, this.MCFOLNMFCPN.LNDDLJMNLBD.transform.position, ForceMode.Impulse);
                    BAJDDIDAFPN.AddForceAtPosition(vector3, this.MCFOLNMFCPN.PIMHHNKOCBE.transform.position, ForceMode.Impulse);
                    this.MCFOLNMFCPN.FIIKBADHOJH.AddForce(-(vector2 + vector3), ForceMode.Impulse);
                    ObjectBoost objectBoost;
                    if (!PBLPJECHFPJ.GBDKOCFFFDD.ContainsKey(NFCEAANBJPK.gameObject))
                    {
                        objectBoost = NFCEAANBJPK.gameObject.AddComponent<ObjectBoost>();
                    }
                    else
                    {
                        objectBoost = PBLPJECHFPJ.GBDKOCFFFDD[NFCEAANBJPK.gameObject];
                    }
                    objectBoost.MAKHHGBKEKA = this.MCFOLNMFCPN;
                    ObjectBoost objectBoost2;
                    if (!PBLPJECHFPJ.GBDKOCFFFDD.ContainsKey(BAJDDIDAFPN.gameObject))
                    {
                        objectBoost2 = BAJDDIDAFPN.gameObject.AddComponent<ObjectBoost>();
                    }
                    else
                    {
                        objectBoost2 = PBLPJECHFPJ.GBDKOCFFFDD[BAJDDIDAFPN.gameObject];
                    }
                    objectBoost2.MAKHHGBKEKA = this.MCFOLNMFCPN;
                    return;
                }
                float num2 = BFNMKMBJKJO.NMMLAMPAMMC(NFCEAANBJPK);
                Vector3 position = (this.MCFOLNMFCPN.LNDDLJMNLBD.transform.position + this.MCFOLNMFCPN.PIMHHNKOCBE.transform.position) * 0.5f;
                Vector3 vector4 = Vector3.ClampMagnitude(11f * num2 * FGOAFPMJOLN, 160f) * num;
                NFCEAANBJPK.AddForceAtPosition(vector4, position, ForceMode.Impulse);
                this.MCFOLNMFCPN.FIIKBADHOJH.AddForce(-vector4, ForceMode.Impulse);
                ObjectBoost objectBoost3;
                if (!PBLPJECHFPJ.GBDKOCFFFDD.ContainsKey(NFCEAANBJPK.gameObject))
                {
                    objectBoost3 = NFCEAANBJPK.gameObject.AddComponent<ObjectBoost>();
                }
                else
                {
                    objectBoost3 = PBLPJECHFPJ.GBDKOCFFFDD[NFCEAANBJPK.gameObject];
                }
                objectBoost3.MAKHHGBKEKA = this.MCFOLNMFCPN;
            }

            public bool isThrowingSth { get; private set; }












            public void CharacterReadyToThrow(float LHMDEBPMNEJ)
            {
                float t = Mathf.SmoothStep(0f, 1f, LHMDEBPMNEJ / 1f);
                this.CPFMKOJPNDO.positionSpring = Mathf.Lerp(this.CDLDBNOIBJM, 1000f, t);
                this.CGBCGBKMHAH.positionSpring = Mathf.Lerp(this.HDNICIEEIJC, 1000f, t);
                this.EHNFLKGFGEE.positionSpring = Mathf.Lerp(this.HBJONGEJBJD, 800f, t);
                this.AGKFPBHLOJE.positionSpring = Mathf.Lerp(this.GLPAONCAPJE, 800f, t);
                this.EJKEHGCGKMG.positionSpring = Mathf.Lerp(this.KMCDEGHMGCC, 250f, t);
                PhysicCharacterController.EIALLPOGAFB.FPJBKENNAKM(this.GAAOLDDGHLK, this.CPFMKOJPNDO, Quaternion.Slerp(this.DOLBPBGHFMN, this.GMLCPNPLHFM, t));
                PhysicCharacterController.EIALLPOGAFB.FPJBKENNAKM(this.HHEBPGKFJJL, this.CGBCGBKMHAH, Quaternion.Slerp(this.NGADCNKPLCN, this.KGGFNNKPNOG, t));
                PhysicCharacterController.EIALLPOGAFB.FPJBKENNAKM(this.AIFFNLKPDBF, this.EHNFLKGFGEE, Quaternion.Slerp(this.KADEDNNOEGL, this.BELFKFAIEGP, t));
                PhysicCharacterController.EIALLPOGAFB.FPJBKENNAKM(this.NEBPCLBAFGA, this.AGKFPBHLOJE, Quaternion.Slerp(this.CPJIHCOCONN, this.MGEKJMDBEKP, t));
                PhysicCharacterController.EIALLPOGAFB.FPJBKENNAKM(this.PAIJAFHPNCI, this.EJKEHGCGKMG, Quaternion.Slerp(this.NHJHJCNJCCJ, this.EMAJENOAPLF, t));
            }


            public EIALLPOGAFB(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, PhysicCharacterController KPLKMDDKCML)
            {
                this.GAAOLDDGHLK = ALLICKLAKDB;
                this.HHEBPGKFJJL = NHNILCHENEH;
                this.AIFFNLKPDBF = ALEGOOOGBOJ;
                this.NEBPCLBAFGA = POCAHMPKOOK;
                this.PAIJAFHPNCI = AJBEMNONLMC;
                this.MCFOLNMFCPN = KPLKMDDKCML;
            }


            public bool cannotGrab { get; private set; }


            private IEnumerator HCNMAELBDPA(float IPJNFOFMGAG)
            {
                this.isThrowingSth = true;
                this.cannotGrab = true;
                this.SetThrowInitialRotationsAndSprings();
                float num4 = Mathf.Lerp(0.3f, 1f, Mathf.Clamp01(IPJNFOFMGAG));
                //a = 1000f * num4;
                //a2 = 500f * num4;
                //num2 = 0.03f;
                //num3 = 0f;
                //while (num3 < num2)
                //{
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num3 += Time.fixedDeltaTime;
                    //float t = Mathf.SmoothStep(0f, 1f, num3 / num2);
                    //this.FHEFDCBMDGE.positionSpring = Mathf.Lerp(a, 0f, t);
                    //this.JBINEDOHAHD.positionSpring = Mathf.Lerp(a, 0f, t);
                    //this.AJAPGOAEGHE.positionSpring = Mathf.Lerp(a2, 0f, t);
                    //this.JNNJIJLNOGA.positionSpring = Mathf.Lerp(a2, 0f, t);
                    PhysicCharacterController.EIALLPOGAFB.FPJBKENNAKM(this.GAAOLDDGHLK, this.FHEFDCBMDGE, this.DEFAPKEALOC);
                    PhysicCharacterController.EIALLPOGAFB.FPJBKENNAKM(this.HHEBPGKFJJL, this.JBINEDOHAHD, this.HJKOJHFLHMC);
                    PhysicCharacterController.EIALLPOGAFB.FPJBKENNAKM(this.AIFFNLKPDBF, this.AJAPGOAEGHE, this.KAKHAIGHAIP);
                    PhysicCharacterController.EIALLPOGAFB.FPJBKENNAKM(this.NEBPCLBAFGA, this.JNNJIJLNOGA, this.CCOJKKNOPAH);
                }
                yield return this.waitForFixedUpdate;
                //}
                //num3 = 0.4f;
                //while (num3 > 0f)
                //{
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    //num3 -= Time.fixedDeltaTime;
                }
                yield return this.waitForFixedUpdate;
                //}
                this.isThrowingSth = false;
                //num3 = 0.2f;
                //while (num3 > 0f)
                //{
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    // num3 -= Time.fixedDeltaTime;
                }
                yield return this.waitForFixedUpdate;
                //}
                this.cannotGrab = false;
                yield break;
            }


            public void SetThrowInitialRotationsAndSprings()
            {
                this.DOLBPBGHFMN = this.GAAOLDDGHLK.targetRotation;
                this.NGADCNKPLCN = this.HHEBPGKFJJL.targetRotation;
                this.KADEDNNOEGL = this.AIFFNLKPDBF.targetRotation;
                this.CPJIHCOCONN = this.NEBPCLBAFGA.targetRotation;
                this.NHJHJCNJCCJ = this.PAIJAFHPNCI.targetRotation;
                this.CDLDBNOIBJM = this.GAAOLDDGHLK.angularXDrive.positionSpring;
                this.HDNICIEEIJC = this.HHEBPGKFJJL.angularXDrive.positionSpring;
                this.HBJONGEJBJD = this.AIFFNLKPDBF.angularXDrive.positionSpring;
                this.GLPAONCAPJE = this.NEBPCLBAFGA.angularXDrive.positionSpring;
                this.KMCDEGHMGCC = this.PAIJAFHPNCI.angularXDrive.positionSpring;
            }


            private static void FPJBKENNAKM(ConfigurableJoint DEIMKLMOEKJ, JointDrive OOOABHLNKLE, Quaternion OBBHADEMJNK)
            {
                DEIMKLMOEKJ.angularXDrive = OOOABHLNKLE;
                DEIMKLMOEKJ.angularYZDrive = OOOABHLNKLE;
                DEIMKLMOEKJ.targetRotation = OBBHADEMJNK;
            }


            public bool isReadyToThrowSth;

            public float readyToThrowStartTime;

            public float readyToThrowDuration;

            private ConfigurableJoint GAAOLDDGHLK;

            private ConfigurableJoint HHEBPGKFJJL;

            private ConfigurableJoint AIFFNLKPDBF;

            private ConfigurableJoint NEBPCLBAFGA;

            private ConfigurableJoint PAIJAFHPNCI;

            private PhysicCharacterController MCFOLNMFCPN;

            private Quaternion GMLCPNPLHFM = Quaternion.Euler(new Vector3(21.4f, -32.81f, -20f));

            private Quaternion KGGFNNKPNOG = Quaternion.Euler(new Vector3(21.4f, 32.81f, 20f));

            private Quaternion BELFKFAIEGP = Quaternion.Euler(new Vector3(127.5f, 0f, 0f));

            private Quaternion MGEKJMDBEKP = Quaternion.Euler(new Vector3(127.5f, 0f, 0f));

            private Quaternion EMAJENOAPLF = Quaternion.Euler(new Vector3(-20f, 0f, 0f));

            private Quaternion DEFAPKEALOC = Quaternion.Euler(new Vector3(95f, 0f, -20f));

            private Quaternion HJKOJHFLHMC = Quaternion.Euler(new Vector3(95f, 0f, 20f));

            private Quaternion KAKHAIGHAIP = Quaternion.Euler(new Vector3(13f, 0f, 0f));

            private Quaternion CCOJKKNOPAH = Quaternion.Euler(new Vector3(13f, 0f, 0f));

            private Quaternion DOLBPBGHFMN;

            private Quaternion NGADCNKPLCN;

            private Quaternion KADEDNNOEGL;

            private Quaternion CPJIHCOCONN;

            private Quaternion NHJHJCNJCCJ;

            private JointDrive CPFMKOJPNDO = new JointDrive
            {
                positionDamper = 5f,
                maximumForce = float.MaxValue
            };

            private JointDrive CGBCGBKMHAH = new JointDrive
            {
                positionDamper = 5f,
                maximumForce = float.MaxValue
            };

            private JointDrive EHNFLKGFGEE = new JointDrive
            {
                positionDamper = 3f,
                maximumForce = float.MaxValue
            };

            private JointDrive AGKFPBHLOJE = new JointDrive
            {
                positionDamper = 3f,
                maximumForce = float.MaxValue
            };

            private JointDrive EJKEHGCGKMG = new JointDrive
            {
                positionDamper = 3f,
                maximumForce = float.MaxValue
            };

            private JointDrive FHEFDCBMDGE = new JointDrive
            {
                positionDamper = 0.2f,
                maximumForce = float.MaxValue
            };

            private JointDrive JBINEDOHAHD = new JointDrive
            {
                positionDamper = 0.2f,
                maximumForce = float.MaxValue
            };

            private JointDrive AJAPGOAEGHE = new JointDrive
            {
                positionDamper = 0.2f,
                maximumForce = float.MaxValue
            };

            private JointDrive JNNJIJLNOGA = new JointDrive
            {
                positionDamper = 0.2f,
                maximumForce = float.MaxValue
            };

            private float CDLDBNOIBJM;

            private float HDNICIEEIJC;

            private float HBJONGEJBJD;

            private float GLPAONCAPJE;

            private float KMCDEGHMGCC;

            private readonly WaitForFixedUpdate waitForFixedUpdate = new WaitForFixedUpdate();
        }

        private class ForwardDirCalculator
        {

            public void CalculateForwardDir(ref Vector3 LGAMMAIJCOJ, Transform ELDPMCGDHKJ, Transform GHKDFNOINDC, Transform EIJAPLDDFEM)
            {
                this.gravityForce -= this.groundCheckRayLength[this.groundedCheckOffset];
                this.groundCheckRayLength[this.groundedCheckOffset] = -ELDPMCGDHKJ.up;
                this.gravityForce += this.groundCheckRayLength[this.groundedCheckOffset];
                Vector3 a = Vector3.zero;
                Vector3 normalized = this.gravityForce.normalized;
                foreach (Vector3 vector in this.groundCheckRayLength)
                {
                    if (Vector3.Dot(normalized, vector) > 0.98f)
                    {
                        a += vector;
                    }
                }
                a = a.normalized;
                this.jumpForce -= this.maxSlopeAngle[this.groundedCheckOffset];
                this.maxSlopeAngle[this.groundedCheckOffset] = -GHKDFNOINDC.up;
                this.jumpForce += this.maxSlopeAngle[this.groundedCheckOffset];
                Vector3 vector2 = Vector3.zero;
                Vector3 normalized2 = this.jumpForce.normalized;
                foreach (Vector3 vector3 in this.maxSlopeAngle)
                {
                    if (Vector3.Dot(normalized2, vector3) > 0.98f)
                    {
                        vector2 += vector3;
                    }
                }
                vector2 = vector2.normalized;
                this.airControlFactor -= this.movementSpeed[this.groundedCheckOffset];
                this.movementSpeed[this.groundedCheckOffset] = -EIJAPLDDFEM.up;
                this.airControlFactor += this.movementSpeed[this.groundedCheckOffset];
                Vector3 vector4 = Vector3.zero;
                Vector3 normalized3 = this.airControlFactor.normalized;
                foreach (Vector3 vector5 in this.movementSpeed)
                {
                    if (Vector3.Dot(normalized3, vector5) > 0.98f)
                    {
                        vector4 += vector5;
                    }
                }
                vector4 = vector4.normalized;
                this.fallVelocityMultiplier -= this.characterMass[this.slopeCheckDistance];
                this.characterMass[this.slopeCheckDistance] = (a + vector2 + vector4).normalized;
                this.fallVelocityMultiplier += this.characterMass[this.slopeCheckDistance];
                Vector3 a2 = Vector3.zero;
                Vector3 normalized4 = this.fallVelocityMultiplier.normalized;
                foreach (Vector3 vector6 in this.characterMass)
                {
                    if (Vector3.Dot(normalized4, vector6) > 0.98f)
                    {
                        a2 += vector6;
                    }
                }
                LGAMMAIJCOJ = a2.normalized;
                if (this.groundedCheckOffset < 29)
                {
                    this.groundedCheckOffset++;
                }
                else
                {
                    this.groundedCheckOffset = 0;
                }
                if (this.slopeCheckDistance < 9)
                {
                    this.slopeCheckDistance++;
                    return;
                }
                this.slopeCheckDistance = 0;
            }


            private readonly Vector3[] groundCheckRayLength = new Vector3[30];

            private Vector3 gravityForce = Vector3.zero;

            private readonly Vector3[] maxSlopeAngle = new Vector3[30];

            private Vector3 jumpForce = Vector3.zero;

            private readonly Vector3[] movementSpeed = new Vector3[30];

            private Vector3 airControlFactor = Vector3.zero;

            private int groundedCheckOffset;

            private int slopeCheckDistance;

            private readonly Vector3[] characterMass = new Vector3[10];

            private Vector3 fallVelocityMultiplier = Vector3.zero;
        }

        private class HipVelocityCalculator
        {


            public void CalculateHipVelocity(Rigidbody hipRigidbody, ref Vector3 averageVelocity)
            {
                this.velocityHistory[this.historyIndex] = hipRigidbody.velocity;
                foreach (Vector3 b in this.velocityHistory)
                {
                    averageVelocity += b;
                }
                averageVelocity *= 0.0476f;
                if (this.historyIndex < 19)
                {
                    this.historyIndex++;
                    return;
                }
                this.historyIndex = 0;
            }





            private readonly Vector3[] velocityHistory = new Vector3[20];

            private int historyIndex;
        }

        private class AccelerationCalculator
        {
            public void CalculateAcceleration(out Vector3 calculatedAcceleration)
            {
                Vector3 velocity = this.rigidbody.velocity;
                calculatedAcceleration = (velocity - this.previousVelocity) / Time.fixedDeltaTime;
                this.previousVelocity = velocity;
            }


            public AccelerationCalculator(Rigidbody targetRigidbody)
            {
                this.rigidbody = targetRigidbody;
            }


            private Vector3 previousVelocity;

            private Rigidbody rigidbody;
        }

        public interface IJumpCallback
        {
            void OnJump(PhysicCharacterController physicCharacterController);
        }

        public interface IBareHandHitCallback
        {
            void BareHandAttack(float attackForce, bool isCritical, PhysicCharacterController.AttackType attackType, GameObject targetObject);
        }

        public enum AttackType
        {
            Headbutt,
            LeftPunch,
            RightPunch,
            HeavyPunch,
            LeftKick,
            RightKick,
            LeftFlyKick,
            RightFlyKick,
            Roll
        }

        public interface IAttackStateChangeCallback
        {
            void OnAttackStateChange(bool isAttacking, PhysicCharacterController.AttackType attackType, Rigidbody attackRigidbody);
        }
    }
}