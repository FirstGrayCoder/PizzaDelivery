using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownPlane : MonoBehaviour
{
    public GameObject track;
    public Transform nextSpownPoint;
    Vector3 nextSpownPoint2;


    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            SpownTrack();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player") SpownTrack();
    }

    public void SpownTrack()
    {
        GameObject temp = Instantiate(track, nextSpownPoint2, Quaternion.identity, nextSpownPoint);
        nextSpownPoint2 = temp.transform.GetChild(0).transform.position;
        
    }
}
