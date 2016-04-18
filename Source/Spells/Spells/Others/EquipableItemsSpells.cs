using System;
using System.Collections;
using Server.Items;

namespace Server
{
	public class EquipableItemsSpells
	{
		public static void OnSpellStoneCriticalIncrease( BaseAbility ba, Mobile m, Item.SpecialAbility sa, Item it )
		{
			AuraEffect st = ( AuraEffect )ba; 
			Aura aura = sa.ActiveAura;
			if ( aura == null )
			{
				aura = new ItemAura( it ); 
				aura.MagicalCriticalBonus = 1; 
				sa.ActiveAura = aura;
			}
			m.AddAura( st, aura ); 
		}

		public static void OnSpellNaturePoison( BaseAbility ba, Mobile m, Mobile target, Item.SpecialAbility sa, Item it )
		{
			AuraEffect st = ( AuraEffect )ba; 
			if ( target.AdditionnalStates.Contains( 0xE020392 ) )
				return;//	Already poisonned
			target.AdditionnalStates.Add( 0xE020392 );
			st.ApplyDot( m, target, st.S1, st.T1, st.Duration( m ) );
		}
	}

	
}