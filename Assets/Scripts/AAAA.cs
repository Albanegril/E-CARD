using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AAAA : MonoBehaviour {

    string btnName;

    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {
        if ((Input.touchCount > 0) && (Input.touches[0].phase == TouchPhase.Began))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "telephone":
                        Application.OpenURL("https://www.google.com");
                        break;

                    case "mail":
                        Application.OpenURL("https://gmail.com");
                        break;

                    case "Twitter":
                        Application.OpenURL("https://www.twitter.com");
                        break;

                    case "fb":
                        Application.OpenURL("https://www.facebook.com");
                        break;

                    default:
                        break;
                }
            }
        }
	}
}
