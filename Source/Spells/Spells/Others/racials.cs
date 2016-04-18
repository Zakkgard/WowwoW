using System;
using Server;
using Server.Items;
using HelperTools;
using System.Collections;

namespace Server
{

	public class RacesSpecialSpells
	{
		#region Auras
		public class WarStompAura : Aura
		{
			public WarStompAura()
			{
				
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
			private AuraEffect auraEffect; 
		}
		public class AxeSpecializationAura : Aura
		{
			// Methods
			public AxeSpecializationAura()
			{
			}
			// Properties
			public override int SkillBonus
			{
				get
				{
					return this.skillBonus;
				}
				set
				{
					this.skillBonus = value;
				}
			}
			public override int SkillId
			{
				get
				{
					return this.skillId;
				}
				set
				{
					this.skillId = value;
				}
			}
			// Fields
			private int skillBonus;
			private int skillId;
		}

		public class MaceSpecializationAura : Aura
		{
			// Methods
			public MaceSpecializationAura()
			{
			}
			// Properties
			public override int SkillBonus
			{
				get
				{
					return this.skillBonus;
				}
				set
				{
					this.skillBonus = value;
				}
			}
			public override int SkillId
			{
				get
				{
					return this.skillId;
				}
				set
				{
					this.skillId = value;
				}
			}
			// Fields
			private int skillBonus;
			private int skillId;
		}

		public class SwordSpecializationAura : Aura
		{
			// Methods
			public SwordSpecializationAura()
			{
			}
			// Properties
			public override int SkillBonus
			{
				get
				{
					return this.skillBonus;
				}
				set
				{
					this.skillBonus = value;
				}
			}
			public override int SkillId
			{
				get
				{
					return this.skillId;
				}
				set
				{
					this.skillId = value;
				}
			}
			// Fields
			private int skillBonus;
			private int skillId;
		}

		public class ThrowingSpecializationAura : Aura
		{
			// Methods
			public ThrowingSpecializationAura()
			{
			}
			// Properties
			public override int SkillBonus
			{
				get
				{
					return this.skillBonus;
				}
				set
				{
					this.skillBonus = value;
				}
			}
			public override int SkillId
			{
				get
				{
					return this.skillId;
				}
				set
				{
					this.skillId = value;
				}
			}
			// Fields
			private int skillBonus;
			private int skillId;
		}

		public class GunSpecializationAura : Aura
		{
			// Methods
			public GunSpecializationAura()
			{
			}
			// Properties
			public override int SkillBonus
			{
				get
				{
					return this.skillBonus;
				}
				set
				{
					this.skillBonus = value;
				}
			}
			public override int SkillId
			{
				get
				{
					return this.skillId;
				}
				set
				{
					this.skillId = value;
				}
			}
			// Fields
			private int skillBonus;
			private int skillId;
		}

		public class CultivationAura : Aura
		{
			// Methods
			public CultivationAura()
			{
			}
			// Properties
			public override int SkillBonus
			{
				get
				{
					return this.skillBonus;
				}
				set
				{
					this.skillBonus = value;
				}
			}
			public override int SkillId
			{
				get
				{
					return this.skillId;
				}
				set
				{
					this.skillId = value;
				}
			}
			// Fields
			private int skillBonus;
			private int skillId;
		}
		
		public class EngineeringSpecializationAura : Aura
		{
			// Methods
			public EngineeringSpecializationAura()
			{
			}
			// Properties
			public override int SkillBonus
			{
				get
				{
					return this.skillBonus;
				}
				set
				{
					this.skillBonus = value;
				}
			}
			public override int SkillId
			{
				get
				{
					return this.skillId;
				}
				set
				{
					this.skillId = value;
				}
			}
			// Fields
			private int skillBonus;
			private int skillId;
		}

		public class Cannibalize : Aura 
		{ 
			// Methods 
			public Cannibalize(AuraEffect st, Mobile c, int dur, int freq)
			{ 
				caster = c;
				this.auraEffect = (AuraEffect)st; 
				base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicCannibalizeEffect), dur, freq); 
			} 

			public void PeriodicCannibalizeEffect() 
			{ 
				foreach(Mobile eat in caster.KnownObjects)
				{
					if(eat.Dead && caster.Distance(eat)<5*5)
					{
						caster.HitPoints = (int)(caster.HitPoints+caster.HitPoints*0.07);
					}
				}
			} 

			// Properties 
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
			private Mobile caster;
			private AuraEffect auraEffect; 
		} 

		#endregion

