using System; 
using Server; 
using HelperTools; 
using System.Collections; 
using System.Reflection; 
using Server.Creatures;


namespace Server 
{ 
	public class HaveWarlockCurse 
	{ 
		public HaveWarlockCurse(Mobile _caster,AuraEffect af) 
		{ 
			caster = _caster; 
			AuraEff = af; 
		} 
		public Mobile caster; 
		public AuraEffect AuraEff; 
	} 
	public class HaveWarlockFear 
	{ 
		public HaveWarlockFear(Mobile _caster) 
		{ 
			caster = _caster; 
		} 
		public Mobile caster; 
	} 

    
	public class WarlockSpells 
	{    

		#region Destruction auras 
		public class ImmolateAura : Aura 
		{ 
			public ImmolateAura(SpellTemplate st, Mobile c, Mobile t) 
			{ 
				if (!t.Dead) 
				{ 
					this.spell = st; 
					this.from = c; 
					this.target = t; 
					base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicImmolate), st.Duration( c ) , st.T1); 
				} 
			} 
			Mobile from; 
			Mobile target; 
			SpellTemplate spell; 
			public void PeriodicImmolate() 
			{              
				this.spell.MakeDamage(this.from,this.target, SpellDamage.TypeS1); 
			} 
		} 
		#endregion 

		#region Affliction auras 
		public class CurseAura : Aura 
		{ 
			public CurseAura() 
			{ 
              
				this.OnRelease = new Aura.AuraReleaseDelegate( OnCastCurseAuraEnded ); 
			} 
          
			public void OnCastCurseAuraEnded( Mobile c ) 
			{ 
				foreach (HaveWarlockCurse obj1 in c.AdditionnalStates) 
				{ 
					if (obj1.caster == this.caster) 
					{                
						c.AdditionnalStates.Remove(obj1);                
					} 
				} 
              
			} 
			public Mobile caster; 

		} 

		public class CurseOfRecklessnessAura : CurseAura 
		{ 
			// Methods 
			public CurseOfRecklessnessAura() 
			{ 
			} 
			// Properties 
			public override int ArmorMalus 
			{ 
				get 
				{ 
					return this.armorMalus; 
				} 
				set 
				{ 
					this.armorMalus = value; 
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

			// Fields 
			private int armorMalus; 
			private bool forceFlee; 
			private AuraEffect auraEffect; 
			private int attackPowerBonus; 
		} 

		public class CurseOfTheElementsAura : CurseAura 
		{ 
			// Methods 
			public CurseOfTheElementsAura() 
			{ 
			} 
			// Properties 
			public override int FireResistanceMalus 
			{ 
				get 
				{ 
					return this.fireResistanceMalus; 
				} 
				set 
				{ 
					this.fireResistanceMalus = value; 
				} 

			} 
			public override int FrostResistanceMalus 
			{ 
				get 
				{ 
					return this.frostResistanceMalus; 
				} 
				set 
				{ 
					this.frostResistanceMalus = value; 
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
			private int fireResistanceMalus; 
			private AuraEffect auraEffect; 
			private int frostResistanceMalus; 
		} 

		public class CurseOfIdiocyAura : CurseAura 
		{ 
			// Methods 
			public CurseOfIdiocyAura(SpellTemplate st, Mobile c, Mobile t, int dur, int freq) 
			{ 
				if (!t.Dead) 
				{ 
					this.auraEffect = (AuraEffect)st; 
					base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicIdiocyEffect), dur, freq); 
				} 
			} 

			public void PeriodicIdiocyEffect() 
			{ 
				this.IQMalus += -1* auraEffect.S1; 
				this.SpiritMalus += -1* auraEffect.S2; 
			} 

			// Properties 
			public override int IQMalus 
			{ 
				get 
				{ 
					return this.iQMalus; 
				} 
				set 
				{ 
					this.iQMalus = value; 
				} 

			} 
			public override int SpiritMalus 
			{ 
				get 
				{ 
					return this.spiritMalus; 
				} 
				set 
				{ 
					this.spiritMalus = value; 
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
			private int iQMalus; 
			private AuraEffect auraEffect; 
			private int spiritMalus; 
		} 

		public class CurseOfShadowAura : CurseAura 
		{ 
			// Methods 
			public CurseOfShadowAura() 
			{ 
			} 
			// Properties 
			public override int ShadowResistanceMalus 
			{ 
				get 
				{ 
					return this.shadowResistanceMalus; 
				} 
				set 
				{ 
					this.shadowResistanceMalus = value; 
				} 

			} 
			public override int ArcaneResistanceMalus 
			{ 
				get 
				{ 
					return this.arcaneResistanceMalus; 
				} 
				set 
				{ 
					this.arcaneResistanceMalus = value; 
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
			private int arcaneResistanceMalus; 
			private AuraEffect auraEffect; 
			private int shadowResistanceMalus; 
		} 

		public class DrainSoulAura : Aura 
		{ 
			// Methods 
			public DrainSoulAura(AuraEffect st, Mobile _c,Mobile _target) 
			{ 
				if (!_target.Dead) 
				{ 
					this.caster = _c; 
					this.OnRelease = new Aura.AuraReleaseDelegate( this.OnDrainSoulEnded ); 
					this.spell = st; 
					this.target = _target; 
					base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicDrainMana), st.Duration( _c ) , st.T2); 
				} 
			} 
			Mobile caster; 
			Mobile target; 
			SpellTemplate spell; 
			public void PeriodicDrainMana() 
			{              
				this.spell.MakeDamage(this.caster, this.target, SpellDamage.TypeS2); 
			} 

       
			public void OnDrainSoulEnded( Mobile c ) 
			{ 
				if (c.Dead) (caster as Character).CreateAndAddObject("SoulShard"); 
			} 
		} 
       
		public class CurseOfDoomAura : CurseAura 
		{ 
			// Methods 
			public CurseOfDoomAura(AuraEffect st, Mobile _c,Mobile _target) 
			{ 
				this.cast = _c; 
				this.af = st; 
				this.target = _target; 
				this.timer = new DoomTimer((int)af.Duration( _c ) ,af, cast,target); 
				this.OnRelease = new Aura.AuraReleaseDelegate( OnCastCurseOfDoomEnded ); 
				timer.Start(); 
			} 
			public void OnCastCurseOfDoomEnded( Mobile c ) 
			{ 
				foreach (HaveWarlockCurse obj1 in c.AdditionnalStates) 
				{ 
					if (obj1.caster == this.caster) 
					{                
						c.AdditionnalStates.Remove(obj1);                
					} 
				} 
				timer.Stop(); 
              
			} 

			public class DoomTimer : WowTimer 
			{ 
				public DoomTimer(int dur,AuraEffect st, Mobile _c,Mobile _target): base(dur) 
				{ 
					this.cast = _c; 
					this.af = st; 
					this.target = _target; 
				} 
              
				public override void OnTick() 
				{ 
					af.MakeDamage(cast, target, SpellDamage.TypeS1); 
					base.OnTick(); 
				} 
				private Mobile target; 
				private Mobile cast; 
				private AuraEffect af; 
			} 
			// Fields 
			WowTimer timer; 
			private Mobile target; 
			private Mobile cast; 
			private AuraEffect af; 
		} 

		public class HowlOfTerrorAura : Aura 
		{ 
			public HowlOfTerrorAura() 
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

		public class DrainLifeAura : Aura 
		{ 
			public DrainLifeAura(SpellTemplate st, Mobile c, Mobile t) 
			{ 
				if (!t.Dead) 
				{ 
					this.spell = st; 
					this.from = c; 
					this.target = t; 
					base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicDrainLife), st.Duration( c ) , st.T1); 
				} 
			} 
			Mobile from; 
			Mobile target; 
			SpellTemplate spell; 
			public void PeriodicDrainLife() 
			{              
				this.spell.DrainLife( this.from,this.target, SpellDamage.TypeS1); 
			} 
		} 

		public class SiphonLifeAura : Aura 
		{ 
			public SiphonLifeAura(SpellTemplate st, Mobile c, Mobile t) 
			{ 
				if (!t.Dead) 
				{ 
					this.spell = st; 
					this.from = c; 
					this.target = t; 
					base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicSiphonLife), st.Duration( c ) , st.T1); 
				} 
			} 
			Mobile from; 
			Mobile target; 
			SpellTemplate spell; 
			public void PeriodicSiphonLife() 
			{              
				this.spell.DrainLife(this.from,this.target, SpellDamage.TypeS1); 
			} 
		} 

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
			{   this.spell.DrainMana(this.from, this.target, SpellDamage.TypeS1);
			} 
		} 

		#endregion 

		#region Demonology auras 
		public class BanishAura : Aura 
		{ 
			// Methods 
			public BanishAura(Mobile target) 
			{ 
				target.GodMode = true; 
				this.OnRelease = new Aura.AuraReleaseDelegate(OnBanishAuraEnded); 
			} 
			public void OnBanishAuraEnded(Mobile c) 
			{ 
				c.GodMode = false; 
			} 
			// Properties 
			public override bool ForceStun 
			{ 
				get 
				{ 
					return this.forceStun ; 
				} 
				set 
				{ 
					this.forceStun  = value; 
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
			private bool forceStun; 
			private AuraEffect auraEffect; 
          
              
		} 
		public class DemonSkinAura : Aura 
		{ 
			
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

			int duration;
			int gain;
			Mobile from;
			Mobile target;
			int frequency;
			SpellTemplate spell;

			public DemonSkinAura(SpellTemplate st, Mobile c, Mobile t, int d, int dur, int freq )
			{
				if ( t.Dead )
					return;
				spell = st;
				from = c;
				target = t;
				gain = d;
				duration = dur;
				frequency = freq;
				PeriodicAura( new AuraPeriodicEffect( this.PeriodicRegen ), dur, freq );
			}

			public void PeriodicRegen()
			{
				target.GainHealth( from, gain );
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
			private int armorBonus; 
			private AuraEffect auraEffect;               
		} 

		public class DemonArmorAura : Aura 
		{ 
			private int shadowResistanceBonus;
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

			int duration;
			int gain;
			Mobile from;
			Mobile target;
			int frequency;
			SpellTemplate spell;

			public DemonArmorAura(SpellTemplate st, Mobile c, Mobile t, int d, int dur, int freq )
			{
				if ( t.Dead )
					return;
				spell = st;
				from = c;
				target = t;
				gain = d;
				duration = dur;
				frequency = freq;
				PeriodicAura( new AuraPeriodicEffect( this.PeriodicRegen ), dur, freq );
			}

			public void PeriodicRegen()
			{
				target.GainHealth( from, gain );
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
			private int armorBonus; 
			private AuraEffect auraEffect;               
		}  
    
		public class HealthFunelAura : Aura 
		{ 
			public HealthFunelAura(SpellTemplate st, Mobile c, Mobile t) 
			{ 
				if (!t.Dead) 
				{ 
					this.spell = st; 
					this.from = c; 
					this.target = t; 
					base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicHealthFunel), st.Duration( c ) , st.T1 ); 
				} 
			} 
			Mobile from; 
			Mobile target; 
			SpellTemplate spell; 
          
			public void PeriodicHealthFunel() 
			{              
				this.spell.DrainLife( this.target,this.from, SpellDamage.TypeS1 ); 
			} 
    
		} 

		#endregion 
        
		#region Destruction 
		public static void OnCastShadowBolt(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% working 
			// working 
			SpellTemplate st = (SpellTemplate)ba; 
			st.MakeDamage(c, target, SpellDamage.TypeS1); 
		} 
		public static void OnCastImmolate(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% 
			// working 
			SpellTemplate st = (SpellTemplate)ba; 
			ImmolateAura aura = new ImmolateAura(st,c,target); 
			target.AddAura(c,ba as AuraEffect,aura,true); 
			float modif = 1f;
			if ( c.HaveTalent( Talents.ImprovedImmolate ) )
				{
					AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedImmolate );
					modif *=1 + ( (float)ae.S1 / 100f );
				}	
			st.MakeDamage(c, target, (int)(st.S2*modif)); 
		} 
		public static void OnCastConflagrate(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% 
			// bug - crash server - cast is not valid 
			Mobile.AuraReleaseTimer timer1 = null; 
			foreach (Mobile.AuraReleaseTimer timer2 in target.Auras) 
			{ 
				if (timer2.ae == (AuraEffect)Abilities.abilities[348] 
					|| timer2.ae == SpellTemplate.SpellEffects[707] 
					|| timer2.ae == SpellTemplate.SpellEffects[1094] 
					|| timer2.ae == SpellTemplate.SpellEffects[2941] 
					|| timer2.ae == SpellTemplate.SpellEffects[11665] 
					|| timer2.ae == SpellTemplate.SpellEffects[11667] 
					|| timer2.ae == SpellTemplate.SpellEffects[11668]) 
				{ 
					timer1 = timer2; 
					break; 
				} 
			} 
			if (timer1 != null) 
			{ 
				target.ReleaseAura(timer1); 
				SpellTemplate st = (SpellTemplate)ba; 
				st.MakeDamage(c, target, SpellDamage.TypeS1); 
			} 
            
		} 
		public static void OnCastSearingPain(BaseAbility ba, Mobile c, Mobile target) 
		{   // 80% - missing threat 
			// working - but most time blocked 
			SpellTemplate st = (SpellTemplate)ba; 
			st.MakeDamage(c, target, SpellDamage.TypeS1); 
		} 
		#region Rain of Fire Effect 
		public class RainOfFireEffect : WowTimer 
		{ 
			Mobile from; 
			Mobile caster; 
			int toCast; 
			int nTime; 
			SingleTargetSpellEffect effectHandler; 
			float area; 

			public RainOfFireEffect( Mobile f, Mobile castr, int cast, float _area, int every, int n, SingleTargetSpellEffect _effectHandler ) :  base( every ) 
			{ 
				from = f; 
				caster = castr; 
				toCast = cast; 
				area = _area; 
				nTime = n; 
				effectHandler = _effectHandler; 
			} 
			public void whenCast() 
			{ 
				ArrayList targets = null; 
				if ( caster is Character ) 
					targets = ( caster as Character ).Player.KnownObjects; 
				else 
					if ( caster.LastSeen != null ) 
					targets = caster.LastSeen.Player.KnownObjects; 
				else 
					return; 
				foreach( Object o in targets ) 
				{ 
					if ( o is Mobile ) 
					{ 
						Mobile target = o as Mobile; 
						if ( target.Distance( from ) < area ) 
							effectHandler( Abilities.abilities[ toCast ], caster, target ); 
					} 
				} 
			} 
			public override void OnTick() 
			{ 
				float x = (float)( Utility.RandomDouble() - 0.5 ) * 20f; 
				float y = (float)( Utility.RandomDouble() - 0.5 ) * 20f; 
				from.FakeCast( toCast, from, from.X + x, from.Y + y, from.Z, new Mobile.WhenDone( this.whenCast ) ); 
				nTime--; 
				if ( nTime <= 0 ) 
				{ 
					Stop(); 
					World.Remove( from, caster );//   remove the invisible mob 
				} 
				base.OnTick(); 
			} 
		} 
		#endregion 

		public static void OnCastRainOfFire(BaseAbility ba, Mobile c,float x,float y,float z) 
		{  
			/*
			// 100% scripted 
			// need testing 
			SpellTemplate st = (SpellTemplate)ba;
			ConstructorInfo ct = Utility.FindConstructor( "Imp", Utility.externAsm );
			BaseCreature bc = null;
			bc =  (BaseCreature)ct.Invoke( null );
			bc.X = x;
			bc.Y = y;
			bc.Z = z;
			bc.MapId = c.MapId;
			bc.Freeze = true; 
			bc.AIEngine = null;          
			bc.GodMode = true; 
			bc.Size = 1.0f;
			bc.Visible = InvisibilityLevel.GM;  
			World.allMobiles.Add( bc, true );	
			RainOfFireEffect rainOfFire = new RainOfFireEffect( bc, c, 5740, 30f, 1001, 8, new SingleTargetSpellEffect( OnCastRainOfFireIndividualDamage ) ); 
			rainOfFire.Start(); 
			c.ChannelStart(bc,st.Id,st.Duration(c));
			*/
		} 
		public static void OnCastRainOfFireIndividualDamage(BaseAbility ba, Mobile c, Mobile target) 
		{ 
			SpellTemplate st = (SpellTemplate)ba; 
			st.MakeDamage(c, target, SpellDamage.TypeS1 ); 
		} 

        
		public static void OnCastShadowburn(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// bug - crash server - cast is not valid 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
			SpellTemplate st = (SpellTemplate)ba; 
			st.MakeDamage(c, target, SpellDamage.TypeS2); 
			if (target.Dead) (c as Character).CreateAndAddObject("SoulShard"); 
		} 
		public static void OnCastHellfire(BaseAbility ba, Mobile c) // Thanks bovi & DrNexus 
		{   // 100% scripted - DrNexus 
			// need testing 
			SpellTemplate st = (SpellTemplate)ba; 
			foreach( Object o in c.KnownObjects ) 
			{ 
				if ( o is Mobile ) 
				{ 
					Mobile mob = (Mobile)o; 
					if ( mob != c && c.Summon != mob && c.Distance( mob ) < 10f * 10f + 10f * 10f && c.Reputation( mob ) < 0.3 ) 
					{ 
                    
						st.ApplyDot( c, mob, st.S2, st.T2, st.Duration( c )  );    
					} 
				} 
			} 
			st.ApplyDot( c, c, st.S1, st.T1, st.Duration( c )  ); //   Damage himself over time 
		} 
		public static void OnCastSoulFire(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// working 
			SpellTemplate st = (SpellTemplate)ba; 
			st.MakeDamage(c, target, SpellDamage.TypeS1); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 

		#endregion 

		#region Affliction 

		public static void OnCastCurseOfWeakness(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// need testing 
          
			foreach (HaveWarlockCurse obj1 in target.AdditionnalStates) 
			{ 
				if (obj1.caster == c) 
				{ 
                
					target.ReleaseAura(obj1.AuraEff); 
					target.AdditionnalStates.Remove(obj1); 
					break; 
                
				} 
			} 
          
			// AmplifyCurse
			float modifi = 1f;
			if( c.HaveTalent(Talents.AmplifyCurse))
			{
				bool bonus = false;
				ArrayList al1 = new ArrayList();
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.AmplifyCurse );
				foreach( Mobile.AuraReleaseTimer art in c.Auras )
					if(art.aura.SpecialState == SpecialStates.AmplifyCurse)
					{
						bonus = true;
						al1.Add(art);
					}
				if (bonus) 
				{
				modifi = 1.5f ;
				foreach( Mobile.AuraReleaseTimer art in al1)
					c.ReleaseAura(art);
				}
			}
			AuraEffect st = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			float minus = (float)st.S1;          
			if ( c.HaveTalent( Talents.ImprovedCurseOfWeakness ) ) 
			{ 
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedCurseOfWeakness ); 
				minus += ( minus * (float)ae.S1 ) / 100f; 
			} 
			aura.MeleeDamageMalus = (int)(minus*modifi);       
			target.AddAura( c, st, aura, true); 
			HaveWarlockCurse haveWarlockCurse = new HaveWarlockCurse(c,st); 
			target.AdditionnalStates.Add(haveWarlockCurse); 
          
		} 

		public static void OnCastCorruption(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// working 
			SpellTemplate st = (SpellTemplate)ba; 
			st.ApplyDot( c, target, st.S1, st.T1, st.Duration( c )  );  
			// nightfall
			if ( c.HaveTalent( Talents.Nightfall ) )
				{
					int prob = 0;
					if ( c.TalentLevel( Talents.Nightfall ) == 1 )
						prob = 2;
					else
						prob = 4;
					if ( Utility.Random( 100 ) < prob )
					{
						Aura aura2 = new Aura();
						aura2.ShadowTrance = true;
						c.AddAura( (AuraEffect)Abilities.abilities[ 17941 ], aura2, false );							
					}
				}
		} 
		public static void OnCastAmplifiCurse(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			AuraEffect af = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.SpecialState = SpecialStates.AmplifyCurse;
			c.AddAura(af,aura);   
		}
		public static void OnCastLifeTap(BaseAbility ba, Mobile c) 
		{   // 100% scripted - work little different 
			// working 
			SpellTemplate st = (SpellTemplate)ba; 
			if (c.HitPoints < st.S1)  st.LifeTap( c, c, c.HitPoints - 1);   
			else st.LifeTap( c, c, SpellDamage.TypeS1);          
		} 

		public static void OnCastSoulLink(BaseAbility ba, Mobile c) 
		{   // 100% scripted - work little different 
			// working 
			AuraEffect af = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.ShareDamageWithPet = true;
			c.AddAura(af,aura);        
		} 


		public class CurseOfAgonyAura : CurseAura 
		{ 
			public CurseOfAgonyAura(AuraEffect st, Mobile c, Mobile t, int _rank) 
			{ 
				if (!t.Dead) 
				{ 
					this.rank = _rank; 
					this.spell = st; 
					this.from = c; 
					this.target = t; 
					this.damage = st.S1; 
					base.PeriodicAura(new Aura.AuraPeriodicEffect(this.PeriodicCurseOfAgony), st.Duration( c ) , st.T1); 
				} 
			} 
			Mobile from; 
			Mobile target; 
			SpellTemplate spell; 
			int[] effects = {-4,0,1,0,1,0,1,0,1,0,1,1,1,2,4}; 
			int damage; 
			int index=0; 
			int rank; 

			public void PeriodicCurseOfAgony() 
			{        
				this.damage = this.damage + effects[index]*rank; 
				index++; 
				// AmplifyCurse
				float modif = 1f;
				if( from.HaveTalent(Talents.AmplifyCurse))
				{
					
					bool bonus = false;
					ArrayList al1 = new ArrayList();
					AuraEffect ae = (AuraEffect)from.GetTalentEffect( Talents.AmplifyCurse );
					foreach( Mobile.AuraReleaseTimer art in from.Auras )
						if(art.aura.SpecialState == SpecialStates.AmplifyCurse)
						{
							bonus = true;
							al1.Add(art);
						}
					if (bonus) 
					{
						modif = 1.5f ;
						foreach( Mobile.AuraReleaseTimer art in al1)
							from.ReleaseAura(art);
					}
				}
				this.damage = (int)(this.damage*modif);
				this.spell.MakeDamage( this.from,this.target, this.damage); 
			} 
		} 

		public static void OnCastCurseOfAgony(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// bug - crash server 
			AuraEffect af = (AuraEffect)ba;
          
			foreach ( object obj1 in target.AdditionnalStates) 
			{ 
				if ( obj1 is HaveWarlockCurse ) 
					if ((obj1 as HaveWarlockCurse).caster == c) 
					{                  
						target.ReleaseAura( ( obj1 as HaveWarlockCurse ).AuraEff); 
						target.AdditionnalStates.Remove( obj1 ); 
						break; 
					} 
			}    
				CurseOfAgonyAura aura = new CurseOfAgonyAura(af, c, target,1); 
				target.AddAura(c,af,aura,true); 
				HaveWarlockCurse haveWarlockCurse = new HaveWarlockCurse(c,af); 
				target.AdditionnalStates.Add(haveWarlockCurse); 
			 
          
		} 
		public static void OnCastCurseOfTongues(BaseAbility ba, Mobile c, Mobile target) 
		{   // 0% scripted - Force target to speak demon. Spell cast times doubled. 
			// dont know how now 

		} 
		public static void OnCastFear(BaseAbility ba, Mobile c, Mobile target) 
		{ 
			// 100% scripted 
			// working but mob is stoped after thet 
			bool haveFear = false; 
			foreach (HaveWarlockFear obj1 in target.AdditionnalStates) 
			{ 
				if (obj1.caster == c) 
				{ 
					haveFear = true; 
					break; 
				} 
			} 
			if(haveFear == false) 
			{ 
				AuraEffect st = (AuraEffect)ba; 
				FearAura aura = new FearAura(); 
				aura.SpeedModifier = ((float)(st.S2/100)+1); 
				aura.ForceFlee = true; 
				target.ChangeRunSpeed( target.RunSpeed ); 
				target.AddAura(c,st,aura,true); 
				HaveWarlockFear haveWarlockFear = new HaveWarlockFear(c); 
				target.AdditionnalStates.Add(haveWarlockFear); 
			} 
          
          
		} 
		public static void OnCastDrainSoul(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted , I add the AddAura ( DrNexus ) 
			// need testing 
			AuraEffect st = (AuraEffect)ba; 
			DrainSoulAura aura = new DrainSoulAura(st, c, target); 
			target.AddAura( c, st, aura, true );   
			c.ChannelStart(target,st.Id,st.Duration(c));
		} 
		public static void OnCastCurseOfRecklessness(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// working 
          
			foreach (HaveWarlockCurse obj1 in target.AdditionnalStates) 
			{ 
				if (obj1.caster == c) 
				{ 
                
					target.ReleaseAura(obj1.AuraEff); 
					target.AdditionnalStates.Remove(obj1); 
					break; 
				} 
			} 
          
			AuraEffect st = (AuraEffect)ba; 
			CurseOfRecklessnessAura aura = new CurseOfRecklessnessAura(); 
			aura.ArmorMalus = -1*st.S1; 
			aura.AttackPowerBonus = st.S2; 
			aura.ForceFlee = false; 
			target.AddAura(c, st, aura, true );    
			HaveWarlockCurse haveWarlockCurse = new HaveWarlockCurse(c,st); 
			target.AdditionnalStates.Add(haveWarlockCurse); 
          
		} 
		public static void OnCastCurseOfTheElements(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// working 
          
			foreach (HaveWarlockCurse obj1 in target.AdditionnalStates) 
			{ 
				if (obj1.caster == c) 
				{ 
                
					target.ReleaseAura(obj1.AuraEff); 
					target.AdditionnalStates.Remove(obj1); 
					break; 
				} 
			} 
          
			AuraEffect st = (AuraEffect)ba; 
			CurseOfTheElementsAura aura = new CurseOfTheElementsAura(); 
			aura.FrostResistanceMalus = -1*st.S1; 
			aura.FireResistanceMalus = -1*st.S1; 
			target.AddAura( c,st, aura,true ); 
			HaveWarlockCurse haveWarlockCurse = new HaveWarlockCurse(c,st); 
			target.AdditionnalStates.Add(haveWarlockCurse); 
          
		} 
		public static void OnCastCurseOfIdiocy(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// working 
          
			foreach (HaveWarlockCurse obj1 in target.AdditionnalStates) 
			{ 
				if (obj1.caster == c) 
				{ 
                
					target.ReleaseAura(obj1.AuraEff); 
					target.AdditionnalStates.Remove(obj1); 
					break; 
				} 
			} 
          
			AuraEffect st = (AuraEffect)ba; 
			CurseOfIdiocyAura aura = new CurseOfIdiocyAura(st as SpellTemplate, c, target, st.Duration( c ) , 8000); 
			aura.IQMalus = -1*st.S1; 
			aura.SpiritMalus = -1*st.S1; 
			target.AddAura( c,st, aura,true );    
			HaveWarlockCurse haveWarlockCurse = new HaveWarlockCurse(c,st); 
			target.AdditionnalStates.Add(haveWarlockCurse); 
          
		} 
		public static void OnCastCurseOfShadow(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// working 
          
			foreach (HaveWarlockCurse obj1 in target.AdditionnalStates) 
			{ 
				if (obj1.caster == c) 
				{                
					target.ReleaseAura(obj1.AuraEff); 
					target.AdditionnalStates.Remove(obj1); 
					break; 
				} 
			} 
			AuraEffect st = (AuraEffect)ba; 
			CurseOfShadowAura aura = new CurseOfShadowAura(); 
			aura.ShadowResistanceMalus = -1*st.S1; 
			aura.ArcaneResistanceMalus = -1*st.S1; 
			target.AddAura( c,st, aura,true );    
			HaveWarlockCurse haveWarlockCurse = new HaveWarlockCurse(c,st); 
			target.AdditionnalStates.Add(haveWarlockCurse); 
          
		} 
		public static void OnCastCurseOfDoom(BaseAbility ba, Mobile c, Mobile target) 
		{   // 70% scripted - no summon of demon 
			// working 
          
			foreach (HaveWarlockCurse obj1 in target.AdditionnalStates) 
			{ 
				if (obj1.caster == c) 
				{ 
					target.ReleaseAura(obj1.AuraEff); 
					target.AdditionnalStates.Remove(obj1); 
					break; 
				} 
			} 
          
			AuraEffect st = (AuraEffect)ba; 
			CurseOfDoomAura aura = new CurseOfDoomAura(st, c, target); 
			target.AddAura( c,st, aura,true ); 
			HaveWarlockCurse haveWarlockCurse = new HaveWarlockCurse(c,st); 
			target.AdditionnalStates.Add(haveWarlockCurse); 
		} 
		public static void OnCastDrainLife(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// working 
			AuraEffect st = (AuraEffect)ba; 
			DrainLifeAura aura = new DrainLifeAura(st as SpellTemplate, c,target); 
			target.AddAura(c, st, aura,true );     
			// nightfall
			if ( c.HaveTalent( Talents.Nightfall ) )
			{
				int prob = 0;
				if ( c.TalentLevel( Talents.Nightfall ) == 1 )
					prob = 2;
				else
					prob = 4;
				if ( Utility.Random( 100 ) < prob )
				{
					Aura aura2 = new Aura();
					aura2.ShadowTrance = true;
					c.AddAura( (AuraEffect)Abilities.abilities[ 17941 ], aura2, false );							
				}
			}
			c.ChannelStart(target,st.Id,st.Duration(c));
		} 

		public static void OnCastSiphonLife(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// working 
			AuraEffect st = (AuraEffect)ba; 
			SiphonLifeAura aura = new SiphonLifeAura(st as SpellTemplate, c,target); 
			target.AddAura( c,st, aura,true ); 
		} 
		public static void OnCastDrainMana(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// working 
			AuraEffect st = (AuraEffect)ba; 
			DrainManaAura aura = new DrainManaAura(st as SpellTemplate, c,target); 
			target.AddAura( c,st, aura,true ); 
			c.ChannelStart(target,st.Id,st.Duration(c));
		} 

		public static void OnCastCurseOfExhaustion(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// not tested 
          
			foreach (HaveWarlockCurse obj1 in target.AdditionnalStates) 
			{ 
				if (obj1.caster == c) 
				{ 
					target.ReleaseAura(obj1.AuraEff); 
					target.AdditionnalStates.Remove(obj1); 
					break; 
				} 
			} 
			// AmplifyCurse
			float modif = 1f;
			if( c.HaveTalent(Talents.AmplifyCurse))
			{
				
				bool bonus = false;
				ArrayList al1 = new ArrayList();
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.AmplifyCurse );
				foreach( Mobile.AuraReleaseTimer art in c.Auras )
					if(art.aura.SpecialState == SpecialStates.AmplifyCurse)
					{
						bonus = true;
						al1.Add(art);
					}
				if (bonus) 
				{
					modif = 1.2f ;
					foreach( Mobile.AuraReleaseTimer art in al1)
						c.ReleaseAura(art);
				}
			}
			AuraEffect st = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			float minus = (float)st.S1 / 100f;          
			if ( c.HaveTalent( Talents.ImprovedCurseOfExhaustion ) ) 
			{ 
				AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedCurseOfExhaustion ); 
				minus += (float)ae.S1 / 100f; 
			} 
			aura.SpeedModifier = minus*modif; 
			target.ChangeRunSpeed( target.RunSpeed ); 
			target.AddAura( c, st, aura,true);  
			HaveWarlockCurse haveWarlockCurse = new HaveWarlockCurse(c,st); 
			target.AdditionnalStates.Add(haveWarlockCurse); 
          
		} 
		public static void OnCastDarkPact(BaseAbility ba, Mobile c ) 
		{   // 100% scripted 
			// working 
			// DrNexus note : Because it's a 'on self' spell 
			if( c.Summon != null ) 
				(ba as SpellTemplate).DrainMana( c, c.Summon, SpellDamage.TypeS1 ); 
		} 
		public static void OnCastHowlOfTerror(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// need testing 
			AuraEffect st = (AuraEffect)ba; 
			Character ch = c as Character; 
			int i = 0; 
			foreach (Object o in ch.Player.KnownObjects) 
			{ 
				if ((o is Mobile) && !(o is BaseSpawner)) 
				{ 
					Mobile around = (Mobile)o; 
					around.UpdateXYZ(); 
					c.UpdateXYZ(); 

					if ((c.Distance(around) < 200) && (around.Faction != c.Faction)) 
					{ 
						bool haveFear = false; 
						foreach (HaveWarlockFear obj1 in around.AdditionnalStates) 
						{ 
							if (obj1.caster == c) 
							{ 
								haveFear = true; 
								break; 
							} 
						} 
						if(haveFear == false) 
						{ 
							i++; 
							HowlOfTerrorAura aura = new HowlOfTerrorAura(); 
							aura.SpeedModifier = ((float)(st.S2/100)+1); 
							aura.ForceFlee = true; 
							around.ChangeRunSpeed( around.RunSpeed ); 
							around.AddAura(c,st,aura,true); 
							if (i==5) break; 
							HaveWarlockFear haveWarlockFear = new HaveWarlockFear(c); 
							around.AdditionnalStates.Add(haveWarlockFear); 
						} 
					} 
				} 
			} 
		} 

		public static void OnCastDeathCoil(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// working 
			SpellTemplate st = (SpellTemplate)ba; 
			st.DrainLife(target, c, SpellDamage.TypeS1);    
		} 

		#endregion 

		#region Demonology 
		public static int FelDomination = 0xE020393;
		public static void OnCastFelDomination(BaseAbility ba, Mobile c) 
		{
			AuraEffect af = (AuraEffect)ba;
			Aura aura = new Aura();
			aura.SpecialState = SpecialStates.FelDomination;
			c.AddAura(af,aura);
		}
		public static int DemonicSacrificeFireDamageIncrease = 0xE020393;
		public static void OnCastDemonicSacrifice(BaseAbility ba, Mobile c) 
		{
			if ( c.Summon == null || c.Summon.Dead ) 
				return; 
			if ( c.Summon is Imp )
			{
				AuraEffect st = (AuraEffect)Abilities.abilities[ 18789 ]; 
				Aura aura = new Aura(); 				
				aura.FirePercentDamageIncrease = ( (float)( st.S1 ) / 100f ); 
				c.AddAura(st, aura); 				
			}
			else
				if ( c.Summon is Voidwalker )
			{
				AuraEffect st = (AuraEffect)Abilities.abilities[ 18790 ]; 
				Aura aura = new Aura(); 				
				aura.HealthPercentBonus = ( (float)( st.S1 ) / 100f ); 
				c.AddAura(st, aura); 				
			}
			else
				if ( c.Summon is Succubus )
			{
				AuraEffect st = (AuraEffect)Abilities.abilities[ 18791 ]; 
				Aura aura = new Aura(); 
				aura.ShadowPercentDamageIncrease = ( (float)( st.S1 ) / 100f ); 
				c.AddAura(st, aura); 				
			}
			else
				if ( c.Summon is Felhunter )
			{
				AuraEffect st = (AuraEffect)Abilities.abilities[ 18789 ]; 
				Aura aura = new Aura(); 
				aura.ManaPercentBonus = ( (float)( st.S1 ) / 100f ); 
				c.AddAura(st, aura); 				
			}
			
			c.Summon.Kill();// DrNexus : May be you should add a nice effect when the summoned creature is killed


		}
		public static void OnCastDemonSkin(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			AuraEffect st = (AuraEffect)ba; 
			DemonSkinAura aura = new DemonSkinAura(st,c,c,st.S2,st.Duration(c),5000); 
			aura.ArmorBonus = st.S1; 
			c.AddAura(st, aura); 
            
		} 
		public static void OnCastDemonArmor(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			AuraEffect st = (AuraEffect)ba; 
			DemonArmorAura aura = new DemonArmorAura(st,c,c,st.S3,st.Duration(c),5000); 
			aura.ArmorBonus = st.S1; 
			aura.ShadowResistanceBonus = st.S2; 
			c.AddAura(st, aura); 
		} 
		public static void OnCastSummonImp(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			c.FeatherFallOn();
			( ba as SpellSummoning ).Summon( c ); 
		} 
		public static void OnCastSummonVoidwalker(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			( ba as SpellSummoning ).Summon( c ); 
			( c as Character ).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastSummonSuccubus(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			( ba as SpellSummoning ).Summon( c ); 
			( c as Character ).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastSummonEyeOfKilrogg(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			( ba as SpellSummoning ).Summon( c ); 
			( c as Character ).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastSummonFelhunter(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			( ba as SpellSummoning ).Summon( c ); 
			( c as Character ).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastSummonFelsteed(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			( ba as MountAuraEffect ).Summon( c ); 
			( c as Character ).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastInferno(BaseAbility ba, Mobile src,Mobile target) 
		{   // Don't know how it works 
		} 

		public static void OnCastRitualOfSummoning(BaseAbility ba, Mobile c, Mobile target) 
		{   // 0% scripted 
			// Summon player to caster. (Need two other people!) 
		} 
		public static void OnCastRitualOfDoom(BaseAbility ba, Mobile c, Mobile target) 
		{   // 0% scripted 
			// not working need creature 36727 
		} 
		public static void OnCastCreateHealthstoneMinor(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject( "MinorHealthstone" ); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateHealthstoneLesser(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("LesserHealthstone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateHealthstone(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("Healthstone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateHealthstoneGreater(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("GreaterHealthstone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateHealthstoneMajor(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("MajorHealthstone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateSoulstoneMinor(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("MinorSoulstone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateSoulstoneLesser(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("LesserSoulstone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateSoulstone(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("Soulstone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateSoulstoneGreater(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("GreaterSoulstone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateSoulstoneMajor(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("MajorSoulstone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateFirestoneLesser(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("LesserFirestone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateFirestone(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("Firestone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateFirestoneGreater(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("GreaterFirestone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateFirestoneMajor(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("MajorFirestone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateSpellstone(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("Spellstone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateSpellstoneGreater(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("GreaterSpellstone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 
		public static void OnCastCreateSpellstoneMajor(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			(c as Character).CreateAndAddObject("MajorSpellstone"); 
			(c as Character).ConsumeItemByIdUpTo( 6265, 1 ); 
		} 

		public static void OnCastHealthFunnel(BaseAbility ba, Mobile c ) 
		{   // 100% scripted 
			// bug in core 
			if ( c.Summon == null || c.Summon.Dead ) 
				return; 
			AuraEffect st = (AuraEffect)ba; 
			HealthFunelAura aura = new HealthFunelAura( st as SpellTemplate, c, c.Summon ); 
			c.AddAura(c, st, aura,true ); 
			c.ChannelStart(c,st.Id,st.Duration(c));
		} 
		public static void OnCastUnendingBreath(BaseAbility ba, Mobile c, Mobile target) 
		{   // 0% scripted - water breathing suport needed 
          
		} 
		public static void OnCastSenseDemons(BaseAbility ba, Mobile c) 
		{   // 0% scripted - detect demons 
            
		} 
		public static void OnCastDetectLesserInvisibility(BaseAbility ba, Mobile c, Mobile target ) 
		{   // 100% scripted 
			// need testing 
			AuraEffect st = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			aura.CanSeeLesserInvisibility = true; 
			target.AddAura( st, aura ); 
		} 
		public static void OnCastDetectInvisibility(BaseAbility ba, Mobile c, Mobile target ) 
		{   // 100% scripted 
			// need testing 
			AuraEffect st = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			aura.CanSeeMediumInvisibility = true; 
			target.AddAura( st, aura ); 
		} 
		public static void OnCastDetectGreaterInvisibility(BaseAbility ba, Mobile c, Mobile target ) 
		{   // 100% scripted 
			// need testing 
			AuraEffect st = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			aura.CanSeeGreaterInvisibility = true; 
			target.AddAura( st, aura ); 
		} 
		public static void OnCastBanish(BaseAbility ba, Mobile c, Mobile target) 
		{   // 100% scripted 
			// need testing 
			if ((target.NpcType == 3) || (target.NpcType == 4)) 
			{ 
				AuraEffect af = (AuraEffect)ba; 
				BanishAura aura = new BanishAura(target); 
				aura.ForceStun = true; 
				target.AddAura(c,af,aura,true); 
			} 
		} 
		public static void OnCastEnslaveDemon(BaseAbility ba, Mobile c, Mobile target) 
		{   // 0% scripted - not suported now 
			// Gain control of a demon. 
		} 
		public static void OnCastShadowWard(BaseAbility ba, Mobile c) 
		{   // 100% scripted 
			// working 
			AuraEffect st = (AuraEffect)ba; 
			Aura aura = new Aura(); 
			aura.ShadowAbsorb = st.S1; 
			c.AddAura(st, aura); 
		} 
  
		#endregion 
	} 
} 
