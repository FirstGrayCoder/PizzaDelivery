using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownCars : MonoBehaviour
{
    public GameObject[] leftCars;
    public GameObject[] rightCars;
    public GameObject[] spownLeftPoints;
    public GameObject[] spownRightPoints;
    private Transform buildingsAndCarsParent;

    // Start is called before the first frame update
    private void Awake()
    {
        buildingsAndCarsParent = FindObjectOfType<SpownCars>().transform;
    }
    void Start()
    {

        for (int i = 0; i < spownLeftPoints.Length; i++)
        {
            var go = Random.Range(0, leftCars.Length);
            Instantiate(leftCars[go], spownLeftPoints[i].transform.position, Quaternion.Euler(0,90,0), buildingsAndCarsParent);
        }

        for (int i = 0; i < spownRightPoints.Length; i++)
        {
            var go = Random.Range(0, rightCars.Length);
            Instantiate(rightCars[go], spownRightPoints[i].transform.position, Quaternion.Euler(0,-90,0), buildingsAndCarsParent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
