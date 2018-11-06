using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetJeSuis : MonoBehaviour {
    public TextMeshProUGUI JeSuis;
    public List<string> UserTags = new List<string>(); // remplacer par le list tags 
    public string Tags = null;

    // Use this for initialization
    void Start () {
        UserTags.Add("Etudiant");
        UserTags.Add("Informatique");
        UserTags.Add("Ensim");

        foreach(string tag in UserTags)
        {
            Tags += tag + " / ";
        }
        Debug.Log("string = " + Tags);

        JeSuis.text = "     Je suis : " + Tags;

    }
	
	// Update is called once per frame
	void Update () {

    }
}
