using UnityEngine;
using UniversalCCG.CommonCCG.Models.CardSets;

namespace UniversalCCG.CommonCCG.Models.Cards
{
	public class Card2DPosition<TCard> where TCard : Card
	{
		public I2DCardSet<TCard> Set { get; }

		public Vector2Int Coordinates { get; }

		public Card2DPosition(I2DCardSet<TCard> set, Vector2Int coordinates)
		{
			Set = set;
			Coordinates = coordinates;
		}
	}
}