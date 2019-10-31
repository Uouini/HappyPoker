/*
	Generated by KBEngine!
	Please do not modify this file!
	Please inherit this module, such as: (class Room : RoomBase)
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Room.def
	// Please inherit and implement "class Room : RoomBase"
	public abstract class RoomBase : Entity
	{
		public EntityBaseEntityCall_RoomBase baseEntityCall = null;
		public EntityCellEntityCall_RoomBase cellEntityCall = null;

		public Int32 gameMupe = 15;
		public virtual void onGameMupeChanged(Int32 oldValue) {}
		public Int64 roomId = 0;
		public virtual void onRoomIdChanged(Int64 oldValue) {}
		public Byte roomType = 0;
		public virtual void onRoomTypeChanged(Byte oldValue) {}


		public RoomBase()
		{
		}

		public override void onComponentsEnterworld()
		{
		}

		public override void onComponentsLeaveworld()
		{
		}

		public override void onGetBase()
		{
			baseEntityCall = new EntityBaseEntityCall_RoomBase(id, className);
		}

		public override void onGetCell()
		{
			cellEntityCall = new EntityCellEntityCall_RoomBase(id, className);
		}

		public override void onLoseCell()
		{
			cellEntityCall = null;
		}

		public override EntityCall getBaseEntityCall()
		{
			return baseEntityCall;
		}

		public override EntityCall getCellEntityCall()
		{
			return cellEntityCall;
		}

		public override void attachComponents()
		{
		}

		public override void detachComponents()
		{
		}

		public override void onRemoteMethodCall(MemoryStream stream)
		{
			ScriptModule sm = EntityDef.moduledefs["Room"];

			UInt16 methodUtype = 0;
			UInt16 componentPropertyUType = 0;

			if(sm.usePropertyDescrAlias)
			{
				componentPropertyUType = stream.readUint8();
			}
			else
			{
				componentPropertyUType = stream.readUint16();
			}

			if(sm.useMethodDescrAlias)
			{
				methodUtype = stream.readUint8();
			}
			else
			{
				methodUtype = stream.readUint16();
			}

			Method method = null;

			if(componentPropertyUType == 0)
			{
				method = sm.idmethods[methodUtype];
			}
			else
			{
				Property pComponentPropertyDescription = sm.idpropertys[componentPropertyUType];
				switch(pComponentPropertyDescription.properUtype)
				{
					default:
						break;
				}

				return;
			}

			switch(method.methodUtype)
			{
				default:
					break;
			};
		}

		public override void onUpdatePropertys(MemoryStream stream)
		{
			ScriptModule sm = EntityDef.moduledefs["Room"];
			Dictionary<UInt16, Property> pdatas = sm.idpropertys;

			while(stream.length() > 0)
			{
				UInt16 _t_utype = 0;
				UInt16 _t_child_utype = 0;

				{
					if(sm.usePropertyDescrAlias)
					{
						_t_utype = stream.readUint8();
						_t_child_utype = stream.readUint8();
					}
					else
					{
						_t_utype = stream.readUint16();
						_t_child_utype = stream.readUint16();
					}
				}

				Property prop = null;

				if(_t_utype == 0)
				{
					prop = pdatas[_t_child_utype];
				}
				else
				{
					Property pComponentPropertyDescription = pdatas[_t_utype];
					switch(pComponentPropertyDescription.properUtype)
					{
						default:
							break;
					}

					return;
				}

				switch(prop.properUtype)
				{
					case 40001:
						Vector3 oldval_direction = direction;
						direction = stream.readVector3();

						if(prop.isBase())
						{
							if(inited)
								onDirectionChanged(oldval_direction);
						}
						else
						{
							if(inWorld)
								onDirectionChanged(oldval_direction);
						}

						break;
					case 11:
						Int32 oldval_gameMupe = gameMupe;
						gameMupe = stream.readInt32();

						if(prop.isBase())
						{
							if(inited)
								onGameMupeChanged(oldval_gameMupe);
						}
						else
						{
							if(inWorld)
								onGameMupeChanged(oldval_gameMupe);
						}

						break;
					case 40000:
						Vector3 oldval_position = position;
						position = stream.readVector3();

						if(prop.isBase())
						{
							if(inited)
								onPositionChanged(oldval_position);
						}
						else
						{
							if(inWorld)
								onPositionChanged(oldval_position);
						}

						break;
					case 9:
						Int64 oldval_roomId = roomId;
						roomId = stream.readInt64();

						if(prop.isBase())
						{
							if(inited)
								onRoomIdChanged(oldval_roomId);
						}
						else
						{
							if(inWorld)
								onRoomIdChanged(oldval_roomId);
						}

						break;
					case 10:
						Byte oldval_roomType = roomType;
						roomType = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onRoomTypeChanged(oldval_roomType);
						}
						else
						{
							if(inWorld)
								onRoomTypeChanged(oldval_roomType);
						}

						break;
					case 40002:
						stream.readUint32();
						break;
					default:
						break;
				};
			}
		}

		public override void callPropertysSetMethods()
		{
			ScriptModule sm = EntityDef.moduledefs["Room"];
			Dictionary<UInt16, Property> pdatas = sm.idpropertys;

			Vector3 oldval_direction = direction;
			Property prop_direction = pdatas[2];
			if(prop_direction.isBase())
			{
				if(inited && !inWorld)
					onDirectionChanged(oldval_direction);
			}
			else
			{
				if(inWorld)
				{
					if(prop_direction.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onDirectionChanged(oldval_direction);
					}
				}
			}

			Int32 oldval_gameMupe = gameMupe;
			Property prop_gameMupe = pdatas[4];
			if(prop_gameMupe.isBase())
			{
				if(inited && !inWorld)
					onGameMupeChanged(oldval_gameMupe);
			}
			else
			{
				if(inWorld)
				{
					if(prop_gameMupe.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onGameMupeChanged(oldval_gameMupe);
					}
				}
			}

			Vector3 oldval_position = position;
			Property prop_position = pdatas[1];
			if(prop_position.isBase())
			{
				if(inited && !inWorld)
					onPositionChanged(oldval_position);
			}
			else
			{
				if(inWorld)
				{
					if(prop_position.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPositionChanged(oldval_position);
					}
				}
			}

			Int64 oldval_roomId = roomId;
			Property prop_roomId = pdatas[5];
			if(prop_roomId.isBase())
			{
				if(inited && !inWorld)
					onRoomIdChanged(oldval_roomId);
			}
			else
			{
				if(inWorld)
				{
					if(prop_roomId.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onRoomIdChanged(oldval_roomId);
					}
				}
			}

			Byte oldval_roomType = roomType;
			Property prop_roomType = pdatas[6];
			if(prop_roomType.isBase())
			{
				if(inited && !inWorld)
					onRoomTypeChanged(oldval_roomType);
			}
			else
			{
				if(inWorld)
				{
					if(prop_roomType.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onRoomTypeChanged(oldval_roomType);
					}
				}
			}

		}
	}
}