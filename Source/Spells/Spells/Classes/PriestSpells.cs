//	Script modified by gandhar - 23/08/05 19:25:47
 //	Script made by gandhar - 20/08/05 21:44:06
//---20.08.2005: added first version. damage absorbtion still not work:(
//---22.08.2005: changed shield and shadowguard
using System;
using Server;
using HelperTools;
using System.Collections;

namespace Server
{
    public class PriestSpells
    {
     //---used for inner fire aura
     public class InnerFireAura : Aura
     {

            public InnerFireAura()
            {
            

            }

            public override int AttackPowerBonus
            {
                get { return this.m_attackBonus;}
                set {this.m_attackBonus = value;}
            }

            public override int ArmorBonus
            {
               get{ return this.m_armorBonus;}
               set{this.m_armorBonus = value;}
            }

             public AuraEffect Effect 
             { 
	   get { return this.auraEffect; } 
	   set { this.auraEffect = value; } 
             } 

            private int m_attackBonus;
            private int m_armorBonus;
            private AuraEffect auraEffect; 
     }

     public class LevitateAura : Aura
     {
          
           public LevitateAura()
           {
           }

         
          public AuraEffect Effect 
          { 
	   get { return this.auraEffect; } 
	   set { this.auraEffect = value; } 
          } 

          private AuraEffect auraEffect; 
          
     }

     //---used for the Priest's shield aura
     public class PriestShieldAura : Aura
     {
           public PriestShieldAura()
           {

           }
          
          public AuraEffect Effect 
          { 
	   get { return this.auraEffect; } 
	   set { this.auraEffect = value; } 
          } 

          public override int AbsorbAllMagic
          {
               get{return this.m_absorbMagic;}
               set{this.m_absorbMagic=value;}
          }
          
          public override int PhysicalAbsorb
          {
              get{return this.m_absorbPhysical;}
              set{this.m_absorbPhysical=value;}
          }

          public override bool InteruptRegeneration
          {
                get{return this.m_interruptRegen;}
                set{this.m_interruptRegen=value;}
          }
          private AuraEffect auraEffect; 
          private int m_absorbMagic;
          private int m_absorbPhysical;
          private bool m_interruptRegen;
     }

     public class ShackleUndeadAura : Aura
     {
         
          public ShackleUndeadAura()
          {

          }
          
          public override bool ForceRoot
          {
               get { return this.m_forceRoot; } 
	 set { this.m_forceRoot = value; } 
          }

          public override bool ForceSilence
          {
               get { return this.m_forceSilence; } 
	 set { this.m_forceSilence = value; } 
          }

          public AuraEffect Effect 
          { 
	   get { return this.auraEffect; } 
	   set { this.auraEffect = value; } 
          } 

           private AuraEffect auraEffect; 
           private bool m_forceRoot;
           private bool m_forceSilence;
     }

     public class ShadowGuardAura : Aura
     {
         
          public ShadowGuardAura()
          {

          }

          public override int OnMeleeHit
          {
             get { return this.m_meleeHit; } 
             set { this.m_meleeHit = value; } 
          }

          public override int OnSpellHit
          {
             get { return this.m_spellHit; } 
             set { this.m_spellHit = value; } 
          }
          public AuraEffect Effect 
          { 
	   get { return this.auraEffect; } 
	   set { this.auraEffect = value; } 
          } 

