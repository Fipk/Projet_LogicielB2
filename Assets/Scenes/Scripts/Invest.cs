using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Invest : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;

    public void ClickTheButton () {

        if (GlobalVariables.Money == 0) {
            statusBox.GetComponent<Text>().text = "Pas assez d'argent.";
            statusBox.GetComponent<Animation>().Play("Status");
        }
        else {
            GlobalVariables.Money -= 1;
            MainButton.clickValue += 1;
        }
    }
    // Start is called before the first frame update


    // Update is called once per frame
    
}
