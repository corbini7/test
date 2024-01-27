using System;
using UnityEngine;
namespace Deobfuscated
{
    public class EnergyBladeEdge : MonoBehaviour
    {

        private void OnTriggerEnter(Collider IADOLHKINCH)
        {
            if (IADOLHKINCH.gameObject.GetComponent<Rigidbody>() != null)
            {
                Rigidbody component = IADOLHKINCH.GetComponent<Rigidbody>();
                if (component != null)
                {
                    Vector3 olhjpbamdmn = new Vector3(0f, 1f, 0f) * 60f;
                    CFOGGNCCHCO.EFNEGHJPJFN(component, olhjpbamdmn, ForceMode.Impulse);
                }
            }
        }


    }
}