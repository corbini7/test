using System.Collections.Generic;
using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    public static class ElectricStatesManager
    {
        internal static void RegisterElectricState(GameObject gameObject, ElectricStates electricState)
        {
            gameObjectToElectricStateMap.Add(gameObject, electricState);
            registeredElectricStates.Add(electricState);
        }

        internal static void UnregisterElectricState(GameObject gameObject)
        {
            registeredElectricStates.Remove(gameObjectToElectricStateMap[gameObject]);
            gameObjectToElectricStateMap.Remove(gameObject);
        }

        public static ElectricStates GetElectricStates(GameObject gameObject)
        {
            if (gameObjectToElectricStateMap.ContainsKey(gameObject))
            {
                return gameObjectToElectricStateMap[gameObject];
            }
            return null;
        }

        internal static Dictionary<GameObject, ElectricStates> gameObjectToElectricStateMap = new Dictionary<GameObject, ElectricStates>();

        internal static HashSet<ElectricStates> registeredElectricStates = new HashSet<ElectricStates>();

        internal static ElectricStatesController ElectricStatesControllerInstance;
    }
}