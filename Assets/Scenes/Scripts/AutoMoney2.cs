using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoney2 : MonoBehaviour
{
    
    public bool CreateMoney = false;
    public static int MoneyIncrease = 10;
    public int InternalIncrease;


    // Update is called once per frame
    void Update()
    {
        MoneyIncrease = GlobalMoney2.moneyPerSecond;
        InternalIncrease = MoneyIncrease;
        if (CreateMoney == false)
        {
            CreateMoney = true;
            StartCoroutine(CreateTheMoney());
        }
    }

    IEnumerator CreateTheMoney ()
    {
        GlobalVariables.Money += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreateMoney = false;
    }
}
