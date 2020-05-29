using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOnFire : MonoBehaviour
{
    public GameObject textBox;
    public static int numberClickPlus = 0;
    public static int numberClick = 10;

    // Update is called once per frame
    void Update()
    {
        if (numberClick < 0 && RandomEvent.fireActive == true)
        {
            numberClickPlus += 1;
            RandomEvent.fireActive = false;
            RandomEvent.timeLeft = Random.Range(60.0f, 180.0f);
            RandomEvent.timeLeftFire = 0.0f;
        }
    }
    
    public void ClickOnButton () {
        textBox.GetComponent<Text>().text = numberClick + " clicks remaining.";
        numberClick -= 1;

    }
}
