// FlightController.cs 
// CENG 454 – HW1: Sky-High Prototype 
// Author: Tunahan Turgut | Student ID: 210444025 
 
using UnityEngine; 
//TO-DO: do not forget the select gravity , I have unboxed it , find the relevant file  git add . does not work.
public class FlightController : MonoBehaviour 
{ 
    [SerializeField] private float pitchSpeed  = 45f;  // degrees/second 
    [SerializeField] private float yawSpeed    = 45f;  // degrees/second 
    [SerializeField] private float rollSpeed   = 45f;  // degrees/second 
    [SerializeField] private float thrustSpeed = 5f;   // units/second 
 
    private Rigidbody rb; // Task 3-A 
 
    void Start() 
    { 
	rb = GetComponent<Rigidbody>(); // Task 3-B
    	rb.freezeRotation = true;
    } 
 
    void Update()// or FixedUpdate() 
    { 
        HandleRotation(); 
        HandleThrust(); 
    } 
 
    private void HandleRotation() 
    { 
     // 3-C
    float pitchInput = Input.GetAxis("Vertical"); 
     // to rotate it up and down we use x-axis rather than  y-axis , I haven't exactly understood the math behind it,
     // to make  it turn  left and right  we use y-axis rathen than x-axis ???  they are reverse of each other  
    transform.Rotate(Vector3.right, -pitchInput * pitchSpeed * Time.deltaTime);

    float yawInput = Input.GetAxis("Horizontal");
    transform.Rotate(Vector3.up, yawInput * yawSpeed * Time.deltaTime);

    //rotation 
    float rollInput = 0f;
    if (Input.GetKey(KeyCode.Q)) rollInput = 1f;  // l
    else if (Input.GetKey(KeyCode.E)) rollInput = -1f;
    transform.Rotate(Vector3.forward, rollInput * rollSpeed * Time.deltaTime);   

    //according to the videos I watched , Time.deltaTime is essantial , most probably it prevents the latency and some vibrations 
    // in Unity Tutorial there is a code block for camera also that includes LateUpdate() but  I have combined camera and aircraft in a 
    // parent class and fixed the distance between aircraft and camera , In Tutorial, there are some vibrations when we do not use the 
    // LateUpdate(), but the way I have used works well, It seems that we do not need LateUpdate() 
    



   
 
    } 
 
    private void HandleThrust() 
    { 
        // TODO (Task 3-D): 
    } 
}