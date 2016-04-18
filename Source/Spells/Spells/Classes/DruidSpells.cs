
using System;
using Server;
using HelperTools;
using System.Collections;
 
namespace Server
{
	public class DruidSpells 
	{
		#region  Functions
			public static void UpdateSwimSpeed(Mobile target)
			{
				int num1 = 4;
				Converter.ToBytes((target as Character).Guid,(target as Character).tempBuff, ref num1);
				Converter.ToBytes((target as Character).SwimSpeed,(target as Character).tempBuff, ref num1);
				(target as Character).ToAllPlayerNear(OpCodes.SMSG_FORCE_SWIM_SPEED_CHANGE, (target as Character).tempBuff, num1);
			}
		public static void DumpInfo(SpellTemplate st)
		{
			Console.WriteLine("S1: " + st.S1);
			Console.WriteLine("S2: " + st.S2);
			Console.WriteLine("S3: " + st.S3);
			Console.WriteLine("T1: " + st.T1);
			Console.WriteLine("T2: " + st.T2);
			Console.WriteLine("AdditionalSpell: " + st.AdditionalSpell);
			Console.WriteLine("Bonus1: " + st.Bonus1);
			Console.WriteLine("Bonus2: " + st.Bonus2);
			Console.WriteLine("H: " + st.H);
			Console.WriteLine("Radius1: " + st.Radius1);
			Console.WriteLine("Radius2: " + st.Radius2);
			Console.WriteLine("Radius3: " + st.Radius3);
			Console.WriteLine("RequieredLevel: " + st.RequieredLevel);
		}
		public static void Mana2Rage(Character c) 
		{
			c.ManaType = 1;
			int[] numArray1 = new int[2] { 0x17 + c.ManaType, 0x1d + c.ManaType } ;
			object[] objArray1 = new object[2] { c.Rage, c.BaseRage } ;
			c.SendSmallUpdate(numArray1, objArray1);
		}
		public static void Mana2Energy(Character c) 
		{
			c.ManaType = 3;
			int[] numArray1 = new int[2] { 0x17 + c.ManaType, 0x1d + c.ManaType } ;
			object[] objArray1 = new object[2] { c.Energy, c.BaseEnergy } ;
			c.SendSmallUpdate(numArray1, objArray1);
		}
		
		#endregion
	
		#region Auras
		public class HurricaneAura : Aura 
		{ 
			public HurricaneAura() 
			{ 
				base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicSlow), 1000 , 1000); 
			} 
			
