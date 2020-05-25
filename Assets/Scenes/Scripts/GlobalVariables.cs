using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVariables : MonoBehaviour
{
    public static int Money;
    public GameObject MoneyDisplay;
    public int InternalMoney;

    // Update is called once per frame
    void Update()
    {
        InternalMoney = Money;
        MoneyDisplay.GetComponent<Text>().text = "Money: " + InternalMoney;
    }
}