          private AuraEffect auraEffect; 
          private int m_meleeHit;
          private int m_spellHit;
     }
        #region Holy Magic
       //---G�ttliche Pein
        public static void OnCastSmite(BaseAbility ba, Mobile c, Mobile target)
        {	// 100% test
           SpellTemplate st = (SpellTemplate)ba;
                                                                             
             Console.WriteLine("Smite: S1:{0} S2:{1} S3:{2} T1:{3} T2:{4}",(ba as SpellTemplate).S1,
                                                                                                     (ba as SpellTemplate).S2,
                                                                                                     (ba as SpellTemplate).S3,
                                                                                                     (ba as SpellTemplate).T1,
                                                                                                     (ba as SpellTemplate).T2);                                                       
            st.MakeDamage(c, target, SpellDamage.TypeS1);
        }
        public static void OnCastHolyFire(BaseAbility ba, Mobile c, Mobile target)
        {	// 100% test            
            SpellTemplate st = (SpellTemplate)ba;
            st.MakeDamage(c, target, SpellDamage.TypeS1);
            st.ApplyDot( c, target, st.S2, st.T2, st.Duration( c )  );	
        }
        public static void OnCastHolyNova(BaseAbility ba, Mobile c)
        {	
             Mobile mob = null;
             float areaEff = 30.0f; //area of effect

             foreach( Object ob in c.KnownObjects ){
                                      
                   if(ob is Mobile)
                   {            
                      mob = (Mobile)ob;
                      if( c.Distance(mob) < areaEff && mob.Faction != c.Faction ){
                         mob.UpdateXYZ();
                         c.UpdateXYZ();
                         SpellTemplate st = (SpellTemplate)ba;
                         st.MakeDamage(c,mob,SpellDamage.TypeS1);
                      }//---if
                                                        
                  }//---if
                                     
            }//---foreach
        }
        public static void OnCastLesserHeal(BaseAbility ba, Mobile c, Mobile target)
        {	// 100% test
            // Heal a target.
			SpellTemplate st = (SpellTemplate)ba;
			st.Heal( c, target, SpellDamage.TypeS1 );
        }
        public static void OnCastHeal(BaseAbility ba, Mobile c, Mobile target)
        {	// 100%
            // Heal a target.
			SpellTemplate st = (SpellTemplate)ba;
			st.Heal( c, target, SpellDamage.TypeS1 );
        }
        public static void OnCastFlashHeal(BaseAbility ba, Mobile c, Mobile target)
        {	// 100%
            // Heal a target.
			SpellTemplate st = (SpellTemplate)ba;
			st.Heal( c, target, SpellDamage.TypeS1 );
        }
        public static void OnCastPrayerOfHealing(BaseAbility ba, Mobile c)
        {	
            SpellTemplate st = (SpellTemplate)ba;
            Character  ch = null;
            Character  cc = (Character)c;
            ArrayList  gr_membs = (c as Character).GroupMembers.Members;
            float areaEff    = 20.0f;
           
               if(gr_membs.Count > 1){
                                   foreach(Member memb in gr_membs){
                                      	if(memb.Character == cc) continue;
                                      	ch = memb.Character;
                                      	Console.WriteLine("healing ..group-member: "+ ch.Name + " distance: "+c.Distance(ch) );
                                      	ch.UpdateXYZ();
                                      	c.UpdateXYZ();
                                      	if( c.Distance(ch) < areaEff*areaEff){                                                        
                                                  st.Heal(c,ch,SpellDamage.TypeS1);
                                          }//---if
                                   }//---foreach
               }//---if

        }
        public static void OnCastGreaterHeal(BaseAbility ba, Mobile c, Mobile target)
        {	// 100%
            // Heal a target.
			SpellTemplate st = (SpellTemplate)ba;
			st.Heal( c, target, SpellDamage.TypeS1 );
        }
        public static void OnCastRenew(BaseAbility ba, Mobile c, Mobile target)
        {	//100% test
			AuraEffect st = (AuraEffect)ba;
			HotAura aura = new HotAura(st,c,c,(st.S1), st.Duration( c ) , st.T1);
			c.AddAura( st, aura );
        }
        //---Verzweifeltes Gebet
        public static void OnCastDesperatePrayer(BaseAbility ba, Mobile c)
        {	//100% test
			SpellTemplate st = (SpellTemplate)ba;
			st.Heal( c, c, SpellDamage.TypeS1 );
		}
        public static void OnCastCureDisease(BaseAbility ba, Mobile c, Mobile target)
        {	//0%
            // Resurrect a target, while not in combat.
        }
        public static void OnCastResurrection(BaseAbility ba, Mobile c, Mobile target)
        {	// 0%
            // Resurrect a target, while not in combat.
            SpellTemplate st = (SpellTemplate) ba;
            target.HitPoints = st.S1;                                       
            target.HitPointsUpdate( target ); 
            if(target.Classe != Classes.Warrior && target.Classe != Classes.Rogue){
                 target.Mana = st.S2;
                 target.ManaUpdate( target );
            }
                            
        }
        public static void OnCastFearWard(BaseAbility ba, Mobile c, Mobile target)
        {   
            // Protects target from fear. Next fear will use ward up, lasts 10 minutes.
            if(c.Faction == target.Faction){
            	  AuraEffect af = (AuraEffect) ba;
            	  Aura aura     = new Aura();
            	  aura.ImmuneToFear = true;
                target.AddAura(af,aura);
            }//---if
        }
        #endregion

