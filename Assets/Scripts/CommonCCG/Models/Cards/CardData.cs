namespace UniversalCCG.CommonCCG.Models.Cards
{
	public abstract class CardData<TCard> where TCard : Card
	{
		public CardPosition<TCard> Position { get; set; }
		public Card2DPosition<TCard> Position2D { get; set; }
	}
}