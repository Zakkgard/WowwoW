using Server;
using HelperTools;
using System.Collections;

namespace Server
{
	public class ItemsSpells
	{
		


		#region AttackPowerXX
		public static void OnAttackPowerXX(BaseAbility ba, Mobile c)
		{
			/* when attackpower++ be done
			 * AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.AtackPowerBonus = st.S1;
			c.AddAura( st, aura );	
			*/					
		}
		#endregion
		#region IncreasedArmor 100%
		public static void OnIncreasedArmor(BaseAbility ba, Mobile c)
		{			 
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.ArmorBonus = st.S1;
			c.AddAura( st, aura );	
		}
		#endregion
		#region AttackPowerBowXX
		public static void OnAttackPowerBowXX(BaseAbility ba, Mobile c)
		{			 
			/* when attackpower++ be done
			 * AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.AtackPowerBowBonus = st.S1;
			c.AddAura( st, aura );	
			*/	
		}
		#endregion
		#region Drink
		#region DrinkAura
		public class DrinkAura : Aura
		{
            public class DrinkTimer : WowTimer
            {
                private AuraEffect ae;
                private Mobile caster;
                private int amount;
                private ushort nTimes;
                private bool odd;
				private bool send;
				private byte[] buffer;

                public DrinkTimer(AuraEffect _ae, Mobile _caster, int _duration)
                    : base(Priorities.Milisec100, 2000)
                {
                    this.ae = _ae;
                    this.caster = _caster;
                    this.amount = (int)((_ae.S1 / 2.5) + 1);
                    if ((_duration % 2000) != 0)
                    {
                        this.nTimes = (ushort)(_duration / 2000);
                        odd = true;
                    }
                    else
                    {
                        this.nTimes = (ushort)((_duration / 2000) - 1);
                        odd = false;
                    }
					this.send = false;
					this.buffer = new byte[128];
                }

                public override void OnTick()
                {
                    if ((caster.StandState != StandStates.Sitting) || (caster.InCombat))
                    {
                        caster.ReleaseAura(ae);
                        return;
                    }

					if (send)
					{
						int i = 4;
						Converter.ToBytes(caster.Guid, buffer, ref i);
						Converter.ToBytes(caster.Guid, buffer, ref i);
						Converter.ToBytes(ae.Id, buffer, ref i);
						Converter.ToBytes((ushort)0, buffer, ref i);
						Converter.ToBytes((byte)0, buffer, ref i);
						Converter.ToBytes((byte)0, buffer, ref i);
						Converter.ToBytes((ushort)0, buffer, ref i);
						caster.ToAllPlayerNear(OpCodes.SMSG_SPELL_GO, buffer, i);

						send = false;
					}
					else
					{
						send = true;
					}

                    caster.GainMana(caster, amount);

                    nTimes--;
                    if (nTimes <= 0)
                    {
                        Stop();
                    }
                }

                public void DrinkAuraReleased(Mobile from)
                {
                    Stop();

                    if ((caster.StandState == StandStates.Sitting) || (!caster.InCombat))
                    {
                        if (odd)
                        {
                            caster.GainMana(caster, (amount / 2));
                        }
                        else
                        {
                            caster.GainMana(caster, amount);
                        }
                    }
                }
            }

            public DrinkAura(AuraEffect _ae, Mobile _caster, int _duration)
			{
                DrinkTimer drinkTimer = new DrinkTimer(_ae, _caster, _duration);
                this.OnRelease = new Aura.AuraReleaseDelegate((drinkTimer as DrinkTimer).DrinkAuraReleased);
                drinkTimer.Start();
			}
		}
		#endregion
		public static void OnDrink(BaseAbility ba, Mobile from)
		{
			if ((!from.Dead) && (!from.InCombat))
			{
				if (from.StandState != StandStates.Sitting)
				{
					from.StandState = StandStates.Sitting;
					from.SendSmallUpdateToPlayerNearMe(new int[] { 143 }, new object[] { (uint)1 });
				}

				AuraEffect ae = (AuraEffect)ba;
				DrinkAura aura = new DrinkAura(ae, from, ae.Duration(from));
				from.AddAura(ae, aura);
			}
		}
		#endregion
		#region Food
		#region FoodAura
		public class FoodAura : Aura
		{
			public class FoodTimer : WowTimer
			{
				private AuraEffect ae;
				private Mobile caster;
				private int amount;
				private ushort nTimes;
				private ushort count;
				private bool odd;
				private bool send;
				private bool gainmana;
				private byte[] buffer;

