using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addHealth : MonoBehaviour
{
    //public health_sceneMng healthScene;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("mainP"))
        {
            health_sceneMng health_Scene = collision.GetComponent<health_sceneMng>();
            health_Scene.setHealth(500);
            Destroy(obj);
        }
    }

}
