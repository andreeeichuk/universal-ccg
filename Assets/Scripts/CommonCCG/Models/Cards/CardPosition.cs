using UniversalCCG.CommonCCG.Models.CardSets;

namespace UniversalCCG.CommonCCG.Models.Cards
{
	public struct CardPosition<TCard> where TCard : Card
	{
		public IOrderedCardSet<TCard> Set { get; }
		public int Index { get; }

		public CardPosition(IOrderedCardSet<TCard> cardSet, int index)
		{
			Set = cardSet;
			Index = index;
		}
	}
}