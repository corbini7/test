using System;
using UnityEngine;
namespace Deobfuscated
{
    public class HitEffectController : MonoBehaviour
    {




        public int DizzyForDisplay
        {
            get
            {
                return this.NPIENCNHHOA;
            }
            set
            {
                if (this.NPIENCNHHOA != value)
                {
                    if (this.NPIENCNHHOA - value > this.WaterSprayThreshold)
                    {
                        this.SprayWater();
                    }
                    this.NPIENCNHHOA = value;
                }
            }
        }









        private void Start()
        {
            if (this.WaterSpray != null)
            {
                this.NJDODIEKHNI = this.WaterSpray.GetComponent<ParticleSystem>();
            }
        }






        public void SprayWater()
        {
            if (this.NJDODIEKHNI != null)
            {
                this.NJDODIEKHNI.Play();
            }
        }












        public GameObject WaterSpray;

        private ParticleSystem NJDODIEKHNI;

        private int NPIENCNHHOA;

        public int WaterSprayThreshold = 50;
    }
}