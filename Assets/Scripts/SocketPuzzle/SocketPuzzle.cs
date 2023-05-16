using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject redShield;
    [SerializeField] private Pedestal pedestal1;
    [SerializeField] private Pedestal pedestal2;
    [SerializeField] private Pedestal pedestal3;
    [SerializeField] private Pedestal pedestal4;
    [SerializeField] private BoxCollider moneyCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckStatus()
    {

        if (pedestal1.GetIsActive() && pedestal2.GetIsActive() && pedestal3.GetIsActive() && pedestal4.GetIsActive())
        {
            redShield.GetComponent<Animator>().enabled = true;
            redShield.GetComponent<AudioSource>().Play();
            moneyCounter.enabled = true;
        }
        
    }
}
