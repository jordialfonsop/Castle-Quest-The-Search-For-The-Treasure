using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;
using UnityEngine.XR.Interaction.Toolkit;

public class LocalPlayerCheck : NetworkBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject xrDeviceSimulator;
    [SerializeField] private GameObject inputActionManager;
    [SerializeField] private GameObject interactionManager;
    [SerializeField] private GameObject eventSystem;
    [SerializeField] private XRDirectInteractor L_xrDirectInteractor;
    [SerializeField] private XRDirectInteractor R_xrDirectInteractor;
    [SerializeField] private ActionBasedController L_xrController;
    [SerializeField] private ActionBasedController R_xrController;
    [SerializeField] private LineRenderer L_LineRenderer;
    [SerializeField] private LineRenderer R_LineRenderer;

    void Start()
    {
        if(!isLocalPlayer)
        {

            _camera.enabled = false;
            xrDeviceSimulator.SetActive(false);
            inputActionManager.SetActive(false);
            interactionManager.SetActive(false);
            eventSystem.SetActive(false);
            L_xrDirectInteractor.enabled = false;
            R_xrDirectInteractor.enabled = false;
            L_xrController.enabled = false;
            R_xrController.enabled = false;
            L_LineRenderer.enabled = false;
            R_LineRenderer.enabled = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
