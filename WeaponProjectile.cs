using System.Collections.Generic;
using UnityEngine;
using Fusion;

// TODO DONE
namespace Deobfuscated
{
    public class WeaponProjectile : MonoBehaviour
    {




        protected virtual void OnDestroy()
        {
            WeaponProjectileFixedUpdateManagerHolder.weaponProjectileFixedUpdateManager.projectilesToUpdate.Remove(this);
            //CEJFCCPGBFO.EFEACIJPBKP.Remove(base.gameObject);
            NetworkWeaponMapping.NetworkObjectToProjectileMap.Remove(base.gameObject.GetComponent<NetworkObject>());
        }


        private void RegisterKillListener(WeaponProjectile.IKillListener newKillListener)
        {
            this.killListeners.Add(newKillListener);
        }

        internal GameObject RelatedGameObject
        {
            get
            {
                return this.projectileGameObject;
            }
            set
            {
                if (value != this.projectileGameObject)
                {
                    if (value != null)
                    {
                        this.physicCharacterController = value.GetComponent<PhysicCharacterController>();
                        this.RegisterAttackListener(this.physicCharacterController);
                        this.RegisterKillListener(this.physicCharacterController);
                    }
                    this.projectileGameObject = value;
                }
            }
        }




        internal virtual void ActivatePin()
        {
        }


        private void RegisterAttackListener(WeaponProjectile.IAttackListener newAttackListener)
        {
            this.attackListeners.Add(newAttackListener);
        }



        // REAL
        internal virtual void UpdateProjectilePhysics()
        {
        }

        protected virtual void Awake()
        {
            this.originalLayer = base.gameObject.layer;
            if (WeaponProjectileFixedUpdateManagerHolder.weaponProjectileFixedUpdateManager == null)
            {
                WeaponProjectileFixedUpdateManagerHolder.weaponProjectileFixedUpdateManager = new GameObject
                {
                    name = "WeaponProjectileManagerObject"
                }.AddComponent<WeaponProjectileFixedUpdateManager>();
            }
            WeaponProjectileFixedUpdateManagerHolder.weaponProjectileFixedUpdateManager.projectilesToUpdate.Add(this);
            //CEJFCCPGBFO.EFEACIJPBKP.Add(base.gameObject, this);
            NetworkWeaponMapping.NetworkObjectToProjectileMap.Add(base.gameObject.GetComponent<NetworkObject>(), this);
        }







        protected void NotifyKillListeners(PhysicCharacterController physicCharacterController)
        {
            foreach (WeaponProjectile.IKillListener killListener in this.killListeners)
            {
                killListener.OnKillSomeone(physicCharacterController);
            }
        }




        protected void NotifyAttackListeners(PhysicCharacterController physicCharacterController)
        {
            foreach (WeaponProjectile.IAttackListener attackListener in this.attackListeners)
            {
                attackListener.OnAttackingSomeone(physicCharacterController);
            }
        }

        private readonly HashSet<WeaponProjectile.IAttackListener> attackListeners = new HashSet<WeaponProjectile.IAttackListener>();

        private GameObject projectileGameObject;

        protected PhysicCharacterController physicCharacterController;

        public Rigidbody ShelfRigidbody;

        public Transform ShelfTransform;

        protected readonly WaitForFixedUpdate waitForFixedUpdate = new WaitForFixedUpdate();

        protected int originalLayer;

        private readonly HashSet<WeaponProjectile.IKillListener> killListeners = new HashSet<WeaponProjectile.IKillListener>();

        internal interface IAttackListener
        {
            void OnAttackingSomeone(PhysicCharacterController physicCharacterController);
        }

        internal interface IKillListener
        {
            void OnKillSomeone(PhysicCharacterController physicCharacterController);
        }
    }
}