using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int savedMoney;
    public int savedClickValue;
    public int savedClientValue;
    public int savedClickPrice;
    public int savedClickNumber;
    public bool savedMakiActivate;
    public bool savedSushiActivate;
    public int savedMakiFactory;
    public int savedMakiPerSecond;
    public int savedMakiPrice;
    public int savedSushiFactory;
    public int savedSushiPerSecond;
    public int savedSushiPrice;

    void Start()
    {
        if (MainMenu.isLoading == true)
        {
            savedMakiFactory = PlayerPrefs.GetInt("MakiFactory");
            GlobalMoney.numberOfMoney = savedMakiFactory;
            savedMakiPerSecond = PlayerPrefs.GetInt("MakiPerSecond");
            GlobalMoney.moneyPerSecond = savedMakiPerSecond;
            savedMakiPrice = PlayerPrefs.GetInt("MakiPrice");
            GlobalMoney.moneyValue = savedMakiPrice;
            savedMakiActivate = GetBool("MakiActivate");
            Purchase.activate1 = savedMakiActivate;

            savedSushiFactory = PlayerPrefs.GetInt("SushiFactory");
            GlobalMoney2.numberOfMoney = savedSushiFactory;
            savedSushiPerSecond = PlayerPrefs.GetInt("SushiPerSecond");
            GlobalMoney2.moneyPerSecond = savedSushiPerSecond;
            savedSushiPrice = PlayerPrefs.GetInt("SushiPrice");
            GlobalMoney2.moneyValue = savedSushiPrice;
            savedSushiActivate = GetBool("SushiActivate");
            Purchase.activate2 = savedSushiActivate;
            
            savedMoney = PlayerPrefs.GetInt("SavedMoney");
            GlobalVariables.Money = savedMoney;
            savedClickValue = PlayerPrefs.GetInt("ClickValue");
            MainButton.clickValue = savedClickValue;
            savedClientValue = PlayerPrefs.GetInt("ClientValue");
            GlobalInvest.Invest = savedClientValue;
            savedClickPrice = PlayerPrefs.GetInt("ClickPrice");
            GlobalInvest.clickCost = savedClickPrice;
            savedClickNumber = PlayerPrefs.GetInt("ClickNumber");
            ClickOnFire.numberClick = savedClickNumber;

        }
    }

    public static bool GetBool(string key)
     {
         int value = PlayerPrefs.GetInt(key);
 
         if (value == 1)
         {
           
            return true;
         }
 
         else
         {
            
            return false;
         }
     }
}
