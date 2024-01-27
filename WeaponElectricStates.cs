// TODO DONE
namespace Deobfuscated
{
    public class WeaponElectricStates : ElectricStates
    {



        private void Start()
        {
            this.associatedWeapon = GameObjectToWeaponMapper.gameObjectToWeaponMap[base.gameObject];
        }




        public override void ConductElectricity(ElectricUnit electricUnit)
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
            if (this.associatedWeapon.Owner != null)
            {
                PccManager.gameObjectToCharacterControllerMap[this.associatedWeapon.Owner].IPLKGBDHFPP[0].ConductElectricity(electricUnit);
            }
        }


        private Weapon associatedWeapon;
    }
}