using Server;

namespace Server
{

	public class SpellHandlers : IInitialize
	{
		public static void Initialize()
		{
			#region Races Special abilites -> in developt
			#region Dwarven 
			#region Find Treasure
			SpellTemplate.SpellEffects[	2481	]=  
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastFindTreasure ); 
			#endregion
			#region    Stoneform
			SpellTemplate.SpellEffects[	20594	]=  
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastFindTreasure ); 
			#endregion
			#region Frost Resistance
			SpellTemplate.SpellEffects[	20596   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastFrostResistance ); 
			#endregion
			#region Gun Specialization
			SpellTemplate.SpellEffects[	20595	]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastGunSpecialization ); 
			#endregion
			#endregion

			#region Tauren 
			#region    War Stomp
			SpellTemplate.SpellEffects[	20549	]=  
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastWarStomp ); 
			#endregion
			#region    Nature Resistance
			SpellTemplate.SpellEffects[	20551   ]=  //tauren
				SpellTemplate.SpellEffects[	20583   ]=  //night elf
				new PermanentSpellEffect( RacesSpecialSpells.OnCastNatureResistance ); 
			#endregion
			#region       Cultivation
			SpellTemplate.SpellEffects[	20552   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastCultivation ); 
			#endregion
			#region    Endurance
			SpellTemplate.SpellEffects[	20550   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastEndurance ); 
			#endregion
			#endregion

			#region Orc 
			#region Command
			SpellTemplate.SpellEffects[	21563   ]=  
				SpellTemplate.SpellEffects[	20576	]= 
				SpellTemplate.SpellEffects[	20575	]= 
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastCommand ); 
			#endregion 
			#region Hardiness
			SpellTemplate.SpellEffects[	20573   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastHardiness ); 
			#endregion
			#region     Blood Fury
			SpellTemplate.SpellEffects[	20572   ]=  
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastBloodFury ); 
			#endregion
			#region        Axe Specialization
			SpellTemplate.SpellEffects[	20574   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastBloodFury ); 
			#endregion
			#endregion

			#region Night Elf 
			#region      Shadowmeld
			SpellTemplate.SpellEffects[	20580   ]=  
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastShadowmeld ); 
			#endregion
			#region Shadowmeld Passive
			SpellTemplate.SpellEffects[	21009   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastShadowmeldPassive ); 
			#endregion
			#region    Wisp Spirit
			SpellTemplate.SpellEffects[	20585   ]=  
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastWispSpirit ); 
			#endregion
			#region      Quickness
			SpellTemplate.SpellEffects[	20582   ]=  
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastQuickness ); 
			#endregion
			#endregion

			#region Undead
			#region  Underwater Breathing
			SpellTemplate.SpellEffects[	5227    ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastUnderwaterBreathing ); 
			#endregion
			#region     Will of the Forsaken
			SpellTemplate.SpellEffects[	7744    ]=  
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastWillOfTheForsaken ); 
			#endregion
			#region  Shadow Resistance
			SpellTemplate.SpellEffects[	20579    ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastShadowResistance ); 
			#endregion
			#region  Cannibalize
			SpellTemplate.SpellEffects[	20577    ]=  
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastCannibalize ); 
			#endregion
			#endregion

			#region Troll
			#region   Berserking
			SpellTemplate.SpellEffects[	23301   ]=  
				SpellTemplate.SpellEffects[	20554	]=  
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastBerserking ); 
			#endregion
			#region      Beast Slaying
			SpellTemplate.SpellEffects[	20557   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastBeastSlaying ); 
			#endregion
			#region    Throwing Specialization
			SpellTemplate.SpellEffects[	20558   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastThrowingSpecialization ); 
			#endregion
			#endregion

			#region Gnome
			#region    Escape Artist
			SpellTemplate.SpellEffects[	20589   ]=  
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastEscapeArtist ); 
			#endregion
			#region    Expansive Mind
			SpellTemplate.SpellEffects[	20591   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastExpansiveMind ); 
			#endregion
			#region    Engineering Specialization
			SpellTemplate.SpellEffects[	20593   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastEngineeringSpecialization ); 
			#endregion
			#region    Arcane Resistance
			SpellTemplate.SpellEffects[	20592   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastArcaneResistance ); 
			#endregion
			#endregion

			#region Human 
			#region  Diplomacy
			SpellTemplate.SpellEffects[	20599   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastDiplomacy ); 
			#endregion
			#region    Perception
			SpellTemplate.SpellEffects[	20600   ]=  
				new OnSelfSpellEffect( RacesSpecialSpells.OnCastPerception ); 
			#endregion
			#region    Sword Specialization
			SpellTemplate.SpellEffects[	  20597    ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastSwordSpecialization ); 
			#endregion
			#region    Mace Specialization
			SpellTemplate.SpellEffects[	20864   ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastMaceSpecialization ); 
			#endregion
			#region  The Human Spirit
			SpellTemplate.SpellEffects[	20598      ]=  
				new PermanentSpellEffect( RacesSpecialSpells.OnCastTheHumanSpirit ); 
			#endregion
			#endregion

			#region NightElf 
			SpellTemplate.SpellEffects[20580] = 
				new OnSelfSpellEffect(NightElf.OnCastShadowmeld); 
			#endregion
			#endregion
			
			#region weapon special -> in developt
            #region Throw
            SpellTemplate.SpellEffects[ 0xACC ] = 
				new SingleTargetSpellEffect( ThrowAndGuns.OnCastThrow );
            #endregion
            #region Gun
            SpellTemplate.SpellEffects[ 0x1EEF ] = 
				SpellTemplate.SpellEffects[ 0x9B0 ] = 
				SpellTemplate.SpellEffects[ 7918 ] = 
				new SingleTargetSpellEffect( ThrowAndGuns.OnCastGun );
            #endregion
			#endregion

			#region Shaman Spells -> all listed need ShamanSpells.cs
			/*#region AncestralSpirit 
				SpellTemplate.SpellEffects[ 2008 ] = // 5 
				SpellTemplate.SpellEffects[ 20777 ] = // 6 
				SpellTemplate.SpellEffects[ 20776 ] = // 7 
				SpellTemplate.SpellEffects[ 20610 ] = // 8 
				SpellTemplate.SpellEffects[ 20609 ] = // 9 
				new SingleTargetSpellEffect( ShamanSpells.OnCastAncestralSpirit ); 
			#endregion
			#region  Astral Recall
				SpellTemplate.SpellEffects[556 ] = // 7 
				new OnSelfSpellEffect( ShamanSpells.OnCastAstralRecall ); 
			#endregion 
			#region  ChainHeal
				SpellTemplate.SpellEffects[10623 ] = // 7 
				SpellTemplate.SpellEffects[1064 ] = // 7 
				SpellTemplate.SpellEffects[10622 ] = // 7 
				new SingleTargetSpellEffect( ShamanSpells.OnCastChainHeal); 
			#endregion 
			#region  CureDisease
				SpellTemplate.SpellEffects[2870] = 
				new SingleTargetSpellEffect( ShamanSpells.OnCastCureDisease); 
			#endregion 
			#region  CurePoison
				SpellTemplate.SpellEffects[526] = 
				new SingleTargetSpellEffect( ShamanSpells.OnCastCurePoison);
			#endregion 
			#region  Disease Cleansing Totem
				SpellTemplate.SpellEffects[8170] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastDiseaseCleansingTotem);
			#endregion 
			#region  Earth Shock
				SpellTemplate.SpellEffects[10414] = 
				SpellTemplate.SpellEffects[10412] = 
				SpellTemplate.SpellEffects[10413] = 
				SpellTemplate.SpellEffects[8046] = 
				SpellTemplate.SpellEffects[8045] = 
				SpellTemplate.SpellEffects[8044] = 
				SpellTemplate.SpellEffects[8042] = 
				new SingleTargetSpellEffect( ShamanSpells.OnCastEarthShock);
			#endregion 
			#region  Earthbind Totem
				SpellTemplate.SpellEffects[2484] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastEarthbindTotem);
			#endregion 
			#region  Far Sight
				SpellTemplate.SpellEffects[6196] = 
				new SingleTargetSpellEffect( ShamanSpells.OnCastEarthbindTotem);
			#endregion 
			#region  Fire Nova Totem
				SpellTemplate.SpellEffects[11315] = 
				SpellTemplate.SpellEffects[11314] = 
				SpellTemplate.SpellEffects[8499] = 
				SpellTemplate.SpellEffects[8498] = 
				SpellTemplate.SpellEffects[1535] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastFireNovaTotem);
			#endregion 
			#region  Fire Resistance Totem
				SpellTemplate.SpellEffects[10538] = 
				SpellTemplate.SpellEffects[10537] = 
				SpellTemplate.SpellEffects[8184] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastFireResistanceTotem);
			#endregion 
			#region  Flame Shock
				SpellTemplate.SpellEffects[10448] = 
				SpellTemplate.SpellEffects[10447] = 
				SpellTemplate.SpellEffects[8053] = 
				SpellTemplate.SpellEffects[8052] = 
				SpellTemplate.SpellEffects[8050] = 
				new SingleTargetSpellEffect( ShamanSpells.OnCastFlameShock);
			#endregion 
			#region  Flametongue Totem
				SpellTemplate.SpellEffects[16387] = 
				SpellTemplate.SpellEffects[10526] = 
				SpellTemplate.SpellEffects[8249] = 
				SpellTemplate.SpellEffects[8227] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastFlametongueTotem);
			#endregion 
			#region  Flametongue Weapon
				SpellTemplate.SpellEffects[16342] = 
				SpellTemplate.SpellEffects[16341] = 
				SpellTemplate.SpellEffects[16339] = 
				SpellTemplate.SpellEffects[8030] = 
				SpellTemplate.SpellEffects[8027] = 
				SpellTemplate.SpellEffects[8024] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastFlametongueWeapon);
			#endregion 
			#region  Frost Resistance Totem
				SpellTemplate.SpellEffects[10478] = 
				SpellTemplate.SpellEffects[8181] = 
				SpellTemplate.SpellEffects[10479] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastFrostResistanceTotem);
			#endregion 
			#region  Frost Shock
				SpellTemplate.SpellEffects[10473] = 
				SpellTemplate.SpellEffects[10472] = 
				SpellTemplate.SpellEffects[8058] = 
				SpellTemplate.SpellEffects[8056] = 
				new SingleTargetSpellEffect( ShamanSpells.OnCastFrostShock);
			#endregion 
			#region  Frostbrand Weapon
				SpellTemplate.SpellEffects[16355] = 
				SpellTemplate.SpellEffects[16356] = 
				SpellTemplate.SpellEffects[10456] = 
				SpellTemplate.SpellEffects[8038] = 
				SpellTemplate.SpellEffects[8033] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastFrostbrandWeapon);
			#endregion 
			#region  Ghost Wolf
			SpellTemplate.SpellEffects[2645] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastGhostWolf);
			#endregion 
			#region  Grace of Air Totem
			SpellTemplate.SpellEffects[10627] = 
				SpellTemplate.SpellEffects[8835] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastGraceofAirTotem);
			#endregion 
			#region  Grounding Totem
			SpellTemplate.SpellEffects[8177] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastGroundingTotem);
			#endregion 
			#region  Healing Stream Totem
				SpellTemplate.SpellEffects[10463] = 
				SpellTemplate.SpellEffects[10462] = 
				SpellTemplate.SpellEffects[6377] = 
				SpellTemplate.SpellEffects[6375] = 
				SpellTemplate.SpellEffects[5394] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastHealingStreamTotem);
			#endregion 
			#region Healing Wave 
				SpellTemplate.SpellEffects[ 331 ] = // 1 
				SpellTemplate.SpellEffects[ 332 ] = // 2 
				SpellTemplate.SpellEffects[ 547 ] = // 3 
				SpellTemplate.SpellEffects[ 913 ] = // 4 
				SpellTemplate.SpellEffects[ 939 ] = // 5 
				SpellTemplate.SpellEffects[ 959 ] = // 6 
				SpellTemplate.SpellEffects[ 8005 ] = // 7 
				SpellTemplate.SpellEffects[ 10395 ] = // 8 
				SpellTemplate.SpellEffects[ 10396 ] = // 9 
				new SingleTargetSpellEffect( ShamanSpells.OnCastHealingWave ); 
			#endregion 
			#region  Lesser Healing Wave
				SpellTemplate.SpellEffects[10468] = 
				SpellTemplate.SpellEffects[10466] = 
				SpellTemplate.SpellEffects[10467] = 
				SpellTemplate.SpellEffects[8004] = 
				SpellTemplate.SpellEffects[8008] = 
				SpellTemplate.SpellEffects[8010] = 
				new SingleTargetSpellEffect( ShamanSpells.OnCastLesserHealingWave);
			#endregion 
			#region Lightning Bolt 
			SpellTemplate.SpellEffects[ 403 ] = // 1 
				SpellTemplate.SpellEffects[ 529 ] = // 2 
				SpellTemplate.SpellEffects[ 548 ] = // 3 
				SpellTemplate.SpellEffects[ 915 ] = // 4 
				SpellTemplate.SpellEffects[ 943 ] = // 5 
				SpellTemplate.SpellEffects[ 6041 ] = // 6 
				SpellTemplate.SpellEffects[ 10391 ] = // 7 
				SpellTemplate.SpellEffects[ 10392 ] = // 8 
				SpellTemplate.SpellEffects[ 15207 ] = // 9 
				SpellTemplate.SpellEffects[ 15208 ] = // 10 
				new SingleTargetSpellEffect( ShamanSpells.OnCastLightningBolt ); 
			#endregion 
			#region Lightning Shield
				SpellTemplate.SpellEffects[ 8134 ] = // 1 
				SpellTemplate.SpellEffects[ 10432 ] = // 2 
				SpellTemplate.SpellEffects[ 10431 ] = // 3 
				SpellTemplate.SpellEffects[ 945 ] = // 4 
				SpellTemplate.SpellEffects[ 905 ] = // 5 
				SpellTemplate.SpellEffects[ 325 ] = // 6 
				SpellTemplate.SpellEffects[ 324 ] = // 7 
				new OnSelfSpellEffect( ShamanSpells.OnCastLightningShield ); 
			#endregion 
			#region Magma Totem
				SpellTemplate.SpellEffects[ 10587 ] = // 1 
				SpellTemplate.SpellEffects[ 10586 ] = // 2 
				SpellTemplate.SpellEffects[ 10585 ] = // 3 
				SpellTemplate.SpellEffects[ 8190 ] = // 4 
				new OnSelfSpellEffect( ShamanSpells.OnCastMagmaTotem ); 
			#endregion 
			#region Mana Spring Totem
			SpellTemplate.SpellEffects[ 10497 ] = // 1 
				SpellTemplate.SpellEffects[ 10496 ] = // 2 
				SpellTemplate.SpellEffects[ 10495 ] = // 3 
				SpellTemplate.SpellEffects[ 5675 ] = // 4 
				new OnSelfSpellEffect( ShamanSpells.OnCastManaSpringTotem ); 
			#endregion 
			#region Mana Tide Totem
				SpellTemplate.SpellEffects[ 16190 ] = // 1 
				SpellTemplate.SpellEffects[ 17359] = // 2 
				SpellTemplate.SpellEffects[ 17354 ] = // 3 
				new OnSelfSpellEffect( ShamanSpells.OnCastManaTideTotem ); 
			#endregion 
			#region Nature Resistance Totem
				SpellTemplate.SpellEffects[ 10601 ] = // 1 
				SpellTemplate.SpellEffects[ 10595] = // 2 
				SpellTemplate.SpellEffects[ 10600 ] = // 3 
				new OnSelfSpellEffect( ShamanSpells.OnCastNatureResistanceTotem); 
			#endregion 
			#region Poison Cleansing Totem
				SpellTemplate.SpellEffects[ 8166 ] = // 3 
				new OnSelfSpellEffect( ShamanSpells.OnCastPoisonCleansingTotem); 
			#endregion 
			#region Purge
				SpellTemplate.SpellEffects[ 8012 ] = // 1 
				SpellTemplate.SpellEffects[ 370 ] = // 1 
				new SingleTargetSpellEffect( ShamanSpells.OnCastPurge); 
			#endregion 
			#region Reincarnation
				SpellTemplate.SpellEffects[ 20608 ] = // 1 
				new OnSelfSpellEffect( ShamanSpells.OnCastReincarnation); 
			#endregion 
			#region  Rockbiter Weapon
				SpellTemplate.SpellEffects[16316] = 
				SpellTemplate.SpellEffects[16314] = 
				SpellTemplate.SpellEffects[16315] = 
				SpellTemplate.SpellEffects[8019] = 
				SpellTemplate.SpellEffects[8018] = 
				SpellTemplate.SpellEffects[8017] = 
				SpellTemplate.SpellEffects[10399] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastRockbiterWeapon);
			#endregion
			#region Searing Totem
				SpellTemplate.SpellEffects[10437] = 
				SpellTemplate.SpellEffects[6365] = 
				SpellTemplate.SpellEffects[6364] = 
				SpellTemplate.SpellEffects[6363] = 
				SpellTemplate.SpellEffects[10438] = 
				SpellTemplate.SpellEffects[3599] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastSearingTotem);
			#endregion
			#region Sentry Totem
			SpellTemplate.SpellEffects[6495] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastSentryTotem);
			#endregion
			#region Stoneclaw Totem
				SpellTemplate.SpellEffects[10428] = 
				SpellTemplate.SpellEffects[10427] = 
				SpellTemplate.SpellEffects[6392] = 
				SpellTemplate.SpellEffects[6391] = 
				SpellTemplate.SpellEffects[6390] = 
				SpellTemplate.SpellEffects[5730] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastStoneclawTotem);
			#endregion
			#region Stoneskin Totem
			SpellTemplate.SpellEffects[8154] = 
				SpellTemplate.SpellEffects[8071] = 
				SpellTemplate.SpellEffects[10407] = 
				SpellTemplate.SpellEffects[10408] = 
				SpellTemplate.SpellEffects[10406] = 
				SpellTemplate.SpellEffects[8155] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastStoneskinTotem);
			#endregion
			#region Strength of Earth Totem
			SpellTemplate.SpellEffects[10442] = 
				SpellTemplate.SpellEffects[8161] = 
				SpellTemplate.SpellEffects[8160] = 
				SpellTemplate.SpellEffects[8075] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastStrengthofEarthTotem);
			#endregion
			#region Tremor Totem
			SpellTemplate.SpellEffects[8143] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastTremorTotem);
			#endregion
			#region Water Breathing
			SpellTemplate.SpellEffects[131] = 
				new SingleTargetSpellEffect( ShamanSpells.OnCastWaterBreathing);
			#endregion
			#region Water Walking
			SpellTemplate.SpellEffects[546] = 
				new SingleTargetSpellEffect( ShamanSpells.OnCastWaterWalking);
			#endregion
			#region Windfury Totem
				SpellTemplate.SpellEffects[10613] = 
				SpellTemplate.SpellEffects[8512] = 
				SpellTemplate.SpellEffects[10614] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastWindfuryTotem);
			#endregion
			#region Windfury Weapon
				SpellTemplate.SpellEffects[8235] = 
				SpellTemplate.SpellEffects[8232] = 
				SpellTemplate.SpellEffects[16362] = 
				SpellTemplate.SpellEffects[10486] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastWindfuryWeapon);
			#endregion
			#region Windwall Totem
				SpellTemplate.SpellEffects[15112] = 
				SpellTemplate.SpellEffects[15111] = 
				SpellTemplate.SpellEffects[15107] = 
				new OnSelfSpellEffect( ShamanSpells.OnCastWindwallTotem);
			#endregion*/
			#endregion

			#region Mage Spells 
			#region Spells 
			#region Arcane 
			#region Amplify Magic 100% 
			SpellTemplate.SpellEffects[1008] = // 1 
				SpellTemplate.SpellEffects[8455] = // 2 
				SpellTemplate.SpellEffects[10169] = // 3 
				SpellTemplate.SpellEffects[10170] = // 4 
				new SingleTargetSpellEffect(MageSpells.OnCastAmplifyMagic); 
			#endregion 
			#region Arcane Explosion 100% 
			SpellTemplate.SpellEffects[1449] = // 1 
				SpellTemplate.SpellEffects[8437] = // 2 
				SpellTemplate.SpellEffects[8438] = // 3 
				SpellTemplate.SpellEffects[8439] = // 4 
				SpellTemplate.SpellEffects[10201] = // 5 
				SpellTemplate.SpellEffects[10202] = // 6 
				new OnSelfSpellEffectMultiple(MageSpells.OnCastArcaneExplosion); 
			#endregion 
			#region Arcane Intellect 100% 
			SpellTemplate.SpellEffects[1459] = // 1 
				SpellTemplate.SpellEffects[1460] = // 2 
				SpellTemplate.SpellEffects[1461] = // 3 
				SpellTemplate.SpellEffects[10156] = // 4 
				SpellTemplate.SpellEffects[10157] = // 5 
				new SingleTargetSpellEffect( MageSpells.OnCastArcaneIntellect ); 
			#endregion 
			#region Arcane Missiles 100% 
			SpellTemplate.SpellEffects[ 5143 ] = // 1 
				SpellTemplate.SpellEffects[ 5144 ] = // 2 
				SpellTemplate.SpellEffects[ 5145 ] = // 3 
				SpellTemplate.SpellEffects[ 8416 ] = // 4 
				SpellTemplate.SpellEffects[ 8417 ] = // 5 
				SpellTemplate.SpellEffects[ 10211 ] = // 6 
				SpellTemplate.SpellEffects[ 10212 ] = // 7 
				new OnSelfSpellEffect( MageSpells.OnCastArcaneMissiles ); 
			#endregion 
			#region Blink 100% 
			SpellTemplate.SpellEffects[ 1953 ] = 
				new OnSelfSpellEffect( MageSpells.OnCastBlink ); 
			#endregion 
			#region Conjure Food 100% 
			SpellTemplate.SpellEffects[587] = // 1 
				SpellTemplate.SpellEffects[597] = // 2 
				SpellTemplate.SpellEffects[990] = // 3 
				SpellTemplate.SpellEffects[6129] = // 4 
				SpellTemplate.SpellEffects[10144] = // 5 
				SpellTemplate.SpellEffects[10145] = // 6 
				new OnSelfSpellEffect(MageSpells.OnCastConjureFood); 
			#endregion 
			#region Conjure Mana Agate 100% 
			SpellTemplate.SpellEffects[759] = new OnSelfSpellEffect(MageSpells.OnCastConjureManaAgate); 
			#endregion 
			#region Conjure Mana Citrine 100% 
			SpellTemplate.SpellEffects[10053] = new OnSelfSpellEffect(MageSpells.OnCastConjureManaCitrine); 
			#endregion 
			#region Conjure Mana Jade 100% 
			SpellTemplate.SpellEffects[3552] = new OnSelfSpellEffect(MageSpells.OnCastConjureManaJade); 
			#endregion 
			#region Conjure Mana Ruby 100% 
			SpellTemplate.SpellEffects[10054] = new OnSelfSpellEffect(MageSpells.OnCastConjureManaRuby); 
			#endregion 
			#region Conjure Water 100% 
			SpellTemplate.SpellEffects[5504] = // 1 
				SpellTemplate.SpellEffects[5505] = // 2 
				SpellTemplate.SpellEffects[5506] = // 3 
				SpellTemplate.SpellEffects[6127] = // 4 
				SpellTemplate.SpellEffects[10138] = // 5 
				SpellTemplate.SpellEffects[10139] = // 6 
				SpellTemplate.SpellEffects[10140] = // 7 
				new OnSelfSpellEffect(MageSpells.OnCastConjureWater); 
			#endregion 
			#region CounterSpell 100% 
			SpellTemplate.SpellEffects[2139] = new SingleTargetSpellEffect(MageSpells.OnCastCounterspell); 
			#endregion 
			#region Dampen Magic 100% 
			SpellTemplate.SpellEffects[604] = // 1 
				SpellTemplate.SpellEffects[8450] = // 2 
				SpellTemplate.SpellEffects[8451] = // 3 
				SpellTemplate.SpellEffects[10173] = // 4 
				SpellTemplate.SpellEffects[10174] = // 5 
				new SingleTargetSpellEffect(MageSpells.OnCastDampenMagic); 
			#endregion 
			#region Detect Magic 100% 
			SpellTemplate.SpellEffects[ 2855 ] = 
				new SingleTargetSpellEffect( MageSpells.OnCastDetectMagic ); 
			#endregion 
			#region Mage Armor 100% 
			SpellTemplate.SpellEffects[6117] = // 1 
				SpellTemplate.SpellEffects[22782] = // 2 
				SpellTemplate.SpellEffects[22783] = // 3 
				new OnSelfSpellEffect(MageSpells.OnCastMageArmor); 
			#endregion 
			#region Mana Shield 100% 
			SpellTemplate.SpellEffects[1463] = // 1 
				SpellTemplate.SpellEffects[8494] = // 2 
				SpellTemplate.SpellEffects[8495] = // 3 
				SpellTemplate.SpellEffects[10191] = // 4 
				SpellTemplate.SpellEffects[10192] = // 5 
				SpellTemplate.SpellEffects[10193] = // 6 
				new OnSelfSpellEffect(MageSpells.OnCastManaShield); 
			#endregion 
			#region Polymorph 100% 
			SpellTemplate.SpellEffects[118] = // 1 
				SpellTemplate.SpellEffects[12824] = // 2 
				SpellTemplate.SpellEffects[12825] = // 3 
				SpellTemplate.SpellEffects[12826] = // 4 
				new SingleTargetSpellEffect(MageSpells.OnCastPolymorph); 
			#endregion 
			#region Portal Darnassus 100% 
			SpellTemplate.SpellEffects[11419] = new OnSelfSpellEffect(MageSpells.OnCastPortalDarnassus); 
			#endregion 
			#region Portal Ironforge 100% 
			SpellTemplate.SpellEffects[11416] = new OnSelfSpellEffect(MageSpells.OnCastPortalIronforge); 
			#endregion 
			#region Portal Orgrimmar 100% 
			SpellTemplate.SpellEffects[11417] = new OnSelfSpellEffect(MageSpells.OnCastPortalOrgrimmar); 
			#endregion 
			#region Portal Stormwind 100% 
			SpellTemplate.SpellEffects[10059] = new OnSelfSpellEffect(MageSpells.OnCastPortalStormwind); 
			#endregion 
			#region Portal ThunderBluff 100% 
			SpellTemplate.SpellEffects[11420] = new OnSelfSpellEffect(MageSpells.OnCastPortalThunderBluff); 
			#endregion 
			#region Portal Undercity 100% 
			SpellTemplate.SpellEffects[11418] = new OnSelfSpellEffect(MageSpells.OnCastPortalUndercity); 
			#endregion 
			#region Remove Lesser Curse 100% 
			SpellTemplate.SpellEffects[475] = new SingleTargetSpellEffect(MageSpells.OnCastRemoveLesserCurse); 
			#endregion 
			#region Slow Fall 100% 
			SpellTemplate.SpellEffects[130] = new OnSelfSpellEffect(MageSpells.OnCastSlowFall); 
			#endregion 
			#region Teleport Darnassus 100% 
			SpellTemplate.SpellEffects[3565] = new OnSelfSpellEffect(MageSpells.OnCastTeleportDarnassus); 
			#endregion 
			#region Teleport Ironforge 100% 
			SpellTemplate.SpellEffects[3562] = new OnSelfSpellEffect(MageSpells.OnCastTeleportIronforge); 
			#endregion 
			#region Teleport Orgrimmar 100% 
			SpellTemplate.SpellEffects[3567] = new OnSelfSpellEffect(MageSpells.OnCastTeleportOrgrimmar); 
			#endregion 
			#region Teleport Stormwind 100% 
			SpellTemplate.SpellEffects[3561] = new OnSelfSpellEffect(MageSpells.OnCastTeleportStormwind); 
			#endregion 
			#region Teleport ThunderBluff 100% 
			SpellTemplate.SpellEffects[3566] = new OnSelfSpellEffect(MageSpells.OnCastTeleportThunderBluff); 
			#endregion 
			#region Teleport Undercity 100% 
			SpellTemplate.SpellEffects[3563] = new OnSelfSpellEffect(MageSpells.OnCastTeleportUndercity); 
			#endregion 
			#endregion 
			#region Fire 
			#region Blast Wave 100% 
			SpellTemplate.SpellEffects[11113] = // 1 
				SpellTemplate.SpellEffects[13018] = // 2 
				SpellTemplate.SpellEffects[13019] = // 3 
				SpellTemplate.SpellEffects[13020] = // 4 
				SpellTemplate.SpellEffects[13021] = // 5 
				new OnSelfSpellEffect(MageSpells.OnCastBlastWave); 
			#endregion 
			#region Fireball 100% 
			SpellTemplate.SpellEffects[133] = // 1 
				SpellTemplate.SpellEffects[143] = // 2 
				SpellTemplate.SpellEffects[145] = // 3 
				SpellTemplate.SpellEffects[3140] = // 4 
				SpellTemplate.SpellEffects[8400] = // 5 
				SpellTemplate.SpellEffects[8401] = // 6 
				SpellTemplate.SpellEffects[8402] = // 7 
				SpellTemplate.SpellEffects[10148] = // 8 
				SpellTemplate.SpellEffects[10149] = // 9 
				SpellTemplate.SpellEffects[10150] = // 10 
				SpellTemplate.SpellEffects[10151] = // 11 
				new SingleTargetSpellEffect(MageSpells.OnCastFireball); 
			#endregion 
			#region Fire Blast 100% 
			SpellTemplate.SpellEffects[2136] = // 1 
				SpellTemplate.SpellEffects[2137] = // 2 
				SpellTemplate.SpellEffects[2138] = // 3 
				SpellTemplate.SpellEffects[8412] = // 4 
				SpellTemplate.SpellEffects[8413] = // 5 
				SpellTemplate.SpellEffects[10197] = // 6 
				SpellTemplate.SpellEffects[10199] = // 7 
				new SingleTargetSpellEffect(MageSpells.OnCastFireBlast); 
			#endregion 
			#region Fire Ward 100% 
			SpellTemplate.SpellEffects[543] = // 1 
				SpellTemplate.SpellEffects[8457] = // 2 
				SpellTemplate.SpellEffects[8458] = // 3 
				SpellTemplate.SpellEffects[10223] = // 4 
				SpellTemplate.SpellEffects[10225] = // 5 
				new OnSelfSpellEffect(MageSpells.OnCastFireWard); 
			#endregion 
			#region Flamestrike 100% 
			SpellTemplate.SpellEffects[ 2120 ] = // 1 
				SpellTemplate.SpellEffects[ 2121 ] = // 2 
				SpellTemplate.SpellEffects[ 8422 ] = // 3 
				SpellTemplate.SpellEffects[ 8423 ] = // 4 
				SpellTemplate.SpellEffects[ 10215 ] = // 5 
				SpellTemplate.SpellEffects[ 10216 ] = // 6 
				new TargetXYZSpellEffect( MageSpells.OnCastFlamestrike ); 
			#endregion       
			#region Pyroblast 100% 
			SpellTemplate.SpellEffects[11366] = // 1 
				SpellTemplate.SpellEffects[12505] = // 2 
				SpellTemplate.SpellEffects[12522] = // 3 
				SpellTemplate.SpellEffects[12523] = // 4 
				SpellTemplate.SpellEffects[12524] = // 5 
				SpellTemplate.SpellEffects[12525] = // 6 
				SpellTemplate.SpellEffects[12526] = // 7 
				SpellTemplate.SpellEffects[18809] = // 8 
				new SingleTargetSpellEffect(MageSpells.OnCastPyroblast); 
			#endregion 
			#region Scorch 100% 
			SpellTemplate.SpellEffects[2948] = // 1 
				SpellTemplate.SpellEffects[8444] = // 2 
				SpellTemplate.SpellEffects[8445] = // 3 
				SpellTemplate.SpellEffects[8446] = // 4 
				SpellTemplate.SpellEffects[10205] = // 5 
				SpellTemplate.SpellEffects[10206] = // 6 
				SpellTemplate.SpellEffects[10207] = // 7 
				new SingleTargetSpellEffect(MageSpells.OnCastScorch); 
			#endregion  
			#endregion 
			#region Frost 
			#region Blusard 100% 
			SpellTemplate.SpellEffects[ 10 ] = // 1 
				SpellTemplate.SpellEffects[ 6141 ] = // 2 
				SpellTemplate.SpellEffects[ 8427 ] = // 3 
				SpellTemplate.SpellEffects[ 10185 ] = // 4 
				SpellTemplate.SpellEffects[ 10186 ] = // 5 
				SpellTemplate.SpellEffects[ 10187 ] = // 6 
				new TargetXYZSpellEffect( MageSpells.OnCastBlizzard ); 
			#endregion       
			#region Cone of Cold 100% 
			SpellTemplate.SpellEffects[120] = // 1 
				SpellTemplate.SpellEffects[8492] = // 2 
				SpellTemplate.SpellEffects[10159] = // 3 
				SpellTemplate.SpellEffects[10160] = // 4 
				SpellTemplate.SpellEffects[10161] = // 5 
				new OnSelfSpellEffect(MageSpells.OnCastConeOfCold); 
			#endregion 
			#region Frost Armor 100% 
			SpellTemplate.SpellEffects[168] = // 1 
				SpellTemplate.SpellEffects[7300] = // 2 
				SpellTemplate.SpellEffects[7301] = // 3 
				new OnSelfSpellEffect(MageSpells.OnCastFrostArmor); 
			#endregion 
			#region Frostbolt 100% 
			SpellTemplate.SpellEffects[ 116 ] = // 1 
				SpellTemplate.SpellEffects[ 205 ] = // 2 
				SpellTemplate.SpellEffects[ 837 ] = // 3 
				SpellTemplate.SpellEffects[ 7322 ] = // 4 
				SpellTemplate.SpellEffects[ 8406 ] = // 5 
				SpellTemplate.SpellEffects[ 8407 ] = // 6 
				SpellTemplate.SpellEffects[ 8408 ] = // 7 
				SpellTemplate.SpellEffects[ 10179 ] = // 8 
				SpellTemplate.SpellEffects[ 10180 ] = // 9 
				SpellTemplate.SpellEffects[ 10181 ] = // 10 
				new SingleTargetSpellEffect( MageSpells.OnCastFrostbolt ); 
			#endregion 
			#region Frost Nova 100% 
			SpellTemplate.SpellEffects[122] = // 1 
				SpellTemplate.SpellEffects[865] = // 2 
				SpellTemplate.SpellEffects[6131] = // 3 
				SpellTemplate.SpellEffects[10230] = // 4 
				new OnSelfSpellEffect(MageSpells.OnCastFrostNova); 
			#endregion    
			#region Frost Ward 100% 
			SpellTemplate.SpellEffects[6143] = // 1 
				SpellTemplate.SpellEffects[8461] = // 2 
				SpellTemplate.SpellEffects[8462] = // 3 
				SpellTemplate.SpellEffects[10177] = // 4 
				new OnSelfSpellEffect(MageSpells.OnCastFrostWard); 
			#endregion 
			#region Ice Armor 100% 
			SpellTemplate.SpellEffects[7302] = // 1 
				SpellTemplate.SpellEffects[7320] = // 2 
				SpellTemplate.SpellEffects[10219] = // 3 
				SpellTemplate.SpellEffects[10220] = // 4 
				new OnSelfSpellEffect(MageSpells.OnCastIceArmor); 
			#endregion 
			#endregion 
			#endregion 
			#region Talents 
			#region   Arcane 
			#region Arcane Power 100% 
			SpellTemplate.SpellEffects[12042] = new OnSelfSpellEffect(MageSpells.OnCastArcanePower); 
			#endregion 
			#region Evocation 100% 
			SpellTemplate.SpellEffects[12051] = new OnSelfSpellEffect(MageSpells.OnCastEvocation); 
			#endregion 
			#region Presence of Mind 100% 
			SpellTemplate.SpellEffects[ 12043 ] = 
				new OnSelfSpellEffect( MageSpells.OnCastPresenceOfMind ); 
			#endregion 
			#endregion 
			#region Fire 
			#region Combustion 100% 
			SpellTemplate.SpellEffects[11129] = new OnSelfSpellEffect(MageSpells.OnCastCombustion); 
			#endregion 
			#endregion 
			#region Frost 
			#region ColdSnap 100% 
			SpellTemplate.SpellEffects[ 12472 ] = 
				new OnSelfSpellEffect( MageSpells.OnCastColdSnap ); 
			#endregion 
			#region Ice Barrier 100% 
			SpellTemplate.SpellEffects[11426] = // 1 
				SpellTemplate.SpellEffects[13031] = // 2 
				SpellTemplate.SpellEffects[13032] = // 3 
				SpellTemplate.SpellEffects[13033] = // 4 
				new OnSelfSpellEffect(MageSpells.OnCastIceBarrier); 
			#endregion 
			#region Ice Block 100% 
			SpellTemplate.SpellEffects[11958] = new OnSelfSpellEffect(MageSpells.OnCastIceBlock); 
			#endregion    
			#endregion 
			#endregion 
			#endregion 


			#region Druid Spells -> all listed 
			#region Abolish Poison	
			SpellTemplate.SpellEffects[	2893	]=	
				new SingleTargetSpellEffect(DruidSpells.OnCastAbolishPoison);		//	
			#endregion
			#region Abolish Poison Effect	
			SpellTemplate.SpellEffects[	3137	]=	
				new OnSelfSpellEffect(DruidSpells.OnCastAbolishPoisonEffect);		//	
			#endregion
			#region Aquatic Form	
			SpellTemplate.SpellEffects[	1066	]=	
				new OnSelfSpellEffect(DruidSpells.OnCastAquaticForm);		//Shapeshift
			#endregion
			#region Aquatic Form (Passive)	
			SpellTemplate.SpellEffects[	5421	]=	
				new OnSelfSpellEffect(DruidSpells.OnCastAquaticForm);		//Passive
			#endregion
			#region Barkskin	
			SpellTemplate.SpellEffects[	22812	]=	
				new OnSelfSpellEffect(DruidSpells.OnCastBarkskin);		//	
			#endregion
			#region Barkskin Effect (DND)
			SpellTemplate.SpellEffects[	22839	]=	
				new OnSelfSpellEffect(DruidSpells.OnCastBarkskinEffect);		
			#endregion
			#region Bash	
			SpellTemplate.SpellEffects[	8983	]=				//Rank 3	
			SpellTemplate.SpellEffects[	6798	]=				//Rank 2	
				SpellTemplate.SpellEffects[	5211	]=
				new SingleTargetSpellEffect(DruidSpells.OnCastBash);		//Rank 1	
			#endregion
			#region Bear Form
			SpellTemplate.SpellEffects[	5487	]=	new OnSelfSpellEffect(DruidSpells.OnCastBearForm);		//Shapeshift	
			#endregion
			#region Bear Form (Passive)
			SpellTemplate.SpellEffects[	1178	]=	new OnSelfSpellEffect(DruidSpells.OnCastBearForm);		//Passive	
			#endregion
			#region Cat Form	
			SpellTemplate.SpellEffects[	768	]=	new OnSelfSpellEffect(DruidSpells.OnCastCatForm);		//Shapeshift	
			#endregion
			#region Cat Form (Passive)
			SpellTemplate.SpellEffects[	3025	]=	new OnSelfSpellEffect(DruidSpells.OnCastCatForm);		//Passive	
			#endregion
			#region Challenging Roar
			SpellTemplate.SpellEffects[	5209	]=	new OnSelfSpellEffect(DruidSpells.OnCastChallengingRoar);		//	
			#endregion
			#region Claw
			SpellTemplate.SpellEffects[	9850	]=				//Rank 5	
			SpellTemplate.SpellEffects[	9849	]=				//Rank 4	
				SpellTemplate.SpellEffects[	5201	]=				//Rank 3	
				SpellTemplate.SpellEffects[	1082	]=				//Rank 1	
				SpellTemplate.SpellEffects[	3029	]=	new SingleTargetSpellEffect(DruidSpells.OnCastClaw);		//Rank 2	
			#endregion
			#region Cower
			SpellTemplate.SpellEffects[	9000	]=				//Rank 2	
			SpellTemplate.SpellEffects[	8998	]=				//Rank 1	
				SpellTemplate.SpellEffects[	9892	]=	new OnSelfSpellEffect(DruidSpells.OnCastCower);		//Rank 3
			#endregion
			#region Cure Poison	
			SpellTemplate.SpellEffects[	8946	]=	new SingleTargetSpellEffect(DruidSpells.OnCastCurePoison);		//
			#endregion
			#region Dash	
			SpellTemplate.SpellEffects[	9821	]=				//Rank 2	
			SpellTemplate.SpellEffects[	1850	]=	new OnSelfSpellEffect(DruidSpells.OnCastDash);		//Rank 1	
			#endregion
			#region Demoralizing Roar
			SpellTemplate.SpellEffects[	9490	]=				//Rank 3	
			SpellTemplate.SpellEffects[	9898	]=				//Rank 5	
				SpellTemplate.SpellEffects[	9747	]=				//Rank 4	
				SpellTemplate.SpellEffects[	1735	]=				//Rank 2	
				SpellTemplate.SpellEffects[	99	]=	new OnSelfSpellEffect(DruidSpells.OnCastDemoralizingRoar);		//Rank 1	
			#endregion
			#region Dire Bear Form
			SpellTemplate.SpellEffects[	9634	]=	new OnSelfSpellEffect(DruidSpells.OnCastDireBearForm);		//Shapeshift	
			#endregion
			#region Dire Bear Form (Passive)
			SpellTemplate.SpellEffects[	9635	]=	new OnSelfSpellEffect(DruidSpells.OnCastDireBearForm);		//Passive	
			#endregion
			#region Enrage	
			SpellTemplate.SpellEffects[	5229	]=	new OnSelfSpellEffect(DruidSpells.OnCastEnrage);		//	#endregion
			#endregion
			#region Entangling Roots
			SpellTemplate.SpellEffects[	9853	]=				//Rank 6	
			SpellTemplate.SpellEffects[	9852	]=				//Rank 5	
				SpellTemplate.SpellEffects[	5196	]=				//Rank 4	
				SpellTemplate.SpellEffects[	5195	]=				//Rank 3	
				SpellTemplate.SpellEffects[	1062	]=				//Rank 2	
				SpellTemplate.SpellEffects[	339	]=	new SingleTargetSpellEffect(DruidSpells.OnCastEntanglingRoots);		//Rank 1	
			#endregion
			#region Faerie Fire
			SpellTemplate.SpellEffects[	9907	]=				//Rank 4	
			SpellTemplate.SpellEffects[	9749	]=				//Rank 3	
				SpellTemplate.SpellEffects[	778	]=				//Rank 2	
				SpellTemplate.SpellEffects[	770	]=	new SingleTargetSpellEffect(DruidSpells.OnCastFaerieFire);		//Rank 1	
			#endregion
			#region Faerie Fire (Bear)	
			SpellTemplate.SpellEffects[	17389	]=				//Rank 4	
			SpellTemplate.SpellEffects[	17388	]=				//Rank 3	
				SpellTemplate.SpellEffects[	17387	]=				//Rank 2	
				SpellTemplate.SpellEffects[	16855	]=	new SingleTargetSpellEffect(DruidSpells.OnCastFaerieFire);		//Rank 1	
			#endregion
			#region Faerie Fire (Cat)
			SpellTemplate.SpellEffects[	17390	]=				//Rank 2	
			SpellTemplate.SpellEffects[	16857	]=				//Rank 1	
				SpellTemplate.SpellEffects[	17392	]=				//Rank 4	
				SpellTemplate.SpellEffects[	17391	]=	new SingleTargetSpellEffect(DruidSpells.OnCastFaerieFire);		//Rank 3	
			#endregion
			#region Feline Grace	
			SpellTemplate.SpellEffects[	20719	]=	new OnSelfSpellEffect(DruidSpells.OnCastFelineGrace);		//Passive
			#endregion
			#region Ferocious Bite
			SpellTemplate.SpellEffects[	22829	]=				//Rank 4	
			SpellTemplate.SpellEffects[	22828	]=				//Rank 3	
				SpellTemplate.SpellEffects[	22827	]=				//Rank 2	
				SpellTemplate.SpellEffects[	22568	]=	new SingleTargetSpellEffect(DruidSpells.OnCastFerociousBite);		//Rank 1	
			#endregion
			#region Frenzied Regeneration	
			SpellTemplate.SpellEffects[	22896	]=				//Rank 3	
			SpellTemplate.SpellEffects[	22895	]=				//Rank 2	
				SpellTemplate.SpellEffects[	22842	]=	new OnSelfSpellEffect(DruidSpells.OnCastFrenziedRegeneration);		//Rank 1	
			#endregion
			#region Gift of the Wild	
			SpellTemplate.SpellEffects[	21850	]=				//Rank 2	
			SpellTemplate.SpellEffects[	21849	]=	new SingleTargetSpellEffect(DruidSpells.OnCastGiftoftheWild);		//Rank 1	
			#endregion
			#region Growl
			SpellTemplate.SpellEffects[	6795	]=	new SingleTargetSpellEffect(DruidSpells.OnCastGrowl);		//
			#endregion
			#region Healing Touch
			SpellTemplate.SpellEffects[	9889	]=				//Rank 10	
			SpellTemplate.SpellEffects[	9888	]=				//Rank 9	
				SpellTemplate.SpellEffects[	9758	]=				//Rank 8	
				SpellTemplate.SpellEffects[	8903	]=				//Rank 7	
				SpellTemplate.SpellEffects[	6778	]=				//Rank 6	
				SpellTemplate.SpellEffects[	5189	]=				//Rank 5	
				SpellTemplate.SpellEffects[	5188	]=				//Rank 4	
				SpellTemplate.SpellEffects[	5187	]=				//Rank 3	
				SpellTemplate.SpellEffects[	5186	]=				//Rank 2	
				SpellTemplate.SpellEffects[	5185	]=	new SingleTargetSpellEffect(DruidSpells.OnCastHealingTouch);		//Rank 1	
			#endregion
			#region Hibernate	
			SpellTemplate.SpellEffects[	18658	]=				//Rank 3	
			SpellTemplate.SpellEffects[	18657	]=				//Rank 2	
				SpellTemplate.SpellEffects[	2637	]=	new SingleTargetSpellEffect(DruidSpells.OnCastHibernate);		//Rank 1
			#region Huricane
			#endregion
			SpellTemplate.SpellEffects[	16914	]=				//Rank 1	
				SpellTemplate.SpellEffects[	17402	]=				//Rank 3	
				SpellTemplate.SpellEffects[	17401	]=	new OnSelfSpellEffect(DruidSpells.OnCastHurricane);		//Rank 2	
			#endregion
			#region Mangle
			SpellTemplate.SpellEffects[	22570	]=	new SingleTargetSpellEffect(DruidSpells.OnCastMangle);		//Rank 1	
			#endregion
			#region Mark of the Wild	
			SpellTemplate.SpellEffects[	1126	]=				//Rank 1	
			SpellTemplate.SpellEffects[	6756	]=				//Rank 3	
				SpellTemplate.SpellEffects[	8907	]=				//Rank 5	
				SpellTemplate.SpellEffects[	9885	]=				//Rank 7	
				SpellTemplate.SpellEffects[	9884	]=				//Rank 6	
				SpellTemplate.SpellEffects[	5234	]=				//Rank 4	
				SpellTemplate.SpellEffects[	5232	]=	new SingleTargetSpellEffect(DruidSpells.OnCastMarkoftheWild);		//Rank 2	
			#endregion
			#region Maul
			SpellTemplate.SpellEffects[	9881	]=				//Rank 7	
			SpellTemplate.SpellEffects[	9880	]=				//Rank 6	
				SpellTemplate.SpellEffects[	8972	]=				//Rank 4	
				SpellTemplate.SpellEffects[	6809	]=				//Rank 3	
				SpellTemplate.SpellEffects[	6808	]=				//Rank 2	
				SpellTemplate.SpellEffects[	6807	]=				//Rank 1	
				SpellTemplate.SpellEffects[	9745	]=	new SingleTargetSpellEffect(DruidSpells.OnCastMaul);		//Rank 5	
			#endregion
			#region Moonfire
			SpellTemplate.SpellEffects[	9834	]=				//Rank 9	
			SpellTemplate.SpellEffects[	9833	]=				//Rank 8	
				SpellTemplate.SpellEffects[	8929	]=				//Rank 7	
				SpellTemplate.SpellEffects[	8928	]=				//Rank 6	
				SpellTemplate.SpellEffects[	8927	]=				//Rank 5	
				SpellTemplate.SpellEffects[	8926	]=				//Rank 4	
				SpellTemplate.SpellEffects[	8925	]=				//Rank 3	
				SpellTemplate.SpellEffects[	8924	]=				//Rank 2	
				SpellTemplate.SpellEffects[	8921	]=				//Rank 1	
				SpellTemplate.SpellEffects[	9835	]=	new SingleTargetSpellEffect(DruidSpells.OnCastMoonfire);		//Rank 10	
			#endregion
			#region Nature's Grasp	
			SpellTemplate.SpellEffects[	16810	]=				//Rank 2	
			SpellTemplate.SpellEffects[	16811	]=				//Rank 3	
				SpellTemplate.SpellEffects[	16813	]=				//Rank 5	
				SpellTemplate.SpellEffects[	16812	]=				//Rank 4	
				SpellTemplate.SpellEffects[	16689	]=	new OnSelfSpellEffect(DruidSpells.OnCastNaturesGrasp);		//Rank 1	
			#endregion
			#region Pounce
				SpellTemplate.SpellEffects[	9827	]=				//Rank 3	
				SpellTemplate.SpellEffects[	9823	]=				//Rank 2	
					SpellTemplate.SpellEffects[	9005	]=	new SingleTargetSpellEffect(DruidSpells.OnCastPounce);		//Rank 1	
			#endregion
			#region Pounce Bleed
			SpellTemplate.SpellEffects[	9826	]=				//Rank 3	
			SpellTemplate.SpellEffects[	9824	]=				//Rank 2	
				SpellTemplate.SpellEffects[	9007	]=	new SingleTargetSpellEffect(DruidSpells.OnCastPounceBleed);		//Rank 1	
			#endregion
			#region Prowl
			SpellTemplate.SpellEffects[	9913	]=				//Rank 3	
			SpellTemplate.SpellEffects[	6783	]=				//Rank 2	
				SpellTemplate.SpellEffects[	5215	]=	new OnSelfSpellEffect(DruidSpells.OnCastProwl);		//Rank 1	
			#endregion
			#region Rake
			SpellTemplate.SpellEffects[	9904	]=				//Rank 4	
			SpellTemplate.SpellEffects[	1824	]=				//Rank 3	
				SpellTemplate.SpellEffects[	1823	]=				//Rank 2	
				SpellTemplate.SpellEffects[	1822	]=	new SingleTargetSpellEffect(DruidSpells.OnCastRake);		//Rank 1	
			#endregion
			#region Ravage
			SpellTemplate.SpellEffects[	9866	]=				//Rank 3	
			SpellTemplate.SpellEffects[	9867	]=				//Rank 4	
				SpellTemplate.SpellEffects[	6787	]=				//Rank 2	
				SpellTemplate.SpellEffects[	6785	]=	new SingleTargetSpellEffect(DruidSpells.OnCastRavage);		//Rank 1
			#endregion
			#region Rebirth
			SpellTemplate.SpellEffects[	20748	]=				//Rank 5	
			SpellTemplate.SpellEffects[	20747	]=				//Rank 4	
				SpellTemplate.SpellEffects[	20742	]=				//Rank 3	
				SpellTemplate.SpellEffects[	20739	]=				//Rank 2	
				SpellTemplate.SpellEffects[	20484	]=	new SingleTargetSpellEffect(DruidSpells.OnCastRebirth);		//Rank 1	
			#endregion
			#region Regrowth
			SpellTemplate.SpellEffects[	8939	]=				//Rank 3	
			SpellTemplate.SpellEffects[	9858	]=				//Rank 9	
				SpellTemplate.SpellEffects[	9857	]=				//Rank 8	
				SpellTemplate.SpellEffects[	9856	]=				//Rank 7	
				SpellTemplate.SpellEffects[	9750	]=				//Rank 6	
				SpellTemplate.SpellEffects[	8941	]=				//Rank 5	
				SpellTemplate.SpellEffects[	8940	]=				//Rank 4	
				SpellTemplate.SpellEffects[	8938	]=				//Rank 2	
				SpellTemplate.SpellEffects[	8936	]=	new SingleTargetSpellEffect(DruidSpells.OnCastRegrowth);		//Rank 1	
			#endregion
			#region Rejuvenation
			SpellTemplate.SpellEffects[	9841	]=				//Rank 10	
			SpellTemplate.SpellEffects[	9840	]=				//Rank 9	
				SpellTemplate.SpellEffects[	9839	]=				//Rank 8	
				SpellTemplate.SpellEffects[	8910	]=				//Rank 7	
				SpellTemplate.SpellEffects[	3627	]=				//Rank 6	
				SpellTemplate.SpellEffects[	2091	]=				//Rank 5	
				SpellTemplate.SpellEffects[	2090	]=				//Rank 4	
				SpellTemplate.SpellEffects[	1430	]=				//Rank 3	
				SpellTemplate.SpellEffects[	1058	]=				//Rank 2	
				SpellTemplate.SpellEffects[	774	]=	new SingleTargetSpellEffect(DruidSpells.OnCastRejuvenation);		//Rank 1
			#endregion
			#region Remove Curse
			SpellTemplate.SpellEffects[	2782	]=	new SingleTargetSpellEffect(DruidSpells.OnCastRemoveCurse);		//
			#endregion
			#region Rip	
				SpellTemplate.SpellEffects[	9493	]=				//Rank 3	
				SpellTemplate.SpellEffects[	1079	]=				//Rank 1	
				SpellTemplate.SpellEffects[	9896	]=				//Rank 6	
				SpellTemplate.SpellEffects[	9894	]=				//Rank 5	
				SpellTemplate.SpellEffects[	9752	]=				//Rank 4	
				SpellTemplate.SpellEffects[	9492	]=	new SingleTargetSpellEffect(DruidSpells.OnCastRip);		//Rank 2	
			#endregion
			#region Shred
			SpellTemplate.SpellEffects[	8992	]=				//Rank 3	
			SpellTemplate.SpellEffects[	9829	]=				//Rank 4	
				SpellTemplate.SpellEffects[	9830	]=				//Rank 5	
				SpellTemplate.SpellEffects[	5221	]=				//Rank 1	
				SpellTemplate.SpellEffects[	6800	]=	new SingleTargetSpellEffect(DruidSpells.OnCastShred);		//Rank 2	
			#endregion
			#region Soothe Animal	
			SpellTemplate.SpellEffects[	9901	]=				//Rank 3	
			SpellTemplate.SpellEffects[	2908	]=				//Rank 1	
				SpellTemplate.SpellEffects[	8955	]=	new SingleTargetSpellEffect(DruidSpells.OnCastSootheAnimal);		//Rank 2
			#endregion
			#region Starfire
			SpellTemplate.SpellEffects[	9876	]=				//Rank 6	
			SpellTemplate.SpellEffects[	9875	]=				//Rank 5	
				SpellTemplate.SpellEffects[	8951	]=				//Rank 4	
				SpellTemplate.SpellEffects[	8950	]=				//Rank 3	
				SpellTemplate.SpellEffects[	8949	]=				//Rank 2	
				SpellTemplate.SpellEffects[	2912	]=	new SingleTargetSpellEffect(DruidSpells.OnCastStarfire);		//Rank 1	
			#endregion
			#region Swipe
			SpellTemplate.SpellEffects[	9908	]=				//Rank 5	
			SpellTemplate.SpellEffects[	769	]=				//Rank 3	
				SpellTemplate.SpellEffects[	9754	]=				//Rank 4	
				SpellTemplate.SpellEffects[	780	]=				//Rank 2	
				SpellTemplate.SpellEffects[	779	]=	new SingleTargetSpellEffect(DruidSpells.OnCastSwipe);		//Rank 1
			#endregion
			#region Teleport: Moonglade
			SpellTemplate.SpellEffects[	18960	]=	new OnSelfSpellEffect(DruidSpells.OnCastTeleportMoonglade);		//	
			#endregion
			#region Thorns
			SpellTemplate.SpellEffects[	1075	]=				//Rank 3	
			SpellTemplate.SpellEffects[	9756	]=				//Rank 5	
				SpellTemplate.SpellEffects[	467	]=				//Rank 1	
				SpellTemplate.SpellEffects[	9910	]=				//Rank 6	
				SpellTemplate.SpellEffects[	8914	]=				//Rank 4	
				SpellTemplate.SpellEffects[	782	]=	new SingleTargetSpellEffect(DruidSpells.OnCastThorns);		//Rank 2	
			#endregion
			#region Tiger's Fury
			SpellTemplate.SpellEffects[	9846	]=				//Rank 4	
			SpellTemplate.SpellEffects[	9845	]=				//Rank 3	
				SpellTemplate.SpellEffects[	5217	]=				//Rank 1	
				SpellTemplate.SpellEffects[	6793	]=	new OnSelfSpellEffect(DruidSpells.OnCastTigersFury);		//Rank 2
			#endregion
			#region Track Humanoids	
				SpellTemplate.SpellEffects[	5225	]=	new OnSelfSpellEffect(DruidSpells.OnCastTrackHumanoids);		//	
			#endregion
			#region Tranquility
			SpellTemplate.SpellEffects[	9863	]=				//Rank 4	
				SpellTemplate.SpellEffects[	9862	]=				//Rank 3	
					SpellTemplate.SpellEffects[	740	]=				//Rank 1	
					SpellTemplate.SpellEffects[	8918	]=	new OnSelfSpellEffect(DruidSpells.OnCastTranquility);		//Rank 2
			#endregion
			#region Travel Form
			SpellTemplate.SpellEffects[	783	]=	new OnSelfSpellEffect(DruidSpells.OnCastTravelForm);		//Shapeshift	
			#endregion
			#region Tree Form
			SpellTemplate.SpellEffects[	775	]=	new OnSelfSpellEffect(DruidSpells.OnCastTreeForm);		//Shapeshift	
			#endregion
			#region Tree Form (Passive)
			SpellTemplate.SpellEffects[	3122	]=	new OnSelfSpellEffect(DruidSpells.OnCastTreeForm);		//Passive
			#endregion
			#region Wrath
			SpellTemplate.SpellEffects[	5176	]=				//Rank 1	
			SpellTemplate.SpellEffects[	5177	]=				//Rank 2	
				SpellTemplate.SpellEffects[	8905	]=				//Rank 7	
				SpellTemplate.SpellEffects[	6780	]=				//Rank 6	
				SpellTemplate.SpellEffects[	5180	]=				//Rank 5	
				SpellTemplate.SpellEffects[	5178	]=				//Rank 3	
				SpellTemplate.SpellEffects[	9912	]=				//Rank 8	
				SpellTemplate.SpellEffects[	5179	]=	new SingleTargetSpellEffect(DruidSpells.OnCastWrath);		//Rank 4	
			#endregion

			#endregion

            #region Priest Spells -> all listed
			#region Abolish Disease
			SpellTemplate.SpellEffects[552] = new OnSelfSpellEffect(PriestSpells.OnCastAbolishDisease);
			#endregion
			#region CureDisease
			SpellTemplate.SpellEffects[528] = new SingleTargetSpellEffect(PriestSpells.OnCastCureDisease);
			#endregion
			#region Desperate Prayer
			SpellTemplate.SpellEffects[13908] = // 1
				SpellTemplate.SpellEffects[19236] = // 2
				SpellTemplate.SpellEffects[19238] = // 3
				SpellTemplate.SpellEffects[19240] = // 4
				SpellTemplate.SpellEffects[19241] = // 5
				SpellTemplate.SpellEffects[19242] = // 6
				SpellTemplate.SpellEffects[19243] = // 7
				new OnSelfSpellEffect(PriestSpells.OnCastDesperatePrayer);
			#endregion
			#region Devouring Plague
			SpellTemplate.SpellEffects[2944] = // 1
				SpellTemplate.SpellEffects[19276] = // 2
				SpellTemplate.SpellEffects[19277] = // 3
				SpellTemplate.SpellEffects[19278] = // 4
				SpellTemplate.SpellEffects[19279] = // 5
				SpellTemplate.SpellEffects[19280] = // 6
				new SingleTargetSpellEffect(PriestSpells.OnCastDevouringPlague);
			#endregion
			#region Dispel Magic
			SpellTemplate.SpellEffects[527] = // 1
				SpellTemplate.SpellEffects[988] = // 2
				new SingleTargetSpellEffect(PriestSpells.OnCastDispelMagic);
			#endregion
			#region Divine Spirit
			SpellTemplate.SpellEffects[14752] = // 1
				SpellTemplate.SpellEffects[14818] = // 2
				SpellTemplate.SpellEffects[14819] = // 3
				new SingleTargetSpellEffect(PriestSpells.OnCastDivineSpirit);
			#endregion
			#region Elune's Grace
			SpellTemplate.SpellEffects[2651] = // 1
				SpellTemplate.SpellEffects[19289] = // 2
				SpellTemplate.SpellEffects[19291] = // 3
				SpellTemplate.SpellEffects[19292] = // 4
				SpellTemplate.SpellEffects[19293] = // 5
				new OnSelfSpellEffect(PriestSpells.OnCastElunesGrace);
			#endregion
			#region Fade
			SpellTemplate.SpellEffects[586] = // 1
				SpellTemplate.SpellEffects[9578] = // 2
				SpellTemplate.SpellEffects[9579] = // 3
				SpellTemplate.SpellEffects[9592] = // 4
				SpellTemplate.SpellEffects[10941] = // 5
				SpellTemplate.SpellEffects[10942] = // 6
				new OnSelfSpellEffect(PriestSpells.OnCastFade);
			#endregion
			#region FearWard
			SpellTemplate.SpellEffects[6346] = new SingleTargetSpellEffect(PriestSpells.OnCastFearWard);
			#endregion
			#region Feedback
			SpellTemplate.SpellEffects[13896] = // 1
				SpellTemplate.SpellEffects[19271] = // 2
				SpellTemplate.SpellEffects[19273] = // 3
				SpellTemplate.SpellEffects[19274] = // 4
				SpellTemplate.SpellEffects[19275] = // 5
				new OnSelfSpellEffect(PriestSpells.OnCastFeedback);
			#endregion
			#region Flash Heal
			SpellTemplate.SpellEffects[2061] = // 1
				SpellTemplate.SpellEffects[9472] = // 2
				SpellTemplate.SpellEffects[9473] = // 3
				SpellTemplate.SpellEffects[9474] = // 4
				SpellTemplate.SpellEffects[10915] = // 5
				SpellTemplate.SpellEffects[10916] = // 6
				SpellTemplate.SpellEffects[10917] = // 7
				new SingleTargetSpellEffect(PriestSpells.OnCastFlashHeal);
			#endregion
			#region Greater Heal
			SpellTemplate.SpellEffects[2060] = // 1
				SpellTemplate.SpellEffects[10963] = // 2
				SpellTemplate.SpellEffects[10964] = // 3
				SpellTemplate.SpellEffects[10965] = // 4
				new SingleTargetSpellEffect(PriestSpells.OnCastGreaterHeal);
			#endregion
			#region Heal
			SpellTemplate.SpellEffects[2054] = // 1
				SpellTemplate.SpellEffects[2055] = // 2
				SpellTemplate.SpellEffects[6063] = // 3
				SpellTemplate.SpellEffects[6064] = // 4
				new SingleTargetSpellEffect(PriestSpells.OnCastHeal);
			#endregion
			#region Hex of Weakness
			SpellTemplate.SpellEffects[9035] = // 1
				SpellTemplate.SpellEffects[19281] = // 2
				SpellTemplate.SpellEffects[19282] = // 3
				SpellTemplate.SpellEffects[19283] = // 4
				SpellTemplate.SpellEffects[19284] = // 5
				SpellTemplate.SpellEffects[19285] = // 6
				new SingleTargetSpellEffect(PriestSpells.OnCastHexOfWeakness);
			#endregion
			#region Holy Fire
			SpellTemplate.SpellEffects[14914] = // 1
				SpellTemplate.SpellEffects[15262] = // 2
				SpellTemplate.SpellEffects[15263] = // 3
				SpellTemplate.SpellEffects[15264] = // 4
				SpellTemplate.SpellEffects[15265] = // 5
				SpellTemplate.SpellEffects[15266] = // 6
				SpellTemplate.SpellEffects[15267] = // 7
				SpellTemplate.SpellEffects[15261] = // 8
				new SingleTargetSpellEffect(PriestSpells.OnCastHolyFire);
			#endregion
			#region Holy Nova
			SpellTemplate.SpellEffects[15237] = // 1
				SpellTemplate.SpellEffects[15430] = // 2
				SpellTemplate.SpellEffects[15431] = // 3
				new OnSelfSpellEffect(PriestSpells.OnCastHolyNova);
			#endregion
			#region Inner Fire
			SpellTemplate.SpellEffects[588] = // 1
				SpellTemplate.SpellEffects[7128] = // 2
				SpellTemplate.SpellEffects[602] = // 3
				SpellTemplate.SpellEffects[1006] = // 4
				SpellTemplate.SpellEffects[10951] = // 5
				SpellTemplate.SpellEffects[10952] = // 6
				new OnSelfSpellEffect(PriestSpells.OnCastInnerFire);
			#endregion
			#region Lesser Heal
			SpellTemplate.SpellEffects[2050] = // 1
				SpellTemplate.SpellEffects[2052] = // 2
				SpellTemplate.SpellEffects[2053] = // 3
				new SingleTargetSpellEffect( PriestSpells.OnCastLesserHeal );
			#endregion
			#region Levitate
            SpellTemplate.SpellEffects[1706] = new OnSelfSpellEffect(PriestSpells.OnCastLevitate);
            #endregion
			#region Mana Burn
			SpellTemplate.SpellEffects[8129] = // 1
				SpellTemplate.SpellEffects[8131] = // 2
				SpellTemplate.SpellEffects[10874] = // 3
				SpellTemplate.SpellEffects[10875] = // 4
				SpellTemplate.SpellEffects[10876] = // 5
				new SingleTargetSpellEffect(PriestSpells.OnCastManaBurn);
			#endregion
			#region Mind Blast
			SpellTemplate.SpellEffects[8092] = // 1
				SpellTemplate.SpellEffects[8102] = // 2
				SpellTemplate.SpellEffects[8103] = // 3
				SpellTemplate.SpellEffects[8104] = // 4
				SpellTemplate.SpellEffects[8105] = // 5
				SpellTemplate.SpellEffects[8106] = // 6
				SpellTemplate.SpellEffects[10945] = // 7
				SpellTemplate.SpellEffects[10946] = // 8
				SpellTemplate.SpellEffects[10947] = // 9
				new SingleTargetSpellEffect(PriestSpells.OnCastMindBlast);
			#endregion
			#region Mind Control
			SpellTemplate.SpellEffects[605] = // 1
				SpellTemplate.SpellEffects[10911] = // 2
				SpellTemplate.SpellEffects[10912] = // 3
				new SingleTargetSpellEffect(PriestSpells.OnCastMindControl);
			#endregion
			#region Mind Flay
			SpellTemplate.SpellEffects[15407] = // 1
				SpellTemplate.SpellEffects[17311] = // 2
				SpellTemplate.SpellEffects[17312] = // 3
				SpellTemplate.SpellEffects[17313] = // 4
				SpellTemplate.SpellEffects[17314] = // 5
				SpellTemplate.SpellEffects[18807] = // 6
				new SingleTargetSpellEffect(PriestSpells.OnCastMindFlay);
			#endregion
			#region Mind Soothe
			SpellTemplate.SpellEffects[453] = // 1
				SpellTemplate.SpellEffects[8192] = // 2
				SpellTemplate.SpellEffects[10953] = // 3
				new SingleTargetSpellEffect(PriestSpells.OnCastMindSoothe);
			#endregion
          	#region Mind Vision
			SpellTemplate.SpellEffects[2096] = // 1
				SpellTemplate.SpellEffects[10909] = // 2
				new SingleTargetSpellEffect(PriestSpells.OnCastMindVision);
			#endregion
			#region Power Word: Fortitude
			SpellTemplate.SpellEffects[1243] = // 1
				SpellTemplate.SpellEffects[1245] = // 2
				SpellTemplate.SpellEffects[2791] = // 3
				SpellTemplate.SpellEffects[10937] = // 4
				SpellTemplate.SpellEffects[10938] = // 5
				new SingleTargetSpellEffect(PriestSpells.OnCastFortitude);
			#endregion
			#region Power Word: Shield
			SpellTemplate.SpellEffects[17] = // 1
				SpellTemplate.SpellEffects[592] = // 2
				SpellTemplate.SpellEffects[600] = // 3
				SpellTemplate.SpellEffects[3747] = // 4
				SpellTemplate.SpellEffects[6065] = // 5
				SpellTemplate.SpellEffects[6066] = // 6
				SpellTemplate.SpellEffects[10898] = // 7
				SpellTemplate.SpellEffects[10899] = // 8
				SpellTemplate.SpellEffects[10900] = // 9
				SpellTemplate.SpellEffects[10901] = // 10
				new SingleTargetSpellEffect(PriestSpells.OnCastShield);
			#endregion
			#region Prayer of Fortitude
			SpellTemplate.SpellEffects[21562] = // 1
				SpellTemplate.SpellEffects[21564] = // 2
				new OnSelfSpellEffect(PriestSpells.OnCastPrayerOfFortitude);
			#endregion
			#region Prayer of Healing
			SpellTemplate.SpellEffects[596] = // 1
				SpellTemplate.SpellEffects[996] = // 2
				SpellTemplate.SpellEffects[10960] = // 3
				SpellTemplate.SpellEffects[10961] = // 4
				new OnSelfSpellEffect(PriestSpells.OnCastPrayerOfHealing);
			#endregion
			#region Psychic Scream
			SpellTemplate.SpellEffects[8122] = // 1
				SpellTemplate.SpellEffects[8124] = // 2
				SpellTemplate.SpellEffects[10888] = // 3
				SpellTemplate.SpellEffects[10890] = // 4
				new OnSelfSpellEffect(PriestSpells.OnCastPsychicScream);
			#endregion
			#region Renew
			SpellTemplate.SpellEffects[139] = // 1
				SpellTemplate.SpellEffects[6074] = // 2
				SpellTemplate.SpellEffects[6075] = // 3
				SpellTemplate.SpellEffects[6076] = // 4
				SpellTemplate.SpellEffects[6077] = // 5
				SpellTemplate.SpellEffects[6078] = // 6
				SpellTemplate.SpellEffects[10972] = // 7
				SpellTemplate.SpellEffects[10928] = // 8
				SpellTemplate.SpellEffects[10929] = // 9
				new SingleTargetSpellEffect(PriestSpells.OnCastRenew);
			#endregion
			#region Resurrection
			SpellTemplate.SpellEffects[2006] = // 1
				SpellTemplate.SpellEffects[2010] = // 2
				SpellTemplate.SpellEffects[10880] = // 3
				SpellTemplate.SpellEffects[10881] = // 4
				SpellTemplate.SpellEffects[20770] = // 5
				new SingleTargetSpellEffect(PriestSpells.OnCastResurrection);
			#endregion
			#region Shackle Undead
			SpellTemplate.SpellEffects[9484] = // 1
				SpellTemplate.SpellEffects[9485] = // 2
				SpellTemplate.SpellEffects[10955] = // 3
				new SingleTargetSpellEffect(PriestSpells.OnCastShackleUndead);
			#endregion
			#region Shadow Protection
			SpellTemplate.SpellEffects[976] = // 1
				SpellTemplate.SpellEffects[10957] = // 2
				SpellTemplate.SpellEffects[10958] = // 3
				new SingleTargetSpellEffect(PriestSpells.OnCastShadowProtection);
			#endregion
			#region Shadow Word: Pain
			SpellTemplate.SpellEffects[589] = // 1
				SpellTemplate.SpellEffects[594] = // 2
				SpellTemplate.SpellEffects[970] = // 3
				SpellTemplate.SpellEffects[992] = // 4
				SpellTemplate.SpellEffects[2767] = // 5
				SpellTemplate.SpellEffects[10892] = // 6
				SpellTemplate.SpellEffects[10893] = // 7
				SpellTemplate.SpellEffects[10894] = // 8
				new SingleTargetSpellEffect(PriestSpells.OnCastPain);
			#endregion
			#region Shadowguard
			SpellTemplate.SpellEffects[18137] = // 1
				SpellTemplate.SpellEffects[19308] = // 2
				SpellTemplate.SpellEffects[19309] = // 3
				SpellTemplate.SpellEffects[19310] = // 4
				SpellTemplate.SpellEffects[19311] = // 5
				SpellTemplate.SpellEffects[19312] = // 6 
				new OnSelfSpellEffect(PriestSpells.OnCastShadowguard);
			#endregion
         	#region Smite
			SpellTemplate.SpellEffects[585] = // 1
				SpellTemplate.SpellEffects[591] = // 2
				SpellTemplate.SpellEffects[598] = // 3
				SpellTemplate.SpellEffects[984] = // 4
				SpellTemplate.SpellEffects[1004] = // 5
				SpellTemplate.SpellEffects[6060] = // 6
				SpellTemplate.SpellEffects[10933] = // 7
				SpellTemplate.SpellEffects[10934] = // 8
				new SingleTargetSpellEffect(PriestSpells.OnCastSmite);
			#endregion
			#region Starshards
			SpellTemplate.SpellEffects[10797] = // 1
				SpellTemplate.SpellEffects[19296] = // 2
				SpellTemplate.SpellEffects[19299] = // 3
				SpellTemplate.SpellEffects[19302] = // 4
				SpellTemplate.SpellEffects[19303] = // 5
				SpellTemplate.SpellEffects[19304] = // 6
				SpellTemplate.SpellEffects[19305] = // 7
				new SingleTargetSpellEffect(PriestSpells.OnCastStarshards);
			#endregion
			#region Touch of Weakness
			SpellTemplate.SpellEffects[2652] = // 1
				SpellTemplate.SpellEffects[19261] = // 2
				SpellTemplate.SpellEffects[19262] = // 3
				SpellTemplate.SpellEffects[19264] = // 4
				SpellTemplate.SpellEffects[19265] = // 5
				SpellTemplate.SpellEffects[19266] = // 6
				new SingleTargetSpellEffect(PriestSpells.OnCastTouchOfWeakness);
			#endregion
			#region Touch of Weakness Effect
			SpellTemplate.SpellEffects[19254] = // 1
				SpellTemplate.SpellEffects[19253] = // 2
				SpellTemplate.SpellEffects[19251] = // 3
				SpellTemplate.SpellEffects[19249] = // 4
				SpellTemplate.SpellEffects[19252] = // 5
				SpellTemplate.SpellEffects[2943] = // 6
				new SingleTargetSpellEffect(PriestSpells.OnCastTouchOfWeaknessEffect);
			#endregion
			#region VampiricEmbarce
            SpellTemplate.SpellEffects[15286] = new SingleTargetSpellEffect(PriestSpells.OnCastVampiricEmbrace);
            #endregion
            #endregion

            #region Warlock Spells -> all listed

			#region Stones 
			#region HealthStones 
			SpellTemplate.SpellEffects[5720]= 
				SpellTemplate.SpellEffects[5723]= 
				SpellTemplate.SpellEffects[6262]= 
				SpellTemplate.SpellEffects[6263]= 
				SpellTemplate.SpellEffects[11732]= 
				new OnSelfSpellEffect( ItemsSpells.OnHealthStones ); 
			#endregion 
			#region SpellStones 
			SpellTemplate.SpellEffects[128]= 				
				SpellTemplate.SpellEffects[17729]= 
				SpellTemplate.SpellEffects[17730]= 
				new OnSelfSpellEffect( ItemsSpells.OnSpellStones );
			#endregion 
			#endregion 
			#region Banish
			SpellTemplate.SpellEffects[710] = // 1
				SpellTemplate.SpellEffects[18647] = // 2
				new SingleTargetSpellEffect(WarlockSpells.OnCastBanish);
			#endregion
			#region Conflagrate
			SpellTemplate.SpellEffects[17962] = // 1
				SpellTemplate.SpellEffects[18930] = // 2
				SpellTemplate.SpellEffects[18931] = // 3
				SpellTemplate.SpellEffects[18932] = // 4
				new SingleTargetSpellEffect(WarlockSpells.OnCastConflagrate);
			#endregion
			#region Corruption
			SpellTemplate.SpellEffects[172] = // 1
				SpellTemplate.SpellEffects[6222] = // 2
				SpellTemplate.SpellEffects[6223] = // 3
				SpellTemplate.SpellEffects[7648] = // 4
				SpellTemplate.SpellEffects[11671] = // 5
				SpellTemplate.SpellEffects[11672] = // 6
				new SingleTargetSpellEffect(WarlockSpells.OnCastCorruption);
			#endregion
			#region Create Spells
			SpellTemplate.SpellEffects[6201] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateHealthstoneMinor);
			SpellTemplate.SpellEffects[693] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateSoulstoneMinor);
			SpellTemplate.SpellEffects[6202] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateHealthstoneLesser);
			SpellTemplate.SpellEffects[6366] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateFirestoneLesser);
			SpellTemplate.SpellEffects[20752] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateSoulstoneLesser);
			SpellTemplate.SpellEffects[5699] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateHealthstone);
			SpellTemplate.SpellEffects[2362] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateSpellstone);
			SpellTemplate.SpellEffects[20755] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateSoulstone);
			SpellTemplate.SpellEffects[17952] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateFirestoneGreater);
			SpellTemplate.SpellEffects[11729] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateHealthstoneGreater);
			SpellTemplate.SpellEffects[17727] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateSpellstoneGreater);
			SpellTemplate.SpellEffects[20756] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateSoulstoneGreater);
			SpellTemplate.SpellEffects[17953] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateFirestoneMajor);
			SpellTemplate.SpellEffects[17728] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateSpellstoneMajor);
			SpellTemplate.SpellEffects[20757] = new OnSelfSpellEffect(WarlockSpells.OnCastCreateSoulstoneMajor);
			#endregion
			#region Curse of Agony
			SpellTemplate.SpellEffects[980] = // 1 
				SpellTemplate.SpellEffects[1014] = // 2 
				SpellTemplate.SpellEffects[6217] = // 3 
				SpellTemplate.SpellEffects[11711] = // 4 
				SpellTemplate.SpellEffects[11712] = // 5 
				SpellTemplate.SpellEffects[11713] = // 6 
				new SingleTargetSpellEffect(WarlockSpells.OnCastCurseOfAgony); 
			#endregion
			#region CurseOfDoom
			SpellTemplate.SpellEffects[603] = new SingleTargetSpellEffect(WarlockSpells.OnCastCurseOfDoom);
			#endregion
			#region CurseOfIdioci
			SpellTemplate.SpellEffects[1010] = new SingleTargetSpellEffect(WarlockSpells.OnCastCurseOfIdiocy);
			#endregion
			#region Curse of Recklessness
			SpellTemplate.SpellEffects[704] = // 1
				SpellTemplate.SpellEffects[7658] = // 2
				SpellTemplate.SpellEffects[7659] = // 3
				SpellTemplate.SpellEffects[11717] = // 4
				new SingleTargetSpellEffect(WarlockSpells.OnCastCurseOfRecklessness);
			#endregion
			#region Curse of Shadow
			SpellTemplate.SpellEffects[17862] = // 1
				SpellTemplate.SpellEffects[17937] = // 2
				new SingleTargetSpellEffect(WarlockSpells.OnCastCurseOfShadow);
			#endregion
			#region Curse of Tongues
			SpellTemplate.SpellEffects[1714] = // 1
				SpellTemplate.SpellEffects[11719] = // 2
				new SingleTargetSpellEffect(WarlockSpells.OnCastCurseOfTongues);
			#endregion
			#region Curse of Weakness
			SpellTemplate.SpellEffects[702] = // 1
				SpellTemplate.SpellEffects[1108] = // 2
				SpellTemplate.SpellEffects[6205] = // 3
				SpellTemplate.SpellEffects[7646] = // 4
				SpellTemplate.SpellEffects[11707] = // 5
				SpellTemplate.SpellEffects[11708] = // 6
				new SingleTargetSpellEffect(WarlockSpells.OnCastCurseOfWeakness);
			#endregion
			#region Curse of the Elements
			SpellTemplate.SpellEffects[1490] = // 1
				SpellTemplate.SpellEffects[11721] = // 2
				SpellTemplate.SpellEffects[11722] = // 3
				new SingleTargetSpellEffect(WarlockSpells.OnCastCurseOfTheElements);
			#endregion
			#region Curse of exhaustion
			SpellTemplate.SpellEffects[18223] = 
				new SingleTargetSpellEffect(WarlockSpells.OnCastCurseOfExhaustion );
			#endregion
			#region Dark Pact
			SpellTemplate.SpellEffects[18220] = // 1
				SpellTemplate.SpellEffects[18937] = // 2
				SpellTemplate.SpellEffects[18938] = // 3
				new OnSelfSpellEffect(WarlockSpells.OnCastDarkPact);
			#endregion
			#region Death Coil
			SpellTemplate.SpellEffects[6789] = // 1
				SpellTemplate.SpellEffects[17925] = // 2
				SpellTemplate.SpellEffects[17926] = // 3
				new SingleTargetSpellEffect(WarlockSpells.OnCastDeathCoil);
			#endregion
			#region Demon Armor
			SpellTemplate.SpellEffects[706] = // 1
				SpellTemplate.SpellEffects[1086] = // 2
				SpellTemplate.SpellEffects[11733] = // 3
				SpellTemplate.SpellEffects[11734] = // 4
				SpellTemplate.SpellEffects[11735] = // 5
				new OnSelfSpellEffect(WarlockSpells.OnCastDemonArmor);
			#endregion
			#region Demon Skin
			SpellTemplate.SpellEffects[687] = // 1
				SpellTemplate.SpellEffects[696] = // 2
				new OnSelfSpellEffect(WarlockSpells.OnCastDemonSkin);
			#endregion
			#region DetectLesserInvisibility
			SpellTemplate.SpellEffects[132] = new SingleTargetSpellEffect(WarlockSpells.OnCastDetectLesserInvisibility);
			#endregion
			#region DetectInvisibility
			SpellTemplate.SpellEffects[2970] = new SingleTargetSpellEffect( WarlockSpells.OnCastDetectInvisibility );
			#endregion
			#region DetectGreaterInvisibility
			SpellTemplate.SpellEffects[11743] = new SingleTargetSpellEffect(WarlockSpells.OnCastDetectGreaterInvisibility);
			#endregion
			#region Drain Life
			SpellTemplate.SpellEffects[689] = // 1
				SpellTemplate.SpellEffects[699] = // 2
				SpellTemplate.SpellEffects[709] = // 3
				SpellTemplate.SpellEffects[7651] = // 4
				SpellTemplate.SpellEffects[11699] = // 5
				SpellTemplate.SpellEffects[11700] = // 6
				new SingleTargetSpellEffect(WarlockSpells.OnCastDrainLife);
			#endregion
			#region Drain Mana
			SpellTemplate.SpellEffects[5138] = // 1
				SpellTemplate.SpellEffects[6226] = // 2
				SpellTemplate.SpellEffects[11703] = // 3
				SpellTemplate.SpellEffects[117074] = // 4
				new SingleTargetSpellEffect(WarlockSpells.OnCastDrainMana);
			#endregion
			#region Drain Soul
			SpellTemplate.SpellEffects[1120] = // 1
				SpellTemplate.SpellEffects[8288] = // 2
				SpellTemplate.SpellEffects[8289] = // 3
				SpellTemplate.SpellEffects[11675] = // 4
				new SingleTargetSpellEffect(WarlockSpells.OnCastDrainSoul);
			#endregion
			#region Enslave Demon
			SpellTemplate.SpellEffects[1098] = // 1
				SpellTemplate.SpellEffects[11725] = // 2
				SpellTemplate.SpellEffects[11726] = // 3
				new SingleTargetSpellEffect(WarlockSpells.OnCastEnslaveDemon);
			#endregion
			#region Fear
			SpellTemplate.SpellEffects[5782] = // 1
				SpellTemplate.SpellEffects[6213] = // 2
				SpellTemplate.SpellEffects[6215] = // 3
				SpellTemplate.SpellEffects[7648] = // 4
				SpellTemplate.SpellEffects[11671] = // 5
				SpellTemplate.SpellEffects[11672] = // 6
				new SingleTargetSpellEffect(WarlockSpells.OnCastFear);
			#endregion
			#region FelDomination
			SpellTemplate.SpellEffects[ 18708 ] = 
				new OnSelfSpellEffect( WarlockSpells.OnCastFelDomination );
			#endregion
			#region Health Funnel
			SpellTemplate.SpellEffects[755] = // 1
				SpellTemplate.SpellEffects[3698] = // 2
				SpellTemplate.SpellEffects[3699] = // 3
				SpellTemplate.SpellEffects[3700] = // 4
				SpellTemplate.SpellEffects[11693] = // 5
				SpellTemplate.SpellEffects[11694] = // 6
				SpellTemplate.SpellEffects[11695] = // 7
				new OnSelfSpellEffect(WarlockSpells.OnCastHealthFunnel);
			#endregion
			#region Hellfire
			SpellTemplate.SpellEffects[1949] = // 1
				SpellTemplate.SpellEffects[11683] = // 2
				SpellTemplate.SpellEffects[11684] = // 3
				new OnSelfSpellEffect(WarlockSpells.OnCastHellfire);
			#endregion
			#region Howl of Terror
			SpellTemplate.SpellEffects[5484] = // 1
				SpellTemplate.SpellEffects[17928] = // 2
				new OnSelfSpellEffect(WarlockSpells.OnCastHowlOfTerror);
			#endregion
			#region Immolate
			SpellTemplate.SpellEffects[348] = // 1
				SpellTemplate.SpellEffects[707] = // 2
				SpellTemplate.SpellEffects[1094] = // 3
				SpellTemplate.SpellEffects[2941] = // 4
				SpellTemplate.SpellEffects[11665] = // 5
				SpellTemplate.SpellEffects[11667] = // 6
				SpellTemplate.SpellEffects[11668] = // 7
				new SingleTargetSpellEffect(WarlockSpells.OnCastImmolate);
			#endregion
			#region Life Tap
			SpellTemplate.SpellEffects[1454] = // 1
				SpellTemplate.SpellEffects[1455] = // 2
				SpellTemplate.SpellEffects[1456] = // 3
				SpellTemplate.SpellEffects[11687] = // 4
				SpellTemplate.SpellEffects[11688] = // 5
				SpellTemplate.SpellEffects[11689] = // 6
				new OnSelfSpellEffect(WarlockSpells.OnCastLifeTap);
			#endregion
			#region Rain of Fire
			SpellTemplate.SpellEffects[5740] = // 1
				SpellTemplate.SpellEffects[6219] = // 2
				SpellTemplate.SpellEffects[11677] = // 3
				SpellTemplate.SpellEffects[11678] = // 4
				new TargetXYZSpellEffect(WarlockSpells.OnCastRainOfFire);
			#endregion
			#region RitualOfDoom
			SpellTemplate.SpellEffects[18540] = new SingleTargetSpellEffect(WarlockSpells.OnCastRitualOfDoom);
			#endregion
			#region Searing Pain
			SpellTemplate.SpellEffects[5676] = // 1
				SpellTemplate.SpellEffects[17919] = // 2
				SpellTemplate.SpellEffects[17920] = // 3
				SpellTemplate.SpellEffects[17921] = // 4
				SpellTemplate.SpellEffects[17922] = // 5
				SpellTemplate.SpellEffects[17923] = // 6
				new SingleTargetSpellEffect(WarlockSpells.OnCastSearingPain);
			#endregion
			#region Sense Demons
            SpellTemplate.SpellEffects[5500] = new OnSelfSpellEffect(WarlockSpells.OnCastSenseDemons);
			#endregion
			#region Shadow Bolt
			SpellTemplate.SpellEffects[686] = // 1
				SpellTemplate.SpellEffects[695] = // 2
				SpellTemplate.SpellEffects[705] = // 3
				SpellTemplate.SpellEffects[1088] = // 4
				SpellTemplate.SpellEffects[1106] = // 5
				SpellTemplate.SpellEffects[7641] = // 6
				SpellTemplate.SpellEffects[11659] = // 7
				SpellTemplate.SpellEffects[11660] = // 8
				SpellTemplate.SpellEffects[11661] = // 9
				new SingleTargetSpellEffect(WarlockSpells.OnCastShadowBolt);
			#endregion
			#region Shadow Ward
			SpellTemplate.SpellEffects[6229] = // 1
				SpellTemplate.SpellEffects[11739] = // 2
				SpellTemplate.SpellEffects[11740] = // 3
				new OnSelfSpellEffect(WarlockSpells.OnCastShadowWard);
			#endregion
			#region Shadowburn
			SpellTemplate.SpellEffects[17877] = // 1
				SpellTemplate.SpellEffects[18867] = // 2
				SpellTemplate.SpellEffects[18868] = // 3
				SpellTemplate.SpellEffects[18869] = // 4
				SpellTemplate.SpellEffects[18870] = // 5
				SpellTemplate.SpellEffects[18871] = // 6
				new SingleTargetSpellEffect(WarlockSpells.OnCastShadowburn);
			#endregion
			#region SiphonLife
			SpellTemplate.SpellEffects[18881] = // 1
				SpellTemplate.SpellEffects[18880] = // 2
				SpellTemplate.SpellEffects[18879] = // 3
				SpellTemplate.SpellEffects[18265] = // 4
				new SingleTargetSpellEffect(WarlockSpells.OnCastSiphonLife);
			#endregion
			#region Soul Fire
			SpellTemplate.SpellEffects[6353] = // 1
				SpellTemplate.SpellEffects[17924] = // 2
				new SingleTargetSpellEffect(WarlockSpells.OnCastSoulFire);
			#endregion
			#region Summon Spells
			SpellTemplate.SpellEffects[688] = new OnSelfSpellEffect(WarlockSpells.OnCastSummonImp);
			SpellTemplate.SpellEffects[697] = new OnSelfSpellEffect(WarlockSpells.OnCastSummonVoidwalker);
			SpellTemplate.SpellEffects[712] = new OnSelfSpellEffect(WarlockSpells.OnCastSummonSuccubus);
			SpellTemplate.SpellEffects[691] = new OnSelfSpellEffect(WarlockSpells.OnCastSummonFelhunter);
			SpellTemplate.SpellEffects[126] = new OnSelfSpellEffect(WarlockSpells.OnCastSummonEyeOfKilrogg);
			SpellTemplate.SpellEffects[5784] = new OnSelfSpellEffect(WarlockSpells.OnCastSummonFelsteed);
			SpellTemplate.SpellEffects[1122] = new SingleTargetSpellEffect(WarlockSpells.OnCastInferno);
			SpellTemplate.SpellEffects[698] = new SingleTargetSpellEffect(WarlockSpells.OnCastRitualOfSummoning);
			#endregion
  			#region UnendingBreath
            SpellTemplate.SpellEffects[5697] = new SingleTargetSpellEffect(WarlockSpells.OnCastUnendingBreath);
			#endregion
			
			
			
           
            
            
            
         
            
            #endregion

            #region Warrior Spells -> all listed
			#region Battle Shout
			SpellTemplate.SpellEffects[6673] = // 1
				SpellTemplate.SpellEffects[5242] = // 2
				SpellTemplate.SpellEffects[6192] = // 3
				SpellTemplate.SpellEffects[11549] = // 4
				SpellTemplate.SpellEffects[11550] = // 5
				SpellTemplate.SpellEffects[11551] = // 6
				new OnSelfSpellEffect(WarriorSpells.OnCastBattleShout);
			#endregion
			#region Battle stance
				SpellTemplate.SpellEffects[2457] = // 1
				new OnSelfSpellEffect(WarriorSpells.OnCastBattleStance);
			#endregion
			#region BarsekersRage
				SpellTemplate.SpellEffects[18499] = 
				new OnSelfSpellEffect(WarriorSpells.OnCastBerserkersRage);
			#endregion
			#region Barseker stance
				SpellTemplate.SpellEffects[2458] = // 1
				new OnSelfSpellEffect(WarriorSpells.OnCastBarsekerStance);
			#endregion
           	#region Bloodrage
            SpellTemplate.SpellEffects[2687] = new OnSelfSpellEffect(WarriorSpells.OnCastBloodrage);
			#endregion
			#region ChalengingShout
            SpellTemplate.SpellEffects[1161] = new OnSelfSpellEffect(WarriorSpells.OnCastChallengingShout);
			#endregion
			#region Charge
			SpellTemplate.SpellEffects[100] = // 1
				SpellTemplate.SpellEffects[6178] = // 2
				SpellTemplate.SpellEffects[11578] = // 3
				new SingleTargetSpellEffect(WarriorSpells.OnCastCharge);
			#endregion
			#region Cleave
			SpellTemplate.SpellEffects[845] = // 1
				SpellTemplate.SpellEffects[7369] = // 2
				SpellTemplate.SpellEffects[11608] = // 3
				SpellTemplate.SpellEffects[11609] = // 4
				SpellTemplate.SpellEffects[20569] = // 5
				new SingleTargetSpellEffect(WarriorSpells.OnCastCleave);
			#endregion
			
			#region Defending stance
			SpellTemplate.SpellEffects[71] = // 1
				new OnSelfSpellEffect(WarriorSpells.OnCastDefendingStance);
			#endregion
			#region Demoralizing Shout
			SpellTemplate.SpellEffects[1160] = // 1
				SpellTemplate.SpellEffects[6190] = // 2
				SpellTemplate.SpellEffects[11554] = // 3
				SpellTemplate.SpellEffects[11555] = // 4
				SpellTemplate.SpellEffects[11556] = // 5
				new OnSelfSpellEffect(WarriorSpells.OnCastDemoralizingShout);
			#endregion
			#region Disarm
			SpellTemplate.SpellEffects[676] = new SingleTargetSpellEffect(WarriorSpells.OnCastDisarm);
			#endregion
			#region Execute
			SpellTemplate.SpellEffects[5308] = // 1
				SpellTemplate.SpellEffects[20658] = // 2
				SpellTemplate.SpellEffects[20660] = // 3
				SpellTemplate.SpellEffects[20661] = // 4
				SpellTemplate.SpellEffects[20662] = // 5
				new SingleTargetSpellEffect(WarriorSpells.OnCastExecute);
			#endregion
			#region Hamstring
			SpellTemplate.SpellEffects[1715] = // 1
				SpellTemplate.SpellEffects[7372] = // 2
				SpellTemplate.SpellEffects[7373] = // 3
				new SingleTargetSpellEffect(WarriorSpells.OnCastHamstring);
			#endregion
			#region Heroic Strike
			SpellTemplate.SpellEffects[78] = // 1
				SpellTemplate.SpellEffects[284] = // 2
				SpellTemplate.SpellEffects[285] = // 3
				SpellTemplate.SpellEffects[1608] = // 4
				SpellTemplate.SpellEffects[11564] = // 5
				SpellTemplate.SpellEffects[11565] = // 6
				SpellTemplate.SpellEffects[11566] = // 7
				SpellTemplate.SpellEffects[11567] = // 8
				new SingleTargetSpellEffect(WarriorSpells.OnCastHeroicStrike);
			#endregion
			#region Intercept
			SpellTemplate.SpellEffects[20252] = // 1
				SpellTemplate.SpellEffects[20616] = // 2
				SpellTemplate.SpellEffects[20617] = // 3
				new SingleTargetSpellEffect(WarriorSpells.OnCastIntercept);
			#endregion
			#region IntimidatingShout
				SpellTemplate.SpellEffects[5246] =
				new SingleTargetSpellEffect(WarriorSpells.OnCastIntimidatingShout);
			#endregion
			#region MockingBlow
				SpellTemplate.SpellEffects[20560] =
				SpellTemplate.SpellEffects[20559] =
				SpellTemplate.SpellEffects[7402] =
				SpellTemplate.SpellEffects[7400] =
				SpellTemplate.SpellEffects[694] =
				new SingleTargetSpellEffect(WarriorSpells.OnCastMockingBlow);
			#endregion
			#region Mortal Strike
			SpellTemplate.SpellEffects[12294] = // 1
				SpellTemplate.SpellEffects[21551] = // 2
				SpellTemplate.SpellEffects[21552] = // 3
				SpellTemplate.SpellEffects[21553] = // 4
				new SingleTargetSpellEffect(WarriorSpells.OnCastMortalStrike);
			#endregion
			#region Overpower
			SpellTemplate.SpellEffects[7384] = // 1
				SpellTemplate.SpellEffects[7887] = // 2
				SpellTemplate.SpellEffects[11584] = // 3
				SpellTemplate.SpellEffects[11585] = // 4
				new SingleTargetSpellEffect(WarriorSpells.OnCastOverpower);
			#endregion
			#region Pummel
			SpellTemplate.SpellEffects[6552] = // 1
				SpellTemplate.SpellEffects[6554] = // 2
				new SingleTargetSpellEffect(WarriorSpells.OnCastPummel);
			#endregion
			#region Recklessness
			SpellTemplate.SpellEffects[1719] = new OnSelfSpellEffect(WarriorSpells.OnCastRecklessness);
			#endregion
			#region Rend
			SpellTemplate.SpellEffects[772] = // 1
				SpellTemplate.SpellEffects[6546] = // 2
				SpellTemplate.SpellEffects[6547] = // 3
				SpellTemplate.SpellEffects[6548] = // 4
				SpellTemplate.SpellEffects[11572] = // 5
				SpellTemplate.SpellEffects[11573] = // 6
				SpellTemplate.SpellEffects[11574] = // 7
				new SingleTargetSpellEffect(WarriorSpells.OnCastRend);
			#endregion
			#region Retaliation
			//SpellTemplate.SpellEffects[20230] = new SingleTargetSpellEffect(WarriorSpells.OnCastRetaliation);
			#endregion
			#region Revenge
			SpellTemplate.SpellEffects[6572] = // 1
				SpellTemplate.SpellEffects[6574] = // 2
				SpellTemplate.SpellEffects[7379] = // 3
				SpellTemplate.SpellEffects[11600] = // 4
				SpellTemplate.SpellEffects[11601] = // 5
				new SingleTargetSpellEffect(WarriorSpells.OnCastRevenge);
			#endregion
			#region Shield Bash
			SpellTemplate.SpellEffects[72] = // 1
				SpellTemplate.SpellEffects[1671] = // 2
				SpellTemplate.SpellEffects[1672] = // 3
				new SingleTargetSpellEffect(WarriorSpells.OnCastShieldBash);
			#endregion
			#region ShieldBlock
			SpellTemplate.SpellEffects[2565] = new OnSelfSpellEffect(WarriorSpells.OnCastShieldBlock);
			#endregion
			#region ShieldWall
			SpellTemplate.SpellEffects[871] = new OnSelfSpellEffect(WarriorSpells.OnCastShieldWall);
			#endregion
			#region Slam
			SpellTemplate.SpellEffects[1464] = // 1
				SpellTemplate.SpellEffects[8820] = // 2
				SpellTemplate.SpellEffects[11604] = // 3
				SpellTemplate.SpellEffects[11605] = // 4
				new SingleTargetSpellEffect(WarriorSpells.OnCastSlam);
			#endregion
			#region Sunder Armor
			SpellTemplate.SpellEffects[7386] = // 1
				SpellTemplate.SpellEffects[7405] = // 2
				SpellTemplate.SpellEffects[8380] = // 3
				SpellTemplate.SpellEffects[11596] = // 4
				SpellTemplate.SpellEffects[11597] = // 5
				new SingleTargetSpellEffect(WarriorSpells.OnCastSunderArmor);
			#endregion
			#region Taunt
			SpellTemplate.SpellEffects[355] = new SingleTargetSpellEffect(WarriorSpells.OnCastTaunt);
			#endregion
			#region Thunder Clap
			SpellTemplate.SpellEffects[6343] = // 1
				SpellTemplate.SpellEffects[8198] = // 2
				SpellTemplate.SpellEffects[8204] = // 3
				SpellTemplate.SpellEffects[8205] = // 4
				SpellTemplate.SpellEffects[11580] = // 5
				SpellTemplate.SpellEffects[11581] = // 6
				new OnSelfSpellEffect(WarriorSpells.OnCastThunderClap);
			#endregion			
			#region Whirlwind
            SpellTemplate.SpellEffects[1680] = new OnSelfSpellEffect(WarriorSpells.OnCastWhirlwind);
			#endregion
			#endregion

			#region Hunter spells -> all listed 
			#region Auto Shoot
		//	SpellTemplate.SpellEffects[75] =
		//		new SingleTargetSpellEffect( HunterSpells.OnCastAutoShoot );
			#endregion
			#region Arcane Shot	
				SpellTemplate.SpellEffects[	14287	]=				//Rank 8
				SpellTemplate.SpellEffects[	14286	]=				//Rank 7
				SpellTemplate.SpellEffects[	14285	]=				//Rank 6
				SpellTemplate.SpellEffects[	14284	]=				//Rank 5
				SpellTemplate.SpellEffects[	14283	]=				//Rank 4
				SpellTemplate.SpellEffects[	14282	]=				//Rank 3
				SpellTemplate.SpellEffects[	14281	]=				//Rank 2
				SpellTemplate.SpellEffects[	3044	]=	
					new SingleTargetSpellEffect(HunterSpells.OnCastArcaneShot	);		//Rank 1
			#endregion
			#region Aspect of the Beast
			SpellTemplate.SpellEffects[	13161	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastAspectoftheBeast	);		//
			#endregion
			#region Aspect of the Cheetah	
			SpellTemplate.SpellEffects[	5118	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastAspectoftheCheetah	);		//
			#endregion
			#region Aspect of the Hawk	
			SpellTemplate.SpellEffects[	14322	]=				//Rank 6
			SpellTemplate.SpellEffects[	14321	]=				//Rank 5
				SpellTemplate.SpellEffects[	14320	]=				//Rank 4
				SpellTemplate.SpellEffects[	14319	]=				//Rank 3
				SpellTemplate.SpellEffects[	14318	]=				//Rank 2
				SpellTemplate.SpellEffects[	13165	]=
				new OnSelfSpellEffect(HunterSpells.OnCastAspectoftheHawk	);		//Rank 1
			#endregion
			#region Aspect of the Monkey	
			SpellTemplate.SpellEffects[	13163	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastAspectoftheMonkey	);		//
			#endregion
			#region Aspect of the Pack	
			SpellTemplate.SpellEffects[	13159	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastAspectofthePack	);		//
			#endregion
			#region Aspect of the Wild	
			SpellTemplate.SpellEffects[	20190	]=				//Rank 2
			SpellTemplate.SpellEffects[	20043	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastAspectoftheWild	);		//Rank 1
			#endregion
			#region Beast Lore	
			SpellTemplate.SpellEffects[	1462	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastBeastLore	);		//
			#endregion
			#region Beast Training	
			SpellTemplate.SpellEffects[	5149	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastBeastTraining	);		//
			#endregion
			#region Bite	
			SpellTemplate.SpellEffects[	17265	]=				//Rank 5
			SpellTemplate.SpellEffects[	17264	]=				//Rank 4
				SpellTemplate.SpellEffects[	17263	]=				//Rank 3
				SpellTemplate.SpellEffects[	17262	]=				//Rank 2
				SpellTemplate.SpellEffects[	17254	]=				//Rank 1
				SpellTemplate.SpellEffects[	17268	]=				//Rank 8
				SpellTemplate.SpellEffects[	17267	]=				//Rank 7
				SpellTemplate.SpellEffects[	17266	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastBite	);		//Rank 6
			#endregion
			#region Call Pet	
			SpellTemplate.SpellEffects[	883	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastCallPet	);		//
			#endregion
			#region Claw	
			SpellTemplate.SpellEffects[	3666	]=				//Rank 8
			SpellTemplate.SpellEffects[	2977	]=				//Rank 7
				SpellTemplate.SpellEffects[	2976	]=				//Rank 6
				SpellTemplate.SpellEffects[	2975	]=				//Rank 5
				SpellTemplate.SpellEffects[	2982	]=				//Rank 3
				SpellTemplate.SpellEffects[	2981	]=				//Rank 2
				SpellTemplate.SpellEffects[	2980	]=				//Rank 1
				SpellTemplate.SpellEffects[	3667	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastClaw	);		//Rank 4
			
			#endregion
			#region Concussive Shot	
			SpellTemplate.SpellEffects[	5116	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastConcussiveShot	);		//
			#endregion
			#region Cower	
			SpellTemplate.SpellEffects[	1747	]=				//Rank 1
			SpellTemplate.SpellEffects[	16698	]=				//Rank 6
				SpellTemplate.SpellEffects[	1751	]=				//Rank 5
				SpellTemplate.SpellEffects[	1750	]=				//Rank 4
				SpellTemplate.SpellEffects[	1749	]=				//Rank 3
				SpellTemplate.SpellEffects[	1748	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastCower	);		//Rank 2
			#endregion
			#region Disengage	
			SpellTemplate.SpellEffects[	14273	]=				//Rank 3
			SpellTemplate.SpellEffects[	14272	]=				//Rank 2
				SpellTemplate.SpellEffects[	781	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastDisengage	);		//Rank 1
			#endregion
			#region Dismiss Pet	
			SpellTemplate.SpellEffects[	2641	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastDismissPet	);		//
			#endregion
			#region Distracting Shot	
			SpellTemplate.SpellEffects[	14274	]=				//Rank 2
			SpellTemplate.SpellEffects[	15632	]=				//Rank 6
				SpellTemplate.SpellEffects[	15631	]=				//Rank 5
				SpellTemplate.SpellEffects[	15630	]=				//Rank 4
				SpellTemplate.SpellEffects[	15629	]=				//Rank 3
				SpellTemplate.SpellEffects[	20736	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastDistractingShot	);		//Rank 1
			#endregion
			#region Eagle Eye	
			SpellTemplate.SpellEffects[	6197	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastEagleEye	);		//
			#endregion
			#region Explosive Trap	
			SpellTemplate.SpellEffects[	13813	]=				//Rank 1
			SpellTemplate.SpellEffects[	14317	]=				//Rank 3
				SpellTemplate.SpellEffects[	14316	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastExplosiveTrap	);		//Rank 2
			#endregion
			#region Eyes of the Beast	
			SpellTemplate.SpellEffects[	1002	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastEyesoftheBeast	);		//
			#endregion
			#region Feed Pet	
			SpellTemplate.SpellEffects[	6991	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastFeedPet	);		//
			
			#endregion
			#region Feign Death	
			SpellTemplate.SpellEffects[	5384	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastFeignDeath	);		//
			#endregion
			#region Flare	
			SpellTemplate.SpellEffects[	1543	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastFlare	);		//
			#endregion
			#region Freezing Trap	
			SpellTemplate.SpellEffects[	14311	]=				//Rank 3
			SpellTemplate.SpellEffects[	14310	]=				//Rank 2
				SpellTemplate.SpellEffects[	1499	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastFreezingTrap	);		//Rank 1

			#endregion
			#region Frost Trap	
			SpellTemplate.SpellEffects[	13809	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastFrostTrap	);		//
			#endregion
			#region Hunter's Mark	
			SpellTemplate.SpellEffects[	1130	]=				//Rank 1
			SpellTemplate.SpellEffects[	14324	]=				//Rank 3
				SpellTemplate.SpellEffects[	14323	]=				//Rank 2
				SpellTemplate.SpellEffects[	14325	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastHuntersMark	);		//Rank 4
			#endregion
			#region Immolation Trap	
			SpellTemplate.SpellEffects[	13795	]=				//Rank 1
			SpellTemplate.SpellEffects[	14305	]=				//Rank 5
				SpellTemplate.SpellEffects[	14304	]=				//Rank 4
				SpellTemplate.SpellEffects[	14303	]=				//Rank 3
				SpellTemplate.SpellEffects[	14302	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastImmolationTrap	);		//Rank 2
			#endregion
			#region Mend Pet	
			SpellTemplate.SpellEffects[	3111	]=				//Rank 2
			SpellTemplate.SpellEffects[	3662	]=				//Rank 4
				SpellTemplate.SpellEffects[	13542	]=				//Rank 5
				SpellTemplate.SpellEffects[	13544	]=				//Rank 7
				SpellTemplate.SpellEffects[	13543	]=				//Rank 6
				SpellTemplate.SpellEffects[	3661	]=				//Rank 3
				SpellTemplate.SpellEffects[	136	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastMendPet	);		//Rank 1
			#endregion
			#region Mongoose Bite	
			SpellTemplate.SpellEffects[	14271	]=				//Rank 4
			SpellTemplate.SpellEffects[	14270	]=				//Rank 3
				SpellTemplate.SpellEffects[	14269	]=				//Rank 2
				SpellTemplate.SpellEffects[	1495	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastMongooseBite	);		//Rank 1
			#endregion
			#region MultiShot	
			SpellTemplate.SpellEffects[	14290	]=				//Rank 4
			SpellTemplate.SpellEffects[	14289	]=				//Rank 3
				SpellTemplate.SpellEffects[	14288	]=				//Rank 2
				SpellTemplate.SpellEffects[	2643	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastMultiShot	);		//Rank 1
							
			#endregion
			#region Rapid Fire	
			SpellTemplate.SpellEffects[	3045	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastRapidFire	);		//
			#endregion
			#region Raptor Strike	
			SpellTemplate.SpellEffects[	14266	]=				//Rank 8
			SpellTemplate.SpellEffects[	14265	]=				//Rank 7
				SpellTemplate.SpellEffects[	14264	]=				//Rank 6
				SpellTemplate.SpellEffects[	14263	]=				//Rank 5
				SpellTemplate.SpellEffects[	14262	]=				//Rank 4
				SpellTemplate.SpellEffects[	14261	]=				//Rank 3
				SpellTemplate.SpellEffects[	14260	]=				//Rank 2
				SpellTemplate.SpellEffects[	2973	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastRaptorStrike	);		//Rank 1
			#endregion
			#region Revive Pet	
			SpellTemplate.SpellEffects[	982	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastRevivePet	);		//
			#endregion
			#region Scare Beast	
			SpellTemplate.SpellEffects[	1513	]=				//Rank 1
			SpellTemplate.SpellEffects[	14327	]=				//Rank 3
				SpellTemplate.SpellEffects[	14326	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastScareBeast	);		//Rank 2
			#endregion
			#region Scorpid Sting	
			SpellTemplate.SpellEffects[	14277	]=				//Rank 4
			SpellTemplate.SpellEffects[	14276	]=				//Rank 3
				SpellTemplate.SpellEffects[	14275	]=				//Rank 2
				SpellTemplate.SpellEffects[	3043	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastScorpidSting	);		//Rank 1
			#endregion
			#region Serpent Sting	
			SpellTemplate.SpellEffects[	13550	]=				//Rank 3
			SpellTemplate.SpellEffects[	13555	]=				//Rank 8
				SpellTemplate.SpellEffects[	13554	]=				//Rank 7
				SpellTemplate.SpellEffects[	13553	]=				//Rank 6
				SpellTemplate.SpellEffects[	13552	]=				//Rank 5
				SpellTemplate.SpellEffects[	13551	]=				//Rank 4
				SpellTemplate.SpellEffects[	1978	]=				//Rank 1
				SpellTemplate.SpellEffects[	13549	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastSerpentSting	);		//Rank 2
			#endregion
			#region Spirit Bond	
			SpellTemplate.SpellEffects[	19578	]=				//Rank 1
			SpellTemplate.SpellEffects[	20896	]=				//Rank 3
				SpellTemplate.SpellEffects[	20895	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastSpiritBond	);		//Rank 2
			#endregion
			#region Tame Beast	
			SpellTemplate.SpellEffects[	13481	]=				//
			SpellTemplate.SpellEffects[	1515	]=	
				new SingleTargetSpellEffect(HunterSpells.OnCastTameBeast	);		//
							
			#endregion
			#region Track Beasts	
			SpellTemplate.SpellEffects[	1494	]=
				new OnSelfSpellEffect(HunterSpells.OnCastTrackBeasts	);		//
			#endregion
			#region Track Demons	
			SpellTemplate.SpellEffects[	19878	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastTrackDemons	);		//
			#endregion
			#region Track Dragonkin	
			SpellTemplate.SpellEffects[	19879	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastTrackDragonkin	);		//
			#endregion
			#region Track Elementals	
			SpellTemplate.SpellEffects[	19880	]=	
				new OnSelfSpellEffect(HunterSpells.OnCastTrackElementals	);		//
			#endregion
			#region Track Giants	
			SpellTemplate.SpellEffects[	19882	]=
				new OnSelfSpellEffect(HunterSpells.OnCastTrackGiants	);		//
			#endregion
			#region Track Hidden	
			SpellTemplate.SpellEffects[	19885	]=
				new OnSelfSpellEffect(HunterSpells.OnCastTrackHidden	);		//
			#endregion
			#region Track Humanoids
				SpellTemplate.SpellEffects[	19883	]=	
					new OnSelfSpellEffect(HunterSpells.OnCastTrackHumanoids	);		//
			#endregion
			#region Track Undead	
				SpellTemplate.SpellEffects[	19884	]=	
					new OnSelfSpellEffect(HunterSpells.OnCastTrackUndead	);		//
			#endregion
			#region Tranquilizing Shot	
				SpellTemplate.SpellEffects[	19801	]=	
					new SingleTargetSpellEffect(HunterSpells.OnCastTranquilizingShot	);		//
			#endregion
			#region Viper Sting	
				SpellTemplate.SpellEffects[	3034	]=				//Rank 1
				SpellTemplate.SpellEffects[	14280	]=				//Rank 3
				SpellTemplate.SpellEffects[	14279	]=
					new SingleTargetSpellEffect(HunterSpells.OnCastViperSting	);		//Rank 2
			#endregion
			#region Volley	
				SpellTemplate.SpellEffects[	14295	]=				//Rank 3
				SpellTemplate.SpellEffects[	14294	]=				//Rank 2
				SpellTemplate.SpellEffects[	1510	]=	
					new SingleTargetSpellEffect(HunterSpells.OnCastVolley	);		//Rank 1
			#endregion
			#region Wing Clip	
				SpellTemplate.SpellEffects[	2974	]=				//Rank 1
				SpellTemplate.SpellEffects[	14268	]=				//Rank 3
				SpellTemplate.SpellEffects[	14267	]=
					new SingleTargetSpellEffect(HunterSpells.OnCastWingClip	);		//Rank 2
	#endregion
			#endregion

			#region Paladin spells -> all listed 
			#region Blessing of Freedom	
			SpellTemplate.SpellEffects[	1044	]=
				new SingleTargetSpellEffect(PaladinSpells.OnCastBlessingofFreedom	);		//
			#endregion
			#region Blessing of Light	
			SpellTemplate.SpellEffects[	19979	]=				//Rank 3
			SpellTemplate.SpellEffects[	19977	]=				//Rank 1
				SpellTemplate.SpellEffects[	19978	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastBlessingofLight	);		//Rank 2
			#endregion
			#region Blessing of Might	
			SpellTemplate.SpellEffects[	19838	]=				//Rank 6
			SpellTemplate.SpellEffects[	19837	]=				//Rank 5
				SpellTemplate.SpellEffects[	19836	]=				//Rank 4
				SpellTemplate.SpellEffects[	19835	]=				//Rank 3
				SpellTemplate.SpellEffects[	19834	]=				//Rank 2
				SpellTemplate.SpellEffects[	19740	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastBlessingofMight	);		//Rank 1
			#endregion
			#region Blessing of Protection	
			SpellTemplate.SpellEffects[	10278	]=				//Rank 3
			SpellTemplate.SpellEffects[	5599	]=				//Rank 2
				SpellTemplate.SpellEffects[	1022	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastBlessingofProtection	);		//Rank 1
			#endregion
			#region Blessing of Sacrifice
			SpellTemplate.SpellEffects[	6940	]=				//Rank 1
			SpellTemplate.SpellEffects[	20729	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastBlessingofSacrifice	);		//Rank 2
			#endregion
			#region Blessing of Salvation
			SpellTemplate.SpellEffects[	1038	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastBlessingofSalvation	);		//
			#endregion
			#region Blessing of Wisdom
			SpellTemplate.SpellEffects[	19854	]=				//Rank 5
			SpellTemplate.SpellEffects[	19853	]=				//Rank 4
				SpellTemplate.SpellEffects[	19852	]=				//Rank 3
				SpellTemplate.SpellEffects[	19850	]=				//Rank 2
				SpellTemplate.SpellEffects[	19742	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastBlessingofWisdom	);		//Rank 1

			#endregion
			#region Cleanse
			SpellTemplate.SpellEffects[	4987	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastCleanse	);		//
			#endregion
			#region Concentration Aura
			SpellTemplate.SpellEffects[	19746	]=	
				new OnSelfSpellEffect(PaladinSpells.OnCastConcentrationAura	);		//
			#endregion
			#region Devotion Aura
			SpellTemplate.SpellEffects[	465	]=				//Rank 1
			SpellTemplate.SpellEffects[	643	]=				//Rank 3
				SpellTemplate.SpellEffects[	1032	]=				//Rank 5
				SpellTemplate.SpellEffects[	10291	]=				//Rank 4
				SpellTemplate.SpellEffects[	10293	]=				//Rank 7
				SpellTemplate.SpellEffects[	10292	]=				//Rank 6
				SpellTemplate.SpellEffects[	10290	]=	
				new OnSelfSpellEffect(PaladinSpells.OnCastDevotionAura	);		//Rank 2
			#endregion
			#region Divine Intervention
			SpellTemplate.SpellEffects[	19752	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastDivineIntervention	);		//
			#endregion
			#region Divine Protection
			SpellTemplate.SpellEffects[	5573	]=				//Rank 2
			SpellTemplate.SpellEffects[	498	]=
				new OnSelfSpellEffect(PaladinSpells.OnCastDivineProtection	);		//Rank 1
			#endregion
			#region Divine Shield
			SpellTemplate.SpellEffects[	642	]=				//Rank 1
			SpellTemplate.SpellEffects[	1020	]=
				new OnSelfSpellEffect(PaladinSpells.OnCastDivineShield	);		//Rank 2
			#endregion
			#region Exorcism
			SpellTemplate.SpellEffects[	10314	]=				//Rank 6
			SpellTemplate.SpellEffects[	10313	]=				//Rank 5
				SpellTemplate.SpellEffects[	10312	]=				//Rank 4
				SpellTemplate.SpellEffects[	5615	]=				//Rank 3
				SpellTemplate.SpellEffects[	5614	]=				//Rank 2
				SpellTemplate.SpellEffects[	879	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastExorcism	);		//Rank 1
			#endregion
			#region Fire Resistance Aura
			SpellTemplate.SpellEffects[	19899	]=				//Rank 2
			SpellTemplate.SpellEffects[	19900	]=				//Rank 3
				SpellTemplate.SpellEffects[	19891	]=	
				new OnSelfSpellEffect(PaladinSpells.OnCastFireResistanceAura	);		//Rank 1
			#endregion
			#region Flash of Light
			SpellTemplate.SpellEffects[	19941	]=				//Rank 4
			SpellTemplate.SpellEffects[	19993	]=				//
				SpellTemplate.SpellEffects[	19943	]=				//Rank 6
				SpellTemplate.SpellEffects[	19942	]=				//Rank 5
				SpellTemplate.SpellEffects[	19940	]=				//Rank 3
				SpellTemplate.SpellEffects[	19939	]=				//Rank 2
				SpellTemplate.SpellEffects[	19750	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastFlashofLight	);		//Rank 1
			#endregion
			#region Frost Resistance Aura
			SpellTemplate.SpellEffects[	19898	]=				//Rank 3
			SpellTemplate.SpellEffects[	19897	]=				//Rank 2
				SpellTemplate.SpellEffects[	19888	]=	
				new OnSelfSpellEffect(PaladinSpells.OnCastFrostResistanceAura	);		//Rank 1
			#endregion
			#region Hammer of Justice
			SpellTemplate.SpellEffects[	853	]=				//Rank 1
			SpellTemplate.SpellEffects[	10308	]=				//Rank 4
				SpellTemplate.SpellEffects[	5589	]=				//Rank 3
				SpellTemplate.SpellEffects[	5588	]=
				new SingleTargetSpellEffect(PaladinSpells.OnCastHammerofJustice	);		//Rank 2
			#endregion
			#region Holy Light
			SpellTemplate.SpellEffects[	10329	]=				//Rank 8
			SpellTemplate.SpellEffects[	10328	]=				//Rank 7
				SpellTemplate.SpellEffects[	3472	]=				//Rank 6
				SpellTemplate.SpellEffects[	1026	]=				//Rank 4
				SpellTemplate.SpellEffects[	647	]=				//Rank 3
				SpellTemplate.SpellEffects[	639	]=				//Rank 2
				SpellTemplate.SpellEffects[	635	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastHolyLight	);		//Rank 1
			#endregion
			#region Holy Wrath
			SpellTemplate.SpellEffects[	2812	]=				//Rank 1
			SpellTemplate.SpellEffects[	10318	]=	
				new OnSelfSpellEffect(PaladinSpells.OnCastHolyWrath	);		//Rank 2
			#endregion
			#region Judgement
			SpellTemplate.SpellEffects[	20271	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastJudgement	);		//
			#endregion
			#region Judgement of Fury
			SpellTemplate.SpellEffects[	20414	]=				//Rank 5
			SpellTemplate.SpellEffects[	20413	]=				//Rank 4
				SpellTemplate.SpellEffects[	20412	]=				//Rank 3
				SpellTemplate.SpellEffects[	20411	]=				//Rank 2
				SpellTemplate.SpellEffects[	20183	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastJudgementofFury	);		//Rank 1
			#endregion
			#region Judgement of Justice
			SpellTemplate.SpellEffects[	20184	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastJudgementofJustice	);		//Rank 1
			#endregion
			#region Judgement of Light
			SpellTemplate.SpellEffects[	20346	]=				//Rank 4
			SpellTemplate.SpellEffects[	20345	]=				//Rank 3
				SpellTemplate.SpellEffects[	20344	]=				//Rank 2
				SpellTemplate.SpellEffects[	20185	]=
				new SingleTargetSpellEffect(PaladinSpells.OnCastJudgementofLight	);		//Rank 1
			#endregion
			#region Judgement of Wisdom
			SpellTemplate.SpellEffects[	20355	]=				//Rank 3
			SpellTemplate.SpellEffects[	20354	]=				//Rank 2
				SpellTemplate.SpellEffects[	20186	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastJudgementofWisdom	);		//Rank 1
			#endregion
			#region Judgement of the Crusader
			SpellTemplate.SpellEffects[	20303	]=				//Rank 6
			SpellTemplate.SpellEffects[	20302	]=				//Rank 5
				SpellTemplate.SpellEffects[	20301	]=				//Rank 4
				SpellTemplate.SpellEffects[	20300	]=				//Rank 3
				SpellTemplate.SpellEffects[	20188	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastJudgementoftheCrusader	);		//Rank 2
			#endregion
			#region Lay on Hands
			SpellTemplate.SpellEffects[	10310	]=				//Rank 3
			SpellTemplate.SpellEffects[	2800	]=				//Rank 2
				SpellTemplate.SpellEffects[	633	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastLayonHands	);		//Rank 1

			#endregion
			#region Purify	
			SpellTemplate.SpellEffects[	1152	]=	
				new SingleTargetSpellEffect(PaladinSpells.OnCastPurify	);		//
			#endregion
			#region Redemption
			SpellTemplate.SpellEffects[	20773	]=				//Rank 5
			SpellTemplate.SpellEffects[	20772	]=				//Rank 4
				SpellTemplate.SpellEffects[	10324	]=				//Rank 3
				SpellTemplate.SpellEffects[	10322	]=				//Rank 2
				SpellTemplate.SpellEffects[	7328	]=
				new SingleTargetSpellEffect(PaladinSpells.OnCastRedemption	);		//Rank 1
			#endregion
			#region Retribution Aura
			SpellTemplate.SpellEffects[	10298	]=				//Rank 2
			SpellTemplate.SpellEffects[	10300	]=				//Rank 4
				SpellTemplate.SpellEffects[	10301	]=				//Rank 5
				SpellTemplate.SpellEffects[	10299	]=				//Rank 3
				SpellTemplate.SpellEffects[	7294	]=
				new OnSelfSpellEffect(PaladinSpells.OnCastRetributionAura	);		//Rank 1
			#endregion
			#region Seal of Fury