		#region Dwarven
		#region 2481   Find Treasure Passive
		public static void OnCastFindTreasure(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura(); 
			//aura.FindMinirals = true;
			caster.AddPermanentAura(ae, aura); 
		}
		#endregion
		#region Stoneform 20594 
		public static void OnCastStoneform(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura(); 
			aura.ImmunePoison=true;
			aura.ImmuneDisease=true;
			//aura.ImmuneBleed=true;
			aura.ArmorPercentBonus = 5;
			aura.SpeedMalus = 70;
			caster.AddAura(ae, aura); 
		}
		#endregion
		#region Frost Resistance 20596 Passive
		public static void OnCastFrostResistance(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura(); 
			aura.FrostResistanceBonus = 10;
			caster.AddPermanentAura(ae, aura); 
		}
		#endregion
		#region  Gun Specialization 20595  Passive
		public static void OnCastGunSpecialization(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura(); 
			aura.SkillBonus = (int)ae.S1;
			aura.SkillId = (int)GunSkill.SkillId;
			caster.AddPermanentAura(ae, aura); 
		}
		#endregion
		#endregion

		#region Tauren 
		#region  War Stomp 20549 
		public static void OnCastWarStomp(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			int i=0;
			foreach(Mobile mob in caster.KnownObjects)
			{
				if(caster.Distance(mob)<8*8 && !mob.Dead && mob.Faction != caster.Faction)
				{
					if(i>5)break;//5 enemies
					WarStompAura aura = new WarStompAura(); 
					aura.ForceStun=true;
					mob.AddAura(caster,ae,aura,true);
					i++;
				}
			}
		}
		#endregion
		#region Nature Resistance 20551 Passive
		public static void OnCastNatureResistance(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura(); 
			aura.NatureResistanceBonus = 10;
			caster.AddPermanentAura(ae, aura); 
		}
		#endregion
		#region Cultivation 20552 Passive
		public static void OnCastCultivation(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			CultivationAura aura = new CultivationAura(); 
			aura.SkillBonus = (int)ae.S1;
			//aura.SkillId = (int)HerbalismSkill.SkillId;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#region Endurance 20550 Passive
		public static void OnCastEndurance(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura(); 
			aura.HealthPercentBonus = ae.S1;
			caster.AddPermanentAura(ae, aura); 
		}
		
		#endregion
		#endregion

		#region Orc 
		#region Command 21563 Passive
		public static void OnCastCommand(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			 
			foreach(Mobile around in caster.KnownObjects)
			{
				if(caster.Distance(around) < 80*80 && caster.Faction == around.Faction && !around.Dead)
				{
					if(around.Classe == Classes.Hunter | around.Classe == Classes.Warlock)
					{
						Aura aura = new Aura();
						aura.PetDamageBonus =5;
						around.AddAura(ae,aura,true);
					}
				}
			}
		}
		#endregion
		#region Hardiness 20573 Passive
		public static void OnCastHardiness(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura(); 
			//aura.StunResistancePercentBonus = 5;
			//aura.KnockoutResistancePercentBonus = 5;
			caster.AddAura(ae, aura); 
		}
		#endregion
		#region Blood Fury 20572
		public static void OnCastBloodFury(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)Abilities.abilities[23234];
			Aura aura = new Aura(); 
			aura.OnRelease = new Aura.AuraReleaseDelegate( OnCastBloodFuryEnded );
			aura.AttackPowerBonus = (int)(caster.AttackPower * 1.25);
			caster.AddAura(ae, aura); 
		}
		public static void OnCastBloodFuryEnded( Mobile caster)
		{
			AuraEffect af = (AuraEffect)Abilities.abilities[23230];
			Aura aura = new Aura();
			aura.AttackPowerMalus = (int)(caster.AttackPower * 0.75);
			caster.AddAura(af, aura); 
		}
		#endregion
		#region Axe Specialization 20574 Passive
		public static void OnCastAxeSpecialization(BaseAbility ba, Mobile caster)
		{
				AuraEffect ae = (AuraEffect) ba;
				AxeSpecializationAura aura = new AxeSpecializationAura();
				aura.SkillBonus = (int)ae.S1;
				aura.SkillId = (int)AxeSkill.SkillId;
				caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#endregion

		#region NightElf
		#region Shadowmeld 20580
		public static void OnCastShadowmeld(BaseAbility ba, Mobile caster)
		{

		}
		#endregion
		#region ShadowmeldPassive  Passive 21009
		public static void OnCastShadowmeldPassive(BaseAbility ba, Mobile caster)
		{

		}
		#endregion
		#region Wisp Spirit
		public static void OnCastWispSpirit(BaseAbility ba, Mobile caster)
		{
			//this spell include in core;
		}

		#endregion
		#region Quickness 20582
		public static void OnCastQuickness(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.DodgeBonus = ae.S1;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#endregion

		#region Undead
		#region Underwater Breathing Passive
		public static void OnCastUnderwaterBreathing(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura();
//			aura.UnderwaterBreathingPercentBonus = 300;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#region  Will of the Forsaken 7744   
		public static void OnCastWillOfTheForsaken(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura(); 
			aura.ImmuneToFear=true;
			//aura.ImmuneToSleep=true;
			//aura.ImmuneToCharm = true;
			caster.AddAura(ae, aura); 
		}
		#endregion
		#region Shadow Resistance Passive 20579
		public static void OnCastShadowResistance(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura(); 
			aura.ShadowResistanceBonus = ae.S1;
			caster.AddPermanentAura(ae, aura); 
		}
		#endregion
		#region Cannibalize 20577
		public static void OnCastCannibalize(BaseAbility ba, Mobile caster)
		{
			AuraEffect af = (AuraEffect)ba;
			Cannibalize aura = new Cannibalize(af, caster, 100001, 2001);
			caster.AddAura(af, aura);
		}
		#endregion
		#endregion

		#region Troll
		#region Berserking 20554 bovie check this spell plz
		public static void OnCastBerserking(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.CastingSpeedModifier=ae.S2;
			aura.AttackSpeedModifier=ae.S2;
			aura.DamageTakenModifier=ae.S1;
			caster.AddAura(ae, aura);
		}
		#endregion
		#region Regeneration 20555   Passive
		public static void OnCastRegeneration(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.HealthRegenerationModifier=ae.S1;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#region Beast Slaying Passive 20557   
		public static void OnCastBeastSlaying(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae= (AuraEffect)ba;
			Aura aura = new Aura();
			aura.AttackPowerBonusAgainsBeast = ae.S1;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#region Throwing Specialization 20558 Passive
		public static void OnCastThrowingSpecialization(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect) ba;
			ThrowingSpecializationAura aura = new ThrowingSpecializationAura();
			aura.SkillBonus = (int)ae.S1;
			aura.SkillId = (int)ThrowsSkill.SkillId;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#endregion

		#region Gnome 
		#region Escape Artist 20589
		public static void OnCastEscapeArtist(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect) ba;
			Aura aura = new Aura();
			aura.ImmuneToImmobilization=true;
			caster.AddAura(ae, aura);
		}
		#endregion
		#region Expansive Mind 20591
		public static void OnCastExpansiveMind(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect) ba;
			Aura aura = new Aura();
			aura.IQPercentBonus = ae.S1;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#region EngineeringSpecialization 20593   
		public static void OnCastEngineeringSpecialization(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect) ba;
			EngineeringSpecializationAura aura = new EngineeringSpecializationAura();
			aura.SkillBonus = (int)ae.S1;
			//aura.SkillId = (int)EngineeringSkill.SkillId;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#region Arcane Resistance 20592
		public static void OnCastArcaneResistance(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect) ba;
			Aura aura = new Aura();
			aura.ArcaneResistanceBonus = ae.S1;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#endregion

		#region Human
		#region Diplomacy 20599 Passive
		public static void OnCastDiplomacy(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect) ba;
			Aura aura = new Aura();
			//aura.ReputationBonus = 10;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#region Perception 20600 Passive
		public static void OnCastPerception(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect) ba;
			Aura aura = new Aura();
			//for complite this spell need some changes in core
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#region Sword Specialization 20597 Passive
		public static void OnCastSwordSpecialization(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect) ba;
			SwordSpecializationAura aura = new SwordSpecializationAura();
			aura.SkillBonus = (int)ae.S1;
			aura.SkillId = (int)SwordSkill.SkillId;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#region Mace Specialization Passive
		public static void OnCastMaceSpecialization(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect) ba;
			MaceSpecializationAura aura = new MaceSpecializationAura();
			aura.SkillBonus = (int)ae.S1;
			aura.SkillId = (int)MacesSkill.SkillId;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#region The Human Spirit 20598 Passive
		public static void OnCastTheHumanSpirit(BaseAbility ba, Mobile caster)
		{
			AuraEffect ae = (AuraEffect) ba;
			Aura aura = new Aura();
			aura.SpiritBonus=5;
			caster.AddPermanentAura(ae, aura);
		}
		#endregion
		#endregion
	}
}

