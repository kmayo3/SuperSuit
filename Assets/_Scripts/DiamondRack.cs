using UnityEngine;
using System.Collections;

public class DiamondRack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Destroy(other.gameObject);
        }
    }
}
