// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPrivacyKeyStatusTimestamp : TLPrivacyKeyBase 
	{
		public TLPrivacyKeyStatusTimestamp() { }
		public TLPrivacyKeyStatusTimestamp(TLBinaryReader from, TLType type = TLType.PrivacyKeyStatusTimestamp)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.PrivacyKeyStatusTimestamp; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.PrivacyKeyStatusTimestamp)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xBC2EAB30);
		}
	}
}