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
    public static float timeLeft = 30.0f;
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
            if (fireActive == true && timeLeftFire >= 5)
            {
                ClickOnFire.numberClickPlus += 10; 
                timeLeft = Random.Range(20.0f, 40.0f);
                chanceFire += 1;
                timeLeftFire = 0.0f;
                fireActive = false;
            }
        }
    }

    IEnumerator StartFire()
    {
        if (fireActive == false)
        {
            ClickOnFire.numberClick = 10 + ClickOnFire.numberClickPlus;
            textBox.GetComponent<Text>().text = "Hurry ! Turn off the heat. " + ClickOnFire.numberClick + " clicks remaining.";
            fireActive = true;
            clickButton.SetActive(true);
            statusBox.GetComponent<Text>().text = "Eteignez le feu sinon vous risquez de perdre de l'argent";
        }
        yield return new WaitForSeconds(1);
    }
}
