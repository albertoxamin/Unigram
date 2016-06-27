// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputChannel : TLInputChannelBase 
	{
		public Int32 ChannelId { get; set; }
		public Int64 AccessHash { get; set; }

		public TLInputChannel() { }
		public TLInputChannel(TLBinaryReader from, TLType type = TLType.InputChannel)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.InputChannel; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.InputChannel)
		{
			ChannelId = from.ReadInt32();
			AccessHash = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xAFEB712E);
			to.Write(ChannelId);
			to.Write(AccessHash);
		}
	}
}