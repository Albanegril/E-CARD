using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AffichageCompte : MonoBehaviour {
    public TextMeshProUGUI Bonjour;
    public string UserName = "Admin";

    public void SetBonjour()
    {
        Bonjour.text = "Bonjour " + UserName;
    }
        


}
