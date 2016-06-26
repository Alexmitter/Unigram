// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputBotInlineResultPhoto : TLInputBotInlineResultBase 
	{
		public TLInputPhotoBase Photo { get; set; }

		public TLInputBotInlineResultPhoto() { }
		public TLInputBotInlineResultPhoto(TLBinaryReader from, TLType type = TLType.InputBotInlineResultPhoto)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.InputBotInlineResultPhoto; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.InputBotInlineResultPhoto)
		{
			Id = from.ReadString();
			Type = from.ReadString();
			Photo = TLFactory.Read<TLInputPhotoBase>(from);
			SendMessage = TLFactory.Read<TLInputBotInlineMessageBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA8D864A7);
			to.Write(Id);
			to.Write(Type);
			to.WriteObject(Photo);
			to.WriteObject(SendMessage);
		}
	}
}