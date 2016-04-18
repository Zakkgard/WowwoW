//	Script modified by Paralon - 29/08/05 12:12:34
/* Last Update: 29 Aug 2005
 *
 * Added some talent bonuses but not tested
 * Flametongue; Frosbrand and Rockbitter are not supported yet
 *
 * Also add to Globals.cs (for example, after "World.HttpServerPort = 8080;"):
 * TotemsTimer.TotemsList = new ArrayList();
 * new TotemsTimer(1001).Start();
 * Without this string totems won't work
 *if(HelperTools.Utility.Random(0,1) == 1)

 */

using System;
using Server;
using Server.Creatures;
using HelperTools;
using Server.Scripts;
using System.Collections;

#region BaseTotem
namespace Server.Creatures
{ 
	public enum TotemTarget
	{
		Friends,
		Enemy
	}
	public enum TotemType
	{
		Air,
		Earth,
		Fire, 
		Water
	}
 
	public class BaseTotems : BaseCreature
	{
		public int LifeTime;
		public int Delay;
		public int BaseDelay;
		public TotemType totemType;
 
		bool MakeFakeCast;
		ArrayList AffectedMobs;
		float Range;
		TotemTarget target;
		public Mobile Caster;
		int SpellID;
		SingleTargetSpellEffect effectHandler; 
 
		public BaseTotems() : base()
		{
			AffectedMobs = new ArrayList();
			Delay = 0;
			BaseDelay = 0;
		}

		public BaseTotems( Mobile caster, int lifetime, int _basedelay, float range, TotemType totemtype, TotemTarget Target, int SpellId, 
			SingleTargetSpellEffect spelleffect, bool Fake ) : base()
		{
			AffectedMobs = new ArrayList();
			Delay = 0;
			BaseDelay = 0;


			MakeFakeCast = Fake;
			Caster = caster;
			LifeTime = lifetime;
			//============================
			Delay = 0;
			BaseDelay = _basedelay;
			//============================
			Range = range;
			effectHandler = spelleffect;
			target = Target;
			SpellID = SpellId;
			totemType = totemtype;

			for(int i=0; i<caster.AdditionnalStates.Count; i++)
			{
				if (caster.AdditionnalStates[i] is BaseTotems)
				{
					BaseTotems bt = (BaseTotems)caster.AdditionnalStates[i];
					if (bt.totemType == totemType)
					{
						bt.LooseHits(bt, bt.BaseHitPoints);
						caster.AdditionnalStates.RemoveAt(i);
						i--;
					}
				}
			}
			caster.AdditionnalStates.Add(this);
 
			Level = Caster.Level;
			Freeze  = true;
			Faction = Caster.Faction;
			SummonedBy = Caster;
			World.Add(this, Caster.X, Caster.Y, Caster.Z, Caster.MapId);
			TotemsTimer.TotemsList.Add(this);
		}
 
		public void ApplyEffect()
		{
			if(this.Delay >= BaseDelay)
			{
				this.Delay = 0;
				//foreach(Mobile mob in this.KnownObjects())	old style. crashes
				foreach( Object obj in this.KnownObjects() )
				{
					if( obj is Mobile )
					{
						Mobile mob = obj as Mobile;
						//Console.WriteLine("TOTEM: mob= " + mob.ToString());
						if (this.Distance(mob) < Range && !mob.Dead)
						{
							if (CanCast(mob))
							{
								if(!mob.AlreadyHaveAura((Abilities.abilities[ SpellID ] as AuraEffect)))
								{
									if(MakeFakeCast)
										FakeCast(SpellID, mob);
									effectHandler( Abilities.abilities[ SpellID ], this, mob );
									if (!AffectedMobs.Contains(mob))
										AffectedMobs.Add(mob);
								}
							}
						}
					}
				} 

				for(int i = 0; i < AffectedMobs.Count; i++)
				{
					Mobile m = AffectedMobs[i] as Mobile;
					if(m.MapId != MapId || Distance(m) > Range || m.Dead)
					{
						m.ReleaseAura((Abilities.abilities[ SpellID ] as AuraEffect));
						AffectedMobs.RemoveAt(i);
						i--;
					}
				}
			}
			this.Delay++;
		}

		private bool CanCast(Mobile mob)
		{
			if (target == TotemTarget.Friends && Caster == mob)
				return true;
			if(Caster is Character)
			{
				Character ch = Caster as Character;
				if((target == TotemTarget.Friends && ch.GroupMembers.Members.Contains(mob))
					|| (target == TotemTarget.Enemy && Caster.Reputation( mob ) < 0.4))
					return true; 
			}
			else if ((target == TotemTarget.Friends && Caster.Reputation( mob ) > 0.6)
				||(target == TotemTarget.Enemy && Caster.Reputation( mob ) < 0.4))
				return true;
			return false;
		}
 
		public void SummonTotem(Mobile caster, int lifetime, int _basedelay, float range, TotemType totemtype, TotemTarget Target, int SpellId,
			SingleTargetSpellEffect spelleffect )
		{
			SummonTotem(caster, lifetime, _basedelay, range, totemtype, Target, SpellId, spelleffect, true);
		}

		public void SummonTotem(Mobile caster, int lifetime, int _basedelay, float range, TotemType totemtype, TotemTarget Target, int SpellId, 
			SingleTargetSpellEffect spelleffect, bool _fakecast )
		{
			MakeFakeCast = _fakecast;
			Caster = caster;
			LifeTime = lifetime;
			//============================
			Delay = 0;
			BaseDelay = _basedelay;
			//============================
			Range = range;
			effectHandler = spelleffect;
			target = Target;
			SpellID = SpellId;
			totemType = totemtype;

			for(int i=0; i<caster.AdditionnalStates.Count; i++)
			{
				if (caster.AdditionnalStates[i] is BaseTotems)
				{
					BaseTotems bt = (BaseTotems)caster.AdditionnalStates[i];
					if (bt.totemType == totemType)
					{
						bt.LooseHits(bt, bt.BaseHitPoints);
						caster.AdditionnalStates.RemoveAt(i);
						i--;
					}
				}
			}
			caster.AdditionnalStates.Add(this);
 
			Level = Caster.Level;
			Freeze  = true;
			Faction = Caster.Faction;
			SummonedBy = Caster;
			World.Add(this, Caster.X, Caster.Y, Caster.Z, Caster.MapId);
			TotemsTimer.TotemsList.Add(this);
		}
 
		public void RemoveTotem()
		{
			foreach (Mobile m in AffectedMobs)
			{
				m.ReleaseAura((Abilities.abilities[ SpellID ] as AuraEffect));
			}
			AffectedMobs.Clear();
			Caster.Summon = null;
			LooseHits(this, BaseHitPoints);
			World.Remove( this, Caster );
		}
	}
 
	public class TotemsTimer : WowTimer
	{
		public static ArrayList TotemsList;
		BaseTotems totem;
 
		public TotemsTimer(double time) : base(time)
		{
		}
 
		public override void OnTick()
		{
			if (TotemsList.Count > 0)
			{
				for (int i=0; i< TotemsList.Count; i++)
				{
					totem = (TotemsList[i] as BaseTotems);
					totem.ApplyEffect();
					totem.LifeTime--;
					if (totem.LifeTime < 0 || totem.Dead)
					{
						TotemsList.RemoveAt(i);
						i--;
						totem.RemoveTotem();
					}
				}
			}
		}
	}
}
#endregion

