using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton() {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    // Update is called once per frame
    public void StartGame() {
        SceneManager.LoadScene("BaseScene");
    }
    
}
