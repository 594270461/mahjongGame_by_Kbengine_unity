/*
	Generated by KBEngine!
	Please do not modify this file!
	
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Account.def
	public class EntityBaseEntityCall_AccountBase : EntityCall
	{

		public EntityBaseEntityCall_AccountBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

		public void EnterMatchesMatch()
		{
			Bundle pBundle = newCall("EnterMatchesMatch", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void reqAddFriend(UInt64 arg1)
		{
			Bundle pBundle = newCall("reqAddFriend", 0);
			if(pBundle == null)
				return;

			bundle.writeUint64(arg1);
			sendCall(null);
		}

		public void reqChangeRoom()
		{
			Bundle pBundle = newCall("reqChangeRoom", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void reqCreateAvatar(string arg1)
		{
			Bundle pBundle = newCall("reqCreateAvatar", 0);
			if(pBundle == null)
				return;

			bundle.writeUnicode(arg1);
			sendCall(null);
		}

		public void reqFriendsList()
		{
			Bundle pBundle = newCall("reqFriendsList", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

	}

	public class EntityCellEntityCall_AccountBase : EntityCall
	{

		public EntityCellEntityCall_AccountBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

		public void LeaveRoom()
		{
			Bundle pBundle = newCall("LeaveRoom", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

	}
	}
