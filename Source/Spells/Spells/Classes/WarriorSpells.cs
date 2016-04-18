using Server; 
using HelperTools; 
using System.Collections; 

namespace Server 
{ 
	public class WarriorSpells 
	{ 
		public static bool InBehindOf(Mobile ch, Mobile target, double maxDifference)
		{
			double angle = System.Math.Atan2( ch.Y - target.Y, ch.X - target.X);	
			System.Console.WriteLine(angle);
			if ( angle > -System.Math.PI && angle < -System.Math.PI/2) // III
			{
				angle += System.Math.PI*2;
			}
			if ( angle > -System.Math.PI/2 && angle < 0.0) // IV
			{
				angle += System.Math.PI*2;
			}
			System.Console.WriteLine(ch.Orientation);
			if ( (ch.Orientation+maxDifference/2) >= angle && (ch.Orientation-maxDifference/2) <= angle)
			{
				return true;
			}
			return false;
		}


		#region aditional states
		public class IsSundered 
		{ 
			public IsSundered(Mobile _caster,Aura _aura) 
			{ 
				caster = _caster; 
				aura = _aura;
				times = 1;
			} 
			public Mobile caster; 
			public Aura aura; 
			public int times;
		} 
		#endregion

		#region auras 
		public class FearAura : Aura 
		{ 
			public FearAura() 
			{ 
			} 
			public override float SpeedModifier 
			{ 
				get 
				{ 
					return this.speedModifier; 
				} 
				set 
				{ 
					this.speedModifier = value; 
				} 

			} 
			public override bool ForceFlee 
			{ 
				get 
				{ 
					return this.forceFlee; 
				} 
				set 
				{ 
					this.forceFlee = value; 
				} 

			} 
			public AuraEffect Effect 
			{ 
				get 
				{ 
					return this.auraEffect; 
				} 
				set 
				{ 
					this.auraEffect = value; 
				} 
			} 
          

			// Fields 
			private float speedModifier; 
			private bool forceFlee; 
			private AuraEffect auraEffect; 
          
		} 

		public class RecklessnessAura : Aura 
		{ 
			public RecklessnessAura() 
			{ 
			} 
			public override int PhysicalCriticalBonus 
			{ 
				get 
				{ 
					return this.physicalCriticalBonus; 
				} 
				set 
				{ 
					this.physicalCriticalBonus = value; 
				} 
			} 
			public override bool ImmuneToFear 
			{ 
				get 
				{ 
					return this.immuneToFear; 
				} 
				set 
				{ 
					this.immuneToFear = value; 
				} 
			} 
          
			public override float DamageTakenModifier
			{
				get 
				{ 
					return this.damageTakenModifier; 
				} 
				set 
				{ 
					this.damageTakenModifier = value; 
				} 
			}
			public AuraEffect Effect 
			{ 
				get 
				{ 
					return this.auraEffect; 
				} 
				set 
				{ 
					this.auraEffect = value; 
				} 
			} 
          

			// Fields 
			private int physicalCriticalBonus; 
			private bool immuneToFear; 
			private AuraEffect auraEffect;
			private float damageTakenModifier;
          
		} 
		public class ShieldBlockAura : Aura 
		{ 
			public ShieldBlockAura() 
			{ 
			} 
			public override int BlockBonus 
			{ 
				get 
				{ 
					return this.blockBonus; 
				} 
				set 
				{ 
					this.blockBonus = value; 
				} 

			} 
			public override int OnMeleeHit 
			{ 
				get 
				{ 
					return this.onMeleeHit; 
				} 
				set 
				{ 
					this.onMeleeHit = value; 
				} 

			} 
			public AuraEffect Effect 
			{ 
				get 
				{ 
					return this.auraEffect; 
				} 
				set 
				{ 
					this.auraEffect = value; 
				} 
			} 
          

