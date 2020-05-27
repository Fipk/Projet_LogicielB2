using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
{
    public GameObject statusBox;
    public float moneyCheck;
    public int chance;
    public bool problemActive = false;
    public int moneyLoss;

    // Update is called once per frame
    void Update()
    {
        moneyCheck = GlobalVariables.Money / 1000;
        if (problemActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster()
    {
        problemActive = true;
        chance = Random.Range(1, 5) + RandomEvent.chanceFire;
        if (moneyCheck >= chance)
        {
            moneyLoss = Mathf.RoundToInt(GlobalVariables.Money * 0.20f);
            statusBox.GetComponent<Text>().text = "You lost " + moneyLoss + " money in a fire.";
            GlobalVariables.Money -= moneyLoss;
            yield return new WaitForSeconds(1);
            statusBox.GetComponent<Animation>().Play("Status");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        problemActive = false;
    }
}
