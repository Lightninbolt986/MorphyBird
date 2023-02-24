using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public float x;
    public float y;
    // Start is called before the first frame update
    private void randpos()
    {
        y = Random.Range(-4.24999999f, 4.24999999f);
        x = Random.Range(-7.74999999f, 7.74999999f);
        y = Mathf.Round(y * 2) / 2;
        x = Mathf.Round(x * 2) / 2;
        transform.position = new Vector3(x, y, 0);
    }
    private void Start()
    {
        Time.timeScale= 1f;

    }
    private void FixedUpdate()
    {
        randpos();
    }
}
