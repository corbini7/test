using System;
using UnityEngine;
namespace Deobfuscated
{
    internal class RGrabObj : GrabObj
    {

        private void OnDestroy()
        {
            Debug.Log("RGrabObj is destroyed on " + base.gameObject.name);
        }


    }
}