namespace Server
{
	public class ShamanSpells
	{
		#region Spells
		#region Shock Auras (crashes; makes "burning hands")
		/*public class EarthShockAura : Aura
		{
			private int duration;
			private int frequency;
			private Mobile src;
			private Mobile targ;
			private SpellTemplate spell;

			public EarthShockAura(SpellTemplate st, Mobile c, Mobile t, int dur, int freq)
			{
				this.spell = st;
				this.src = c;
				this.targ = t;
				this.duration = dur;
				this.frequency = freq;
				base.PeriodicAura(new Aura.AuraPeriodicEffect(this.AuraTick), dur, this.frequency);
			}

			public void AuraTick()
			{
				if(!targ.Dead)
					this.targ.CancelCast();
			}
		}

		public class FrostShockAura : Aura
		{
			private int duration;
			private int frequency;
			private Mobile src;
			private Mobile targ;
			private SpellTemplate spell;

			public FrostShockAura(SpellTemplate st, Mobile c, Mobile t, int dur, int freq)
			{
				this.spell = st;
				this.src = c;
				this.targ = t;
				this.duration = dur;
				this.frequency = freq;
				this.SpeedModifier = -st.S1;
				this.OnRelease = new Aura.AuraReleaseDelegate(FrostShockEnd);
				base.PeriodicAura(new Aura.AuraPeriodicEffect(this.AuraTick), dur, this.frequency);
			}

			public void FrostShockEnd(Mobile c)
			{
				this.SpeedModifier = 0;
				c.ReleaseAura((this.spell as AuraEffect));
			}

			public void AuraTick()
			{
			}
		}

		public class FlameShockAura : Aura
		{
			private int duration;
			private int frequency;
			private Mobile src;
			private Mobile targ;
			private SpellTemplate spell;

			public FlameShockAura(SpellTemplate st, Mobile c, Mobile t, int dur, int freq)
			{
				this.spell = st;
				this.src = c;
				this.targ = t;
				this.duration = dur;
				this.frequency = freq;
				base.PeriodicAura(new Aura.AuraPeriodicEffect(this.AuraTick), dur, this.frequency);
			}

			public void AuraTick()
			{//TODO: check if is dead
				if(!targ.Dead)
					this.spell.MakeDamage(src, targ, spell.S1);
			}
		}*/
		#endregion

		#region Earthbnid Totem (100% working)
		public static void OnCastEarthbindTotem( BaseAbility ba, Mobile c ) 
		{
			BaseTotems bt = new BaseTotems();
			bt.Name = "Earthbind Totem";
			bt.Id = 2630;
			bt.Model = 4588;
			bt.SummonTotem(c, 45, 0, 900f, TotemType.Earth, TotemTarget.Enemy, 3600, new SingleTargetSpellEffect(OnCastEarthbind));
		}
		public static void OnCastEarthbind(BaseAbility ba, Mobile c, Mobile target) 
		{
			AuraEffect st = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			aura.SpeedModifier = (((float)st.S1-100f)/100f); 
			target.AddAura(c, st, aura);
		}
		#endregion
		#region Ancestral Spirit
		public static void OnCastAncestralSpirit(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			if(!c.InCombat)
			{
				if(target.Dead)
				{
					Character ch = target as Character;
					ch.ReclaimCorps();
					st.Heal(c, ch, SpellDamage.TypeS1);
				}
			}
			else c.CancelCast();
			(c as Character).SendMessage(string.Format("OnCastAncestralSpirit: S1={0} S2={1} S3={2}", st.S1.ToString(), st.S2.ToString(), st.S3.ToString()));
		}
		#endregion
		#region Astral Recall
		public static void OnCastAstralRecall(BaseAbility ba, Mobile c)
		{
			//Character ch = c as Character;
		}
		#endregion
		#region +Chain Heal
		public static void OnCastChainHeal(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			int dmg;
			if(c.HaveTalent(Server.Talents.Purification))
			{
				AuraEffect add = (AuraEffect)c.GetTalentEffect(Server.Talents.Purification);
				dmg = (int)(st.S1*((100+add.S1)/100));
			}
			else dmg = st.S1;

			st.Heal(c, target, dmg);
			Mobile lasttarg = target;
			int jump = 0;
			for(int i=0; i<target.KnownObjects.Count; i++)
			{
				if(target.KnownObjects[i] is Mobile)
				{
					Mobile m = target.KnownObjects[i] as Mobile;
					lasttarg.FakeCast(ba.Id, m);
					st.Heal(c, m, (int)(dmg*(Math.Pow(0.5, jump))));
					lasttarg = m;
					jump--;
				}
			}
		}
		#endregion
		#region +Chain Lightning
		public static void OnCastChainLightning(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			(c as Character).SendMessage(String.Format("ChainLightning: S1={0} S2={1} S3={2}", st.S1.ToString(), st.S2.ToString(), st.S3.ToString()));
			int dmg;
			if(c.HaveTalent(Server.Talents.ImprovedChainLightning))
			{
				AuraEffect add = (AuraEffect)c.GetTalentEffect(Server.Talents.ImprovedChainLightning);
				dmg = (int)(st.S1*((100+add.S1)/100));
			}
			else dmg = st.S1;
			st.MakeDamage(c, target, dmg);
			int jump = 0;
			Mobile lasttarg = target;
			for(int i=0; i<c.KnownObjects.Count; i++)
			{
				if(c.KnownObjects[i] is Mobile)
				{
					if(jump < 3)
					{
						Mobile mob = c.KnownObjects[i] as Mobile;
						lasttarg.FakeCast(ba.Id, mob);
						st.MakeDamage(c, mob, (int)((dmg)*(Math.Pow(0.7,jump))));
						lasttarg = mob;
						jump++;
					}
				}
			}
		}
		#endregion
		#region Cure Disease (not tested)
		public static void OnCastCureDisease(BaseAbility ba, Mobile c, Mobile target)
		{
			Aura tmp;
			bool cured = false;
			for(int i=0; i<target.Auras.Count; i++)
			{
				if((target.Auras[i] as AuraEffect).Dispeltype == DispelType.Disease)
				{
					tmp = target.Auras[i] as Aura;
					if(HelperTools.Utility.Random(0,1) == 1)
					{
						//target.ReleaseAura((target.Auras[i] as AuraEffect));
						tmp.Release(target);
						cured = true;
						break;
					}
				}
			}
			if(!cured)
			{
				for(int i=0; i<target.Auras.Count; i++)
				{
					if((target.Auras[i] as AuraEffect).Dispeltype == DispelType.Disease)
					{
						tmp = target.Auras[i] as Aura;
						tmp.Release(target);
					}
				}
			}
		}
		#endregion
		#region Cure Poison (not tested)
		public static void OnCastCurePoison(BaseAbility ba, Mobile c, Mobile target)
		{
			Aura tmp;
			bool cured = false;
			for(int i=0; i<target.Auras.Count; i++)
			{
				if((target.Auras[i] as AuraEffect).Dispeltype == DispelType.Poison)
				{
					tmp = target.Auras[i] as Aura;
					if(HelperTools.Utility.Random(0,1) == 1)
					{
						//target.ReleaseAura((target.Auras[i] as AuraEffect));
						(target.Auras[i] as Aura).Release(target);
						cured = true;
						break;
					}
				}
			}
			if(!cured)
			{
				for(int i=0; i<target.Auras.Count; i++)
				{
					if((target.Auras[i] as AuraEffect).Dispeltype == DispelType.Poison)
					{
						tmp = target.Auras[i] as Aura;
						tmp.Release(target);
					}
				}
			}
		}
		#endregion
		#region Disease Cleansing Totem (not tested)
		public static void OnCastDiseaseCleansingTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();

