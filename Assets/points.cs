using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class points : MonoBehaviour
{
    public int pointsCount;
    public TMP_Text tmp;
    // Start is called before the first frame update
    void Start()
    {
        tmp.text = PlayerPrefs.GetInt("score").ToString();
        pointsCount = PlayerPrefs.GetInt("score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8) 
        {
            pointsCount++;
            tmp.text = pointsCount.ToString();
            PlayerPrefs.SetInt("score", pointsCount);
        }
        if (collision.gameObject.layer == 9)
        {
            SceneManager.LoadScene("platformer",LoadSceneMode.Single);
        }
        else if (collision.gameObject.layer == 12)
        {
            SceneManager.LoadScene("Snek", LoadSceneMode.Single);
        }
    }
}
