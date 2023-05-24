using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed =3;
    public float jumpForce =5;

    public float leftRightSpeed = 4;

<<<<<<< HEAD
    private bool isJumping =false;
    private bool ComingDown = false;
    

    public GameObject PlayerObject;

=======
>>>>>>> parent of 9c7e867 (Removing run over sections)
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

            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * Time.deltaTime * jumpForce);
            }
        }
        
    }

}
