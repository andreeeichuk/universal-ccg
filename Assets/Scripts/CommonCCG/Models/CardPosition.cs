namespace UniversalCCG.CommonCCG.Models
{
	public struct CardPosition
	{
		public CardSet Set { get; }
		public int Index { get; }

		public CardPosition(CardSet cardSet, int index)
		{
			Set = cardSet;
			Index = index;
		}
	}
}