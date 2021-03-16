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
        if (rb.velocity.x >= 20)
            rb.velocity = new Vector2(20, rb.velocity.y);
       
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(0, 2f));
        rb.angularVelocity = -1000;
        //rb.AddTorque(-7);
    }

}
