// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLAuthSentCodeTypeFlashCall : TLAuthSentCodeTypeBase 
	{
		public String Pattern { get; set; }

		public TLAuthSentCodeTypeFlashCall() { }
		public TLAuthSentCodeTypeFlashCall(TLBinaryReader from, TLType type = TLType.AuthSentCodeTypeFlashCall)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.AuthSentCodeTypeFlashCall; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.AuthSentCodeTypeFlashCall)
		{
			Pattern = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xAB03C6D9);
			to.Write(Pattern);
		}
	}
}