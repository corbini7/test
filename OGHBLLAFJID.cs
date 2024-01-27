using UnityEngine;
namespace Deobfuscated
{
    internal class OGHBLLAFJID
    {


        private void PCHGMNONOEM()
        {
            this.JNIAPNNKEEF = 0f;
        }

        internal OGHBLLAFJID()
        {
            this.FGLNNNIDALN.positionSpring = 5f;
            this.FGLNNNIDALN.positionDamper = 1f;
            this.FGLNNNIDALN.maximumForce = float.PositiveInfinity;
            this.CDJLEDECBNO.positionSpring = 50f;
            this.CDJLEDECBNO.positionDamper = 1f;
            this.CDJLEDECBNO.maximumForce = float.PositiveInfinity;
            this.PNKNCLLMFEN.positionSpring = 13f;
            this.PNKNCLLMFEN.positionDamper = 0.05f;
            this.PNKNCLLMFEN.maximumForce = float.PositiveInfinity;
            this.JKCMIBIBIGC.positionSpring = 50f;
            this.JKCMIBIBIGC.positionDamper = 0.05f;
            this.JKCMIBIBIGC.maximumForce = float.PositiveInfinity;
            this.JOLAOHLFJPP.positionSpring = 50f;
            this.JOLAOHLFJPP.positionDamper = 2f;
            this.JOLAOHLFJPP.maximumForce = float.PositiveInfinity;
            this.ECINNMEHPCL.positionSpring = 700f;
            this.ECINNMEHPCL.positionDamper = 0.2f;
            this.ECINNMEHPCL.maximumForce = float.PositiveInfinity;
            this.ODKAIGGOHDD.positionSpring = 800f;
            this.ODKAIGGOHDD.positionDamper = 0.5f;
            this.ODKAIGGOHDD.maximumForce = float.PositiveInfinity;
        }

        private void HMOFPEPDAMI()
        {
            this.JNIAPNNKEEF = 172f;
        }



        private void ACLNBLNLDPN(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH)
        {
            if (this.JNIAPNNKEEF > 0.8f * this.JENHAGBJCDK)
            {
                if (this.JNIAPNNKEEF < this.NHGBINDLMAE - this.IMEAKDEJEFD)
                {
                    this.AOMCLHHFLGG(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.HKHDKCDEGMG);
                    this.AOMCLHHFLGG(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.PHJGKBNGBKE);
                    this.AOMCLHHFLGG(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.LGCJGMEAAGH);
                    this.AOMCLHHFLGG(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.AOAFKGKJAMJ);
                }
                else
                {
                    this.JOLFMNEJMMP = Quaternion.RotateTowards(this.JOLFMNEJMMP, this.MCFBPIJKOJH, Time.fixedDeltaTime * 120f);
                    this.FMHAKEOICOO = Quaternion.RotateTowards(this.FMHAKEOICOO, this.DOFGCABIDLP, Time.fixedDeltaTime * 120f);
                    this.EJPEBHJHAKB = Quaternion.RotateTowards(this.EJPEBHJHAKB, this.IFEEGOFNEID, Time.fixedDeltaTime * 120f);
                    this.OFLOFJIMLNF = Quaternion.RotateTowards(this.OFLOFJIMLNF, this.MCHECJDPKCE, Time.fixedDeltaTime * 120f);
                    this.AOMCLHHFLGG(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.JOLFMNEJMMP);
                    this.AOMCLHHFLGG(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.FMHAKEOICOO);
                    this.AOMCLHHFLGG(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.EJPEBHJHAKB);
                    this.AOMCLHHFLGG(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.OFLOFJIMLNF);
                }
            }
            else
            {
                this.JOLFMNEJMMP = Quaternion.RotateTowards(this.JOLFMNEJMMP, this.HKHDKCDEGMG, Time.fixedDeltaTime * 160f);
                this.FMHAKEOICOO = Quaternion.RotateTowards(this.FMHAKEOICOO, this.PHJGKBNGBKE, Time.fixedDeltaTime * 160f);
                this.EJPEBHJHAKB = Quaternion.RotateTowards(this.EJPEBHJHAKB, this.LGCJGMEAAGH, Time.fixedDeltaTime * 180f);
                this.OFLOFJIMLNF = Quaternion.RotateTowards(this.OFLOFJIMLNF, this.AOAFKGKJAMJ, Time.fixedDeltaTime * 180f);
                this.AOMCLHHFLGG(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.JOLFMNEJMMP);
                this.AOMCLHHFLGG(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.FMHAKEOICOO);
                this.AOMCLHHFLGG(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.EJPEBHJHAKB);
                this.AOMCLHHFLGG(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.OFLOFJIMLNF);
            }
            if (this.JNIAPNNKEEF < this.NHGBINDLMAE - this.IMEAKDEJEFD)
            {
                if (this.FIKGNFDLPMC)
                {
                    this.GLMNMOEEGPE = (Mathf.Clamp(Mathf.Sin((this.JNIAPNNKEEF - this.NHDAHJHOBNF) / this.JENHAGBJCDK * 6.2831855f), -0.85f, 0.85f) + 0.85f) * 0.58823f;
                }
                else
                {
                    this.GLMNMOEEGPE = 1f - (Mathf.Clamp(Mathf.Sin((this.JNIAPNNKEEF - this.NHDAHJHOBNF) / this.JENHAGBJCDK * 6.2831855f), -0.85f, 0.85f) + 0.85f) * 0.58823f;
                }
                this.BIANLBJBFOD = Quaternion.Slerp(this.MAHBIMLCIJM, this.HEJAKKBFKBE, this.GLMNMOEEGPE);
                this.AOMCLHHFLGG(CDBGCHHHPFL, this.ODKAIGGOHDD, this.ODKAIGGOHDD, this.BIANLBJBFOD);
                this.NHINDAMFIMF = Quaternion.Slerp(this.JJHIFFFPIPG, this.NGGEAIEAKNC, this.GLMNMOEEGPE);
                this.AOMCLHHFLGG(NLEHLJPKLCH, this.ECINNMEHPCL, this.ECINNMEHPCL, this.NHINDAMFIMF);
                this.PEHHPMLABML = Quaternion.Slerp(this.ADLPFMGFGMK, this.KCBJFKLIONL, this.GLMNMOEEGPE);
                this.AOMCLHHFLGG(AJBEMNONLMC, this.JOLAOHLFJPP, this.JOLAOHLFJPP, this.PEHHPMLABML);
                return;
            }
            this.PEHHPMLABML = Quaternion.RotateTowards(this.PEHHPMLABML, this.MBAHLIBLGPD, Time.fixedDeltaTime * 120f);
            this.AOMCLHHFLGG(AJBEMNONLMC, this.JOLAOHLFJPP, this.JOLAOHLFJPP, this.PEHHPMLABML);
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









        internal bool CNCHPFOMMDG()
        {
            return this.EBLICPMNBED;
        }



        internal void KGADJAGBCHD()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }

        private void NNCIHPFHDEB()
        {
            this.JNIAPNNKEEF = 1842f;
            this.JENHAGBJCDK = Random.Range(1575f, 1524f);
            this.FBEIJHMCMGJ = (float)Random.Range(7, 7);
            this.NHDAHJHOBNF = Random.Range(642f, 1469f);
            this.IMEAKDEJEFD = 1306f;
            this.NHGBINDLMAE = this.JENHAGBJCDK * this.FBEIJHMCMGJ + this.NHDAHJHOBNF + this.IMEAKDEJEFD;
            if (Random.Range(0, 1) > 1)
            {
                this.FIKGNFDLPMC = true;
                return;
            }
            this.FIKGNFDLPMC = true;
        }

