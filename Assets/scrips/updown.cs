using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour
{
    float posX = 0, posY = 0;
    // Start is called before the first frame update

    public float orgSize;
    public float zScale;

    //testing 
    bool doChange = false;


    void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(0, 1 * Time.deltaTime, 0));
        posY = transform.position.y;


        if (Input.GetMouseButtonDown(0))
        {
            doChange = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            doChange = false;
        }



        if (doChange)
        {
            Vector3 mouseP = Input.mousePosition;
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(mouseP);
            mousePos.z = 0;
            //Debug.Log(Touchpos);
            if (mousePos.x > posX - 0.2 && mousePos.x < posX + 0.2)
            {
                mousePos.x = posX;
                if (mousePos.y >= 9)
                    mousePos.y = 9;
                if (mousePos.y <= -1)
                    mousePos.y = -1;
                transform.position = mousePos;
            }
            
        }


        if (Input.touchCount > 0)
        {
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
