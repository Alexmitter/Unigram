// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Contacts
{
	/// <summary>
	/// RCP method contacts.exportCard
	/// </summary>
	public partial class TLContactsExportCard : TLObject
	{
		public TLContactsExportCard() { }
		public TLContactsExportCard(TLBinaryReader from, TLType type = TLType.ContactsExportCard)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ContactsExportCard; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ContactsExportCard)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x84E53737);
		}
	}
}