        #region Shadow Magic 20%
        public static void OnCastVampiricEmbrace(BaseAbility ba, Mobile c, Mobile target)
        {	// 0%
            // Afflicts target with aura, party healed 20% per shadow spell cast.
        }
        public static void OnCastShadowguard(BaseAbility ba, Mobile c)
        {	
             //---80%: without x charges! can be used infinite as long the aura is active.

	AuraEffect af = (AuraEffect) ba;
              Aura aura = new ShadowGuardAura();
              aura.OnMeleeHit = 105;
              aura.OnSpellHit  = 106;
              c.Triggers[ 105 ] = new Mobile.OnMeleeHitTrigger( OnShadowGuardHit );
              c.Triggers[ 106 ] = new Mobile.OnSpellHitTrigger( OnShadowGuardHit );
              c.AddAura(af,aura);		
            
        }
        public static void OnShadowGuardHit(Mobile m, Mobile target, AuraEffect ae )
        {
             SpellTemplate st = (SpellTemplate) ae;
             st.MakeDamage(m,target,SpellDamage.TypeS1);
        }
        public static void OnCastShadowProtection(BaseAbility ba, Mobile c, Mobile target)
        {	//100%
            AuraEffect st = (AuraEffect)ba;
            Aura aura = new Aura();
            aura.ShadowResistanceBonus = st.S1;
            target.AddAura(st, aura);
        }
        public static void OnCastTouchOfWeakness(BaseAbility ba, Mobile c, Mobile target)
        {	// 80%: Makes damage immediately instead to make damage in next attack!
            // Additional damage and damage reduction.
             // Damage reduction.
            int cdmg = c.Hit(target);
            cdmg+= (ba as SpellTemplate).S1;
            target.LooseHits(c, cdmg );
            if(c.Faction != target.Faction){
            	   AuraEffect af = (AuraEffect) ba;
            	   Aura  aura    = new Aura();
            	   aura.MeleeDamageMalus = af.S2;
            	   target.AddAura(af,aura);
            }//---if
        }
        public static void OnCastHexOfWeakness(BaseAbility ba, Mobile c, Mobile target)
        {
            // Damage reduction.
            if(c.Faction != target.Faction){
            	   AuraEffect af = (AuraEffect) ba;
            	   Aura  aura    = new Aura();
            	   aura.MeleeDamageMalus = af.S1;
            	   target.AddAura(af,aura);
            }//---if
        }
        public static void OnCastDevouringPlague(BaseAbility ba, Mobile c, Mobile target)
        {	
            //---DOT on target heals the caster(not tested!)
            SpellTemplate st = (SpellTemplate) ba;
            st.ApplyDot( c, target, st.S1, st.T1, st.Duration( c )  );
            AuraEffect af = (AuraEffect) ba;
            Aura     aura = new Aura();
            aura.OnSpellHitDone = 8;
            aura.OnSpellHit = 7;
            target.Triggers[7] = new Mobile.OnSpellHitTrigger( OnPlagueSpellHit ); 
            target.Triggers[8] = new Mobile.OnSpellHitDoneTrigger( OnPlagueSpellDone );
            target.AddAura(af,aura); 
      
        }
         public static void OnPlagueSpellHit(Mobile m, Mobile target, AuraEffect ae )
         {					
              (ae as SpellTemplate).Heal(m,target,SpellDamage.TypeS1);                            
         }		
         public static void OnPlagueSpellDone(Mobile m, Mobile target, AuraEffect ae )
         {					
             (ae as SpellTemplate).Heal(m,target,SpellDamage.TypeS1);                                                                 
        }		  
        public static void OnCastMindFlay(BaseAbility ba, Mobile c, Mobile target)
        {	//100% test
	AuraEffect af = (AuraEffect)ba;
	Aura aura = new Aura();
	aura.SpeedModifier = (af.S2)/100;
	target.AddAura(af,aura,true);
            //(af as SpellTemplate).ApplyDot( c, target, af.S1, af.T1, af.Duration( c )  );	
        }
        public static void OnCastMindControl(BaseAbility ba, Mobile c, Mobile target)
        {	// 0%
            // Take control of a mob.
        }
        public static void OnCastPain(BaseAbility ba, Mobile c, Mobile target)
        {	//100% test
            /*SpellTemplate st  = (SpellTemplate)ba;
            st.ApplyDot( c, target, st.S1, st.T1, st.Duration( c )  );*/
        }
        public static void OnCastMindBlast(BaseAbility ba, Mobile c, Mobile target)
        {	
            /*SpellTemplate st = (SpellTemplate)ba;
            st.MakeDamage(c, target, SpellDamage.TypeS1);*/
        }
        public static void OnCastMindSoothe(BaseAbility ba, Mobile c, Mobile target)
        {	//0%
            // Reduces aggro range, level limit.
            AuraEffect af = (AuraEffect) ba;
            Aura aura    = new Aura();
            target.AddAura(af,aura);
        }
        public static void OnCastMindVision(BaseAbility ba, Mobile c, Mobile target)
        {	//0%
            // Allows caster to see through targets eyes.
        }
        public static void OnCastPsychicScream(BaseAbility ba, Mobile c)
        {	
			
	AuraEffect af = (AuraEffect)ba;
	Aura aura = new Aura();
	aura.ForceFlee = true;
	

              Mobile mob = null;
              float areaEff = 30.0f; //area of effect
              
                foreach( Object ob in c.KnownObjects ){
                                      
                   if(ob is Mobile)
                   {            
                      mob = (Mobile)ob;
                      if( c.Distance(mob) < areaEff && mob.Faction != c.Faction ){
                         mob.UpdateXYZ();
                         c.UpdateXYZ();
                         mob.AddAura(af,aura,true);
                      }//---if
                                                        
                  }//---if
                                     
            }//---foreach
        }
        #endregion

