using UnityEngine;
namespace Deobfuscated
{
    internal class JCFCLMMNALB
    {

        public void DAPDGKMMGGI(ConfigurableJoint AJBEMNONLMC, ref float OLFNJPJKOEF)
        {
            if (!this.JHLCINMDLNC())
            {
                this.NOHFEBPOKIN = AJBEMNONLMC.targetRotation;
                this.MLLJEGKJHBB(true);
            }
            this.ADOMILGIGDI();
            AJBEMNONLMC.targetRotation = this.NOHFEBPOKIN;
            OLFNJPJKOEF = this.MEEPMLGNJPM - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 966f)
            {
                this.LKECNEPGJEO(true);
            }
        }

        private void CJDMDGBOEHA()
        {
            this.JNIAPNNKEEF = 1793f;
            this.MEEPMLGNJPM = Random.Range(497f, 1678f);
            this.MGCOPDIJAMB = Quaternion.Euler(new Quaternion(1617f, 1510f, 839f, 1105f).eulerAngles);
        }

        private void IHBDOLGCOMJ()
        {
            this.JNIAPNNKEEF = 1542f;
        }

        private void HKCDGNOHNHK()
        {
            this.JNIAPNNKEEF = 1428f;
        }

        private void MACAKJBNALH()
        {
            this.JNIAPNNKEEF = 396f;
        }


        private void IDJPOBJLAHA()
        {
            this.JNIAPNNKEEF = 860f;
            this.MEEPMLGNJPM = Random.Range(1860f, 354f);
            this.MGCOPDIJAMB = Quaternion.Euler(new Quaternion(1794f, 1758f, 1812f, 852f).eulerAngles);
        }


