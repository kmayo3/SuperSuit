using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

/// An enumeration for card ranks
public enum Rank
{
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
}

// An enumeration for card suits
public enum Suit
{
        Clubs,
        Diamonds,
        Hearts,
        Spades

}

/// Provides a class for the decks of cards
public class Deck : MonoBehaviour
{
	List<Card> cardClub = new List<Card>();
	List<Texture2D> cardHeart = new List<Texture2D> ();
	List<Texture2D> cardDiamond = new List<Texture2D>();
	List<Texture2D>cardSpade = new List<Texture2D>();

	void Start()
	{
	}
	/// Constructor
	public Deck()
	{
	}
	
	/// Gets whether the deck is empty
	public bool ClubEmpty 
	{
		get { return cardClub.Count == 0; }
	}
// Gets whether the deck is empty
public bool HeartEmpty
	{
		get { return cardHeart.Count == 0; }
	}
// Gets whether the deck is empty
public bool DiamondEmpty
	{
		get { return cardDiamond.Count == 0; }
	}
	// Gets whether the deck is empty
public bool SpadeEmpty
	{
		get { return cardSpade.Count == 0; }
	}
}