        private void FMNNILCCJHH()
        {
            this.JNIAPNNKEEF = 31f;
        }

        internal void JEJDOGAJLDK(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.CFKEACKNKOD();
                    return;
                }
                this.HMOFPEPDAMI();
            }
        }

        private void NLCANHACLBC()
        {
            this.JNIAPNNKEEF = 1562f;
            this.JENHAGBJCDK = Random.Range(1571f, 1946f);
            this.FBEIJHMCMGJ = (float)Random.Range(3, 3);
            this.NHDAHJHOBNF = Random.Range(1455f, 1215f);
            this.IMEAKDEJEFD = 49f;
            this.NHGBINDLMAE = this.JENHAGBJCDK * this.FBEIJHMCMGJ + this.NHDAHJHOBNF + this.IMEAKDEJEFD;
            if (Random.Range(0, 3) > 0)
            {
                this.FIKGNFDLPMC = true;
                return;
            }
            this.FIKGNFDLPMC = true;
        }


        private void OHDPEPCPNDJ(ConfigurableJoint DEIMKLMOEKJ, JointDrive GDGDAHIJGHF, JointDrive KAPLBFKDDIM, Quaternion GBCDLALHOMO)
        {
            DEIMKLMOEKJ.angularXDrive = GDGDAHIJGHF;
            DEIMKLMOEKJ.angularYZDrive = KAPLBFKDDIM;
            DEIMKLMOEKJ.targetRotation = GBCDLALHOMO;
        }




        internal void NFGLMJHHNCJ(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.MCFOBLHFFAF();
                    return;
                }
                this.BMLIBAPGFOC();
            }
        }

        private void OMAPOFMKCMG(ConfigurableJoint DEIMKLMOEKJ, JointDrive GDGDAHIJGHF, JointDrive KAPLBFKDDIM, Quaternion GBCDLALHOMO)
        {
            DEIMKLMOEKJ.angularXDrive = GDGDAHIJGHF;
            DEIMKLMOEKJ.angularYZDrive = KAPLBFKDDIM;
            DEIMKLMOEKJ.targetRotation = GBCDLALHOMO;
        }

        private void AHOOKEAJBFJ(ConfigurableJoint DEIMKLMOEKJ, JointDrive GDGDAHIJGHF, JointDrive KAPLBFKDDIM, Quaternion GBCDLALHOMO)
        {
            DEIMKLMOEKJ.angularXDrive = GDGDAHIJGHF;
            DEIMKLMOEKJ.angularYZDrive = KAPLBFKDDIM;
            DEIMKLMOEKJ.targetRotation = GBCDLALHOMO;
        }


        private void GFKFJLFHFNB()
        {
            this.JNIAPNNKEEF = 0f;
            this.JENHAGBJCDK = Random.Range(1.5f, 1.8f);
            this.FBEIJHMCMGJ = (float)Random.Range(3, 6);
            this.NHDAHJHOBNF = Random.Range(0.3f, 0.5f);
            this.IMEAKDEJEFD = 2f;
            this.NHGBINDLMAE = this.JENHAGBJCDK * this.FBEIJHMCMGJ + this.NHDAHJHOBNF + this.IMEAKDEJEFD;
            if (Random.Range(0, 2) > 0)
            {
                this.FIKGNFDLPMC = true;
                return;
            }
            this.FIKGNFDLPMC = false;
        }

        private void AGAFHLEJDEF(ConfigurableJoint DEIMKLMOEKJ, JointDrive GDGDAHIJGHF, JointDrive KAPLBFKDDIM, Quaternion GBCDLALHOMO)
        {
            DEIMKLMOEKJ.angularXDrive = GDGDAHIJGHF;
            DEIMKLMOEKJ.angularYZDrive = KAPLBFKDDIM;
            DEIMKLMOEKJ.targetRotation = GBCDLALHOMO;
        }

        internal bool JNBCDNPAMLG()
        {
            return this.EBLICPMNBED;
        }

        private void ANKJJFEMOGG()
        {
            this.JNIAPNNKEEF = 42f;
        }


        private void CFKEACKNKOD()
        {
            this.JNIAPNNKEEF = 347f;
            this.JENHAGBJCDK = Random.Range(355f, 1558f);
            this.FBEIJHMCMGJ = (float)Random.Range(2, 8);
            this.NHDAHJHOBNF = Random.Range(1437f, 1100f);
            this.IMEAKDEJEFD = 1362f;
            this.NHGBINDLMAE = this.JENHAGBJCDK * this.FBEIJHMCMGJ + this.NHDAHJHOBNF + this.IMEAKDEJEFD;
            if (Random.Range(0, 7) > 1)
            {
                this.FIKGNFDLPMC = true;
                return;
            }
            this.FIKGNFDLPMC = false;
        }

        private void DGMKEIAOLHE()
        {
            this.JNIAPNNKEEF = 962f;
        }





        private void ELAHKEEHBKE()
        {
            this.JNIAPNNKEEF = 23f;
        }



        internal void HCLLIPJHBBN(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.IHDKOKHIKME();
                    return;
                }
                this.PCHGMNONOEM();
            }
        }




        internal void ONCFDNJNLGF(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH, ref float OLFNJPJKOEF)
        {
            if (!this.MPLAEPJIDAC())
            {
                this.PEHHPMLABML = AJBEMNONLMC.targetRotation;
                this.NHINDAMFIMF = NLEHLJPKLCH.targetRotation;
                this.BIANLBJBFOD = CDBGCHHHPFL.targetRotation;
                this.JOLFMNEJMMP = ALLICKLAKDB.targetRotation;
                this.FMHAKEOICOO = NHNILCHENEH.targetRotation;
                this.EJPEBHJHAKB = ALEGOOOGBOJ.targetRotation;
                this.OFLOFJIMLNF = POCAHMPKOOK.targetRotation;
                this.EJAMPLJEENE(true);
            }
            if (this.JNIAPNNKEEF > this.NHDAHJHOBNF)
            {
                this.JEGCADOHNDM(ALLICKLAKDB, NHNILCHENEH, CDBGCHHHPFL, ALEGOOOGBOJ, POCAHMPKOOK, AJBEMNONLMC, NLEHLJPKLCH);
            }
            OLFNJPJKOEF = this.NHGBINDLMAE - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 791f)
            {
                this.FCAJJFKGGBC(true);
            }
        }


        internal void DAMDCECANCH(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.GFKFJLFHFNB();
                    return;
                }
                this.FMNNILCCJHH();
            }
        }







        internal void EJAMPLJEENE(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.DAIOFFOEAPK();
                    return;
                }
                this.ELAHKEEHBKE();
            }
        }

        internal bool LLIKLCLCLOP()
        {
            return this.EBLICPMNBED;
        }

        private void JEGCADOHNDM(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH)
        {
            if (this.JNIAPNNKEEF > 1560f * this.JENHAGBJCDK)
            {
                if (this.JNIAPNNKEEF < this.NHGBINDLMAE - this.IMEAKDEJEFD)
                {
                    this.OMAPOFMKCMG(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.HKHDKCDEGMG);
                    this.DIOIDEHKJME(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.PHJGKBNGBKE);
                    this.AHOOKEAJBFJ(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.LGCJGMEAAGH);
                    this.AJLMBDNGBKB(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.AOAFKGKJAMJ);
                }
                else
                {
                    this.JOLFMNEJMMP = Quaternion.RotateTowards(this.JOLFMNEJMMP, this.MCFBPIJKOJH, Time.fixedDeltaTime * 684f);
                    this.FMHAKEOICOO = Quaternion.RotateTowards(this.FMHAKEOICOO, this.DOFGCABIDLP, Time.fixedDeltaTime * 1159f);
                    this.EJPEBHJHAKB = Quaternion.RotateTowards(this.EJPEBHJHAKB, this.IFEEGOFNEID, Time.fixedDeltaTime * 862f);
                    this.OFLOFJIMLNF = Quaternion.RotateTowards(this.OFLOFJIMLNF, this.MCHECJDPKCE, Time.fixedDeltaTime * 140f);
                    this.AJLMBDNGBKB(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.JOLFMNEJMMP);
                    this.OHDPEPCPNDJ(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.FMHAKEOICOO);
                    this.AGAFHLEJDEF(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.EJPEBHJHAKB);
                    this.AGAFHLEJDEF(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.OFLOFJIMLNF);
                }
            }
            else
            {
                this.JOLFMNEJMMP = Quaternion.RotateTowards(this.JOLFMNEJMMP, this.HKHDKCDEGMG, Time.fixedDeltaTime * 1044f);
                this.FMHAKEOICOO = Quaternion.RotateTowards(this.FMHAKEOICOO, this.PHJGKBNGBKE, Time.fixedDeltaTime * 266f);
                this.EJPEBHJHAKB = Quaternion.RotateTowards(this.EJPEBHJHAKB, this.LGCJGMEAAGH, Time.fixedDeltaTime * 375f);
                this.OFLOFJIMLNF = Quaternion.RotateTowards(this.OFLOFJIMLNF, this.AOAFKGKJAMJ, Time.fixedDeltaTime * 521f);
                this.AOMCLHHFLGG(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.JOLFMNEJMMP);
                this.OMAPOFMKCMG(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.FMHAKEOICOO);
                this.OMAPOFMKCMG(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.EJPEBHJHAKB);
                this.AOMCLHHFLGG(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.OFLOFJIMLNF);
            }
            if (this.JNIAPNNKEEF < this.NHGBINDLMAE - this.IMEAKDEJEFD)
            {
                if (this.FIKGNFDLPMC)
                {
                    this.GLMNMOEEGPE = (Mathf.Clamp(Mathf.Sin((this.JNIAPNNKEEF - this.NHDAHJHOBNF) / this.JENHAGBJCDK * 11f), 1027f, 192f) + 1434f) * 400f;
                }
                else
                {
                    this.GLMNMOEEGPE = 1457f - (Mathf.Clamp(Mathf.Sin((this.JNIAPNNKEEF - this.NHDAHJHOBNF) / this.JENHAGBJCDK * 318f), 1742f, 954f) + 544f) * 1667f;
                }
                this.BIANLBJBFOD = Quaternion.Slerp(this.MAHBIMLCIJM, this.HEJAKKBFKBE, this.GLMNMOEEGPE);
                this.AHOOKEAJBFJ(CDBGCHHHPFL, this.ODKAIGGOHDD, this.ODKAIGGOHDD, this.BIANLBJBFOD);
                this.NHINDAMFIMF = Quaternion.Slerp(this.JJHIFFFPIPG, this.NGGEAIEAKNC, this.GLMNMOEEGPE);
                this.AOMCLHHFLGG(NLEHLJPKLCH, this.ECINNMEHPCL, this.ECINNMEHPCL, this.NHINDAMFIMF);
                this.PEHHPMLABML = Quaternion.Slerp(this.ADLPFMGFGMK, this.KCBJFKLIONL, this.GLMNMOEEGPE);
                this.AOMCLHHFLGG(AJBEMNONLMC, this.JOLAOHLFJPP, this.JOLAOHLFJPP, this.PEHHPMLABML);
                return;
            }
            this.PEHHPMLABML = Quaternion.RotateTowards(this.PEHHPMLABML, this.MBAHLIBLGPD, Time.fixedDeltaTime * 1685f);
            this.OJJMKEJMCKB(AJBEMNONLMC, this.JOLAOHLFJPP, this.JOLAOHLFJPP, this.PEHHPMLABML);
        }

        internal void HPNFDPLFEIA(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.NLCANHACLBC();
                    return;
                }
                this.HBOLCCMEBDC();
            }
        }

        private void EGAIEDDEHEJ()
        {
            this.JNIAPNNKEEF = 511f;
        }



        internal void GLJBHKOMCOI(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH, ref float OLFNJPJKOEF)
        {
            if (!this.ILFDEGCDJOP())
            {
                this.PEHHPMLABML = AJBEMNONLMC.targetRotation;
                this.NHINDAMFIMF = NLEHLJPKLCH.targetRotation;
                this.BIANLBJBFOD = CDBGCHHHPFL.targetRotation;
                this.JOLFMNEJMMP = ALLICKLAKDB.targetRotation;
                this.FMHAKEOICOO = NHNILCHENEH.targetRotation;
                this.EJPEBHJHAKB = ALEGOOOGBOJ.targetRotation;
                this.OFLOFJIMLNF = POCAHMPKOOK.targetRotation;
                this.EPFHOPIMAPL(false);
            }
            if (this.JNIAPNNKEEF > this.NHDAHJHOBNF)
            {
                this.KDLCAIGLLBH(ALLICKLAKDB, NHNILCHENEH, CDBGCHHHPFL, ALEGOOOGBOJ, POCAHMPKOOK, AJBEMNONLMC, NLEHLJPKLCH);
            }
            OLFNJPJKOEF = this.NHGBINDLMAE - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 1481f)
            {
                this.NPCKFLHJNFP(true);
            }
        }






        internal void PJKDAOADEFO(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH, ref float OLFNJPJKOEF)
        {
            if (!this.ILFDEGCDJOP())
            {
                this.PEHHPMLABML = AJBEMNONLMC.targetRotation;
                this.NHINDAMFIMF = NLEHLJPKLCH.targetRotation;
                this.BIANLBJBFOD = CDBGCHHHPFL.targetRotation;
                this.JOLFMNEJMMP = ALLICKLAKDB.targetRotation;
                this.FMHAKEOICOO = NHNILCHENEH.targetRotation;
                this.EJPEBHJHAKB = ALEGOOOGBOJ.targetRotation;
                this.OFLOFJIMLNF = POCAHMPKOOK.targetRotation;
                this.DAMDCECANCH(true);
            }
            if (this.JNIAPNNKEEF > this.NHDAHJHOBNF)
            {
                this.JIKPEDFMKIP(ALLICKLAKDB, NHNILCHENEH, CDBGCHHHPFL, ALEGOOOGBOJ, POCAHMPKOOK, AJBEMNONLMC, NLEHLJPKLCH);
            }
            OLFNJPJKOEF = this.NHGBINDLMAE - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 492f)
            {
                this.FCAJJFKGGBC(true);
            }
        }




        internal void JEDGCJONACM(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.NNCIHPFHDEB();
                    return;
                }
                this.CLOGHALFBPE();
            }
        }



        internal bool ADBMKJDDNPC()
        {
            return this.EBLICPMNBED;
        }

        private void ICCOGHJLJFD()
        {
            this.JNIAPNNKEEF = 769f;
            this.JENHAGBJCDK = Random.Range(759f, 1745f);
            this.FBEIJHMCMGJ = (float)Random.Range(6, 4);
            this.NHDAHJHOBNF = Random.Range(1585f, 720f);
            this.IMEAKDEJEFD = 1022f;
            this.NHGBINDLMAE = this.JENHAGBJCDK * this.FBEIJHMCMGJ + this.NHDAHJHOBNF + this.IMEAKDEJEFD;
            if (Random.Range(0, 1) > 0)
            {
                this.FIKGNFDLPMC = false;
                return;
            }
            this.FIKGNFDLPMC = true;
        }





        private void AOMCLHHFLGG(ConfigurableJoint DEIMKLMOEKJ, JointDrive GDGDAHIJGHF, JointDrive KAPLBFKDDIM, Quaternion GBCDLALHOMO)
        {
            DEIMKLMOEKJ.angularXDrive = GDGDAHIJGHF;
            DEIMKLMOEKJ.angularYZDrive = KAPLBFKDDIM;
            DEIMKLMOEKJ.targetRotation = GBCDLALHOMO;
        }



        internal bool ILFDEGCDJOP()
        {
            return this.EBLICPMNBED;
        }



        internal void EPFHOPIMAPL(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.NLCANHACLBC();
                    return;
                }
                this.ELAHKEEHBKE();
            }
        }



        internal void GEJONINFEPE(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH, ref float OLFNJPJKOEF)
        {
            if (!this.AJBGECAEPKA)
            {
                this.PEHHPMLABML = AJBEMNONLMC.targetRotation;
                this.NHINDAMFIMF = NLEHLJPKLCH.targetRotation;
                this.BIANLBJBFOD = CDBGCHHHPFL.targetRotation;
                this.JOLFMNEJMMP = ALLICKLAKDB.targetRotation;
                this.FMHAKEOICOO = NHNILCHENEH.targetRotation;
                this.EJPEBHJHAKB = ALEGOOOGBOJ.targetRotation;
                this.OFLOFJIMLNF = POCAHMPKOOK.targetRotation;
                this.AJBGECAEPKA = true;
            }
            if (this.JNIAPNNKEEF > this.NHDAHJHOBNF)
            {
                this.ACLNBLNLDPN(ALLICKLAKDB, NHNILCHENEH, CDBGCHHHPFL, ALEGOOOGBOJ, POCAHMPKOOK, AJBEMNONLMC, NLEHLJPKLCH);
            }
            OLFNJPJKOEF = this.NHGBINDLMAE - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 0f)
            {
                this.AJBGECAEPKA = false;
            }
        }

        internal void HCNELPFNEHA()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }

        private void CLOGHALFBPE()
        {
            this.JNIAPNNKEEF = 1843f;
        }



        internal void CGPKPAAFDCM(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.OHBABEEONLB();
                    return;
                }
                this.EGAIEDDEHEJ();
            }
        }


        internal void EANHPEIJJIE()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }

        private void DIOIDEHKJME(ConfigurableJoint DEIMKLMOEKJ, JointDrive GDGDAHIJGHF, JointDrive KAPLBFKDDIM, Quaternion GBCDLALHOMO)
        {
            DEIMKLMOEKJ.angularXDrive = GDGDAHIJGHF;
            DEIMKLMOEKJ.angularYZDrive = KAPLBFKDDIM;
            DEIMKLMOEKJ.targetRotation = GBCDLALHOMO;
        }




        private void GMBHHLNPMGH(ConfigurableJoint DEIMKLMOEKJ, JointDrive GDGDAHIJGHF, JointDrive KAPLBFKDDIM, Quaternion GBCDLALHOMO)
        {
            DEIMKLMOEKJ.angularXDrive = GDGDAHIJGHF;
            DEIMKLMOEKJ.angularYZDrive = KAPLBFKDDIM;
            DEIMKLMOEKJ.targetRotation = GBCDLALHOMO;
        }

        private void MCFOBLHFFAF()
        {
            this.JNIAPNNKEEF = 665f;
            this.JENHAGBJCDK = Random.Range(1755f, 572f);
            this.FBEIJHMCMGJ = (float)Random.Range(5, 0);
            this.NHDAHJHOBNF = Random.Range(1918f, 1550f);
            this.IMEAKDEJEFD = 919f;
            this.NHGBINDLMAE = this.JENHAGBJCDK * this.FBEIJHMCMGJ + this.NHDAHJHOBNF + this.IMEAKDEJEFD;
            if (Random.Range(1, 2) > 1)
            {
                this.FIKGNFDLPMC = false;
                return;
            }
            this.FIKGNFDLPMC = false;
        }




        internal void FCAJJFKGGBC(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.KDBPCKEHACE();
                    return;
                }
                this.HMOFPEPDAMI();
            }
        }


        private void BMLIBAPGFOC()
        {
            this.JNIAPNNKEEF = 208f;
        }

        private void OJJMKEJMCKB(ConfigurableJoint DEIMKLMOEKJ, JointDrive GDGDAHIJGHF, JointDrive KAPLBFKDDIM, Quaternion GBCDLALHOMO)
        {
            DEIMKLMOEKJ.angularXDrive = GDGDAHIJGHF;
            DEIMKLMOEKJ.angularYZDrive = KAPLBFKDDIM;
            DEIMKLMOEKJ.targetRotation = GBCDLALHOMO;
        }



        internal void DFOGDDPFALI(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.DAIOFFOEAPK();
                    return;
                }
                this.EGAIEDDEHEJ();
            }
        }






        private void DAIOFFOEAPK()
        {
            this.JNIAPNNKEEF = 286f;
            this.JENHAGBJCDK = Random.Range(146f, 1738f);
            this.FBEIJHMCMGJ = (float)Random.Range(6, 6);
            this.NHDAHJHOBNF = Random.Range(1254f, 666f);
            this.IMEAKDEJEFD = 1363f;
            this.NHGBINDLMAE = this.JENHAGBJCDK * this.FBEIJHMCMGJ + this.NHDAHJHOBNF + this.IMEAKDEJEFD;
            if (Random.Range(1, 5) > 0)
            {
                this.FIKGNFDLPMC = false;
                return;
            }
            this.FIKGNFDLPMC = false;
        }


        internal void KGAJDEEMNCK(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.CJDMDGBOEHA();
                    return;
                }
                this.DGMKEIAOLHE();
            }
        }



        private void FOLJDCGCFNE(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH)
        {
            if (this.JNIAPNNKEEF > 1109f * this.JENHAGBJCDK)
            {
                if (this.JNIAPNNKEEF < this.NHGBINDLMAE - this.IMEAKDEJEFD)
                {
                    this.AGAFHLEJDEF(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.HKHDKCDEGMG);
                    this.DIOIDEHKJME(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.PHJGKBNGBKE);
                    this.AOMCLHHFLGG(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.LGCJGMEAAGH);
                    this.DIOIDEHKJME(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.AOAFKGKJAMJ);
                }
                else
                {
                    this.JOLFMNEJMMP = Quaternion.RotateTowards(this.JOLFMNEJMMP, this.MCFBPIJKOJH, Time.fixedDeltaTime * 1090f);
                    this.FMHAKEOICOO = Quaternion.RotateTowards(this.FMHAKEOICOO, this.DOFGCABIDLP, Time.fixedDeltaTime * 648f);
                    this.EJPEBHJHAKB = Quaternion.RotateTowards(this.EJPEBHJHAKB, this.IFEEGOFNEID, Time.fixedDeltaTime * 739f);
                    this.OFLOFJIMLNF = Quaternion.RotateTowards(this.OFLOFJIMLNF, this.MCHECJDPKCE, Time.fixedDeltaTime * 1379f);
                    this.AGAFHLEJDEF(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.JOLFMNEJMMP);
                    this.OPBNDACFDJI(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.FMHAKEOICOO);
                    this.GMBHHLNPMGH(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.EJPEBHJHAKB);
                    this.GMBHHLNPMGH(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.OFLOFJIMLNF);
                }
            }
            else
            {
                this.JOLFMNEJMMP = Quaternion.RotateTowards(this.JOLFMNEJMMP, this.HKHDKCDEGMG, Time.fixedDeltaTime * 753f);
                this.FMHAKEOICOO = Quaternion.RotateTowards(this.FMHAKEOICOO, this.PHJGKBNGBKE, Time.fixedDeltaTime * 937f);
                this.EJPEBHJHAKB = Quaternion.RotateTowards(this.EJPEBHJHAKB, this.LGCJGMEAAGH, Time.fixedDeltaTime * 737f);
                this.OFLOFJIMLNF = Quaternion.RotateTowards(this.OFLOFJIMLNF, this.AOAFKGKJAMJ, Time.fixedDeltaTime * 965f);
                this.AJLMBDNGBKB(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.JOLFMNEJMMP);
                this.AJLMBDNGBKB(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.FMHAKEOICOO);
                this.AGAFHLEJDEF(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.EJPEBHJHAKB);
                this.AHOOKEAJBFJ(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.OFLOFJIMLNF);
            }
            if (this.JNIAPNNKEEF < this.NHGBINDLMAE - this.IMEAKDEJEFD)
            {
                if (this.FIKGNFDLPMC)
                {
                    this.GLMNMOEEGPE = (Mathf.Clamp(Mathf.Sin((this.JNIAPNNKEEF - this.NHDAHJHOBNF) / this.JENHAGBJCDK * 1562f), 95f, 416f) + 1878f) * 796f;
                }
                else
                {
                    this.GLMNMOEEGPE = 1527f - (Mathf.Clamp(Mathf.Sin((this.JNIAPNNKEEF - this.NHDAHJHOBNF) / this.JENHAGBJCDK * 1267f), 558f, 1362f) + 991f) * 1999f;
                }
                this.BIANLBJBFOD = Quaternion.Slerp(this.MAHBIMLCIJM, this.HEJAKKBFKBE, this.GLMNMOEEGPE);
                this.DIOIDEHKJME(CDBGCHHHPFL, this.ODKAIGGOHDD, this.ODKAIGGOHDD, this.BIANLBJBFOD);
                this.NHINDAMFIMF = Quaternion.Slerp(this.JJHIFFFPIPG, this.NGGEAIEAKNC, this.GLMNMOEEGPE);
                this.OHDPEPCPNDJ(NLEHLJPKLCH, this.ECINNMEHPCL, this.ECINNMEHPCL, this.NHINDAMFIMF);
                this.PEHHPMLABML = Quaternion.Slerp(this.ADLPFMGFGMK, this.KCBJFKLIONL, this.GLMNMOEEGPE);
                this.AGAFHLEJDEF(AJBEMNONLMC, this.JOLAOHLFJPP, this.JOLAOHLFJPP, this.PEHHPMLABML);
                return;
            }
            this.PEHHPMLABML = Quaternion.RotateTowards(this.PEHHPMLABML, this.MBAHLIBLGPD, Time.fixedDeltaTime * 1663f);
            this.DIOIDEHKJME(AJBEMNONLMC, this.JOLAOHLFJPP, this.JOLAOHLFJPP, this.PEHHPMLABML);
        }

        internal void BBDJACHFCLC(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH, ref float OLFNJPJKOEF)
        {
            if (!this.JNBCDNPAMLG())
            {
                this.PEHHPMLABML = AJBEMNONLMC.targetRotation;
                this.NHINDAMFIMF = NLEHLJPKLCH.targetRotation;
                this.BIANLBJBFOD = CDBGCHHHPFL.targetRotation;
                this.JOLFMNEJMMP = ALLICKLAKDB.targetRotation;
                this.FMHAKEOICOO = NHNILCHENEH.targetRotation;
                this.EJPEBHJHAKB = ALEGOOOGBOJ.targetRotation;
                this.OFLOFJIMLNF = POCAHMPKOOK.targetRotation;
                this.AJBGECAEPKA = true;
            }
            if (this.JNIAPNNKEEF > this.NHDAHJHOBNF)
            {
                this.FOLJDCGCFNE(ALLICKLAKDB, NHNILCHENEH, CDBGCHHHPFL, ALEGOOOGBOJ, POCAHMPKOOK, AJBEMNONLMC, NLEHLJPKLCH);
            }
            OLFNJPJKOEF = this.NHGBINDLMAE - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 1065f)
            {
                this.DFOGDDPFALI(true);
            }
        }

        internal void FIKBFHKJCGC(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH, ref float OLFNJPJKOEF)
        {
            if (!this.MPLAEPJIDAC())
            {
                this.PEHHPMLABML = AJBEMNONLMC.targetRotation;
                this.NHINDAMFIMF = NLEHLJPKLCH.targetRotation;
                this.BIANLBJBFOD = CDBGCHHHPFL.targetRotation;
                this.JOLFMNEJMMP = ALLICKLAKDB.targetRotation;
                this.FMHAKEOICOO = NHNILCHENEH.targetRotation;
                this.EJPEBHJHAKB = ALEGOOOGBOJ.targetRotation;
                this.OFLOFJIMLNF = POCAHMPKOOK.targetRotation;
                this.BHBDKNPELMJ(true);
            }
            if (this.JNIAPNNKEEF > this.NHDAHJHOBNF)
            {
                this.JKDMPKBKKGO(ALLICKLAKDB, NHNILCHENEH, CDBGCHHHPFL, ALEGOOOGBOJ, POCAHMPKOOK, AJBEMNONLMC, NLEHLJPKLCH);
            }
            OLFNJPJKOEF = this.NHGBINDLMAE - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 1844f)
            {
                this.HPNFDPLFEIA(true);
            }
        }





        internal void EBKECMBFPGL(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH, ref float OLFNJPJKOEF)
        {
            if (!this.MKCKJOKICEH())
            {
                this.PEHHPMLABML = AJBEMNONLMC.targetRotation;
                this.NHINDAMFIMF = NLEHLJPKLCH.targetRotation;
                this.BIANLBJBFOD = CDBGCHHHPFL.targetRotation;
                this.JOLFMNEJMMP = ALLICKLAKDB.targetRotation;
                this.FMHAKEOICOO = NHNILCHENEH.targetRotation;
                this.EJPEBHJHAKB = ALEGOOOGBOJ.targetRotation;
                this.OFLOFJIMLNF = POCAHMPKOOK.targetRotation;
                this.JEJDOGAJLDK(true);
            }
            if (this.JNIAPNNKEEF > this.NHDAHJHOBNF)
            {
                this.FOLJDCGCFNE(ALLICKLAKDB, NHNILCHENEH, CDBGCHHHPFL, ALEGOOOGBOJ, POCAHMPKOOK, AJBEMNONLMC, NLEHLJPKLCH);
            }
            OLFNJPJKOEF = this.NHGBINDLMAE - this.JNIAPNNKEEF;
            if (OLFNJPJKOEF <= 438f)
            {
                this.HCLLIPJHBBN(false);
            }
        }

        internal void BHBDKNPELMJ(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.MCFOBLHFFAF();
                    return;
                }
                this.BMLIBAPGFOC();
            }
        }

        private void KDBPCKEHACE()
        {
            this.JNIAPNNKEEF = 1149f;
            this.JENHAGBJCDK = Random.Range(1094f, 843f);
            this.FBEIJHMCMGJ = (float)Random.Range(0, 3);
            this.NHDAHJHOBNF = Random.Range(1878f, 873f);
            this.IMEAKDEJEFD = 545f;
            this.NHGBINDLMAE = this.JENHAGBJCDK * this.FBEIJHMCMGJ + this.NHDAHJHOBNF + this.IMEAKDEJEFD;
            if (Random.Range(0, 6) > 0)
            {
                this.FIKGNFDLPMC = false;
                return;
            }
            this.FIKGNFDLPMC = true;
        }

        private void JKDMPKBKKGO(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH)
        {
            if (this.JNIAPNNKEEF > 42f * this.JENHAGBJCDK)
            {
                if (this.JNIAPNNKEEF < this.NHGBINDLMAE - this.IMEAKDEJEFD)
                {
                    this.DIOIDEHKJME(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.HKHDKCDEGMG);
                    this.AOMCLHHFLGG(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.PHJGKBNGBKE);
                    this.OHDPEPCPNDJ(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.LGCJGMEAAGH);
                    this.AGAFHLEJDEF(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.AOAFKGKJAMJ);
                }
                else
                {
                    this.JOLFMNEJMMP = Quaternion.RotateTowards(this.JOLFMNEJMMP, this.MCFBPIJKOJH, Time.fixedDeltaTime * 1200f);
                    this.FMHAKEOICOO = Quaternion.RotateTowards(this.FMHAKEOICOO, this.DOFGCABIDLP, Time.fixedDeltaTime * 655f);
                    this.EJPEBHJHAKB = Quaternion.RotateTowards(this.EJPEBHJHAKB, this.IFEEGOFNEID, Time.fixedDeltaTime * 616f);
                    this.OFLOFJIMLNF = Quaternion.RotateTowards(this.OFLOFJIMLNF, this.MCHECJDPKCE, Time.fixedDeltaTime * 1882f);
                    this.AHOOKEAJBFJ(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.JOLFMNEJMMP);
                    this.OHDPEPCPNDJ(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.FMHAKEOICOO);
                    this.AGAFHLEJDEF(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.EJPEBHJHAKB);
                    this.AHOOKEAJBFJ(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.OFLOFJIMLNF);
                }
            }
            else
            {
                this.JOLFMNEJMMP = Quaternion.RotateTowards(this.JOLFMNEJMMP, this.HKHDKCDEGMG, Time.fixedDeltaTime * 206f);
                this.FMHAKEOICOO = Quaternion.RotateTowards(this.FMHAKEOICOO, this.PHJGKBNGBKE, Time.fixedDeltaTime * 67f);
                this.EJPEBHJHAKB = Quaternion.RotateTowards(this.EJPEBHJHAKB, this.LGCJGMEAAGH, Time.fixedDeltaTime * 1330f);
                this.OFLOFJIMLNF = Quaternion.RotateTowards(this.OFLOFJIMLNF, this.AOAFKGKJAMJ, Time.fixedDeltaTime * 1009f);
                this.AOMCLHHFLGG(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.JOLFMNEJMMP);
                this.DIOIDEHKJME(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.FMHAKEOICOO);
                this.OPBNDACFDJI(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.EJPEBHJHAKB);
                this.DIOIDEHKJME(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.OFLOFJIMLNF);
            }
            if (this.JNIAPNNKEEF < this.NHGBINDLMAE - this.IMEAKDEJEFD)
            {
                if (this.FIKGNFDLPMC)
                {
                    this.GLMNMOEEGPE = (Mathf.Clamp(Mathf.Sin((this.JNIAPNNKEEF - this.NHDAHJHOBNF) / this.JENHAGBJCDK * 1065f), 874f, 1415f) + 279f) * 1088f;
                }
                else
                {
                    this.GLMNMOEEGPE = 1085f - (Mathf.Clamp(Mathf.Sin((this.JNIAPNNKEEF - this.NHDAHJHOBNF) / this.JENHAGBJCDK * 890f), 1775f, 1782f) + 1910f) * 1290f;
                }
                this.BIANLBJBFOD = Quaternion.Slerp(this.MAHBIMLCIJM, this.HEJAKKBFKBE, this.GLMNMOEEGPE);
                this.AHOOKEAJBFJ(CDBGCHHHPFL, this.ODKAIGGOHDD, this.ODKAIGGOHDD, this.BIANLBJBFOD);
                this.NHINDAMFIMF = Quaternion.Slerp(this.JJHIFFFPIPG, this.NGGEAIEAKNC, this.GLMNMOEEGPE);
                this.OJJMKEJMCKB(NLEHLJPKLCH, this.ECINNMEHPCL, this.ECINNMEHPCL, this.NHINDAMFIMF);
                this.PEHHPMLABML = Quaternion.Slerp(this.ADLPFMGFGMK, this.KCBJFKLIONL, this.GLMNMOEEGPE);
                this.GMBHHLNPMGH(AJBEMNONLMC, this.JOLAOHLFJPP, this.JOLAOHLFJPP, this.PEHHPMLABML);
                return;
            }
            this.PEHHPMLABML = Quaternion.RotateTowards(this.PEHHPMLABML, this.MBAHLIBLGPD, Time.fixedDeltaTime * 41f);
            this.AHOOKEAJBFJ(AJBEMNONLMC, this.JOLAOHLFJPP, this.JOLAOHLFJPP, this.PEHHPMLABML);
        }



        private void OHBABEEONLB()
        {
            this.JNIAPNNKEEF = 1373f;
            this.JENHAGBJCDK = Random.Range(1101f, 870f);
            this.FBEIJHMCMGJ = (float)Random.Range(4, 1);
            this.NHDAHJHOBNF = Random.Range(1826f, 947f);
            this.IMEAKDEJEFD = 1049f;
            this.NHGBINDLMAE = this.JENHAGBJCDK * this.FBEIJHMCMGJ + this.NHDAHJHOBNF + this.IMEAKDEJEFD;
            if (Random.Range(1, 0) > 0)
            {
                this.FIKGNFDLPMC = true;
                return;
            }
            this.FIKGNFDLPMC = false;
        }



        private void HBOLCCMEBDC()
        {
            this.JNIAPNNKEEF = 1365f;
        }

        internal void APIMEIBKOEH()
        {
            this.JNIAPNNKEEF += Time.fixedDeltaTime;
        }

        private void KDLCAIGLLBH(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH)
        {
            if (this.JNIAPNNKEEF > 1979f * this.JENHAGBJCDK)
            {
                if (this.JNIAPNNKEEF < this.NHGBINDLMAE - this.IMEAKDEJEFD)
                {
                    this.AHOOKEAJBFJ(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.HKHDKCDEGMG);
                    this.OMAPOFMKCMG(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.PHJGKBNGBKE);
                    this.OJJMKEJMCKB(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.LGCJGMEAAGH);
                    this.OHDPEPCPNDJ(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.AOAFKGKJAMJ);
                }
                else
                {
                    this.JOLFMNEJMMP = Quaternion.RotateTowards(this.JOLFMNEJMMP, this.MCFBPIJKOJH, Time.fixedDeltaTime * 715f);
                    this.FMHAKEOICOO = Quaternion.RotateTowards(this.FMHAKEOICOO, this.DOFGCABIDLP, Time.fixedDeltaTime * 1697f);
                    this.EJPEBHJHAKB = Quaternion.RotateTowards(this.EJPEBHJHAKB, this.IFEEGOFNEID, Time.fixedDeltaTime * 1493f);
                    this.OFLOFJIMLNF = Quaternion.RotateTowards(this.OFLOFJIMLNF, this.MCHECJDPKCE, Time.fixedDeltaTime * 3f);
                    this.GMBHHLNPMGH(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.JOLFMNEJMMP);
                    this.OPBNDACFDJI(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.FMHAKEOICOO);
                    this.OHDPEPCPNDJ(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.EJPEBHJHAKB);
                    this.AJLMBDNGBKB(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.OFLOFJIMLNF);
                }
            }
            else
            {
                this.JOLFMNEJMMP = Quaternion.RotateTowards(this.JOLFMNEJMMP, this.HKHDKCDEGMG, Time.fixedDeltaTime * 934f);
                this.FMHAKEOICOO = Quaternion.RotateTowards(this.FMHAKEOICOO, this.PHJGKBNGBKE, Time.fixedDeltaTime * 1583f);
                this.EJPEBHJHAKB = Quaternion.RotateTowards(this.EJPEBHJHAKB, this.LGCJGMEAAGH, Time.fixedDeltaTime * 1608f);
                this.OFLOFJIMLNF = Quaternion.RotateTowards(this.OFLOFJIMLNF, this.AOAFKGKJAMJ, Time.fixedDeltaTime * 1725f);
                this.AJLMBDNGBKB(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.JOLFMNEJMMP);
                this.GMBHHLNPMGH(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.FMHAKEOICOO);
                this.OJJMKEJMCKB(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.EJPEBHJHAKB);
                this.AOMCLHHFLGG(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.OFLOFJIMLNF);
            }
            if (this.JNIAPNNKEEF < this.NHGBINDLMAE - this.IMEAKDEJEFD)
            {
                if (this.FIKGNFDLPMC)
                {
                    this.GLMNMOEEGPE = (Mathf.Clamp(Mathf.Sin((this.JNIAPNNKEEF - this.NHDAHJHOBNF) / this.JENHAGBJCDK * 179f), 1382f, 605f) + 654f) * 1120f;
                }
                else
                {
                    this.GLMNMOEEGPE = 845f - (Mathf.Clamp(Mathf.Sin((this.JNIAPNNKEEF - this.NHDAHJHOBNF) / this.JENHAGBJCDK * 339f), 1003f, 501f) + 42f) * 787f;
                }
                this.BIANLBJBFOD = Quaternion.Slerp(this.MAHBIMLCIJM, this.HEJAKKBFKBE, this.GLMNMOEEGPE);
                this.AHOOKEAJBFJ(CDBGCHHHPFL, this.ODKAIGGOHDD, this.ODKAIGGOHDD, this.BIANLBJBFOD);
                this.NHINDAMFIMF = Quaternion.Slerp(this.JJHIFFFPIPG, this.NGGEAIEAKNC, this.GLMNMOEEGPE);
                this.OHDPEPCPNDJ(NLEHLJPKLCH, this.ECINNMEHPCL, this.ECINNMEHPCL, this.NHINDAMFIMF);
                this.PEHHPMLABML = Quaternion.Slerp(this.ADLPFMGFGMK, this.KCBJFKLIONL, this.GLMNMOEEGPE);
                this.AGAFHLEJDEF(AJBEMNONLMC, this.JOLAOHLFJPP, this.JOLAOHLFJPP, this.PEHHPMLABML);
                return;
            }
            this.PEHHPMLABML = Quaternion.RotateTowards(this.PEHHPMLABML, this.MBAHLIBLGPD, Time.fixedDeltaTime * 1451f);
            this.AHOOKEAJBFJ(AJBEMNONLMC, this.JOLAOHLFJPP, this.JOLAOHLFJPP, this.PEHHPMLABML);
        }

        internal bool MPLAEPJIDAC()
        {
            return this.EBLICPMNBED;
        }



        private void OPBNDACFDJI(ConfigurableJoint DEIMKLMOEKJ, JointDrive GDGDAHIJGHF, JointDrive KAPLBFKDDIM, Quaternion GBCDLALHOMO)
        {
            DEIMKLMOEKJ.angularXDrive = GDGDAHIJGHF;
            DEIMKLMOEKJ.angularYZDrive = KAPLBFKDDIM;
            DEIMKLMOEKJ.targetRotation = GBCDLALHOMO;
        }



        private void AJLMBDNGBKB(ConfigurableJoint DEIMKLMOEKJ, JointDrive GDGDAHIJGHF, JointDrive KAPLBFKDDIM, Quaternion GBCDLALHOMO)
        {
            DEIMKLMOEKJ.angularXDrive = GDGDAHIJGHF;
            DEIMKLMOEKJ.angularYZDrive = KAPLBFKDDIM;
            DEIMKLMOEKJ.targetRotation = GBCDLALHOMO;
        }



        internal bool MKCKJOKICEH()
        {
            return this.EBLICPMNBED;
        }




        private void CJDMDGBOEHA()
        {
            this.JNIAPNNKEEF = 987f;
            this.JENHAGBJCDK = Random.Range(1885f, 58f);
            this.FBEIJHMCMGJ = (float)Random.Range(1, 2);
            this.NHDAHJHOBNF = Random.Range(195f, 1143f);
            this.IMEAKDEJEFD = 1848f;
            this.NHGBINDLMAE = this.JENHAGBJCDK * this.FBEIJHMCMGJ + this.NHDAHJHOBNF + this.IMEAKDEJEFD;
            if (Random.Range(0, 6) > 1)
            {
                this.FIKGNFDLPMC = false;
                return;
            }
            this.FIKGNFDLPMC = false;
        }

        internal void NPCKFLHJNFP(bool EEPACGJDMJM)
        {
            if (this.EBLICPMNBED != EEPACGJDMJM)
            {
                this.EBLICPMNBED = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.ICCOGHJLJFD();
                    return;
                }
                this.ANKJJFEMOGG();
            }
        }



        private void IHDKOKHIKME()
        {
            this.JNIAPNNKEEF = 697f;
            this.JENHAGBJCDK = Random.Range(23f, 483f);
            this.FBEIJHMCMGJ = (float)Random.Range(4, 4);
            this.NHDAHJHOBNF = Random.Range(726f, 1658f);
            this.IMEAKDEJEFD = 298f;
            this.NHGBINDLMAE = this.JENHAGBJCDK * this.FBEIJHMCMGJ + this.NHDAHJHOBNF + this.IMEAKDEJEFD;
            if (Random.Range(1, 4) > 1)
            {
                this.FIKGNFDLPMC = false;
                return;
            }
            this.FIKGNFDLPMC = false;
        }

        private void JIKPEDFMKIP(ConfigurableJoint ALLICKLAKDB, ConfigurableJoint NHNILCHENEH, ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint ALEGOOOGBOJ, ConfigurableJoint POCAHMPKOOK, ConfigurableJoint AJBEMNONLMC, ConfigurableJoint NLEHLJPKLCH)
        {
            if (this.JNIAPNNKEEF > 1392f * this.JENHAGBJCDK)
            {
                if (this.JNIAPNNKEEF < this.NHGBINDLMAE - this.IMEAKDEJEFD)
                {
                    this.AJLMBDNGBKB(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.HKHDKCDEGMG);
                    this.AHOOKEAJBFJ(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.PHJGKBNGBKE);
                    this.OPBNDACFDJI(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.LGCJGMEAAGH);
                    this.AJLMBDNGBKB(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.AOAFKGKJAMJ);
                }
                else
                {
                    this.JOLFMNEJMMP = Quaternion.RotateTowards(this.JOLFMNEJMMP, this.MCFBPIJKOJH, Time.fixedDeltaTime * 405f);
                    this.FMHAKEOICOO = Quaternion.RotateTowards(this.FMHAKEOICOO, this.DOFGCABIDLP, Time.fixedDeltaTime * 277f);
                    this.EJPEBHJHAKB = Quaternion.RotateTowards(this.EJPEBHJHAKB, this.IFEEGOFNEID, Time.fixedDeltaTime * 648f);
                    this.OFLOFJIMLNF = Quaternion.RotateTowards(this.OFLOFJIMLNF, this.MCHECJDPKCE, Time.fixedDeltaTime * 1507f);
                    this.OHDPEPCPNDJ(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.JOLFMNEJMMP);
                    this.AHOOKEAJBFJ(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.FMHAKEOICOO);
                    this.GMBHHLNPMGH(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.EJPEBHJHAKB);
                    this.AGAFHLEJDEF(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.OFLOFJIMLNF);
                }
            }
            else
            {
                this.JOLFMNEJMMP = Quaternion.RotateTowards(this.JOLFMNEJMMP, this.HKHDKCDEGMG, Time.fixedDeltaTime * 1414f);
                this.FMHAKEOICOO = Quaternion.RotateTowards(this.FMHAKEOICOO, this.PHJGKBNGBKE, Time.fixedDeltaTime * 1290f);
                this.EJPEBHJHAKB = Quaternion.RotateTowards(this.EJPEBHJHAKB, this.LGCJGMEAAGH, Time.fixedDeltaTime * 91f);
                this.OFLOFJIMLNF = Quaternion.RotateTowards(this.OFLOFJIMLNF, this.AOAFKGKJAMJ, Time.fixedDeltaTime * 1174f);
                this.AJLMBDNGBKB(ALLICKLAKDB, this.FGLNNNIDALN, this.CDJLEDECBNO, this.JOLFMNEJMMP);
                this.OMAPOFMKCMG(NHNILCHENEH, this.FGLNNNIDALN, this.CDJLEDECBNO, this.FMHAKEOICOO);
                this.AHOOKEAJBFJ(ALEGOOOGBOJ, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.EJPEBHJHAKB);
                this.AJLMBDNGBKB(POCAHMPKOOK, this.PNKNCLLMFEN, this.JKCMIBIBIGC, this.OFLOFJIMLNF);
            }
            if (this.JNIAPNNKEEF < this.NHGBINDLMAE - this.IMEAKDEJEFD)
            {
                if (this.FIKGNFDLPMC)
                {
                    this.GLMNMOEEGPE = (Mathf.Clamp(Mathf.Sin((this.JNIAPNNKEEF - this.NHDAHJHOBNF) / this.JENHAGBJCDK * 558f), 746f, 862f) + 242f) * 1269f;
                }
                else
                {
                    this.GLMNMOEEGPE = 1185f - (Mathf.Clamp(Mathf.Sin((this.JNIAPNNKEEF - this.NHDAHJHOBNF) / this.JENHAGBJCDK * 1192f), 340f, 1137f) + 1774f) * 1497f;
                }
                this.BIANLBJBFOD = Quaternion.Slerp(this.MAHBIMLCIJM, this.HEJAKKBFKBE, this.GLMNMOEEGPE);
                this.AHOOKEAJBFJ(CDBGCHHHPFL, this.ODKAIGGOHDD, this.ODKAIGGOHDD, this.BIANLBJBFOD);
                this.NHINDAMFIMF = Quaternion.Slerp(this.JJHIFFFPIPG, this.NGGEAIEAKNC, this.GLMNMOEEGPE);
                this.AHOOKEAJBFJ(NLEHLJPKLCH, this.ECINNMEHPCL, this.ECINNMEHPCL, this.NHINDAMFIMF);
                this.PEHHPMLABML = Quaternion.Slerp(this.ADLPFMGFGMK, this.KCBJFKLIONL, this.GLMNMOEEGPE);
                this.OMAPOFMKCMG(AJBEMNONLMC, this.JOLAOHLFJPP, this.JOLAOHLFJPP, this.PEHHPMLABML);
                return;
            }
            this.PEHHPMLABML = Quaternion.RotateTowards(this.PEHHPMLABML, this.MBAHLIBLGPD, Time.fixedDeltaTime * 1677f);
            this.OHDPEPCPNDJ(AJBEMNONLMC, this.JOLAOHLFJPP, this.JOLAOHLFJPP, this.PEHHPMLABML);
        }



        private bool EBLICPMNBED;

        private float NHGBINDLMAE;

        private float JENHAGBJCDK;

        private float FBEIJHMCMGJ;

        private float NHDAHJHOBNF;

        private float IMEAKDEJEFD;

        private float JNIAPNNKEEF;

        private bool FIKGNFDLPMC;

        private float GLMNMOEEGPE;

        private Quaternion HKHDKCDEGMG = Quaternion.Euler(new Quaternion(0f, -0.22f, -0.07f, 1f).eulerAngles);

        private Quaternion PHJGKBNGBKE = Quaternion.Euler(new Quaternion(0f, 0.22f, 0.07f, 1f).eulerAngles);

        private Quaternion LGCJGMEAAGH = Quaternion.Euler(new Quaternion(2.5f, 0f, 0f, 1f).eulerAngles);

        private Quaternion AOAFKGKJAMJ = Quaternion.Euler(new Quaternion(2.5f, 0f, 0f, 1f).eulerAngles);

        private Quaternion MAHBIMLCIJM = Quaternion.Euler(new Quaternion(0f, 0f, 0.25f, 1f).eulerAngles);

        private Quaternion HEJAKKBFKBE = Quaternion.Euler(new Quaternion(0f, 0f, -0.25f, 1f).eulerAngles);

        private Quaternion JJHIFFFPIPG = Quaternion.Euler(new Quaternion(0f, 0f, 0.25f, 1f).eulerAngles);

        private Quaternion NGGEAIEAKNC = Quaternion.Euler(new Quaternion(0f, 0f, -0.25f, 1f).eulerAngles);

        private Quaternion ADLPFMGFGMK = Quaternion.Euler(new Quaternion(0.1f, 0f, -0.35f, 1f).eulerAngles);

        private Quaternion KCBJFKLIONL = Quaternion.Euler(new Quaternion(0.1f, 0f, 0.35f, 1f).eulerAngles);

        private Quaternion MBAHLIBLGPD = Quaternion.Euler(new Quaternion(-0.04f, 0f, 0f, 1f).eulerAngles);


        private Quaternion MCFBPIJKOJH = new Quaternion(0f, 0.5449883f, 0f, -0.8384436f);

        private Quaternion DOFGCABIDLP = new Quaternion(0f, 0.5449883f, 0f, 0.8384436f);

        private Quaternion IFEEGOFNEID = new Quaternion(0.1675955f, 0f, 0f, 0.9858558f);

        private Quaternion MCHECJDPKCE = new Quaternion(0.1675955f, 0f, 0f, 0.9858558f);

        private Quaternion PEHHPMLABML;

        private Quaternion NHINDAMFIMF;

        private Quaternion BIANLBJBFOD;

        private Quaternion JOLFMNEJMMP;

        private Quaternion FMHAKEOICOO;

        private Quaternion EJPEBHJHAKB;

        private Quaternion OFLOFJIMLNF;

        private JointDrive FGLNNNIDALN;

        private JointDrive CDJLEDECBNO;

        private JointDrive PNKNCLLMFEN;

        private JointDrive JKCMIBIBIGC;

        private JointDrive JOLAOHLFJPP;

        private JointDrive ECINNMEHPCL;

        private JointDrive ODKAIGGOHDD;
    }
}