using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialTransform : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform GetInitialTransform()
    {
        return _transform;
    }
}
