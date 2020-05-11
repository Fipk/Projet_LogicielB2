using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalInvest : MonoBehaviour
{
    public static int Invest;
    public GameObject InvestDisplay;
    public int InternalInvest;

    // Update is called once per frame
    void Update()
    {
        InternalInvest = Invest;
        InvestDisplay.GetComponent<Text>().text = "Invest: " + InternalInvest;
    }
}
