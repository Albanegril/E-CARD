using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EditButtonCard : MonoBehaviour {
    public TMP_InputField ChampsSaisie;
    public TextMeshProUGUI TextBox;

    // Use this for initialization
    void Start () {
        
        TextBox = new TextMeshProUGUI();
    }
	
    public void Facebook()
    {
        // set input text box active, 
        // ChampsSaisie.SetActive();
        // enter fb name or link // drag&drop link
        TextBox.text = "Saisisez votre nom fb ou un lien";
        // register link in card link DB
        // afficher la saisie
                   TextBox.text = ChampsSaisie.text;

    }



}
