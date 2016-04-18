using System;
using Server.Items;
using HelperTools;


namespace Server.Creatures
{
	public class RellianGreenspyre : BaseNPC
	{
		public RellianGreenspyre() : base()
		{
			Name = "Rellian Greenspyre";
			Id = 3517;
			Model = 5071;
			Level = RandomLevel(17);
			SetDamage(1f+1.8f*Level,1f+2.5*Level);			
			AttackSpeed = 1500;
			Armor = 4526;
			Block = 0;
			ResistArcane = 0;
			ResistFire = 0;
			ResistFrost = 0;
			ResistHoly = 0;
			ResistNature = 0;
			Flags1=0x08480046;
			BaseMana = 0;
			BoundingRadius = 0.3f;
			CombatReach = 1.5f;
			Size = 1.0f;
			Speed = 3f;
			WalkSpeed = 3f;
			RunSpeed = 69f;
			Str = (int)(Level/2.5f);
			Faction = Factions.Darnasus;
			AIEngine = new TravellerSalesmanAI( this );
			NpcType = 7;
			NpcFlags = (int)NpcActions.Dialog ;
			//Item( int _model, InventoryTypes _inventoryType, int _quality, int _subclass, int _objectclass, int _sheath, int param1, int param2, int param3 ) 
			Equip( new Item( 6537, InventoryTypes.HeldInHand, 4, 0, 1, 7, 0, 0, 0 ) ); 
			Loots = new BaseTreasure[]{  new BaseTreasure(Drops.MoneyA , 100f )};
			/*****************************/
			BCAddon.Hp( this, 253, 17 );
			/*****************************/
		}
	}
}
