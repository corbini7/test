using System;
using UnityEngine;
namespace Deobfuscated
{
    internal class FakeWavingPhysics : MonoBehaviour
    {

        private void Awake()
        {
        }


        [Range(0f, 20f)]
        public float Strength = 1f;

        [Range(0f, 20f)]
        public float Damp = 1f;
    }
}