			// Fields 
			private int blockBonus; 
			private int onMeleeHit; 
			private AuraEffect auraEffect; 
          
		} 
		public class BerserkersRageAura : Aura 
		{ 
			public BerserkersRageAura() 
			{ 
			} 
			public override bool ImmuneToFear 
			{ 
				get 
				{ 
					return this.immuneToFear; 
				} 
				set 
				{ 
					this.immuneToFear = value; 
				} 

			} 
			public override float RageGenerationModifier
			{
				get 
				{ 
					return this.rageGenerationModifier; 
				} 
				set 
				{ 
					this.rageGenerationModifier = value; 
				} 
			}
			public override bool ImmuneToKnockBack 
			{ 
				get 
				{ 
					return this.immuneToKnockBack; 
				} 
				set 
				{ 
					this.immuneToKnockBack = value; 
				} 

			} 
			public AuraEffect Effect 
			{ 
				get 
				{ 
					return this.auraEffect; 
				} 
				set 
				{ 
					this.auraEffect = value; 
				} 
			} 
          

			// Fields 
			private bool immuneToFear; 
			private float rageGenerationModifier;
			private bool immuneToKnockBack; 
			private AuraEffect auraEffect; 

          
		} 
		public class DeathWishAura : Aura 
		{ 
			public DeathWishAura() 
			{ 
			} 
			public override float PhysicalPercentDamageIncrease
			{ 
				get 
				{ 
					return this.physicalPercentDamageIncrease; 
				} 
				set 
				{ 
					this.physicalPercentDamageIncrease = value; 
				} 
			} 
			public override float AllResistancePercentMalus
			{ 
				get 
				{ 
					return this.allResistancePercentMalus; 
				} 
				set 
				{ 
					this.allResistancePercentMalus = value; 
				} 
			}
			public override float ArmorPercentMalus
			{ 
				get 
				{ 
					return this.armorPercentMalus; 
				} 
				set 
				{ 
					this.armorPercentMalus = value; 
				} 
			}
			public override bool ImmuneToFear 
			{ 
				get 
				{ 
					return this.immuneToFear; 
				} 
				set 
				{ 
					this.immuneToFear = value; 
				} 
			} 

          
          
			public AuraEffect Effect 
			{ 
				get 
				{ 
					return this.auraEffect; 
				} 
				set 
				{ 
					this.auraEffect = value; 
				} 
			} 
          

			// Fields 
			
			private bool immuneToFear; 
			private AuraEffect auraEffect; 
			private float physicalPercentDamageIncrease;
			private float armorPercentMalus;
			private float allResistancePercentMalus;     
		} 
		public class BloodRageAura : Aura
		{
			int duration;
			int gain;
			Mobile from;
			Mobile target;
			int frequency;
			SpellTemplate spell;
			bool interuptRegeneration;
			AuraEffect auraEffect;
			public override bool InteruptRegeneration 
			{ 
				get 
				{ 
					return this.interuptRegeneration; 
				} 
				set 
				{ 
					this.interuptRegeneration = value; 
				} 
			} 

			public AuraEffect Effect 
			{ 
				get 
				{ 
					return this.auraEffect; 
				} 
				set 
				{ 
					this.auraEffect = value; 
				} 
			} 
			public BloodRageAura( SpellTemplate st, Mobile c, Mobile t, int d, int dur, int freq )
			{
				if ( t.Dead )
					return;
				spell = st;
				from = c;
				target = t;
				gain = d;
				duration = dur;
				frequency = freq;
				PeriodicAura( new AuraPeriodicEffect( this.PeriodicManaRegen ), dur, freq );
			}

			public void PeriodicManaRegen()
			{
				target.GainMana( from, gain );
			}
		}
		#endregion 
		
		#region 100% done

		#region Arms 
		public static void OnCastMockingBlow(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// Force enemy focus on caster. 
			SpellTemplate st = (SpellTemplate)ba; 
			st.MakeDamage(c, target, SpellDamage.TypeS1); 
			Aura aura = new Aura(); 
			aura.ForceAttackTo = c; 
			target.AddAura(c, st as AuraEffect, aura, true); 
		} 
		public static void OnCastHeroicStrike(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted right
			// need testing 
			int int1 = c.AttackSwing(target);
			if ( int1 > 0 ) 
			{ 
				SpellTemplate st = (SpellTemplate)ba; 
				st.MakeDamage(c, target, SpellDamage.TypeS1); // Hp lost by spell - this is affected by resistance
			}   
		} 

		public static void OnCastRend(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted right
			// need testing 
			SpellTemplate st = (SpellTemplate)ba; 
			int damage = st.S1;
			if(c is Character && c.Level > 9 && c.HaveTalent(Talents.ImprovedRend))
			{
				AuraEffect effect1 = (AuraEffect) c.GetTalentEffect(Talents.ImprovedRend);
				float single1 = 1+((float)effect1.S1)/100;
				damage = (int)(st.S1*single1);
			}
			st.ApplyDot( c, target, damage, st.T1, st.Duration( c ) ); 
		} 

