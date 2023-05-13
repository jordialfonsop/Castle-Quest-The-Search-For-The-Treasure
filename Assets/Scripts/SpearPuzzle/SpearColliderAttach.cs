using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SpearColliderAttach : MonoBehaviour
{
    [SerializeField] private bool isCollided = false;
    [SerializeField] private Spear spear;
    [SerializeField] private SpearPuzzle spearPuzzle;
    // Start is called before the first frame update
    void Start()
    {
        spearPuzzle = GameObject.Find("SpearPuzzle").GetComponent<SpearPuzzle>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool GetIsCollided()
    {
        return isCollided;
    }

    public void SetIsCollided(bool state)
    {
        isCollided = state;
    }

    private void OnTriggerEnter(Collider other)
    {
        SetIsCollided(true);

        if (spear.GetIsCollided() && other.gameObject.tag == "Map") 
        {
            spear.GetComponent<XRGrabInteractable>().enabled = false;
            spear.GetComponent<Rigidbody>().isKinematic = true;
            spear.SetIsDisabled(true);
            spearPuzzle.CheckStatus();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        SetIsCollided(false);
    }
}
