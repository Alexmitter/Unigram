// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLAuthPasswordRecovery : TLObject 
	{
		public String EmailPattern { get; set; }

		public TLAuthPasswordRecovery() { }
		public TLAuthPasswordRecovery(TLBinaryReader from, TLType type = TLType.AuthPasswordRecovery)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.AuthPasswordRecovery; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.AuthPasswordRecovery)
		{
			EmailPattern = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x137948A5);
			to.Write(EmailPattern);
		}
	}
}