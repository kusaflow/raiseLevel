using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMainPlayer : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        playerPos.z = -1;
        playerPos.x += 12;
        playerPos.y += 2;
        transform.position = playerPos;
    }
}
