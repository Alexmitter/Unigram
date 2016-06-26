// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getChats
	/// </summary>
	public partial class TLMessagesGetChats : TLObject
	{
		public TLVector<Int32> Id { get; set; }

		public TLMessagesGetChats() { }
		public TLMessagesGetChats(TLBinaryReader from, TLType type = TLType.MessagesGetChats)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesGetChats; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesGetChats)
		{
			Id = TLFactory.Read<TLVector<Int32>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3C6AA187);
			to.WriteObject(Id);
		}
	}
}