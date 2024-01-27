using System.Collections;
using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    internal class ElectricStatesController : MonoBehaviour
    {
        private void OnDestroy()
        {
            ElectricStatesManager.ElectricStatesControllerInstance = null;
        }














        private void Awake()
        {
            base.StartCoroutine(this.UpdateElectricStatesRoutine());
        }


        private IEnumerator UpdateElectricStatesRoutine()
        {
            for (; ; )
            {
                if (!PhysicsDummyModeManager.IsPaused)
                {
                    foreach (ElectricStates electricStates in ElectricStatesManager.registeredElectricStates)
                    {
                        electricStates.UpdateElectricState();
                    }
                }
                yield return this.waitForFixedUpdate;
            }
            yield break;
        }








        private WaitForFixedUpdate waitForFixedUpdate = new WaitForFixedUpdate();
    }
}