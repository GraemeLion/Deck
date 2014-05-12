using System;
using System.Collections.Generic;

namespace Deck
{
	public class Deck
	{
		List<Card> _deck = new List<Card>();


		public Deck ()
		{
			for (int suit = 0; suit < 4; suit++) {
				for (int value = 1; value < 14; value++) {
					var tmpCard = new Card ();
					switch(suit)
					{
					case 0:
						tmpCard.Suit = Suit.HEARTS;
						break;
					case 1:
						tmpCard.Suit = Suit.CLUBS;
						break;
					case 2:
						tmpCard.Suit = Suit.HEARTS;
						break;
					case 3:
						tmpCard.Suit = Suit.SPADES;
						break;

					}

					tmpCard.Value = value;		
					_deck.Add (tmpCard);

				}
			}
		}
		public void Shuffle()
		{
			Random rng = new Random();
			int count = _deck.Count;
			while (count > 1)
			{
				count--;
				int k = rng.Next(count+1);
				var tmpCard = _deck[k];
				_deck[k] = _deck[count];
				_deck[count] = tmpCard;

			}
		}
		public List<Card> GetDeck()
		{
			return _deck;
		}

		public struct Card
		{
			//public enum Suit {Hearts, Clubs, Spades, Diamonds};
			public Suit Suit;
			public int Value;
		}
		public enum Suit {
			HEARTS=0,
			CLUBS,
			SPADES,
			DIAMONDS
		}

	}


}

