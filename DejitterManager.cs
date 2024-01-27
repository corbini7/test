namespace Deobfuscated
{
    public class DejitterManager
    {

        public static DejitterManager Singleton
        {
            get
            {
                DejitterManager result;
                if ((result = DejitterManager.DKPGLKJBAOG) == null)
                {
                    result = (DejitterManager.DKPGLKJBAOG = new DejitterManager());
                }
                return result;
            }
        }


        private static DejitterManager DKPGLKJBAOG;

        public float bufTargetSize;

        public int interpolationCount = 1;
    }
}