		public static void OnCastThunderClap(BaseAbility ba, Mobile c) // Thanks bovi & DrNexus. 
		{   // 100% scripted 
			// need testing 
			SpellTemplate st = (SpellTemplate)ba; 
			Character ch = c as Character; 
			int num = 0; 

			foreach (Object o in ch.Player.KnownObjects) 
			{ 
				if ((o is Mobile) && !(o is BaseSpawner)) 
				{    
					Mobile around = (Mobile)o; 
					around.UpdateXYZ(); 

					if ((c.Distance(around) < st.Radius1) && (around.Faction != c.Faction)) 
					{ 
						if (num < 5) 
						{ 
							num++; 
							st.MakeDamage(c, around, SpellDamage.TypeS1); 
							Aura aura = new Aura(); 
							aura.AttackSpeedModifier = 1+(float)st.S2/100f; 
							around.AddAura(c,st as AuraEffect, aura, true); 
						} 
					} 
				} 
			} 
		} 

		public static void OnCastOverpower(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			int dmg = c.AttackSwing( target, true ); 
			if ( dmg > 0 ) 
			{ 
				SpellTemplate st = (SpellTemplate)ba; 
				st.MakeDamage(c, target, SpellDamage.TypeS1); 
			} 
		} 
		public static void OnCastHamstring(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// need testing 
			SpellTemplate st = (SpellTemplate)ba; 
			st.MakeDamage(c, target, SpellDamage.TypeS2);
			Aura aura = new Aura(); 
			float DecraseSpeedMod = (float)st.S2/100f;
			if(c is Character && c.Level > 9 && c.HaveTalent(Talents.ImprovedHamstring))
			{
				AuraEffect effect1 = (AuraEffect) c.GetTalentEffect(Talents.ImprovedHamstring);
				int roll = Utility.Random( 100 );
				if(roll < effect1.H)
				{
					AuraEffect auraEf = (AuraEffect)Abilities.abilities[effect1.AdditionalSpell];
					Aura aura2 = new Aura();
					aura2.ForceStun = true;
					target.AddAura(c,auraEf,aura,true);
				}
			}
			aura.SpeedModifier = 1 - DecraseSpeedMod;
			target.AddAura(c,st as AuraEffect, aura, true); 
			target.ChangeRunSpeed( target.RunSpeed);
		} 
		public static void OnCastCharge(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			if (c.Running == false) c.Running = true;
			target.UpdateXYZ();
			c.RunSpeed *=2;
			target.ChangeRunSpeed( target.RunSpeed);
			c.MoveTo(target.X,target.Y,target.Z);
			c.RunSpeed /=2;
			target.ChangeRunSpeed( target.RunSpeed);
			SpellTemplate af = (SpellTemplate)ba; 
			int manaPlus = af.S2;
			if(c is Character && c.Level > 9 && c.HaveTalent(Talents.ImprovedCharge))
			{
				AuraEffect effect1 = (AuraEffect) c.GetTalentEffect(Talents.ImprovedCharge);
				manaPlus += effect1.S1;
			}
			c.GainMana(c,manaPlus); 
			Aura aura = new Aura(); 
			aura.ForceStun = true; 
			target.AddAura(c,(AuraEffect)Abilities.abilities[7922],aura,true); 
		} 
		public static void OnCastRetaliation(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			         
			AuraEffect st = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			aura.OnMeleeHit = 50005;//   id of the trigger 
			c.Triggers[ 50005 ] = new Mobile.OnMeleeHitTrigger( OnRetaliationHit ); 
			c.AddAura( st, aura );                   
		} 
		public static void OnRetaliationHit( Mobile m, Mobile target, AuraEffect ae ) 
		{   
			if (!InBehindOf(m,target,3f))
			{
				int dmg = m.AttackSwing( target ); 
				if ( dmg > 0 ) 
				{ 
					SpellTemplate st = (SpellTemplate)ae; 
					st.MakeDamage(m, target, SpellDamage.TypeS1); 
				} 
			}
		} 
		#endregion

