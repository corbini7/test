using System;
using UnityEngine;
namespace Deobfuscated
{
    internal class RigidbodyGrabPriority : MonoBehaviour
    {

        private void Start()
        {
            if (this.notRaise)
            {
                PADJPIDNGPI.LELFDPEBCIN.Add(this.rigidbody);
            }
            if (this.treatedAsStatic)
            {
                PADJPIDNGPI.CAHGLANGCEN.Add(this.rigidbody);
            }
        }



        private void OnDestroy()
        {
            if (PADJPIDNGPI.LELFDPEBCIN.Contains(this.rigidbody))
            {
                PADJPIDNGPI.LELFDPEBCIN.Remove(this.rigidbody);
            }
            if (PADJPIDNGPI.CAHGLANGCEN.Contains(this.rigidbody))
            {
                PADJPIDNGPI.CAHGLANGCEN.Remove(this.rigidbody);
            }
        }

        public bool notRaise;

        public bool treatedAsStatic;

        public Rigidbody rigidbody;
    }
}