using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plat_followMainChar : MonoBehaviour
{

    public GameObject player;

    public float ypos = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        playerPos.z = 1;
        playerPos.y = ypos;
        transform.position = playerPos;
    }
}
