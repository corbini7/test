using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    internal static class BFNMKMBJKJO
    {
        internal static void NPDHCGHMKDE(List<Rigidbody> GPOIOKNHDNH)
        {
            foreach (Rigidbody rigidbody in GPOIOKNHDNH)
            {
                if (!BFNMKMBJKJO.BFBBKPJOPMO.ContainsKey(rigidbody))
                {
                    BFNMKMBJKJO.BFBBKPJOPMO.Add(rigidbody, BFNMKMBJKJO.MIMMALGCDEK);
                    rigidbody.gameObject.AddComponent<ConnectedRigidbodiesOnDestroy>().DPIJEBPBDMM = rigidbody;
                }
                if (!BFNMKMBJKJO.MHGNCBHADCB.ContainsKey(BFNMKMBJKJO.MIMMALGCDEK))
                {
                    BFNMKMBJKJO.MHGNCBHADCB.Add(BFNMKMBJKJO.MIMMALGCDEK, rigidbody.mass);
                    List<Rigidbody> list = new List<Rigidbody>();
                    list.Add(rigidbody);
                    BFNMKMBJKJO.MOKFJHECHCN.Add(BFNMKMBJKJO.MIMMALGCDEK, list);
                }
                else
                {
                    Dictionary<int, float> mhgncbhadcb = BFNMKMBJKJO.MHGNCBHADCB;
                    int mimmalgcdek = BFNMKMBJKJO.MIMMALGCDEK;
                    mhgncbhadcb[mimmalgcdek] += rigidbody.mass;
                    BFNMKMBJKJO.MOKFJHECHCN[BFNMKMBJKJO.MIMMALGCDEK].Add(rigidbody);
                }
            }
            BFNMKMBJKJO.MIMMALGCDEK++;
        }

        internal static void ACCIMJHBIML(List<Rigidbody> GPOIOKNHDNH)
        {
            foreach (Rigidbody key in GPOIOKNHDNH)
            {
                if (BFNMKMBJKJO.BFBBKPJOPMO.ContainsKey(key))
                {
                    int key2 = BFNMKMBJKJO.BFBBKPJOPMO[key];
                    BFNMKMBJKJO.BFBBKPJOPMO.Remove(key);
                    if (BFNMKMBJKJO.MHGNCBHADCB.ContainsKey(key2))
                    {
                        BFNMKMBJKJO.MHGNCBHADCB.Remove(key2);
                        BFNMKMBJKJO.MOKFJHECHCN.Remove(key2);
                    }
                }
            }
            if (BFNMKMBJKJO.MHGNCBHADCB.Keys.Count == 0)
            {
                BFNMKMBJKJO.MIMMALGCDEK = 0;
            }
        }

        internal static void NADFFCEENKK(Rigidbody HNMALBNOMNJ)
        {
            if (BFNMKMBJKJO.BFBBKPJOPMO.ContainsKey(HNMALBNOMNJ))
            {
                int num = BFNMKMBJKJO.BFBBKPJOPMO[HNMALBNOMNJ];
                BFNMKMBJKJO.BFBBKPJOPMO.Remove(HNMALBNOMNJ);
                BFNMKMBJKJO.MOKFJHECHCN[num].Remove(HNMALBNOMNJ);
                if (BFNMKMBJKJO.MOKFJHECHCN[num].Count == 0)
                {
                    BFNMKMBJKJO.MOKFJHECHCN.Remove(num);
                    BFNMKMBJKJO.MHGNCBHADCB.Remove(num);
                }
                else
                {
                    Dictionary<int, float> mhgncbhadcb = BFNMKMBJKJO.MHGNCBHADCB;
                    int key = num;
                    mhgncbhadcb[key] -= HNMALBNOMNJ.mass;
                }
            }
            if (BFNMKMBJKJO.MHGNCBHADCB.Keys.Count == 0)
            {
                BFNMKMBJKJO.MIMMALGCDEK = 0;
            }
        }

        internal static bool POMKGJDAIBO(Rigidbody ILOLBDAFLIG, Rigidbody DGCOKMPGMID)
        {
            bool result = false;
            if (BFNMKMBJKJO.BFBBKPJOPMO.ContainsKey(ILOLBDAFLIG) && BFNMKMBJKJO.BFBBKPJOPMO.ContainsKey(DGCOKMPGMID) && BFNMKMBJKJO.BFBBKPJOPMO[ILOLBDAFLIG] == BFNMKMBJKJO.BFBBKPJOPMO[DGCOKMPGMID])
            {
                result = true;
            }
            return result;
        }

        internal static float NMMLAMPAMMC(Rigidbody HNMALBNOMNJ)
        {
            if (BFNMKMBJKJO.BFBBKPJOPMO.ContainsKey(HNMALBNOMNJ))
            {
                return BFNMKMBJKJO.MHGNCBHADCB[BFNMKMBJKJO.BFBBKPJOPMO[HNMALBNOMNJ]];
            }
            return HNMALBNOMNJ.mass;
        }

        internal static List<Rigidbody> HOBGDODGPIH(Rigidbody HNMALBNOMNJ)
        {
            if (!BFNMKMBJKJO.BFBBKPJOPMO.ContainsKey(HNMALBNOMNJ))
            {
                return BFNMKMBJKJO.HEBGLMONHID;
            }
            return BFNMKMBJKJO.MOKFJHECHCN[BFNMKMBJKJO.BFBBKPJOPMO[HNMALBNOMNJ]];
        }

        private static readonly Dictionary<Rigidbody, int> BFBBKPJOPMO = new Dictionary<Rigidbody, int>();

        private static readonly Dictionary<int, float> MHGNCBHADCB = new Dictionary<int, float>();

        private static readonly Dictionary<int, List<Rigidbody>> MOKFJHECHCN = new Dictionary<int, List<Rigidbody>>();

        private static int MIMMALGCDEK = 0;

        private static readonly List<Rigidbody> HEBGLMONHID = new List<Rigidbody>();
    }
}