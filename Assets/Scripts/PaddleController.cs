using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey, downKey;
    private Rigidbody2D rig;

    private float timerPU;
    private float timerSU;
    private bool isPU;
    private bool isSU;

    private Vector2 resetScale;
    private int resetSpeed;

    private void Start(){
        rig = GetComponent<Rigidbody2D>();

        resetScale = transform.localScale;
        resetSpeed = speed;
        isPU = false;
        isSU = false;
    }

    private void Update(){
        MoveObject(GetInput());
        Debug.Log("Paddle speed : " + speed);

        if(isPU){
            // Debug.Log("TIMERPURR NOOO");
            timerPU += Time.deltaTime;
            if(timerPU > 4){
                // Debug.Log("udh 5 detik?");
                speed = resetSpeed;
                timerPU = 0;
                isPU = false;
                
            }
        } else if(isSU){
            timerSU += Time.deltaTime;
            if(timerSU > 4){
                // Debug.Log("udh 5 detik?");
                transform.localScale = new Vector2(resetScale.x, resetScale.y);
                timerSU = 0;
                isSU = false;
            }
        }
    }
    
    private Vector2 GetInput(){
        if (Input.GetKey(upKey)){
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey)){
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement){
        rig.velocity = movement;
    }

    public void ActivatePUPaddle(){
        isPU = true;
        speed *= 2;
    }

    public void ActivateSUPaddle(){
        isSU = true;
        transform.localScale = new Vector2(-transform.localScale.x, (transform.localScale.y + 1));
    }
}
