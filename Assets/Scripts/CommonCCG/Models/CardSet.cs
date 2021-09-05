using System.Collections.Generic;

namespace UniversalCCG.CommonCCG.Models
{
	public abstract class CardSet
	{
		private List<Card> _cards;

		protected CardSet()
		{
			_cards = new List<Card>();
		}
	}
}