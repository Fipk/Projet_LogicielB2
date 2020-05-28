using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public GameObject saveText;

    void Start()
    {
        saveText.GetComponent<Text>().text = "Save.";
    }

    public static void SetBool(string key, bool state)
    {
        PlayerPrefs.SetInt(key, state ? 1 : 0);
    }

    public void SaveTheGame()
    {
        PlayerPrefs.SetInt("MakiFactory", GlobalMoney.numberOfMoney);
        PlayerPrefs.SetInt("MakiPerSecond", GlobalMoney.moneyPerSecond);
        PlayerPrefs.SetInt("MakiPrice", GlobalMoney.moneyValue);
        SetBool("MakiActivate", Purchase.activate1);

        PlayerPrefs.SetInt("SushiFactory", GlobalMoney2.numberOfMoney);
        PlayerPrefs.SetInt("SushiPerSecond", GlobalMoney2.moneyPerSecond);
        PlayerPrefs.SetInt("SushiPrice", GlobalMoney2.moneyValue);
        SetBool("SushiActivate", Purchase.activate2);

        PlayerPrefs.SetInt("SavedMoney", GlobalVariables.Money);
        PlayerPrefs.SetInt("ClickValue", MainButton.clickValue);
        PlayerPrefs.SetInt("ClientValue", GlobalInvest.Invest);
        PlayerPrefs.SetInt("ClickPrice", GlobalInvest.clickCost);
        PlayerPrefs.SetInt("ClickNumber", ClickOnFire.numberClick);
    }
}
