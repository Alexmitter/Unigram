// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPrivacyValueAllowAll : TLPrivacyRuleBase 
	{
		public TLPrivacyValueAllowAll() { }
		public TLPrivacyValueAllowAll(TLBinaryReader from, TLType type = TLType.PrivacyValueAllowAll)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.PrivacyValueAllowAll; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.PrivacyValueAllowAll)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x65427B82);
		}
	}
}