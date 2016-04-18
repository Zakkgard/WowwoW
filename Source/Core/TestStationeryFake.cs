namespace Server.Items
{
    public class TestStationeryFake : Item
    {
        public TestStationeryFake() 
            : base()
        {
            this.BuyPrice = 10;
            this.SubClass = 0;
            this.Material = -1;
            this.Stackable = 10;
            this.Model = 1069;
            this.ObjectClass = 0;
            this.Name = "Test Stationery";
            this.AvailableClasses = 0x07FFF;
            this.Quality = 1;
            this.SellPrice = 2;
            this.AvailableRaces = 0x01FF;
            this.Id = 8164;
        }
    }
}
