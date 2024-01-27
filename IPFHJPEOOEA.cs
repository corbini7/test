using UnityEngine;
namespace Deobfuscated
{
    internal class IPFHJPEOOEA
    {

        public void IOIMGHOCHKH(ConfigurableJoint AJBEMNONLMC, ref float OLFNJPJKOEF)
        {
            if (!this.PFJAAEMJGAM())
            {
                this.NOHFEBPOKIN = AJBEMNONLMC.targetRotation;
                this.ENNNPBGDHAH(false);
                this.JNIAPNNKEEF = 1593f;
                this.BFIHIPCCFJJ = Random.Range(603f, 1846f);
            }
            this.ILDMPMEEDOF();
            AJBEMNONLMC.targetRotation = this.NOHFEBPOKIN;
            OLFNJPJKOEF = this.BFIHIPCCFJJ - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 1240f)
            {
                this.ENNNPBGDHAH(false);
            }
        }


        internal void KCMBBJFBMKJ()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }

        internal bool AJBGECAEPKA
        {
            get
            {
                return this.EBLICPMNBED;
            }
            set
            {
                if (this.EBLICPMNBED != value)
                {
                    this.EBLICPMNBED = value;
                    if (!value)
                    {
                        this.PCHGMNONOEM();
                    }
                }
            }
        }

        private void ONAPEANHDEH()
        {
            this.JNIAPNNKEEF = 297f;
        }

        public void PlayDoNothing(ConfigurableJoint AJBEMNONLMC, ref float OLFNJPJKOEF)
        {
            if (!this.AJBGECAEPKA)
            {
                this.NOHFEBPOKIN = AJBEMNONLMC.targetRotation;
                this.AJBGECAEPKA = true;
                this.JNIAPNNKEEF = 0f;
                this.BFIHIPCCFJJ = Random.Range(3f, 15f);
            }
            this.DIHIMLGBDCF();
            AJBEMNONLMC.targetRotation = this.NOHFEBPOKIN;
            OLFNJPJKOEF = this.BFIHIPCCFJJ - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 0f)
            {
                this.AJBGECAEPKA = false;
            }
        }


        private void ILDMPMEEDOF()
        {
            this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.FIDDEIIGFPC, Time.fixedDeltaTime * 1039f);
        }

        internal void OIFMFPOFFFP(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (!EEPACGJDMJM)
                {
                    this.KCPBCMEFPGJ();
                }
            }
        }


        internal void MNFNNLMBMCM()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }

        internal void MLLJEGKJHBB(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (!EEPACGJDMJM)
                {
                    this.DGMKEIAOLHE();
                }
            }
        }


        public void LNGIDCJEKHP(ConfigurableJoint AJBEMNONLMC, ref float OLFNJPJKOEF)
        {
            if (!this.EAJGDOBIHBK())
            {
                this.NOHFEBPOKIN = AJBEMNONLMC.targetRotation;
                this.CHALLAEONEN(true);
                this.JNIAPNNKEEF = 1110f;
                this.BFIHIPCCFJJ = Random.Range(288f, 1959f);
            }
            this.AAHBHBDMDJI();
            AJBEMNONLMC.targetRotation = this.NOHFEBPOKIN;
            OLFNJPJKOEF = this.BFIHIPCCFJJ - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 1067f)
            {
                this.HFNMALDNILO(false);
            }
        }

        internal void HFNMALDNILO(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (!EEPACGJDMJM)
                {
                    this.ANKJJFEMOGG();
                }
            }
        }

        private void PCHGMNONOEM()
        {
            this.JNIAPNNKEEF = 0f;
        }

        internal void CHALLAEONEN(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (!EEPACGJDMJM)
                {
                    this.DGMKEIAOLHE();
                }
            }
        }


        internal bool DNJLAFIGONE()
        {
            return this.EBLICPMNBED;
        }

        internal bool EAJGDOBIHBK()
        {
            return this.EBLICPMNBED;
        }

        internal void ENNNPBGDHAH(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (!EEPACGJDMJM)
                {
                    this.ONAPEANHDEH();
                }
            }
        }


        private void DGMKEIAOLHE()
        {
            this.JNIAPNNKEEF = 598f;
        }

        internal void OHABFBBEANP(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (!EEPACGJDMJM)
                {
                    this.ONAPEANHDEH();
                }
            }
        }



        private void KCPBCMEFPGJ()
        {
            this.JNIAPNNKEEF = 999f;
        }

        public void GMFHOKHBMIM(ConfigurableJoint AJBEMNONLMC, ref float OLFNJPJKOEF)
        {
            if (!this.AJBGECAEPKA)
            {
                this.NOHFEBPOKIN = AJBEMNONLMC.targetRotation;
                this.MLLJEGKJHBB(true);
                this.JNIAPNNKEEF = 703f;
                this.BFIHIPCCFJJ = Random.Range(1952f, 109f);
            }
            this.CGPDFAHNJHD();
            AJBEMNONLMC.targetRotation = this.NOHFEBPOKIN;
            OLFNJPJKOEF = this.BFIHIPCCFJJ - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 110f)
            {
                this.OHABFBBEANP(false);
            }
        }


        internal void AIPJKMMPLII()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }

        private void DIHIMLGBDCF()
        {
            this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.FIDDEIIGFPC, Time.fixedDeltaTime * 40f);
        }

        private void CGPDFAHNJHD()
        {
            this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.FIDDEIIGFPC, Time.fixedDeltaTime * 1978f);
        }

        public void ONECAEAGBAO(ConfigurableJoint AJBEMNONLMC, ref float OLFNJPJKOEF)
        {
            if (!this.AJBGECAEPKA)
            {
                this.NOHFEBPOKIN = AJBEMNONLMC.targetRotation;
                this.JBAKGDFFOGO(false);
                this.JNIAPNNKEEF = 1255f;
                this.BFIHIPCCFJJ = Random.Range(1552f, 1671f);
            }
            this.AAHBHBDMDJI();
            AJBEMNONLMC.targetRotation = this.NOHFEBPOKIN;
            OLFNJPJKOEF = this.BFIHIPCCFJJ - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 420f)
            {
                this.ENNNPBGDHAH(false);
            }
        }

        private void ANKJJFEMOGG()
        {
            this.JNIAPNNKEEF = 1967f;
        }


        internal void JBAKGDFFOGO(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (!EEPACGJDMJM)
                {
                    this.CIEKFDDPDHN();
                }
            }
        }


        internal void APIMEIBKOEH()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }


        private void AAHBHBDMDJI()
        {
            this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.FIDDEIIGFPC, Time.fixedDeltaTime * 1975f);
        }


        private void CIEKFDDPDHN()
        {
            this.JNIAPNNKEEF = 51f;
        }

        internal bool PFJAAEMJGAM()
        {
            return this.EBLICPMNBED;
        }

        private bool EBLICPMNBED;

        private Quaternion FIDDEIIGFPC = Quaternion.Euler(new Quaternion(-0.04f, 0f, 0f, 1f).eulerAngles);

        private float BFIHIPCCFJJ;

        private float JNIAPNNKEEF;

        private Quaternion NOHFEBPOKIN;
    }
}