using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownBehaviour : MonoBehaviour
{
    public TextMeshProUGUI output;
    public GameObject Cat;
    public GameObject Cat2;
    public TMP_Dropdown dropdown;
    void Start()
    {
        Cat.SetActive(false);
        Cat2.SetActive(false);
        output.text = "Where is everyone?";
    }
    //Handles the Input Data from the Drop down menu 
    public void InputData()
    {
        //NOTE: The dropdown value changes automatically when selecting different options
        if(dropdown.value == 0)
        {
            Cat.SetActive(false);
            Cat2.SetActive(false);
            output.text = "Where did everyone go?";
        }
        if(dropdown.value == 1)
        {
            Cat.SetActive(true);
            Cat2.SetActive(false);
              output.text = "WOW";
        }
           if(dropdown.value == 2)
        {   Cat2.SetActive(true);
            Cat.SetActive(false);
              output.text = "Chill like Will";
        }
    }
}
