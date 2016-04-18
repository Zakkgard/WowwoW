// Note the bind is not workin yet cause a function needs to be made for an npc cast spell with effects
using Server;
using HelperTools;
using System.Collections;
namespace Server
{
	public class HearthStoneFunc
	{
		
		public static void OnUse(BaseAbility ba, Mobile c) 
		{				
			(c as Character).Teleport((c as Character).BindingPointX,(c as Character).BindingPointY,(c as Character).BindingPointZ,(int)(c as Character).BindingPointMapId);				
								
		}			
			
	}
	public class Bind
	{
		public static void OnUse(BaseAbility ba, Mobile c, Mobile b)
		{
		
			(b as Character).ConsumeItemByIdUpTo("Hearthstone", 1 );
			(b as Character).CreateAndAddObject("Hearthstone");
		}
	}
}
//Need 2 add to spellhandlers: [CODE]SpellTemplate.SpellEffects[8690]=new OnSelfSpellEffect( HearthStoneFunc.OnUse );SpellTemplate.SpellEffects[3286]=new OnSelfSpellEffect( Bind.OnUse );

