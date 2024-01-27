// TODO DONE
namespace Deobfuscated
{
    internal class EffectIdManager
    {
        public static int PunchAndGrabPosID
        {
            get
            {
                EffectIdManager.UpdateCounter(ref EffectIdManager.punchAndGrabPosCounter, 0, 2);
                return EffectIdManager.punchAndGrabPosCounter;
            }
        }



        public static int RunningDustEffectID
        {
            get
            {
                EffectIdManager.UpdateCounter(ref EffectIdManager.runningDustEffectCounter, 0, 1);
                return EffectIdManager.runningDustEffectCounter;
            }
        }



        public static int BodyDustEffectID
        {
            get
            {
                EffectIdManager.UpdateCounter(ref EffectIdManager.bodyDustEffectCounter, 0, 2);
                return EffectIdManager.bodyDustEffectCounter;
            }
        }

        public static int JumpID
        {
            get
            {
                EffectIdManager.UpdateCounter(ref EffectIdManager.jumpIdCounter, 0, 2);
                return EffectIdManager.jumpIdCounter;
            }
        }



        private static void UpdateCounter(ref int counter, int min, int max)
        {
            if (counter >= max)
            {
                counter = min;
                return;
            }
            counter++;
        }


        private static int jumpIdCounter = 1;

        private static int punchAndGrabPosCounter = 1;

        private static int runningDustEffectCounter = 1;

        private static int bodyDustEffectCounter = 2;
    }
}