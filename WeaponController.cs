using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    public class WeaponController : MonoBehaviour
    {


        public void SetAngularVelocityToZero()
        {
            foreach (Weapon weapon in this.weapons)
            {
                weapon.LDCAMGLJFJG();
            }
        }


        public GameObject WeaponOwner
        {
            get
            {
                return this.weapons[0].Owner;
            }
        }



        public void RemoveAttackInvokeCallback(WeaponController.IAttackInvokeCallback KOMCGCIBLEP)
        {
            this.MGMBJIJPMNN.Remove(KOMCGCIBLEP);
        }

        private void OnDestroy()
        {
            this.MGMBJIJPMNN.Clear();
        }


        public void CastProjectile(WeaponProjectile LMKANGLMDPO)
        {
            foreach (Weapon weapon in this.weapons)
            {
                weapon.PJHLCELOAHP(LMKANGLMDPO);
            }
        }

        public void AddAttackInvokeCallback(WeaponController.IAttackInvokeCallback KOMCGCIBLEP)
        {
            this.MGMBJIJPMNN.Add(KOMCGCIBLEP);
        }

        public void SetRotation(Quaternion GBCDLALHOMO)
        {
            foreach (Weapon weapon in this.weapons)
            {
                weapon.CFFDMBHGHFE(GBCDLALHOMO);
            }
        }


        public virtual Weapon weapon
        {
            get
            {
                return this.weapons[0];
            }
        }


        internal void JGBLPPKMAMA()
        {
            foreach (WeaponController.IAttackInvokeCallback attackInvokeCallback in this.MGMBJIJPMNN)
            {
                attackInvokeCallback.OnAttackInvoked();
            }
        }

        public void SetVelocityToZero()
        {
            foreach (Weapon weapon in this.weapons)
            {
                weapon.CKNIMEIJEGN();
            }
        }













        public void PlayWeaponAnimation()
        {
            foreach (Weapon weapon in this.weapons)
            {
                weapon.IncreaseAttackCount();
            }
        }



        public int AnimationCount
        {
            get
            {
                return this.weapons[0].JFDMKJOBPAG;
            }
        }




        internal void ACAFGMODKOB()
        {
            foreach (WeaponController.IAttackInvokeCallback attackInvokeCallback in this.MGMBJIJPMNN)
            {
                attackInvokeCallback.OnAttackInvoked();
            }
        }




        public void SetPosition(Vector3 FJCCBCEAALN)
        {
            foreach (Weapon weapon in this.weapons)
            {
                weapon.PDCFAMMLLCG(FJCCBCEAALN);
            }
        }


        internal void PIBCDFLFOGI()
        {
            foreach (WeaponController.IAttackInvokeCallback attackInvokeCallback in this.MGMBJIJPMNN)
            {
                attackInvokeCallback.OnAttackInvoked();
            }
        }




        internal readonly HashSet<WeaponController.IAttackInvokeCallback> MGMBJIJPMNN = new HashSet<WeaponController.IAttackInvokeCallback>();

        public List<Weapon> weapons;

        public interface IAttackInvokeCallback
        {
            void OnAttackInvoked();
        }
    }
}