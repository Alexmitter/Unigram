// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods
{
	/// <summary>
	/// RCP method destroy_session
	/// </summary>
	public partial class TLDestroySession : TLObject
	{
		public Int64 SessionId { get; set; }

		public TLDestroySession() { }
		public TLDestroySession(TLBinaryReader from, TLType type = TLType.DestroySession)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.DestroySession; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.DestroySession)
		{
			SessionId = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE7512126);
			to.Write(SessionId);
		}
	}
}