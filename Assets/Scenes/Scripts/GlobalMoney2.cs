using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMoney2 : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentMoney;
    public static int moneyValue = 200;
    public static bool turnOffButton = false;
    public GameObject moneyStats;
    public static int numberOfMoney;
    public static int moneyPerSecond;

    // Update is called once per frame
    void Update()
    {
        currentMoney = GlobalVariables.Money;
        moneyStats.GetComponent<Text>().text = "Auto: " + numberOfMoney + " / " + moneyPerSecond + " Per second";
        fakeText.GetComponent<Text>().text = "Buy Money auto - € " + moneyValue;
        realText.GetComponent<Text>().text = "Buy Money auto - € " + moneyValue;
        if (currentMoney >= moneyValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
