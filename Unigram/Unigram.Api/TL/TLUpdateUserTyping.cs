// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateUserTyping : TLUpdateBase 
	{

		public TLUpdateUserTyping() { }
		public TLUpdateUserTyping(TLBinaryReader from, TLType type = TLType.UpdateUserTyping)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateUserTyping; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateUserTyping)
		{
			UserId = from.ReadInt32();
			Action = TLFactory.Read<TLSendMessageActionBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x5C486927);
			to.Write(UserId);
			to.WriteObject(Action);
		}
	}
}