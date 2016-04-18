namespace Server.Items
{
    public class DefaultStationeryFake : Item
    {
        public DefaultStationeryFake() 
            : base()
        {
            this.AvailableRaces = 0x01FF;
            this.SubClass = 0;
            this.Material = -1;
            this.PageMaterial = 1;
            this.Stackable = 1;
            this.Model = 7798;
            this.ObjectClass = 0;
            this.Name = "Default Stationery";
            this.AvailableClasses = 0x07FFF;
            this.Quality = 1;
            this.Id = 9311;
        }
    }
}
