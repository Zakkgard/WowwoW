/* ======================================================================

NAME: <Rouge Spells>

DATE  : 16.09.2005

VERSION : v 1.1 for Alpha 7.2

DESCRITION :
For normal working need BaseTrap and HateSystem

VERSION LOG :
----------------------------------
v 1.1 - 15.09.2005
----------------------------------
fix some bugs and mistakes in spell:
-Backstab
-Expose Armor
-Gouge
-Rupture

Spells which not done or have bugs:
-Evasion
-Hemorrhage
-Kick
-Kidney Shot
-Safe Fall
-Slice and Dice
-Sprint
-Stealth
-Vanish
-Mind-numbing Poison

----------------------------------
v 1.0 - 12.09.2005
----------------------------------
Added spell:
-[100%]Detect Traps
-[100%]Disarm Trap
-[90%]Rupture
and some Talents
====================================================================== */
using System.Collections;
using System.Reflection;
using System;
using Server;
using Server.Items;
using HelperTools;
using Server.Creatures;

namespace Server
{
	
	#region Auras
	#region DistractEffect 
	public class DistractEffect : WowTimer 
	{ 
		public ArrayList Targets; 
		BaseCreature bc; 
		Mobile caster; 
		float area; 
		int nTime; 
			   
		public DistractEffect(Mobile _caster, BaseCreature _bc, float _area, int every, int time) : base( every ) 
		{ 
			
			Targets = new ArrayList(); 
			bc = _bc; 
			caster = _caster; 
			area = _area; 
			nTime = time; 
			ApplyDistractEffect(); 
		} 
		public void ApplyDistractEffect() 
		{ 
			foreach(object obj in bc.KnownObjects()) 
			{ 
				Console.WriteLine("Distract effect ---- test1");
				if(obj is Mobile)
				{
					Console.WriteLine("Distract effect ---- test2");
					Mobile target = obj as Mobile;
					if (!Targets.Contains(target)) 
					{ 
						Console.WriteLine("Distract effect ---- test3");
						if (bc.Distance(target) < area && !target.Dead && target is BaseCreature && target!=bc) 
						{ 
							target.FaitFace(bc); 
							target.Freeze = true; 
							Targets.Add(target); 
						} 
					}
				}
			}             
		} 
		public override void OnTick() 
		{ 
			nTime--; 
			if ( nTime <= 0 ) 
			{ 
				Stop(); 
				foreach(Mobile mob in Targets) 
				{ 
					mob.Freeze = false;    
				} 
				Targets.Clear(); 
				World.Remove( bc, caster ); 
			} 
			foreach(Mobile mob in Targets) 
			{ 
				if(mob.InCombat==true) 
				{ 
					mob.Freeze=false; 
				} 
			} 
			base.OnTick(); 
		} 
	} 
	#endregion 
	#region RuptureAura thanks NoXi for corection
	public class RuptureAura : Aura 
	{ 
		private Mobile caster; 
		private Mobile target; 
		private SpellTemplate st; 
		private AuraEffect ae; 
		private int nTime; 

