using UnityEngine;
namespace Deobfuscated
{
    internal class FixedUpdateCounterComponent : MonoBehaviour
    {




        internal int DMKOPKFIGLN { get; private set; }







        private void FixedUpdate()
        {
            this.DMKOPKFIGLN++;
            if (this.DMKOPKFIGLN >= 99999)
            {
                this.DMKOPKFIGLN = 0;
            }
        }




    }
}