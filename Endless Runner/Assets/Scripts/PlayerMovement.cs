
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    bool isAlive = true;

    public float speed = 5;

    public Rigidbody rb;

    float horizontalInput;

    public float horizontalMultiplier = 2;

    public float speedIncreasePerPoint = 0.1f;

    [SerializeField] float JumpForce = 400;
    [SerializeField] LayerMask groundMask;



    private void FixedUpdate()
    {

        if (!isAlive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);

        
    }




    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();

        }
        
    }

    public void Die()
    {
        isAlive = false;


        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


    void Jump()
    {
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundMask);



        rb.AddForce(Vector3.up * JumpForce);
    }
}
