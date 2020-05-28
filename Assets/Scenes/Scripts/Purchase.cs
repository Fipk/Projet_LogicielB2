using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Purchase : MonoBehaviour
{
    public GameObject AutoMoney;
    public GameObject AutoMoney2;
    public static bool activate1;
    public static bool activate2;
    public GameObject textBar;

    void Update()
    {
        if (activate1 == true)
        {
            AutoMoney.SetActive(true);
        }

        if (activate2 == true)
        {
            AutoMoney2.SetActive(true);
        }
    }
    public void StartAutoMoney() {
        activate1 = true;
        AutoMoney.SetActive(true);
        GlobalVariables.Money -= GlobalMoney.moneyValue;
        GlobalMoney.moneyValue = Mathf.RoundToInt(GlobalMoney.moneyValue * 1.35f);
        GlobalMoney.turnOffButton = true;
        GlobalMoney.numberOfMoney += 1;
        GlobalMoney.moneyPerSecond += 1;
    }

    public void StartAutoMoney2() {
        activate2 = true;
        AutoMoney2.SetActive(true);
        GlobalVariables.Money -= GlobalMoney2.moneyValue;
        GlobalMoney2.moneyValue = Mathf.RoundToInt(GlobalMoney2.moneyValue * 1.50f);
        GlobalMoney2.turnOffButton = true;
        GlobalMoney2.numberOfMoney += 1;
        GlobalMoney2.moneyPerSecond += 10;
    }

    public void ClickPlus() {
        if (GlobalVariables.Money >= GlobalInvest.clickCost)
        {
            GlobalVariables.Money -= GlobalInvest.clickCost;
            MainButton.clickValue += 1;
            GlobalInvest.Invest += 1;
            GlobalInvest.clickCost = Mathf.RoundToInt(GlobalInvest.clickCost * 1.37f);
            textBar.GetComponent<Text>().text = "Vous avez investit dans 1 click.";
        } 
        else {
            textBar.GetComponent<Text>().text = "Pas assez d'argent.";

        }
    }
}
