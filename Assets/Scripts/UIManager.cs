using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pausebtn, pausepanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pausegame()
    {
        Time.timeScale = 0f;
        pausepanel.SetActive(true);
        pausebtn.SetActive(false);
    }
    public void resumegame()
    {
        Time.timeScale = 1f;
        pausepanel.SetActive(false);
        pausebtn.SetActive(true);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
