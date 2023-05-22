using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{

    [SerializeField] private InputActionProperty pinchAnimationAction;
    [SerializeField] private InputActionProperty grabAnimationAction;
    [SerializeField] private Animator handAnimator;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        handAnimator.SetFloat("Trigger", pinchAnimationAction.action.ReadValue<float>());
        handAnimator.SetFloat("Grip", grabAnimationAction.action.ReadValue<float>());
    }
}
