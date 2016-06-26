// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputStickerSetID : TLInputStickerSetBase 
	{
		public Int64 Id { get; set; }
		public Int64 AccessHash { get; set; }

		public TLInputStickerSetID() { }
		public TLInputStickerSetID(TLBinaryReader from, TLType type = TLType.InputStickerSetID)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.InputStickerSetID; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.InputStickerSetID)
		{
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9DE7A269);
			to.Write(Id);
			to.Write(AccessHash);
		}
	}
}