		#region Fury 
		public static void OnCastPummel(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// need testing 
			SpellTemplate st = (SpellTemplate)ba; 
			st.MakeDamage(c, target, SpellDamage.TypeS1); 
			int id = st.InterruptCasting(c,target);
			if(id !=0)
			{
				AuraEffect af = (AuraEffect)ba; 
				Aura aura = new Aura(); 
				aura.AvoidCastMagicClass = AbilityClasses.abilityClasses[ id ]; 
				target.AddAura(c,af,aura,true); 
			}
		} 
		public static void OnCastChallengingShout(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// need focus aura 
			AuraEffect af = (AuraEffect)ba; 
			Character ch = c as Character; 

			foreach (Object o in ch.Player.KnownObjects) 
			{ 
				if ((o is Mobile) && !(o is BaseSpawner)) 
				{ 
					Mobile around = (Mobile)o; 
					around.UpdateXYZ(); 

					if ((c.Distance(around) < af.Radius1) && (around.Faction != c.Faction)) 
					{ 
						Aura aura = new Aura(); 
						aura.ForceAttackTo = c; 
						around.AddAura(c,af, aura, true); 
					} 
				} 
			} 
		} 
		
		public static void OnCastBerserkersRage(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// Generate more rage. 
			AuraEffect af = (AuraEffect)ba; 
			BerserkersRageAura aura = new BerserkersRageAura(); 
			aura.ImmuneToFear = true;
			aura.RageGenerationModifier = 1.5f;
			aura.ImmuneToKnockBack = true; 
			c.AddAura(af,aura); 
			if ( c.HaveTalent( Talents.ImprovedBerserkerRage ) )
				{
					AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedBerserkerRage );
					if (ae.Id == 20500) c.GainMana(c,5);
					if (ae.Id == 20501) c.GainMana(c,10);
				}

		} 
		public static void OnCastBattleShout(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// not tested 
			AuraEffect af = (AuraEffect)ba;
			if (c is Character)
			{
			Character ch = c as Character; 
			int bonus = af.S1;
			float modif =  1f;
			
			if(c.Level > 9 && c.HaveTalent(Talents.ImprovedBattleShout))
			{
				AuraEffect effect1 = (AuraEffect) c.GetTalentEffect(Talents.ImprovedBattleShout);
				float single1 = 1+((float)effect1.S1)/100;
				bonus = (int)(af.S1*single1);
			}
			if(c.Level > 9 && c.HaveTalent(Talents.BoomingVoice))
			{
				AuraEffect effect1 = (AuraEffect) c.GetTalentEffect(Talents.BoomingVoice);
				modif = 1+((float)effect1.S1)/100;
			}
			foreach (Character obj1 in ch.GroupMembers.Members) 
			{ 
				if (ch.Distance(obj1) < af.Radius1*modif)  
				{ 
					Aura aura = new Aura(); 
					aura.AttackPowerBonus = (int)(bonus*modif); 
					obj1.AddAura(af,aura); 
				} 
			} 
			}
			else 
				foreach (Object o in (c as Character).Player.KnownObjects) 
				{ 
					if ((o is Mobile) && !(o is BaseSpawner)) 
					{ 
						Mobile around = (Mobile)o; 
						around.UpdateXYZ(); 

						if ((c.Distance(around) < af.Radius1) && (around.Faction == c.Faction)) 
						{ 
							Aura aura = new Aura(); 
							aura.AttackPowerBonus = af.S1; 
							around.AddAura(c,af, aura, true); 
						} 
					} 
				} 

			Aura aura1 = new Aura(); 
			aura1.AttackPowerBonus = af.S1; 
			c.AddAura(af,aura1); 
		} 
		public static void OnCastDemoralizingShout(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// need testing 
			AuraEffect st = (AuraEffect)ba; 
			Character ch = c as Character; 
			int reduction = st.S1;
			float modif = 1f;
			if(c.Level > 9 && c.HaveTalent(Talents.ImprovedDemoralizingShout))
			{
				AuraEffect effect1 = (AuraEffect) c.GetTalentEffect(Talents.ImprovedDemoralizingShout);
				float single1 = 1+((float)effect1.S1)/100;
				reduction = (int)(st.S1*single1);
			}
			if(c.Level > 9 && c.HaveTalent(Talents.BoomingVoice))
			{
				AuraEffect effect1 = (AuraEffect) c.GetTalentEffect(Talents.BoomingVoice);
				modif = 1+((float)effect1.S1)/100;
			}
			foreach (Object o in ch.Player.KnownObjects) 
			{ 
				if ((o is Mobile) && !(o is BaseSpawner)) 
				{ 
					Mobile around = (Mobile)o; 
					around.UpdateXYZ(); 
					c.UpdateXYZ(); 

					if ((c.Distance(around) < st.Radius1*modif) && (around.Faction != c.Faction)) 
					{ 
						Aura aura = new Aura(); 
						aura.AttackPowerMalus = (int)(reduction*modif); 
						around.AddAura(c,st,aura,true); 
					} 
				} 
			} 
		} 
		public static void OnCastCleave(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// need testing 
			SpellTemplate st = (SpellTemplate)ba; 
			Character ch = c as Character;
			int damage = st.S1;
			if(c is Character && c.Level > 9 && c.HaveTalent(Talents.ImprovedCleave))
			{
				AuraEffect effect1 = (AuraEffect) c.GetTalentEffect(Talents.ImprovedCleave);
				float single1 = 1+((float)effect1.S1)/100;
				damage = (int)(st.S1*single1);
			}
			foreach (Object o in ch.Player.KnownObjects) 
			{ 
				if ((o is Mobile) && !(o is BaseSpawner)) 
				{ 
					Mobile around = (Mobile)o; 
					around.UpdateXYZ(); 
					target.UpdateXYZ(); 

					if ((target.Distance(around) < st.Radius1) && (around.Faction != c.Faction) && (target.Faction == around.Faction) && (target!= around) ) 
					{ 
						int int1 = c.AttackSwing(around);
						if ( int1 > 0 ) 
						{ 
							st.MakeDamage(c, around, damage); // Hp lost by spell - this is affected by resistance
						}   
					} 
				} 
			} 
			int int2 = c.AttackSwing(target);
			if ( int2 > 0 ) 
			{ 
				st.MakeDamage(c, target, SpellDamage.TypeS1); // Hp lost by spell - this is affected by resistance
			}   
		} 

