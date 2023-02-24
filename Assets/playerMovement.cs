using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;
    public float horizontalMove = 0f;
    public float runspeed = 40f;
    private bool jump = false;
    private bool crouch = false;
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")*runspeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;

        }


    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
}
