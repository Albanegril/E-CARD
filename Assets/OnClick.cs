using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour {

    string btnName;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if ((Input.touchCount > 0) && (Input.touches[0].phase == TouchPhase.Began))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "twitter":
                        Application.OpenURL("https://www.google.com");
                        break; 
                    case "Cube":
                        Application.OpenURL("https://www.twitter.com");
                        break;
                    case "Cube 2":
                        Application.OpenURL("https://www.google.com");
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
