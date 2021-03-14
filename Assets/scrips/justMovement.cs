using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(5, 1.5f));
    }

}
