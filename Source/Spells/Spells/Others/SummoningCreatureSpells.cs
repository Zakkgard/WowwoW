using Server;
using HelperTools;
using System.Collections;
using System.Reflection;

namespace Server
{
	public class SummoningCreatureSpells
	{
		#region Imp 
		public static void OnCastFireBolt(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// 100% working 
			SpellTemplate st = (SpellTemplate)ba; 
			st.MakeDamage(c, target, SpellDamage.TypeS1); 
		} 
  
		public static void OnCastBloodPact(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			AuraEffect af = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			aura.StaminaBonus = af.S1; 
			target.AddAura(af, aura); 
			if ( target.SummonedBy != null )
			{
				aura = new Aura(); 
				aura.StaminaBonus = af.S1; 
				target.SummonedBy.AddAura( af, aura ); 
			}
		} 

		public static void OnCastFireShield(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// not tested 
			AuraEffect st = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			aura.OnMeleeHit = 1;//   id of the trigger 
			c.Triggers[ 1 ] = new Mobile.OnMeleeHitTrigger( OnFireShieldHit ); 
			c.AddAura( st, aura );                   
		} 
		public static void OnFireShieldHit( Mobile m, Mobile target, AuraEffect ae ) 
		{          
			(ae as SpellTemplate).MakeDamage(m,target,SpellDamage.TypeS1); 
		} 

		public static void OnCastPhaseShift(BaseAbility ba, Mobile c, Mobile target) 
		{ 
			// mob get unatackable until he attack 
		} 
		#endregion 

		#region Voidwalker 
		public static void OnCastTorment(BaseAbility ba, Mobile c, Mobile target) 
		{ 
			// threat 
		} 

		public static void OnCastSuffering(BaseAbility ba, Mobile c, Mobile target) 
		{ 
			// threat 
		} 

		public static void OnCastConsumeShadows(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// not tested 
			AuraEffect af = (AuraEffect)ba; 
			HotAura aura = new HotAura(af,c,c,af.S1, af.Duration( c ) , af.T2); 
			target.AddAura(af,aura); 
		} 

		public static void OnCastSacrifice(BaseAbility ba, Mobile c, Mobile target) 
		{ 
			AuraEffect af = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			} 
		#endregion 

		#region Succubus 
		public static void OnCastLashOfPain(BaseAbility ba, Mobile c, Mobile target) 
		{ 
		} 

		public static void OnCastSeduction(BaseAbility ba, Mobile c, Mobile target) 
		{ 
		} 

		public static void OnCastSoothingKiss(BaseAbility ba, Mobile c, Mobile target) 
		{ 
		} 

		public static void OnCastLesserInvisibility(BaseAbility ba, Mobile c, Mobile target) 
		{ 
		} 
		#endregion 

		#region FellHunter 
		public static void OnCastParanoia(BaseAbility ba, Mobile c, Mobile target) 
		{ 
		} 

		public static void OnCastTaintedBlood(BaseAbility ba, Mobile c, Mobile target) 
		{ 
		} 

		public static void OnCastDevourMagic(BaseAbility ba, Mobile c, Mobile target) 
		{ 
		} 

		public static void OnCastSpellLock(BaseAbility ba, Mobile c, Mobile target) 
		{ 
		} 
		#endregion 

	}
}

