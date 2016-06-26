// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChannelParticipantKicked : TLChannelParticipantBase 
	{
		public Int32 KickedBy { get; set; }

		public TLChannelParticipantKicked() { }
		public TLChannelParticipantKicked(TLBinaryReader from, TLType type = TLType.ChannelParticipantKicked)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ChannelParticipantKicked; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ChannelParticipantKicked)
		{
			UserId = from.ReadInt32();
			KickedBy = from.ReadInt32();
			Date = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x8CC5E69A);
			to.Write(UserId);
			to.Write(KickedBy);
			to.Write(Date);
		}
	}
}