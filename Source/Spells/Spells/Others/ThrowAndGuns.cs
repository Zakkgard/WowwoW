using Server;
using Server.Items;
using HelperTools;

namespace Server
{
	public class ThrowAndGuns
	{
		public static void OnCastGun( BaseAbility ba, Mobile c, Mobile target )
		{
			SpellTemplate st = (SpellTemplate)ba;
			Character ch = c as Character;
			Item weap = ch.Items[ (int)Slots.Ranged ];
			if ( weap == null )
				return;
			Item ammo = World.CreateItemInPoolById( ch.AmmoType );
			ch.ConsumeItemByIdUpTo( ch.AmmoType, 1 );
			target.LooseHits( c, (int)( weap.PhysicalMinDamage + ammo.PhysicalMinDamage + Utility.RandomDouble() * ( weap.PhysicalMaxDamage - weap.PhysicalMinDamage ) + Utility.RandomDouble() * ( ammo.PhysicalMaxDamage - ammo.PhysicalMinDamage ) ) );
		}
		
		public static void OnCastThrow( BaseAbility ba, Mobile c, Mobile target )
		{
			SpellTemplate st = (SpellTemplate)ba;
			Character ch = c as Character;
			Item weap = ch.Items[ (int)Slots.Ranged ];
			if ( weap == null )
				return;
			ch.ConsumeItemByIdUpTo( weap.Id, 1 );
			target.LooseHits( c, (int)( weap.PhysicalMinDamage + Utility.RandomDouble() * ( weap.PhysicalMaxDamage - weap.PhysicalMinDamage ) ) );
		}			
	}
}