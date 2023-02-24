using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    private Rigidbody2D rb;
    private int force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        force = 700;
    }
    // Update is called once per frame
    void Update()
    {
        //1.5 jump
        if (Input.GetKeyDown(KeyCode.Space))
        {   
            rb.velocity = new Vector3(0, 0, 0);
            //Vector3.up is (0,1,0)
            //Force is 700
            rb.AddForce(Vector3.up * force);
        }
    }
}