        #region Discipline cca 60%
        public static void OnCastStarshards(BaseAbility ba, Mobile c, Mobile target)
        {	// test 100%
	SpellTemplate st = (SpellTemplate)ba;
	st.ApplyDot( c, target, st.S1, st.T1, st.Duration( c )  );	
        }
        public static void OnCastInnerFire(BaseAbility ba, Mobile c)
        {
            // 100%
            AuraEffect st = (AuraEffect)ba;
            Aura aura = new InnerFireAura();
            aura.ArmorBonus = st.S2;
            aura.AttackPowerBonus = st.S1;
            c.AddAura(st, aura);
        }
        public static void OnCastFortitude(BaseAbility ba, Mobile c, Mobile target)
        {	// 100%
            AuraEffect st = (AuraEffect)ba;
            Aura aura = new Aura();
            aura.StaminaBonus = st.S1;
            c.AddAura(st, aura);
        }
        public static void OnCastPrayerOfFortitude(BaseAbility ba, Mobile c)
        {	// 100%            
            AuraEffect af = (AuraEffect)ba;
            Aura aura     = new Aura();
            //Character  ch = null;
            Character  cc = (Character)c;
            ArrayList  gr_membs = (c as Character).GroupMembers.Members;
            //float areaEff    = 20.0f;
            aura.StaminaBonus = af.S1;
            c.ReleaseAllAura();
            c.AddAura(af,aura);
            /*    if(gr_membs.Count > 1){
                                   foreach(Member memb in gr_membs){
                                      	if(memb.Char == cc) continue;
                                      	ch = memb.Char;
                                      	Console.WriteLine("Group-Member: "+ ch.Name + " Distance: "+c.Distance(ch) );
                                      	ch.UpdateXYZ();
                                      	c.UpdateXYZ();
                                      	if( c.Distance(ch) < areaEff*areaEff){
                                                        ch.ReleaseAllAura();
                                        		Aura aura2 = new Aura();
                                        		aura2.StaminaBonus = af.S1;
                                                        ch.AddAura(af,aura2);
                                        
                                     	 }
                                   }
               } */
        }
        public static void OnCastDivineSpirit(BaseAbility ba, Mobile c, Mobile target)
        {	// 100%
            AuraEffect st = (AuraEffect)ba;
            Aura aura = new Aura();
            aura.SpiritBonus = st.S1;
            c.AddAura(st, aura);
        }
        public static void OnCastShield(BaseAbility ba, Mobile c, Mobile target)
        {	// 100%: absorbs x damage and gives immunity against casting-interrupts while shield is active
           AuraEffect af = (AuraEffect)ba;
           PriestShieldAura aura = new PriestShieldAura();
           //aura.AbsorbAllMagic = af.S1 * 15;
           //aura.PhysicalAbsorb = af.S1 * 15;
           aura.InteruptRegeneration = true;
           aura.ImmunePhysicalDamage = true;
           target.AddAura(af,aura);
        }
        public static void OnCastDispelMagic(BaseAbility ba, Mobile c, Mobile target)
        {	// 0%
            // Remove one beneficial spell from an enemy, or damaging spell from an ally.
        }
        public static void OnCastShackleUndead(BaseAbility ba, Mobile c, Mobile target)
        {	
            // Freeze undead target until damaged or expiration.
            if(target.NpcType == (int)NpcTypes.Undead){
            		AuraEffect af = (AuraEffect) ba;
            		ShackleUndeadAura aura     = new ShackleUndeadAura();
            		aura.ForceRoot = true;
                            aura.ForceSilence = true;
            		target.AddAura(af,aura);
            }//---if
        }
        public static void OnCastFeedback(BaseAbility ba, Mobile c)
        {	//0%
            // Drain mana dealing damage based on drain amount.
        }
        public static void OnCastElunesGrace(BaseAbility ba, Mobile c)
        {	//100% 
            // Ranged damage reduction.
            AuraEffect af = (AuraEffect) ba;
            Aura aura     = new Aura();
            aura.RangedDamageTakenMalus = af.S1;
            c.AddAura(af,aura);
        }
        public static void OnCastLevitate(BaseAbility ba, Mobile c)
        {
            //90%: need hover-effect done by core
            AuraEffect af = (AuraEffect) ba;
            LevitateAura aura = new LevitateAura();
            aura.FeatherFall = true;
            //aura.WaterWalking = true;
            c.AddAura(af,aura);
        }
        public static void OnCastManaBurn(BaseAbility ba, Mobile c, Mobile target)
        {	// 100% test: Target takes 50 percent damage from the manaburn
              if(c.Faction != target.Faction){
	    SpellTemplate st = (SpellTemplate)ba;
	    int num1= Utility.Random( st.S1, st.S1 + st.Bonus1 );
	    if (target.Mana < num1) num1 = target.Mana;
                  float burn_damage = (float)( (float) num1 * 0.5f);
	    target.LooseMana(c,num1);	
	    st.MakeDamage(c,target,burn_damage);
              }
         }
        #endregion
		public static void OnCastAbolishDisease(BaseAbility ba, Mobile c)
				{	// 0%
					
				}
		       
        public static void OnCastTouchOfWeaknessEffect(BaseAbility ba, Mobile c, Mobile target)
        {
            // 0%
        }
       

        #region Miscellanious Spells
        public static void OnCastFade(BaseAbility ba, Mobile c)
        {
            //---50%: need aggro system
            AuraEffect st = (AuraEffect)ba;
            Aura aura = new Aura();
            aura.OnRelease = new Aura.AuraReleaseDelegate(OnCastFadeEnded);
            c.Visible = InvisibilityLevel.Lesser;
            c.AddAura(st, aura);
        }
        public static void OnCastFadeEnded(Mobile c)
        {
            c.Visible = InvisibilityLevel.Visible;
        }
        #endregion
    }
}