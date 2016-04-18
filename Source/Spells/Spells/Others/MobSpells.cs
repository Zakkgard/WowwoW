using Server; 
using HelperTools; 
using System.Collections; 

namespace Server 
{ 
    public class MobSpells
    {
        #region Boar
        public class BoarChargeAura : Aura
        {
            int speedModifier;
            //int healthModifier;
            public BoarChargeAura(int speedMod, int healthMod)
            {
                speedModifier = speedMod;
                HealthBonus = healthMod;
            }
            public override float SpeedModifier
            {
                get
                {
                    return (float)((float)speedModifier / 1000.0f);
                }
            }
        }
        public static void OnCastBoarCharge(BaseAbility ba, Mobile c)
        {
            AuraEffect ae = (AuraEffect)ba;
            ae.ManaCost = 30;
            Aura aura = new BoarChargeAura(ae.S1, ae.S2);
            aura.SpeedModifier = (float)ae.S1 / 100f;
            aura.OnRelease = new Aura.AuraReleaseDelegate(OnBoarChargeAuraEnded);
            c.ChangeRunSpeed(c.RunSpeed);
            c.AddAura(ae, aura);
        }
        public static void OnBoarChargeAuraEnded(Mobile c)
        {
            c.ChangeRunSpeed(c.RunSpeed);
        }
        public static void OnCastWeakPoison(BaseAbility ba, Mobile c, Mobile target)
        {
            SpellTemplate st = (SpellTemplate)ba;
            st.ApplyDot(c, target, st.S1, st.T1, st.Duration(c));
        }