//			SpellTemplate.SpellEffects[	20423	]=				//Rank 5
//			SpellTemplate.SpellEffects[	20422	]=				//Rank 4
//				SpellTemplate.SpellEffects[	20421	]=				//Rank 3
//				SpellTemplate.SpellEffects[	20419	]=				//Rank 2
//				SpellTemplate.SpellEffects[	20232	]=				//Rank 1
//				SpellTemplate.SpellEffects[	20163	]=	
//				new OnSelfSpellEffect(PaladinSpells.OnCastSealofFury	);		//Rank 1
			#endregion
			#region Seal of Justice
			SpellTemplate.SpellEffects[	20164	]=	
				new OnSelfSpellEffect(PaladinSpells.OnCastSealofJustice	);		//
			#endregion
			#region Seal of Light
			SpellTemplate.SpellEffects[	20349	]=				//Rank 4
			SpellTemplate.SpellEffects[	20348	]=				//Rank 3
				SpellTemplate.SpellEffects[	20347	]=				//Rank 2
				SpellTemplate.SpellEffects[	20165	]=
				new OnSelfSpellEffect(PaladinSpells.OnCastSealofLight	);		//Rank 1
			#endregion
			#region Seal of Righteousness
			SpellTemplate.SpellEffects[	20285	]=				//Rank 7
			SpellTemplate.SpellEffects[	20292	]=				//Rank 7
				SpellTemplate.SpellEffects[	20284	]=				//Rank 6
				SpellTemplate.SpellEffects[	20283	]=				//Rank 5
				SpellTemplate.SpellEffects[	20282	]=				//Rank 4
				SpellTemplate.SpellEffects[	20281	]=				//Rank 3
				SpellTemplate.SpellEffects[	20293	]=				//Rank 8
				SpellTemplate.SpellEffects[	20286	]=				//Rank 8
				SpellTemplate.SpellEffects[	20291	]=				//Rank 6
				SpellTemplate.SpellEffects[	20290	]=				//Rank 5
				SpellTemplate.SpellEffects[	20289	]=				//Rank 4
				SpellTemplate.SpellEffects[	20288	]=				//Rank 3
				SpellTemplate.SpellEffects[	20280	]=				//Rank 2
				SpellTemplate.SpellEffects[	20287	]=				//Rank 2
				SpellTemplate.SpellEffects[	20187	]=				//Rank 1
				SpellTemplate.SpellEffects[	20154	]=				//Rank 1
				SpellTemplate.SpellEffects[	21084	]=
				new OnSelfSpellEffect(PaladinSpells.OnCastSealofRighteousness	);		//Rank 1
			#endregion
			#region Seal of Wisdom
			SpellTemplate.SpellEffects[	20357	]=				//Rank 3
			SpellTemplate.SpellEffects[	20356	]=				//Rank 2
				SpellTemplate.SpellEffects[	20166	]=
				new OnSelfSpellEffect(PaladinSpells.OnCastSealofWisdom	);		//Rank 1
			#endregion
			#region Seal of the Crusader
			SpellTemplate.SpellEffects[	21082	]=				//Rank 1
			SpellTemplate.SpellEffects[	20308	]=				//Rank 6
				SpellTemplate.SpellEffects[	20307	]=				//Rank 5
				SpellTemplate.SpellEffects[	20306	]=				//Rank 4
				SpellTemplate.SpellEffects[	20305	]=				//Rank 3
				SpellTemplate.SpellEffects[	20162	]=	
				new OnSelfSpellEffect(PaladinSpells.OnCastSealoftheCrusader	);		//Rank 2
			#endregion
			#region Sense Undead
			SpellTemplate.SpellEffects[	5502	]=	
				new OnSelfSpellEffect(PaladinSpells.OnCastSenseUndead	);		//
			#endregion
			#region Shadow Resistance Aura
			SpellTemplate.SpellEffects[	19895	]=				//Rank 2
			SpellTemplate.SpellEffects[	19896	]=				//Rank 3
				SpellTemplate.SpellEffects[	19876	]=	
				new OnSelfSpellEffect(PaladinSpells.OnCastShadowResistanceAura	);		//Rank 1
			#endregion
			#region Turn Undead
				SpellTemplate.SpellEffects[	10326	]=				//Rank 3
				SpellTemplate.SpellEffects[	2878	]=				//Rank 1
				SpellTemplate.SpellEffects[	5627	]=	
					new SingleTargetSpellEffect(PaladinSpells.OnCastTurnUndead	);		//Rank 2
			#endregion
			#endregion

			#region Rogue spells -> all listed 
			#region Ambush	
			SpellTemplate.SpellEffects[	11269	]=				//Rank 6
				SpellTemplate.SpellEffects[	11268	]=				//Rank 5
				SpellTemplate.SpellEffects[	11267	]=				//Rank 4
				SpellTemplate.SpellEffects[	8725	]=				//Rank 3
				SpellTemplate.SpellEffects[	8724	]=				//Rank 2
				SpellTemplate.SpellEffects[	8676	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastAmbush	);		//Rank 1
			#endregion
			#region Backstab	
			SpellTemplate.SpellEffects[	11281	]=				//Rank 8
				SpellTemplate.SpellEffects[	11280	]=				//Rank 7
				SpellTemplate.SpellEffects[	11279	]=				//Rank 6
				SpellTemplate.SpellEffects[	8721	]=				//Rank 5
				SpellTemplate.SpellEffects[	2591	]=				//Rank 4
				SpellTemplate.SpellEffects[	2590	]=				//Rank 3
				SpellTemplate.SpellEffects[	2589	]=				//Rank 2
				SpellTemplate.SpellEffects[	53	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastBackstab	);		//Rank 1
			#endregion
			#region Blind	
			SpellTemplate.SpellEffects[	2094	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastBlind	);		//
			#endregion
			#region Cheap Shot	
			SpellTemplate.SpellEffects[	1833	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastCheapShot	);		//
			#endregion
			#region Detect Traps	
			SpellTemplate.SpellEffects[	2836	]=	
				new OnSelfSpellEffect(RogueSpells.OnCastDetectTraps	);		//
			#endregion
			#region Disarm Trap
			SpellTemplate.SpellEffects[	1842	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastDisarmTrap	);		//
			#endregion
			#region Distract	
			SpellTemplate.SpellEffects[	1725	]=	
				new TargetXYZSpellEffect(RogueSpells.OnCastDistract   );		//
			#endregion
			#region Evasion	
			SpellTemplate.SpellEffects[	5277	]=	
				new OnSelfSpellEffect(RogueSpells.OnCastEvasion	);		//
			#endregion
			#region Eviscerate	
			SpellTemplate.SpellEffects[	2098	]=				//Rank 1
				SpellTemplate.SpellEffects[	6761	]=				//Rank 3
				SpellTemplate.SpellEffects[	6762	]=				//Rank 4
				SpellTemplate.SpellEffects[	6760	]=				//Rank 2
				SpellTemplate.SpellEffects[	8624	]=				//Rank 6
				SpellTemplate.SpellEffects[	8623	]=				//Rank 5
				SpellTemplate.SpellEffects[	11300	]=				//Rank 8
				SpellTemplate.SpellEffects[	11299	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastEviscerate	);		//Rank 7
			#endregion
			#region Expose Armor
			SpellTemplate.SpellEffects[	8650	]=				//Rank 3
				SpellTemplate.SpellEffects[	8649	]=				//Rank 2
				SpellTemplate.SpellEffects[	11198	]=				//Rank 5
				SpellTemplate.SpellEffects[	11197	]=				//Rank 4
				SpellTemplate.SpellEffects[	8647	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastExposeArmor	);		//Rank 1
			#endregion
			#region Feint	
			SpellTemplate.SpellEffects[	11303	]=				//Rank 4
				SpellTemplate.SpellEffects[	8637	]=				//Rank 3
				SpellTemplate.SpellEffects[	6768	]=				//Rank 2
				SpellTemplate.SpellEffects[	1966	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastFeint	);		//Rank 1
			#endregion
			#region Garrote	
			SpellTemplate.SpellEffects[	703	]=				//Rank 1
				SpellTemplate.SpellEffects[	8633	]=				//Rank 4
				SpellTemplate.SpellEffects[	8632	]=				//Rank 3
				SpellTemplate.SpellEffects[	8631	]=				//Rank 2
				SpellTemplate.SpellEffects[	11290	]=				//Rank 6
				SpellTemplate.SpellEffects[	11289	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastGarrote	);		//Rank 5
			#endregion
			#region Gouge
			SpellTemplate.SpellEffects[	1777	]=				//Rank 2
				SpellTemplate.SpellEffects[	11286	]=				//Rank 5
				SpellTemplate.SpellEffects[	11285	]=				//Rank 4
				SpellTemplate.SpellEffects[	8629	]=				//Rank 3
				SpellTemplate.SpellEffects[	1776	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastGouge	);		//Rank 1
			#endregion
			#region Kick	
			SpellTemplate.SpellEffects[	1769	]=				//Rank 4
				SpellTemplate.SpellEffects[	1768	]=				//Rank 3
				SpellTemplate.SpellEffects[	1767	]=				//Rank 2
				SpellTemplate.SpellEffects[	1766	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastKick	);		//Rank 1
			#endregion
			#region Kidney Shot	
			SpellTemplate.SpellEffects[	8643	]=				//Rank 2
				SpellTemplate.SpellEffects[	408	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastKidneyShot	);		//Rank 1
			#endregion
			#region Pick Lock
			SpellTemplate.SpellEffects[	1804	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastPickLock	);		//
			#endregion
			#region Pick Pocket	
			SpellTemplate.SpellEffects[	921	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastPickPocket	);		//
			#endregion
			#region Rupture	
			SpellTemplate.SpellEffects[	1943	]=				//Rank 1
				SpellTemplate.SpellEffects[	8640	]=				//Rank 3
				SpellTemplate.SpellEffects[	8639	]=				//Rank 2
				SpellTemplate.SpellEffects[	11273	]=				//Rank 4
				SpellTemplate.SpellEffects[	11275	]=				//Rank 6
				SpellTemplate.SpellEffects[	11274	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastRupture	);		//Rank 5
			#endregion
			#region Safe Fall	
			SpellTemplate.SpellEffects[	1860	]=	
				new OnSelfSpellEffect(RogueSpells.OnCastSafeFall	);		//Passive
			#endregion
			#region Sap	
			SpellTemplate.SpellEffects[	11297	]=				//Rank 3
				SpellTemplate.SpellEffects[	2070	]=				//Rank 2
				SpellTemplate.SpellEffects[	6770	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastSap	);		//Rank 1
			#endregion
			#region Sinister Strike	
			SpellTemplate.SpellEffects[	11293	]=				//Rank 7
				SpellTemplate.SpellEffects[	11294	]=				//Rank 8
				SpellTemplate.SpellEffects[	8621	]=				//Rank 6
				SpellTemplate.SpellEffects[	1760	]=				//Rank 5
				SpellTemplate.SpellEffects[	1759	]=				//Rank 4
				SpellTemplate.SpellEffects[	1758	]=				//Rank 3
				SpellTemplate.SpellEffects[	1757	]=				//Rank 2
				SpellTemplate.SpellEffects[	1752	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastSinisterStrike	);		//Rank 1
			#endregion
			#region Slice and Dice	
			SpellTemplate.SpellEffects[	6774	]=				//Rank 2
				SpellTemplate.SpellEffects[	5171	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastSliceandDice	);		//Rank 1
			#endregion
			#region Sprint	
			SpellTemplate.SpellEffects[	2983	]=				//Rank 1
				SpellTemplate.SpellEffects[	11305	]=				//Rank 3
				SpellTemplate.SpellEffects[	8696	]=	
				new OnSelfSpellEffect(RogueSpells.OnCastSprint	);		//Rank 2
			#endregion
			#region Stealth	
			SpellTemplate.SpellEffects[	1787	]=				//Rank 4
				SpellTemplate.SpellEffects[	1786	]=				//Rank 3
				SpellTemplate.SpellEffects[	1785	]=				//Rank 2
				SpellTemplate.SpellEffects[	1784	]=	
				new OnSelfSpellEffect(RogueSpells.OnCastStealth	);		//Rank 1
							
			#endregion
			#region Vanish	
			SpellTemplate.SpellEffects[	1857	]=				//Rank 2
				SpellTemplate.SpellEffects[	1856	]=	
				new OnSelfSpellEffect(RogueSpells.OnCastVanish	);		//Rank 1
			#endregion

			#region Poisons
			#region Blinding Powder
			SpellTemplate.SpellEffects[	6510	]=				
				new OnSelfSpellEffect(RogueSpells.OnCastBlindingPowder	);
			#endregion
			//			#region Cold Blood
			//			SpellTemplate.SpellEffects[	14177	]=				
			//				new OnSelfSpellEffect(RogueSpells.OnCastColdBlood	);
			//			#endregion
			#endregion

			#region Talent
			#region Cold Blood
			SpellTemplate.SpellEffects[	14177	]=				
				new OnSelfSpellEffect(RogueSpells.OnCastColdBlood	);
			#endregion
			#region Relentless Strikes
			SpellTemplate.SpellEffects[	14179	]=				
				new OnSelfSpellEffect(RogueSpells.OnCastRelentlessStrikes	);
			#endregion
			#region Adrenaline Rush
			SpellTemplate.SpellEffects[	13750	]=				
				new OnSelfSpellEffect(RogueSpells.OnCastAdrenalineRush	);
			#endregion
			#region Blade Flurry
			SpellTemplate.SpellEffects[	13877	]=				
				new OnSelfSpellEffect(RogueSpells.OnCastBladeFlurry	);
			#endregion
			#region Riposte
			SpellTemplate.SpellEffects[	14251	]=				
				new SingleTargetSpellEffect(RogueSpells.OnCastRiposte	);
			#endregion
			#region Ghostly Strike
			SpellTemplate.SpellEffects[	14278	]=				
				new SingleTargetSpellEffect(RogueSpells.OnCastGhostlyStrike	);
			#endregion
			#region Premeditation
			SpellTemplate.SpellEffects[	14183	]=				
				new SingleTargetSpellEffect(RogueSpells.OnCastPremeditation	);
			#endregion
			#region Hemorrhage
			SpellTemplate.SpellEffects[	17348	]=				//Rank 3
				SpellTemplate.SpellEffects[	17347	]=				//Rank 2
				SpellTemplate.SpellEffects[	16511	]=	
				new SingleTargetSpellEffect(RogueSpells.OnCastHemorrhage	);		//Rank 1
			#endregion
			#region Preparation
			//			SpellTemplate.SpellEffects[	14185	]=				
			//				new OnSelfSpellEffect(RogueSpells.OnCastPreparation	);
			#endregion
			#endregion
			#endregion

			#region Potions -> in developt
            #region Mana Potion
				SpellTemplate.SpellEffects[ 436 ] = 
                SpellTemplate.SpellEffects[ 437 ] = 
                SpellTemplate.SpellEffects[ 438 ] = 
				SpellTemplate.SpellEffects[ 11903 ] = 
				SpellTemplate.SpellEffects[ 17530 ] = 
				SpellTemplate.SpellEffects[ 17531 ] =
				SpellTemplate.SpellEffects[ 2023 ] = 
                new OnSelfSpellEffect( Potions.OnUseManaPotion );
            #endregion
			#region StoneShieldPotion
				SpellTemplate.SpellEffects[ 4941] = 
				SpellTemplate.SpellEffects[ 17540 ] = 
				new OnSelfSpellEffect( Potions.OnUseStoneshieldPotion );
			#endregion
			#region Invisibility potion
				SpellTemplate.SpellEffects[ 3680 ] = 
				SpellTemplate.SpellEffects[ 11392 ] = 
				new OnSelfSpellEffect( Potions.OnUseInvisibilityPotion );
			#endregion
			#region Magic Resistance potion
			SpellTemplate.SpellEffects[ 11364 ] = 
				SpellTemplate.SpellEffects[ 2380 ] = 
				new OnSelfSpellEffect( Potions.OnUseMagicResistancePotion );
			#endregion
			#region Fire Protection potion
			SpellTemplate.SpellEffects[ 6049 ] = 
				SpellTemplate.SpellEffects[ 13457 ] = 
				new OnSelfSpellEffect( Potions.OnUseFireProtectionPotion );
			#endregion
			#region Arcane Protection potion
			SpellTemplate.SpellEffects[ 13461 ] = 
				new OnSelfSpellEffect( Potions.OnUseArcaneProtectionPotion );
			#endregion
			#region Frost Protection potion
			SpellTemplate.SpellEffects[ 6050 ] = 
				SpellTemplate.SpellEffects[ 13456 ] = 
				new OnSelfSpellEffect( Potions.OnUseFrostProtectionPotion );
			#endregion
			#region Nature Protection potion
			SpellTemplate.SpellEffects[ 6052 ] = 
				SpellTemplate.SpellEffects[ 13458 ] = 
				new OnSelfSpellEffect( Potions.OnUseNatureProtectionPotion );
			#endregion
			#region Shadow Protection potion
			SpellTemplate.SpellEffects[ 6048 ] = 
				SpellTemplate.SpellEffects[ 13459 ] = 
				new OnSelfSpellEffect( Potions.OnUseShadowProtectionPotion );
			#endregion
			#region Rejuvenation potion
				SpellTemplate.SpellEffects[ 22729 ] = 
				SpellTemplate.SpellEffects[ 2370 ] = 
				SpellTemplate.SpellEffects[ 11387 ] = 
				new OnSelfSpellEffect( Potions.OnUseRejuvenationPotion );
			#endregion
            #region Health Potion
				SpellTemplate.SpellEffects[ 439 ] = 
				SpellTemplate.SpellEffects[ 440 ] = 
				SpellTemplate.SpellEffects[ 441 ] = 
				SpellTemplate.SpellEffects[ 4042 ] = 
				SpellTemplate.SpellEffects[ 17534 ] = 
				SpellTemplate.SpellEffects[ 2024 ] = 
                new OnSelfSpellEffect( Potions.OnUseHealthPotion );
            #endregion
			#region TrollsBloods potions
			SpellTemplate.SpellEffects[ 3382 ] = 
				SpellTemplate.SpellEffects[ 3826 ] = 
				SpellTemplate.SpellEffects[ 3388 ] = 
				new OnSelfSpellEffect( Potions.OnUseTrollBloodPotion );
			#endregion
			#region Dreamless Sleep potions
			SpellTemplate.SpellEffects[ 12190 ] = 
				new OnSelfSpellEffect( Potions.OnUseDreamlessSleepPotion );
			#endregion
            #endregion

			#region Poisons -> in developt
			#endregion

			#region Elixirs -> in developt
			#region Elixirs of Agility
			SpellTemplate.SpellEffects[ 11328 ] = 
				SpellTemplate.SpellEffects[ 11334 ] = 
				SpellTemplate.SpellEffects[ 3160 ] = 
				SpellTemplate.SpellEffects[ 2374 ] = 
				new OnSelfSpellEffect( Elixirs.OnUseElixirOfAgility );
			#endregion
			#region Elixirs of Defense
			SpellTemplate.SpellEffects[ 3220 ] = 
				SpellTemplate.SpellEffects[ 673 ] = 
				SpellTemplate.SpellEffects[ 11349 ] = 
				SpellTemplate.SpellEffects[ 11348 ] = 
				new OnSelfSpellEffect( Elixirs.OnUseElixirOfDefense );
			#endregion
			#region Elixirs of BruteForce
			SpellTemplate.SpellEffects[ 17537 ] = 
				new OnSelfSpellEffect( Elixirs.OnUseElixirOfBruteForce );
			#endregion
			#region Elixirs of Fortitude
				SpellTemplate.SpellEffects[ 3593 ] = 
				SpellTemplate.SpellEffects[ 2378 ] = 
				new OnSelfSpellEffect( Elixirs.OnUseElixirOfFortitude );
			#endregion
			#region Elixirs of Strenght
				SpellTemplate.SpellEffects[ 11405 ] = 
				SpellTemplate.SpellEffects[ 2367 ] = 
				SpellTemplate.SpellEffects[ 3164 ] = 
				new OnSelfSpellEffect( Elixirs.OnUseElixirOfStrenght );
			#endregion
			#region Elixirs of IQ
				SpellTemplate.SpellEffects[ 11396 ] = 
				SpellTemplate.SpellEffects[ 3166 ] = 
				new OnSelfSpellEffect( Elixirs.OnUseElixirOfIQ );
			#endregion
			#region Elixirs of Sages
				SpellTemplate.SpellEffects[ 17535 ] = 
				new OnSelfSpellEffect( Elixirs.OnUseElixirOfSages );
			#endregion
			#endregion

			#region Items-> in developt
			#region Increased Armor
				SpellTemplate.SpellEffects[	9760	]=
				SpellTemplate.SpellEffects[	15666	]=
				SpellTemplate.SpellEffects[	15805	]=
				SpellTemplate.SpellEffects[	19787	]=
				SpellTemplate.SpellEffects[	15508	]=
				SpellTemplate.SpellEffects[	15367	]=
				SpellTemplate.SpellEffects[	18190	]=
				SpellTemplate.SpellEffects[	15693	]=
				SpellTemplate.SpellEffects[	18069	]=
				SpellTemplate.SpellEffects[	18188	]=
				SpellTemplate.SpellEffects[	9761	]=
				SpellTemplate.SpellEffects[	14803	]=
				SpellTemplate.SpellEffects[	18281	]=
				SpellTemplate.SpellEffects[	18195	]=
				SpellTemplate.SpellEffects[	15687	]=
				SpellTemplate.SpellEffects[	18068	]=
				SpellTemplate.SpellEffects[	9762	]=
				SpellTemplate.SpellEffects[	15957	]=
				SpellTemplate.SpellEffects[	9763	]=
				SpellTemplate.SpellEffects[	17617	]=
				SpellTemplate.SpellEffects[	9764	]=
				SpellTemplate.SpellEffects[	9765	]=
				SpellTemplate.SpellEffects[	9766	]=
				SpellTemplate.SpellEffects[	9767	]=
				SpellTemplate.SpellEffects[	9768	]=
				new OnSelfSpellEffect( ItemsSpells.OnIncreasedArmor );
			#endregion
			#region Drink
			SpellTemplate.SpellEffects[430]=
			SpellTemplate.SpellEffects[431]=
			SpellTemplate.SpellEffects[432]=
			SpellTemplate.SpellEffects[1133]=
			SpellTemplate.SpellEffects[1135]=
			SpellTemplate.SpellEffects[1137]=
			SpellTemplate.SpellEffects[10250]=
			SpellTemplate.SpellEffects[22734]=
				new OnSelfSpellEffect( ItemsSpells.OnDrink );
			#endregion
			#region Base Food
				SpellTemplate.SpellEffects[433]=
				SpellTemplate.SpellEffects[434]=
				SpellTemplate.SpellEffects[435]=
				SpellTemplate.SpellEffects[1127]=
				SpellTemplate.SpellEffects[1129]=
				SpellTemplate.SpellEffects[1131]=
				SpellTemplate.SpellEffects[7737]=
				SpellTemplate.SpellEffects[5004]=
				SpellTemplate.SpellEffects[5005]=
				SpellTemplate.SpellEffects[5006]=
				SpellTemplate.SpellEffects[5007]=
				SpellTemplate.SpellEffects[10256]=
				SpellTemplate.SpellEffects[10257]=
				SpellTemplate.SpellEffects[2639]=
				SpellTemplate.SpellEffects[10257]=
				SpellTemplate.SpellEffects[18230]=
				new OnSelfSpellEffect( ItemsSpells.OnBaseFood );
			#endregion
			#region FoodType2
				SpellTemplate.SpellEffects[18229]=
				SpellTemplate.SpellEffects[18234]=
				SpellTemplate.SpellEffects[18231]=
				SpellTemplate.SpellEffects[18232]=
				SpellTemplate.SpellEffects[18233]=
				SpellTemplate.SpellEffects[22731]=
				new OnSelfSpellEffect( ItemsSpells.OnFoodType2 );
			#endregion
			#region food effect1
			SpellTemplate.SpellEffects[19705]=
				SpellTemplate.SpellEffects[19706]=
				SpellTemplate.SpellEffects[19708]=
				SpellTemplate.SpellEffects[19709]=
				SpellTemplate.SpellEffects[19710]=
				SpellTemplate.SpellEffects[19711]=
				new OnSelfSpellEffect( ItemsSpells.OnFoodEffect1 );
			#endregion
			#region food effect2
				SpellTemplate.SpellEffects[18192]=
				new OnSelfSpellEffect( ItemsSpells.OnFoodEffect2 );
			#endregion
			#region food effect3
			SpellTemplate.SpellEffects[18191]=
				new OnSelfSpellEffect( ItemsSpells.OnFoodEffect3 );
			#endregion
			#region food effect4
			SpellTemplate.SpellEffects[18193]=
				new OnSelfSpellEffect( ItemsSpells.OnFoodEffect4 );
			#endregion
			#region food effect5
			SpellTemplate.SpellEffects[18222]=
				new OnSelfSpellEffect( ItemsSpells.OnFoodEffect5 );
			#endregion
			#region food effect6
			SpellTemplate.SpellEffects[18194]=
				new OnSelfSpellEffect( ItemsSpells.OnFoodEffect6 );
			#endregion

			#endregion

			#region Summon creature spells
			//	Imp Firebolt            
			/*SpellTemplate.SpellEffects[	701	]=//1
				SpellTemplate.SpellEffects[	690	]=//2
				SpellTemplate.SpellEffects[	1084 ]=//3
				SpellTemplate.SpellEffects[	1096 ]=//4
				SpellTemplate.SpellEffects[	1114 ]=//5				
				new SingleTargetSpellEffect(SummoningCreatureSpells.OnCastFireBolt );*/
			SpellTemplate.SetSpellEffects( new int[]{ 701, 690, 1084, 1096, 1114 }, new SingleTargetSpellEffect(SummoningCreatureSpells.OnCastFireBolt ) );
			//	Blood pact            
			SpellTemplate.SpellEffects[	6307 ]=//1
				SpellTemplate.SpellEffects[	7804 ]=//2
				SpellTemplate.SpellEffects[	7805 ]=//3
				SpellTemplate.SpellEffects[	11766 ]=//4
				SpellTemplate.SpellEffects[	11767 ]=//5				
				new SingleTargetSpellEffect(SummoningCreatureSpells.OnCastBloodPact );
