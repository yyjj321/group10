using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlAnimatorWithSlider : MonoBehaviour
{
    Animator animator;
    // 2. What is the slider that controls the animator? What is the parameter name?
    public Slider slider;
    public string animatorParameterName;


    private void Start() {
        // 1. Find our own Animator
        animator = gameObject.GetComponent<Animator>();
        // Check if slider is set, and if not disable the scirpt
        if (slider == null) {
            this.enabled = false;
            Debug.LogWarning("Forgot to set a slider!");
        }
    }

    // Repeat every frame:
    private void Update() {
        // 3. Take value from a slider
        float sliderValue = slider.value;
        // 4. Pass the value to the animator by the paramter name.
        animator.SetFloat(animatorParameterName, sliderValue);
    }
}
