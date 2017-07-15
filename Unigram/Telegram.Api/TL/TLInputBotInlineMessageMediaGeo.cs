// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputBotInlineMessageMediaGeo : TLInputBotInlineMessageBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			ReplyMarkup = (1 << 2),
		}

		public bool HasReplyMarkup { get { return Flags.HasFlag(Flag.ReplyMarkup); } set { Flags = value ? (Flags | Flag.ReplyMarkup) : (Flags & ~Flag.ReplyMarkup); } }

		public Flag Flags { get; set; }
		public TLInputGeoPointBase GeoPoint { get; set; }

		public TLInputBotInlineMessageMediaGeo() { }
		public TLInputBotInlineMessageMediaGeo(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputBotInlineMessageMediaGeo; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			GeoPoint = TLFactory.Read<TLInputGeoPointBase>(from);
			if (HasReplyMarkup) ReplyMarkup = TLFactory.Read<TLReplyMarkupBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0xF4A59DE1);
			to.Write((Int32)Flags);
			to.WriteObject(GeoPoint);
			if (HasReplyMarkup) to.WriteObject(ReplyMarkup);
		}

		private void UpdateFlags()
		{
			HasReplyMarkup = ReplyMarkup != null;
		}
	}
}