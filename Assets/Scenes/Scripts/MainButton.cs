using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButton : MonoBehaviour
{
    public GameObject textBox;
    public static int clickValue = 1;

    public void ClickTheButton () {
        GlobalVariables.Money += clickValue + Objects.surplusClick;

    }
    // Start is called before the first frame update


    // Update is called once per frame
    
}
