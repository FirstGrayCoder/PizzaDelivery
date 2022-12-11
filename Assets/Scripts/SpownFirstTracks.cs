using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownFirstTracks : MonoBehaviour
{
    public GameObject track;
    Vector3 nextSpownPoint;
     
    void Start()
    {
        for (int i = 0; i < 25; i++)
        {
            SpownTrack();
        }
    }

    public void SpownTrack()
    {
        GameObject temp = Instantiate(track, nextSpownPoint, Quaternion.Euler(0,90,0));
        nextSpownPoint = temp.transform.GetChild(0).transform.position;
    }
}
