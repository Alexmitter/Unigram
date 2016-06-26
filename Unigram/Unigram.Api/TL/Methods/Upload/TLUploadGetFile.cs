// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Upload
{
	/// <summary>
	/// RCP method upload.getFile
	/// </summary>
	public partial class TLUploadGetFile : TLObject
	{
		public TLInputFileLocationBase Location { get; set; }
		public Int32 Offset { get; set; }
		public Int32 Limit { get; set; }

		public TLUploadGetFile() { }
		public TLUploadGetFile(TLBinaryReader from, TLType type = TLType.UploadGetFile)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UploadGetFile; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UploadGetFile)
		{
			Location = TLFactory.Read<TLInputFileLocationBase>(from);
			Offset = from.ReadInt32();
			Limit = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE3A6CFB5);
			to.WriteObject(Location);
			to.Write(Offset);
			to.Write(Limit);
		}
	}
}