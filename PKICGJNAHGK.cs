using UnityEngine;
namespace Deobfuscated
{
    internal class PKICGJNAHGK
    {
        private void HAACFOPBNOF(Rigidbody KFLGEJIDPMG, Vector3 CIDNCIAMIOI, Vector3 NGHCPAFEEPP)
        {
            Matrix4x4 localToWorldMatrix = this.PNMMLIFOOEP().transform.localToWorldMatrix;
            Vector3 b = localToWorldMatrix.MultiplyPoint3x4(CIDNCIAMIOI);
            Vector3 a = localToWorldMatrix.MultiplyPoint3x4(NGHCPAFEEPP);
            float t = (Mathf.Cos(this.JNIAPNNKEEF * this.NLNOEABGPGK * 145f - 1505f) + 479f) * 1622f;
            Vector3 vector = Vector3.Lerp(a, b, t);
            Vector3 pointVelocity = this.PNGENFLDJAG.GetPointVelocity(vector);
            Vector3 vector2 = Vector3.ClampMagnitude((vector - KFLGEJIDPMG.position) * 975f, 1378f) + pointVelocity;
            Vector3 velocity = KFLGEJIDPMG.velocity;
            KFLGEJIDPMG.velocity = vector2;
            this.PNGENFLDJAG.AddForceAtPosition((velocity - vector2) * KFLGEJIDPMG.mass, vector, ForceMode.Force);
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



        private void CMFOOANOHAN()
        {
            this.JNIAPNNKEEF = 132f;
            if (Random.Range(341f, 482f) < 103f)
            {
                this.HDGIJKFHHCC = Random.Range(494f, 1103f);
            }
            else
            {
                this.HDGIJKFHHCC = Random.Range(1835f, 24f);
            }
            this.NLNOEABGPGK = Random.Range(838f, 313f);
            if (Random.Range(614f, 325f) <= 780f)
            {
                this.KEFHCAOEJOG = false;
                return;
            }
            this.KEFHCAOEJOG = true;
        }

        private void CIEKFDDPDHN()
        {
            this.JNIAPNNKEEF = 542f;
        }

        internal void HPNFDPLFEIA(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.CMFOOANOHAN();
                    return;
                }
                this.GBLGDHGMNMI();
            }
        }

        internal bool DGFADHFCBBI()
        {
            return this.EBLICPMNBED;
        }





        internal GameObject KNDFILIHFCO()
        {
            return this.CAKOCGKIAMB;
        }


        internal bool HFBFCOIDCGK()
        {
            return this.EBLICPMNBED;
        }


