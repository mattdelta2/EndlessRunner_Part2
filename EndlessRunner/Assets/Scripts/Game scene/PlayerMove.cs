using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed =10;
    public float jumpForce =7;

    public float leftRightSpeed = 4;

    public bool isJumping =false;
    public bool ComingDown = false;
    

    public GameObject PlayerObject;

    static public bool canMove = true;





    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (canMove == true)
        {

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {

                if (this.gameObject.transform.position.x > LevelBoundry.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }

            }


            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundry.rightSide)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
                }
            }

            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                if(isJumping == false) 
                {
                    isJumping =true;
                    PlayerObject.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequence());
                }
                
            }
        }



        if(isJumping == true)
        {
            if(ComingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * jumpForce, Space.World);
            }

            if (ComingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -jumpForce, Space.World);
            }
        }

        
    }


    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);

        ComingDown = true;

        yield return new WaitForSeconds(0.45f);


        isJumping = false;
        ComingDown=false;

        PlayerObject.GetComponent<Animator>().Play("Standard Run");
    }

}
