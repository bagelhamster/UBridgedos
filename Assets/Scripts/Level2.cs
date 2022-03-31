using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level2 : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Level2");
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("MainMenu");
    }

}