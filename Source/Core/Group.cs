namespace Server
{
    using System.Collections;

    using HelperTools;

    public class Group
	{
		ArrayList members = new ArrayList();
		Member groupLeader;
        
		public Group()
		{
			members = new ArrayList();
		}

		public void Add(Character c)
		{
			Add(c, 0x1);			
		}

		public void Add(Character c, ushort droit)
		{
			Member m = new Member(c);
			m.Droits = droit;
			members.Add(m);
			if (Count == 1)
            {
                groupLeader = m;
            }
			else
            {
                this.UpdateList();
            }
		}

		public void UpdateList()
		{
			foreach( Member to in Members )
			{
				int offset = 4;
				Converter.ToBytes( (short)0, groupLeader.Character.tempBuff, ref offset);
				Converter.ToBytes( Count, groupLeader.Character.tempBuff, ref offset);
				int n = 0;
				foreach(Member m in Members)
				{
					Converter.ToBytes(m.Character.Name, groupLeader.Character.tempBuff, ref offset);
					Converter.ToBytes((byte)0, groupLeader.Character.tempBuff, ref offset);
					Converter.ToBytes(m.Character.Guid, groupLeader.Character.tempBuff, ref offset);
					if (to == m)
						Converter.ToBytes((ushort)0x101, groupLeader.Character.tempBuff, ref offset);					
					else
						Converter.ToBytes((ushort)0x1, groupLeader.Character.tempBuff, ref offset);					
					n++;
				}

				Converter.ToBytes(GroupLeader.Character.Guid, groupLeader.Character.tempBuff, ref offset);
				Converter.ToBytes((byte)0, groupLeader.Character.tempBuff, ref offset);
				Converter.ToBytes(GroupLeader.Character.Guid, groupLeader.Character.tempBuff, ref offset);
				Converter.ToBytes((byte)0, groupLeader.Character.tempBuff, ref offset);
			
				to.Character.Send(OpCodes.SMSG_GROUP_LIST, groupLeader.Character.tempBuff, offset);
			}
		}

		public void PromoteLeader(Character c)
		{
			foreach(Member to in Members)
			{
				int offset = 4;
				Converter.ToBytes(to.Character.Name, groupLeader.Character.tempBuff, ref offset);
				Converter.ToBytes((byte)0, groupLeader.Character.tempBuff, ref offset);
				to.Character.Send(OpCodes.SMSG_GROUP_SET_LEADER, groupLeader.Character.tempBuff, offset);
				if (c == to.Character)
                {
                    groupLeader = to;
                }
			}			

			this.UpdateList();
		}

		public void Quit(Character c)
		{
			if (members == null)
            {
                return;
            }

			ArrayList al = new ArrayList();
			foreach( Member m in members )
			{
				if (m.Character == c)
				{					
					c.Send(OpCodes.SMSG_GROUP_DESTROYED, c.tempBuff, 4);
				}
				else
				{
				//	Console.WriteLine("Stay in group {0}", m.Char.Name );
					al.Add(m);
				}
			}

			members = al;
			if (Count > 1)
			{
				if (groupLeader.Character == c)
                {
                    groupLeader = (Member)al[0];
                }

				this.UpdateList();
			}
			else if (Count == 1)
			{
				(members[0] as Member).Character.Send(OpCodes.SMSG_GROUP_DESTROYED, c.tempBuff, 4);
				(members[0] as Member).Character.QuitGroup();				
			}
		}

		public Member GroupLeader
		{
			get { return groupLeader; }
		}

		public int Count
		{
			get { return members.Count; }
		}

		public ArrayList Members
		{
			get { return members; }
		}
	}
}
