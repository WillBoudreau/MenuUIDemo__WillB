using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBehaviour : MonoBehaviour
{
    public Slider rSlider;
    public Slider gSlider;
    public Slider bSlider;
    public Slider aSlider;
    public float sliderValue;
    public Image sliderImage;
    // Start is called before the first frame update
    void Start()
    {
        rSlider.value = 1;
        gSlider.value = 1;
        bSlider.value = 1;
        aSlider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(rSlider.value);
        sliderImage.color = new Color(rSlider.value,gSlider.value,bSlider.value,aSlider.value);
    }
}
