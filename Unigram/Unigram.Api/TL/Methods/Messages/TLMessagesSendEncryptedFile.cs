// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.sendEncryptedFile
	/// </summary>
	public partial class TLMessagesSendEncryptedFile : TLObject
	{
		public TLInputEncryptedChat Peer { get; set; }
		public Int64 RandomId { get; set; }
		public Byte[] Data { get; set; }
		public TLInputEncryptedFileBase File { get; set; }

		public TLMessagesSendEncryptedFile() { }
		public TLMessagesSendEncryptedFile(TLBinaryReader from, TLType type = TLType.MessagesSendEncryptedFile)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesSendEncryptedFile; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesSendEncryptedFile)
		{
			Peer = TLFactory.Read<TLInputEncryptedChat>(from);
			RandomId = from.ReadInt64();
			Data = from.ReadByteArray();
			File = TLFactory.Read<TLInputEncryptedFileBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9A901B66);
			to.WriteObject(Peer);
			to.Write(RandomId);
			to.WriteByteArray(Data);
			to.WriteObject(File);
		}
	}
}