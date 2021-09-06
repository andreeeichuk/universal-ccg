using UniversalCCG.CommonCCG.Models.Cards;

namespace UniversalCCG.GwentLike.Models
{
	public class GwentCardData : CardData<GwentCard>
	{
		public CardStrength CardStrength { get; private set; }
	}
}