using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LockedDoor : MonoBehaviour
{

    [SerializeField]
    private XRGrabInteractable Interactable;

    [SerializeField]
    private AudioClip locked;

    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag != "Key" && Interactable.isActiveAndEnabled == false)
        {
            audio = GetComponent<AudioSource>();
            audio.clip = locked;
            audio.Play();
        }
    }
}
