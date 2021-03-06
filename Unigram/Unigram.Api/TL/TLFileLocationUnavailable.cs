// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLFileLocationUnavailable : TLFileLocationBase 
	{
		public TLFileLocationUnavailable() { }
		public TLFileLocationUnavailable(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.FileLocationUnavailable; } }

		public override void Read(TLBinaryReader from)
		{
			VolumeId = from.ReadInt64();
			LocalId = from.ReadInt32();
			Secret = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x7C596B46);
			to.Write(VolumeId);
			to.Write(LocalId);
			to.Write(Secret);
		}
	}
}