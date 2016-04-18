/*
 * Date: 10.09.2005
 * TrapTimer.TrapsList = new ArrayList();
 * new TrapTimer(1001).Start();
 * Without this string traps don't work
 */
using System;
using Server;
using System.Collections;
using HelperTools;
using System.Reflection;

namespace Server.Creatures
{
	
	public class BaseTrap : BaseCreature
	{
		public ArrayList AffMobs;
		public ArrayList ImmunMobs;
		public int LifeTime;
		protected float area;
		protected int spellID;
		protected Mobile caster;
		protected SingleTargetSpellEffect effectHandler;
		public BaseTrap()
		{
			AffMobs = new ArrayList();
			ImmunMobs = new ArrayList();
		}
		protected void UpdateLists()
		{
			foreach(Object obj in this.KnownObjects())
			{
				if(obj is Mobile)
				{
					Mobile mob = obj as Mobile;
					if(AffMobs.Contains(mob))
					{
						if(mob.Dead | this.Distance(mob)>area)
						{
							AffMobs.Remove(mob);
							mob.ReleaseAura((Abilities.abilities[ spellID ] as AuraEffect));
						}
						continue;
					}
					if(ImmunMobs.Contains(mob))
					{
						if(mob.Dead | this.Distance(mob)>area)
						{
							ImmunMobs.Remove(mob);
							mob.ReleaseAura((Abilities.abilities[ spellID ] as AuraEffect));
						}
						continue;
					}
					if(!mob.Dead && this.Distance(mob)<area && this.Faction != mob.Faction)
					{
						AffMobs.Add(mob);
					}
				}
			}
		}
		public void SummonTrap(float _area, int _lifeTime, int _spellId, Mobile _caster, SingleTargetSpellEffect effect)
		{
//			if(caster.AdditionnalStates.Count>0)
//			{
//				for(int i=0; i<caster.AdditionnalStates.Count; i++)
//				{
//					if (caster.AdditionnalStates[i] is BaseTrap)
//					{
//						BaseTrap tr = caster.AdditionnalStates[i] as BaseTrap;
//						caster.AdditionnalStates.RemoveAt(i);
//						TrapTimer.TrapsList.Remove(tr);
//						tr.Remove();
//						i--;	
//					}
//				}
//			}
			area = _area;
			LifeTime = _lifeTime;
			spellID = _spellId;
			caster = _caster;
			effectHandler = effect;
			
			caster.AdditionnalStates.Add(this);
			Level = caster.Level;
			Freeze  = true;
			Faction = caster.Faction;
			SummonedBy = caster;
			Visible = InvisibilityLevel.GM;
			BaseHitPoints = caster.BaseHitPoints / 4;
			
			World.Add(this, caster.X, caster.Y, caster.Z, caster.MapId);
			TrapTimer.TrapsList.Add(this);
		}
		public virtual void ApllyEffect()
		{
		}
		public void Remove()
		{
			foreach (Mobile m in this.AffMobs)
			{
				m.ReleaseAura((Abilities.abilities[ spellID ] as AuraEffect));
			}
			this.ImmunMobs.Clear();
			this.AffMobs.Clear();
			this.caster.Summon = null;
			TrapTimer.TrapsList.Remove(this);
			World.Remove( this, caster );
		}
	}
	public class ImmolationTrap : BaseTrap
	{
		public ImmolationTrap()
		{
			AffMobs = new ArrayList();
			ImmunMobs = new ArrayList();
		}
		public override void ApllyEffect()
		{
			UpdateLists();
			if(AffMobs.Count > 0)
			{
				Mobile target = AffMobs[Utility.Random(AffMobs.Count)] as Mobile;
				FakeCast(spellID, target);
					effectHandler( Abilities.abilities[ spellID ], this, target );
				Remove();
			}
		}
	}
	public class TrapTimer : WowTimer
	{
		public static ArrayList TrapsList;

 		public TrapTimer(double time) : base(time)
		{
		}
 		public override void OnTick()
		{
			if(TrapsList.Count > 0)
			{
				BaseTrap trap;
				for(int i=0; i< TrapsList.Count; i++)
				{
					
						if( TrapsList[i] is BaseTrap )
						{
							trap = (TrapsList[i] as BaseTrap);
							trap.ApllyEffect();
							trap.LifeTime--;
							if (trap.LifeTime <= 0)
							{
								TrapsList.Remove(trap);
								trap.Remove();
								i--;
							}
						}
					}
				}
			}
		}
	}
