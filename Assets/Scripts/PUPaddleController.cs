using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleController : MonoBehaviour
{
    public Collider2D ballColl;
    public BallController ball;
    public Collider2D LeftPaddle;
    public Collider2D RightPaddle;
    public PowerUpManager manager;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision == ballColl){
            if(ball.isLeft){
                LeftPaddle.GetComponent<PaddleController>().ActivatePUPaddle();
                manager.RemovePowerUp(gameObject);
            } else {
                RightPaddle.GetComponent<PaddleController>().ActivatePUPaddle();
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