		public static void OnCastExecute(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// need testing 
			SpellTemplate st = (SpellTemplate)ba; 
			if (target.HitPoints/target.BaseHitPoints < 0.2) 
			{    
				st.MakeDamage(c,target,SpellDamage.TypeS1); 
				if (target.HitPoints/10 < c.Mana) 
				{ 
					c.LooseMana(target,target.HitPoints/10); 
					st.MakeDamage(c,target,target.HitPoints); 
				} 
				else 
				{ 
					c.LooseMana(target,c.Mana); 
					st.MakeDamage(c,target,c.Mana*10); 
				} 
			} 
		} 

		public static void OnCastIntimidatingShout(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// need testing 
			AuraEffect af = (AuraEffect)ba; 
			Character ch = c as Character; 

			foreach (Object o in ch.Player.KnownObjects) 
			{ 
				if ((o is Mobile) && !(o is BaseSpawner)) 
				{ 
					Mobile around = (Mobile)o; 
					around.UpdateXYZ(); 

					if ((c.Distance(around) < af.Radius1) && (around.Faction != c.Faction)) 
					{ 
						if (around == target) 
						{ 
							Aura aura = new Aura(); 
							aura.ForceStun = true; 
							target.AddAura(c,af,aura,true); 
						} 
						else 
						{ 
							FearAura aura = new FearAura(); 
							aura.SpeedModifier = ((float)(af.S3/100)+1); 
							aura.ForceFlee = true; 
							target.AddAura(c,af,aura,true); 
							target.ChangeRunSpeed( target.RunSpeed ); 
						} 
					} 
				} 
			} 
		} 
		public static void OnCastSlam(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// need testing 
			int int1 = c.AttackSwing(target);
			if ( int1 > 0 ) 
			{ 
				SpellTemplate st = (SpellTemplate)ba; 
				st.MakeDamage(c, target, SpellDamage.TypeS1); // Hp lost by spell - this is affected by resistance
			}   
            
		} 
		public static void OnCastWhirlwind(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// need testing 
			SpellTemplate st = (SpellTemplate)ba; 
			Character ch = c as Character; 
			int i = 0; 
			foreach (Object o in ch.Player.KnownObjects) 
			{ 
				if ((o is Mobile) && !(o is BaseSpawner)) 
				{ 
					Mobile around = (Mobile)o; 
					around.UpdateXYZ(); 

					if ((c.Distance(around) < st.Radius1) && (around.Faction != c.Faction) && i < 5) 
					{ 
						int int1 = c.AttackSwing(around);
						if ( int1 > 0 ) 
						{ 
							 
							st.MakeDamage(c, around, SpellDamage.TypeS1); // Hp lost by spell - this is affected by resistance
						}   
						++i; 
					} 
				} 
			} 
		} 
		public static void OnCastRecklessness(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			
			AuraEffect af = (AuraEffect)ba; 
			RecklessnessAura aura = new RecklessnessAura(); 
			aura.PhysicalCriticalBonus = af.S1; 
			aura.DamageTakenModifier = 1 + (float)af.S2/100; 
			aura.ImmuneToFear = true; 
			c.AddAura(af,aura); 
		} 
		public static void OnCastIntercept(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			if (c.Running == false) c.Running = true;
			target.UpdateXYZ();
			c.RunSpeed *=2;
			target.ChangeRunSpeed( target.RunSpeed);
			c.MoveTo(target.X,target.Y,target.Z);
			c.RunSpeed /=2;
			target.ChangeRunSpeed( target.RunSpeed);
			SpellTemplate st = (SpellTemplate)ba; 
			st.MakeDamage(c, target, SpellDamage.TypeS2); 
			Aura aura = new Aura(); 
			aura.ForceStun = true; 
			target.AddAura(c,st as AuraEffect, aura,true); 
		} 
		#endregion

