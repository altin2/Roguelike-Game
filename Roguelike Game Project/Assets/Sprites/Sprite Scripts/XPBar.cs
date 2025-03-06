using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class XPBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    void Awake(){
        slider.value = 0;
    }
    public void UpdateXPBar(float currentValue, float maxValue )
    {
        slider.value  = currentValue/maxValue;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
