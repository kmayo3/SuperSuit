using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuScript : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Box(new Rect(900, 900, 50, 50), "");
        if (GUI.Button(new Rect(540, 450, 200, 35), ""))
        {
            Application.LoadLevel("_Scene1");
        }
        if (GUI.Button(new Rect(537, 500, 210, 45), ""))
        {
            Application.LoadLevel("_Instructions");
        }
    }
}
