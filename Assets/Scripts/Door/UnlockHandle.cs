using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UnlockHandle : MonoBehaviour
{

    [SerializeField]
    private XRGrabInteractable Interactable;

    [SerializeField]
    private XRSimpleInteractable HandleInterior;

    [SerializeField]
    private XRSimpleInteractable HandleExterior;

    [SerializeField]
    private GameObject CheaterText;

    [SerializeField]
    private AudioClip unlock;

    private AudioSource audio;
    
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Key")
        {
            audio = GetComponent<AudioSource>();
            audio.clip = unlock;
            audio.Play();
            HandleInterior.enabled = false; 
            HandleExterior.enabled = false;
            Interactable.enabled = true;
            //Destroy(col.gameObject);
            CheaterText.SetActive(false);
        }
    }
}
