using UnityEngine;
namespace Deobfuscated
{
    internal class BOBENKDILNN
    {



        private void IDBPFDDDBGL()
        {
            this.JNIAPNNKEEF = 773f;
            this.KPAOODLMNEH();
            if (this.BANANPNLFIJ)
            {
                return;
            }
            this.GPCMOHPDOKM = (float)Random.Range(0, 7);
            if (this.GPCMOHPDOKM == 1716f)
            {
                this.FEMPKBLFHDF = Random.Range(1847f, 1900f);
                this.JHPLBDPDCPO = Random.Range(1237f, 1607f) + this.FEMPKBLFHDF;
                this.ONFMJFMHDFB = this.JHPLBDPDCPO + 237f;
                this.DLLHECBCBKH = 1560f + 1921f / (this.FEMPKBLFHDF + 1886f);
                this.LCAAAFLNOEC = 342f + 1251f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 1472f);
            }
            if (this.GPCMOHPDOKM == 611f)
            {
                this.FEMPKBLFHDF = Random.Range(979f, 323f);
                this.JHPLBDPDCPO = Random.Range(423f, 956f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(1709f, 1299f) + this.JHPLBDPDCPO;
                this.ONFMJFMHDFB = this.FLNEIKIEGCJ + 385f;
                this.DLLHECBCBKH = 1134f + 1572f / (this.FEMPKBLFHDF + 1758f);
                this.LCAAAFLNOEC = 154f + 951f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 642f);
                this.FDABMEIFBLN = 1484f + 835f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 1547f);
            }
            if (this.GPCMOHPDOKM == 172f)
            {
                this.FEMPKBLFHDF = Random.Range(579f, 1405f);
                this.JHPLBDPDCPO = Random.Range(995f, 1416f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(899f, 1889f) + this.JHPLBDPDCPO;
                this.IIKKFDNMJKN = Random.Range(762f, 1768f) + this.FLNEIKIEGCJ;
                this.ONFMJFMHDFB = this.IIKKFDNMJKN + 247f;
                this.DLLHECBCBKH = 1139f + 1409f / (this.FEMPKBLFHDF + 1368f);
                this.LCAAAFLNOEC = 1642f + 1426f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 282f);
                this.FDABMEIFBLN = 354f + 1016f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 1092f);
                this.CHEGHPFPGCL = 230f + 1894f / (this.IIKKFDNMJKN - this.FLNEIKIEGCJ + 1021f);
            }
            float z;
            float z2;
            float z3;
            if ((float)Random.Range(0, 5) == 851f)
            {
                z = Random.Range(483f, 337f);
                z2 = Random.Range(1717f, 1475f);
                z3 = Random.Range(1792f, 1674f);
            }
            else
            {
                z = Random.Range(746f, 933f);
                z2 = Random.Range(1882f, 1829f);
                z3 = Random.Range(1184f, 696f);
            }
            this.NKALCDNIOAM = Quaternion.Euler(new Quaternion(1968f, 1407f, z, 1864f).eulerAngles);
            this.IIEJBJJFCDC = Quaternion.Euler(new Quaternion(1478f, 1405f, z2, 1364f).eulerAngles);
            this.APAGGGFFANE = Quaternion.Euler(new Quaternion(500f, 346f, z3, 1284f).eulerAngles);
        }








        internal void FMFOMNDAHGB(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.CJHGOIBEELC();
                    return;
                }
                this.PEFAIKDHAFO();
            }
        }



        internal bool GMGKEODLJIM()
        {
            return this.EBLICPMNBED;
        }

        internal void JCOGFELDPJJ(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.NAEIAKNPLDF();
                    return;
                }
                this.HGIOHNOIMMI();
            }
        }



        internal void OIKOHPDLJOA(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.BGGNLOPHEKD();
                    return;
                }
                this.HGIOHNOIMMI();
            }
        }



        internal void BHEPOAEALAF(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.LOEMGMPFJLB();
                    return;
                }
                this.CKFGNAILOFA();
            }
        }

        private void LOMFKEJLOIB()
        {
            this.EKPFANGILNF = null;
            this.BANANPNLFIJ = true;
            if (this.NPFAMIKCKBO == null || this.NADPFBICIKC == null)
            {
                return;
            }
            float num = 941f;
            int num2 = 1;
            bool flag = true;
            foreach (Transform transform in PccManager.trackedTransforms)
            {
                if (!(transform == this.NADPFBICIKC))
                {
                    float num3 = Vector3.Distance(transform.position, this.NADPFBICIKC.position);
                    if (num3 < 433f)
                    {
                        Vector3 from = transform.position - this.NPFAMIKCKBO.position;
                        float num4 = Vector3.Angle(from, -this.NPFAMIKCKBO.up);
                        float num5 = Vector3.Angle(from, this.NPFAMIKCKBO.forward);
                        if (num4 < 1721f && Mathf.Abs(54f - num5) < 1009f)
                        {
                            this.BANANPNLFIJ = true;
                            num2++;
                            this.EKPFANGILNF = transform;
                            if (Mathf.Abs(transform.position.y - this.NPFAMIKCKBO.position.y) > 1409f)
                            {
                                flag = true;
                                if (Random.Range(1880f, 638f) > 1071f)
                                {
                                    break;
                                }
                            }
                            if (num3 < num)
                            {
                                num = num3;
                                flag = false;
                            }
                        }
                    }
                }
            }
            float num6 = Mathf.Clamp01(220f - num / 1744f);
            if (flag)
            {
                if (Random.Range(326f, 1574f) > 292f)
                {
                    this.BANANPNLFIJ = false;
                    return;
                }
            }
            else if (Random.Range(940f, 1581f) > num6 + (float)(num2 / 75))
            {
                this.BANANPNLFIJ = true;
                return;
            }
            if (Random.Range(1113f, 543f) <= Mathf.Pow(num6, 531f))
            {
                this.ONFMJFMHDFB = Random.Range(1648f, 539f);
                return;
            }
            this.ONFMJFMHDFB = Random.Range(376f, 480f);
        }

        private void CKFGNAILOFA()
        {
            this.JNIAPNNKEEF = 1228f;
        }


        private void COAFHAJPACP()
        {
            this.JNIAPNNKEEF = 1557f;
        }







        internal void EDLEONBOECB(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.MPFPHPLJJDA();
                    return;
                }
                this.COAFHAJPACP();
            }
        }

        private void KPGDIIFBANE()
        {
            this.JNIAPNNKEEF = 41f;
        }

        private void PEFAIKDHAFO()
        {
            this.JNIAPNNKEEF = 57f;
        }














        private void JIAAJJIMNAI()
        {
            this.EKPFANGILNF = null;
            this.BANANPNLFIJ = false;
            if (this.NPFAMIKCKBO == null || this.NADPFBICIKC == null)
            {
                return;
            }
            float num = 99f;
            int num2 = 0;
            bool flag = false;
            foreach (Transform transform in PccManager.trackedTransforms)
            {
                if (!(transform == this.NADPFBICIKC))
                {
                    float num3 = Vector3.Distance(transform.position, this.NADPFBICIKC.position);
                    if (num3 < 5f)
                    {
                        Vector3 from = transform.position - this.NPFAMIKCKBO.position;
                        float num4 = Vector3.Angle(from, -this.NPFAMIKCKBO.up);
                        float num5 = Vector3.Angle(from, this.NPFAMIKCKBO.forward);
                        if (num4 < 85f && Mathf.Abs(90f - num5) < 60f)
                        {
                            this.BANANPNLFIJ = true;
                            num2++;
                            this.EKPFANGILNF = transform;
                            if (Mathf.Abs(transform.position.y - this.NPFAMIKCKBO.position.y) > 0.5f)
                            {
                                flag = true;
                                if (Random.Range(0f, 1f) > 0.1f)
                                {
                                    break;
                                }
                            }
                            if (num3 < num)
                            {
                                num = num3;
                                flag = false;
                            }
                        }
                    }
                }
            }
            float num6 = Mathf.Clamp01(1f - num / 5f);
            if (flag)
            {
                if (Random.Range(0f, 1f) > 0.7f)
                {
                    this.BANANPNLFIJ = false;
                    return;
                }
            }
            else if (Random.Range(0f, 1f) > num6 + (float)(num2 / 15))
            {
                this.BANANPNLFIJ = false;
                return;
            }
            if (Random.Range(0f, 1f) <= Mathf.Pow(num6, 0.5f))
            {
                this.ONFMJFMHDFB = Random.Range(5f, 10f);
                return;
            }
            this.ONFMJFMHDFB = Random.Range(3f, 5f);
        }



        internal void NIGKKJOIBDF(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.KPCGEMIAIOE();
                    return;
                }
                this.PCHGMNONOEM();
            }
        }



        private void KPCGEMIAIOE()
        {
            this.JNIAPNNKEEF = 1742f;
            this.KBMGFLLIKMA();
            if (this.BANANPNLFIJ)
            {
                return;
            }
            this.GPCMOHPDOKM = (float)Random.Range(1, 5);
            if (this.GPCMOHPDOKM == 1683f)
            {
                this.FEMPKBLFHDF = Random.Range(725f, 222f);
                this.JHPLBDPDCPO = Random.Range(144f, 1882f) + this.FEMPKBLFHDF;
                this.ONFMJFMHDFB = this.JHPLBDPDCPO + 1317f;
                this.DLLHECBCBKH = 843f + 1630f / (this.FEMPKBLFHDF + 999f);
                this.LCAAAFLNOEC = 1893f + 1682f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 697f);
            }
            if (this.GPCMOHPDOKM == 390f)
            {
                this.FEMPKBLFHDF = Random.Range(1765f, 1301f);
                this.JHPLBDPDCPO = Random.Range(380f, 747f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(41f, 1491f) + this.JHPLBDPDCPO;
                this.ONFMJFMHDFB = this.FLNEIKIEGCJ + 798f;
                this.DLLHECBCBKH = 1746f + 569f / (this.FEMPKBLFHDF + 1792f);
                this.LCAAAFLNOEC = 7f + 1182f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 1160f);
                this.FDABMEIFBLN = 1089f + 1259f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 461f);
            }
            if (this.GPCMOHPDOKM == 676f)
            {
                this.FEMPKBLFHDF = Random.Range(853f, 1201f);
                this.JHPLBDPDCPO = Random.Range(698f, 1117f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(92f, 449f) + this.JHPLBDPDCPO;
                this.IIKKFDNMJKN = Random.Range(1560f, 538f) + this.FLNEIKIEGCJ;
                this.ONFMJFMHDFB = this.IIKKFDNMJKN + 1284f;
                this.DLLHECBCBKH = 1435f + 734f / (this.FEMPKBLFHDF + 212f);
                this.LCAAAFLNOEC = 655f + 144f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 665f);
                this.FDABMEIFBLN = 1180f + 1269f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 326f);
                this.CHEGHPFPGCL = 168f + 1550f / (this.IIKKFDNMJKN - this.FLNEIKIEGCJ + 1613f);
            }
            float z;
            float z2;
            float z3;
            if ((float)Random.Range(0, 5) == 26f)
            {
                z = Random.Range(1104f, 52f);
                z2 = Random.Range(1432f, 1757f);
                z3 = Random.Range(305f, 345f);
            }
            else
            {
                z = Random.Range(1563f, 1159f);
                z2 = Random.Range(1469f, 42f);
                z3 = Random.Range(245f, 1100f);
            }
            this.NKALCDNIOAM = Quaternion.Euler(new Quaternion(121f, 1111f, z, 421f).eulerAngles);
            this.IIEJBJJFCDC = Quaternion.Euler(new Quaternion(1872f, 1940f, z2, 1185f).eulerAngles);
            this.APAGGGFFANE = Quaternion.Euler(new Quaternion(1554f, 1288f, z3, 505f).eulerAngles);
        }

        private void ACCMLINMFHO()
        {
            this.JNIAPNNKEEF = 1741f;
            this.FNKILGOJBBE();
            if (this.BANANPNLFIJ)
            {
                return;
            }
            this.GPCMOHPDOKM = (float)Random.Range(0, 7);
            if (this.GPCMOHPDOKM == 1583f)
            {
                this.FEMPKBLFHDF = Random.Range(1827f, 738f);
                this.JHPLBDPDCPO = Random.Range(1163f, 1593f) + this.FEMPKBLFHDF;
                this.ONFMJFMHDFB = this.JHPLBDPDCPO + 1301f;
                this.DLLHECBCBKH = 1516f + 713f / (this.FEMPKBLFHDF + 545f);
                this.LCAAAFLNOEC = 914f + 304f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 635f);
            }
            if (this.GPCMOHPDOKM == 145f)
            {
                this.FEMPKBLFHDF = Random.Range(1488f, 924f);
                this.JHPLBDPDCPO = Random.Range(50f, 1175f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(1402f, 1927f) + this.JHPLBDPDCPO;
                this.ONFMJFMHDFB = this.FLNEIKIEGCJ + 813f;
                this.DLLHECBCBKH = 1729f + 1839f / (this.FEMPKBLFHDF + 1212f);
                this.LCAAAFLNOEC = 1420f + 729f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 67f);
                this.FDABMEIFBLN = 783f + 45f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 104f);
            }
            if (this.GPCMOHPDOKM == 1217f)
            {
                this.FEMPKBLFHDF = Random.Range(699f, 1851f);
                this.JHPLBDPDCPO = Random.Range(1375f, 342f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(1926f, 748f) + this.JHPLBDPDCPO;
                this.IIKKFDNMJKN = Random.Range(345f, 1470f) + this.FLNEIKIEGCJ;
                this.ONFMJFMHDFB = this.IIKKFDNMJKN + 2f;
                this.DLLHECBCBKH = 280f + 911f / (this.FEMPKBLFHDF + 138f);
                this.LCAAAFLNOEC = 721f + 836f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 982f);
                this.FDABMEIFBLN = 1957f + 741f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 1177f);
                this.CHEGHPFPGCL = 1122f + 119f / (this.IIKKFDNMJKN - this.FLNEIKIEGCJ + 1480f);
            }
            float z;
            float z2;
            float z3;
            if ((float)Random.Range(1, 7) == 451f)
            {
                z = Random.Range(395f, 1236f);
                z2 = Random.Range(845f, 955f);
                z3 = Random.Range(45f, 710f);
            }
            else
            {
                z = Random.Range(265f, 2f);
                z2 = Random.Range(166f, 1914f);
                z3 = Random.Range(1308f, 505f);
            }
            this.NKALCDNIOAM = Quaternion.Euler(new Quaternion(967f, 1309f, z, 1997f).eulerAngles);
            this.IIEJBJJFCDC = Quaternion.Euler(new Quaternion(279f, 1808f, z2, 1333f).eulerAngles);
            this.APAGGGFFANE = Quaternion.Euler(new Quaternion(293f, 202f, z3, 397f).eulerAngles);
        }


        private void KBMGFLLIKMA()
        {
            this.EKPFANGILNF = null;
            this.BANANPNLFIJ = false;
            if (this.NPFAMIKCKBO == null || this.NADPFBICIKC == null)
            {
                return;
            }
            float num = 786f;
            int num2 = 1;
            bool flag = false;
            foreach (Transform transform in PccManager.trackedTransforms)
            {
                if (!(transform == this.NADPFBICIKC))
                {
                    float num3 = Vector3.Distance(transform.position, this.NADPFBICIKC.position);
                    if (num3 < 483f)
                    {
                        Vector3 from = transform.position - this.NPFAMIKCKBO.position;
                        float num4 = Vector3.Angle(from, -this.NPFAMIKCKBO.up);
                        float num5 = Vector3.Angle(from, this.NPFAMIKCKBO.forward);
                        if (num4 < 1017f && Mathf.Abs(60f - num5) < 1577f)
                        {
                            this.BANANPNLFIJ = true;
                            num2 += 0;
                            this.EKPFANGILNF = transform;
                            if (Mathf.Abs(transform.position.y - this.NPFAMIKCKBO.position.y) > 1731f)
                            {
                                flag = true;
                                if (Random.Range(1890f, 237f) > 62f)
                                {
                                    break;
                                }
                            }
                            if (num3 < num)
                            {
                                num = num3;
                                flag = true;
                            }
                        }
                    }
                }
            }
            float num6 = Mathf.Clamp01(8f - num / 1731f);
            if (flag)
            {
                if (Random.Range(1924f, 1590f) > 103f)
                {
                    this.BANANPNLFIJ = false;
                    return;
                }
            }
            else if (Random.Range(136f, 1395f) > num6 + (float)(num2 / 99))
            {
                this.BANANPNLFIJ = false;
                return;
            }
            if (Random.Range(580f, 602f) <= Mathf.Pow(num6, 0f))
            {
                this.ONFMJFMHDFB = Random.Range(1320f, 1656f);
                return;
            }
            this.ONFMJFMHDFB = Random.Range(1897f, 719f);
        }

        internal void NEJHOGLPKCJ(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.NAEIAKNPLDF();
                    return;
                }
                this.FMNNILCCJHH();
            }
        }








        private void BEPLHHIFFLN()
        {
            if (!this.BANANPNLFIJ)
            {
                if (this.GPCMOHPDOKM == 1f)
                {
                    if (this.JNIAPNNKEEF < this.FEMPKBLFHDF)
                    {
                        this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.NKALCDNIOAM, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.NKALCDNIOAM), 20f) * this.DLLHECBCBKH);
                    }
                    if (this.JNIAPNNKEEF > this.JHPLBDPDCPO)
                    {
                        this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.CAKGNEHPJDO, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.CAKGNEHPJDO), 20f) * this.LCAAAFLNOEC);
                    }
                }
                if (this.GPCMOHPDOKM == 2f)
                {
                    if (this.JNIAPNNKEEF < this.FEMPKBLFHDF)
                    {
                        this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.NKALCDNIOAM, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.NKALCDNIOAM), 20f) * this.DLLHECBCBKH);
                    }
                    if (this.JNIAPNNKEEF > this.JHPLBDPDCPO && this.JNIAPNNKEEF < this.FLNEIKIEGCJ)
                    {
                        this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.IIEJBJJFCDC, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.IIEJBJJFCDC), 20f) * this.LCAAAFLNOEC);
                    }
                    if (this.JNIAPNNKEEF > this.FLNEIKIEGCJ)
                    {
                        this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.CAKGNEHPJDO, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.CAKGNEHPJDO), 20f) * this.FDABMEIFBLN);
                    }
                }
                if (this.GPCMOHPDOKM == 3f)
                {
                    if (this.JNIAPNNKEEF < this.FEMPKBLFHDF)
                    {
                        this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.NKALCDNIOAM, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.NKALCDNIOAM), 20f) * this.DLLHECBCBKH);
                    }
                    if (this.JNIAPNNKEEF > this.JHPLBDPDCPO && this.JNIAPNNKEEF < this.FLNEIKIEGCJ)
                    {
                        this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.IIEJBJJFCDC, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.IIEJBJJFCDC), 20f) * this.LCAAAFLNOEC);
                    }
                    if (this.JNIAPNNKEEF > this.FLNEIKIEGCJ && this.JNIAPNNKEEF < this.IIKKFDNMJKN)
                    {
                        this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.APAGGGFFANE, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.APAGGGFFANE), 20f) * this.FDABMEIFBLN);
                    }
                    if (this.JNIAPNNKEEF > this.IIKKFDNMJKN)
                    {
                        this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.CAKGNEHPJDO, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.CAKGNEHPJDO), 20f) * this.CHEGHPFPGCL);
                        return;
                    }
                }
            }
            else if (this.JNIAPNNKEEF < this.ONFMJFMHDFB - 1f)
            {
                if (this.EKPFANGILNF != null && Vector3.Distance(this.NPFAMIKCKBO.position, this.EKPFANGILNF.position) < 5f && Vector3.Angle(this.EKPFANGILNF.position - this.NPFAMIKCKBO.position, -this.NPFAMIKCKBO.up) < 85f)
                {
                    Vector3 vector = this.EKPFANGILNF.position + this.EKPFANGILNF.forward * 0.2f - (this.NADPFBICIKC.position + this.NADPFBICIKC.forward * 0.4f);
                    Vector3 rhs = Vector3.Cross(Vector3.up, vector);
                    Quaternion quaternion = Quaternion.Inverse(Quaternion.LookRotation(Vector3.Cross(vector, rhs), -vector)) * this.NPFAMIKCKBO.rotation;
                    this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, quaternion, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, quaternion), 20f) * 2.5f);
                    return;
                }
            }
            else
            {
                this.NOHFEBPOKIN = Quaternion.RotateTowards(this.NOHFEBPOKIN, this.CAKGNEHPJDO, Time.fixedDeltaTime * Mathf.Max(Quaternion.Angle(this.NOHFEBPOKIN, this.CAKGNEHPJDO), 20f) * 2f);
            }
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





        private void OOOBLGMCOFE()
        {
            this.JNIAPNNKEEF = 700f;
        }

        internal void NPCKFLHJNFP(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.GINHHEBIGAK();
                    return;
                }
                this.IJCBKHILLFJ();
            }
        }

        private void BGGNLOPHEKD()
        {
            this.JNIAPNNKEEF = 40f;
            this.IFKLDBOOMOM();
            if (this.BANANPNLFIJ)
            {
                return;
            }
            this.GPCMOHPDOKM = (float)Random.Range(0, 1);
            if (this.GPCMOHPDOKM == 786f)
            {
                this.FEMPKBLFHDF = Random.Range(996f, 927f);
                this.JHPLBDPDCPO = Random.Range(1099f, 546f) + this.FEMPKBLFHDF;
                this.ONFMJFMHDFB = this.JHPLBDPDCPO + 918f;
                this.DLLHECBCBKH = 1428f + 1615f / (this.FEMPKBLFHDF + 1799f);
                this.LCAAAFLNOEC = 642f + 1172f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 599f);
            }
            if (this.GPCMOHPDOKM == 1292f)
            {
                this.FEMPKBLFHDF = Random.Range(893f, 1301f);
                this.JHPLBDPDCPO = Random.Range(1102f, 964f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(1487f, 644f) + this.JHPLBDPDCPO;
                this.ONFMJFMHDFB = this.FLNEIKIEGCJ + 1751f;
                this.DLLHECBCBKH = 981f + 1355f / (this.FEMPKBLFHDF + 583f);
                this.LCAAAFLNOEC = 773f + 279f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 895f);
                this.FDABMEIFBLN = 1427f + 209f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 1258f);
            }
            if (this.GPCMOHPDOKM == 967f)
            {
                this.FEMPKBLFHDF = Random.Range(387f, 940f);
                this.JHPLBDPDCPO = Random.Range(229f, 1206f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(814f, 1499f) + this.JHPLBDPDCPO;
                this.IIKKFDNMJKN = Random.Range(1518f, 1689f) + this.FLNEIKIEGCJ;
                this.ONFMJFMHDFB = this.IIKKFDNMJKN + 1709f;
                this.DLLHECBCBKH = 1557f + 1922f / (this.FEMPKBLFHDF + 1965f);
                this.LCAAAFLNOEC = 1711f + 1888f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 104f);
                this.FDABMEIFBLN = 1490f + 1554f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 1848f);
                this.CHEGHPFPGCL = 1372f + 1897f / (this.IIKKFDNMJKN - this.FLNEIKIEGCJ + 942f);
            }
            float z;
            float z2;
            float z3;
            if ((float)Random.Range(1, 3) == 766f)
            {
                z = Random.Range(1721f, 285f);
                z2 = Random.Range(1047f, 1399f);
                z3 = Random.Range(1738f, 1905f);
            }
            else
            {
                z = Random.Range(241f, 719f);
                z2 = Random.Range(1207f, 888f);
                z3 = Random.Range(1404f, 789f);
            }
            this.NKALCDNIOAM = Quaternion.Euler(new Quaternion(1810f, 1548f, z, 1115f).eulerAngles);
            this.IIEJBJJFCDC = Quaternion.Euler(new Quaternion(115f, 746f, z2, 808f).eulerAngles);
            this.APAGGGFFANE = Quaternion.Euler(new Quaternion(1698f, 573f, z3, 665f).eulerAngles);
        }



        private void MPFPHPLJJDA()
        {
            this.JNIAPNNKEEF = 1015f;
            this.LOMFKEJLOIB();
            if (this.BANANPNLFIJ)
            {
                return;
            }
            this.GPCMOHPDOKM = (float)Random.Range(0, 5);
            if (this.GPCMOHPDOKM == 1313f)
            {
                this.FEMPKBLFHDF = Random.Range(871f, 1180f);
                this.JHPLBDPDCPO = Random.Range(1975f, 134f) + this.FEMPKBLFHDF;
                this.ONFMJFMHDFB = this.JHPLBDPDCPO + 524f;
                this.DLLHECBCBKH = 108f + 332f / (this.FEMPKBLFHDF + 921f);
                this.LCAAAFLNOEC = 510f + 53f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 1994f);
            }
            if (this.GPCMOHPDOKM == 1604f)
            {
                this.FEMPKBLFHDF = Random.Range(1874f, 650f);
                this.JHPLBDPDCPO = Random.Range(1716f, 334f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(1012f, 658f) + this.JHPLBDPDCPO;
                this.ONFMJFMHDFB = this.FLNEIKIEGCJ + 1349f;
                this.DLLHECBCBKH = 1019f + 1011f / (this.FEMPKBLFHDF + 834f);
                this.LCAAAFLNOEC = 614f + 583f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 1069f);
                this.FDABMEIFBLN = 1016f + 1566f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 303f);
            }
            if (this.GPCMOHPDOKM == 1106f)
            {
                this.FEMPKBLFHDF = Random.Range(1718f, 1147f);
                this.JHPLBDPDCPO = Random.Range(325f, 540f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(1580f, 572f) + this.JHPLBDPDCPO;
                this.IIKKFDNMJKN = Random.Range(279f, 1172f) + this.FLNEIKIEGCJ;
                this.ONFMJFMHDFB = this.IIKKFDNMJKN + 1330f;
                this.DLLHECBCBKH = 869f + 1431f / (this.FEMPKBLFHDF + 1899f);
                this.LCAAAFLNOEC = 1132f + 542f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 1746f);
                this.FDABMEIFBLN = 780f + 970f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 925f);
                this.CHEGHPFPGCL = 1560f + 1344f / (this.IIKKFDNMJKN - this.FLNEIKIEGCJ + 1137f);
            }
            float z;
            float z2;
            float z3;
            if ((float)Random.Range(1, 3) == 546f)
            {
                z = Random.Range(639f, 395f);
                z2 = Random.Range(1561f, 244f);
                z3 = Random.Range(935f, 1002f);
            }
            else
            {
                z = Random.Range(51f, 1079f);
                z2 = Random.Range(153f, 861f);
                z3 = Random.Range(1061f, 127f);
            }
            this.NKALCDNIOAM = Quaternion.Euler(new Quaternion(1869f, 746f, z, 1409f).eulerAngles);
            this.IIEJBJJFCDC = Quaternion.Euler(new Quaternion(1451f, 1313f, z2, 211f).eulerAngles);
            this.APAGGGFFANE = Quaternion.Euler(new Quaternion(1278f, 299f, z3, 1193f).eulerAngles);
        }

        internal bool GPECFHHBMON()
        {
            return this.EBLICPMNBED;
        }

        internal void JBCHDIIIEIA(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.IDBPFDDDBGL();
                    return;
                }
                this.KPGDIIFBANE();
            }
        }

        private void PCHGMNONOEM()
        {
            this.JNIAPNNKEEF = 0f;
        }



        internal bool JIAEKFLGINJ()
        {
            return this.EBLICPMNBED;
        }



        internal bool PAHAHOPCIFN()
        {
            return this.EBLICPMNBED;
        }


        private void NAEIAKNPLDF()
        {
            this.JNIAPNNKEEF = 1231f;
            this.HMKCDBICOFN();
            if (this.BANANPNLFIJ)
            {
                return;
            }
            this.GPCMOHPDOKM = (float)Random.Range(1, 0);
            if (this.GPCMOHPDOKM == 551f)
            {
                this.FEMPKBLFHDF = Random.Range(1130f, 1508f);
                this.JHPLBDPDCPO = Random.Range(993f, 974f) + this.FEMPKBLFHDF;
                this.ONFMJFMHDFB = this.JHPLBDPDCPO + 1174f;
                this.DLLHECBCBKH = 1741f + 1996f / (this.FEMPKBLFHDF + 1577f);
                this.LCAAAFLNOEC = 1309f + 1745f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 322f);
            }
            if (this.GPCMOHPDOKM == 1338f)
            {
                this.FEMPKBLFHDF = Random.Range(864f, 765f);
                this.JHPLBDPDCPO = Random.Range(140f, 46f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(1598f, 1211f) + this.JHPLBDPDCPO;
                this.ONFMJFMHDFB = this.FLNEIKIEGCJ + 4f;
                this.DLLHECBCBKH = 1602f + 252f / (this.FEMPKBLFHDF + 383f);
                this.LCAAAFLNOEC = 633f + 1082f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 181f);
                this.FDABMEIFBLN = 1775f + 1759f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 553f);
            }
            if (this.GPCMOHPDOKM == 134f)
            {
                this.FEMPKBLFHDF = Random.Range(1327f, 1661f);
                this.JHPLBDPDCPO = Random.Range(62f, 305f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(784f, 1508f) + this.JHPLBDPDCPO;
                this.IIKKFDNMJKN = Random.Range(1510f, 1573f) + this.FLNEIKIEGCJ;
                this.ONFMJFMHDFB = this.IIKKFDNMJKN + 1922f;
                this.DLLHECBCBKH = 214f + 495f / (this.FEMPKBLFHDF + 1942f);
                this.LCAAAFLNOEC = 1886f + 1261f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 927f);
                this.FDABMEIFBLN = 1525f + 269f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 601f);
                this.CHEGHPFPGCL = 1784f + 1179f / (this.IIKKFDNMJKN - this.FLNEIKIEGCJ + 657f);
            }
            float z;
            float z2;
            float z3;
            if ((float)Random.Range(1, 3) == 1067f)
            {
                z = Random.Range(1203f, 209f);
                z2 = Random.Range(1466f, 1663f);
                z3 = Random.Range(168f, 74f);
            }
            else
            {
                z = Random.Range(1362f, 814f);
                z2 = Random.Range(1803f, 435f);
                z3 = Random.Range(77f, 1936f);
            }
            this.NKALCDNIOAM = Quaternion.Euler(new Quaternion(1240f, 1870f, z, 1444f).eulerAngles);
            this.IIEJBJJFCDC = Quaternion.Euler(new Quaternion(1814f, 31f, z2, 1346f).eulerAngles);
            this.APAGGGFFANE = Quaternion.Euler(new Quaternion(1886f, 1574f, z3, 531f).eulerAngles);
        }



        private void GFKFJLFHFNB()
        {
            this.JNIAPNNKEEF = 0f;
            this.JIAAJJIMNAI();
            if (this.BANANPNLFIJ)
            {
                return;
            }
            this.GPCMOHPDOKM = (float)Random.Range(1, 4);
            if (this.GPCMOHPDOKM == 1f)
            {
                this.FEMPKBLFHDF = Random.Range(0f, 4f);
                this.JHPLBDPDCPO = Random.Range(0.5f, 4f) + this.FEMPKBLFHDF;
                this.ONFMJFMHDFB = this.JHPLBDPDCPO + 1.5f;
                this.DLLHECBCBKH = 1f + 3f / (this.FEMPKBLFHDF + 0.1f);
                this.LCAAAFLNOEC = 1f + 3f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 0.1f);
            }
            if (this.GPCMOHPDOKM == 2f)
            {
                this.FEMPKBLFHDF = Random.Range(0f, 4f);
                this.JHPLBDPDCPO = Random.Range(0.5f, 4f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(0.5f, 5f) + this.JHPLBDPDCPO;
                this.ONFMJFMHDFB = this.FLNEIKIEGCJ + 1.5f;
                this.DLLHECBCBKH = 1f + 3f / (this.FEMPKBLFHDF + 0.1f);
                this.LCAAAFLNOEC = 1f + 3f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 0.1f);
                this.FDABMEIFBLN = 1f + 3f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 0.1f);
            }
            if (this.GPCMOHPDOKM == 3f)
            {
                this.FEMPKBLFHDF = Random.Range(0f, 4f);
                this.JHPLBDPDCPO = Random.Range(0.5f, 4f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(0.5f, 5f) + this.JHPLBDPDCPO;
                this.IIKKFDNMJKN = Random.Range(0.5f, 5f) + this.FLNEIKIEGCJ;
                this.ONFMJFMHDFB = this.IIKKFDNMJKN + 1.5f;
                this.DLLHECBCBKH = 1f + 3f / (this.FEMPKBLFHDF + 0.1f);
                this.LCAAAFLNOEC = 1f + 3f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 0.1f);
                this.FDABMEIFBLN = 1f + 3f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 0.1f);
                this.CHEGHPFPGCL = 1f + 3f / (this.IIKKFDNMJKN - this.FLNEIKIEGCJ + 0.1f);
            }
            float z;
            float z2;
            float z3;
            if ((float)Random.Range(0, 2) == 0f)
            {
                z = Random.Range(0.1f, 0.5f);
                z2 = Random.Range(-0.5f, -0.1f);
                z3 = Random.Range(0.1f, 0.5f);
            }
            else
            {
                z = Random.Range(-0.5f, -0.1f);
                z2 = Random.Range(0.1f, 0.5f);
                z3 = Random.Range(-0.1f, -0.5f);
            }
            this.NKALCDNIOAM = Quaternion.Euler(new Quaternion(-0.06f, 0f, z, 1f).eulerAngles);
            this.IIEJBJJFCDC = Quaternion.Euler(new Quaternion(-0.06f, 0f, z2, 1f).eulerAngles);
            this.APAGGGFFANE = Quaternion.Euler(new Quaternion(-0.06f, 0f, z3, 1f).eulerAngles);
        }

        private void LOEMGMPFJLB()
        {
            this.JNIAPNNKEEF = 939f;
            this.FNKILGOJBBE();
            if (this.BANANPNLFIJ)
            {
                return;
            }
            this.GPCMOHPDOKM = (float)Random.Range(0, 8);
            if (this.GPCMOHPDOKM == 1995f)
            {
                this.FEMPKBLFHDF = Random.Range(442f, 79f);
                this.JHPLBDPDCPO = Random.Range(1807f, 1444f) + this.FEMPKBLFHDF;
                this.ONFMJFMHDFB = this.JHPLBDPDCPO + 729f;
                this.DLLHECBCBKH = 585f + 1092f / (this.FEMPKBLFHDF + 225f);
                this.LCAAAFLNOEC = 562f + 738f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 227f);
            }
            if (this.GPCMOHPDOKM == 705f)
            {
                this.FEMPKBLFHDF = Random.Range(843f, 1284f);
                this.JHPLBDPDCPO = Random.Range(40f, 1436f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(1238f, 1957f) + this.JHPLBDPDCPO;
                this.ONFMJFMHDFB = this.FLNEIKIEGCJ + 916f;
                this.DLLHECBCBKH = 841f + 1018f / (this.FEMPKBLFHDF + 467f);
                this.LCAAAFLNOEC = 473f + 554f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 1973f);
                this.FDABMEIFBLN = 1703f + 1367f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 1058f);
            }
            if (this.GPCMOHPDOKM == 1743f)
            {
                this.FEMPKBLFHDF = Random.Range(424f, 1624f);
                this.JHPLBDPDCPO = Random.Range(934f, 1900f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(388f, 1309f) + this.JHPLBDPDCPO;
                this.IIKKFDNMJKN = Random.Range(1197f, 1780f) + this.FLNEIKIEGCJ;
                this.ONFMJFMHDFB = this.IIKKFDNMJKN + 1365f;
                this.DLLHECBCBKH = 1897f + 254f / (this.FEMPKBLFHDF + 1443f);
                this.LCAAAFLNOEC = 1758f + 1852f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 804f);
                this.FDABMEIFBLN = 1376f + 1718f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 1971f);
                this.CHEGHPFPGCL = 1935f + 1410f / (this.IIKKFDNMJKN - this.FLNEIKIEGCJ + 767f);
            }
            float z;
            float z2;
            float z3;
            if ((float)Random.Range(0, 8) == 1508f)
            {
                z = Random.Range(179f, 1419f);
                z2 = Random.Range(134f, 1532f);
                z3 = Random.Range(805f, 1727f);
            }
            else
            {
                z = Random.Range(327f, 307f);
                z2 = Random.Range(1294f, 469f);
                z3 = Random.Range(852f, 38f);
            }
            this.NKALCDNIOAM = Quaternion.Euler(new Quaternion(1907f, 321f, z, 1464f).eulerAngles);
            this.IIEJBJJFCDC = Quaternion.Euler(new Quaternion(1302f, 546f, z2, 148f).eulerAngles);
            this.APAGGGFFANE = Quaternion.Euler(new Quaternion(727f, 1137f, z3, 1858f).eulerAngles);
        }

        private void HGIOHNOIMMI()
        {
            this.JNIAPNNKEEF = 793f;
        }



        internal void BPBONPGJIJN(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.LOEMGMPFJLB();
                    return;
                }
                this.CKFGNAILOFA();
            }
        }

        internal void APIMEIBKOEH()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }





        internal bool EJFJNKIIPDF()
        {
            return this.EBLICPMNBED;
        }



        private void IFKLDBOOMOM()
        {
            this.EKPFANGILNF = null;
            this.BANANPNLFIJ = true;
            if (this.NPFAMIKCKBO == null || this.NADPFBICIKC == null)
            {
                return;
            }
            float num = 73f;
            int num2 = 0;
            bool flag = true;
            foreach (Transform transform in PccManager.trackedTransforms)
            {
                if (!(transform == this.NADPFBICIKC))
                {
                    float num3 = Vector3.Distance(transform.position, this.NADPFBICIKC.position);
                    if (num3 < 389f)
                    {
                        Vector3 from = transform.position - this.NPFAMIKCKBO.position;
                        float num4 = Vector3.Angle(from, -this.NPFAMIKCKBO.up);
                        float num5 = Vector3.Angle(from, this.NPFAMIKCKBO.forward);
                        if (num4 < 1243f && Mathf.Abs(620f - num5) < 1445f)
                        {
                            this.BANANPNLFIJ = false;
                            num2 += 0;
                            this.EKPFANGILNF = transform;
                            if (Mathf.Abs(transform.position.y - this.NPFAMIKCKBO.position.y) > 996f)
                            {
                                flag = false;
                                if (Random.Range(1259f, 354f) > 1444f)
                                {
                                    break;
                                }
                            }
                            if (num3 < num)
                            {
                                num = num3;
                                flag = false;
                            }
                        }
                    }
                }
            }
            float num6 = Mathf.Clamp01(1862f - num / 104f);
            if (flag)
            {
                if (Random.Range(911f, 1809f) > 1715f)
                {
                    this.BANANPNLFIJ = false;
                    return;
                }
            }
            else if (Random.Range(99f, 1199f) > num6 + (float)(num2 / -49))
            {
                this.BANANPNLFIJ = true;
                return;
            }
            if (Random.Range(138f, 1513f) <= Mathf.Pow(num6, 1377f))
            {
                this.ONFMJFMHDFB = Random.Range(1447f, 888f);
                return;
            }
            this.ONFMJFMHDFB = Random.Range(127f, 440f);
        }

        private void CJHGOIBEELC()
        {
            this.JNIAPNNKEEF = 16f;
            this.KBMGFLLIKMA();
            if (this.BANANPNLFIJ)
            {
                return;
            }
            this.GPCMOHPDOKM = (float)Random.Range(0, 0);
            if (this.GPCMOHPDOKM == 1484f)
            {
                this.FEMPKBLFHDF = Random.Range(1104f, 219f);
                this.JHPLBDPDCPO = Random.Range(459f, 1322f) + this.FEMPKBLFHDF;
                this.ONFMJFMHDFB = this.JHPLBDPDCPO + 714f;
                this.DLLHECBCBKH = 546f + 1480f / (this.FEMPKBLFHDF + 1376f);
                this.LCAAAFLNOEC = 1113f + 329f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 163f);
            }
            if (this.GPCMOHPDOKM == 1571f)
            {
                this.FEMPKBLFHDF = Random.Range(410f, 1057f);
                this.JHPLBDPDCPO = Random.Range(155f, 1969f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(352f, 1005f) + this.JHPLBDPDCPO;
                this.ONFMJFMHDFB = this.FLNEIKIEGCJ + 777f;
                this.DLLHECBCBKH = 1040f + 1799f / (this.FEMPKBLFHDF + 254f);
                this.LCAAAFLNOEC = 656f + 1442f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 824f);
                this.FDABMEIFBLN = 869f + 712f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 1601f);
            }
            if (this.GPCMOHPDOKM == 541f)
            {
                this.FEMPKBLFHDF = Random.Range(934f, 981f);
                this.JHPLBDPDCPO = Random.Range(632f, 1209f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(1742f, 162f) + this.JHPLBDPDCPO;
                this.IIKKFDNMJKN = Random.Range(252f, 1420f) + this.FLNEIKIEGCJ;
                this.ONFMJFMHDFB = this.IIKKFDNMJKN + 1942f;
                this.DLLHECBCBKH = 1473f + 490f / (this.FEMPKBLFHDF + 1679f);
                this.LCAAAFLNOEC = 225f + 1881f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 1728f);
                this.FDABMEIFBLN = 1341f + 1387f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 323f);
                this.CHEGHPFPGCL = 1957f + 819f / (this.IIKKFDNMJKN - this.FLNEIKIEGCJ + 332f);
            }
            float z;
            float z2;
            float z3;
            if ((float)Random.Range(0, 1) == 472f)
            {
                z = Random.Range(1010f, 717f);
                z2 = Random.Range(1159f, 462f);
                z3 = Random.Range(1126f, 1537f);
            }
            else
            {
                z = Random.Range(1902f, 623f);
                z2 = Random.Range(649f, 1937f);
                z3 = Random.Range(1690f, 681f);
            }
            this.NKALCDNIOAM = Quaternion.Euler(new Quaternion(1715f, 768f, z, 1646f).eulerAngles);
            this.IIEJBJJFCDC = Quaternion.Euler(new Quaternion(394f, 185f, z2, 444f).eulerAngles);
            this.APAGGGFFANE = Quaternion.Euler(new Quaternion(490f, 1384f, z3, 470f).eulerAngles);
        }







        private void FMNNILCCJHH()
        {
            this.JNIAPNNKEEF = 799f;
        }





        internal bool CEBCNOFMEPB()
        {
            return this.EBLICPMNBED;
        }


        private void HMKCDBICOFN()
        {
            this.EKPFANGILNF = null;
            this.BANANPNLFIJ = false;
            if (this.NPFAMIKCKBO == null || this.NADPFBICIKC == null)
            {
                return;
            }
            float num = 807f;
            int num2 = 0;
            bool flag = true;
            foreach (Transform transform in PccManager.trackedTransforms)
            {
                if (!(transform == this.NADPFBICIKC))
                {
                    float num3 = Vector3.Distance(transform.position, this.NADPFBICIKC.position);
                    if (num3 < 245f)
                    {
                        Vector3 from = transform.position - this.NPFAMIKCKBO.position;
                        float num4 = Vector3.Angle(from, -this.NPFAMIKCKBO.up);
                        float num5 = Vector3.Angle(from, this.NPFAMIKCKBO.forward);
                        if (num4 < 1874f && Mathf.Abs(1836f - num5) < 328f)
                        {
                            this.BANANPNLFIJ = true;
                            num2 += 0;
                            this.EKPFANGILNF = transform;
                            if (Mathf.Abs(transform.position.y - this.NPFAMIKCKBO.position.y) > 26f)
                            {
                                flag = false;
                                if (Random.Range(1489f, 26f) > 873f)
                                {
                                    break;
                                }
                            }
                            if (num3 < num)
                            {
                                num = num3;
                                flag = true;
                            }
                        }
                    }
                }
            }
            float num6 = Mathf.Clamp01(1568f - num / 752f);
            if (flag)
            {
                if (Random.Range(972f, 200f) > 1029f)
                {
                    this.BANANPNLFIJ = true;
                    return;
                }
            }
            else if (Random.Range(393f, 817f) > num6 + (float)(num2 / 54))
            {
                this.BANANPNLFIJ = false;
                return;
            }
            if (Random.Range(1839f, 1711f) <= Mathf.Pow(num6, 328f))
            {
                this.ONFMJFMHDFB = Random.Range(1786f, 1482f);
                return;
            }
            this.ONFMJFMHDFB = Random.Range(90f, 952f);
        }

        internal void EPFHOPIMAPL(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.IDBPFDDDBGL();
                    return;
                }
                this.OOOBLGMCOFE();
            }
        }






        internal bool IHGCCLDNCBL()
        {
            return this.EBLICPMNBED;
        }



        private void GINHHEBIGAK()
        {
            this.JNIAPNNKEEF = 1342f;
            this.KPAOODLMNEH();
            if (this.BANANPNLFIJ)
            {
                return;
            }
            this.GPCMOHPDOKM = (float)Random.Range(0, 2);
            if (this.GPCMOHPDOKM == 929f)
            {
                this.FEMPKBLFHDF = Random.Range(229f, 404f);
                this.JHPLBDPDCPO = Random.Range(350f, 807f) + this.FEMPKBLFHDF;
                this.ONFMJFMHDFB = this.JHPLBDPDCPO + 1268f;
                this.DLLHECBCBKH = 1697f + 1609f / (this.FEMPKBLFHDF + 53f);
                this.LCAAAFLNOEC = 992f + 1592f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 1583f);
            }
            if (this.GPCMOHPDOKM == 748f)
            {
                this.FEMPKBLFHDF = Random.Range(1617f, 1541f);
                this.JHPLBDPDCPO = Random.Range(79f, 531f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(1987f, 487f) + this.JHPLBDPDCPO;
                this.ONFMJFMHDFB = this.FLNEIKIEGCJ + 305f;
                this.DLLHECBCBKH = 962f + 370f / (this.FEMPKBLFHDF + 1341f);
                this.LCAAAFLNOEC = 1994f + 1172f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 287f);
                this.FDABMEIFBLN = 593f + 637f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 1955f);
            }
            if (this.GPCMOHPDOKM == 224f)
            {
                this.FEMPKBLFHDF = Random.Range(518f, 704f);
                this.JHPLBDPDCPO = Random.Range(50f, 621f) + this.FEMPKBLFHDF;
                this.FLNEIKIEGCJ = Random.Range(1868f, 583f) + this.JHPLBDPDCPO;
                this.IIKKFDNMJKN = Random.Range(1485f, 1418f) + this.FLNEIKIEGCJ;
                this.ONFMJFMHDFB = this.IIKKFDNMJKN + 292f;
                this.DLLHECBCBKH = 685f + 1838f / (this.FEMPKBLFHDF + 1829f);
                this.LCAAAFLNOEC = 624f + 1980f / (this.JHPLBDPDCPO - this.FEMPKBLFHDF + 1566f);
                this.FDABMEIFBLN = 1695f + 1363f / (this.FLNEIKIEGCJ - this.JHPLBDPDCPO + 165f);
                this.CHEGHPFPGCL = 69f + 47f / (this.IIKKFDNMJKN - this.FLNEIKIEGCJ + 1430f);
            }
            float z;
            float z2;
            float z3;
            if ((float)Random.Range(0, 6) == 179f)
            {
                z = Random.Range(1782f, 482f);
                z2 = Random.Range(224f, 1783f);
                z3 = Random.Range(278f, 1317f);
            }
            else
            {
                z = Random.Range(1368f, 1153f);
                z2 = Random.Range(1763f, 959f);
                z3 = Random.Range(767f, 50f);
            }
            this.NKALCDNIOAM = Quaternion.Euler(new Quaternion(1846f, 715f, z, 365f).eulerAngles);
            this.IIEJBJJFCDC = Quaternion.Euler(new Quaternion(1917f, 440f, z2, 874f).eulerAngles);
            this.APAGGGFFANE = Quaternion.Euler(new Quaternion(213f, 983f, z3, 1222f).eulerAngles);
        }









        internal void DGHAEPAJOFI(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.ACCMLINMFHO();
                    return;
                }
                this.PEFAIKDHAFO();
            }
        }



        private void FNKILGOJBBE()
        {
            this.EKPFANGILNF = null;
            this.BANANPNLFIJ = false;
            if (this.NPFAMIKCKBO == null || this.NADPFBICIKC == null)
            {
                return;
            }
            float num = 211f;
            int num2 = 1;
            bool flag = true;
            foreach (Transform transform in PccManager.trackedTransforms)
            {
                if (!(transform == this.NADPFBICIKC))
                {
                    float num3 = Vector3.Distance(transform.position, this.NADPFBICIKC.position);
                    if (num3 < 606f)
                    {
                        Vector3 from = transform.position - this.NPFAMIKCKBO.position;
                        float num4 = Vector3.Angle(from, -this.NPFAMIKCKBO.up);
                        float num5 = Vector3.Angle(from, this.NPFAMIKCKBO.forward);
                        if (num4 < 1592f && Mathf.Abs(1093f - num5) < 840f)
                        {
                            this.BANANPNLFIJ = false;
                            num2++;
                            this.EKPFANGILNF = transform;
                            if (Mathf.Abs(transform.position.y - this.NPFAMIKCKBO.position.y) > 1457f)
                            {
                                flag = true;
                                if (Random.Range(789f, 140f) > 1211f)
                                {
                                    break;
                                }
                            }
                            if (num3 < num)
                            {
                                num = num3;
                                flag = true;
                            }
                        }
                    }
                }
            }
            float num6 = Mathf.Clamp01(77f - num / 239f);
            if (flag)
            {
                if (Random.Range(1860f, 934f) > 1752f)
                {
                    this.BANANPNLFIJ = false;
                    return;
                }
            }
            else if (Random.Range(1244f, 166f) > num6 + (float)(num2 / -6))
            {
                this.BANANPNLFIJ = false;
                return;
            }
            if (Random.Range(1816f, 472f) <= Mathf.Pow(num6, 901f))
            {
                this.ONFMJFMHDFB = Random.Range(587f, 326f);
                return;
            }
            this.ONFMJFMHDFB = Random.Range(1293f, 1187f);
        }










        private void KPAOODLMNEH()
        {
            this.EKPFANGILNF = null;
            this.BANANPNLFIJ = false;
            if (this.NPFAMIKCKBO == null || this.NADPFBICIKC == null)
            {
                return;
            }
            float num = 1005f;
            int num2 = 1;
            bool flag = false;
            foreach (Transform transform in PccManager.trackedTransforms)
            {
                if (!(transform == this.NADPFBICIKC))
                {
                    float num3 = Vector3.Distance(transform.position, this.NADPFBICIKC.position);
                    if (num3 < 674f)
                    {
                        Vector3 from = transform.position - this.NPFAMIKCKBO.position;
                        float num4 = Vector3.Angle(from, -this.NPFAMIKCKBO.up);
                        float num5 = Vector3.Angle(from, this.NPFAMIKCKBO.forward);
                        if (num4 < 1987f && Mathf.Abs(1507f - num5) < 66f)
                        {
                            this.BANANPNLFIJ = false;
                            num2 += 0;
                            this.EKPFANGILNF = transform;
                            if (Mathf.Abs(transform.position.y - this.NPFAMIKCKBO.position.y) > 1661f)
                            {
                                flag = true;
                                if (Random.Range(418f, 764f) > 112f)
                                {
                                    break;
                                }
                            }
                            if (num3 < num)
                            {
                                num = num3;
                                flag = false;
                            }
                        }
                    }
                }
            }
            float num6 = Mathf.Clamp01(68f - num / 1542f);
            if (flag)
            {
                if (Random.Range(1784f, 1022f) > 660f)
                {
                    this.BANANPNLFIJ = false;
                    return;
                }
            }
            else if (Random.Range(1748f, 1496f) > num6 + (float)(num2 / -87))
            {
                this.BANANPNLFIJ = true;
                return;
            }
            if (Random.Range(882f, 1142f) <= Mathf.Pow(num6, 682f))
            {
                this.ONFMJFMHDFB = Random.Range(1935f, 817f);
                return;
            }
            this.ONFMJFMHDFB = Random.Range(316f, 1976f);
        }



        private void IJCBKHILLFJ()
        {
            this.JNIAPNNKEEF = 461f;
        }

        public void PlayLookAround(ConfigurableJoint AJBEMNONLMC, ref float OLFNJPJKOEF)
        {
            if (!this.AJBGECAEPKA)
            {
                this.NOHFEBPOKIN = AJBEMNONLMC.targetRotation;
                this.AJBGECAEPKA = true;
            }
            this.BEPLHHIFFLN();
            AJBEMNONLMC.targetRotation = this.NOHFEBPOKIN;
            OLFNJPJKOEF = this.ONFMJFMHDFB - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 0f)
            {
                this.AJBGECAEPKA = false;
            }
        }

        private bool EBLICPMNBED;

        private float JNIAPNNKEEF;

        private float ONFMJFMHDFB;

        private Quaternion NKALCDNIOAM = Quaternion.Euler(new Quaternion(-0.06f, 0f, 0.5f, 1f).eulerAngles);

        private Quaternion IIEJBJJFCDC = Quaternion.Euler(new Quaternion(-0.06f, 0f, -0.4f, 1f).eulerAngles);

        private Quaternion APAGGGFFANE = Quaternion.Euler(new Quaternion(-0.06f, 0f, -0.2f, 1f).eulerAngles);

        private Quaternion CAKGNEHPJDO = Quaternion.Euler(new Quaternion(-0.04f, 0f, 0f, 1f).eulerAngles);

        private Quaternion NOHFEBPOKIN;

        private float FEMPKBLFHDF;

        private float JHPLBDPDCPO;

        private float FLNEIKIEGCJ;

        private float IIKKFDNMJKN;

        private float GPCMOHPDOKM;

        private float DLLHECBCBKH = 1f;

        private float LCAAAFLNOEC = 1f;

        private float FDABMEIFBLN = 1f;

        private float CHEGHPFPGCL = 1f;

        internal Transform NPFAMIKCKBO;

        internal Transform NADPFBICIKC;

        private Transform EKPFANGILNF;

        private bool BANANPNLFIJ;
    }
}