				public FoodTimer(AuraEffect _ae, Mobile _caster, int _duration)
					: base(Priorities.Milisec100, 2000)
				{
					this.ae = _ae;
					this.caster = _caster;
					this.amount = (int)((_ae.S1 / 2.5) + 1);

					if ((_duration % 2000) != 0)
					{
						this.nTimes = (ushort)(_duration / 2000);
						odd = true;
					}
					else
					{
						this.nTimes = (ushort)((_duration / 2000) - 1);
						odd = false;
					}

					this.count = 0;
					this.send = false;
					this.gainmana = (_ae.Id == 2639);
					this.buffer = new byte[128];
				}

				public override void OnTick()
				{
					if ((caster.StandState != StandStates.Sitting) || (caster.InCombat))
					{
						caster.ReleaseAura(ae);
						return;
					}

					if (send)
					{
						int i = 4;
						Converter.ToBytes(caster.Guid, buffer, ref i);
						Converter.ToBytes(caster.Guid, buffer, ref i);
						Converter.ToBytes(ae.Id, buffer, ref i);
						Converter.ToBytes((ushort)0, buffer, ref i);
						Converter.ToBytes((byte)0, buffer, ref i);
						Converter.ToBytes((byte)0, buffer, ref i);
						Converter.ToBytes((ushort)0, buffer, ref i);
						caster.ToAllPlayerNear(OpCodes.SMSG_SPELL_GO, buffer, i);

						send = false;
					}
					else
					{
						send = true;
					}

					caster.GainHealth(caster, amount);
					if (gainmana) caster.GainMana(caster, amount);

					count++;
					if (count == 5)
					{
						/*
						System.Console.WriteLine("Additional: " + ae.AdditionalSpell);
						if (ae.AdditionalSpell2 != 0) caster.CastOnSelf(false, ae.AdditionalSpell, 0);											
						*/
						int casting = 0;

						switch (ae.Id)
						{
							case 5004: casting = 19705; break;
							case 5005: casting = 19706; break;
							case 5006: casting = 19708; break;
							case 5007: casting = 19709; break;
							case 10256: casting = 19710; break;
							case 10257: casting = 19711; break;
							case 18230: casting = 18192; break;
						}
						if (casting != 0) ((OnSelfSpellEffect)SpellTemplate.SpellEffects[casting])(Abilities.abilities[casting], caster);
					}

					nTimes--;
					if (nTimes <= 0)
					{
						Stop();
					}
				}

				public void FoodAuraReleased(Mobile from)
				{
					Stop();

					if ((caster.StandState == StandStates.Sitting) || (!caster.InCombat))
					{
						if (odd)
						{
							caster.GainHealth(caster, (amount / 2));
							if (gainmana) caster.GainMana(caster, (amount / 2));
						}
						else
						{
							caster.GainHealth(caster, amount);
							if (gainmana) caster.GainMana(caster, amount);
						}
					}
				}
			}

