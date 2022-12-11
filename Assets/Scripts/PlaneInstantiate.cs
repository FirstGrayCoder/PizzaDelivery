using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneInstantiate : MonoBehaviour
{
    public GameObject plane;
    public Transform gamePlane; 


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(plane, gamePlane, false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpownClientsbuildings()
    {

    }
    public void SpownPizzaShops()
    {

    }
}

