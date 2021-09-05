using UniversalCCG.CommonCCG.Interfaces;

namespace UniversalCCG.GwentLike.Models
{
	public class CardStrength : IHasPower, IHasArmor
	{
		public int CurrentPower { get; }
		public int BasePower { get; }
		public int Armor { get; }


		public bool IsBoosted()
		{
			return CurrentPower > BasePower;
		}

		public bool IsDamaged()
		{
			return CurrentPower < BasePower;
		}
	}
}