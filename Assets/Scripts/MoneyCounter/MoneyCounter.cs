using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCounter : MonoBehaviour
{

    private int counter = 0;
    [SerializeField] private int triggerCounter = 9999999;
    [SerializeField] private GameObject tula;
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
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            counter++;
        }if (counter >= triggerCounter)
        {
            tula.SetActive(true);
        }
    }
}
