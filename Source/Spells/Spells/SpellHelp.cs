using System;
using Server;
using HelperTools;
using System.Collections;

namespace Server
{
    public class SpellHelp
    {
		public static void GraphicEffectTarget(Object caster, int spell, Object target)
		{
			byte[] tempBuff = new byte[300];
			int i = 4;
			Converter.ToBytes((ulong)caster.Guid, tempBuff, ref i);
			Converter.ToBytes((ulong)caster.Guid, tempBuff, ref i);
			Converter.ToBytes((uint)spell, tempBuff, ref i);
			Converter.ToBytes((ushort)0, tempBuff, ref i);
			Converter.ToBytes((byte)1, tempBuff, ref i);
			Converter.ToBytes((ulong)target.Guid, tempBuff, ref i);
			Converter.ToBytes((byte)0, tempBuff, ref i);
			Converter.ToBytes((ushort)2, tempBuff, ref i);
			Converter.ToBytes((ulong)target.Guid, tempBuff, ref i);
			(caster as Character).ToAllPlayerNear(OpCodes.SMSG_SPELL_GO, tempBuff, i);
		}

		public static void GraphicEffectTargetMultiple(Object caster, int spell, ArrayList target)
		{
			byte[] tempBuff = new byte[500];
			int i = 4;
			Converter.ToBytes((ulong)caster.Guid, tempBuff, ref i);
			Converter.ToBytes((ulong)caster.Guid, tempBuff, ref i);
			Converter.ToBytes((uint)spell, tempBuff, ref i);
			Converter.ToBytes((ushort)0, tempBuff, ref i);
			Converter.ToBytes((byte)target.Count, tempBuff, ref i);
			foreach(Object o in target)
			{
				Converter.ToBytes((ulong)o.Guid, tempBuff, ref i);
			}
			Converter.ToBytes((byte)0, tempBuff, ref i);
			Converter.ToBytes((ushort)2, tempBuff, ref i);
			Converter.ToBytes((ulong)(target[0] as Object).Guid, tempBuff, ref i);
			(caster as Character).ToAllPlayerNear(OpCodes.SMSG_SPELL_GO, tempBuff, i);
		}

		public static void GraphicEffectXYZ(Object caster, int spell, float x, float y,float z)
		{
			byte[] tempBuff = new byte[300];
			int offset = 4;
			Converter.ToBytes( caster.Guid, tempBuff, ref offset );
			Converter.ToBytes( caster.Guid, tempBuff, ref offset );
			Converter.ToBytes( spell, tempBuff, ref offset );
			Converter.ToBytes( (byte)0, tempBuff, ref offset );
			Converter.ToBytes( (short)0x0201, tempBuff, ref offset );
			Converter.ToBytes( (UInt64)0x32, tempBuff, ref offset );
			Converter.ToBytes( (byte)0, tempBuff, ref offset );
			Converter.ToBytes( (UInt64)1, tempBuff, ref offset );
			Converter.ToBytes( 0x20, tempBuff, ref offset );
			Converter.ToBytes( x, tempBuff, ref offset );
			Converter.ToBytes( y, tempBuff, ref offset );
			Converter.ToBytes( z, tempBuff, ref offset );
			(caster as Character).ToAllPlayerNear( OpCodes.SMSG_SPELL_GO, tempBuff, offset );
		}
		public static void GraphicEffectSelf(Object caster, int spell)
		{
			byte[] tempBuff = new byte[300];
			int offset = 4;
			Converter.ToBytes( (ulong)caster.Guid, tempBuff, ref offset );
			Converter.ToBytes( (ulong)caster.Guid, tempBuff, ref offset );
			Converter.ToBytes( (uint)spell, tempBuff, ref offset );
			Converter.ToBytes( (short)0x0101, tempBuff, ref offset );
			Converter.ToBytes( (byte)1, tempBuff, ref offset );
			Converter.ToBytes( (ulong)caster.Guid, tempBuff, ref offset );
			Converter.ToBytes( (byte)0, tempBuff, ref offset );
			Converter.ToBytes( (ushort)0, tempBuff, ref offset );
			Converter.ToBytes( (ulong)caster.Guid, tempBuff, ref offset );
			(caster as Character).ToAllPlayerNear( OpCodes.SMSG_SPELL_GO, tempBuff, offset );
		}
	}
}