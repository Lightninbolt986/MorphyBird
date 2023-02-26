using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class food : MonoBehaviour
{
    public MoveSnakeHead shead;
    // Start is called before the first frame update
    private void randpos()
    {
        float y = Random.Range(-4.24999999f, 4.24999999f);
        float x = Random.Range(-7.74999999f, 7.74999999f);
        y = Mathf.Round(y * 2) / 2;
        x = Mathf.Round(x * 2) / 2;
        foreach (Transform t in shead.segments)
        {
            if(t.position == new Vector3(x, y, 0))
            {
                randpos();
                return;
            }
        }
        transform.position = new Vector3(x, y, 0);
    }
    private void Start()
    {
        randpos();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            randpos();
        }
    }
}
