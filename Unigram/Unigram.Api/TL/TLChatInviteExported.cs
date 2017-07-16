// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChatInviteExported : TLExportedChatInviteBase 
	{
		public String Link { get; set; }

		public TLChatInviteExported() { }
		public TLChatInviteExported(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChatInviteExported; } }

		public override void Read(TLBinaryReader from)
		{
			Link = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xFC2E05BC);
			to.Write(Link);
		}
	}
}