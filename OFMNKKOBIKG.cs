using UnityEngine;
namespace Deobfuscated
{
    internal class OFMNKKOBIKG
    {

        internal void AOKMBPLCGHI(float CMJDIPPJAGO, float OOLLDMLBGLP, PhysicMaterialCombine ADKDLBILIAC)
        {
            this.JGMNCPOFIPC.staticFriction = CMJDIPPJAGO;
            this.JGMNCPOFIPC.dynamicFriction = OOLLDMLBGLP;
            this.JGMNCPOFIPC.frictionCombine = ADKDLBILIAC;
        }


        internal void FIICDLLMMBC(float CMJDIPPJAGO, float OOLLDMLBGLP, PhysicMaterialCombine ADKDLBILIAC)
        {
            this.KHNKGENDLJJ.staticFriction = CMJDIPPJAGO;
            this.KHNKGENDLJJ.dynamicFriction = OOLLDMLBGLP;
            this.KHNKGENDLJJ.frictionCombine = ADKDLBILIAC;
        }


        internal void MDADOFMGFAP(float CMJDIPPJAGO, float OOLLDMLBGLP, PhysicMaterialCombine ADKDLBILIAC)
        {
            this.CIPLCEFFBKD.staticFriction = CMJDIPPJAGO;
            this.CIPLCEFFBKD.dynamicFriction = OOLLDMLBGLP;
            this.CIPLCEFFBKD.frictionCombine = ADKDLBILIAC;
        }


        internal void JFFGEAGPKFA(float CMJDIPPJAGO, float OOLLDMLBGLP, PhysicMaterialCombine ADKDLBILIAC)
        {
            this.LJFMFGJPMCK.staticFriction = CMJDIPPJAGO;
            this.LJFMFGJPMCK.dynamicFriction = OOLLDMLBGLP;
            this.LJFMFGJPMCK.frictionCombine = ADKDLBILIAC;
        }


        internal void GFGIJKOKKOL(float CMJDIPPJAGO, float OOLLDMLBGLP, PhysicMaterialCombine ADKDLBILIAC)
        {
            this.BGIDIBCNPOO.staticFriction = CMJDIPPJAGO;
            this.BGIDIBCNPOO.dynamicFriction = OOLLDMLBGLP;
            this.BGIDIBCNPOO.frictionCombine = ADKDLBILIAC;
        }


        internal OFMNKKOBIKG(PhysicCharacterController MCFOLNMFCPN)
        {
            PhysicMaterial material = new PhysicMaterial
            {
                bounciness = 0f,
                bounceCombine = PhysicMaterialCombine.Minimum
            };
            PhysicMaterial material2 = new PhysicMaterial
            {
                dynamicFriction = 5f,
                staticFriction = 5f,
                bounciness = 0f,
                frictionCombine = PhysicMaterialCombine.Minimum
            };
            PhysicMaterial material3 = new PhysicMaterial
            {
                dynamicFriction = 5f,
                staticFriction = 5f,
                bounciness = 0f,
                frictionCombine = PhysicMaterialCombine.Average
            };
            PhysicMaterial material4 = new PhysicMaterial
            {
                dynamicFriction = 0f,
                staticFriction = 0f,
                bounciness = 0f,
                frictionCombine = PhysicMaterialCombine.Average
            };
            Collider component = MCFOLNMFCPN.GreenHead.GetComponent<Collider>();
            Collider component2 = MCFOLNMFCPN.GreenChest.GetComponent<Collider>();
            Collider component3 = MCFOLNMFCPN.GreenWaist.GetComponent<Collider>();
            Collider component4 = MCFOLNMFCPN.GreenHip.GetComponent<Collider>();
            Collider component5 = MCFOLNMFCPN.GreenUpperArmL.GetComponent<Collider>();
            Collider component6 = MCFOLNMFCPN.GreenUpperArmR.GetComponent<Collider>();
            Collider component7 = MCFOLNMFCPN.GreenForeArmL.GetComponent<Collider>();
            Collider component8 = MCFOLNMFCPN.GreenForeArmR.GetComponent<Collider>();
            Collider component9 = MCFOLNMFCPN.GreenFistL.GetComponent<Collider>();
            Collider component10 = MCFOLNMFCPN.GreenFistR.GetComponent<Collider>();
            Collider component11 = MCFOLNMFCPN.GreenLegL1.GetComponent<Collider>();
            Collider component12 = MCFOLNMFCPN.GreenLegR1.GetComponent<Collider>();
            Collider component13 = MCFOLNMFCPN.GreenLegL2.GetComponent<Collider>();
            Collider component14 = MCFOLNMFCPN.GreenLegR2.GetComponent<Collider>();
            component.material = material3;
            component2.material = material3;
            component3.material = material3;
            component4.material = material2;
            component5.material = material3;
            component6.material = material3;
            component7.material = material3;
            component8.material = material3;
            component9.material = material4;
            component10.material = material4;
            component11.material = material3;
            component12.material = material3;
            component13.material = material;
            component14.material = material;
            this.DNPBCOMIIME = component.material;
            this.EBNIMPIJPLN = component2.material;
            this.DELDFGGBMLN = component3.material;
            this.MDJBEANEFAI = component4.material;
            this.LAEFKNACOIO = component5.material;
            this.BGIDIBCNPOO = component6.material;
            this.BPAKAFCODCM = component7.material;
            this.LJFMFGJPMCK = component8.material;
            this.MMDEPDHNBEL = component9.material;
            this.KHNKGENDLJJ = component10.material;
            this.MKENNEAPINP = component11.material;
            this.JDIONDPNBLA = component12.material;
            this.JGMNCPOFIPC = component13.material;
            this.CIPLCEFFBKD = component14.material;
        }



        private PhysicMaterial DNPBCOMIIME;

        private PhysicMaterial EBNIMPIJPLN;

        private PhysicMaterial DELDFGGBMLN;

        private PhysicMaterial MDJBEANEFAI;

        private PhysicMaterial LAEFKNACOIO;

        private PhysicMaterial BGIDIBCNPOO;

        private PhysicMaterial BPAKAFCODCM;

        private PhysicMaterial LJFMFGJPMCK;

        private PhysicMaterial MMDEPDHNBEL;

        private PhysicMaterial KHNKGENDLJJ;

        private PhysicMaterial MKENNEAPINP;

        private PhysicMaterial JDIONDPNBLA;

        private PhysicMaterial JGMNCPOFIPC;

        private PhysicMaterial CIPLCEFFBKD;
    }
}