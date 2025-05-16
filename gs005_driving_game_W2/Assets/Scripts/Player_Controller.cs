using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed = 6;
    private Rigidbody rb;
    float horizontalInput, verticalInput;
    public float turnSpeed;

    public int playerIndex; //if this value is 1, it will be player 1. If this value is set as 2, it will be player 2.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Method 1, using translation for movement
        //transform.Translate(0,0,speed * Time.deltatime);

        //Method 2, using translation for movement but while using short forms
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //Method 3, using the physics engine to move our object forward
        //rb.AddForce(Vector3.forward * speed, Time.deltaTime * verticalInput);

        //Method 4, using the physics engine to move our object forward
        //rb.AddRelativeForce(Vector3.forward * speed * Time.deltaTime * verticalInput);


        //Movement mechanics

        //Recording Player Inputs

        horizontalInput = Input.GetAxis("Horizontal" + playerIndex); //Left, Right, A, D, Analogue Stick Left/Right
        verticalInput = Input.GetAxis("Vertical" + playerIndex); //Up, Drown, W, S, Analogue Stick Up/Down

        //If you change Translate to rotate and Vector3.Right to up it will turn instead of shift
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

    }

}
