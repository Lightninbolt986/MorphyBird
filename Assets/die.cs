using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    public GameObject particle;
    // Start is called before the first frame update
    private void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            Destroy(gameObject);
            Instantiate(particle, transform.position, Quaternion.Euler(0, 0, 0));
            
        }
    }
}
