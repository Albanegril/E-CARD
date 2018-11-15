using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EditButtonCard : MonoBehaviour {
    public TMP_InputField ChampsSaisie;
    public TextMeshProUGUI TextBox;
    public Button Icone;

    // Use this for initialization
    void Start () {
        
        TextBox = new TextMeshProUGUI();
    }

    void Update()
    {

                
            switch (Icone.name)
            {
                case "Button_Telephone":
                   
                    break;

                case "Button_Mail":
                    
                    break;

                case "Button_Twitter":
                    
                    break;

                case "Button_Facebook":
                    TextBox.text = "Saisisez votre nom fb ou un lien";
                    TextBox.text = ChampsSaisie.text;
                    break;

                default:
                    break;
            }
    }

}
