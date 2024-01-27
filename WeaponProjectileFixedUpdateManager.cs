using System.Collections.Generic;
using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    internal class WeaponProjectileFixedUpdateManager : MonoBehaviour
    {

        private void FixedUpdate()
        {
            foreach (WeaponProjectile weaponProjectile in this.projectilesToUpdate)
            {
                weaponProjectile.UpdateProjectilePhysics();
            }
        }


        internal readonly List<WeaponProjectile> projectilesToUpdate = new List<WeaponProjectile>();
    }
}