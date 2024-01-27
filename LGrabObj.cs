using System;
using UnityEngine;
namespace Deobfuscated
{
    internal class LGrabObj : GrabObj
    {

        private void OnDestroy()
        {
            Debug.Log("LGrabObj is destroyed on " + base.gameObject.name);
        }


    }
}