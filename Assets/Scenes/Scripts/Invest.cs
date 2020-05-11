using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invest : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton () {
        GlobalVariables.Money -= 1;
        GlobalInvest.Invest += 1;
    }
    // Start is called before the first frame update


    // Update is called once per frame
    
}
