namespace Server
{
    public class Member
    {
        public Member(Character character)
        {
            this.Character = character;
            this.Droits = 0x1;
        }

        public Character Character { get; set; }

        public ushort Droits { get; set; }
    }
}
