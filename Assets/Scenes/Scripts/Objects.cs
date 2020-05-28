using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public static bool isActive = false;
    public static int surplusClick;
    public static int valueObject = 100;
    public static float timeLeft = 5f;

    

    // Update is called once per frame
    void Update()
    {
        fakeText.GetComponent<Text>().text = "Bonus click € " + valueObject;
        realText.GetComponent<Text>().text = "Bonus click € " + valueObject;

        if (isActive == true)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 1)
            {
                timeLeft = 5f;
                surplusClick = 0;
                valueObject += 50;
                isActive = false;
            }
        }
        if (GlobalVariables.Money >= valueObject && isActive == false && timeLeft == 5)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
    }

    public void Activation()
    {
        GlobalVariables.Money -= valueObject;
        isActive = true;
        surplusClick = Mathf.RoundToInt(MainButton.clickValue * 0.10f);
    }
}