			bt.Model = 4587;
			bt.Name = "Disease Cleansing Totem";
			bt.Id = 5924;
			bt.SummonTotem(c, 90, 5, 400f, TotemType.Water, TotemTarget.Friends, 8185, new SingleTargetSpellEffect(OnCastDiseaseCleansing));
		}

		public static void OnCastDiseaseCleansing(BaseAbility ba, Mobile c, Mobile target)
		{
			Aura tmp;
			bool cured = false;
			for(int i=0; i<target.Auras.Count; i++)
			{
				if((target.Auras[i] as AuraEffect).Dispeltype == DispelType.Disease)
				{
					tmp = target.Auras[i] as Aura;
					if(HelperTools.Utility.Random(0,1) == 1)

					{
						//target.ReleaseAura((target.Auras[i] as AuraEffect));
						tmp.Release(target);
						cured = true;
						break;
					}
				}
			}
			if(!cured)
			{
				for(int i=0; i<target.Auras.Count; i++)
				{
					if((target.Auras[i] as AuraEffect).Dispeltype == DispelType.Disease)
					{
						tmp = target.Auras[i] as Aura;
						tmp.Release(target);
					}
				}
			}
		}
		#endregion
		#region +Earth Shock
		public static void OnCastEarthShock(BaseAbility ba, Mobile c, Mobile target)
		{//TODO: earth shock (cancel earth cast)
			SpellTemplate st = (SpellTemplate)ba;
			if(c.HaveTalent(Server.Talents.Concussion))
			{
				AuraEffect add = (AuraEffect)c.GetTalentEffect(Server.Talents.Concussion);
				st.MakeDamage(c, target, (int)(st.S1*((100+add.S1)/100)));
			}
			else st.MakeDamage(c, target, st.S1);
			Console.WriteLine("OnCastEarthShock: st S1={0} S2={1} S3={2}", st.S1.ToString(), st.S2.ToString(), st.S3.ToString());
			if(!target.Dead) target.CancelCast();
		}
		#endregion
		#region Far Sight
		public static void OnCastFarSight(BaseAbility ba, Mobile c, Mobile target)
		{
		}
		#endregion
		#region +Fire Nova Totem
		public static void OnCastFireNovaTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			bt.Model = 4683;
			switch(ba.Id)
			{
				case 1535:
					bt.Name = "Fire Nova Totem";
					bt.Id = 5879;
					bt.SummonTotem(c, 5, 0, 400f, TotemType.Fire, TotemTarget.Enemy, 8349, new SingleTargetSpellEffect(OnCastFireNova));
					break;
				case 8498:
					bt.Name = "Fire Nova Totem II";
					bt.Id = 6110;
					bt.SummonTotem(c, 5, 0, 400f, TotemType.Fire, TotemTarget.Enemy, 8502, new SingleTargetSpellEffect(OnCastFireNova));
					break;
				case 8499:
					bt.Name = "Fire Nova Totem III";
					bt.Id = 6111;
					bt.SummonTotem(c, 5, 0, 400f, TotemType.Fire, TotemTarget.Enemy, 8503, new SingleTargetSpellEffect(OnCastFireNova));
					break;
				case 11314:
					bt.Name = "Fire Nova Totem IV";
					bt.Id = 7844;
					bt.SummonTotem(c, 5, 0, 400f, TotemType.Fire, TotemTarget.Enemy, 11306, new SingleTargetSpellEffect(OnCastFireNova));
					break;
				case 11315:
					bt.Name = "Fire Nova Totem V";
					bt.Id = 7845;
					bt.SummonTotem(c, 5, 0, 400f, TotemType.Fire, TotemTarget.Enemy, 11307, new SingleTargetSpellEffect(OnCastFireNova));
					break;
			}
		}

		public static void OnCastFireNova(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			if((c as BaseTotems).Caster.HaveTalent(Server.Talents.CallOfFlame))
			{
				AuraEffect add = (AuraEffect)(c as BaseTotems).Caster.GetTalentEffect(Server.Talents.CallOfFlame);
				st.MakeDamage(c, target, (int)(st.S1*((100+add.S1)/100)));
			}
			else st.MakeDamage(c, target, st.S1);
		}
		#endregion
		#region Fire Resistance Totem
		public static void OnCastFireResistanceTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();

			bt.Model = 4587;
			switch(ba.Id)
			{
				case 8184:
					bt.Name = "Fire Resistance Totem";
					bt.Id = 5927;
					bt.SummonTotem(c, 60, 0, 400f, TotemType.Water, TotemTarget.Friends, 8185, new SingleTargetSpellEffect(OnCastFireResistance));
					break;
				case 10537:
					bt.Name = "Fire Resistance Totem II";
					bt.Id = 7424;
					bt.SummonTotem(c, 60, 0, 400f, TotemType.Water, TotemTarget.Friends, 10534, new SingleTargetSpellEffect(OnCastFireResistance));
					break;
				case 10538:
					bt.Name = "Fire Resistance Totem III";
					bt.Id = 7425;
					bt.SummonTotem(c, 60, 0, 400f, TotemType.Water, TotemTarget.Friends, 10535, new SingleTargetSpellEffect(OnCastFireResistance));
					break;
			}
		}

		public static void OnCastFireResistance(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect st = (AuraEffect)ba;
			Aura a = new Aura();
			a.FireResistanceBonus = st.S1;
			target.AddAura(st, a);
		}
		#endregion
		#region +Flame Shock
		public static void OnCastFlameShock(BaseAbility ba, Mobile c, Mobile target)
		{//Flame Shock Instantly sears the target with fire, causing $s1 damage immediately and 
		 //		$o2 damage over $d. $s2 Fire damage every $t2 seconds.
			SpellTemplate st = (SpellTemplate)ba;
			Console.WriteLine("FlameShock st.S1={0} st.S2={1} st.S3={2}", st.S1.ToString(), st.S2.ToString(), st.S3.ToString());
			if(c.HaveTalent(Server.Talents.Concussion))
			{
				AuraEffect add = (AuraEffect)c.GetTalentEffect(Server.Talents.Concussion);
				st.MakeDamage(c, target, (int)(st.S1*((100+add.S1)/100)));
			}
			else st.MakeDamage(c, target, st.S1);
			if(!target.Dead) st.ApplyDot(c, target, st.S2, 2, st.Duration(c));
			//st.MakeDamage(c, target, SpellDamage.TypeS1);
			//Console.WriteLine("OnCastFlameShock st.S1={0} st.S2={1} st.S3={2}", st.S1.ToString(), st.S2.ToString(), st.S3.ToString());
			//Console.WriteLine("OnCastFlameShock st.Duration(c)={0}", st.Duration(c).ToString());
			
			//AuraEffect ae = (AuraEffect)ba;
			//FlameShockAura fsa = new FlameShockAura((ba as SpellTemplate), c, target, st.Duration, st.T1);
			//target.AddAura(ae, fsa);
		}
		#endregion
		#region +Flametongue Weapon
		public static void OnCastFlametongueWeapon(BaseAbility ba, Mobile c)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura a = new Aura();
			if(c.HaveTalent(Server.Talents.ImprovedFlametongueWeapon))
			{
				AuraEffect add = (AuraEffect)c.GetTalentEffect(Server.Talents.ImprovedFlametongueWeapon);
				a.FireDamageIncrease = (int)(ae.S1*((100+add.S1)/100));
			}
			else a.FireDamageIncrease = ae.S1;
			Console.WriteLine("FlametongueWeapon S1={0} S2={1} S3={2}", ae.S1.ToString(), ae.S2.ToString(), ae.S3.ToString());
			c.AddAura(ae, a);
		}
		#endregion
		#region +Flametongue Totem
		public static void OnCastFlametongueTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			bt.Model = 4589;
			/*dunno correct number for totems spell*/

			switch(ba.Id)
			{
				case 8227:
					bt.Id = 5950;
					bt.Name = "Flametongue Totem";
					bt.SummonTotem(c, 90, 1, 400f, TotemType.Fire, TotemTarget.Friends, 8230, new SingleTargetSpellEffect(OnTotemFlameTongue));
					//or 8253
					break;
				case 8249:
					bt.Id = 6012;
					bt.Name = "Flametongue Totem II";
					bt.SummonTotem(c, 90, 1, 400f, TotemType.Fire, TotemTarget.Friends, 8250, new SingleTargetSpellEffect(OnTotemFlameTongue));
					//or 8248
					break;
				case 10526:
					bt.Id = 7423;
					bt.Name = "Flametongue Totem III";
					bt.SummonTotem(c, 90, 1, 400f, TotemType.Fire, TotemTarget.Friends, 10521, new SingleTargetSpellEffect(OnTotemFlameTongue));
					//or 10523
					break;
				case 16387:
					bt.Id = 10557;
					bt.Name = "Flametongue Totem IV";
					bt.SummonTotem(c, 90, 1, 400f, TotemType.Fire, TotemTarget.Friends, 15036, new SingleTargetSpellEffect(OnTotemFlameTongue));
					//or 16389
					break;
			}
		}

		public static void OnTotemFlameTongue(BaseAbility ba, Mobile c, Mobile target)
		{//TODO: FlameTongue totem
			AuraEffect ae = (AuraEffect)ba;
			Aura a = new Aura();
			a.FireDamageIncrease = ae.S1;
			target.AddAura(ae, a);
		}
		#endregion
		#region Frost Resistance Totem (100% working)
		public static void OnCastFrostResistanceTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			bt.Model = 4589;
			switch(ba.Id)
			{
				case 8181:
					bt.Name = "Frost Resistance Totem";
					bt.Id = 5926;
					bt.SummonTotem(c, 60, 0, 400f, TotemType.Fire, TotemTarget.Friends, 8182, new SingleTargetSpellEffect(OnCastFrostResistance));
					break;
				case 10478:
					bt.Name = "Frost Resistance Totem II";
					bt.Id = 7412;
					bt.SummonTotem(c, 60, 0, 400f, TotemType.Fire, TotemTarget.Friends, 10476, new SingleTargetSpellEffect(OnCastFrostResistance));
					break;
				case 10479:
					bt.Name = "Frost Resistance Totem III";
					bt.Id = 7413;
					bt.SummonTotem(c, 60, 0, 400f, TotemType.Fire, TotemTarget.Friends, 10477, new SingleTargetSpellEffect(OnCastFrostResistance));
					break;
			}
		}

		public static void OnCastFrostResistance(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect st = (AuraEffect)ba;
			Aura a = new Aura();
			a.FrostResistanceBonus = st.S1;
			target.AddAura(st, a);
		}
		#endregion
		#region +Frost Shock
		public static void OnCastFrostShock(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			//st.MakeDamage(c, target, SpellDamage.TypeS1);
			if(c.HaveTalent(Server.Talents.Concussion))
			{
				AuraEffect add = (AuraEffect)c.GetTalentEffect(Server.Talents.Concussion);
				st.MakeDamage(c, target, (int)(st.S1*((100+add.S1)/100)));
			}
			else st.MakeDamage(c, target, st.S1);
			if(!target.Dead)
			{
				AuraEffect ae = (AuraEffect)ba;
				Aura a = new Aura();
				a.OnRelease = new Aura.AuraReleaseDelegate(OnFrostShockEnded);
				a.SpeedModifier = ae.S1;
				target.AddAura(ae, a);
				target.ChangeRunSpeed(target.RunSpeed);
			}
		}

		public static void OnFrostShockEnded(Mobile from)
		{
			from.ChangeRunSpeed(from.RunSpeed);
		}
		#endregion
		#region +Frostbrand Weapon
		public static void OnCastFrostbrandWeapon(BaseAbility ba, Mobile c)
		{//TODO: Frostbrabd Weapon (hits every time instead of a chance to hit)
			//Imbue the Shaman's weapon with frost. Each hit has a chance of causing <..> additional Frost damage and slowing the 
			//target's movement speed to 75% for 8 seconds. Lasts for 5 minutes.
			AuraEffect ae = (AuraEffect)ba;
			Aura a = new Aura();
			a.FrostDamageIncrease = ae.S1;
			c.AddAura(ae, a);
			a.OnMeleeHitDone = 1;
			c.Triggers[1] = new Mobile.OnMeleeHitDoneTrigger(OnFrostbrandHit);
		}

		public static void OnFrostbrandHit( Mobile c, Mobile target, AuraEffect ae )
		{
			(c as Character).SendMessage(String.Format("Frostbrand: S1={0} S2={1} S3={2}", ae.S1.ToString(), ae.S2.ToString(), ae.S3.ToString()));
			(c as Character).SendMessage(String.Format("Frostbrand: T1={0} T2={1}", ae.T1.ToString(), ae.T2.ToString()));
		}
		#endregion
		#region Ghost Wolf (not tested)
		public static void OnCastGhostWolf(BaseAbility ba, Mobile c)
		{
			c.Polymorph(171);
			SpellTemplate st = (SpellTemplate)ba;
			Console.WriteLine("OnCastGhostWolf st.S1={0} st.S2={1} st.S3={2}", st.S1.ToString(), st.S2.ToString(), st.S3.ToString());
		}
		#endregion
		#region +Grace of Air Totem
		public static void OnCastGraceofAirTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			bt.totemType = TotemType.Water;
			bt.Model = 4590;
			switch(ba.Id)
			{
				case 8835:
					bt.Name = "Grace of Air Totem";
					bt.Id = 7486;
					bt.SummonTotem(c, 75, 0, 400f, TotemType.Air, TotemTarget.Friends, 8836, new SingleTargetSpellEffect(OnTotemGraceofAir));
					break;
				case 10627:
					bt.Name = "Grace of Air Totem II";
					bt.Id = 7487;
					bt.SummonTotem(c, 75, 0, 400f, TotemType.Air, TotemTarget.Friends, 10626, new SingleTargetSpellEffect(OnTotemGraceofAir));
					break;
			}
		}

		public static void OnTotemGraceofAir(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura a = new Aura();
			if((c as BaseTotems).Caster.HaveTalent(Server.Talents.ImprovedGraceOfAirTotem))
			{
				AuraEffect add = (AuraEffect)(c as BaseTotems).Caster.GetTalentEffect(Server.Talents.ImprovedGraceOfAirTotem);
				a.AgBonus = (int)(ae.S1*(100 + add.S1)/100);
			}
			else a.AgBonus = ae.S1;
			target.AddAura(ae, a);
		}
		#endregion
		#region Grounding Totem
		public static void OnCastGroundingTotem(BaseAbility ba, Mobile c)
		{

		}
		#endregion
		#region ++Healing Stream Totem
		public static void OnCastHealingStreamTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			bt.Model = 4587;
			int duradd;
			if(c.HaveTalent(Server.Talents.Eventide))
			{
				duradd = (int)((100+(c.GetTalentEffect(Server.Talents.Eventide) as AuraEffect).S1)/100);
			}
			else duradd = 1;
			switch(ba.Id)
			{
				case 5394:
					bt.Name = "Healing Stream Totem";
					bt.Id = 3527;
					bt.SummonTotem(c, 60*duradd, 2, 400f, TotemType.Water, TotemTarget.Friends, 5672, new SingleTargetSpellEffect(OnCastHealingStream), false);
					break;
				case 6375:
					bt.Name = "Healing Stream Totem II";
					bt.Id = 3906;
					bt.SummonTotem(c, 60*duradd, 2, 400f, TotemType.Water, TotemTarget.Friends, 6371, new SingleTargetSpellEffect(OnCastHealingStream), false);
					break;
				case 6377:
					bt.Name = "Healing Stream Totem III";
					bt.Id = 3907;
					bt.SummonTotem(c, 60*duradd, 2, 400f, TotemType.Water, TotemTarget.Friends, 6372, new SingleTargetSpellEffect(OnCastHealingStream), false);
					break;
				case 10462:
					bt.Name = "Healing Stream Totem IV";
					bt.Id = 3908;
					bt.SummonTotem(c, 60*duradd, 2, 400f, TotemType.Water, TotemTarget.Friends, 10460, new SingleTargetSpellEffect(OnCastHealingStream), false);
					break;
				case 10463:
					bt.Name = "Healing Stream Totem V";
					bt.Id = 3909;
					bt.SummonTotem(c, 60*duradd, 2, 400f, TotemType.Water, TotemTarget.Friends, 10461, new SingleTargetSpellEffect(OnCastHealingStream), false);
					break;
			}
		}

		public static void OnCastHealingStream(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			if(target.HitPoints < target.BaseHitPoints)
			{
				c.FakeCast(ba.Id, target);
				if((c as BaseTotems).Caster.HaveTalent(Server.Talents.ImprovedHealingStreamTotem))
				{
					AuraEffect add = (AuraEffect)(c as BaseTotems).Caster.GetTalentEffect(Server.Talents.ImprovedHealingStreamTotem);
					st.Heal(c, target, (int)((st.S1)*((100+add.S1)/100)));
				}
				else st.Heal(c, target, st.S1);
			}
		}
		#endregion
		#region +Healing Wave
		public static void OnCastHealingWave(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			int dmg;
			if(c.HaveTalent(Server.Talents.Purification))
			{
				AuraEffect add = (AuraEffect)c.GetTalentEffect(Server.Talents.Purification);
				dmg = (int)(st.S1*((100+add.S1)/100));
			}
			else dmg = st.S1;

			st.Heal(c, target, dmg);
		}
		#endregion
		#region +Lesser Healing Wave
		public static void OnCastLesserHealingWave(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			int dmg;
			if(c.HaveTalent(Server.Talents.Purification))
			{
				AuraEffect add = (AuraEffect)c.GetTalentEffect(Server.Talents.Purification);
				dmg = (int)(st.S1*((100+add.S1)/100));
			}
			else dmg = st.S1;

			st.Heal(c, target, dmg);
		}
		#endregion
		#region Lightning Bolt (100% working)
		public static void OnCastLightningBolt(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			st.MakeDamage(c, target, st.S1);
		}
		#endregion
		#region LightningShield (only one ball and no effect)
		public static void OnCastLightningShield(BaseAbility ba, Mobile c)
		{
			AuraEffect ae = (AuraEffect)ba;
			//FrostArmorAura aura = new FrostArmorAura();
			Aura a = new Aura();
			a.OnMeleeHit = 324;	//id of the trigger
			//OnRangedHit ??
			c.Triggers[ 324 ] = new Mobile.OnMeleeHitTrigger( OnLightningShieldHit );
			c.AddAura( ae, a );
		}

		public static void OnLightningShieldHit( Mobile m, Mobile target, AuraEffect ae )
		{
			Console.WriteLine("OnLightningShieldHit: S1={0} S2={1} S3={2}", ae.S1.ToString(), ae.S2.ToString(), ae.S3.ToString());
			//ae.MakeDamage(m, target, ae.S2);
			//Aura au = new Aura();
			//aura.SpeedModifier = 0.5f;
			//target.AddAura( (AuraEffect)Abilities.abilities[ 14207 ], aura, true );//	true for offensive aura
			//target.ChangeRunSpeed( target.RunSpeed );
		}

		#endregion
		#region +Magma Totem (no graphics)
		public static void OnCastMagmaTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			bt.Model = 4589;
			switch(ba.Id)
			{
				case 8190:
					bt.Name = "Magma Totem";
					bt.Id = 5929;
					bt.SummonTotem(c, 20, 2, 256f, TotemType.Fire, TotemTarget.Enemy, 8187, new SingleTargetSpellEffect(OnCastMagma), true);
					Console.WriteLine("MagmaTotem created");
					break;
				case 10585:
					bt.Name = "Magma Totem II";
					bt.Id = 7464;
					bt.SummonTotem(c, 20, 2, 256f, TotemType.Fire, TotemTarget.Enemy, 10579, new SingleTargetSpellEffect(OnCastMagma), true);
					break;
				case 10586:
					bt.Name = "Magma Totem III";
					bt.Id = 7465;
					bt.SummonTotem(c, 20, 2, 256f, TotemType.Fire, TotemTarget.Enemy, 10580, new SingleTargetSpellEffect(OnCastMagma), true);
					break;
				case 10587:
					bt.Name = "Magma Totem IV";
					bt.Id = 7466;
					bt.SummonTotem(c, 20, 2, 256f, TotemType.Fire, TotemTarget.Enemy, 10581, new SingleTargetSpellEffect(OnCastMagma), true);
					break;
			}
		}

		public static void OnCastMagma(BaseAbility ba, Mobile c, Mobile target) 
		{
			SpellTemplate st = (SpellTemplate)ba;
			Console.WriteLine("MagmaTotemCast: S1={0}; S2={1}; S3={2}", st.S1.ToString(), st.S2.ToString(), st.S3.ToString());
			if((c as BaseTotems).Caster.HaveTalent(Server.Talents.CallOfFlame))
			{
				AuraEffect add = (AuraEffect)(c as BaseTotems).Caster.GetTalentEffect(Server.Talents.CallOfFlame);
				st.MakeDamage(c, target, (int)(st.S1*((100+add.S1)/100)));
			}
			else st.MakeDamage(c, target, st.S1);
		}
		#endregion
		#region ++Mana Spring Totem
		public static void OnCastManaSpringTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			bt.Model = 4587;
			int duradd;
			if(c.HaveTalent(Server.Talents.Eventide))
			{
				duradd = (int)((100+(c.GetTalentEffect(Server.Talents.Eventide) as AuraEffect).S1)/100);
			}
			else duradd = 1;
			switch(ba.Id)
			{
				case 5675:
					bt.Name = "Mana Spring Totem";
					bt.Id = 3573;
					bt.SummonTotem(c, 60*duradd, 2, 400f, TotemType.Water, TotemTarget.Friends, 5677, new SingleTargetSpellEffect(OnCastManaSpring), false);
					break;
				case 10495:
					bt.Name = "Mana Spring Totem II";
					bt.Id = 7414;
					bt.SummonTotem(c, 60*duradd, 2, 400f, TotemType.Water, TotemTarget.Friends, 10491, new SingleTargetSpellEffect(OnCastManaSpring), false);
					break;
				case 10496:
					bt.Name = "Mana Spring Totem III";
					bt.Id = 7415;
					bt.SummonTotem(c, 60*duradd, 2, 400f, TotemType.Water, TotemTarget.Friends, 10493, new SingleTargetSpellEffect(OnCastManaSpring), false);
					break;
				case 10497:
					bt.Name = "Mana Spring Totem IV";
					bt.Id = 7416;
					bt.SummonTotem(c, 60*duradd, 2, 400f, TotemType.Water, TotemTarget.Friends, 10494, new SingleTargetSpellEffect(OnCastManaSpring), false);
					break;
			}
		}
		
		public static void OnCastManaSpring(BaseAbility ba, Mobile c, Mobile target)
		{//TODO: OnCastManaSpring (working. check values)
			SpellTemplate st = (SpellTemplate)ba;
			if(target.Mana < target.BaseMana)
			{
				c.FakeCast(ba.Id, target);
				if((c as BaseTotems).Caster.HaveTalent(Server.Talents.ImprovedManaSpringTotem))
				{
					AuraEffect add = (AuraEffect)(c as BaseTotems).Caster.GetTalentEffect(Server.Talents.ImprovedManaSpringTotem);
					//(target as Character).SendMessage(String.Format("ManaSpring: add: S1={0} S2={1} S3={2}", add.S1.ToString(), add.S2.ToString(), add.S3.ToString()));
					target.GainMana(c, (int)((st.S1)*((100 + add.S1)/100)));
					(target as Character).SendMessage(String.Format("ManaSpring: gained: {0}", Convert.ToString(((st.S1)*((100+add.S1)/100)))));
				}
				else target.GainMana(c, st.S1);
			}
		}
		#endregion
		#region Mana Tide Totem (100% scripted)
		public static void OnCastManaTideTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			bt.Model = 4587;
			switch(ba.Id)
			{
				case 5675:
					bt.Name = "Mana Tide Totem";
					bt.Id = 10467;
					bt.SummonTotem(c, 12, 3, 400f, TotemType.Water, TotemTarget.Friends, 16191, new SingleTargetSpellEffect(OnCastManaTide), false);
					break;
				case 10495:
					bt.Name = "Mana Tide Totem II";
					bt.Id = 11100;
					bt.SummonTotem(c, 12, 3, 400f, TotemType.Water, TotemTarget.Friends, 17355, new SingleTargetSpellEffect(OnCastManaTide), false);
					break;
				case 10496:
					bt.Name = "Mana Tide Totem III";
					bt.Id = 11101;
					bt.SummonTotem(c, 12, 3, 400f, TotemType.Water, TotemTarget.Friends, 17360, new SingleTargetSpellEffect(OnCastManaTide), false);
					break;
			}
		}

		public static void OnCastManaTide(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			if(target.Mana < target.BaseMana)
			{
				c.FakeCast(ba.Id, target);
				target.GainMana(c, (ba as SpellTemplate).S1);
			}
		}
		#endregion
		#region Nature Resistance Totem (100% working)
		public static void OnCastNatureResistanceTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			bt.Model = 4590;
			switch(ba.Id)
			{
				case 10595:
					bt.Name = "Nature Resistance Totem";
					bt.Id = 7467;
					bt.SummonTotem(c, 60, 0, 400f, TotemType.Air, TotemTarget.Friends, 10596, new SingleTargetSpellEffect(OnCastNatureResistance));
					break;
				case 10600:
					bt.Name = "Nature Resistance Totem II";
					bt.Id = 7468;
					bt.SummonTotem(c, 60, 0, 400f, TotemType.Air, TotemTarget.Friends, 10598, new SingleTargetSpellEffect(OnCastNatureResistance));
					break;
				case 10601:
					bt.Name = "Nature Resistance Totem III";
					bt.Id = 7469;
					bt.SummonTotem(c, 60, 0, 400f, TotemType.Air, TotemTarget.Friends, 10599, new SingleTargetSpellEffect(OnCastNatureResistance));
					break;
			}
		}

		public static void OnCastNatureResistance(BaseAbility ba, Mobile c, Mobile target)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura a = new Aura();
			a.NatureResistanceBonus = ae.S1;
			target.AddAura(c, ae, a);
		}
		#endregion
		#region Poison Cleansing Totem
		public static void OnCastPoisonCleansingTotem(BaseAbility ba, Mobile c)
		{//spellID for totem 8168
		}
		#endregion
		#region Purge (50% working)
		public static void OnCastPurge(BaseAbility ba, Mobile c, Mobile target)
		{
			if(ba.Id == 370)
			{
				//target.ReleaseAura(target.Auras[Utility.Random(0, target.Auras.Count)] as AuraEffect); 
				
				(target.Auras[HelperTools.Utility.Random(0, target.Auras.Count)] as Aura).Release(target);
			}
			else if(ba.Id == 8012)
			{
				//target.ReleaseAura(target.Auras[Utility.Random(0, target.Auras.Count)] as AuraEffect);
				//target.ReleaseAura(target.Auras[Utility.Random(0, target.Auras.Count)] as AuraEffect);
				(target.Auras[HelperTools.Utility.Random(0, target.Auras.Count)] as Aura).Release(target);
				(target.Auras[HelperTools.Utility.Random(0, target.Auras.Count)] as Aura).Release(target);
			}
		}
		#endregion
		#region Reincarnation
		public static void OnCastReincarnation(BaseAbility ba, Mobile c)
		{
		}
		#endregion
		#region +Rockbiter Weapon
		public static void OnCastRockbiterWeapon(BaseAbility ba, Mobile c)
		{//Rockbitter Weapon (not working. no talent)
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			if(c.HaveTalent(Server.Talents.ImprovedRockbiterWeapon))
			{
				AuraEffect add = (AuraEffect)c.GetTalentEffect(Server.Talents.ImprovedRockbiterWeapon);
				aura.AttackPowerBonus = (int)(st.S1*((100+add.S1)/100));
			}
			else aura.AttackPowerBonus = st.S1;
			(c as Character).SendMessage(String.Format("RockbiterWeapon: S1={0}; S2={1}; S3={2}", st.S1.ToString(), st.S2.ToString(), st.S3.ToString()));
			c.AddAura(st, aura);
			Console.WriteLine("RockbiterWeaponCast done");
		}
		#endregion
		#region ++Searing Totem (no graphics)
		public static void OnCastSearingTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			int bonus;
			if(c.HaveTalent(Server.Talents.ImprovedSearingTotem))
			{
				bonus = (int)(100 + ((c.GetTalentEffect(Server.Talents.ImprovedSearingTotem) as AuraEffect).S1)/100);
			}
			else bonus = 1;

			bt.Model = 4589;
			switch(ba.Id)
			{
				case 3599:
					bt.Name = "Searing Totem";
					bt.Id = 2523;
					bt.SummonTotem(c, 30*bonus, 2, 400f, TotemType.Fire, TotemTarget.Enemy, 3606, new SingleTargetSpellEffect(OnCastSearing));
					break;
				case 6363:
					bt.Name = "Searing Totem II";
					bt.Id = 3902;
					bt.SummonTotem(c, 35*bonus, 2, 400f, TotemType.Fire, TotemTarget.Enemy, 6350, new SingleTargetSpellEffect(OnCastSearing));
					break;
				case 6364:
					bt.Name = "Searing Totem III";
					bt.Id = 3903;
					bt.SummonTotem(c, 40*bonus, 2, 400f, TotemType.Fire, TotemTarget.Enemy, 6351, new SingleTargetSpellEffect(OnCastSearing));
					break;
				case 6365:
					bt.Name = "Searing Totem IV";
					bt.Id = 3904;
					bt.SummonTotem(c, 45*bonus, 2, 400f, TotemType.Fire, TotemTarget.Enemy, 6352, new SingleTargetSpellEffect(OnCastSearing));
					break;
				case 10437:
					bt.Name = "Searing Totem V";
					bt.Id = 7400;
					bt.SummonTotem(c, 50*bonus, 2, 400f, TotemType.Fire, TotemTarget.Enemy, 10435, new SingleTargetSpellEffect(OnCastSearing));
					break;
				case 10438:
					bt.Name = "Searing Totem VI";
					bt.Id = 7402;
					bt.SummonTotem(c, 55*bonus, 2, 400f, TotemType.Fire, TotemTarget.Enemy, 10436, new SingleTargetSpellEffect(OnCastSearing));
					break;
			}
		}
		public static void OnCastSearing(BaseAbility ba, Mobile c, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			Console.WriteLine("SearingTotemCast: S1={0}; S2={1}; S3={2}", st.S1.ToString(), st.S2.ToString(), st.S3.ToString());
			if((c as BaseTotems).Caster.HaveTalent(Server.Talents.CallOfFlame))
			{
				AuraEffect add = (AuraEffect)(c as BaseTotems).Caster.GetTalentEffect(Server.Talents.CallOfFlame);
				st.MakeDamage(c, target, (int)(st.S1*((100+add.S1)/100)));
			}
			else st.MakeDamage(c, target, st.S1);
		}
		#endregion
		#region Sentry Totem (looks like it's impossible to create it using base totem)
		public static void OnCastSentryTotem(BaseAbility ba, Mobile c)
		{
/*
			BaseTotems bt = new BaseTotems();
			bt.Name = "Stoneskin Totem";
			bt.Id = 2630;
			bt.Model = 4588;
			bt.BaseHitPoints = 100;
			bt.HitPoints = 100;
			bt.SummonTotem(c, 45, 0, 3, 20f, TotemTarget.Friends, 8072, new SingleTargetSpellEffect(OnCastSearing));
*/
		}
		#endregion
		#region +Stoneclaw Totem
		public static void OnCastStoneclawTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			bt.Model = 4588;
			int bonus;
			if(c.HaveTalent(Server.Talents.ImprovedStoneclawTotem))
			{
				AuraEffect add = (AuraEffect)c.GetTalentEffect(Server.Talents.ImprovedStoneclawTotem);
				bonus = (int)((100 + add.S1)/100);
			}
			else bonus = 1;

			switch(ba.Id)
			{
				case 5730:
					bt.BaseHitPoints = 50;
					bt.HitPoints = 50*bonus;
					bt.Name = "Stoneclaw Totem";
					bt.Id = 3579;
					bt.SummonTotem(c, 15, 1, 16f, TotemType.Earth, TotemTarget.Enemy, 5729, new SingleTargetSpellEffect(OnCastStoneClaw));
					break;
				case 6390:
					bt.BaseHitPoints = 150;
					bt.HitPoints = 150*bonus;
					bt.Name = "Stoneclaw Totem II";
					bt.Id = 3911;
					bt.SummonTotem(c, 60, 2, 16f, TotemType.Earth, TotemTarget.Enemy, 6393, new SingleTargetSpellEffect(OnCastStoneClaw));
					break;
				case 6391:
					bt.BaseHitPoints = 220;
					bt.HitPoints = 220*bonus;
					bt.Name = "Stoneclaw Totem III";
					bt.Id = 3912;
					bt.SummonTotem(c, 45, 2, 16f, TotemType.Earth, TotemTarget.Enemy, 6394, new SingleTargetSpellEffect(OnCastStoneClaw));
					break;
				case 6392:
					bt.BaseHitPoints = 280;
					bt.HitPoints = 280*bonus;
					bt.Name = "Stoneclaw Totem IV";
					bt.Id = 3913;
					bt.SummonTotem(c, 45, 2, 16f, TotemType.Earth, TotemTarget.Enemy, 6395, new SingleTargetSpellEffect(OnCastStoneClaw));
					break;
				case 10427:
					bt.BaseHitPoints = 390;
					bt.HitPoints = 390*bonus;
					bt.Name = "Stoneclaw Totem V";
					bt.Id = 7398;
					bt.SummonTotem(c, 45, 2, 16f, TotemType.Earth, TotemTarget.Enemy, 10423, new SingleTargetSpellEffect(OnCastStoneClaw));
					break;
				case 10428:
					bt.BaseHitPoints = 480;
					bt.HitPoints = 480*bonus;
					bt.Name = "Stoneclaw Totem VI";
					bt.Id = 7399;
					bt.SummonTotem(c, 45, 2, 16f, TotemType.Earth, TotemTarget.Enemy, 10424, new SingleTargetSpellEffect(OnCastStoneClaw));
					break;
			}
		}

		public static void OnCastStoneClaw(BaseAbility ba, Mobile c, Mobile target)
		{
			//dunno if here should be an auraeffect
			//AuraEffect st = (AuraEffect)ba;
			//Aura a = new Aura();
			//if(target is BaseCreature) 
			//{
			//	target.AddAura(st, a);
			if(target is BaseCreature)
			{
				BaseCreature bc = target as BaseCreature;
				bc.BeginCombatWith(c);
			}
			//}
		}
		#endregion
		#region +Stoneskin Totem
		public static void OnCastStoneskinTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			bt.Model = 4588;
			switch(ba.Id)
			{
				case 8071:
					bt.Name = "Stoneskin Totem";
					bt.Id = 5873;
					bt.SummonTotem(c, 45, 0, 400f, TotemType.Earth, TotemTarget.Friends, 8072, new SingleTargetSpellEffect(OnCastStoneskin));
					break;
				case 8154:
					bt.Name = "Stoneskin Totem II";
					bt.Id = 5919;
					bt.SummonTotem(c, 60, 0, 400f, TotemType.Earth, TotemTarget.Friends, 8156, new SingleTargetSpellEffect(OnCastStoneskin));
					break;
				case 8155:
					bt.Name = "Stoneskin Totem III";
					bt.Id = 5920;
					bt.SummonTotem(c, 45, 0, 400f, TotemType.Earth, TotemTarget.Friends, 8157, new SingleTargetSpellEffect(OnCastStoneskin));
					break;
				case 10406:
					bt.Name = "Stoneskin Totem IV";
					bt.Id = 7366;
					bt.SummonTotem(c, 45, 0, 400f, TotemType.Earth, TotemTarget.Friends, 10403, new SingleTargetSpellEffect(OnCastStoneskin));
					break;
				case 10407:
					bt.Name = "Stoneskin Totem V";
					bt.Id = 7367;
					bt.SummonTotem(c, 45, 0, 400f, TotemType.Earth, TotemTarget.Friends, 10404, new SingleTargetSpellEffect(OnCastStoneskin));
					break;
				case 10408:
					bt.Name = "Stoneskin Totem VI";
					bt.Id = 7368;
					bt.SummonTotem(c, 45, 0, 400f, TotemType.Earth, TotemTarget.Friends, 10405, new SingleTargetSpellEffect(OnCastStoneskin));
					break;
			}
		}

		public static void OnCastStoneskin(BaseAbility ba, Mobile c, Mobile target)
		{//TODO: stoneskin totem talent added (crashes with null obj. reference)
			Console.WriteLine("Stoneskin Cast Begin");
			AuraEffect ae = (AuraEffect)ba;
			Console.WriteLine("Line1");
			Aura aura = new Aura();
			Console.WriteLine("Line2");
			if((c as BaseTotems).Caster.HaveTalent(Server.Talents.ImprovedStoneskinTotem))
			{
				Console.WriteLine("Line3");
				AuraEffect add = (AuraEffect)(c as BaseTotems).Caster.GetTalentEffect(Server.Talents.ImprovedStoneskinTotem);
				Console.WriteLine("Line4");
				aura.PhysicalAbsorb = ae.S1 + add.S1;
				Console.WriteLine("Line5");
				//(target as Character).SendMessage(String.Format("TalentBonus: S1={0}, S2={1}, S3={2}", add.S1.ToString(), add.S2.ToString(), add.S3.ToString()));
			}
			else 
			{
				Console.WriteLine("Line6");
				aura.PhysicalAbsorb = ae.S1;
				Console.WriteLine("Line7");
			}
			Console.WriteLine("Line8");
			//(c as Character).SendMessage(String.Format("OnCastStoneskin: S1={0}, S2={1}, S3={2}", ae.S1.ToString(), ae.S2.ToString(), ae.S3.ToString()));
            target.AddAura(c, ae, aura);
			Console.WriteLine("Stoneskin Successfull");
		}
		#endregion
		#region +Strength of Earth Totem
		public static void OnCastStrengthofEarthTotem(BaseAbility ba, Mobile c)
		{
			BaseTotems bt = new BaseTotems();
			bt.Model = 4588;
			switch(ba.Id)
			{
				case 8075:
					bt.Name = "Strength of Earth Totem";
					bt.Id = 5874;
					bt.SummonTotem(c, 45, 0, 400f, TotemType.Earth, TotemTarget.Friends, 8076, new SingleTargetSpellEffect(OnCastStrengthofEarth));
					break;
				case 8160:
					bt.Name = "Strength of Earth Totem II";
					bt.Id = 5921;
					bt.SummonTotem(c, 60, 0, 400f, TotemType.Earth, TotemTarget.Friends, 8162, new SingleTargetSpellEffect(OnCastStrengthofEarth));
					break;
				case 8161:
					bt.Name = "Strength of Earth Totem III";
					bt.Id = 5922;
					bt.SummonTotem(c, 75, 0, 400f, TotemType.Earth, TotemTarget.Friends, 8163, new SingleTargetSpellEffect(OnCastStrengthofEarth));
					break;
				case 10442:
					bt.Name = "Strength of Earth Totem IV";
					bt.Id = 7403;
					bt.SummonTotem(c, 90, 0, 400f, TotemType.Earth, TotemTarget.Friends, 10441, new SingleTargetSpellEffect(OnCastStrengthofEarth));
					break;
			}
		}

		public static void OnCastStrengthofEarth(BaseAbility ba, Mobile c, Mobile target)
		{//TODO: strength of the earth totem talent added (not tested)
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura();
			if((c as BaseTotems).Caster.HaveTalent(Server.Talents.ImprovedStrengthOfEarthTotem))
			{
				AuraEffect add = (AuraEffect)(c as BaseTotems).Caster.GetTalentEffect(Server.Talents.ImprovedStrengthOfEarthTotem);
				aura.StrBonus = (int)(ae.S1)*(1 + (add.S1/100));
				(target as Character).SendMessage(string.Format("OnCastStrengthofEarth: tS1={0} tS2={1} tS3={2}", add.S1.ToString(), add.S2.ToString(), add.S3.ToString()));
			}
			else aura.StrBonus = ae.S1;			
			target.AddAura(c, ae, aura);
		}
		#endregion
		#region Tremor Totem
		public static void OnCastTremorTotem(BaseAbility ba, Mobile c)
		{//spell ID = 8146
			/*BaseTotems bt = new BaseTotems(c, 90, 0, 900f, TotemType.Earth, TotemTarget.Friends, 8146, new SingleTargetSpellEffect(OnCastTremor));
			bt.Name = "Tremor Totem";
			bt.Id = 2630;
			bt.Model = 4588;
			//bt.SummonTotem(c, 45, 20f, TotemTarget.Friends, 8072, new SingleTargetSpellEffect(OnCastTremor));*/
		}

		public static void OnCastTremor(BaseAbility ba, Mobile c, Mobile target)
		{
			/*for(int i=0; i<target.Auras; i++)
			{
				if((target.Auras[i] as AuraEffect).Dispeltype
			}*/
		}
		#endregion
		#region Water Breathing
		public static void OnCastWaterBreathing(BaseAbility ba, Mobile c, Mobile target)
		{
		}
		#endregion
		#region Water Walking
		public static void OnCastWaterWalking(BaseAbility ba, Mobile c, Mobile target)
		{
		}
		#endregion
		#region Windfury Totem
		public static void OnCastWindfuryTotem(BaseAbility ba, Mobile c)
		{
/*			BaseTotems bt = new BaseTotems();
			bt.Name = "Windfury Totem";
			bt.Id = 6112;
			bt.Model = 4588;
			switch(ba.Id)
			{
				case 8512:
					bt.SummonTotem(c, 90, 400f, TotemType.Earth, TotemTarget.Friends, 8516, new SingleTargetSpellEffect(OnCastWindfury));
					break;
				case 10613:
					bt.SummonTotem(c, 90, 400f, TotemType.Earth, TotemTarget.Friends, 10608, new SingleTargetSpellEffect(OnCastWindfury));
					break;
				case 10614:
					bt.SummonTotem(c, 90, 400f, TotemType.Earth, TotemTarget.Friends, 10610, new SingleTargetSpellEffect(OnCastWindfury));
					break;
			}*/
		}

		public static void OnCastWindfury(BaseAbility ba, Mobile c, Mobile target)
		{
/*			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.AgBonus = st.Bonus1;
			if( Utility.Random(100) < 20 ) aura.AttackPowerBonus = st.S1;
			Console.WriteLine("OnCastEarthbind st.S1={0} st.S2={1} st.S3={2}", st.S1.ToString(), st.S2.ToString(), st.S3.ToString());
			target.AddAura(st, aura);*/
		}
		#endregion
		#region Windfury Weapon
		public static void OnCastWindfuryWeapon(BaseAbility ba, Mobile c)
		{
		}
		#endregion
		#region Windwall Totem
		public static void OnCastWindwallTotem(BaseAbility ba, Mobile c)
		{
		}
		#endregion
		#endregion
	}
}