// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods
{
	/// <summary>
	/// RCP method get_future_salts
	/// </summary>
	public partial class TLGetFutureSalts : TLObject
	{
		public Int32 Num { get; set; }

		public TLGetFutureSalts() { }
		public TLGetFutureSalts(TLBinaryReader from, TLType type = TLType.GetFutureSalts)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.GetFutureSalts; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.GetFutureSalts)
		{
			Num = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xB921BD04);
			to.Write(Num);
		}
	}
}