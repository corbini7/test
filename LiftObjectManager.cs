using System.Collections.Generic;
using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    internal static class LiftObjectManager
    {
        static LiftObjectManager()
        {
            PCCRigidbodyDictionary = new Dictionary<Rigidbody, HashSet<PhysicCharacterController>>();
            for (int i = 0; i < 64; i++)
            {
                _PCCHashSetPool.Push(new HashSet<PhysicCharacterController>());
            }
        }

        internal static HashSet<PhysicCharacterController> GetPCCHashSetFromPool()
        {
            if (_PCCHashSetPool.Count > 0)
            {
                return _PCCHashSetPool.Pop();
            }
            _PCCHashSetPool.Push(new HashSet<PhysicCharacterController>());
            return _PCCHashSetPool.Pop();
        }

        internal static void ReturnPCCHashSetToPool(HashSet<PhysicCharacterController> PCCHashSet)
        {
            _PCCHashSetPool.Push(PCCHashSet);
        }

        internal static Dictionary<Rigidbody, HashSet<PhysicCharacterController>> PCCRigidbodyDictionary;

        private static readonly Stack<HashSet<PhysicCharacterController>> _PCCHashSetPool = new Stack<HashSet<PhysicCharacterController>>();

        internal static LiftObjectManagerController LiftObjectManagerController;
    }
}