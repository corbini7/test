using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    internal class FootCollision : MonoBehaviour
    {

        private void OnCollisionExit(Collision IADOLHKINCH)
        {
            if (this.ANLOJKFEJIF.Contains(IADOLHKINCH.gameObject))
            {
                this.ANLOJKFEJIF.Remove(IADOLHKINCH.gameObject);
            }
        }


        private void OnCollisionEnter(Collision IADOLHKINCH)
        {
            this.ANLOJKFEJIF.Add(IADOLHKINCH.gameObject);
        }


        internal readonly HashSet<GameObject> ANLOJKFEJIF = new HashSet<GameObject>();
    }
}