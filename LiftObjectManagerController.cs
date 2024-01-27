using System.Linq;
using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    internal class LiftObjectManagerController : MonoBehaviour
    {
        private void OnDestroy()
        {
            foreach (Rigidbody key in LiftObjectManager.PCCRigidbodyDictionary.Keys.ToList<Rigidbody>())
            {
                if (LiftObjectManager.PCCRigidbodyDictionary[key] != null)
                {
                    LiftObjectManager.PCCRigidbodyDictionary[key].Clear();
                    LiftObjectManager.ReturnPCCHashSetToPool(LiftObjectManager.PCCRigidbodyDictionary[key]);
                }
                LiftObjectManager.PCCRigidbodyDictionary.Remove(key);
            }
        }
    }
}