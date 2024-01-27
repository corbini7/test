using UnityEngine;
namespace Deobfuscated
{
    internal class PunchHitEffectSpawner : HitEffectSpawner
    {





        public override void SpawnEffect(GameObject DHDCFCOKNMF)
        {
            base.SpawnEffect(DHDCFCOKNMF);
            this.LPHELLDLIMG = (base.transform.position - this.FOJABPKNHKD.transform.position).normalized;
            if (Mathf.Abs(Vector3.Dot(this.LPHELLDLIMG, base.transform.forward)) > 0.99f)
            {
                this.KCLKEAIPNPP = base.transform.up;
            }
            else
            {
                this.KCLKEAIPNPP = Vector3.Cross(this.LPHELLDLIMG, base.transform.up).normalized;
            }
            Object.Instantiate<GameObject>(DHDCFCOKNMF, base.transform.position, Quaternion.LookRotation(this.LPHELLDLIMG, this.KCLKEAIPNPP));
        }



        private GameObject FOJABPKNHKD;

        private Vector3 LPHELLDLIMG;

        private Vector3 KCLKEAIPNPP;
    }
}