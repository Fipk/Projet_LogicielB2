using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomEvent : MonoBehaviour
{

    public GameObject statusBox;
    public GameObject textBox;
    public GameObject clickButton;
    public static bool fireActive = false;
    public static float timeLeft = 10.0f;
    public static float timeLeftFire = 0f;
    public static int chanceFire = 0;

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0)
        {
            StartCoroutine(StartFire());
        }
        else
        {
            clickButton.SetActive(false);
        }
        if (fireActive == true) 
        {
            timeLeftFire += Time.deltaTime;
            if (fireActive == true && timeLeftFire >= 45)
            {
                ClickOnFire.numberClickPlus += 10; 
                timeLeft = 10.0f;
                chanceFire += 1;
                timeLeftFire = 0.0f;
                fireActive = false;
                ClickOnFire.numberClick = 10 + ClickOnFire.numberClickPlus;
            }
        }
    }

    IEnumerator StartFire()
    {
        if (fireActive == false)
        {
            ClickOnFire.numberClick = 10;
            textBox.GetComponent<Text>().text = "Il vous reste " + ClickOnFire.numberClick + " clicks à faire";
            fireActive = true;
            clickButton.SetActive(true);
            statusBox.GetComponent<Text>().text = "Eteignez le feu sinon vous risquez de perdre de l'argent";
        }
        yield return new WaitForSeconds(1);
    }
}