		public RuptureAura( BaseAbility ba, Mobile caster, Mobile target ) 
		{ 
			this.st = (SpellTemplate)ba; 
			this.ae = (AuraEffect)ba; 
			this.caster = caster; 
			this.target = target; 
			this.nTime = 1 + 2 * caster.ComboPoints; 
			base.PeriodicAura( new Aura.AuraPeriodicEffect( this.PeriodicRuptureDamage ), 2000 + 4000 * caster.ComboPoints , this.st.T1 ); 
		} 
		public void PeriodicRuptureDamage() 
		{              
			this.st.MakeDamage( caster, target, SpellDamage.TypeS1 ); 
			nTime--; 
			if( nTime == 0 ) 
			{ 
				target.ReleaseAura( ae ); 
			} 
		} 
	} 
	#endregion
	#region GarroteAura
	public class GarroteAura : Aura 
	{ 
		public GarroteAura(SpellTemplate st, Mobile c, Mobile t) 
		{ 
			if (!t.Dead) 
			{ 
				this.spell = st; 
				this.from = c; 
				this.target = t; 
				base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicGarroteAura), st.Duration( c ) , st.T1); 
			} 
		} 
		Mobile from; 
		Mobile target; 
		SpellTemplate spell; 
		public void PeriodicGarroteAura() 
		{              
			this.spell.MakeDamage(this.from,this.target, spell.S1); 
		} 
	} 
	#endregion
	#endregion
	#region Rogue spells
	public class RogueSpells
	{
		#region LevelModifier
		public static float LevelMofier(int TargetLevel, int CasterLevel)
		{
			if(TargetLevel>CasterLevel)return (float)( 100 - (TargetLevel-CasterLevel) )/100;
			else return (float)( 100 + (CasterLevel-TargetLevel) )/100;
		}
		#endregion
		
		#region Assassination
		#region Ambush // need test	
		public static void OnCastAmbush( BaseAbility ba, Mobile c, Mobile target ) 
		{
			Item mhi = c.ActiveWeapon; 
			if( c.Visible != InvisibilityLevel.True &&  c.Visible != InvisibilityLevel.Visible
				&& mhi.SubClass == 15 && SpellTarget.FaceToBehind(c, target) == true )
			{ 
				int dmg = c.AttackSwing(target);
				if (dmg > 0)
				{
					SpellTemplate st = (SpellTemplate)ba;    
					st.MakeDamage(c,target, st.S1); 
					c.AddComboPoint(target);
				}
			}
			else c.SpellFaillure(SpellFailedReason.Failed); 
		}
		#endregion
		#region Cheap Shot need test 
		public static void OnCastCheapShot( BaseAbility ba, Mobile c, Mobile target ) 
		{ 
			if( SpellTarget.FaceToBehind(c, target) == true ) 
			{ 
				AuraEffect af = (AuraEffect)ba; 
				Aura aura = new Aura();
				aura.ForceStun = true; 
				target.AddAura(af,aura,true); 
				c.AddComboPoint(target); 
				c.AddComboPoint(target); 
			}
		}       
		#endregion 
		#region Eviscerate work 100%
		public static void OnCastEviscerate( BaseAbility ba, Mobile c, Mobile target )
		{
			ComboSpellTemplate ct = (ComboSpellTemplate)ba;
			ct.ComboHit( c, target, Server.SpellDamage.TypeS2 );
		}		 
		#endregion
		#region Expose Armor // don't work, becase ArmorMalus not decrease armor
		public static void OnCastExposeArmor( BaseAbility ba, Mobile c, Mobile target )
		{
			int amount=0;
			switch(ba.Id)
			{
				case 8647 : 
				{
					amount = 80 * c.ComboPoints;
					break;
				}//Rank 1
				case 8649 : 
				{
					amount = 140 * c.ComboPoints;
					break;
				}//Rank 2 
				case 8650 : 
				{
					amount = 200 * c.ComboPoints;
					break;
				}//Rank 3
				case 11197 : 
				{
					amount = 270 * c.ComboPoints;
					break;
				}//Rank 4
				case 11198 : 
				{
					amount = 340 * c.ComboPoints;
					break;
				}//Rank 5
			}
			Console.WriteLine("Explose Armor = {0}", amount);
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.ArmorMalus = amount;
			target.AddAura(c, ae, aura);
			c.ResetCombo(target);
		}		 
		#endregion
		#region Garrote	work 100%
		public static void OnCastGarrote( BaseAbility ba, Mobile c, Mobile target )
		{
			if( c.Visible != InvisibilityLevel.True &&  c.Visible != InvisibilityLevel.Visible
				&& SpellTarget.FaceToBehind(c, target) == true )
			{
				int dmg = c.AttackSwing(target);
				if (dmg > 0)
				{
					SpellTemplate st = (SpellTemplate)ba;
					st.MakeDamage(c, target, SpellDamage.TypeS1);
					GarroteAura aura = new GarroteAura(st,c,target); 
					target.AddAura(c,ba as AuraEffect,aura,true); 
					c.AddComboPoint(target);
				}
			}
		}		 
		#endregion
		#region Kidney Shot	work 100%
		public static void OnCastKidneyShot( BaseAbility ba, Mobile c, Mobile target )
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.ForceStun = true;
			target.AddAura(c, ae, aura);
			c.ResetCombo(target);
		}		 
		#endregion
		#region Rupture work 100%
		public static void OnCastRupture(BaseAbility ba, Mobile c, Mobile target)
		{
			RuptureAura aura = new RuptureAura( ba, c, target ); 
			target.AddAura( ba as AuraEffect, aura, true ); 
			c.ResetCombo(target); 
		}
		#endregion
		#region Slice and Dice	have bug
		public static void OnCastSliceandDice( BaseAbility ba, Mobile c, Mobile target )
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.AttackSpeedModifier = ( ( st.S1 / 100 ) + 1 ); 
			c.AddAura(st, aura);
			c.ResetCombo(target);
		}
                
		#endregion 
		#endregion

		#region Combat
		#region Backstab work 100%
		public static void OnCastBackstab( BaseAbility ba, Mobile c, Mobile target )
		{
			Item mhi = c.ActiveWeapon; 
			if( mhi.SubClass == 15 && SpellTarget.FaceToBehind(c, target) == true )
			{
				int dmg = c.AttackSwing(target);
				if (dmg > 0)
				{
					SpellTemplate st = (SpellTemplate)ba;
					st.MakeDamage(c, target, st.S1 );
					c.AddComboPoint(target);
				}
			}
			else c.SpellFaillure(SpellFailedReason.Failed); 
		}		 
		#endregion
		#region Evasion	Dodge increase at target :)
		public static void OnCastEvasion( BaseAbility ba, Mobile c)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.DodgeBonus = ae.S1;
			c.AddAura( ae, aura );
		}		
		#endregion
		#region Feint    need test 
		public static void OnCastFeint( BaseAbility ba, Mobile c, Mobile target ) 
		{ 
			switch(ba.Id) 
			{ 
				case 1966://Rank 1 
					FeintEffect((target as BaseCreature), c,2.0d, 1.5d); 
					break; 
				case 6768://Rank 2 
					FeintEffect((target as BaseCreature),c,2.5d, 2.0d); 
					break; 
				case 8637://Rank 3 
					FeintEffect( (target as BaseCreature), c, 3.2d, 2.8d ); 
					break; 
				case 11303://Rank 4 
					FeintEffect((target as BaseCreature),c,4.0d, 3.6d); 
					break; 
			} 
		} 
		public static void FeintEffect(BaseCreature target, Mobile c, double low, double high) 
		{ 
			HateUnit unit; 
			for( int i=0; i < target.HateList.Count; i++ ) 
			{ 
				unit = (HateUnit)target.HateList[i]; 
				if(unit.HatedMobile == c) 
				{ 

					if ( target.Level > c.Level ) 
					{ 
						unit.Hate = (float)(unit.Hate - (System.Math.Abs(1-(c.Level / target.Level)) * HelperTools.Utility2.Random( (int)(c.Agility * high) ))); 
						if(unit.Hate < 15) 
						{ 
							target.EndCombat( c );
							target.HateList[i] = unit; 
							c.AddComboPoint(target); 
							break; 
		                    
						} 
						else 
						{ 
							target.HateList[i] = unit; 
							c.AddComboPoint(target); 
							break; 
						} 
					} 
					else//if ((target.Level - c.Level) < 0) 
					{ 
						unit.Hate = (float)(unit.Hate - ((1-(target.Level / c.Level)) * HelperTools.Utility2.Random( (int)(c.Agility * low)) )); 
						if (unit.Hate < 15) 
						{ 
							target.EndCombat( c );
							target.HateList[i] = unit; 
							c.AddComboPoint(target); 
							break; 
						} 
						else 
						{ 
							target.HateList[i] = unit; 
							c.AddComboPoint(target); 
							break; 
						} 
					} 
				} 
			} 
		}
		#endregion 
		#region Gouge work 100%
		public static void OnCastGouge( BaseAbility ba, Mobile c, Mobile target )
		{
			if( SpellTarget.FaceToBehind(c, target) == false )
			{
				AuraEffect ae = (AuraEffect)ba;
				Aura aura = new Aura();
				aura.ForceStun = true;
				ae.MakeDamage(c, target, SpellDamage.TypeS1);
				c.AddComboPoint(target);
				target.AddAura(c, ae, aura);
			}
			else c.SpellFaillure(SpellFailedReason.Failed); 
		}     
		#endregion
		#region Kick
		public static void OnCastKick( BaseAbility ba, Mobile c, Mobile target ) 
		{ 
			AuraEffect af = (AuraEffect)ba; 
			af.MakeDamage(c,target, af.S1);
			Aura aura= new Aura(); 
			//aura.ForceSilence = true; 
			target.AddAura(c, af, aura); 
		}       		
		#endregion
		#region Sinister Strike	work 100%
		public static void OnCastSinisterStrike( BaseAbility ba, Mobile c, Mobile target )
		{
			int dmg = c.AttackSwing( target );
			if ( dmg > 0 )
			{
				SpellTemplate st = (SpellTemplate)ba; 
				st.MakeDamage(c, target, st.S1);
				c.AddComboPoint( target );
			}
		}		 
		#endregion
		#region Sprint	work 100%
		public static void OnCastSprint	( BaseAbility ba, Mobile c )
		{
			AuraEffect st = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			aura.OnRelease = new Aura.AuraReleaseDelegate( OnSpeedBoostSprintEnded ); 
			aura.SpeedModifier =  ((float)st.S1 / 100 )+ 1F;
			c.AddAura(st, aura);
			c.ChangeRunSpeed( c.RunSpeed );
		} 
		public static void OnSpeedBoostSprintEnded( Mobile c )  
		{ 
			c.ChangeRunSpeed( c.RunSpeed );
		}	 
		#endregion
		#endregion

		#region Lockpicking
		#region Pick Lock
		public static void OnCastPickLock( BaseAbility ba, Mobile c, Mobile target )
		{
			//			if(target is BaseChest)
			//			{
			//				BaseChest bch = target as BaseChest;
			//				if(bch.Locked = true)
			//				{
			//					bch.Locked = false;
			//				}
			//			}
			//			else c.SpellFaillure(SpellFailedReason.InvalidTarget); 
		}		
		#endregion
		#endregion

		#region Poisons
		#region Blinding Powder
		public static void OnCastBlindingPowder( BaseAbility ba, Mobile c )
		{
			(c as Character).CreateAndAddObject("BlindingPowder");
		}
		#endregion
		#region Crippling Poison
		public static void OnCastCripplingPoison( BaseAbility ba, Mobile c )
		{}
		#endregion
		#region Deadly Poison
		public static void OnCastDeadlyPoison( BaseAbility ba, Mobile c )
		{}
		#endregion
		#region Instant Poison
		public static void OnCastInstantPoison( BaseAbility ba, Mobile c )
		{}
		#endregion 
		#region Wound Poison
		public static void OnCastWoundPoison( BaseAbility ba, Mobile c )
		{}
		#endregion 
		#region Mind-numbing Poison
		public static void OnCastMindnumbingPoison( BaseAbility ba, Mobile c)
		{

		}
		#endregion
		#endregion

		#region Subtlety
		#region Blind   // need test 
		public static void OnCastBlind( BaseAbility ba, Mobile c, Mobile target ) 
		{ /*
			AuraEffect af = (AuraEffect)ba; 
			NextAttackAura aura = new NextAttackAura(af, 2, new NextAttackAura.NextAttackEffect(BlindAttackEff));
			aura.SpeedModifier = 0.4f; 
			//aura.onEffect = new NextAttackAura.NextAttackEffect(BlindAttackEff);
			target.AddAura(c, af, aura); 
			
			if( Utility.Random(c.Level)>Utility.Random(target.Level) )
			{
				target.EndCombat( c );
			}*/
		}    
		public static void BlindAttackEff(Mobile attack, Mobile target, AuraEffect st)
		{/*
			target.ReleaseAura((AuraEffect)Abilities.abilities[2094]);
			Console.WriteLine("!RELEASE AURA!");
			target.ChangeRunSpeed(target.RunSpeed);*/
		}
		#endregion 
		#region Detect Traps //need test
		public static void OnCastDetectTraps( BaseAbility ba, Mobile c)
		{
			foreach(BaseTrap trap in TrapTimer.TrapsList)
			{
				if(c.Distance(trap)>100 && !trap.Dead)
				{
					trap.ImmunMobs.Add(c);
					trap.Visible = InvisibilityLevel.True;
				}
			}
		}		
		#endregion
		#region Disarm Trap //need test
		public static void OnCastDisarmTrap( BaseAbility ba, Mobile c, Mobile target )
		{
			if(target is BaseTrap)
			{
				BaseTrap trap = target as BaseTrap;
				if(c.Distance(trap)<25 && !trap.Dead)
				{
					trap.Remove();
				}
				else c.SpellFaillure(SpellFailedReason.Failed);
			}
			else c.SpellFaillure(SpellFailedReason.InvalidTarget); 
		}		
		#endregion
		#region Distract   scripted 100% 
		public static void OnCastDistract(BaseAbility ba, Mobile c, float x, float y, float z) 
		{
			/*
			if(!c.InCombat) 
			{ 
				ConstructorInfo ct = Utility.FindConstructor( "Imp", Utility.externAsm ); 
				BaseCreature bc = null; 
				bc = (BaseCreature)ct.Invoke( null ); 
				bc.Freeze = true; 
				bc.AIEngine = null;          
				bc.GodMode = true; 
				bc.Size = 1.0f; 
				//bc.Visible = InvisibilityLevel.GM; 
				World.Add(bc, x, y, z, c.MapId); 
				
				DistractEffect timer = new DistractEffect(c, bc, 900f, 1001, 10); 
				timer.Start();
			}
			*/
		} 
		#endregion 
		#region Pick Pocket   work 100%
		public static void OnCastPickPocket( BaseAbility ba, Mobile c, Mobile target ) 
		{ 
			if((c.Level/10)>1.5 ) 
			{ 
				target.LootMoney = (int)(target.LootMoney * c.Level/10); 
			} 
			else 
			{ 
				target.LootMoney = (int)(target.LootMoney * 1.5); 
			} 
		}       
		#endregion 
		#region Safe Fall not support yet
		public static void OnCastSafeFall( BaseAbility ba, Mobile c)
		{
			// need support falling damage
		}		
		#endregion
		#region Sap	//need test
		public static void OnCastSap( BaseAbility ba, Mobile c, Mobile target )
		{/*
			if (target.NpcType == 7 && !target.InCombat && 
				c.Visible != InvisibilityLevel.True &&  c.Visible != InvisibilityLevel.Visible)
			{
				AuraEffect af = (AuraEffect)ba;
				NextAttackAura aura = new NextAttackAura(af, 1);
				aura.ForceStun = true;
				aura.onEffect = new NextAttackAura.NextAttackEffect(SapAttackEff);
				target.AddAura(af, aura);
				af.MakeDamage(c, target, af.S1);
			}
			else c.SpellFaillure(SpellFailedReason.InvalidTarget); */
		}
		public static void SapAttackEff(Mobile attack, Mobile target, AuraEffect st)
		{/*
			target.ReleaseAura(st as AuraEffect);*/
		} 
		#endregion
		#region Stealth	work 100%
		public static void OnCastStealth	( BaseAbility ba, Mobile c )
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.OnRelease = new Aura.AuraReleaseDelegate( OnCastStealthEnded );
			c.AddAura(st, aura);
			aura.SpeedModifier = st.S1;
			c.Visible = InvisibilityLevel.Medium;
		}
		public static void OnCastStealthEnded( Mobile c )
		{
			c.ChangeRunSpeed(c.RunSpeed); 
			c.Visible = InvisibilityLevel.Visible;
		}  	 
                		 
		#endregion
		#region Vanish not support yet
		public static void OnCastVanish	( BaseAbility ba, Mobile c){}		 
		#endregion
		#endregion

		#region Talent
		#region Adrenaline Rush scripted need test
		public static void OnCastAdrenalineRush( BaseAbility ba, Mobile c )
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.ManaRegenerationModifier = ae.S1;
			c.AddAura(ae, aura);
		}
		#endregion
		#region Blade Flurry not done
		public static void OnCastBladeFlurry( BaseAbility ba, Mobile c )
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.AttackSpeedModifier = ae.S1;
			c.AddAura(ae, aura);
		}
		#endregion
		#region Cold Blood need AuraEffect AttackCritBonus
		public static void OnCastColdBlood( BaseAbility ba, Mobile c )
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura();
			//aura.AttackCritBonus = 100;
			c.AddAura(ae, aura);
		}
		#endregion
		#region Ghostly Strike scripted need test
		public static void OnCastGhostlyStrike(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.DodgeBonus = st.S1;
			st.MakeDamage(c, target, st.S2);
			c.AddAura( (st as AuraEffect), aura );
			c.AddComboPoint(target);
		}
		#endregion
		#region Hemorrhage scripted 90%
		public static void OnCastHemorrhage( BaseAbility ba, Mobile c, Mobile target ) 
		{ 
			int dmg = c.AttackSwing(target); 
			if (dmg > 0) 
			{ 
				AuraEffect af = (AuraEffect)ba; 
				Aura aura     = new Aura(); 

				aura.MeleeDamageMalus = af.S1; 
				//aura.PhysicalDamageIncrease = 3;
				target.AddAura(c, af, aura); 
				c.AddComboPoint(target); 
			} 
		}		
		#endregion
		#region Premeditation not done
		public static void OnCastPremeditation(BaseAbility ba, Mobile c, Mobile target)
		{
		//			AuraEffect ae = (AuraEffect)ba;
		//			Aura aura = new Aura();
		//			aura.OnRelease = new Aura.AuraReleaseDelegate( OnCastPremeditationEnded );
		//			c.AddAura(ae, aura);
		//		}
		//		public static void OnCastPremeditationEnded(Mobile m)
		//		{
		}
		#endregion
		#region Relentless Strikes not done
		public static void OnCastRelentlessStrikes(BaseAbility ba, Mobile c)
		{
			//SpellTemplate st = (SpellTemplate)ba;
			for(int i=0; c.ComboPoints>i; i++)
			{
				if ( Utility.Random(0, 100)<21 ) 
				{
					if ( c.Mana + 25>c.BaseMana )c.Mana=c.BaseMana;
					else c.Mana = c.Mana + 25;
				}
			}
		}
		#endregion
		#region Riposte need Disarm AuraEffect
		public static void OnCastRiposte(BaseAbility ba, Mobile c, Mobile target)
		{
			if(c.LastAttackStatus == Server.AttackStatus.Parry)
			{
				SpellTemplate st = (SpellTemplate)ba;
				Aura aura = new Aura();
				//				aura.Disarm = true;
				//				target.AddAura( c,(st as AuraEffect), aura );
				st.MakeDamage( c, target, st.S1 );
			}
			else c.SpellFaillure(Server.SpellFailedReason.AbilityIsntReadyYet);
		}
		#endregion
		#endregion
	}
	#endregion
}
