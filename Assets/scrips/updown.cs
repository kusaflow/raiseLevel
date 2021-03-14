using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour
{
    float posX = 0, posY = 0;
    // Start is called before the first frame update

    public float orgSize;
    public float zScale;



    void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(0, 1 * Time.deltaTime, 0));

        if (Input.touchCount > 0)
        {
            posY = transform.position.y;
            Touch touch = Input.GetTouch(0);
            Vector3 Touchpos = Camera.main.ScreenToWorldPoint(touch.position);
            Touchpos.z = 0;
            //Debug.Log(Touchpos);
            if (Touchpos.x > posX - 0.5 && Touchpos.x < posX + 0.5)
            {
                Touchpos.x = posX;
                transform.position = Touchpos;
            }
            // transform.position.Set(posX, posY + 1 * Time.deltaTime, 0);
            //transform.Translate(new Vector3(0,1*Time.deltaTime, 0));


        }
        
    }
}
