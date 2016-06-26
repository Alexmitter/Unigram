// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.saveDraft
	/// </summary>
	public partial class TLMessagesSaveDraft : TLObject
	{
		[Flags]
		public enum Flag : int
		{
			NoWebpage = (1 << 1),
			ReplyToMsgId = (1 << 0),
			Entities = (1 << 3),
		}

		public bool IsNoWebpage { get { return Flags.HasFlag(Flag.NoWebpage); } set { Flags = value ? (Flags | Flag.NoWebpage) : (Flags & ~Flag.NoWebpage); } }
		public bool HasReplyToMsgId { get { return Flags.HasFlag(Flag.ReplyToMsgId); } set { Flags = value ? (Flags | Flag.ReplyToMsgId) : (Flags & ~Flag.ReplyToMsgId); } }
		public bool HasEntities { get { return Flags.HasFlag(Flag.Entities); } set { Flags = value ? (Flags | Flag.Entities) : (Flags & ~Flag.Entities); } }

		public Flag Flags { get; set; }
		public Int32? ReplyToMsgId { get; set; }
		public TLInputPeerBase Peer { get; set; }
		public String Message { get; set; }
		public TLVector<TLMessageEntityBase> Entities { get; set; }

		public TLMessagesSaveDraft() { }
		public TLMessagesSaveDraft(TLBinaryReader from, TLType type = TLType.MessagesSaveDraft)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesSaveDraft; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesSaveDraft)
		{
			Flags = (Flag)from.ReadInt32();
			if (HasReplyToMsgId) { ReplyToMsgId = from.ReadInt32(); }
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Message = from.ReadString();
			if (HasEntities) { Entities = TLFactory.Read<TLVector<TLMessageEntityBase>>(from); }
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xBC39E14B);
			to.Write((Int32)Flags);
			if (HasReplyToMsgId) to.Write(ReplyToMsgId.Value);
			to.WriteObject(Peer);
			to.Write(Message);
			if (HasEntities) to.WriteObject(Entities);
		}
	}
}