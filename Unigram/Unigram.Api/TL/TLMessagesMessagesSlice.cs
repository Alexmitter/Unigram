// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessagesMessagesSlice : TLMessagesMessagesBase 
	{

		public TLMessagesMessagesSlice() { }
		public TLMessagesMessagesSlice(TLBinaryReader from, TLType type = TLType.MessagesMessagesSlice)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesMessagesSlice; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesMessagesSlice)
		{
			Count = from.ReadInt32();
			Messages = TLFactory.Read<TLVector<TLMessageBase>>(from);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xB446AE3);
			to.Write(Count);
			to.WriteObject(Messages);
			to.WriteObject(Chats);
			to.WriteObject(Users);
		}
	}
}