namespace Server.Items
{
    public class ItemDamage
    {
        public ItemDamage()
        {
        }

        public ItemDamage(float min, float max)
        {
            this.MinDamage = min;
            this.MaxDamage = max;
        }

        public float MinDamage { get; set; }

        public float MaxDamage { get; set; }
    }
}