/*
			//	Unholy Frenzy            
			SpellTemplate.SpellEffects[	698	]=//1
				SpellTemplate.SpellEffects[	710	]=//2
				SpellTemplate.SpellEffects[	1098 ]=//3
				new SingleTargetSpellEffect(SummoningCreatureSpells.OnCastUnHolyFrenzy );
			*/
			#endregion
		
			#region Equipable Items
				#region Soul Stones
				SpellTemplate.SpellEffects[	18384	] =
					new OnSelfItemSpellEffect( EquipableItemsSpells.OnSpellStoneCriticalIncrease );
				#endregion
			#region On Hit Spells
			SpellTemplate.SpellEffects[	13518 ] =
				new OnSingleTargetItemSpellEffect( EquipableItemsSpells.OnSpellNaturePoison );
			#endregion
			#endregion

			#region Mob spells
			SpellTemplate.SpellEffects[ 3385 ] =  new OnSelfSpellEffect( MobSpells.OnCastBoarCharge );
			SpellTemplate.SpellEffects[ 13496 ] = new SingleTargetSpellEffect( MobSpells.OnCastDaze );
			SpellTemplate.SpellEffects[ 6751 ] =  new SingleTargetSpellEffect( MobSpells.OnCastWeakPoison );
			SpellTemplate.SpellEffects[ 744 ] =  new SingleTargetSpellEffect( MobSpells.OnCastWeakPoison );
			SpellTemplate.SpellEffects[ 15571 ] = new SingleTargetSpellEffect( MobSpells.OnCastDaze );
			SpellTemplate.SpellEffects[ 5718 ] =  new SingleTargetSpellEffect( MobSpells.OnCastThreateningGrowl );
			SpellTemplate.SpellEffects[ 8646 ] = SpellTemplate.SpellEffects[ 15618 ] = new SingleTargetSpellEffect( MobSpells.OnCastSnapKick );
			SpellTemplate.SpellEffects[12550] = new OnSelfSpellEffect(MobSpells.OnCastLightningShield);
			SpellTemplate.SpellEffects[3130] = new SingleTargetSpellEffect(MobSpells.OnCastIceClaw);
			SpellTemplate.SpellEffects[8715] = new OnSelfSpellEffect(MobSpells.OnCastTerrifyingHowl);
			SpellTemplate.SpellEffects[3604] = new SingleTargetSpellEffect(MobSpells.OnCastTendonRip);
			SpellTemplate.SpellEffects[6548] = new SingleTargetSpellEffect(MobSpells.OnCastRend);
			SpellTemplate.SpellEffects[3149] = new OnSelfSpellEffect(MobSpells.OnCastFuriousHowl);
			SpellTemplate.SpellEffects[12166] = new SingleTargetSpellEffect(MobSpells.OnCastMuscleTear);
			SpellTemplate.SpellEffects[5708] = new OnSelfSpellEffect(MobSpells.OnCastSwoop);
			SpellTemplate.SpellEffects[8014] = new SingleTargetSpellEffect(MobSpells.OnCastTetanus);
			SpellTemplate.SpellEffects[6268] = SpellTemplate.SpellEffects[8260] = new OnSelfSpellEffect(MobSpells.OnCastRushingCharge);
			SpellTemplate.SpellEffects[5568] = new OnSelfSpellEffect(MobSpells.OnCastTrample);
			SpellTemplate.SpellEffects[3242] = new SingleTargetSpellEffect(MobSpells.OnCastRavage);
			SpellTemplate.SpellEffects[1604] = SpellTemplate.SpellEffects[13496] = SpellTemplate.SpellEffects[15571] = new SingleTargetSpellEffect(MobSpells.OnCastDazed);
			SpellTemplate.SpellEffects[7127] = new SingleTargetSpellEffect(MobSpells.OnCastWaveringWill);
			#region HearthStone
			SpellTemplate.SpellEffects[8690]=new OnSelfSpellEffect( HearthStoneFunc.OnUse );
			#endregion
			#endregion
        }
	}
}