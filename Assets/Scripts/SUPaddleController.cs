using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SUPaddleController : MonoBehaviour
{
    public Collider2D ballColl;
    public BallController ball;
    public Collider2D LeftPaddle;
    public Collider2D RightPaddle;
    public PowerUpManager manager;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision == ballColl){
            if(ball.isLeft){
                LeftPaddle.GetComponent<PaddleController>().ActivateSUPaddle();
                manager.RemovePowerUp(gameObject);
            } else {
                RightPaddle.GetComponent<PaddleController>().ActivateSUPaddle();
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
