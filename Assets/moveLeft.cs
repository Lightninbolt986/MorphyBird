using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class moveLeft : MonoBehaviour
{
    private Vector3 velocity;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2(-2, 0);
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -16)
        {
            Destroy(transform.gameObject);
        }
    }
}
