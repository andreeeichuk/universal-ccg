using UniversalCCG.CommonCCG.Models.Cards;

namespace UniversalCCG.CommonCCG.Models.CardSets
{
	public interface IOrderedCardSet<TCard> : ICardSet<TCard> where TCard : Card
	{
		void AddAt(int index);
		void RemoveAt(int index);
		TCard GetAt(int index);
	}
}