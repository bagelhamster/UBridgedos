using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level1 : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Level1");
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("Level2");
    }

}
