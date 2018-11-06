using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetBonjour : MonoBehaviour {
    public TextMeshProUGUI Bonjour;
    public string UserName = "Admin"; // remplacer par le pseudo

    // Use this for initialization
    void Start () {
        Bonjour.text = "Bonjour " + UserName;
    }
	
	// Update is called once per frame
	void Update () {
        Bonjour.text = "Bonjour " + UserName;
    }
}