			public FoodAura(AuraEffect _ae, Mobile _caster, int _duration)
			{				
				FoodTimer foodTimer = new FoodTimer(_ae, _caster, _duration);
				this.OnRelease = new Aura.AuraReleaseDelegate((foodTimer as FoodTimer).FoodAuraReleased);
				foodTimer.Start();
			}
		}
		#endregion
		#region BaseFood
		public static void OnBaseFood(BaseAbility ba, Mobile from)
		{
			if (!from.Dead && !from.InCombat)
			{
				if (from.StandState != StandStates.Sitting)
				{
					from.StandState = StandStates.Sitting;
					from.SendSmallUpdateToPlayerNearMe(new int[] { 143 }, new object[] { (uint)1 });
				}

				AuraEffect ae = (AuraEffect)ba;
				FoodAura aura = new FoodAura(ae, from, ae.Duration(from));
				from.AddAura(ae, aura);
			}
		}
		#endregion
		#region FoodType2
		public static void OnFoodType2(BaseAbility ba, Mobile from)
		{
			if (!from.Dead && !from.InCombat)
			{
				if (from.StandState != StandStates.Sitting)
				{
					from.StandState = StandStates.Sitting;
					from.SendSmallUpdateToPlayerNearMe(new int[] { 143 }, new object[] { (uint)1 });
				}

				AuraEffect ae = (AuraEffect)ba;
				FoodAura aura = new FoodAura(ae, from, ae.Duration(from));
				from.AddAura(ae, aura);
				
				int casting = 0;
				switch (ae.Id)
				{
					case 18229: casting = 18191; break;
					case 18234: casting = 18191; break;
					case 18231: casting = 18193; break;
					case 18232: casting = 18222; break;
					case 18233: casting = 18194; break;
					case 22731: casting = 18191; break;
				}
				if (casting != 0) ((OnSelfSpellEffect)SpellTemplate.SpellEffects[casting])(Abilities.abilities[casting], from);
			}
		}
		#endregion
		#region food effects
		public static void OnFoodEffect1(BaseAbility ba, Mobile c)
		{
			
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.SpiritBonus = st.S1;
			aura.StaminaBonus = st.S1;
			c.AddAura( st, aura );
			
		}
		public static void OnFoodEffect2(BaseAbility ba, Mobile c)
		{
			
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.AgBonus = st.S1;
			c.AddAura( st, aura );
		}
		public static void OnFoodEffect3(BaseAbility ba, Mobile c)
		{
			
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.StaminaBonus = st.S1;
			c.AddAura( st, aura );
		}
		public static void OnFoodEffect4(BaseAbility ba, Mobile c)
		{
			
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.SpiritBonus = st.S1;
			c.AddAura( st, aura );
		}
		public static void OnFoodEffect5(BaseAbility ba, Mobile c)
		{
			
			AuraEffect st = (AuraEffect)ba;
			HotAura aura = new HotAura(st,c,c,(st.S1+1), st.Duration( c ), st.T2);
			c.AddAura( st, aura );
		}
		public static void OnFoodEffect6(BaseAbility ba, Mobile c)
		{
			
			AuraEffect st = (AuraEffect)ba;
			MotAura aura = new MotAura(st,c,c,(st.S1+1), st.Duration( c ), st.T2);
			c.AddAura( st, aura );
		}
		#endregion
		#endregion
		#region stones 
		public static void OnHealthStones(BaseAbility ba, Mobile c) 
		{             
			SpellTemplate st = (SpellTemplate)ba; 
			st.Heal( c, c, SpellDamage.TypeS1 ); 
		} 
		public static void OnSpellStones(BaseAbility ba, Mobile c) 
		{             
			AuraEffect st = (AuraEffect)ba; 
			c.ReleaseAllAura(); 
			Aura aura = new Aura(); 
			if ( c.HaveTalent( Talents.ImprovedSpellstone ) )
			{
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedSpellstone );
				float abs = (float)st.S2;
				abs += abs * ( (float)ae.S1 ) / 100f;
				aura.AbsorbAllMagic = (int)abs; 
			}
			else
				aura.AbsorbAllMagic = st.S2; 

			c.AddAura(st,aura); 
		} 

		#endregion 

		

    }
}
