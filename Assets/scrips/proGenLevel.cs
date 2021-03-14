using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proGenLevel : MonoBehaviour
{

    float nextMil = 100;
    float CurrDrawPos = 0;
    public GameObject preF;
    float inc = 0.2f;

    //float 
    // Start is called before the first frame update
    void Start()
    {
        CurrDrawPos = 5;
        nextMil = CurrDrawPos;
        for (int i =0; i<100; i++)
        {
            GameObject instance = (GameObject)Instantiate(preF, new Vector3(CurrDrawPos, 0, 0), new Quaternion());
            CurrDrawPos += inc;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (nextMil <= transform.position.x)
        { 
            nextMil = CurrDrawPos;
            for (int i = 0; i < 100; i++)
            {
                GameObject instance = (GameObject)Instantiate(preF, new Vector3(CurrDrawPos, 0, 0), new Quaternion());
                CurrDrawPos += inc;
            }
        }   
    }
}
