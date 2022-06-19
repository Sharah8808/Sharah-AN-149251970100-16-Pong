using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey, downKey;
    private Rigidbody2D rig;

    private float timer;
    private bool isPU;

    private Vector2 resetScale;
    private int resetSpeed;

    private void Start(){
        rig = GetComponent<Rigidbody2D>();

        resetScale = transform.localScale;
        resetSpeed = speed;
        isPU = false;
    }

    private void Update(){
        MoveObject(GetInput());
        Debug.Log("Paddle speed : " + speed);

        if(isPU){
            // Debug.Log("TIMERRR NOOO");
            timer += Time.deltaTime;
            if(timer > 4){
                // Debug.Log("udh 5 detik?");
                transform.localScale = new Vector2(resetScale.x, resetScale.y);
                speed = resetSpeed;
                timer = 0;
                isPU = false;
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
        transform.localScale = new Vector2(-transform.localScale.x, (transform.localScale.y + 1));
        speed *= 2;
    }
}
