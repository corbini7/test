using System;
using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    public class PhysicsIgnoredList
    {
        public static HashSet<GameObject> NoGrabObjects;

        public static HashSet<GameObject> ArrowCantAttachObjects;

        public static HashSet<GameObject> PinCantAttachObjects;

        public static HashSet<GameObject> NoWalkingDustObjects;

        public static HashSet<GameObject> NoLiftObjects;
    }
}