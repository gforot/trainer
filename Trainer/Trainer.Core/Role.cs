using System;

namespace Trainer.Core
{
	[Flags]
	public enum Role
	{
		P = 1,
		TDes = 2,
		TSin = 4,
		DCen = 8,
		CCen = 16,
		CEst = 32,
		CInt = 64,
		Trq = 128,
		ACen = 256,
		AEst = 512,
	}
}
