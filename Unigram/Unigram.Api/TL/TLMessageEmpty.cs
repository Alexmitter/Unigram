// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageEmpty : TLMessageBase 
	{

		public TLMessageEmpty() { }
		public TLMessageEmpty(TLBinaryReader from, TLType type = TLType.MessageEmpty)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessageEmpty; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessageEmpty)
		{
			Id = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x83E5DE54);
			to.Write(Id);
		}
	}
}