		#region Protection 
		public static void OnCastShieldBash(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// need testing 

			SpellTemplate st = (SpellTemplate)ba; 
			st.MakeDamage(c, target, SpellDamage.TypeS2); 
			int id = st.InterruptCasting(c,target); 
			if (id !=0)
			{
				AuraEffect af = (AuraEffect)ba; 
				Aura aura = new Aura(); 
				aura.AvoidCastMagicClass = AbilityClasses.abilityClasses[ id ]; 
				target.AddAura(c,af,aura,true); 
				if(c is Character && c.Level > 9 && c.HaveTalent(Talents.ImprovedShieldBash))
				{
					AuraEffect effect1 = (AuraEffect) c.GetTalentEffect(Talents.ImprovedShieldBash);
					float chance = ((float)effect1.H)/100;
					float single1 = (float) Utility.RandomDouble();
					if (single1 <= chance)
					{
						AuraEffect af1 = (AuraEffect) Abilities.abilities[18498];
						Aura aura1 = new Aura();
						aura1.ForceSilence = true;
						target.AddAura(c,af1,aura,true);
					}
				}
			}
            
		} 
	
		public static void OnCastTaunt(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted
			AuraEffect af = (AuraEffect)ba;
			Aura aura = new Aura(); 
			aura.ForceAttackTo = c; 
			target.AddAura(c,af, aura, true); 
		} 
		public static void OnCastBloodrage(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// test
			SpellTemplate st = (SpellTemplate)ba; 
			int life = st.S1;
			if(c is Character && c.Level > 9 && c.HaveTalent(Talents.ImprovedBloodrage))
			{
				AuraEffect effect1 = (AuraEffect) c.GetTalentEffect(Talents.ImprovedBloodrage);
				float single1 = 1+((float)effect1.S1)/100;
				life = (int)((float)life * single1);
			}
			c.LooseHits(c,life);
			c.GainMana(c,st.S1);
			BloodRageAura aura = new BloodRageAura(st, c,c, st.S1, st.Duration( c ), st.T1); 
			aura.InteruptRegeneration = true;
			c.AddAura(c,st as AuraEffect, aura); 
		} 
		public static void OnCastSunderArmor(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted
			// test
			AuraEffect af = (AuraEffect)ba;
			bool sundered = false;
			foreach (IsSundered obj1 in target.AdditionnalStates) 
			{ 
				if (obj1.caster == c) 
				{ 
					if(obj1.times < 5)
					{
						obj1.aura.ArmorMalus += -1*af.S1;
						obj1.times++;
						sundered = true;
						break;
					}           
				} 
			} 
			if(!sundered)
			{
				Aura aura = new Aura(); 
				aura.ArmorMalus = -1*af.S1; 
				target.AddAura(c,af, aura, true); 
			}         
		} 
		public static void OnCastRevenge(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			SpellTemplate st = (SpellTemplate)ba; 
			st.MakeDamage(c, target, SpellDamage.TypeS1); 
			if(c is Character && c.Level > 9 && c.HaveTalent(Talents.ImprovedRevenge))
			{
				AuraEffect effect1 = (AuraEffect) c.GetTalentEffect(Talents.ImprovedRevenge);
				float chance = ((float)effect1.H)/100;
				float single1 = (float) Utility.RandomDouble();
				if (single1 <= chance)
				{
					AuraEffect af = (AuraEffect) Abilities.abilities[effect1.AdditionalSpell];
					Aura aura = new Aura();
					aura.ForceStun = true;
					target.AddAura(c,af,aura,true);
				}
			}
		} 
		
