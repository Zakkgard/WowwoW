using Server;
using HelperTools;

namespace Server
{
	public class Potions
	{
		public static void OnUseManaPotion( BaseAbility ba, Mobile c )
		{
			SpellTemplate st = (SpellTemplate)ba;
			int mana = Utility.Random( st.S1, st.S1 + st.Bonus1 );
			c.GainMana(c,mana);		
		}
		public static void OnUseHealthPotion( BaseAbility ba, Mobile c )
		{
			SpellTemplate st = (SpellTemplate)ba;
			int hp = Utility.Random( st.S1, st.S1 + st.Bonus1 );
			c.GainHealth(c,hp);
		}
		public static void OnUseRejuvenationPotion( BaseAbility ba, Mobile c )
		{
			SpellTemplate st = (SpellTemplate)ba;
			int mana = Utility.Random( st.S1, st.S1 + st.Bonus1 );
			c.GainMana(c,mana);	
			int hp = Utility.Random( st.S2, st.S2 + st.Bonus2 );
			c.GainHealth(c,hp);
		}
		public static void OnUseStoneshieldPotion(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.ArmorBonus = st.S1;
			c.AddAura( st, aura );						
		}
		public static void OnUseMagicResistancePotion(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.ShadowResistanceBonus = st.S1;
			aura.ArcaneResistanceBonus = st.S1;
			aura.FrostResistanceBonus = st.S1;
			aura.FireResistanceBonus = st.S1;
			aura.HolyResistanceBonus = st.S1;
			aura.NatureResistanceBonus = st.S1;
			c.AddAura(st, aura);						
		}
		public static void OnUseFireProtectionPotion(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.FireAbsorb=Utility.Random(st.S1, st.S1 + st.Bonus1);
			c.AddAura(st, aura);						
		}
		public static void OnUseTrollBloodPotion(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			HotAura aura = new HotAura(st,c,c,(st.S1+1), st.Duration( c ) , 5000);
			c.AddAura(st, aura);						
		}
		public static void OnUseDreamlessSleepPotion(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			HotAura aura1 = new HotAura(st,c,c,(st.S1+1), st.Duration( c ) , 5000);
			MotAura aura2 = new MotAura(st,c,c,(st.S1+1), st.Duration( c ) , 5000);
			Aura aura = new Aura();
			aura.ForceStun = true;
			c.AddAura(st, aura);
			c.AddAura(st, aura2);
			c.AddAura(st, aura1);
		}
		public static void OnUseFrostProtectionPotion(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.FrostAbsorb=Utility.Random(st.S1, st.S1 + st.Bonus1);
			c.AddAura(st, aura);						
		}
		public static void OnUseArcaneProtectionPotion(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.ArcaneAbsorb=Utility.Random(st.S1, st.S1 + st.Bonus1);
			c.AddAura(st, aura);						
		}
		public static void OnUseNatureProtectionPotion(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.NatureAbsorb=Utility.Random(st.S1, st.S1 + st.Bonus1);
			c.AddAura(st, aura);						
		}
		public static void OnUseShadowProtectionPotion(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.ShadowAbsorb=Utility.Random(st.S1, st.S1 + st.Bonus1);
			c.AddAura(st, aura);						
		}
		public static void OnUseInvisibilityPotion( BaseAbility ba, Mobile c )
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.OnRelease = new Aura.AuraReleaseDelegate( OnUseInvisibilityPotionEnded );
			c.Visible = InvisibilityLevel.Lesser;
			c.AddAura( st, aura );
		}
		public static void OnUseInvisibilityPotionEnded( Mobile c )
		{
			c.Visible = InvisibilityLevel.Visible;
		}

	}
}