using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownBuildings : MonoBehaviour
{
    public GameObject[] buildings;
    public GameObject[] spownPoints;
    private Transform buildingsAndCarsParent;

    // Start is called before the first frame update

    private void Awake()
    {
        buildingsAndCarsParent = FindObjectOfType<SpownCars>().transform;
    }
    void Start()
    {
        var temp = -1;
        for (int i = 0; i < spownPoints.Length; i++)
        {
            Debug.Log("Temp before GOO: " + temp);
            var go = Random.Range(0, buildings.Length);
            Debug.Log("This is GOO: " + go);
            if (go == temp && go < buildings.Length -1) { go++; }
            Debug.Log("This is GOO 222222: " + go);
            temp = go;
            Debug.Log("This is Temp = go: " + temp);
            Instantiate(buildings[temp], spownPoints[i].transform.position, Quaternion.identity, buildingsAndCarsParent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
