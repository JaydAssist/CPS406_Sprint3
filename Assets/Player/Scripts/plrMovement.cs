using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plrMovement : MonoBehaviour
{
   
    public CharacterController controller;
    public Transform playerCamera;
    public float speed = 2f;
    public float gravity = -9.81f;
    public float jumpForce = 0.1f;
    public float lookSpeed = 2f;
    public float lookXLimit = 80f;
    public float bobbingAmount = 0.1f; // Amount of bobbing
    public float bobbingSpeed = 5f;   // Speed of bobbing

    private float xRotation = 0f;
    private Vector3 originalCameraPosition;
    private float walkCycle;
    private Vector3 velocity; // New variable to track the player's vertical velocity
    private bool isGrounded;
    private bool canLook = true;
    private bool canMove = true;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        originalCameraPosition = playerCamera.localPosition;
    }

    private void Update()
    {
        // Check if the player is grounded
        isGrounded = controller.isGrounded;

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Small negative value to keep the player grounded
        }

        
        // Movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = transform.right * horizontal + transform.forward * vertical;

        if (move.magnitude > 1f)
        {
            move.Normalize();
        }

        if(canMove){
            controller.Move(move * speed * Time.deltaTime);
        }
            

        
        

        //Sprinting

        if (Input.GetKey(KeyCode.LeftShift)){
            speed = 4f;
            bobbingSpeed = 10f;
        }
        else{
            speed = 2f;
            bobbingSpeed = 5f;
        }

        // Jumping
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity); // Calculate jump velocity
        }

        // Apply gravity
        velocity.y += gravity * Time.deltaTime; // Apply gravity over time
        controller.Move(velocity * Time.deltaTime); // Move the player vertically

        // Camera bobbing
        if (isGrounded && move.magnitude > 0)
        {
            walkCycle += Time.deltaTime * bobbingSpeed;
            float offsetY = Mathf.Sin(walkCycle) * bobbingAmount;
            playerCamera.localPosition = new Vector3(originalCameraPosition.x, originalCameraPosition.y + offsetY, originalCameraPosition.z);
        }
        else
        {
            walkCycle = 0; // Reset bobbing when not moving
            playerCamera.localPosition = originalCameraPosition; // Ensure camera is reset
        }

        if (canLook){
            // Mouse look
            float mouseX = Input.GetAxis("Mouse X") * lookSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * lookSpeed;
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -lookXLimit, lookXLimit);
            playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            transform.Rotate(Vector3.up * mouseX);
            
        }
    }


    public void DisableMovement(){
        canLook = false;
        canMove = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    public void EnableMovement(){
        canLook = true;
        canMove = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    
}
