namespace Server.Items
{
    public class BlizzardStationeryFake : Item
    {
        public BlizzardStationeryFake() 
            : base()
        {
            this.AvailableRaces = 0x07FFF;
            this.SubClass = 0;
            this.Material = -1;
            this.PageMaterial = 1;
            this.Stackable = 1;
            this.Model = 30658;
            this.ObjectClass = 0;
            this.Name = "Blizzard Stationery";
            this.AvailableClasses = 0x07FFF;
            this.Quality = 1;
            this.Id = 18154;
        }
    }
}
