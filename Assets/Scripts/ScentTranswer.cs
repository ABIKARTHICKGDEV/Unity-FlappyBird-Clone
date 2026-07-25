using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScentTranswer : MonoBehaviour
{

    public void LoadDayScene()
    {
        if (Time.timeScale == 0f) { Time.timeScale = 1f; }
        SceneManager.LoadScene(1);
    }
    public void LoadNightScene()
    {
        if (Time.timeScale == 0f) { Time.timeScale = 1f; }
        SceneManager.LoadScene(2);
    }

}
