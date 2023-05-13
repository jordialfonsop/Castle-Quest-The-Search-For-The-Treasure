using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{

    [SerializeField] private bool isCollided = false;
    [SerializeField] private bool isDisabled = false;
    [SerializeField] private Transform initialTransform;
    // Start is called before the first frame update
    void Start()
    {
        initialTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetIsCollided()
    {
        return isCollided;
    }

    public Transform GetInitialTransform()
    {
        return initialTransform;
    }

    public void SetIsCollided(bool state)
    {
        isCollided = state;
    }

    public bool GetIsDisabled()
    {
        return isDisabled;
    }

    public void SetIsDisabled(bool state)
    {
        isDisabled = state;
    }

    private void OnTriggerEnter(Collider other)
    {
        SetIsCollided(true);

    }

    private void OnTriggerExit(Collider other)
    {
        SetIsCollided(false);
    }

}
