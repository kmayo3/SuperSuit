using UnityEngine;
using System.Collections;

public class ClubRack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        while (Input.GetKeyDown(KeyCode.G))
        {
            Destroy(other.gameObject);
        }
    }
}
