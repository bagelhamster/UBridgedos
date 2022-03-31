using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject Win, MainMenu2, OverBudget,Retry;
    // Start is called before the first frame update
    void Start()
    {
        Win.gameObject.SetActive(false);
        MainMenu2.gameObject.SetActive(false);
        OverBudget.gameObject.SetActive(false);
        Retry.gameObject.SetActive(false);
        Time.timeScale = 1;

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player"&& Budget.Budget1<ScoreScript.scoreValue)
        {
            OverBudget.gameObject.SetActive(true);
            MainMenu2.gameObject.SetActive(true);
            Retry.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.tag == "Player" &&   Budget.Budget1>= ScoreScript.scoreValue)
        {
            Win.gameObject.SetActive(true);
            MainMenu2.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }



}
