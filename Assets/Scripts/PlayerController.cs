using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField] 
    public float speed = 5.0f;
    [SerializeField] 
    public float jumpHeight = 10.0f;
    public float gravity = 1.0f;
    public float yVelocity = 0.0f;

    private int desiredLane = 1;//0:left, 1:middle, 2:right
    public float laneDistance = 2.5f;//The distance between tow lanes
    public float maxSpeed;
    public Animator animator;
    private int time = 0;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!PlayerManager.isGameStarted )
            return;
        ;
        animator.SetBool("isGameStarted", true);
        if(speed < maxSpeed)
        {
            speed += 0.1f * Time.deltaTime;
        }
        if (PlayerManager.isGameStarted && !PlayerManager.gameOver && !PlayerManager.isGamePaused){
            time +=1;
            if (time > 100){
                PlayerManager.distance +=1;
                time = 0;
        }
        }
        
        Vector3 direction = new Vector3(0, 0, 1);
        Vector3 velocity = direction * speed;

        if (controller.isGrounded == true){
            if(SwipeManager.swipeUp)
            {
                //animator.SetBool("isGrounded", false);
                
                yVelocity = jumpHeight;
                FindObjectOfType<AudioManager>().PlaySound("Jump");
            }
        }
        else
        {
            //animator.SetBool("isGrounded", true);
            yVelocity -= gravity;
        }
        
        velocity.y = yVelocity;

        if (SwipeManager.swipeRight)
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
        }
        if (SwipeManager.swipeLeft)
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;
        }

        //Calculate where we should be in the future
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (desiredLane == 0)
            targetPosition += Vector3.left * laneDistance;
        else if (desiredLane == 2)
            targetPosition += Vector3.right * laneDistance;

        //transform.position = targetPosition;
        if (transform.position != targetPosition)
        {
            Vector3 diff = targetPosition - transform.position;
            Vector3 moveDir = diff.normalized * 30 * Time.deltaTime;
            if (moveDir.sqrMagnitude < diff.magnitude)
                controller.Move(moveDir);
            else
                controller.Move(diff);
        }
        controller.Move(velocity * Time.deltaTime);
    

    }

    private void FixedUpdate() {



    }

    
    private void Jump()
    {

    }
 

    private void OnControllerColliderHit(ControllerColliderHit hit) {
        if(hit.transform.tag=="Obstacle")
        {
            
            PlayerManager.gameOver = true;
            FindObjectOfType<AudioManager>().StopSound("LevelTheme");
            FindObjectOfType<AudioManager>().PlaySound("GameOver");
        }
    }
}
