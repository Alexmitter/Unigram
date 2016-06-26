// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.readMessageContents
	/// </summary>
	public partial class TLMessagesReadMessageContents : TLObject
	{
		public TLVector<Int32> Id { get; set; }

		public TLMessagesReadMessageContents() { }
		public TLMessagesReadMessageContents(TLBinaryReader from, TLType type = TLType.MessagesReadMessageContents)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesReadMessageContents; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesReadMessageContents)
		{
			Id = TLFactory.Read<TLVector<Int32>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x36A73F77);
			to.WriteObject(Id);
		}
	}
}