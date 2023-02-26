using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSnakeHead : MonoBehaviour
{
    public Vector2 dir = Vector2.right;
    public float gox;
    public float goy;
    public List<Transform> segments;
    public Transform bodyPrefab;
    public GameObject resetter;
    public int points = 0;
    public TMP_Text tmp;
    private void Update()
    {
        if (segments.Count > 1)
        {
            if (Input.GetKeyDown(KeyCode.W) && (transform.position - segments[1].position).y != -0.5) dir = Vector2.up;
            if (Input.GetKeyDown(KeyCode.S) && (transform.position - segments[1].position).y != 0.5) dir = Vector2.down;
            if (Input.GetKeyDown(KeyCode.A) && (transform.position - segments[1].position).x != 0.5) dir = Vector2.left;
            if (Input.GetKeyDown(KeyCode.D) && (transform.position - segments[1].position).x != -0.5) dir = Vector2.right;

        } else
        {
            if (Input.GetKeyDown(KeyCode.W)) dir = Vector2.up;
            if (Input.GetKeyDown(KeyCode.S)) dir = Vector2.down;
            if (Input.GetKeyDown(KeyCode.A)) dir = Vector2.left;
            if (Input.GetKeyDown(KeyCode.D)) dir = Vector2.right;

        }
    }
    private void FixedUpdate()
    {
        for(int i = segments.Count-1; i > 0; i--)
        {
            segments[i].position = segments[i-1].position;
        }

        gox = Mathf.Round(this.transform.position.x * 2) / 2 + dir.x / 2;
        goy = Mathf.Round(this.transform.position.y * 2) / 2 + dir.y / 2;
        this.transform.position = new Vector3(Mathf.Round(this.transform.position.x * 2) / 2 + dir.x / 2, Mathf.Round(this.transform.position.y * 2) / 2 + dir.y / 2, 0.0f);

    }
    private void Start()
    {
        Time.timeScale = 0.1f;
        segments = new List<Transform>
        {
            this.transform
        };
    }
    private void grow()
    {
        Transform seg = Instantiate(bodyPrefab.gameObject, segments[segments.Count - 1].position, Quaternion.Euler(0, 0, 0)).transform;
        segments.Add(seg);
        seg.position = segments[segments.Count-1].position;
        points++;
        tmp.text = points.ToString();
        if (points>= 10) {
            //Back to flappy
           Time.timeScale = 1f;
           SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }

    }
    private void resetState()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("score", 0);
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Food")
        {
            grow();
        }
        if (collision.tag == "Obstacle")
        {
            resetState();
        }
    }
}