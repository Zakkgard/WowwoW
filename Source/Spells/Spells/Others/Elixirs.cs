using Server;
using HelperTools;

namespace Server
{
	public class Elixirs
	{
		public static void OnUseElixirOfAgility( BaseAbility ba, Mobile c )
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.AgBonus = st.S1;
			c.AddAura( st, aura );			
		}
		public static void OnUseElixirOfDefense( BaseAbility ba, Mobile c )
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.ArmorBonus = st.S1;
			c.AddAura( st, aura );			
		}
		public static void OnUseElixirOfBruteForce( BaseAbility ba, Mobile c )
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.StaminaBonus = st.S1;
			aura.StrBonus = st.S1;
			c.AddAura( st, aura );			
		}
		
		public static void OnUseElixirOfFortitude( BaseAbility ba, Mobile c )
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.HealthBonus = st.S1;
			c.AddAura( st, aura );			
		}
		public static void OnUseElixirOfStrenght( BaseAbility ba, Mobile c )
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.StrBonus = st.S1;
			c.AddAura( st, aura );			
		}
		public static void OnUseElixirOfIQ( BaseAbility ba, Mobile c )
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.IQBonus = st.S1;
			c.AddAura( st, aura );			
		}
		public static void OnUseElixirOfSages( BaseAbility ba, Mobile c )
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.SpiritBonus = st.S1;
			aura.IQBonus = st.S1;
			c.AddAura( st, aura );			
		}

		
	}
}
			