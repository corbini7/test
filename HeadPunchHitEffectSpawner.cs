using UnityEngine;
namespace Deobfuscated
{
    internal class HeadPunchHitEffectSpawner : HitEffectSpawner
    {

        public override void SpawnEffect(GameObject DHDCFCOKNMF)
        {
            base.SpawnEffect(DHDCFCOKNMF);
            Object.Instantiate<GameObject>(DHDCFCOKNMF, base.transform.localToWorldMatrix.MultiplyPoint(this.IEHCPBGOFEC), Quaternion.LookRotation(-base.transform.up, base.transform.forward));
        }


        private Vector3 IEHCPBGOFEC = new Vector3(0f, -0.404f, 0.224f);
    }
}