using UnityEngine;
namespace Deobfuscated
{
    internal class KickHitEffectSpawner : HitEffectSpawner
    {

        public override void SpawnEffect(GameObject DHDCFCOKNMF)
        {
            base.SpawnEffect(DHDCFCOKNMF);
            Object.Instantiate<GameObject>(DHDCFCOKNMF, base.transform.position, Quaternion.LookRotation(-base.transform.forward, base.transform.up));
        }


    }
}