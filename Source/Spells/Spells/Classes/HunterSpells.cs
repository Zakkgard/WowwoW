using Server;
using HelperTools;
using Server.Creatures;

namespace Server
{
	public class HunterSpells
	{
		#region Hunter spells -> cca 10%
			#region Arcane Shot 100% test	
				public static void OnCastArcaneShot( BaseAbility ba, Mobile c, Mobile target )
				{
					SpellTemplate st = (SpellTemplate)ba;
					st.MakeDamage(c,target,SpellDamage.TypeS1);
				}		
			#endregion
			#region Aspect of the Beast 0%
				public static void OnCastAspectoftheBeast( BaseAbility ba, Mobile c){}		
			#endregion
			#region Aspect of the Cheetah 50% test need triger
				public static void OnCastAspectoftheCheetah( BaseAbility ba, Mobile c)
				{	
					AuraEffect af = (AuraEffect)ba;
					Aura aura = new Aura();
					aura.SpeedModifier = (1 + (af.S1+1)/100);
					c.AddAura(af,aura);
				}		
			#endregion
			#region Aspect of the Hawk	100% but affeckt attack power no ranged ap
				public static void OnCastAspectoftheHawk( BaseAbility ba, Mobile c)
				{	// 1
					AuraEffect af = (AuraEffect)ba;
					Aura aura = new Aura();
					aura.AttackPowerBonus = af.S1+1;
					c.AddAura(af,aura);
				}		
			#endregion
			#region Aspect of the Monkey	0% when dodge then 100%						
				public static void OnCastAspectoftheMonkey( BaseAbility ba, Mobile c)
				{
					AuraEffect af = (AuraEffect)ba;
					Aura aura = new Aura();
					//aura.DodgeBonus = S1+1;
					c.AddAura(af,aura);
				}		
			#endregion
			#region Aspect of the Pack	0% when group then 100% if trigger
				public static void OnCastAspectofthePack( BaseAbility ba, Mobile c){}		
			#endregion
			#region Aspect of the Wild	0% when group then 100%						
				public static void OnCastAspectoftheWild( BaseAbility ba, Mobile c){}		
			#endregion
			#region Beast Lore	0% but can be
				public static void OnCastBeastLore( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Beast Training	0%					
				public static void OnCastBeastTraining( BaseAbility ba, Mobile c){}		
			#endregion
			#region Bite	0%	
				public static void OnCastBite( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Call Pet 0%
				public static void OnCastCallPet( BaseAbility ba, Mobile c){}		
			#endregion
			#region Claw 0%	
				public static void OnCastClaw( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Concussive Shot	100% test					
				public static void OnCastConcussiveShot( BaseAbility ba, Mobile c, Mobile target )
				{
					AuraEffect af = (AuraEffect)ba;
					Aura aura = new Aura();
					aura.SpeedModifier = ((af.S1+1)/100);
					target.AddAura(af,aura);
				}		
			#endregion
			#region Cower 0%
				public static void OnCastCower( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Disengage 50% test	
				public static void OnCastDisengage( BaseAbility ba, Mobile c, Mobile target )
				{
					AuraEffect st = (AuraEffect)ba;
					Aura aura = new Aura();
					aura.OnRelease = new Aura.AuraReleaseDelegate(OnCastDisengageEnded);
					c.Visible = InvisibilityLevel.Lesser;
					c.AddAura(st, aura);
				}
			public static void OnCastDisengageEnded(Mobile c)
			{
				c.Visible = InvisibilityLevel.Visible;
			}		
			#endregion
			#region Dismiss Pet	0%
				public static void OnCastDismissPet( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Distracting Shot 0%
				public static void OnCastDistractingShot( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Eagle Eye 0%
				public static void OnCastEagleEye( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Explosive Trap	0%
				public static void OnCastExplosiveTrap( BaseAbility ba, Mobile c){}		
			#endregion
			#region Eyes of the Beast 0%
				public static void OnCastEyesoftheBeast( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Feed Pet 0%	
				public static void OnCastFeedPet( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Feign Death	0%
				public static void OnCastFeignDeath( BaseAbility ba, Mobile c){}		
			#endregion
			#region Flare 0%
				public static void OnCastFlare( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Freezing Trap	0%	
				public static void OnCastFreezingTrap( BaseAbility ba, Mobile c){}		
			#endregion
			#region Frost Trap 0%	
				public static void OnCastFrostTrap( BaseAbility ba, Mobile c){}		
			#endregion
			#region Hunter's Mark 0%		
				public static void OnCastHuntersMark( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Immolation Trap 0%		
				public static void OnCastImmolationTrap( BaseAbility ba, Mobile c)
				{
					ImmolationTrap trap = new ImmolationTrap();
					trap.Model = 3074;
					//trap.Visible = InvisibilityLevel.GM;
					switch(ba.Id)
					{
						case 13795:
							{
								trap.Name = "ImmolationTrap I";
								trap.Id = 164638;
								trap.SummonTrap(2.5f, 60, 13797, c, new SingleTargetSpellEffect(OnCastImmolationTrapEffect));
								break;
							}
					}
				}
				public static void OnCastImmolationTrapEffect(BaseAbility ba, Mobile c, Mobile target)
				{
					SpellTemplate st = (SpellTemplate)ba;
					st.MakeDamage(c, target, st.S1);
				}
			#endregion
			#region Mend Pet 0%
				public static void OnCastMendPet( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Mongoose Bite 0% after dodge		
				public static void OnCastMongooseBite( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region MultiShot 0%	
				public static void OnCastMultiShot( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Rapid Fire 0%
				public static void OnCastRapidFire( BaseAbility ba, Mobile c)
				{}		
			#endregion
			#region Raptor Strike 100% test	
				public static void OnCastRaptorStrike( BaseAbility ba, Mobile c, Mobile target )
				{
					SpellTemplate st = (SpellTemplate)ba;
					int num1 = c.Hit( target  );
					num1 +=st.S1+1;
					target.LooseHits(c, num1);
				}		
			#endregion
			#region Revive Pet	0%
				public static void OnCastRevivePet( BaseAbility ba, Mobile c){}		
			#endregion
			#region Scare Beast	100% test
				public static void OnCastScareBeast( BaseAbility ba, Mobile c, Mobile target )
				{
					AuraEffect af = (AuraEffect)ba;
					Aura aura = new Aura();
					aura.ForceFlee = true;
					target.AddAura(af,aura);
				}		
			#endregion
			#region Scorpid Sting	100% when multiple auras
				public static void OnCastScorpidSting( BaseAbility ba, Mobile c, Mobile target )
				{
					AuraEffect af = (AuraEffect)ba;
					Aura aura = new Aura();
					aura.AgMalus = af.S1+1;
					aura.StrMalus = af.S1+1;
					target.AddAura(af,aura);
				}		
			#endregion
			#region Serpent Sting	100% test
				public static void OnCastSerpentSting( BaseAbility ba, Mobile c, Mobile target )
				{
					SpellTemplate st = (SpellTemplate)ba;
					st.ApplyDot( c, target, st.S1, st.T2, st.Duration( c ) );	
				}		
			#endregion
			#region Spirit Bond	0%
				public static void OnCastSpiritBond( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Tame Beast 0%
				public static void OnCastTameBeast( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Track Beasts 100%
				public static void OnCastTrackBeasts( BaseAbility ba, Mobile c)
				{
					Aura.SetDetectCreature( TrackableCreatures.Beast, c );
				}		
			#endregion
			#region Track Demons
				public static void OnCastTrackDemons( BaseAbility ba, Mobile c){}		
			#endregion
			#region Track Dragonkin	
				public static void OnCastTrackDragonkin( BaseAbility ba, Mobile c){}		
			#endregion
			#region Track Elementals
				public static void OnCastTrackElementals( BaseAbility ba, Mobile c){}		
			#endregion
			#region Track Giants	
				public static void OnCastTrackGiants( BaseAbility ba, Mobile c){}		
			#endregion
			#region Track Hidden
				public static void OnCastTrackHidden( BaseAbility ba, Mobile c){}		
			#endregion
			#region Track Humanoids	
				public static void OnCastTrackHumanoids( BaseAbility ba, Mobile c){}		
			#endregion
			#region Track Undead	
				public static void OnCastTrackUndead( BaseAbility ba, Mobile c){}		
			#endregion
			#region Tranquilizing Shot 0%	
				public static void OnCastTranquilizingShot( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Viper Sting	0%
				public static void OnCastViperSting( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Volley 0%
				public static void OnCastVolley( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Wing Clip	100% test	
				public static void OnCastWingClip( BaseAbility ba, Mobile c, Mobile target )
				{
					SpellTemplate st = (SpellTemplate)ba;
					st.MakeDamage( c, target, SpellDamage.TypeS2 );
					AuraEffect af = (AuraEffect)ba;
					Aura aura = new Aura();
					aura.SpeedModifier = ((af.S1)/100);
					target.AddAura( af, aura );
				}		
			#endregion
			#endregion
	}
}