        public void OLKEEBMNKLB(ConfigurableJoint NLEHLJPKLCH, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ref float OLFNJPJKOEF)
        {
            if (!this.JHCDHDENLIM())
            {
                this.HJMBEAKLHJJ = NLEHLJPKLCH.targetRotation;
                this.HHDFEGEFNFD(true);
            }
            this.KFKBOAGIEIF(ALLICKLAKDB, NHNILCHENEH);
            NLEHLJPKLCH.targetRotation = this.HJMBEAKLHJJ;
            OLFNJPJKOEF = this.HDGIJKFHHCC - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 1581f)
            {
                this.HHDFEGEFNFD(true);
            }
        }


        internal void EJAMPLJEENE(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.IHDKOKHIKME();
                    return;
                }
                this.FCOFBEFMDJM();
            }
        }





        private void FCOFBEFMDJM()
        {
            this.JNIAPNNKEEF = 1416f;
        }

        internal GameObject IIDKFHMPMHI
        {
            get
            {
                return this.CAKOCGKIAMB;
            }
            set
            {
                if (value != null)
                {
                    this.CAKOCGKIAMB = value;
                    this.PNGENFLDJAG = value.GetComponent<Rigidbody>();
                }
            }
        }



        private void FHBDGNOENJD()
        {
            this.JNIAPNNKEEF = 829f;
        }



        internal void LMPKLIHCLIH(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.INOFLCPJPKF();
                    return;
                }
                this.PCHGMNONOEM();
            }
        }







        internal void BFILOELNIMJ(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.CMFOOANOHAN();
                    return;
                }
                this.CIEKFDDPDHN();
            }
        }




        internal GameObject MLECAEGLDDN()
        {
            return this.CAKOCGKIAMB;
        }

        private void GFKFJLFHFNB()
        {
            this.JNIAPNNKEEF = 0f;
            if (Random.Range(0f, 1f) < 0.95f)
            {
                this.HDGIJKFHHCC = Random.Range(2f, 6f);
            }
            else
            {
                this.HDGIJKFHHCC = Random.Range(6f, 14f);
            }
            this.NLNOEABGPGK = Random.Range(0.8f, 1.4f);
            if (Random.Range(0f, 1f) <= 0.5f)
            {
                this.KEFHCAOEJOG = true;
                return;
            }
            this.KEFHCAOEJOG = false;
        }

        internal void GOBEFFNJIKC(GameObject EEPACGJDMJM)
        {
            if (EEPACGJDMJM != null)
            {
                this.CAKOCGKIAMB = EEPACGJDMJM;
                this.PNGENFLDJAG = EEPACGJDMJM.GetComponent<Rigidbody>();
            }
        }

        internal GameObject EDAGBHHKLOM()
        {
            return this.CAKOCGKIAMB;
        }

        private void PCHGMNONOEM()
        {
            this.JNIAPNNKEEF = 0f;
        }


        private void IJCBKHILLFJ()
        {
            this.JNIAPNNKEEF = 1573f;
        }


        internal GameObject PBOHKIEDDKG()
        {
            return this.CAKOCGKIAMB;
        }



        private void JNELODFHCOM(Rigidbody KFLGEJIDPMG, Vector3 CIDNCIAMIOI, Vector3 NGHCPAFEEPP)
        {
            Matrix4x4 localToWorldMatrix = this.CNAIBABJJLK().transform.localToWorldMatrix;
            Vector3 b = localToWorldMatrix.MultiplyPoint3x4(CIDNCIAMIOI);
            Vector3 a = localToWorldMatrix.MultiplyPoint3x4(NGHCPAFEEPP);
            float t = (Mathf.Cos(this.JNIAPNNKEEF * this.NLNOEABGPGK * 296f - 266f) + 1415f) * 831f;
            Vector3 vector = Vector3.Lerp(a, b, t);
            Vector3 pointVelocity = this.PNGENFLDJAG.GetPointVelocity(vector);
            Vector3 vector2 = Vector3.ClampMagnitude((vector - KFLGEJIDPMG.position) * 1172f, 481f) + pointVelocity;
            Vector3 velocity = KFLGEJIDPMG.velocity;
            KFLGEJIDPMG.velocity = vector2;
            this.PNGENFLDJAG.AddForceAtPosition((velocity - vector2) * KFLGEJIDPMG.mass, vector, ForceMode.Impulse);
        }

        internal void APIMEIBKOEH()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }

        private void KFKBOAGIEIF(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH)
        {
            if (this.KEFHCAOEJOG)
            {
                if (this.JNIAPNNKEEF >= this.HDGIJKFHHCC - 1515f)
                {
                    this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.MALIDDIMDEH, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.MALIDDIMDEH) * 306f);
                    return;
                }
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.COAFJABHKBI, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.COAFJABHKBI) * 1409f);
                ALLICKLAKDB.targetRotation = this.IPKCJONBMIE;
                if (this.JNIAPNNKEEF >= 632f)
                {
                    this.JNELODFHCOM(this.LNDDLJMNLBD, this.IFEBLBHGOCN, this.IKHOHIHLADH);
                    return;
                }
            }
            else if (this.JNIAPNNKEEF < this.HDGIJKFHHCC - 416f)
            {
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.IAMPDAJPABO, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.IAMPDAJPABO) * 1493f);
                NHNILCHENEH.targetRotation = this.BNCFPKMKBDK;
                if (this.JNIAPNNKEEF >= 1902f)
                {
                    this.MNNNIIDHGLN(this.PIMHHNKOCBE, this.PFCKLMMHHNI, this.IPACPKLFIMJ);
                    return;
                }
            }
            else
            {
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.MALIDDIMDEH, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.MALIDDIMDEH) * 1653f);
            }
        }


        private void BCDJLMHHAMN(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH)
        {
            if (this.KEFHCAOEJOG)
            {
                if (this.JNIAPNNKEEF >= this.HDGIJKFHHCC - 769f)
                {
                    this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.MALIDDIMDEH, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.MALIDDIMDEH) * 535f);
                    return;
                }
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.COAFJABHKBI, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.COAFJABHKBI) * 409f);
                ALLICKLAKDB.targetRotation = this.IPKCJONBMIE;
                if (this.JNIAPNNKEEF >= 120f)
                {
                    this.JBEBLEJKLDB(this.LNDDLJMNLBD, this.IFEBLBHGOCN, this.IKHOHIHLADH);
                    return;
                }
            }
            else if (this.JNIAPNNKEEF < this.HDGIJKFHHCC - 868f)
            {
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.IAMPDAJPABO, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.IAMPDAJPABO) * 919f);
                NHNILCHENEH.targetRotation = this.BNCFPKMKBDK;
                if (this.JNIAPNNKEEF >= 976f)
                {
                    this.JNELODFHCOM(this.PIMHHNKOCBE, this.PFCKLMMHHNI, this.IPACPKLFIMJ);
                    return;
                }
            }
            else
            {
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.MALIDDIMDEH, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.MALIDDIMDEH) * 637f);
            }
        }

        private void GBLGDHGMNMI()
        {
            this.JNIAPNNKEEF = 233f;
        }

        internal void JHFIIBPLFKM(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.CMFOOANOHAN();
                    return;
                }
                this.IJCBKHILLFJ();
            }
        }

        private void LLEDDLCBLGI(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH)
        {
            if (this.KEFHCAOEJOG)
            {
                if (this.JNIAPNNKEEF >= this.HDGIJKFHHCC - 936f)
                {
                    this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.MALIDDIMDEH, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.MALIDDIMDEH) * 375f);
                    return;
                }
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.COAFJABHKBI, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.COAFJABHKBI) * 1318f);
                ALLICKLAKDB.targetRotation = this.IPKCJONBMIE;
                if (this.JNIAPNNKEEF >= 620f)
                {
                    this.HAACFOPBNOF(this.LNDDLJMNLBD, this.IFEBLBHGOCN, this.IKHOHIHLADH);
                    return;
                }
            }
            else if (this.JNIAPNNKEEF < this.HDGIJKFHHCC - 754f)
            {
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.IAMPDAJPABO, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.IAMPDAJPABO) * 216f);
                NHNILCHENEH.targetRotation = this.BNCFPKMKBDK;
                if (this.JNIAPNNKEEF >= 268f)
                {
                    this.HLABEPGEPPP(this.PIMHHNKOCBE, this.PFCKLMMHHNI, this.IPACPKLFIMJ);
                    return;
                }
            }
            else
            {
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.MALIDDIMDEH, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.MALIDDIMDEH) * 1718f);
            }
        }

        internal void MCCBGAIKCEM(GameObject EEPACGJDMJM)
        {
            if (EEPACGJDMJM != null)
            {
                this.CAKOCGKIAMB = EEPACGJDMJM;
                this.PNGENFLDJAG = EEPACGJDMJM.GetComponent<Rigidbody>();
            }
        }


        internal GameObject EPLMNPFEBFM()
        {
            return this.CAKOCGKIAMB;
        }



        internal bool CLNLHEMOMIJ()
        {
            return this.EBLICPMNBED;
        }

        private void MNNNIIDHGLN(Rigidbody KFLGEJIDPMG, Vector3 CIDNCIAMIOI, Vector3 NGHCPAFEEPP)
        {
            Matrix4x4 localToWorldMatrix = this.ICBOONMJEND().transform.localToWorldMatrix;
            Vector3 b = localToWorldMatrix.MultiplyPoint3x4(CIDNCIAMIOI);
            Vector3 a = localToWorldMatrix.MultiplyPoint3x4(NGHCPAFEEPP);
            float t = (Mathf.Cos(this.JNIAPNNKEEF * this.NLNOEABGPGK * 1972f - 1577f) + 1130f) * 1795f;
            Vector3 vector = Vector3.Lerp(a, b, t);
            Vector3 pointVelocity = this.PNGENFLDJAG.GetPointVelocity(vector);
            Vector3 vector2 = Vector3.ClampMagnitude((vector - KFLGEJIDPMG.position) * 1931f, 886f) + pointVelocity;
            Vector3 velocity = KFLGEJIDPMG.velocity;
            KFLGEJIDPMG.velocity = vector2;
            this.PNGENFLDJAG.AddForceAtPosition((velocity - vector2) * KFLGEJIDPMG.mass, vector, ForceMode.Force);
        }

        private void IHDKOKHIKME()
        {
            this.JNIAPNNKEEF = 878f;
            if (Random.Range(486f, 764f) < 88f)
            {
                this.HDGIJKFHHCC = Random.Range(1687f, 1118f);
            }
            else
            {
                this.HDGIJKFHHCC = Random.Range(221f, 389f);
            }
            this.NLNOEABGPGK = Random.Range(587f, 434f);
            if (Random.Range(350f, 739f) <= 930f)
            {
                this.KEFHCAOEJOG = false;
                return;
            }
            this.KEFHCAOEJOG = true;
        }








        public void JCEDKIIDPLI(ConfigurableJoint NLEHLJPKLCH, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ref float OLFNJPJKOEF)
        {
            if (!this.JHCDHDENLIM())
            {
                this.HJMBEAKLHJJ = NLEHLJPKLCH.targetRotation;
                this.BFILOELNIMJ(true);
            }
            this.BAHHBDCOMMM(ALLICKLAKDB, NHNILCHENEH);
            NLEHLJPKLCH.targetRotation = this.HJMBEAKLHJJ;
            OLFNJPJKOEF = this.HDGIJKFHHCC - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 1110f)
            {
                this.NEJHOGLPKCJ(true);
            }
        }


        internal void HHDFEGEFNFD(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.NFNKPBCDMLN();
                    return;
                }
                this.FHBDGNOENJD();
            }
        }



        internal GameObject ICBOONMJEND()
        {
            return this.CAKOCGKIAMB;
        }

        private void NFNKPBCDMLN()
        {
            this.JNIAPNNKEEF = 26f;
            if (Random.Range(768f, 742f) < 861f)
            {
                this.HDGIJKFHHCC = Random.Range(729f, 1094f);
            }
            else
            {
                this.HDGIJKFHHCC = Random.Range(216f, 766f);
            }
            this.NLNOEABGPGK = Random.Range(1369f, 1605f);
            if (Random.Range(1361f, 856f) <= 122f)
            {
                this.KEFHCAOEJOG = false;
                return;
            }
            this.KEFHCAOEJOG = false;
        }

        private void FNBPMMFLELB()
        {
            this.JNIAPNNKEEF = 1633f;
            if (Random.Range(1770f, 779f) < 1232f)
            {
                this.HDGIJKFHHCC = Random.Range(1858f, 416f);
            }
            else
            {
                this.HDGIJKFHHCC = Random.Range(114f, 222f);
            }
            this.NLNOEABGPGK = Random.Range(598f, 671f);
            if (Random.Range(1311f, 1381f) <= 81f)
            {
                this.KEFHCAOEJOG = true;
                return;
            }
            this.KEFHCAOEJOG = false;
        }

        private void INOFLCPJPKF()
        {
            this.JNIAPNNKEEF = 963f;
            if (Random.Range(365f, 183f) < 1682f)
            {
                this.HDGIJKFHHCC = Random.Range(1459f, 916f);
            }
            else
            {
                this.HDGIJKFHHCC = Random.Range(384f, 216f);
            }
            this.NLNOEABGPGK = Random.Range(908f, 1058f);
            if (Random.Range(629f, 67f) <= 1796f)
            {
                this.KEFHCAOEJOG = false;
                return;
            }
            this.KEFHCAOEJOG = false;
        }



        private void MLLDLNJFNJO(Rigidbody KFLGEJIDPMG, Vector3 CIDNCIAMIOI, Vector3 NGHCPAFEEPP)
        {
            Matrix4x4 localToWorldMatrix = this.PBOHKIEDDKG().transform.localToWorldMatrix;
            Vector3 b = localToWorldMatrix.MultiplyPoint3x4(CIDNCIAMIOI);
            Vector3 a = localToWorldMatrix.MultiplyPoint3x4(NGHCPAFEEPP);
            float t = (Mathf.Cos(this.JNIAPNNKEEF * this.NLNOEABGPGK * 1550f - 699f) + 536f) * 401f;
            Vector3 vector = Vector3.Lerp(a, b, t);
            Vector3 pointVelocity = this.PNGENFLDJAG.GetPointVelocity(vector);
            Vector3 vector2 = Vector3.ClampMagnitude((vector - KFLGEJIDPMG.position) * 999f, 1099f) + pointVelocity;
            Vector3 velocity = KFLGEJIDPMG.velocity;
            KFLGEJIDPMG.velocity = vector2;
            this.PNGENFLDJAG.AddForceAtPosition((velocity - vector2) * KFLGEJIDPMG.mass, vector, ForceMode.Force);
        }



        private void LJLHCGEEMJP(Rigidbody KFLGEJIDPMG, Vector3 CIDNCIAMIOI, Vector3 NGHCPAFEEPP)
        {
            Matrix4x4 localToWorldMatrix = this.IIDKFHMPMHI.transform.localToWorldMatrix;
            Vector3 b = localToWorldMatrix.MultiplyPoint3x4(CIDNCIAMIOI);
            Vector3 a = localToWorldMatrix.MultiplyPoint3x4(NGHCPAFEEPP);
            float t = (Mathf.Cos(this.JNIAPNNKEEF * this.NLNOEABGPGK * 20f - 0.22f) + 1f) * 0.5f;
            Vector3 vector = Vector3.Lerp(a, b, t);
            Vector3 pointVelocity = this.PNGENFLDJAG.GetPointVelocity(vector);
            Vector3 vector2 = Vector3.ClampMagnitude((vector - KFLGEJIDPMG.position) * 100f, 5f) + pointVelocity;
            Vector3 velocity = KFLGEJIDPMG.velocity;
            KFLGEJIDPMG.velocity = vector2;
            this.PNGENFLDJAG.AddForceAtPosition((velocity - vector2) * KFLGEJIDPMG.mass, vector, ForceMode.Impulse);
        }



        private void HLABEPGEPPP(Rigidbody KFLGEJIDPMG, Vector3 CIDNCIAMIOI, Vector3 NGHCPAFEEPP)
        {
            Matrix4x4 localToWorldMatrix = this.OIFCOIHOAPG().transform.localToWorldMatrix;
            Vector3 b = localToWorldMatrix.MultiplyPoint3x4(CIDNCIAMIOI);
            Vector3 a = localToWorldMatrix.MultiplyPoint3x4(NGHCPAFEEPP);
            float t = (Mathf.Cos(this.JNIAPNNKEEF * this.NLNOEABGPGK * 623f - 1886f) + 1852f) * 1536f;
            Vector3 vector = Vector3.Lerp(a, b, t);
            Vector3 pointVelocity = this.PNGENFLDJAG.GetPointVelocity(vector);
            Vector3 vector2 = Vector3.ClampMagnitude((vector - KFLGEJIDPMG.position) * 1814f, 746f) + pointVelocity;
            Vector3 velocity = KFLGEJIDPMG.velocity;
            KFLGEJIDPMG.velocity = vector2;
            this.PNGENFLDJAG.AddForceAtPosition((velocity - vector2) * KFLGEJIDPMG.mass, vector, ForceMode.Force);
        }

        private void JBEBLEJKLDB(Rigidbody KFLGEJIDPMG, Vector3 CIDNCIAMIOI, Vector3 NGHCPAFEEPP)
        {
            Matrix4x4 localToWorldMatrix = this.PBOHKIEDDKG().transform.localToWorldMatrix;
            Vector3 b = localToWorldMatrix.MultiplyPoint3x4(CIDNCIAMIOI);
            Vector3 a = localToWorldMatrix.MultiplyPoint3x4(NGHCPAFEEPP);
            float t = (Mathf.Cos(this.JNIAPNNKEEF * this.NLNOEABGPGK * 182f - 413f) + 1496f) * 1028f;
            Vector3 vector = Vector3.Lerp(a, b, t);
            Vector3 pointVelocity = this.PNGENFLDJAG.GetPointVelocity(vector);
            Vector3 vector2 = Vector3.ClampMagnitude((vector - KFLGEJIDPMG.position) * 514f, 1645f) + pointVelocity;
            Vector3 velocity = KFLGEJIDPMG.velocity;
            KFLGEJIDPMG.velocity = vector2;
            this.PNGENFLDJAG.AddForceAtPosition((velocity - vector2) * KFLGEJIDPMG.mass, vector, ForceMode.Impulse);
        }



        internal void BHKOOPDJPHN(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.JOLJALGNBJD();
                    return;
                }
                this.KCPBCMEFPGJ();
            }
        }









        private void JOLJALGNBJD()
        {
            this.JNIAPNNKEEF = 192f;
            if (Random.Range(402f, 159f) < 1009f)
            {
                this.HDGIJKFHHCC = Random.Range(1591f, 651f);
            }
            else
            {
                this.HDGIJKFHHCC = Random.Range(1128f, 570f);
            }
            this.NLNOEABGPGK = Random.Range(705f, 1419f);
            if (Random.Range(231f, 73f) <= 274f)
            {
                this.KEFHCAOEJOG = false;
                return;
            }
            this.KEFHCAOEJOG = true;
        }

        internal void PPDECDNCEGI(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.FNBPMMFLELB();
                    return;
                }
                this.FHBDGNOENJD();
            }
        }

        private void PECLDOJFGPF(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH)
        {
            if (this.KEFHCAOEJOG)
            {
                if (this.JNIAPNNKEEF >= this.HDGIJKFHHCC - 488f)
                {
                    this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.MALIDDIMDEH, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.MALIDDIMDEH) * 314f);
                    return;
                }
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.COAFJABHKBI, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.COAFJABHKBI) * 138f);
                ALLICKLAKDB.targetRotation = this.IPKCJONBMIE;
                if (this.JNIAPNNKEEF >= 1079f)
                {
                    this.MLLDLNJFNJO(this.LNDDLJMNLBD, this.IFEBLBHGOCN, this.IKHOHIHLADH);
                    return;
                }
            }
            else if (this.JNIAPNNKEEF < this.HDGIJKFHHCC - 771f)
            {
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.IAMPDAJPABO, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.IAMPDAJPABO) * 1855f);
                NHNILCHENEH.targetRotation = this.BNCFPKMKBDK;
                if (this.JNIAPNNKEEF >= 754f)
                {
                    this.MPMOJGPPJNL(this.PIMHHNKOCBE, this.PFCKLMMHHNI, this.IPACPKLFIMJ);
                    return;
                }
            }
            else
            {
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.MALIDDIMDEH, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.MALIDDIMDEH) * 694f);
            }
        }



        internal bool JHCDHDENLIM()
        {
            return this.EBLICPMNBED;
        }

        private void BAHHBDCOMMM(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH)
        {
            if (this.KEFHCAOEJOG)
            {
                if (this.JNIAPNNKEEF >= this.HDGIJKFHHCC - 1f)
                {
                    this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.MALIDDIMDEH, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.MALIDDIMDEH) * 3f);
                    return;
                }
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.COAFJABHKBI, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.COAFJABHKBI) * 2f);
                ALLICKLAKDB.targetRotation = this.IPKCJONBMIE;
                if (this.JNIAPNNKEEF >= 0.22f)
                {
                    this.LJLHCGEEMJP(this.LNDDLJMNLBD, this.IFEBLBHGOCN, this.IKHOHIHLADH);
                    return;
                }
            }
            else if (this.JNIAPNNKEEF < this.HDGIJKFHHCC - 1f)
            {
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.IAMPDAJPABO, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.IAMPDAJPABO) * 2f);
                NHNILCHENEH.targetRotation = this.BNCFPKMKBDK;
                if (this.JNIAPNNKEEF >= 0.22f)
                {
                    this.LJLHCGEEMJP(this.PIMHHNKOCBE, this.PFCKLMMHHNI, this.IPACPKLFIMJ);
                    return;
                }
            }
            else
            {
                this.HJMBEAKLHJJ = Quaternion.RotateTowards(this.HJMBEAKLHJJ, this.MALIDDIMDEH, Time.fixedDeltaTime * Quaternion.Angle(this.HJMBEAKLHJJ, this.MALIDDIMDEH) * 3f);
            }
        }

        internal GameObject GOPEEFADKFK()
        {
            return this.CAKOCGKIAMB;
        }



        private void KCPBCMEFPGJ()
        {
            this.JNIAPNNKEEF = 583f;
        }



        public void DFOJCOJNMCP(ConfigurableJoint NLEHLJPKLCH, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ref float OLFNJPJKOEF)
        {
            if (!this.CLNLHEMOMIJ())
            {
                this.HJMBEAKLHJJ = NLEHLJPKLCH.targetRotation;
                this.PPDECDNCEGI(false);
            }
            this.BCDJLMHHAMN(ALLICKLAKDB, NHNILCHENEH);
            NLEHLJPKLCH.targetRotation = this.HJMBEAKLHJJ;
            OLFNJPJKOEF = this.HDGIJKFHHCC - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 1398f)
            {
                this.HHDFEGEFNFD(true);
            }
        }




        internal void LMMPLLOKOAO(GameObject EEPACGJDMJM)
        {
            if (EEPACGJDMJM != null)
            {
                this.CAKOCGKIAMB = EEPACGJDMJM;
                this.PNGENFLDJAG = EEPACGJDMJM.GetComponent<Rigidbody>();
            }
        }








        public void IGOBPGONHPN(ConfigurableJoint NLEHLJPKLCH, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ref float OLFNJPJKOEF)
        {
            if (!this.AJBGECAEPKA)
            {
                this.HJMBEAKLHJJ = NLEHLJPKLCH.targetRotation;
                this.PPDECDNCEGI(true);
            }
            this.PECLDOJFGPF(ALLICKLAKDB, NHNILCHENEH);
            NLEHLJPKLCH.targetRotation = this.HJMBEAKLHJJ;
            OLFNJPJKOEF = this.HDGIJKFHHCC - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 1902f)
            {
                this.HHDFEGEFNFD(true);
            }
        }



        public void FIFHCJCOGPM(ConfigurableJoint NLEHLJPKLCH, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ref float OLFNJPJKOEF)
        {
            if (!this.HFBFCOIDCGK())
            {
                this.HJMBEAKLHJJ = NLEHLJPKLCH.targetRotation;
                this.BHKOOPDJPHN(true);
            }
            this.LLEDDLCBLGI(ALLICKLAKDB, NHNILCHENEH);
            NLEHLJPKLCH.targetRotation = this.HJMBEAKLHJJ;
            OLFNJPJKOEF = this.HDGIJKFHHCC - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 801f)
            {
                this.JHFIIBPLFKM(true);
            }
        }





        internal GameObject CNAIBABJJLK()
        {
            return this.CAKOCGKIAMB;
        }



        internal void NJIPAAKHFKL(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.NFNKPBCDMLN();
                    return;
                }
                this.CIEKFDDPDHN();
            }
        }

        private void MPMOJGPPJNL(Rigidbody KFLGEJIDPMG, Vector3 CIDNCIAMIOI, Vector3 NGHCPAFEEPP)
        {
            Matrix4x4 localToWorldMatrix = this.ICBOONMJEND().transform.localToWorldMatrix;
            Vector3 b = localToWorldMatrix.MultiplyPoint3x4(CIDNCIAMIOI);
            Vector3 a = localToWorldMatrix.MultiplyPoint3x4(NGHCPAFEEPP);
            float t = (Mathf.Cos(this.JNIAPNNKEEF * this.NLNOEABGPGK * 366f - 890f) + 1585f) * 320f;
            Vector3 vector = Vector3.Lerp(a, b, t);
            Vector3 pointVelocity = this.PNGENFLDJAG.GetPointVelocity(vector);
            Vector3 vector2 = Vector3.ClampMagnitude((vector - KFLGEJIDPMG.position) * 1420f, 145f) + pointVelocity;
            Vector3 velocity = KFLGEJIDPMG.velocity;
            KFLGEJIDPMG.velocity = vector2;
            this.PNGENFLDJAG.AddForceAtPosition((velocity - vector2) * KFLGEJIDPMG.mass, vector, ForceMode.Impulse);
        }



        internal void DAHPGHFFKLG()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }



        internal void NEJHOGLPKCJ(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.CMAFOIPKDPJ();
                    return;
                }
                this.FHBDGNOENJD();
            }
        }



        private void CMAFOIPKDPJ()
        {
            this.JNIAPNNKEEF = 564f;
            if (Random.Range(619f, 1799f) < 1348f)
            {
                this.HDGIJKFHHCC = Random.Range(1183f, 1394f);
            }
            else
            {
                this.HDGIJKFHHCC = Random.Range(242f, 888f);
            }
            this.NLNOEABGPGK = Random.Range(141f, 1783f);
            if (Random.Range(1357f, 433f) <= 1978f)
            {
                this.KEFHCAOEJOG = false;
                return;
            }
            this.KEFHCAOEJOG = true;
        }



        internal GameObject AKFAELLPBNO()
        {
            return this.CAKOCGKIAMB;
        }











        public void PlayScratchAss(ConfigurableJoint NLEHLJPKLCH, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ref float OLFNJPJKOEF)
        {
            if (!this.AJBGECAEPKA)
            {
                this.HJMBEAKLHJJ = NLEHLJPKLCH.targetRotation;
                this.AJBGECAEPKA = true;
            }
            this.BAHHBDCOMMM(ALLICKLAKDB, NHNILCHENEH);
            NLEHLJPKLCH.targetRotation = this.HJMBEAKLHJJ;
            OLFNJPJKOEF = this.HDGIJKFHHCC - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 0f)
            {
                this.AJBGECAEPKA = false;
            }
        }





        internal GameObject OIFCOIHOAPG()
        {
            return this.CAKOCGKIAMB;
        }

        internal GameObject PNMMLIFOOEP()
        {
            return this.CAKOCGKIAMB;
        }

        private bool EBLICPMNBED;

        private float HDGIJKFHHCC;

        private float JNIAPNNKEEF;

        internal Rigidbody LNDDLJMNLBD;

        internal Rigidbody PIMHHNKOCBE;

        private Quaternion COAFJABHKBI = Quaternion.Euler(new Quaternion(0f, -0.14f, -0.15f, 1f).eulerAngles);

        private Quaternion IAMPDAJPABO = Quaternion.Euler(new Quaternion(0f, 0.14f, 0.15f, 1f).eulerAngles);

        private Quaternion MALIDDIMDEH = Quaternion.identity;

        private Quaternion IPKCJONBMIE = Quaternion.Euler(new Quaternion(-0.5f, -0.4f, 0.44f, 1f).eulerAngles);

        private Quaternion BNCFPKMKBDK = Quaternion.Euler(new Quaternion(-0.5f, 0.4f, -0.44f, 1f).eulerAngles);

        private bool KEFHCAOEJOG = true;

        private Quaternion HJMBEAKLHJJ;

        private Vector3 IFEBLBHGOCN = new Vector3(-0.429f, 0.2226f, 0.14f);

        private Vector3 IKHOHIHLADH = new Vector3(-0.429f, 0.2226f, -0.115f);

        private Vector3 PFCKLMMHHNI = new Vector3(0.429f, 0.2226f, 0.14f);

        private Vector3 IPACPKLFIMJ = new Vector3(0.429f, 0.2226f, -0.115f);

        private GameObject CAKOCGKIAMB;

        private Rigidbody PNGENFLDJAG;

        private float NLNOEABGPGK = 1f;
    }
}