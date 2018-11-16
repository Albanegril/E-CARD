using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VueCarteButton : MonoBehaviour {
    public Button Icone;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        switch (Icone.name)
        {
            case "Button_Telephone":
                Application.OpenURL("https://www.google.com");
                break;

            case "Button_Mail":
                Application.OpenURL("https://gmail.com");
                break;

            case "Button_Twitter":
                Application.OpenURL("https://www.twitter.com");
                break;

            case "Button_Facebook":
                Application.OpenURL("https://www.facebook.com");
                break;

            default:
                break;
        }

    }
}
