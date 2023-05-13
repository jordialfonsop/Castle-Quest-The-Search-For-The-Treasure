using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot : MonoBehaviour
{
    [SerializeField] bool isCollided = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetIsCollided()
    {
        return isCollided;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Spear") 
        {
            
            isCollided = true;
        
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isCollided = false;
    }
}
