using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SpearPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject tula;

    [SerializeField] private Spot spot1;
    [SerializeField] private Spot spot2;
    [SerializeField] private Spot spot3;
    [SerializeField] private Spot spot4;

    [SerializeField] private GameObject spear1;
    [SerializeField] private GameObject spear2;
    [SerializeField] private GameObject spear3;
    [SerializeField] private GameObject spear4;

    [SerializeField] private Transform spearT1;
    [SerializeField] private Transform spearT2;
    [SerializeField] private Transform spearT3;
    [SerializeField] private Transform spearT4;

    [SerializeField] private GameObject spearPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Reset()
    {

        GameObject.Destroy(spear1);
        GameObject.Destroy(spear2);
        GameObject.Destroy(spear3);
        GameObject.Destroy(spear4);

        GameObject Instance1 = Instantiate(spearPrefab, spearT1);
        spear1 = Instance1;

        GameObject Instance2 = Instantiate(spearPrefab, spearT2);
        spear2 = Instance2;

        GameObject Instance3 = Instantiate(spearPrefab, spearT3);
        spear3 = Instance3;

        GameObject Instance4 = Instantiate(spearPrefab, spearT4);
        spear4 = Instance4;

    }

    public void CheckStatus()
    {

        if (spear1.GetComponent<Spear>().GetIsDisabled() && spear2.GetComponent<Spear>().GetIsDisabled() && spear3.GetComponent<Spear>().GetIsDisabled() && spear4.GetComponent<Spear>().GetIsDisabled())
        {
            if (spot1.GetIsCollided() && spot2.GetIsCollided() && spot3.GetIsCollided() && spot4.GetIsCollided())
            {

                tula.SetActive(true);

            }
            else
            {
                Reset();
            }
                
        }
        
    }
}
