using UnityEngine;
namespace Deobfuscated
{
    internal class DICBDBEIGEP
    {




        public void CharacterBreath(ConfigurableJoint CDBGCHHHPFL, ConfigurableJoint AKFKHFBDPBI, ConfigurableJoint GDPPIFIJPMF, float PAKNGDIDFGK)
        {
            this.NLHMIFFMKJG = CDBGCHHHPFL.targetRotation;
            this.HOJEDALKCKL = AKFKHFBDPBI.targetRotation;
            this.NNPAHMGEAHB = GDPPIFIJPMF.targetRotation;
            this.MBBIGMFLDBP = Mathf.Pow((PAKNGDIDFGK * this.IGCKEOCPKHC - (float)Mathf.FloorToInt(PAKNGDIDFGK * this.IGCKEOCPKHC / 3.1415927f) * 3.1415927f) / 3.1415927f, 0.9f) * 3.1415927f * 1.17f;
            this.BMDJHDLNNGN = Mathf.Clamp01(Mathf.Sin(this.MBBIGMFLDBP)) * 2f;
            CDBGCHHHPFL.targetRotation = new Quaternion(this.NLHMIFFMKJG.x + (this.BMDJHDLNNGN - 1f) * 0.018f, this.NLHMIFFMKJG.y, this.NLHMIFFMKJG.z, this.NLHMIFFMKJG.w);
            AKFKHFBDPBI.targetRotation = new Quaternion(this.HOJEDALKCKL.x, this.HOJEDALKCKL.y + this.BMDJHDLNNGN * 0.021f, this.HOJEDALKCKL.z, this.HOJEDALKCKL.w);
            GDPPIFIJPMF.targetRotation = new Quaternion(this.NNPAHMGEAHB.x, this.NNPAHMGEAHB.y - this.BMDJHDLNNGN * 0.021f, this.NNPAHMGEAHB.z, this.NNPAHMGEAHB.w);
        }





        public DICBDBEIGEP()
        {
            this.IGCKEOCPKHC = Random.Range(0.6f, 0.625f);
        }




        private Quaternion NLHMIFFMKJG;

        private Quaternion HOJEDALKCKL;

        private Quaternion NNPAHMGEAHB;

        private float IGCKEOCPKHC = 1f;

        private float MBBIGMFLDBP;

        private float BMDJHDLNNGN;
    }
}