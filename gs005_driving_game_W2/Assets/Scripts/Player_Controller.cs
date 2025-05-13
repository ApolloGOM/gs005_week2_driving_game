using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed = 6;
    private Rigidbody rb;
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
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //Method 3, using the physics engine to move our object forward
        //rb.AddForce(Vector3.forward * speed);

        //Method 4, using the physics engine to move our object forward
        //rb.AddRelativeForce(Vector3.forward * speed);

    }

}