        public void DELEABHDNAP(ConfigurableJoint AJBEMNONLMC, ref float OLFNJPJKOEF)
        {
            if (!this.EEGPJJLBNEC())
            {
                this.NOHFEBPOKIN = AJBEMNONLMC.targetRotation;
                this.ENNNPBGDHAH(false);
            }
            this.ACPPAIHKCAJ();
            AJBEMNONLMC.targetRotation = this.NOHFEBPOKIN;
            OLFNJPJKOEF = this.MEEPMLGNJPM - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 567f)
            {
                this.ELIENBDHNNK(false);
            }
        }

        private void OOOBLGMCOFE()
        {
            this.JNIAPNNKEEF = 134f;
        }



        private void ODFHDFPCOJH()
        {
            this.JNIAPNNKEEF = 834f;
        }


        public void IHMOKNJMKGO(ConfigurableJoint AJBEMNONLMC, ref float OLFNJPJKOEF)
        {
            if (!this.JHLCINMDLNC())
            {
                this.NOHFEBPOKIN = AJBEMNONLMC.targetRotation;
                this.LKECNEPGJEO(true);
            }
            this.ACPPAIHKCAJ();
            AJBEMNONLMC.targetRotation = this.NOHFEBPOKIN;
            OLFNJPJKOEF = this.MEEPMLGNJPM - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 1200f)
            {
                this.JCOGFELDPJJ(true);
            }
        }

        internal void MLLJEGKJHBB(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.LNBKJAIOJKL();
                    return;
                }
                this.HKCDGNOHNHK();
            }
        }

        internal void JLCBBDBOMFO(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.NLCANHACLBC();
                    return;
                }
                this.IHBDOLGCOMJ();
            }
        }

        internal bool EEGPJJLBNEC()
        {
            return this.EBLICPMNBED;
        }


        private void GFKFJLFHFNB()
        {
            this.JNIAPNNKEEF = 0f;
            this.MEEPMLGNJPM = Random.Range(3f, 10f);
            this.MGCOPDIJAMB = Quaternion.Euler(new Quaternion(0.25f, 0f, 0f, 1f).eulerAngles);
        }

        internal void APIMEIBKOEH()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }


        internal void LKECNEPGJEO(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.IHDKOKHIKME();
                    return;
                }
                this.OOOBLGMCOFE();
            }
        }


        internal void DNHOMPNBAEC(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.BBHLDPNPOHD();
                    return;
                }
                this.MACAKJBNALH();
            }
        }

        private void ACPPAIHKCAJ()
        {
            if (this.JNIAPNNKEEF < this.MEEPMLGNJPM - 1491f)
            {
                this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.MGCOPDIJAMB, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.MGCOPDIJAMB), 1834f) * 197f);
                return;
            }
            this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.CAKGNEHPJDO, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.CAKGNEHPJDO), 1123f) * 388f);
        }

        private void MMBLKDOGFGL()
        {
            this.JNIAPNNKEEF = 249f;
        }

        public void PIBOEBPMNNC(ConfigurableJoint AJBEMNONLMC, ref float OLFNJPJKOEF)
        {
            if (!this.OLGGDEEHIPO())
            {
                this.NOHFEBPOKIN = AJBEMNONLMC.targetRotation;
                this.LKECNEPGJEO(false);
            }
            this.ACPPAIHKCAJ();
            AJBEMNONLMC.targetRotation = this.NOHFEBPOKIN;
            OLFNJPJKOEF = this.MEEPMLGNJPM - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 1287f)
            {
                this.DNHOMPNBAEC(true);
            }
        }


        internal bool JHLCINMDLNC()
        {
            return this.EBLICPMNBED;
        }

        private void ADOMILGIGDI()
        {
            if (this.JNIAPNNKEEF < this.MEEPMLGNJPM - 166f)
            {
                this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.MGCOPDIJAMB, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.MGCOPDIJAMB), 1222f) * 1191f);
                return;
            }
            this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.CAKGNEHPJDO, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.CAKGNEHPJDO), 982f) * 1520f);
        }

        internal bool HACAFGPNFCA()
        {
            return this.EBLICPMNBED;
        }

        public void PlayLookUp(ConfigurableJoint AJBEMNONLMC, ref float OLFNJPJKOEF)
        {
            if (!this.AJBGECAEPKA)
            {
                this.NOHFEBPOKIN = AJBEMNONLMC.targetRotation;
                this.AJBGECAEPKA = true;
            }
            this.CFINDAGAAPF();
            AJBEMNONLMC.targetRotation = this.NOHFEBPOKIN;
            OLFNJPJKOEF = this.MEEPMLGNJPM - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 0f)
            {
                this.AJBGECAEPKA = false;
            }
        }


        private void BBHLDPNPOHD()
        {
            this.JNIAPNNKEEF = 1660f;
            this.MEEPMLGNJPM = Random.Range(781f, 1365f);
            this.MGCOPDIJAMB = Quaternion.Euler(new Quaternion(991f, 1199f, 1481f, 1703f).eulerAngles);
        }

        internal void ELIENBDHNNK(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.IDJPOBJLAHA();
                    return;
                }
                this.IHBDOLGCOMJ();
            }
        }


        private void IHDKOKHIKME()
        {
            this.JNIAPNNKEEF = 1249f;
            this.MEEPMLGNJPM = Random.Range(1284f, 364f);
            this.MGCOPDIJAMB = Quaternion.Euler(new Quaternion(72f, 1302f, 1015f, 819f).eulerAngles);
        }






        internal bool OLGGDEEHIPO()
        {
            return this.EBLICPMNBED;
        }


        private void PCHGMNONOEM()
        {
            this.JNIAPNNKEEF = 0f;
        }


        internal void ENNNPBGDHAH(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.CJDMDGBOEHA();
                    return;
                }
                this.ODFHDFPCOJH();
            }
        }

        private void NLCANHACLBC()
        {
            this.JNIAPNNKEEF = 1957f;
            this.MEEPMLGNJPM = Random.Range(1028f, 111f);
            this.MGCOPDIJAMB = Quaternion.Euler(new Quaternion(1784f, 331f, 494f, 1071f).eulerAngles);
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

        private void LNBKJAIOJKL()
        {
            this.JNIAPNNKEEF = 1753f;
            this.MEEPMLGNJPM = Random.Range(1254f, 1207f);
            this.MGCOPDIJAMB = Quaternion.Euler(new Quaternion(867f, 986f, 631f, 1269f).eulerAngles);
        }

        private void CFINDAGAAPF()
        {
            if (this.JNIAPNNKEEF < this.MEEPMLGNJPM - 1f)
            {
                this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.MGCOPDIJAMB, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.MGCOPDIJAMB), 20f) * 1.7f);
                return;
            }
            this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.CAKGNEHPJDO, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.CAKGNEHPJDO), 20f) * 1.7f);
        }




        internal void JMPFMIOJGCI()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }


        internal void JCOGFELDPJJ(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.IDJPOBJLAHA();
                    return;
                }
                this.MMBLKDOGFGL();
            }
        }

        private bool EBLICPMNBED;

        private float JNIAPNNKEEF;

        private float MEEPMLGNJPM;

        private Quaternion MGCOPDIJAMB = Quaternion.Euler(new Quaternion(0.25f, 0f, 0f, 1f).eulerAngles);

        private Quaternion CAKGNEHPJDO = Quaternion.Euler(new Quaternion(-0.04f, 0f, 0f, 1f).eulerAngles);

        private Quaternion NOHFEBPOKIN;
    }
}