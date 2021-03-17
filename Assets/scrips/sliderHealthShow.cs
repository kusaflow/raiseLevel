using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderHealthShow : MonoBehaviour
{
    public health_sceneMng hlth_mngr;

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = hlth_mngr.getHealth();
    }
}
