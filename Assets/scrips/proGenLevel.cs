using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proGenLevel : MonoBehaviour
{

    float nextMil = 100;
    float CurrDrawPos = 0;
    public GameObject preF;
    public GameObject PowerIncPrefab;
    float inc = 0.2f;

    Queue<GameObject> plat = new Queue<GameObject>();

    //float 
    // Start is called before the first frame update
    void Start()
    {
        CurrDrawPos = 5;
        nextMil = 70;
        for (int i =0; i<500; i++)
        {
            GameObject instance = (GameObject)Instantiate(preF, new Vector3(CurrDrawPos, 0, 0), new Quaternion());
            plat.Enqueue(instance);
            CurrDrawPos += inc;
        }
    }

    // Update is called once per frame
    void Update()
    {

       
        if (nextMil <= transform.position.x)
        {
            bool isPowerDroped = false;
            int div = 6;
            if (nextMil >= 100)
            {
                div = 5;
            }else if (nextMil >= 200)
            {
                div = 4;
            }else if (nextMil >= 300)
            {
                div = 3;
            }else if (nextMil >= 500)
            {
                div = 2;
            }

            if ((int)(Random.Range(1, 17)) % 2 == 0)
                isPowerDroped = true;

            if ((int)(Random.Range(1, 17)) % div == 0)
            {
                isPowerDroped = true;
            }




            nextMil = CurrDrawPos;
            for (int i = 0; i < 200; i++)
            {
                GameObject instance = (GameObject)Instantiate(preF, new Vector3(CurrDrawPos,0, 0), new Quaternion());
                plat.Enqueue(instance);
                Destroy(plat.Dequeue());
                CurrDrawPos += inc;

                if (i >= 40 && i<=60 && !isPowerDroped)
                {
                    int rnd = Random.Range(40,60);
                    if (rnd % 10 == 0)
                    {
                        isPowerDroped = true;
                        GameObject powerUp = (GameObject)Instantiate(PowerIncPrefab, new Vector3(CurrDrawPos, Random.Range(1,7.5f), 0), new Quaternion());
                    }
                }

            }
        }   
    }
}
