using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestalTriggerSocket : MonoBehaviour
{

    [SerializeField] private Pedestal pedestal;
    [SerializeField] private SocketPuzzle socketPuzzle;
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

        if (other.gameObject.tag == this.gameObject.tag)
        {
            pedestal.SetIsActive(true);
        }
        else
        {
            Debug.Log("Huh");
            pedestal.SetIsActive(false);
        }

        socketPuzzle.CheckStatus();
    }

    private void OnTriggerExit(Collider other)
    {

        pedestal.SetIsActive(false);
        socketPuzzle.CheckStatus();
        this.gameObject.SetActive(false);
    }
}
