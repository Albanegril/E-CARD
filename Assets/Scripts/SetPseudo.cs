using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetPseudo : MonoBehaviour {
    public TextMeshProUGUI Pseudo;
    public string UserPseudo = "Admin"; // remplacer par le pseudo

    // Use this for initialization
    void Start () {
        Pseudo.text = "     Pseudo : " + UserPseudo;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
