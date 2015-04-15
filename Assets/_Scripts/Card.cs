using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// A class for a playing card
public class Card : MonoBehaviour
{
    //string rank;
    //string suit;

    //public Texture2D aceOfHeart;
    //public Texture2D twoOfHeart;
    //public Texture2D threeOfHeart;
    //public Texture2D fourOfHeart;
    //public Texture2D fiveOfHeart;
    //public Texture2D sixOfHeart;
    //public Texture2D sevenOfHeart;
    //public Texture2D eightOfHeart;
    //public Texture2D nineOfHeart;
    //public Texture2D tenOfHeart;
	
    //public Texture2D aceOfClubs;
    //public Texture2D twoOfClubs;
    //public Texture2D threeOfClubs;
    //public Texture2D fourOfClubs;
    //public Texture2D fiveOfClubs;
    //public Texture2D sixOfClubs;
    //public Texture2D sevenOfClubs;
    //public Texture2D eightOfClubs;
    //public Texture2D nineOfClubs;
    //public Texture2D tenOfClubs;
	
    //public Texture2D aceOfSpades;
    //public Texture2D twoOfSpades;
    //public Texture2D threeOfSpades;
    //public Texture2D fourOfSpades;
    //public Texture2D fiveOfSpades;
    //public Texture2D sixOfSpades;
    //public Texture2D sevenOfSpades;
    //public Texture2D eightOfSpades;
    //public Texture2D nineOfSpades;
    //public Texture2D tenOfSpades;
	
    //public Texture2D aceOfDiamond;
    //public Texture2D twoOfDiamond;
    //public Texture2D threeOfDiamond;
    //public Texture2D fourOfDiamond;
    //public Texture2D fiveOfDiamond;
    //public Texture2D sixOfDiamond;
    //public Texture2D sevenOfDiamond;
    //public Texture2D eightOfDiamond;
    //public Texture2D nineOfDiamond;
    //public Texture2D tenOfDiamond;

    public static float bottomY = -20f;
    public HealthBar healthBar;
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            healthBar.LoseOne();
        }
    }

}