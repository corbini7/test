using System;
using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    internal class RigidbodiesCanGrabbedSimultaneouly : MonoBehaviour
    {

        private void OnDestroy()
        {
            OFLJNAJKDHM.ACCIMJHBIML(this.rigidbodies);
        }

        private void Start()
        {
            OFLJNAJKDHM.NPDHCGHMKDE(this.rigidbodies);
        }


        public List<Rigidbody> rigidbodies;
    }
}