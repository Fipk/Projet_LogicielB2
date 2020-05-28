using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalInvest : MonoBehaviour
{
    public static int Invest;
    public GameObject InvestDisplay;
    public GameObject investCost;
    public int InternalInvest;
    public static int clickCost = 5;

    // Update is called once per frame
    void Update()
    {
        InternalInvest = Invest;
        InvestDisplay.GetComponent<Text>().text = "Knives: " + InternalInvest;
        investCost.GetComponent<Text>().text = "Buy some knives € " + clickCost;
    }
}
