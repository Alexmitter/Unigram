// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChatForbidden : TLChatBase 
	{

		public TLChatForbidden() { }
		public TLChatForbidden(TLBinaryReader from, TLType type = TLType.ChatForbidden)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ChatForbidden; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ChatForbidden)
		{
			Id = from.ReadInt32();
			Title = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x7328BDB);
			to.Write(Id);
			to.Write(Title);
		}
	}
}