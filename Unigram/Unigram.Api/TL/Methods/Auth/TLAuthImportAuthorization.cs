// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Auth
{
	/// <summary>
	/// RCP method auth.importAuthorization
	/// </summary>
	public partial class TLAuthImportAuthorization : TLObject
	{
		public Int32 Id { get; set; }
		public Byte[] Bytes { get; set; }

		public TLAuthImportAuthorization() { }
		public TLAuthImportAuthorization(TLBinaryReader from, TLType type = TLType.AuthImportAuthorization)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.AuthImportAuthorization; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.AuthImportAuthorization)
		{
			Id = from.ReadInt32();
			Bytes = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE3EF9613);
			to.Write(Id);
			to.WriteByteArray(Bytes);
		}
	}
}