			public void PeriodicSlow() 
			{
 
			} 
		}
		public class HurricaneEffect : WowTimer
		{
			private AuraEffect ae;
			private Mobile dummy;
			private Mobile caster;
			private SpellTemplate spell;
			private int nTime;
			
			
			public HurricaneEffect(SpellTemplate st, Mobile _dummy, Mobile _caster, int every, int _duration,AuraEffect af)
				: base(Priorities.Milisec, every)
			{
				this.dummy = _dummy;
				this.caster = _caster;
				this.spell = st;
				this.nTime = (int)_duration / every;
				this.ae = af;
			}

			public override void OnTick()
			{
				
				ArrayList targets = SpellTarget.targetsAround(caster, spell.Radius1*spell.Radius2, TargetType.Enemy);

				foreach (Mobile target in targets)
				{
					if (!target.Dead)
					{
						spell.MakeDamage(caster, target, SpellDamage.TypeS1);
						HurricaneAura a = new HurricaneAura();
						a.AttackSpeedModifier=0.8f;
						target.AddAura(caster,ae,a,true);
						SpellHelp.GraphicEffectTarget(caster, spell.Id,target);  
					}
					
				}
                      
				
				nTime--;
				if (nTime <= 0)
				{
					Stop();
				}
			}
		}
		
		public class Innervate : Aura 
		{
			public Innervate() {}
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
			public override float ManaRegenerationModifier 
			{
				get { return this.manaRegenerationModifier; }
				set { this.manaRegenerationModifier = value; }
			}
			public override float ManaRegenWhileCastingPercent
			{
				get { return this.manaRegenWhileCastingPercent; }
				set { this.manaRegenWhileCastingPercent = value; }
			}
			private AuraEffect auraEffect;
			private float manaRegenerationModifier;
			private float manaRegenWhileCastingPercent;
		
	}
			public class Barkskin : Aura
			{
			
			public Barkskin() {}
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
			public override float AttackSpeedModifier 
			{
				get { return this.attackSpeedModifier; }
				set { this.attackSpeedModifier = value; }
			}
			public override float MeleePercentDamageTakenReduction
			{
				get { return this.meleePercentDamageTakenReduction; }
				set { this.meleePercentDamageTakenReduction = value; }
			}
			private float attackSpeedModifier;
			private float meleePercentDamageTakenReduction;
			private AuraEffect auraEffect;
		}

		
		public class Ravage : Aura
		{
			public Ravage() {}
 
			public override int PhysicalCriticalBonus 
			{
				get { return this.physicalCriticalBonus; }
				set { this.physicalCriticalBonus = value; }
			}
			public override bool ForceStun
			{
				get
				{
					return this.forceStun;
				}
				set
				{
					this.forceStun = value;
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
 
			private AuraEffect auraEffect;
			private bool forceStun;
			private int physicalCriticalBonus;
 
		}
		public class FrenziedAura : Aura 
		{ 
			public FrenziedAura(SpellTemplate st, Mobile c) 
			{ 
				if (!c.Dead) 
				{ 
					this.spell = st; 
					this.from = c; 
 
					base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicFrenzy), this.spell.Duration( this.from ) , this.spell.T1); 
				} 
			} 
			int amount;
			int amount2;
			Mobile from; 
			SpellTemplate spell; 
 
			public void PeriodicFrenzy() 
			{
 
				amount = Utility.Random(1,11)*10;
				if(this.from.Mana >= amount)
				{
					this.from.LooseMana(this.from,amount);
					int health = (amount/10)*this.spell.S1;
					this.from.GainHealth(this.from,health);
				}
				else 
				{
					amount2 = this.from.Mana*10;
					this.from.LooseMana(this.from,amount2);
					int health = (amount2/10)*this.spell.S1;
					this.from.GainHealth(this.from,health);
				}
			} 
		} 
		public class NatureGrasp : Aura 
		{
			public NatureGrasp() {}
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
			public override int OnSpellHit 
			{
				get
				{
					return this.onSpellHit;
				}
				set
				{
					this.onSpellHit = value;
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
			private int onMeleeHit;
			private int onSpellHit;
			private AuraEffect auraEffect;
		}
 
 
		public class Catform : Aura
		{
			public Catform() { }
			public override int PhysicalCriticalBonus
			{
				get { return this.physicalCriticalBonus; }
				set { this.physicalCriticalBonus = value; }
			}
 
			public override float StrPercentBonus
			{
				get
				{
					return this.strPercentBonus;
				}
				set
				{
					this.strPercentBonus = value;
				}
			}
			public override int AttackPowerBonus
			{
				get
				{
					return this.attackPowerBonus;
				}
				set
				{
					this.attackPowerBonus = value;
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
			private int attackPowerBonus;
			private float strPercentBonus;
			private AuraEffect auraEffect;
			private int physicalCriticalBonus;
		}
		public class PredatoryStrikes : Aura
		{
			public PredatoryStrikes() { }
			public override int AttackPowerBonus
			{
				get
				{
					return this.attackPowerBonus;
				}
				set
				{
					this.attackPowerBonus = value;
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
 
			private int attackPowerBonus;
			private AuraEffect auraEffect;
		}
		public class PrimalFury : Aura
		{
			public PrimalFury() { }
			public override int OnCriticalHitDone
			{
				get
				{
					return this.onCriticalHitDone;
				}
				set
				{
					this.onCriticalHitDone = value;
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
 
			private int onCriticalHitDone;
			private AuraEffect auraEffect;
		}
		public class MoonFireTalent : Aura 
		{
			public MoonFireTalent() { }
			public override int ArcaneCriticalBonus
			{
				get
				{
					return this.arcaneCriticalBonus;
				}
				set
				{
					this.arcaneCriticalBonus = value;
				}
			}
			public override int ArcaneDamageIncrease
			{
				get
				{
					return this.arcaneDamageIncrease;
				}
				set
				{
					this.arcaneDamageIncrease = value;
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
			private int arcaneDamageIncrease;
			private int arcaneCriticalBonus;
			private AuraEffect auraEffect;
		}
 
		public class Hibernate : Aura
		{
			public Hibernate() { }
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
			public override int OnSpellHit
			{
				get
				{
					return this.onSpellHit;
				}
				set
				{
					this.onSpellHit = value;
				}
			}
			public override bool ForceStun
			{
				get
				{
					return this.forceStun;
				}
				set
				{
					this.forceStun = value;
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
			private bool forceStun;
			private int onSpellHit;
			private int onMeleeHit;
			private AuraEffect auraEffect;
		}
 
 
		public class Enrage : Aura
		{
			public Enrage(SpellTemplate st, Mobile c, int duration, int freq)
			{
				this.spell = st;
				this.from = c;
				base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicEnrage), duration , freq); 
			}
			Mobile from; 
			SpellTemplate spell;
			public void PeriodicEnrage()
			{
				this.from.GainMana(this.from, 20);
			}
			public override float ArmorPercentMalus 
			{
				get { return this.armorPercentMalus; }
				set { this.armorPercentMalus = value; }
			}
 
			private float armorPercentMalus;
 
		}
 
		public class Bear : Aura
		{
			public Bear() { }
			public override int PhysicalCriticalBonus
			{
				get { return this.physicalCriticalBonus; }
				set { this.physicalCriticalBonus = value; }
			}
			public override float ArmorFromItemsPercentIncrease
			{
				get { return this.armorFromItemsPercentIncrease; }
				set { this.armorFromItemsPercentIncrease = value; }
			}
			public override int OnCriticalHitDone
			{
				get
				{
					return this.onCriticalHitDone;
				}
				set
				{
					this.onCriticalHitDone = value;
				}
			}
			public override int ArmorBonus 
			{ 
				get 
				{ 
					return this.armorBonus; 
				} 
				set 
				{ 
					this.armorBonus = value; 
				} 
			}
			public override int HealthBonus 
			{ 
				get 
				{ 
					return this.healthBonus; 
				} 
				set 
				{ 
					this.healthBonus = value; 
				} 
			}
			public override int AttackPowerBonus 
			{ 
				get 
				{ 
					return this.attackPowerBonus; 
				} 
				set 
				{ 
					this.attackPowerBonus = value; 
				} 
			}
			public override float StrPercentBonus
			{
				get
				{
					return this.strPercentBonus;
				}
				set
				{
					this.strPercentBonus = value;
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
			private int onCriticalHitDone;
			private float strPercentBonus;
			private AuraEffect auraEffect;
			private float armorFromItemsPercentIncrease;
			private int armorBonus;
			private int attackPowerBonus;
			private int healthBonus;
			private int physicalCriticalBonus;
		}
 
		public class AuraOfWild : Aura 
		{ 
			public AuraOfWild() 
			{ 
			} 
			public override int ArmorBonus 
			{ 
				get 
				{ 
					return this.armorBonus; 
				} 
				set 
				{ 
					this.armorBonus = value; 
				} 
 
			} 
			public override int AgBonus 
			{ 
				get 
				{ 
					return this.agBonus;
				} 
				set 
				{ 
					this.agBonus = value; 
				} 
 
			} 
			public override int ArcaneResistanceBonus
			{ 
				get 
				{ 
					return this.arcaneResistanceBonus; 
				} 
				set 
				{ 
					this.arcaneResistanceBonus = value; 
				} 
 
			} 
			public override int FireResistanceBonus 
			{ 
				get 
				{ 
					return this.fireResistanceBonus; 
				} 
				set 
				{ 
					this.fireResistanceBonus = value; 
				} 
 
			} 
			public override int FrostResistanceBonus 
			{ 
				get 
				{ 
					return this.frostResistanceBonus; 
				} 
				set 
				{ 
					this.frostResistanceBonus = value; 
				} 
 
			} 
			public override int HolyResistanceBonus 
			{ 
				get 
				{ 
					return this.holyResistanceBonus; 
				} 
				set 
				{ 
					this.holyResistanceBonus = value; 
				} 
 
			} 
			public override int IQBonus 
			{ 
				get 
				{ 
					return this.iQBonus; 
				} 
				set 
				{ 
					this.iQBonus = value; 
				} 
 
			} 
			public override int NatureResistanceBonus 
			{ 
				get 
				{ 
					return this.natureResistanceBonus; 
				} 
				set 
				{ 
					this.natureResistanceBonus = value; 
				} 
 
			} 
			public override int ShadowResistanceBonus
			{ 
				get 
				{ 
					return this.shadowResistanceBonus; 
				} 
				set 
				{ 
					this.shadowResistanceBonus = value; 
				} 
 
			} 
			public override int SpiritBonus 
			{ 
				get 
				{ 
					return this.spiritBonus; 
				} 
				set 
				{ 
					this.spiritBonus = value; 
				} 
 
			} 
			public override int StaminaBonus 
			{ 
				get 
				{ 
					return this.staminaBonus; 
				} 
				set 
				{ 
					this.staminaBonus = value; 
				} 
 
			} 
			public override int StrBonus
			{ 
				get 
				{ 
					return this.strBonus; 
				} 
				set 
				{ 
					this.strBonus = value; 
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
			private AuraEffect auraEffect; 
			private int strBonus;
			private int staminaBonus;
			private int spiritBonus;
			private int shadowResistanceBonus;
			private int natureResistanceBonus;
			private int iQBonus;
			private int holyResistanceBonus;
			private int frostResistanceBonus;
			private int fireResistanceBonus;
			private int arcaneResistanceBonus;
			private int agBonus;
			private int armorBonus;
		} 
		public class AbolishPoisonAura : Aura
		{
			public AbolishPoisonAura(Mobile _target, Mobile c, SpellTemplate _st)
			{
				target = _target;
				caster = c;
				st = _st;
				base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicAbolishPoison), 8001, 2000);
			}
			public void PeriodicAbolishPoison()
			{
				if(Utility2.Random(caster.Level)> Utility2.Random(50))
				{
					st.Dispel(DispelType.Poison, 1, target);
				}
			}
			private Mobile target;
			private Mobile caster;
			private SpellTemplate st;
		}
		#endregion
 
		#region 100% Scripted but Fixes in progress
 
		#region Feral Combat
		#region Bash 100%
		public static void OnCastBash(BaseAbility ba, Mobile c, Mobile target)
		{
			if ( c.HaveTalent( Talents.ImprovedBash ) ) 
			{
 
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedBash );
				Aura aura = new Aura();
				aura.ForceStun = true;
				target.AddAura(c,ae, aura,true);
			}
			else 
			{
				AuraEffect af =(AuraEffect)ba;
				Aura aura = new Aura();
				aura.ForceStun = true;
				target.AddAura(c,af, aura,true);
			}
		}			
		#endregion
		#region Claw  100%
		public static void OnCastClaw(BaseAbility ba, Mobile c, Mobile target)
		{
			int int1 = c.AttackSwing(target);
			if ( int1 > 0 ) 
			{ 
				SpellTemplate st = (SpellTemplate)ba; 
				st.MakeDamage(c, target, SpellDamage.TypeS1); // Hp lost by spell - this is affected by resistance
				target.AddComboPoint(c);
			}   
 
		}			
		#endregion
		#region Dash 100%
		public static void OnCastDash(BaseAbility ba, Mobile c)
		{
			AuraEffect af = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.OnRelease = new Aura.AuraReleaseDelegate( OnCastDashEnded );   
 
			switch ((af as SpellTemplate).Id)
			{
				case 1850 : {	aura.SpeedModifier = 1.5f;break; }
				case 9821 :	{ aura.SpeedModifier = 1.6f;break; }
			}
			c.AddAura(af,aura);
			c.ChangeRunSpeed( c.RunSpeed);
		}			
		public static void OnCastDashEnded( Mobile c )
		{
			c.ChangeRunSpeed( c.RunSpeed);
		}
		#endregion
		#region DemoralizingRoar 100%
		public static void OnCastDemoralizingRoar(BaseAbility ba, Mobile c)
		{
			if ( c.HaveTalent( Talents.ImprovedDemoralizingRoar ) ) 
			{
 
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedDemoralizingRoar );
				Character ch = c as Character;
				foreach (Object o in ch.Player.KnownObjects) 
				{ 
					if ((o is Mobile) && !(o is BaseSpawner)) 
					{ 
						Mobile around = (Mobile)o; 
						around.UpdateXYZ(); 
						c.UpdateXYZ(); 
 
						if ((c.Distance(around) < ae.Radius1) && (around.Faction != c.Faction)) 
						{ 
							Aura aura = new Aura(); 
							aura.AttackPowerMalus = ae.S1; 
							around.AddAura(c,ae,aura,true); 
						} 
					} 
				} 
 
			}
			else 
			{
				AuraEffect st = (AuraEffect)ba; 
				Character ch = c as Character; 
				foreach (Object o in ch.Player.KnownObjects) 
				{ 
					if ((o is Mobile) && !(o is BaseSpawner)) 
					{ 
						Mobile around = (Mobile)o; 
						around.UpdateXYZ(); 
						c.UpdateXYZ(); 
 
						if ((c.Distance(around) < st.Radius1) && (around.Faction != c.Faction)) 
						{ 
							Aura aura = new Aura(); 
							aura.AttackPowerMalus = st.S1; 
							around.AddAura(c,st,aura,true); 
						} 
					} 
				} 
			}
		}			
		#endregion
		#region Rake 100%
		public static void OnCastRake(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect af =(AuraEffect)ba;
			af.MakeDamage(c,target,SpellDamage.TypeS1);
			af.ApplyDot( c, target, af.S2, af.T2, af.Duration( c ) ); 
			target.AddComboPoint(c);
		}		
		#endregion
		#region Rip 100%
		public static void OnCastRip(BaseAbility ba, Mobile c, Mobile target)
		{
			ComboSpellTemplate ct = (ComboSpellTemplate)ba;
			ct.ApplyDot( c, target, ct.S1, ct.T1, ct.Duration( c ) ); 
		}			
		#endregion
		#region Swipe 100%
		public static void OnCastSwipe(BaseAbility ba, Mobile c, Mobile target)
		{
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
						if (num < 3) 
						{ 
							num++; 
							st.MakeDamage(c, around, SpellDamage.TypeS1); 
						} 
					} 
				} 
			} 
		} 
		#endregion
		#region Tiger'sFury 100%
		public static void OnCastTigersFury(BaseAbility ba, Mobile c)
		{
			AuraEffect af = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.MeleeDamageBonus = af.S1;
			c.AddAura(af,aura);
		}		
		#endregion
		#region FerociousBite	100%
		public static void OnCastFerociousBite(BaseAbility ba, Mobile c, Mobile target)
		{
			float baseDamage = 0f;
			SpellTemplate st = (SpellTemplate)ba;
			switch (st.Id)
			{
				case 22568: baseDamage = st.S1 + Utility.Random(1, st.Bonus1) + 40*target.ComboPoints;break;
				case 22827: baseDamage = st.S1 + Utility.Random(1, st.Bonus1) + 60*target.ComboPoints;break;
				case 22828: baseDamage = st.S1 + Utility.Random(1, st.Bonus1) + 90*target.ComboPoints;break;
				case 22829: baseDamage = st.S1 + Utility.Random(1, st.Bonus1) + 125*target.ComboPoints;break;
			}
			int plusDamage = c.Mana;
			c.LooseMana(c,plusDamage);
			int damage = (int)baseDamage + plusDamage*3;
			st.MakeDamage(c,target,damage);
		}			
		#endregion
		#region CatForm 100%
		public static void OnCastCatForm(BaseAbility ba, Mobile c)
		{
			int bonus = 40;
			int bonus1=0;
			int bonus2 =0;
			float speedmodifier = 1f;
			int critbonus2 = (int)((c as Character).BaseCritChance);
			if ( c.HaveTalent( Talents.SharpenedClaws ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.SharpenedClaws );
				critbonus2 += (int)((ae.S1*(c as Character).BaseCritChance)/100);
			}
			if ( c.HaveTalent( Talents.FelineSwiftness ) ) 
			{
				speedmodifier = 1.3f;
			}
			if ( c.HaveTalent( Talents.Intensity ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.Intensity );
				int roll = Utility.Random(100);
				if(roll < ae.S1)
				{
					c.GainMana(c,400);
				}

			}

			if ( c.HaveTalent( Talents.StrengthOfTheWild ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.StrengthOfTheWild );
				bonus2=ae.S1;
 
 
			}
			if ( c.HaveTalent( Talents.PredatoryStrikes ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.PredatoryStrikes );
 
				bonus1 = (ae.S1*bonus)/100;
 
			}
			AuraEffect st = (AuraEffect)ba;
			Catform aura = new Catform();
			aura.OnRelease = new Aura.AuraReleaseDelegate( OnCastCatFormEnded );   
			aura.AttackPowerBonus = bonus+bonus1;
			aura.StrPercentBonus = bonus2;
			aura.SpeedModifier = speedmodifier;
			aura.PhysicalCriticalBonus = critbonus2;
			c.AddAura( st, aura );   
			c.ChangeRunSpeed( c.RunSpeed );
			if((c as Character).Race == Races.NightElf)
			{
				c.Polymorph( 0x37C );
			}
			else if ((c as Character).Race == Races.Tauren)
			{
				c.Polymorph( 0x217B );
			} 
			c.BaseMana = 100;
			(c as Character).BaseEnergy = 100;
			(c as Character).Energy = 100;
			Mana2Energy(c as Character);
			(c as Character).ChangeBattleStance( StandStates.CatForm );
		}			
		public static void OnCastCatFormEnded( Mobile c )
		{
			c.ChangeRunSpeed( c.RunSpeed );
			c.CancelPolymorph();(c as Character).ChangeBattleStance( StandStates.Standing );(c as Character).SwitchManatypeToMana();	
 
			c.ManaUpdate( c );
		}
		#endregion
		#region Cower 100%
		public static Mobile ChooseTarget(BaseCreature bc)
		{
			HateUnit AttackTarget = new HateUnit(null,0);
			foreach(HateUnit unit in bc.HateList)
			{
				if (bc.Distance(unit.HatedMobile) < 40*40 && !unit.HatedMobile.Dead)
				{
					if (bc.Distance(unit.HatedMobile) < bc.Distance(AttackTarget.HatedMobile) && unit.Hate > AttackTarget.Hate |
						bc.Distance(unit.HatedMobile) == bc.Distance(AttackTarget.HatedMobile) && unit.Hate > AttackTarget.Hate )
					{
						AttackTarget.HatedMobile = unit.HatedMobile;
					}
				}
				else
				{
					AttackTarget.HatedMobile = null;
				}
			}
			return AttackTarget.HatedMobile;
		}
		public static void OnCastCower(BaseAbility ba, Mobile c)
		{
			foreach(Mobile target in c.KnownObjects)
			{
				if( target.Distance( c ) < 5 * 5)
				{
					HateUnit Threat;
					for(int i=0; (target as BaseCreature).HateList.Count > i;i++)
					{
						int amount=0;
						Threat = (HateUnit)(target as BaseCreature).HateList[i];
						if( Threat.HatedMobile == c ) 
						{
							switch (ba.Id)
							{
								case 9892: //Rank 3
								{
									amount = Utility.Random(c.Level, (int)(c.Level*1.5));
									break;
								}
								case 9000: //Rank 2
								{
									amount = Utility.Random(c.Level/2, c.Level);
									break;
								}
								case 8998: //Rank 1 
								{
									amount = Utility.Random(c.Level/3, (int)(c.Level/1.5));
									break;
								}
							}
							Threat.Hate = amount;//amount threat
							(target as BaseCreature).HateList[i] = Threat;//lowering threat
						}
					}
					if ( target.InCombat )
					{
						target.AttackTarget = (ChooseTarget( (target as BaseCreature)));
						if(target.AttackTarget != null) target.BeginCombatWith(target.AttackTarget);
					}
				}
			}
		}		
		#endregion
		#region DireBearForm  100%
		public static void OnCastDireBearForm(BaseAbility ba, Mobile c)
		{
			int bonus = 0;
			int critbonus = 0;
			int critbonus2 = (int)((c as Character).BaseCritChance);
			if ( c.HaveTalent( Talents.SharpenedClaws ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.SharpenedClaws );
				critbonus2 += (int)((ae.S1*(c as Character).BaseCritChance)/100);
			}
			if ( c.HaveTalent( Talents.Furor ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.Furor );
				int roll = Utility.Random(100);
				if(roll < ae.S1)
				{
					c.GainMana(c,100);
				}

			}
			if ( c.HaveTalent( Talents.PrimalFury ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.PrimalFury );
				int roll = Utility.Random(100);
				if(roll < ae.H)
				{
					critbonus = 1;
				}
			}

			if ( c.HaveTalent( Talents.StrengthOfTheWild ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.StrengthOfTheWild );
 
				bonus=ae.S1;
 
			}
 
			AuraEffect st = (AuraEffect)ba;
			Bear aura = new Bear();
			aura.OnRelease = new Aura.AuraReleaseDelegate( OnCastDireBearFormEnded );   
			aura.AttackPowerBonus = 120;
			aura.HealthBonus = 600;
			aura.StrPercentBonus = bonus;
			aura.ArmorFromItemsPercentIncrease=360f;
			aura.PhysicalCriticalBonus = critbonus2;
			if(critbonus == 1) { aura.OnCriticalHitDone = 123; c.Triggers[ 123 ] = new Mobile.OnCriticalHitDoneTrigger( OnCrit );}
			c.AddAura( st, aura );
			if((c as Character).Race == Races.NightElf)
			{
				c.Polymorph( 0x8E9 );
			}
			else if((c as Character).Race == Races.Tauren)
			{
				c.Polymorph( 0x8F1 );
			} 
			c.BaseMana = 100;
			
			(c as Character).BaseRage = 100;
			(c as Character).Rage = 0;
			Mana2Rage(c as Character);
			(c as Character).ChangeBattleStance( StandStates.FireBearForm );
		}
		public static void OnCastDireBearFormEnded( Mobile c )
		{
			c.CancelPolymorph(); (c as Character).ChangeBattleStance( StandStates.Standing );(c as Character).SwitchManatypeToMana();	
 
			c.ManaUpdate( c );
		} 
	
 
 
		#endregion
		#region Enrage 100%
		public static void OnCastEnrage(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			int duration = (st as SpellTemplate).Duration(c);
			float armormalus = 75f;
			if ( c.HaveTalent( Talents.ImprovedEnrage ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedEnrage );
				duration -= ae.S2;
				switch (c.TalentLevel(Talents.ImprovedEnrage))
				{
					case 1 : { armormalus -= 5;break; }
					case 2 : { armormalus -= 14;break; }
				}
				
			}
			Enrage aura = new Enrage(st as SpellTemplate,c,duration,st.T1);
			aura.ArmorPercentMalus = armormalus;
			c.AddAura( st, aura );
 
		}		
		#endregion
		#region FelineGrace 0%
		public static void OnCastFelineGrace(BaseAbility ba, Mobile c){}		
		#endregion
		#region ChallengingRoar 100%
		public static void OnCastChallengingRoar(BaseAbility ba, Mobile c)
		{
			
			AuraEffect st = ( AuraEffect )ba; 
			Character ch = c as Character; 
			foreach (Object o in ch.Player.KnownObjects) 
			{ 
				if ((o is Mobile) && !(o is BaseSpawner)) 
				{ 
					Mobile around = (Mobile)o; 
					around.UpdateXYZ(); 
 
					if ( ( c.Distance( around ) < 250) && (around.Faction != c.Faction ) )
					{ 
						Aura aura = new Aura();
						aura.ForceAttackTo = c; 
						around.AddAura(st, aura);
						
					} 
				} 
			} 
		}
		
		#endregion
		#region Maul 100%
		public static void OnCastMaul(BaseAbility ba, Mobile c, Mobile target)
		{
			int dmg = c.AttackSwing( target );
			if ( dmg > 0 ) 
			{ 
				SpellTemplate st = (SpellTemplate)ba; 
				st.MakeDamage(c, target, SpellDamage.TypeS1); 
			} 
		}			
		#endregion
		#region Pounce 100%
		public static void OnCastPounce(BaseAbility ba, Mobile c, Mobile target)
		{
 
			if ((c.StandState == StandStates.Stealth))
			{
				SpellTemplate st = (SpellTemplate)ba; 
				st.ApplyDot( c, target, st.S1, st.T1, st.Duration( c )  ); 
				AuraEffect af = (AuraEffect)ba;
				Aura aura = new Aura();
				aura.ForceStun = true;
				target.AddAura(c,af,aura,true);
				target.AddComboPoint(c);
 
			}
		}			
		#endregion
		#region PounceBleed 100%
		public static void OnCastPounceBleed(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba; 
			st.ApplyDot( c, target, st.S1, st.T1, st.Duration( c )  ); 
 
		}			
		#endregion
		#region Prowl 100%
		public static void OnCastProwl(BaseAbility ba, Mobile c)
		{
 
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.OnRelease = new Aura.AuraReleaseDelegate( OnCastProwlEnded );
			c.Visible = InvisibilityLevel.Lesser;
			aura.SpeedModifier = (st.S2)/100;
			c.AddAura( st, aura );
			c.ChangeRunSpeed( c.RunSpeed );
			(c as Character).ChangeBattleStance( StandStates.CatForm & StandStates.Stealth);
		}
		public static void OnCastProwlEnded( Mobile c )
		{
			c.Visible = InvisibilityLevel.Visible;
 
			(c as Character).ChangeBattleStance( StandStates.CatForm );
		}
 
		#endregion
		#region Ravage 100%
		public static void OnCastRavage(BaseAbility ba, Mobile c, Mobile target)
		{
			int bonus = (int)(c as Character).BaseCritChance;
			if ( c.HaveTalent( Talents.ImprovedRavage ) )
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedRavage );
				bonus += (int)((ae.S1*(c as Character).BaseCritChance)/100);
			}
			int dmg = c.AttackSwing( target );
			if ( dmg > 0 ) 
			{ 
				SpellTemplate st = (SpellTemplate)ba; 
				st.MakeDamage(c, target, SpellDamage.TypeS1);
				AuraEffect af = (AuraEffect)ba;
				Ravage aura = new Ravage();
				aura.ForceStun = true;
				aura.PhysicalCriticalBonus = bonus;
				target.AddAura(c,af,aura,true);
 
			} 
 
		}		
		#endregion
		#region Shred 100%
		public static void OnCastShred(BaseAbility ba, Mobile c, Mobile target)
 
		{
			int dmg = c.AttackSwing( target );
			if ( dmg > 0 ) 
			{ 
				SpellTemplate st = (SpellTemplate)ba; 
				st.MakeDamage(c, target, SpellDamage.TypeS2); 
				target.AddComboPoint(c);
			} 
 
 
		}		
		#endregion
		#region TrackHumanoids 100%
		public static void OnCastTrackHumanoids	(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			Server.Aura.SetDetectCreature(TrackableCreatures.Humanoid,c);
			Aura a = new Aura();
			c.AddAura(st,a);
			
		}			
		#endregion
		#region TravelForm 100%
		public static void OnCastTravelForm(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.OnRelease = new Aura.AuraReleaseDelegate( OnCastTravelFormEnded );   
			aura.AttackPowerBonus = 40;
			aura.SpeedModifier = 1.4f;
			c.AddAura( st, aura );   
			c.ChangeRunSpeed( c.RunSpeed );
			c.Polymorph( 0x278 ); 
			(c as Character).ChangeBattleStance( StandStates.TravelForm );
		}			
		public static void OnCastTravelFormEnded( Mobile c )
		{
			c.CancelPolymorph();
			c.ChangeRunSpeed( c.RunSpeed );
			(c as Character).ChangeBattleStance( StandStates.Standing );
		} 
		#endregion	
		#region PrimalFuryCrit - needed for PrimalFuryTalent :)
		public static void OnCrit( Mobile m, Mobile target, BaseAbility ae )
		{        
			m.GainMana(m,50);
		}
		#endregion
		#region BearForm 100%
		public static void OnCastBearForm(BaseAbility ba, Mobile c)
		{
			
			int bonus = 0;
			float armor = 180f;
			int critbonus = 0;
			int critbonus2 = (int)((c as Character).BaseCritChance);
			if ( c.HaveTalent( Talents.SharpenedClaws ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.SharpenedClaws );
				critbonus2 += (int)((ae.S1*(c as Character).BaseCritChance)/100);
			}
			if ( c.HaveTalent( Talents.Furor ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.Furor );
				int roll = Utility.Random(100);
				if(roll < ae.S1)
				{
					c.GainMana(c,100);
				}

			}
			if ( c.HaveTalent( Talents.ThickHide ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ThickHide );
				armor = (float)(armor + ((ae.S1*armor)/100));

			}
			if ( c.HaveTalent( Talents.PrimalFury ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.PrimalFury );
				int roll = Utility.Random(100);
				if(roll < ae.H)
				{
					critbonus = 1;
				}
			}
			if ( c.HaveTalent( Talents.StrengthOfTheWild ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.StrengthOfTheWild );
 
				bonus=ae.S1;
 
			}
 
			AuraEffect st = (AuraEffect)ba;
			Bear aura = new Bear();
			aura.OnRelease = new Aura.AuraReleaseDelegate( OnCastBearFormEnded );   
			aura.AttackPowerBonus = 30;
			aura.HealthBonus = 20;
			aura.StrPercentBonus = bonus;
			aura.ArmorFromItemsPercentIncrease=armor;
			aura.PhysicalCriticalBonus = critbonus2;
			if(critbonus == 1) { aura.OnCriticalHitDone = 123; c.Triggers[ 123 ] = new Mobile.OnCriticalHitDoneTrigger( OnCrit );}
			c.AddAura( st, aura );
			if((c as Character).Race == Races.NightElf)
			{
				c.Polymorph( 0x8E9 );
			}
			else if((c as Character).Race == Races.Tauren)
			{
				c.Polymorph( 0x8F1 );
			} 
			(c as Character).SwitchManatypeToRage();	
			(c as Character).BaseRage = 100;
			(c as Character).Rage = 100;
			c.ManaUpdate( c );
			(c as Character).ChangeBattleStance( StandStates.BearForm );
		}		
		public static void OnCastBearFormEnded( Mobile c )
		{
			c.CancelPolymorph();(c as Character).ChangeBattleStance( StandStates.Standing );(c as Character).SwitchManatypeToMana();	
 
			c.ManaUpdate( c );
		} 
		
		#endregion
		#region FrenziedRegeneration  100%
		public static void OnCastFrenziedRegeneration(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba; 
			FrenziedAura a = new FrenziedAura(st as SpellTemplate, c); 
			c.AddAura(st,a);
		}			
		#endregion
		#region Growl 100%
		public static void OnCastGrowl(BaseAbility ba, Mobile c, Mobile target)
		{
			if ( target.AttackTarget != c)
			{
				if ( target is BaseCreature)
				{
					HateUnit hu;
					for( int i=0; (target as BaseCreature).HateList.Count > i; i++ )
					{
						hu = (HateUnit)(target as BaseCreature).HateList[i];
						hu.Hate = Utility.Random(target.Level);
						(target as BaseCreature).HateList[i] = hu;
 
					}
					if( ChooseTarget((target as BaseCreature)) == c )target.BeginCombatWith( c );
				}
			}
		}		
		#endregion
		#region AquaticForm 100%
		public static void OnCastAquaticForm(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.OnRelease = new Aura.AuraReleaseDelegate( OnCastAquaticFormEnded );   
			aura.SwimSpeedModifier = 1.5f;
			c.AddAura( st, aura ); 
			DruidSpells.UpdateSwimSpeed(c);
			c.Polymorph( 0x97C ); 
			(c as Character).ChangeBattleStance( StandStates.AquaticForm );
		}		
 
		public static void OnCastAquaticFormEnded( Mobile c )
		{
			DruidSpells.UpdateSwimSpeed(c);
			c.CancelPolymorph();
			(c as Character).ChangeBattleStance( StandStates.Standing );
		} 
 
		#endregion
		#region Mangle 100% scripted
		public static void OnCastMangle(BaseAbility ba, Mobile c, Mobile target)
		{
			ComboSpellTemplate ct = (ComboSpellTemplate)ba;
			ct.ApplyDot( c, target, ct.S1, ct.T1, ct.Duration( c ) ); 
			AuraEffect ae = (AuraEffect)ba;
			Aura a = new Aura();
			a.ForceStun = true;
			target.AddAura(c,ae,a,true);
			(c as Character).StopAttacking();
		}			
		#endregion
		
		#endregion
 
		#region Balance
		#region EntanglingRoots 100% scripted right has bugs with apply dot - shows double dmg
		public static void OnCastEntanglingRoots(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect af = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.ForceRoot = true;
			target.AddAura(c,af,aura,true);
			(af as SpellTemplate).ApplyDot(c,target,af.S2,af.T1,af.Duration(c));
 
		}		
		#endregion
		#region Moonfire 100% 
 
		public static void OnCastMoonfire(BaseAbility ba, Mobile c, Mobile target)
		{
 
			SpellTemplate st = (SpellTemplate)ba;
			int damage = st.S1;
			int damage2 = st.S2;
			if ( c.HaveTalent( Talents.ImprovedMoonfire ) )
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedMoonfire );
				MoonFireTalent aura = new MoonFireTalent();
				aura.ArcaneCriticalBonus = ae.S1;
				aura.ArcaneDamageIncrease = ae.S1;
				c.AddAura(ae,aura);
 
			}
			if ( c.HaveTalent( Talents.Moonfury ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.Moonfury );
				float single1 = 1+((float)ae.S1)/100;
				float single2 = 1+((float)ae.S2)/100;
				damage = (int)(st.S1*single1);
				damage2 = (int)(st.S2*single2);
 
			}
 
 
 
			st.MakeDamage( c, target, damage2);
			st.ApplyDot( c, target, damage, st.T1, st.Duration( c ) );	
 
		}		
		#endregion
		#region Starfire 100% 
		public static void OnCastStarfire(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			int damage = st.S1;
			if ( c.HaveTalent( Talents.ImprovedStarfire ) )
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedStarfire );
				float chance = ((float)ae.H)/100;
				int roll = Utility.Random( 100 );
				if(roll < chance) 
				{
					AuraEffect af = (AuraEffect) Abilities.abilities[16922];
					Aura aura = new Aura();
					aura.ForceStun = true;
					target.AddAura(c,af,aura,true);
				}
 
			}
			if ( c.HaveTalent( Talents.Moonfury ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.Moonfury );
				float single1 = 1+((float)ae.S1)/100;
				damage = (int)(st.S1*single1);
			}
			st.MakeDamage(c, target, damage);
 
		}	
 
		#endregion
		#region Wrath 100%
		public static void OnCastWrath(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			st.MakeDamage(c, target, SpellDamage.TypeS1);
		}		
		#endregion
		#region TeleportMoonglade 100%
		public static void OnCastTeleportMoonglade(BaseAbility ba, Mobile c) // Made by SneakerXZ 
		{
			// Spell id is 18960, 19027;
			(c as Character ).Teleport( 7980.842285f, -2501.763428f, 487.576508f, 1 ); // Moonglade (X, Y, Z, MapId)
		}
 
		#endregion
		#region Thorns 100% scripted right has bugs with apply dot - shows double dmg
		public static void OnCastThorns(BaseAbility ba, Mobile c, Mobile target)
		{
 
 
			AuraEffect af = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.OnMeleeHit = 7001;//   id of the trigger
			c.AddAura(af, aura);
			c.Triggers[ 7001 ] = new Mobile.OnMeleeHitTrigger( OnThornsHit );
		}
		public static void OnThornsHit( Mobile m, Mobile target, AuraEffect ae )
		{        
 
 
			if ( m.HaveTalent( Talents.ImprovedThorns ) )
			{
				AuraEffect ab = (AuraEffect)m.GetTalentEffect( Talents.ImprovedThorns );
				int roll = Utility.Random( 100 );
				if(roll < ab.H) 
				{
					ab.MakeDamage(m,target,ae.S1);
				}
 
			}
			ae.MakeDamage(m,target,SpellDamage.TypeS1);
		}			
		#endregion
		#region Hibernate 100% scripted right only core bug!
		public static void OnCastHibernate(BaseAbility ba, Mobile c, Mobile target)
		{
 
			// this check should be added on the core
			//if((target.NpcType == (int)NpcTypes.Beast)||(target.NpcType == (int)NpcTypes.Dragonkin))
			//{
 
			AuraEffect st = (AuraEffect)ba;
			Hibernate aura = new Hibernate();					
			aura.ForceStun = true;
			aura.OnMeleeHit = 6666;
			aura.OnSpellHit = 6667;
			target.AddAura(c,st, aura,true);
			target.Triggers[ 6666 ] = new Mobile.OnMeleeHitTrigger( OnSleepHit );
			target.Triggers[ 6667 ] = new Mobile.OnSpellHitTrigger( OnSleepHit );
				
			//}
 
		}
		public static void OnSleepHit( Mobile m, Mobile target, AuraEffect ae )
		{        
			
			target.ReleaseAura( ae );	
			
		}	
		#endregion			
		#endregion
 
		#region Restoration
		#region HealingTouch 100% scripted
		public static void OnCastHealingTouch(BaseAbility ba, Mobile c, Mobile target)
		{
            SpellTemplate st = (SpellTemplate)ba;
			int healamount = st.S1;
			if ( c.HaveTalent( Talents.GiftOfNature ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.GiftOfNature );
				healamount += ((ae.S1*healamount)/100);
			}
			st.Heal(c,target,healamount);
		}			
		#endregion
		#region Regrowth 100% scripted
		public static void OnCastRegrowth(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			int healamount = st.S1;
			int healamount2 = st.S2;
			if ( c.HaveTalent( Talents.GiftOfNature ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.GiftOfNature );
				healamount += ((ae.S1*healamount)/100);
				healamount2 += ((ae.S1*healamount2)/100);
			}
			st.Heal(c,target,healamount);
			AuraEffect af = (AuraEffect)ba;
			HotAura aura = new HotAura(st,c,c,healamount2, af.Duration( c ), af.T2);
			target.AddAura(af,aura);
		}		
		#endregion
		#region Rejuvenation 100% scripted
		public static void OnCastRejuvenation(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect af = (AuraEffect)ba;
			int healamount = af.S2;
			if ( c.HaveTalent( Talents.GiftOfNature ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.GiftOfNature );
				healamount += ((ae.S1*healamount)/100);

			}
			if ( c.HaveTalent( Talents.ImprovedRejuvenation ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedRejuvenation );
				healamount += ((ae.S1*healamount)/100);

			}
			HotAura aura = new HotAura(af,c,c,healamount, af.Duration( c ), af.T2);
			target.AddAura(af,aura);
		}		
		#endregion
		#region AbolishPoison 100% scripted
		public static void OnCastAbolishPoison(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect af = (AuraEffect)ba;
			AbolishPoisonAura aura = new AbolishPoisonAura(target,c, af);
			target.AddAura(af, aura);
		}	
		public static void OnCastAbolishPoisonEffect(BaseAbility ba, Mobile c)
		{
			
			
		}	
		#endregion
		#region CurePoison 100% scripted
		public static void OnCastCurePoison(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			st.Dispel(DispelType.Poison, 1, target);
		}		
		#endregion
		#region MarkoftheWild 100% scripted
		public static void OnCastMarkoftheWild(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect af = (AuraEffect)ba;
			int strbonus = af.S2;
			int staminabonus = af.S2;
			int spiritbonus = af.S2;
			int iqbonus = af.S2;
			int frostbonus = af.S3;
			int firebonus = af.S3;
			int arcanebonus = af.S3;
			int holybonus = af.S3;
			int natbonus = af.S3;
			int shbonus = af.S3;
			int agbonus = af.S2;
			int armbonus = af.S1;
			if ( c.HaveTalent( Talents.ImprovedMarkOfTheWild ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedMarkOfTheWild );
				 strbonus += ((ae.S1*strbonus)/100);
				 staminabonus += ((ae.S1*staminabonus)/100);
				 spiritbonus += ((ae.S1*spiritbonus)/100);
				 iqbonus += ((ae.S1*iqbonus)/100);
				 frostbonus += ((ae.S1*frostbonus)/100);
				 firebonus += ((ae.S1*firebonus)/100);
				 arcanebonus += ((ae.S1*arcanebonus)/100);
				 holybonus += ((ae.S1*holybonus)/100);
				 natbonus += ((ae.S1*natbonus)/100);
				 shbonus += ((ae.S1*shbonus)/100);
				 agbonus += ((ae.S1*agbonus)/100);
				 armbonus += ((ae.S1*armbonus)/100);
			}
			AuraOfWild aura = new AuraOfWild();
			aura.StrBonus = strbonus;
			aura.StaminaBonus = staminabonus;
			aura.SpiritBonus = spiritbonus;
			aura.IQBonus = iqbonus;
			aura.FrostResistanceBonus = frostbonus;
			aura.ArcaneResistanceBonus = arcanebonus ;
			aura.FireResistanceBonus = firebonus;
			aura.HolyResistanceBonus = holybonus;
			aura.NatureResistanceBonus = natbonus;
			aura.ShadowResistanceBonus = shbonus;
			aura.AgBonus = agbonus;
			aura.ArmorBonus = armbonus;
			target.AddAura(af,aura);
 
		}			
		#endregion
		#region Rebirth 100% 
		public static void OnCastRebirth(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba; 
			switch(st.Id)
			{
				case 20484 : {target.HitPoints = 400;target.Mana = 700;( c as Character ).ConsumeItemByIdUpTo( "MapleSeed", 1 );break; }
				case 20739 : {target.HitPoints = 750;target.Mana = 1200;( c as Character ).ConsumeItemByIdUpTo( "StranglethornSeed", 1 );break;} 
				case 20742 : {target.HitPoints = 1100;target.Mana = 1700;( c as Character ).ConsumeItemByIdUpTo( "AshwoodSeed", 1 );break;}
				case 20747 : {target.HitPoints = 1600;target.Mana = 2200;( c as Character ).ConsumeItemByIdUpTo( "HornbeamSeed", 1 );break;}
				case 20748 : {target.HitPoints = 2200;target.Mana = 2800;( c as Character ).ConsumeItemByIdUpTo( "Ironwood", 1 );break;}
			}
			
			target.HitPointsUpdate(target);
			target.ManaUpdate(target);
			(target as Character).ReclaimCorps();
		}		
 
		#endregion
		#region RemoveCurse 100%
		public static void OnCastRemoveCurse(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			st.Dispel(DispelType.Curse, 1, target);
		}
		#endregion
		#region Tranquility 100%
		public static void OnCastTranquility(BaseAbility ba, Mobile c)
		{
			foreach(Mobile around in (c as Character).GroupMembers.Members)
			{
				if( c.Distance(around) < 80 * 80 && !around.Dead )
				{
					SpellTemplate st = (SpellTemplate)ba; 
					int healamount = st.S1;
					if ( c.HaveTalent( Talents.GiftOfNature ) ) 
					{
						AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.GiftOfNature );
						healamount += ((ae.S1*healamount)/100);

					}
					st.Heal(c,around,SpellDamage.TypeS1); 
				}
			}
		}
		#endregion
		#region GiftoftheWild 100% 
		public static void OnCastGiftoftheWild(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect af = (AuraEffect)ba;
			int strbonus = af.S2;
			int staminabonus = af.S2;
			int spiritbonus = af.S2;
			int iqbonus = af.S2;
			int frostbonus = af.S3;
			int firebonus = af.S3;
			int arcanebonus = af.S3;
			int holybonus = af.S3;
			int natbonus = af.S3;
			int shbonus = af.S3;
			int agbonus = af.S2;
			int armbonus = af.S1;
			if ( c.HaveTalent( Talents.ImprovedMarkOfTheWild ) ) 
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedMarkOfTheWild );
				strbonus += ((ae.S1*strbonus)/100);
				staminabonus += ((ae.S1*staminabonus)/100);
				spiritbonus += ((ae.S1*spiritbonus)/100);
				iqbonus += ((ae.S1*iqbonus)/100);
				frostbonus += ((ae.S1*frostbonus)/100);
				firebonus += ((ae.S1*firebonus)/100);
				arcanebonus += ((ae.S1*arcanebonus)/100);
				holybonus += ((ae.S1*holybonus)/100);
				natbonus += ((ae.S1*natbonus)/100);
				shbonus += ((ae.S1*shbonus)/100);
				agbonus += ((ae.S1*agbonus)/100);
				armbonus += ((ae.S1*armbonus)/100);
			}
			AuraOfWild aura = new AuraOfWild();
			aura.StrBonus = strbonus;
			aura.StaminaBonus = staminabonus;
			aura.SpiritBonus = spiritbonus;
			aura.IQBonus = iqbonus;
			aura.FrostResistanceBonus = frostbonus;
			aura.ArcaneResistanceBonus = arcanebonus ;
			aura.FireResistanceBonus = firebonus;
			aura.HolyResistanceBonus = holybonus;
			aura.NatureResistanceBonus = natbonus;
			aura.ShadowResistanceBonus = shbonus;
			aura.AgBonus = agbonus;
			aura.ArmorBonus = armbonus;
			target.AddAura(af,aura);
 
		}			
		#endregion
		#endregion
 
		#region TalentSpells
		#region Nature'sGrasp 100%  
		public static void OnCastNaturesGrasp(BaseAbility ba, Mobile c)
		{
			AuraEffect ae = (AuraEffect)ba;
			NatureGrasp aura = new NatureGrasp();
			aura.OnMeleeHit = 222;
			aura.OnSpellHit = 223;
			c.AddAura(ae,aura);
			c.Triggers[ 222 ] = new Mobile.OnMeleeHitTrigger( OnNatureHit );
			c.Triggers[ 223 ] = new Mobile.OnSpellHitTrigger( OnNatureHit );
		}		
		public static void OnNatureHit( Mobile m, Mobile target, AuraEffect ae )
		{   
			int chance = 35;
			if ( m.HaveTalent( Talents.ImprovedNaturesGrasp ) ) 
			{
				AuraEffect ab = (AuraEffect)m.GetTalentEffect( Talents.ImprovedNaturesGrasp );
				chance += ab.S1;
			}
			int roll = Utility.Random(100);
			int id=0;
			if(roll < chance)
			{
				switch((ae as SpellTemplate).Id)
				{
					case 16689 : {id=339;break; } 												
					case 16810 : {id=1062;break; } 	
					case 16811 : {id=5195;break; } 	
					case 16812 : {id=5196;break; } 	
					case 16813 : {id=9852;break; } 	
					case 17329 : {id=9853;break; } 	

				}
				AuraEffect af = (AuraEffect) Abilities.abilities[id];
				Aura aura = new Aura();
				aura.ForceRoot = true;
				target.AddAura(m,af,aura,true);
				(af as SpellTemplate).ApplyDot(m,target,af.S2,af.T2,af.Duration(m));
 
			}
		}
		
		#endregion
		#region Innervate scripted should work
		public static void OnCastInnervate(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect af =(AuraEffect)ba;
			Innervate aura = new Innervate();
			aura.ManaRegenerationModifier = (af.S1/100);
			aura.ManaRegenWhileCastingPercent = af.S2;
			target.AddAura(af,aura);

		}
		#endregion
		#region Huricane 100% by bovie
		
		public static void OnCastHurricane(BaseAbility ba, Mobile c)
		{

			AuraEffect af = (AuraEffect)ba;
			BaseCreature bc = new Server.Creatures.Rabbit();
			bc.Freeze = true;
			bc.AIEngine = null;
			bc.GodMode = true;
			bc.Visible = InvisibilityLevel.GM;
			World.Add(bc, c.X, c.Y, c.Z, c.MapId);
			c.ChannelStart(bc,af.Id,af.Duration(c));
			HurricaneEffect hurricaneeffect = new HurricaneEffect(af, bc, c, af.T1, af.Duration(c),af);
			hurricaneeffect.Start();
			c.ChannelStart(bc,af.Id,af.Duration(c));
		
		}			
			
				
		#endregion
		#region FeralCharge 100% scripted
		public static void OnCastFeralCharge(BaseAbility ba, Mobile c, Mobile target)
		{
			if (c.Running == false) c.Running = true;
			target.UpdateXYZ();
			c.RunSpeed *=2;
			target.ChangeRunSpeed( target.RunSpeed);
			c.MoveTo(target.X,target.Y,target.Z);
			c.RunSpeed /=2;
			target.ChangeRunSpeed( target.RunSpeed);
			Aura aura = new Aura(); 
			aura.ForceRoot = true; 
			target.AddAura(c,(AuraEffect)Abilities.abilities[19675],aura,true); 
			target.InterruptCasting();
		}
		#endregion
		#endregion
 
		#endregion

		#region Work In Progress
		#region Feral Combat
		
		#region TreeForm No Need To Script - not ingame now maybe later Blizz will add it
		public static void OnCastTreeForm(BaseAbility ba, Mobile c){}
		public static void OnCastTreeFormEffect(BaseAbility ba, Mobile c){}
		#endregion
		#endregion
 
		#region Balance
		#region FaerieFire 90% should not be able to go stealth or invisibility
		public static void OnCastFaerieFire(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect af =(AuraEffect)ba;
			Aura aura = new Aura();
			aura.ArmorMalus = af.S1;
			target.AddAura(af,aura);
			// avoid stealth and unvisible
		}			
		#endregion
		
		#region SootheAnimal 0%
		public static void OnCastSootheAnimal(BaseAbility ba, Mobile c, Mobile target){}		
		#endregion	
		#region Barkskin  90% need to slow all noninstant spells by 1sec
		public static void OnCastBarkskin(BaseAbility ba, Mobile c)
		{
			AuraEffect st = (AuraEffect)ba;
			Barkskin aura = new Barkskin();
			aura.AttackSpeedModifier = 0.8f;
			aura.MeleePercentDamageTakenReduction=20f;
			c.AddAura(st,aura);
		}	
		public static void OnCastBarkskinEffect(BaseAbility ba, Mobile c){}
		#endregion
		#endregion
 
		#region TalentSpells
		
	
		#region FaerieFire(Bear) 90% should not be able to go stealth or invisibility
		public static void OnCastFaerieFireBear(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect af =(AuraEffect)ba;
			Aura aura = new Aura();
			aura.ArmorMalus = af.S1;
			target.AddAura(c,af,aura,true);
			// avoid stealth and unvisible
		}			
		#endregion
		#region FaerieFire(Cat) 90% should not be able to go stealth or invisibility
		public static void OnCastFaerieFireCat(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect af =(AuraEffect)ba;
			Aura aura = new Aura();
			aura.ArmorMalus = af.S1;
			target.AddAura(c,af,aura,true);
			// avoid stealth and unvisible
		}		
		#endregion
		
		#region OmenOfClarity 0% yet
		#endregion
		
		#endregion
		#endregion
	}
}