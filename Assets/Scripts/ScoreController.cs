using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text lftScore;
    public Text rgtScore;

    public ScoreManager manager;

    private void Update(){
        lftScore.text = manager.leftScore.ToString();
        rgtScore.text = manager.rightScore.ToString();
    }
}
