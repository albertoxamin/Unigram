// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.getAccountTTL
	/// </summary>
	public partial class TLAccountGetAccountTTL : TLObject
	{
		public TLAccountGetAccountTTL() { }
		public TLAccountGetAccountTTL(TLBinaryReader from, TLType type = TLType.AccountGetAccountTTL)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.AccountGetAccountTTL; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.AccountGetAccountTTL)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x8FC711D);
		}
	}
}