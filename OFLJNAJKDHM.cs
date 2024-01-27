using System;
using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    internal static class OFLJNAJKDHM
    {
        internal static void NPDHCGHMKDE(List<Rigidbody> GPOIOKNHDNH)
        {
            foreach (Rigidbody rigidbody in GPOIOKNHDNH)
            {
                if (!OFLJNAJKDHM.BFBBKPJOPMO.ContainsKey(rigidbody))
                {
                    OFLJNAJKDHM.BFBBKPJOPMO.Add(rigidbody, OFLJNAJKDHM.MIMMALGCDEK);
                    rigidbody.gameObject.AddComponent<RigidbodiesCanGrabbedSimultaneoulyOnDestroy>().DPIJEBPBDMM = rigidbody;
                }
            }
            OFLJNAJKDHM.MIMMALGCDEK++;
        }

        internal static void ACCIMJHBIML(List<Rigidbody> GPOIOKNHDNH)
        {
            foreach (Rigidbody key in GPOIOKNHDNH)
            {
                if (OFLJNAJKDHM.BFBBKPJOPMO.ContainsKey(key))
                {
                    OFLJNAJKDHM.BFBBKPJOPMO.Remove(key);
                }
            }
            if (OFLJNAJKDHM.BFBBKPJOPMO.Keys.Count == 0)
            {
                OFLJNAJKDHM.MIMMALGCDEK = 0;
            }
        }

        internal static bool NMNBLMIPPID(Rigidbody ILOLBDAFLIG, Rigidbody DGCOKMPGMID)
        {
            bool result = false;
            if (OFLJNAJKDHM.BFBBKPJOPMO.ContainsKey(ILOLBDAFLIG) && OFLJNAJKDHM.BFBBKPJOPMO.ContainsKey(DGCOKMPGMID) && OFLJNAJKDHM.BFBBKPJOPMO[ILOLBDAFLIG] == OFLJNAJKDHM.BFBBKPJOPMO[DGCOKMPGMID])
            {
                result = true;
            }
            return result;
        }

        internal static void NADFFCEENKK(Rigidbody HNMALBNOMNJ)
        {
            if (OFLJNAJKDHM.BFBBKPJOPMO.ContainsKey(HNMALBNOMNJ))
            {
                OFLJNAJKDHM.BFBBKPJOPMO.Remove(HNMALBNOMNJ);
            }
            if (OFLJNAJKDHM.BFBBKPJOPMO.Keys.Count == 0)
            {
                OFLJNAJKDHM.MIMMALGCDEK = 0;
            }
        }

        private static readonly Dictionary<Rigidbody, int> BFBBKPJOPMO = new Dictionary<Rigidbody, int>();

        private static int MIMMALGCDEK = 0;
    }
}