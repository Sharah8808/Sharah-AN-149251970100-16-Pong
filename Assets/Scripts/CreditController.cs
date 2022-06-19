using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditController : MonoBehaviour
{
    public void CreditToMenu(){
        SceneManager.LoadScene("Main Menu");
    }
}
