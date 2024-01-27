using System.Collections.Generic;
using UnityEngine;
using Fusion;


namespace Deobfuscated
{
    public class Weapon : NetworkBehaviour
    {






        internal virtual void LDCAMGLJFJG()
        {
            this.LGLOPGKONLO.angularVelocity = Vector3.zero;
        }






        public float NoPowerRecoverCD { get; set; }

        internal virtual void HPMGJPMEFED(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
        }

        internal virtual void NGAFJKGCKMN()
        {
            this.GCAPLNOJOFM(null);
        }





        internal virtual void DPMCHIFEGKO(PhysicCharacterController MCFOLNMFCPN, ref bool OGMMABHJCNI)
        {
        }



        private void OMCANMBABCP(Weapon.JLCPDFFPDCF KOMCGCIBLEP)
        {
            this.GBHEKKJFIJE.Remove(KOMCGCIBLEP);
        }

        protected virtual void LKIECPMHADJ(GameObject MAKHHGBKEKA)
        {
            this.Owner = MAKHHGBKEKA;
        }








        internal virtual void FCPOCNFEKCJ(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG)
        {
        }


        public WeaponType weaponType
        {
            get
            {
                return this.m_WeaponType;
            }
        }




        protected void BLKCAIGLNMJ(PhysicCharacterController FLPIPBCIIHB)
        {
            foreach (Weapon.JLCPDFFPDCF jlcpdffpdcf in this.GBHEKKJFIJE)
            {
                jlcpdffpdcf.OnAttackingSomeone(FLPIPBCIIHB);
            }
        }


        internal virtual float FBJDPKDEJNP
        {
            get
            {
                return 0f;
            }
        }



        private void MOFNCDKJBED(Weapon.IIDPMLDBKFM KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Remove(KOMCGCIBLEP);
        }




        public GameObject Owner
        {
            get
            {
                return this.IILPJMAEHAO;
            }
            protected set
            {
                if (this.IILPJMAEHAO != value)
                {
                    if (value == null)
                    {
                        this.weaponIsEquipped = false;
                        if (this.IEDNGFIDBBL != null)
                        {
                            this.OMCANMBABCP(this.IEDNGFIDBBL);
                            this.MOFNCDKJBED(this.IEDNGFIDBBL);
                        }
                        this.IEDNGFIDBBL = null;
                    }
                    else
                    {
                        this.IEDNGFIDBBL = PccManager.gameObjectToCharacterControllerMap[value];
                        this.EHMAHJAIJFK(this.IEDNGFIDBBL);
                        this.ELIGPBNCLIG(this.IEDNGFIDBBL);
                    }
                    this.IILPJMAEHAO = value;
                }
            }
        }

        internal virtual void GDENHBKDDGO()
        {
            this.GCAPLNOJOFM(null);
        }










        internal virtual void PDCFAMMLLCG(Vector3 LPDJIJPIHBC)
        {
            this.JCGCLLMLCLH.position = LPDJIJPIHBC;
        }










        internal virtual void CFFDMBHGHFE(Quaternion OBBHADEMJNK)
        {
            this.JCGCLLMLCLH.rotation = OBBHADEMJNK;
        }



        internal virtual void DMJOIPHGHEB(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, float BNLPAPMFDLL, bool DOLMJFFJFBH, bool PKGLIMPDIIP, bool GHMBNLHGMHG, float DPKCPMHPAAJ)
        {
        }





        public float PowerConsume { get; set; }


        internal Rigidbody LGLOPGKONLO
        {
            get
            {
                if (this.HLHFKCOMBNK == null)
                {
                    this.HLHFKCOMBNK = base.GetComponent<Rigidbody>();
                }
                return this.HLHFKCOMBNK;
            }
        }



        internal virtual void PJHLCELOAHP(WeaponProjectile LMKANGLMDPO)
        {
        }

        protected Transform JCGCLLMLCLH
        {
            get
            {
                if (this.KFJLBANCNCK == null)
                {
                    this.KFJLBANCNCK = base.transform;
                }
                return this.KFJLBANCNCK;
            }
        }




        internal virtual void OFBBDAJGDHN()
        {
            this.LKIECPMHADJ(null);
        }


        private void EHMAHJAIJFK(Weapon.JLCPDFFPDCF KOMCGCIBLEP)
        {
            this.GBHEKKJFIJE.Add(KOMCGCIBLEP);
        }








        public bool weaponIsEquipped
        {
            get
            {
                return this.FMLKHBOOGAC;
            }
            set
            {
                if (this.FMLKHBOOGAC == value)
                {
                    return;
                }
                if (value)
                {
                    this.IKIJBENLEFE();
                }
                else
                {
                    this.GIKCPEIMJFO();
                }
                this.FMLKHBOOGAC = value;
            }
        }