        public class ThreateningGrowlAura : Aura
        {
            // Methods 
            public ThreateningGrowlAura()
            {
            }
            // Properties 
            public override int StrMalus
            {
                get
                {
                    return this.strMalus;
                }
                set
                {
                    this.strMalus = value;
                }

            }
            public override int AgMalus
            {
                get
                {
                    return this.agilityMalus;
                }
                set
                {
                    this.agilityMalus = value;
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
            private int strMalus;
            private AuraEffect auraEffect;
            private int agilityMalus;
        }

        public static void OnCastThreateningGrowl(BaseAbility ba, Mobile c, Mobile target)
        {
            AuraEffect af = (AuraEffect)ba;
            ThreateningGrowlAura aura = new ThreateningGrowlAura();
            aura.AgMalus = af.S1;
            aura.StrMalus = af.S1;
            target.AddAura(af, aura, true);
        }

        public static void OnCastSnapKick(BaseAbility ba, Mobile c, Mobile target)
        {
            Aura aura = new Aura();
            aura.ForceStun = true;
            target.AddAura((ba as AuraEffect), aura, true);
            (ba as SpellTemplate).MakeDamage(c, target, SpellDamage.TypeS1);
        }

        		public static void OnCastDaze(BaseAbility ba, Mobile c, Mobile target) 
                        {    
                    AuraEffect af = (AuraEffect)ba; 
                    Aura aura = new Aura(); 
                    aura.SpeedModifier = (float)(af.S1/100); 
                    target.AddAura(af, aura, true); 
                    target.ChangeRunSpeed(target.RunSpeed); 
                       }
        #endregion

        #region Lightning Shield      
        public class LightningShieldAura : Aura
        {
            //Methods
            public LightningShieldAura()
            {
                this.lightningballs = 3; //Number of hits before the aura is released
            }
            public void OnCastLightningShieldTrigger(Mobile from, Mobile target, AuraEffect ae)
            {
                int chance;
                chance = HelperTools.Utility.Random(0, 2); //50% chance to hit
                              
                if (chance == 1)
                {
                    ae.MakeDamage(from, target, SpellDamage.TypeS1);
                    
                    this.lightningballs--;
                    
                    if (this.lightningballs == 0)
                    {
                        from.ReleaseAura(ae);
                    }
                }
            }
            // Properties
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
            private int lightningballs;
            private int onMeleeHit;
            private int onSpellHit;
        } 
        public static void OnCastLightningShield(BaseAbility ba, Mobile from)
        {
            AuraEffect af = (AuraEffect)ba;

            Aura lightningshieldaura = new LightningShieldAura();
            lightningshieldaura.OnMeleeHit = 7;//   id of the trigger
            lightningshieldaura.OnSpellHit = 8;//   id of the trigger
            lightningshieldaura.MeleeDamageBonus = 10000;

            from.Triggers[7] = new Mobile.OnMeleeHitTrigger((lightningshieldaura as LightningShieldAura).OnCastLightningShieldTrigger);
            from.Triggers[8] = new Mobile.OnSpellHitTrigger((lightningshieldaura as LightningShieldAura).OnCastLightningShieldTrigger);

            System.Console.WriteLine("S1: " + af.S1 + " S2: " + af.S2 + " S3: " + af.S3);
            System.Console.WriteLine("Caster GUID: " + from.Guid);

            from.AddAura(af, lightningshieldaura);
        }
        #endregion
        #region Ice Claw
        public class IceClawAura : Aura
        {
            // Methods
            public IceClawAura()
            {
            }
            // Properties
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
            private float attackSpeedModifier;
            private AuraEffect auraEffect;
        }
        public static void OnCastIceClaw(BaseAbility ba, Mobile from, Mobile target)
        {
            AuraEffect ae = (AuraEffect)ba;

            int dmg = from.Hit(target, ((float)ae.S2));

            if (dmg > 0)
            {
                SpellTemplate st = (SpellTemplate)ba;
                st.MakeDamage(from, target, ((float)dmg));

                float attackspeedmodifier = (((float)ae.S1) / 100f);

                IceClawAura iceclawaura = new IceClawAura();
                iceclawaura.AttackSpeedModifier = (((float)ae.S1) / 100f);

                target.AddAura(ae, iceclawaura, true);
            }
        }
        #endregion
        #region Terrifying Howl
        public static void OnCastTerrifyingHowl(BaseAbility ba, Mobile from)
        {
            AuraEffect ae = (AuraEffect)ba;

            ArrayList targets = SpellTarget.targetsAround(from, 5f, TargetType.Enemy);

            foreach (Mobile target in targets)
            {
                Aura terrifyinghowlaura = new Aura();
                terrifyinghowlaura.ForceFlee = true;

                target.AddAura(ae, terrifyinghowlaura, true);
            }
        }
        #endregion
        #region Tendon Rip
        public static void OnCastTendonRip(BaseAbility ba, Mobile from, Mobile target)
        {
            AuraEffect ae = (AuraEffect)ba;

            Aura tendonripaura = new Aura();
            tendonripaura.SpeedModifier = (((float)ae.S1 - 100f) / 100f);
            tendonripaura.OnRelease = new Aura.AuraReleaseDelegate(OnCastCastTendonRipEnded);

            target.AddAura(ae, tendonripaura, true);
            target.ChangeRunSpeed(target.RunSpeed);
        }
        public static void OnCastCastTendonRipEnded(Mobile c)
		{
			c.ChangeRunSpeed(c.RunSpeed);
		}
        #endregion
        #region Rend
        public static void OnCastRend(BaseAbility ba, Mobile from, Mobile target)
        {
            //Its a warrior spell
            SpellTemplate st = (SpellTemplate)ba;
            
            int damage = st.S1;

            if (from is Character && from.Level > 9 && from.HaveTalent(Talents.ImprovedRend))
            {
                AuraEffect effect1 = (AuraEffect)from.GetTalentEffect(Talents.ImprovedRend);
                float single1 = 1 + ((float)effect1.S1) / 100;
                damage = (int)(st.S1 * single1);
            }

            st.ApplyDot(from, target, damage, st.T1, st.Duration(from));
        }
        #endregion
        #region Furious Howl
        public static void OnCastFuriousHowl(BaseAbility ba, Mobile from)
        {
            Aura furioushowlaura;
            AuraEffect ae = (AuraEffect)ba;            
            
            ArrayList targets = SpellTarget.targetsAround(from, 10f, TargetType.Party);

            foreach (Mobile target in targets)
            {
                furioushowlaura = new Aura();
                furioushowlaura.StrBonus = ae.S1;

                target.AddAura(ae, furioushowlaura);
            }

            furioushowlaura = new Aura();
            furioushowlaura.StrBonus = ae.S1;

            from.AddAura(ae, furioushowlaura);
        }
        #endregion
        #region Muscle Tear
        public static void OnCastMuscleTear(BaseAbility ba, Mobile from, Mobile target)
        {
            AuraEffect ae = (AuraEffect)ba;
            int dmg = from.Hit(target, (float)ae.S1);

            if (dmg > 0)
            {
                (ba as SpellTemplate).MakeDamage(from, target, ((float)dmg));

                Aura muscletearaura = new Aura();
                muscletearaura.StrMalus = -(ae.S2);

                target.AddAura(ae, muscletearaura, true);
            }
        }
        #endregion
        #region Swoop
        public static void OnCastSwoop(BaseAbility ba, Mobile from)
        {
            AuraEffect ae = (AuraEffect)ba;
            int dmg;

            ArrayList targets = SpellTarget.targetsInConeFront(from, 5f, TargetType.Enemy, 2);

            foreach (Mobile target in targets)
            {
                dmg = from.Hit(target, ((float)ae.S1));

                if (dmg > 0)
                {
                    (ba as SpellTemplate).MakeDamage(from, target, ((float)dmg));

                    Aura swoopaura = new Aura();
                    swoopaura.ForceStun = true;

                    target.AddAura(ae, swoopaura, true);
                }
            }
        }
        #endregion
        #region Tetanus
        public static void OnCastTetanus(BaseAbility ba, Mobile from, Mobile target)
        {
            AuraEffect ae = (AuraEffect)ba;
            int dmg = from.Hit(target);

            if (dmg > 0)
            {
                Aura tetanusaura = new Aura();
                tetanusaura.StaminaMalus = -(ae.S1);

                target.AddAura(ae, tetanusaura, true);
            }
        }
        #endregion
        #region Rushing Charge
        public class RushingChargeAura : Aura
        {
            // Methods
            public RushingChargeAura()
            {
                this.firstattack = true;
            }
            // Properties
            public override int MeleeDamageBonus
            {
                get
                {
                    if (firstattack)
                    {                      
                        this.firstattack = false;
                        
                        return this.meleeDamageBonus;
                    }
                    
                    return 0;
                }
                set
                {
                    this.meleeDamageBonus = value;
                }
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
            // Fields
            private bool firstattack;
            private int meleeDamageBonus;
            private float speedModifier;
        }
        public static void OnCastRushingCharge(BaseAbility ba, Mobile from)
        {
            AuraEffect ae = (AuraEffect)ba;

            RushingChargeAura rushingchargeaura = new RushingChargeAura();
            rushingchargeaura.MeleeDamageBonus = ae.S2;
            rushingchargeaura.SpeedModifier = ((float)(ae.S1 / 100f));
            rushingchargeaura.OnRelease = new Aura.AuraReleaseDelegate(OnCastRushingChargeEnded);

            from.AddAura(ae, rushingchargeaura);
            from.ChangeRunSpeed(from.RunSpeed);
        }
        public static void OnCastRushingChargeEnded(Mobile c)
        {
            c.ChangeRunSpeed(c.RunSpeed);
        }
        #endregion
#region Trample
        public static void OnCastTrample(BaseAbility ba, Mobile from)
        {
            SpellTemplate ae = (SpellTemplate)ba;
            int dmg;
 
            ArrayList targets = SpellTarget.targetsAround(from, 10f, TargetType.Enemy);
 
            foreach (Mobile target in targets)
            {
                dmg = from.AttackSwing(target,false);
 
                if (dmg > 0)
                {
                    (ba as SpellTemplate).MakeDamage(from, target, SpellDamage.TypeS1);
                }
            }
        }
        #endregion
        #region Ravage
        public static void OnCastRavage(BaseAbility ba, Mobile from, Mobile target)
        {
            AuraEffect ae = (AuraEffect)ba;
            int dmg;

            System.Console.WriteLine("S1: " + ae.S1 + " S2: " + ae.S2 + " S3: " + ae.S3);

            dmg = from.AttackSwing(target);

            if (dmg > 0)
            {
                dmg += ae.S1;

                (ba as SpellTemplate).MakeDamage(from, target, ((float)dmg));

                Aura ravageaura = new Aura();
                ravageaura.ForceStun = true;

                target.AddAura(ae, ravageaura, true);
            }
        }
        #endregion
        #region Daze
        public static void OnCastDazed(BaseAbility ba, Mobile from, Mobile target)
        {
            AuraEffect ae = (AuraEffect)ba;

            if (ba.Id == 1604)
            {
                //Dispel Mechanic (forces dismount)
                if (target.MountModel != 0)
                {
                    target.ReleaseAura((AuraEffect)World.MountsList[target.Mounting.Id]);
                }
            }

            Aura aura = new Aura();
            aura.SpeedModifier = -(((float)ae.S1) / 100f);
            aura.OnRelease = new Aura.AuraReleaseDelegate(OnCastDazedAuraEnded);
            
            target.AddAura(ae, aura, true);
            target.ChangeRunSpeed(target.RunSpeed);
        }
        public static void OnCastDazedAuraEnded(Mobile from)
        {
            from.ChangeRunSpeed(from.RunSpeed);
        }
        #endregion
        #region Wavering Will
        public static void OnCastWaveringWill(BaseAbility ba, Mobile from, Mobile target)
        {
            AuraEffect ae = (AuraEffect)ba;

            Aura aura = new Aura();
            aura.AttackSpeedModifier = (((float)ae.S1) / 100f);
            aura.SpeedModifier = (((float)ae.S2 - 100f) / 100f);
            //aura.SpellCastSpeedModifier = (((float)ae.S1) / 100f);
            aura.OnRelease = new Aura.AuraReleaseDelegate(OnCastWaveringWillEnded);

            target.AddAura(ae, aura, true);
            target.ChangeRunSpeed(target.RunSpeed);
        }
        public static void OnCastWaveringWillEnded(Mobile from)
        {
            from.ChangeRunSpeed(from.RunSpeed);
        }
        #endregion
    } 
}