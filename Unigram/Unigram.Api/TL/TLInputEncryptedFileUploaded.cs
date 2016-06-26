// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputEncryptedFileUploaded : TLInputEncryptedFileBase 
	{
		public String Md5Checksum { get; set; }

		public TLInputEncryptedFileUploaded() { }
		public TLInputEncryptedFileUploaded(TLBinaryReader from, TLType type = TLType.InputEncryptedFileUploaded)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.InputEncryptedFileUploaded; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.InputEncryptedFileUploaded)
		{
			Id = from.ReadInt64();
			Parts = from.ReadInt32();
			Md5Checksum = from.ReadString();
			KeyFingerprint = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x64BD0306);
			to.Write(Id);
			to.Write(Parts);
			to.Write(Md5Checksum);
			to.Write(KeyFingerprint);
		}
	}
}