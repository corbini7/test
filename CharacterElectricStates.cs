// TODO DONE
namespace Deobfuscated
{
    public class CharacterElectricStates : ElectricStates
    {



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
            foreach (CharacterElectricStates characterElectricStates in this.physicCharacterController.IPLKGBDHFPP)
            {
                characterElectricStates.ConductElectricity(electricUnit);
            }
        }


        internal PhysicCharacterController physicCharacterController;
    }
}