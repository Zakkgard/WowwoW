/**************************************************************
*
*		Made by fulgas (fulgas@gmail.com)
*
*  WowwoW Item Designer ( 2005/8/23 - 10:05:14 )
*
***************************************************************/

using System;
using System.Collections;

/***************************************************************/

/**************************************************************
*
*				(1000 Gold!)
*
***************************************************************/

namespace Server.Items
{
	public class _1000Gold : Item
	{
		public _1000Gold() : base()
		{
			Id = 7;
			SellPrice = 10000000;
			AvailableClasses = 0x7FFF;
			Description = "1000 Gold";
			Model = 11766;
			ObjectClass = 12;
			SubClass = 0;
			Name = "1000 Gold!";
			Name2 = "1000 Gold!";
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
		}
	}
}


/**************************************************************
*
*				(Garrick's Head)
*
***************************************************************/

namespace Server.Items
{
	public class GarricksHead : Item
	{
		public GarricksHead() : base()
		{
			Id = 182;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7038;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Garrick's Head";
			Name2 = "Garrick's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Gnoll Paw)
*
***************************************************************/

namespace Server.Items
{
	public class GnollPaw : Item
	{
		public GnollPaw() : base()
		{
			Id = 725;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6671;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gnoll Paw";
			Name2 = "Gnoll Paw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Rolf and Malakai's Medallions)
*
***************************************************************/

namespace Server.Items
{
	public class RolfAndMalakaisMedallions : Item
	{
		public RolfAndMalakaisMedallions() : base()
		{
			Id = 735;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rolf and Malakai's Medallions";
			Name2 = "Rolf and Malakai's Medallions";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Holy Spring Water)
*
***************************************************************/

namespace Server.Items
{
	public class HolySpringWater : Item
	{
		public HolySpringWater() : base()
		{
			Id = 737;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 926;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Holy Spring Water";
			Name2 = "Holy Spring Water";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 3591 , 0 , -1 , 300000 , 4 , 120000 );
		}
	}
}


/**************************************************************
*
*				(Sack of Barley)
*
***************************************************************/

namespace Server.Items
{
	public class SackOfBarley : Item
	{
		public SackOfBarley() : base()
		{
			Id = 738;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1297;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sack of Barley";
			Name2 = "Sack of Barley";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sack of Corn)
*
***************************************************************/

namespace Server.Items
{
	public class SackOfCorn : Item
	{
		public SackOfCorn() : base()
		{
			Id = 739;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11994;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sack of Corn";
			Name2 = "Sack of Corn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sack of Rye)
*
***************************************************************/

namespace Server.Items
{
	public class SackOfRye : Item
	{
		public SackOfRye() : base()
		{
			Id = 740;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11998;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sack of Rye";
			Name2 = "Sack of Rye";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(A Sycamore Branch)
*
***************************************************************/

namespace Server.Items
{
	public class ASycamoreBranch : Item
	{
		public ASycamoreBranch() : base()
		{
			Id = 742;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 928;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Sycamore Branch";
			Name2 = "A Sycamore Branch";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bundle of Charred Oak)
*
***************************************************************/

namespace Server.Items
{
	public class BundleOfCharredOak : Item
	{
		public BundleOfCharredOak() : base()
		{
			Id = 743;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 929;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bundle of Charred Oak";
			Name2 = "Bundle of Charred Oak";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
		}
	}
}


/**************************************************************
*
*				(Marshal McBride's Documents)
*
***************************************************************/

namespace Server.Items
{
	public class MarshalMcBridesDocuments : Item
	{
		public MarshalMcBridesDocuments() : base()
		{
			Id = 745;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1102;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Marshal McBride's Documents";
			Name2 = "Marshal McBride's Documents";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 209;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Stormwind Armor Marker)
*
***************************************************************/

namespace Server.Items
{
	public class StormwindArmorMarker : Item
	{
		public StormwindArmorMarker() : base()
		{
			Id = 748;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1102;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stormwind Armor Marker";
			Name2 = "Stormwind Armor Marker";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 78;
		}
	}
}


/**************************************************************
*
*				(Tough Wolf Meat)
*
***************************************************************/

namespace Server.Items
{
	public class ToughWolfMeat : Item
	{
		public ToughWolfMeat() : base()
		{
			Id = 750;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1116;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tough Wolf Meat";
			Name2 = "Tough Wolf Meats";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Red Burlap Bandana)
*
***************************************************************/

namespace Server.Items
{
	public class RedBurlapBandana : Item
	{
		public RedBurlapBandana() : base()
		{
			Id = 752;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1272;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Red Burlap Bandana";
			Name2 = "Red Burlap Bandana";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 7;
		}
	}
}


/**************************************************************
*
*				(Large Candle)
*
***************************************************************/

namespace Server.Items
{
	public class LargeCandle : Item
	{
		public LargeCandle() : base()
		{
			Id = 772;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7066;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Large Candle";
			Name2 = "Large Candle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gold Dust)
*
***************************************************************/

namespace Server.Items
{
	public class GoldDust : Item
	{
		public GoldDust() : base()
		{
			Id = 773;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7137;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gold Dust";
			Name2 = "Gold Dust";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Torn Murloc Fin)
*
***************************************************************/

namespace Server.Items
{
	public class TornMurlocFin : Item
	{
		public TornMurlocFin() : base()
		{
			Id = 780;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6628;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Torn Murloc Fin";
			Name2 = "Torn Murloc Fin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Painted Gnoll Armband)
*
***************************************************************/

namespace Server.Items
{
	public class PaintedGnollArmband : Item
	{
		public PaintedGnollArmband() : base()
		{
			Id = 782;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1329;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Painted Gnoll Armband";
			Name2 = "Painted Gnoll Armband";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 7;
		}
	}
}


/**************************************************************
*
*				(Red Leather Bandana)
*
***************************************************************/

namespace Server.Items
{
	public class RedLeatherBandana : Item
	{
		public RedLeatherBandana() : base()
		{
			Id = 829;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1272;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Red Leather Bandana";
			Name2 = "Red Leather Bandana";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Furlbrow's Pocket Watch)
*
***************************************************************/

namespace Server.Items
{
	public class FurlbrowsPocketWatch : Item
	{
		public FurlbrowsPocketWatch() : base()
		{
			Id = 841;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1270;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Furlbrow's Pocket Watch";
			Name2 = "Furlbrow's Pocket Watch";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ghoul Rib)
*
***************************************************************/

namespace Server.Items
{
	public class GhoulRib : Item
	{
		public GhoulRib() : base()
		{
			Id = 884;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6368;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ghoul Rib";
			Name2 = "Ghoul Rib";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(A Dusty Unsent Letter)
*
***************************************************************/

namespace Server.Items
{
	public class ADustyUnsentLetter : Item
	{
		public ADustyUnsentLetter() : base()
		{
			Id = 889;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "This dusty letter from long ago was never sent.";
			Model = 3022;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Dusty Unsent Letter";
			Name2 = "A Dusty Unsent Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 16;
		}
	}
}


/**************************************************************
*
*				(Worgen Skull)
*
***************************************************************/

namespace Server.Items
{
	public class WorgenSkull : Item
	{
		public WorgenSkull() : base()
		{
			Id = 895;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7103;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Worgen Skull";
			Name2 = "Worgen Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Worgen Fang)
*
***************************************************************/

namespace Server.Items
{
	public class WorgenFang : Item
	{
		public WorgenFang() : base()
		{
			Id = 896;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 959;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Worgen Fang";
			Name2 = "Worgen Fang";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(An Undelivered Letter)
*
***************************************************************/

namespace Server.Items
{
	public class AnUndeliveredLetter : Item
	{
		public AnUndeliveredLetter() : base()
		{
			Id = 910;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Weathered and old, this letter was never delivered.";
			Model = 3024;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "An Undelivered Letter";
			Name2 = "An Undelivered Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 18;
		}
	}
}


/**************************************************************
*
*				(Red Silk Bandana)
*
***************************************************************/

namespace Server.Items
{
	public class RedSilkBandana : Item
	{
		public RedSilkBandana() : base()
		{
			Id = 915;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1272;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Red Silk Bandana";
			Name2 = "Red Silk Bandana";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 7;
		}
	}
}


/**************************************************************
*
*				(A Torn Journal Page)
*
***************************************************************/

namespace Server.Items
{
	public class ATornJournalPage : Item
	{
		public ATornJournalPage() : base()
		{
			Id = 916;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Only the bottom half of this journal page remains.";
			Model = 7589;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Torn Journal Page";
			Name2 = "A Torn Journal Page";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 20;
		}
	}
}


/**************************************************************
*
*				(A Faded Journal Page)
*
***************************************************************/

namespace Server.Items
{
	public class AFadedJournalPage : Item
	{
		public AFadedJournalPage() : base()
		{
			Id = 921;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Although most of the text is long faded, some words can still be read.";
			Model = 7588;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Faded Journal Page";
			Name2 = "A Faded Journal Page";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 21;
		}
	}
}


/**************************************************************
*
*				(Muddy Journal Pages)
*
***************************************************************/

namespace Server.Items
{
	public class MuddyJournalPages : Item
	{
		public MuddyJournalPages() : base()
		{
			Id = 938;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Although the pages are covered in mud, some words can be read.";
			Model = 7601;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Muddy Journal Pages";
			Name2 = "Muddy Journal Pages";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 22;
		}
	}
}


/**************************************************************
*
*				(A Bloodstained Journal Page)
*
***************************************************************/

namespace Server.Items
{
	public class ABloodstainedJournalPage : Item
	{
		public ABloodstainedJournalPage() : base()
		{
			Id = 939;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Through thick blood a few words still remain legible.";
			Model = 7588;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Bloodstained Journal Page";
			Name2 = "A Bloodstained Journal Page";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 24;
		}
	}
}


/**************************************************************
*
*				(William's Shipment)
*
***************************************************************/

namespace Server.Items
{
	public class WilliamsShipment : Item
	{
		public WilliamsShipment() : base()
		{
			Id = 957;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "There is a note attached.";
			Model = 7286;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "William's Shipment";
			Name2 = "William's Shipment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 15;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Pork Belly Pie)
*
***************************************************************/

namespace Server.Items
{
	public class PorkBellyPie : Item
	{
		public PorkBellyPie() : base()
		{
			Id = 962;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6385;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pork Belly Pie";
			Name2 = "Pork Belly Pie";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bernice's Necklace)
*
***************************************************************/

namespace Server.Items
{
	public class BernicesNecklace : Item
	{
		public BernicesNecklace() : base()
		{
			Id = 981;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1399;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bernice's Necklace";
			Name2 = "Bernice's Necklace";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Brass Collar)
*
***************************************************************/

namespace Server.Items
{
	public class BrassCollar : Item
	{
		public BrassCollar() : base()
		{
			Id = 1006;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Princess - First Prize";
			Model = 224;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Brass Collar";
			Name2 = "Brass Collar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Iron Rivet)
*
***************************************************************/

namespace Server.Items
{
	public class IronRivet : Item
	{
		public IronRivet() : base()
		{
			Id = 1013;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1236;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Iron Rivet";
			Name2 = "Iron Rivet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Red Linen Bandana)
*
***************************************************************/

namespace Server.Items
{
	public class RedLinenBandana : Item
	{
		public RedLinenBandana() : base()
		{
			Id = 1019;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1272;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Red Linen Bandana";
			Name2 = "Red Linen Bandana";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 7;
		}
	}
}


/**************************************************************
*
*				(Shadowhide Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class ShadowhidePendant : Item
	{
		public ShadowhidePendant() : base()
		{
			Id = 1075;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7236;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shadowhide Pendant";
			Name2 = "Shadowhide Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Glyph of Azora)
*
***************************************************************/

namespace Server.Items
{
	public class GlyphOfAzora : Item
	{
		public GlyphOfAzora() : base()
		{
			Id = 1083;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7133;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glyph of Azora";
			Name2 = "Glyph of Azora";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ghoul Fang)
*
***************************************************************/

namespace Server.Items
{
	public class GhoulFang : Item
	{
		public GhoulFang() : base()
		{
			Id = 1129;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7129;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ghoul Fang";
			Name2 = "Ghoul Fang";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Vial of Spider Venom)
*
***************************************************************/

namespace Server.Items
{
	public class VialOfSpiderVenom : Item
	{
		public VialOfSpiderVenom() : base()
		{
			Id = 1130;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1288;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vial of Spider Venom";
			Name2 = "Vial of Spider Venom";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 3;
		}
	}
}


/**************************************************************
*
*				(Maybell's Love Letter)
*
***************************************************************/

namespace Server.Items
{
	public class MaybellsLoveLetter : Item
	{
		public MaybellsLoveLetter() : base()
		{
			Id = 1208;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2616;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Maybell's Love Letter";
			Name2 = "Maybell's Love Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 25;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Unknown Reward)
*
***************************************************************/

namespace Server.Items
{
	public class UnknownReward : Item
	{
		public UnknownReward() : base()
		{
			Id = 1217;
			AvailableClasses = 0x7FFF;
			Description = "It is not known what the reward will be...";
			Model = 7280;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Unknown Reward";
			Name2 = "Unknown Reward";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
		}
	}
}


/**************************************************************
*
*				(Underbelly Whelp Scale)
*
***************************************************************/

namespace Server.Items
{
	public class UnderbellyWhelpScale : Item
	{
		public UnderbellyWhelpScale() : base()
		{
			Id = 1221;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 568;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Underbelly Whelp Scale";
			Name2 = "Underbelly Whelp Scale";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Gramma Stonefield's Note)
*
***************************************************************/

namespace Server.Items
{
	public class GrammaStonefieldsNote : Item
	{
		public GrammaStonefieldsNote() : base()
		{
			Id = 1252;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2616;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gramma Stonefield's Note";
			Name2 = "Gramma Stonefield's Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 26;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Crystal Kelp Frond)
*
***************************************************************/

namespace Server.Items
{
	public class CrystalKelpFrond : Item
	{
		public CrystalKelpFrond() : base()
		{
			Id = 1256;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7078;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crystal Kelp Frond";
			Name2 = "Crystal Kelp Frond";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Invisibility Liquor)
*
***************************************************************/

namespace Server.Items
{
	public class InvisibilityLiquor : Item
	{
		public InvisibilityLiquor() : base()
		{
			Id = 1257;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1656;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Invisibility Liquor";
			Name2 = "Invisibility Liquor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tharil'zun's Head)
*
***************************************************************/

namespace Server.Items
{
	public class TharilzunsHead : Item
	{
		public TharilzunsHead() : base()
		{
			Id = 1260;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1310;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tharil'zun's Head";
			Name2 = "Tharil'zun's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Midnight Orb)
*
***************************************************************/

namespace Server.Items
{
	public class MidnightOrb : Item
	{
		public MidnightOrb() : base()
		{
			Id = 1261;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6009;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Midnight Orb";
			Name2 = "Midnight Orb";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Verner's Note)
*
***************************************************************/

namespace Server.Items
{
	public class VernersNote : Item
	{
		public VernersNote() : base()
		{
			Id = 1283;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 811;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Verner's Note";
			Name2 = "Verner's Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 28;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Crate of Horseshoes)
*
***************************************************************/

namespace Server.Items
{
	public class CrateOfHorseshoes : Item
	{
		public CrateOfHorseshoes() : base()
		{
			Id = 1284;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "There's a note attached to this crate.";
			Model = 7914;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crate of Horseshoes";
			Name2 = "Crate of Horseshoes";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 29;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(The State of Lakeshire)
*
***************************************************************/

namespace Server.Items
{
	public class TheStateOfLakeshire : Item
	{
		public TheStateOfLakeshire() : base()
		{
			Id = 1293;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Written by Magistrate Solomon, this report details the events unfolding in Redridge.";
			Model = 3034;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The State of Lakeshire";
			Name2 = "The State of Lakeshire";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 30;
		}
	}
}


/**************************************************************
*
*				(The General's Response)
*
***************************************************************/

namespace Server.Items
{
	public class TheGeneralsResponse : Item
	{
		public TheGeneralsResponse() : base()
		{
			Id = 1294;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "General Marcus Jonathan's response to Magistrate Solomon's plea for help.";
			Model = 3035;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The General's Response";
			Name2 = "The General's Response";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 36;
		}
	}
}


/**************************************************************
*
*				(Gold Pickup Schedule)
*
***************************************************************/

namespace Server.Items
{
	public class GoldPickupSchedule : Item
	{
		public GoldPickupSchedule() : base()
		{
			Id = 1307;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 811;
			ObjectClass = 12;
			SubClass = 0;
			Level = 7;
			ReqLevel = 7;
			Name = "Gold Pickup Schedule";
			Name2 = "Gold Pickup Schedule";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 123;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Oslow's Toolbox)
*
***************************************************************/

namespace Server.Items
{
	public class OslowsToolbox : Item
	{
		public OslowsToolbox() : base()
		{
			Id = 1309;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12334;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Oslow's Toolbox";
			Name2 = "Oslow's Toolbox";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Daffodil Bouquet)
*
***************************************************************/

namespace Server.Items
{
	public class DaffodilBouquet : Item
	{
		public DaffodilBouquet() : base()
		{
			Id = 1325;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6524;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Daffodil Bouquet";
			Name2 = "Daffodil Bouquet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Wiley's Note)
*
***************************************************************/

namespace Server.Items
{
	public class WileysNote : Item
	{
		public WileysNote() : base()
		{
			Id = 1327;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "A hastily written note written by Wiley the Black for Gryan Stoutmantle.";
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wiley's Note";
			Name2 = "Wiley's Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 38;
		}
	}
}


/**************************************************************
*
*				(Abercrombie's Crate)
*
***************************************************************/

namespace Server.Items
{
	public class AbercrombiesCrate : Item
	{
		public AbercrombiesCrate() : base()
		{
			Id = 1349;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "This large crate is sealed tight, but it reeks of dead things.";
			Model = 7918;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Abercrombie's Crate";
			Name2 = "Abercrombie's Crate";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Shaw's Report)
*
***************************************************************/

namespace Server.Items
{
	public class ShawsReport : Item
	{
		public ShawsReport() : base()
		{
			Id = 1353;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Shaw's report on the Stonemason Guild for Gryan Stoutmantle.";
			Model = 3031;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shaw's Report";
			Name2 = "Shaw's Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 41;
		}
	}
}


/**************************************************************
*
*				(Captain Sander's Treasure Map)
*
***************************************************************/

namespace Server.Items
{
	public class CaptainSandersTreasureMap : Item
	{
		public CaptainSandersTreasureMap() : base()
		{
			Id = 1357;
			AvailableClasses = 0x7FFF;
			Description = "The waterlogged parchment is about to disintegrate.";
			Model = 1322;
			ObjectClass = 12;
			SubClass = 0;
			Level = 10;
			ReqLevel = 10;
			Name = "Captain Sander's Treasure Map";
			Name2 = "Captain Sander's Treasure Map";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 136;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(A Clue to Sander's Treasure)
*
***************************************************************/

namespace Server.Items
{
	public class AClueToSandersTreasure : Item
	{
		public AClueToSandersTreasure() : base()
		{
			Id = 1358;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "This torn piece of parchment contains scribbled writing.";
			Model = 7593;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Clue to Sander's Treasure";
			Name2 = "A Clue to Sander's Treasure";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 45;
		}
	}
}


/**************************************************************
*
*				(Another Clue to Sander's Treasure)
*
***************************************************************/

namespace Server.Items
{
	public class AnotherClueToSandersTreasure : Item
	{
		public AnotherClueToSandersTreasure() : base()
		{
			Id = 1361;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "This torn piece of parchment contains scribbled writing.";
			Model = 7594;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Another Clue to Sander's Treasure";
			Name2 = "Another Clue to Sander's Treasure";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 46;
		}
	}
}


/**************************************************************
*
*				(Final Clue to Sander's Treasure)
*
***************************************************************/

namespace Server.Items
{
	public class FinalClueToSandersTreasure : Item
	{
		public FinalClueToSandersTreasure() : base()
		{
			Id = 1362;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "This torn piece of parchment contains scribbled writing.";
			Model = 7595;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Final Clue to Sander's Treasure";
			Name2 = "Final Clue to Sander's Treasure";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 47;
		}
	}
}


/**************************************************************
*
*				(A Mysterious Message)
*
***************************************************************/

namespace Server.Items
{
	public class AMysteriousMessage : Item
	{
		public AMysteriousMessage() : base()
		{
			Id = 1381;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "This soot-covered note contains some cryptic text.";
			Model = 3023;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Mysterious Message";
			Name2 = "A Mysterious Message";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 48;
		}
	}
}


/**************************************************************
*
*				(Solomon's Plea to Westfall)
*
***************************************************************/

namespace Server.Items
{
	public class SolomonsPleaToWestfall : Item
	{
		public SolomonsPleaToWestfall() : base()
		{
			Id = 1407;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3032;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Solomon's Plea to Westfall";
			Name2 = "Solomon's Plea to Westfall";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 49;
		}
	}
}


/**************************************************************
*
*				(Stoutmantle's Response to Solomon)
*
***************************************************************/

namespace Server.Items
{
	public class StoutmantlesResponseToSolomon : Item
	{
		public StoutmantlesResponseToSolomon() : base()
		{
			Id = 1408;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3033;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stoutmantle's Response to Solomon";
			Name2 = "Stoutmantle's Response to Solomon";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 50;
		}
	}
}


/**************************************************************
*
*				(Solomon's Plea to Darkshire)
*
***************************************************************/

namespace Server.Items
{
	public class SolomonsPleaToDarkshire : Item
	{
		public SolomonsPleaToDarkshire() : base()
		{
			Id = 1409;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3032;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Solomon's Plea to Darkshire";
			Name2 = "Solomon's Plea to Darkshire";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 51;
		}
	}
}


/**************************************************************
*
*				(Ebonlocke's Response to Solomon)
*
***************************************************************/

namespace Server.Items
{
	public class EbonlockesResponseToSolomon : Item
	{
		public EbonlockesResponseToSolomon() : base()
		{
			Id = 1410;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3032;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ebonlocke's Response to Solomon";
			Name2 = "Ebonlocke's Response to Solomon";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 52;
		}
	}
}


/**************************************************************
*
*				(Bottle of Zombie Juice)
*
***************************************************************/

namespace Server.Items
{
	public class BottleOfZombieJuice : Item
	{
		public BottleOfZombieJuice() : base()
		{
			Id = 1451;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1249;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bottle of Zombie Juice";
			Name2 = "Bottle of Zombie Juice";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Spectral Comb)
*
***************************************************************/

namespace Server.Items
{
	public class SpectralComb : Item
	{
		public SpectralComb() : base()
		{
			Id = 1453;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9825;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Spectral Comb";
			Name2 = "Spectral Comb";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 3;
		}
	}
}


/**************************************************************
*
*				(Spotted Sunfish)
*
***************************************************************/

namespace Server.Items
{
	public class SpottedSunfish : Item
	{
		public SpottedSunfish() : base()
		{
			Id = 1467;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1361;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Spotted Sunfish";
			Name2 = "Spotted Sunfish";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ghost Hair Comb)
*
***************************************************************/

namespace Server.Items
{
	public class GhostHairComb : Item
	{
		public GhostHairComb() : base()
		{
			Id = 1518;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9825;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ghost Hair Comb";
			Name2 = "Ghost Hair Comb";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 3;
		}
	}
}


/**************************************************************
*
*				(Bloodscalp Ear)
*
***************************************************************/

namespace Server.Items
{
	public class BloodscalpEar : Item
	{
		public BloodscalpEar() : base()
		{
			Id = 1519;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1438;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodscalp Ear";
			Name2 = "Bloodscalp Ear";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Skullsplitter Tusk)
*
***************************************************************/

namespace Server.Items
{
	public class SkullsplitterTusk : Item
	{
		public SkullsplitterTusk() : base()
		{
			Id = 1524;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 959;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Skullsplitter Tusk";
			Name2 = "Skullsplitter Tusk";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Handful of Oats)
*
***************************************************************/

namespace Server.Items
{
	public class HandfulOfOats : Item
	{
		public HandfulOfOats() : base()
		{
			Id = 1528;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1443;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Handful of Oats";
			Name2 = "Handful of Oats";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Shrunken Head)
*
***************************************************************/

namespace Server.Items
{
	public class ShrunkenHead : Item
	{
		public ShrunkenHead() : base()
		{
			Id = 1532;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7104;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shrunken Head";
			Name2 = "Shrunken Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ghost Hair Thread)
*
***************************************************************/

namespace Server.Items
{
	public class GhostHairThread : Item
	{
		public GhostHairThread() : base()
		{
			Id = 1596;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18096;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ghost Hair Thread";
			Name2 = "Ghost Hair Thread";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Rot Blossom)
*
***************************************************************/

namespace Server.Items
{
	public class RotBlossom : Item
	{
		public RotBlossom() : base()
		{
			Id = 1598;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1464;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rot Blossom";
			Name2 = "Rot Blossom";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Letter to Ello)
*
***************************************************************/

namespace Server.Items
{
	public class LetterToEllo : Item
	{
		public LetterToEllo() : base()
		{
			Id = 1637;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1102;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Letter to Ello";
			Name2 = "Letter to Ello";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 53;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Translated Letter)
*
***************************************************************/

namespace Server.Items
{
	public class TranslatedLetter : Item
	{
		public TranslatedLetter() : base()
		{
			Id = 1656;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1102;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Translated Letter";
			Name2 = "Translated Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 54;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Thistlenettle's Badge)
*
***************************************************************/

namespace Server.Items
{
	public class ThistlenettlesBadge : Item
	{
		public ThistlenettlesBadge() : base()
		{
			Id = 1875;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Foreman Thistlenettle - Member of the Explorers' League";
			Model = 8604;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thistlenettle's Badge";
			Name2 = "Thistlenettle's Badge";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Miners' Union Card)
*
***************************************************************/

namespace Server.Items
{
	public class MinersUnionCard : Item
	{
		public MinersUnionCard() : base()
		{
			Id = 1894;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3029;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Miners' Union Card";
			Name2 = "Miners' Union Card";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Supplies for Sven)
*
***************************************************************/

namespace Server.Items
{
	public class SuppliesForSven : Item
	{
		public SuppliesForSven() : base()
		{
			Id = 1922;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "A bundle of miscellaneous supplies for Sven.";
			Model = 1283;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Supplies for Sven";
			Name2 = "Supplies for Sven";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ambassador's Satchel)
*
***************************************************************/

namespace Server.Items
{
	public class AmbassadorsSatchel : Item
	{
		public AmbassadorsSatchel() : base()
		{
			Id = 1923;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1625;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ambassador's Satchel";
			Name2 = "Ambassador's Satchel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Huge Gnoll Claw)
*
***************************************************************/

namespace Server.Items
{
	public class HugeGnollClaw : Item
	{
		public HugeGnollClaw() : base()
		{
			Id = 1931;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1645;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Huge Gnoll Claw";
			Name2 = "Huge Gnoll Claw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Skin of Sweet Rum)
*
***************************************************************/

namespace Server.Items
{
	public class SkinOfSweetRum : Item
	{
		public SkinOfSweetRum() : base()
		{
			Id = 1939;
			Bonding = 4;
			SellPrice = 168;
			AvailableClasses = 0x7FFF;
			Model = 18084;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Skin of Sweet Rum";
			Name2 = "Skin of Sweet Rum";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 675;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Cask of Merlot)
*
***************************************************************/

namespace Server.Items
{
	public class CaskOfMerlot : Item
	{
		public CaskOfMerlot() : base()
		{
			Id = 1941;
			Bonding = 4;
			SellPrice = 203;
			AvailableClasses = 0x7FFF;
			Model = 8383;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cask of Merlot";
			Name2 = "Cask of Merlot";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 815;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
		}
	}
}


/**************************************************************
*
*				(Bottle of Moonshine)
*
***************************************************************/

namespace Server.Items
{
	public class BottleOfMoonshine : Item
	{
		public BottleOfMoonshine() : base()
		{
			Id = 1942;
			Bonding = 4;
			SellPrice = 316;
			AvailableClasses = 0x7FFF;
			Model = 18080;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bottle of Moonshine";
			Name2 = "Bottle of Moonshine";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1265;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 3;
		}
	}
}


/**************************************************************
*
*				(Mary's Looking Glass)
*
***************************************************************/

namespace Server.Items
{
	public class MarysLookingGlass : Item
	{
		public MarysLookingGlass() : base()
		{
			Id = 1946;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20919;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mary's Looking Glass";
			Name2 = "Mary's Looking Glass";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Faded Shadowhide Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class FadedShadowhidePendant : Item
	{
		public FadedShadowhidePendant() : base()
		{
			Id = 1956;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The spell on this pendant has faded.";
			Model = 7236;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Faded Shadowhide Pendant";
			Name2 = "Faded Shadowhide Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Glowing Shadowhide Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class GlowingShadowhidePendant : Item
	{
		public GlowingShadowhidePendant() : base()
		{
			Id = 1962;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "This pendant glows with magic.";
			Model = 6565;
			ObjectClass = 12;
			SubClass = 0;
			Level = 15;
			ReqLevel = 15;
			Name = "Glowing Shadowhide Pendant";
			Name2 = "Glowing Shadowhide Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 178;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ogre's Monocle)
*
***************************************************************/

namespace Server.Items
{
	public class OgresMonocle : Item
	{
		public OgresMonocle() : base()
		{
			Id = 1968;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1695;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ogre's Monocle";
			Name2 = "Ogre's Monocle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Furlbrow's Deed)
*
***************************************************************/

namespace Server.Items
{
	public class FurlbrowsDeed : Item
	{
		public FurlbrowsDeed() : base()
		{
			Id = 1971;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7128;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Furlbrow's Deed";
			Name2 = "Furlbrow's Deed";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 55;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Westfall Deed)
*
***************************************************************/

namespace Server.Items
{
	public class WestfallDeed : Item
	{
		public WestfallDeed() : base()
		{
			Id = 1972;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 924;
			ObjectClass = 12;
			SubClass = 0;
			Level = 8;
			ReqLevel = 8;
			Name = "Westfall Deed";
			Name2 = "Westfall Deed";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 184;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Krazek's Fixed Pot)
*
***************************************************************/

namespace Server.Items
{
	public class KrazeksFixedPot : Item
	{
		public KrazeksFixedPot() : base()
		{
			Id = 1987;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "An improved pot, with extra whistles and choppers.";
			Model = 7155;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Krazek's Fixed Pot";
			Name2 = "Krazek's Fixed Pot";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
			Sheath = 1;
		}
	}
}


/**************************************************************
*
*				(Grelin Whitebeard's Journal)
*
***************************************************************/

namespace Server.Items
{
	public class GrelinWhitebeardsJournal : Item
	{
		public GrelinWhitebeardsJournal() : base()
		{
			Id = 2004;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7138;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Grelin Whitebeard's Journal";
			Name2 = "Grelin Whitebeard's Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 74;
		}
	}
}


/**************************************************************
*
*				(The First Troll Legend)
*
***************************************************************/

namespace Server.Items
{
	public class TheFirstTrollLegend : Item
	{
		public TheFirstTrollLegend() : base()
		{
			Id = 2005;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Moon over the Vale";
			Model = 7270;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The First Troll Legend";
			Name2 = "The First Troll Legend";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 58;
		}
	}
}


/**************************************************************
*
*				(The Second Troll Legend)
*
***************************************************************/

namespace Server.Items
{
	public class TheSecondTrollLegend : Item
	{
		public TheSecondTrollLegend() : base()
		{
			Id = 2006;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Gri'lek the Wanderer";
			Model = 7270;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The Second Troll Legend";
			Name2 = "The Second Troll Legend";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 285;
		}
	}
}


/**************************************************************
*
*				(The Third Troll Legend)
*
***************************************************************/

namespace Server.Items
{
	public class TheThirdTrollLegend : Item
	{
		public TheThirdTrollLegend() : base()
		{
			Id = 2007;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Fall of Gurubashi";
			Model = 7270;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The Third Troll Legend";
			Name2 = "The Third Troll Legend";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 324;
		}
	}
}


/**************************************************************
*
*				(The Fourth Troll Legend)
*
***************************************************************/

namespace Server.Items
{
	public class TheFourthTrollLegend : Item
	{
		public TheFourthTrollLegend() : base()
		{
			Id = 2008;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The Emperor's Tomb";
			Model = 7270;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The Fourth Troll Legend";
			Name2 = "The Fourth Troll Legend";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 62;
		}
	}
}


/**************************************************************
*
*				(Calor's Note)
*
***************************************************************/

namespace Server.Items
{
	public class CalorsNote : Item
	{
		public CalorsNote() : base()
		{
			Id = 2113;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 924;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Calor's Note";
			Name2 = "Calor's Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 63;
		}
	}
}


/**************************************************************
*
*				(Book from Sven's Farm)
*
***************************************************************/

namespace Server.Items
{
	public class BookFromSvensFarm : Item
	{
		public BookFromSvensFarm() : base()
		{
			Id = 2161;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1143;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Book from Sven's Farm";
			Name2 = "Book from Sven's Farm";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 73;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Sarah's Ring)
*
***************************************************************/

namespace Server.Items
{
	public class SarahsRing : Item
	{
		public SarahsRing() : base()
		{
			Id = 2162;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Sarah Ladimore's ring.";
			Model = 963;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sarah's Ring";
			Name2 = "Sarah's Ring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(A Stack of Letters)
*
***************************************************************/

namespace Server.Items
{
	public class AStackOfLetters : Item
	{
		public AStackOfLetters() : base()
		{
			Id = 2187;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3019;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Stack of Letters";
			Name2 = "A Stack of Letters";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(A Letter to Grelin Whitebeard)
*
***************************************************************/

namespace Server.Items
{
	public class ALetterToGrelinWhitebeard : Item
	{
		public ALetterToGrelinWhitebeard() : base()
		{
			Id = 2188;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3020;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Letter to Grelin Whitebeard";
			Name2 = "A Letter to Grelin Whitebeard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 80;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(The Collector's Schedule)
*
***************************************************************/

namespace Server.Items
{
	public class TheCollectorsSchedule : Item
	{
		public TheCollectorsSchedule() : base()
		{
			Id = 2223;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1102;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The Collector's Schedule";
			Name2 = "The Collector's Schedule";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 79;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(The Collector's Ring)
*
***************************************************************/

namespace Server.Items
{
	public class TheCollectorsRing : Item
	{
		public TheCollectorsRing() : base()
		{
			Id = 2239;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Engraved with the words 'For years of service: -EVC.'";
			Model = 2854;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The Collector's Ring";
			Name2 = "The Collector's Ring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Dusky Crab Cakes)
*
***************************************************************/

namespace Server.Items
{
	public class DuskyCrabCakes : Item
	{
		public DuskyCrabCakes() : base()
		{
			Id = 2250;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7113;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dusky Crab Cakes";
			Name2 = "Dusky Crab Cakes";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Miscellaneous Goblin Supplies)
*
***************************************************************/

namespace Server.Items
{
	public class MiscellaneousGoblinSupplies : Item
	{
		public MiscellaneousGoblinSupplies() : base()
		{
			Id = 2252;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "A crate of miscellaneous supplies addressed to Private Thorsen.";
			Model = 7167;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Miscellaneous Goblin Supplies";
			Name2 = "Miscellaneous Goblin Supplies";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Skeleton Finger)
*
***************************************************************/

namespace Server.Items
{
	public class SkeletonFinger : Item
	{
		public SkeletonFinger() : base()
		{
			Id = 2378;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7251;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Skeleton Finger";
			Name2 = "Skeleton Finger";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(The Embalmer's Heart)
*
***************************************************************/

namespace Server.Items
{
	public class TheEmbalmersHeart : Item
	{
		public TheEmbalmersHeart() : base()
		{
			Id = 2382;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7269;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The Embalmer's Heart";
			Name2 = "The Embalmer's Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Skullsplitter Fetish)
*
***************************************************************/

namespace Server.Items
{
	public class SkullsplitterFetish : Item
	{
		public SkullsplitterFetish() : base()
		{
			Id = 2466;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6368;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Skullsplitter Fetish";
			Name2 = "Skullsplitter Fetish";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Chilled Basilisk Haunch)
*
***************************************************************/

namespace Server.Items
{
	public class ChilledBasiliskHaunch : Item
	{
		public ChilledBasiliskHaunch() : base()
		{
			Id = 2476;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2376;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Chilled Basilisk Haunch";
			Name2 = "Chilled Basilisk Haunch";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ravager's Skull)
*
***************************************************************/

namespace Server.Items
{
	public class RavagersSkull : Item
	{
		public RavagersSkull() : base()
		{
			Id = 2477;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23527;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ravager's Skull";
			Name2 = "Ravager's Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 4;
		}
	}
}


/**************************************************************
*
*				(Trogg Stone Tooth)
*
***************************************************************/

namespace Server.Items
{
	public class TroggStoneTooth : Item
	{
		public TroggStoneTooth() : base()
		{
			Id = 2536;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6630;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Trogg Stone Tooth";
			Name2 = "Trogg Stone Tooth";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Barrel of Barleybrew Scalder)
*
***************************************************************/

namespace Server.Items
{
	public class BarrelOfBarleybrewScalder : Item
	{
		public BarrelOfBarleybrewScalder() : base()
		{
			Id = 2548;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7922;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Barrel of Barleybrew Scalder";
			Name2 = "Barrel of Barleybrew Scalder";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Jitters' Completed Journal)
*
***************************************************************/

namespace Server.Items
{
	public class JittersCompletedJournal : Item
	{
		public JittersCompletedJournal() : base()
		{
			Id = 2560;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1143;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jitters' Completed Journal";
			Name2 = "Jitters' Completed Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 85;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Chok'sul's Head)
*
***************************************************************/

namespace Server.Items
{
	public class ChoksulsHead : Item
	{
		public ChoksulsHead() : base()
		{
			Id = 2561;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1310;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Chok'sul's Head";
			Name2 = "Chok'sul's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Strange Smelling Powder)
*
***************************************************************/

namespace Server.Items
{
	public class StrangeSmellingPowder : Item
	{
		public StrangeSmellingPowder() : base()
		{
			Id = 2563;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6396;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Strange Smelling Powder";
			Name2 = "Strange Smelling Powder";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Lurker Venom)
*
***************************************************************/

namespace Server.Items
{
	public class LurkerVenom : Item
	{
		public LurkerVenom() : base()
		{
			Id = 2606;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2515;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lurker Venom";
			Name2 = "Lurker Venom";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mo'grosh Crystal)
*
***************************************************************/

namespace Server.Items
{
	public class MogroshCrystal : Item
	{
		public MogroshCrystal() : base()
		{
			Id = 2607;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2516;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mo'grosh Crystal";
			Name2 = "Mo'grosh Crystal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Disarming Colloid)
*
***************************************************************/

namespace Server.Items
{
	public class DisarmingColloid : Item
	{
		public DisarmingColloid() : base()
		{
			Id = 2609;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2637;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Disarming Colloid";
			Name2 = "Disarming Colloid";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Disarming Mixture)
*
***************************************************************/

namespace Server.Items
{
	public class DisarmingMixture : Item
	{
		public DisarmingMixture() : base()
		{
			Id = 2610;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6396;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Disarming Mixture";
			Name2 = "Disarming Mixture";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crude Flint)
*
***************************************************************/

namespace Server.Items
{
	public class CrudeFlint : Item
	{
		public CrudeFlint() : base()
		{
			Id = 2611;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18107;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crude Flint";
			Name2 = "Crude Flint";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Grelin's Report)
*
***************************************************************/

namespace Server.Items
{
	public class GrelinsReport : Item
	{
		public GrelinsReport() : base()
		{
			Id = 2619;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3029;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Grelin's Report";
			Name2 = "Grelin's Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 86;
		}
	}
}


/**************************************************************
*
*				(Menethil Statuette)
*
***************************************************************/

namespace Server.Items
{
	public class MenethilStatuette : Item
	{
		public MenethilStatuette() : base()
		{
			Id = 2625;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12931;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Menethil Statuette";
			Name2 = "Menethil Statuette";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Senir's Report)
*
***************************************************************/

namespace Server.Items
{
	public class SenirsReport : Item
	{
		public SenirsReport() : base()
		{
			Id = 2628;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3048;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Senir's Report";
			Name2 = "Senir's Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 88;
		}
	}
}


/**************************************************************
*
*				(Venom Fern Extract)
*
***************************************************************/

namespace Server.Items
{
	public class VenomFernExtract : Item
	{
		public VenomFernExtract() : base()
		{
			Id = 2634;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7283;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Venom Fern Extract";
			Name2 = "Venom Fern Extract";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = 7;
		}
	}
}


/**************************************************************
*
*				(Carved Stone Idol)
*
***************************************************************/

namespace Server.Items
{
	public class CarvedStoneIdol : Item
	{
		public CarvedStoneIdol() : base()
		{
			Id = 2636;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2551;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Carved Stone Idol";
			Name2 = "Carved Stone Idol";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ironband's Progress Report)
*
***************************************************************/

namespace Server.Items
{
	public class IronbandsProgressReport : Item
	{
		public IronbandsProgressReport() : base()
		{
			Id = 2637;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 924;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ironband's Progress Report";
			Name2 = "Ironband's Progress Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 182;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Merrin's Letter)
*
***************************************************************/

namespace Server.Items
{
	public class MerrinsLetter : Item
	{
		public MerrinsLetter() : base()
		{
			Id = 2639;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2571;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Merrin's Letter";
			Name2 = "Merrin's Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 92;
		}
	}
}


/**************************************************************
*
*				(Miners' Gear)
*
***************************************************************/

namespace Server.Items
{
	public class MinersGear : Item
	{
		public MinersGear() : base()
		{
			Id = 2640;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7166;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Miners' Gear";
			Name2 = "Miners' Gear";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Ados Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class AdosFragment : Item
	{
		public AdosFragment() : base()
		{
			Id = 2658;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18103;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ados Fragment";
			Name2 = "Ados Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Modr Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class ModrFragment : Item
	{
		public ModrFragment() : base()
		{
			Id = 2659;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18105;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Modr Fragment";
			Name2 = "Modr Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Golm Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class GolmFragment : Item
	{
		public GolmFragment() : base()
		{
			Id = 2660;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18104;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Golm Fragment";
			Name2 = "Golm Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Neru Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class NeruFragment : Item
	{
		public NeruFragment() : base()
		{
			Id = 2661;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18106;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Neru Fragment";
			Name2 = "Neru Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Barrel of Thunder Ale)
*
***************************************************************/

namespace Server.Items
{
	public class BarrelOfThunderAle : Item
	{
		public BarrelOfThunderAle() : base()
		{
			Id = 2666;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7923;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Barrel of Thunder Ale";
			Name2 = "Barrel of Thunder Ale";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(MacGrann's Dried Meats)
*
***************************************************************/

namespace Server.Items
{
	public class MacGrannsDriedMeats : Item
	{
		public MacGrannsDriedMeats() : base()
		{
			Id = 2667;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2599;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "MacGrann's Dried Meats";
			Name2 = "MacGrann's Dried Meats";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Wendigo Mane)
*
***************************************************************/

namespace Server.Items
{
	public class WendigoMane : Item
	{
		public WendigoMane() : base()
		{
			Id = 2671;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6655;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wendigo Mane";
			Name2 = "Wendigo Mane";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Shimmerweed)
*
***************************************************************/

namespace Server.Items
{
	public class Shimmerweed : Item
	{
		public Shimmerweed() : base()
		{
			Id = 2676;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7241;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shimmerweed";
			Name2 = "Shimmerweed";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Cask of Evershine)
*
***************************************************************/

namespace Server.Items
{
	public class CaskOfEvershine : Item
	{
		public CaskOfEvershine() : base()
		{
			Id = 2696;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7922;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cask of Evershine";
			Name2 = "Cask of Evershine";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Lightforge Ingot)
*
***************************************************************/

namespace Server.Items
{
	public class LightforgeIngot : Item
	{
		public LightforgeIngot() : base()
		{
			Id = 2702;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7158;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lightforge Ingot";
			Name2 = "Lightforge Ingot";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crate of Lightforge Ingots)
*
***************************************************************/

namespace Server.Items
{
	public class CrateOfLightforgeIngots : Item
	{
		public CrateOfLightforgeIngots() : base()
		{
			Id = 2712;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7916;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crate of Lightforge Ingots";
			Name2 = "Crate of Lightforge Ingots";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ol' Sooty's Head)
*
***************************************************************/

namespace Server.Items
{
	public class OlSootysHead : Item
	{
		public OlSootysHead() : base()
		{
			Id = 2713;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 28952;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ol' Sooty's Head";
			Name2 = "Ol' Sooty's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Muddy Note)
*
***************************************************************/

namespace Server.Items
{
	public class MuddyNote : Item
	{
		public MuddyNote() : base()
		{
			Id = 2720;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1102;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Muddy Note";
			Name2 = "Muddy Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 311;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Wine Ticket)
*
***************************************************************/

namespace Server.Items
{
	public class WineTicket : Item
	{
		public WineTicket() : base()
		{
			Id = 2722;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1102;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wine Ticket";
			Name2 = "Wine Ticket";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Cloth Request)
*
***************************************************************/

namespace Server.Items
{
	public class ClothRequest : Item
	{
		public ClothRequest() : base()
		{
			Id = 2724;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1323;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cloth Request";
			Name2 = "Cloth Request";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 336;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 1)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage1 : Item
	{
		public GreenHillsOfStranglethornPage1() : base()
		{
			Id = 2725;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 1";
			Name2 = "Green Hills of Stranglethorn - Page 1";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 95;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 4)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage4 : Item
	{
		public GreenHillsOfStranglethornPage4() : base()
		{
			Id = 2728;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 4";
			Name2 = "Green Hills of Stranglethorn - Page 4";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 98;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 6)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage6 : Item
	{
		public GreenHillsOfStranglethornPage6() : base()
		{
			Id = 2730;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 6";
			Name2 = "Green Hills of Stranglethorn - Page 6";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 100;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 8)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage8 : Item
	{
		public GreenHillsOfStranglethornPage8() : base()
		{
			Id = 2732;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 8";
			Name2 = "Green Hills of Stranglethorn - Page 8";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 102;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 10)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage10 : Item
	{
		public GreenHillsOfStranglethornPage10() : base()
		{
			Id = 2734;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 10";
			Name2 = "Green Hills of Stranglethorn - Page 10";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 104;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 11)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage11 : Item
	{
		public GreenHillsOfStranglethornPage11() : base()
		{
			Id = 2735;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 11";
			Name2 = "Green Hills of Stranglethorn - Page 11";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 105;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 14)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage14 : Item
	{
		public GreenHillsOfStranglethornPage14() : base()
		{
			Id = 2738;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 14";
			Name2 = "Green Hills of Stranglethorn - Page 14";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 108;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 16)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage16 : Item
	{
		public GreenHillsOfStranglethornPage16() : base()
		{
			Id = 2740;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 16";
			Name2 = "Green Hills of Stranglethorn - Page 16";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 110;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 18)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage18 : Item
	{
		public GreenHillsOfStranglethornPage18() : base()
		{
			Id = 2742;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 18";
			Name2 = "Green Hills of Stranglethorn - Page 18";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 112;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 20)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage20 : Item
	{
		public GreenHillsOfStranglethornPage20() : base()
		{
			Id = 2744;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 20";
			Name2 = "Green Hills of Stranglethorn - Page 20";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 114;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 21)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage21 : Item
	{
		public GreenHillsOfStranglethornPage21() : base()
		{
			Id = 2745;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 21";
			Name2 = "Green Hills of Stranglethorn - Page 21";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 115;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 24)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage24 : Item
	{
		public GreenHillsOfStranglethornPage24() : base()
		{
			Id = 2748;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 24";
			Name2 = "Green Hills of Stranglethorn - Page 24";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 118;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 25)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage25 : Item
	{
		public GreenHillsOfStranglethornPage25() : base()
		{
			Id = 2749;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 25";
			Name2 = "Green Hills of Stranglethorn - Page 25";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 119;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 26)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage26 : Item
	{
		public GreenHillsOfStranglethornPage26() : base()
		{
			Id = 2750;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 26";
			Name2 = "Green Hills of Stranglethorn - Page 26";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 120;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Page 27)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornPage27 : Item
	{
		public GreenHillsOfStranglethornPage27() : base()
		{
			Id = 2751;
			SellPrice = 375;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Page 27";
			Name2 = "Green Hills of Stranglethorn - Page 27";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1500;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			PageText = 121;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Chapter I)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornChapterI : Item
	{
		public GreenHillsOfStranglethornChapterI() : base()
		{
			Id = 2756;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7596;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Chapter I";
			Name2 = "Green Hills of Stranglethorn - Chapter I";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 153;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Chapter II)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornChapterII : Item
	{
		public GreenHillsOfStranglethornChapterII() : base()
		{
			Id = 2757;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7596;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Chapter II";
			Name2 = "Green Hills of Stranglethorn - Chapter II";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 161;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Chapter III)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornChapterIII : Item
	{
		public GreenHillsOfStranglethornChapterIII() : base()
		{
			Id = 2758;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7596;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Chapter III";
			Name2 = "Green Hills of Stranglethorn - Chapter III";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 169;
		}
	}
}


/**************************************************************
*
*				(Green Hills of Stranglethorn - Chapter IV)
*
***************************************************************/

namespace Server.Items
{
	public class GreenHillsOfStranglethornChapterIV : Item
	{
		public GreenHillsOfStranglethornChapterIV() : base()
		{
			Id = 2759;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7596;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Hills of Stranglethorn - Chapter IV";
			Name2 = "Green Hills of Stranglethorn - Chapter IV";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			PageText = 177;
		}
	}
}


/**************************************************************
*
*				(Thurman's Sewing Kit)
*
***************************************************************/

namespace Server.Items
{
	public class ThurmansSewingKit : Item
	{
		public ThurmansSewingKit() : base()
		{
			Id = 2760;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6430;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thurman's Sewing Kit";
			Name2 = "Thurman's Sewing Kit";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Tear of Tilloa)
*
***************************************************************/

namespace Server.Items
{
	public class TearOfTilloa : Item
	{
		public TearOfTilloa() : base()
		{
			Id = 2779;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2788;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tear of Tilloa";
			Name2 = "Tear of Tilloa";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Musquash Root)
*
***************************************************************/

namespace Server.Items
{
	public class MusquashRoot : Item
	{
		public MusquashRoot() : base()
		{
			Id = 2784;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2793;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Musquash Root";
			Name2 = "Musquash Root";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Black Claw Stout)
*
***************************************************************/

namespace Server.Items
{
	public class BlackClawStout : Item
	{
		public BlackClawStout() : base()
		{
			Id = 2788;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18115;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Black Claw Stout";
			Name2 = "Black Claw Stout";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(An Old History Book)
*
***************************************************************/

namespace Server.Items
{
	public class AnOldHistoryBook : Item
	{
		public AnOldHistoryBook() : base()
		{
			Id = 2794;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 1143;
			ObjectClass = 12;
			SubClass = 0;
			Level = 20;
			ReqLevel = 20;
			Name = "An Old History Book";
			Name2 = "An Old History Book";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 337;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Book: Stresses of Iron)
*
***************************************************************/

namespace Server.Items
{
	public class BookStressesOfIron : Item
	{
		public BookStressesOfIron() : base()
		{
			Id = 2795;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1143;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Book: Stresses of Iron";
			Name2 = "Book: Stresses of Iron";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Heart of Mokk)
*
***************************************************************/

namespace Server.Items
{
	public class HeartOfMokk : Item
	{
		public HeartOfMokk() : base()
		{
			Id = 2797;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3422;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Heart of Mokk";
			Name2 = "Heart of Mokk";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Rethban Ore)
*
***************************************************************/

namespace Server.Items
{
	public class RethbanOre : Item
	{
		public RethbanOre() : base()
		{
			Id = 2798;
			AvailableClasses = 0x7FFF;
			Model = 4689;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rethban Ore";
			Name2 = "Rethban Ore";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Gorilla Fang)
*
***************************************************************/

namespace Server.Items
{
	public class GorillaFang : Item
	{
		public GorillaFang() : base()
		{
			Id = 2799;
			SellPrice = 67;
			AvailableClasses = 0x7FFF;
			Model = 7129;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gorilla Fang";
			Name2 = "Gorilla Fang";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 270;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Package for Stormpike)
*
***************************************************************/

namespace Server.Items
{
	public class PackageForStormpike : Item
	{
		public PackageForStormpike() : base()
		{
			Id = 2806;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1244;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Package for Stormpike";
			Name2 = "Package for Stormpike";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Nissa's Remains)
*
***************************************************************/

namespace Server.Items
{
	public class NissasRemains : Item
	{
		public NissasRemains() : base()
		{
			Id = 2828;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7105;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nissa's Remains";
			Name2 = "Nissa's Remains";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Gregor's Remains)
*
***************************************************************/

namespace Server.Items
{
	public class GregorsRemains : Item
	{
		public GregorsRemains() : base()
		{
			Id = 2829;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2853;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gregor's Remains";
			Name2 = "Gregor's Remains";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Thurman's Remains)
*
***************************************************************/

namespace Server.Items
{
	public class ThurmansRemains : Item
	{
		public ThurmansRemains() : base()
		{
			Id = 2830;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2853;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thurman's Remains";
			Name2 = "Thurman's Remains";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Devlin's Remains)
*
***************************************************************/

namespace Server.Items
{
	public class DevlinsRemains : Item
	{
		public DevlinsRemains() : base()
		{
			Id = 2831;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2853;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Devlin's Remains";
			Name2 = "Devlin's Remains";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Verna's Westfall Stew Recipe)
*
***************************************************************/

namespace Server.Items
{
	public class VernasWestfallStewRecipe : Item
	{
		public VernasWestfallStewRecipe() : base()
		{
			Id = 2832;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 811;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Verna's Westfall Stew Recipe";
			Name2 = "Verna's Westfall Stew Recipe";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 213;
		}
	}
}


/**************************************************************
*
*				(The Lich's Spellbook)
*
***************************************************************/

namespace Server.Items
{
	public class TheLichsSpellbook : Item
	{
		public TheLichsSpellbook() : base()
		{
			Id = 2833;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7139;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The Lich's Spellbook";
			Name2 = "The Lich's Spellbook";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Embalming Ichor)
*
***************************************************************/

namespace Server.Items
{
	public class EmbalmingIchor : Item
	{
		public EmbalmingIchor() : base()
		{
			Id = 2834;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3152;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Embalming Ichor";
			Name2 = "Embalming Ichor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Thurman's Letter)
*
***************************************************************/

namespace Server.Items
{
	public class ThurmansLetter : Item
	{
		public ThurmansLetter() : base()
		{
			Id = 2837;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 924;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thurman's Letter";
			Name2 = "Thurman's Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 214;
		}
	}
}


/**************************************************************
*
*				(A Letter to Yvette)
*
***************************************************************/

namespace Server.Items
{
	public class ALetterToYvette : Item
	{
		public ALetterToYvette() : base()
		{
			Id = 2839;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 924;
			ObjectClass = 12;
			SubClass = 0;
			Level = 4;
			ReqLevel = 4;
			Name = "A Letter to Yvette";
			Name2 = "A Letter to Yvette";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 361;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Dirty Knucklebones)
*
***************************************************************/

namespace Server.Items
{
	public class DirtyKnucklebones : Item
	{
		public DirtyKnucklebones() : base()
		{
			Id = 2843;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18074;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dirty Knucklebones";
			Name2 = "Dirty Knucklebones";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tirisfal Pumpkin)
*
***************************************************************/

namespace Server.Items
{
	public class TirisfalPumpkin : Item
	{
		public TirisfalPumpkin() : base()
		{
			Id = 2846;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3225;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tirisfal Pumpkin";
			Name2 = "Tirisfal Pumpkin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Putrid Claw)
*
***************************************************************/

namespace Server.Items
{
	public class PutridClaw : Item
	{
		public PutridClaw() : base()
		{
			Id = 2855;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7207;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Putrid Claw";
			Name2 = "Putrid Claw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Iron Pike)
*
***************************************************************/

namespace Server.Items
{
	public class IronPike : Item
	{
		public IronPike() : base()
		{
			Id = 2856;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2868;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Iron Pike";
			Name2 = "Iron Pike";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Darkhound Blood)
*
***************************************************************/

namespace Server.Items
{
	public class DarkhoundBlood : Item
	{
		public DarkhoundBlood() : base()
		{
			Id = 2858;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2873;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Darkhound Blood";
			Name2 = "Darkhound Blood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Vile Fin Scale)
*
***************************************************************/

namespace Server.Items
{
	public class VileFinScale : Item
	{
		public VileFinScale() : base()
		{
			Id = 2859;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2874;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vile Fin Scale";
			Name2 = "Vile Fin Scale";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Vicious Night Web Spider Venom)
*
***************************************************************/

namespace Server.Items
{
	public class ViciousNightWebSpiderVenom : Item
	{
		public ViciousNightWebSpiderVenom() : base()
		{
			Id = 2872;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2885;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vicious Night Web Spider Venom";
			Name2 = "Vicious Night Web Spider Venom";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(An Unsent Letter)
*
***************************************************************/

namespace Server.Items
{
	public class AnUnsentLetter : Item
	{
		public AnUnsentLetter() : base()
		{
			Id = 2874;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "A letter found on Edwin VanCleef's person.";
			Model = 3020;
			ObjectClass = 12;
			SubClass = 0;
			Level = 16;
			ReqLevel = 16;
			Name = "An Unsent Letter";
			Name2 = "An Unsent Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 373;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Scarlet Insignia Ring)
*
***************************************************************/

namespace Server.Items
{
	public class ScarletInsigniaRing : Item
	{
		public ScarletInsigniaRing() : base()
		{
			Id = 2875;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11990;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scarlet Insignia Ring";
			Name2 = "Scarlet Insignia Ring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Duskbat Pelt)
*
***************************************************************/

namespace Server.Items
{
	public class DuskbatPelt : Item
	{
		public DuskbatPelt() : base()
		{
			Id = 2876;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6660;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Duskbat Pelt";
			Name2 = "Duskbat Pelt";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Scarlet Crusade Documents)
*
***************************************************************/

namespace Server.Items
{
	public class ScarletCrusadeDocuments : Item
	{
		public ScarletCrusadeDocuments() : base()
		{
			Id = 2885;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3048;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scarlet Crusade Documents";
			Name2 = "Scarlet Crusade Documents";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 223;
		}
	}
}


/**************************************************************
*
*				(Letter to Baros)
*
***************************************************************/

namespace Server.Items
{
	public class LetterToBaros : Item
	{
		public LetterToBaros() : base()
		{
			Id = 2891;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3021;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Letter to Baros";
			Name2 = "Letter to Baros";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 215;
		}
	}
}


/**************************************************************
*
*				(Red Wool Bandana)
*
***************************************************************/

namespace Server.Items
{
	public class RedWoolBandana : Item
	{
		public RedWoolBandana() : base()
		{
			Id = 2909;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2925;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Red Wool Bandana";
			Name2 = "Red Wool Bandana";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crocolisk Skin)
*
***************************************************************/

namespace Server.Items
{
	public class CrocoliskSkin : Item
	{
		public CrocoliskSkin() : base()
		{
			Id = 2925;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3124;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crocolisk Skin";
			Name2 = "Crocolisk Skin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Head of Bazil Thredd)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfBazilThredd : Item
	{
		public HeadOfBazilThredd() : base()
		{
			Id = 2926;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7038;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Bazil Thredd";
			Name2 = "Head of Bazil Thredd";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Crocolisk Tear)
*
***************************************************************/

namespace Server.Items
{
	public class CrocoliskTear : Item
	{
		public CrocoliskTear() : base()
		{
			Id = 2939;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3004;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crocolisk Tear";
			Name2 = "Crocolisk Tear";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Report on the Defias Brotherhood)
*
***************************************************************/

namespace Server.Items
{
	public class ReportOnTheDefiasBrotherhood : Item
	{
		public ReportOnTheDefiasBrotherhood() : base()
		{
			Id = 2956;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3031;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Report on the Defias Brotherhood";
			Name2 = "Report on the Defias Brotherhood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 219;
		}
	}
}


/**************************************************************
*
*				(A Simple Compass)
*
***************************************************************/

namespace Server.Items
{
	public class ASimpleCompass : Item
	{
		public ASimpleCompass() : base()
		{
			Id = 2998;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Baros Alexston's first compass.";
			Model = 6562;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Simple Compass";
			Name2 = "A Simple Compass";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Steelgrill's Tools)
*
***************************************************************/

namespace Server.Items
{
	public class SteelgrillsTools : Item
	{
		public SteelgrillsTools() : base()
		{
			Id = 2999;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7259;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Steelgrill's Tools";
			Name2 = "Steelgrill's Tools";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Battleworn Axe)
*
***************************************************************/

namespace Server.Items
{
	public class BattlewornAxe : Item
	{
		public BattlewornAxe() : base()
		{
			Id = 3014;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7040;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Battleworn Axe";
			Name2 = "Battleworn Axe";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gunther's Spellbook)
*
***************************************************************/

namespace Server.Items
{
	public class GunthersSpellbook : Item
	{
		public GunthersSpellbook() : base()
		{
			Id = 3016;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7139;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gunther's Spellbook";
			Name2 = "Gunther's Spellbook";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sevren's Orders)
*
***************************************************************/

namespace Server.Items
{
	public class SevrensOrders : Item
	{
		public SevrensOrders() : base()
		{
			Id = 3017;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 811;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sevren's Orders";
			Name2 = "Sevren's Orders";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 244;
		}
	}
}


/**************************************************************
*
*				(Laced Pumpkin)
*
***************************************************************/

namespace Server.Items
{
	public class LacedPumpkin : Item
	{
		public LacedPumpkin() : base()
		{
			Id = 3035;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3225;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Laced Pumpkin";
			Name2 = "Laced Pumpkin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Candle of Beckoning)
*
***************************************************************/

namespace Server.Items
{
	public class CandleOfBeckoning : Item
	{
		public CandleOfBeckoning() : base()
		{
			Id = 3080;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7066;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Candle of Beckoning";
			Name2 = "Candle of Beckoning";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Nether Gem)
*
***************************************************************/

namespace Server.Items
{
	public class NetherGem : Item
	{
		public NetherGem() : base()
		{
			Id = 3081;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7185;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nether Gem";
			Name2 = "Nether Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dargol's Skull)
*
***************************************************************/

namespace Server.Items
{
	public class DargolsSkull : Item
	{
		public DargolsSkull() : base()
		{
			Id = 3082;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2853;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dargol's Skull";
			Name2 = "Dargol's Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Restabilization Cog)
*
***************************************************************/

namespace Server.Items
{
	public class RestabilizationCog : Item
	{
		public RestabilizationCog() : base()
		{
			Id = 3083;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7215;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Restabilization Cog";
			Name2 = "Restabilization Cog";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gyromechanic Gear)
*
***************************************************************/

namespace Server.Items
{
	public class GyromechanicGear : Item
	{
		public GyromechanicGear() : base()
		{
			Id = 3084;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7072;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gyromechanic Gear";
			Name2 = "Gyromechanic Gear";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Barrel of Shimmer Stout)
*
***************************************************************/

namespace Server.Items
{
	public class BarrelOfShimmerStout : Item
	{
		public BarrelOfShimmerStout() : base()
		{
			Id = 3085;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7922;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Barrel of Shimmer Stout";
			Name2 = "Barrel of Shimmer Stout";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Cask of Shimmer Stout)
*
***************************************************************/

namespace Server.Items
{
	public class CaskOfShimmerStout : Item
	{
		public CaskOfShimmerStout() : base()
		{
			Id = 3086;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7922;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cask of Shimmer Stout";
			Name2 = "Cask of Shimmer Stout";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Tunnel Rat Ear)
*
***************************************************************/

namespace Server.Items
{
	public class TunnelRatEar : Item
	{
		public TunnelRatEar() : base()
		{
			Id = 3110;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7723;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tunnel Rat Ear";
			Name2 = "Tunnel Rat Ear";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Hildelve's Journal)
*
***************************************************************/

namespace Server.Items
{
	public class HildelvesJournal : Item
	{
		public HildelvesJournal() : base()
		{
			Id = 3117;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7138;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hildelve's Journal";
			Name2 = "Hildelve's Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 229;
		}
	}
}


/**************************************************************
*
*				(Remedy of Arugal)
*
***************************************************************/

namespace Server.Items
{
	public class RemedyOfArugal : Item
	{
		public RemedyOfArugal() : base()
		{
			Id = 3155;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "This aging scroll is written in the indecipherable language of the Kirin Tor.";
			Model = 3331;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Remedy of Arugal";
			Name2 = "Remedy of Arugal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Glutton Shackle)
*
***************************************************************/

namespace Server.Items
{
	public class GluttonShackle : Item
	{
		public GluttonShackle() : base()
		{
			Id = 3156;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7132;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glutton Shackle";
			Name2 = "Glutton Shackle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Darksoul Shackle)
*
***************************************************************/

namespace Server.Items
{
	public class DarksoulShackle : Item
	{
		public DarksoulShackle() : base()
		{
			Id = 3157;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7083;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Darksoul Shackle";
			Name2 = "Darksoul Shackle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Notched Rib)
*
***************************************************************/

namespace Server.Items
{
	public class NotchedRib : Item
	{
		public NotchedRib() : base()
		{
			Id = 3162;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3233;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Notched Rib";
			Name2 = "Notched Rib";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Blackened Skull)
*
***************************************************************/

namespace Server.Items
{
	public class BlackenedSkull : Item
	{
		public BlackenedSkull() : base()
		{
			Id = 3163;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2853;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blackened Skull";
			Name2 = "Blackened Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Quinn's Potion)
*
***************************************************************/

namespace Server.Items
{
	public class QuinnsPotion : Item
	{
		public QuinnsPotion() : base()
		{
			Id = 3165;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 983;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Quinn's Potion";
			Name2 = "Quinn's Potion";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mangy Claw)
*
***************************************************************/

namespace Server.Items
{
	public class MangyClaw : Item
	{
		public MangyClaw() : base()
		{
			Id = 3183;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6669;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mangy Claw";
			Name2 = "Mangy Claw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Pyrewood Shackle)
*
***************************************************************/

namespace Server.Items
{
	public class PyrewoodShackle : Item
	{
		public PyrewoodShackle() : base()
		{
			Id = 3218;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7208;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pyrewood Shackle";
			Name2 = "Pyrewood Shackle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Deliah's Ring)
*
***************************************************************/

namespace Server.Items
{
	public class DeliahsRing : Item
	{
		public DeliahsRing() : base()
		{
			Id = 3234;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 963;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Deliah's Ring";
			Name2 = "Deliah's Ring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Rot Hide Ichor)
*
***************************************************************/

namespace Server.Items
{
	public class RotHideIchor : Item
	{
		public RotHideIchor() : base()
		{
			Id = 3236;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3152;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rot Hide Ichor";
			Name2 = "Rot Hide Ichor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sample Ichor)
*
***************************************************************/

namespace Server.Items
{
	public class SampleIchor : Item
	{
		public SampleIchor() : base()
		{
			Id = 3237;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3152;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sample Ichor";
			Name2 = "Sample Ichor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Johaan's Findings)
*
***************************************************************/

namespace Server.Items
{
	public class JohaansFindings : Item
	{
		public JohaansFindings() : base()
		{
			Id = 3238;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The sealed findings of Apothecary Johaan.";
			Model = 3411;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Johaan's Findings";
			Name2 = "Johaan's Findings";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Translated Letter from The Embalmer)
*
***************************************************************/

namespace Server.Items
{
	public class TranslatedLetterFromTheEmbalmer : Item
	{
		public TranslatedLetterFromTheEmbalmer() : base()
		{
			Id = 3248;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1102;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Translated Letter from The Embalmer";
			Name2 = "Translated Letter from The Embalmer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 235;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Bethor's Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class BethorsScroll : Item
	{
		public BethorsScroll() : base()
		{
			Id = 3250;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1301;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bethor's Scroll";
			Name2 = "Bethor's Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Bethor's Potion)
*
***************************************************************/

namespace Server.Items
{
	public class BethorsPotion : Item
	{
		public BethorsPotion() : base()
		{
			Id = 3251;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 8452;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bethor's Potion";
			Name2 = "Bethor's Potion";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Sheath = 1;
			Flags = 64;
			SetSpell( 7669 , 0 , -10 , 30000 , 4 , 0 );
		}
	}
}


/**************************************************************
*
*				(Deathstalker Report)
*
***************************************************************/

namespace Server.Items
{
	public class DeathstalkerReport : Item
	{
		public DeathstalkerReport() : base()
		{
			Id = 3252;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3029;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Deathstalker Report";
			Name2 = "Deathstalker Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 380;
		}
	}
}


/**************************************************************
*
*				(Grizzled Bear Heart)
*
***************************************************************/

namespace Server.Items
{
	public class GrizzledBearHeart : Item
	{
		public GrizzledBearHeart() : base()
		{
			Id = 3253;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3422;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Grizzled Bear Heart";
			Name2 = "Grizzled Bear Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Skittering Blood)
*
***************************************************************/

namespace Server.Items
{
	public class SkitteringBlood : Item
	{
		public SkitteringBlood() : base()
		{
			Id = 3254;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2885;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Skittering Blood";
			Name2 = "Skittering Blood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Berard's Journal)
*
***************************************************************/

namespace Server.Items
{
	public class BerardsJournal : Item
	{
		public BerardsJournal() : base()
		{
			Id = 3255;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3426;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Berard's Journal";
			Name2 = "Berard's Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 236;
		}
	}
}


/**************************************************************
*
*				(Lake Skulker Moss)
*
***************************************************************/

namespace Server.Items
{
	public class LakeSkulkerMoss : Item
	{
		public LakeSkulkerMoss() : base()
		{
			Id = 3256;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3427;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lake Skulker Moss";
			Name2 = "Lake Skulker Moss";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Lake Creeper Moss)
*
***************************************************************/

namespace Server.Items
{
	public class LakeCreeperMoss : Item
	{
		public LakeCreeperMoss() : base()
		{
			Id = 3257;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3427;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lake Creeper Moss";
			Name2 = "Lake Creeper Moss";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Hardened Tumor)
*
***************************************************************/

namespace Server.Items
{
	public class HardenedTumor : Item
	{
		public HardenedTumor() : base()
		{
			Id = 3258;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 5283;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hardened Tumor";
			Name2 = "Hardened Tumor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Duskbat Wing)
*
***************************************************************/

namespace Server.Items
{
	public class DuskbatWing : Item
	{
		public DuskbatWing() : base()
		{
			Id = 3264;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11489;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Duskbat Wing";
			Name2 = "Duskbat Wing";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Scavenger Paw)
*
***************************************************************/

namespace Server.Items
{
	public class ScavengerPaw : Item
	{
		public ScavengerPaw() : base()
		{
			Id = 3265;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6669;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scavenger Paw";
			Name2 = "Scavenger Paw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Scarlet Armband)
*
***************************************************************/

namespace Server.Items
{
	public class ScarletArmband : Item
	{
		public ScarletArmband() : base()
		{
			Id = 3266;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3433;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scarlet Armband";
			Name2 = "Scarlet Armband";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fel Moss)
*
***************************************************************/

namespace Server.Items
{
	public class FelMoss : Item
	{
		public FelMoss() : base()
		{
			Id = 3297;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3427;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fel Moss";
			Name2 = "Fel Moss";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(A Talking Head)
*
***************************************************************/

namespace Server.Items
{
	public class ATalkingHead : Item
	{
		public ATalkingHead() : base()
		{
			Id = 3317;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "Its lips are moving!";
			Model = 3486;
			ObjectClass = 12;
			SubClass = 0;
			Level = 12;
			ReqLevel = 12;
			Name = "A Talking Head";
			Name2 = "A Talking Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 460;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Alaric's Remains)
*
***************************************************************/

namespace Server.Items
{
	public class AlaricsRemains : Item
	{
		public AlaricsRemains() : base()
		{
			Id = 3318;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3487;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Alaric's Remains";
			Name2 = "Alaric's Remains";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dragonmaw War Banner)
*
***************************************************************/

namespace Server.Items
{
	public class DragonmawWarBanner : Item
	{
		public DragonmawWarBanner() : base()
		{
			Id = 3337;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7111;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dragonmaw War Banner";
			Name2 = "Dragonmaw War Banner";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dwarven Tinder)
*
***************************************************************/

namespace Server.Items
{
	public class DwarvenTinder : Item
	{
		public DwarvenTinder() : base()
		{
			Id = 3339;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6371;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dwarven Tinder";
			Name2 = "Dwarven Tinder";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bundle of Crocolisk Skins)
*
***************************************************************/

namespace Server.Items
{
	public class BundleOfCrocoliskSkins : Item
	{
		public BundleOfCrocoliskSkins() : base()
		{
			Id = 3347;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 568;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bundle of Crocolisk Skins";
			Name2 = "Bundle of Crocolisk Skins";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Giant Crocolisk Skin)
*
***************************************************************/

namespace Server.Items
{
	public class GiantCrocoliskSkin : Item
	{
		public GiantCrocoliskSkin() : base()
		{
			Id = 3348;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6646;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Giant Crocolisk Skin";
			Name2 = "Giant Crocolisk Skin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sida's Bag)
*
***************************************************************/

namespace Server.Items
{
	public class SidasBag : Item
	{
		public SidasBag() : base()
		{
			Id = 3349;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "It's dripping.";
			Model = 3565;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sida's Bag";
			Name2 = "Sida's Bag";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Rune-inscribed Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class RuneInscribedPendant : Item
	{
		public RuneInscribedPendant() : base()
		{
			Id = 3353;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6502;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rune-inscribed Pendant";
			Name2 = "Rune-inscribed Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dalaran Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class DalaranPendant : Item
	{
		public DalaranPendant() : base()
		{
			Id = 3354;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6502;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dalaran Pendant";
			Name2 = "Dalaran Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Young Crocolisk Skin)
*
***************************************************************/

namespace Server.Items
{
	public class YoungCrocoliskSkin : Item
	{
		public YoungCrocoliskSkin() : base()
		{
			Id = 3397;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Young Crocolisk Skin";
			Name2 = "Young Crocolisk Skin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Raven Claw Talisman)
*
***************************************************************/

namespace Server.Items
{
	public class RavenClawTalisman : Item
	{
		public RavenClawTalisman() : base()
		{
			Id = 3405;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7210;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Raven Claw Talisman";
			Name2 = "Raven Claw Talisman";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Black Feather Quill)
*
***************************************************************/

namespace Server.Items
{
	public class BlackFeatherQuill : Item
	{
		public BlackFeatherQuill() : base()
		{
			Id = 3406;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19567;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Black Feather Quill";
			Name2 = "Black Feather Quill";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sapphire of Sky)
*
***************************************************************/

namespace Server.Items
{
	public class SapphireOfSky : Item
	{
		public SapphireOfSky() : base()
		{
			Id = 3407;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1659;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sapphire of Sky";
			Name2 = "Sapphire of Sky";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Rune of Nesting)
*
***************************************************************/

namespace Server.Items
{
	public class RuneOfNesting : Item
	{
		public RuneOfNesting() : base()
		{
			Id = 3408;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7217;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rune of Nesting";
			Name2 = "Rune of Nesting";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Nightsaber Fang)
*
***************************************************************/

namespace Server.Items
{
	public class NightsaberFang : Item
	{
		public NightsaberFang() : base()
		{
			Id = 3409;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7186;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nightsaber Fang";
			Name2 = "Nightsaber Fang";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Strigid Owl Feather)
*
***************************************************************/

namespace Server.Items
{
	public class StrigidOwlFeather : Item
	{
		public StrigidOwlFeather() : base()
		{
			Id = 3411;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19528;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Strigid Owl Feather";
			Name2 = "Strigid Owl Feather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Webwood Spider Silk)
*
***************************************************************/

namespace Server.Items
{
	public class WebwoodSpiderSilk : Item
	{
		public WebwoodSpiderSilk() : base()
		{
			Id = 3412;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18597;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Webwood Spider Silk";
			Name2 = "Webwood Spider Silk";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fel Cone)
*
***************************************************************/

namespace Server.Items
{
	public class FelCone : Item
	{
		public FelCone() : base()
		{
			Id = 3418;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7287;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fel Cone";
			Name2 = "Fel Cone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Woven Wand)
*
***************************************************************/

namespace Server.Items
{
	public class WovenWand : Item
	{
		public WovenWand() : base()
		{
			Id = 3425;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7292;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Woven Wand";
			Name2 = "Woven Wand";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Johaan's Special Drink)
*
***************************************************************/

namespace Server.Items
{
	public class JohaansSpecialDrink : Item
	{
		public JohaansSpecialDrink() : base()
		{
			Id = 3460;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18115;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Johaan's Special Drink";
			Name2 = "Johaan's Special Drink";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Renferrel's Findings)
*
***************************************************************/

namespace Server.Items
{
	public class RenferrelsFindings : Item
	{
		public RenferrelsFindings() : base()
		{
			Id = 3468;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The sealed findings of Apothecary Renferrel.";
			Model = 3411;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Renferrel's Findings";
			Name2 = "Renferrel's Findings";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gray Bear Tongue)
*
***************************************************************/

namespace Server.Items
{
	public class GrayBearTongue : Item
	{
		public GrayBearTongue() : base()
		{
			Id = 3476;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20898;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gray Bear Tongue";
			Name2 = "Gray Bear Tongue";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Creeper Ichor)
*
***************************************************************/

namespace Server.Items
{
	public class CreeperIchor : Item
	{
		public CreeperIchor() : base()
		{
			Id = 3477;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2885;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Creeper Ichor";
			Name2 = "Creeper Ichor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Elixir of Suffering)
*
***************************************************************/

namespace Server.Items
{
	public class ElixirOfSuffering : Item
	{
		public ElixirOfSuffering() : base()
		{
			Id = 3495;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3788;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Elixir of Suffering";
			Name2 = "Elixir of Suffering";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mountain Lion Blood)
*
***************************************************************/

namespace Server.Items
{
	public class MountainLionBlood : Item
	{
		public MountainLionBlood() : base()
		{
			Id = 3496;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16452;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mountain Lion Blood";
			Name2 = "Mountain Lion Blood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Elixir of Pain)
*
***************************************************************/

namespace Server.Items
{
	public class ElixirOfPain : Item
	{
		public ElixirOfPain() : base()
		{
			Id = 3497;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3788;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Elixir of Pain";
			Name2 = "Elixir of Pain";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Taretha's Necklace)
*
***************************************************************/

namespace Server.Items
{
	public class TarethasNecklace : Item
	{
		public TarethasNecklace() : base()
		{
			Id = 3498;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "A crescent moon dangling from a silver chain.";
			Model = 9657;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Taretha's Necklace";
			Name2 = "Taretha's Necklace";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mudsnout Blossoms)
*
***************************************************************/

namespace Server.Items
{
	public class MudsnoutBlossoms : Item
	{
		public MudsnoutBlossoms() : base()
		{
			Id = 3502;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17459;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mudsnout Blossoms";
			Name2 = "Mudsnout Blossoms";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Alterac Signet Ring)
*
***************************************************************/

namespace Server.Items
{
	public class AlteracSignetRing : Item
	{
		public AlteracSignetRing() : base()
		{
			Id = 3505;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6012;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Alterac Signet Ring";
			Name2 = "Alterac Signet Ring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mudsnout Composite)
*
***************************************************************/

namespace Server.Items
{
	public class MudsnoutComposite : Item
	{
		public MudsnoutComposite() : base()
		{
			Id = 3506;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7171;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mudsnout Composite";
			Name2 = "Mudsnout Composite";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mudsnout Mixture)
*
***************************************************************/

namespace Server.Items
{
	public class MudsnoutMixture : Item
	{
		public MudsnoutMixture() : base()
		{
			Id = 3508;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7175;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mudsnout Mixture";
			Name2 = "Mudsnout Mixture";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Daggerspine Scale)
*
***************************************************************/

namespace Server.Items
{
	public class DaggerspineScale : Item
	{
		public DaggerspineScale() : base()
		{
			Id = 3509;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7043;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Daggerspine Scale";
			Name2 = "Daggerspine Scale";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Torn Fin Eye)
*
***************************************************************/

namespace Server.Items
{
	public class TornFinEye : Item
	{
		public TornFinEye() : base()
		{
			Id = 3510;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7110;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Torn Fin Eye";
			Name2 = "Torn Fin Eye";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mor'Ladim's Skull)
*
***************************************************************/

namespace Server.Items
{
	public class MorLadimsSkull : Item
	{
		public MorLadimsSkull() : base()
		{
			Id = 3514;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2853;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mor'Ladim's Skull";
			Name2 = "Mor'Ladim's Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ataeric's Staff)
*
***************************************************************/

namespace Server.Items
{
	public class AtaericsStaff : Item
	{
		public AtaericsStaff() : base()
		{
			Id = 3515;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7030;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ataeric's Staff";
			Name2 = "Ataeric's Staff";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Lescovar's Head)
*
***************************************************************/

namespace Server.Items
{
	public class LescovarsHead : Item
	{
		public LescovarsHead() : base()
		{
			Id = 3516;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7038;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lescovar's Head";
			Name2 = "Lescovar's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Keg of Shindigger Stout)
*
***************************************************************/

namespace Server.Items
{
	public class KegOfShindiggerStout : Item
	{
		public KegOfShindiggerStout() : base()
		{
			Id = 3517;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7921;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Keg of Shindigger Stout";
			Name2 = "Keg of Shindigger Stout";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Decrypted Letter)
*
***************************************************************/

namespace Server.Items
{
	public class DecryptedLetter : Item
	{
		public DecryptedLetter() : base()
		{
			Id = 3518;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1096;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Decrypted Letter";
			Name2 = "Decrypted Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 7;
			PageText = 248;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Tainted Keg)
*
***************************************************************/

namespace Server.Items
{
	public class TaintedKeg : Item
	{
		public TaintedKeg() : base()
		{
			Id = 3520;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7921;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tainted Keg";
			Name2 = "Tainted Keg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Cleverly Encrypted Letter)
*
***************************************************************/

namespace Server.Items
{
	public class CleverlyEncryptedLetter : Item
	{
		public CleverlyEncryptedLetter() : base()
		{
			Id = 3521;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "This letter is encrypted and indecipherable.";
			Model = 1323;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cleverly Encrypted Letter";
			Name2 = "Cleverly Encrypted Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
		}
	}
}


/**************************************************************
*
*				(Targ's Head)
*
***************************************************************/

namespace Server.Items
{
	public class TargsHead : Item
	{
		public TargsHead() : base()
		{
			Id = 3550;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1310;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Targ's Head";
			Name2 = "Targ's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Muckrake's Head)
*
***************************************************************/

namespace Server.Items
{
	public class MuckrakesHead : Item
	{
		public MuckrakesHead() : base()
		{
			Id = 3551;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1310;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Muckrake's Head";
			Name2 = "Muckrake's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Glommus's Head)
*
***************************************************************/

namespace Server.Items
{
	public class GlommussHead : Item
	{
		public GlommussHead() : base()
		{
			Id = 3552;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1310;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glommus's Head";
			Name2 = "Glommus's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Mug'thol's Head)
*
***************************************************************/

namespace Server.Items
{
	public class MugtholsHead : Item
	{
		public MugtholsHead() : base()
		{
			Id = 3553;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1310;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mug'thol's Head";
			Name2 = "Mug'thol's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Crown of Will)
*
***************************************************************/

namespace Server.Items
{
	public class CrownOfWill : Item
	{
		public CrownOfWill() : base()
		{
			Id = 3554;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7077;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crown of Will";
			Name2 = "Crown of Will";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Shipment of Iron)
*
***************************************************************/

namespace Server.Items
{
	public class ShipmentOfIron : Item
	{
		public ShipmentOfIron() : base()
		{
			Id = 3564;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7924;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shipment of Iron";
			Name2 = "Shipment of Iron";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Syndicate Missive)
*
***************************************************************/

namespace Server.Items
{
	public class SyndicateMissive : Item
	{
		public SyndicateMissive() : base()
		{
			Id = 3601;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7263;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Syndicate Missive";
			Name2 = "Syndicate Missive";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 249;
		}
	}
}


/**************************************************************
*
*				(Valdred's Hands)
*
***************************************************************/

namespace Server.Items
{
	public class ValdredsHands : Item
	{
		public ValdredsHands() : base()
		{
			Id = 3613;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7282;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Valdred's Hands";
			Name2 = "Valdred's Hands";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Yowler's Paw)
*
***************************************************************/

namespace Server.Items
{
	public class YowlersPaw : Item
	{
		public YowlersPaw() : base()
		{
			Id = 3614;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6669;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Yowler's Paw";
			Name2 = "Yowler's Paw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Kurzen's Head)
*
***************************************************************/

namespace Server.Items
{
	public class KurzensHead : Item
	{
		public KurzensHead() : base()
		{
			Id = 3615;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7038;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kurzen's Head";
			Name2 = "Kurzen's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Mind's Eye)
*
***************************************************************/

namespace Server.Items
{
	public class MindsEye : Item
	{
		public MindsEye() : base()
		{
			Id = 3616;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6521;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mind's Eye";
			Name2 = "Mind's Eye";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Pendant of Shadow)
*
***************************************************************/

namespace Server.Items
{
	public class PendantOfShadow : Item
	{
		public PendantOfShadow() : base()
		{
			Id = 3617;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7197;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pendant of Shadow";
			Name2 = "Pendant of Shadow";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Gobbler's Head)
*
***************************************************************/

namespace Server.Items
{
	public class GobblersHead : Item
	{
		public GobblersHead() : base()
		{
			Id = 3618;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7135;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gobbler's Head";
			Name2 = "Gobbler's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Snellig's Snuffbox)
*
***************************************************************/

namespace Server.Items
{
	public class SnelligsSnuffbox : Item
	{
		public SnelligsSnuffbox() : base()
		{
			Id = 3619;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9515;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Snellig's Snuffbox";
			Name2 = "Snellig's Snuffbox";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ivar's Head)
*
***************************************************************/

namespace Server.Items
{
	public class IvarsHead : Item
	{
		public IvarsHead() : base()
		{
			Id = 3621;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7150;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ivar's Head";
			Name2 = "Ivar's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Essence of Nightlash)
*
***************************************************************/

namespace Server.Items
{
	public class EssenceOfNightlash : Item
	{
		public EssenceOfNightlash() : base()
		{
			Id = 3622;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6371;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Essence of Nightlash";
			Name2 = "Essence of Nightlash";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Thule's Head)
*
***************************************************************/

namespace Server.Items
{
	public class ThulesHead : Item
	{
		public ThulesHead() : base()
		{
			Id = 3623;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7038;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thule's Head";
			Name2 = "Thule's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Nek'rosh's Head)
*
***************************************************************/

namespace Server.Items
{
	public class NekroshsHead : Item
	{
		public NekroshsHead() : base()
		{
			Id = 3625;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7141;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nek'rosh's Head";
			Name2 = "Nek'rosh's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Head of Baron Vardus)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfBaronVardus : Item
	{
		public HeadOfBaronVardus() : base()
		{
			Id = 3626;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7038;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Baron Vardus";
			Name2 = "Head of Baron Vardus";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Fang of Vagash)
*
***************************************************************/

namespace Server.Items
{
	public class FangOfVagash : Item
	{
		public FangOfVagash() : base()
		{
			Id = 3627;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3671;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fang of Vagash";
			Name2 = "Fang of Vagash";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Hand of Dextren Ward)
*
***************************************************************/

namespace Server.Items
{
	public class HandOfDextrenWard : Item
	{
		public HandOfDextrenWard() : base()
		{
			Id = 3628;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3913;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hand of Dextren Ward";
			Name2 = "Hand of Dextren Ward";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Mistmantle Family Ring)
*
***************************************************************/

namespace Server.Items
{
	public class MistmantleFamilyRing : Item
	{
		public MistmantleFamilyRing() : base()
		{
			Id = 3629;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6538;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mistmantle Family Ring";
			Name2 = "Mistmantle Family Ring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Head of Targorr)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfTargorr : Item
	{
		public HeadOfTargorr() : base()
		{
			Id = 3630;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3914;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Targorr";
			Name2 = "Head of Targorr";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bellygrub's Tusk)
*
***************************************************************/

namespace Server.Items
{
	public class BellygrubsTusk : Item
	{
		public BellygrubsTusk() : base()
		{
			Id = 3631;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7042;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bellygrub's Tusk";
			Name2 = "Bellygrub's Tusk";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Fangore's Paw)
*
***************************************************************/

namespace Server.Items
{
	public class FangoresPaw : Item
	{
		public FangoresPaw() : base()
		{
			Id = 3632;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3916;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fangore's Paw";
			Name2 = "Fangore's Paw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Head of Gath'Ilzogg)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfGathIlzogg : Item
	{
		public HeadOfGathIlzogg() : base()
		{
			Id = 3633;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3914;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Gath'Ilzogg";
			Name2 = "Head of Gath'Ilzogg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Head of Grimson)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfGrimson : Item
	{
		public HeadOfGrimson() : base()
		{
			Id = 3634;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3917;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Grimson";
			Name2 = "Head of Grimson";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Maggot Eye's Paw)
*
***************************************************************/

namespace Server.Items
{
	public class MaggotEyesPaw : Item
	{
		public MaggotEyesPaw() : base()
		{
			Id = 3635;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3916;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Maggot Eye's Paw";
			Name2 = "Maggot Eye's Paw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Scale of Old Murk-Eye)
*
***************************************************************/

namespace Server.Items
{
	public class ScaleOfOldMurkEye : Item
	{
		public ScaleOfOldMurkEye() : base()
		{
			Id = 3636;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7043;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scale of Old Murk-Eye";
			Name2 = "Scale of Old Murk-Eye";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Head of VanCleef)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfVanCleef : Item
	{
		public HeadOfVanCleef() : base()
		{
			Id = 3637;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3918;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of VanCleef";
			Name2 = "Head of VanCleef";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Sarltooth's Talon)
*
***************************************************************/

namespace Server.Items
{
	public class SarltoothsTalon : Item
	{
		public SarltoothsTalon() : base()
		{
			Id = 3638;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7089;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sarltooth's Talon";
			Name2 = "Sarltooth's Talon";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ear of Balgaras)
*
***************************************************************/

namespace Server.Items
{
	public class EarOfBalgaras : Item
	{
		public EarOfBalgaras() : base()
		{
			Id = 3639;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7612;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ear of Balgaras";
			Name2 = "Ear of Balgaras";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Head of Deepfury)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfDeepfury : Item
	{
		public HeadOfDeepfury() : base()
		{
			Id = 3640;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3920;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Deepfury";
			Name2 = "Head of Deepfury";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Hillsbrad Town Registry)
*
***************************************************************/

namespace Server.Items
{
	public class HillsbradTownRegistry : Item
	{
		public HillsbradTownRegistry() : base()
		{
			Id = 3657;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2757;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hillsbrad Town Registry";
			Name2 = "Hillsbrad Town Registry";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 261;
		}
	}
}


/**************************************************************
*
*				(Recovered Tome)
*
***************************************************************/

namespace Server.Items
{
	public class RecoveredTome : Item
	{
		public RecoveredTome() : base()
		{
			Id = 3658;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1317;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Recovered Tome";
			Name2 = "Recovered Tome";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = 2;
		}
	}
}


/**************************************************************
*
*				(Worn Leather Book)
*
***************************************************************/

namespace Server.Items
{
	public class WornLeatherBook : Item
	{
		public WornLeatherBook() : base()
		{
			Id = 3659;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Arm of Gri'lek";
			Model = 1103;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Worn Leather Book";
			Name2 = "Worn Leather Book";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
		}
	}
}


/**************************************************************
*
*				(Tomes of Alterac)
*
***************************************************************/

namespace Server.Items
{
	public class TomesOfAlterac : Item
	{
		public TomesOfAlterac() : base()
		{
			Id = 3660;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8731;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tomes of Alterac";
			Name2 = "Tomes of Alterac";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
		}
	}
}


/**************************************************************
*
*				(Assassin's Contract)
*
***************************************************************/

namespace Server.Items
{
	public class AssassinsContract : Item
	{
		public AssassinsContract() : base()
		{
			Id = 3668;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 1323;
			ObjectClass = 12;
			SubClass = 0;
			Level = 30;
			ReqLevel = 30;
			Name = "Assassin's Contract";
			Name2 = "Assassin's Contract";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 522;
			MaxCount = 1;
			Material = 2;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Head of Nagaz)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfNagaz : Item
	{
		public HeadOfNagaz() : base()
		{
			Id = 3672;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7141;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Nagaz";
			Name2 = "Head of Nagaz";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Perenolde Tiara)
*
***************************************************************/

namespace Server.Items
{
	public class PerenoldeTiara : Item
	{
		public PerenoldeTiara() : base()
		{
			Id = 3684;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7198;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Perenolde Tiara";
			Name2 = "Perenolde Tiara";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bloodstone Oval)
*
***************************************************************/

namespace Server.Items
{
	public class BloodstoneOval : Item
	{
		public BloodstoneOval() : base()
		{
			Id = 3688;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7051;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodstone Oval";
			Name2 = "Bloodstone Oval";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bloodstone Marble)
*
***************************************************************/

namespace Server.Items
{
	public class BloodstoneMarble : Item
	{
		public BloodstoneMarble() : base()
		{
			Id = 3689;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7050;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodstone Marble";
			Name2 = "Bloodstone Marble";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bloodstone Shard)
*
***************************************************************/

namespace Server.Items
{
	public class BloodstoneShard : Item
	{
		public BloodstoneShard() : base()
		{
			Id = 3690;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7052;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodstone Shard";
			Name2 = "Bloodstone Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bloodstone Wedge)
*
***************************************************************/

namespace Server.Items
{
	public class BloodstoneWedge : Item
	{
		public BloodstoneWedge() : base()
		{
			Id = 3691;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7053;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodstone Wedge";
			Name2 = "Bloodstone Wedge";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Hillsbrad Human Skull)
*
***************************************************************/

namespace Server.Items
{
	public class HillsbradHumanSkull : Item
	{
		public HillsbradHumanSkull() : base()
		{
			Id = 3692;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7100;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hillsbrad Human Skull";
			Name2 = "Hillsbrad Human Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Humbert's Sword)
*
***************************************************************/

namespace Server.Items
{
	public class HumbertsSword : Item
	{
		public HumbertsSword() : base()
		{
			Id = 3693;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7147;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Humbert's Sword";
			Name2 = "Humbert's Sword";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Darthalia's Sealed Commendation)
*
***************************************************************/

namespace Server.Items
{
	public class DarthaliasSealedCommendation : Item
	{
		public DarthaliasSealedCommendation() : base()
		{
			Id = 3701;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "To be opened by Lord Varimathras.";
			Model = 6639;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Darthalia's Sealed Commendation";
			Name2 = "Darthalia's Sealed Commendation";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ensorcelled Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class EnsorcelledParchment : Item
	{
		public EnsorcelledParchment() : base()
		{
			Id = 3706;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "Its letters are enshrouded in magic.";
			Model = 7015;
			ObjectClass = 12;
			SubClass = 0;
			Level = 30;
			ReqLevel = 30;
			Name = "Ensorcelled Parchment";
			Name2 = "Ensorcelled Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 551;
			MaxCount = 1;
			Material = 2;
		}
	}
}


/**************************************************************
*
*				(Helcular's Rod)
*
***************************************************************/

namespace Server.Items
{
	public class HelcularsRod : Item
	{
		public HelcularsRod() : base()
		{
			Id = 3708;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10275;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Helcular's Rod";
			Name2 = "Helcular's Rod";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Rod of Helcular)
*
***************************************************************/

namespace Server.Items
{
	public class RodOfHelcular : Item
	{
		public RodOfHelcular() : base()
		{
			Id = 3710;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10275;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rod of Helcular";
			Name2 = "Rod of Helcular";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 1538 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Belamoore's Research Journal)
*
***************************************************************/

namespace Server.Items
{
	public class BelamooresResearchJournal : Item
	{
		public BelamooresResearchJournal() : base()
		{
			Id = 3711;
			AvailableClasses = 0x7FFF;
			Model = 4049;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Belamoore's Research Journal";
			Name2 = "Belamoore's Research Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
			PageText = 266;
		}
	}
}


/**************************************************************
*
*				(Worn Stone Token)
*
***************************************************************/

namespace Server.Items
{
	public class WornStoneToken : Item
	{
		public WornStoneToken() : base()
		{
			Id = 3714;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Its magic has faded.";
			Model = 7291;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Worn Stone Token";
			Name2 = "Worn Stone Token";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bracers of Earth Binding)
*
***************************************************************/

namespace Server.Items
{
	public class BracersOfEarthBinding : Item
	{
		public BracersOfEarthBinding() : base()
		{
			Id = 3715;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7059;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bracers of Earth Binding";
			Name2 = "Bracers of Earth Binding";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Murloc Head)
*
***************************************************************/

namespace Server.Items
{
	public class MurlocHead : Item
	{
		public MurlocHead() : base()
		{
			Id = 3716;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9585;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Murloc Head";
			Name2 = "Murloc Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sack of Murloc Heads)
*
***************************************************************/

namespace Server.Items
{
	public class SackOfMurlocHeads : Item
	{
		public SackOfMurlocHeads() : base()
		{
			Id = 3717;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7219;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sack of Murloc Heads";
			Name2 = "Sack of Murloc Heads";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Foreboding Plans)
*
***************************************************************/

namespace Server.Items
{
	public class ForebodingPlans : Item
	{
		public ForebodingPlans() : base()
		{
			Id = 3718;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1323;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Foreboding Plans";
			Name2 = "Foreboding Plans";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
			PageText = 371;
		}
	}
}


/**************************************************************
*
*				(Yeti Fur)
*
***************************************************************/

namespace Server.Items
{
	public class YetiFur : Item
	{
		public YetiFur() : base()
		{
			Id = 3720;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7294;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Yeti Fur";
			Name2 = "Yeti Fur";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Farren's Report)
*
***************************************************************/

namespace Server.Items
{
	public class FarrensReport : Item
	{
		public FarrensReport() : base()
		{
			Id = 3721;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3031;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Farren's Report";
			Name2 = "Farren's Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bloodstone Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class BloodstonePendant : Item
	{
		public BloodstonePendant() : base()
		{
			Id = 3744;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "NYI - THIS ITEM WILL SPAWN A QUEST";
			Model = 1399;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodstone Pendant";
			Name2 = "Bloodstone Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Rune of Opening)
*
***************************************************************/

namespace Server.Items
{
	public class RuneOfOpening : Item
	{
		public RuneOfOpening() : base()
		{
			Id = 3745;
			AvailableClasses = 0x7FFF;
			Model = 7218;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rune of Opening";
			Name2 = "Rune of Opening";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 64;
			SetSpell( 3407 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Shadowmaw Claw)
*
***************************************************************/

namespace Server.Items
{
	public class ShadowmawClaw : Item
	{
		public ShadowmawClaw() : base()
		{
			Id = 3838;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7089;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shadowmaw Claw";
			Name2 = "Shadowmaw Claw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Pristine Tigress Fang)
*
***************************************************************/

namespace Server.Items
{
	public class PristineTigressFang : Item
	{
		public PristineTigressFang() : base()
		{
			Id = 3839;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7186;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pristine Tigress Fang";
			Name2 = "Pristine Tigress Fang";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Aged Gorilla Sinew)
*
***************************************************************/

namespace Server.Items
{
	public class AgedGorillaSinew : Item
	{
		public AgedGorillaSinew() : base()
		{
			Id = 3862;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20951;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Aged Gorilla Sinew";
			Name2 = "Aged Gorilla Sinew";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Jungle Stalker Feather)
*
***************************************************************/

namespace Server.Items
{
	public class JungleStalkerFeather : Item
	{
		public JungleStalkerFeather() : base()
		{
			Id = 3863;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11205;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jungle Stalker Feather";
			Name2 = "Jungle Stalker Feather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fang of Bhag'thera)
*
***************************************************************/

namespace Server.Items
{
	public class FangOfBhagthera : Item
	{
		public FangOfBhagthera() : base()
		{
			Id = 3876;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1151;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fang of Bhag'thera";
			Name2 = "Fang of Bhag'thera";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Talon of Tethis)
*
***************************************************************/

namespace Server.Items
{
	public class TalonOfTethis : Item
	{
		public TalonOfTethis() : base()
		{
			Id = 3877;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7266;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Talon of Tethis";
			Name2 = "Talon of Tethis";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Paw of Sin'Dall)
*
***************************************************************/

namespace Server.Items
{
	public class PawOfSinDall : Item
	{
		public PawOfSinDall() : base()
		{
			Id = 3879;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7230;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Paw of Sin'Dall";
			Name2 = "Paw of Sin'Dall";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Head of Bangalash)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfBangalash : Item
	{
		public HeadOfBangalash() : base()
		{
			Id = 3880;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 5689;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Bangalash";
			Name2 = "Head of Bangalash";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Dizzy's Eye)
*
***************************************************************/

namespace Server.Items
{
	public class DizzysEye : Item
	{
		public DizzysEye() : base()
		{
			Id = 3897;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7110;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dizzy's Eye";
			Name2 = "Dizzy's Eye";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Library Scrip)
*
***************************************************************/

namespace Server.Items
{
	public class LibraryScrip : Item
	{
		public LibraryScrip() : base()
		{
			Id = 3898;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 1102;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Library Scrip";
			Name2 = "Library Scrip";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Pupellyverbos Port)
*
***************************************************************/

namespace Server.Items
{
	public class PupellyverbosPort : Item
	{
		public PupellyverbosPort() : base()
		{
			Id = 3900;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18078;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pupellyverbos Port";
			Name2 = "Pupellyverbos Port";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bloodscalp Tusk)
*
***************************************************************/

namespace Server.Items
{
	public class BloodscalpTusk : Item
	{
		public BloodscalpTusk() : base()
		{
			Id = 3901;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7048;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodscalp Tusk";
			Name2 = "Bloodscalp Tusk";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gan'zulah's Head)
*
***************************************************************/

namespace Server.Items
{
	public class GanzulahsHead : Item
	{
		public GanzulahsHead() : base()
		{
			Id = 3904;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1310;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gan'zulah's Head";
			Name2 = "Gan'zulah's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Nezzliok's Head)
*
***************************************************************/

namespace Server.Items
{
	public class NezzlioksHead : Item
	{
		public NezzlioksHead() : base()
		{
			Id = 3905;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1310;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nezzliok's Head";
			Name2 = "Nezzliok's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Balia'mah Trophy)
*
***************************************************************/

namespace Server.Items
{
	public class BaliamahTrophy : Item
	{
		public BaliamahTrophy() : base()
		{
			Id = 3906;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7036;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Balia'mah Trophy";
			Name2 = "Balia'mah Trophy";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ziata'jai Trophy)
*
***************************************************************/

namespace Server.Items
{
	public class ZiatajaiTrophy : Item
	{
		public ZiatajaiTrophy() : base()
		{
			Id = 3907;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7100;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ziata'jai Trophy";
			Name2 = "Ziata'jai Trophy";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Zul'Mamwe Trophy)
*
***************************************************************/

namespace Server.Items
{
	public class ZulMamweTrophy : Item
	{
		public ZulMamweTrophy() : base()
		{
			Id = 3908;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7100;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Zul'Mamwe Trophy";
			Name2 = "Zul'Mamwe Trophy";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Broken Armor of Ana'thek)
*
***************************************************************/

namespace Server.Items
{
	public class BrokenArmorOfAnathek : Item
	{
		public BrokenArmorOfAnathek() : base()
		{
			Id = 3909;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7063;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Broken Armor of Ana'thek";
			Name2 = "Broken Armor of Ana'thek";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Snuff)
*
***************************************************************/

namespace Server.Items
{
	public class Snuff : Item
	{
		public Snuff() : base()
		{
			Id = 3910;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7171;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Snuff";
			Name2 = "Snuff";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Pulsing Blue Shard)
*
***************************************************************/

namespace Server.Items
{
	public class PulsingBlueShard : Item
	{
		public PulsingBlueShard() : base()
		{
			Id = 3911;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7205;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pulsing Blue Shard";
			Name2 = "Pulsing Blue Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Soul Gem)
*
***************************************************************/

namespace Server.Items
{
	public class SoulGem : Item
	{
		public SoulGem() : base()
		{
			Id = 3912;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7257;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Soul Gem";
			Name2 = "Soul Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 3607 , 0 , 0 , 120000 , 2 , -1 );
		}
	}
}


/**************************************************************
*
*				(Filled Soul Gem)
*
***************************************************************/

namespace Server.Items
{
	public class FilledSoulGem : Item
	{
		public FilledSoulGem() : base()
		{
			Id = 3913;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "A glowing gem filled with the soul of Yenniku.";
			Model = 6554;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Soul Gem";
			Name2 = "Filled Soul Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bloody Bone Necklace)
*
***************************************************************/

namespace Server.Items
{
	public class BloodyBoneNecklace : Item
	{
		public BloodyBoneNecklace() : base()
		{
			Id = 3915;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7054;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloody Bone Necklace";
			Name2 = "Bloody Bone Necklace";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Split Bone Necklace)
*
***************************************************************/

namespace Server.Items
{
	public class SplitBoneNecklace : Item
	{
		public SplitBoneNecklace() : base()
		{
			Id = 3916;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18075;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Split Bone Necklace";
			Name2 = "Split Bone Necklace";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Singing Blue Crystal)
*
***************************************************************/

namespace Server.Items
{
	public class SingingBlueCrystal : Item
	{
		public SingingBlueCrystal() : base()
		{
			Id = 3917;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6546;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Singing Blue Crystal";
			Name2 = "Singing Blue Crystal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Singing Crystal Shard)
*
***************************************************************/

namespace Server.Items
{
	public class SingingCrystalShard : Item
	{
		public SingingCrystalShard() : base()
		{
			Id = 3918;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6614;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Singing Crystal Shard";
			Name2 = "Singing Crystal Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mistvale Giblets)
*
***************************************************************/

namespace Server.Items
{
	public class MistvaleGiblets : Item
	{
		public MistvaleGiblets() : base()
		{
			Id = 3919;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7168;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mistvale Giblets";
			Name2 = "Mistvale Giblets";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bloodsail Charts)
*
***************************************************************/

namespace Server.Items
{
	public class BloodsailCharts : Item
	{
		public BloodsailCharts() : base()
		{
			Id = 3920;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7047;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodsail Charts";
			Name2 = "Bloodsail Charts";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bloodsail Orders)
*
***************************************************************/

namespace Server.Items
{
	public class BloodsailOrders : Item
	{
		public BloodsailOrders() : base()
		{
			Id = 3921;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodsail Orders";
			Name2 = "Bloodsail Orders";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 303;
		}
	}
}


/**************************************************************
*
*				(Shaky's Payment)
*
***************************************************************/

namespace Server.Items
{
	public class ShakysPayment : Item
	{
		public ShakysPayment() : base()
		{
			Id = 3922;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4280;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shaky's Payment";
			Name2 = "Shaky's Payment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Water Elemental Bracers)
*
***************************************************************/

namespace Server.Items
{
	public class WaterElementalBracers : Item
	{
		public WaterElementalBracers() : base()
		{
			Id = 3923;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7284;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Water Elemental Bracers";
			Name2 = "Water Elemental Bracers";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Maury's Clubbed Foot)
*
***************************************************************/

namespace Server.Items
{
	public class MaurysClubbedFoot : Item
	{
		public MaurysClubbedFoot() : base()
		{
			Id = 3924;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "It jingles when shaken.";
			Model = 7161;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Maury's Clubbed Foot";
			Name2 = "Maury's Clubbed Foot";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Jon-Jon's Golden Spyglass)
*
***************************************************************/

namespace Server.Items
{
	public class JonJonsGoldenSpyglass : Item
	{
		public JonJonsGoldenSpyglass() : base()
		{
			Id = 3925;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7151;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jon-Jon's Golden Spyglass";
			Name2 = "Jon-Jon's Golden Spyglass";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Chucky's Huge Ring)
*
***************************************************************/

namespace Server.Items
{
	public class ChuckysHugeRing : Item
	{
		public ChuckysHugeRing() : base()
		{
			Id = 3926;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4284;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Chucky's Huge Ring";
			Name2 = "Chucky's Huge Ring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Smotts' Chest)
*
***************************************************************/

namespace Server.Items
{
	public class SmottsChest : Item
	{
		public SmottsChest() : base()
		{
			Id = 3932;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12333;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Smotts' Chest";
			Name2 = "Smotts' Chest";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bag of Water Elemental Bracers)
*
***************************************************************/

namespace Server.Items
{
	public class BagOfWaterElementalBracers : Item
	{
		public BagOfWaterElementalBracers() : base()
		{
			Id = 3960;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6430;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bag of Water Elemental Bracers";
			Name2 = "Bag of Water Elemental Bracers";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Zanzil's Mixture)
*
***************************************************************/

namespace Server.Items
{
	public class ZanzilsMixture : Item
	{
		public ZanzilsMixture() : base()
		{
			Id = 4016;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1288;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Zanzil's Mixture";
			Name2 = "Zanzil's Mixture";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Catelyn's Blade)
*
***************************************************************/

namespace Server.Items
{
	public class CatelynsBlade : Item
	{
		public CatelynsBlade() : base()
		{
			Id = 4027;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7069;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Catelyn's Blade";
			Name2 = "Catelyn's Blade";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2112;
			SetSpell( 3678 , 0 , 0 , 1000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Bundle of Akiris Reeds)
*
***************************************************************/

namespace Server.Items
{
	public class BundleOfAkirisReeds : Item
	{
		public BundleOfAkirisReeds() : base()
		{
			Id = 4028;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "To: Privateer Groy";
			Model = 7065;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bundle of Akiris Reeds";
			Name2 = "Bundle of Akiris Reeds";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Akiris Reed)
*
***************************************************************/

namespace Server.Items
{
	public class AkirisReed : Item
	{
		public AkirisReed() : base()
		{
			Id = 4029;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3427;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Akiris Reed";
			Name2 = "Akiris Reed";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Stone of the Tides)
*
***************************************************************/

namespace Server.Items
{
	public class StoneOfTheTides : Item
	{
		public StoneOfTheTides() : base()
		{
			Id = 4034;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7261;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stone of the Tides";
			Name2 = "Stone of the Tides";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Large River Crocolisk Skin)
*
***************************************************************/

namespace Server.Items
{
	public class LargeRiverCrocoliskSkin : Item
	{
		public LargeRiverCrocoliskSkin() : base()
		{
			Id = 4053;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Large River Crocolisk Skin";
			Name2 = "Large River Crocolisk Skin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Cortello's Riddle)
*
***************************************************************/

namespace Server.Items
{
	public class CortellosRiddle : Item
	{
		public CortellosRiddle() : base()
		{
			Id = 4056;
			AvailableClasses = 0x7FFF;
			Model = 811;
			ObjectClass = 12;
			SubClass = 0;
			Level = 35;
			ReqLevel = 35;
			Name = "Cortello's Riddle";
			Name2 = "Cortello's Riddle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 624;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Krazek's Crock Pot)
*
***************************************************************/

namespace Server.Items
{
	public class KrazeksCrockPot : Item
	{
		public KrazeksCrockPot() : base()
		{
			Id = 4085;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "A cooking pot covered with gauges and dials.";
			Model = 7155;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Krazek's Crock Pot";
			Name2 = "Krazek's Crock Pot";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
			Sheath = 1;
		}
	}
}


/**************************************************************
*
*				(Tablet Shard)
*
***************************************************************/

namespace Server.Items
{
	public class TabletShard : Item
	{
		public TabletShard() : base()
		{
			Id = 4094;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7264;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tablet Shard";
			Name2 = "Tablet Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Carefully Folded Note)
*
***************************************************************/

namespace Server.Items
{
	public class CarefullyFoldedNote : Item
	{
		public CarefullyFoldedNote() : base()
		{
			Id = 4098;
			AvailableClasses = 0x7FFF;
			Model = 4435;
			ObjectClass = 12;
			SubClass = 0;
			Level = 45;
			ReqLevel = 45;
			Name = "Carefully Folded Note";
			Name2 = "Carefully Folded Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 594;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Snapjaw Crocolisk Skin)
*
***************************************************************/

namespace Server.Items
{
	public class SnapjawCrocoliskSkin : Item
	{
		public SnapjawCrocoliskSkin() : base()
		{
			Id = 4104;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6646;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Snapjaw Crocolisk Skin";
			Name2 = "Snapjaw Crocolisk Skin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Elder Crocolisk Skin)
*
***************************************************************/

namespace Server.Items
{
	public class ElderCrocoliskSkin : Item
	{
		public ElderCrocoliskSkin() : base()
		{
			Id = 4105;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6658;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Elder Crocolisk Skin";
			Name2 = "Elder Crocolisk Skin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Tumbled Crystal)
*
***************************************************************/

namespace Server.Items
{
	public class TumbledCrystal : Item
	{
		public TumbledCrystal() : base()
		{
			Id = 4106;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7279;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tumbled Crystal";
			Name2 = "Tumbled Crystal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Lesser Bloodstone Ore)
*
***************************************************************/

namespace Server.Items
{
	public class LesserBloodstoneOre : Item
	{
		public LesserBloodstoneOre() : base()
		{
			Id = 4278;
			SellPrice = 25;
			AvailableClasses = 0x7FFF;
			Model = 7148;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lesser Bloodstone Ore";
			Name2 = "Lesser Bloodstone Ore";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 100;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Deepfury's Orders)
*
***************************************************************/

namespace Server.Items
{
	public class DeepfurysOrders : Item
	{
		public DeepfurysOrders() : base()
		{
			Id = 4429;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Deepfury's Orders";
			Name2 = "Deepfury's Orders";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 316;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Sully Balloo's Letter)
*
***************************************************************/

namespace Server.Items
{
	public class SullyBalloosLetter : Item
	{
		public SullyBalloosLetter() : base()
		{
			Id = 4432;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "My dear Sara...";
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sully Balloo's Letter";
			Name2 = "Sully Balloo's Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 317;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Waterlogged Envelope)
*
***************************************************************/

namespace Server.Items
{
	public class WaterloggedEnvelope : Item
	{
		public WaterloggedEnvelope() : base()
		{
			Id = 4433;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 4435;
			ObjectClass = 12;
			SubClass = 0;
			Level = 25;
			ReqLevel = 25;
			Name = "Waterlogged Envelope";
			Name2 = "Waterlogged Envelope";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 637;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mote of Myzrael)
*
***************************************************************/

namespace Server.Items
{
	public class MoteOfMyzrael : Item
	{
		public MoteOfMyzrael() : base()
		{
			Id = 4435;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6614;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mote of Myzrael";
			Name2 = "Mote of Myzrael";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sigil of Strom)
*
***************************************************************/

namespace Server.Items
{
	public class SigilOfStrom : Item
	{
		public SigilOfStrom() : base()
		{
			Id = 4440;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7246;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sigil of Strom";
			Name2 = "Sigil of Strom";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(MacKreel's Moonshine)
*
***************************************************************/

namespace Server.Items
{
	public class MacKreelsMoonshine : Item
	{
		public MacKreelsMoonshine() : base()
		{
			Id = 4441;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18078;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "MacKreel's Moonshine";
			Name2 = "MacKreel's Moonshine";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sigil Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class SigilFragment : Item
	{
		public SigilFragment() : base()
		{
			Id = 4450;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7184;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sigil Fragment";
			Name2 = "Sigil Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sigil of Thoradin)
*
***************************************************************/

namespace Server.Items
{
	public class SigilOfThoradin : Item
	{
		public SigilOfThoradin() : base()
		{
			Id = 4453;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7248;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sigil of Thoradin";
			Name2 = "Sigil of Thoradin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sigil of Arathor)
*
***************************************************************/

namespace Server.Items
{
	public class SigilOfArathor : Item
	{
		public SigilOfArathor() : base()
		{
			Id = 4458;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7245;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sigil of Arathor";
			Name2 = "Sigil of Arathor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Sigil of Trollbane)
*
***************************************************************/

namespace Server.Items
{
	public class SigilOfTrollbane : Item
	{
		public SigilOfTrollbane() : base()
		{
			Id = 4466;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7249;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sigil of Trollbane";
			Name2 = "Sigil of Trollbane";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Sigil of Ignaeus)
*
***************************************************************/

namespace Server.Items
{
	public class SigilOfIgnaeus : Item
	{
		public SigilOfIgnaeus() : base()
		{
			Id = 4467;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7244;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sigil of Ignaeus";
			Name2 = "Sigil of Ignaeus";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sheathed Trol'kalar)
*
***************************************************************/

namespace Server.Items
{
	public class SheathedTrolkalar : Item
	{
		public SheathedTrolkalar() : base()
		{
			Id = 4468;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The legendary blade of Ignaeus Trollbane.";
			Model = 7239;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sheathed Trol'kalar";
			Name2 = "Sheathed Trol'kalar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Rod of Order)
*
***************************************************************/

namespace Server.Items
{
	public class RodOfOrder : Item
	{
		public RodOfOrder() : base()
		{
			Id = 4469;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7216;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rod of Order";
			Name2 = "Rod of Order";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Scroll of Myzrael)
*
***************************************************************/

namespace Server.Items
{
	public class ScrollOfMyzrael : Item
	{
		public ScrollOfMyzrael() : base()
		{
			Id = 4472;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2616;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Scroll of Myzrael";
			Name2 = "Scroll of Myzrael";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 7;
			Flags = 64;
			SetSpell( 4141 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Eldritch Shackles)
*
***************************************************************/

namespace Server.Items
{
	public class EldritchShackles : Item
	{
		public EldritchShackles() : base()
		{
			Id = 4473;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7118;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Eldritch Shackles";
			Name2 = "Eldritch Shackles";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 5;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Sealed Folder)
*
***************************************************************/

namespace Server.Items
{
	public class SealedFolder : Item
	{
		public SealedFolder() : base()
		{
			Id = 4482;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7234;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sealed Folder";
			Name2 = "Sealed Folder";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Maiden's Folly Charts)
*
***************************************************************/

namespace Server.Items
{
	public class MaidensFollyCharts : Item
	{
		public MaidensFollyCharts() : base()
		{
			Id = 4487;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7047;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Maiden's Folly Charts";
			Name2 = "Maiden's Folly Charts";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Spirit of Silverpine Charts)
*
***************************************************************/

namespace Server.Items
{
	public class SpiritOfSilverpineCharts : Item
	{
		public SpiritOfSilverpineCharts() : base()
		{
			Id = 4488;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7047;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Spirit of Silverpine Charts";
			Name2 = "Spirit of Silverpine Charts";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Maiden's Folly Log)
*
***************************************************************/

namespace Server.Items
{
	public class MaidensFollyLog : Item
	{
		public MaidensFollyLog() : base()
		{
			Id = 4489;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7152;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Maiden's Folly Log";
			Name2 = "Maiden's Folly Log";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Spirit of Silverpine Log)
*
***************************************************************/

namespace Server.Items
{
	public class SpiritOfSilverpineLog : Item
	{
		public SpiritOfSilverpineLog() : base()
		{
			Id = 4490;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3426;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Spirit of Silverpine Log";
			Name2 = "Spirit of Silverpine Log";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Goggles of Gem Hunting)
*
***************************************************************/

namespace Server.Items
{
	public class GogglesOfGemHunting : Item
	{
		public GogglesOfGemHunting() : base()
		{
			Id = 4491;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12289;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Goggles of Gem Hunting";
			Name2 = "Goggles of Gem Hunting";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.Head;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 4152 , 1 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Elven Gem)
*
***************************************************************/

namespace Server.Items
{
	public class ElvenGem : Item
	{
		public ElvenGem() : base()
		{
			Id = 4492;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7119;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Elven Gem";
			Name2 = "Elven Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Elven Gems)
*
***************************************************************/

namespace Server.Items
{
	public class ElvenGems : Item
	{
		public ElvenGems() : base()
		{
			Id = 4493;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7120;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Elven Gems";
			Name2 = "Elven Gems";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Seahorn's Sealed Letter)
*
***************************************************************/

namespace Server.Items
{
	public class SeahornsSealedLetter : Item
	{
		public SeahornsSealedLetter() : base()
		{
			Id = 4494;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7233;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Seahorn's Sealed Letter";
			Name2 = "Seahorn's Sealed Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bloodstone Amulet)
*
***************************************************************/

namespace Server.Items
{
	public class BloodstoneAmulet : Item
	{
		public BloodstoneAmulet() : base()
		{
			Id = 4495;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9658;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodstone Amulet";
			Name2 = "Bloodstone Amulet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sample Elven Gem)
*
***************************************************************/

namespace Server.Items
{
	public class SampleElvenGem : Item
	{
		public SampleElvenGem() : base()
		{
			Id = 4502;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7221;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sample Elven Gem";
			Name2 = "Sample Elven Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Witherbark Tusk)
*
***************************************************************/

namespace Server.Items
{
	public class WitherbarkTusk : Item
	{
		public WitherbarkTusk() : base()
		{
			Id = 4503;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3429;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Witherbark Tusk";
			Name2 = "Witherbark Tusk";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Stromgarde Badge)
*
***************************************************************/

namespace Server.Items
{
	public class StromgardeBadge : Item
	{
		public StromgardeBadge() : base()
		{
			Id = 4506;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6510;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stromgarde Badge";
			Name2 = "Stromgarde Badge";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Befouled Bloodstone Orb)
*
***************************************************************/

namespace Server.Items
{
	public class BefouledBloodstoneOrb : Item
	{
		public BefouledBloodstoneOrb() : base()
		{
			Id = 4510;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7041;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Befouled Bloodstone Orb";
			Name2 = "Befouled Bloodstone Orb";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Highland Raptor Eye)
*
***************************************************************/

namespace Server.Items
{
	public class HighlandRaptorEye : Item
	{
		public HighlandRaptorEye() : base()
		{
			Id = 4512;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1504;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Highland Raptor Eye";
			Name2 = "Highland Raptor Eye";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Raptor Heart)
*
***************************************************************/

namespace Server.Items
{
	public class RaptorHeart : Item
	{
		public RaptorHeart() : base()
		{
			Id = 4513;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6693;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Raptor Heart";
			Name2 = "Raptor Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sara Balloo's Plea)
*
***************************************************************/

namespace Server.Items
{
	public class SaraBalloosPlea : Item
	{
		public SaraBalloosPlea() : base()
		{
			Id = 4514;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "To My Honorable King";
			Model = 4771;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sara Balloo's Plea";
			Name2 = "Sara Balloo's Plea";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 333;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Marez's Head)
*
***************************************************************/

namespace Server.Items
{
	public class MarezsHead : Item
	{
		public MarezsHead() : base()
		{
			Id = 4515;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1310;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Marez's Head";
			Name2 = "Marez's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Otto's Head)
*
***************************************************************/

namespace Server.Items
{
	public class OttosHead : Item
	{
		public OttosHead() : base()
		{
			Id = 4516;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7038;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Otto's Head";
			Name2 = "Otto's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Falconcrest's Head)
*
***************************************************************/

namespace Server.Items
{
	public class FalconcrestsHead : Item
	{
		public FalconcrestsHead() : base()
		{
			Id = 4517;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7038;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Falconcrest's Head";
			Name2 = "Falconcrest's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Torn Scroll Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class TornScrollFragment : Item
	{
		public TornScrollFragment() : base()
		{
			Id = 4518;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2616;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Torn Scroll Fragment";
			Name2 = "Torn Scroll Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 7;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Crumpled Scroll Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class CrumpledScrollFragment : Item
	{
		public CrumpledScrollFragment() : base()
		{
			Id = 4519;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2616;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crumpled Scroll Fragment";
			Name2 = "Crumpled Scroll Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 7;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Singed Scroll Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class SingedScrollFragment : Item
	{
		public SingedScrollFragment() : base()
		{
			Id = 4520;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2616;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Singed Scroll Fragment";
			Name2 = "Singed Scroll Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 7;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Alterac Granite)
*
***************************************************************/

namespace Server.Items
{
	public class AlteracGranite : Item
	{
		public AlteracGranite() : base()
		{
			Id = 4521;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7024;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Alterac Granite";
			Name2 = "Alterac Granite";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Witherbark Medicine Pouch)
*
***************************************************************/

namespace Server.Items
{
	public class WitherbarkMedicinePouch : Item
	{
		public WitherbarkMedicinePouch() : base()
		{
			Id = 4522;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7289;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Witherbark Medicine Pouch";
			Name2 = "Witherbark Medicine Pouch";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Trelane's Wand of Invocation)
*
***************************************************************/

namespace Server.Items
{
	public class TrelanesWandOfInvocation : Item
	{
		public TrelanesWandOfInvocation() : base()
		{
			Id = 4525;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7278;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Trelane's Wand of Invocation";
			Name2 = "Trelane's Wand of Invocation";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Raptor Talon Amulet)
*
***************************************************************/

namespace Server.Items
{
	public class RaptorTalonAmulet : Item
	{
		public RaptorTalonAmulet() : base()
		{
			Id = 4526;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7202;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Raptor Talon Amulet";
			Name2 = "Raptor Talon Amulet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Azure Agate)
*
***************************************************************/

namespace Server.Items
{
	public class AzureAgate : Item
	{
		public AzureAgate() : base()
		{
			Id = 4527;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1659;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Azure Agate";
			Name2 = "Azure Agate";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tor'gan's Orb)
*
***************************************************************/

namespace Server.Items
{
	public class TorgansOrb : Item
	{
		public TorgansOrb() : base()
		{
			Id = 4528;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7261;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tor'gan's Orb";
			Name2 = "Tor'gan's Orb";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Enchanted Agate)
*
***************************************************************/

namespace Server.Items
{
	public class EnchantedAgate : Item
	{
		public EnchantedAgate() : base()
		{
			Id = 4529;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4775;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Enchanted Agate";
			Name2 = "Enchanted Agate";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 4239 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Trelane's Phylactery)
*
***************************************************************/

namespace Server.Items
{
	public class TrelanesPhylactery : Item
	{
		public TrelanesPhylactery() : base()
		{
			Id = 4530;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7277;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Trelane's Phylactery";
			Name2 = "Trelane's Phylactery";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Trelane's Orb)
*
***************************************************************/

namespace Server.Items
{
	public class TrelanesOrb : Item
	{
		public TrelanesOrb() : base()
		{
			Id = 4531;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6564;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Trelane's Orb";
			Name2 = "Trelane's Orb";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Trelane's Ember Agate)
*
***************************************************************/

namespace Server.Items
{
	public class TrelanesEmberAgate : Item
	{
		public TrelanesEmberAgate() : base()
		{
			Id = 4532;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4777;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Trelane's Ember Agate";
			Name2 = "Trelane's Ember Agate";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sealed Letter to Archmage Malin)
*
***************************************************************/

namespace Server.Items
{
	public class SealedLetterToArchmageMalin : Item
	{
		public SealedLetterToArchmageMalin() : base()
		{
			Id = 4533;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4435;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sealed Letter to Archmage Malin";
			Name2 = "Sealed Letter to Archmage Malin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Or'Kalar's Head)
*
***************************************************************/

namespace Server.Items
{
	public class OrKalarsHead : Item
	{
		public OrKalarsHead() : base()
		{
			Id = 4551;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3918;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Or'Kalar's Head";
			Name2 = "Or'Kalar's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Carved Stone Urn)
*
***************************************************************/

namespace Server.Items
{
	public class CarvedStoneUrn : Item
	{
		public CarvedStoneUrn() : base()
		{
			Id = 4610;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6393;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Carved Stone Urn";
			Name2 = "Carved Stone Urn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Black Drake's Heart)
*
***************************************************************/

namespace Server.Items
{
	public class BlackDrakesHeart : Item
	{
		public BlackDrakesHeart() : base()
		{
			Id = 4612;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4826;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Black Drake's Heart";
			Name2 = "Black Drake's Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Corroded Black Box)
*
***************************************************************/

namespace Server.Items
{
	public class CorrodedBlackBox : Item
	{
		public CorrodedBlackBox() : base()
		{
			Id = 4613;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 20913;
			ObjectClass = 12;
			SubClass = 0;
			Level = 30;
			ReqLevel = 30;
			Name = "Corroded Black Box";
			Name2 = "Corroded Black Box";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 708;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Blacklash's Bindings)
*
***************************************************************/

namespace Server.Items
{
	public class BlacklashsBindings : Item
	{
		public BlacklashsBindings() : base()
		{
			Id = 4615;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4829;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blacklash's Bindings";
			Name2 = "Blacklash's Bindings";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ambassador Infernus' Bracer)
*
***************************************************************/

namespace Server.Items
{
	public class AmbassadorInfernusBracer : Item
	{
		public AmbassadorInfernusBracer() : base()
		{
			Id = 4621;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7025;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ambassador Infernus' Bracer";
			Name2 = "Ambassador Infernus' Bracer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Sealed Note to Advisor Belgrum)
*
***************************************************************/

namespace Server.Items
{
	public class SealedNoteToAdvisorBelgrum : Item
	{
		public SealedNoteToAdvisorBelgrum() : base()
		{
			Id = 4622;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4435;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sealed Note to Advisor Belgrum";
			Name2 = "Sealed Note to Advisor Belgrum";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Small Stone Shard)
*
***************************************************************/

namespace Server.Items
{
	public class SmallStoneShard : Item
	{
		public SmallStoneShard() : base()
		{
			Id = 4626;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4717;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Small Stone Shard";
			Name2 = "Small Stone Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Large Stone Slab)
*
***************************************************************/

namespace Server.Items
{
	public class LargeStoneSlab : Item
	{
		public LargeStoneSlab() : base()
		{
			Id = 4627;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7157;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Large Stone Slab";
			Name2 = "Large Stone Slab";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 5;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bracers of Rock Binding)
*
***************************************************************/

namespace Server.Items
{
	public class BracersOfRockBinding : Item
	{
		public BracersOfRockBinding() : base()
		{
			Id = 4628;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7060;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bracers of Rock Binding";
			Name2 = "Bracers of Rock Binding";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Supply Crate)
*
***************************************************************/

namespace Server.Items
{
	public class SupplyCrate : Item
	{
		public SupplyCrate() : base()
		{
			Id = 4629;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7925;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Supply Crate";
			Name2 = "Supply Crate";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Scrap Metal)
*
***************************************************************/

namespace Server.Items
{
	public class ScrapMetal : Item
	{
		public ScrapMetal() : base()
		{
			Id = 4630;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7064;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scrap Metal";
			Name2 = "Scrap Metal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tablet of Ryun'eh)
*
***************************************************************/

namespace Server.Items
{
	public class TabletOfRyuneh : Item
	{
		public TabletOfRyuneh() : base()
		{
			Id = 4631;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7264;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tablet of Ryun'eh";
			Name2 = "Tablet of Ryun'eh";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Hammertoe's Amulet)
*
***************************************************************/

namespace Server.Items
{
	public class HammertoesAmulet : Item
	{
		public HammertoesAmulet() : base()
		{
			Id = 4635;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4841;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hammertoe's Amulet";
			Name2 = "Hammertoe's Amulet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Enchanted Sea Kelp)
*
***************************************************************/

namespace Server.Items
{
	public class EnchantedSeaKelp : Item
	{
		public EnchantedSeaKelp() : base()
		{
			Id = 4639;
			SellPrice = 162;
			AvailableClasses = 0x7FFF;
			Model = 7078;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Enchanted Sea Kelp";
			Name2 = "Enchanted Sea Kelp";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 650;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 4945 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Sign of the Earth)
*
***************************************************************/

namespace Server.Items
{
	public class SignOfTheEarth : Item
	{
		public SignOfTheEarth() : base()
		{
			Id = 4640;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4681;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sign of the Earth";
			Name2 = "Sign of the Earth";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			SetSpell( 4982 , 0 , 0 , -1 , 1 , -1 );
		}
	}
}


/**************************************************************
*
*				(Hand of Dagun)
*
***************************************************************/

namespace Server.Items
{
	public class HandOfDagun : Item
	{
		public HandOfDagun() : base()
		{
			Id = 4641;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3146;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hand of Dagun";
			Name2 = "Hand of Dagun";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(The Legacy Heart)
*
***************************************************************/

namespace Server.Items
{
	public class TheLegacyHeart : Item
	{
		public TheLegacyHeart() : base()
		{
			Id = 4644;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7269;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The Legacy Heart";
			Name2 = "The Legacy Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Chains of Hematus)
*
***************************************************************/

namespace Server.Items
{
	public class ChainsOfHematus : Item
	{
		public ChainsOfHematus() : base()
		{
			Id = 4645;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4829;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Chains of Hematus";
			Name2 = "Chains of Hematus";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Star of Xil'yeh)
*
***************************************************************/

namespace Server.Items
{
	public class StarOfXilyeh : Item
	{
		public StarOfXilyeh() : base()
		{
			Id = 4646;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2516;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Star of Xil'yeh";
			Name2 = "Star of Xil'yeh";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Yagyin's Digest)
*
***************************************************************/

namespace Server.Items
{
	public class YagyinsDigest : Item
	{
		public YagyinsDigest() : base()
		{
			Id = 4647;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7293;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Yagyin's Digest";
			Name2 = "Yagyin's Digest";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sigil of the Hammer)
*
***************************************************************/

namespace Server.Items
{
	public class SigilOfTheHammer : Item
	{
		public SigilOfTheHammer() : base()
		{
			Id = 4648;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7247;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sigil of the Hammer";
			Name2 = "Sigil of the Hammer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bonegrip's Note)
*
***************************************************************/

namespace Server.Items
{
	public class BonegripsNote : Item
	{
		public BonegripsNote() : base()
		{
			Id = 4649;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 811;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bonegrip's Note";
			Name2 = "Bonegrip's Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 372;
		}
	}
}


/**************************************************************
*
*				(Bel'dugur's Note)
*
***************************************************************/

namespace Server.Items
{
	public class BeldugursNote : Item
	{
		public BeldugursNote() : base()
		{
			Id = 4650;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 811;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bel'dugur's Note";
			Name2 = "Bel'dugur's Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 376;
		}
	}
}


/**************************************************************
*
*				(Mysterious Fossil)
*
***************************************************************/

namespace Server.Items
{
	public class MysteriousFossil : Item
	{
		public MysteriousFossil() : base()
		{
			Id = 4654;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7177;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mysterious Fossil";
			Name2 = "Mysterious Fossil";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Prospector's Pick)
*
***************************************************************/

namespace Server.Items
{
	public class ProspectorsPick : Item
	{
		public ProspectorsPick() : base()
		{
			Id = 4702;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7096;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Prospector's Pick";
			Name2 = "Prospector's Pick";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 64;
			SetSpell( 4954 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Broken Tools)
*
***************************************************************/

namespace Server.Items
{
	public class BrokenTools : Item
	{
		public BrokenTools() : base()
		{
			Id = 4703;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7064;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Broken Tools";
			Name2 = "Broken Tools";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Plainstrider Meat)
*
***************************************************************/

namespace Server.Items
{
	public class PlainstriderMeat : Item
	{
		public PlainstriderMeat() : base()
		{
			Id = 4739;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2599;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Plainstrider Meat";
			Name2 = "Plainstrider Meat";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Plainstrider Feather)
*
***************************************************************/

namespace Server.Items
{
	public class PlainstriderFeather : Item
	{
		public PlainstriderFeather() : base()
		{
			Id = 4740;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19572;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Plainstrider Feather";
			Name2 = "Plainstrider Feather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mountain Cougar Pelt)
*
***************************************************************/

namespace Server.Items
{
	public class MountainCougarPelt : Item
	{
		public MountainCougarPelt() : base()
		{
			Id = 4742;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7169;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mountain Cougar Pelt";
			Name2 = "Mountain Cougar Pelt";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Windfury Talon)
*
***************************************************************/

namespace Server.Items
{
	public class WindfuryTalon : Item
	{
		public WindfuryTalon() : base()
		{
			Id = 4751;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7266;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Windfury Talon";
			Name2 = "Windfury Talon";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Azure Feather)
*
***************************************************************/

namespace Server.Items
{
	public class AzureFeather : Item
	{
		public AzureFeather() : base()
		{
			Id = 4752;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19528;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Azure Feather";
			Name2 = "Azure Feather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bronze Feather)
*
***************************************************************/

namespace Server.Items
{
	public class BronzeFeather : Item
	{
		public BronzeFeather() : base()
		{
			Id = 4753;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19529;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bronze Feather";
			Name2 = "Bronze Feather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Water Pitcher)
*
***************************************************************/

namespace Server.Items
{
	public class WaterPitcher : Item
	{
		public WaterPitcher() : base()
		{
			Id = 4755;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18102;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Water Pitcher";
			Name2 = "Water Pitcher";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Prairie Wolf Paw)
*
***************************************************************/

namespace Server.Items
{
	public class PrairieWolfPaw : Item
	{
		public PrairieWolfPaw() : base()
		{
			Id = 4758;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6669;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Prairie Wolf Paw";
			Name2 = "Prairie Wolf Paw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Plainstrider Talon)
*
***************************************************************/

namespace Server.Items
{
	public class PlainstriderTalon : Item
	{
		public PlainstriderTalon() : base()
		{
			Id = 4759;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7202;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Plainstrider Talon";
			Name2 = "Plainstrider Talon";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Trophy Swoop Quill)
*
***************************************************************/

namespace Server.Items
{
	public class TrophySwoopQuill : Item
	{
		public TrophySwoopQuill() : base()
		{
			Id = 4769;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11207;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Trophy Swoop Quill";
			Name2 = "Trophy Swoop Quill";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bristleback Belt)
*
***************************************************************/

namespace Server.Items
{
	public class BristlebackBelt : Item
	{
		public BristlebackBelt() : base()
		{
			Id = 4770;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7061;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bristleback Belt";
			Name2 = "Bristleback Belt";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Totem of Hawkwind)
*
***************************************************************/

namespace Server.Items
{
	public class TotemOfHawkwind : Item
	{
		public TotemOfHawkwind() : base()
		{
			Id = 4783;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7276;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Totem of Hawkwind";
			Name2 = "Totem of Hawkwind";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Stalker Claws)
*
***************************************************************/

namespace Server.Items
{
	public class StalkerClaws : Item
	{
		public StalkerClaws() : base()
		{
			Id = 4801;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1496;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stalker Claws";
			Name2 = "Stalker Claws";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Cougar Claws)
*
***************************************************************/

namespace Server.Items
{
	public class CougarClaws : Item
	{
		public CougarClaws() : base()
		{
			Id = 4802;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6671;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cougar Claws";
			Name2 = "Cougar Claws";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Prairie Alpha Tooth)
*
***************************************************************/

namespace Server.Items
{
	public class PrairieAlphaTooth : Item
	{
		public PrairieAlphaTooth() : base()
		{
			Id = 4803;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6630;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Prairie Alpha Tooth";
			Name2 = "Prairie Alpha Tooth";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Prairie Wolf Heart)
*
***************************************************************/

namespace Server.Items
{
	public class PrairieWolfHeart : Item
	{
		public PrairieWolfHeart() : base()
		{
			Id = 4804;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7142;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Prairie Wolf Heart";
			Name2 = "Prairie Wolf Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Flatland Cougar Femur)
*
***************************************************************/

namespace Server.Items
{
	public class FlatlandCougarFemur : Item
	{
		public FlatlandCougarFemur() : base()
		{
			Id = 4805;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7126;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Flatland Cougar Femur";
			Name2 = "Flatland Cougar Femur";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Plainstrider Scale)
*
***************************************************************/

namespace Server.Items
{
	public class PlainstriderScale : Item
	{
		public PlainstriderScale() : base()
		{
			Id = 4806;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6646;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Plainstrider Scale";
			Name2 = "Plainstrider Scale";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Swoop Gizzard)
*
***************************************************************/

namespace Server.Items
{
	public class SwoopGizzard : Item
	{
		public SwoopGizzard() : base()
		{
			Id = 4807;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6427;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Swoop Gizzard";
			Name2 = "Swoop Gizzard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Well Stone)
*
***************************************************************/

namespace Server.Items
{
	public class WellStone : Item
	{
		public WellStone() : base()
		{
			Id = 4808;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8039;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Well Stone";
			Name2 = "Well Stone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ambercorn)
*
***************************************************************/

namespace Server.Items
{
	public class Ambercorn : Item
	{
		public Ambercorn() : base()
		{
			Id = 4809;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7287;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ambercorn";
			Name2 = "Ambercorn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fizsprocket's Clipboard)
*
***************************************************************/

namespace Server.Items
{
	public class FizsprocketsClipboard : Item
	{
		public FizsprocketsClipboard() : base()
		{
			Id = 4819;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4110;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fizsprocket's Clipboard";
			Name2 = "Fizsprocket's Clipboard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Water of the Seers)
*
***************************************************************/

namespace Server.Items
{
	public class WaterOfTheSeers : Item
	{
		public WaterOfTheSeers() : base()
		{
			Id = 4823;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4984;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Water of the Seers";
			Name2 = "Water of the Seers";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 4981 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Venture Co. Documents)
*
***************************************************************/

namespace Server.Items
{
	public class VentureCoDocuments : Item
	{
		public VentureCoDocuments() : base()
		{
			Id = 4834;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7234;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Venture Co. Documents";
			Name2 = "Venture Co. Documents";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 352;
		}
	}
}


/**************************************************************
*
*				(Horn of Arra'chea)
*
***************************************************************/

namespace Server.Items
{
	public class HornOfArrachea : Item
	{
		public HornOfArrachea() : base()
		{
			Id = 4841;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7145;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Horn of Arra'chea";
			Name2 = "Horn of Arra'chea";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Amethyst Runestone)
*
***************************************************************/

namespace Server.Items
{
	public class AmethystRunestone : Item
	{
		public AmethystRunestone() : base()
		{
			Id = 4843;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7026;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Amethyst Runestone";
			Name2 = "Amethyst Runestone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Opal Runestone)
*
***************************************************************/

namespace Server.Items
{
	public class OpalRunestone : Item
	{
		public OpalRunestone() : base()
		{
			Id = 4844;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7189;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Opal Runestone";
			Name2 = "Opal Runestone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Diamond Runestone)
*
***************************************************************/

namespace Server.Items
{
	public class DiamondRunestone : Item
	{
		public DiamondRunestone() : base()
		{
			Id = 4845;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7106;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Diamond Runestone";
			Name2 = "Diamond Runestone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Cog #5)
*
***************************************************************/

namespace Server.Items
{
	public class Cog5 : Item
	{
		public Cog5() : base()
		{
			Id = 4846;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7072;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cog #5";
			Name2 = "Cog #5";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Lotwil's Shackles of Elemental Binding)
*
***************************************************************/

namespace Server.Items
{
	public class LotwilsShacklesOfElementalBinding : Item
	{
		public LotwilsShacklesOfElementalBinding() : base()
		{
			Id = 4847;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7159;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lotwil's Shackles of Elemental Binding";
			Name2 = "Lotwil's Shackles of Elemental Binding";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Battleboar Snout)
*
***************************************************************/

namespace Server.Items
{
	public class BattleboarSnout : Item
	{
		public BattleboarSnout() : base()
		{
			Id = 4848;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8802;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Battleboar Snout";
			Name2 = "Battleboar Snout";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Battleboar Flank)
*
***************************************************************/

namespace Server.Items
{
	public class BattleboarFlank : Item
	{
		public BattleboarFlank() : base()
		{
			Id = 4849;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2599;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Battleboar Flank";
			Name2 = "Battleboar Flank";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bristleback Attack Plans)
*
***************************************************************/

namespace Server.Items
{
	public class BristlebackAttackPlans : Item
	{
		public BristlebackAttackPlans() : base()
		{
			Id = 4850;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7047;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bristleback Attack Plans";
			Name2 = "Bristleback Attack Plans";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dirt-stained Map)
*
***************************************************************/

namespace Server.Items
{
	public class DirtStainedMap : Item
	{
		public DirtStainedMap() : base()
		{
			Id = 4851;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7047;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Dirt-stained Map";
			Name2 = "Dirt-stained Map";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 781;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Burning Blade Medallion)
*
***************************************************************/

namespace Server.Items
{
	public class BurningBladeMedallion : Item
	{
		public BurningBladeMedallion() : base()
		{
			Id = 4859;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6484;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Burning Blade Medallion";
			Name2 = "Burning Blade Medallion";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Scorpid Worker Tail)
*
***************************************************************/

namespace Server.Items
{
	public class ScorpidWorkerTail : Item
	{
		public ScorpidWorkerTail() : base()
		{
			Id = 4862;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7229;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scorpid Worker Tail";
			Name2 = "Scorpid Worker Tail";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gnomish Tools)
*
***************************************************************/

namespace Server.Items
{
	public class GnomishTools : Item
	{
		public GnomishTools() : base()
		{
			Id = 4863;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7602;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gnomish Tools";
			Name2 = "Gnomish Tools";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Minshina's Skull)
*
***************************************************************/

namespace Server.Items
{
	public class MinshinasSkull : Item
	{
		public MinshinasSkull() : base()
		{
			Id = 4864;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7102;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Minshina's Skull";
			Name2 = "Minshina's Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Zalazane's Head)
*
***************************************************************/

namespace Server.Items
{
	public class ZalazanesHead : Item
	{
		public ZalazanesHead() : base()
		{
			Id = 4866;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9090;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Zalazane's Head";
			Name2 = "Zalazane's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Fizzle's Claw)
*
***************************************************************/

namespace Server.Items
{
	public class FizzlesClaw : Item
	{
		public FizzlesClaw() : base()
		{
			Id = 4869;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3146;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fizzle's Claw";
			Name2 = "Fizzle's Claw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Canvas Scraps)
*
***************************************************************/

namespace Server.Items
{
	public class CanvasScraps : Item
	{
		public CanvasScraps() : base()
		{
			Id = 4870;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7067;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Canvas Scraps";
			Name2 = "Canvas Scraps";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Searing Collar)
*
***************************************************************/

namespace Server.Items
{
	public class SearingCollar : Item
	{
		public SearingCollar() : base()
		{
			Id = 4871;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12643;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Searing Collar";
			Name2 = "Searing Collar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Aged Envelope)
*
***************************************************************/

namespace Server.Items
{
	public class AgedEnvelope : Item
	{
		public AgedEnvelope() : base()
		{
			Id = 4881;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Aged Envelope";
			Name2 = "Aged Envelope";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 830;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Admiral Proudmoore's Orders)
*
***************************************************************/

namespace Server.Items
{
	public class AdmiralProudmooresOrders : Item
	{
		public AdmiralProudmooresOrders() : base()
		{
			Id = 4883;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Admiral Proudmoore's Orders";
			Name2 = "Admiral Proudmoore's Orders";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 337;
		}
	}
}


/**************************************************************
*
*				(Venomtail Poison Sac)
*
***************************************************************/

namespace Server.Items
{
	public class VenomtailPoisonSac : Item
	{
		public VenomtailPoisonSac() : base()
		{
			Id = 4886;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6694;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Venomtail Poison Sac";
			Name2 = "Venomtail Poison Sac";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Intact Makrura Eye)
*
***************************************************************/

namespace Server.Items
{
	public class IntactMakruraEye : Item
	{
		public IntactMakruraEye() : base()
		{
			Id = 4887;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7110;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Intact Makrura Eye";
			Name2 = "Intact Makrura Eye";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crawler Mucus)
*
***************************************************************/

namespace Server.Items
{
	public class CrawlerMucus : Item
	{
		public CrawlerMucus() : base()
		{
			Id = 4888;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3788;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crawler Mucus";
			Name2 = "Crawler Mucus";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Taillasher Egg)
*
***************************************************************/

namespace Server.Items
{
	public class TaillasherEgg : Item
	{
		public TaillasherEgg() : base()
		{
			Id = 4890;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18047;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Taillasher Egg";
			Name2 = "Taillasher Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Kron's Amulet)
*
***************************************************************/

namespace Server.Items
{
	public class KronsAmulet : Item
	{
		public KronsAmulet() : base()
		{
			Id = 4891;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4841;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kron's Amulet";
			Name2 = "Kron's Amulet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Durotar Tiger Fur)
*
***************************************************************/

namespace Server.Items
{
	public class DurotarTigerFur : Item
	{
		public DurotarTigerFur() : base()
		{
			Id = 4892;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7112;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Durotar Tiger Fur";
			Name2 = "Durotar Tiger Fur";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Savannah Lion Tusk)
*
***************************************************************/

namespace Server.Items
{
	public class SavannahLionTusk : Item
	{
		public SavannahLionTusk() : base()
		{
			Id = 4893;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3672;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Savannah Lion Tusk";
			Name2 = "Savannah Lion Tusk";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Plainstrider Kidney)
*
***************************************************************/

namespace Server.Items
{
	public class PlainstriderKidney : Item
	{
		public PlainstriderKidney() : base()
		{
			Id = 4894;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3759;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Plainstrider Kidney";
			Name2 = "Plainstrider Kidney";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Thunder Lizard Horn)
*
***************************************************************/

namespace Server.Items
{
	public class ThunderLizardHorn : Item
	{
		public ThunderLizardHorn() : base()
		{
			Id = 4895;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7089;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thunder Lizard Horn";
			Name2 = "Thunder Lizard Horn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Kodo Liver)
*
***************************************************************/

namespace Server.Items
{
	public class KodoLiver : Item
	{
		public KodoLiver() : base()
		{
			Id = 4896;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 5287;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kodo Liver";
			Name2 = "Kodo Liver";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Thunderhawk Saliva Gland)
*
***************************************************************/

namespace Server.Items
{
	public class ThunderhawkSalivaGland : Item
	{
		public ThunderhawkSalivaGland() : base()
		{
			Id = 4897;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6694;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thunderhawk Saliva Gland";
			Name2 = "Thunderhawk Saliva Gland";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Lightning Gland)
*
***************************************************************/

namespace Server.Items
{
	public class LightningGland : Item
	{
		public LightningGland() : base()
		{
			Id = 4898;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 5283;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lightning Gland";
			Name2 = "Lightning Gland";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Eye of Burning Shadow)
*
***************************************************************/

namespace Server.Items
{
	public class EyeOfBurningShadow : Item
	{
		public EyeOfBurningShadow() : base()
		{
			Id = 4903;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7122;
			ObjectClass = 12;
			SubClass = 0;
			Level = 4;
			ReqLevel = 4;
			Name = "Eye of Burning Shadow";
			Name2 = "Eye of Burning Shadow";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 832;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Venomtail Antidote)
*
***************************************************************/

namespace Server.Items
{
	public class VenomtailAntidote : Item
	{
		public VenomtailAntidote() : base()
		{
			Id = 4904;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2533;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Venomtail Antidote";
			Name2 = "Venomtail Antidote";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sarkoth's Mangled Claw)
*
***************************************************************/

namespace Server.Items
{
	public class SarkothsMangledClaw : Item
	{
		public SarkothsMangledClaw() : base()
		{
			Id = 4905;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3146;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sarkoth's Mangled Claw";
			Name2 = "Sarkoth's Mangled Claw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Sack of Supplies)
*
***************************************************************/

namespace Server.Items
{
	public class SackOfSupplies : Item
	{
		public SackOfSupplies() : base()
		{
			Id = 4918;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1183;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sack of Supplies";
			Name2 = "Sack of Supplies";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Chen's Empty Keg)
*
***************************************************************/

namespace Server.Items
{
	public class ChensEmptyKeg : Item
	{
		public ChensEmptyKeg() : base()
		{
			Id = 4926;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 18116;
			ObjectClass = 12;
			SubClass = 0;
			Level = 11;
			ReqLevel = 11;
			Name = "Chen's Empty Keg";
			Name2 = "Chen's Empty Keg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 819;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Flawed Power Stone)
*
***************************************************************/

namespace Server.Items
{
	public class FlawedPowerStone : Item
	{
		public FlawedPowerStone() : base()
		{
			Id = 4986;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6521;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Flawed Power Stone";
			Name2 = "Flawed Power Stone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 5099 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Recruitment Letter)
*
***************************************************************/

namespace Server.Items
{
	public class RecruitmentLetter : Item
	{
		public RecruitmentLetter() : base()
		{
			Id = 4992;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "An unsigned recruitment letter.";
			Model = 5567;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Recruitment Letter";
			Name2 = "Recruitment Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 340;
			Language = 1;
		}
	}
}


/**************************************************************
*
*				(Signed Recruitment Letter)
*
***************************************************************/

namespace Server.Items
{
	public class SignedRecruitmentLetter : Item
	{
		public SignedRecruitmentLetter() : base()
		{
			Id = 4995;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 5567;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Signed Recruitment Letter";
			Name2 = "Signed Recruitment Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 341;
			Language = 1;
		}
	}
}


/**************************************************************
*
*				(Khazgorm's Journal)
*
***************************************************************/

namespace Server.Items
{
	public class KhazgormsJournal : Item
	{
		public KhazgormsJournal() : base()
		{
			Id = 5006;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7152;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Khazgorm's Journal";
			Name2 = "Khazgorm's Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 342;
		}
	}
}


/**************************************************************
*
*				(Fungal Spores)
*
***************************************************************/

namespace Server.Items
{
	public class FungalSpores : Item
	{
		public FungalSpores() : base()
		{
			Id = 5012;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7127;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fungal Spores";
			Name2 = "Fungal Spores";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Nitroglycerin)
*
***************************************************************/

namespace Server.Items
{
	public class Nitroglycerin : Item
	{
		public Nitroglycerin() : base()
		{
			Id = 5017;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1150;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nitroglycerin";
			Name2 = "Nitroglycerin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Wood Pulp)
*
***************************************************************/

namespace Server.Items
{
	public class WoodPulp : Item
	{
		public WoodPulp() : base()
		{
			Id = 5018;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7290;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wood Pulp";
			Name2 = "Wood Pulp";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sodium Nitrate)
*
***************************************************************/

namespace Server.Items
{
	public class SodiumNitrate : Item
	{
		public SodiumNitrate() : base()
		{
			Id = 5019;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7256;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sodium Nitrate";
			Name2 = "Sodium Nitrate";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Explosive Stick of Gann)
*
***************************************************************/

namespace Server.Items
{
	public class ExplosiveStickOfGann : Item
	{
		public ExplosiveStickOfGann() : base()
		{
			Id = 5021;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18062;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Explosive Stick of Gann";
			Name2 = "Explosive Stick of Gann";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
			Flags = 64;
			SetSpell( 5140 , 0 , -1 , 1000 , 0 , 0 );
		}
	}
}


/**************************************************************
*
*				(Barak's Head)
*
***************************************************************/

namespace Server.Items
{
	public class BaraksHead : Item
	{
		public BaraksHead() : base()
		{
			Id = 5022;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12904;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Barak's Head";
			Name2 = "Barak's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Verog's Head)
*
***************************************************************/

namespace Server.Items
{
	public class VerogsHead : Item
	{
		public VerogsHead() : base()
		{
			Id = 5023;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12904;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Verog's Head";
			Name2 = "Verog's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Hezrul's Head)
*
***************************************************************/

namespace Server.Items
{
	public class HezrulsHead : Item
	{
		public HezrulsHead() : base()
		{
			Id = 5025;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12904;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hezrul's Head";
			Name2 = "Hezrul's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Fire Tar)
*
***************************************************************/

namespace Server.Items
{
	public class FireTar : Item
	{
		public FireTar() : base()
		{
			Id = 5026;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9518;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fire Tar";
			Name2 = "Fire Tar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = 3;
		}
	}
}


/**************************************************************
*
*				(Rendered Spores)
*
***************************************************************/

namespace Server.Items
{
	public class RenderedSpores : Item
	{
		public RenderedSpores() : base()
		{
			Id = 5027;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1282;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rendered Spores";
			Name2 = "Rendered Spores";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Centaur Bracers)
*
***************************************************************/

namespace Server.Items
{
	public class CentaurBracers : Item
	{
		public CentaurBracers() : base()
		{
			Id = 5030;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7070;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Centaur Bracers";
			Name2 = "Centaur Bracers";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tear of the Moons)
*
***************************************************************/

namespace Server.Items
{
	public class TearOfTheMoons : Item
	{
		public TearOfTheMoons() : base()
		{
			Id = 5038;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7267;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tear of the Moons";
			Name2 = "Tear of the Moons";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dig Rat)
*
***************************************************************/

namespace Server.Items
{
	public class DigRat : Item
	{
		public DigRat() : base()
		{
			Id = 5051;
			SellPrice = 1;
			AvailableClasses = 0x7FFF;
			Model = 7107;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dig Rat";
			Name2 = "Dig Rat";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Samophlange)
*
***************************************************************/

namespace Server.Items
{
	public class Samophlange : Item
	{
		public Samophlange() : base()
		{
			Id = 5054;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9167;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Samophlange";
			Name2 = "Samophlange";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Intact Raptor Horn)
*
***************************************************************/

namespace Server.Items
{
	public class IntactRaptorHorn : Item
	{
		public IntactRaptorHorn() : base()
		{
			Id = 5055;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7048;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Intact Raptor Horn";
			Name2 = "Intact Raptor Horn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Root Sample)
*
***************************************************************/

namespace Server.Items
{
	public class RootSample : Item
	{
		public RootSample() : base()
		{
			Id = 5056;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1464;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Root Sample";
			Name2 = "Root Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Silithid Egg)
*
***************************************************************/

namespace Server.Items
{
	public class SilithidEgg : Item
	{
		public SilithidEgg() : base()
		{
			Id = 5058;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18050;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Silithid Egg";
			Name2 = "Silithid Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Digging Claw)
*
***************************************************************/

namespace Server.Items
{
	public class DiggingClaw : Item
	{
		public DiggingClaw() : base()
		{
			Id = 5059;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7108;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Digging Claw";
			Name2 = "Digging Claw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 5166 , 0 , 0 , 1000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Stolen Silver)
*
***************************************************************/

namespace Server.Items
{
	public class StolenSilver : Item
	{
		public StolenSilver() : base()
		{
			Id = 5061;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7260;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stolen Silver";
			Name2 = "Stolen Silver";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Raptor Head)
*
***************************************************************/

namespace Server.Items
{
	public class RaptorHead : Item
	{
		public RaptorHead() : base()
		{
			Id = 5062;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9826;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Raptor Head";
			Name2 = "Raptor Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Kreenig Snarlsnout's Tusk)
*
***************************************************************/

namespace Server.Items
{
	public class KreenigSnarlsnoutsTusk : Item
	{
		public KreenigSnarlsnoutsTusk() : base()
		{
			Id = 5063;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7154;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kreenig Snarlsnout's Tusk";
			Name2 = "Kreenig Snarlsnout's Tusk";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Witchwing Talon)
*
***************************************************************/

namespace Server.Items
{
	public class WitchwingTalon : Item
	{
		public WitchwingTalon() : base()
		{
			Id = 5064;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7288;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Witchwing Talon";
			Name2 = "Witchwing Talon";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Harpy Lieutenant Ring)
*
***************************************************************/

namespace Server.Items
{
	public class HarpyLieutenantRing : Item
	{
		public HarpyLieutenantRing() : base()
		{
			Id = 5065;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6013;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Harpy Lieutenant Ring";
			Name2 = "Harpy Lieutenant Ring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Serena's Head)
*
***************************************************************/

namespace Server.Items
{
	public class SerenasHead : Item
	{
		public SerenasHead() : base()
		{
			Id = 5067;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7235;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Serena's Head";
			Name2 = "Serena's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Dried Seeds)
*
***************************************************************/

namespace Server.Items
{
	public class DriedSeeds : Item
	{
		public DriedSeeds() : base()
		{
			Id = 5068;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6371;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dried Seeds";
			Name2 = "Dried Seeds";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 5206 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Lok's Skull)
*
***************************************************************/

namespace Server.Items
{
	public class LoksSkull : Item
	{
		public LoksSkull() : base()
		{
			Id = 5072;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7101;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lok's Skull";
			Name2 = "Lok's Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Nak's Skull)
*
***************************************************************/

namespace Server.Items
{
	public class NaksSkull : Item
	{
		public NaksSkull() : base()
		{
			Id = 5073;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7101;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nak's Skull";
			Name2 = "Nak's Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Kuz's Skull)
*
***************************************************************/

namespace Server.Items
{
	public class KuzsSkull : Item
	{
		public KuzsSkull() : base()
		{
			Id = 5074;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7101;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kuz's Skull";
			Name2 = "Kuz's Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Blood Shard)
*
***************************************************************/

namespace Server.Items
{
	public class BloodShard : Item
	{
		public BloodShard() : base()
		{
			Id = 5075;
			SellPrice = 25;
			AvailableClasses = 0x7FFF;
			Model = 7045;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blood Shard";
			Name2 = "Blood Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 100;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Shipment of Boots)
*
***************************************************************/

namespace Server.Items
{
	public class ShipmentOfBoots : Item
	{
		public ShipmentOfBoots() : base()
		{
			Id = 5076;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7242;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shipment of Boots";
			Name2 = "Shipment of Boots";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Telescopic Lens)
*
***************************************************************/

namespace Server.Items
{
	public class TelescopicLens : Item
	{
		public TelescopicLens() : base()
		{
			Id = 5077;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7268;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Telescopic Lens";
			Name2 = "Telescopic Lens";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Theramore Medal)
*
***************************************************************/

namespace Server.Items
{
	public class TheramoreMedal : Item
	{
		public TheramoreMedal() : base()
		{
			Id = 5078;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7271;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Theramore Medal";
			Name2 = "Theramore Medal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gazlowe's Ledger)
*
***************************************************************/

namespace Server.Items
{
	public class GazlowesLedger : Item
	{
		public GazlowesLedger() : base()
		{
			Id = 5080;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1134;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gazlowe's Ledger";
			Name2 = "Gazlowe's Ledger";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Baron Longshore's Head)
*
***************************************************************/

namespace Server.Items
{
	public class BaronLongshoresHead : Item
	{
		public BaronLongshoresHead() : base()
		{
			Id = 5084;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7038;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Baron Longshore's Head";
			Name2 = "Baron Longshore's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bristleback Quilboar Tusk)
*
***************************************************************/

namespace Server.Items
{
	public class BristlebackQuilboarTusk : Item
	{
		public BristlebackQuilboarTusk() : base()
		{
			Id = 5085;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7209;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bristleback Quilboar Tusk";
			Name2 = "Bristleback Quilboar Tusk";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Zhevra Hooves)
*
***************************************************************/

namespace Server.Items
{
	public class ZhevraHooves : Item
	{
		public ZhevraHooves() : base()
		{
			Id = 5086;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7295;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Zhevra Hooves";
			Name2 = "Zhevra Hooves";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Plainstrider Beak)
*
***************************************************************/

namespace Server.Items
{
	public class PlainstriderBeak : Item
	{
		public PlainstriderBeak() : base()
		{
			Id = 5087;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6633;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Plainstrider Beak";
			Name2 = "Plainstrider Beak";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Control Console Operating Manual)
*
***************************************************************/

namespace Server.Items
{
	public class ControlConsoleOperatingManual : Item
	{
		public ControlConsoleOperatingManual() : base()
		{
			Id = 5088;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "Venture Co. Document 534x9";
			Model = 7073;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Control Console Operating Manual";
			Name2 = "Control Console Operating Manual";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 350;
		}
	}
}


/**************************************************************
*
*				(Prowler Claws)
*
***************************************************************/

namespace Server.Items
{
	public class ProwlerClaws : Item
	{
		public ProwlerClaws() : base()
		{
			Id = 5096;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7204;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Prowler Claws";
			Name2 = "Prowler Claws";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Cats Eye Emerald)
*
***************************************************************/

namespace Server.Items
{
	public class CatsEyeEmerald : Item
	{
		public CatsEyeEmerald() : base()
		{
			Id = 5097;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6851;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cats Eye Emerald";
			Name2 = "Cats Eye Emerald";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Altered Snapjaw Shell)
*
***************************************************************/

namespace Server.Items
{
	public class AlteredSnapjawShell : Item
	{
		public AlteredSnapjawShell() : base()
		{
			Id = 5098;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17460;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Altered Snapjaw Shell";
			Name2 = "Altered Snapjaw Shell";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Hoof of Lakota'mani)
*
***************************************************************/

namespace Server.Items
{
	public class HoofOfLakotamani : Item
	{
		public HoofOfLakotamani() : base()
		{
			Id = 5099;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7144;
			ObjectClass = 12;
			SubClass = 0;
			Level = 10;
			ReqLevel = 10;
			Name = "Hoof of Lakota'mani";
			Name2 = "Hoof of Lakota'mani";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 883;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Echeyakee's Hide)
*
***************************************************************/

namespace Server.Items
{
	public class EcheyakeesHide : Item
	{
		public EcheyakeesHide() : base()
		{
			Id = 5100;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7086;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Echeyakee's Hide";
			Name2 = "Echeyakee's Hide";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ishamuhale's Fang)
*
***************************************************************/

namespace Server.Items
{
	public class IshamuhalesFang : Item
	{
		public IshamuhalesFang() : base()
		{
			Id = 5101;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6666;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ishamuhale's Fang";
			Name2 = "Ishamuhale's Fang";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Owatanka's Tailspike)
*
***************************************************************/

namespace Server.Items
{
	public class OwatankasTailspike : Item
	{
		public OwatankasTailspike() : base()
		{
			Id = 5102;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 8007;
			ObjectClass = 12;
			SubClass = 0;
			Level = 10;
			ReqLevel = 10;
			Name = "Owatanka's Tailspike";
			Name2 = "Owatanka's Tailspike";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 884;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Washte Pawne's Feather)
*
***************************************************************/

namespace Server.Items
{
	public class WashtePawnesFeather : Item
	{
		public WashtePawnesFeather() : base()
		{
			Id = 5103;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 11207;
			ObjectClass = 12;
			SubClass = 0;
			Level = 10;
			ReqLevel = 10;
			Name = "Washte Pawne's Feather";
			Name2 = "Washte Pawne's Feather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 885;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Heart of Isha Awak)
*
***************************************************************/

namespace Server.Items
{
	public class HeartOfIshaAwak : Item
	{
		public HeartOfIshaAwak() : base()
		{
			Id = 5104;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7142;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Heart of Isha Awak";
			Name2 = "Heart of Isha Awak";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Harvester's Head)
*
***************************************************************/

namespace Server.Items
{
	public class HarvestersHead : Item
	{
		public HarvestersHead() : base()
		{
			Id = 5138;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 15525;
			ObjectClass = 12;
			SubClass = 0;
			Level = 10;
			ReqLevel = 10;
			Name = "Harvester's Head";
			Name2 = "Harvester's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 897;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Thunder Lizard Blood)
*
***************************************************************/

namespace Server.Items
{
	public class ThunderLizardBlood : Item
	{
		public ThunderLizardBlood() : base()
		{
			Id = 5143;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7262;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thunder Lizard Blood";
			Name2 = "Thunder Lizard Blood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Thunderhawk Wings)
*
***************************************************************/

namespace Server.Items
{
	public class ThunderhawkWings : Item
	{
		public ThunderhawkWings() : base()
		{
			Id = 5164;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8284;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thunderhawk Wings";
			Name2 = "Thunderhawk Wings";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Sunscale Feather)
*
***************************************************************/

namespace Server.Items
{
	public class SunscaleFeather : Item
	{
		public SunscaleFeather() : base()
		{
			Id = 5165;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19799;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sunscale Feather";
			Name2 = "Sunscale Feather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 64;
			SetSpell( 5316 , 0 , -1 , 10000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Webwood Venom Sac)
*
***************************************************************/

namespace Server.Items
{
	public class WebwoodVenomSac : Item
	{
		public WebwoodVenomSac() : base()
		{
			Id = 5166;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4045;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Webwood Venom Sac";
			Name2 = "Webwood Venom Sac";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Webwood Egg)
*
***************************************************************/

namespace Server.Items
{
	public class WebwoodEgg : Item
	{
		public WebwoodEgg() : base()
		{
			Id = 5167;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18047;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Webwood Egg";
			Name2 = "Webwood Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Timberling Seed)
*
***************************************************************/

namespace Server.Items
{
	public class TimberlingSeed : Item
	{
		public TimberlingSeed() : base()
		{
			Id = 5168;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7273;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Timberling Seed";
			Name2 = "Timberling Seed";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Timberling Sprout)
*
***************************************************************/

namespace Server.Items
{
	public class TimberlingSprout : Item
	{
		public TimberlingSprout() : base()
		{
			Id = 5169;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7274;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Timberling Sprout";
			Name2 = "Timberling Sprout";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mossy Tumor)
*
***************************************************************/

namespace Server.Items
{
	public class MossyTumor : Item
	{
		public MossyTumor() : base()
		{
			Id = 5170;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 5283;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mossy Tumor";
			Name2 = "Mossy Tumor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Moss-twined Heart)
*
***************************************************************/

namespace Server.Items
{
	public class MossTwinedHeart : Item
	{
		public MossTwinedHeart() : base()
		{
			Id = 5179;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 5283;
			ObjectClass = 12;
			SubClass = 0;
			Level = 5;
			ReqLevel = 5;
			Name = "Moss-twined Heart";
			Name2 = "Moss-twined Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 927;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Filled Crystal Phial)
*
***************************************************************/

namespace Server.Items
{
	public class FilledCrystalPhial : Item
	{
		public FilledCrystalPhial() : base()
		{
			Id = 5184;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7124;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Crystal Phial";
			Name2 = "Filled Crystal Phial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crystal Phial)
*
***************************************************************/

namespace Server.Items
{
	public class CrystalPhial : Item
	{
		public CrystalPhial() : base()
		{
			Id = 5185;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8545;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crystal Phial";
			Name2 = "Crystal Phial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 4976 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Partially Filled Vessel)
*
***************************************************************/

namespace Server.Items
{
	public class PartiallyFilledVessel : Item
	{
		public PartiallyFilledVessel() : base()
		{
			Id = 5186;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7125;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Partially Filled Vessel";
			Name2 = "Partially Filled Vessel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Filled Vessel)
*
***************************************************************/

namespace Server.Items
{
	public class FilledVessel : Item
	{
		public FilledVessel() : base()
		{
			Id = 5188;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7125;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Vessel";
			Name2 = "Filled Vessel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Glowing Fruit)
*
***************************************************************/

namespace Server.Items
{
	public class GlowingFruit : Item
	{
		public GlowingFruit() : base()
		{
			Id = 5189;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7130;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glowing Fruit";
			Name2 = "Glowing Fruit";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Shimmering Frond)
*
***************************************************************/

namespace Server.Items
{
	public class ShimmeringFrond : Item
	{
		public ShimmeringFrond() : base()
		{
			Id = 5190;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7240;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shimmering Frond";
			Name2 = "Shimmering Frond";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Flatland Prowler Claw)
*
***************************************************************/

namespace Server.Items
{
	public class FlatlandProwlerClaw : Item
	{
		public FlatlandProwlerClaw() : base()
		{
			Id = 5203;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6669;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Flatland Prowler Claw";
			Name2 = "Flatland Prowler Claw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bloodfeather Belt)
*
***************************************************************/

namespace Server.Items
{
	public class BloodfeatherBelt : Item
	{
		public BloodfeatherBelt() : base()
		{
			Id = 5204;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7046;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodfeather Belt";
			Name2 = "Bloodfeather Belt";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tainted Heart)
*
***************************************************************/

namespace Server.Items
{
	public class TaintedHeart : Item
	{
		public TaintedHeart() : base()
		{
			Id = 5217;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3422;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tainted Heart";
			Name2 = "Tainted Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Cleansed Timberling Heart)
*
***************************************************************/

namespace Server.Items
{
	public class CleansedTimberlingHeart : Item
	{
		public CleansedTimberlingHeart() : base()
		{
			Id = 5218;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3422;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cleansed Timberling Heart";
			Name2 = "Cleansed Timberling Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 5666 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Inscribed Bark)
*
***************************************************************/

namespace Server.Items
{
	public class InscribedBark : Item
	{
		public InscribedBark() : base()
		{
			Id = 5219;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7149;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Inscribed Bark";
			Name2 = "Inscribed Bark";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gnarlpine Fang)
*
***************************************************************/

namespace Server.Items
{
	public class GnarlpineFang : Item
	{
		public GnarlpineFang() : base()
		{
			Id = 5220;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7134;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gnarlpine Fang";
			Name2 = "Gnarlpine Fang";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Melenas' Head)
*
***************************************************************/

namespace Server.Items
{
	public class MelenasHead : Item
	{
		public MelenasHead() : base()
		{
			Id = 5221;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7164;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Melenas' Head";
			Name2 = "Melenas' Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Stone of Relu)
*
***************************************************************/

namespace Server.Items
{
	public class StoneOfRelu : Item
	{
		public StoneOfRelu() : base()
		{
			Id = 5233;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6017;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stone of Relu";
			Name2 = "Stone of Relu";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Flagongut's Fossil)
*
***************************************************************/

namespace Server.Items
{
	public class FlagongutsFossil : Item
	{
		public FlagongutsFossil() : base()
		{
			Id = 5234;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6016;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Flagongut's Fossil";
			Name2 = "Flagongut's Fossil";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Phial of Scrying)
*
***************************************************************/

namespace Server.Items
{
	public class PhialOfScrying : Item
	{
		public PhialOfScrying() : base()
		{
			Id = 5251;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8752;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Phial of Scrying";
			Name2 = "Phial of Scrying";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 5809 , 0 , -5 , 120000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Death Cap)
*
***************************************************************/

namespace Server.Items
{
	public class DeathCap : Item
	{
		public DeathCap() : base()
		{
			Id = 5270;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15857;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Death Cap";
			Name2 = "Death Cap";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Scaber Stalk)
*
***************************************************************/

namespace Server.Items
{
	public class ScaberStalk : Item
	{
		public ScaberStalk() : base()
		{
			Id = 5271;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19488;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scaber Stalk";
			Name2 = "Scaber Stalk";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Insane Scribbles)
*
***************************************************************/

namespace Server.Items
{
	public class InsaneScribbles : Item
	{
		public InsaneScribbles() : base()
		{
			Id = 5272;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6927;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Insane Scribbles";
			Name2 = "Insane Scribbles";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mathystra Relic)
*
***************************************************************/

namespace Server.Items
{
	public class MathystraRelic : Item
	{
		public MathystraRelic() : base()
		{
			Id = 5273;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13988;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mathystra Relic";
			Name2 = "Mathystra Relic";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Elven Cup Relic)
*
***************************************************************/

namespace Server.Items
{
	public class ElvenCupRelic : Item
	{
		public ElvenCupRelic() : base()
		{
			Id = 5330;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13989;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Elven Cup Relic";
			Name2 = "Elven Cup Relic";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mathystra Relic)
*
***************************************************************/

namespace Server.Items
{
	public class MathystraRelic5333 : Item
	{
		public MathystraRelic5333() : base()
		{
			Id = 5333;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13990;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mathystra Relic";
			Name2 = "Mathystra Relic";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(99-Year-Old Port)
*
***************************************************************/

namespace Server.Items
{
	public class _99YearOldPort : Item
	{
		public _99YearOldPort() : base()
		{
			Id = 5334;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18079;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "99-Year-Old Port";
			Name2 = "99-Year-Old Port";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Grell Earring)
*
***************************************************************/

namespace Server.Items
{
	public class GrellEarring : Item
	{
		public GrellEarring() : base()
		{
			Id = 5336;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9849;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Grell Earring";
			Name2 = "Grell Earring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ancient Moonstone Seal)
*
***************************************************************/

namespace Server.Items
{
	public class AncientMoonstoneSeal : Item
	{
		public AncientMoonstoneSeal() : base()
		{
			Id = 5338;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7572;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ancient Moonstone Seal";
			Name2 = "Ancient Moonstone Seal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2112;
			SetSpell( 6234 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Serpentbloom)
*
***************************************************************/

namespace Server.Items
{
	public class Serpentbloom : Item
	{
		public Serpentbloom() : base()
		{
			Id = 5339;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7573;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Serpentbloom";
			Name2 = "Serpentbloom";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Worn Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class WornParchment : Item
	{
		public WornParchment() : base()
		{
			Id = 5348;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3331;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Worn Parchment";
			Name2 = "Worn Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Book: The Powers Below)
*
***************************************************************/

namespace Server.Items
{
	public class BookThePowersBelow : Item
	{
		public BookThePowersBelow() : base()
		{
			Id = 5352;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7637;
			ObjectClass = 12;
			SubClass = 0;
			Level = 20;
			ReqLevel = 10;
			Name = "Book: The Powers Below";
			Name2 = "Book: The Powers Below";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 968;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Letter to Delgren)
*
***************************************************************/

namespace Server.Items
{
	public class LetterToDelgren : Item
	{
		public LetterToDelgren() : base()
		{
			Id = 5354;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8919;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Letter to Delgren";
			Name2 = "Letter to Delgren";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 361;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Lorgalis Manuscript)
*
***************************************************************/

namespace Server.Items
{
	public class LorgalisManuscript : Item
	{
		public LorgalisManuscript() : base()
		{
			Id = 5359;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lorgalis Manuscript";
			Name2 = "Lorgalis Manuscript";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 794;
		}
	}
}


/**************************************************************
*
*				(Highborne Relic)
*
***************************************************************/

namespace Server.Items
{
	public class HighborneRelic : Item
	{
		public HighborneRelic() : base()
		{
			Id = 5360;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7697;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Highborne Relic";
			Name2 = "Highborne Relic";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Glowing Soul Gem)
*
***************************************************************/

namespace Server.Items
{
	public class GlowingSoulGem : Item
	{
		public GlowingSoulGem() : base()
		{
			Id = 5366;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6554;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glowing Soul Gem";
			Name2 = "Glowing Soul Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Anaya's Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class AnayasPendant : Item
	{
		public AnayasPendant() : base()
		{
			Id = 5382;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7735;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Anaya's Pendant";
			Name2 = "Anaya's Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Athrikus Narassin's Head)
*
***************************************************************/

namespace Server.Items
{
	public class AthrikusNarassinsHead : Item
	{
		public AthrikusNarassinsHead() : base()
		{
			Id = 5383;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7164;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Athrikus Narassin's Head";
			Name2 = "Athrikus Narassin's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			Language = 8;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Crawler Leg)
*
***************************************************************/

namespace Server.Items
{
	public class CrawlerLeg : Item
	{
		public CrawlerLeg() : base()
		{
			Id = 5385;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8007;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crawler Leg";
			Name2 = "Crawler Leg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fine Moonstalker Pelt)
*
***************************************************************/

namespace Server.Items
{
	public class FineMoonstalkerPelt : Item
	{
		public FineMoonstalkerPelt() : base()
		{
			Id = 5386;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7740;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fine Moonstalker Pelt";
			Name2 = "Fine Moonstalker Pelt";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ran Bloodtooth's Skull)
*
***************************************************************/

namespace Server.Items
{
	public class RanBloodtoothsSkull : Item
	{
		public RanBloodtoothsSkull() : base()
		{
			Id = 5388;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7741;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ran Bloodtooth's Skull";
			Name2 = "Ran Bloodtooth's Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Corrupted Furbolg Totem)
*
***************************************************************/

namespace Server.Items
{
	public class CorruptedFurbolgTotem : Item
	{
		public CorruptedFurbolgTotem() : base()
		{
			Id = 5389;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7742;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Corrupted Furbolg Totem";
			Name2 = "Corrupted Furbolg Totem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Fandral's Message)
*
***************************************************************/

namespace Server.Items
{
	public class FandralsMessage : Item
	{
		public FandralsMessage() : base()
		{
			Id = 5390;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7744;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fandral's Message";
			Name2 = "Fandral's Message";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Rare Earth)
*
***************************************************************/

namespace Server.Items
{
	public class RareEarth : Item
	{
		public RareEarth() : base()
		{
			Id = 5391;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7791;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rare Earth";
			Name2 = "Rare Earth";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Thresher Eye)
*
***************************************************************/

namespace Server.Items
{
	public class ThresherEye : Item
	{
		public ThresherEye() : base()
		{
			Id = 5412;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6492;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thresher Eye";
			Name2 = "Thresher Eye";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Moonstalker Fang)
*
***************************************************************/

namespace Server.Items
{
	public class MoonstalkerFang : Item
	{
		public MoonstalkerFang() : base()
		{
			Id = 5413;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7886;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Moonstalker Fang";
			Name2 = "Moonstalker Fang";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Grizzled Scalp)
*
***************************************************************/

namespace Server.Items
{
	public class GrizzledScalp : Item
	{
		public GrizzledScalp() : base()
		{
			Id = 5414;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6683;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Grizzled Scalp";
			Name2 = "Grizzled Scalp";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Thunderhorn Cleansing Totem)
*
***************************************************************/

namespace Server.Items
{
	public class ThunderhornCleansingTotem : Item
	{
		public ThunderhornCleansingTotem() : base()
		{
			Id = 5415;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7866;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thunderhorn Cleansing Totem";
			Name2 = "Thunderhorn Cleansing Totem";
			Quality = 1;
			AvailableRaces = 0x20;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
			Sheath = 2;
			Flags = 64;
			SetSpell( 4977 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Wildmane Cleansing Totem)
*
***************************************************************/

namespace Server.Items
{
	public class WildmaneCleansingTotem : Item
	{
		public WildmaneCleansingTotem() : base()
		{
			Id = 5416;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7866;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wildmane Cleansing Totem";
			Name2 = "Wildmane Cleansing Totem";
			Quality = 1;
			AvailableRaces = 0x20;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
			Sheath = 2;
			Flags = 64;
			SetSpell( 4978 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Ancient Statuette)
*
***************************************************************/

namespace Server.Items
{
	public class AncientStatuette : Item
	{
		public AncientStatuette() : base()
		{
			Id = 5424;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7928;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ancient Statuette";
			Name2 = "Ancient Statuette";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bathran's Hair)
*
***************************************************************/

namespace Server.Items
{
	public class BathransHair : Item
	{
		public BathransHair() : base()
		{
			Id = 5437;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1442;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bathran's Hair";
			Name2 = "Bathran's Hair";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bottle of Disease)
*
***************************************************************/

namespace Server.Items
{
	public class BottleOfDisease : Item
	{
		public BottleOfDisease() : base()
		{
			Id = 5440;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3788;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bottle of Disease";
			Name2 = "Bottle of Disease";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Head of Arugal)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfArugal : Item
	{
		public HeadOfArugal() : base()
		{
			Id = 5442;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7951;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Arugal";
			Name2 = "Head of Arugal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ring of Zoram)
*
***************************************************************/

namespace Server.Items
{
	public class RingOfZoram : Item
	{
		public RingOfZoram() : base()
		{
			Id = 5445;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9865;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ring of Zoram";
			Name2 = "Ring of Zoram";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Broken Elemental Bracer)
*
***************************************************************/

namespace Server.Items
{
	public class BrokenElementalBracer : Item
	{
		public BrokenElementalBracer() : base()
		{
			Id = 5446;
			SellPrice = 13;
			AvailableClasses = 0x7FFF;
			Model = 7954;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Broken Elemental Bracer";
			Name2 = "Broken Elemental Bracer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 55;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Damaged Elemental Bracer)
*
***************************************************************/

namespace Server.Items
{
	public class DamagedElementalBracer : Item
	{
		public DamagedElementalBracer() : base()
		{
			Id = 5447;
			SellPrice = 20;
			AvailableClasses = 0x7FFF;
			Model = 7954;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Damaged Elemental Bracer";
			Name2 = "Damaged Elemental Bracer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 80;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fractured Elemental Bracer)
*
***************************************************************/

namespace Server.Items
{
	public class FracturedElementalBracer : Item
	{
		public FracturedElementalBracer() : base()
		{
			Id = 5448;
			SellPrice = 17;
			AvailableClasses = 0x7FFF;
			Model = 7954;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fractured Elemental Bracer";
			Name2 = "Fractured Elemental Bracer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 70;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crushed Elemental Bracer)
*
***************************************************************/

namespace Server.Items
{
	public class CrushedElementalBracer : Item
	{
		public CrushedElementalBracer() : base()
		{
			Id = 5451;
			SellPrice = 22;
			AvailableClasses = 0x7FFF;
			Model = 7954;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crushed Elemental Bracer";
			Name2 = "Crushed Elemental Bracer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 90;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Divined Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class DivinedScroll : Item
	{
		public DivinedScroll() : base()
		{
			Id = 5455;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "This paper is covered in glowing runes.";
			Model = 7957;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Divined Scroll";
			Name2 = "Divined Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 394;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Divining Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class DiviningScroll : Item
	{
		public DiviningScroll() : base()
		{
			Id = 5456;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The paper is blank save for a few runes. You'll need bracers from the elementals to use it.";
			Model = 7956;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Divining Scroll";
			Name2 = "Divining Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 1024;
			SetSpell( 6310 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Orendil's Cure)
*
***************************************************************/

namespace Server.Items
{
	public class OrendilsCure : Item
	{
		public OrendilsCure() : base()
		{
			Id = 5460;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7976;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Orendil's Cure";
			Name2 = "Orendil's Cure";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Branch of Cenarius)
*
***************************************************************/

namespace Server.Items
{
	public class BranchOfCenarius : Item
	{
		public BranchOfCenarius() : base()
		{
			Id = 5461;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9659;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Branch of Cenarius";
			Name2 = "Branch of Cenarius";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Dartol's Rod of Transformation)
*
***************************************************************/

namespace Server.Items
{
	public class DartolsRodOfTransformation : Item
	{
		public DartolsRodOfTransformation() : base()
		{
			Id = 5462;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7982;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dartol's Rod of Transformation";
			Name2 = "Dartol's Rod of Transformation";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 6405 , 0 , 0 , 60000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Glowing Gem)
*
***************************************************************/

namespace Server.Items
{
	public class GlowingGem : Item
	{
		public GlowingGem() : base()
		{
			Id = 5463;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7984;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glowing Gem";
			Name2 = "Glowing Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Iron Shaft)
*
***************************************************************/

namespace Server.Items
{
	public class IronShaft : Item
	{
		public IronShaft() : base()
		{
			Id = 5464;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8033;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Iron Shaft";
			Name2 = "Iron Shaft";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Satyr Horns)
*
***************************************************************/

namespace Server.Items
{
	public class SatyrHorns : Item
	{
		public SatyrHorns() : base()
		{
			Id = 5481;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7999;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Satyr Horns";
			Name2 = "Satyr Horns";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Wrathtail Head)
*
***************************************************************/

namespace Server.Items
{
	public class WrathtailHead : Item
	{
		public WrathtailHead() : base()
		{
			Id = 5490;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8009;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wrathtail Head";
			Name2 = "Wrathtail Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Elune's Tear)
*
***************************************************************/

namespace Server.Items
{
	public class ElunesTear : Item
	{
		public ElunesTear() : base()
		{
			Id = 5493;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13120;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Elune's Tear";
			Name2 = "Elune's Tear";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Handful of Stardust)
*
***************************************************************/

namespace Server.Items
{
	public class HandfulOfStardust : Item
	{
		public HandfulOfStardust() : base()
		{
			Id = 5494;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8014;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Handful of Stardust";
			Name2 = "Handful of Stardust";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Teronis' Journal)
*
***************************************************************/

namespace Server.Items
{
	public class TeronisJournal : Item
	{
		public TeronisJournal() : base()
		{
			Id = 5505;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The journal is waterlogged, but in otherwise good condition.";
			Model = 7152;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Teronis' Journal";
			Name2 = "Teronis' Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 403;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Fallen Moonstone)
*
***************************************************************/

namespace Server.Items
{
	public class FallenMoonstone : Item
	{
		public FallenMoonstone() : base()
		{
			Id = 5508;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8025;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fallen Moonstone";
			Name2 = "Fallen Moonstone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Iron Pommel)
*
***************************************************************/

namespace Server.Items
{
	public class IronPommel : Item
	{
		public IronPommel() : base()
		{
			Id = 5519;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8032;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Iron Pommel";
			Name2 = "Iron Pommel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Velinde's Journal)
*
***************************************************************/

namespace Server.Items
{
	public class VelindesJournal : Item
	{
		public VelindesJournal() : base()
		{
			Id = 5520;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8040;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Velinde's Journal";
			Name2 = "Velinde's Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			PageText = 396;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Velinde's Key)
*
***************************************************************/

namespace Server.Items
{
	public class VelindesKey : Item
	{
		public VelindesKey() : base()
		{
			Id = 5521;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8042;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Velinde's Key";
			Name2 = "Velinde's Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 3366 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Ilkrud Magthrull's Tome)
*
***************************************************************/

namespace Server.Items
{
	public class IlkrudMagthrullsTome : Item
	{
		public IlkrudMagthrullsTome() : base()
		{
			Id = 5533;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9129;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ilkrud Magthrull's Tome";
			Name2 = "Ilkrud Magthrull's Tome";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Parker's Lunch)
*
***************************************************************/

namespace Server.Items
{
	public class ParkersLunch : Item
	{
		public ParkersLunch() : base()
		{
			Id = 5534;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7416;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Parker's Lunch";
			Name2 = "Parker's Lunch";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Compendium of the Fallen)
*
***************************************************************/

namespace Server.Items
{
	public class CompendiumOfTheFallen : Item
	{
		public CompendiumOfTheFallen() : base()
		{
			Id = 5535;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Compendium of the Fallen";
			Name2 = "Compendium of the Fallen";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 572;
		}
	}
}


/**************************************************************
*
*				(Mythology of the Titans)
*
***************************************************************/

namespace Server.Items
{
	public class MythologyOfTheTitans : Item
	{
		public MythologyOfTheTitans() : base()
		{
			Id = 5536;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8094;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mythology of the Titans";
			Name2 = "Mythology of the Titans";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 575;
		}
	}
}


/**************************************************************
*
*				(Sarilus Foulborne's Head)
*
***************************************************************/

namespace Server.Items
{
	public class SarilusFoulbornesHead : Item
	{
		public SarilusFoulbornesHead() : base()
		{
			Id = 5537;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3486;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sarilus Foulborne's Head";
			Name2 = "Sarilus Foulborne's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Vorrel's Wedding Ring)
*
***************************************************************/

namespace Server.Items
{
	public class VorrelsWeddingRing : Item
	{
		public VorrelsWeddingRing() : base()
		{
			Id = 5538;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8096;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vorrel's Wedding Ring";
			Name2 = "Vorrel's Wedding Ring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Letter of Commendation)
*
***************************************************************/

namespace Server.Items
{
	public class LetterOfCommendation : Item
	{
		public LetterOfCommendation() : base()
		{
			Id = 5539;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Sealed by Brother Anton of the Scarlet Crusade";
			Model = 8097;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Letter of Commendation";
			Name2 = "Letter of Commendation";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dal Bloodclaw's Skull)
*
***************************************************************/

namespace Server.Items
{
	public class DalBloodclawsSkull : Item
	{
		public DalBloodclawsSkull() : base()
		{
			Id = 5544;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7741;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dal Bloodclaw's Skull";
			Name2 = "Dal Bloodclaw's Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Reconstructed Rod)
*
***************************************************************/

namespace Server.Items
{
	public class ReconstructedRod : Item
	{
		public ReconstructedRod() : base()
		{
			Id = 5547;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 8122;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Reconstructed Rod";
			Name2 = "Reconstructed Rod";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Deepmoss Egg)
*
***************************************************************/

namespace Server.Items
{
	public class DeepmossEgg : Item
	{
		public DeepmossEgg() : base()
		{
			Id = 5570;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18050;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Deepmoss Egg";
			Name2 = "Deepmoss Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Stonetalon Sap)
*
***************************************************************/

namespace Server.Items
{
	public class StonetalonSap : Item
	{
		public StonetalonSap() : base()
		{
			Id = 5582;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8283;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stonetalon Sap";
			Name2 = "Stonetalon Sap";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fey Dragon Scale)
*
***************************************************************/

namespace Server.Items
{
	public class FeyDragonScale : Item
	{
		public FeyDragonScale() : base()
		{
			Id = 5583;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8284;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fey Dragon Scale";
			Name2 = "Fey Dragon Scale";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Twilight Whisker)
*
***************************************************************/

namespace Server.Items
{
	public class TwilightWhisker : Item
	{
		public TwilightWhisker() : base()
		{
			Id = 5584;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18096;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Twilight Whisker";
			Name2 = "Twilight Whisker";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Courser Eye)
*
***************************************************************/

namespace Server.Items
{
	public class CourserEye : Item
	{
		public CourserEye() : base()
		{
			Id = 5585;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6492;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Courser Eye";
			Name2 = "Courser Eye";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Lydon's Toxin)
*
***************************************************************/

namespace Server.Items
{
	public class LydonsToxin : Item
	{
		public LydonsToxin() : base()
		{
			Id = 5588;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7976;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lydon's Toxin";
			Name2 = "Lydon's Toxin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Letter to Jin'Zil)
*
***************************************************************/

namespace Server.Items
{
	public class LetterToJinZil : Item
	{
		public LetterToJinZil() : base()
		{
			Id = 5594;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7649;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Letter to Jin'Zil";
			Name2 = "Letter to Jin'Zil";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 415;
			Language = 1;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Jade Phial)
*
***************************************************************/

namespace Server.Items
{
	public class JadePhial : Item
	{
		public JadePhial() : base()
		{
			Id = 5619;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8518;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jade Phial";
			Name2 = "Jade Phial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 6609 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Vial of Innocent Blood)
*
***************************************************************/

namespace Server.Items
{
	public class VialOfInnocentBlood : Item
	{
		public VialOfInnocentBlood() : base()
		{
			Id = 5620;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7206;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vial of Innocent Blood";
			Name2 = "Vial of Innocent Blood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tourmaline Phial)
*
***************************************************************/

namespace Server.Items
{
	public class TourmalinePhial : Item
	{
		public TourmalinePhial() : base()
		{
			Id = 5621;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8543;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tourmaline Phial";
			Name2 = "Tourmaline Phial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 6610 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Amethyst Phial)
*
***************************************************************/

namespace Server.Items
{
	public class AmethystPhial : Item
	{
		public AmethystPhial() : base()
		{
			Id = 5623;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8547;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Amethyst Phial";
			Name2 = "Amethyst Phial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 6611 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Zamah's Note)
*
***************************************************************/

namespace Server.Items
{
	public class ZamahsNote : Item
	{
		public ZamahsNote() : base()
		{
			Id = 5628;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6639;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Zamah's Note";
			Name2 = "Zamah's Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 448;
		}
	}
}


/**************************************************************
*
*				(Toxic Fogger)
*
***************************************************************/

namespace Server.Items
{
	public class ToxicFogger : Item
	{
		public ToxicFogger() : base()
		{
			Id = 5638;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8471;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Toxic Fogger";
			Name2 = "Toxic Fogger";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 6620 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Filled Jade Phial)
*
***************************************************************/

namespace Server.Items
{
	public class FilledJadePhial : Item
	{
		public FilledJadePhial() : base()
		{
			Id = 5639;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8523;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Jade Phial";
			Name2 = "Filled Jade Phial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Filled Tourmaline Phial)
*
***************************************************************/

namespace Server.Items
{
	public class FilledTourmalinePhial : Item
	{
		public FilledTourmalinePhial() : base()
		{
			Id = 5645;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8544;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Tourmaline Phial";
			Name2 = "Filled Tourmaline Phial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Vial of Blessed Water)
*
***************************************************************/

namespace Server.Items
{
	public class VialOfBlessedWater : Item
	{
		public VialOfBlessedWater() : base()
		{
			Id = 5646;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21672;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vial of Blessed Water";
			Name2 = "Vial of Blessed Water";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
		}
	}
}


/**************************************************************
*
*				(Smoldering Embers)
*
***************************************************************/

namespace Server.Items
{
	public class SmolderingEmbers : Item
	{
		public SmolderingEmbers() : base()
		{
			Id = 5659;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8560;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Smoldering Embers";
			Name2 = "Smoldering Embers";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Corroded Shrapnel)
*
***************************************************************/

namespace Server.Items
{
	public class CorrodedShrapnel : Item
	{
		public CorrodedShrapnel() : base()
		{
			Id = 5664;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8562;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Corroded Shrapnel";
			Name2 = "Corroded Shrapnel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dust Devil Debris)
*
***************************************************************/

namespace Server.Items
{
	public class DustDevilDebris : Item
	{
		public DustDevilDebris() : base()
		{
			Id = 5669;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2480;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dust Devil Debris";
			Name2 = "Dust Devil Debris";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Crystalized Scales)
*
***************************************************************/

namespace Server.Items
{
	public class CrystalizedScales : Item
	{
		public CrystalizedScales() : base()
		{
			Id = 5675;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8564;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crystalized Scales";
			Name2 = "Crystalized Scales";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Corrosive Sap)
*
***************************************************************/

namespace Server.Items
{
	public class CorrosiveSap : Item
	{
		public CorrosiveSap() : base()
		{
			Id = 5681;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8283;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Corrosive Sap";
			Name2 = "Corrosive Sap";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ordanus' Head)
*
***************************************************************/

namespace Server.Items
{
	public class OrdanusHead : Item
	{
		public OrdanusHead() : base()
		{
			Id = 5686;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7164;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ordanus' Head";
			Name2 = "Ordanus' Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Gatekeeper's Key)
*
***************************************************************/

namespace Server.Items
{
	public class GatekeepersKey : Item
	{
		public GatekeepersKey() : base()
		{
			Id = 5687;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6554;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gatekeeper's Key";
			Name2 = "Gatekeeper's Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 6658 , 0 , 0 , 1000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Sleepers' Key)
*
***************************************************************/

namespace Server.Items
{
	public class SleepersKey : Item
	{
		public SleepersKey() : base()
		{
			Id = 5689;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8737;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sleepers' Key";
			Name2 = "Sleepers' Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Claw Key)
*
***************************************************************/

namespace Server.Items
{
	public class ClawKey : Item
	{
		public ClawKey() : base()
		{
			Id = 5690;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7737;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Claw Key";
			Name2 = "Claw Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Barrow Key)
*
***************************************************************/

namespace Server.Items
{
	public class BarrowKey : Item
	{
		public BarrowKey() : base()
		{
			Id = 5691;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8735;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Barrow Key";
			Name2 = "Barrow Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Remote Detonator (Red))
*
***************************************************************/

namespace Server.Items
{
	public class RemoteDetonatorRed : Item
	{
		public RemoteDetonatorRed() : base()
		{
			Id = 5692;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 8622;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Remote Detonator (Red)";
			Name2 = "Remote Detonator (Red)";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 6627 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Remote Detonator (Blue))
*
***************************************************************/

namespace Server.Items
{
	public class RemoteDetonatorBlue : Item
	{
		public RemoteDetonatorBlue() : base()
		{
			Id = 5693;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 8622;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Remote Detonator (Blue)";
			Name2 = "Remote Detonator (Blue)";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 6656 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(NG-5 Explosives (Red))
*
***************************************************************/

namespace Server.Items
{
	public class NG5ExplosivesRed : Item
	{
		public NG5ExplosivesRed() : base()
		{
			Id = 5694;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 8625;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "NG-5 Explosives (Red)";
			Name2 = "NG-5 Explosives (Red)";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 6630 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(NG-5 Explosives (Blue))
*
***************************************************************/

namespace Server.Items
{
	public class NG5ExplosivesBlue : Item
	{
		public NG5ExplosivesBlue() : base()
		{
			Id = 5695;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 8625;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "NG-5 Explosives (Blue)";
			Name2 = "NG-5 Explosives (Blue)";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 6626 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Venture Co. Letters)
*
***************************************************************/

namespace Server.Items
{
	public class VentureCoLetters : Item
	{
		public VentureCoLetters() : base()
		{
			Id = 5717;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8623;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Venture Co. Letters";
			Name2 = "Venture Co. Letters";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Venture Co. Engineering Plans)
*
***************************************************************/

namespace Server.Items
{
	public class VentureCoEngineeringPlans : Item
	{
		public VentureCoEngineeringPlans() : base()
		{
			Id = 5718;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8624;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Venture Co. Engineering Plans";
			Name2 = "Venture Co. Engineering Plans";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Scroll of Messaging)
*
***************************************************************/

namespace Server.Items
{
	public class ScrollOfMessaging : Item
	{
		public ScrollOfMessaging() : base()
		{
			Id = 5731;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8626;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scroll of Messaging";
			Name2 = "Scroll of Messaging";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(NG-5)
*
***************************************************************/

namespace Server.Items
{
	public class NG5 : Item
	{
		public NG5() : base()
		{
			Id = 5732;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8627;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "NG-5";
			Name2 = "NG-5";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Unidentified Ore)
*
***************************************************************/

namespace Server.Items
{
	public class UnidentifiedOre : Item
	{
		public UnidentifiedOre() : base()
		{
			Id = 5733;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7340;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Unidentified Ore";
			Name2 = "Unidentified Ore";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Super Reaper 6000 Blueprints)
*
***************************************************************/

namespace Server.Items
{
	public class SuperReaper6000Blueprints : Item
	{
		public SuperReaper6000Blueprints() : base()
		{
			Id = 5734;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8628;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Super Reaper 6000 Blueprints";
			Name2 = "Super Reaper 6000 Blueprints";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Sealed Envelope)
*
***************************************************************/

namespace Server.Items
{
	public class SealedEnvelope : Item
	{
		public SealedEnvelope() : base()
		{
			Id = 5735;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3411;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sealed Envelope";
			Name2 = "Sealed Envelope";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gerenzo's Mechanical Arm)
*
***************************************************************/

namespace Server.Items
{
	public class GerenzosMechanicalArm : Item
	{
		public GerenzosMechanicalArm() : base()
		{
			Id = 5736;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gerenzo's Mechanical Arm";
			Name2 = "Gerenzo's Mechanical Arm";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Covert Ops Plans: Alpha & Beta)
*
***************************************************************/

namespace Server.Items
{
	public class CovertOpsPlansAlphaBeta : Item
	{
		public CovertOpsPlansAlphaBeta() : base()
		{
			Id = 5737;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 8630;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Covert Ops Plans: Alpha & Beta";
			Name2 = "Covert Ops Plans: Alpha & Beta";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 417;
		}
	}
}


/**************************************************************
*
*				(Gnome Voucher)
*
***************************************************************/

namespace Server.Items
{
	public class GnomeVoucher : Item
	{
		public GnomeVoucher() : base()
		{
			Id = 5768;
			Bonding = 1;
			SellPrice = 1250;
			AvailableClasses = 0x7FFF;
			Model = 16037;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gnome Voucher";
			Name2 = "Gnome Voucher";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 5000;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Goblin Voucher)
*
***************************************************************/

namespace Server.Items
{
	public class GoblinVoucher : Item
	{
		public GoblinVoucher() : base()
		{
			Id = 5769;
			Bonding = 1;
			SellPrice = 1250;
			AvailableClasses = 0x7FFF;
			Model = 1097;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Goblin Voucher";
			Name2 = "Goblin Voucher";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 5000;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Lonebrow's Journal)
*
***************************************************************/

namespace Server.Items
{
	public class LonebrowsJournal : Item
	{
		public LonebrowsJournal() : base()
		{
			Id = 5790;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8040;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lonebrow's Journal";
			Name2 = "Lonebrow's Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 424;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Henrig Lonebrow's Journal)
*
***************************************************************/

namespace Server.Items
{
	public class HenrigLonebrowsJournal : Item
	{
		public HenrigLonebrowsJournal() : base()
		{
			Id = 5791;
			AvailableClasses = 0x7FFF;
			Model = 8040;
			ObjectClass = 12;
			SubClass = 0;
			Level = 29;
			ReqLevel = 29;
			Name = "Henrig Lonebrow's Journal";
			Name2 = "Henrig Lonebrow's Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 1100;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Razorflank's Medallion)
*
***************************************************************/

namespace Server.Items
{
	public class RazorflanksMedallion : Item
	{
		public RazorflanksMedallion() : base()
		{
			Id = 5792;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8918;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Razorflank's Medallion";
			Name2 = "Razorflank's Medallion";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Razorflank's Heart)
*
***************************************************************/

namespace Server.Items
{
	public class RazorflanksHeart : Item
	{
		public RazorflanksHeart() : base()
		{
			Id = 5793;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8917;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Razorflank's Heart";
			Name2 = "Razorflank's Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Salty Scorpid Venom)
*
***************************************************************/

namespace Server.Items
{
	public class SaltyScorpidVenom : Item
	{
		public SaltyScorpidVenom() : base()
		{
			Id = 5794;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8922;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Salty Scorpid Venom";
			Name2 = "Salty Scorpid Venom";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Hardened Tortoise Shell)
*
***************************************************************/

namespace Server.Items
{
	public class HardenedTortoiseShell : Item
	{
		public HardenedTortoiseShell() : base()
		{
			Id = 5795;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8923;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hardened Tortoise Shell";
			Name2 = "Hardened Tortoise Shell";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Encrusted Tail Fin)
*
***************************************************************/

namespace Server.Items
{
	public class EncrustedTailFin : Item
	{
		public EncrustedTailFin() : base()
		{
			Id = 5796;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10043;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Encrusted Tail Fin";
			Name2 = "Encrusted Tail Fin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Indurium Flake)
*
***************************************************************/

namespace Server.Items
{
	public class InduriumFlake : Item
	{
		public InduriumFlake() : base()
		{
			Id = 5797;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9110;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Indurium Flake";
			Name2 = "Indurium Flake";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Rocket Car Parts)
*
***************************************************************/

namespace Server.Items
{
	public class RocketCarParts : Item
	{
		public RocketCarParts() : base()
		{
			Id = 5798;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8926;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rocket Car Parts";
			Name2 = "Rocket Car Parts";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Kravel's Parts Order)
*
***************************************************************/

namespace Server.Items
{
	public class KravelsPartsOrder : Item
	{
		public KravelsPartsOrder() : base()
		{
			Id = 5799;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8927;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kravel's Parts Order";
			Name2 = "Kravel's Parts Order";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 436;
		}
	}
}


/**************************************************************
*
*				(Kravel's Parts)
*
***************************************************************/

namespace Server.Items
{
	public class KravelsParts : Item
	{
		public KravelsParts() : base()
		{
			Id = 5800;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8928;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kravel's Parts";
			Name2 = "Kravel's Parts";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Kraul Guano)
*
***************************************************************/

namespace Server.Items
{
	public class KraulGuano : Item
	{
		public KraulGuano() : base()
		{
			Id = 5801;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13715;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kraul Guano";
			Name2 = "Kraul Guano";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Delicate Car Parts)
*
***************************************************************/

namespace Server.Items
{
	public class DelicateCarParts : Item
	{
		public DelicateCarParts() : base()
		{
			Id = 5802;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8931;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Delicate Car Parts";
			Name2 = "Delicate Car Parts";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Speck of Dream Dust)
*
***************************************************************/

namespace Server.Items
{
	public class SpeckOfDreamDust : Item
	{
		public SpeckOfDreamDust() : base()
		{
			Id = 5803;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8932;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Speck of Dream Dust";
			Name2 = "Speck of Dream Dust";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Goblin Rumors)
*
***************************************************************/

namespace Server.Items
{
	public class GoblinRumors : Item
	{
		public GoblinRumors() : base()
		{
			Id = 5804;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4435;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Goblin Rumors";
			Name2 = "Goblin Rumors";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 438;
		}
	}
}


/**************************************************************
*
*				(Heart of Zeal)
*
***************************************************************/

namespace Server.Items
{
	public class HeartOfZeal : Item
	{
		public HeartOfZeal() : base()
		{
			Id = 5805;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4045;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Heart of Zeal";
			Name2 = "Heart of Zeal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fool's Stout)
*
***************************************************************/

namespace Server.Items
{
	public class FoolsStout : Item
	{
		public FoolsStout() : base()
		{
			Id = 5806;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8935;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fool's Stout";
			Name2 = "Fool's Stout";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fool's Stout Report)
*
***************************************************************/

namespace Server.Items
{
	public class FoolsStoutReport : Item
	{
		public FoolsStoutReport() : base()
		{
			Id = 5807;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fool's Stout Report";
			Name2 = "Fool's Stout Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 440;
		}
	}
}


/**************************************************************
*
*				(Pridewing Venom Sac)
*
***************************************************************/

namespace Server.Items
{
	public class PridewingVenomSac : Item
	{
		public PridewingVenomSac() : base()
		{
			Id = 5808;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8940;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pridewing Venom Sac";
			Name2 = "Pridewing Venom Sac";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Highperch Venom Sac)
*
***************************************************************/

namespace Server.Items
{
	public class HighperchVenomSac : Item
	{
		public HighperchVenomSac() : base()
		{
			Id = 5809;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8940;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Highperch Venom Sac";
			Name2 = "Highperch Venom Sac";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fresh Carcass)
*
***************************************************************/

namespace Server.Items
{
	public class FreshCarcass : Item
	{
		public FreshCarcass() : base()
		{
			Id = 5810;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8942;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fresh Carcass";
			Name2 = "Fresh Carcass";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 6717 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Frostmaw's Mane)
*
***************************************************************/

namespace Server.Items
{
	public class FrostmawsMane : Item
	{
		public FrostmawsMane() : base()
		{
			Id = 5811;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8952;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Frostmaw's Mane";
			Name2 = "Frostmaw's Mane";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Tablet of Will)
*
***************************************************************/

namespace Server.Items
{
	public class TabletOfWill : Item
	{
		public TabletOfWill() : base()
		{
			Id = 5824;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9106;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tablet of Will";
			Name2 = "Tablet of Will";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Treshala's Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class TreshalasPendant : Item
	{
		public TreshalasPendant() : base()
		{
			Id = 5825;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9305;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Treshala's Pendant";
			Name2 = "Treshala's Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Kravel's Scheme)
*
***************************************************************/

namespace Server.Items
{
	public class KravelsScheme : Item
	{
		public KravelsScheme() : base()
		{
			Id = 5826;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kravel's Scheme";
			Name2 = "Kravel's Scheme";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 439;
		}
	}
}


/**************************************************************
*
*				(Fizzle Brassbolts' Letter)
*
***************************************************************/

namespace Server.Items
{
	public class FizzleBrassboltsLetter : Item
	{
		public FizzleBrassboltsLetter() : base()
		{
			Id = 5827;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4435;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fizzle Brassbolts' Letter";
			Name2 = "Fizzle Brassbolts' Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 441;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Kenata's Head)
*
***************************************************************/

namespace Server.Items
{
	public class KenatasHead : Item
	{
		public KenatasHead() : base()
		{
			Id = 5830;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15706;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kenata's Head";
			Name2 = "Kenata's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Fardel's Head)
*
***************************************************************/

namespace Server.Items
{
	public class FardelsHead : Item
	{
		public FardelsHead() : base()
		{
			Id = 5831;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7038;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fardel's Head";
			Name2 = "Fardel's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Marcel's Head)
*
***************************************************************/

namespace Server.Items
{
	public class MarcelsHead : Item
	{
		public MarcelsHead() : base()
		{
			Id = 5832;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7038;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Marcel's Head";
			Name2 = "Marcel's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Mok'Morokk's Snuff)
*
***************************************************************/

namespace Server.Items
{
	public class MokMorokksSnuff : Item
	{
		public MokMorokksSnuff() : base()
		{
			Id = 5834;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9124;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mok'Morokk's Snuff";
			Name2 = "Mok'Morokk's Snuff";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mok'Morokk's Grog)
*
***************************************************************/

namespace Server.Items
{
	public class MokMorokksGrog : Item
	{
		public MokMorokksGrog() : base()
		{
			Id = 5835;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18078;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mok'Morokk's Grog";
			Name2 = "Mok'Morokk's Grog";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mok'Morokk's Strongbox)
*
***************************************************************/

namespace Server.Items
{
	public class MokMorokksStrongbox : Item
	{
		public MokMorokksStrongbox() : base()
		{
			Id = 5836;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12644;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mok'Morokk's Strongbox";
			Name2 = "Mok'Morokk's Strongbox";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Steelsnap's Rib)
*
***************************************************************/

namespace Server.Items
{
	public class SteelsnapsRib : Item
	{
		public SteelsnapsRib() : base()
		{
			Id = 5837;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9134;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Steelsnap's Rib";
			Name2 = "Steelsnap's Rib";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Kodo Skin Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class KodoSkinScroll : Item
	{
		public KodoSkinScroll() : base()
		{
			Id = 5838;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9144;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kodo Skin Scroll";
			Name2 = "Kodo Skin Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 442;
		}
	}
}


/**************************************************************
*
*				(Searing Tongue)
*
***************************************************************/

namespace Server.Items
{
	public class SearingTongue : Item
	{
		public SearingTongue() : base()
		{
			Id = 5840;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20952;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Searing Tongue";
			Name2 = "Searing Tongue";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Searing Heart)
*
***************************************************************/

namespace Server.Items
{
	public class SearingHeart : Item
	{
		public SearingHeart() : base()
		{
			Id = 5841;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3422;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Searing Heart";
			Name2 = "Searing Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Unrefined Ore Sample)
*
***************************************************************/

namespace Server.Items
{
	public class UnrefinedOreSample : Item
	{
		public UnrefinedOreSample() : base()
		{
			Id = 5842;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18107;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Unrefined Ore Sample";
			Name2 = "Unrefined Ore Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Grenka's Claw)
*
***************************************************************/

namespace Server.Items
{
	public class GrenkasClaw : Item
	{
		public GrenkasClaw() : base()
		{
			Id = 5843;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3596;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Grenka's Claw";
			Name2 = "Grenka's Claw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Fragments of Rok'Alim)
*
***************************************************************/

namespace Server.Items
{
	public class FragmentsOfRokAlim : Item
	{
		public FragmentsOfRokAlim() : base()
		{
			Id = 5844;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9147;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fragments of Rok'Alim";
			Name2 = "Fragments of Rok'Alim";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Korran's Sealed Note)
*
***************************************************************/

namespace Server.Items
{
	public class KorransSealedNote : Item
	{
		public KorransSealedNote() : base()
		{
			Id = 5846;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9148;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Korran's Sealed Note";
			Name2 = "Korran's Sealed Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mirefin Head)
*
***************************************************************/

namespace Server.Items
{
	public class MirefinHead : Item
	{
		public MirefinHead() : base()
		{
			Id = 5847;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9150;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mirefin Head";
			Name2 = "Mirefin Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Hollow Vulture Bone)
*
***************************************************************/

namespace Server.Items
{
	public class HollowVultureBone : Item
	{
		public HollowVultureBone() : base()
		{
			Id = 5848;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7126;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hollow Vulture Bone";
			Name2 = "Hollow Vulture Bone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crate of Crash Helmets)
*
***************************************************************/

namespace Server.Items
{
	public class CrateOfCrashHelmets : Item
	{
		public CrateOfCrashHelmets() : base()
		{
			Id = 5849;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9151;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crate of Crash Helmets";
			Name2 = "Crate of Crash Helmets";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Belgrom's Sealed Note)
*
***************************************************************/

namespace Server.Items
{
	public class BelgromsSealedNote : Item
	{
		public BelgromsSealedNote() : base()
		{
			Id = 5850;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9152;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Belgrom's Sealed Note";
			Name2 = "Belgrom's Sealed Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fuel Regulator Blueprints)
*
***************************************************************/

namespace Server.Items
{
	public class FuelRegulatorBlueprints : Item
	{
		public FuelRegulatorBlueprints() : base()
		{
			Id = 5852;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9155;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fuel Regulator Blueprints";
			Name2 = "Fuel Regulator Blueprints";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Intact Silithid Carapace)
*
***************************************************************/

namespace Server.Items
{
	public class IntactSilithidCarapace : Item
	{
		public IntactSilithidCarapace() : base()
		{
			Id = 5853;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9158;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Intact Silithid Carapace";
			Name2 = "Intact Silithid Carapace";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Silithid Talon)
*
***************************************************************/

namespace Server.Items
{
	public class SilithidTalon : Item
	{
		public SilithidTalon() : base()
		{
			Id = 5854;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9157;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Silithid Talon";
			Name2 = "Silithid Talon";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Silithid Heart)
*
***************************************************************/

namespace Server.Items
{
	public class SilithidHeart : Item
	{
		public SilithidHeart() : base()
		{
			Id = 5855;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4045;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Silithid Heart";
			Name2 = "Silithid Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Goblin Prize Box)
*
***************************************************************/

namespace Server.Items
{
	public class GoblinPrizeBox : Item
	{
		public GoblinPrizeBox() : base()
		{
			Id = 5858;
			Bonding = 1;
			SellPrice = 37;
			AvailableClasses = 0x7FFF;
			Description = "Open for a prize!";
			Model = 9161;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Goblin Prize Box";
			Name2 = "Goblin Prize Box";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 150;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 4;
		}
	}
}


/**************************************************************
*
*				(Legacy of the Aspects)
*
***************************************************************/

namespace Server.Items
{
	public class LegacyOfTheAspects : Item
	{
		public LegacyOfTheAspects() : base()
		{
			Id = 5860;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9164;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Legacy of the Aspects";
			Name2 = "Legacy of the Aspects";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 447;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Beginnings of the Undead Threat)
*
***************************************************************/

namespace Server.Items
{
	public class BeginningsOfTheUndeadThreat : Item
	{
		public BeginningsOfTheUndeadThreat() : base()
		{
			Id = 5861;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9165;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Beginnings of the Undead Threat";
			Name2 = "Beginnings of the Undead Threat";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 669;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Seaforium Booster)
*
***************************************************************/

namespace Server.Items
{
	public class SeaforiumBooster : Item
	{
		public SeaforiumBooster() : base()
		{
			Id = 5862;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9166;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Seaforium Booster";
			Name2 = "Seaforium Booster";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Modified Seaforium Booster)
*
***************************************************************/

namespace Server.Items
{
	public class ModifiedSeaforiumBooster : Item
	{
		public ModifiedSeaforiumBooster() : base()
		{
			Id = 5865;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9166;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Modified Seaforium Booster";
			Name2 = "Modified Seaforium Booster";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sample of Indurium Ore)
*
***************************************************************/

namespace Server.Items
{
	public class SampleOfInduriumOre : Item
	{
		public SampleOfInduriumOre() : base()
		{
			Id = 5866;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9116;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sample of Indurium Ore";
			Name2 = "Sample of Indurium Ore";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Etched Phial)
*
***************************************************************/

namespace Server.Items
{
	public class EtchedPhial : Item
	{
		public EtchedPhial() : base()
		{
			Id = 5867;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9208;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Etched Phial";
			Name2 = "Etched Phial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			SetSpell( 6803 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Filled Etched Phial)
*
***************************************************************/

namespace Server.Items
{
	public class FilledEtchedPhial : Item
	{
		public FilledEtchedPhial() : base()
		{
			Id = 5868;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9207;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Etched Phial";
			Name2 = "Filled Etched Phial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2112;
			SetSpell( 6805 , 0 , -1 , 1000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Cloven Hoof)
*
***************************************************************/

namespace Server.Items
{
	public class ClovenHoof : Item
	{
		public ClovenHoof() : base()
		{
			Id = 5869;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9209;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cloven Hoof";
			Name2 = "Cloven Hoof";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Blueleaf Tuber)
*
***************************************************************/

namespace Server.Items
{
	public class BlueleafTuber : Item
	{
		public BlueleafTuber() : base()
		{
			Id = 5876;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6624;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blueleaf Tuber";
			Name2 = "Blueleaf Tuber";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Cracked Silithid Carapace)
*
***************************************************************/

namespace Server.Items
{
	public class CrackedSilithidCarapace : Item
	{
		public CrackedSilithidCarapace() : base()
		{
			Id = 5877;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 9284;
			ObjectClass = 12;
			SubClass = 0;
			Level = 28;
			ReqLevel = 28;
			Name = "Cracked Silithid Carapace";
			Name2 = "Cracked Silithid Carapace";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 1148;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Twilight Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class TwilightPendant : Item
	{
		public TwilightPendant() : base()
		{
			Id = 5879;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9285;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Twilight Pendant";
			Name2 = "Twilight Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Head of Kelris)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfKelris : Item
	{
		public HeadOfKelris() : base()
		{
			Id = 5881;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9289;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Kelris";
			Name2 = "Head of Kelris";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Captain's Documents)
*
***************************************************************/

namespace Server.Items
{
	public class CaptainsDocuments : Item
	{
		public CaptainsDocuments() : base()
		{
			Id = 5882;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9467;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Captain's Documents";
			Name2 = "Captain's Documents";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 527;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Forked Mudrock Tongue)
*
***************************************************************/

namespace Server.Items
{
	public class ForkedMudrockTongue : Item
	{
		public ForkedMudrockTongue() : base()
		{
			Id = 5883;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9291;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Forked Mudrock Tongue";
			Name2 = "Forked Mudrock Tongue";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Unpopped Darkmist Eye)
*
***************************************************************/

namespace Server.Items
{
	public class UnpoppedDarkmistEye : Item
	{
		public UnpoppedDarkmistEye() : base()
		{
			Id = 5884;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9292;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Unpopped Darkmist Eye";
			Name2 = "Unpopped Darkmist Eye";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Snufflenose Owner's Manual)
*
***************************************************************/

namespace Server.Items
{
	public class SnufflenoseOwnersManual : Item
	{
		public SnufflenoseOwnersManual() : base()
		{
			Id = 5897;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9319;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Snufflenose Owner's Manual";
			Name2 = "Snufflenose Owner's Manual";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 467;
		}
	}
}


/**************************************************************
*
*				(Spy's Report)
*
***************************************************************/

namespace Server.Items
{
	public class SpysReport : Item
	{
		public SpysReport() : base()
		{
			Id = 5917;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 811;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Spy's Report";
			Name2 = "Spy's Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 507;
			Language = 1;
		}
	}
}


/**************************************************************
*
*				(Defiant Orc Head)
*
***************************************************************/

namespace Server.Items
{
	public class DefiantOrcHead : Item
	{
		public DefiantOrcHead() : base()
		{
			Id = 5918;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3914;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Defiant Orc Head";
			Name2 = "Defiant Orc Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Blackened Iron Shield)
*
***************************************************************/

namespace Server.Items
{
	public class BlackenedIronShield : Item
	{
		public BlackenedIronShield() : base()
		{
			Id = 5919;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9354;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blackened Iron Shield";
			Name2 = "Blackened Iron Shield";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Pristine Crawler Leg)
*
***************************************************************/

namespace Server.Items
{
	public class PristineCrawlerLeg : Item
	{
		public PristineCrawlerLeg() : base()
		{
			Id = 5938;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7345;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pristine Crawler Leg";
			Name2 = "Pristine Crawler Leg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Jeweled Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class JeweledPendant : Item
	{
		public JeweledPendant() : base()
		{
			Id = 5942;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9377;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jeweled Pendant";
			Name2 = "Jeweled Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Deadmire's Tooth)
*
***************************************************************/

namespace Server.Items
{
	public class DeadmiresTooth : Item
	{
		public DeadmiresTooth() : base()
		{
			Id = 5945;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9396;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Deadmire's Tooth";
			Name2 = "Deadmire's Tooth";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Sealed Note to Elling)
*
***************************************************************/

namespace Server.Items
{
	public class SealedNoteToElling : Item
	{
		public SealedNoteToElling() : base()
		{
			Id = 5946;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9148;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sealed Note to Elling";
			Name2 = "Sealed Note to Elling";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Defias Docket)
*
***************************************************************/

namespace Server.Items
{
	public class DefiasDocket : Item
	{
		public DefiasDocket() : base()
		{
			Id = 5947;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9397;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Defias Docket";
			Name2 = "Defias Docket";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 580;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Letter to Jorgen)
*
***************************************************************/

namespace Server.Items
{
	public class LetterToJorgen : Item
	{
		public LetterToJorgen() : base()
		{
			Id = 5948;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9148;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Letter to Jorgen";
			Name2 = "Letter to Jorgen";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 528;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Reethe's Badge)
*
***************************************************************/

namespace Server.Items
{
	public class ReethesBadge : Item
	{
		public ReethesBadge() : base()
		{
			Id = 5950;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9429;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Reethe's Badge";
			Name2 = "Reethe's Badge";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Corrupted Brain Stem)
*
***************************************************************/

namespace Server.Items
{
	public class CorruptedBrainStem : Item
	{
		public CorruptedBrainStem() : base()
		{
			Id = 5952;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13531;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Corrupted Brain Stem";
			Name2 = "Corrupted Brain Stem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Acidic Venom Sac)
*
***************************************************************/

namespace Server.Items
{
	public class AcidicVenomSac : Item
	{
		public AcidicVenomSac() : base()
		{
			Id = 5959;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2885;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Acidic Venom Sac";
			Name2 = "Acidic Venom Sac";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sealed Note to Watcher Backus)
*
***************************************************************/

namespace Server.Items
{
	public class SealedNoteToWatcherBackus : Item
	{
		public SealedNoteToWatcherBackus() : base()
		{
			Id = 5960;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9152;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sealed Note to Watcher Backus";
			Name2 = "Sealed Note to Watcher Backus";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Stormpike's Request)
*
***************************************************************/

namespace Server.Items
{
	public class StormpikesRequest : Item
	{
		public StormpikesRequest() : base()
		{
			Id = 5998;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4435;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stormpike's Request";
			Name2 = "Stormpike's Request";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 607;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Wolf Heart Sample)
*
***************************************************************/

namespace Server.Items
{
	public class WolfHeartSample : Item
	{
		public WolfHeartSample() : base()
		{
			Id = 6016;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4045;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wolf Heart Sample";
			Name2 = "Wolf Heart Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Miniature Platinum Discs)
*
***************************************************************/

namespace Server.Items
{
	public class MiniaturePlatinumDiscs : Item
	{
		public MiniaturePlatinumDiscs() : base()
		{
			Id = 6064;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16265;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Miniature Platinum Discs";
			Name2 = "Miniature Platinum Discs";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Khadgar's Essays on Dimensional Convergence)
*
***************************************************************/

namespace Server.Items
{
	public class KhadgarsEssaysOnDimensionalConvergence : Item
	{
		public KhadgarsEssaysOnDimensionalConvergence() : base()
		{
			Id = 6065;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "These documents are sealed by a magical force.";
			Model = 9663;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Khadgar's Essays on Dimensional Convergence";
			Name2 = "Khadgar's Essays on Dimensional Convergence";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Khan Dez'hepah's Head)
*
***************************************************************/

namespace Server.Items
{
	public class KhanDezhepahsHead : Item
	{
		public KhanDezhepahsHead() : base()
		{
			Id = 6066;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9666;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Khan Dez'hepah's Head";
			Name2 = "Khan Dez'hepah's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Centaur Ear)
*
***************************************************************/

namespace Server.Items
{
	public class CentaurEar : Item
	{
		public CentaurEar() : base()
		{
			Id = 6067;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9668;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Centaur Ear";
			Name2 = "Centaur Ear";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crudely Dried Meat)
*
***************************************************************/

namespace Server.Items
{
	public class CrudelyDriedMeat : Item
	{
		public CrudelyDriedMeat() : base()
		{
			Id = 6069;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7407;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crudely Dried Meat";
			Name2 = "Crudely Dried Meat";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Draenethyst Crystal)
*
***************************************************************/

namespace Server.Items
{
	public class DraenethystCrystal : Item
	{
		public DraenethystCrystal() : base()
		{
			Id = 6071;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6563;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Draenethyst Crystal";
			Name2 = "Draenethyst Crystal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Khan Jehn's Head)
*
***************************************************************/

namespace Server.Items
{
	public class KhanJehnsHead : Item
	{
		public KhanJehnsHead() : base()
		{
			Id = 6072;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9666;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Khan Jehn's Head";
			Name2 = "Khan Jehn's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Khan Shaka's Head)
*
***************************************************************/

namespace Server.Items
{
	public class KhanShakasHead : Item
	{
		public KhanShakasHead() : base()
		{
			Id = 6073;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9666;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Khan Shaka's Head";
			Name2 = "Khan Shaka's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Vimes's Report)
*
***************************************************************/

namespace Server.Items
{
	public class VimessReport : Item
	{
		public VimessReport() : base()
		{
			Id = 6075;
			Bonding = 5;
			AvailableClasses = 0x7FFF;
			Model = 9725;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vimes's Report";
			Name2 = "Vimes's Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Maraudine Key Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class MaraudineKeyFragment : Item
	{
		public MaraudineKeyFragment() : base()
		{
			Id = 6077;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9728;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Maraudine Key Fragment";
			Name2 = "Maraudine Key Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Crude Charm)
*
***************************************************************/

namespace Server.Items
{
	public class CrudeCharm : Item
	{
		public CrudeCharm() : base()
		{
			Id = 6079;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9730;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crude Charm";
			Name2 = "Crude Charm";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Shadow Panther Heart)
*
***************************************************************/

namespace Server.Items
{
	public class ShadowPantherHeart : Item
	{
		public ShadowPantherHeart() : base()
		{
			Id = 6080;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8917;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shadow Panther Heart";
			Name2 = "Shadow Panther Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mire Lord Fungus)
*
***************************************************************/

namespace Server.Items
{
	public class MireLordFungus : Item
	{
		public MireLordFungus() : base()
		{
			Id = 6081;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9733;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mire Lord Fungus";
			Name2 = "Mire Lord Fungus";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Deepstrider Tumor)
*
***************************************************************/

namespace Server.Items
{
	public class DeepstriderTumor : Item
	{
		public DeepstriderTumor() : base()
		{
			Id = 6082;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9734;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Deepstrider Tumor";
			Name2 = "Deepstrider Tumor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Broken Tears)
*
***************************************************************/

namespace Server.Items
{
	public class BrokenTears : Item
	{
		public BrokenTears() : base()
		{
			Id = 6083;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9737;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Broken Tears";
			Name2 = "Broken Tears";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Faustin's Truth Serum)
*
***************************************************************/

namespace Server.Items
{
	public class FaustinsTruthSerum : Item
	{
		public FaustinsTruthSerum() : base()
		{
			Id = 6086;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9741;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Faustin's Truth Serum";
			Name2 = "Faustin's Truth Serum";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Zraedus's Brew)
*
***************************************************************/

namespace Server.Items
{
	public class ZraedussBrew : Item
	{
		public ZraedussBrew() : base()
		{
			Id = 6089;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18117;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Zraedus's Brew";
			Name2 = "Zraedus's Brew";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crate of Power Stones)
*
***************************************************************/

namespace Server.Items
{
	public class CrateOfPowerStones : Item
	{
		public CrateOfPowerStones() : base()
		{
			Id = 6091;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9822;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crate of Power Stones";
			Name2 = "Crate of Power Stones";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Clarice's Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class ClaricesPendant : Item
	{
		public ClaricesPendant() : base()
		{
			Id = 6145;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Place upon Yuriv's grave.";
			Model = 7570;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Clarice's Pendant";
			Name2 = "Clarice's Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 8001 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Sundried Driftwood)
*
***************************************************************/

namespace Server.Items
{
	public class SundriedDriftwood : Item
	{
		public SundriedDriftwood() : base()
		{
			Id = 6146;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10190;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sundried Driftwood";
			Name2 = "Sundried Driftwood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Coyote Jawbone)
*
***************************************************************/

namespace Server.Items
{
	public class CoyoteJawbone : Item
	{
		public CoyoteJawbone() : base()
		{
			Id = 6166;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10345;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Coyote Jawbone";
			Name2 = "Coyote Jawbone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Neeka's Report)
*
***************************************************************/

namespace Server.Items
{
	public class NeekasReport : Item
	{
		public NeekasReport() : base()
		{
			Id = 6167;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6423;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Neeka's Report";
			Name2 = "Neeka's Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 711;
			Language = 1;
		}
	}
}


/**************************************************************
*
*				(Sawtooth Snapper Claw)
*
***************************************************************/

namespace Server.Items
{
	public class SawtoothSnapperClaw : Item
	{
		public SawtoothSnapperClaw() : base()
		{
			Id = 6168;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9157;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sawtooth Snapper Claw";
			Name2 = "Sawtooth Snapper Claw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Unprepared Sawtooth Flank)
*
***************************************************************/

namespace Server.Items
{
	public class UnpreparedSawtoothFlank : Item
	{
		public UnpreparedSawtoothFlank() : base()
		{
			Id = 6169;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6678;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Unprepared Sawtooth Flank";
			Name2 = "Unprepared Sawtooth Flank";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Wizards' Reagents)
*
***************************************************************/

namespace Server.Items
{
	public class WizardsReagents : Item
	{
		public WizardsReagents() : base()
		{
			Id = 6170;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10353;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wizards' Reagents";
			Name2 = "Wizards' Reagents";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Lost Supplies)
*
***************************************************************/

namespace Server.Items
{
	public class LostSupplies : Item
	{
		public LostSupplies() : base()
		{
			Id = 6172;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 12927;
			ObjectClass = 12;
			SubClass = 0;
			Level = 30;
			ReqLevel = 30;
			Name = "Lost Supplies";
			Name2 = "Lost Supplies";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 1423;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Atal'ai Artifact)
*
***************************************************************/

namespace Server.Items
{
	public class AtalaiArtifact : Item
	{
		public AtalaiArtifact() : base()
		{
			Id = 6175;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10365;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Atal'ai Artifact";
			Name2 = "Atal'ai Artifact";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Shipment to Nethergarde)
*
***************************************************************/

namespace Server.Items
{
	public class ShipmentToNethergarde : Item
	{
		public ShipmentToNethergarde() : base()
		{
			Id = 6178;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8928;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shipment to Nethergarde";
			Name2 = "Shipment to Nethergarde";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fetish of Hakkar)
*
***************************************************************/

namespace Server.Items
{
	public class FetishOfHakkar : Item
	{
		public FetishOfHakkar() : base()
		{
			Id = 6181;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4262;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fetish of Hakkar";
			Name2 = "Fetish of Hakkar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Monstrous Crawler Leg)
*
***************************************************************/

namespace Server.Items
{
	public class MonstrousCrawlerLeg : Item
	{
		public MonstrousCrawlerLeg() : base()
		{
			Id = 6184;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10399;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Monstrous Crawler Leg";
			Name2 = "Monstrous Crawler Leg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Draenethyst Shard)
*
***************************************************************/

namespace Server.Items
{
	public class DraenethystShard : Item
	{
		public DraenethystShard() : base()
		{
			Id = 6190;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10449;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Draenethyst Shard";
			Name2 = "Draenethyst Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bundle of Atal'ai Artifacts)
*
***************************************************************/

namespace Server.Items
{
	public class BundleOfAtalaiArtifacts : Item
	{
		public BundleOfAtalaiArtifacts() : base()
		{
			Id = 6193;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10481;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bundle of Atal'ai Artifacts";
			Name2 = "Bundle of Atal'ai Artifacts";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Head of Jammal'an)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfJammalan : Item
	{
		public HeadOfJammalan() : base()
		{
			Id = 6212;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10546;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Jammal'an";
			Name2 = "Head of Jammal'an";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Karnitol's Satchel)
*
***************************************************************/

namespace Server.Items
{
	public class KarnitolsSatchel : Item
	{
		public KarnitolsSatchel() : base()
		{
			Id = 6245;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7289;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Karnitol's Satchel";
			Name2 = "Karnitol's Satchel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Hatefury Claw)
*
***************************************************************/

namespace Server.Items
{
	public class HatefuryClaw : Item
	{
		public HatefuryClaw() : base()
		{
			Id = 6246;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10920;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hatefury Claw";
			Name2 = "Hatefury Claw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Hatefury Horn)
*
***************************************************************/

namespace Server.Items
{
	public class HatefuryHorn : Item
	{
		public HatefuryHorn() : base()
		{
			Id = 6247;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10921;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hatefury Horn";
			Name2 = "Hatefury Horn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Scorpashi Venom)
*
***************************************************************/

namespace Server.Items
{
	public class ScorpashiVenom : Item
	{
		public ScorpashiVenom() : base()
		{
			Id = 6248;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6400;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scorpashi Venom";
			Name2 = "Scorpashi Venom";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Aged Kodo Hide)
*
***************************************************************/

namespace Server.Items
{
	public class AgedKodoHide : Item
	{
		public AgedKodoHide() : base()
		{
			Id = 6249;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10922;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Aged Kodo Hide";
			Name2 = "Aged Kodo Hide";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Felhound Brain)
*
***************************************************************/

namespace Server.Items
{
	public class FelhoundBrain : Item
	{
		public FelhoundBrain() : base()
		{
			Id = 6250;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10923;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Felhound Brain";
			Name2 = "Felhound Brain";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Nether Wing)
*
***************************************************************/

namespace Server.Items
{
	public class NetherWing : Item
	{
		public NetherWing() : base()
		{
			Id = 6251;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3124;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nether Wing";
			Name2 = "Nether Wing";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Doomwarder Blood)
*
***************************************************************/

namespace Server.Items
{
	public class DoomwarderBlood : Item
	{
		public DoomwarderBlood() : base()
		{
			Id = 6252;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6400;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Doomwarder Blood";
			Name2 = "Doomwarder Blood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Leftwitch's Package)
*
***************************************************************/

namespace Server.Items
{
	public class LeftwitchsPackage : Item
	{
		public LeftwitchsPackage() : base()
		{
			Id = 6253;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10924;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Leftwitch's Package";
			Name2 = "Leftwitch's Package";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Roc Gizzard)
*
***************************************************************/

namespace Server.Items
{
	public class RocGizzard : Item
	{
		public RocGizzard() : base()
		{
			Id = 6257;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11012;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Roc Gizzard";
			Name2 = "Roc Gizzard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ironfur Liver)
*
***************************************************************/

namespace Server.Items
{
	public class IronfurLiver : Item
	{
		public IronfurLiver() : base()
		{
			Id = 6258;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6427;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ironfur Liver";
			Name2 = "Ironfur Liver";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Groddoc Liver)
*
***************************************************************/

namespace Server.Items
{
	public class GroddocLiver : Item
	{
		public GroddocLiver() : base()
		{
			Id = 6259;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4045;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Groddoc Liver";
			Name2 = "Groddoc Liver";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Musty Note)
*
***************************************************************/

namespace Server.Items
{
	public class MustyNote : Item
	{
		public MustyNote() : base()
		{
			Id = 6276;
			AvailableClasses = 0x7FFF;
			Model = 6639;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Musty Note";
			Name2 = "Musty Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 691;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Musty Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class MustyParchment : Item
	{
		public MustyParchment() : base()
		{
			Id = 6277;
			AvailableClasses = 0x7FFF;
			Model = 11160;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Musty Parchment";
			Name2 = "Musty Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 692;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Musty Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class MustyScroll : Item
	{
		public MustyScroll() : base()
		{
			Id = 6278;
			AvailableClasses = 0x7FFF;
			Model = 11161;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Musty Scroll";
			Name2 = "Musty Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 693;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Musty Letter)
*
***************************************************************/

namespace Server.Items
{
	public class MustyLetter : Item
	{
		public MustyLetter() : base()
		{
			Id = 6279;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Musty Letter";
			Name2 = "Musty Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 694;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Musty Missive)
*
***************************************************************/

namespace Server.Items
{
	public class MustyMissive : Item
	{
		public MustyMissive() : base()
		{
			Id = 6280;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Musty Missive";
			Name2 = "Musty Missive";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 695;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Rattlecage Skull)
*
***************************************************************/

namespace Server.Items
{
	public class RattlecageSkull : Item
	{
		public RattlecageSkull() : base()
		{
			Id = 6281;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4262;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rattlecage Skull";
			Name2 = "Rattlecage Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(The Book of Ur)
*
***************************************************************/

namespace Server.Items
{
	public class TheBookOfUr : Item
	{
		public TheBookOfUr() : base()
		{
			Id = 6283;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2757;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The Book of Ur";
			Name2 = "The Book of Ur";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 698;
		}
	}
}


/**************************************************************
*
*				(Runes of Summoning)
*
***************************************************************/

namespace Server.Items
{
	public class RunesOfSummoning : Item
	{
		public RunesOfSummoning() : base()
		{
			Id = 6284;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11180;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Runes of Summoning";
			Name2 = "Runes of Summoning";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 9221 , 0 , 0 , 180000 , 0 , 0 );
		}
	}
}


/**************************************************************
*
*				(Egalin's Grimoire)
*
***************************************************************/

namespace Server.Items
{
	public class EgalinsGrimoire : Item
	{
		public EgalinsGrimoire() : base()
		{
			Id = 6285;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11181;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Egalin's Grimoire";
			Name2 = "Egalin's Grimoire";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Pure Hearts)
*
***************************************************************/

namespace Server.Items
{
	public class PureHearts : Item
	{
		public PureHearts() : base()
		{
			Id = 6286;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6694;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pure Hearts";
			Name2 = "Pure Hearts";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 9223 , 0 , 0 , 180000 , 0 , 0 );
		}
	}
}


/**************************************************************
*
*				(Atal'ai Tablet Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class AtalaiTabletFragment : Item
	{
		public AtalaiTabletFragment() : base()
		{
			Id = 6287;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11183;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Atal'ai Tablet Fragment";
			Name2 = "Atal'ai Tablet Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Atal'ai Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class AtalaiTablet : Item
	{
		public AtalaiTablet() : base()
		{
			Id = 6288;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11185;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Atal'ai Tablet";
			Name2 = "Atal'ai Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dalin's Heart)
*
***************************************************************/

namespace Server.Items
{
	public class DalinsHeart : Item
	{
		public DalinsHeart() : base()
		{
			Id = 6312;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3422;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dalin's Heart";
			Name2 = "Dalin's Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Comar's Heart)
*
***************************************************************/

namespace Server.Items
{
	public class ComarsHeart : Item
	{
		public ComarsHeart() : base()
		{
			Id = 6313;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3422;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Comar's Heart";
			Name2 = "Comar's Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Infused Burning Gem)
*
***************************************************************/

namespace Server.Items
{
	public class InfusedBurningGem : Item
	{
		public InfusedBurningGem() : base()
		{
			Id = 6435;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11766;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Infused Burning Gem";
			Name2 = "Infused Burning Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Burning Gem)
*
***************************************************************/

namespace Server.Items
{
	public class BurningGem : Item
	{
		public BurningGem() : base()
		{
			Id = 6436;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 6521;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Burning Gem";
			Name2 = "Burning Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 7914 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Shadowstalker Scalp)
*
***************************************************************/

namespace Server.Items
{
	public class ShadowstalkerScalp : Item
	{
		public ShadowstalkerScalp() : base()
		{
			Id = 6441;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11825;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shadowstalker Scalp";
			Name2 = "Shadowstalker Scalp";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 4;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Oracle Crystal)
*
***************************************************************/

namespace Server.Items
{
	public class OracleCrystal : Item
	{
		public OracleCrystal() : base()
		{
			Id = 6442;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15027;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Oracle Crystal";
			Name2 = "Oracle Crystal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Deviate Hide)
*
***************************************************************/

namespace Server.Items
{
	public class DeviateHide : Item
	{
		public DeviateHide() : base()
		{
			Id = 6443;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11164;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Deviate Hide";
			Name2 = "Deviate Hide";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Secure Crate)
*
***************************************************************/

namespace Server.Items
{
	public class SecureCrate : Item
	{
		public SecureCrate() : base()
		{
			Id = 6462;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11449;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Secure Crate";
			Name2 = "Secure Crate";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Malem Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class MalemPendant : Item
	{
		public MalemPendant() : base()
		{
			Id = 6479;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12018;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Malem Pendant";
			Name2 = "Malem Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Vile Familiar Head)
*
***************************************************************/

namespace Server.Items
{
	public class VileFamiliarHead : Item
	{
		public VileFamiliarHead() : base()
		{
			Id = 6487;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20931;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vile Familiar Head";
			Name2 = "Vile Familiar Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Simple Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class SimpleTablet : Item
	{
		public SimpleTablet() : base()
		{
			Id = 6488;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12221;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Simple Tablet";
			Name2 = "Simple Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 752;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Dark Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class DarkParchment : Item
	{
		public DarkParchment() : base()
		{
			Id = 6490;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dark Parchment";
			Name2 = "Dark Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 754;
			Language = 1;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Heavy Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class HeavyParchment : Item
	{
		public HeavyParchment() : base()
		{
			Id = 6491;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Heavy Parchment";
			Name2 = "Heavy Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			PageText = 755;
			Language = 1;
		}
	}
}


/**************************************************************
*
*				(Sooty Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class SootyParchment : Item
	{
		public SootyParchment() : base()
		{
			Id = 6492;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sooty Parchment";
			Name2 = "Sooty Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 756;
			Language = 1;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Weatherbeaten Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class WeatherbeatenParchment : Item
	{
		public WeatherbeatenParchment() : base()
		{
			Id = 6495;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Weatherbeaten Parchment";
			Name2 = "Weatherbeaten Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 759;
			Language = 1;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Detailed Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class DetailedParchment : Item
	{
		public DetailedParchment() : base()
		{
			Id = 6496;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Detailed Parchment";
			Name2 = "Detailed Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 760;
			Language = 1;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Simple Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class SimpleParchment : Item
	{
		public SimpleParchment() : base()
		{
			Id = 6497;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Simple Parchment";
			Name2 = "Simple Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 2383;
			MaxCount = 1;
			Material = -1;
			PageText = 761;
			Language = 1;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Inscribed Kodo Leather)
*
***************************************************************/

namespace Server.Items
{
	public class InscribedKodoLeather : Item
	{
		public InscribedKodoLeather() : base()
		{
			Id = 6498;
			AvailableClasses = 0x7FFF;
			Model = 12222;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Inscribed Kodo Leather";
			Name2 = "Inscribed Kodo Leather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 762;
			Language = 1;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Inscribed Kodo Leather)
*
***************************************************************/

namespace Server.Items
{
	public class InscribedKodoLeather6500 : Item
	{
		public InscribedKodoLeather6500() : base()
		{
			Id = 6500;
			AvailableClasses = 0x7FFF;
			Model = 12222;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Inscribed Kodo Leather";
			Name2 = "Inscribed Kodo Leather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 764;
			Language = 3;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Inscribed Kodo Leather)
*
***************************************************************/

namespace Server.Items
{
	public class InscribedKodoLeather6501 : Item
	{
		public InscribedKodoLeather6501() : base()
		{
			Id = 6501;
			AvailableClasses = 0x7FFF;
			Model = 12222;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Inscribed Kodo Leather";
			Name2 = "Inscribed Kodo Leather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 765;
			Language = 3;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Imp Summoning Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class ImpSummoningScroll : Item
	{
		public ImpSummoningScroll() : base()
		{
			Id = 6516;
			Bonding = 4;
			AvailableClasses = 0x100;
			Model = 12328;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Imp Summoning Scroll";
			Name2 = "Imp Summoning Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 96;
			SetSpell( 1366 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Forged Steel Bars)
*
***************************************************************/

namespace Server.Items
{
	public class ForgedSteelBars : Item
	{
		public ForgedSteelBars() : base()
		{
			Id = 6534;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12434;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Forged Steel Bars";
			Name2 = "Forged Steel Bars";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tablet of Verga)
*
***************************************************************/

namespace Server.Items
{
	public class TabletOfVerga : Item
	{
		public TabletOfVerga() : base()
		{
			Id = 6535;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12435;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tablet of Verga";
			Name2 = "Tablet of Verga";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Voidwalker Summoning Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class VoidwalkerSummoningScroll : Item
	{
		public VoidwalkerSummoningScroll() : base()
		{
			Id = 6544;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12328;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Voidwalker Summoning Scroll";
			Name2 = "Voidwalker Summoning Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 96;
			SetSpell( 1385 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Succubus Summoning Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class SuccubusSummoningScroll : Item
	{
		public SuccubusSummoningScroll() : base()
		{
			Id = 6623;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12328;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Succubus Summoning Scroll";
			Name2 = "Succubus Summoning Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 96;
			SetSpell( 1403 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Ken'zigla's Draught)
*
***************************************************************/

namespace Server.Items
{
	public class KenziglasDraught : Item
	{
		public KenziglasDraught() : base()
		{
			Id = 6624;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12565;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ken'zigla's Draught";
			Name2 = "Ken'zigla's Draught";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dirt-caked Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class DirtCakedPendant : Item
	{
		public DirtCakedPendant() : base()
		{
			Id = 6625;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12567;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dirt-caked Pendant";
			Name2 = "Dirt-caked Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dogran's Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class DogransPendant : Item
	{
		public DogransPendant() : base()
		{
			Id = 6626;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12567;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dogran's Pendant";
			Name2 = "Dogran's Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 9224 , 0 , 0 , 180000 , 0 , 0 );
		}
	}
}


/**************************************************************
*
*				(Ritual Salve)
*
***************************************************************/

namespace Server.Items
{
	public class RitualSalve : Item
	{
		public RitualSalve() : base()
		{
			Id = 6634;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6381;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ritual Salve";
			Name2 = "Ritual Salve";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Felstalker Hoof)
*
***************************************************************/

namespace Server.Items
{
	public class FelstalkerHoof : Item
	{
		public FelstalkerHoof() : base()
		{
			Id = 6640;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12625;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Felstalker Hoof";
			Name2 = "Felstalker Hoof";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Stoneskin Totem Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class StoneskinTotemScroll : Item
	{
		public StoneskinTotemScroll() : base()
		{
			Id = 6648;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12328;
			ObjectClass = 12;
			SubClass = 0;
			Level = 4;
			ReqLevel = 4;
			Name = "Stoneskin Totem Scroll";
			Name2 = "Stoneskin Totem Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 96;
			SetSpell( 8199 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Searing Totem Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class SearingTotemScroll : Item
	{
		public SearingTotemScroll() : base()
		{
			Id = 6649;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12328;
			ObjectClass = 12;
			SubClass = 0;
			Level = 10;
			ReqLevel = 10;
			Name = "Searing Totem Scroll";
			Name2 = "Searing Totem Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 96;
			SetSpell( 8200 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Reagent Pouch)
*
***************************************************************/

namespace Server.Items
{
	public class ReagentPouch : Item
	{
		public ReagentPouch() : base()
		{
			Id = 6652;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12735;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Reagent Pouch";
			Name2 = "Reagent Pouch";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Torch of the Dormant Flame)
*
***************************************************************/

namespace Server.Items
{
	public class TorchOfTheDormantFlame : Item
	{
		public TorchOfTheDormantFlame() : base()
		{
			Id = 6653;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12992;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Torch of the Dormant Flame";
			Name2 = "Torch of the Dormant Flame";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.HeldInHand;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
			Sheath = 7;
		}
	}
}


/**************************************************************
*
*				(Torch of the Eternal Flame)
*
***************************************************************/

namespace Server.Items
{
	public class TorchOfTheEternalFlame : Item
	{
		public TorchOfTheEternalFlame() : base()
		{
			Id = 6654;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12738;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Torch of the Eternal Flame";
			Name2 = "Torch of the Eternal Flame";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.HeldInHand;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
			Sheath = 7;
		}
	}
}


/**************************************************************
*
*				(Glowing Ember)
*
***************************************************************/

namespace Server.Items
{
	public class GlowingEmber : Item
	{
		public GlowingEmber() : base()
		{
			Id = 6655;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12736;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glowing Ember";
			Name2 = "Glowing Ember";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Rough Quartz)
*
***************************************************************/

namespace Server.Items
{
	public class RoughQuartz : Item
	{
		public RoughQuartz() : base()
		{
			Id = 6656;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12746;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rough Quartz";
			Name2 = "Rough Quartz";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Example Collar)
*
***************************************************************/

namespace Server.Items
{
	public class ExampleCollar : Item
	{
		public ExampleCollar() : base()
		{
			Id = 6658;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12643;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Example Collar";
			Name2 = "Example Collar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Snufflenose Command Stick)
*
***************************************************************/

namespace Server.Items
{
	public class SnufflenoseCommandStick : Item
	{
		public SnufflenoseCommandStick() : base()
		{
			Id = 6684;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12866;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Snufflenose Command Stick";
			Name2 = "Snufflenose Command Stick";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 8283 , 0 , 0 , 1000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Gaffer Jack)
*
***************************************************************/

namespace Server.Items
{
	public class GafferJack : Item
	{
		public GafferJack() : base()
		{
			Id = 6717;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8931;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gaffer Jack";
			Name2 = "Gaffer Jack";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Electropeller)
*
***************************************************************/

namespace Server.Items
{
	public class Electropeller : Item
	{
		public Electropeller() : base()
		{
			Id = 6718;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7411;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Electropeller";
			Name2 = "Electropeller";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Feather Charm)
*
***************************************************************/

namespace Server.Items
{
	public class FeatherCharm : Item
	{
		public FeatherCharm() : base()
		{
			Id = 6753;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12989;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Feather Charm";
			Name2 = "Feather Charm";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Flayed Demon Skin)
*
***************************************************************/

namespace Server.Items
{
	public class FlayedDemonSkin : Item
	{
		public FlayedDemonSkin() : base()
		{
			Id = 6766;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 13002;
			ObjectClass = 12;
			SubClass = 0;
			Level = 25;
			ReqLevel = 25;
			Name = "Flayed Demon Skin";
			Name2 = "Flayed Demon Skin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 1480;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Tyranis' Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class TyranisPendant : Item
	{
		public TyranisPendant() : base()
		{
			Id = 6767;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12863;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tyranis' Pendant";
			Name2 = "Tyranis' Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Tome of Divinity)
*
***************************************************************/

namespace Server.Items
{
	public class TomeOfDivinity : Item
	{
		public TomeOfDivinity() : base()
		{
			Id = 6775;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 13005;
			ObjectClass = 12;
			SubClass = 0;
			Level = 12;
			ReqLevel = 12;
			Name = "Tome of Divinity";
			Name2 = "Tome of Divinity";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 1642;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tome of Valor)
*
***************************************************************/

namespace Server.Items
{
	public class TomeOfValor : Item
	{
		public TomeOfValor() : base()
		{
			Id = 6776;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 13005;
			ObjectClass = 12;
			SubClass = 0;
			Level = 20;
			ReqLevel = 20;
			Name = "Tome of Valor";
			Name2 = "Tome of Valor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 1649;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dead-tooth's Key)
*
***************************************************************/

namespace Server.Items
{
	public class DeadToothsKey : Item
	{
		public DeadToothsKey() : base()
		{
			Id = 6783;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13025;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dead-tooth's Key";
			Name2 = "Dead-tooth's Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2112;
			SetSpell( 8517 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Powers of the Void)
*
***************************************************************/

namespace Server.Items
{
	public class PowersOfTheVoid : Item
	{
		public PowersOfTheVoid() : base()
		{
			Id = 6785;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "By the hand of Khadgar";
			Model = 7637;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Powers of the Void";
			Name2 = "Powers of the Void";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Vejrek's Head)
*
***************************************************************/

namespace Server.Items
{
	public class VejreksHead : Item
	{
		public VejreksHead() : base()
		{
			Id = 6799;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13061;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vejrek's Head";
			Name2 = "Vejrek's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Umbral Ore)
*
***************************************************************/

namespace Server.Items
{
	public class UmbralOre : Item
	{
		public UmbralOre() : base()
		{
			Id = 6800;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13063;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Umbral Ore";
			Name2 = "Umbral Ore";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Horn of Vorlus)
*
***************************************************************/

namespace Server.Items
{
	public class HornOfVorlus : Item
	{
		public HornOfVorlus() : base()
		{
			Id = 6805;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13082;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Horn of Vorlus";
			Name2 = "Horn of Vorlus";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Elunite Ore)
*
***************************************************************/

namespace Server.Items
{
	public class EluniteOre : Item
	{
		public EluniteOre() : base()
		{
			Id = 6808;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13063;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Elunite Ore";
			Name2 = "Elunite Ore";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Elura's Medallion)
*
***************************************************************/

namespace Server.Items
{
	public class ElurasMedallion : Item
	{
		public ElurasMedallion() : base()
		{
			Id = 6809;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7425;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Elura's Medallion";
			Name2 = "Elura's Medallion";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Surena's Choker)
*
***************************************************************/

namespace Server.Items
{
	public class SurenasChoker : Item
	{
		public SurenasChoker() : base()
		{
			Id = 6810;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13085;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Surena's Choker";
			Name2 = "Surena's Choker";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Scorched Spider Fang)
*
***************************************************************/

namespace Server.Items
{
	public class ScorchedSpiderFang : Item
	{
		public ScorchedSpiderFang() : base()
		{
			Id = 6838;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9396;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scorched Spider Fang";
			Name2 = "Scorched Spider Fang";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Charred Horn)
*
***************************************************************/

namespace Server.Items
{
	public class CharredHorn : Item
	{
		public CharredHorn() : base()
		{
			Id = 6839;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13121;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Charred Horn";
			Name2 = "Charred Horn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Galvanized Horn)
*
***************************************************************/

namespace Server.Items
{
	public class GalvanizedHorn : Item
	{
		public GalvanizedHorn() : base()
		{
			Id = 6840;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13122;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Galvanized Horn";
			Name2 = "Galvanized Horn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Cask of Scalder)
*
***************************************************************/

namespace Server.Items
{
	public class CaskOfScalder : Item
	{
		public CaskOfScalder() : base()
		{
			Id = 6843;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7922;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cask of Scalder";
			Name2 = "Cask of Scalder";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Burning Blood)
*
***************************************************************/

namespace Server.Items
{
	public class BurningBlood : Item
	{
		public BurningBlood() : base()
		{
			Id = 6844;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18060;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Burning Blood";
			Name2 = "Burning Blood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Burning Rock)
*
***************************************************************/

namespace Server.Items
{
	public class BurningRock : Item
	{
		public BurningRock() : base()
		{
			Id = 6845;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13124;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Burning Rock";
			Name2 = "Burning Rock";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Defias Script)
*
***************************************************************/

namespace Server.Items
{
	public class DefiasScript : Item
	{
		public DefiasScript() : base()
		{
			Id = 6846;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13125;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Defias Script";
			Name2 = "Defias Script";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 811;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Dark Iron Script)
*
***************************************************************/

namespace Server.Items
{
	public class DarkIronScript : Item
	{
		public DarkIronScript() : base()
		{
			Id = 6847;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13125;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dark Iron Script";
			Name2 = "Dark Iron Script";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 812;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Searing Coral)
*
***************************************************************/

namespace Server.Items
{
	public class SearingCoral : Item
	{
		public SearingCoral() : base()
		{
			Id = 6848;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13918;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Searing Coral";
			Name2 = "Searing Coral";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sunscorched Shell)
*
***************************************************************/

namespace Server.Items
{
	public class SunscorchedShell : Item
	{
		public SunscorchedShell() : base()
		{
			Id = 6849;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18054;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sunscorched Shell";
			Name2 = "Sunscorched Shell";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Symbol of Life)
*
***************************************************************/

namespace Server.Items
{
	public class SymbolOfLife : Item
	{
		public SymbolOfLife() : base()
		{
			Id = 6866;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 13144;
			ObjectClass = 12;
			SubClass = 0;
			Level = 12;
			ReqLevel = 12;
			Name = "Symbol of Life";
			Name2 = "Symbol of Life";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 8593 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Whirlwind Heart)
*
***************************************************************/

namespace Server.Items
{
	public class WhirlwindHeart : Item
	{
		public WhirlwindHeart() : base()
		{
			Id = 6894;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13291;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Whirlwind Heart";
			Name2 = "Whirlwind Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Jordan's Smithing Hammer)
*
***************************************************************/

namespace Server.Items
{
	public class JordansSmithingHammer : Item
	{
		public JordansSmithingHammer() : base()
		{
			Id = 6895;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13292;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jordan's Smithing Hammer";
			Name2 = "Jordan's Smithing Hammer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Heartswood)
*
***************************************************************/

namespace Server.Items
{
	public class Heartswood : Item
	{
		public Heartswood() : base()
		{
			Id = 6912;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13370;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Heartswood";
			Name2 = "Heartswood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Heartswood Core)
*
***************************************************************/

namespace Server.Items
{
	public class HeartswoodCore : Item
	{
		public HeartswoodCore() : base()
		{
			Id = 6913;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13458;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Heartswood Core";
			Name2 = "Heartswood Core";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 8674 , 0 , 0 , 180000 , 0 , 0 );
		}
	}
}


/**************************************************************
*
*				(Soran'ruk Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class SoranrukFragment : Item
	{
		public SoranrukFragment() : base()
		{
			Id = 6914;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1695;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Soran'ruk Fragment";
			Name2 = "Soran'ruk Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Large Soran'ruk Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class LargeSoranrukFragment : Item
	{
		public LargeSoranrukFragment() : base()
		{
			Id = 6915;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6564;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Large Soran'ruk Fragment";
			Name2 = "Large Soran'ruk Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Tome of Divinity)
*
***************************************************************/

namespace Server.Items
{
	public class TomeOfDivinity6916 : Item
	{
		public TomeOfDivinity6916() : base()
		{
			Id = 6916;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 13005;
			ObjectClass = 12;
			SubClass = 0;
			Level = 12;
			ReqLevel = 12;
			Name = "Tome of Divinity";
			Name2 = "Tome of Divinity";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 1646;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bloodstone Choker)
*
***************************************************************/

namespace Server.Items
{
	public class BloodstoneChoker : Item
	{
		public BloodstoneChoker() : base()
		{
			Id = 6928;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13085;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodstone Choker";
			Name2 = "Bloodstone Choker";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 7728 , 0 , 0 , 180000 , 0 , 0 );
		}
	}
}


/**************************************************************
*
*				(Rod of Channeling)
*
***************************************************************/

namespace Server.Items
{
	public class RodOfChanneling : Item
	{
		public RodOfChanneling() : base()
		{
			Id = 6930;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13435;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rod of Channeling";
			Name2 = "Rod of Channeling";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Moldy Tome)
*
***************************************************************/

namespace Server.Items
{
	public class MoldyTome : Item
	{
		public MoldyTome() : base()
		{
			Id = 6931;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Faint letters on the cover of the locked book read, 'Tome of the Cabal.'";
			Model = 2757;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Moldy Tome";
			Name2 = "Moldy Tome";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 8712 , 0 , 0 , 180000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Thick Bear Fur)
*
***************************************************************/

namespace Server.Items
{
	public class ThickBearFur : Item
	{
		public ThickBearFur() : base()
		{
			Id = 6952;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7169;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thick Bear Fur";
			Name2 = "Thick Bear Fur";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Felhunter Summoning Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class FelhunterSummoningScroll : Item
	{
		public FelhunterSummoningScroll() : base()
		{
			Id = 6988;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12328;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Felhunter Summoning Scroll";
			Name2 = "Felhunter Summoning Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 96;
			SetSpell( 8717 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Vial of Hatefury Blood)
*
***************************************************************/

namespace Server.Items
{
	public class VialOfHatefuryBlood : Item
	{
		public VialOfHatefuryBlood() : base()
		{
			Id = 6989;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1150;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vial of Hatefury Blood";
			Name2 = "Vial of Hatefury Blood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Lesser Infernal Stone)
*
***************************************************************/

namespace Server.Items
{
	public class LesserInfernalStone : Item
	{
		public LesserInfernalStone() : base()
		{
			Id = 6990;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13490;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lesser Infernal Stone";
			Name2 = "Lesser Infernal Stone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Smoldering Coal)
*
***************************************************************/

namespace Server.Items
{
	public class SmolderingCoal : Item
	{
		public SmolderingCoal() : base()
		{
			Id = 6991;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9116;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Smoldering Coal";
			Name2 = "Smoldering Coal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Jordan's Ore Shipment)
*
***************************************************************/

namespace Server.Items
{
	public class JordansOreShipment : Item
	{
		public JordansOreShipment() : base()
		{
			Id = 6992;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13493;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jordan's Ore Shipment";
			Name2 = "Jordan's Ore Shipment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Jordan's Refined Ore Shipment)
*
***************************************************************/

namespace Server.Items
{
	public class JordansRefinedOreShipment : Item
	{
		public JordansRefinedOreShipment() : base()
		{
			Id = 6993;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13494;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jordan's Refined Ore Shipment";
			Name2 = "Jordan's Refined Ore Shipment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Whitestone Oak Lumber)
*
***************************************************************/

namespace Server.Items
{
	public class WhitestoneOakLumber : Item
	{
		public WhitestoneOakLumber() : base()
		{
			Id = 6994;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13495;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Whitestone Oak Lumber";
			Name2 = "Whitestone Oak Lumber";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Corrupted Kor Gem)
*
***************************************************************/

namespace Server.Items
{
	public class CorruptedKorGem : Item
	{
		public CorruptedKorGem() : base()
		{
			Id = 6995;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13703;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Corrupted Kor Gem";
			Name2 = "Corrupted Kor Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Jordan's Weapon Notes)
*
***************************************************************/

namespace Server.Items
{
	public class JordansWeaponNotes : Item
	{
		public JordansWeaponNotes() : base()
		{
			Id = 6996;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 13497;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jordan's Weapon Notes";
			Name2 = "Jordan's Weapon Notes";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 871;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Tattered Manuscript)
*
***************************************************************/

namespace Server.Items
{
	public class TatteredManuscript : Item
	{
		public TatteredManuscript() : base()
		{
			Id = 6997;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "A large number of papers from the 'Tome of the Cabal.'";
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tattered Manuscript";
			Name2 = "Tattered Manuscript";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 8712 , 0 , 0 , 180000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Tome of the Cabal)
*
***************************************************************/

namespace Server.Items
{
	public class TomeOfTheCabal : Item
	{
		public TomeOfTheCabal() : base()
		{
			Id = 6999;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2757;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tome of the Cabal";
			Name2 = "Tome of the Cabal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 8712 , 0 , 0 , 180000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Reconstructed Tome)
*
***************************************************************/

namespace Server.Items
{
	public class ReconstructedTome : Item
	{
		public ReconstructedTome() : base()
		{
			Id = 7006;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2757;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Reconstructed Tome";
			Name2 = "Reconstructed Tome";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Purified Kor Gem)
*
***************************************************************/

namespace Server.Items
{
	public class PurifiedKorGem : Item
	{
		public PurifiedKorGem() : base()
		{
			Id = 7083;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7279;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Purified Kor Gem";
			Name2 = "Purified Kor Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Twitching Antenna)
*
***************************************************************/

namespace Server.Items
{
	public class TwitchingAntenna : Item
	{
		public TwitchingAntenna() : base()
		{
			Id = 7119;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "This antenna won't twitch forever";
			Model = 15507;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Twitching Antenna";
			Name2 = "Twitching Antenna";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Smokey Iron Ingot)
*
***************************************************************/

namespace Server.Items
{
	public class SmokeyIronIngot : Item
	{
		public SmokeyIronIngot() : base()
		{
			Id = 7126;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13783;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Smokey Iron Ingot";
			Name2 = "Smokey Iron Ingot";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Uncloven Satyr Hoof)
*
***************************************************************/

namespace Server.Items
{
	public class UnclovenSatyrHoof : Item
	{
		public UnclovenSatyrHoof() : base()
		{
			Id = 7128;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13785;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Uncloven Satyr Hoof";
			Name2 = "Uncloven Satyr Hoof";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dragonmaw Shinbone)
*
***************************************************************/

namespace Server.Items
{
	public class DragonmawShinbone : Item
	{
		public DragonmawShinbone() : base()
		{
			Id = 7131;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13799;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dragonmaw Shinbone";
			Name2 = "Dragonmaw Shinbone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 64;
			SetSpell( 8856 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Sturdy Dragonmaw Shinbone)
*
***************************************************************/

namespace Server.Items
{
	public class SturdyDragonmawShinbone : Item
	{
		public SturdyDragonmawShinbone() : base()
		{
			Id = 7134;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13799;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sturdy Dragonmaw Shinbone";
			Name2 = "Sturdy Dragonmaw Shinbone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mirror Lake Water Sample)
*
***************************************************************/

namespace Server.Items
{
	public class MirrorLakeWaterSample : Item
	{
		public MirrorLakeWaterSample() : base()
		{
			Id = 7206;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18059;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mirror Lake Water Sample";
			Name2 = "Mirror Lake Water Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Jennea's Flask)
*
***************************************************************/

namespace Server.Items
{
	public class JenneasFlask : Item
	{
		public JenneasFlask() : base()
		{
			Id = 7207;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18057;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jennea's Flask";
			Name2 = "Jennea's Flask";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 8919 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Tazan's Key)
*
***************************************************************/

namespace Server.Items
{
	public class TazansKey : Item
	{
		public TazansKey() : base()
		{
			Id = 7208;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13885;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tazan's Key";
			Name2 = "Tazan's Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 8917 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Mage-tastic Gizmonitor)
*
***************************************************************/

namespace Server.Items
{
	public class MageTasticGizmonitor : Item
	{
		public MageTasticGizmonitor() : base()
		{
			Id = 7226;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13903;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mage-tastic Gizmonitor";
			Name2 = "Mage-tastic Gizmonitor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Astor's Letter of Introduction)
*
***************************************************************/

namespace Server.Items
{
	public class AstorsLetterOfIntroduction : Item
	{
		public AstorsLetterOfIntroduction() : base()
		{
			Id = 7231;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7695;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Astor's Letter of Introduction";
			Name2 = "Astor's Letter of Introduction";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Charged Rift Gem)
*
***************************************************************/

namespace Server.Items
{
	public class ChargedRiftGem : Item
	{
		public ChargedRiftGem() : base()
		{
			Id = 7249;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7162;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Charged Rift Gem";
			Name2 = "Charged Rift Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Pristine Spider Silk)
*
***************************************************************/

namespace Server.Items
{
	public class PristineSpiderSilk : Item
	{
		public PristineSpiderSilk() : base()
		{
			Id = 7267;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18597;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pristine Spider Silk";
			Name2 = "Pristine Spider Silk";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Xavian Water Sample)
*
***************************************************************/

namespace Server.Items
{
	public class XavianWaterSample : Item
	{
		public XavianWaterSample() : base()
		{
			Id = 7268;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18059;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Xavian Water Sample";
			Name2 = "Xavian Water Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Deino's Flask)
*
***************************************************************/

namespace Server.Items
{
	public class DeinosFlask : Item
	{
		public DeinosFlask() : base()
		{
			Id = 7269;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18057;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Deino's Flask";
			Name2 = "Deino's Flask";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 9052 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Laughing Sister's Hair)
*
***************************************************************/

namespace Server.Items
{
	public class LaughingSistersHair : Item
	{
		public LaughingSistersHair() : base()
		{
			Id = 7270;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13992;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Laughing Sister's Hair";
			Name2 = "Laughing Sister's Hair";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Flawless Ivory Tusk)
*
***************************************************************/

namespace Server.Items
{
	public class FlawlessIvoryTusk : Item
	{
		public FlawlessIvoryTusk() : base()
		{
			Id = 7271;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13998;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Flawless Ivory Tusk";
			Name2 = "Flawless Ivory Tusk";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bolt Charged Bramble)
*
***************************************************************/

namespace Server.Items
{
	public class BoltChargedBramble : Item
	{
		public BoltChargedBramble() : base()
		{
			Id = 7272;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7143;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bolt Charged Bramble";
			Name2 = "Bolt Charged Bramble";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Witherbark Totem Stick)
*
***************************************************************/

namespace Server.Items
{
	public class WitherbarkTotemStick : Item
	{
		public WitherbarkTotemStick() : base()
		{
			Id = 7273;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 14000;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Witherbark Totem Stick";
			Name2 = "Witherbark Totem Stick";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 1088;
			SetSpell( 9055 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Rituals of Power)
*
***************************************************************/

namespace Server.Items
{
	public class RitualsOfPower : Item
	{
		public RitualsOfPower() : base()
		{
			Id = 7274;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "By Magus Tirth";
			Model = 11181;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rituals of Power";
			Name2 = "Rituals of Power";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Infernal Orb)
*
***************************************************************/

namespace Server.Items
{
	public class InfernalOrb : Item
	{
		public InfernalOrb() : base()
		{
			Id = 7291;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1695;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Infernal Orb";
			Name2 = "Infernal Orb";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Filled Containment Coffer)
*
***************************************************************/

namespace Server.Items
{
	public class FilledContainmentCoffer : Item
	{
		public FilledContainmentCoffer() : base()
		{
			Id = 7292;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 14006;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Containment Coffer";
			Name2 = "Filled Containment Coffer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dalaran Mana Gem)
*
***************************************************************/

namespace Server.Items
{
	public class DalaranManaGem : Item
	{
		public DalaranManaGem() : base()
		{
			Id = 7293;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 14007;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dalaran Mana Gem";
			Name2 = "Dalaran Mana Gem";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Andron's Ledger)
*
***************************************************************/

namespace Server.Items
{
	public class AndronsLedger : Item
	{
		public AndronsLedger() : base()
		{
			Id = 7294;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 14008;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Andron's Ledger";
			Name2 = "Andron's Ledger";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tazan's Logbook)
*
***************************************************************/

namespace Server.Items
{
	public class TazansLogbook : Item
	{
		public TazansLogbook() : base()
		{
			Id = 7295;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 6645;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tazan's Logbook";
			Name2 = "Tazan's Logbook";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fenwick's Head)
*
***************************************************************/

namespace Server.Items
{
	public class FenwicksHead : Item
	{
		public FenwicksHead() : base()
		{
			Id = 7306;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 14023;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fenwick's Head";
			Name2 = "Fenwick's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Cantation of Manifestation)
*
***************************************************************/

namespace Server.Items
{
	public class CantationOfManifestation : Item
	{
		public CantationOfManifestation() : base()
		{
			Id = 7308;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Use near a mana rift disturbance";
			Model = 12328;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cantation of Manifestation";
			Name2 = "Cantation of Manifestation";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 9095 , 0 , 0 , 10000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Dalaran Status Report)
*
***************************************************************/

namespace Server.Items
{
	public class DalaranStatusReport : Item
	{
		public DalaranStatusReport() : base()
		{
			Id = 7309;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15374;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dalaran Status Report";
			Name2 = "Dalaran Status Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Overseer's Whistle)
*
***************************************************************/

namespace Server.Items
{
	public class OverseersWhistle : Item
	{
		public OverseersWhistle() : base()
		{
			Id = 7333;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7276;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Overseer's Whistle";
			Name2 = "Overseer's Whistle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bingles's Wrench)
*
***************************************************************/

namespace Server.Items
{
	public class BinglessWrench : Item
	{
		public BinglessWrench() : base()
		{
			Id = 7343;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7602;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bingles's Wrench";
			Name2 = "Bingles's Wrench";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bingles's Screwdriver)
*
***************************************************************/

namespace Server.Items
{
	public class BinglessScrewdriver : Item
	{
		public BinglessScrewdriver() : base()
		{
			Id = 7345;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 14305;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bingles's Screwdriver";
			Name2 = "Bingles's Screwdriver";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bingles's Hammer)
*
***************************************************************/

namespace Server.Items
{
	public class BinglessHammer : Item
	{
		public BinglessHammer() : base()
		{
			Id = 7346;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 14306;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bingles's Hammer";
			Name2 = "Bingles's Hammer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gnoam Sprecklesprocket)
*
***************************************************************/

namespace Server.Items
{
	public class GnoamSprecklesprocket : Item
	{
		public GnoamSprecklesprocket() : base()
		{
			Id = 7365;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 14326;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gnoam Sprecklesprocket";
			Name2 = "Gnoam Sprecklesprocket";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bingles's Blastencapper)
*
***************************************************************/

namespace Server.Items
{
	public class BinglessBlastencapper : Item
	{
		public BinglessBlastencapper() : base()
		{
			Id = 7376;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18062;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bingles's Blastencapper";
			Name2 = "Bingles's Blastencapper";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Venture Co. Ledger)
*
***************************************************************/

namespace Server.Items
{
	public class VentureCoLedger : Item
	{
		public VentureCoLedger() : base()
		{
			Id = 7389;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3426;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Venture Co. Ledger";
			Name2 = "Venture Co. Ledger";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gyromast's Key)
*
***************************************************************/

namespace Server.Items
{
	public class GyromastsKey : Item
	{
		public GyromastsKey() : base()
		{
			Id = 7442;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 14993;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gyromast's Key";
			Name2 = "Gyromast's Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Glyphs of Summoning)
*
***************************************************************/

namespace Server.Items
{
	public class GlyphsOfSummoning : Item
	{
		public GlyphsOfSummoning() : base()
		{
			Id = 7464;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11180;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glyphs of Summoning";
			Name2 = "Glyphs of Summoning";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 9222 , 0 , 0 , 180000 , 0 , 0 );
		}
	}
}


/**************************************************************
*
*				(Top of Gelkak's Key)
*
***************************************************************/

namespace Server.Items
{
	public class TopOfGelkaksKey : Item
	{
		public TopOfGelkaksKey() : base()
		{
			Id = 7498;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13025;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Top of Gelkak's Key";
			Name2 = "Top of Gelkak's Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Middle of Gelkak's Key)
*
***************************************************************/

namespace Server.Items
{
	public class MiddleOfGelkaksKey : Item
	{
		public MiddleOfGelkaksKey() : base()
		{
			Id = 7499;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15123;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Middle of Gelkak's Key";
			Name2 = "Middle of Gelkak's Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bottom of Gelkak's Key)
*
***************************************************************/

namespace Server.Items
{
	public class BottomOfGelkaksKey : Item
	{
		public BottomOfGelkaksKey() : base()
		{
			Id = 7500;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8031;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bottom of Gelkak's Key";
			Name2 = "Bottom of Gelkak's Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Agamand Family Sword)
*
***************************************************************/

namespace Server.Items
{
	public class AgamandFamilySword : Item
	{
		public AgamandFamilySword() : base()
		{
			Id = 7566;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16204;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Agamand Family Sword";
			Name2 = "Agamand Family Sword";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Agamand Family Axe)
*
***************************************************************/

namespace Server.Items
{
	public class AgamandFamilyAxe : Item
	{
		public AgamandFamilyAxe() : base()
		{
			Id = 7567;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15471;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Agamand Family Axe";
			Name2 = "Agamand Family Axe";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Agamand Family Dagger)
*
***************************************************************/

namespace Server.Items
{
	public class AgamandFamilyDagger : Item
	{
		public AgamandFamilyDagger() : base()
		{
			Id = 7568;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7098;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Agamand Family Dagger";
			Name2 = "Agamand Family Dagger";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Agamand Family Mace)
*
***************************************************************/

namespace Server.Items
{
	public class AgamandFamilyMace : Item
	{
		public AgamandFamilyMace() : base()
		{
			Id = 7569;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16203;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Agamand Family Mace";
			Name2 = "Agamand Family Mace";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tharnariun's Hope)
*
***************************************************************/

namespace Server.Items
{
	public class TharnariunsHope : Item
	{
		public TharnariunsHope() : base()
		{
			Id = 7586;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7245;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tharnariun's Hope";
			Name2 = "Tharnariun's Hope";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 9437 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Thun'grim's Instructions)
*
***************************************************************/

namespace Server.Items
{
	public class ThungrimsInstructions : Item
	{
		public ThungrimsInstructions() : base()
		{
			Id = 7587;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 15510;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thun'grim's Instructions";
			Name2 = "Thun'grim's Instructions";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 931;
		}
	}
}


/**************************************************************
*
*				(Bundle of Furs)
*
***************************************************************/

namespace Server.Items
{
	public class BundleOfFurs : Item
	{
		public BundleOfFurs() : base()
		{
			Id = 7626;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15583;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Bundle of Furs";
			Name2 = "Bundle of Furs";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Nondescript Letter)
*
***************************************************************/

namespace Server.Items
{
	public class NondescriptLetter : Item
	{
		public NondescriptLetter() : base()
		{
			Id = 7628;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "A sealed letter";
			Model = 13125;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Nondescript Letter";
			Name2 = "Nondescript Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crate of Inn Supplies)
*
***************************************************************/

namespace Server.Items
{
	public class CrateOfInnSupplies : Item
	{
		public CrateOfInnSupplies() : base()
		{
			Id = 7646;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11448;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crate of Inn Supplies";
			Name2 = "Crate of Inn Supplies";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Shattered Necklace)
*
***************************************************************/

namespace Server.Items
{
	public class ShatteredNecklace : Item
	{
		public ShatteredNecklace() : base()
		{
			Id = 7666;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 15685;
			ObjectClass = 12;
			SubClass = 0;
			Level = 37;
			ReqLevel = 37;
			Name = "Shattered Necklace";
			Name2 = "Shattered Necklace";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 2198;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Talvash's Phial of Scrying)
*
***************************************************************/

namespace Server.Items
{
	public class TalvashsPhialOfScrying : Item
	{
		public TalvashsPhialOfScrying() : base()
		{
			Id = 7667;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8752;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Talvash's Phial of Scrying";
			Name2 = "Talvash's Phial of Scrying";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 9489 , 0 , -5 , 120000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Shattered Necklace Ruby)
*
***************************************************************/

namespace Server.Items
{
	public class ShatteredNecklaceRuby : Item
	{
		public ShatteredNecklaceRuby() : base()
		{
			Id = 7669;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7045;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shattered Necklace Ruby";
			Name2 = "Shattered Necklace Ruby";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Shattered Necklace Sapphire)
*
***************************************************************/

namespace Server.Items
{
	public class ShatteredNecklaceSapphire : Item
	{
		public ShatteredNecklaceSapphire() : base()
		{
			Id = 7670;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1659;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shattered Necklace Sapphire";
			Name2 = "Shattered Necklace Sapphire";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Shattered Necklace Topaz)
*
***************************************************************/

namespace Server.Items
{
	public class ShatteredNecklaceTopaz : Item
	{
		public ShatteredNecklaceTopaz() : base()
		{
			Id = 7671;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18707;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shattered Necklace Topaz";
			Name2 = "Shattered Necklace Topaz";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Shattered Necklace Power Source)
*
***************************************************************/

namespace Server.Items
{
	public class ShatteredNecklacePowerSource : Item
	{
		public ShatteredNecklacePowerSource() : base()
		{
			Id = 7672;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6014;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shattered Necklace Power Source";
			Name2 = "Shattered Necklace Power Source";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Delivery to Mathias)
*
***************************************************************/

namespace Server.Items
{
	public class DeliveryToMathias : Item
	{
		public DeliveryToMathias() : base()
		{
			Id = 7674;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Sealed";
			Model = 15692;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Delivery to Mathias";
			Name2 = "Delivery to Mathias";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Defias Shipping Schedule)
*
***************************************************************/

namespace Server.Items
{
	public class DefiasShippingSchedule : Item
	{
		public DefiasShippingSchedule() : base()
		{
			Id = 7675;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9717;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Defias Shipping Schedule";
			Name2 = "Defias Shipping Schedule";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Shrike Bat Fang)
*
***************************************************************/

namespace Server.Items
{
	public class ShrikeBatFang : Item
	{
		public ShrikeBatFang() : base()
		{
			Id = 7679;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7886;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shrike Bat Fang";
			Name2 = "Shrike Bat Fang";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Jadespine Basilisk Scale)
*
***************************************************************/

namespace Server.Items
{
	public class JadespineBasiliskScale : Item
	{
		public JadespineBasiliskScale() : base()
		{
			Id = 7680;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3563;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jadespine Basilisk Scale";
			Name2 = "Jadespine Basilisk Scale";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Obsidian Golem Shard)
*
***************************************************************/

namespace Server.Items
{
	public class ObsidianGolemShard : Item
	{
		public ObsidianGolemShard() : base()
		{
			Id = 7681;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15805;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Obsidian Golem Shard";
			Name2 = "Obsidian Golem Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Onin's Report)
*
***************************************************************/

namespace Server.Items
{
	public class OninsReport : Item
	{
		public OninsReport() : base()
		{
			Id = 7715;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9725;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Onin's Report";
			Name2 = "Onin's Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Shattered Necklace)
*
***************************************************************/

namespace Server.Items
{
	public class ShatteredNecklace7716 : Item
	{
		public ShatteredNecklace7716() : base()
		{
			Id = 7716;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 15685;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shattered Necklace";
			Name2 = "Shattered Necklace";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Staff of Prehistoria)
*
***************************************************************/

namespace Server.Items
{
	public class StaffOfPrehistoria : Item
	{
		public StaffOfPrehistoria() : base()
		{
			Id = 7733;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15828;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Staff of Prehistoria";
			Name2 = "Staff of Prehistoria";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 9577 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Jannok's Rose)
*
***************************************************************/

namespace Server.Items
{
	public class JannoksRose : Item
	{
		public JannoksRose() : base()
		{
			Id = 7735;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13489;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Jannok's Rose";
			Name2 = "Jannok's Rose";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sethir's Journal)
*
***************************************************************/

namespace Server.Items
{
	public class SethirsJournal : Item
	{
		public SethirsJournal() : base()
		{
			Id = 7737;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Written in a language you cannot decipher.";
			Model = 1246;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Sethir's Journal";
			Name2 = "Sethir's Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gni'kiv Medallion)
*
***************************************************************/

namespace Server.Items
{
	public class GnikivMedallion : Item
	{
		public GnikivMedallion() : base()
		{
			Id = 7740;
			AvailableClasses = 0x7FFF;
			Model = 7366;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gni'kiv Medallion";
			Name2 = "Gni'kiv Medallion";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 1088;
			SetSpell( 9594 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(The Shaft of Tsol)
*
***************************************************************/

namespace Server.Items
{
	public class TheShaftOfTsol : Item
	{
		public TheShaftOfTsol() : base()
		{
			Id = 7741;
			AvailableClasses = 0x7FFF;
			Model = 15867;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The Shaft of Tsol";
			Name2 = "The Shaft of Tsol";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Flags = 1088;
			SetSpell( 9595 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Empty Brown Waterskin)
*
***************************************************************/

namespace Server.Items
{
	public class EmptyBrownWaterskin : Item
	{
		public EmptyBrownWaterskin() : base()
		{
			Id = 7766;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 29438;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Empty Brown Waterskin";
			Name2 = "Empty Brown Waterskin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 9586 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Empty Blue Waterskin)
*
***************************************************************/

namespace Server.Items
{
	public class EmptyBlueWaterskin : Item
	{
		public EmptyBlueWaterskin() : base()
		{
			Id = 7767;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 29434;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Empty Blue Waterskin";
			Name2 = "Empty Blue Waterskin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 9584 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Empty Red Waterskin)
*
***************************************************************/

namespace Server.Items
{
	public class EmptyRedWaterskin : Item
	{
		public EmptyRedWaterskin() : base()
		{
			Id = 7768;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 29436;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Empty Red Waterskin";
			Name2 = "Empty Red Waterskin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 9583 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Filled Brown Waterskin)
*
***************************************************************/

namespace Server.Items
{
	public class FilledBrownWaterskin : Item
	{
		public FilledBrownWaterskin() : base()
		{
			Id = 7769;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 29439;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Filled Brown Waterskin";
			Name2 = "Filled Brown Waterskin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Filled Blue Waterskin)
*
***************************************************************/

namespace Server.Items
{
	public class FilledBlueWaterskin : Item
	{
		public FilledBlueWaterskin() : base()
		{
			Id = 7770;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 29435;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Filled Blue Waterskin";
			Name2 = "Filled Blue Waterskin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Filled Red Waterskin)
*
***************************************************************/

namespace Server.Items
{
	public class FilledRedWaterskin : Item
	{
		public FilledRedWaterskin() : base()
		{
			Id = 7771;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 29437;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Filled Red Waterskin";
			Name2 = "Filled Red Waterskin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Vial of Purest Water)
*
***************************************************************/

namespace Server.Items
{
	public class VialOfPurestWater : Item
	{
		public VialOfPurestWater() : base()
		{
			Id = 7810;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15794;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vial of Purest Water";
			Name2 = "Vial of Purest Water";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Remaining Drops of Purest Water)
*
***************************************************************/

namespace Server.Items
{
	public class RemainingDropsOfPurestWater : Item
	{
		public RemainingDropsOfPurestWater() : base()
		{
			Id = 7811;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4836;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Remaining Drops of Purest Water";
			Name2 = "Remaining Drops of Purest Water";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Corrupt Manifestation's Bracers)
*
***************************************************************/

namespace Server.Items
{
	public class CorruptManifestationsBracers : Item
	{
		public CorruptManifestationsBracers() : base()
		{
			Id = 7812;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4829;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Corrupt Manifestation's Bracers";
			Name2 = "Corrupt Manifestation's Bracers";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Shard of Water)
*
***************************************************************/

namespace Server.Items
{
	public class ShardOfWater : Item
	{
		public ShardOfWater() : base()
		{
			Id = 7813;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1659;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Shard of Water";
			Name2 = "Shard of Water";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crag Coyote Fang)
*
***************************************************************/

namespace Server.Items
{
	public class CragCoyoteFang : Item
	{
		public CragCoyoteFang() : base()
		{
			Id = 7846;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7886;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crag Coyote Fang";
			Name2 = "Crag Coyote Fang";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Buzzard Gizzard)
*
***************************************************************/

namespace Server.Items
{
	public class BuzzardGizzard : Item
	{
		public BuzzardGizzard() : base()
		{
			Id = 7847;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1438;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Buzzard Gizzard";
			Name2 = "Buzzard Gizzard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Rock Elemental Shard)
*
***************************************************************/

namespace Server.Items
{
	public class RockElementalShard : Item
	{
		public RockElementalShard() : base()
		{
			Id = 7848;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18500;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rock Elemental Shard";
			Name2 = "Rock Elemental Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Empty Thaumaturgy Vessel)
*
***************************************************************/

namespace Server.Items
{
	public class EmptyThaumaturgyVessel : Item
	{
		public EmptyThaumaturgyVessel() : base()
		{
			Id = 7866;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 16023;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Empty Thaumaturgy Vessel";
			Name2 = "Empty Thaumaturgy Vessel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 9712 , 0 , -1 , 60000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Vessel of Dragon's Blood)
*
***************************************************************/

namespace Server.Items
{
	public class VesselOfDragonsBlood : Item
	{
		public VesselOfDragonsBlood() : base()
		{
			Id = 7867;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16024;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vessel of Dragon's Blood";
			Name2 = "Vessel of Dragon's Blood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Thaumaturgy Vessel Lockbox)
*
***************************************************************/

namespace Server.Items
{
	public class ThaumaturgyVesselLockbox : Item
	{
		public ThaumaturgyVesselLockbox() : base()
		{
			Id = 7870;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Inside this lockbox are the empty thaumaturgy vessels.";
			Model = 18721;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thaumaturgy Vessel Lockbox";
			Name2 = "Thaumaturgy Vessel Lockbox";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 4;
		}
	}
}


/**************************************************************
*
*				(Token of Thievery)
*
***************************************************************/

namespace Server.Items
{
	public class TokenOfThievery : Item
	{
		public TokenOfThievery() : base()
		{
			Id = 7871;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6357;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Token of Thievery";
			Name2 = "Token of Thievery";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Untranslated Journal)
*
***************************************************************/

namespace Server.Items
{
	public class UntranslatedJournal : Item
	{
		public UntranslatedJournal() : base()
		{
			Id = 7886;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "You do not understand the writing in the journal.";
			Model = 4049;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Untranslated Journal";
			Name2 = "Untranslated Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Necklace and Gem Salvage)
*
***************************************************************/

namespace Server.Items
{
	public class NecklaceAndGemSalvage : Item
	{
		public NecklaceAndGemSalvage() : base()
		{
			Id = 7887;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16052;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Necklace and Gem Salvage";
			Name2 = "Necklace and Gem Salvage";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Horns of Nez'ra)
*
***************************************************************/

namespace Server.Items
{
	public class HornsOfNezra : Item
	{
		public HornsOfNezra() : base()
		{
			Id = 7906;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16283;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Horns of Nez'ra";
			Name2 = "Horns of Nez'ra";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Klaven Mortwake's Journal)
*
***************************************************************/

namespace Server.Items
{
	public class KlavenMortwakesJournal : Item
	{
		public KlavenMortwakesJournal() : base()
		{
			Id = 7908;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1134;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Klaven Mortwake's Journal";
			Name2 = "Klaven Mortwake's Journal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 1151;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Southsea Treasure)
*
***************************************************************/

namespace Server.Items
{
	public class SouthseaTreasure : Item
	{
		public SouthseaTreasure() : base()
		{
			Id = 7968;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16190;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Southsea Treasure";
			Name2 = "Southsea Treasure";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dentrium Power Stone)
*
***************************************************************/

namespace Server.Items
{
	public class DentriumPowerStone : Item
	{
		public DentriumPowerStone() : base()
		{
			Id = 8009;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17923;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dentrium Power Stone";
			Name2 = "Dentrium Power Stone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Garrett Family Treasure)
*
***************************************************************/

namespace Server.Items
{
	public class GarrettFamilyTreasure : Item
	{
		public GarrettFamilyTreasure() : base()
		{
			Id = 8026;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18722;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Garrett Family Treasure";
			Name2 = "Garrett Family Treasure";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Krom Stoutarm's Treasure)
*
***************************************************************/

namespace Server.Items
{
	public class KromStoutarmsTreasure : Item
	{
		public KromStoutarmsTreasure() : base()
		{
			Id = 8027;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18718;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Krom Stoutarm's Treasure";
			Name2 = "Krom Stoutarm's Treasure";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Magenta Fungus Cap)
*
***************************************************************/

namespace Server.Items
{
	public class MagentaFungusCap : Item
	{
		public MagentaFungusCap() : base()
		{
			Id = 8047;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18719;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Magenta Fungus Cap";
			Name2 = "Magenta Fungus Cap";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gnarlpine Necklace)
*
***************************************************************/

namespace Server.Items
{
	public class GnarlpineNecklace : Item
	{
		public GnarlpineNecklace() : base()
		{
			Id = 8049;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The glowing emerald just needs to be pulled out...";
			Model = 6539;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gnarlpine Necklace";
			Name2 = "Gnarlpine Necklace";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = 3;
			Flags = 2052;
		}
	}
}


/**************************************************************
*
*				(Tallonkai's Jewel)
*
***************************************************************/

namespace Server.Items
{
	public class TallonkaisJewel : Item
	{
		public TallonkaisJewel() : base()
		{
			Id = 8050;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 6851;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tallonkai's Jewel";
			Name2 = "Tallonkai's Jewel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Flare Gun)
*
***************************************************************/

namespace Server.Items
{
	public class FlareGun : Item
	{
		public FlareGun() : base()
		{
			Id = 8051;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 16299;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Flare Gun";
			Name2 = "Flare Gun";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 10113 , 0 , 10 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(An'Alleum Power Stone)
*
***************************************************************/

namespace Server.Items
{
	public class AnAlleumPowerStone : Item
	{
		public AnAlleumPowerStone() : base()
		{
			Id = 8052;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17922;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "An'Alleum Power Stone";
			Name2 = "An'Alleum Power Stone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Obsidian Power Source)
*
***************************************************************/

namespace Server.Items
{
	public class ObsidianPowerSource : Item
	{
		public ObsidianPowerSource() : base()
		{
			Id = 8053;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12410;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Obsidian Power Source";
			Name2 = "Obsidian Power Source";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Fizzule's Whistle)
*
***************************************************************/

namespace Server.Items
{
	public class FizzulesWhistle : Item
	{
		public FizzulesWhistle() : base()
		{
			Id = 8066;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 16303;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Fizzule's Whistle";
			Name2 = "Fizzule's Whistle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 10137 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Reward Voucher)
*
***************************************************************/

namespace Server.Items
{
	public class RewardVoucher : Item
	{
		public RewardVoucher() : base()
		{
			Id = 8070;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3029;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Reward Voucher";
			Name2 = "Reward Voucher";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Cache of Zanzil's Altered Mixture)
*
***************************************************************/

namespace Server.Items
{
	public class CacheOfZanzilsAlteredMixture : Item
	{
		public CacheOfZanzilsAlteredMixture() : base()
		{
			Id = 8073;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16321;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Cache of Zanzil's Altered Mixture";
			Name2 = "Cache of Zanzil's Altered Mixture";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gallywix's Head)
*
***************************************************************/

namespace Server.Items
{
	public class GallywixsHead : Item
	{
		public GallywixsHead() : base()
		{
			Id = 8074;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16322;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Gallywix's Head";
			Name2 = "Gallywix's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gargantuan Tumor)
*
***************************************************************/

namespace Server.Items
{
	public class GargantuanTumor : Item
	{
		public GargantuanTumor() : base()
		{
			Id = 8136;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1438;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Gargantuan Tumor";
			Name2 = "Gargantuan Tumor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Voodoo Charm)
*
***************************************************************/

namespace Server.Items
{
	public class VoodooCharm : Item
	{
		public VoodooCharm() : base()
		{
			Id = 8149;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16456;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Voodoo Charm";
			Name2 = "Voodoo Charm";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 10617 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Sathrah's Sacrifice)
*
***************************************************************/

namespace Server.Items
{
	public class SathrahsSacrifice : Item
	{
		public SathrahsSacrifice() : base()
		{
			Id = 8155;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16464;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sathrah's Sacrifice";
			Name2 = "Sathrah's Sacrifice";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 10459 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Flawless Draenethyst Sphere)
*
***************************************************************/

namespace Server.Items
{
	public class FlawlessDraenethystSphere : Item
	{
		public FlawlessDraenethystSphere() : base()
		{
			Id = 8244;
			SellPrice = 10000;
			AvailableClasses = 0x7FFF;
			Model = 18704;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Flawless Draenethyst Sphere";
			Name2 = "Flawless Draenethyst Sphere";
			Quality = 3;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Silvery Spinnerets)
*
***************************************************************/

namespace Server.Items
{
	public class SilverySpinnerets : Item
	{
		public SilverySpinnerets() : base()
		{
			Id = 8344;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16464;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Silvery Spinnerets";
			Name2 = "Silvery Spinnerets";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Shaman Voodoo Charm)
*
***************************************************************/

namespace Server.Items
{
	public class ShamanVoodooCharm : Item
	{
		public ShamanVoodooCharm() : base()
		{
			Id = 8363;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16456;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Shaman Voodoo Charm";
			Name2 = "Shaman Voodoo Charm";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Snickerfang Jowl)
*
***************************************************************/

namespace Server.Items
{
	public class SnickerfangJowl : Item
	{
		public SnickerfangJowl() : base()
		{
			Id = 8391;
			AvailableClasses = 0x7FFF;
			Model = 1116;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Snickerfang Jowl";
			Name2 = "Snickerfang Jowl";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Blasted Boar Lung)
*
***************************************************************/

namespace Server.Items
{
	public class BlastedBoarLung : Item
	{
		public BlastedBoarLung() : base()
		{
			Id = 8392;
			AvailableClasses = 0x7FFF;
			Model = 1438;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Blasted Boar Lung";
			Name2 = "Blasted Boar Lung";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Scorpok Pincer)
*
***************************************************************/

namespace Server.Items
{
	public class ScorpokPincer : Item
	{
		public ScorpokPincer() : base()
		{
			Id = 8393;
			AvailableClasses = 0x7FFF;
			Model = 16776;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Scorpok Pincer";
			Name2 = "Scorpok Pincer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Basilisk Brain)
*
***************************************************************/

namespace Server.Items
{
	public class BasiliskBrain : Item
	{
		public BasiliskBrain() : base()
		{
			Id = 8394;
			AvailableClasses = 0x7FFF;
			Model = 10923;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Basilisk Brain";
			Name2 = "Basilisk Brain";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Vulture Gizzard)
*
***************************************************************/

namespace Server.Items
{
	public class VultureGizzard : Item
	{
		public VultureGizzard() : base()
		{
			Id = 8396;
			AvailableClasses = 0x7FFF;
			Model = 3759;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Vulture Gizzard";
			Name2 = "Vulture Gizzard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Laden Dew Gland)
*
***************************************************************/

namespace Server.Items
{
	public class LadenDewGland : Item
	{
		public LadenDewGland() : base()
		{
			Id = 8428;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16861;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Laden Dew Gland";
			Name2 = "Laden Dew Gland";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Spool of Light Chartreuse Silk Thread)
*
***************************************************************/

namespace Server.Items
{
	public class SpoolOfLightChartreuseSilkThread : Item
	{
		public SpoolOfLightChartreuseSilkThread() : base()
		{
			Id = 8431;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7403;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Spool of Light Chartreuse Silk Thread";
			Name2 = "Spool of Light Chartreuse Silk Thread";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gahz'ridian Ornament)
*
***************************************************************/

namespace Server.Items
{
	public class GahzridianOrnament : Item
	{
		public GahzridianOrnament() : base()
		{
			Id = 8443;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18725;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gahz'ridian Ornament";
			Name2 = "Gahz'ridian Ornament";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Warchief's Orders)
*
***************************************************************/

namespace Server.Items
{
	public class WarchiefsOrders : Item
	{
		public WarchiefsOrders() : base()
		{
			Id = 8463;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The seal is broken.";
			Model = 16161;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Warchief's Orders";
			Name2 = "Warchief's Orders";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 1071;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Field Testing Kit)
*
***************************************************************/

namespace Server.Items
{
	public class FieldTestingKit : Item
	{
		public FieldTestingKit() : base()
		{
			Id = 8523;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2592;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Field Testing Kit";
			Name2 = "Field Testing Kit";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1000;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Model 4711-FTZ Power Source)
*
***************************************************************/

namespace Server.Items
{
	public class Model4711FTZPowerSource : Item
	{
		public Model4711FTZPowerSource() : base()
		{
			Id = 8524;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "Using this power source will activate the Field Testing Kit.";
			Model = 14993;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Model 4711-FTZ Power Source";
			Name2 = "Model 4711-FTZ Power Source";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 654;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Zinge's Purchase Order)
*
***************************************************************/

namespace Server.Items
{
	public class ZingesPurchaseOrder : Item
	{
		public ZingesPurchaseOrder() : base()
		{
			Id = 8525;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Zinge's Purchase Order";
			Name2 = "Zinge's Purchase Order";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Violet Tragan)
*
***************************************************************/

namespace Server.Items
{
	public class VioletTragan : Item
	{
		public VioletTragan() : base()
		{
			Id = 8526;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17391;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Violet Tragan";
			Name2 = "Violet Tragan";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 6727 , 0 , -1 , 0 , 11 , 1000 );
		}
	}
}


/**************************************************************
*
*				(Sealed Field Testing Kit)
*
***************************************************************/

namespace Server.Items
{
	public class SealedFieldTestingKit : Item
	{
		public SealedFieldTestingKit() : base()
		{
			Id = 8527;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2592;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sealed Field Testing Kit";
			Name2 = "Sealed Field Testing Kit";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Violet Powder)
*
***************************************************************/

namespace Server.Items
{
	public class VioletPowder : Item
	{
		public VioletPowder() : base()
		{
			Id = 8528;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17397;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Violet Powder";
			Name2 = "Violet Powder";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Hippogryph Egg)
*
***************************************************************/

namespace Server.Items
{
	public class HippogryphEgg : Item
	{
		public HippogryphEgg() : base()
		{
			Id = 8564;
			Bonding = 1;
			SellPrice = 200;
			AvailableClasses = 0x7FFF;
			Description = "It's huge!";
			Model = 18047;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hippogryph Egg";
			Name2 = "Hippogryph Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 800;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Untapped Dowsing Widget)
*
***************************************************************/

namespace Server.Items
{
	public class UntappedDowsingWidget : Item
	{
		public UntappedDowsingWidget() : base()
		{
			Id = 8584;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18717;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Untapped Dowsing Widget";
			Name2 = "Untapped Dowsing Widget";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 11758 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Tapped Dowsing Widget)
*
***************************************************************/

namespace Server.Items
{
	public class TappedDowsingWidget : Item
	{
		public TappedDowsingWidget() : base()
		{
			Id = 8585;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15718;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Tapped Dowsing Widget";
			Name2 = "Tapped Dowsing Widget";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Centipaar Insect Parts)
*
***************************************************************/

namespace Server.Items
{
	public class CentipaarInsectParts : Item
	{
		public CentipaarInsectParts() : base()
		{
			Id = 8587;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18723;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Centipaar Insect Parts";
			Name2 = "Centipaar Insect Parts";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Scrimshank's Surveying Gear)
*
***************************************************************/

namespace Server.Items
{
	public class ScrimshanksSurveyingGear : Item
	{
		public ScrimshanksSurveyingGear() : base()
		{
			Id = 8593;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 14326;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scrimshank's Surveying Gear";
			Name2 = "Scrimshank's Surveying Gear";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Insect Analysis Report)
*
***************************************************************/

namespace Server.Items
{
	public class InsectAnalysisReport : Item
	{
		public InsectAnalysisReport() : base()
		{
			Id = 8594;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7695;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Insect Analysis Report";
			Name2 = "Insect Analysis Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Thistleshrub Dew)
*
***************************************************************/

namespace Server.Items
{
	public class ThistleshrubDew : Item
	{
		public ThistleshrubDew() : base()
		{
			Id = 8603;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15734;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Thistleshrub Dew";
			Name2 = "Thistleshrub Dew";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(OOX-17/TN Distress Beacon)
*
***************************************************************/

namespace Server.Items
{
	public class OOX17TNDistressBeacon : Item
	{
		public OOX17TNDistressBeacon() : base()
		{
			Id = 8623;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 18632;
			ObjectClass = 12;
			SubClass = 0;
			Level = 43;
			ReqLevel = 43;
			Name = "OOX-17/TN Distress Beacon";
			Name2 = "OOX-17/TN Distress Beacon";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 351;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Extraordinary Egg)
*
***************************************************************/

namespace Server.Items
{
	public class ExtraordinaryEgg : Item
	{
		public ExtraordinaryEgg() : base()
		{
			Id = 8643;
			Bonding = 1;
			SellPrice = 2500;
			AvailableClasses = 0x7FFF;
			Description = "There's something very special about this egg...";
			Model = 18050;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Extraordinary Egg";
			Name2 = "Extraordinary Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 10000;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fine Egg)
*
***************************************************************/

namespace Server.Items
{
	public class FineEgg : Item
	{
		public FineEgg() : base()
		{
			Id = 8644;
			Bonding = 1;
			SellPrice = 1500;
			AvailableClasses = 0x7FFF;
			Model = 18050;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fine Egg";
			Name2 = "Fine Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 6000;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ordinary Egg)
*
***************************************************************/

namespace Server.Items
{
	public class OrdinaryEgg : Item
	{
		public OrdinaryEgg() : base()
		{
			Id = 8645;
			Bonding = 1;
			SellPrice = 750;
			AvailableClasses = 0x7FFF;
			Model = 18049;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ordinary Egg";
			Name2 = "Ordinary Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 3000;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bad Egg)
*
***************************************************************/

namespace Server.Items
{
	public class BadEgg : Item
	{
		public BadEgg() : base()
		{
			Id = 8646;
			Bonding = 1;
			SellPrice = 250;
			AvailableClasses = 0x7FFF;
			Model = 18049;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bad Egg";
			Name2 = "Bad Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1000;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Egg Crate)
*
***************************************************************/

namespace Server.Items
{
	public class EggCrate : Item
	{
		public EggCrate() : base()
		{
			Id = 8647;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "Quality Guaranteed!";
			Model = 12331;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Egg Crate";
			Name2 = "Egg Crate";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = 2;
			Flags = 4;
		}
	}
}


/**************************************************************
*
*				(Mithril Insignia)
*
***************************************************************/

namespace Server.Items
{
	public class MithrilInsignia : Item
	{
		public MithrilInsignia() : base()
		{
			Id = 8663;
			Resistance[0] = 50;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "E Pluribus Mithril";
			Model = 17655;
			ObjectClass = 12;
			SubClass = 0;
			Level = 40;
			Name = "Mithril Insignia";
			Name2 = "Mithril Insignia";
			Quality = 2;
			AvailableRaces = 0x1FF;
			SkillRank = 210;
			Skill = 164;
			InventoryType = InventoryTypes.Trinket1;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Clara's Fresh Apple)
*
***************************************************************/

namespace Server.Items
{
	public class ClarasFreshApple : Item
	{
		public ClarasFreshApple() : base()
		{
			Id = 8683;
			Bonding = 1;
			SellPrice = 1;
			AvailableClasses = 0x7FFF;
			Description = "A fresh piece of fruit that's good to eat... and is apparently good for disguises also!";
			Model = 6410;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Clara's Fresh Apple";
			Name2 = "Clara's Fresh Apple";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 4;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			SetSpell( 7737 , 0 , -1 , 0 , 11 , 1000 );
		}
	}
}


/**************************************************************
*
*				(Hinterlands Honey Ripple)
*
***************************************************************/

namespace Server.Items
{
	public class HinterlandsHoneyRipple : Item
	{
		public HinterlandsHoneyRipple() : base()
		{
			Id = 8684;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18079;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hinterlands Honey Ripple";
			Name2 = "Hinterlands Honey Ripple";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dran's Ripple Delivery)
*
***************************************************************/

namespace Server.Items
{
	public class DransRippleDelivery : Item
	{
		public DransRippleDelivery() : base()
		{
			Id = 8685;
			AvailableClasses = 0x7FFF;
			Description = "This barrel contains Dran's packaged ripple and his extra bottles.";
			Model = 8381;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dran's Ripple Delivery";
			Name2 = "Dran's Ripple Delivery";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mithril Pendant)
*
***************************************************************/

namespace Server.Items
{
	public class MithrilPendant : Item
	{
		public MithrilPendant() : base()
		{
			Id = 8686;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Bears the Seal of Galvan the Ancient";
			Model = 17685;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Mithril Pendant";
			Name2 = "Mithril Pendant";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sealed Description of Thredd's Visitor)
*
***************************************************************/

namespace Server.Items
{
	public class SealedDescriptionOfThreddsVisitor : Item
	{
		public SealedDescriptionOfThreddsVisitor() : base()
		{
			Id = 8687;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7744;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sealed Description of Thredd's Visitor";
			Name2 = "Sealed Description of Thredd's Visitor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Signet of Expertise)
*
***************************************************************/

namespace Server.Items
{
	public class SignetOfExpertise : Item
	{
		public SignetOfExpertise() : base()
		{
			Id = 8703;
			Bonding = 1;
			SellPrice = 6492;
			AvailableClasses = 0x7FFF;
			Description = "Honorable Member of the Mithril Order";
			Model = 17776;
			ObjectClass = 12;
			SubClass = 0;
			Level = 45;
			Name = "Signet of Expertise";
			Name2 = "Signet of Expertise";
			Quality = 2;
			AvailableRaces = 0x1FF;
			SkillRank = 210;
			Skill = 164;
			BuyPrice = 25968;
			InventoryType = InventoryTypes.Trinket1;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 11209 , 0 , 0 , 10800000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(OOX-09/HL Distress Beacon)
*
***************************************************************/

namespace Server.Items
{
	public class OOX09HLDistressBeacon : Item
	{
		public OOX09HLDistressBeacon() : base()
		{
			Id = 8704;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 18632;
			ObjectClass = 12;
			SubClass = 0;
			Level = 43;
			ReqLevel = 43;
			Name = "OOX-09/HL Distress Beacon";
			Name2 = "OOX-09/HL Distress Beacon";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 485;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(OOX-22/FE Distress Beacon)
*
***************************************************************/

namespace Server.Items
{
	public class OOX22FEDistressBeacon : Item
	{
		public OOX22FEDistressBeacon() : base()
		{
			Id = 8705;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 18632;
			ObjectClass = 12;
			SubClass = 0;
			Level = 40;
			ReqLevel = 40;
			Name = "OOX-22/FE Distress Beacon";
			Name2 = "OOX-22/FE Distress Beacon";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 2766;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gahz'rilla's Electrified Scale)
*
***************************************************************/

namespace Server.Items
{
	public class GahzrillasElectrifiedScale : Item
	{
		public GahzrillasElectrifiedScale() : base()
		{
			Id = 8707;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8923;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gahz'rilla's Electrified Scale";
			Name2 = "Gahz'rilla's Electrified Scale";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Caliph Scorpidsting's Head)
*
***************************************************************/

namespace Server.Items
{
	public class CaliphScorpidstingsHead : Item
	{
		public CaliphScorpidstingsHead() : base()
		{
			Id = 8723;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3918;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Caliph Scorpidsting's Head";
			Name2 = "Caliph Scorpidsting's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Rin'ji's Secret)
*
***************************************************************/

namespace Server.Items
{
	public class RinjisSecret : Item
	{
		public RinjisSecret() : base()
		{
			Id = 8724;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17809;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Rin'ji's Secret";
			Name2 = "Rin'ji's Secret";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Thick Yeti Hide)
*
***************************************************************/

namespace Server.Items
{
	public class ThickYetiHide : Item
	{
		public ThickYetiHide() : base()
		{
			Id = 8973;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7373;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thick Yeti Hide";
			Name2 = "Thick Yeti Hide";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Rig Blueprints)
*
***************************************************************/

namespace Server.Items
{
	public class RigBlueprints : Item
	{
		public RigBlueprints() : base()
		{
			Id = 9153;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Rig Blueprints";
			Name2 = "Rig Blueprints";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Goblin Transponder)
*
***************************************************************/

namespace Server.Items
{
	public class GoblinTransponder : Item
	{
		public GoblinTransponder() : base()
		{
			Id = 9173;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17899;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Goblin Transponder";
			Name2 = "Goblin Transponder";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Shay's Bell)
*
***************************************************************/

namespace Server.Items
{
	public class ShaysBell : Item
	{
		public ShaysBell() : base()
		{
			Id = 9189;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17911;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shay's Bell";
			Name2 = "Shay's Bell";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2112;
			SetSpell( 11402 , 0 , 0 , 60000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Tiara of the Deep)
*
***************************************************************/

namespace Server.Items
{
	public class TiaraOfTheDeep : Item
	{
		public TiaraOfTheDeep() : base()
		{
			Id = 9234;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1399;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tiara of the Deep";
			Name2 = "Tiara of the Deep";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Pratt's Letter)
*
***************************************************************/

namespace Server.Items
{
	public class PrattsLetter : Item
	{
		public PrattsLetter() : base()
		{
			Id = 9235;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3018;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pratt's Letter";
			Name2 = "Pratt's Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Jangdor's Letter)
*
***************************************************************/

namespace Server.Items
{
	public class JangdorsLetter : Item
	{
		public JangdorsLetter() : base()
		{
			Id = 9236;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3029;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Jangdor's Letter";
			Name2 = "Jangdor's Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Woodpaw Gnoll Mane)
*
***************************************************************/

namespace Server.Items
{
	public class WoodpawGnollMane : Item
	{
		public WoodpawGnollMane() : base()
		{
			Id = 9237;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Woodpaw Gnoll Mane";
			Name2 = "Woodpaw Gnoll Mane";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Uncracked Scarab Shell)
*
***************************************************************/

namespace Server.Items
{
	public class UncrackedScarabShell : Item
	{
		public UncrackedScarabShell() : base()
		{
			Id = 9238;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8923;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Uncracked Scarab Shell";
			Name2 = "Uncracked Scarab Shell";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mallet of Zul'Farrak)
*
***************************************************************/

namespace Server.Items
{
	public class MalletOfZulFarrak : Item
	{
		public MalletOfZulFarrak() : base()
		{
			Id = 9240;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 17916;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mallet of Zul'Farrak";
			Name2 = "Mallet of Zul'Farrak";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2112;
			SetSpell( 11434 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Sacred Mallet)
*
***************************************************************/

namespace Server.Items
{
	public class SacredMallet : Item
	{
		public SacredMallet() : base()
		{
			Id = 9241;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 17916;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sacred Mallet";
			Name2 = "Sacred Mallet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2112;
			SetSpell( 11435 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Stoley's Shipment)
*
***************************************************************/

namespace Server.Items
{
	public class StoleysShipment : Item
	{
		public StoleysShipment() : base()
		{
			Id = 9244;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7922;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stoley's Shipment";
			Name2 = "Stoley's Shipment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Stoley's Bottle)
*
***************************************************************/

namespace Server.Items
{
	public class StoleysBottle : Item
	{
		public StoleysBottle() : base()
		{
			Id = 9245;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18080;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stoley's Bottle";
			Name2 = "Stoley's Bottle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Firebeard's Head)
*
***************************************************************/

namespace Server.Items
{
	public class FirebeardsHead : Item
	{
		public FirebeardsHead() : base()
		{
			Id = 9246;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7038;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Firebeard's Head";
			Name2 = "Firebeard's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Hatecrest Naga Scale)
*
***************************************************************/

namespace Server.Items
{
	public class HatecrestNagaScale : Item
	{
		public HatecrestNagaScale() : base()
		{
			Id = 9247;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3668;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Hatecrest Naga Scale";
			Name2 = "Hatecrest Naga Scale";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mysterious Relic)
*
***************************************************************/

namespace Server.Items
{
	public class MysteriousRelic : Item
	{
		public MysteriousRelic() : base()
		{
			Id = 9248;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18720;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Mysterious Relic";
			Name2 = "Mysterious Relic";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ship Schedule)
*
***************************************************************/

namespace Server.Items
{
	public class ShipSchedule : Item
	{
		public ShipSchedule() : base()
		{
			Id = 9250;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 811;
			ObjectClass = 12;
			SubClass = 0;
			Level = 40;
			ReqLevel = 40;
			Name = "Ship Schedule";
			Name2 = "Ship Schedule";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 2876;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Upper Map Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class UpperMapFragment : Item
	{
		public UpperMapFragment() : base()
		{
			Id = 9251;
			SellPrice = 62;
			AvailableClasses = 0x7FFF;
			Model = 7695;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Upper Map Fragment";
			Name2 = "Upper Map Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 250;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 1088;
			SetSpell( 11438 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Lower Map Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class LowerMapFragment : Item
	{
		public LowerMapFragment() : base()
		{
			Id = 9252;
			SellPrice = 62;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lower Map Fragment";
			Name2 = "Lower Map Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 250;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 1088;
			SetSpell( 11438 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Middle Map Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class MiddleMapFragment : Item
	{
		public MiddleMapFragment() : base()
		{
			Id = 9253;
			SellPrice = 62;
			AvailableClasses = 0x7FFF;
			Model = 8927;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Middle Map Fragment";
			Name2 = "Middle Map Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 250;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 1088;
			SetSpell( 11438 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Cuergo's Treasure Map)
*
***************************************************************/

namespace Server.Items
{
	public class CuergosTreasureMap : Item
	{
		public CuergosTreasureMap() : base()
		{
			Id = 9254;
			AvailableClasses = 0x7FFF;
			Model = 1322;
			ObjectClass = 12;
			SubClass = 0;
			Level = 40;
			ReqLevel = 40;
			Name = "Cuergo's Treasure Map";
			Name2 = "Cuergo's Treasure Map";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 2882;
		}
	}
}


/**************************************************************
*
*				(Lahassa Essence)
*
***************************************************************/

namespace Server.Items
{
	public class LahassaEssence : Item
	{
		public LahassaEssence() : base()
		{
			Id = 9255;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 6688;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lahassa Essence";
			Name2 = "Lahassa Essence";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Imbel Essence)
*
***************************************************************/

namespace Server.Items
{
	public class ImbelEssence : Item
	{
		public ImbelEssence() : base()
		{
			Id = 9256;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 18021;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Imbel Essence";
			Name2 = "Imbel Essence";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Samha Essence)
*
***************************************************************/

namespace Server.Items
{
	public class SamhaEssence : Item
	{
		public SamhaEssence() : base()
		{
			Id = 9257;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 18022;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Samha Essence";
			Name2 = "Samha Essence";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Byltan Essence)
*
***************************************************************/

namespace Server.Items
{
	public class ByltanEssence : Item
	{
		public ByltanEssence() : base()
		{
			Id = 9258;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 1659;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Byltan Essence";
			Name2 = "Byltan Essence";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Troyas' Stave)
*
***************************************************************/

namespace Server.Items
{
	public class TroyasStave : Item
	{
		public TroyasStave() : base()
		{
			Id = 9263;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8556;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Troyas' Stave";
			Name2 = "Troyas' Stave";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 1088;
			SetSpell( 11537 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Cuergo's Hidden Treasure)
*
***************************************************************/

namespace Server.Items
{
	public class CuergosHiddenTreasure : Item
	{
		public CuergosHiddenTreasure() : base()
		{
			Id = 9265;
			SellPrice = 15;
			AvailableClasses = 0x7FFF;
			Model = 13100;
			ObjectClass = 12;
			SubClass = 0;
			Level = 45;
			Name = "Cuergo's Hidden Treasure";
			Name2 = "Cuergo's Hidden Treasure";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 60;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 4;
		}
	}
}


/**************************************************************
*
*				(Woodpaw Battle Plans)
*
***************************************************************/

namespace Server.Items
{
	public class WoodpawBattlePlans : Item
	{
		public WoodpawBattlePlans() : base()
		{
			Id = 9266;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3331;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Woodpaw Battle Plans";
			Name2 = "Woodpaw Battle Plans";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Cuergo's Key)
*
***************************************************************/

namespace Server.Items
{
	public class CuergosKey : Item
	{
		public CuergosKey() : base()
		{
			Id = 9275;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13025;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cuergo's Key";
			Name2 = "Cuergo's Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2112;
		}
	}
}


/**************************************************************
*
*				(Techbot's Memory Core)
*
***************************************************************/

namespace Server.Items
{
	public class TechbotsMemoryCore : Item
	{
		public TechbotsMemoryCore() : base()
		{
			Id = 9277;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17922;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Techbot's Memory Core";
			Name2 = "Techbot's Memory Core";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Essential Artificial)
*
***************************************************************/

namespace Server.Items
{
	public class EssentialArtificial : Item
	{
		public EssentialArtificial() : base()
		{
			Id = 9278;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18215;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Essential Artificial";
			Name2 = "Essential Artificial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(White Punch Card)
*
***************************************************************/

namespace Server.Items
{
	public class WhitePunchCard : Item
	{
		public WhitePunchCard() : base()
		{
			Id = 9279;
			Bonding = 1;
			SellPrice = 45;
			AvailableClasses = 0x7FFF;
			Description = "Grants access to Matrix Punchograph 3005-A";
			Model = 7355;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "White Punch Card";
			Name2 = "White Punch Card";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 180;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 1131;
		}
	}
}


/**************************************************************
*
*				(Yellow Punch Card)
*
***************************************************************/

namespace Server.Items
{
	public class YellowPunchCard : Item
	{
		public YellowPunchCard() : base()
		{
			Id = 9280;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Grants access to Matrix Punchograph 3005-B";
			Model = 7355;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Yellow Punch Card";
			Name2 = "Yellow Punch Card";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 1191;
		}
	}
}


/**************************************************************
*
*				(Red Punch Card)
*
***************************************************************/

namespace Server.Items
{
	public class RedPunchCard : Item
	{
		public RedPunchCard() : base()
		{
			Id = 9281;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Grants access to Matrix Punchograph 3005-D";
			Model = 7355;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Red Punch Card";
			Name2 = "Red Punch Card";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 1193;
		}
	}
}


/**************************************************************
*
*				(Blue Punch Card)
*
***************************************************************/

namespace Server.Items
{
	public class BluePunchCard : Item
	{
		public BluePunchCard() : base()
		{
			Id = 9282;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Grants access to Matrix Punchograph 3005-C";
			Model = 7355;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blue Punch Card";
			Name2 = "Blue Punch Card";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 1192;
		}
	}
}


/**************************************************************
*
*				(Empty Leaden Collection Phial)
*
***************************************************************/

namespace Server.Items
{
	public class EmptyLeadenCollectionPhial : Item
	{
		public EmptyLeadenCollectionPhial() : base()
		{
			Id = 9283;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "One Shot, One Fill";
			Model = 18057;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Empty Leaden Collection Phial";
			Name2 = "Empty Leaden Collection Phial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 11513 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Full Leaden Collection Phial)
*
***************************************************************/

namespace Server.Items
{
	public class FullLeadenCollectionPhial : Item
	{
		public FullLeadenCollectionPhial() : base()
		{
			Id = 9284;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Keep Out of Reach of Children";
			Model = 18057;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Full Leaden Collection Phial";
			Name2 = "Full Leaden Collection Phial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Stave of Equinex)
*
***************************************************************/

namespace Server.Items
{
	public class StaveOfEquinex : Item
	{
		public StaveOfEquinex() : base()
		{
			Id = 9306;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18026;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stave of Equinex";
			Name2 = "Stave of Equinex";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 2;
		}
	}
}


/**************************************************************
*
*				(A Sparkling Stone)
*
***************************************************************/

namespace Server.Items
{
	public class ASparklingStone : Item
	{
		public ASparklingStone() : base()
		{
			Id = 9307;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6506;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Sparkling Stone";
			Name2 = "A Sparkling Stone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Grime-Encrusted Object)
*
***************************************************************/

namespace Server.Items
{
	public class GrimeEncrustedObject : Item
	{
		public GrimeEncrustedObject() : base()
		{
			Id = 9308;
			SellPrice = 38;
			AvailableClasses = 0x7FFF;
			Description = "Caked grime obscures the true identity of this object.";
			Model = 18716;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Grime-Encrusted Object";
			Name2 = "Grime-Encrusted Object";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 152;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Robo-mechanical Guts)
*
***************************************************************/

namespace Server.Items
{
	public class RoboMechanicalGuts : Item
	{
		public RoboMechanicalGuts() : base()
		{
			Id = 9309;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8931;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Robo-mechanical Guts";
			Name2 = "Robo-mechanical Guts";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Prismatic Punch Card)
*
***************************************************************/

namespace Server.Items
{
	public class PrismaticPunchCard : Item
	{
		public PrismaticPunchCard() : base()
		{
			Id = 9316;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Data card only";
			Model = 7355;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Prismatic Punch Card";
			Name2 = "Prismatic Punch Card";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 1194;
		}
	}
}


/**************************************************************
*
*				(Witherbark Skull)
*
***************************************************************/

namespace Server.Items
{
	public class WitherbarkSkull : Item
	{
		public WitherbarkSkull() : base()
		{
			Id = 9320;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7150;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Witherbark Skull";
			Name2 = "Witherbark Skull";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Venom Bottle)
*
***************************************************************/

namespace Server.Items
{
	public class VenomBottle : Item
	{
		public VenomBottle() : base()
		{
			Id = 9321;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1288;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Venom Bottle";
			Name2 = "Venom Bottle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 3;
		}
	}
}


/**************************************************************
*
*				(Undamaged Venom Sac)
*
***************************************************************/

namespace Server.Items
{
	public class UndamagedVenomSac : Item
	{
		public UndamagedVenomSac() : base()
		{
			Id = 9322;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8940;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Undamaged Venom Sac";
			Name2 = "Undamaged Venom Sac";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Gadrin's Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class GadrinsParchment : Item
	{
		public GadrinsParchment() : base()
		{
			Id = 9323;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2616;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Gadrin's Parchment";
			Name2 = "Gadrin's Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 7;
			Flags = 64;
			SetSpell( 11548 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Shadra's Venom)
*
***************************************************************/

namespace Server.Items
{
	public class ShadrasVenom : Item
	{
		public ShadrasVenom() : base()
		{
			Id = 9324;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15770;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shadra's Venom";
			Name2 = "Shadra's Venom";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(A Small Stave)
*
***************************************************************/

namespace Server.Items
{
	public class ASmallStave : Item
	{
		public ASmallStave() : base()
		{
			Id = 9325;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Troyas has entrusted this to you until you return.";
			Model = 8556;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Small Stave";
			Name2 = "A Small Stave";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = 2;
		}
	}
}


/**************************************************************
*
*				(Grime-Encrusted Ring)
*
***************************************************************/

namespace Server.Items
{
	public class GrimeEncrustedRing : Item
	{
		public GrimeEncrustedRing() : base()
		{
			Id = 9326;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 13490;
			ObjectClass = 12;
			SubClass = 0;
			Level = 28;
			ReqLevel = 28;
			Name = "Grime-Encrusted Ring";
			Name2 = "Grime-Encrusted Ring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 2945;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Super Snapper FX)
*
***************************************************************/

namespace Server.Items
{
	public class SuperSnapperFX : Item
	{
		public SuperSnapperFX() : base()
		{
			Id = 9328;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "New & Improved!";
			Model = 18155;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Super Snapper FX";
			Name2 = "Super Snapper FX";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
			Flags = 64;
			SetSpell( 11610 , 0 , 0 , 1000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(A Short Note)
*
***************************************************************/

namespace Server.Items
{
	public class AShortNote : Item
	{
		public AShortNote() : base()
		{
			Id = 9329;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Tied with a bow.";
			Model = 3029;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Short Note";
			Name2 = "A Short Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 1156;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Snapshot of Gammerita)
*
***************************************************************/

namespace Server.Items
{
	public class SnapshotOfGammerita : Item
	{
		public SnapshotOfGammerita() : base()
		{
			Id = 9330;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "She's so photogenic...";
			Model = 18158;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Snapshot of Gammerita";
			Name2 = "Snapshot of Gammerita";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 1171;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Feralas: A History)
*
***************************************************************/

namespace Server.Items
{
	public class FeralasAHistory : Item
	{
		public FeralasAHistory() : base()
		{
			Id = 9331;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18164;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Feralas: A History";
			Name2 = "Feralas: A History";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 2;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Heavy Leaden Collection Phial)
*
***************************************************************/

namespace Server.Items
{
	public class HeavyLeadenCollectionPhial : Item
	{
		public HeavyLeadenCollectionPhial() : base()
		{
			Id = 9364;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Handle With Care";
			Model = 18057;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Heavy Leaden Collection Phial";
			Name2 = "Heavy Leaden Collection Phial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 12709 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(High Potency Radioactive Fallout)
*
***************************************************************/

namespace Server.Items
{
	public class HighPotencyRadioactiveFallout : Item
	{
		public HighPotencyRadioactiveFallout() : base()
		{
			Id = 9365;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "DANGER! DO NOT INGEST!";
			Model = 18649;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "High Potency Radioactive Fallout";
			Name2 = "High Potency Radioactive Fallout";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Jer'kai's Signet Ring)
*
***************************************************************/

namespace Server.Items
{
	public class JerkaisSignetRing : Item
	{
		public JerkaisSignetRing() : base()
		{
			Id = 9368;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9837;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jer'kai's Signet Ring";
			Name2 = "Jer'kai's Signet Ring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Iridescent Sprite Darter Wing)
*
***************************************************************/

namespace Server.Items
{
	public class IridescentSpriteDarterWing : Item
	{
		public IridescentSpriteDarterWing() : base()
		{
			Id = 9369;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3668;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Iridescent Sprite Darter Wing";
			Name2 = "Iridescent Sprite Darter Wing";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gordunni Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class GordunniScroll : Item
	{
		public GordunniScroll() : base()
		{
			Id = 9370;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 1093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 38;
			ReqLevel = 38;
			Name = "Gordunni Scroll";
			Name2 = "Gordunni Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 2978;
			MaxCount = 1;
			Material = -1;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Gordunni Orb)
*
***************************************************************/

namespace Server.Items
{
	public class GordunniOrb : Item
	{
		public GordunniOrb() : base()
		{
			Id = 9371;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16209;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gordunni Orb";
			Name2 = "Gordunni Orb";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Faranell's Parcel)
*
***************************************************************/

namespace Server.Items
{
	public class FaranellsParcel : Item
	{
		public FaranellsParcel() : base()
		{
			Id = 9436;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18359;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Faranell's Parcel";
			Name2 = "Faranell's Parcel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Untested Basilisk Sample)
*
***************************************************************/

namespace Server.Items
{
	public class UntestedBasiliskSample : Item
	{
		public UntestedBasiliskSample() : base()
		{
			Id = 9437;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3563;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Untested Basilisk Sample";
			Name2 = "Untested Basilisk Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 64;
			SetSpell( 11759 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Acceptable Scorpid Sample)
*
***************************************************************/

namespace Server.Items
{
	public class AcceptableScorpidSample : Item
	{
		public AcceptableScorpidSample() : base()
		{
			Id = 9438;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18712;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Acceptable Scorpid Sample";
			Name2 = "Acceptable Scorpid Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Untested Hyena Sample)
*
***************************************************************/

namespace Server.Items
{
	public class UntestedHyenaSample : Item
	{
		public UntestedHyenaSample() : base()
		{
			Id = 9439;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11164;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Untested Hyena Sample";
			Name2 = "Untested Hyena Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 64;
			SetSpell( 11760 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Acceptable Basilisk Sample)
*
***************************************************************/

namespace Server.Items
{
	public class AcceptableBasiliskSample : Item
	{
		public AcceptableBasiliskSample() : base()
		{
			Id = 9440;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3563;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Acceptable Basilisk Sample";
			Name2 = "Acceptable Basilisk Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Acceptable Hyena Sample)
*
***************************************************************/

namespace Server.Items
{
	public class AcceptableHyenaSample : Item
	{
		public AcceptableHyenaSample() : base()
		{
			Id = 9441;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11164;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Acceptable Hyena Sample";
			Name2 = "Acceptable Hyena Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Untested Scorpid Sample)
*
***************************************************************/

namespace Server.Items
{
	public class UntestedScorpidSample : Item
	{
		public UntestedScorpidSample() : base()
		{
			Id = 9442;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18712;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Untested Scorpid Sample";
			Name2 = "Untested Scorpid Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 64;
			SetSpell( 11761 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Grimtotem Horn)
*
***************************************************************/

namespace Server.Items
{
	public class GrimtotemHorn : Item
	{
		public GrimtotemHorn() : base()
		{
			Id = 9460;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13998;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Grimtotem Horn";
			Name2 = "Grimtotem Horn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crate of Grimtotem Horns)
*
***************************************************************/

namespace Server.Items
{
	public class CrateOfGrimtotemHorns : Item
	{
		public CrateOfGrimtotemHorns() : base()
		{
			Id = 9462;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9151;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crate of Grimtotem Horns";
			Name2 = "Crate of Grimtotem Horns";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gordunni Cobalt)
*
***************************************************************/

namespace Server.Items
{
	public class GordunniCobalt : Item
	{
		public GordunniCobalt() : base()
		{
			Id = 9463;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18021;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gordunni Cobalt";
			Name2 = "Gordunni Cobalt";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Orwin's Shovel)
*
***************************************************************/

namespace Server.Items
{
	public class OrwinsShovel : Item
	{
		public OrwinsShovel() : base()
		{
			Id = 9466;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18379;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Orwin's Shovel";
			Name2 = "Orwin's Shovel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
			Flags = 64;
			SetSpell( 11757 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Sharpbeak's Feather)
*
***************************************************************/

namespace Server.Items
{
	public class SharpbeaksFeather : Item
	{
		public SharpbeaksFeather() : base()
		{
			Id = 9468;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11205;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sharpbeak's Feather";
			Name2 = "Sharpbeak's Feather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Nekrum's Medallion)
*
***************************************************************/

namespace Server.Items
{
	public class NekrumsMedallion : Item
	{
		public NekrumsMedallion() : base()
		{
			Id = 9471;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7425;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nekrum's Medallion";
			Name2 = "Nekrum's Medallion";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Hexx's Key)
*
***************************************************************/

namespace Server.Items
{
	public class HexxsKey : Item
	{
		public HexxsKey() : base()
		{
			Id = 9472;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13025;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hexx's Key";
			Name2 = "Hexx's Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2112;
			SetSpell( 11792 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(A Carefully-packed Crate)
*
***************************************************************/

namespace Server.Items
{
	public class ACarefullyPackedCrate : Item
	{
		public ACarefullyPackedCrate() : base()
		{
			Id = 9507;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18426;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Carefully-packed Crate";
			Name2 = "A Carefully-packed Crate";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Troll Temper)
*
***************************************************************/

namespace Server.Items
{
	public class TrollTemper : Item
	{
		public TrollTemper() : base()
		{
			Id = 9523;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17898;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Troll Temper";
			Name2 = "Troll Temper";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 7;
		}
	}
}


/**************************************************************
*
*				(Edana's Dark Heart)
*
***************************************************************/

namespace Server.Items
{
	public class EdanasDarkHeart : Item
	{
		public EdanasDarkHeart() : base()
		{
			Id = 9528;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18473;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Edana's Dark Heart";
			Name2 = "Edana's Dark Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Horn of Hatetalon)
*
***************************************************************/

namespace Server.Items
{
	public class HornOfHatetalon : Item
	{
		public HornOfHatetalon() : base()
		{
			Id = 9530;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13122;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Horn of Hatetalon";
			Name2 = "Horn of Hatetalon";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2112;
			SetSpell( 11840 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Simple Letter)
*
***************************************************************/

namespace Server.Items
{
	public class SimpleLetter : Item
	{
		public SimpleLetter() : base()
		{
			Id = 9542;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Simple Letter";
			Name2 = "Simple Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2439;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Simple Rune)
*
***************************************************************/

namespace Server.Items
{
	public class SimpleRune : Item
	{
		public SimpleRune() : base()
		{
			Id = 9543;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22443;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Simple Rune";
			Name2 = "Simple Rune";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2442;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Simple Memorandum)
*
***************************************************************/

namespace Server.Items
{
	public class SimpleMemorandum : Item
	{
		public SimpleMemorandum() : base()
		{
			Id = 9544;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Simple Memorandum";
			Name2 = "Simple Memorandum";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2440;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Simple Sigil)
*
***************************************************************/

namespace Server.Items
{
	public class SimpleSigil : Item
	{
		public SimpleSigil() : base()
		{
			Id = 9545;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6015;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Simple Sigil";
			Name2 = "Simple Sigil";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2444;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Simple Note)
*
***************************************************************/

namespace Server.Items
{
	public class SimpleNote : Item
	{
		public SimpleNote() : base()
		{
			Id = 9547;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Simple Note";
			Name2 = "Simple Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2441;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Hallowed Letter)
*
***************************************************************/

namespace Server.Items
{
	public class HallowedLetter : Item
	{
		public HallowedLetter() : base()
		{
			Id = 9548;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hallowed Letter";
			Name2 = "Hallowed Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2465;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Encrypted Rune)
*
***************************************************************/

namespace Server.Items
{
	public class EncryptedRune : Item
	{
		public EncryptedRune() : base()
		{
			Id = 9550;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22443;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Encrypted Rune";
			Name2 = "Encrypted Rune";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2435;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Encrypted Sigil)
*
***************************************************************/

namespace Server.Items
{
	public class EncryptedSigil : Item
	{
		public EncryptedSigil() : base()
		{
			Id = 9551;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6015;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Encrypted Sigil";
			Name2 = "Encrypted Sigil";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2437;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Rune-Inscribed Note)
*
***************************************************************/

namespace Server.Items
{
	public class RuneInscribedNote : Item
	{
		public RuneInscribedNote() : base()
		{
			Id = 9552;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rune-Inscribed Note";
			Name2 = "Rune-Inscribed Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2460;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Etched Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class EtchedParchment : Item
	{
		public EtchedParchment() : base()
		{
			Id = 9553;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Etched Parchment";
			Name2 = "Etched Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2454;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Encrypted Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class EncryptedTablet : Item
	{
		public EncryptedTablet() : base()
		{
			Id = 9554;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18500;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Encrypted Tablet";
			Name2 = "Encrypted Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2438;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Encrypted Letter)
*
***************************************************************/

namespace Server.Items
{
	public class EncryptedLetter : Item
	{
		public EncryptedLetter() : base()
		{
			Id = 9555;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Encrypted Letter";
			Name2 = "Encrypted Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2432;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Hallowed Rune)
*
***************************************************************/

namespace Server.Items
{
	public class HallowedRune : Item
	{
		public HallowedRune() : base()
		{
			Id = 9556;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22443;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hallowed Rune";
			Name2 = "Hallowed Rune";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2466;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Hallowed Sigil)
*
***************************************************************/

namespace Server.Items
{
	public class HallowedSigil : Item
	{
		public HallowedSigil() : base()
		{
			Id = 9557;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6015;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hallowed Sigil";
			Name2 = "Hallowed Sigil";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2468;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Encrypted Memorandum)
*
***************************************************************/

namespace Server.Items
{
	public class EncryptedMemorandum : Item
	{
		public EncryptedMemorandum() : base()
		{
			Id = 9558;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Encrypted Memorandum";
			Name2 = "Encrypted Memorandum";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2433;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Encrypted Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class EncryptedScroll : Item
	{
		public EncryptedScroll() : base()
		{
			Id = 9559;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1301;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Encrypted Scroll";
			Name2 = "Encrypted Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2436;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Encrypted Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class EncryptedParchment : Item
	{
		public EncryptedParchment() : base()
		{
			Id = 9560;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Encrypted Parchment";
			Name2 = "Encrypted Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2434;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Hallowed Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class HallowedTablet : Item
	{
		public HallowedTablet() : base()
		{
			Id = 9561;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18500;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hallowed Tablet";
			Name2 = "Hallowed Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2469;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Rune-Inscribed Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class RuneInscribedTablet : Item
	{
		public RuneInscribedTablet() : base()
		{
			Id = 9562;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18500;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rune-Inscribed Tablet";
			Name2 = "Rune-Inscribed Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2462;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Consecrated Rune)
*
***************************************************************/

namespace Server.Items
{
	public class ConsecratedRune : Item
	{
		public ConsecratedRune() : base()
		{
			Id = 9563;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22443;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Consecrated Rune";
			Name2 = "Consecrated Rune";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2464;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Etched Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class EtchedTablet : Item
	{
		public EtchedTablet() : base()
		{
			Id = 9564;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18500;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Etched Tablet";
			Name2 = "Etched Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2457;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Etched Note)
*
***************************************************************/

namespace Server.Items
{
	public class EtchedNote : Item
	{
		public EtchedNote() : base()
		{
			Id = 9565;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Etched Note";
			Name2 = "Etched Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2453;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Etched Rune)
*
***************************************************************/

namespace Server.Items
{
	public class EtchedRune : Item
	{
		public EtchedRune() : base()
		{
			Id = 9566;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22443;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Etched Rune";
			Name2 = "Etched Rune";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2455;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Etched Sigil)
*
***************************************************************/

namespace Server.Items
{
	public class EtchedSigil : Item
	{
		public EtchedSigil() : base()
		{
			Id = 9567;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6015;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Etched Sigil";
			Name2 = "Etched Sigil";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2456;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Rune-Inscribed Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class RuneInscribedParchment : Item
	{
		public RuneInscribedParchment() : base()
		{
			Id = 9568;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Rune-Inscribed Parchment";
			Name2 = "Rune-Inscribed Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2461;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Consecrated Letter)
*
***************************************************************/

namespace Server.Items
{
	public class ConsecratedLetter : Item
	{
		public ConsecratedLetter() : base()
		{
			Id = 9570;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Consecrated Letter";
			Name2 = "Consecrated Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2463;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Glyphic Letter)
*
***************************************************************/

namespace Server.Items
{
	public class GlyphicLetter : Item
	{
		public GlyphicLetter() : base()
		{
			Id = 9571;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glyphic Letter";
			Name2 = "Glyphic Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2445;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Glyphic Rune)
*
***************************************************************/

namespace Server.Items
{
	public class GlyphicRune : Item
	{
		public GlyphicRune() : base()
		{
			Id = 9572;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3669;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glyphic Rune";
			Name2 = "Glyphic Rune";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 3111;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Glyphic Memorandum)
*
***************************************************************/

namespace Server.Items
{
	public class GlyphicMemorandum : Item
	{
		public GlyphicMemorandum() : base()
		{
			Id = 9573;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glyphic Memorandum";
			Name2 = "Glyphic Memorandum";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2446;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Glyphic Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class GlyphicScroll : Item
	{
		public GlyphicScroll() : base()
		{
			Id = 9574;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1301;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glyphic Scroll";
			Name2 = "Glyphic Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2447;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Glyphic Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class GlyphicTablet : Item
	{
		public GlyphicTablet() : base()
		{
			Id = 9575;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18500;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glyphic Tablet";
			Name2 = "Glyphic Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2448;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Tainted Letter)
*
***************************************************************/

namespace Server.Items
{
	public class TaintedLetter : Item
	{
		public TaintedLetter() : base()
		{
			Id = 9576;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tainted Letter";
			Name2 = "Tainted Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2449;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Tainted Memorandum)
*
***************************************************************/

namespace Server.Items
{
	public class TaintedMemorandum : Item
	{
		public TaintedMemorandum() : base()
		{
			Id = 9577;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tainted Memorandum";
			Name2 = "Tainted Memorandum";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2450;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Tainted Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class TaintedScroll : Item
	{
		public TaintedScroll() : base()
		{
			Id = 9578;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1301;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tainted Scroll";
			Name2 = "Tainted Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2452;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Tainted Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class TaintedParchment : Item
	{
		public TaintedParchment() : base()
		{
			Id = 9579;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tainted Parchment";
			Name2 = "Tainted Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2451;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Verdant Sigil)
*
***************************************************************/

namespace Server.Items
{
	public class VerdantSigil : Item
	{
		public VerdantSigil() : base()
		{
			Id = 9580;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6015;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Verdant Sigil";
			Name2 = "Verdant Sigil";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2459;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Verdant Note)
*
***************************************************************/

namespace Server.Items
{
	public class VerdantNote : Item
	{
		public VerdantNote() : base()
		{
			Id = 9581;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Verdant Note";
			Name2 = "Verdant Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2458;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Encrusted Minerals)
*
***************************************************************/

namespace Server.Items
{
	public class EncrustedMinerals : Item
	{
		public EncrustedMinerals() : base()
		{
			Id = 9589;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18514;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Encrusted Minerals";
			Name2 = "Encrusted Minerals";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Splintered Log)
*
***************************************************************/

namespace Server.Items
{
	public class SplinteredLog : Item
	{
		public SplinteredLog() : base()
		{
			Id = 9590;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 929;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Splintered Log";
			Name2 = "Splintered Log";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 2;
			Material = 1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Resilient Sinew)
*
***************************************************************/

namespace Server.Items
{
	public class ResilientSinew : Item
	{
		public ResilientSinew() : base()
		{
			Id = 9591;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18517;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Resilient Sinew";
			Name2 = "Resilient Sinew";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Metallic Fragments)
*
***************************************************************/

namespace Server.Items
{
	public class MetallicFragments : Item
	{
		public MetallicFragments() : base()
		{
			Id = 9592;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18519;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Metallic Fragments";
			Name2 = "Metallic Fragments";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 40;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Treant Muisek)
*
***************************************************************/

namespace Server.Items
{
	public class TreantMuisek : Item
	{
		public TreantMuisek() : base()
		{
			Id = 9593;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18524;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Treant Muisek";
			Name2 = "Treant Muisek";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Wildkin Muisek)
*
***************************************************************/

namespace Server.Items
{
	public class WildkinMuisek : Item
	{
		public WildkinMuisek() : base()
		{
			Id = 9594;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18094;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wildkin Muisek";
			Name2 = "Wildkin Muisek";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Hippogryph Muisek)
*
***************************************************************/

namespace Server.Items
{
	public class HippogryphMuisek : Item
	{
		public HippogryphMuisek() : base()
		{
			Id = 9595;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18525;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hippogryph Muisek";
			Name2 = "Hippogryph Muisek";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Faerie Dragon Muisek)
*
***************************************************************/

namespace Server.Items
{
	public class FaerieDragonMuisek : Item
	{
		public FaerieDragonMuisek() : base()
		{
			Id = 9596;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18526;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Faerie Dragon Muisek";
			Name2 = "Faerie Dragon Muisek";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Mountain Giant Muisek)
*
***************************************************************/

namespace Server.Items
{
	public class MountainGiantMuisek : Item
	{
		public MountainGiantMuisek() : base()
		{
			Id = 9597;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18527;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mountain Giant Muisek";
			Name2 = "Mountain Giant Muisek";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Treant Muisek Vessel)
*
***************************************************************/

namespace Server.Items
{
	public class TreantMuisekVessel : Item
	{
		public TreantMuisekVessel() : base()
		{
			Id = 9606;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18532;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Treant Muisek Vessel";
			Name2 = "Treant Muisek Vessel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
			Flags = 64;
			SetSpell( 11885 , 0 , 0 , 30000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Wildkin Muisek Vessel)
*
***************************************************************/

namespace Server.Items
{
	public class WildkinMuisekVessel : Item
	{
		public WildkinMuisekVessel() : base()
		{
			Id = 9618;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18532;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wildkin Muisek Vessel";
			Name2 = "Wildkin Muisek Vessel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
			Flags = 64;
			SetSpell( 11886 , 0 , 0 , 30000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Hippogryph Muisek Vessel)
*
***************************************************************/

namespace Server.Items
{
	public class HippogryphMuisekVessel : Item
	{
		public HippogryphMuisekVessel() : base()
		{
			Id = 9619;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18532;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hippogryph Muisek Vessel";
			Name2 = "Hippogryph Muisek Vessel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
			Flags = 64;
			SetSpell( 11887 , 0 , 0 , 30000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Faerie Dragon Muisek Vessel)
*
***************************************************************/

namespace Server.Items
{
	public class FaerieDragonMuisekVessel : Item
	{
		public FaerieDragonMuisekVessel() : base()
		{
			Id = 9620;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18532;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Faerie Dragon Muisek Vessel";
			Name2 = "Faerie Dragon Muisek Vessel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
			Flags = 64;
			SetSpell( 11888 , 0 , 0 , 30000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Mountain Giant Muisek Vessel)
*
***************************************************************/

namespace Server.Items
{
	public class MountainGiantMuisekVessel : Item
	{
		public MountainGiantMuisekVessel() : base()
		{
			Id = 9621;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18532;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mountain Giant Muisek Vessel";
			Name2 = "Mountain Giant Muisek Vessel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
			Flags = 64;
			SetSpell( 11889 , 0 , 0 , 30000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Neeru's Herb Pouch)
*
***************************************************************/

namespace Server.Items
{
	public class NeerusHerbPouch : Item
	{
		public NeerusHerbPouch() : base()
		{
			Id = 9628;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2593;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Neeru's Herb Pouch";
			Name2 = "Neeru's Herb Pouch";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(A Shrunken Head)
*
***************************************************************/

namespace Server.Items
{
	public class AShrunkenHead : Item
	{
		public AShrunkenHead() : base()
		{
			Id = 9629;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18568;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Shrunken Head";
			Name2 = "A Shrunken Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gem of Cobrahn)
*
***************************************************************/

namespace Server.Items
{
	public class GemOfCobrahn : Item
	{
		public GemOfCobrahn() : base()
		{
			Id = 9738;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1262;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gem of Cobrahn";
			Name2 = "Gem of Cobrahn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Gem of Anacondra)
*
***************************************************************/

namespace Server.Items
{
	public class GemOfAnacondra : Item
	{
		public GemOfAnacondra() : base()
		{
			Id = 9739;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1262;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gem of Anacondra";
			Name2 = "Gem of Anacondra";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Gem of Pythas)
*
***************************************************************/

namespace Server.Items
{
	public class GemOfPythas : Item
	{
		public GemOfPythas() : base()
		{
			Id = 9740;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1262;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gem of Pythas";
			Name2 = "Gem of Pythas";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Gem of Serpentis)
*
***************************************************************/

namespace Server.Items
{
	public class GemOfSerpentis : Item
	{
		public GemOfSerpentis() : base()
		{
			Id = 9741;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1262;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gem of Serpentis";
			Name2 = "Gem of Serpentis";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Gahz'ridian Detector)
*
***************************************************************/

namespace Server.Items
{
	public class GahzridianDetector : Item
	{
		public GahzridianDetector() : base()
		{
			Id = 9978;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21296;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gahz'ridian Detector";
			Name2 = "Gahz'ridian Detector";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.Head;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 11992 , 1 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Margol's Horn)
*
***************************************************************/

namespace Server.Items
{
	public class MargolsHorn : Item
	{
		public MargolsHorn() : base()
		{
			Id = 10000;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 6338;
			ObjectClass = 12;
			SubClass = 0;
			Level = 40;
			ReqLevel = 40;
			Name = "Margol's Horn";
			Name2 = "Margol's Horn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 3181;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Margol's Gigantic Horn)
*
***************************************************************/

namespace Server.Items
{
	public class MargolsGiganticHorn : Item
	{
		public MargolsGiganticHorn() : base()
		{
			Id = 10005;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6338;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Margol's Gigantic Horn";
			Name2 = "Margol's Gigantic Horn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Proof of Deed)
*
***************************************************************/

namespace Server.Items
{
	public class ProofOfDeed : Item
	{
		public ProofOfDeed() : base()
		{
			Id = 10022;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16065;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Proof of Deed";
			Name2 = "Proof of Deed";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 1231;
		}
	}
}


/**************************************************************
*
*				(Wolf Heart Samples)
*
***************************************************************/

namespace Server.Items
{
	public class WolfHeartSamples : Item
	{
		public WolfHeartSamples() : base()
		{
			Id = 10283;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7357;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wolf Heart Samples";
			Name2 = "Wolf Heart Samples";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Horn of Echeyakee)
*
***************************************************************/

namespace Server.Items
{
	public class HornOfEcheyakee : Item
	{
		public HornOfEcheyakee() : base()
		{
			Id = 10327;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13121;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Horn of Echeyakee";
			Name2 = "Horn of Echeyakee";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 12189 , 0 , -1 , 30000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Fresh Zhevra Carcass)
*
***************************************************************/

namespace Server.Items
{
	public class FreshZhevraCarcass : Item
	{
		public FreshZhevraCarcass() : base()
		{
			Id = 10338;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8942;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fresh Zhevra Carcass";
			Name2 = "Fresh Zhevra Carcass";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 12199 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Sample Snapjaw Shell)
*
***************************************************************/

namespace Server.Items
{
	public class SampleSnapjawShell : Item
	{
		public SampleSnapjawShell() : base()
		{
			Id = 10414;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17460;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sample Snapjaw Shell";
			Name2 = "Sample Snapjaw Shell";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Glimmering Mithril Insignia)
*
***************************************************************/

namespace Server.Items
{
	public class GlimmeringMithrilInsignia : Item
	{
		public GlimmeringMithrilInsignia() : base()
		{
			Id = 10418;
			Bonding = 1;
			SellPrice = 16464;
			AvailableClasses = 0x7FFF;
			Description = "Courage, Honor, and above all, Patience";
			Model = 19149;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Glimmering Mithril Insignia";
			Name2 = "Glimmering Mithril Insignia";
			Quality = 2;
			AvailableRaces = 0x1FF;
			SkillRank = 225;
			Skill = 164;
			BuyPrice = 65859;
			InventoryType = InventoryTypes.Trinket1;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 12733 , 0 , 0 , 600000 , 28 , 300000 );
		}
	}
}


/**************************************************************
*
*				(Skull of the Coldbringer)
*
***************************************************************/

namespace Server.Items
{
	public class SkullOfTheColdbringer : Item
	{
		public SkullOfTheColdbringer() : base()
		{
			Id = 10420;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2853;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Skull of the Coldbringer";
			Name2 = "Skull of the Coldbringer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Felix's Box)
*
***************************************************************/

namespace Server.Items
{
	public class FelixsBox : Item
	{
		public FelixsBox() : base()
		{
			Id = 10438;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12331;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Felix's Box";
			Name2 = "Felix's Box";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Durnan's Scalding Mornbrew)
*
***************************************************************/

namespace Server.Items
{
	public class DurnansScaldingMornbrew : Item
	{
		public DurnansScaldingMornbrew() : base()
		{
			Id = 10439;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19222;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Durnan's Scalding Mornbrew";
			Name2 = "Durnan's Scalding Mornbrew";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Nori's Mug)
*
***************************************************************/

namespace Server.Items
{
	public class NorisMug : Item
	{
		public NorisMug() : base()
		{
			Id = 10440;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19222;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nori's Mug";
			Name2 = "Nori's Mug";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Glowing Shard)
*
***************************************************************/

namespace Server.Items
{
	public class GlowingShard : Item
	{
		public GlowingShard() : base()
		{
			Id = 10441;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 19223;
			ObjectClass = 12;
			SubClass = 0;
			Level = 15;
			ReqLevel = 15;
			Name = "Glowing Shard";
			Name2 = "Glowing Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 6981;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Mysterious Artifact)
*
***************************************************************/

namespace Server.Items
{
	public class MysteriousArtifact : Item
	{
		public MysteriousArtifact() : base()
		{
			Id = 10442;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The Stone Emanates Evil";
			Model = 7148;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mysterious Artifact";
			Name2 = "Mysterious Artifact";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Singed Letter)
*
***************************************************************/

namespace Server.Items
{
	public class SingedLetter : Item
	{
		public SingedLetter() : base()
		{
			Id = 10443;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 48;
			ReqLevel = 40;
			Name = "Singed Letter";
			Name2 = "Singed Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Standard Issue Flare Gun)
*
***************************************************************/

namespace Server.Items
{
	public class StandardIssueFlareGun : Item
	{
		public StandardIssueFlareGun() : base()
		{
			Id = 10444;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19225;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Standard Issue Flare Gun";
			Name2 = "Standard Issue Flare Gun";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 12283 , 0 , 2 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Drawing Kit)
*
***************************************************************/

namespace Server.Items
{
	public class DrawingKit : Item
	{
		public DrawingKit() : base()
		{
			Id = 10445;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12925;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Drawing Kit";
			Name2 = "Drawing Kit";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 12304 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Heart of Obsidion)
*
***************************************************************/

namespace Server.Items
{
	public class HeartOfObsidion : Item
	{
		public HeartOfObsidion() : base()
		{
			Id = 10446;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The cold black heart is still pulsing";
			Model = 19239;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Heart of Obsidion";
			Name2 = "Heart of Obsidion";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Head of Lathoric the Black)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfLathoricTheBlack : Item
	{
		public HeadOfLathoricTheBlack() : base()
		{
			Id = 10447;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The remnants of a once honorable dwarf";
			Model = 3920;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Lathoric the Black";
			Name2 = "Head of Lathoric the Black";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Undamaged Hippogryph Feather)
*
***************************************************************/

namespace Server.Items
{
	public class UndamagedHippogryphFeather : Item
	{
		public UndamagedHippogryphFeather() : base()
		{
			Id = 10450;
			SellPrice = 396;
			AvailableClasses = 0x7FFF;
			Model = 19530;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Undamaged Hippogryph Feather";
			Name2 = "Undamaged Hippogryph Feather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1585;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Essence of Eranikus)
*
***************************************************************/

namespace Server.Items
{
	public class EssenceOfEranikus : Item
	{
		public EssenceOfEranikus() : base()
		{
			Id = 10454;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "Green mists swirl inside the lattices of this gem.";
			Model = 6513;
			ObjectClass = 12;
			SubClass = 0;
			Level = 48;
			ReqLevel = 48;
			Name = "Essence of Eranikus";
			Name2 = "Essence of Eranikus";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 3373;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Prayer to Elune)
*
***************************************************************/

namespace Server.Items
{
	public class PrayerToElune : Item
	{
		public PrayerToElune() : base()
		{
			Id = 10458;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Your heart feels light when you hold this item.";
			Model = 7697;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Prayer to Elune";
			Name2 = "Prayer to Elune";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Chief Sharptusk Thornmantle's Head)
*
***************************************************************/

namespace Server.Items
{
	public class ChiefSharptuskThornmantlesHead : Item
	{
		public ChiefSharptuskThornmantlesHead() : base()
		{
			Id = 10459;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10377;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Chief Sharptusk Thornmantle's Head";
			Name2 = "Chief Sharptusk Thornmantle's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Staff of Command)
*
***************************************************************/

namespace Server.Items
{
	public class StaffOfCommand : Item
	{
		public StaffOfCommand() : base()
		{
			Id = 10464;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19315;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Staff of Command";
			Name2 = "Staff of Command";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 12347 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Egg of Hakkar)
*
***************************************************************/

namespace Server.Items
{
	public class EggOfHakkar : Item
	{
		public EggOfHakkar() : base()
		{
			Id = 10465;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18050;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Egg of Hakkar";
			Name2 = "Egg of Hakkar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 7;
			Flags = 64;
			SetSpell( 12346 , 0 , 0 , 300000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Atal'ai Stone Circle)
*
***************************************************************/

namespace Server.Items
{
	public class AtalaiStoneCircle : Item
	{
		public AtalaiStoneCircle() : base()
		{
			Id = 10466;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19316;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Atal'ai Stone Circle";
			Name2 = "Atal'ai Stone Circle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
		}
	}
}


/**************************************************************
*
*				(Heart of Flame)
*
***************************************************************/

namespace Server.Items
{
	public class HeartOfFlame : Item
	{
		public HeartOfFlame() : base()
		{
			Id = 10509;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The flame burns eternally";
			Model = 7050;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Heart of Flame";
			Name2 = "Heart of Flame";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 4;
			MaxCount = 4;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Golem Oil)
*
***************************************************************/

namespace Server.Items
{
	public class GolemOil : Item
	{
		public GolemOil() : base()
		{
			Id = 10511;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The oil is encased in stone";
			Model = 19421;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Golem Oil";
			Name2 = "Golem Oil";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 4;
			MaxCount = 4;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tablet of Beth'Amara)
*
***************************************************************/

namespace Server.Items
{
	public class TabletOfBethAmara : Item
	{
		public TabletOfBethAmara() : base()
		{
			Id = 10538;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18203;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tablet of Beth'Amara";
			Name2 = "Tablet of Beth'Amara";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tablet of Jin'yael)
*
***************************************************************/

namespace Server.Items
{
	public class TabletOfJinyael : Item
	{
		public TabletOfJinyael() : base()
		{
			Id = 10539;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19830;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tablet of Jin'yael";
			Name2 = "Tablet of Jin'yael";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tablet of Markri)
*
***************************************************************/

namespace Server.Items
{
	public class TabletOfMarkri : Item
	{
		public TabletOfMarkri() : base()
		{
			Id = 10540;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19831;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tablet of Markri";
			Name2 = "Tablet of Markri";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tablet of Sael'hai)
*
***************************************************************/

namespace Server.Items
{
	public class TabletOfSaelhai : Item
	{
		public TabletOfSaelhai() : base()
		{
			Id = 10541;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19832;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tablet of Sael'hai";
			Name2 = "Tablet of Sael'hai";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Thorium Plated Dagger)
*
***************************************************************/

namespace Server.Items
{
	public class ThoriumPlatedDagger : Item
	{
		public ThoriumPlatedDagger() : base()
		{
			Id = 10551;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19459;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thorium Plated Dagger";
			Name2 = "Thorium Plated Dagger";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Symbol of Ragnaros)
*
***************************************************************/

namespace Server.Items
{
	public class SymbolOfRagnaros : Item
	{
		public SymbolOfRagnaros() : base()
		{
			Id = 10552;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The symbol emanates old magic";
			Model = 19462;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Symbol of Ragnaros";
			Name2 = "Symbol of Ragnaros";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Stone Circle)
*
***************************************************************/

namespace Server.Items
{
	public class StoneCircle : Item
	{
		public StoneCircle() : base()
		{
			Id = 10556;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19316;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Stone Circle";
			Name2 = "Stone Circle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
		}
	}
}


/**************************************************************
*
*				(Rubbing: Rune of Beth'Amara)
*
***************************************************************/

namespace Server.Items
{
	public class RubbingRuneOfBethAmara : Item
	{
		public RubbingRuneOfBethAmara() : base()
		{
			Id = 10563;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Rubbing: Rune of Beth'Amara";
			Name2 = "Rubbing: Rune of Beth'Amara";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Rubbing: Rune of Jin'yael)
*
***************************************************************/

namespace Server.Items
{
	public class RubbingRuneOfJinyael : Item
	{
		public RubbingRuneOfJinyael() : base()
		{
			Id = 10564;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Rubbing: Rune of Jin'yael";
			Name2 = "Rubbing: Rune of Jin'yael";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Rubbing: Rune of Markri)
*
***************************************************************/

namespace Server.Items
{
	public class RubbingRuneOfMarkri : Item
	{
		public RubbingRuneOfMarkri() : base()
		{
			Id = 10565;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Rubbing: Rune of Markri";
			Name2 = "Rubbing: Rune of Markri";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Rubbing: Rune of Sael'hai)
*
***************************************************************/

namespace Server.Items
{
	public class RubbingRuneOfSaelhai : Item
	{
		public RubbingRuneOfSaelhai() : base()
		{
			Id = 10566;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7629;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Rubbing: Rune of Sael'hai";
			Name2 = "Rubbing: Rune of Sael'hai";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Oathstone of Ysera's Dragonflight)
*
***************************************************************/

namespace Server.Items
{
	public class OathstoneOfYserasDragonflight : Item
	{
		public OathstoneOfYserasDragonflight() : base()
		{
			Id = 10589;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Using this stone binds someone to aid Ysera's Dragonflight.";
			Model = 20220;
			ObjectClass = 12;
			SubClass = 0;
			Level = 48;
			ReqLevel = 48;
			Name = "Oathstone of Ysera's Dragonflight";
			Name2 = "Oathstone of Ysera's Dragonflight";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 3374;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Pocked Black Box)
*
***************************************************************/

namespace Server.Items
{
	public class PockedBlackBox : Item
	{
		public PockedBlackBox() : base()
		{
			Id = 10590;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7074;
			ObjectClass = 12;
			SubClass = 0;
			Level = 30;
			ReqLevel = 30;
			Name = "Pocked Black Box";
			Name2 = "Pocked Black Box";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 3482;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Imperfect Draenethyst Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class ImperfectDraenethystFragment : Item
	{
		public ImperfectDraenethystFragment() : base()
		{
			Id = 10593;
			AvailableClasses = 0x7FFF;
			Model = 6673;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Imperfect Draenethyst Fragment";
			Name2 = "Imperfect Draenethyst Fragment";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Head of Magus Rimtori)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfMagusRimtori : Item
	{
		public HeadOfMagusRimtori() : base()
		{
			Id = 10597;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15706;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Head of Magus Rimtori";
			Name2 = "Head of Magus Rimtori";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Hetaera's Bloodied Head)
*
***************************************************************/

namespace Server.Items
{
	public class HetaerasBloodiedHead : Item
	{
		public HetaerasBloodiedHead() : base()
		{
			Id = 10598;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7135;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hetaera's Bloodied Head";
			Name2 = "Hetaera's Bloodied Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Hetaera's Beaten Head)
*
***************************************************************/

namespace Server.Items
{
	public class HetaerasBeatenHead : Item
	{
		public HetaerasBeatenHead() : base()
		{
			Id = 10599;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11932;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hetaera's Beaten Head";
			Name2 = "Hetaera's Beaten Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Hetaera's Bruised Head)
*
***************************************************************/

namespace Server.Items
{
	public class HetaerasBruisedHead : Item
	{
		public HetaerasBruisedHead() : base()
		{
			Id = 10600;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9150;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hetaera's Bruised Head";
			Name2 = "Hetaera's Bruised Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Hetaera's Blood)
*
***************************************************************/

namespace Server.Items
{
	public class HetaerasBlood : Item
	{
		public HetaerasBlood() : base()
		{
			Id = 10610;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Blood of the Sea Queen";
			Model = 19547;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hetaera's Blood";
			Name2 = "Hetaera's Blood";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Kadrak's Flag)
*
***************************************************************/

namespace Server.Items
{
	public class KadraksFlag : Item
	{
		public KadraksFlag() : base()
		{
			Id = 10622;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19562;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kadrak's Flag";
			Name2 = "Kadrak's Flag";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 12684 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Hyacinth Mushroom)
*
***************************************************************/

namespace Server.Items
{
	public class HyacinthMushroom : Item
	{
		public HyacinthMushroom() : base()
		{
			Id = 10639;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19566;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Hyacinth Mushroom";
			Name2 = "Hyacinth Mushroom";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Webwood Ichor)
*
***************************************************************/

namespace Server.Items
{
	public class WebwoodIchor : Item
	{
		public WebwoodIchor() : base()
		{
			Id = 10640;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2885;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Webwood Ichor";
			Name2 = "Webwood Ichor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Moonpetal Lily)
*
***************************************************************/

namespace Server.Items
{
	public class MoonpetalLily : Item
	{
		public MoonpetalLily() : base()
		{
			Id = 10641;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18168;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Moonpetal Lily";
			Name2 = "Moonpetal Lily";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Iverron's Antidote)
*
***************************************************************/

namespace Server.Items
{
	public class IverronsAntidote : Item
	{
		public IverronsAntidote() : base()
		{
			Id = 10642;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 17893;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Iverron's Antidote";
			Name2 = "Iverron's Antidote";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sealed Letter to Ag'tor)
*
***************************************************************/

namespace Server.Items
{
	public class SealedLetterToAgtor : Item
	{
		public SealedLetterToAgtor() : base()
		{
			Id = 10643;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3029;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sealed Letter to Ag'tor";
			Name2 = "Sealed Letter to Ag'tor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Nightmare Shard)
*
***************************************************************/

namespace Server.Items
{
	public class NightmareShard : Item
	{
		public NightmareShard() : base()
		{
			Id = 10649;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19223;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nightmare Shard";
			Name2 = "Nightmare Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(First Mosh'aru Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class FirstMosharuTablet : Item
	{
		public FirstMosharuTablet() : base()
		{
			Id = 10660;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22484;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "First Mosh'aru Tablet";
			Name2 = "First Mosh'aru Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Second Mosh'aru Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class SecondMosharuTablet : Item
	{
		public SecondMosharuTablet() : base()
		{
			Id = 10661;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20220;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Second Mosh'aru Tablet";
			Name2 = "Second Mosh'aru Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Filled Egg of Hakkar)
*
***************************************************************/

namespace Server.Items
{
	public class FilledEggOfHakkar : Item
	{
		public FilledEggOfHakkar() : base()
		{
			Id = 10662;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19527;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Filled Egg of Hakkar";
			Name2 = "Filled Egg of Hakkar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 7;
			Flags = 64;
		}
	}
}


/**************************************************************
*
*				(A Note to Magus Rimtori)
*
***************************************************************/

namespace Server.Items
{
	public class ANoteToMagusRimtori : Item
	{
		public ANoteToMagusRimtori() : base()
		{
			Id = 10664;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 45;
			ReqLevel = 45;
			Name = "A Note to Magus Rimtori";
			Name2 = "A Note to Magus Rimtori";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Magatha's Note)
*
***************************************************************/

namespace Server.Items
{
	public class MagathasNote : Item
	{
		public MagathasNote() : base()
		{
			Id = 10678;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3024;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Magatha's Note";
			Name2 = "Magatha's Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Andron's Note)
*
***************************************************************/

namespace Server.Items
{
	public class AndronsNote : Item
	{
		public AndronsNote() : base()
		{
			Id = 10679;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3024;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Andron's Note";
			Name2 = "Andron's Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Jes'rimon's Note)
*
***************************************************************/

namespace Server.Items
{
	public class JesrimonsNote : Item
	{
		public JesrimonsNote() : base()
		{
			Id = 10680;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3024;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Jes'rimon's Note";
			Name2 = "Jes'rimon's Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Xylem's Note)
*
***************************************************************/

namespace Server.Items
{
	public class XylemsNote : Item
	{
		public XylemsNote() : base()
		{
			Id = 10681;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3024;
			ObjectClass = 12;
			SubClass = 0;
			ReqLevel = 1;
			Name = "Xylem's Note";
			Name2 = "Xylem's Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Belnistrasz's Oathstone)
*
***************************************************************/

namespace Server.Items
{
	public class BelnistraszsOathstone : Item
	{
		public BelnistraszsOathstone() : base()
		{
			Id = 10682;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20219;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Belnistrasz's Oathstone";
			Name2 = "Belnistrasz's Oathstone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Filled Vial Labeled #1)
*
***************************************************************/

namespace Server.Items
{
	public class FilledVialLabeled1 : Item
	{
		public FilledVialLabeled1() : base()
		{
			Id = 10691;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15736;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Vial Labeled #1";
			Name2 = "Filled Vial Labeled #1";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Filled Vial Labeled #2)
*
***************************************************************/

namespace Server.Items
{
	public class FilledVialLabeled2 : Item
	{
		public FilledVialLabeled2() : base()
		{
			Id = 10692;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15737;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Vial Labeled #2";
			Name2 = "Filled Vial Labeled #2";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Filled Vial Labeled #3)
*
***************************************************************/

namespace Server.Items
{
	public class FilledVialLabeled3 : Item
	{
		public FilledVialLabeled3() : base()
		{
			Id = 10693;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15733;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Vial Labeled #3";
			Name2 = "Filled Vial Labeled #3";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Filled Vial Labeled #4)
*
***************************************************************/

namespace Server.Items
{
	public class FilledVialLabeled4 : Item
	{
		public FilledVialLabeled4() : base()
		{
			Id = 10694;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15734;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Vial Labeled #4";
			Name2 = "Filled Vial Labeled #4";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Yeh'kinya's Bramble)
*
***************************************************************/

namespace Server.Items
{
	public class YehkinyasBramble : Item
	{
		public YehkinyasBramble() : base()
		{
			Id = 10699;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12866;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Yeh'kinya's Bramble";
			Name2 = "Yeh'kinya's Bramble";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 12699 , 0 , 0 , 5000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Cuely's Elixir)
*
***************************************************************/

namespace Server.Items
{
	public class CuelysElixir : Item
	{
		public CuelysElixir() : base()
		{
			Id = 10712;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2533;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cuely's Elixir";
			Name2 = "Cuely's Elixir";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crystallized Azsharite)
*
***************************************************************/

namespace Server.Items
{
	public class CrystallizedAzsharite : Item
	{
		public CrystallizedAzsharite() : base()
		{
			Id = 10714;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Hot out of the oven.";
			Model = 13496;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crystallized Azsharite";
			Name2 = "Crystallized Azsharite";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Kim'Jael's Scope)
*
***************************************************************/

namespace Server.Items
{
	public class KimJaelsScope : Item
	{
		public KimJaelsScope() : base()
		{
			Id = 10715;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18155;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kim'Jael's Scope";
			Name2 = "Kim'Jael's Scope";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Kim'Jael's Compass)
*
***************************************************************/

namespace Server.Items
{
	public class KimJaelsCompass : Item
	{
		public KimJaelsCompass() : base()
		{
			Id = 10717;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19658;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kim'Jael's Compass";
			Name2 = "Kim'Jael's Compass";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Kim'Jael's Wizzlegoober)
*
***************************************************************/

namespace Server.Items
{
	public class KimJaelsWizzlegoober : Item
	{
		public KimJaelsWizzlegoober() : base()
		{
			Id = 10718;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7842;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kim'Jael's Wizzlegoober";
			Name2 = "Kim'Jael's Wizzlegoober";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Kim'Jael's Stuffed Chicken)
*
***************************************************************/

namespace Server.Items
{
	public class KimJaelsStuffedChicken : Item
	{
		public KimJaelsStuffedChicken() : base()
		{
			Id = 10722;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19663;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Kim'Jael's Stuffed Chicken";
			Name2 = "Kim'Jael's Stuffed Chicken";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Shipment to Galvan)
*
***************************************************************/

namespace Server.Items
{
	public class ShipmentToGalvan : Item
	{
		public ShipmentToGalvan() : base()
		{
			Id = 10738;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The massive box is surprisingly light.";
			Model = 11448;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shipment to Galvan";
			Name2 = "Shipment to Galvan";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Amulet of Grol)
*
***************************************************************/

namespace Server.Items
{
	public class AmuletOfGrol : Item
	{
		public AmuletOfGrol() : base()
		{
			Id = 10753;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Once worn by Grol the Destroyer.";
			Model = 19762;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Amulet of Grol";
			Name2 = "Amulet of Grol";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Amulet of Sevine)
*
***************************************************************/

namespace Server.Items
{
	public class AmuletOfSevine : Item
	{
		public AmuletOfSevine() : base()
		{
			Id = 10754;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The putrid scent of Sevine still radiates from this amulet.";
			Model = 19763;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Amulet of Sevine";
			Name2 = "Amulet of Sevine";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Amulet of Allistarj)
*
***************************************************************/

namespace Server.Items
{
	public class AmuletOfAllistarj : Item
	{
		public AmuletOfAllistarj() : base()
		{
			Id = 10755;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The only thing that remains from a once powerful sorcerer.";
			Model = 19764;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Amulet of Allistarj";
			Name2 = "Amulet of Allistarj";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Severed Horn of the Defiler)
*
***************************************************************/

namespace Server.Items
{
	public class SeveredHornOfTheDefiler : Item
	{
		public SeveredHornOfTheDefiler() : base()
		{
			Id = 10759;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "A severed and bloody horn of Razelikh the Defiler.";
			Model = 13122;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Severed Horn of the Defiler";
			Name2 = "Severed Horn of the Defiler";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Manual of Engineering Disciplines)
*
***************************************************************/

namespace Server.Items
{
	public class ManualOfEngineeringDisciplines : Item
	{
		public ManualOfEngineeringDisciplines() : base()
		{
			Id = 10789;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1134;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Manual of Engineering Disciplines";
			Name2 = "Manual of Engineering Disciplines";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 1271;
			PageMaterial = 5;
		}
	}
}


/**************************************************************
*
*				(Gnome Engineer Membership Card)
*
***************************************************************/

namespace Server.Items
{
	public class GnomeEngineerMembershipCard : Item
	{
		public GnomeEngineerMembershipCard() : base()
		{
			Id = 10790;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "A member in good standing of the Mechanical Engineering Guild, Associated.";
			Model = 3032;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Gnome Engineer Membership Card";
			Name2 = "Gnome Engineer Membership Card";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Goblin Engineer Membership Card)
*
***************************************************************/

namespace Server.Items
{
	public class GoblinEngineerMembershipCard : Item
	{
		public GoblinEngineerMembershipCard() : base()
		{
			Id = 10791;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "A member in good standing of the Goblin Experimental Engineering Korporation.";
			Model = 5567;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Goblin Engineer Membership Card";
			Name2 = "Goblin Engineer Membership Card";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Nixx's Pledge of Secrecy)
*
***************************************************************/

namespace Server.Items
{
	public class NixxsPledgeOfSecrecy : Item
	{
		public NixxsPledgeOfSecrecy() : base()
		{
			Id = 10792;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7744;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nixx's Pledge of Secrecy";
			Name2 = "Nixx's Pledge of Secrecy";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 14209 , 0 , -1 , 1000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Overspark's Pledge of Secrecy)
*
***************************************************************/

namespace Server.Items
{
	public class OversparksPledgeOfSecrecy : Item
	{
		public OversparksPledgeOfSecrecy() : base()
		{
			Id = 10793;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7744;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Overspark's Pledge of Secrecy";
			Name2 = "Overspark's Pledge of Secrecy";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 14227 , 0 , -1 , 1000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Oglethorpe's Pledge of Secrecy)
*
***************************************************************/

namespace Server.Items
{
	public class OglethorpesPledgeOfSecrecy : Item
	{
		public OglethorpesPledgeOfSecrecy() : base()
		{
			Id = 10794;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7744;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Oglethorpe's Pledge of Secrecy";
			Name2 = "Oglethorpe's Pledge of Secrecy";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 14210 , 0 , -1 , 1000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Yeh'kinya's Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class YehkinyasScroll : Item
	{
		public YehkinyasScroll() : base()
		{
			Id = 10818;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 3331;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Yeh'kinya's Scroll";
			Name2 = "Yeh'kinya's Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 7;
			Flags = 64;
			SetSpell( 12346 , 0 , 0 , 300000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Wildkin Feather)
*
***************************************************************/

namespace Server.Items
{
	public class WildkinFeather : Item
	{
		public WildkinFeather() : base()
		{
			Id = 10819;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19529;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wildkin Feather";
			Name2 = "Wildkin Feather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fel Orb)
*
***************************************************************/

namespace Server.Items
{
	public class FelOrb : Item
	{
		public FelOrb() : base()
		{
			Id = 10831;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "Use to conjure a Felhound Tracker.";
			Model = 6506;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fel Orb";
			Name2 = "Fel Orb";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 12851 , 0 , -5 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Fel Tracker Owner's Manual)
*
***************************************************************/

namespace Server.Items
{
	public class FelTrackerOwnersManual : Item
	{
		public FelTrackerOwnersManual() : base()
		{
			Id = 10832;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "Information on how to control your new Felhound Tracker.";
			Model = 1246;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fel Tracker Owner's Manual";
			Name2 = "Fel Tracker Owner's Manual";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			PageText = 1291;
		}
	}
}


/**************************************************************
*
*				(Hilary's Necklace)
*
***************************************************************/

namespace Server.Items
{
	public class HilarysNecklace : Item
	{
		public HilarysNecklace() : base()
		{
			Id = 10958;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15658;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hilary's Necklace";
			Name2 = "Hilary's Necklace";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ironfel)
*
***************************************************************/

namespace Server.Items
{
	public class Ironfel : Item
	{
		public Ironfel() : base()
		{
			Id = 10999;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Etched into the face of the hammer are the letters: F.F.F.";
			Model = 20433;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ironfel";
			Name2 = "Ironfel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Evergreen Pouch)
*
***************************************************************/

namespace Server.Items
{
	public class EvergreenPouch : Item
	{
		public EvergreenPouch() : base()
		{
			Id = 11020;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 20503;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Evergreen Pouch";
			Name2 = "Evergreen Pouch";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 10000;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 1088;
			SetSpell( 13399 , 0 , 0 , 600000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Packet of Tharlendris Seeds)
*
***************************************************************/

namespace Server.Items
{
	public class PacketOfTharlendrisSeeds : Item
	{
		public PacketOfTharlendrisSeeds() : base()
		{
			Id = 11022;
			SellPrice = 250;
			AvailableClasses = 0x7FFF;
			Model = 20505;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Packet of Tharlendris Seeds";
			Name2 = "Packet of Tharlendris Seeds";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Evergreen Herb Casing)
*
***************************************************************/

namespace Server.Items
{
	public class EvergreenHerbCasing : Item
	{
		public EvergreenHerbCasing() : base()
		{
			Id = 11024;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "Using Un'Goro soil, Tharlendris seeds have been cultivated inside.";
			Model = 23217;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Evergreen Herb Casing";
			Name2 = "Evergreen Herb Casing";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 4;
		}
	}
}


/**************************************************************
*
*				(Sha'ni's Nose-Ring)
*
***************************************************************/

namespace Server.Items
{
	public class ShanisNoseRing : Item
	{
		public ShanisNoseRing() : base()
		{
			Id = 11058;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20558;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sha'ni's Nose-Ring";
			Name2 = "Sha'ni's Nose-Ring";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Gor'tesh's Lopped Off Head)
*
***************************************************************/

namespace Server.Items
{
	public class GorteshsLoppedOffHead11080 : Item
	{
		public GorteshsLoppedOffHead11080() : base()
		{
			Id = 11080;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Squishy, Smelly, Slimy";
			Model = 20597;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gor'tesh's Lopped Off Head";
			Name2 = "Gor'tesh's Lopped Off Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Unhatched Sprite Darter Egg)
*
***************************************************************/

namespace Server.Items
{
	public class UnhatchedSpriteDarterEgg : Item
	{
		public UnhatchedSpriteDarterEgg() : base()
		{
			Id = 11102;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 20692;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Unhatched Sprite Darter Egg";
			Name2 = "Unhatched Sprite Darter Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Seed Voucher)
*
***************************************************************/

namespace Server.Items
{
	public class SeedVoucher : Item
	{
		public SeedVoucher() : base()
		{
			Id = 11103;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Good for twenty packs of Tharlendris seeds.";
			Model = 3093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Seed Voucher";
			Name2 = "Seed Voucher";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Large Compass)
*
***************************************************************/

namespace Server.Items
{
	public class LargeCompass : Item
	{
		public LargeCompass() : base()
		{
			Id = 11104;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "It always points towards the center of Ungoro Crater...";
			Model = 6562;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Large Compass";
			Name2 = "Large Compass";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Curled Map Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class CurledMapParchment : Item
	{
		public CurledMapParchment() : base()
		{
			Id = 11105;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20710;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Curled Map Parchment";
			Name2 = "Curled Map Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 1;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Lion-headed Key)
*
***************************************************************/

namespace Server.Items
{
	public class LionHeadedKey : Item
	{
		public LionHeadedKey() : base()
		{
			Id = 11106;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20711;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lion-headed Key";
			Name2 = "Lion-headed Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(A Small Pack)
*
***************************************************************/

namespace Server.Items
{
	public class ASmallPack : Item
	{
		public ASmallPack() : base()
		{
			Id = 11107;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20709;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "A Small Pack";
			Name2 = "A Small Pack";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 4;
		}
	}
}


/**************************************************************
*
*				(Faded Photograph)
*
***************************************************************/

namespace Server.Items
{
	public class FadedPhotograph : Item
	{
		public FadedPhotograph() : base()
		{
			Id = 11108;
			AvailableClasses = 0x7FFF;
			Model = 4110;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Faded Photograph";
			Name2 = "Faded Photograph";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 1371;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Research Equipment)
*
***************************************************************/

namespace Server.Items
{
	public class ResearchEquipment : Item
	{
		public ResearchEquipment() : base()
		{
			Id = 11112;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Property of Marshal Expeditions.";
			Model = 20733;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Research Equipment";
			Name2 = "Research Equipment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crate of Foodstuffs)
*
***************************************************************/

namespace Server.Items
{
	public class CrateOfFoodstuffs : Item
	{
		public CrateOfFoodstuffs() : base()
		{
			Id = 11113;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Property of Marshal Expeditions.";
			Model = 11448;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Crate of Foodstuffs";
			Name2 = "Crate of Foodstuffs";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dinosaur Bone)
*
***************************************************************/

namespace Server.Items
{
	public class DinosaurBone : Item
	{
		public DinosaurBone() : base()
		{
			Id = 11114;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6668;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dinosaur Bone";
			Name2 = "Dinosaur Bone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Milly's Harvest)
*
***************************************************************/

namespace Server.Items
{
	public class MillysHarvest : Item
	{
		public MillysHarvest() : base()
		{
			Id = 11119;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21973;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Milly's Harvest";
			Name2 = "Milly's Harvest";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Grape Manifest)
*
***************************************************************/

namespace Server.Items
{
	public class GrapeManifest : Item
	{
		public GrapeManifest() : base()
		{
			Id = 11125;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2247;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Grape Manifest";
			Name2 = "Grape Manifest";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 1392;
			Language = 7;
		}
	}
}


/**************************************************************
*
*				(Tablet of Kurniya)
*
***************************************************************/

namespace Server.Items
{
	public class TabletOfKurniya : Item
	{
		public TabletOfKurniya() : base()
		{
			Id = 11126;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Runes filled with liquid fire dance across the tablet.";
			Model = 20774;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tablet of Kurniya";
			Name2 = "Tablet of Kurniya";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Scavenged Goods)
*
***************************************************************/

namespace Server.Items
{
	public class ScavengedGoods : Item
	{
		public ScavengedGoods() : base()
		{
			Id = 11127;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20775;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Scavenged Goods";
			Name2 = "Scavenged Goods";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Essence of the Elements)
*
***************************************************************/

namespace Server.Items
{
	public class EssenceOfTheElements : Item
	{
		public EssenceOfTheElements() : base()
		{
			Id = 11129;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20784;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Essence of the Elements";
			Name2 = "Essence of the Elements";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Hive Wall Sample)
*
***************************************************************/

namespace Server.Items
{
	public class HiveWallSample : Item
	{
		public HiveWallSample() : base()
		{
			Id = 11131;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20789;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hive Wall Sample";
			Name2 = "Hive Wall Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Unused Scraping Vial)
*
***************************************************************/

namespace Server.Items
{
	public class UnusedScrapingVial : Item
	{
		public UnusedScrapingVial() : base()
		{
			Id = 11132;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20791;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Unused Scraping Vial";
			Name2 = "Unused Scraping Vial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 13630 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Linken's Training Sword)
*
***************************************************************/

namespace Server.Items
{
	public class LinkensTrainingSword : Item
	{
		public LinkensTrainingSword() : base()
		{
			Id = 11133;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20797;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Linken's Training Sword";
			Name2 = "Linken's Training Sword";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Linken's Tempered Sword)
*
***************************************************************/

namespace Server.Items
{
	public class LinkensTemperedSword : Item
	{
		public LinkensTemperedSword() : base()
		{
			Id = 11136;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20796;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Linken's Tempered Sword";
			Name2 = "Linken's Tempered Sword";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bait)
*
***************************************************************/

namespace Server.Items
{
	public class Bait : Item
	{
		public Bait() : base()
		{
			Id = 11141;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20803;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bait";
			Name2 = "Bait";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 2000;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 14008 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Broken Samophlange)
*
***************************************************************/

namespace Server.Items
{
	public class BrokenSamophlange : Item
	{
		public BrokenSamophlange() : base()
		{
			Id = 11142;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9167;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Broken Samophlange";
			Name2 = "Broken Samophlange";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Nugget Slug)
*
***************************************************************/

namespace Server.Items
{
	public class NuggetSlug : Item
	{
		public NuggetSlug() : base()
		{
			Id = 11143;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20818;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nugget Slug";
			Name2 = "Nugget Slug";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Broken and Battered Samophlange)
*
***************************************************************/

namespace Server.Items
{
	public class BrokenAndBatteredSamophlange : Item
	{
		public BrokenAndBatteredSamophlange() : base()
		{
			Id = 11146;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9167;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Broken and Battered Samophlange";
			Name2 = "Broken and Battered Samophlange";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Samophlange Manual Cover)
*
***************************************************************/

namespace Server.Items
{
	public class SamophlangeManualCover : Item
	{
		public SamophlangeManualCover() : base()
		{
			Id = 11147;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3426;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Samophlange Manual Cover";
			Name2 = "Samophlange Manual Cover";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 3136;
			SetSpell( 13714 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Samophlange Manual)
*
***************************************************************/

namespace Server.Items
{
	public class SamophlangeManual : Item
	{
		public SamophlangeManual() : base()
		{
			Id = 11149;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6672;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Samophlange Manual";
			Name2 = "Samophlange Manual";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 1088;
		}
	}
}


/**************************************************************
*
*				(Linken's Superior Sword)
*
***************************************************************/

namespace Server.Items
{
	public class LinkensSuperiorSword : Item
	{
		public LinkensSuperiorSword() : base()
		{
			Id = 11162;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20872;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Linken's Superior Sword";
			Name2 = "Linken's Superior Sword";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Book of Aquor)
*
***************************************************************/

namespace Server.Items
{
	public class BookOfAquor : Item
	{
		public BookOfAquor() : base()
		{
			Id = 11169;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21032;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Book of Aquor";
			Name2 = "Book of Aquor";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 13978 , 0 , 0 , 300000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Silvery Claws)
*
***************************************************************/

namespace Server.Items
{
	public class SilveryClaws : Item
	{
		public SilveryClaws() : base()
		{
			Id = 11172;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20893;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Silvery Claws";
			Name2 = "Silvery Claws";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Irontree Heart)
*
***************************************************************/

namespace Server.Items
{
	public class IrontreeHeart : Item
	{
		public IrontreeHeart() : base()
		{
			Id = 11173;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20894;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Irontree Heart";
			Name2 = "Irontree Heart";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Golden Flame)
*
***************************************************************/

namespace Server.Items
{
	public class GoldenFlame : Item
	{
		public GoldenFlame() : base()
		{
			Id = 11179;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20912;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Golden Flame";
			Name2 = "Golden Flame";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Blue Power Crystal)
*
***************************************************************/

namespace Server.Items
{
	public class BluePowerCrystal : Item
	{
		public BluePowerCrystal() : base()
		{
			Id = 11184;
			AvailableClasses = 0x7FFF;
			Model = 6614;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blue Power Crystal";
			Name2 = "Blue Power Crystal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Green Power Crystal)
*
***************************************************************/

namespace Server.Items
{
	public class GreenPowerCrystal : Item
	{
		public GreenPowerCrystal() : base()
		{
			Id = 11185;
			AvailableClasses = 0x7FFF;
			Model = 7393;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Green Power Crystal";
			Name2 = "Green Power Crystal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Red Power Crystal)
*
***************************************************************/

namespace Server.Items
{
	public class RedPowerCrystal : Item
	{
		public RedPowerCrystal() : base()
		{
			Id = 11186;
			AvailableClasses = 0x7FFF;
			Model = 20977;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Red Power Crystal";
			Name2 = "Red Power Crystal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Yellow Power Crystal)
*
***************************************************************/

namespace Server.Items
{
	public class YellowPowerCrystal : Item
	{
		public YellowPowerCrystal() : base()
		{
			Id = 11188;
			AvailableClasses = 0x7FFF;
			Model = 20978;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Yellow Power Crystal";
			Name2 = "Yellow Power Crystal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Head of Krom'zar)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfKromzar : Item
	{
		public HeadOfKromzar() : base()
		{
			Id = 11222;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9666;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Krom'zar";
			Name2 = "Head of Krom'zar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Piece of Krom'zar's Banner)
*
***************************************************************/

namespace Server.Items
{
	public class PieceOfKromzarsBanner : Item
	{
		public PieceOfKromzarsBanner() : base()
		{
			Id = 11227;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6748;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Piece of Krom'zar's Banner";
			Name2 = "Piece of Krom'zar's Banner";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Encased Fiery Essence)
*
***************************************************************/

namespace Server.Items
{
	public class EncasedFieryEssence : Item
	{
		public EncasedFieryEssence() : base()
		{
			Id = 11230;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The fiery essence of Bael'Gar wrapped tightly inside black dragonflight molt.";
			Model = 20995;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Encased Fiery Essence";
			Name2 = "Encased Fiery Essence";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Altered Black Dragonflight Molt)
*
***************************************************************/

namespace Server.Items
{
	public class AlteredBlackDragonflightMolt : Item
	{
		public AlteredBlackDragonflightMolt() : base()
		{
			Id = 11231;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "A dull and gray patch of black dragon skin";
			Model = 19502;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Altered Black Dragonflight Molt";
			Name2 = "Altered Black Dragonflight Molt";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			MaxCount = 1;
			Material = 8;
			Flags = 64;
			SetSpell( 13982 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Evoroot)
*
***************************************************************/

namespace Server.Items
{
	public class Evoroot : Item
	{
		public Evoroot() : base()
		{
			Id = 11242;
			AvailableClasses = 0x7FFF;
			Model = 18169;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Evoroot";
			Name2 = "Evoroot";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Videre Elixir)
*
***************************************************************/

namespace Server.Items
{
	public class VidereElixir : Item
	{
		public VidereElixir() : base()
		{
			Id = 11243;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15788;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Videre Elixir";
			Name2 = "Videre Elixir";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 64;
			SetSpell( 14050 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Fractured Elemental Shard)
*
***************************************************************/

namespace Server.Items
{
	public class FracturedElementalShard : Item
	{
		public FracturedElementalShard() : base()
		{
			Id = 11266;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21072;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fractured Elemental Shard";
			Name2 = "Fractured Elemental Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Elemental Shard Sample)
*
***************************************************************/

namespace Server.Items
{
	public class ElementalShardSample : Item
	{
		public ElementalShardSample() : base()
		{
			Id = 11267;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21072;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Elemental Shard Sample";
			Name2 = "Elemental Shard Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Head of Argelmach)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfArgelmach : Item
	{
		public HeadOfArgelmach() : base()
		{
			Id = 11268;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The dark, pale skin feels like clay.";
			Model = 3920;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Argelmach";
			Name2 = "Head of Argelmach";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Intact Elemental Core)
*
***************************************************************/

namespace Server.Items
{
	public class IntactElementalCore : Item
	{
		public IntactElementalCore() : base()
		{
			Id = 11269;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8560;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Intact Elemental Core";
			Name2 = "Intact Elemental Core";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Nixx's Signed Pledge)
*
***************************************************************/

namespace Server.Items
{
	public class NixxsSignedPledge : Item
	{
		public NixxsSignedPledge() : base()
		{
			Id = 11270;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7744;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Nixx's Signed Pledge";
			Name2 = "Nixx's Signed Pledge";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Oglethorpe's Signed Pledge)
*
***************************************************************/

namespace Server.Items
{
	public class OglethorpesSignedPledge : Item
	{
		public OglethorpesSignedPledge() : base()
		{
			Id = 11282;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7744;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Oglethorpe's Signed Pledge";
			Name2 = "Oglethorpe's Signed Pledge";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Overspark's Signed Pledge)
*
***************************************************************/

namespace Server.Items
{
	public class OversparksSignedPledge : Item
	{
		public OversparksSignedPledge() : base()
		{
			Id = 11283;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7744;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Overspark's Signed Pledge";
			Name2 = "Overspark's Signed Pledge";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Thorium Shackles)
*
***************************************************************/

namespace Server.Items
{
	public class ThoriumShackles : Item
	{
		public ThoriumShackles() : base()
		{
			Id = 11286;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Unbreakable bindings.";
			Model = 21092;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thorium Shackles";
			Name2 = "Thorium Shackles";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 14250 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(The Heart of the Mountain)
*
***************************************************************/

namespace Server.Items
{
	public class TheHeartOfTheMountain : Item
	{
		public TheHeartOfTheMountain() : base()
		{
			Id = 11309;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7050;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "The Heart of the Mountain";
			Name2 = "The Heart of the Mountain";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Lost Thunderbrew Recipe)
*
***************************************************************/

namespace Server.Items
{
	public class LostThunderbrewRecipe : Item
	{
		public LostThunderbrewRecipe() : base()
		{
			Id = 11312;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8927;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lost Thunderbrew Recipe";
			Name2 = "Lost Thunderbrew Recipe";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ribbly's Head)
*
***************************************************************/

namespace Server.Items
{
	public class RibblysHead : Item
	{
		public RibblysHead() : base()
		{
			Id = 11313;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1310;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ribbly's Head";
			Name2 = "Ribbly's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bloodpetal Sprout)
*
***************************************************************/

namespace Server.Items
{
	public class BloodpetalSprout : Item
	{
		public BloodpetalSprout() : base()
		{
			Id = 11315;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 21149;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodpetal Sprout";
			Name2 = "Bloodpetal Sprout";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bloodpetal)
*
***************************************************************/

namespace Server.Items
{
	public class Bloodpetal : Item
	{
		public Bloodpetal() : base()
		{
			Id = 11316;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 13489;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodpetal";
			Name2 = "Bloodpetal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Atal'ai Haze)
*
***************************************************************/

namespace Server.Items
{
	public class AtalaiHaze : Item
	{
		public AtalaiHaze() : base()
		{
			Id = 11318;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21164;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Atal'ai Haze";
			Name2 = "Atal'ai Haze";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Unloaded Zapper)
*
***************************************************************/

namespace Server.Items
{
	public class UnloadedZapper : Item
	{
		public UnloadedZapper() : base()
		{
			Id = 11319;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21175;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Unloaded Zapper";
			Name2 = "Unloaded Zapper";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bloodpetal Zapper)
*
***************************************************************/

namespace Server.Items
{
	public class BloodpetalZapper : Item
	{
		public BloodpetalZapper() : base()
		{
			Id = 11320;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21189;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bloodpetal Zapper";
			Name2 = "Bloodpetal Zapper";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 14806 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Helendis Riverhorn's Letter)
*
***************************************************************/

namespace Server.Items
{
	public class HelendisRiverhornsLetter : Item
	{
		public HelendisRiverhornsLetter() : base()
		{
			Id = 11366;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Sealed";
			Model = 7649;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Helendis Riverhorn's Letter";
			Name2 = "Helendis Riverhorn's Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Solomon's Plea to Bolvar)
*
***************************************************************/

namespace Server.Items
{
	public class SolomonsPleaToBolvar : Item
	{
		public SolomonsPleaToBolvar() : base()
		{
			Id = 11367;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7726;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Solomon's Plea to Bolvar";
			Name2 = "Solomon's Plea to Bolvar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bolvar's Decree)
*
***************************************************************/

namespace Server.Items
{
	public class BolvarsDecree : Item
	{
		public BolvarsDecree() : base()
		{
			Id = 11368;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Bears the Seal of Stormwind";
			Model = 16065;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bolvar's Decree";
			Name2 = "Bolvar's Decree";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 1471;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Nagmara's Vial)
*
***************************************************************/

namespace Server.Items
{
	public class NagmarasVial : Item
	{
		public NagmarasVial() : base()
		{
			Id = 11412;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 4136;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Nagmara's Vial";
			Name2 = "Nagmara's Vial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 14929 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Flute of the Ancients)
*
***************************************************************/

namespace Server.Items
{
	public class FluteOfTheAncients : Item
	{
		public FluteOfTheAncients() : base()
		{
			Id = 11445;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21402;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Flute of the Ancients";
			Name2 = "Flute of the Ancients";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15033 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(A Crumpled Up Note)
*
***************************************************************/

namespace Server.Items
{
	public class ACrumpledUpNote : Item
	{
		public ACrumpledUpNote() : base()
		{
			Id = 11446;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7695;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			ReqLevel = 50;
			Name = "A Crumpled Up Note";
			Name2 = "A Crumpled Up Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 4264;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Discarded Knife)
*
***************************************************************/

namespace Server.Items
{
	public class DiscardedKnife : Item
	{
		public DiscardedKnife() : base()
		{
			Id = 11462;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21411;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Discarded Knife";
			Name2 = "Discarded Knife";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Undelivered Parcel)
*
***************************************************************/

namespace Server.Items
{
	public class UndeliveredParcel : Item
	{
		public UndeliveredParcel() : base()
		{
			Id = 11463;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 1244;
			ObjectClass = 12;
			SubClass = 0;
			Level = 40;
			ReqLevel = 40;
			Name = "Undelivered Parcel";
			Name2 = "Undelivered Parcel";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 4281;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Marshal Windsor's Lost Information)
*
***************************************************************/

namespace Server.Items
{
	public class MarshalWindsorsLostInformation : Item
	{
		public MarshalWindsorsLostInformation() : base()
		{
			Id = 11464;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "-General Angerforge";
			Model = 20219;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Marshal Windsor's Lost Information";
			Name2 = "Marshal Windsor's Lost Information";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Marshal Windsor's Lost Information)
*
***************************************************************/

namespace Server.Items
{
	public class MarshalWindsorsLostInformation11465 : Item
	{
		public MarshalWindsorsLostInformation11465() : base()
		{
			Id = 11465;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "-Golem Lord Argelmach";
			Model = 20219;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Marshal Windsor's Lost Information";
			Name2 = "Marshal Windsor's Lost Information";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Raschal's Report)
*
***************************************************************/

namespace Server.Items
{
	public class RaschalsReport : Item
	{
		public RaschalsReport() : base()
		{
			Id = 11466;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1093;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Raschal's Report";
			Name2 = "Raschal's Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Blackrock Medallion)
*
***************************************************************/

namespace Server.Items
{
	public class BlackrockMedallion : Item
	{
		public BlackrockMedallion() : base()
		{
			Id = 11467;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18725;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blackrock Medallion";
			Name2 = "Blackrock Medallion";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 50;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dark Iron Fanny Pack)
*
***************************************************************/

namespace Server.Items
{
	public class DarkIronFannyPack : Item
	{
		public DarkIronFannyPack() : base()
		{
			Id = 11468;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1281;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dark Iron Fanny Pack";
			Name2 = "Dark Iron Fanny Pack";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tablet Transcript)
*
***************************************************************/

namespace Server.Items
{
	public class TabletTranscript : Item
	{
		public TabletTranscript() : base()
		{
			Id = 11470;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7695;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tablet Transcript";
			Name2 = "Tablet Transcript";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fragile Sprite Darter Egg)
*
***************************************************************/

namespace Server.Items
{
	public class FragileSpriteDarterEgg : Item
	{
		public FragileSpriteDarterEgg() : base()
		{
			Id = 11471;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 20692;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fragile Sprite Darter Egg";
			Name2 = "Fragile Sprite Darter Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Silvermane Stalker Flank)
*
***************************************************************/

namespace Server.Items
{
	public class SilvermaneStalkerFlank : Item
	{
		public SilvermaneStalkerFlank() : base()
		{
			Id = 11472;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2599;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Silvermane Stalker Flank";
			Name2 = "Silvermane Stalker Flank";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			MaxCount = 5;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(U'cha's Pelt)
*
***************************************************************/

namespace Server.Items
{
	public class UchasPelt : Item
	{
		public UchasPelt() : base()
		{
			Id = 11476;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7112;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "U'cha's Pelt";
			Name2 = "U'cha's Pelt";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(White Ravasaur Claw)
*
***************************************************************/

namespace Server.Items
{
	public class WhiteRavasaurClaw : Item
	{
		public WhiteRavasaurClaw() : base()
		{
			Id = 11477;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21415;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "White Ravasaur Claw";
			Name2 = "White Ravasaur Claw";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			MaxCount = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Un'Goro Gorilla Pelt)
*
***************************************************************/

namespace Server.Items
{
	public class UnGoroGorillaPelt : Item
	{
		public UnGoroGorillaPelt() : base()
		{
			Id = 11478;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8952;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Un'Goro Gorilla Pelt";
			Name2 = "Un'Goro Gorilla Pelt";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Un'Goro Stomper Pelt)
*
***************************************************************/

namespace Server.Items
{
	public class UnGoroStomperPelt : Item
	{
		public UnGoroStomperPelt() : base()
		{
			Id = 11479;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21416;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Un'Goro Stomper Pelt";
			Name2 = "Un'Goro Stomper Pelt";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Un'Goro Thunderer Pelt)
*
***************************************************************/

namespace Server.Items
{
	public class UnGoroThundererPelt : Item
	{
		public UnGoroThundererPelt() : base()
		{
			Id = 11480;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3164;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Un'Goro Thunderer Pelt";
			Name2 = "Un'Goro Thunderer Pelt";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crystal Pylon User's Manual)
*
***************************************************************/

namespace Server.Items
{
	public class CrystalPylonUsersManual : Item
	{
		public CrystalPylonUsersManual() : base()
		{
			Id = 11482;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21431;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crystal Pylon User's Manual";
			Name2 = "Crystal Pylon User's Manual";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 1491;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Blood Amber)
*
***************************************************************/

namespace Server.Items
{
	public class BloodAmber : Item
	{
		public BloodAmber() : base()
		{
			Id = 11503;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21458;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Blood Amber";
			Name2 = "Blood Amber";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Piece of Threshadon Carcass)
*
***************************************************************/

namespace Server.Items
{
	public class PieceOfThreshadonCarcass : Item
	{
		public PieceOfThreshadonCarcass() : base()
		{
			Id = 11504;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1116;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Piece of Threshadon Carcass";
			Name2 = "Piece of Threshadon Carcass";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Spotted Hyena Pelt)
*
***************************************************************/

namespace Server.Items
{
	public class SpottedHyenaPelt : Item
	{
		public SpottedHyenaPelt() : base()
		{
			Id = 11507;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21463;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Spotted Hyena Pelt";
			Name2 = "Spotted Hyena Pelt";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Ravasaur Pheromone Gland)
*
***************************************************************/

namespace Server.Items
{
	public class RavasaurPheromoneGland : Item
	{
		public RavasaurPheromoneGland() : base()
		{
			Id = 11509;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1438;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ravasaur Pheromone Gland";
			Name2 = "Ravasaur Pheromone Gland";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 5;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Lar'korwi's Head)
*
***************************************************************/

namespace Server.Items
{
	public class LarkorwisHead : Item
	{
		public LarkorwisHead() : base()
		{
			Id = 11510;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 30111;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Lar'korwi's Head";
			Name2 = "Lar'korwi's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Cenarion Beacon)
*
***************************************************************/

namespace Server.Items
{
	public class CenarionBeacon : Item
	{
		public CenarionBeacon() : base()
		{
			Id = 11511;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "This device helps identify corrupted elements of nature.";
			Model = 21469;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Cenarion Beacon";
			Name2 = "Cenarion Beacon";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Patch of Tainted Skin)
*
***************************************************************/

namespace Server.Items
{
	public class PatchOfTaintedSkin : Item
	{
		public PatchOfTaintedSkin() : base()
		{
			Id = 11512;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 21470;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Patch of Tainted Skin";
			Name2 = "Patch of Tainted Skin";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tainted Vitriol)
*
***************************************************************/

namespace Server.Items
{
	public class TaintedVitriol : Item
	{
		public TaintedVitriol() : base()
		{
			Id = 11513;
			Bonding = 1;
			SellPrice = 1;
			AvailableClasses = 0x7FFF;
			Model = 19239;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tainted Vitriol";
			Name2 = "Tainted Vitriol";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 4;
			InventoryType = InventoryTypes.None;
			Delay = 500;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fel Creep)
*
***************************************************************/

namespace Server.Items
{
	public class FelCreep : Item
	{
		public FelCreep() : base()
		{
			Id = 11514;
			Bonding = 1;
			SellPrice = 1;
			AvailableClasses = 0x7FFF;
			Model = 21471;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Fel Creep";
			Name2 = "Fel Creep";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 4;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Corrupted Soul Shard)
*
***************************************************************/

namespace Server.Items
{
	public class CorruptedSoulShard : Item
	{
		public CorruptedSoulShard() : base()
		{
			Id = 11515;
			Bonding = 1;
			SellPrice = 1;
			AvailableClasses = 0x7FFF;
			Model = 21472;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Corrupted Soul Shard";
			Name2 = "Corrupted Soul Shard";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 4;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Cenarion Plant Salve)
*
***************************************************************/

namespace Server.Items
{
	public class CenarionPlantSalve : Item
	{
		public CenarionPlantSalve() : base()
		{
			Id = 11516;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "This druidic brew is used to cleanse corrupted plants.";
			Model = 21473;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cenarion Plant Salve";
			Name2 = "Cenarion Plant Salve";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 100;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crystal Restore)
*
***************************************************************/

namespace Server.Items
{
	public class CrystalRestore : Item
	{
		public CrystalRestore() : base()
		{
			Id = 11562;
			Bonding = 1;
			SellPrice = 1000;
			AvailableClasses = 0x7FFF;
			Model = 2516;
			ObjectClass = 12;
			SubClass = 0;
			Level = 55;
			Name = "Crystal Restore";
			Name2 = "Crystal Restore";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 4000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2112;
			SetSpell( 15229 , 0 , -1 , 0 , 30 , 180000 );
		}
	}
}


/**************************************************************
*
*				(Crystal Force)
*
***************************************************************/

namespace Server.Items
{
	public class CrystalForce : Item
	{
		public CrystalForce() : base()
		{
			Id = 11563;
			Bonding = 1;
			SellPrice = 1000;
			AvailableClasses = 0x7FFF;
			Model = 13496;
			ObjectClass = 12;
			SubClass = 0;
			Level = 55;
			Name = "Crystal Force";
			Name2 = "Crystal Force";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 4000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2112;
			SetSpell( 15231 , 0 , -1 , 0 , 102 , 600000 );
		}
	}
}


/**************************************************************
*
*				(Crystal Ward)
*
***************************************************************/

namespace Server.Items
{
	public class CrystalWard : Item
	{
		public CrystalWard() : base()
		{
			Id = 11564;
			Bonding = 1;
			SellPrice = 1000;
			AvailableClasses = 0x7FFF;
			Model = 4777;
			ObjectClass = 12;
			SubClass = 0;
			Level = 55;
			Name = "Crystal Ward";
			Name2 = "Crystal Ward";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 4000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2112;
			SetSpell( 15233 , 0 , -1 , 0 , 102 , 600000 );
		}
	}
}


/**************************************************************
*
*				(Crystal Yield)
*
***************************************************************/

namespace Server.Items
{
	public class CrystalYield : Item
	{
		public CrystalYield() : base()
		{
			Id = 11565;
			Bonding = 1;
			SellPrice = 1000;
			AvailableClasses = 0x7FFF;
			Model = 7401;
			ObjectClass = 12;
			SubClass = 0;
			Level = 55;
			Name = "Crystal Yield";
			Name2 = "Crystal Yield";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 4000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2112;
			SetSpell( 15235 , 0 , -1 , 0 , 29 , 180000 );
		}
	}
}


/**************************************************************
*
*				(Crystal Charge)
*
***************************************************************/

namespace Server.Items
{
	public class CrystalCharge : Item
	{
		public CrystalCharge() : base()
		{
			Id = 11566;
			Bonding = 1;
			SellPrice = 1000;
			AvailableClasses = 0x7FFF;
			Model = 6496;
			ObjectClass = 12;
			SubClass = 0;
			Level = 55;
			Name = "Crystal Charge";
			Name2 = "Crystal Charge";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 4000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2112;
			SetSpell( 15239 , 0 , -1 , 0 , 24 , 60000 );
		}
	}
}


/**************************************************************
*
*				(Crystal Spire)
*
***************************************************************/

namespace Server.Items
{
	public class CrystalSpire : Item
	{
		public CrystalSpire() : base()
		{
			Id = 11567;
			Bonding = 1;
			SellPrice = 1000;
			AvailableClasses = 0x7FFF;
			Model = 1262;
			ObjectClass = 12;
			SubClass = 0;
			Level = 55;
			Name = "Crystal Spire";
			Name2 = "Crystal Spire";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 4000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2112;
			SetSpell( 15279 , 0 , -1 , 0 , 28 , 300000 );
		}
	}
}


/**************************************************************
*
*				(Preserved Threshadon Meat)
*
***************************************************************/

namespace Server.Items
{
	public class PreservedThreshadonMeat : Item
	{
		public PreservedThreshadonMeat() : base()
		{
			Id = 11569;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 2599;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Preserved Threshadon Meat";
			Name2 = "Preserved Threshadon Meat";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15118 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Preserved Pheromone Mixture)
*
***************************************************************/

namespace Server.Items
{
	public class PreservedPheromoneMixture : Item
	{
		public PreservedPheromoneMixture() : base()
		{
			Id = 11570;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 1275;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Preserved Pheromone Mixture";
			Name2 = "Preserved Pheromone Mixture";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15119 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Cactus Apple)
*
***************************************************************/

namespace Server.Items
{
	public class CactusApple : Item
	{
		public CactusApple() : base()
		{
			Id = 11583;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6410;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cactus Apple";
			Name2 = "Cactus Apple";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Eridan's Supplies)
*
***************************************************************/

namespace Server.Items
{
	public class EridansSupplies : Item
	{
		public EridansSupplies() : base()
		{
			Id = 11617;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21586;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Eridan's Supplies";
			Name2 = "Eridan's Supplies";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 8;
			Flags = 4;
		}
	}
}


/**************************************************************
*
*				(Lesser Arcanum of Rumination)
*
***************************************************************/

namespace Server.Items
{
	public class LesserArcanumOfRumination : Item
	{
		public LesserArcanumOfRumination() : base()
		{
			Id = 11622;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22651;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Lesser Arcanum of Rumination";
			Name2 = "Lesser Arcanum of Rumination";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15340 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Lesser Arcanum of Constitution)
*
***************************************************************/

namespace Server.Items
{
	public class LesserArcanumOfConstitution : Item
	{
		public LesserArcanumOfConstitution() : base()
		{
			Id = 11642;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22651;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Lesser Arcanum of Constitution";
			Name2 = "Lesser Arcanum of Constitution";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15389 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Lesser Arcanum of Tenacity)
*
***************************************************************/

namespace Server.Items
{
	public class LesserArcanumOfTenacity : Item
	{
		public LesserArcanumOfTenacity() : base()
		{
			Id = 11643;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22651;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Lesser Arcanum of Tenacity";
			Name2 = "Lesser Arcanum of Tenacity";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15391 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Lesser Arcanum of Resilience)
*
***************************************************************/

namespace Server.Items
{
	public class LesserArcanumOfResilience : Item
	{
		public LesserArcanumOfResilience() : base()
		{
			Id = 11644;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22651;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Lesser Arcanum of Resilience";
			Name2 = "Lesser Arcanum of Resilience";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15394 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Lesser Arcanum of Voracity)
*
***************************************************************/

namespace Server.Items
{
	public class LesserArcanumOfVoracity : Item
	{
		public LesserArcanumOfVoracity() : base()
		{
			Id = 11645;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22651;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Lesser Arcanum of Voracity";
			Name2 = "Lesser Arcanum of Voracity";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15397 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Lesser Arcanum of Voracity)
*
***************************************************************/

namespace Server.Items
{
	public class LesserArcanumOfVoracity11646 : Item
	{
		public LesserArcanumOfVoracity11646() : base()
		{
			Id = 11646;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22651;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Lesser Arcanum of Voracity";
			Name2 = "Lesser Arcanum of Voracity";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15400 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Lesser Arcanum of Voracity)
*
***************************************************************/

namespace Server.Items
{
	public class LesserArcanumOfVoracity11647 : Item
	{
		public LesserArcanumOfVoracity11647() : base()
		{
			Id = 11647;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22651;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Lesser Arcanum of Voracity";
			Name2 = "Lesser Arcanum of Voracity";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15402 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Lesser Arcanum of Voracity)
*
***************************************************************/

namespace Server.Items
{
	public class LesserArcanumOfVoracity11648 : Item
	{
		public LesserArcanumOfVoracity11648() : base()
		{
			Id = 11648;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22651;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Lesser Arcanum of Voracity";
			Name2 = "Lesser Arcanum of Voracity";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15404 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Lesser Arcanum of Voracity)
*
***************************************************************/

namespace Server.Items
{
	public class LesserArcanumOfVoracity11649 : Item
	{
		public LesserArcanumOfVoracity11649() : base()
		{
			Id = 11649;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22651;
			ObjectClass = 12;
			SubClass = 0;
			Level = 50;
			Name = "Lesser Arcanum of Voracity";
			Name2 = "Lesser Arcanum of Voracity";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15406 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Flute of Xavaric)
*
***************************************************************/

namespace Server.Items
{
	public class FluteOfXavaric : Item
	{
		public FluteOfXavaric() : base()
		{
			Id = 11668;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 21402;
			ObjectClass = 12;
			SubClass = 0;
			Level = 54;
			ReqLevel = 49;
			Name = "Flute of Xavaric";
			Name2 = "Flute of Xavaric";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 939;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Jadefire Felbind)
*
***************************************************************/

namespace Server.Items
{
	public class JadefireFelbind : Item
	{
		public JadefireFelbind() : base()
		{
			Id = 11674;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21651;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Jadefire Felbind";
			Name2 = "Jadefire Felbind";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Eridan's Vial)
*
***************************************************************/

namespace Server.Items
{
	public class EridansVial : Item
	{
		public EridansVial() : base()
		{
			Id = 11682;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21673;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Eridan's Vial";
			Name2 = "Eridan's Vial";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 3;
			Flags = 64;
			SetSpell( 15491 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Goodsteel's Balanced Flameberge)
*
***************************************************************/

namespace Server.Items
{
	public class GoodsteelsBalancedFlameberge : Item
	{
		public GoodsteelsBalancedFlameberge() : base()
		{
			Id = 11723;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21692;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Goodsteel's Balanced Flameberge";
			Name2 = "Goodsteel's Balanced Flameberge";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Overdue Package)
*
***************************************************************/

namespace Server.Items
{
	public class OverduePackage : Item
	{
		public OverduePackage() : base()
		{
			Id = 11724;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "To: Krinkle Goodsteel, Tanaris";
			Model = 7918;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Overdue Package";
			Name2 = "Overdue Package";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Solid Crystal Leg Shaft)
*
***************************************************************/

namespace Server.Items
{
	public class SolidCrystalLegShaft : Item
	{
		public SolidCrystalLegShaft() : base()
		{
			Id = 11725;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10530;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Solid Crystal Leg Shaft";
			Name2 = "Solid Crystal Leg Shaft";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Goodsteel Ledger)
*
***************************************************************/

namespace Server.Items
{
	public class GoodsteelLedger : Item
	{
		public GoodsteelLedger() : base()
		{
			Id = 11727;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1143;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Goodsteel Ledger";
			Name2 = "Goodsteel Ledger";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 1551;
		}
	}
}


/**************************************************************
*
*				(Burning Essence)
*
***************************************************************/

namespace Server.Items
{
	public class BurningEssence : Item
	{
		public BurningEssence() : base()
		{
			Id = 11751;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "The smoldering remains of something...";
			Model = 21724;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Burning Essence";
			Name2 = "Burning Essence";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 5;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Black Blood of the Tormented)
*
***************************************************************/

namespace Server.Items
{
	public class BlackBloodOfTheTormented : Item
	{
		public BlackBloodOfTheTormented() : base()
		{
			Id = 11752;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "The putrid scent of burned blood assaults your senses.";
			Model = 17974;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Black Blood of the Tormented";
			Name2 = "Black Blood of the Tormented";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 5;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Eye of Kajal)
*
***************************************************************/

namespace Server.Items
{
	public class EyeOfKajal : Item
	{
		public EyeOfKajal() : base()
		{
			Id = 11753;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "The pupil tracks your every move.";
			Model = 7986;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Eye of Kajal";
			Name2 = "Eye of Kajal";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Black Diamond)
*
***************************************************************/

namespace Server.Items
{
	public class BlackDiamond : Item
	{
		public BlackDiamond() : base()
		{
			Id = 11754;
			AvailableClasses = 0x7FFF;
			Model = 22652;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Black Diamond";
			Name2 = "Black Diamond";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 5;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Spraggle's Canteen)
*
***************************************************************/

namespace Server.Items
{
	public class SpragglesCanteen : Item
	{
		public SpragglesCanteen() : base()
		{
			Id = 11804;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21794;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Spraggle's Canteen";
			Name2 = "Spraggle's Canteen";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2112;
			SetSpell( 15591 , 0 , 0 , 45000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Grimsite Outhouse Key)
*
***************************************************************/

namespace Server.Items
{
	public class GrimsiteOuthouseKey : Item
	{
		public GrimsiteOuthouseKey() : base()
		{
			Id = 11818;
			AvailableClasses = 0x7FFF;
			Model = 21807;
			ObjectClass = 12;
			SubClass = 0;
			Level = 43;
			ReqLevel = 43;
			Name = "Grimsite Outhouse Key";
			Name2 = "Grimsite Outhouse Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 4451;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Un'Goro Ash)
*
***************************************************************/

namespace Server.Items
{
	public class UnGoroAsh : Item
	{
		public UnGoroAsh() : base()
		{
			Id = 11829;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2480;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Un'Goro Ash";
			Name2 = "Un'Goro Ash";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Webbed Diemetradon Scale)
*
***************************************************************/

namespace Server.Items
{
	public class WebbedDiemetradonScale : Item
	{
		public WebbedDiemetradonScale() : base()
		{
			Id = 11830;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21834;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Webbed Diemetradon Scale";
			Name2 = "Webbed Diemetradon Scale";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Webbed Pterrordax Scale)
*
***************************************************************/

namespace Server.Items
{
	public class WebbedPterrordaxScale : Item
	{
		public WebbedPterrordaxScale() : base()
		{
			Id = 11831;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21835;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Webbed Pterrordax Scale";
			Name2 = "Webbed Pterrordax Scale";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Gorishi Queen Lure)
*
***************************************************************/

namespace Server.Items
{
	public class GorishiQueenLure : Item
	{
		public GorishiQueenLure() : base()
		{
			Id = 11833;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21836;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gorishi Queen Lure";
			Name2 = "Gorishi Queen Lure";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15627 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Super Sticky Tar)
*
***************************************************************/

namespace Server.Items
{
	public class SuperStickyTar : Item
	{
		public SuperStickyTar() : base()
		{
			Id = 11834;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9518;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Super Sticky Tar";
			Name2 = "Super Sticky Tar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = 8;
		}
	}
}


/**************************************************************
*
*				(Gorishi Queen Brain)
*
***************************************************************/

namespace Server.Items
{
	public class GorishiQueenBrain : Item
	{
		public GorishiQueenBrain() : base()
		{
			Id = 11835;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 10923;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Gorishi Queen Brain";
			Name2 = "Gorishi Queen Brain";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Gorishi Scent Gland)
*
***************************************************************/

namespace Server.Items
{
	public class GorishiScentGland : Item
	{
		public GorishiScentGland() : base()
		{
			Id = 11837;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1438;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gorishi Scent Gland";
			Name2 = "Gorishi Scent Gland";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Bank Voucher)
*
***************************************************************/

namespace Server.Items
{
	public class BankVoucher : Item
	{
		public BankVoucher() : base()
		{
			Id = 11843;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bank Voucher";
			Name2 = "Bank Voucher";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Pestlezugg's Un'Goro Report)
*
***************************************************************/

namespace Server.Items
{
	public class PestlezuggsUnGoroReport : Item
	{
		public PestlezuggsUnGoroReport() : base()
		{
			Id = 11844;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1301;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pestlezugg's Un'Goro Report";
			Name2 = "Pestlezugg's Un'Goro Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Urgent Message)
*
***************************************************************/

namespace Server.Items
{
	public class UrgentMessage : Item
	{
		public UrgentMessage() : base()
		{
			Id = 11886;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7695;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Urgent Message";
			Name2 = "Urgent Message";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 1711;
		}
	}
}


/**************************************************************
*
*				(Filled Cursed Ooze Jar)
*
***************************************************************/

namespace Server.Items
{
	public class FilledCursedOozeJar : Item
	{
		public FilledCursedOozeJar() : base()
		{
			Id = 11947;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21971;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Cursed Ooze Jar";
			Name2 = "Filled Cursed Ooze Jar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 64;
		}
	}
}


/**************************************************************
*
*				(Filled Tainted Ooze Jar)
*
***************************************************************/

namespace Server.Items
{
	public class FilledTaintedOozeJar : Item
	{
		public FilledTaintedOozeJar() : base()
		{
			Id = 11949;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21972;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Tainted Ooze Jar";
			Name2 = "Filled Tainted Ooze Jar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 64;
		}
	}
}


/**************************************************************
*
*				(Filled Pure Sample Jar)
*
***************************************************************/

namespace Server.Items
{
	public class FilledPureSampleJar : Item
	{
		public FilledPureSampleJar() : base()
		{
			Id = 11954;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21976;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Pure Sample Jar";
			Name2 = "Filled Pure Sample Jar";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 64;
		}
	}
}


/**************************************************************
*
*				(Shindrell's Note)
*
***************************************************************/

namespace Server.Items
{
	public class ShindrellsNote : Item
	{
		public ShindrellsNote() : base()
		{
			Id = 12060;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6270;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shindrell's Note";
			Name2 = "Shindrell's Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Silver Dawning's Lockbox)
*
***************************************************************/

namespace Server.Items
{
	public class SilverDawningsLockbox : Item
	{
		public SilverDawningsLockbox() : base()
		{
			Id = 12191;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22192;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Silver Dawning's Lockbox";
			Name2 = "Silver Dawning's Lockbox";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Mist Veil's Lockbox)
*
***************************************************************/

namespace Server.Items
{
	public class MistVeilsLockbox : Item
	{
		public MistVeilsLockbox() : base()
		{
			Id = 12192;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16028;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Mist Veil's Lockbox";
			Name2 = "Mist Veil's Lockbox";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Unadorned Seal of Ascension)
*
***************************************************************/

namespace Server.Items
{
	public class UnadornedSealOfAscension : Item
	{
		public UnadornedSealOfAscension() : base()
		{
			Id = 12219;
			AvailableClasses = 0x7FFF;
			Description = "Three empty sockets cover the face.";
			Model = 19330;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Unadorned Seal of Ascension";
			Name2 = "Unadorned Seal of Ascension";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Intact Elemental Bracer)
*
***************************************************************/

namespace Server.Items
{
	public class IntactElementalBracer : Item
	{
		public IntactElementalBracer() : base()
		{
			Id = 12220;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7025;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Intact Elemental Bracer";
			Name2 = "Intact Elemental Bracer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Felwood Slime Sample)
*
***************************************************************/

namespace Server.Items
{
	public class FelwoodSlimeSample : Item
	{
		public FelwoodSlimeSample() : base()
		{
			Id = 12230;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22202;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Felwood Slime Sample";
			Name2 = "Felwood Slime Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Corrupted Felwood Sample)
*
***************************************************************/

namespace Server.Items
{
	public class CorruptedFelwoodSample : Item
	{
		public CorruptedFelwoodSample() : base()
		{
			Id = 12234;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22203;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Corrupted Felwood Sample";
			Name2 = "Corrupted Felwood Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Un'Goro Slime Sample)
*
***************************************************************/

namespace Server.Items
{
	public class UnGoroSlimeSample : Item
	{
		public UnGoroSlimeSample() : base()
		{
			Id = 12235;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22204;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Un'Goro Slime Sample";
			Name2 = "Un'Goro Slime Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Pure Un'Goro Sample)
*
***************************************************************/

namespace Server.Items
{
	public class PureUnGoroSample : Item
	{
		public PureUnGoroSample() : base()
		{
			Id = 12236;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22205;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pure Un'Goro Sample";
			Name2 = "Pure Un'Goro Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fine Crab Chunks)
*
***************************************************************/

namespace Server.Items
{
	public class FineCrabChunks : Item
	{
		public FineCrabChunks() : base()
		{
			Id = 12237;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22193;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fine Crab Chunks";
			Name2 = "Fine Crab Chunks";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Collected Dragon Egg)
*
***************************************************************/

namespace Server.Items
{
	public class CollectedDragonEgg : Item
	{
		public CollectedDragonEgg() : base()
		{
			Id = 12241;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1659;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Collected Dragon Egg";
			Name2 = "Collected Dragon Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sea Creature Bones)
*
***************************************************************/

namespace Server.Items
{
	public class SeaCreatureBones : Item
	{
		public SeaCreatureBones() : base()
		{
			Id = 12242;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22207;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Sea Creature Bones";
			Name2 = "Sea Creature Bones";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Empty Worg Pup Cage)
*
***************************************************************/

namespace Server.Items
{
	public class EmptyWorgPupCage : Item
	{
		public EmptyWorgPupCage() : base()
		{
			Id = 12262;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22271;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Empty Worg Pup Cage";
			Name2 = "Empty Worg Pup Cage";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15998 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Caged Worg Pup)
*
***************************************************************/

namespace Server.Items
{
	public class CagedWorgPup : Item
	{
		public CagedWorgPup() : base()
		{
			Id = 12263;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The cage rattles and shakes.";
			Model = 22271;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Caged Worg Pup";
			Name2 = "Caged Worg Pup";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Broodling Essence)
*
***************************************************************/

namespace Server.Items
{
	public class BroodlingEssence : Item
	{
		public BroodlingEssence() : base()
		{
			Id = 12283;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7050;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Broodling Essence";
			Name2 = "Broodling Essence";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Draco-Incarcinatrix 900)
*
***************************************************************/

namespace Server.Items
{
	public class DracoIncarcinatrix900 : Item
	{
		public DracoIncarcinatrix900() : base()
		{
			Id = 12284;
			AvailableClasses = 0x7FFF;
			Model = 22293;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Draco-Incarcinatrix 900";
			Name2 = "Draco-Incarcinatrix 900";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16007 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Eggscilloscope Prototype)
*
***************************************************************/

namespace Server.Items
{
	public class EggscilloscopePrototype : Item
	{
		public EggscilloscopePrototype() : base()
		{
			Id = 12286;
			AvailableClasses = 0x7FFF;
			Model = 22299;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Eggscilloscope Prototype";
			Name2 = "Eggscilloscope Prototype";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16028 , 0 , 0 , 3000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Collectronic Module)
*
***************************************************************/

namespace Server.Items
{
	public class CollectronicModule : Item
	{
		public CollectronicModule() : base()
		{
			Id = 12287;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22303;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Collectronic Module";
			Name2 = "Collectronic Module";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 15958 , 0 , 0 , 6000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Encased Corrupt Ooze)
*
***************************************************************/

namespace Server.Items
{
	public class EncasedCorruptOoze : Item
	{
		public EncasedCorruptOoze() : base()
		{
			Id = 12288;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 8381;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Encased Corrupt Ooze";
			Name2 = "Encased Corrupt Ooze";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16031 , 0 , -1 , 180000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Sea Turtle Remains)
*
***************************************************************/

namespace Server.Items
{
	public class SeaTurtleRemains : Item
	{
		public SeaTurtleRemains() : base()
		{
			Id = 12289;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22304;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Sea Turtle Remains";
			Name2 = "Sea Turtle Remains";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Merged Ooze Sample)
*
***************************************************************/

namespace Server.Items
{
	public class MergedOozeSample : Item
	{
		public MergedOozeSample() : base()
		{
			Id = 12291;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6703;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Merged Ooze Sample";
			Name2 = "Merged Ooze Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Strangely Marked Box)
*
***************************************************************/

namespace Server.Items
{
	public class StrangelyMarkedBox : Item
	{
		public StrangelyMarkedBox() : base()
		{
			Id = 12292;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7913;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Strangely Marked Box";
			Name2 = "Strangely Marked Box";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fine Gold Thread)
*
***************************************************************/

namespace Server.Items
{
	public class FineGoldThread : Item
	{
		public FineGoldThread() : base()
		{
			Id = 12293;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7331;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fine Gold Thread";
			Name2 = "Fine Gold Thread";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Orb of Draconic Energy)
*
***************************************************************/

namespace Server.Items
{
	public class OrbOfDraconicEnergy : Item
	{
		public OrbOfDraconicEnergy() : base()
		{
			Id = 12300;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 6506;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Orb of Draconic Energy";
			Name2 = "Orb of Draconic Energy";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16053 , 0 , -5 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Unforged Seal of Ascension)
*
***************************************************************/

namespace Server.Items
{
	public class UnforgedSealOfAscension : Item
	{
		public UnforgedSealOfAscension() : base()
		{
			Id = 12323;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7366;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Unforged Seal of Ascension";
			Name2 = "Unforged Seal of Ascension";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16057 , 0 , -5 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Forged Seal of Ascension)
*
***************************************************************/

namespace Server.Items
{
	public class ForgedSealOfAscension : Item
	{
		public ForgedSealOfAscension() : base()
		{
			Id = 12324;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7366;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Forged Seal of Ascension";
			Name2 = "Forged Seal of Ascension";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Frostmaul Shards)
*
***************************************************************/

namespace Server.Items
{
	public class FrostmaulShards : Item
	{
		public FrostmaulShards() : base()
		{
			Id = 12334;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6563;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Frostmaul Shards";
			Name2 = "Frostmaul Shards";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Gemstone of Smolderthorn)
*
***************************************************************/

namespace Server.Items
{
	public class GemstoneOfSmolderthorn : Item
	{
		public GemstoneOfSmolderthorn() : base()
		{
			Id = 12335;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 6496;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gemstone of Smolderthorn";
			Name2 = "Gemstone of Smolderthorn";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gemstone of Spirestone)
*
***************************************************************/

namespace Server.Items
{
	public class GemstoneOfSpirestone : Item
	{
		public GemstoneOfSpirestone() : base()
		{
			Id = 12336;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 2516;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gemstone of Spirestone";
			Name2 = "Gemstone of Spirestone";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gemstone of Bloodaxe)
*
***************************************************************/

namespace Server.Items
{
	public class GemstoneOfBloodaxe : Item
	{
		public GemstoneOfBloodaxe() : base()
		{
			Id = 12337;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 6006;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gemstone of Bloodaxe";
			Name2 = "Gemstone of Bloodaxe";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Vaelan's Gift)
*
***************************************************************/

namespace Server.Items
{
	public class VaelansGift : Item
	{
		public VaelansGift() : base()
		{
			Id = 12339;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 18721;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Vaelan's Gift";
			Name2 = "Vaelan's Gift";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 4;
		}
	}
}


/**************************************************************
*
*				(Blackwood Fruit Sample)
*
***************************************************************/

namespace Server.Items
{
	public class BlackwoodFruitSample : Item
	{
		public BlackwoodFruitSample() : base()
		{
			Id = 12341;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22414;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blackwood Fruit Sample";
			Name2 = "Blackwood Fruit Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Blackwood Grain Sample)
*
***************************************************************/

namespace Server.Items
{
	public class BlackwoodGrainSample : Item
	{
		public BlackwoodGrainSample() : base()
		{
			Id = 12342;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16206;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blackwood Grain Sample";
			Name2 = "Blackwood Grain Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Blackwood Nut Sample)
*
***************************************************************/

namespace Server.Items
{
	public class BlackwoodNutSample : Item
	{
		public BlackwoodNutSample() : base()
		{
			Id = 12343;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6417;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blackwood Nut Sample";
			Name2 = "Blackwood Nut Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Bijou's Belongings)
*
***************************************************************/

namespace Server.Items
{
	public class BijousBelongings : Item
	{
		public BijousBelongings() : base()
		{
			Id = 12345;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19595;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bijou's Belongings";
			Name2 = "Bijou's Belongings";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Empty Cleansing Bowl)
*
***************************************************************/

namespace Server.Items
{
	public class EmptyCleansingBowl : Item
	{
		public EmptyCleansingBowl() : base()
		{
			Id = 12346;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22416;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Empty Cleansing Bowl";
			Name2 = "Empty Cleansing Bowl";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16073 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Filled Cleansing Bowl)
*
***************************************************************/

namespace Server.Items
{
	public class FilledCleansingBowl : Item
	{
		public FilledCleansingBowl() : base()
		{
			Id = 12347;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22417;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Cleansing Bowl";
			Name2 = "Filled Cleansing Bowl";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 1088;
			SetSpell( 16072 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Cliffspring River Sample)
*
***************************************************************/

namespace Server.Items
{
	public class CliffspringRiverSample : Item
	{
		public CliffspringRiverSample() : base()
		{
			Id = 12349;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 15773;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cliffspring River Sample";
			Name2 = "Cliffspring River Sample";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Empty Sampling Tube)
*
***************************************************************/

namespace Server.Items
{
	public class EmptySamplingTube : Item
	{
		public EmptySamplingTube() : base()
		{
			Id = 12350;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22429;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Empty Sampling Tube";
			Name2 = "Empty Sampling Tube";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16077 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Doomrigger's Clasp)
*
***************************************************************/

namespace Server.Items
{
	public class DoomriggersClasp : Item
	{
		public DoomriggersClasp() : base()
		{
			Id = 12352;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7366;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Doomrigger's Clasp";
			Name2 = "Doomrigger's Clasp";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Talisman of Corruption)
*
***************************************************************/

namespace Server.Items
{
	public class TalismanOfCorruption : Item
	{
		public TalismanOfCorruption() : base()
		{
			Id = 12355;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19462;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Talisman of Corruption";
			Name2 = "Talisman of Corruption";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Highperch Wyvern Egg)
*
***************************************************************/

namespace Server.Items
{
	public class HighperchWyvernEgg : Item
	{
		public HighperchWyvernEgg() : base()
		{
			Id = 12356;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22436;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Highperch Wyvern Egg";
			Name2 = "Highperch Wyvern Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Darkstone Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class DarkstoneTablet : Item
	{
		public DarkstoneTablet() : base()
		{
			Id = 12358;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22443;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Darkstone Tablet";
			Name2 = "Darkstone Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Thick Yeti Fur)
*
***************************************************************/

namespace Server.Items
{
	public class ThickYetiFur : Item
	{
		public ThickYetiFur() : base()
		{
			Id = 12366;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21366;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Thick Yeti Fur";
			Name2 = "Thick Yeti Fur";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Pristine Yeti Horn)
*
***************************************************************/

namespace Server.Items
{
	public class PristineYetiHorn : Item
	{
		public PristineYetiHorn() : base()
		{
			Id = 12367;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22464;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pristine Yeti Horn";
			Name2 = "Pristine Yeti Horn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dawn's Gambit)
*
***************************************************************/

namespace Server.Items
{
	public class DawnsGambit : Item
	{
		public DawnsGambit() : base()
		{
			Id = 12368;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 12332;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dawn's Gambit";
			Name2 = "Dawn's Gambit";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 17045 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Moontouched Feather)
*
***************************************************************/

namespace Server.Items
{
	public class MoontouchedFeather : Item
	{
		public MoontouchedFeather() : base()
		{
			Id = 12383;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19528;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Moontouched Feather";
			Name2 = "Moontouched Feather";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Cache of Mau'ari)
*
***************************************************************/

namespace Server.Items
{
	public class CacheOfMauari : Item
	{
		public CacheOfMauari() : base()
		{
			Id = 12384;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 22483;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cache of Mau'ari";
			Name2 = "Cache of Mau'ari";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ancient Egg)
*
***************************************************************/

namespace Server.Items
{
	public class AncientEgg : Item
	{
		public AncientEgg() : base()
		{
			Id = 12402;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18050;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ancient Egg";
			Name2 = "Ancient Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Third Mosh'aru Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class ThirdMosharuTablet : Item
	{
		public ThirdMosharuTablet() : base()
		{
			Id = 12411;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22484;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Third Mosh'aru Tablet";
			Name2 = "Third Mosh'aru Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Fourth Mosh'aru Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class FourthMosharuTablet : Item
	{
		public FourthMosharuTablet() : base()
		{
			Id = 12412;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20220;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fourth Mosh'aru Tablet";
			Name2 = "Fourth Mosh'aru Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Frostsaber E'ko)
*
***************************************************************/

namespace Server.Items
{
	public class FrostsaberEko : Item
	{
		public FrostsaberEko() : base()
		{
			Id = 12430;
			AvailableClasses = 0x7FFF;
			Model = 19800;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Frostsaber E'ko";
			Name2 = "Frostsaber E'ko";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Winterfall E'ko)
*
***************************************************************/

namespace Server.Items
{
	public class WinterfallEko : Item
	{
		public WinterfallEko() : base()
		{
			Id = 12431;
			AvailableClasses = 0x7FFF;
			Model = 19800;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Winterfall E'ko";
			Name2 = "Winterfall E'ko";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Shardtooth E'ko)
*
***************************************************************/

namespace Server.Items
{
	public class ShardtoothEko : Item
	{
		public ShardtoothEko() : base()
		{
			Id = 12432;
			AvailableClasses = 0x7FFF;
			Model = 19800;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shardtooth E'ko";
			Name2 = "Shardtooth E'ko";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Wildkin E'ko)
*
***************************************************************/

namespace Server.Items
{
	public class WildkinEko : Item
	{
		public WildkinEko() : base()
		{
			Id = 12433;
			AvailableClasses = 0x7FFF;
			Model = 19800;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Wildkin E'ko";
			Name2 = "Wildkin E'ko";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Chillwind E'ko)
*
***************************************************************/

namespace Server.Items
{
	public class ChillwindEko : Item
	{
		public ChillwindEko() : base()
		{
			Id = 12434;
			AvailableClasses = 0x7FFF;
			Model = 19800;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Chillwind E'ko";
			Name2 = "Chillwind E'ko";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ice Thistle E'ko)
*
***************************************************************/

namespace Server.Items
{
	public class IceThistleEko : Item
	{
		public IceThistleEko() : base()
		{
			Id = 12435;
			AvailableClasses = 0x7FFF;
			Model = 19800;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ice Thistle E'ko";
			Name2 = "Ice Thistle E'ko";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Frostmaul E'ko)
*
***************************************************************/

namespace Server.Items
{
	public class FrostmaulEko : Item
	{
		public FrostmaulEko() : base()
		{
			Id = 12436;
			AvailableClasses = 0x7FFF;
			Model = 19800;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Frostmaul E'ko";
			Name2 = "Frostmaul E'ko";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Ridgewell's Crate)
*
***************************************************************/

namespace Server.Items
{
	public class RidgewellsCrate : Item
	{
		public RidgewellsCrate() : base()
		{
			Id = 12437;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 8928;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Ridgewell's Crate";
			Name2 = "Ridgewell's Crate";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Tinkee's Letter)
*
***************************************************************/

namespace Server.Items
{
	public class TinkeesLetter : Item
	{
		public TinkeesLetter() : base()
		{
			Id = 12438;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3029;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Tinkee's Letter";
			Name2 = "Tinkee's Letter";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 1691;
		}
	}
}


/**************************************************************
*
*				(Uncracked Chillwind Horn)
*
***************************************************************/

namespace Server.Items
{
	public class UncrackedChillwindHorn : Item
	{
		public UncrackedChillwindHorn() : base()
		{
			Id = 12444;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 16283;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Uncracked Chillwind Horn";
			Name2 = "Uncracked Chillwind Horn";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Felnok's Package)
*
***************************************************************/

namespace Server.Items
{
	public class FelnoksPackage : Item
	{
		public FelnoksPackage() : base()
		{
			Id = 12445;
			AvailableClasses = 0x7FFF;
			Model = 11448;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Felnok's Package";
			Name2 = "Felnok's Package";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Juju Flurry)
*
***************************************************************/

namespace Server.Items
{
	public class JujuFlurry : Item
	{
		public JujuFlurry() : base()
		{
			Id = 12450;
			Bonding = 1;
			SellPrice = 1500;
			AvailableClasses = 0x7FFF;
			Model = 22634;
			ObjectClass = 12;
			SubClass = 0;
			Level = 60;
			Name = "Juju Flurry";
			Name2 = "Juju Flurry";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 6000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
			SetSpell( 16322 , 0 , -1 , 60000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Juju Power)
*
***************************************************************/

namespace Server.Items
{
	public class JujuPower : Item
	{
		public JujuPower() : base()
		{
			Id = 12451;
			Bonding = 1;
			SellPrice = 1500;
			AvailableClasses = 0x7FFF;
			Model = 22636;
			ObjectClass = 12;
			SubClass = 0;
			Level = 60;
			Name = "Juju Power";
			Name2 = "Juju Power";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 6000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
			SetSpell( 16323 , 0 , -1 , 60000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Juju Ember)
*
***************************************************************/

namespace Server.Items
{
	public class JujuEmber : Item
	{
		public JujuEmber() : base()
		{
			Id = 12455;
			Bonding = 1;
			SellPrice = 1500;
			AvailableClasses = 0x7FFF;
			Model = 22639;
			ObjectClass = 12;
			SubClass = 0;
			Level = 60;
			Name = "Juju Ember";
			Name2 = "Juju Ember";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 6000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
			SetSpell( 16326 , 0 , -1 , 60000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Juju Chill)
*
***************************************************************/

namespace Server.Items
{
	public class JujuChill : Item
	{
		public JujuChill() : base()
		{
			Id = 12457;
			Bonding = 1;
			SellPrice = 1500;
			AvailableClasses = 0x7FFF;
			Model = 22641;
			ObjectClass = 12;
			SubClass = 0;
			Level = 60;
			Name = "Juju Chill";
			Name2 = "Juju Chill";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 6000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
			SetSpell( 16325 , 0 , -1 , 60000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Juju Guile)
*
***************************************************************/

namespace Server.Items
{
	public class JujuGuile : Item
	{
		public JujuGuile() : base()
		{
			Id = 12458;
			Bonding = 1;
			SellPrice = 1500;
			AvailableClasses = 0x7FFF;
			Model = 22642;
			ObjectClass = 12;
			SubClass = 0;
			Level = 60;
			Name = "Juju Guile";
			Name2 = "Juju Guile";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 6000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
			SetSpell( 16327 , 0 , -1 , 60000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Juju Escape)
*
***************************************************************/

namespace Server.Items
{
	public class JujuEscape : Item
	{
		public JujuEscape() : base()
		{
			Id = 12459;
			Bonding = 1;
			SellPrice = 1500;
			AvailableClasses = 0x7FFF;
			Model = 22634;
			ObjectClass = 12;
			SubClass = 0;
			Level = 60;
			Name = "Juju Escape";
			Name2 = "Juju Escape";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 6000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
			SetSpell( 16321 , 0 , -1 , 60000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Juju Might)
*
***************************************************************/

namespace Server.Items
{
	public class JujuMight : Item
	{
		public JujuMight() : base()
		{
			Id = 12460;
			Bonding = 1;
			SellPrice = 1500;
			AvailableClasses = 0x7FFF;
			Model = 22643;
			ObjectClass = 12;
			SubClass = 0;
			Level = 60;
			Name = "Juju Might";
			Name2 = "Juju Might";
			Quality = 1;
			AvailableRaces = 0x1FF;
			BuyPrice = 6000;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
			Flags = 2048;
			SetSpell( 16329 , 0 , -1 , 60000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Alien Egg)
*
***************************************************************/

namespace Server.Items
{
	public class AlienEgg : Item
	{
		public AlienEgg() : base()
		{
			Id = 12467;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Something seems to shake from within";
			Model = 6504;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			ReqLevel = 1;
			Name = "Alien Egg";
			Name2 = "Alien Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Krakle's Thermometer)
*
***************************************************************/

namespace Server.Items
{
	public class KraklesThermometer : Item
	{
		public KraklesThermometer() : base()
		{
			Id = 12472;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Quality Guaranteed by Kraklenheit Industries";
			Model = 7841;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Krakle's Thermometer";
			Name2 = "Krakle's Thermometer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16378 , 0 , 0 , 10000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Blue-feathered Amulet)
*
***************************************************************/

namespace Server.Items
{
	public class BlueFeatheredAmulet : Item
	{
		public BlueFeatheredAmulet() : base()
		{
			Id = 12524;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22716;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blue-feathered Amulet";
			Name2 = "Blue-feathered Amulet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Jaron's Supplies)
*
***************************************************************/

namespace Server.Items
{
	public class JaronsSupplies : Item
	{
		public JaronsSupplies() : base()
		{
			Id = 12525;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 9151;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jaron's Supplies";
			Name2 = "Jaron's Supplies";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Spire Spider Egg)
*
***************************************************************/

namespace Server.Items
{
	public class SpireSpiderEgg : Item
	{
		public SpireSpiderEgg() : base()
		{
			Id = 12530;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 18047;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Spire Spider Egg";
			Name2 = "Spire Spider Egg";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Omokk's Head)
*
***************************************************************/

namespace Server.Items
{
	public class OmokksHead : Item
	{
		public OmokksHead() : base()
		{
			Id = 12534;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 9666;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Omokk's Head";
			Name2 = "Omokk's Head";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 3136;
			SetSpell( 16447 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Blue-feathered Necklace)
*
***************************************************************/

namespace Server.Items
{
	public class BlueFeatheredNecklace : Item
	{
		public BlueFeatheredNecklace() : base()
		{
			Id = 12558;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 22765;
			ObjectClass = 12;
			SubClass = 0;
			Level = 52;
			ReqLevel = 52;
			Name = "Blue-feathered Necklace";
			Name2 = "Blue-feathered Necklace";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 4882;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Important Blackrock Documents)
*
***************************************************************/

namespace Server.Items
{
	public class ImportantBlackrockDocuments : Item
	{
		public ImportantBlackrockDocuments() : base()
		{
			Id = 12562;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3331;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Important Blackrock Documents";
			Name2 = "Important Blackrock Documents";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
			PageText = 1772;
		}
	}
}


/**************************************************************
*
*				(Warlord Goretooth's Command)
*
***************************************************************/

namespace Server.Items
{
	public class WarlordGoretoothsCommand : Item
	{
		public WarlordGoretoothsCommand() : base()
		{
			Id = 12563;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "Bears the seal of the K.E.F.";
			Model = 5567;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Warlord Goretooth's Command";
			Name2 = "Warlord Goretooth's Command";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 4903;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Assassination Note)
*
***************************************************************/

namespace Server.Items
{
	public class AssassinationNote : Item
	{
		public AssassinationNote() : base()
		{
			Id = 12564;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 22771;
			ObjectClass = 12;
			SubClass = 0;
			Level = 23;
			ReqLevel = 23;
			Name = "Assassination Note";
			Name2 = "Assassination Note";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 4881;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
			PageText = 1771;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Hardened Flasket)
*
***************************************************************/

namespace Server.Items
{
	public class HardenedFlasket : Item
	{
		public HardenedFlasket() : base()
		{
			Id = 12566;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 21673;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Hardened Flasket";
			Name2 = "Hardened Flasket";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 3;
			Flags = 64;
			SetSpell( 15649 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Filled Flasket)
*
***************************************************************/

namespace Server.Items
{
	public class FilledFlasket : Item
	{
		public FilledFlasket() : base()
		{
			Id = 12567;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22785;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Filled Flasket";
			Name2 = "Filled Flasket";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 3;
		}
	}
}


/**************************************************************
*
*				(Shardtooth Meat)
*
***************************************************************/

namespace Server.Items
{
	public class ShardtoothMeat : Item
	{
		public ShardtoothMeat() : base()
		{
			Id = 12622;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2599;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Shardtooth Meat";
			Name2 = "Shardtooth Meat";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Chillwind Meat)
*
***************************************************************/

namespace Server.Items
{
	public class ChillwindMeat : Item
	{
		public ChillwindMeat() : base()
		{
			Id = 12623;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2599;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Chillwind Meat";
			Name2 = "Chillwind Meat";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Temporal Displacer)
*
***************************************************************/

namespace Server.Items
{
	public class TemporalDisplacer : Item
	{
		public TemporalDisplacer() : base()
		{
			Id = 12627;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6338;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Temporal Displacer";
			Name2 = "Temporal Displacer";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16613 , 0 , 0 , 60000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Head of Rend Blackhand)
*
***************************************************************/

namespace Server.Items
{
	public class HeadOfRendBlackhand : Item
	{
		public HeadOfRendBlackhand() : base()
		{
			Id = 12630;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Sickening, bloody, foulness.";
			Model = 1310;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Head of Rend Blackhand";
			Name2 = "Head of Rend Blackhand";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Simple Parchment)
*
***************************************************************/

namespace Server.Items
{
	public class SimpleParchment12635 : Item
	{
		public SimpleParchment12635() : base()
		{
			Id = 12635;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7798;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Simple Parchment";
			Name2 = "Simple Parchment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2131;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Andorhal Watch)
*
***************************************************************/

namespace Server.Items
{
	public class AndorhalWatch : Item
	{
		public AndorhalWatch() : base()
		{
			Id = 12638;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "The hands of this watch are frozen at 3:00.";
			Model = 22911;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Andorhal Watch";
			Name2 = "Andorhal Watch";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Cleansed Infernal Orb)
*
***************************************************************/

namespace Server.Items
{
	public class CleansedInfernalOrb : Item
	{
		public CleansedInfernalOrb() : base()
		{
			Id = 12642;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1695;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Cleansed Infernal Orb";
			Name2 = "Cleansed Infernal Orb";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Infus Emerald)
*
***************************************************************/

namespace Server.Items
{
	public class InfusEmerald : Item
	{
		public InfusEmerald() : base()
		{
			Id = 12646;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7393;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Infus Emerald";
			Name2 = "Infus Emerald";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16628 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Felhas Ruby)
*
***************************************************************/

namespace Server.Items
{
	public class FelhasRuby : Item
	{
		public FelhasRuby() : base()
		{
			Id = 12647;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 4777;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Felhas Ruby";
			Name2 = "Felhas Ruby";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16627 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Imprisoned Felhound Spirit)
*
***************************************************************/

namespace Server.Items
{
	public class ImprisonedFelhoundSpirit : Item
	{
		public ImprisonedFelhoundSpirit() : base()
		{
			Id = 12648;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7045;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Imprisoned Felhound Spirit";
			Name2 = "Imprisoned Felhound Spirit";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
		}
	}
}


/**************************************************************
*
*				(Imprisoned Infernal Spirit)
*
***************************************************************/

namespace Server.Items
{
	public class ImprisonedInfernalSpirit : Item
	{
		public ImprisonedInfernalSpirit() : base()
		{
			Id = 12649;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6851;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Imprisoned Infernal Spirit";
			Name2 = "Imprisoned Infernal Spirit";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
		}
	}
}


/**************************************************************
*
*				(Bijou's Reconnaissance Report)
*
***************************************************************/

namespace Server.Items
{
	public class BijousReconnaissanceReport : Item
	{
		public BijousReconnaissanceReport() : base()
		{
			Id = 12652;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "TOP SECRET";
			Model = 7649;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bijou's Reconnaissance Report";
			Name2 = "Bijou's Reconnaissance Report";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Glyphed Oaken Branch)
*
***************************************************************/

namespace Server.Items
{
	public class GlyphedOakenBranch : Item
	{
		public GlyphedOakenBranch() : base()
		{
			Id = 12663;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "Glyphs of a druidic nature adorn the branch.";
			Model = 22953;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glyphed Oaken Branch";
			Name2 = "Glyphed Oaken Branch";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crossroads' Supply Crates)
*
***************************************************************/

namespace Server.Items
{
	public class CrossroadsSupplyCrates : Item
	{
		public CrossroadsSupplyCrates() : base()
		{
			Id = 12708;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 11449;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Crossroads' Supply Crates";
			Name2 = "Crossroads' Supply Crates";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Glowing Hunk of the Beast's Flesh)
*
***************************************************************/

namespace Server.Items
{
	public class GlowingHunkOfTheBeastsFlesh : Item
	{
		public GlowingHunkOfTheBeastsFlesh() : base()
		{
			Id = 12710;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "It Glows!";
			Model = 22979;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Glowing Hunk of the Beast's Flesh";
			Name2 = "Glowing Hunk of the Beast's Flesh";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Good Luck Half-Charm)
*
***************************************************************/

namespace Server.Items
{
	public class GoodLuckHalfCharm : Item
	{
		public GoodLuckHalfCharm() : base()
		{
			Id = 12721;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23713;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Good Luck Half-Charm";
			Name2 = "Good Luck Half-Charm";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Good Luck Other-Half-Charm)
*
***************************************************************/

namespace Server.Items
{
	public class GoodLuckOtherHalfCharm : Item
	{
		public GoodLuckOtherHalfCharm() : base()
		{
			Id = 12722;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23714;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Good Luck Other-Half-Charm";
			Name2 = "Good Luck Other-Half-Charm";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 3136;
			SetSpell( 16781 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Good Luck Charm)
*
***************************************************************/

namespace Server.Items
{
	public class GoodLuckCharm : Item
	{
		public GoodLuckCharm() : base()
		{
			Id = 12723;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23715;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Good Luck Charm";
			Name2 = "Good Luck Charm";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Janice's Parcel)
*
***************************************************************/

namespace Server.Items
{
	public class JanicesParcel : Item
	{
		public JanicesParcel() : base()
		{
			Id = 12724;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23146;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Janice's Parcel";
			Name2 = "Janice's Parcel";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Warosh's Scroll)
*
***************************************************************/

namespace Server.Items
{
	public class WaroshsScroll : Item
	{
		public WaroshsScroll() : base()
		{
			Id = 12730;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 4110;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Warosh's Scroll";
			Name2 = "Warosh's Scroll";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			PageText = 2212;
		}
	}
}


/**************************************************************
*
*				(Pristine Hide of the Beast)
*
***************************************************************/

namespace Server.Items
{
	public class PristineHideOfTheBeast : Item
	{
		public PristineHideOfTheBeast() : base()
		{
			Id = 12731;
			AvailableClasses = 0x7FFF;
			Model = 23150;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pristine Hide of the Beast";
			Name2 = "Pristine Hide of the Beast";
			Quality = 4;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Incendia Agave)
*
***************************************************************/

namespace Server.Items
{
	public class IncendiaAgave : Item
	{
		public IncendiaAgave() : base()
		{
			Id = 12732;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 19497;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Incendia Agave";
			Name2 = "Incendia Agave";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Sacred Frostsaber Meat)
*
***************************************************************/

namespace Server.Items
{
	public class SacredFrostsaberMeat : Item
	{
		public SacredFrostsaberMeat() : base()
		{
			Id = 12733;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1116;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sacred Frostsaber Meat";
			Name2 = "Sacred Frostsaber Meat";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			SetSpell( 16796 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Enchanted Scarlet Thread)
*
***************************************************************/

namespace Server.Items
{
	public class EnchantedScarletThread : Item
	{
		public EnchantedScarletThread() : base()
		{
			Id = 12734;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 7403;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Enchanted Scarlet Thread";
			Name2 = "Enchanted Scarlet Thread";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Frayed Abomination Stitching)
*
***************************************************************/

namespace Server.Items
{
	public class FrayedAbominationStitching : Item
	{
		public FrayedAbominationStitching() : base()
		{
			Id = 12735;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 21416;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Frayed Abomination Stitching";
			Name2 = "Frayed Abomination Stitching";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Frostwhisper's Embalming Fluid)
*
***************************************************************/

namespace Server.Items
{
	public class FrostwhispersEmbalmingFluid : Item
	{
		public FrostwhispersEmbalmingFluid() : base()
		{
			Id = 12736;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 21473;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Frostwhisper's Embalming Fluid";
			Name2 = "Frostwhisper's Embalming Fluid";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Gloom Weed)
*
***************************************************************/

namespace Server.Items
{
	public class GloomWeed : Item
	{
		public GloomWeed() : base()
		{
			Id = 12737;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1442;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Gloom Weed";
			Name2 = "Gloom Weed";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Dalson Outhouse Key)
*
***************************************************************/

namespace Server.Items
{
	public class DalsonOuthouseKey : Item
	{
		public DalsonOuthouseKey() : base()
		{
			Id = 12738;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 13290;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dalson Outhouse Key";
			Name2 = "Dalson Outhouse Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Dalson Cabinet Key)
*
***************************************************************/

namespace Server.Items
{
	public class DalsonCabinetKey : Item
	{
		public DalsonCabinetKey() : base()
		{
			Id = 12739;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 21807;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Dalson Cabinet Key";
			Name2 = "Dalson Cabinet Key";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Fifth Mosh'aru Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class FifthMosharuTablet : Item
	{
		public FifthMosharuTablet() : base()
		{
			Id = 12740;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 20220;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fifth Mosh'aru Tablet";
			Name2 = "Fifth Mosh'aru Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Sixth Mosh'aru Tablet)
*
***************************************************************/

namespace Server.Items
{
	public class SixthMosharuTablet : Item
	{
		public SixthMosharuTablet() : base()
		{
			Id = 12741;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 22484;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Sixth Mosh'aru Tablet";
			Name2 = "Sixth Mosh'aru Tablet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Skin of Shadow)
*
***************************************************************/

namespace Server.Items
{
	public class SkinOfShadow : Item
	{
		public SkinOfShadow() : base()
		{
			Id = 12753;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 19316;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Skin of Shadow";
			Name2 = "Skin of Shadow";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 10;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Secret Note #1)
*
***************************************************************/

namespace Server.Items
{
	public class SecretNote1 : Item
	{
		public SecretNote1() : base()
		{
			Id = 12765;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23201;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Secret Note #1";
			Name2 = "Secret Note #1";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 18432;
			PageText = 2232;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Secret Note #2)
*
***************************************************************/

namespace Server.Items
{
	public class SecretNote2 : Item
	{
		public SecretNote2() : base()
		{
			Id = 12766;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23201;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Secret Note #2";
			Name2 = "Secret Note #2";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 18432;
			PageText = 2233;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Secret Note #3)
*
***************************************************************/

namespace Server.Items
{
	public class SecretNote3 : Item
	{
		public SecretNote3() : base()
		{
			Id = 12768;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23201;
			ObjectClass = 12;
			SubClass = 0;
			Name = "Secret Note #3";
			Name2 = "Secret Note #3";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 18432;
			PageText = 2234;
		}
	}
}


/**************************************************************
*
*				(Bijou's Information)
*
***************************************************************/

namespace Server.Items
{
	public class BijousInformation : Item
	{
		public BijousInformation() : base()
		{
			Id = 12770;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23229;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Bijou's Information";
			Name2 = "Bijou's Information";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Empty Firewater Flask)
*
***************************************************************/

namespace Server.Items
{
	public class EmptyFirewaterFlask : Item
	{
		public EmptyFirewaterFlask() : base()
		{
			Id = 12771;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 22429;
			ObjectClass = 12;
			SubClass = 0;
			Level = 52;
			ReqLevel = 52;
			Name = "Empty Firewater Flask";
			Name2 = "Empty Firewater Flask";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 5083;
			MaxCount = 1;
			Material = -1;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(General Drakkisath's Command)
*
***************************************************************/

namespace Server.Items
{
	public class GeneralDrakkisathsCommand : Item
	{
		public GeneralDrakkisathsCommand() : base()
		{
			Id = 12780;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 16161;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "General Drakkisath's Command";
			Name2 = "General Drakkisath's Command";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 5089;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Incendia Powder)
*
***************************************************************/

namespace Server.Items
{
	public class IncendiaPowder : Item
	{
		public IncendiaPowder() : base()
		{
			Id = 12785;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 3116;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Incendia Powder";
			Name2 = "Incendia Powder";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16996 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Unforged Rune Covered Breastplate)
*
***************************************************************/

namespace Server.Items
{
	public class UnforgedRuneCoveredBreastplate : Item
	{
		public UnforgedRuneCoveredBreastplate() : base()
		{
			Id = 12806;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "Covered in Demonic runes.";
			Model = 23289;
			ObjectClass = 12;
			SubClass = 0;
			Level = 60;
			Name = "Unforged Rune Covered Breastplate";
			Name2 = "Unforged Rune Covered Breastplate";
			Quality = 3;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 1;
		}
	}
}


/**************************************************************
*
*				(Scourge Banner)
*
***************************************************************/

namespace Server.Items
{
	public class ScourgeBanner : Item
	{
		public ScourgeBanner() : base()
		{
			Id = 12807;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 6748;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Scourge Banner";
			Name2 = "Scourge Banner";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 16989 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Unfired Plate Gauntlets)
*
***************************************************************/

namespace Server.Items
{
	public class UnfiredPlateGauntlets : Item
	{
		public UnfiredPlateGauntlets() : base()
		{
			Id = 12812;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 23294;
			ObjectClass = 12;
			SubClass = 0;
			Level = 60;
			Name = "Unfired Plate Gauntlets";
			Name2 = "Unfired Plate Gauntlets";
			Quality = 3;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = 6;
		}
	}
}


/**************************************************************
*
*				(Flask of Mystery Goo)
*
***************************************************************/

namespace Server.Items
{
	public class FlaskOfMysteryGoo : Item
	{
		public FlaskOfMysteryGoo() : base()
		{
			Id = 12813;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1288;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Flask of Mystery Goo";
			Name2 = "Flask of Mystery Goo";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Language = 7;
			PageMaterial = 1;
		}
	}
}


/**************************************************************
*
*				(Flame in a Bottle)
*
***************************************************************/

namespace Server.Items
{
	public class FlameInABottle : Item
	{
		public FlameInABottle() : base()
		{
			Id = 12814;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Description = "It's got enough juice to set a large tent on fire!";
			Model = 18080;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Flame in a Bottle";
			Name2 = "Flame in a Bottle";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 17015 , 0 , -1 , -1 , 1 , -1 );
		}
	}
}


/**************************************************************
*
*				(Beacon Torch)
*
***************************************************************/

namespace Server.Items
{
	public class BeaconTorch : Item
	{
		public BeaconTorch() : base()
		{
			Id = 12815;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23295;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Beacon Torch";
			Name2 = "Beacon Torch";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 17016 , 0 , -5 , 120000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Toxic Horror Droplet)
*
***************************************************************/

namespace Server.Items
{
	public class ToxicHorrorDroplet : Item
	{
		public ToxicHorrorDroplet() : base()
		{
			Id = 12822;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 2885;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Toxic Horror Droplet";
			Name2 = "Toxic Horror Droplet";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 20;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Winterfall Crate)
*
***************************************************************/

namespace Server.Items
{
	public class WinterfallCrate : Item
	{
		public WinterfallCrate() : base()
		{
			Id = 12829;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 7918;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Winterfall Crate";
			Name2 = "Winterfall Crate";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Minion's Scourgestone)
*
***************************************************************/

namespace Server.Items
{
	public class MinionsScourgestone : Item
	{
		public MinionsScourgestone() : base()
		{
			Id = 12840;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 23722;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Minion's Scourgestone";
			Name2 = "Minion's Scourgestone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 250;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Invader's Scourgestone)
*
***************************************************************/

namespace Server.Items
{
	public class InvadersScourgestone : Item
	{
		public InvadersScourgestone() : base()
		{
			Id = 12841;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 23720;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Invader's Scourgestone";
			Name2 = "Invader's Scourgestone";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 250;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Crudely-written Log)
*
***************************************************************/

namespace Server.Items
{
	public class CrudelyWrittenLog : Item
	{
		public CrudelyWrittenLog() : base()
		{
			Id = 12842;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 1155;
			ObjectClass = 12;
			SubClass = 0;
			Level = 52;
			ReqLevel = 52;
			Name = "Crudely-written Log";
			Name2 = "Crudely-written Log";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			StartQuest = 5123;
			MaxCount = 1;
			Material = -1;
			Flags = 2048;
		}
	}
}


/**************************************************************
*
*				(Corruptor's Scourgestone)
*
***************************************************************/

namespace Server.Items
{
	public class CorruptorsScourgestone : Item
	{
		public CorruptorsScourgestone() : base()
		{
			Id = 12843;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 23721;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Corruptor's Scourgestone";
			Name2 = "Corruptor's Scourgestone";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 250;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Argent Dawn Valor Token)
*
***************************************************************/

namespace Server.Items
{
	public class ArgentDawnValorToken : Item
	{
		public ArgentDawnValorToken() : base()
		{
			Id = 12844;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 23717;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Argent Dawn Valor Token";
			Name2 = "Argent Dawn Valor Token";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 250;
			Material = -1;
			Flags = 64;
			SetSpell( 17047 , 0 , -1 , 2000 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Medallion of Faith)
*
***************************************************************/

namespace Server.Items
{
	public class MedallionOfFaith : Item
	{
		public MedallionOfFaith() : base()
		{
			Id = 12845;
			AvailableClasses = 0x7FFF;
			Model = 9857;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Medallion of Faith";
			Name2 = "Medallion of Faith";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
		}
	}
}


/**************************************************************
*
*				(Soul Stained Pike)
*
***************************************************************/

namespace Server.Items
{
	public class SoulStainedPike : Item
	{
		public SoulStainedPike() : base()
		{
			Id = 12847;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23315;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Soul Stained Pike";
			Name2 = "Soul Stained Pike";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Blood Stained Pike)
*
***************************************************************/

namespace Server.Items
{
	public class BloodStainedPike : Item
	{
		public BloodStainedPike() : base()
		{
			Id = 12848;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Description = "Fel energies pulse across the pike.";
			Model = 23315;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Blood Stained Pike";
			Name2 = "Blood Stained Pike";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 17048 , 0 , -1 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Demon Kissed Sack)
*
***************************************************************/

namespace Server.Items
{
	public class DemonKissedSack : Item
	{
		public DemonKissedSack() : base()
		{
			Id = 12849;
			Bonding = 1;
			AvailableClasses = 0x7FFF;
			Model = 20342;
			ObjectClass = 12;
			SubClass = 0;
			Level = 61;
			Name = "Demon Kissed Sack";
			Name2 = "Demon Kissed Sack";
			Quality = 2;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 4;
		}
	}
}


/**************************************************************
*
*				(Pamela's Doll's Left Side)
*
***************************************************************/

namespace Server.Items
{
	public class PamelasDollsLeftSide : Item
	{
		public PamelasDollsLeftSide() : base()
		{
			Id = 12887;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23371;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pamela's Doll's Left Side";
			Name2 = "Pamela's Doll's Left Side";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 1088;
			SetSpell( 17133 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Pamela's Doll's Right Side)
*
***************************************************************/

namespace Server.Items
{
	public class PamelasDollsRightSide : Item
	{
		public PamelasDollsRightSide() : base()
		{
			Id = 12888;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23371;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Pamela's Doll's Right Side";
			Name2 = "Pamela's Doll's Right Side";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			Flags = 1088;
			SetSpell( 17133 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(Jaron's Pick)
*
***************************************************************/

namespace Server.Items
{
	public class JaronsPick : Item
	{
		public JaronsPick() : base()
		{
			Id = 12891;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23383;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Jaron's Pick";
			Name2 = "Jaron's Pick";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
			Flags = 64;
			SetSpell( 17474 , 0 , 0 , -1 , 0 , -1 );
		}
	}
}


/**************************************************************
*
*				(First Relic Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class FirstRelicFragment : Item
	{
		public FirstRelicFragment() : base()
		{
			Id = 12896;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23398;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "First Relic Fragment";
			Name2 = "First Relic Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Second Relic Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class SecondRelicFragment : Item
	{
		public SecondRelicFragment() : base()
		{
			Id = 12897;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23398;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Second Relic Fragment";
			Name2 = "Second Relic Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Third Relic Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class ThirdRelicFragment : Item
	{
		public ThirdRelicFragment() : base()
		{
			Id = 12898;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23398;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Third Relic Fragment";
			Name2 = "Third Relic Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Fourth Relic Fragment)
*
***************************************************************/

namespace Server.Items
{
	public class FourthRelicFragment : Item
	{
		public FourthRelicFragment() : base()
		{
			Id = 12899;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 23398;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Fourth Relic Fragment";
			Name2 = "Fourth Relic Fragment";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			MaxCount = 1;
			Material = -1;
		}
	}
}


/**************************************************************
*
*				(Annals of Darrowshire)
*
***************************************************************/

namespace Server.Items
{
	public class AnnalsOfDarrowshire : Item
	{
		public AnnalsOfDarrowshire() : base()
		{
			Id = 12900;
			Bonding = 4;
			AvailableClasses = 0x7FFF;
			Model = 1103;
			ObjectClass = 12;
			SubClass = 0;
			Level = 1;
			Name = "Annals of Darrowshire";
			Name2 = "Annals of Darrowshire";
			Quality = 1;
			AvailableRaces = 0x1FF;
			InventoryType = InventoryTypes.None;
			Stackable = 1;
			Material = -1;
			PageText = 2371;
		}
	}
}


/**************************************************************
*
*				(Purified Moonwell Water)
*
***************************************************************/

namespace Server.Items
{
	public class PurifiedMoonwellWater : Item
	{
		{
			Id = 12906;
	}