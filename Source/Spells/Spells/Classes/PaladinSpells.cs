//	Script modified by gandhar - 30/08/05 13:46:31
 //	Script modified by gandhar - 20/08/05 21:50:59
//---17.08.2005: Adjusted the script to work an Alpha 7.0
//---25.08.2005: Adjusted the script to work an Alpha 7.1: adjusted spells: purify,seal of fury,blessing of protection,blessing of the refugium(talent)
using System;
using Server;
using HelperTools;
using System.Collections; 
using System.Reflection; 

namespace Server
{        
	public class PaladinSpells
	{

           //---defines a safe location
           public class SanctSafeLocation
           {
              public SanctSafeLocation(Position pos,string name)
              {
                m_pos  = pos;
                m_name = name;
              }

              public Position m_pos;
              public string   m_name;
           }
           //---used to teleport to member to a safe place
           public class PaladinSanctuary{           
             
                public PaladinSanctuary()
                {  
                 
                }

                public void AddSanct(SanctSafeLocation sss)
                {

                  m_sanct.Add(sss);
                }
                
                public Position GetSanct(Character m)
                {
                     //int s = max(m_sanct.Count);
                     
                     switch(m.Race)
                     {
                       
                        case Races.Human:
                          foreach(SanctSafeLocation sloc in m_sanct){
                            if(sloc.m_name == "Stormwind"){
                              return sloc.m_pos;
                            }
                          }
                        break;

                        case Races.Dwarf:
                         foreach(SanctSafeLocation sloc in m_sanct){
                            if(sloc.m_name == "Ironforge"){
                              return sloc.m_pos;
                            }
                          }
                        break;
                        
                        case Races.NightElf:
                         foreach(SanctSafeLocation sloc in m_sanct){
                            if(sloc.m_name == "Darnassus"){
                              return sloc.m_pos;
                            }
                          }
                        break;

                        case Races.Gnome:
                         foreach(SanctSafeLocation sloc in m_sanct){
                            if(sloc.m_name == "Ironforge"){
                              return sloc.m_pos;
                            }
                          }
                        break;

                     }
                     return (new Position(16620.74f,16622.701f,21.338f,0));
                }
                ArrayList m_sanct = new ArrayList();
               
           }
           //---for active seals that affect the paladin
           public enum PSealTypes{
             IPaladinSealOfFury=0,
             IPaladinSealOfJustice,
             IPaladinSealOfCrusader,
             IPaladinSealOfLight,
             IPaladinSealOfRighteous,
             IPaladinSealOfWisdom          
          };
           public class HavePaladinSeal
	   { 
		public HavePaladinSeal(Mobile _caster,AuraEffect af,PSealTypes SealType) 
		{ 
			caster = _caster; 
			AuraEff = af; 
                                          SType = SealType;
		} 
		public Mobile caster; 
		public AuraEffect AuraEff; 
                            public PSealTypes SType;
	   } 
           //---for active auras
           public class HavePaladinAura
	   { 
		public HavePaladinAura(Mobile _caster,Mobile _target,AuraEffect af) 
		{ 
			caster = _caster; 
                        target = _target;
			AuraEff = af; 
		} 
		public Mobile caster; 
                public Mobile target;
		public AuraEffect AuraEff; 
	   } 
           //---for active blessings
           public class HavePaladinBlessing
	   { 
		public HavePaladinBlessing(Mobile _caster,Mobile _target,AuraEffect af) 
		{ 
			caster = _caster; 
                        target = _target;
			AuraEff = af; 
		} 
		public Mobile caster; 
                public Mobile target;
		public AuraEffect AuraEff; 
	   } 
            //---used for the talent-aura 'Blessing of Kings'. buff all attributes.
            public class BlessingOfKingsAura :Aura
            {
                  public BlessingOfKingsAura()
                  {

                  } 

