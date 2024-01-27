using System.Collections.Generic;
using UnityEngine;

// TODO DONE
namespace Deobfuscated
{
    public class ElectricStates : MonoBehaviour
    {
        private void Awake()
        {
            ElectricStatesManager.RegisterElectricState(base.gameObject, this);
            if (ElectricStatesManager.ElectricStatesControllerInstance == null)
            {
                ElectricStatesManager.ElectricStatesControllerInstance = new GameObject
                {
                    name = "ElectriStatesControllerGo"
                }.AddComponent<ElectricStatesController>();
            }
        }


        private bool isElectrified
        {
            get
            {
                return this.isElectrifiedInternal;
            }
            set
            {
                if (this.isElectrifiedInternal != value)
                {
                    this.isElectrifiedInternal = value;
                    this.IsElectrified = value;
                    foreach (ElectricStates.IIsElectrifiedChangeCallbacks isElectrifiedChangeCallbacks in this.electrifiedChangeCallbacks)
                    {
                        isElectrifiedChangeCallbacks.OnIsElectrifiedChanged(value);
                    }
                }
            }
        }

        protected virtual void OnCollisionEnter(Collision collision)
        {
            if (ElectricStatesManager.gameObjectToElectricStateMap.ContainsKey(collision.gameObject))
            {
                this.adjacentElectricStates.Add(ElectricStatesManager.gameObjectToElectricStateMap[collision.gameObject]);
            }
        }


        public void RemoveIsElectrifiedChangeCallback(ElectricStates.IIsElectrifiedChangeCallbacks callback)
        {
            this.electrifiedChangeCallbacks.Remove(callback);
        }

        public int ElectricUnitCount
        {
            get
            {
                return this.electricUnitCount;
            }
            set
            {
                if (this.electricUnitCount != value)
                {
                    this.electricUnitCount = value;
                    foreach (ElectricStates.IElectricUnitCountCallbacks electricUnitCountCallbacks in this.electricUnitCountCallbacks)
                    {
                        electricUnitCountCallbacks.OnElectricUnitCountChanged(value);
                    }
                    if (value > 0)
                    {
                        this.isElectrified = true;
                        return;
                    }
                    this.isElectrified = false;
                }
            }
        }

        protected virtual void OnCollisionExit(Collision collision)
        {
            if (ElectricStatesManager.gameObjectToElectricStateMap.ContainsKey(collision.gameObject))
            {
                this.adjacentElectricStates.Remove(ElectricStatesManager.gameObjectToElectricStateMap[collision.gameObject]);
            }
        }


        public void RemoveElectricUnitCountCallback(ElectricStates.IElectricUnitCountCallbacks callback)
        {
            this.electricUnitCountCallbacks.Remove(callback);
        }

        public void AddElectricUnitCountCallback(ElectricStates.IElectricUnitCountCallbacks callback)
        {
            this.electricUnitCountCallbacks.Add(callback);
        }

        internal void UpdateElectricState()
        {
            if (!this.isConductive)
            {
                this.ElectricUnitCount = 0;
                return;
            }
            int count = this.receivedElectricUnits.Count;
            if (count > 0)
            {
                this.ElectricUnitCount = count;
                this.receivedElectricUnits.Clear();
                return;
            }
            this.ElectricUnitCount = 0;
        }

        private void OnDestroy()
        {
            ElectricStatesManager.UnregisterElectricState(base.gameObject);
        }


        public virtual void ConductElectricity(ElectricUnit electricUnit)
        {
            if (!this.isConductive || this.receivedElectricUnits.Contains(electricUnit))
            {
                return;
            }
            this.receivedElectricUnits.Add(electricUnit);
            foreach (ElectricStates electricStates in this.adjacentElectricStates)
            {
                electricStates.ConductElectricity(electricUnit);
            }
            foreach (ElectricStates electricStates2 in this.connectedElectriStates)
            {
                electricStates2.ConductElectricity(electricUnit);
            }
        }


        public void AddIsElectrifiedChangeCallback(ElectricStates.IIsElectrifiedChangeCallbacks callback)
        {
            this.electrifiedChangeCallbacks.Add(callback);
        }

        public bool isConductive = true;

        public List<ElectricStates> connectedElectriStates = new List<ElectricStates>();

        protected bool isElectrifiedInternal;

        public bool IsElectrified;

        private HashSet<ElectricStates.IIsElectrifiedChangeCallbacks> electrifiedChangeCallbacks = new HashSet<ElectricStates.IIsElectrifiedChangeCallbacks>();

        protected readonly HashSet<ElectricStates> adjacentElectricStates = new HashSet<ElectricStates>();

        protected HashSet<ElectricUnit> receivedElectricUnits = new HashSet<ElectricUnit>();

        private int electricUnitCount;

        private HashSet<ElectricStates.IElectricUnitCountCallbacks> electricUnitCountCallbacks = new HashSet<ElectricStates.IElectricUnitCountCallbacks>();

        public interface IIsElectrifiedChangeCallbacks
        {
            void OnIsElectrifiedChanged(bool isElectrified);
        }

        public interface IElectricUnitCountCallbacks
        {
            void OnElectricUnitCountChanged(int unitCount);
        }
    }
}