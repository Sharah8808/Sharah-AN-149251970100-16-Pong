using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rig;
    public Vector2 resetPosition;

    public bool isLeft;

    private void Start(){
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void ResetBall(){
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void ActivatePUSpeedUp(float magnitude){
        rig.velocity *= magnitude;
    }

    public void OnCollisionEnter2D(Collision2D other){
         if (other.gameObject.name == "Paddle Kiri"){
            // Debug.Log("kiirriii");
            isLeft = true;
        }
        else if((other.gameObject.name == "Paddle Kanan")){
            isLeft = false;
            // Debug.Log("kanaannn aaaaa");
        }
    }
    
}
