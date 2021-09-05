namespace UniversalCCG.CommonCCG.Interfaces
{
	public interface IHasPower
	{
		int CurrentPower { get; }
		int BasePower { get; }

		bool IsBoosted();
		bool IsDamaged();
	}
}