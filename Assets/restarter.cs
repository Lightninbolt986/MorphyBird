using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Restart", 3);

    }
    void Restart()
    {   
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("sampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
