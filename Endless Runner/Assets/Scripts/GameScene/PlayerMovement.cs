
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    bool isAlive = true;

    public float speed = 5;

    public Rigidbody rb;
    public GameObject player;

    float horizontalInput;

    public float horizontalMultiplier = 2;

    public float speedIncreasePerPoint = 0.1f;

    public  float JumpForce = 10f;
    [SerializeField] LayerMask groundMask;

    public GameObject EndScene;

    [SerializeField] GameManager gameManager;

    public Text score;

    public bool isJumping = false;
    public bool comingDown = false;






    private void FixedUpdate()
    {

        if (!isAlive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);

        
    }

    void Start()
    {
        Time.timeScale = 1f;
        
    }




    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space))
        {

            Jump();




            /*
            if (isJumping == false)
            {
                isJumping = true;
                player.GetComponent<Animator>().Play("Jump");

               // StartCoroutine(jumpSequence());
                float height = GetComponent<Collider>().bounds.size.y;
                rb.AddForce(Vector3.up * JumpForce);
            }*/
            

        }

        /*if(isJumping == true) 
        {
            if(comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * JumpForce, Space.World);
            }
            if (comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -JumpForce, Space.World);
            }


        }*/
        
    }


    /*IEnumerator jumpSequence()
    {
        yield return new WaitForSeconds(0.45f);

        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;

        comingDown = false;

        player.GetComponent<Animator>().Play("Standard Run");


    }*/

    public void Die()
    {
        isAlive = false;
        Time.timeScale = 0f;

        EndScene.SetActive(true);
        score.text = "You're Score Was: " + gameManager.score.ToString();


        

    }

    void Jump()
    {
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundMask);


        rb.AddForce(Vector3.up * JumpForce);

    }






    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1f;

    }

}
