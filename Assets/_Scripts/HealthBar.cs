using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour 
{
    public float healthBarAmount = 0;
    public float healthBarLocation;
    public float healthBarInitialLocation = 0;
    public Image healthBarImage;
    Vector3 pos = new Vector3(0, 0, 0);

    void Start()
    {
        healthBarImage = healthBarImage.GetComponent<Image>();
    }

    void Update()
    {
        //if (healthBarAmount == 0)
        //{
        //    Application.LoadLevel("_GameOver");
        //}
    }

    public void LoseOne()
    {
        healthBarAmount = healthBarAmount - 1;
        pos.x = healthBarInitialLocation - healthBarAmount;
        //healthBarImage.transform.localPosition = pos;
    }

    public void AddOne()
    {
        healthBarAmount = healthBarAmount + 1;
        pos.x = healthBarInitialLocation + healthBarAmount;
        //healthBarImage.transform.localPosition = pos;
    }
}
