using System;

namespace FOnline.BT
{
	public class IsSeen : CritterCheckCondition<CritterBlackboard>
	{
		public override bool Check (Critter checkEntity)
		{
			return GetBlackboard ().Critter.IsSeeCr (checkEntity);
		}
	}
}
