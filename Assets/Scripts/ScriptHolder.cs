using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptHolder : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("MainGame", LoadSceneMode.Single);
    }

    public void MainMenu()
    {

    }

    public void Quit()
    {
        
    }

}
