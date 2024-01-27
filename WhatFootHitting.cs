using UnityEngine;

namespace Deobfuscated
{
    internal class WhatFootHitting : MonoBehaviour
    {
        private Rigidbody _theHitGameobject;

        public Vector3 TheHitPos;

        private Transform _parentTransform;

        private RaycastHit[] _raycastHitResults = new RaycastHit[4];


        public Rigidbody TheHitGameobject
        {
            get
            {
                this.FindHitGameobject();
                return this._theHitGameobject;
            }
        }

        private void Awake()
        {
            this._parentTransform = base.transform.parent;
        }

        private void FindHitGameobject()
        {
            int num = Physics.SphereCastNonAlloc(base.transform.position + base.transform.forward * 0.081f, 0.09f, -base.transform.forward, this._raycastHitResults, 0.09f);
            if (num == 0)
            {
                this._theHitGameobject = null;
            }
            for (int i = 0; i < num; i++)
            {
                Rigidbody rigidbody = this._raycastHitResults[i].rigidbody;
                if (rigidbody != null)
                {
                    Transform parent = rigidbody.gameObject.transform.parent;
                    if (!(parent != null))
                    {
                        this._theHitGameobject = rigidbody;
                        this.TheHitPos = this._raycastHitResults[i].point;
                        return;
                    }
                    if (parent != this._parentTransform)
                    {
                        this._theHitGameobject = rigidbody;
                        this.TheHitPos = this._raycastHitResults[i].point;
                        return;
                    }
                    this._theHitGameobject = null;
                }
                else
                {
                    this._theHitGameobject = null;
                }
            }
        }
    }
}