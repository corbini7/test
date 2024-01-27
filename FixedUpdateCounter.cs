using UnityEngine;
namespace Deobfuscated
{
    public static class FixedUpdateCounter
    {
        public static int frameCount
        {
            get
            {
                if (FixedUpdateCounter.BJCAGNNIICF == null)
                {
                    FixedUpdateCounter.BJCAGNNIICF = new GameObject
                    {
                        name = "FixedUpdaterCounter"
                    }.AddComponent<FixedUpdateCounterComponent>();
                }
                return FixedUpdateCounter.BJCAGNNIICF.DMKOPKFIGLN;
            }
        }

        private static FixedUpdateCounterComponent BJCAGNNIICF;
    }
}