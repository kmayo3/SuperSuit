using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// A class for a playing card
public class Card : MonoBehaviour
{
    public static float bottomY = -20f;
    //public HealthBar healthBar;
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            //healthBar.LoseOne();
            //healthBar.AddOne();
        }
    }

}