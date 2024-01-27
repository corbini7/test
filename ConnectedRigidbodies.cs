using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    public class ConnectedRigidbodies : MonoBehaviour
    {

        private void Start()
        {
            BFNMKMBJKJO.NPDHCGHMKDE(this.rigidbodiesConnected);
        }


        private void OnDestroy()
        {
            BFNMKMBJKJO.ACCIMJHBIML(this.rigidbodiesConnected);
        }


        public List<Rigidbody> rigidbodiesConnected;
    }
}