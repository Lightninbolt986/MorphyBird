using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class makepipe : MonoBehaviour
{
    public GameObject[] pipes;
    public GameObject platformerPipe;
    public GameObject snakePipe;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Pipe", 1f, 5f);
    }

    void Pipe()
    {
        //TODO: APP helps find values for exact spawn
        //H > 5
        float h = NextFloat(3f, 4);
        float x = NextFloat(-7.5f, 0.5f-h);
        
        Instantiate(pipes[0], new Vector2(12,x), Quaternion.Euler(0, 0, 0));
        Instantiate(pipes[1], new Vector2(12,x+7+h), Quaternion.Euler(0, 0, 0));

        bool special = NextFloat(0, 10) < 1;
        if (special)
        {
            if (NextFloat(0, 1) > 0.5)
            {
                Instantiate(platformerPipe, new Vector3(12, 0, 0), Quaternion.Euler(0, 0, 0));
            }
            else
            {
                Instantiate(snakePipe, new Vector3(12, 0, 0), Quaternion.Euler(0, 0, 0));
            }
        }
    }
    static float NextFloat(float min, float max)
    {
        System.Random random = new System.Random();
        double val = (random.NextDouble() * (max - min) + min);
        return (float)val;
    }

}
