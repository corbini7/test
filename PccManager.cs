using System.Collections.Generic;
using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    public static class PccManager
    {
        public static bool RigidbodyHasPhysicCharacterController(GameObject targetGameObject, out PhysicCharacterController physicCharacterController)
        {
            if (rigidbodyCharacterControllerMap.ContainsKey(targetGameObject))
            {
                physicCharacterController = rigidbodyCharacterControllerMap[targetGameObject];
                return true;
            }
            physicCharacterController = null;
            return false;
        }

        internal static readonly Dictionary<GameObject, PhysicCharacterController> gameObjectToCharacterControllerMap = new Dictionary<GameObject, PhysicCharacterController>();

        internal static readonly Dictionary<GameObject, PhysicCharacterController> rigidbodyCharacterControllerMap = new Dictionary<GameObject, PhysicCharacterController>();

        internal static readonly List<Transform> trackedTransforms = new List<Transform>();
    }
}