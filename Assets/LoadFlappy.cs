using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFlappy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
