using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    internal class GrabCollisionDetect : MonoBehaviour
    {
        public bool ThisHandIsGrabbingObj
        {
            get
            {
                return this.ODHHBGLGBOB;
            }
            set
            {
                if (this.ODHHBGLGBOB != value)
                {
                    this.ODHHBGLGBOB = value;
                    if (!this.ODHHBGLGBOB)
                    {
                        this.UngrabObjDetail();
                        this.BDKOJBBADON(this.GCIIBALOLJM);
                    }
                }
            }
        }



        internal Rigidbody JIIIHLGDFFN
        {
            get
            {
                return this.PKPNCJBNBEK;
            }
            private set
            {
                if (this.PKPNCJBNBEK != value)
                {
                    if (value == null)
                    {
                        this.AIGAKJGIDDF(this.PKPNCJBNBEK);
                    }
                    this.PKPNCJBNBEK = value;
                }
            }
        }

        public void FixedUpdateOfThis()
        {
            this.MHLCAPEDMLF(this.KPLKMDDKCML.HBBHGFFPFPC, this.KPLKMDDKCML.DIFAOOPOMDL, this.KPLKMDDKCML.GLFNLPJFGEM, this.KPLKMDDKCML.MJAFJDDBMHN, this.KPLKMDDKCML.GAAABCJJPLA);
            this.JointForceFalloff();
            this.CANEICDHJCK();
            if (!this.KAFCDALNOPJ)
            {
                this.KHABJLNHGKO.liftObjectWeight = 0f;
                return;
            }
            if (this.GrabbedObjectGO.layer == 8)
            {
                this.KHABJLNHGKO.liftObjectWeight = 33f;
                return;
            }
            float num;
            if (BFNMKMBJKJO.POMKGJDAIBO(this.JIIIHLGDFFN, this.MIBGEKAAMGG.JIIIHLGDFFN) || this.JIIIHLGDFFN == this.MIBGEKAAMGG.JIIIHLGDFFN)
            {
                num = BFNMKMBJKJO.NMMLAMPAMMC(this.JIIIHLGDFFN);
            }
            else
            {
                num = BFNMKMBJKJO.NMMLAMPAMMC(this.JIIIHLGDFFN) + BFNMKMBJKJO.NMMLAMPAMMC(this.MIBGEKAAMGG.JIIIHLGDFFN);
            }
            this.KHABJLNHGKO.liftObjectWeight = (this.JIIIHLGDFFN.isKinematic ? 0f : num) / (float)LiftObjectManager.PCCRigidbodyDictionary[this.JIIIHLGDFFN].Count;
        }





        private SphereCollider DJOLKGGCCJA
        {
            get
            {
                if (this.KOFEJOHFKOE == null)
                {
                    this.KOFEJOHFKOE = base.GetComponent<SphereCollider>();
                }
                return this.KOFEJOHFKOE;
            }
        }

        private PhysicCharacterController IIOKFILHPDF
        {
            get
            {
                return this.GEODDMAIHIP;
            }
            set
            {
                if (this.GEODDMAIHIP != value)
                {
                    PhysicCharacterController geoddmaihip = this.GEODDMAIHIP;
                    this.GEODDMAIHIP = value;
                    if (value != null)
                    {
                        if (this.KPLKMDDKCML.GreenFistL == base.gameObject)
                        {
                            this.KPLKMDDKCML.GAOJKIAHDOP(value);
                        }
                        else
                        {
                            this.KPLKMDDKCML.BDPCMGOLPCC(value);
                        }
                        value.EOPMJOGMMNI.Add(this.KPLKMDDKCML);
                        if (!this.MIBGEKAAMGG.ThisHandIsGrabbingObj)
                        {
                            this.KPLKMDDKCML.OMOKCIKGEBN(value);
                            return;
                        }
                    }
                    else if (!this.MIBGEKAAMGG.ThisHandIsGrabbingObj)
                    {
                        this.KPLKMDDKCML.OKKJDMDHOFO(geoddmaihip);
                        geoddmaihip.EOPMJOGMMNI.Remove(this.KPLKMDDKCML);
                    }
                }
            }
        }

        public bool isReaching
        {
            get
            {
                return this.GHHEOLCBGDH;
            }
            set
            {
                if (this.GHHEOLCBGDH != value)
                {
                    this.GHHEOLCBGDH = value;
                    if (value)
                    {
                        this.BDKOJBBADON(0.06f);
                        return;
                    }
                    if (!this.ThisHandIsGrabbingObj)
                    {
                        this.BDKOJBBADON(this.GCIIBALOLJM);
                    }
                }
            }
        }







        private PhysicCharacterController OKEAOJIFBDP()
        {
            if (this.FKDODJMPGMI == null)
            {
                this.FKDODJMPGMI = this.Parent.GetComponent<PhysicCharacterController>();
            }
            return this.FKDODJMPGMI;
        }











        internal void NODNAFAKHBF()
        {
            this.DDFDDKFJPDN(false);
        }

        private void BPBGOPCOBFK(Rigidbody EEPACGJDMJM)
        {
            if (this.PKPNCJBNBEK != EEPACGJDMJM)
            {
                if (EEPACGJDMJM == null)
                {
                    this.DBJAHECOPPI(this.PKPNCJBNBEK);
                }
                this.PKPNCJBNBEK = EEPACGJDMJM;
            }
        }





        public void AddJoint(Rigidbody IAPBMOKHBFH, Vector3 JLLJPDAHKNB)
        {
            this.PMAJPMCCNCN = 8000f;
            this.MNIKDMOCGNA = base.gameObject.AddComponent<GrabJoint>();
            this.MNIKDMOCGNA.EJGINBONHKE = this;
            this.MNIKDMOCGNA.KOFJBKAKBNL.connectedBody = IAPBMOKHBFH;
            this.MNIKDMOCGNA.KOFJBKAKBNL.anchor = JLLJPDAHKNB;
            this.MNIKDMOCGNA.KOFJBKAKBNL.xMotion = ConfigurableJointMotion.Locked;
            this.MNIKDMOCGNA.KOFJBKAKBNL.yMotion = ConfigurableJointMotion.Locked;
            this.MNIKDMOCGNA.KOFJBKAKBNL.zMotion = ConfigurableJointMotion.Locked;
            this.MNIKDMOCGNA.KOFJBKAKBNL.enableCollision = true;
            this.MNIKDMOCGNA.KOFJBKAKBNL.connectedMassScale = 1f;
            this.MNIKDMOCGNA.KOFJBKAKBNL.massScale = 1f;
            this.MNIKDMOCGNA.KOFJBKAKBNL.angularXDrive = this.GrabJointDrive;
            this.MNIKDMOCGNA.KOFJBKAKBNL.angularYZDrive = this.GrabJointDrive;
            this.MNIKDMOCGNA.KOFJBKAKBNL.breakForce = this.PMAJPMCCNCN;
            this.ThisHandIsGrabbingObj = true;
            this.OJLPBGJEJLM = Time.timeSinceLevelLoad;
        }








        private void DBOELKNINLI(PhysicCharacterController EEPACGJDMJM)
        {
            if (this.GEODDMAIHIP != EEPACGJDMJM)
            {
                PhysicCharacterController geoddmaihip = this.GEODDMAIHIP;
                this.GEODDMAIHIP = EEPACGJDMJM;
                if (EEPACGJDMJM != null)
                {
                    if (this.NJEEHIMGBOG().GreenFistL == base.gameObject)
                    {
                        this.NJEEHIMGBOG().GAOJKIAHDOP(EEPACGJDMJM);
                    }
                    else
                    {
                        this.OKEAOJIFBDP().BDPCMGOLPCC(EEPACGJDMJM);
                    }
                    EEPACGJDMJM.EOPMJOGMMNI.Add(this.KPLKMDDKCML);
                    if (!this.MIBGEKAAMGG.GEPFLFOEENM())
                    {
                        this.OKEAOJIFBDP().OMOKCIKGEBN(EEPACGJDMJM);
                        return;
                    }
                }
                else if (!this.MIBGEKAAMGG.KJAIPDGCFBI())
                {
                    this.DAKOCFHLPBG().OKKJDMDHOFO(geoddmaihip);
                    geoddmaihip.EOPMJOGMMNI.Remove(this.KPLKMDDKCML);
                }
            }
        }


        public bool OCLAHLDDLFB()
        {
            return this.ODHHBGLGBOB;
        }


        public void BPFPAKFKHNI(GameObject EEPACGJDMJM)
        {
            if (this.JLGGJPDHJBP != EEPACGJDMJM)
            {
                this.JLGGJPDHJBP = EEPACGJDMJM;
                if (EEPACGJDMJM != null)
                {
                    if (EEPACGJDMJM.GetComponent<Rigidbody>() != null)
                    {
                        this.BPBGOPCOBFK(EEPACGJDMJM.GetComponent<Rigidbody>());
                    }
                    else
                    {
                        this.DGDNNMLLMHL(null);
                    }
                    if (PccManager.rigidbodyCharacterControllerMap.ContainsKey(EEPACGJDMJM))
                    {
                        this.NONKCKEDNOD(PccManager.rigidbodyCharacterControllerMap[EEPACGJDMJM]);
                        return;
                    }
                    this.DBOELKNINLI(null);
                    return;
                }
                else
                {
                    this.BFDBDIAGIKM(null);
                    this.NONKCKEDNOD(null);
                    if (!this.GrabbingStaticObject)
                    {
                        this.NGHJLHFEIEI(true);
                    }
                }
            }
        }







        private CharacterStates BJCJKDOFOFO()
        {
            if (this.HAHJIPDKHLF == null)
            {
                this.HAHJIPDKHLF = this.Parent.GetComponent<CharacterStates>();
            }
            return this.HAHJIPDKHLF;
        }


        private CharacterStates OFPIFBLOPHE()
        {
            if (this.HAHJIPDKHLF == null)
            {
                this.HAHJIPDKHLF = this.Parent.GetComponent<CharacterStates>();
            }
            return this.HAHJIPDKHLF;
        }

        private void DGDNNMLLMHL(Rigidbody EEPACGJDMJM)
        {
            if (this.PKPNCJBNBEK != EEPACGJDMJM)
            {
                if (EEPACGJDMJM == null)
                {
                    this.AIGAKJGIDDF(this.PKPNCJBNBEK);
                }
                this.PKPNCJBNBEK = EEPACGJDMJM;
            }
        }




        public void DIHBHCMEIPF(bool EEPACGJDMJM)
        {
            if (this.ODHHBGLGBOB != EEPACGJDMJM)
            {
                this.ODHHBGLGBOB = EEPACGJDMJM;
                if (!this.ODHHBGLGBOB)
                {
                    this.UngrabObjDetail();
                    this.BDKOJBBADON(this.GCIIBALOLJM);
                }
            }
        }



        private Rigidbody PDLLKEJMBGC
        {
            get
            {
                if (this.PNGFPCPBAKB == null)
                {
                    this.PNGFPCPBAKB = this.KPLKMDDKCML.GreenHip.GetComponent<Rigidbody>();
                }
                return this.PNGFPCPBAKB;
            }
        }




        private PhysicCharacterController IMFNPPNIHKH()
        {
            if (this.FKDODJMPGMI == null)
            {
                this.FKDODJMPGMI = this.Parent.GetComponent<PhysicCharacterController>();
            }
            return this.FKDODJMPGMI;
        }


        public void HNCPCMEPOEO()
        {
            if (this.MNIKDMOCGNA != null)
            {
                this.MNIKDMOCGNA.EJPOBMNNHIE();
            }
            this.FBMANMIKMBH(true);
            this.GrabbingStaticObject = true;
            this.BPFPAKFKHNI(null);
            this.MBIJOJNNCIM(null);
            this.DIHBHCMEIPF(true);
            this.BJCJKDOFOFO().KMODJNJCLAG(1941f);
            if (this.NJEEHIMGBOG().GreenFistL == base.gameObject)
            {
                this.OCKEGIBHDKE().BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.Punching;
                this.OKEAOJIFBDP().MKEOCJIIKKB();
                return;
            }
            this.FAFDBIPICDJ().EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.Punching;
            this.IMFNPPNIHKH().OPIJAEDLIKG();
        }



        private bool KAFCDALNOPJ
        {
            get
            {
                return this.AKEKCFAENEC;
            }
            set
            {
                if (this.AKEKCFAENEC != value)
                {
                    this.AKEKCFAENEC = value;
                    if (value)
                    {
                        this.DPIANPNBHLC(this.JIIIHLGDFFN);
                        return;
                    }
                    if (this.JIIIHLGDFFN != null)
                    {
                        this.AIGAKJGIDDF(this.JIIIHLGDFFN);
                    }
                }
            }
        }




        internal void MMMGMIIDODH(GameObject EEPACGJDMJM)
        {
            if (this.PJINDHCBKGO != EEPACGJDMJM)
            {
                if (EEPACGJDMJM != null)
                {
                    if (PGNNPNAAFLP.EFAJMCPOLOE.ContainsKey(EEPACGJDMJM))
                    {
                        PGNNPNAAFLP.EFAJMCPOLOE[EEPACGJDMJM].NFICMGIMHOK(this.OCKEGIBHDKE().gameObject, (this.OCKEGIBHDKE().GreenFistL == base.gameObject) ? InteractiveObject.Side.LeftHand : InteractiveObject.Side.LeftHand);
                    }
                }
                else if (this.PJINDHCBKGO != null && PGNNPNAAFLP.EFAJMCPOLOE.ContainsKey(this.PJINDHCBKGO))
                {
                    PGNNPNAAFLP.EFAJMCPOLOE[this.PJINDHCBKGO].JFBIAIILOPE(this.NJEEHIMGBOG().gameObject, (this.IMFNPPNIHKH().GreenFistL == base.gameObject) ? InteractiveObject.Side.RightHand : InteractiveObject.Side.LeftHand);
                }
                this.PJINDHCBKGO = EEPACGJDMJM;
            }
        }


        public GameObject GrabbedObjectGO
        {
            get
            {
                return this.JLGGJPDHJBP;
            }
            set
            {
                if (this.JLGGJPDHJBP != value)
                {
                    this.JLGGJPDHJBP = value;
                    if (value != null)
                    {
                        if (value.GetComponent<Rigidbody>() != null)
                        {
                            this.JIIIHLGDFFN = value.GetComponent<Rigidbody>();
                        }
                        else
                        {
                            this.JIIIHLGDFFN = null;
                        }
                        if (PccManager.rigidbodyCharacterControllerMap.ContainsKey(value))
                        {
                            this.IIOKFILHPDF = PccManager.rigidbodyCharacterControllerMap[value];
                            return;
                        }
                        this.IIOKFILHPDF = null;
                        return;
                    }
                    else
                    {
                        this.JIIIHLGDFFN = null;
                        this.IIOKFILHPDF = null;
                        if (!this.GrabbingStaticObject)
                        {
                            this.ThisHandIsGrabbingObj = false;
                        }
                    }
                }
            }
        }






        public void JointForceFalloff()
        {
            if (this.MNIKDMOCGNA != null)
            {
                if (this.KHABJLNHGKO.Power > 0f)
                {
                    float num = Mathf.Min(Mathf.Pow(this.MNIKDMOCGNA.KOFJBKAKBNL.currentForce.magnitude * 0.001f, 2f), 6.25f) * Time.fixedDeltaTime * 0.15f;
                    if (this.GrabbingStaticObject || (this.GrabbedObjectGO != null && this.GrabbedObjectGO.layer != 8))
                    {
                        num *= 0.35f;
                    }
                    this.KHABJLNHGKO.FIEKPFBMNIC(num);
                }
                this.KHABJLNHGKO.HKHHJCILJGO(1f);
                this.PMAJPMCCNCN = Mathf.Pow(this.KHABJLNHGKO.Power, 0.4f) * 4000f;
                if (this.GrabbedObjectGO != null && GameObjectToWeaponMapper.gameObjectToWeaponMap.ContainsKey(this.GrabbedObjectGO) && GameObjectToWeaponMapper.gameObjectToWeaponMap[this.GrabbedObjectGO] as WeaponNunchucks != null)
                {
                    this.PMAJPMCCNCN = Mathf.Clamp(this.PMAJPMCCNCN, -1f, 300f);
                }
                this.MNIKDMOCGNA.KOFJBKAKBNL.breakForce = this.PMAJPMCCNCN;
            }
        }







        private void AIGAKJGIDDF(Rigidbody HJLAPMFLIIB)
        {
            if (BFNMKMBJKJO.HOBGDODGPIH(HJLAPMFLIIB).Count > 0)
            {
                using (List<Rigidbody>.Enumerator enumerator = BFNMKMBJKJO.HOBGDODGPIH(HJLAPMFLIIB).GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        Rigidbody key = enumerator.Current;
                        if (LiftObjectManager.PCCRigidbodyDictionary.ContainsKey(key))
                        {
                            if (LiftObjectManager.PCCRigidbodyDictionary[key] != null)
                            {
                                LiftObjectManager.PCCRigidbodyDictionary[key].Remove(this.KPLKMDDKCML);
                                if (LiftObjectManager.PCCRigidbodyDictionary[key].Count == 0)
                                {
                                    LiftObjectManager.ReturnPCCHashSetToPool(LiftObjectManager.PCCRigidbodyDictionary[key]);
                                    LiftObjectManager.PCCRigidbodyDictionary.Remove(key);
                                }
                            }
                            else
                            {
                                LiftObjectManager.PCCRigidbodyDictionary.Remove(key);
                            }
                        }
                    }
                    return;
                }
            }
            if (LiftObjectManager.PCCRigidbodyDictionary.ContainsKey(HJLAPMFLIIB))
            {
                if (LiftObjectManager.PCCRigidbodyDictionary[HJLAPMFLIIB] != null)
                {
                    LiftObjectManager.PCCRigidbodyDictionary[HJLAPMFLIIB].Remove(this.KPLKMDDKCML);
                    if (LiftObjectManager.PCCRigidbodyDictionary[HJLAPMFLIIB].Count == 0)
                    {
                        LiftObjectManager.ReturnPCCHashSetToPool(LiftObjectManager.PCCRigidbodyDictionary[HJLAPMFLIIB]);
                        LiftObjectManager.PCCRigidbodyDictionary.Remove(HJLAPMFLIIB);
                        return;
                    }
                }
                else
                {
                    LiftObjectManager.PCCRigidbodyDictionary.Remove(HJLAPMFLIIB);
                }
            }
        }

        private PhysicCharacterController FAFDBIPICDJ()
        {
            if (this.FKDODJMPGMI == null)
            {
                this.FKDODJMPGMI = this.Parent.GetComponent<PhysicCharacterController>();
            }
            return this.FKDODJMPGMI;
        }



        public GameObject TheOtherFistGO
        {
            get
            {
                return this.FOIEFCHNCBK;
            }
            set
            {
                this.FOIEFCHNCBK = value;
                this.MIBGEKAAMGG = this.FOIEFCHNCBK.GetComponent<GrabCollisionDetect>();
            }
        }


        protected void OODLGHMPPMJ(Collision NLJBANLOGGI, Vector3 ELJLMLADLDL)
        {
            if (!this.isReaching)
            {
                return;
            }
            if (Time.timeSinceLevelLoad - this.OJLPBGJEJLM < 0.1f)
            {
                return;
            }
            if (PhysicsIgnoredList.NoGrabObjects != null && PhysicsIgnoredList.NoGrabObjects.Contains(NLJBANLOGGI.gameObject))
            {
                return;
            }
            if (this.KPLKMDDKCML.IINJFJOIHMK.Contains(NLJBANLOGGI.gameObject))
            {
                return;
            }
            if (this.MNIKDMOCGNA == null)
            {
                if (this.KPLKMDDKCML.ILPCNDKKCHO)
                {
                    if (NLJBANLOGGI.rigidbody == null)
                    {
                        this.AddJoint(null, ELJLMLADLDL);
                        this.GrabbingStaticObject = true;
                        this.LKCGBILOJJI = NLJBANLOGGI.gameObject;
                        return;
                    }
                    this.AddJoint(NLJBANLOGGI.rigidbody, ELJLMLADLDL);
                    this.GrabbedObjectGO = NLJBANLOGGI.gameObject;
                    this.LKCGBILOJJI = NLJBANLOGGI.gameObject;
                    return;
                }
                else if (this.MIBGEKAAMGG.GrabbingStaticObject)
                {
                    if (NLJBANLOGGI.rigidbody == null)
                    {
                        this.AddJoint(null, ELJLMLADLDL);
                        this.GrabbingStaticObject = true;
                        this.LKCGBILOJJI = NLJBANLOGGI.gameObject;
                        return;
                    }
                }
                else if (this.MIBGEKAAMGG.GrabbedObjectGO == null)
                {
                    if (NLJBANLOGGI.rigidbody == null)
                    {
                        this.AddJoint(null, ELJLMLADLDL);
                        this.GrabbingStaticObject = true;
                        this.LKCGBILOJJI = NLJBANLOGGI.gameObject;
                        return;
                    }
                    this.AddJoint(NLJBANLOGGI.rigidbody, ELJLMLADLDL);
                    this.GrabbedObjectGO = NLJBANLOGGI.gameObject;
                    this.LKCGBILOJJI = NLJBANLOGGI.gameObject;
                    return;
                }
                else if (NLJBANLOGGI.rigidbody != null)
                {
                    if (NLJBANLOGGI.rigidbody == this.MIBGEKAAMGG.JIIIHLGDFFN || BFNMKMBJKJO.POMKGJDAIBO(NLJBANLOGGI.rigidbody, this.MIBGEKAAMGG.JIIIHLGDFFN) || OFLJNAJKDHM.NMNBLMIPPID(NLJBANLOGGI.rigidbody, this.MIBGEKAAMGG.JIIIHLGDFFN) || (NLJBANLOGGI.rigidbody.isKinematic && this.MIBGEKAAMGG.JIIIHLGDFFN.isKinematic))
                    {
                        this.AddJoint(NLJBANLOGGI.rigidbody, ELJLMLADLDL);
                        this.GrabbedObjectGO = NLJBANLOGGI.gameObject;
                        this.LKCGBILOJJI = NLJBANLOGGI.gameObject;
                        return;
                    }
                    if (NLJBANLOGGI.gameObject.layer == 8 && this.MIBGEKAAMGG.GrabbedObjectGO.layer == 8 && NLJBANLOGGI.transform.parent == this.MIBGEKAAMGG.GrabbedObjectGO.transform.parent)
                    {
                        this.AddJoint(NLJBANLOGGI.rigidbody, ELJLMLADLDL);
                        this.GrabbedObjectGO = NLJBANLOGGI.gameObject;
                        this.LKCGBILOJJI = NLJBANLOGGI.gameObject;
                    }
                }
            }
        }

        internal void FBEGGHPAOFK()
        {
            this.NGHJLHFEIEI(true);
        }










        public void DDFDDKFJPDN(bool EEPACGJDMJM)
        {
            if (this.ODHHBGLGBOB != EEPACGJDMJM)
            {
                this.ODHHBGLGBOB = EEPACGJDMJM;
                if (!this.ODHHBGLGBOB)
                {
                    this.HNCPCMEPOEO();
                    this.BDKOJBBADON(this.GCIIBALOLJM);
                }
            }
        }

        private PhysicCharacterController DAKOCFHLPBG()
        {
            if (this.FKDODJMPGMI == null)
            {
                this.FKDODJMPGMI = this.Parent.GetComponent<PhysicCharacterController>();
            }
            return this.FKDODJMPGMI;
        }



        private void MHLCAPEDMLF(bool GIHKOACPIBH, bool COBHEMBAHKD, bool EKGEKNCACEB, bool DEKABKJLMGI, bool AHHODAPIPOD)
        {
            if (GIHKOACPIBH || COBHEMBAHKD || EKGEKNCACEB)
            {
                this.KAFCDALNOPJ = false;
                return;
            }
            if (this.JIIIHLGDFFN == null || this.MIBGEKAAMGG.JIIIHLGDFFN == null)
            {
                this.KAFCDALNOPJ = false;
                return;
            }
            if (this.JIIIHLGDFFN != this.MIBGEKAAMGG.JIIIHLGDFFN && !BFNMKMBJKJO.POMKGJDAIBO(this.JIIIHLGDFFN, this.MIBGEKAAMGG.JIIIHLGDFFN) && this.GrabbedObjectGO.layer == 8 && this.MIBGEKAAMGG.GrabbedObjectGO.layer == 8 && this.IIOKFILHPDF != this.MIBGEKAAMGG.IIOKFILHPDF && !OFLJNAJKDHM.NMNBLMIPPID(this.JIIIHLGDFFN, this.MIBGEKAAMGG.JIIIHLGDFFN))
            {
                this.KAFCDALNOPJ = false;
                return;
            }
            if (!this.ThisHandIsGrabbingObj || !this.MIBGEKAAMGG.ThisHandIsGrabbingObj || this.JIIIHLGDFFN.isKinematic || PADJPIDNGPI.LELFDPEBCIN.Contains(this.JIIIHLGDFFN) || this.PDLLKEJMBGC.constraints == RigidbodyConstraints.None)
            {
                this.KAFCDALNOPJ = false;
                return;
            }
            if (!DEKABKJLMGI || AHHODAPIPOD)
            {
                this.KAFCDALNOPJ = false;
                return;
            }
            if (!(this.IIOKFILHPDF != null))
            {
                this.KAFCDALNOPJ = true;
                float num = BFNMKMBJKJO.NMMLAMPAMMC(this.JIIIHLGDFFN) / (float)LiftObjectManager.PCCRigidbodyDictionary[this.JIIIHLGDFFN].Count;
                if (this.JIIIHLGDFFN != this.MIBGEKAAMGG.JIIIHLGDFFN && !BFNMKMBJKJO.POMKGJDAIBO(this.JIIIHLGDFFN, this.MIBGEKAAMGG.JIIIHLGDFFN) && this.MIBGEKAAMGG.KAFCDALNOPJ)
                {
                    num += Mathf.Min(BFNMKMBJKJO.NMMLAMPAMMC(this.MIBGEKAAMGG.JIIIHLGDFFN) / (float)LiftObjectManager.PCCRigidbodyDictionary[this.MIBGEKAAMGG.JIIIHLGDFFN].Count, num);
                }
                Vector3 vector = Mathf.Min(num, 45f) * 17f * Vector3.up;
                CFOGGNCCHCO.OEODACNOHCD(this.JIIIHLGDFFN, vector, base.transform.position, ForceMode.Force);
                CFOGGNCCHCO.EFNEGHJPJFN(this.PDLLKEJMBGC, -vector, ForceMode.Force);
                return;
            }
            if (this.IIOKFILHPDF.CBasicState == PhysicCharacterController.CharacterBasicState.Unconcious || !this.IIOKFILHPDF.IsCharacterBalanced)
            {
                this.KAFCDALNOPJ = true;
                CFOGGNCCHCO.EFNEGHJPJFN(this.JIIIHLGDFFN, Vector3.up * 550f, ForceMode.Force);
                CFOGGNCCHCO.EFNEGHJPJFN(this.PDLLKEJMBGC, Vector3.down * 550f, ForceMode.Force);
                return;
            }
            this.KAFCDALNOPJ = false;
        }


        private void BDKOJBBADON(float AINAMLCHFLF)
        {
            this.DJOLKGGCCJA.radius = AINAMLCHFLF;
        }

        private void NONKCKEDNOD(PhysicCharacterController EEPACGJDMJM)
        {
            if (this.GEODDMAIHIP != EEPACGJDMJM)
            {
                PhysicCharacterController geoddmaihip = this.GEODDMAIHIP;
                this.GEODDMAIHIP = EEPACGJDMJM;
                if (EEPACGJDMJM != null)
                {
                    if (this.NJEEHIMGBOG().GreenFistL == base.gameObject)
                    {
                        this.KPLKMDDKCML.GAOJKIAHDOP(EEPACGJDMJM);
                    }
                    else
                    {
                        this.NJEEHIMGBOG().BDPCMGOLPCC(EEPACGJDMJM);
                    }
                    EEPACGJDMJM.EOPMJOGMMNI.Add(this.KPLKMDDKCML);
                    if (!this.MIBGEKAAMGG.OCLAHLDDLFB())
                    {
                        this.OKEAOJIFBDP().OMOKCIKGEBN(EEPACGJDMJM);
                        return;
                    }
                }
                else if (!this.MIBGEKAAMGG.GEPFLFOEENM())
                {
                    this.OKEAOJIFBDP().OKKJDMDHOFO(geoddmaihip);
                    geoddmaihip.EOPMJOGMMNI.Remove(this.FAFDBIPICDJ());
                }
            }
        }

        private PhysicCharacterController NJEEHIMGBOG()
        {
            if (this.FKDODJMPGMI == null)
            {
                this.FKDODJMPGMI = this.Parent.GetComponent<PhysicCharacterController>();
            }
            return this.FKDODJMPGMI;
        }

        internal void JHOAEADLMKA()
        {
            this.DDFDDKFJPDN(false);
        }



        private void BFDBDIAGIKM(Rigidbody EEPACGJDMJM)
        {
            if (this.PKPNCJBNBEK != EEPACGJDMJM)
            {
                if (EEPACGJDMJM == null)
                {
                    this.DBJAHECOPPI(this.PKPNCJBNBEK);
                }
                this.PKPNCJBNBEK = EEPACGJDMJM;
            }
        }



        private void DBJAHECOPPI(Rigidbody HJLAPMFLIIB)
        {
            if (BFNMKMBJKJO.HOBGDODGPIH(HJLAPMFLIIB).Count > 1)
            {
                using (List<Rigidbody>.Enumerator enumerator = BFNMKMBJKJO.HOBGDODGPIH(HJLAPMFLIIB).GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        Rigidbody key = enumerator.Current;
                        if (LiftObjectManager.PCCRigidbodyDictionary.ContainsKey(key))
                        {
                            if (LiftObjectManager.PCCRigidbodyDictionary[key] != null)
                            {
                                LiftObjectManager.PCCRigidbodyDictionary[key].Remove(this.DAKOCFHLPBG());
                                if (LiftObjectManager.PCCRigidbodyDictionary[key].Count == 0)
                                {
                                    LiftObjectManager.ReturnPCCHashSetToPool(LiftObjectManager.PCCRigidbodyDictionary[key]);
                                    LiftObjectManager.PCCRigidbodyDictionary.Remove(key);
                                }
                            }
                            else
                            {
                                LiftObjectManager.PCCRigidbodyDictionary.Remove(key);
                            }
                        }
                    }
                    return;
                }
            }
            if (LiftObjectManager.PCCRigidbodyDictionary.ContainsKey(HJLAPMFLIIB))
            {
                if (LiftObjectManager.PCCRigidbodyDictionary[HJLAPMFLIIB] != null)
                {
                    LiftObjectManager.PCCRigidbodyDictionary[HJLAPMFLIIB].Remove(this.NJEEHIMGBOG());
                    if (LiftObjectManager.PCCRigidbodyDictionary[HJLAPMFLIIB].Count == 0)
                    {
                        LiftObjectManager.ReturnPCCHashSetToPool(LiftObjectManager.PCCRigidbodyDictionary[HJLAPMFLIIB]);
                        LiftObjectManager.PCCRigidbodyDictionary.Remove(HJLAPMFLIIB);
                        return;
                    }
                }
                else
                {
                    LiftObjectManager.PCCRigidbodyDictionary.Remove(HJLAPMFLIIB);
                }
            }
        }

        public bool KJAIPDGCFBI()
        {
            return this.ODHHBGLGBOB;
        }



        private void Awake()
        {
            this.GCIIBALOLJM = this.DJOLKGGCCJA.radius;
        }

        private void OnDestroy()
        {
            this.KAFCDALNOPJ = false;
        }












        internal void MBIJOJNNCIM(GameObject EEPACGJDMJM)
        {
            if (this.PJINDHCBKGO != EEPACGJDMJM)
            {
                if (EEPACGJDMJM != null)
                {
                    if (PGNNPNAAFLP.EFAJMCPOLOE.ContainsKey(EEPACGJDMJM))
                    {
                        PGNNPNAAFLP.EFAJMCPOLOE[EEPACGJDMJM].GJPHEIJFPMK(this.IMFNPPNIHKH().gameObject, (this.FAFDBIPICDJ().GreenFistL == base.gameObject) ? InteractiveObject.Side.LeftHand : InteractiveObject.Side.LeftHand);
                    }
                }
                else if (this.PJINDHCBKGO != null && PGNNPNAAFLP.EFAJMCPOLOE.ContainsKey(this.PJINDHCBKGO))
                {
                    PGNNPNAAFLP.EFAJMCPOLOE[this.PJINDHCBKGO].JACHNHEPJJG(this.OKEAOJIFBDP().gameObject, (this.OKEAOJIFBDP().GreenFistL == base.gameObject) ? InteractiveObject.Side.RightHand : InteractiveObject.Side.RightHand);
                }
                this.PJINDHCBKGO = EEPACGJDMJM;
            }
        }

        private CharacterStates KHABJLNHGKO
        {
            get
            {
                if (this.HAHJIPDKHLF == null)
                {
                    this.HAHJIPDKHLF = this.Parent.GetComponent<CharacterStates>();
                }
                return this.HAHJIPDKHLF;
            }
        }

        private PhysicCharacterController KPLKMDDKCML
        {
            get
            {
                if (this.FKDODJMPGMI == null)
                {
                    this.FKDODJMPGMI = this.Parent.GetComponent<PhysicCharacterController>();
                }
                return this.FKDODJMPGMI;
            }
        }







        internal GameObject LKCGBILOJJI
        {
            get
            {
                return this.PJINDHCBKGO;
            }
            set
            {
                if (this.PJINDHCBKGO != value)
                {
                    if (value != null)
                    {
                        if (PGNNPNAAFLP.EFAJMCPOLOE.ContainsKey(value))
                        {
                            PGNNPNAAFLP.EFAJMCPOLOE[value].DNAFBBMDEJK(this.KPLKMDDKCML.gameObject, (this.KPLKMDDKCML.GreenFistL == base.gameObject) ? InteractiveObject.Side.LeftHand : InteractiveObject.Side.RightHand);
                        }
                    }
                    else if (this.PJINDHCBKGO != null && PGNNPNAAFLP.EFAJMCPOLOE.ContainsKey(this.PJINDHCBKGO))
                    {
                        PGNNPNAAFLP.EFAJMCPOLOE[this.PJINDHCBKGO].FMIABHHKAOD(this.KPLKMDDKCML.gameObject, (this.KPLKMDDKCML.GreenFistL == base.gameObject) ? InteractiveObject.Side.LeftHand : InteractiveObject.Side.RightHand);
                    }
                    this.PJINDHCBKGO = value;
                }
            }
        }








        public void NAJFEPNEAHD()
        {
            if (this.MNIKDMOCGNA != null)
            {
                this.MNIKDMOCGNA.NLOOMFEBFFO();
            }
            this.PGMFNNIPBHP(false);
            this.GrabbingStaticObject = true;
            this.AEKDCJNNLHD(null);
            this.MMMGMIIDODH(null);
            this.NGHJLHFEIEI(true);
            this.OFPIFBLOPHE().liftObjectWeight = 313f;
            if (this.NJEEHIMGBOG().GreenFistL == base.gameObject)
            {
                this.DAKOCFHLPBG().BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
                this.KPLKMDDKCML.MKEOCJIIKKB();
                return;
            }
            this.NJEEHIMGBOG().EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.Punching;
            this.DAKOCFHLPBG().OPIJAEDLIKG();
        }







        public void UngrabObjDetail()
        {
            if (this.MNIKDMOCGNA != null)
            {
                this.MNIKDMOCGNA.OnDestroy();
            }
            this.isReaching = false;
            this.GrabbingStaticObject = false;
            this.GrabbedObjectGO = null;
            this.LKCGBILOJJI = null;
            this.ThisHandIsGrabbingObj = false;
            this.KHABJLNHGKO.liftObjectWeight = 0f;
            if (this.KPLKMDDKCML.GreenFistL == base.gameObject)
            {
                this.KPLKMDDKCML.BMFBMAMHGKG = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
                this.KPLKMDDKCML.MKEOCJIIKKB();
                return;
            }
            this.KPLKMDDKCML.EHGLGFNALGH = PhysicCharacterController.AKDGAGJFAOJ.Nothing;
            this.KPLKMDDKCML.OPIJAEDLIKG();
        }






        public bool GEPFLFOEENM()
        {
            return this.ODHHBGLGBOB;
        }

        public void NGHJLHFEIEI(bool EEPACGJDMJM)
        {
            if (this.ODHHBGLGBOB != EEPACGJDMJM)
            {
                this.ODHHBGLGBOB = EEPACGJDMJM;
                if (!this.ODHHBGLGBOB)
                {
                    this.NAJFEPNEAHD();
                    this.NNCGNDCFMKE(this.GCIIBALOLJM);
                }
            }
        }





        private void CANEICDHJCK()
        {
            if (this.IIOKFILHPDF != null)
            {
                this.IIOKFILHPDF.OBLGBHHMHPC();
            }
        }



        public void FBMANMIKMBH(bool EEPACGJDMJM)
        {
            if (this.GHHEOLCBGDH != EEPACGJDMJM)
            {
                this.GHHEOLCBGDH = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.BDKOJBBADON(1323f);
                    return;
                }
                if (!this.ThisHandIsGrabbingObj)
                {
                    this.NNCGNDCFMKE(this.GCIIBALOLJM);
                }
            }
        }






        public void AEKDCJNNLHD(GameObject EEPACGJDMJM)
        {
            if (this.JLGGJPDHJBP != EEPACGJDMJM)
            {
                this.JLGGJPDHJBP = EEPACGJDMJM;
                if (EEPACGJDMJM != null)
                {
                    if (EEPACGJDMJM.GetComponent<Rigidbody>() != null)
                    {
                        this.BFDBDIAGIKM(EEPACGJDMJM.GetComponent<Rigidbody>());
                    }
                    else
                    {
                        this.BPBGOPCOBFK(null);
                    }
                    if (PccManager.rigidbodyCharacterControllerMap.ContainsKey(EEPACGJDMJM))
                    {
                        this.DBOELKNINLI(PccManager.rigidbodyCharacterControllerMap[EEPACGJDMJM]);
                        return;
                    }
                    this.NONKCKEDNOD(null);
                    return;
                }
                else
                {
                    this.DGDNNMLLMHL(null);
                    this.NONKCKEDNOD(null);
                    if (!this.GrabbingStaticObject)
                    {
                        this.NGHJLHFEIEI(true);
                    }
                }
            }
        }



        private void NNCGNDCFMKE(float AINAMLCHFLF)
        {
            this.DJOLKGGCCJA.radius = AINAMLCHFLF;
        }



        private PhysicCharacterController OCKEGIBHDKE()
        {
            if (this.FKDODJMPGMI == null)
            {
                this.FKDODJMPGMI = this.Parent.GetComponent<PhysicCharacterController>();
            }
            return this.FKDODJMPGMI;
        }

        public void PGMFNNIPBHP(bool EEPACGJDMJM)
        {
            if (this.GHHEOLCBGDH != EEPACGJDMJM)
            {
                this.GHHEOLCBGDH = EEPACGJDMJM;
                if (EEPACGJDMJM)
                {
                    this.BDKOJBBADON(1676f);
                    return;
                }
                if (!this.OCLAHLDDLFB())
                {
                    this.BDKOJBBADON(this.GCIIBALOLJM);
                }
            }
        }





        private void DPIANPNBHLC(Rigidbody HJLAPMFLIIB)
        {
            if (BFNMKMBJKJO.HOBGDODGPIH(HJLAPMFLIIB).Count > 0)
            {
                using (List<Rigidbody>.Enumerator enumerator = BFNMKMBJKJO.HOBGDODGPIH(HJLAPMFLIIB).GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        Rigidbody key = enumerator.Current;
                        if (LiftObjectManager.PCCRigidbodyDictionary.ContainsKey(key))
                        {
                            if (LiftObjectManager.PCCRigidbodyDictionary[key] == null)
                            {
                                LiftObjectManager.PCCRigidbodyDictionary[key] = LiftObjectManager.GetPCCHashSetFromPool();
                            }
                            else
                            {
                                LiftObjectManager.PCCRigidbodyDictionary[key].Add(this.KPLKMDDKCML);
                            }
                        }
                        else
                        {
                            HashSet<PhysicCharacterController> hashSet = LiftObjectManager.GetPCCHashSetFromPool();
                            hashSet.Add(this.KPLKMDDKCML);
                            LiftObjectManager.PCCRigidbodyDictionary.Add(key, hashSet);
                        }
                    }
                    return;
                }
            }
            if (LiftObjectManager.PCCRigidbodyDictionary.ContainsKey(HJLAPMFLIIB))
            {
                if (LiftObjectManager.PCCRigidbodyDictionary[HJLAPMFLIIB] == null)
                {
                    LiftObjectManager.PCCRigidbodyDictionary[HJLAPMFLIIB] = LiftObjectManager.GetPCCHashSetFromPool();
                    return;
                }
                LiftObjectManager.PCCRigidbodyDictionary[HJLAPMFLIIB].Add(this.KPLKMDDKCML);
                return;
            }
            else
            {
                HashSet<PhysicCharacterController> hashSet2 = LiftObjectManager.GetPCCHashSetFromPool();
                hashSet2.Add(this.KPLKMDDKCML);
                LiftObjectManager.PCCRigidbodyDictionary.Add(HJLAPMFLIIB, hashSet2);
            }
        }










        internal void ADOFJBLIDFN()
        {
            this.ThisHandIsGrabbingObj = false;
        }



        public GameObject Parent;

        private bool GHHEOLCBGDH;

        private GameObject JLGGJPDHJBP;

        private Rigidbody PKPNCJBNBEK;

        private PhysicCharacterController GEODDMAIHIP;

        public bool GrabbingStaticObject;

        private bool ODHHBGLGBOB;

        public JointDrive GrabJointDrive = new JointDrive
        {
            positionSpring = 0f,
            positionDamper = 12f,
            maximumForce = 9999f
        };

        private GrabJoint MNIKDMOCGNA;

        private float PMAJPMCCNCN;

        private CharacterStates HAHJIPDKHLF;

        private PhysicCharacterController FKDODJMPGMI;

        private Rigidbody PNGFPCPBAKB;

        private WaitForFixedUpdate LGJIFPAHACH = new WaitForFixedUpdate();

        private GameObject FOIEFCHNCBK;

        private GrabCollisionDetect MIBGEKAAMGG;

        private GameObject PJINDHCBKGO;

        private bool AKEKCFAENEC;

        private SphereCollider KOFEJOHFKOE;

        private float GCIIBALOLJM;

        private float OJLPBGJEJLM;
    }
}