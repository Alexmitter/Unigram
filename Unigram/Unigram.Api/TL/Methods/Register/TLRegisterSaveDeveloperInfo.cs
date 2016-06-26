// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Register
{
	/// <summary>
	/// RCP method register.saveDeveloperInfo
	/// </summary>
	public partial class TLRegisterSaveDeveloperInfo : TLObject
	{
		public String Name { get; set; }
		public String Email { get; set; }
		public String PhoneNumber { get; set; }
		public Int32 Age { get; set; }
		public String City { get; set; }

		public TLRegisterSaveDeveloperInfo() { }
		public TLRegisterSaveDeveloperInfo(TLBinaryReader from, TLType type = TLType.RegisterSaveDeveloperInfo)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.RegisterSaveDeveloperInfo; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.RegisterSaveDeveloperInfo)
		{
			Name = from.ReadString();
			Email = from.ReadString();
			PhoneNumber = from.ReadString();
			Age = from.ReadInt32();
			City = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9A5F6E95);
			to.Write(Name);
			to.Write(Email);
			to.Write(PhoneNumber);
			to.Write(Age);
			to.Write(City);
		}
	}
}