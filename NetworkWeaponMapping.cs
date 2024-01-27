using System.Collections.Generic;
using Fusion;

// TODO DONE
namespace Deobfuscated
{
    internal static class NetworkWeaponMapping
    {
        //internal static readonly Dictionary<GameObject, WeaponProjectile> EFEACIJPBKP = new Dictionary<GameObject, WeaponProjectile>();
        internal static readonly Dictionary<NetworkObject, WeaponProjectile> NetworkObjectToProjectileMap = new Dictionary<NetworkObject, WeaponProjectile>();
    }
}