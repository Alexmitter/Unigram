// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLTopPeerCategoryGroups : TLTopPeerCategoryBase 
	{
		public TLTopPeerCategoryGroups() { }
		public TLTopPeerCategoryGroups(TLBinaryReader from, TLType type = TLType.TopPeerCategoryGroups)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.TopPeerCategoryGroups; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.TopPeerCategoryGroups)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xBD17A14A);
		}
	}
}