                  public override int AgBonus
                  {
                         get {return this.m_agBonus;}
                         set{this.m_agBonus = value;}
                  }
                  public override int IQBonus
                  {
                         get {return this.m_iqBonus;}
                         set{this.m_iqBonus = value;}
                  }
                  public override int SpiritBonus
                  {
                         get {return this.m_spiBonus;}
                         set{this.m_spiBonus = value;}
                  }
                  public override int StaminaBonus
                  {
                         get {return this.m_staBonus;}
                         set{this.m_staBonus = value;}
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
                   private int m_agBonus;
                   private int m_iqBonus;
                   private int m_spiBonus;
                   private int m_staBonus;
            }
            public class DivineAura : Aura 
		{ 
			// Methods 
			public DivineAura() 
			{ 
			} 
			// Properties 
			/*public override int MeleeAbsorb 
			{ 
				get 
				{ 
					return this.m_meleeAbsorb; 
				} 
				set 
				{ 
					this.m_meleeAbsorb = value; 
				} 

			} */
                                          public override bool ImmunePhysicalDamage
                                          {
                                                       get 
				{ 
					return this.m_meleeAbsorb; 
				} 
				set 
				{ 
					this.m_meleeAbsorb = value; 
				} 
                                          }
                        public override float MeleePercentDamageTakenReduction 
			{ 
				get 
				{ 
					return this.m_meleePercentReduction; 
				} 
				set 
				{ 
					this.m_meleePercentReduction = value; 
				} 

			} 
                        public override int AbsorbAllMagic 
			{ 
				get 
				{ 
					return this.m_magicAbsorb; 
				} 
				set 
				{ 
					this.m_magicAbsorb = value; 
				} 

			} 
			public override float AttackSpeedModifier 
			{ 
				get 
				{ 
					return this.m_attackSpeedMod; 
				} 
				set 
				{ 
					this.m_attackSpeedMod   = value; 
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
			private bool m_meleeAbsorb; 
                        private int m_magicAbsorb;
			private AuraEffect auraEffect; 
			private float m_attackSpeedMod; 
                        private float m_meleePercentReduction;
              
		} 

		public class SealAura : Aura 
		{ 
			// Methods 
			public SealAura() 
			{ 
			} 
			// Properties 
			public override int AttackPowerBonus 
			{ 
				get 
				{ 
					return this.m_attackBonus; 
				} 
				set 
				{ 
					this.m_attackBonus = value; 
				} 

			} 
                       
			public override float AttackSpeedModifier 
			{ 
				get 
				{ 
					return this.m_attackSpeedMod; 
				} 
				set 
				{ 
					this.m_attackSpeedMod   = value; 
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
			private int m_attackBonus; 
			private AuraEffect auraEffect; 
			private float m_attackSpeedMod; 
              
		} 
                
                public static void ResetNormalMode (Mobile m)
                {
                  m.GodMode = false;
                }

                public static void RemoveSeals(Mobile m)
                {
                    //--delete all previos seals states when this current seal is ready
                    foreach(HavePaladinSeal hs in m.AdditionnalStates){
                          
                          
                          	m.AdditionnalStates.Remove(hs);
                          	break;
                         
                        
                    }
                }
                //---test target for auraeffects by a caster
                public static bool PaladinAuraAttached(Mobile caster,Mobile target,AuraEffect af)
                {
                  bool aAura = false;
                  foreach(HavePaladinAura hAura in target.AdditionnalStates){
                   
                      if(hAura.caster == caster){
                        aAura = true;
                        break;
                      }
                  }
                  return aAura;
                }		
	        //---test sealeffects on self
                public static bool PaladinSealAttached(Mobile m)
                {
                  bool aSeal = false;
                  foreach(HavePaladinSeal hAura in m.AdditionnalStates){
                   
                      if( hAura.caster == m ){
                        aSeal = true;
                        break;
                      }
                  }
                  return aSeal;
                }	
		#region Paladin spells -> all listed need PaladinSpells.cs
			#region Blessing of Freedom
                              	//0%
		   public static void OnCastBlessingofFreedom( BaseAbility ba, Mobile c, Mobile target )
                                {
                                   //need extra member-variable in the aura ,to prevent movement impairing effects
                                   AuraEffect af = (AuraEffect)ba;
                                   Aura  aura    = new Aura();
                                   aura.ForceRoot = false;
                                   target.AddAura(af,aura);
                                }
			#endregion
			#region Blessing of Light	
                                //0%
				public static void OnCastBlessingofLight( BaseAbility ba, Mobile c, Mobile target )
                                {   //increases flash light an holy light effects by x
                                    AuraEffect af = (AuraEffect)ba;
                                    Aura aura     = new Aura();
                                    target.AddAura(af,aura);
                                }		 
			#endregion
			#region Blessing of Might
                                //tested. it work's so far.	
		   public static void OnCastBlessingofMight( BaseAbility ba, Mobile c, Mobile target )
                                {
                                  //increase attack power of party member by x
                                  float areaEff    = 30.0f;
                                  if(c.Distance(target) < areaEff && c.Faction == target.Faction){
                                  	
                                        
                                  	AuraEffect af    = (AuraEffect)ba;
                                  	Aura aura        = new Aura();
                                  	aura.AttackPowerBonus = af.S1;
                                  	target.AddAura(af,aura);
                                  }
                                }		 
			#endregion
			#region Blessing of Protection	
                                //damagereduction doesn't work. used godmode instead.
				public static void OnCastBlessingofProtection( BaseAbility ba, Mobile c, Mobile target )
                           	{
                                  float areaEff    = 30.0f; 
                                  if(c.Distance(target) < areaEff && c.Faction == target.Faction){
                                   	
                                        AuraEffect af    = (AuraEffect)ba;
                                   	Aura aura        = new Aura();
                                   	aura.ImmunePhysicalDamage = true;
                                   	target.AddAura(af,aura);
                                   	
                                   }
                                }		 
			#endregion
			#region Blessing of Sacrifice
                                //must be tested.
		  public static Mobile mobCasterSacrifice = null;
                              public static int mobCurrDmgTaken = 0;
                                public static void OnCastBlessingofSacrifice( BaseAbility ba, Mobile c, Mobile target )
                                {
                                    //transfer X damage from the blessed partymember to the caster 
                                    float areaEff    = 30.0f; 
                                    if(c.Distance(target) < areaEff && c.Faction == target.Faction){
                                      
                                      mobCasterSacrifice = c;
                                      mobCurrDmgTaken = 0;
                                      AuraEffect af = (AuraEffect)ba;
                                      Aura aura     = new Aura();
                                      //aura.MeleeAbsorb = af.S1;
                                      aura.OnMeleeHit = 125;
                                      target.Triggers[ 125 ] = new Mobile.OnMeleeHitTrigger( OnBlessingSacrificeHit );
                                      target.AddAura(af,aura); 
                                    
                                    }
                                }
                                public static void OnBlessingSacrificeHit(Mobile m, Mobile target, AuraEffect ae )
				{
			            		
                                   SpellTemplate st = (SpellTemplate)ae; 
                                   int maxDmgTaken  = st.S1;
                                   int dmg = target.Hit( mobCasterSacrifice );     
		       mobCurrDmgTaken += dmg;	          		
                                   //---the caster takes a specific amout of 'damages'
                                   if(mobCurrDmgTaken <= maxDmgTaken){
                                   	mobCasterSacrifice.LooseHits(target,dmg); 
                                   }   
                                  
				}			 
			#endregion
			#region Blessing of Salvation
		   public static void OnCastBlessingofSalvation( BaseAbility ba, Mobile c, Mobile target )
                                {
                                  //reducing threat
                                }		
			#endregion
			#region Blessing of Wisdom
                                //tested and works so far.
				public static void OnCastBlessingofWisdom( BaseAbility ba, Mobile c, Mobile target )
                                {
                                    float areaEff    = 30.0f;
                                    if( c.Distance(target) < areaEff && c.Faction == target.Faction){
                                      	
                                          SpellTemplate st = (SpellTemplate)ba;
                                          int motval = st.S1;
                                             if( c.HaveTalent(Talents.ImprovedBlessingOfWisdom) ){
                                       		 AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedBlessingOfWisdom ); 
                                                        float bonus = (((float)motval / 100.0f) * ae.S1);
                                                        float t = bonus - (int)bonus;
                                                        if( t > 0.5f) bonus ++;
                                                        motval += (int) bonus;
                                        		
                                     	   }
                                    	MotAura aura     = new MotAura(st, c,target,  motval, st.Duration( target ), st.T1); 
                                    	target.AddAura(st as AuraEffect,aura);
                                    }
                                }		 
			#endregion
			#region Cleanse
                                // 0% not tested.
				public static void OnCastCleanse( BaseAbility ba, Mobile c, Mobile target )
                                {
                                    SpellTemplate st = (SpellTemplate)ba;
                                    st.Heal(c,target,SpellDamage.TypeS1);
                                }		
			#endregion
			#region Concentration Aura
				public static void OnCastConcentrationAura( BaseAbility ba, Mobile c)
                                {
                                   //gives a $s1% chance to ignore spell interruption
                                }		
			#endregion
		    #region Devotion Aura
                                //tested.work's so far.need testing in party.
		    public static void OnCastDevotionAura( BaseAbility ba, Mobile c)
                                {
                                   AuraEffect af = (AuraEffect)ba;
                                   int defense_bonus   = af.S1;
                                   if( c.HaveTalent(Talents.ImprovedDevotionAura) ){
                                        AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedDevotionAura ); 
                                        float bonus = (((float)af.S1 / 100.0f) * ae.S1);
                                        float t = bonus - (int)bonus;
                                        if(t >= 0.5f) bonus++;
                                        defense_bonus += (int)bonus;
                                        
                                        Console.WriteLine("++ Used Improved Devotion Aura ("+ae.S1+") tail:" + t );
                                    }
                                   Aura aura     = new Aura();
                                   aura.ArmorBonus = defense_bonus;
                                   Character  ch = null;
                                   Character  cc = (Character)c;
                                   ArrayList  gr_membs = (c as Character).GroupMembers.Members;
                                   float     areaEff = 30.0f; //30 Meters
                                   c.ReleaseAllAura();
                                   c.AddAura(af,aura);
                                   if(gr_membs.Count > 1){
                                   	foreach(Member memb in gr_membs){
                                      		if(memb.Character == cc) continue;
                                      		ch = memb.Character;
                                      		ch.UpdateXYZ();
                                      		c.UpdateXYZ();
                                      
                                      		if( c.Distance(ch) < areaEff * areaEff){
                                      			ch.ReleaseAllAura();
                                      			Aura aura2 = new Aura();
                                      			aura2.ArmorBonus = defense_bonus;
                                      			ch.AddAura(af,aura2);
                                    	 	}//---if
                                  	}//---foreach
                                   }//---if                                
                                }		 
		   #endregion
		   #region Divine Intervention
                                //behavior must be researched..
		   public static void OnCastDivineIntervention( BaseAbility ba, Mobile c, Mobile target )
                                {
                                                                         
                                    (c as Character).ConsumeItemByIdUpTo( 17033, 1 ); 
                                    
                                    //PaladinSanctuary sanct = new PaladinSanctuary();
                                    //sanct.AddSanct(new SanctSafeLocation(new Position(-9047.497f, 447.364f, 93.05588f,0),"Stormwind"));
                                    //sanct.AddSanct(new SanctSafeLocation(new Position(-5049.45f, -809.697f, 495.127f,0), "Ironforge"));
                                    //sanct.AddSanct(new SanctSafeLocation(new Position(9931.99f, 2193.67f, 1328.67f,1),   "Darnassus"));
                                   
                                    AuraEffect af    = (AuraEffect)ba;
                                    Aura aura        = new Aura();
                                    //Position pos     = sanct.GetSanct((Character)target);
                                    //(target as Character).Teleport(pos.X,pos.Y,pos.Z,pos.MapId);
                                    (target as Character).Teleport(-9047.497f,447.364f,93.05588f,0); //test:stormwind
                                    //aura.MeleePercentDamageTakenReduction = 100f;
                                    //aura.OnRelease   = new Aura.AuraReleaseDelegate( ResetNormalMode ); 
                                    //target.AddAura(af,aura);
                                    //target.GodMode = true;
                                    c.LooseHits(c,c.BaseHitPoints);
                                }		
			#endregion
			#region Divine Protection
                                //immune to any damage
		   public static void OnCastDivineProtection( BaseAbility ba, Mobile c)
                                {
                                  AuraEffect af    = (AuraEffect)ba;
                                  DivineAura aura  = new DivineAura();
                                  aura.ImmunePhysicalDamage = true;
                                  c.AddAura(af,aura);
                                  
                                }		 
			#endregion
			#region Divine Shield
                                //immune to any damage and lowered attack speed
				public static void OnCastDivineShield( BaseAbility ba, Mobile c)
                                {
                                   AuraEffect af = (AuraEffect)ba;
                                   DivineAura aura = new DivineAura();
                                   aura.AttackSpeedModifier = 1.0f-(af.S2/100);
                                   aura.ImmunePhysicalDamage = true;
                                   c.AddAura(af,aura);
                                }
			#endregion
		   #region Exorcism
                                //works on undead
		  public static void OnCastExorcism( BaseAbility ba, Mobile c, Mobile target )
                                {
                                     if(target.NpcType == (int)NpcTypes.Undead && c.Distance(target) < 30){
                                        
                                        SpellTemplate st = (SpellTemplate)ba;
                                        st.MakeDamage(c,target,SpellDamage.TypeS1);

                                     }
                                     else c.SpellFaillure(SpellFailedReason.InvalidTarget);
                                }		 
			#endregion
			#region Fire Resistance Aura
                                //100%.Tested in Single and Party.
		   public static void OnCastFireResistanceAura( BaseAbility ba, Mobile c )
                                {
                                   AuraEffect af = (AuraEffect)ba;
                                   Aura aura     = new Aura();
                                   Character  ch = null;
                                   Character  cc = (Character)c;
                                   ArrayList  gr_membs = (c as Character).GroupMembers.Members;
                                   float areaEff    = 20.0f;
                                   aura.FireResistanceBonus = af.S1;
                                   c.ReleaseAllAura();
                                   c.AddAura(af,aura);
                                   if(gr_membs.Count > 1){
                                   	foreach(Member memb in gr_membs){
                                      		if(memb.Character == cc) continue;
                                      		ch = memb.Character;
                                      		Console.WriteLine("Group-Member: "+ ch.Name + " Distance: "+c.Distance(ch) );
                                      		ch.UpdateXYZ();
                                      		c.UpdateXYZ();
                                      		if( c.Distance(ch) < areaEff*areaEff){
                                         			ch.ReleaseAllAura();
                                         			Aura aura2 = new Aura();
                                         			aura2.FireResistanceBonus = af.S1;
                                         			ch.AddAura(af,aura2);
                                         			Console.WriteLine("Fire Resistance Aura Gained: "+ ch.Name);
                                      		}
                                   	}//---foreach
                                   }//---if
                                }		 
			#endregion
			#region Flash of Light
                                //works so far
		   public static void OnCastFlashofLight( BaseAbility ba, Mobile c, Mobile target )
                                {
                                   SpellTemplate st = (SpellTemplate)ba;
                                   st.Heal(c,target,SpellDamage.TypeS1);
                                }		 
			#endregion
			#region Frost Resistance Aura
                                //100%.Tested in Single and Party.
		  public static void OnCastFrostResistanceAura( BaseAbility ba, Mobile c)
                                {
                                   AuraEffect af = (AuraEffect)ba;
                                   Aura aura     = new Aura();
                                   Character  ch = null;
                                   Character  cc = (Character)c;
                                   ArrayList  gr_membs = (c as Character).GroupMembers.Members;
                                   float areaEff    = 20.0f;
                                   aura.FrostResistanceBonus = af.S1;
                                   c.ReleaseAllAura();
                                   c.AddAura(af,aura);
                                   if(gr_membs.Count > 1){
                                   foreach(Member memb in gr_membs){
                                      	if(memb.Character == cc) continue;
                                      	ch = memb.Character;
                                      	Console.WriteLine("Group-Member: "+ ch.Name + " Distance: "+c.Distance(ch) );
                                      	ch.UpdateXYZ();
                                      	c.UpdateXYZ();
                                      	if( c.Distance(ch) < areaEff*areaEff){
                                                        ch.ReleaseAllAura();
                                        		Aura aura2 = new Aura();
                                        		aura2.FrostResistanceBonus = af.S1;
                                                        ch.AddAura(af,aura2);
                                        
                                     	 }//---if
                                   }//---foreach
                                  }//---if
                                }		 
			#endregion
			#region Hammer of Justice
                                //tested. it works so far.
		   public static void OnCastHammerofJustice( BaseAbility ba, Mobile c, Mobile target )
                                {
                                     float areaEff    = 10.0f;                                     
                                     if( c.Distance(target) < areaEff){
                                     	//stuns the target
                                     	AuraEffect af = (AuraEffect)ba;
                                     	Aura aura     = new Aura();
                                     	aura.ForceStun = true;
                                     	target.AddAura(af,aura);
                                     }
                                }		 
			#endregion
			#region Holy Light
                                //tested and worked.
				public static void OnCastHolyLight( BaseAbility ba, Mobile c, Mobile target )
                                {
                                   Console.WriteLine("Casting...");
                                   float areaEff    = 40.0f;                                   
                                   if( c.Distance(target) < areaEff * areaEff){
                                   	SpellTemplate st = (SpellTemplate)ba;
                                   	//st.Heal(c,target,SpellDamage.TypeS1);
                                        int hv = st.S1;
                                        int hv1 = st.S3;
                                        float bonus = 0;
                                        if( c.HaveTalent(Talents.ImprovedHolyLight) ){
                                        AuraEffect ae = (AuraEffect)c.GetTalentEffect( Talents.ImprovedHolyLight ); 
                                        bonus = (((float)hv / 100.0f) * ae.S1);
                                        float t = bonus - (int)bonus;
                                        if(t >= 0.5f) bonus++;
                                        hv += (int)bonus;
                                        
                                        Console.WriteLine("++ Used Improved Holy Light ("+ae.S1+") tail:" + t );
                                        }
                                        Console.WriteLine("[Holy Light healed "+target.Name +" for "+hv+" Talentbonus-heal: "+bonus);
                                        Console.WriteLine("Healvalue 1: "+hv+ "Healvalue 2: "+hv1+ "]");
                                        if(target.HitPoints < target.BaseHitPoints)
                                        target.HitPoints += hv;
                                        target.HitPointsUpdate( target );
                                        //c.FakeCast(635,target);
                                   }
                                }		 
			#endregion
			#region Holy Wrath
                                //tested and works. distance restrictor added.
				public static void OnCastHolyWrath( BaseAbility ba, Mobile c)
                                {
                                   Mobile mob = null;
                                   float areaEff = 20.0f; //area of effect

		        foreach( Object ob in c.KnownObjects ){
                                      
                                          if(ob is Mobile)
                                          {            
                                                        mob = (Mobile)ob;
                                       		if(mob.NpcType == (int)NpcTypes.Undead && c.Distance(mob) < areaEff){
                                                        mob.UpdateXYZ();
                                     		c.UpdateXYZ();
                                       		SpellTemplate st = (SpellTemplate)ba;
                                       		st.MakeDamage(c,mob,SpellDamage.TypeS1);
                                                        }
                                                        
                                          }
                                     
                                     }//---foreach
                                    
                                  
                                }		 
			#endregion
			#region Judgement
				public static void OnCastJudgement( BaseAbility ba, Mobile c, Mobile target ){}		
			#endregion
			#region Judgement of Fury
				public static void OnCastJudgementofFury( BaseAbility ba, Mobile c, Mobile target ){}		 
			#endregion
			#region Judgement of Justice
				public static void OnCastJudgementofJustice( BaseAbility ba, Mobile c, Mobile target ){}		 
			#endregion
			#region Judgement of Light
				public static void OnCastJudgementofLight( BaseAbility ba, Mobile c, Mobile target ){}		 
			#endregion
			#region Judgement of Wisdom
				public static void OnCastJudgementofWisdom( BaseAbility ba, Mobile c, Mobile target ){}		 
			#endregion
			#region Judgement of the Crusader
				public static void OnCastJudgementoftheCrusader( BaseAbility ba, Mobile c, Mobile target ){}		 
			#endregion
			#region Lay on Hands
                        //--tested and it works.
		  public static void OnCastLayonHands( BaseAbility ba, Mobile c, Mobile target )
                                {
                                  float areaEff    = 20.0f;
                                  if(target.Faction == c.Faction && c.Distance(target) < areaEff * areaEff)
                                  {
                                     int hp = c.BaseHitPoints;
                                     //float mana = c.Mana;
                                     SpellTemplate st = (SpellTemplate)ba;
                                     if(target.HitPoints < target.BaseHitPoints)
                                     
                                     target.HitPoints += hp;
                                     target.HitPointsUpdate( target ); 
                                    //st.Heal(c,target,SpellDamage.TypeS2);
                                     c.FakeCast( 633, target );
                                     //st.DrainMana(c,c,100f);
                                     c.Mana = 0; 
                                     c.ManaUpdate( c ); 
                                     
                                  }//---if
                                 
                                                                        
                                }		 
			#endregion
		    #region Purify	
		    public static void OnCastPurify( BaseAbility ba, Mobile c, Mobile target )
                                {
                                    //removes spelleffects from player(s)
                                     SpellTemplate st = (SpellTemplate) ba;
                                     st.Dispel(DispelType.Disease,1,target);
                                     st.Dispel(DispelType.Poison,1,target);
                               }		
			#endregion
		    #region Redemption
                                //need to be tested in party(BUG:resurrection works, but the body remains dead 'ONLY' to others,strange and funny BUG:), have you  ever seen a moving corpse:)!
				public static void OnCastRedemption( BaseAbility ba, Mobile c, Mobile target )
                                {
                                    if(target.Dead == true && target.Faction == c.Faction)
                                    {
                                       
                                        //SpellTemplate st = (SpellTemplate)ba;
                                        //st.Heal(c,target,SpellDamage.TypeS1);
                                        target.HitPoints = target.BaseHitPoints;                                       
                                        target.HitPointsUpdate(target);                                        
                                        (target as Character).ChangeBattleStance(StandStates.Standing);
                                        
                                    }
                                }		 
		#endregion
		#region Retribution Aura
                                //testeded in single. must be tested in a party 
				public static void OnCastRetributionAura( BaseAbility ba, Mobile c)
                                {
                                   AuraEffect af = (AuraEffect)ba;
                                   Aura aura     = new Aura();
                                   Character  ch = null;
                                   Character  cc = (Character)c;
                                   ArrayList  gr_membs = (c as Character).GroupMembers.Members;
                                   float areaEff = 30.0f;
                                   aura.OnMeleeHit = 123;
                                   c.Triggers[ 123 ] = new Mobile.OnMeleeHitTrigger( OnGroupMemberHit );
                                   c.ReleaseAllAura();
                                   c.AddAura(af,aura);
                                   if(gr_membs.Count > 1){
                                   	foreach(Member memb in gr_membs){
                                     		if(memb.Character == cc) continue;
                                     		ch = memb.Character;  
                                                        ch.UpdateXYZ();
                                      		c.UpdateXYZ();
                                      		if( c.Distance(ch) < areaEff*areaEff){ 
                                          		ch.ReleaseAllAura();
                                       			Aura aura2 = new Aura();
                                       			aura2.OnMeleeHit = 124;
                                       			ch.Triggers[ 124 ] = new Mobile.OnMeleeHitTrigger( OnGroupMemberHit );
                                       			ch.AddAura(af,aura);
                                       
                                     		}//---if
                                   	}//----foreach
                                   }//---if
                                }
                                public static void OnGroupMemberHit(Mobile m, Mobile target, AuraEffect ae )
		    {
					
                                        //int dmg = m.AttackSwing( target ); 
					//Console.WriteLine("HP: "+target.HitPoints);
					SpellTemplate st = (SpellTemplate) ae;
                                        st.MakeDamage(m,target,SpellDamage.TypeS1);
                                        
		   }		 
			#endregion
			#region Seal of Fury
                                //don't tested . not expected to work! need aggro management.
				public static void OnCastSealofFury( BaseAbility ba, Mobile c)
                                {
                                  if( !PaladinSealAttached(c) ){


                                      AuraEffect af = (AuraEffect)ba;
                                      Aura aura     = new Aura();
                                      aura.MeleeDamageBonus = af.S1;
                                      aura.OnRelease = new Aura.AuraReleaseDelegate( RemoveSeals ); 
                                      aura.OnMeleeHit = 5656;
                                      c.Triggers[ 5656 ] = new Mobile.OnMeleeHitTrigger( OnSealOfFuryHit );
                                      c.AddAura(af,aura);
                                      HavePaladinSeal hSeal = new HavePaladinSeal(c,af,PSealTypes.IPaladinSealOfFury);
                                      c.AdditionnalStates.Add(hSeal);
                                  }
                                }	
                                public static void OnSealOfFuryHit(Mobile m, Mobile target, AuraEffect ae )
                                {
                                     HateUnit unit; 
                                     bool ftest = false;
                                      for( int i=0; i < (target as BaseCreature).HateList.Count; i++ ) {
                                           unit = (HateUnit)(target as BaseCreature).HateList[i]; 
                                               if(unit.HatedMobile == m){
                                                     if(ftest == false){                                                                                             
                                                            switch( (ae as BaseAbility).Id ){
                                                                      case 20163: unit.Hate *= 1.5f; break;
                                                                      case 20232: unit.Hate *= 1.5f; break;
                                                                      case 20419: unit.Hate *= 2.0f; break;
                                                                      case 20421: unit.Hate *= 2.5f; break;
                                                                      case 20422: unit.Hate *= 3.0f; break;
                                                                      case 20423: unit.Hate *= 3.5f; break;
                                                            }//---switch
                                                            ftest = true;
                                                     }//---if(set modifier only once)
                                                (target as BaseCreature).HateList[i] = unit; 
                                               }//---if(player in mobile's hatelist)
                                      } //for
                                }	 
			#endregion
			#region Seal of Justice
                                //--crash the client!
		   public static void OnCastSealofJustice( BaseAbility ba, Mobile c)
                                {
                                  /*AuraEffect af = (AuraEffect)ba;
                                  Aura aura     = new Aura();
                                  aura.ForceStun = true;
                                  c.AddAura(af,aura);*/
                                }		
			#endregion
			#region Seal of Light
                                //---crashes the client!
				public static void OnCastSealofLight( BaseAbility ba, Mobile c)
                                {
                                   
                                  if( !PaladinSealAttached(c) ){

                                       //---chance to heal the paladin in melee attack
                                       AuraEffect af = (AuraEffect)ba;
                                       SealAura aura = new SealAura();
                                       /*aura.OnMeleeHit = 9800; 
                                       c.Triggers[ 9800 ] = new Mobile.OnMeleeHitTrigger( OnAuraSealOfLightHit );*/
                                       aura.OnRelease = new Aura.AuraReleaseDelegate( RemoveSeals ); 
                                       c.AddAura(af,aura);
                                       HavePaladinSeal hSeal = new HavePaladinSeal(c,af,PSealTypes.IPaladinSealOfLight);
                                       c.AdditionnalStates.Add(hSeal);
                                  }
                                }
                                public static void OnAuraSealOfLightHit(Mobile m, Mobile target, AuraEffect ae )
				{
					
                                    if( Utility.Random(1,60) < m.Level ){    
					
                                         SpellTemplate st = (SpellTemplate)ae;
                                         st.Heal(m,m,SpellDamage.TypeS1);
                                    }     
				}			 
			#endregion
			#region Seal of Righteousness
                        //tested. work's partially.'chance'-member in aura missed.
				public static void OnCastSealofRighteousness( BaseAbility ba, Mobile c)
                                {
                                   if( !PaladinSealAttached(c) ){
                                        
                                        //chance to make holy damage in melee attack
                                   	AuraEffect af = (AuraEffect)ba;
                                   	SealAura aura = new SealAura();
                                   	aura.OnMeleeHit = 9801; 
                                   	c.Triggers[ 9801 ] = new Mobile.OnMeleeHitTrigger( OnAuraRighteousnessHit );
                                        aura.OnRelease     = new Aura.AuraReleaseDelegate( RemoveSeals ); 
                                   	c.AddAura(af,aura);
                                        HavePaladinSeal hSeal = new HavePaladinSeal(c,af,PSealTypes.IPaladinSealOfRighteous);
                                        c.AdditionnalStates.Add(hSeal);
                                   }
                                   
                                }
                                public static void OnAuraRighteousnessHit(Mobile m, Mobile target, AuraEffect ae )
				{
		        //the chance to make magical damage raises with the level, don't know the original behavior		
                                    if( Utility.Random(1,60) < m.Level ){    
					
                                         SpellTemplate st = (SpellTemplate)ae;
                                         st.MakeDamage(m,target,SpellDamage.TypeS1);
                                    }     
				}				 
			#endregion
			#region Seal of Wisdom
                                //---crash the client
		   public static void OnCastSealofWisdom( BaseAbility ba, Mobile c)
                                {
                                   /*AuraEffect af = (AuraEffect)ba;
                                   SealAura aura = new SealAura();
                                   aura.OnMeleeHit = 9867; 
                                   c.Triggers[ 9867 ] = new Mobile.OnMeleeHitTrigger( OnAuraWisdomHit );
                                   c.AddAura(af,aura);
                                  */
                                }	
                                public static void OnAuraWisdomHit(Mobile m, Mobile target, AuraEffect ae )
				{
					
                                    if(Utility.Random(1,60) < m.Level && m.Mana < m.BaseMana){    
					
                                         m.GainMana(m,ae.S1);
                                    }     
				}			 
			#endregion
			#region Seal of the Crusader
                                //tested. it work's so far.
				public static void OnCastSealoftheCrusader( BaseAbility ba, Mobile c )
                                {
                                    if( !PaladinSealAttached(c) ){

                                        AuraEffect af = (AuraEffect)ba;
                                    	SealAura aura     = new SealAura();
                                    	aura.AttackPowerBonus    = af.S1;
                                    	aura.AttackSpeedModifier = 1 + (af.S2 / 100);
                                        aura.OnRelease = new Aura.AuraReleaseDelegate( RemoveSeals ); 
                                    	c.AddAura(af,aura);
                                        HavePaladinSeal hSeal = new HavePaladinSeal(c,af,PSealTypes.IPaladinSealOfCrusader);
                                        c.AdditionnalStates.Add(hSeal);
                                    }
                                }		 
			#endregion
			#region Sense Undead
				public static void OnCastSenseUndead( BaseAbility ba, Mobile c)
                                {
                                    
                                     
                                    AuraEffect af = (AuraEffect)ba;
                                    Aura aura     = new Aura();
                                    c.AddAura(af,aura);
                                    Aura.SetDetectCreature(TrackableCreatures.Undead,c);
                                }		
			#endregion
			#region Shadow Resistance Aura
                                //100%.Tested in Single and Party.
				public static void OnCastShadowResistanceAura( BaseAbility ba, Mobile c)
                                {
                                  
                                   AuraEffect af = (AuraEffect)ba;
                                   Aura aura     = new Aura();
                                   Character  ch = null;
                                   Character  cc = (Character)c;
                                   ArrayList  gr_membs = (c as Character).GroupMembers.Members;
                                   float areaEff    = 20.0f;
                                   aura.ShadowResistanceBonus = af.S1;
                                   c.ReleaseAllAura();
                                   c.AddAura(af,aura);
                                   if(gr_membs.Count > 1){
                                   	foreach(Member memb in gr_membs){
                                      		if(memb.Character == cc) continue;
                                      		ch = memb.Character;
                                      		Console.WriteLine("Group-Member: "+ ch.Name + " Distance: "+c.Distance(ch) );
                                      		ch.UpdateXYZ();
                                      		c.UpdateXYZ();
                                      		if( c.Distance(ch) < areaEff*areaEff){
                                                                      ch.ReleaseAllAura();
                                         			Aura aura2 = new Aura();
                                         			aura2.ShadowResistanceBonus = af.S1;
                                      			ch.AddAura(af,aura2);
                                        
                                      		}//---if
                                   	}//---foreach
                                   }//---if
                                }		 
			#endregion
			#region Turn Undead
                                //tested. it work's so far.
				public static void OnCastTurnUndead( BaseAbility ba, Mobile c, Mobile target )
				{
				   if(target.NpcType == (int)NpcTypes.Undead && c.Distance(target) < 400){	
                                        AuraEffect st = (AuraEffect)ba;
					Aura aura = new Aura();
					aura.ForceFlee = true;
					target.AddAura( c, st, aura );
                                  	                 }
				}
			#endregion

                                          #region holy shock - talent spell (3 ranks) - works
                                           public static void OnCastHolyShock( BaseAbility ba, Mobile c, Mobile target )
				{
				   SpellTemplate st = (SpellTemplate) ba;
                                                           st.MakeDamage( c, target, SpellDamage.TypeS1);
				}
                                          #endregion
                                            #region repentance (Bu�e) - talent spell (1 rank) - works
                                           public static void OnCastRepentance( BaseAbility ba, Mobile c, Mobile target )
				{
                                                             if( target.NpcType == (int)NpcTypes.Humanoid){
                                                             
				    	AuraEffect af  = (AuraEffect) ba;
                                                            	Aura aura      = new Aura();
                                                            	aura.ForceStun = true;
                                                            	target.AddAura( af, aura );
                                                             }
                                                             else c.SpellFaillure(SpellFailedReason.InvalidTarget);
				}
                                          #endregion
                                            #region Seal of Order - talent spell (5 ranks) - crashes the client!
                                           public static void OnCastSealOfOrder( BaseAbility ba, Mobile c )
				{
                                                          

				 /*   AuraEffect af  = (AuraEffect) ba;
                                                            Aura aura      = new Aura();
                                                            c.AddAura( af, aura ); */
				}
                                          #endregion
                                           #region Blessing of Kings - talent spell (1 rank) - works
                                           public static void OnCastBlessingOfKings( BaseAbility ba, Mobile c, Mobile target )
				{
				    AuraEffect af  = (AuraEffect) ba;
                                                            BlessingOfKingsAura aura      = new BlessingOfKingsAura();
                                                            float bonus = ( ( (float)target.Agility / 100.0f ) * af.S1 );
                                                            aura.AgBonus = (int)bonus;
                                                            bonus = ( ( (float)target.Iq / 100.0f ) * af.S1 );
                                                            aura.IQBonus = (int)bonus;
                                                            bonus = ( ( (float)target.Spirit / 100.0f ) * af.S1 );
                                                            aura.SpiritBonus = (int)bonus;
                                                            bonus = ( ( (float)target.Stamina / 100.0f ) * af.S1 );
                                                            aura.StaminaBonus = (int)bonus;
                                                            bonus = ( ( (float)target.Str / 100.0f ) * af.S1 );
                                                            aura.StrBonus = (int)bonus;
                                                            target.AddAura( af, aura );
				}
                                          #endregion
                                          #region Blessing of Refugium - talent spell (5 ranks)
                                           public static void OnCastBlessingOfRefugium( BaseAbility ba, Mobile c, Mobile target )
				{
				    AuraEffect af = (AuraEffect) ba;
                                                            Aura aura = new Aura();
                                                            aura.AllDamageAbsorb = af.S1;
                                                            target.AddAura(af,aura);
				}
                                          #endregion
                                          #endregion
	}
}