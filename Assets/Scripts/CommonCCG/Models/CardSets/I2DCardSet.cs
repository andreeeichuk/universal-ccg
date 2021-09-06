using UniversalCCG.CommonCCG.Models.Cards;

namespace UniversalCCG.CommonCCG.Models.CardSets
{
	public interface I2DCardSet<TCard> : ICardSet<TCard> where TCard : Card
	{
		void AddAt(int x, int y);
		void RemoveAt(int x, int y);
		TCard GetAt(int x, int y);
	}
}