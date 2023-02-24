using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveSnakeHead : MonoBehaviour
{
    public Vector2 dir = Vector2.right;
    public float gox;
    public float goy;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) dir = Vector2.up;
        if(Input.GetKeyDown(KeyCode.S)) dir = Vector2.down;
        if (Input.GetKeyDown(KeyCode.A)) dir = Vector2.left;
        if (Input.GetKeyDown(KeyCode.D)) dir = Vector2.right;
    }
    private void FixedUpdate()
    {
        gox = Mathf.Round(this.transform.position.x * 2) / 2 + dir.x / 2;
        goy = Mathf.Round(this.transform.position.y * 2) / 2 + dir.y / 2;
        this.transform.position = new Vector3(Mathf.Round(this.transform.position.x*2)/2 + dir.x/2, Mathf.Round(this.transform.position.y*2)/2 + dir.y/2, 0.0f);
    }
    private void Start()
    {
        Time.timeScale = 0.04f;
    }
}
