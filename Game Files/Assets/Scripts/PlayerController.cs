using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce;
    private bool isGrounded;
    public bool JumpEnabled;
    public string prefabName;
    // Audio
    [SerializeField] private AudioSource jumpSFX;
    [SerializeField] private AudioSource deathSFX;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        JumpEnabled = true;
    }

    void Start()
    {
        Time.timeScale = 1;
    }

    public void Jump()
    {
        float currentSpeed = GameManager.Instance.gameSpeed;
        if(isGrounded && JumpEnabled)
            if(currentSpeed < 0f){
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpSFX.Play();
            if(currentSpeed > -10.1f)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
            
    }
    
    void OnCollisionStay(Collision coll)
    {
        isGrounded = true;
    }
    void OnCollisionExit(Collision coll)
    {
        if(isGrounded)
        {
           isGrounded = false;   
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            deathSFX.Play();
            JumpEnabled = false;
            GameManager.Instance.GameOver();
        }
    }

    public void RestoreJump()
    {
        JumpEnabled = true;
    }
}
