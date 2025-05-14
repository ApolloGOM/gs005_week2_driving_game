using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraOffset;
    private bool isFirstPerson;
    public Vector3 FPcameraOffset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Method 1 hard coding the offset
        //transform.position = player.position + new Vector3(0,10,-5);
    }


    private void LateUpdate()
    {
        //Method 2, using a variable for the offset
        transform.position = player.position + cameraOffset;

        if (Input.GetKeyDown(KeyCode.P))

            if (isFirstPerson == false)
        {     
            
            cameraOffset = FPcameraOffset;
            isFirstPerson = true;
        }
        else 
        {
            cameraOffset = new Vector3(10, 6, 0);
            isFirstPerson = false;
        }
        //Method 3 to be able to use a second button to activate the camera movement
       // if (Input.GetKeyDown.O)
        //{ 
         //   cameraOffset = new Vector3(0,0,0)
       // }

    }

}