        internal virtual void GIKCPEIMJFO()
        {
            this.LGLOPGKONLO.useGravity = true;
            this.LGLOPGKONLO.mass = this.NormalWeight;
            CFOGGNCCHCO.IPIGMALBAKG(this.LGLOPGKONLO, Vector3.ClampMagnitude(this.LGLOPGKONLO.velocity, 25f));
        }


        protected virtual void ECNADICBAEI()
        {
        }




        internal virtual void CKNIMEIJEGN()
        {
            this.LGLOPGKONLO.velocity = Vector3.zero;
        }


        internal int JFDMKJOBPAG { get; private set; }



        public bool IsAttacking
        {
            get
            {
                return this.OHGACGGINAA;
            }
            set
            {
                if (this.OHGACGGINAA != value)
                {
                    this.OHGACGGINAA = value;
                    if (value)
                    {
                        this.ECNADICBAEI();
                    }
                }
            }
        }




        private void ELIGPBNCLIG(Weapon.IIDPMLDBKFM KOMCGCIBLEP)
        {
            this.PKOEBJAKICC.Add(KOMCGCIBLEP);
        }




        protected void JJMPJGKNCFK(PhysicCharacterController FLPIPBCIIHB)
        {
            foreach (Weapon.IIDPMLDBKFM iidpmldbkfm in this.PKOEBJAKICC)
            {
                iidpmldbkfm.OnKillSomeone(FLPIPBCIIHB);
            }
        }




        private void OnDestroy()
        {
            if (this.IEDNGFIDBBL != null)
            {
                this.IEDNGFIDBBL.CharacterDropWeapon();
            }
            else
            {
                this.GDENHBKDDGO();
            }
            GameObjectToWeaponMapper.gameObjectToWeaponMap.Remove(base.gameObject);
        }








        internal virtual void IncreaseAttackCount()
        {
            int num = this.JFDMKJOBPAG;
            this.JFDMKJOBPAG = num + 1;
        }














        internal virtual void AHKAOLIBCON()
        {
            this.LKIECPMHADJ(null);
        }





        protected virtual void GCAPLNOJOFM(GameObject MAKHHGBKEKA)
        {
            this.Owner = MAKHHGBKEKA;
        }

        internal virtual void GHGLMNMONHK(PhysicCharacterController MCFOLNMFCPN, float AGCJDIFCAKA, bool DOLMJFFJFBH, bool PKGLIMPDIIP)
        {
        }

        internal virtual void AGIKMKKNICC()
        {
        }










        internal virtual void MPKJPGBHBNK()
        {
        }


        protected virtual void Awake()
        {
            GameObjectToWeaponMapper.gameObjectToWeaponMap.Add(base.gameObject, this);
            this.LGLOPGKONLO.maxDepenetrationVelocity = 1f;
            this.GIKCPEIMJFO();
            if (this.grabPositions == null || this.grabPositions.Count == 0)
            {
                Debug.LogError(base.gameObject.name + " No Valid Grab Position!");
            }
        }





        internal virtual void IKIJBENLEFE()
        {
        }







        public WeaponController weaponController;

        public int BulletCount;

        public float TotalDamgeScale = 1f;

        public float HealthRate = 0.5f;

        public float NormalWeight = 5f;

        public float GrabbedWeight = 1f;

        protected readonly WaitForFixedUpdate MJOFAKABBGM = new WaitForFixedUpdate();

        private bool OHGACGGINAA;

        protected float LIFGGMBLIBC;

        private Rigidbody HLHFKCOMBNK;

        private Transform KFJLBANCNCK;

        private GameObject IILPJMAEHAO;

        protected PhysicCharacterController IEDNGFIDBBL;

        private bool FMLKHBOOGAC;

        public List<Transform> grabPositions;

        internal bool ECPGAOFDCKC;

        [SerializeField]
        private WeaponType m_WeaponType;

        private readonly HashSet<Weapon.JLCPDFFPDCF> GBHEKKJFIJE = new HashSet<Weapon.JLCPDFFPDCF>();

        private readonly HashSet<Weapon.IIDPMLDBKFM> PKOEBJAKICC = new HashSet<Weapon.IIDPMLDBKFM>();

        internal interface JLCPDFFPDCF
        {
            void OnAttackingSomeone(PhysicCharacterController PKBFLBHFLBN);
        }

        internal interface IIDPMLDBKFM
        {
            void OnKillSomeone(PhysicCharacterController PKBFLBHFLBN);
        }
    }
}