using System;
using UniversalCCG.CommonCCG.Models.Cards;

namespace UniversalCCG.CommonCCG.Models.CardSets
{
	public interface ICardSet<TCard> where TCard : Card
	{
		int CardCount { get; }
		
		void AddCard(TCard card);
		void RemoveCard(TCard card);
		void GetRandomCard();
		void GetCardWithCondition(Func<TCard, bool> condition);
		void Clear();
	}
}