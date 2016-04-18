
using System;
using Server;
using HelperTools;
using System.Collections;

namespace Server
{
    public class MageSpells
    {
		#region HELPS
        #region AdditionnalStates
        public class PolymorphCasted
        {
            public Mobile caster;
            public Mobile target;
            public AuraEffect ae;

            public PolymorphCasted(Mobile _caster, Mobile _target, AuraEffect _ae)
            {
                this.caster = _caster;
                this.target = _target;
                this.ae = _ae;
            }
        }

        public class HaveMagicArmor
        {
            public Mobile caster;
            public AuraEffect ae;

            public HaveMagicArmor(Mobile _caster, AuraEffect _ae)
            {
                this.caster = _caster;
                this.ae = _ae;
            }
        }
		public class HaveMagicBuff
		{
			public Mobile caster;
			public AuraEffect ae;

			public HaveMagicBuff(Mobile _caster, AuraEffect _ae)
			{
				this.caster = _caster;
				this.ae = _ae;
			}
		}
        #endregion

        #region MagicArmor
        public class MagicArmorAura : Aura
        {
            public HaveMagicArmor haveMagicArmor;

            public MagicArmorAura(HaveMagicArmor _haveMagicArmor)
            {
                foreach (object obj in _haveMagicArmor.caster.AdditionnalStates)
                {
					if (obj is HaveMagicArmor)
					{
						(obj as HaveMagicArmor).caster.ReleaseAura((obj as HaveMagicArmor).ae);
						break;
					}
                }
              
                this.haveMagicArmor = _haveMagicArmor;
                this.OnRelease = new Aura.AuraReleaseDelegate(this.MagicArmorAuraRelease);

                this.haveMagicArmor.caster.AdditionnalStates.Add(haveMagicArmor);
            }

            public void MagicArmorAuraRelease(Mobile from)
            {
                haveMagicArmor.caster.AdditionnalStates.Remove(haveMagicArmor); 
            }
        }
        #endregion

		#region MagicBuff
		public class MagicBuff : Aura
		{
			public HaveMagicBuff haveMagicBuff;

			public MagicBuff(HaveMagicBuff _haveMagicBuff)
			{
				foreach (object obj in _haveMagicBuff.caster.AdditionnalStates)
				{
					if (obj is HaveMagicBuff)
					{
						(obj as HaveMagicBuff).caster.ReleaseAura((obj as HaveMagicBuff).ae);
						break;
					}
				}
              
				this.haveMagicBuff = _haveMagicBuff;
				this.OnRelease = new Aura.AuraReleaseDelegate(this.MagicArmorBuffRelease);

				this.haveMagicBuff.caster.AdditionnalStates.Add(haveMagicBuff);
			}

			public void MagicArmorBuffRelease(Mobile from)
			{
				haveMagicBuff.caster.AdditionnalStates.Remove(haveMagicBuff); 
			}
		}
		#endregion
		#endregion