		public static void OnCastShieldBlock(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// need testing 
			AuraEffect af = (AuraEffect)ba; 
			ShieldBlockAura aura = new ShieldBlockAura(); 
			aura.BlockBonus = (int)(c.Block*(float)af.S1/100f); 
			aura.OnMeleeHit = 50006;//   id of the trigger 
			c.Triggers[ 50006 ] = new Mobile.OnMeleeHitTrigger( OnShieldBlockHit ); 
			c.AddAura(af,aura); 
		} 
		public static void OnShieldBlockHit( Mobile m, Mobile target, AuraEffect ae ) 
		{        
			int ImprovedShieldBlockOne = 0x1f2d4e;
			if (target.HaveTalent(Talents.ImprovedShieldBlock))
			{
				if(target.AdditionnalStates.Contains(ImprovedShieldBlockOne))
				{
					target.AdditionnalStates.Remove(ImprovedShieldBlockOne);
					target.ReleaseAura(ae);
				}
				else 
					target.AdditionnalStates.Add(ImprovedShieldBlockOne);
			}
			else target.ReleaseAura(ae); 
		} 
		public static void OnCastShieldWall(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// need testing 
			AuraEffect af = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			aura.MeleePercentDamageTakenReduction = af.S1; 
			c.AddAura(af,aura); 
		} 
		#endregion

		#region Talents
		public static void OnCastMortalStrike(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			
			int dmg = c.AttackSwing( target ); 
			if ( dmg > 0 ) 
			{ 
				SpellTemplate st = (SpellTemplate)ba; 
				st.MakeDamage(c, target, SpellDamage.TypeS2); 
			} 
			AuraEffect af = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.HealTakeModifier = 1 + af.S1;
			target.AddAura(c,af,aura,true);
		} 
		public static void OnCastDeathWish(BaseAbility ba, Mobile c) 
		{   // 100%
			AuraEffect af = (AuraEffect)ba;
			DeathWishAura aura = new DeathWishAura();
			aura.ImmuneToFear = true; 
			aura.PhysicalPercentDamageIncrease = af.S1 ;
			aura.ArmorPercentMalus = -1 *(float)af.S3;
			aura.AllResistancePercentMalus =-1 *(float)af.S3;
			c.AddAura(af,aura);
		} 
		public static void OnCastShieldSlam(BaseAbility ba, Mobile c,Mobile target) 
		{   
			SpellTemplate st = (SpellTemplate)ba;
			st.MakeDamage(c,target,SpellDamage.TypeS2);
			int roll = Utility.Random( 100 );
			if (50 >= roll)
			{
				st.Dispel(DispelType.Magic, st.S1, target);
			}
		} 
		public static void OnCastLastStand(BaseAbility ba, Mobile c)
		{	// 100% working when HealthModifier be working
			AuraEffect af = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.HealthPercentBonus =(float)af.S1;
			c.AddAura(af,aura);
			int life = (int)(((float)af.S1/100)*c.BaseHitPoints);
			c.GainHealth(c,life);
		}
		public static void OnCastConcussionBlow(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted
			c.AttackSwing(target);
			AuraEffect af = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.ForceStun = true;
			target.AddAura(c,af,aura,true);
		} 
		public static void OnCastPiercingHowl(BaseAbility ba, Mobile c) 
		{   // 100% 
			AuraEffect af = (AuraEffect)ba; 
			foreach (Object obj1 in (c as Character).Player.KnownObjects)
			{
				Mobile mobile1 = obj1 as Mobile;
				if ((mobile1.Distance(c) < af.Radius1*af.Radius1) && (c.Reputation(mobile1) < 0.3))
				{
					Aura aura = new Aura();
					if (af.S1 > 0) aura.SpeedModifier = 1 - (float)af.S1/100;
					else aura.SpeedModifier = 1 + (float)af.S1/100;
					aura.OnRelease = new Aura.AuraReleaseDelegate(OnPiercingHowlEnded);
					mobile1.AddAura(c,af, aura, true); 
					mobile1.ChangeRunSpeed(mobile1.RunSpeed);
				}
			}
		} 
		public static void OnPiercingHowlEnded(Mobile from)
		{
			from.ChangeRunSpeed(from.RunSpeed);
		}
		#endregion

