// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Help
{
	/// <summary>
	/// RCP method help.getSupport
	/// </summary>
	public partial class TLHelpGetSupport : TLObject
	{
		public TLHelpGetSupport() { }
		public TLHelpGetSupport(TLBinaryReader from, TLType type = TLType.HelpGetSupport)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.HelpGetSupport; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.HelpGetSupport)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9CDF08CD);
		}
	}
}