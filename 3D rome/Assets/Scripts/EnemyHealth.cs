using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Slider slider;


    void Start() {
        slider.maxValue = 100.0F;
        slider.minValue = 0F;
        slider.value = slider.maxValue;
    }

    void Update() {

        // slider.direction = Slider.Direction.RightToLeft;
        // slider.transform.LookAt(Camera.main.transform.position);

        slider.direction = Slider.Direction.LeftToRight;
        slider.transform.rotation = Camera.main.transform.rotation;
    }

    public void Hurt(float h) {
        slider.value -= h;
        if(slider.value <= 0){
            slider.value = 0;
        }
    }

    public void Heal(float h) {
        if(slider.value > 0){
            slider.value += h;
            if(slider.value >= slider.maxValue) {
                slider.value = slider.maxValue;
            }
        }
    }

}