using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_sceneMng : MonoBehaviour
{

    float health;

    
    // Start is called before the first frame update
    void Start()
    {
        health = 500;
        
    }

    // Update is called once per frame
    void Update()
    {
        health -= 10 * Time.deltaTime;   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    public float getHealth()
    {
        return health;
    }

    public void setHealth(float h)
    {
        health = h;
    }
}
