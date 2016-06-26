// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLContact : TLObject 
	{
		public Int32 UserId { get; set; }
		public Boolean Mutual { get; set; }

		public TLContact() { }
		public TLContact(TLBinaryReader from, TLType type = TLType.Contact)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.Contact; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.Contact)
		{
			UserId = from.ReadInt32();
			Mutual = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF911C994);
			to.Write(UserId);
			to.Write(Mutual);
		}
	}
}