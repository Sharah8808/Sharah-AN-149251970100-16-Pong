using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Game");
    }

    // public void BackToMenu(){
    //     SceneManager.LoadScene("Main Menu");
    // }

    public void Credit(){
        SceneManager.LoadScene("Credit");
        // Debug.Log("Created By Sharah A.N-  149251970100-16");
    }

    public void CreditToMenu(){
        SceneManager.LoadScene("Main Menu");
    }
}
