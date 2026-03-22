// FlightController.cs 
// CENG 454 – HW1: Sky-High Prototype 
// Author: Tunahan Turgut | Student ID: 210444025 
 
using UnityEngine; 
 
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
        // TODO (Task 3-C): 
        // Pitch   
        // Roll    
 
    } 
 
    private void HandleThrust() 
    { 
        // TODO (Task 3-D): 
    } 
}