		#region OVERRIDED AURAS
        #region other Auras
        public class DrainManaAura : Aura
        {
            public DrainManaAura(SpellTemplate st, Mobile c, Mobile t)
            {
                if (!t.Dead)
                {
                    this.spell = st;
                    this.from = c;
                    this.target = t;
                    base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicDrainMana), st.Duration( c ) , st.T1);
                }
            }
            Mobile from;
            Mobile target;
            SpellTemplate spell;
            public void PeriodicDrainMana()
            {            
                this.spell.DrainMana( this.from, this.target, SpellDamage.TypeS1);
            }
        }
        #endregion
		#region Arcane Auras
		#region Portals
		public class PortalObject : GameObject
		{
			int gameObjectId;
			public PortalObject(): base ()
			{
			}
			public PortalObject(int _gameObjectId, float X, float Y, float Z, ushort MapId) : base(_gameObjectId, X, Y, Z, MapId)
			{
				gameObjectId=_gameObjectId;
			}
			public override bool OnUse(Mobile from)
			{
				Character ch = from as Character;
				switch(gameObjectId)
				{
					case 176498: // darnassus
						if ( ch.Race == Races.Human || ch.Race == Races.Dwarf 
							|| ch.Race == Races.NightElf || ch.Race == Races.Gnome )
						{
							ch.Teleport( 9951.792969f, 2145.915771f, 1327.724854f, 1 );
						}
						break;
					case 176497: // IronForge
						if ( ch.Race == Races.Human || ch.Race == Races.Dwarf 
							|| ch.Race == Races.NightElf || ch.Race == Races.Gnome )
						{
							ch.Teleport( -5032f, -819f, 495f, 0 );
						}
						break;
					case 176499: // Orgrimmar
						if ( ch.Race == Races.Orc || ch.Race == Races.Undead 
							|| ch.Race == Races.Tauren || ch.Race == Races.Troll )
						{
							ch.Teleport( 1552.499268f, -4420.658691f, 8.948024f, 1 );
						}
						break;
					case 176296: // Stormwind
						if ( ch.Race == Races.Human || ch.Race == Races.Dwarf 
							|| ch.Race == Races.NightElf || ch.Race == Races.Gnome )
						{
							ch.Teleport( -8960.140625f, 516.265686f, 96.356819f, 0 );
						}
						break;
					case 176500: // ThunderBluff
						if ( ch.Race == Races.Orc || ch.Race == Races.Undead 
							|| ch.Race == Races.Tauren || ch.Race == Races.Troll )
						{
							ch.Teleport( -1391.0f, 140.0f, 22.478f, 1 );
						}
						break;
					case 176501: // UnderCity
						if ( ch.Race == Races.Orc || ch.Race == Races.Undead 
							|| ch.Race == Races.Tauren || ch.Race == Races.Troll )
						{
							ch.Teleport( 1819.708374f, 238.789505f, 60.532143f, 0 );
						}
						break;
				}
				return true;
			}
			public override bool OnRelease(Mobile from)
			{
				return base.OnRelease(from);
			}
		}
		public class PortalEffect : WowTimer
		{ 
			PortalObject from; 
			Character ch; 
			int nTime;

			public PortalEffect( Character castr, int cast, int every, int n ) :  base( every ) 
			{ 
                
				ch = castr;
				nTime = n; 
				float distance = 3.0f; // 3 yards
				double X = ch.X;
				double Y = ch.Y;
				double r1 = System.Math.Sqrt(distance*distance/((System.Math.Tan(ch.Orientation)*System.Math.Tan(ch.Orientation)+1)));
				double r2 = System.Math.Tan(ch.Orientation)*r1;
				if ( ch.Orientation >= 0 && ch.Orientation <= System.Math.PI/2 || ch.Orientation == System.Math.PI*2 )
				{
					X += r1;
					Y += r2;
				}
				else if ( ch.Orientation > System.Math.PI/2  && ch.Orientation < System.Math.PI)
				{
					X += r1;
					Y -= r2;
				}
				else if ( ch.Orientation >= System.Math.PI  && ch.Orientation <= System.Math.PI*3/2)
				{
					X -= r1;
					Y -= r2;
				}
				else if ( ch.Orientation > System.Math.PI*3/2  && ch.Orientation < System.Math.PI*2)
				{
					X -= r1;
					Y += r2;
				}
				from = new PortalObject(cast, (float)X, (float)Y, ch.Z, ch.MapId);
				World.allGameObjects.Add(from);
			} 
			public override void OnTick() 
			{ 
				nTime--; 
				if ( nTime <= 0 ) 
				{ 
					Stop(); 
					World.Remove( from, ch ); 
				} 
			}
		}
		#endregion
		#endregion
		#region Frost Auras
		public class ChilledAura : Aura
		{
			// Methods
			public ChilledAura()
			{
			}
			// Properties
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
			public override float AttackSpeedModifier
			{
				get
				{
					return this.attackSpeedModifier;
				}
				set
				{
					this.attackSpeedModifier = value;
				}

			}
			// Fields
			private float speedModifier;
			private float attackSpeedModifier;
		}
        
		public class FrostNovaAura : Aura
		{
			// Methods
			public FrostNovaAura()
			{
			}

			// Properties
			public override bool ForceRoot
			{
				get
				{
					return this.forceRoot;
				}
				set
				{
					this.forceRoot = value;
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
			// Fields
			private bool forceRoot;
			private int onMeleeHit;
			private int onSpellHit;
		}

		public class FrostArmorAura : MagicArmorAura
		{
			// Methods
			public FrostArmorAura(HaveMagicArmor _haveMagicArmor) : base(_haveMagicArmor)
			{
			}
			// Properties
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
			// Fields
			private int armorBonus;
			private int onMeleeHit;
			private int onSpellHit;
		}

		public class IceArmorAura : MagicArmorAura
		{
			// Methods
			public IceArmorAura(HaveMagicArmor _haveMagicArmor) : base(_haveMagicArmor)
			{
			}
			// Properties
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
			public override int FrostResistanceBonus
			{
				get
				{
					return this.frostResistanceBonus;
				}
				set
				{
					this.frostResistanceBonus   = value;
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
			// Fields
			private int armorBonus;
			private int frostResistanceBonus;
			private int onMeleeHit;
			private int onSpellHit;  
		}
		#endregion
		#endregion

		#region SPELLS
		#region Arcane Spells 80%

		#region AmplifyMagic 100%
		#region AmplifyMagicAura
		public class AmplifyMagicAura : MagicBuff
		{
			//TODO: Amplify mechanics based on wow wiki
			//http://www.wowwiki.com/Amplify_Magic
			//Note that it's "up to" the number given. The actual amount damage/healing is increased depends on the spell being altered. See the page on damage bonuses from gear. Amplify Magic works in the same way as Type One gear.

			private int spellDamageTakenBonus;
			private int healTakeIncrease;

			public AmplifyMagicAura(HaveMagicBuff _haveMagicBuff)
				: base(_haveMagicBuff)
			{
			}

			public override int SpellDamageTakenBonus
			{
				get
				{
					return this.spellDamageTakenBonus;
				}
				set
				{
					this.spellDamageTakenBonus = value;
				}
			}
			public override int HealTakeIncrease
			{
				get
				{
					return this.healTakeIncrease;
				}
				set
				{
					this.healTakeIncrease = value;
				}
			}
		}
		#endregion
		public static void OnCastAmplifyMagic(BaseAbility ba, Mobile from, Mobile target)
		{
			AuraEffect ae = (AuraEffect)ba;

			HaveMagicBuff haveMagicBuff = new HaveMagicBuff(from, ae);
            
			AmplifyMagicAura aura = new AmplifyMagicAura(haveMagicBuff);
			aura.SpellDamageTakenBonus = ae.S1;
			aura.HealTakeIncrease = ae.S2;

			target.AddAura(ae, aura);
		}
		#endregion

		#region Arcane Explosion 100%
		public static void OnCastArcaneExplosion(BaseAbility ba, Mobile from,ArrayList targets) // Thanks bovi & DrNexus
		{   
			SpellTemplate st = (SpellTemplate)ba;
			foreach (Mobile target in targets)
			{
				st.MakeDamage(from, target, SpellDamage.TypeS1);        
			}
		}
		#endregion

		#region Arcane Intellect 100%
		public static void OnCastArcaneIntellect( BaseAbility ba, Mobile from, Mobile target )
		{   
			AuraEffect st = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.IQBonus = st.S1;
			target.AddAura( st, aura );
		}
		#endregion

		#region Arcane Missiles 100%
		public class ArcaneMissilesEffect : WowTimer
		{ 
			Mobile caster;
			Mobile target;
			SpellTemplate spell;
			int nTime;
			byte[] tmpBuff;

			public ArcaneMissilesEffect(SpellTemplate _st, Mobile _caster, Mobile _target, int every, int _nTime)
				: base(Priorities.Milisec10, every) 
			{ 
				this.caster = _caster;
				this.target = _target;
				this.spell = _st; 
				this.nTime = _nTime;
				this.tmpBuff = new byte[46];

				int i = 4;
				Converter.ToBytes((ulong)caster.Guid, tmpBuff, ref i);
				Converter.ToBytes((ulong)caster.Guid, tmpBuff, ref i);
				Converter.ToBytes((uint)spell.Id, tmpBuff, ref i);
				Converter.ToBytes((ushort)0, tmpBuff, ref i);
				Converter.ToBytes((byte)1, tmpBuff, ref i);
				Converter.ToBytes((ulong)target.Guid, tmpBuff, ref i);
				Converter.ToBytes((byte)0, tmpBuff, ref i);
				Converter.ToBytes((ushort)2, tmpBuff, ref i);
			}

			public void OnArcaneMissilesInterrupt(Mobile from)
			{
				Stop();
			}

			public override void OnTick() 
			{
				caster.ToAllPlayerNear(OpCodes.SMSG_SPELL_GO, tmpBuff, 46);

				spell.MakeDamage(caster, target, SpellDamage.TypeS1);

                
			}
		}
		public static void OnCastArcaneMissiles(BaseAbility ba, Mobile from)
		{
			AuraEffect ae = (AuraEffect)ba;
			
			Mobile target;

			if (from is Character) target = ((from as Character).Selection as Mobile);
			else target = from.AttackTarget;

			if (target != null)
			{
				ArcaneMissilesEffect arcaneMissilesEffect = new ArcaneMissilesEffect((Abilities.abilities[ae.AdditionalSpell] as SpellTemplate), from, target, 1000, (int)(ae.Duration(from) / 1000));

				Aura aura = new Aura();
				aura.OnRelease = new Aura.AuraReleaseDelegate((arcaneMissilesEffect as ArcaneMissilesEffect).OnArcaneMissilesInterrupt);

				target.AddAura(ae, aura, true);

				arcaneMissilesEffect.Start();
				from.ChannelStart(target, ae.Id, ae.Duration(from));
			}
		}
		#endregion

		#region Blink 50%
		public static void OnCastBlink(BaseAbility ba, Mobile from)
		{
			//(from as Character).DestroyObject(from.Guid);

			if (from.Visible != InvisibilityLevel.True)
			{
				System.Console.WriteLine("INVISIBLE");
				from.Visible = InvisibilityLevel.True;
				from.ChangeRunSpeed(50.0f);
			}
			else
			{
				System.Console.WriteLine("VISIBLE");
				from.Visible = InvisibilityLevel.Visible;
				from.ChangeRunSpeed(from.RunSpeed);
			}

			
			Character ch = from as Character;
			float distance = 20.0f; // 20 yards
			float X = ch.X;
			float Y = ch.Y;
			// not using ch.Z
			System.Console.WriteLine("X: "+ch.X);
			System.Console.WriteLine("Y: "+ch.Y);
			System.Console.WriteLine("Z: "+ch.Z);
			System.Console.WriteLine("Orientation: "+ch.Orientation);
			float r1 = (float)System.Math.Sqrt(distance * distance / ((System.Math.Tan(ch.Orientation) * System.Math.Tan(ch.Orientation) + 1)));
			float r2 = (float)System.Math.Tan(ch.Orientation) * r1;
			if ( ch.Orientation >= 0 && ch.Orientation <= System.Math.PI/2 || ch.Orientation == System.Math.PI*2 )
			{
				X += r1;
				Y += r2;
			}
			else if ( ch.Orientation > System.Math.PI/2  && ch.Orientation < System.Math.PI)
			{
				X += r1;
				Y -= r2;
			}
			else if ( ch.Orientation >= System.Math.PI  && ch.Orientation <= System.Math.PI*3/2)
			{
				X -= r1;
				Y -= r2;
			}
			else if ( ch.Orientation > System.Math.PI*3/2  && ch.Orientation < System.Math.PI*2)
			{
				X -= r1;
				Y += r2;
			}

			//MapPoint temp = Server.World.mapZones.NearestPoint(ch.MapId, ch.ZoneId, X, Y);
			MapPoint temp = Server.World.mapZones.Get(0, ch.ZoneId, ch.MapId, from, false);

			if (temp != null)
			{
				System.Console.WriteLine("X: " + X);
				System.Console.WriteLine("Y: " + Y);
				System.Console.WriteLine("Distance: " + System.Math.Sqrt((ch.X - X) * (ch.X - X) + (ch.Y - Y) * (ch.Y - Y)));
				Aura aura = new Aura();
				aura.ForceStun = false;
				Console.WriteLine("Duration: " + ((AuraEffect)ba).Duration(ch));
				//aura.ForceRoot = false;
				ch.AddAura((AuraEffect)ba, aura);
				ch.Teleport((float)temp.x, (float)temp.y, (float)temp.z, ch.MapId);
			}
			
		}
		#endregion

		#region Conjure Water 100%
		public static void OnCastConjureWater(BaseAbility ba, Mobile c) // Thanks TUM
		{
			Character ch = c as Character;
			SpellTemplate st = (SpellTemplate)ba;

			int diff = ch.Level - st.RequieredLevel;
			int quantity = 2;

			if (diff > 0)
			{
				if (diff < 9)
				{
					quantity += diff * 2;
				}
				else
				{
					quantity = 20;
				}
			}

			switch (ba.Id)
			{
				case 5504: ch.CreateAndAddObject("ConjuredWater", quantity,true); break;
				case 5505: ch.CreateAndAddObject("ConjuredFreshWater", quantity,true); break;
				case 5506: ch.CreateAndAddObject("ConjuredPurifiedWater", quantity,true); break;
				case 6127: ch.CreateAndAddObject("ConjuredSpringWater", quantity,true); break;
				case 10138: ch.CreateAndAddObject("ConjuredMineralWater", quantity,true); break;
				case 10139: ch.CreateAndAddObject("ConjuredSparklingWater", quantity,true); break;
				case 10140: ch.CreateAndAddObject("ConjuredCrystalWater", 4,true); break;
			}
		}
		#endregion 

		#region Conjure Food 100%
		public static void OnCastConjureFood(BaseAbility ba, Mobile c) // Thanks TUM
		{
			Character ch = c as Character;
			SpellTemplate st = (SpellTemplate)ba;

			int diff = ch.Level - st.RequieredLevel;
			int quantity = 2;

			if (diff > 0)
			{
				if (diff < 9)
				{
					quantity += diff * 2;
				}
				else
				{
					quantity = 20;
				}
			}

			switch (ba.Id)
			{
				case 587: ch.CreateAndAddObject("ConjuredMuffin", quantity,true); break;
				case 597: ch.CreateAndAddObject("ConjuredBread", quantity,true); break;
				case 990: ch.CreateAndAddObject("ConjuredRye", quantity,true); break;
				case 6129: ch.CreateAndAddObject("ConjuredPumpernickel", quantity,true); break;
				case 10144: ch.CreateAndAddObject("ConjuredSourdough", quantity,true); break;
				case 10145: ch.CreateAndAddObject("ConjuredSweetRoll", quantity,true); break;
			}
		}
		#endregion 

		#region Conjure Mana Agate 100%
		public static void OnCastConjureManaAgate(BaseAbility ba, Mobile c) // Thanks TUM
		{
			(c as Character).CreateAndAddObject("ManaAgate",true);
		}
		#endregion

		#region Conjure Mana Citrine 100%
		public static void OnCastConjureManaCitrine(BaseAbility ba, Mobile c) // Thanks TUM
		{
			(c as Character).CreateAndAddObject("ManaCitrine",true);
		}
		#endregion

		#region Conjure Mana Jade 100%
		public static void OnCastConjureManaJade(BaseAbility ba, Mobile c) // Thanks TUM
		{
			(c as Character).CreateAndAddObject("ManaJade",true);
		}
		#endregion

		#region Conjure Mana Ruby 100%
		public static void OnCastConjureManaRuby(BaseAbility ba, Mobile c) // Thanks TUM
		{
			(c as Character).CreateAndAddObject("ManaRuby",true);
		}
		#endregion

		#region Counterspell 100%
		public class CounterSpellAura : Aura
		{
			private int avoidCastMagicClass;

			public CounterSpellAura()
			{
			}
			public override int AvoidCastMagicClass
			{
				get
				{
					return this.avoidCastMagicClass;
				}
				set
				{
					this.avoidCastMagicClass = value;
				}
			}
		}
		public static void OnCastCounterspell(BaseAbility ba, Mobile from, Mobile target)
		{   // 100%
			// ...			
						
			SpellTemplate st = (SpellTemplate)ba;

			int spellID = target.InterruptCasting();
			if (spellID != 0)
			{
				//???? its no auraeffect
				AuraEffect ae = (AuraEffect)ba;

				CounterSpellAura aura = new CounterSpellAura();
				aura.AvoidCastMagicClass = AbilityClasses.abilityClasses[spellID];

				target.AddAura(ae, aura, true);
			}
		}
		#endregion

		#region DampenMagic 100%
		#region DampenMagicAura
		public class DampenMagicAura : MagicBuff
		{
			//TODO: Absorption mechanics based on wow wiki
			//http://www.wowwiki.com/Dampen_Magic
			//Note that it's "up to" the number given. The actual amount damage/healing is decreased depends on the spell being altered. See the page on damage bonuses from gear. Dampen Magic works in the same way as Type One gear.

			private int spellDamageTakenMalus;
			private int healTakeDecrease;

			public DampenMagicAura(HaveMagicBuff _haveMagicBuff)
				: base(_haveMagicBuff)
			{
			}

			public override int SpellDamageTakenMalus
			{
				get
				{
					System.Console.WriteLine("GET: " + this.spellDamageTakenMalus);
					return this.spellDamageTakenMalus;
				}
				set
				{
					System.Console.WriteLine("SET: " + value);
					this.spellDamageTakenMalus = value;
				}
			}
			public override int HealTakeDecrease
			{
				get
				{
					System.Console.WriteLine("GET: " + this.healTakeDecrease);
					return this.healTakeDecrease;
				}
				set
				{
					System.Console.WriteLine("SET: " + value);
					this.healTakeDecrease = value;
				}
			}
		}
		#endregion
		public static void OnCastDampenMagic(BaseAbility ba, Mobile from, Mobile target)
		{
			AuraEffect ae = (AuraEffect)ba;

			HaveMagicBuff haveMagicBuff = new HaveMagicBuff(from, ae);
            
			DampenMagicAura dampenMagicAura = new DampenMagicAura(haveMagicBuff);
			dampenMagicAura.SpellDamageTakenMalus = (-(ae.S1));
			dampenMagicAura.HealTakeDecrease = (-(ae.S2));

			target.AddAura(ae, dampenMagicAura);
		}
		#endregion

		#region DetectMagic 0%
		public static void OnCastDetectMagic(BaseAbility ba, Mobile c, Mobile target)
		{   // 0%
		}
		#endregion

		#region MageArmor 100%
		#region MageArmorAura
		public class MageArmorAura : MagicArmorAura
		{
			private float manaRegenWhileCastingPercent;
			private int allResistanceBonus;

			public MageArmorAura(HaveMagicArmor _haveMagicArmor)
				: base(_haveMagicArmor)
			{
			}

			public override float ManaRegenWhileCastingPercent
			{
				get
				{
					return this.manaRegenWhileCastingPercent;
				}
				set
				{
					this.manaRegenWhileCastingPercent = value;
				}
			}
			public override int AllResistanceBonus
			{
				get
				{
					return this.allResistanceBonus;
				}
				set
				{
					this.allResistanceBonus = value;
				}
			}
		}
		#endregion
		public static void OnCastMageArmor(BaseAbility ba, Mobile from)
		{
			AuraEffect ae = (AuraEffect)ba;
            
			HaveMagicArmor haveMagicArmor = new HaveMagicArmor(from, ae);
            
			MageArmorAura aura = new MageArmorAura(haveMagicArmor);

			aura.AllResistanceBonus = ae.S1;
			aura.ManaRegenWhileCastingPercent = (float)ae.S2;           
           
			from.AddAura(ae, aura);            
		}
		#endregion

		#region ManaShield 100%
		#region ManaShieldAura
		public class ManaShieldAura : Aura
		{
			private int manaShield;

			public ManaShieldAura()
			{
			}
			public override int ManaShield
			{
				get
				{
					return this.manaShield;
				}
				set
				{
					this.manaShield = value;
				}
			}
		}
		#endregion
		public static void OnCastManaShield(BaseAbility ba, Mobile from)
		{
			AuraEffect ae = (AuraEffect)ba;

			ManaShieldAura aura = new ManaShieldAura();
			aura.ManaShield	 = ae.S1;

			from.AddAura(ae, aura);
		}
		#endregion    

		#region Polymorph 80%
		#region PolymorphAura
		public class PolymorphAura : Aura
		{
			//http://www.wowwiki.com/Polymorph
			//TODO: This spell works on those given above, and does NOT work on elementals, demons, undead, or typeless creeps. It works just fine against Undead players, though their racial ability counters and prevents the effect. 
			//DONE: A Mage can only have one target Polymorphed at a time. If cast on a second target, the first Polymorph breaks. 
			//TODO: It does not work on players who are in animal form. (Druids, Shaman) 
			//DONE: No matter the listed duration, players have an ever-increasing chance to break the effect each second, with 100% chance at 15 seconds. Expect the spell to last 7 seconds on average. 

			public class PolymorphTimer : WowTimer
			{
				private ushort count;
				private bool isCharacter;
				private float X;
				private float Y;
				private float Z;
				private Mobile target;
				private AuraEffect ae;

				public PolymorphTimer(Mobile _target, AuraEffect _ae, int every)
					: base(Priorities.Second, every)
				{   
					this.count = 0;
					this.isCharacter = (_target is Character);
					this.X = _target.X;
					this.Y = _target.Y;
					this.Z = _target.Z;
					this.target = _target;
					this.ae = _ae;
				}

				public override void OnTick()
				{
					if (isCharacter)
					{
						switch (count)
						{
							case 1:
							{
								if (Utility.Random4() == 0)
								{
									target.ReleaseAura(ae);
								}
								break;
							}
							case 3:
							{
								if (Utility.Random4() <= 1)
								{
									target.ReleaseAura(ae);
								}
								break;
							}
							case 5:
							{
								target.ReleaseAura(ae);
								break;
							}
						}

						count++;
					}

					float x = (float)(Utility.RandomDouble() - 0.5f) * 8f;
					float y = (float)(Utility.RandomDouble() - 0.5f) * 8f;

					target.MoveTo(this.X + x, Y + y, this.Z);
				}
			}   

			private float healthRegenerationModifier;
			private bool forceStun;
			private int onSpellHit;
			private int onMeleeHit;
			private BaseAIType oldAIEngine;
			private AIStates oldAIState;
			private Mobile oldAttackTarget;
			private PolymorphCasted polymorphCasted;
			private PolymorphTimer polymorphTimer;

			public PolymorphAura(PolymorphCasted _polymorphCasted)
			{
				foreach (object obj in _polymorphCasted.caster.AdditionnalStates)
				{
					if (obj is PolymorphCasted)
					{
						(obj as PolymorphCasted).target.ReleaseAura((obj as PolymorphCasted).ae);
						break;
					}
				}

				this.polymorphCasted = _polymorphCasted;
				this.OnRelease = new Aura.AuraReleaseDelegate(this.OnCastPolymorphAuraRelease);

				this.polymorphCasted.caster.AdditionnalStates.Add(polymorphCasted);

				if (!(polymorphCasted.target is Character))
				{
					BaseCreature target = (polymorphCasted.target as BaseCreature);

					oldAIEngine = target.AIEngine;
					oldAIState = target.AIState;
					oldAttackTarget = target.AttackTarget;
					target.AIEngine = null;
					target.AttackTarget = null;
					target.ChooseAttackMode();

					forceStun = false;
				}
				else
				{
					forceStun = false;
				}

				//polymorphCasted.target.Running = false;

				polymorphTimer = new PolymorphTimer(polymorphCasted.target, polymorphCasted.ae, 2500);
				polymorphTimer.Start();
			}
            
			public override float HealthRegenerationModifier
			{
				get
				{
					return this.healthRegenerationModifier;
				}
				set
				{
					this.healthRegenerationModifier = value;
				}
			}
			public override bool ForceStun //Should be a "sleep" effect
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

			public void OnCastPolymorphHitTrigger(Mobile from, Mobile target, AuraEffect ae)
			{
				this.polymorphCasted.target.ReleaseAura(ae);
			}
			public void OnCastPolymorphAuraRelease(Mobile from)
			{
				polymorphTimer.Stop();
				polymorphCasted.target.CancelPolymorph();

				if (!(polymorphCasted.target is Character))
				{
					(polymorphCasted.target as BaseCreature).AIEngine = oldAIEngine;
					(polymorphCasted.target as BaseCreature).AIState = oldAIState;
					(polymorphCasted.target as BaseCreature).AttackTarget = oldAttackTarget;
				}
				else
				{
					polymorphCasted.caster.AdditionnalStates.Remove(polymorphCasted); 
				}                
			}
		}
		#endregion
		public static void OnCastPolymorph(BaseAbility ba, Mobile from, Mobile target)
		{
			//sheep modelId (856)
			if((target.NpcType == (int)NpcTypes.Beast) || (target.NpcType == (int)NpcTypes.Humanoid) || (target.NpcType == (int)NpcTypes.Critter))
			{
				Console.WriteLine("ups");
				AuraEffect ae = (AuraEffect)ba;

				//Dispel Mechanic (forces dismount)
				if (target.MountModel != 0)
				{
					target.ReleaseAura((AuraEffect)World.MountsList[target.Mounting.Id]);
				}

				PolymorphCasted polymorphCasted = new PolymorphCasted(from, target, ae);

				PolymorphAura polymorphAura = new PolymorphAura(polymorphCasted);

				polymorphAura.HealthRegenerationModifier = 15; //1500%
				polymorphAura.OnMeleeHit = 118;//Polymorph rank 1
				polymorphAura.OnSpellHit = 12824;//Polymorph rank 2

				target.Triggers[118] = new Mobile.OnMeleeHitTrigger((polymorphAura as PolymorphAura).OnCastPolymorphHitTrigger);
				target.Triggers[12824] = new Mobile.OnSpellHitTrigger((polymorphAura as PolymorphAura).OnCastPolymorphHitTrigger);
				target.AddAura(ae, polymorphAura, true);
				target.Polymorph(856); 
			}
		}
		#endregion

		#region Portal Darnassus 100%
		public static void OnCastPortalDarnassus(BaseAbility ba, Mobile c)
		{
			Character ch = (c as Character);
			if ( ch.Race == Races.Human || ch.Race == Races.Dwarf 
				|| ch.Race == Races.NightElf || ch.Race == Races.Gnome )
			{
				PortalEffect portalDarnassus = new PortalEffect( ch, 176498, 1000, 60 ); 
				portalDarnassus.Start();
				ch.ConsumeItemByIdUpTo("RuneOfPortals", 1 );
			}
		}
		#endregion

		#region Portal Ironforge 100%
		public static void OnCastPortalIronforge(BaseAbility ba, Mobile c)
		{
			Character ch = (c as Character);
			if ( ch.Race == Races.Human || ch.Race == Races.Dwarf 
				|| ch.Race == Races.NightElf || ch.Race == Races.Gnome )
			{
				PortalEffect portalIronforge = new PortalEffect( ch, 176497, 1000, 60 ); 
				portalIronforge.Start();
				ch.ConsumeItemByIdUpTo("RuneOfPortals", 1 );
			}
		}
		#endregion

		#region Portal Orgrimmar 100%
		public static void OnCastPortalOrgrimmar(BaseAbility ba, Mobile c)
		{
			Character ch = (c as Character);
			if ( ch.Race == Races.Orc || ch.Race == Races.Undead 
				|| ch.Race == Races.Tauren || ch.Race == Races.Troll )
			{
				PortalEffect portalOrgrimmar = new PortalEffect( ch, 176499, 1000, 60 ); 
				portalOrgrimmar.Start();
				ch.ConsumeItemByIdUpTo("RuneOfPortals", 1 );
			}
		}
		#endregion

		#region Portal Stormwind 100%
		public static void OnCastPortalStormwind(BaseAbility ba, Mobile c)
		{
			Character ch = (c as Character);
			if ( ch.Race == Races.Human || ch.Race == Races.Dwarf 
				|| ch.Race == Races.NightElf || ch.Race == Races.Gnome )
			{
				PortalEffect portalStormWind = new PortalEffect( ch, 176296, 1000, 60 ); 
				portalStormWind.Start();
				ch.ConsumeItemByIdUpTo("RuneOfPortals", 1 );
			}
		}
		#endregion

		#region Portal ThunderBluff 100%
		public static void OnCastPortalThunderBluff(BaseAbility ba, Mobile c)
		{
			Character ch = (c as Character);
			if ( ch.Race == Races.Orc || ch.Race == Races.Undead 
				|| ch.Race == Races.Tauren || ch.Race == Races.Troll )
			{
				PortalEffect portalThunderBluff = new PortalEffect( ch, 176500, 1000, 60 ); 
				portalThunderBluff.Start();
				ch.ConsumeItemByIdUpTo("RuneOfPortals", 1 );
			}
		}
		#endregion

		#region Portal Undercity 100%
		public static void OnCastPortalUndercity(BaseAbility ba, Mobile c)
		{
			Character ch = (c as Character);
			if ( ch.Race == Races.Orc || ch.Race == Races.Undead 
				|| ch.Race == Races.Tauren || ch.Race == Races.Troll )
			{
				PortalEffect portalUndercity = new PortalEffect( ch, 176501, 1000, 60 ); 
				portalUndercity.Start();
				ch.ConsumeItemByIdUpTo("RuneOfPortals", 1 );
			}
		}
		#endregion

		#region Remove Lesser Curse 100%
		public static void OnCastRemoveLesserCurse(BaseAbility ba, Mobile from, Mobile target)
		{   // 100%
			// Removes a single lesser curse.
			(ba as SpellTemplate).Dispel(DispelType.Curse, 1, target);
		}
		#endregion

		#region SlowFall 100%
		public static void OnCastSlowFall(BaseAbility ba, Mobile from)
		{   
			Aura aura = new Aura();
			aura.FeatherFall = true;

			from.AddAura((ba as AuraEffect),aura);
			(from as Character).ConsumeItemByIdUpTo("LightFeather", 1);
		}
		#endregion

		#region Teleport Darnassus 100%
		public static void OnCastTeleportDarnassus(BaseAbility ba, Mobile c) // Made by SneakerXZ (thx Dr.Nexus for help)
		{ // fixed by fulgas
			Character ch = c as Character;
			if ( ch.Race == Races.Human || ch.Race == Races.Dwarf 
				|| ch.Race == Races.NightElf || ch.Race == Races.Gnome )
			{
				ch.Teleport( 9951.792969f, 2145.915771f, 1327.724854f, 1 );
				ch.ConsumeItemByIdUpTo("RuneOfTeleportation", 1 ); 
			}
		}
		#endregion

		#region Teleport Ironforge 100%
		public static void OnCastTeleportIronforge(BaseAbility ba, Mobile c) // Made by SneakerXZ (thx Dr.Nexus for help)
		{
			Character ch = c as Character;
			if ( ch.Race == Races.Human || ch.Race == Races.Dwarf 
				|| ch.Race == Races.NightElf || ch.Race == Races.Gnome )
			{
				ch.Teleport( -5032f, -819f, 495f, 0 );
				ch.ConsumeItemByIdUpTo("RuneOfTeleportation", 1 ); 
			}
		}
		#endregion

		#region Teleport Orgrimmar 100%
		public static void OnCastTeleportOrgrimmar(BaseAbility ba, Mobile c) // Made by SneakerXZ (thx Dr.Nexus for help)
		{
			Character ch = (c as Character);
			if ( ch.Race == Races.Orc || ch.Race == Races.Undead 
				|| ch.Race == Races.Tauren || ch.Race == Races.Troll )
			{
				ch.Teleport( 1552.499268f, -4420.658691f, 8.948024f, 1 );
				ch.ConsumeItemByIdUpTo("RuneOfTeleportation", 1 ); 
			}
		}
		#endregion

		#region Teleport Stormwind 100%
		public static void OnCastTeleportStormwind(BaseAbility ba, Mobile c) // Made by SneakerXZ (thx Dr.Nexus for help)
		{
			Character ch = c as Character;
			if ( ch.Race == Races.Human || ch.Race == Races.Dwarf 
				|| ch.Race == Races.NightElf || ch.Race == Races.Gnome )
			{
				ch.Teleport( -8960.140625f, 516.265686f, 96.356819f, 0 );
				ch.ConsumeItemByIdUpTo("RuneOfTeleportation", 1 ); 
			}
		}
		#endregion    

		#region Teleport ThunderBluff 100%
		public static void OnCastTeleportThunderBluff(BaseAbility ba, Mobile c) // Made by SneakerXZ (thx Dr.Nexus for help)
		{
			Character ch = (c as Character);
			if ( ch.Race == Races.Orc || ch.Race == Races.Undead 
				|| ch.Race == Races.Tauren || ch.Race == Races.Troll )
			{
				ch.Teleport( -1391.0f, 140.0f, 22.478f, 1 );
				ch.ConsumeItemByIdUpTo("RuneOfTeleportation", 1 ); 
			}
		}
		#endregion

		#region Teleport Undercity 100%
		public static void OnCastTeleportUndercity(BaseAbility ba, Mobile c) // Made by SneakerXZ (thx Dr.Nexus for help)
		{
			Character ch = (c as Character);
			if ( ch.Race == Races.Orc || ch.Race == Races.Undead 
				|| ch.Race == Races.Tauren || ch.Race == Races.Troll )
			{
				ch.Teleport( 1819.708374f, 238.789505f, 60.532143f, 0 );
				ch.ConsumeItemByIdUpTo("RuneOfTeleportation", 1 ); 
			}
		}
		#endregion

		#endregion

		#region Fire Spells 100%
		#region Fire Ward 100%
		public static void OnCastFireWard(BaseAbility ba, Mobile from)
		{
			AuraEffect ae = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.FireAbsorb = ae.S1;
			from.AddAura(ae, aura);
		}
		#endregion
		#region Fireball 100%
		public static void OnCastFireball(BaseAbility ba, Mobile from, Mobile target)
		{   
			SpellTemplate st = (SpellTemplate)ba;
			st.MakeDamage(from, target, SpellDamage.TypeS1);
			st.ApplyDot(from, target, st.S2, st.T2, st.Duration(from));
		}
		#endregion
		#region Fire Blast 100%
		public static void OnCastFireBlast(BaseAbility ba, Mobile from, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			st.MakeDamage(from, target, SpellDamage.TypeS1);
		}
		#endregion
		#region Flamestrike 100%
		#region FlamestrikeEffect
		public class FlamestrikeEffect : WowTimer
		{
			private DynamicObject dyno;
			private Mobile caster;
			private AuraEffect spell;
			private int nTime;
			private float area;
			

			public FlamestrikeEffect(AuraEffect af, Mobile _caster, DynamicObject _dyno, float _area,int _nTime,int every)
				: base(Priorities.Milisec, every)
			{
				this.caster = _caster;
				this.spell = af;
				this.dyno = _dyno;
				this.nTime =_nTime;
				this.area = _area;
			}

			public override void OnTick()
			{
				ArrayList targets = SpellTargets.targetsAroundXYZ(caster, dyno.X,dyno.Y,dyno.Z, area, TargetType.Enemy);
			
				foreach (Mobile target in targets)
				{
					bool check = spell.CheckSpellTargetMultiple(caster,target);
					bool m = spell.MissAndRessistTest(target,caster);	
					if(check && !m)	spell.MakeDamage(caster, target, SpellDamage.TypeS2);
					
				}
				Console.WriteLine(nTime);
				nTime--;
				if (nTime < 0)
				{
					Console.WriteLine("ups");
					dyno.End();
					Stop();
				}

			}
		}
		#endregion
		public static void OnCastFlamestrike(BaseAbility ba, Mobile from, float X, float Y, float Z)
		{
			AuraEffect st = (AuraEffect)ba;

			DumpInfo(st);

			DynamicObject DO = new DynamicObject(X, Y, Z, from.MapId, from, ba.Id, from.cast.radius);
			
			ArrayList targets = SpellTargets.targetsAroundXYZ(from, X, Y, Z, 5f, TargetType.Enemy);
			DO.Start();

			foreach (Mobile target in targets)
			{
				bool check = st.CheckSpellTargetMultiple(from,target);
				bool m = st.MissAndRessistTest(target,from);	
				if(check && !m)	st.MakeDamage(from, target, SpellDamage.TypeS1);
				
			}
			
			FlamestrikeEffect fe = new FlamestrikeEffect(st,from,DO,from.cast.radius,(int)(from.cast.duration/st.T2),st.T2);
			fe.Start();
		}
		#endregion
		#region Scorch 100%
		public static void OnCastScorch(BaseAbility ba, Mobile from, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			st.MakeDamage(from, target, SpellDamage.TypeS1);
		}
		#endregion
		#endregion

		#region Frost Spells 100%
		#region Blizzard
		public class BlizzardEffect : WowTimer
		{
			private DynamicObject dyno;
			private Mobile caster;
			private AuraEffect spell;
			private int nTime;
			private float area;
			

			public BlizzardEffect(AuraEffect af, Mobile _caster, DynamicObject _dyno, float _area,int _nTime,int every)
				: base(Priorities.Milisec, every)
			{
				this.caster = _caster;
				this.spell = af;
				this.dyno = _dyno;
				this.nTime =_nTime;
				this.area = _area;
			}

			public override void OnTick()
			{
				if(caster.Chan.channeling != 0)
				{
					ArrayList targets = SpellTargets.targetsAroundXYZ(caster, dyno.X,dyno.Y,dyno.Z, area, TargetType.Enemy);
			
					foreach (Mobile target in targets)
					{
						bool check = spell.CheckSpellTargetMultiple(caster,target);
						bool m = spell.MissAndRessistTest(target,caster);	
						if(check && !m)	spell.MakeDamage(caster, target, SpellDamage.TypeS1);
					}
					SpellHelp.GraphicEffectXYZ(caster, spell.Id, dyno.X, dyno.Y,dyno.Z);
					Console.WriteLine(nTime);
					nTime--;
					if (nTime < 0)
					{
						
						Console.WriteLine("ups");
						dyno.End();
						Stop();
					}
				}
				else
				{
					
					Console.WriteLine("ups");
					dyno.End();
					Stop();
				}

			}
		}
		
		public static void OnCastBlizzard(BaseAbility ba, Mobile from, float X, float Y, float Z)
		{
			AuraEffect af = (AuraEffect)ba;

			DumpInfo(af);

			DynamicObject DO = new DynamicObject(X, Y, Z, from.MapId, from, ba.Id, from.cast.radius);
			
			ArrayList targets = SpellTargets.targetsAroundXYZ(from, X, Y, Z, 5f, TargetType.Enemy);
			DO.Start();

			foreach (Mobile target in targets)
			{
				bool check = af.CheckSpellTargetMultiple(from,target);
				bool m = af.MissAndRessistTest(target,from);	
				if(check && !m)	af.MakeDamage(from, target, SpellDamage.TypeS1);
			}
			BlizzardEffect fe = new BlizzardEffect(af,from,DO,from.cast.radius,(int)(from.cast.duration/af.T1),af.T1);
			fe.Start();
					
			from.ChannelStart(DO, af.Id, af.Duration(from));
			
		}
		

		#endregion

		#region Cone of Cold 100%
		public static void OnCastConeOfCold(BaseAbility ba, Mobile from)
		{   
			SpellTemplate st = (SpellTemplate)ba;
			AuraEffect ae = (AuraEffect)ba;

			ArrayList targets = SpellTargets.targetsInConeFront(from, 10f, TargetType.Enemy, 2);

			foreach (Mobile target in targets)
			{
				bool check = ae.CheckSpellTargetMultiple(from,target);
				bool m = ae.MissAndRessistTest(target,from);	
				if(check && !m)	
				{
					st.MakeDamage(from, target, SpellDamage.TypeS2);
					Aura aura = new Aura();
					aura.SpeedModifier = (float)ae.S1 / 100f;
					aura.OnRelease = new Aura.AuraReleaseDelegate(OnCastConeOfColdAuraEnded);
                
					target.AddAura(ae, aura, true);
					target.ChangeRunSpeed(target.RunSpeed);
				}
			}
		}
		public static void OnCastConeOfColdAuraEnded(Mobile from)
		{
			from.ChangeRunSpeed(from.RunSpeed);
		}
		#endregion

		#region Frost Armor 100%
		public static void OnCastFrostArmor(BaseAbility ba, Mobile from)
		{   
			
			AuraEffect ae = (AuraEffect)ba;
            
			HaveMagicArmor haveMagicArmor = new HaveMagicArmor(from, ae);

			FrostArmorAura aura = new FrostArmorAura(haveMagicArmor);
			aura.ArmorBonus = ae.S1;
			aura.OnMeleeHit = 168; //Frost Armor rank 1
			aura.OnSpellHit = 7300; //Frost Armor rank 2

			from.Triggers[168] = new Mobile.OnMeleeHitTrigger(OnFrostArmorHit);
			from.Triggers[7300] = new Mobile.OnSpellHitTrigger(OnFrostArmorHit);

			from.AddAura(ae, aura);    
		}
		public static void OnFrostArmorHit(Mobile from, Mobile target, AuraEffect _ae)
		{        
			AuraEffect ae = (AuraEffect)Abilities.abilities[6136];

			ChilledAura aura = new ChilledAura();
			aura.AttackSpeedModifier = (float)(ae.S1 + 100) / 100f;
			aura.SpeedModifier = (float)ae.S2 / 100f;
			aura.OnRelease = new Aura.AuraReleaseDelegate(OnFrostArmorHitAuraEnded);

			target.AddAura(ae, aura, true);
			target.ChangeRunSpeed(target.RunSpeed);
		}
		public static void OnFrostArmorHitAuraEnded(Mobile from)
		{
			from.ChangeRunSpeed(from.RunSpeed);
		}
		#endregion

		#region Frostbolt 100%
		public static void OnCastFrostbolt(BaseAbility ba, Mobile from, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			AuraEffect ae = (AuraEffect)ba;

			st.MakeDamage(from, target, SpellDamage.TypeS2);

			Aura aura = new Aura();
			aura.SpeedModifier = (float)ae.S1 / 100f;
			aura.OnRelease = new Aura.AuraReleaseDelegate(OnFrostboltAuraEnded);
            
			target.AddAura(ae, aura, true);
			target.ChangeRunSpeed(target.RunSpeed);
		}
		public static void OnFrostboltAuraEnded(Mobile from)
		{
			from.ChangeRunSpeed(from.RunSpeed);
		}
		#endregion

		#region Frost Nova 100%
		public static void OnCastFrostNova(BaseAbility ba, Mobile from) // Thanks bovi & DrNexus.
		{  
			SpellTemplate st = (SpellTemplate)ba;
			AuraEffect ae = (AuraEffect)ba;

			ArrayList targets = SpellTargets.targetsAround(from, 10f, TargetType.Enemy);

			foreach (Mobile target in targets)
			{
				bool check = ae.CheckSpellTargetMultiple(from,target);
				bool m = ae.MissAndRessistTest(target,from);	
				if(check && !m)	
				{
					ae.MakeDamage(from, target, SpellDamage.TypeS1);
			                
					FrostNovaAura aura = new FrostNovaAura();
					aura.ForceRoot = true;
					aura.OnMeleeHit = 122; //Frost nova rank 1
					aura.OnSpellHit = 865; //Frost nova rank 2

					target.Triggers[122] = new Mobile.OnMeleeHitTrigger(OnFrostNovaHit);
					target.Triggers[865] = new Mobile.OnSpellHitTrigger(OnFrostNovaHit);

					target.AddAura(ae, aura, true);
				}
			}
		}
		public static void OnFrostNovaHit(Mobile from, Mobile target, AuraEffect ae)
		{
			//Chance to break i dont know what is the chance           
			if (Utility.Random8() == 0)
			{
				from.ReleaseAura(ae);
			}
		}
		#endregion

		#region Frost Ward 100%
		public static void OnCastFrostWard(BaseAbility ba, Mobile from)
		{   
			AuraEffect ae = (AuraEffect)ba;
            
			Aura aura = new Aura();
			aura.FrostAbsorb = ae.S1;

			from.AddAura(ae, aura);
		}
		#endregion

		#region Ice Armor 100%
		public static void OnCastIceArmor(BaseAbility ba, Mobile from)
		{
			AuraEffect ae = (AuraEffect)ba;

			HaveMagicArmor haveMagicArmor = new HaveMagicArmor(from, ae);

			IceArmorAura aura = new IceArmorAura(haveMagicArmor);
			aura.ArmorBonus = ae.S1;
			aura.FrostResistanceBonus = ae.S3;
			aura.OnMeleeHit = 7302; //Ice Armor rank 1
			aura.OnSpellHit = 7320; //Ice Armor rank 2

			from.Triggers[7302] = new Mobile.OnMeleeHitTrigger(OnIceArmorHit);
			from.Triggers[7320] = new Mobile.OnSpellHitTrigger(OnIceArmorHit);

			from.AddAura(ae, aura); 
		}
		public static void OnIceArmorHit(Mobile from, Mobile target, AuraEffect _ae)
		{  
			AuraEffect ae = (AuraEffect)Abilities.abilities[7321];

			ChilledAura aura = new ChilledAura();
			aura.AttackSpeedModifier = (float)(ae.S1 + 100) / 100f;
			aura.SpeedModifier = (float)ae.S2 / 100f;
			aura.OnRelease = new Aura.AuraReleaseDelegate(OnIceArmorHitAuraEnded);

			target.AddAura(ae, aura, true);
			target.ChangeRunSpeed(target.RunSpeed);
		}
		public static void OnIceArmorHitAuraEnded(Mobile from)
		{
			from.ChangeRunSpeed(from.RunSpeed);
		}
		#endregion

		#endregion

		#endregion
        
		
		#region TALENTS
        #region Arcane Talents 100%
        #region Arcane Power 100%
	    public static void OnCastArcanePower(BaseAbility ba, Mobile from)
        {
			AuraEffect ae = (AuraEffect)ba;

			Aura aura = new Aura();
			aura.SpecialState = SpecialStates.ArcanePower;
			
			from.AddAura(ae, aura);
        }
        #endregion
        #region Evocation 100%
		#region Evocation Aura
		public class EvocationAura : Aura
		{
			// Methods
			public EvocationAura()
			{
			}
			// Properties
			public override float ManaRegenerationModifier
			{
				get
				{
					return this.manaRegenerationModifier;
				}
				set
				{
					this.manaRegenerationModifier = value;
				}

			}
			private float manaRegenerationModifier;
		}
		#endregion
		public static void OnCastEvocation(BaseAbility ba, Mobile from)
        {
            AuraEffect ae = (AuraEffect)ba;

            Aura aura = new Aura();
            aura.ManaRegenerationModifier = (((float)ae.S1) / 100f);
            from.AddAura(ae, aura);

			from.ChannelStart(from, ae.Id,ae.Duration(from));
        }
        #endregion
        #region Presence of Mind 100%
        public static void OnCastPresenceOfMind(BaseAbility ba, Mobile from)
        {
			Aura a = new Aura();
			a.SpecialState = SpecialStates.PresenceOfMind;
			from.AddAura(ba as AuraEffect,a);
        }
        #endregion
        #endregion

        #region Fire Talents 100%
		#region Blast Wave 100%
		public static void OnCastBlastWave(BaseAbility ba, Mobile from) // Thanks bovi & DrNexus
		{
			SpellTemplate st = (SpellTemplate)ba;
			AuraEffect ae = (AuraEffect)ba;

			ArrayList targets = SpellTargets.targetsAround(from, 10f, TargetType.Enemy);

			foreach (Mobile target in targets)
			{
				st.MakeDamage(from, target, SpellDamage.TypeS1);

				Aura aura = new Aura();
				aura.SpeedModifier = (float)ae.S2 / 100f;
				aura.OnRelease = new Aura.AuraReleaseDelegate(OnBlastWaveAuraEnded);

				target.AddAura(ae, aura, true);
				target.ChangeRunSpeed(target.RunSpeed);
			}
		}
		public static void OnBlastWaveAuraEnded(Mobile from)
		{
			from.ChangeRunSpeed(from.RunSpeed);
		}
		#endregion
		#region Pyroblast 100%
		public static void OnCastPyroblast(BaseAbility ba, Mobile from, Mobile target)
		{
			SpellTemplate st = (SpellTemplate)ba;
			st.MakeDamage(from, target, SpellDamage.TypeS1);
			st.ApplyDot(from, target, st.S2, st.T2, st.Duration(from));
		}
		#endregion    
        #region Combustion 100%
		public static void OnCastCombustion(BaseAbility ba, Mobile from)
        {
			Aura a = new Aura();
			a.SpecialState = SpecialStates.Combustion;
			a.OnRelease = new Aura.AuraReleaseDelegate(OnCombustionEnd);
			from.AddAura(ba as AuraEffect,a);
        }
		public static void OnCombustionEnd( Mobile from)
		{
			Abilities.abilities[11129].SendCooldownEvent(11129,from);
		}
        #endregion
        #endregion

		#region Frost Talents 100%
		
        #region Cold Snap 100%
        public static void OnCastColdSnap(BaseAbility ba, Mobile from)
        {   
			from.CooldownReset(ClassesOfSpells.Frost);
        }
        #endregion
        #region Ice Barrier 100%
		#region Ice Barrier Aura
		public class IceBarrierAura : Aura
		{
			// Methods
			public IceBarrierAura()
			{
			}
			// Properties
			public override int AllDamageAbsorb
			{
				get
				{
					return this.allDamageAbsorb;
				}
				set
				{
					this.allDamageAbsorb = value;
				}

			}
			private int allDamageAbsorb;
		}
		#endregion
		public static void OnCastIceBarrier(BaseAbility ba, Mobile from)
        {   
            AuraEffect ae = (AuraEffect)ba;

            Aura aura = new Aura();
			aura.AllDamageAbsorb = ae.S1;

            from.AddAura(ae, aura);
        }
        #endregion
        #region Ice Block 100%
		#region IceBlockAura
		public class IceBlockAura : Aura
		{
			// Methods
			public IceBlockAura()
			{
			}
			// Properties
			public override int AllDamageAbsorb
			{
				get
				{
					return this.allDamageAbsorb;
				}
				set
				{
					this.allDamageAbsorb = value;
				}

			}
			public override bool ForceRoot
			{
				get
				{
					return this.forceRoot;
				}
				set
				{
					this.forceRoot = value;
				}
			}
			// Fields
			private int allDamageAbsorb;
			private bool forceRoot;
		}
		#endregion

		public static void OnCastIceBlock(BaseAbility ba, Mobile from)
        {   
            AuraEffect ae = (AuraEffect)ba;

            IceBlockAura aura = new IceBlockAura();
			aura.AllDamageAbsorb = 60000;
            aura.ForceRoot = true;

            from.AddAura(ae, aura);
        }
        #endregion
        #endregion
        #endregion

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
    } 
}
