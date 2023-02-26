using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die : MonoBehaviour
{
    public GameObject particle;
    public GameObject restarter;
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
            Instantiate(restarter);
        }
    }
}