		#endregion

		#region Arms 	
		public static void OnCastBattleStance(BaseAbility ba, Mobile c) 
		{   // 0% scripted 
          
			if((c is Character) && (c.Level > 9) && (c.HaveTalent(Talents.TacticalMastery)) && (c.StandState == StandStates.BattleStance || c.StandState == StandStates.DefensiveStance || c.StandState == StandStates.BerserkerStance ))
			{
				
				Ability effect1 = (Ability) c.GetTalentEffect(Talents.TacticalMastery);
				switch (effect1.Id)
				{
					case 12296: c.GainMana(c,5);break;
					case 12676: c.GainMana(c,10);break;
					case 12677: c.GainMana(c,15);break;
					case 12678: c.GainMana(c,20);break;
					case 12679: c.GainMana(c,25);break;
				}				
			}
			(c as Character).ChangeBattleStance( StandStates.BattleStance ); 
			AuraEffect st = (AuraEffect)(Abilities.abilities[21156]); 
			Aura aura = new Aura(); 
			//threat bonus
			c.AddAura( st, aura );    
          
		} 
		
		#endregion

		#region Fury 
   		public static void OnCastBarsekerStance(BaseAbility ba, Mobile c) 
		{ // 0% scripted 
			if((c is Character) && (c.Level > 9) && (c.HaveTalent(Talents.TacticalMastery)) && (c.StandState == StandStates.BattleStance || c.StandState == StandStates.DefensiveStance || c.StandState == StandStates.BerserkerStance ))
			{
				
				Ability effect1 = (Ability) c.GetTalentEffect(Talents.TacticalMastery);
				switch (effect1.Id)
				{
					case 12296: c.GainMana(c,50);break;
					case 12676: c.GainMana(c,100);break;
					case 12677: c.GainMana(c,150);break;
					case 12678: c.GainMana(c,200);break;
					case 12679: c.GainMana(c,250);break;
				}				
			}

			(c as Character).ChangeBattleStance( StandStates.BerserkerStance ); 
            
		} 
		#endregion 

		#region Protection 
		public static void OnCastDisarm(BaseAbility ba, Mobile c, Mobile target) 
		{   // 0% scripted 
			// Disarm enemy for 10 seconds. 
		} 
		
		public static void OnCastDefendingStance(BaseAbility ba, Mobile c) 
		{ // 0% scripted 
			if((c is Character) && (c.Level > 9) && (c.HaveTalent(Talents.TacticalMastery)) && (c.StandState == StandStates.BattleStance || c.StandState == StandStates.DefensiveStance || c.StandState == StandStates.BerserkerStance ))
			{
				
				Ability effect1 = (Ability) c.GetTalentEffect(Talents.TacticalMastery);
				switch (effect1.Id)
				{
					case 12296: c.GainMana(c,50);break;
					case 12676: c.GainMana(c,100);break;
					case 12677: c.GainMana(c,150);break;
					case 12678: c.GainMana(c,200);break;
					case 12679: c.GainMana(c,250);break;
				}				
			}
			(c as Character).ChangeBattleStance( StandStates.DefensiveStance); 
			AuraEffect st = (AuraEffect)(Abilities.abilities[7376]); 
			Aura aura = new Aura(); 
			//aura.IncreaseGeneratedThreat = st.S3; 
			c.AddAura( st, aura ); 
            
		}
		#endregion 

		#region Talents
		
		public static void OnCastSweepingStrikes(BaseAbility ba, Mobile c)
		{	
			// need support of on next attack
		}
		
		
		

		#endregion
	} 
}