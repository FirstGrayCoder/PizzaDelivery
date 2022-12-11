using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownNextPlanes : MonoBehaviour
{
    private SpownPlane spownPlane;
    private SpownCars destroyObject;
    [SerializeField] private GameObject planeParent;
    // Start is called before the first frame update
    void Start()
    {
        spownPlane = FindObjectOfType<SpownPlane>();
        destroyObject = FindObjectOfType<SpownCars>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            for (int i = 0; i < 2; i++)
            {
                spownPlane.SpownTrack();
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {

            GameObject go = spownPlane.transform.GetChild(0).gameObject;
            Destroy(go, 6);
        }
    }
}
