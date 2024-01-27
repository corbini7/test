using System;
using UnityEngine;
namespace Deobfuscated
{
    internal class CharacterDamage : MonoBehaviour
    {





        private void OnCollisionEnter(Collision NLJBANLOGGI)
        {
            if (PhysicsDummyModeManager.IsPaused || !this.NBFMOKBNBGP)
            {
                return;
            }
            if (NLJBANLOGGI.gameObject.layer == 10 && GameObjectToWeaponMapper.gameObjectToWeaponMap.ContainsKey(NLJBANLOGGI.gameObject) && GameObjectToWeaponMapper.gameObjectToWeaponMap[NLJBANLOGGI.gameObject].IsAttacking)
            {
                return;
            }
            if (NLJBANLOGGI.gameObject.transform.parent != null && NLJBANLOGGI.gameObject.transform.parent.gameObject == this.Holder)
            {
                return;
            }
            float magnitude = NLJBANLOGGI.impulse.magnitude;
            if (magnitude >= this.MinForceToCauseDamage)
            {
                float num = Mathf.Pow(magnitude / 80f, 1.3f);
                float num2 = Mathf.Pow(magnitude / 160f, 3f);
                this.PODIHHICOEG.DBHFPLBJGKH(num * 0.24f * this.DamageTweak * this.PODIHHICOEG.AntiDizzy * this.PODIHHICOEG.AntiDizzyByEquip);
                this.PODIHHICOEG.Health -= num2 * 0.12f * this.DamageTweak * this.PODIHHICOEG.AntiHealthLose * this.PODIHHICOEG.AntiHealthLoseByEquip;
                this.PODIHHICOEG.KilledByWhat = CharacterStates.KilledBy.KnockOut;
            }
        }




        private CharacterStates PODIHHICOEG
        {
            get
            {
                if (this.OGIKHBGBMFI == null)
                {
                    this.OGIKHBGBMFI = this.Holder.GetComponent<CharacterStates>();
                }
                return this.OGIKHBGBMFI;
            }
        }




        public GameObject Holder;

        public float DamageTweak = 0.5f;

        public float MinForceToCauseDamage = 5f;

        internal bool NBFMOKBNBGP = true;

        private CharacterStates OGIKHBGBMFI;
    }
}