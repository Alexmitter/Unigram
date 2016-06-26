// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getSavedGifs
	/// </summary>
	public partial class TLMessagesGetSavedGifs : TLObject
	{
		public Int32 Hash { get; set; }

		public TLMessagesGetSavedGifs() { }
		public TLMessagesGetSavedGifs(TLBinaryReader from, TLType type = TLType.MessagesGetSavedGifs)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesGetSavedGifs; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesGetSavedGifs)
		{
			Hash = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x83BF3D52);
			to.Write(Hash);
		}
	}
}