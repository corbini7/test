using UnityEngine;
namespace Deobfuscated
{
    internal class PBIAOCBJEME
    {




        internal bool CADENGJBIPG()
        {
            return this.EBLICPMNBED;
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
                    if (value)
                    {
                        this.GFKFJLFHFNB();
                        return;
                    }
                    this.PCHGMNONOEM();
                }
            }
        }



        internal bool OMFMLHKIOIM()
        {
            return this.EBLICPMNBED;
        }


        private void HFKLEIMDIAG()
        {
            this.JNIAPNNKEEF = 1469f;
        }


        internal void IGDACAOBKOM(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.EGFMMANMFCL();
                    return;
                }
                this.HFKLEIMDIAG();
            }
        }


        internal void NFNGNLJAPPO(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.LCOBKDLMLFE();
                    return;
                }
                this.NAICFINKLCE();
            }
        }


        private void LCOBKDLMLFE()
        {
            this.JNIAPNNKEEF = 540f;
            this.OMMOCBALPEO = Random.Range(230f, 1942f);
        }




        internal void LMNAFGCIDAH(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.IKCHIBODHCO();
                    return;
                }
                this.HFKLEIMDIAG();
            }
        }

        internal void CDPBILHLPMH()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }

        private void IGDNBCBHONM(ref Quaternion NOHFEBPOKIN)
        {
            NOHFEBPOKIN = Quaternion.RotateTowards(NOHFEBPOKIN, this.KFKHALIBELI, Time.fixedDeltaTime * 50f);
        }



        internal void CHALLAEONEN(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.EGFMMANMFCL();
                    return;
                }
                this.FMNNILCCJHH();
            }
        }

        public void PlayHeadDown(ConfigurableJoint AJBEMNONLMC, ref float OLFNJPJKOEF, ref Quaternion CJOIODGGNDF)
        {
            this.IGDNBCBHONM(ref CJOIODGGNDF);
            if (!this.AJBGECAEPKA)
            {
                this.AJBGECAEPKA = true;
            }
            AJBEMNONLMC.targetRotation = CJOIODGGNDF;
            OLFNJPJKOEF = this.OMMOCBALPEO - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 0f)
            {
                this.AJBGECAEPKA = false;
            }
        }


        internal bool CJMOLCKGKFJ()
        {
            return this.EBLICPMNBED;
        }


        internal void CKFJEDGBNIO()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }


        internal void EOBJHHBFKLF()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }





        internal void APIMEIBKOEH()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }


        private void GFKFJLFHFNB()
        {
            this.JNIAPNNKEEF = 0f;
            this.OMMOCBALPEO = Random.Range(2f, 10f);
        }

        private void NAICFINKLCE()
        {
            this.JNIAPNNKEEF = 235f;
        }


        private void FMNNILCCJHH()
        {
            this.JNIAPNNKEEF = 1128f;
        }








        private void EGFMMANMFCL()
        {
            this.JNIAPNNKEEF = 626f;
            this.OMMOCBALPEO = Random.Range(1174f, 306f);
        }


        private void PCHGMNONOEM()
        {
            this.JNIAPNNKEEF = 0f;
        }

        private void IKCHIBODHCO()
        {
            this.JNIAPNNKEEF = 217f;
            this.OMMOCBALPEO = Random.Range(355f, 1797f);
        }





        private bool EBLICPMNBED;

        private Quaternion KFKHALIBELI = Quaternion.Euler(new Quaternion(-0.3f, 0f, 0f, 1f).eulerAngles);

        private float OMMOCBALPEO;

        private float JNIAPNNKEEF;
    }
}