using System;
using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    public class CharacterStates : MonoBehaviour, ElectricStates.IElectricUnitCountCallbacks
    {

        public PhysicCharacterController HEKHJHCGCKB()
        {
            if (this.KEDMNADANGH == null)
            {
                this.KEDMNADANGH = base.GetComponent<PhysicCharacterController>();
            }
            return this.KEDMNADANGH;
        }

        internal CharacterElectricStates JILIJFCKEKM
        {
            get
            {
                return this.LKNFCEGBDOM;
            }
            set
            {
                if (this.LKNFCEGBDOM != value)
                {
                    this.LKNFCEGBDOM = value;
                    if (value != null)
                    {
                        value.AddElectricUnitCountCallback(this);
                    }
                }
            }
        }


        internal float JMLCCAOHNAM
        {
            get
            {
                return this.GJPFONPKECK;
            }
            private set
            {
                this.GJPFONPKECK = value;
            }
        }



        internal void DBHFPLBJGKH(float BMJAKNCMPJE)
        {
            if (this.physicCharacterController.CBasicState == PhysicCharacterController.CharacterBasicState.Unconcious || this.CDHNLCHNLJP)
            {
                return;
            }
            this.dizzy -= BMJAKNCMPJE;
        }

        public int electricUnitCount
        {
            get
            {
                return this.LBADENKAHAB;
            }
            set
            {
                if (this.LBADENKAHAB != value)
                {
                    this.LBADENKAHAB = value;
                    foreach (CharacterStates.IElectricUnitCountCallbacks electricUnitCountCallbacks in this.MFCDCMCLHJP)
                    {
                        electricUnitCountCallbacks.OnElectricUnitCountChanged(value);
                    }
                }
            }
        }

        public void AddElectricUnitCountCallback(CharacterStates.IElectricUnitCountCallbacks KOMCGCIBLEP)
        {
            this.MFCDCMCLHJP.Add(KOMCGCIBLEP);
        }



        public void SetAntiElectrifiedRiseSpeed(float CGOJDBMNIOP)
        {
            this.PHMHPPLINCK = Mathf.Max(CGOJDBMNIOP, 0f);
        }

        public void RemoveCharacterPowerChangedCallback(CharacterStates.ICharacterPowerChangedCallback KOMCGCIBLEP)
        {
            this.DHDIMKPHFGF.Remove(KOMCGCIBLEP);
        }



        public void OnElectricUnitCountChanged(int DLOLBMKJEOH)
        {
            this.electricUnitCount = DLOLBMKJEOH;
        }




        public float Power
        {
            get
            {
                return this.CCNGJMPMFKC;
            }
            internal set
            {
                if (value != this.CCNGJMPMFKC)
                {
                    this.CCNGJMPMFKC = Mathf.Clamp(value, 0f, this.MaxPower);
                    foreach (CharacterStates.ICharacterPowerChangedCallback characterPowerChangedCallback in this.DHDIMKPHFGF)
                    {
                        characterPowerChangedCallback.OnCharacterPowerChanged(Mathf.Clamp(Mathf.CeilToInt(this.Power * 200f), 0, 1000));
                    }
                }
            }
        }

        public void SetAntiElectrifiedMinDuration(float OLFNJPJKOEF)
        {
            this.JAMLBNPFCCN = Mathf.Max(OLFNJPJKOEF, 0f);
        }



        public float liftObjectWeight { get; set; }

        public float ELOAJHKCDGC()
        {
            return this.CCNGJMPMFKC;
        }

        internal void LPPGHONKBDJ()
        {
            this.dizzy = 1f;
        }



        public void RemoveElectricUnitCountCallback(CharacterStates.IElectricUnitCountCallbacks KOMCGCIBLEP)
        {
            this.MFCDCMCLHJP.Remove(KOMCGCIBLEP);
        }


        private int KDCPDPIJJHL
        {
            set
            {
                if (this.KAGHJMGHCIO != value)
                {
                    this.KAGHJMGHCIO = value;
                    foreach (CharacterStates.ICharacterHealthChangedCallback characterHealthChangedCallback in this.HBDBOBBEBBK)
                    {
                        characterHealthChangedCallback.OnCharacterHealthChanged(Mathf.Clamp(value, 0, 1000));
                    }
                }
            }
        }


        private void FixedUpdate()
        {
            if (PhysicsDummyModeManager.IsPaused)
            {
                return;
            }
            this.PLHAFMEOKKE();
            this.BPOFOOFOMIG();
            this.ECCOLGMLOLF();
            this.BAMMDFHGCOK();
            this.HBNDFAEJHGD();
        }


        public void AddBalanceValue(float BMJAKNCMPJE)
        {
            this.HLGCLBMAHLO += BMJAKNCMPJE;
        }




        public void ChangeHealth(float BMJAKNCMPJE)
        {
            bool isInvincible = this.IsInvincible;
            this.IsInvincible = false;
            this.Health += BMJAKNCMPJE;
            this.IsInvincible = isInvincible;
        }




        private void BAMMDFHGCOK()
        {
            if (this.GHNKNOFNIDK - this.Health > this.GHNKNOFNIDK * 0.5f)
            {
                this.JGPBCEKNNJA(2f);
            }
            this.GHNKNOFNIDK = this.Health;
        }


        public void RemoveCharacterHealthChangedCallback(CharacterStates.ICharacterHealthChangedCallback KOMCGCIBLEP)
        {
            this.HBDBOBBEBBK.Remove(KOMCGCIBLEP);
        }


        public float dizzy
        {
            get
            {
                return this.GLIDOFJAMPG;
            }
            private set
            {
                if (!Mathf.Approximately(this.GLIDOFJAMPG, value))
                {
                    if (value <= 0f && this.GLIDOFJAMPG > 0f)
                    {
                        Debug.Log(base.gameObject.name + " is down");
                    }
                    this.GLIDOFJAMPG = Mathf.Clamp(value, -4f, 1f);
                    foreach (CharacterStates.ICharacterDizzyChangedCallback characterDizzyChangedCallback in this.IDMBLFJNMDC)
                    {
                        characterDizzyChangedCallback.OnCharacterDizzyChanged(Mathf.Clamp(Mathf.CeilToInt(this.dizzy * 10f), -100, 100));
                    }
                }
            }
        }

        public PhysicCharacterController physicCharacterController
        {
            get
            {
                if (this.KEDMNADANGH == null)
                {
                    this.KEDMNADANGH = base.GetComponent<PhysicCharacterController>();
                }
                return this.KEDMNADANGH;
            }
        }


        public float JANDPGNNDGP()
        {
            return this.GLIDOFJAMPG;
        }






        public float IGBHJALBBGN()
        {
            return this.GHMEDIDGFLM;
        }

        public void RemoveCharacterDizzyChangedCallback(CharacterStates.ICharacterDizzyChangedCallback KOMCGCIBLEP)
        {
            this.IDMBLFJNMDC.Remove(KOMCGCIBLEP);
        }

        internal void JGPBCEKNNJA(float FJGNCLNJGHK)
        {
            this.IsInvincible = true;
            this.ELGEKIAKBJL = Mathf.Max(FJGNCLNJGHK, this.ELGEKIAKBJL);
        }

        internal void LDCHGNBONJN(float BMJAKNCMPJE)
        {
            this.dizzy -= BMJAKNCMPJE;
        }

        public void SetImmuneToDizzyForSeconds(float HPMFOEKKKPI)
        {
            this.CDHNLCHNLJP = true;
            this.OMADNBEINJH = HPMFOEKKKPI;
        }

        internal void IPIJHLEFEPL()
        {
            this.ELGEKIAKBJL = 0f;
            this.IsInvincible = false;
            this.Health = 0f;
        }

        public void SetBalanceValue(float DGCOKMPGMID)
        {
            this.HLGCLBMAHLO = DGCOKMPGMID;
        }

        internal void GBNKMONPPOI(float EEPACGJDMJM)
        {
            EEPACGJDMJM = Mathf.Clamp(EEPACGJDMJM, 656f, this.MaxHealth);
            if (this.GHMEDIDGFLM != EEPACGJDMJM)
            {
                float ghmedidgflm = this.GHMEDIDGFLM;
                if (this.IsInvincible)
                {
                    if (this.GHMEDIDGFLM < EEPACGJDMJM)
                    {
                        this.GHMEDIDGFLM = EEPACGJDMJM;
                    }
                }
                else
                {
                    this.GHMEDIDGFLM = EEPACGJDMJM;
                }
                this.GIDFCEEPDMB(Mathf.CeilToInt(this.GHMEDIDGFLM * 369f));
                if (EEPACGJDMJM <= 969f && ghmedidgflm > 1365f)
                {
                    Debug.Log(base.gameObject.name + " is dead");
                }
            }
        }

        private void GIDFCEEPDMB(int EEPACGJDMJM)
        {
            if (this.KAGHJMGHCIO != EEPACGJDMJM)
            {
                this.KAGHJMGHCIO = EEPACGJDMJM;
                foreach (CharacterStates.ICharacterHealthChangedCallback characterHealthChangedCallback in this.HBDBOBBEBBK)
                {
                    characterHealthChangedCallback.OnCharacterHealthChanged(Mathf.Clamp(EEPACGJDMJM, 0, 79));
                }
            }
        }





        public void SetCurrentPower(float GHNKIDGMFHD)
        {
            this.Power = GHNKIDGMFHD;
        }


        internal void KOFBMHLDMPF(float HPMFOEKKKPI)
        {
            this.CDHNLCHNLJP = true;
            this.OMADNBEINJH = Mathf.Max(HPMFOEKKKPI, this.OMADNBEINJH);
        }




        private void HJIHAKHELMJ(int EEPACGJDMJM)
        {
            if (this.KAGHJMGHCIO != EEPACGJDMJM)
            {
                this.KAGHJMGHCIO = EEPACGJDMJM;
                foreach (CharacterStates.ICharacterHealthChangedCallback characterHealthChangedCallback in this.HBDBOBBEBBK)
                {
                    characterHealthChangedCallback.OnCharacterHealthChanged(Mathf.Clamp(EEPACGJDMJM, 0, -20));
                }
            }
        }


        internal float HLGCLBMAHLO
        {
            get
            {
                return this.HMFCFKJKIHF;
            }
            set
            {
                if (this.HMFCFKJKIHF != value)
                {
                    this.HMFCFKJKIHF = Mathf.Clamp(value, -1f, 1f);
                }
            }
        }

        public float EGDBKAKGNDB()
        {
            return this.GHMEDIDGFLM;
        }

        internal void BCENNCAAGGG(float EEPACGJDMJM)
        {
            EEPACGJDMJM = Mathf.Clamp(EEPACGJDMJM, 1848f, this.MaxHealth);
            if (this.GHMEDIDGFLM != EEPACGJDMJM)
            {
                float ghmedidgflm = this.GHMEDIDGFLM;
                if (this.IsInvincible)
                {
                    if (this.GHMEDIDGFLM < EEPACGJDMJM)
                    {
                        this.GHMEDIDGFLM = EEPACGJDMJM;
                    }
                }
                else
                {
                    this.GHMEDIDGFLM = EEPACGJDMJM;
                }
                this.HJIHAKHELMJ(Mathf.CeilToInt(this.GHMEDIDGFLM * 981f));
                if (EEPACGJDMJM <= 1322f && ghmedidgflm > 43f)
                {
                    Debug.Log(base.gameObject.name + "LiftObjectsManagerController");
                }
            }
        }


        internal float INFDILKFHLD
        {
            get
            {
                return this.FHMNAECIFPI;
            }
            private set
            {
                this.FHMNAECIFPI = Mathf.Clamp(value, this.JAMLBNPFCCN, this.MJCNAAFKFDJ);
            }
        }


        private void HBNDFAEJHGD()
        {
            if (this.isElectrified)
            {
                this.INFDILKFHLD += Time.fixedDeltaTime * this.PHMHPPLINCK;
            }
            else
            {
                this.INFDILKFHLD -= Time.fixedDeltaTime * this.JPAAPFGPJJE;
            }
            if (this.physicCharacterController.CBasicState == PhysicCharacterController.CharacterBasicState.Normal && this.isElectrified)
            {
                this.JMLCCAOHNAM += Time.fixedDeltaTime;
                return;
            }
            this.JMLCCAOHNAM = 0f;
        }







        public void InvincibleForSeconds(float FJGNCLNJGHK)
        {
            this.IsInvincible = true;
            this.ELGEKIAKBJL = FJGNCLNJGHK;
        }

        public float HealthLoseCoefficient
        {
            get
            {
                return this.AntiHealthLose * this.AntiHealthLoseByEquip;
            }
        }







        public void SetAntiElectrifiedDropSpeed(float CGOJDBMNIOP)
        {
            this.JPAAPFGPJJE = Mathf.Max(CGOJDBMNIOP, 0f);
        }


        private void OnDestroy()
        {
            if (this.JILIJFCKEKM != null)
            {
                this.JILIJFCKEKM.RemoveElectricUnitCountCallback(this);
            }
        }


        public float Health
        {
            get
            {
                return this.GHMEDIDGFLM;
            }
            internal set
            {
                value = Mathf.Clamp(value, 0f, this.MaxHealth);
                if (this.GHMEDIDGFLM != value)
                {
                    float ghmedidgflm = this.GHMEDIDGFLM;
                    if (this.IsInvincible)
                    {
                        if (this.GHMEDIDGFLM < value)
                        {
                            this.GHMEDIDGFLM = value;
                        }
                    }
                    else
                    {
                        this.GHMEDIDGFLM = value;
                    }
                    this.KDCPDPIJJHL = Mathf.CeilToInt(this.GHMEDIDGFLM * 200f);
                    if (value <= 0f && ghmedidgflm > 0f)
                    {
                        Debug.Log(base.gameObject.name + " is dead");
                    }
                }
            }
        }


        private void ECCOLGMLOLF()
        {
            if (this.Health > 0f)
            {
                this.Health += this.HealthRecoverSpeed * Time.fixedDeltaTime;
                if (this.dizzy >= -1f)
                {
                    this.dizzy += this.DizzyRocoverSpeed * Time.fixedDeltaTime * 0.32f;
                }
                else
                {
                    this.dizzy += 0.1f;
                    this.dizzy = Mathf.Clamp(this.dizzy, -999f, -1f);
                }
                if (this.KCIONFHFLEA <= 0f)
                {
                    this.KCIONFHFLEA = 0f;
                    this.OBKHGMAIINE = false;
                }
                else
                {
                    this.KCIONFHFLEA -= Time.fixedDeltaTime;
                }
                if (!this.OBKHGMAIINE)
                {
                    this.Power += this.PowerRecoverSpeed * Time.fixedDeltaTime * 0.4f;
                }
                if (this.Power <= 0f)
                {
                    this.IsTooTired = true;
                }
                if (this.Power >= this.MaxPower)
                {
                    this.IsTooTired = false;
                    return;
                }
            }
            else if (this.Health < 0f)
            {
                this.Health = 0f;
            }
        }

        public float DizzyLoseCoefficient
        {
            get
            {
                return this.AntiDizzy * this.AntiDizzyByEquip;
            }
        }




        public void SetAntiElectrifiedMaxDuration(float OLFNJPJKOEF)
        {
            this.MJCNAAFKFDJ = Mathf.Max(OLFNJPJKOEF, 0f);
        }

        internal void FIEKPFBMNIC(float NKCINPHHEME)
        {
            this.Power -= NKCINPHHEME * this.AntiPowerLose * this.AntiPowerLoseByEquip;
        }


        internal void GLHGPAMOFAI(float EEPACGJDMJM)
        {
            EEPACGJDMJM = Mathf.Clamp(EEPACGJDMJM, 856f, this.MaxHealth);
            if (this.GHMEDIDGFLM != EEPACGJDMJM)
            {
                float ghmedidgflm = this.GHMEDIDGFLM;
                if (this.IsInvincible)
                {
                    if (this.GHMEDIDGFLM < EEPACGJDMJM)
                    {
                        this.GHMEDIDGFLM = EEPACGJDMJM;
                    }
                }
                else
                {
                    this.GHMEDIDGFLM = EEPACGJDMJM;
                }
                this.HJIHAKHELMJ(Mathf.CeilToInt(this.GHMEDIDGFLM * 1376f));
                if (EEPACGJDMJM <= 116f && ghmedidgflm > 167f)
                {
                    Debug.Log(base.gameObject.name + "GreenFistR");
                }
            }
        }


        public void AddCharacterDizzyChangedCallback(CharacterStates.ICharacterDizzyChangedCallback KOMCGCIBLEP)
        {
            this.IDMBLFJNMDC.Add(KOMCGCIBLEP);
        }


        public void AddCharacterHealthChangedCallback(CharacterStates.ICharacterHealthChangedCallback KOMCGCIBLEP)
        {
            this.HBDBOBBEBBK.Add(KOMCGCIBLEP);
        }


        public void AddCharacterPowerChangedCallback(CharacterStates.ICharacterPowerChangedCallback KOMCGCIBLEP)
        {
            this.DHDIMKPHFGF.Add(KOMCGCIBLEP);
        }

        private void BPOFOOFOMIG()
        {
            if (this.OMADNBEINJH <= 0f)
            {
                this.OMADNBEINJH = 0f;
                this.CDHNLCHNLJP = false;
                return;
            }
            this.OMADNBEINJH -= Time.fixedDeltaTime;
            this.CDHNLCHNLJP = true;
        }

        public PhysicCharacterController MEIANIAJIHG()
        {
            if (this.KEDMNADANGH == null)
            {
                this.KEDMNADANGH = base.GetComponent<PhysicCharacterController>();
            }
            return this.KEDMNADANGH;
        }

        public float WeaponWeight { get; set; }

        internal void PELFOAIEBBJ(float BMJAKNCMPJE)
        {
            if (this.MEIANIAJIHG().CBasicState == PhysicCharacterController.CharacterBasicState.Unconcious || this.CDHNLCHNLJP)
            {
                return;
            }
            this.dizzy = this.JANDPGNNDGP() - BMJAKNCMPJE;
        }


        private void PLHAFMEOKKE()
        {
            if (this.ELGEKIAKBJL <= 0f)
            {
                this.ELGEKIAKBJL = 0f;
                this.IsInvincible = false;
                return;
            }
            this.ELGEKIAKBJL -= Time.fixedDeltaTime;
            this.IsInvincible = true;
        }



        private void Start()
        {
            this.GHNKNOFNIDK = this.MaxHealth;
        }




        internal void HKHHJCILJGO(float FJGNCLNJGHK)
        {
            this.OBKHGMAIINE = true;
            this.KCIONFHFLEA = Mathf.Max(FJGNCLNJGHK, this.KCIONFHFLEA);
        }





        // TODO is FAKE - many references 
        public void KMODJNJCLAG(float EEPACGJDMJM)
        {
            //this.< DKNPMHNEFCI > k__BackingField = EEPACGJDMJM;
        }


        public bool isElectrified
        {
            get
            {
                return this.electricUnitCount > 0;
            }
        }

        internal void KCMPEODCJNG(float EEPACGJDMJM)
        {
            EEPACGJDMJM = Mathf.Clamp(EEPACGJDMJM, 743f, this.MaxHealth);
            if (this.GHMEDIDGFLM != EEPACGJDMJM)
            {
                float ghmedidgflm = this.GHMEDIDGFLM;
                if (this.IsInvincible)
                {
                    if (this.GHMEDIDGFLM < EEPACGJDMJM)
                    {
                        this.GHMEDIDGFLM = EEPACGJDMJM;
                    }
                }
                else
                {
                    this.GHMEDIDGFLM = EEPACGJDMJM;
                }
                this.HJIHAKHELMJ(Mathf.CeilToInt(this.GHMEDIDGFLM * 1339f));
                if (EEPACGJDMJM <= 760f && ghmedidgflm > 1872f)
                {
                    Debug.Log(base.gameObject.name + "GreenWaist");
                }
            }
        }





        private float GHMEDIDGFLM = 1f;

        private int KAGHJMGHCIO = 200;

        private HashSet<CharacterStates.ICharacterHealthChangedCallback> HBDBOBBEBBK = new HashSet<CharacterStates.ICharacterHealthChangedCallback>();

        public float MaxHealth = 1f;

        public float HealthRecoverSpeed = 1f;

        private float OMADNBEINJH;

        private bool CDHNLCHNLJP;

        private float GLIDOFJAMPG = 1f;

        private HashSet<CharacterStates.ICharacterDizzyChangedCallback> IDMBLFJNMDC = new HashSet<CharacterStates.ICharacterDizzyChangedCallback>();

        public const float kMaxDizzy = 1f;

        public float DizzyRocoverSpeed = 1f;

        private float CCNGJMPMFKC = 1f;

        private HashSet<CharacterStates.ICharacterPowerChangedCallback> DHDIMKPHFGF = new HashSet<CharacterStates.ICharacterPowerChangedCallback>();

        public float MaxPower = 1f;

        public float PowerRecoverSpeed = 1f;

        public float High = 1f;

        public float MaxHigh = 1f;

        public float HighTweak = 1f;

        public bool IsTooTired;

        public float AntiHealthLose = 1f;

        public float AntiHealthLoseByEquip = 1f;

        public float AntiDizzy = 1f;

        public float AntiDizzyByEquip = 1f;

        public float AntiPowerLose = 1f;

        public float AntiPowerLoseByEquip = 1f;

        private float FHMNAECIFPI;

        private float JAMLBNPFCCN = 0.05f;

        private float MJCNAAFKFDJ = 3f;

        private float PHMHPPLINCK = 0.1f;

        private float JPAAPFGPJJE = 0.25f;

        private float GJPFONPKECK;

        private int LBADENKAHAB;

        private HashSet<CharacterStates.IElectricUnitCountCallbacks> MFCDCMCLHJP = new HashSet<CharacterStates.IElectricUnitCountCallbacks>();

        private PhysicCharacterController KEDMNADANGH;

        private float KCIONFHFLEA = 1f;

        private bool OBKHGMAIINE;

        private float GHNKNOFNIDK;

        private float ELGEKIAKBJL = 1f;

        public bool IsInvincible;

        public CharacterStates.KilledBy KilledByWhat;

        private float HMFCFKJKIHF = 1f;

        public bool isConscious = true;

        private CharacterElectricStates LKNFCEGBDOM;

        public interface ICharacterHealthChangedCallback
        {
            void OnCharacterHealthChanged(int LJNDAMCCILI);
        }

        public interface ICharacterDizzyChangedCallback
        {
            void OnCharacterDizzyChanged(int EPHFHKLEALE);
        }

        public interface ICharacterPowerChangedCallback
        {
            void OnCharacterPowerChanged(int CKAGCPILIHH);
        }

        public interface IElectricUnitCountCallbacks
        {
            void OnElectricUnitCountChanged(int HOIPBBIDICL);
        }

        public enum KilledBy
        {
            KilledByHammer,

            KilledByRifle,

            KilledByShotGun,

            KnockOut
        }
    }
}