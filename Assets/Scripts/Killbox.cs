using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        Instantiate(other.gameObject, other.gameObject.GetComponent<InitialTransform>().GetInitialTransform().position, other.gameObject.GetComponent<InitialTransform>().GetInitialTransform().rotation);
        Destroy(other.gameObject);

    }
}
