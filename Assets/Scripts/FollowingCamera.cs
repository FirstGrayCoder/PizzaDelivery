using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public PlayerMoving player;
    private Vector3 lastPlayerPos;
    private float distanceToMove;

    void Start()
    {
        player = FindObjectOfType<PlayerMoving>();
        lastPlayerPos = player.transform.position;
    }

    void Update()
    {
        distanceToMove = player.transform.position.z - lastPlayerPos.z;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + distanceToMove);
        lastPlayerPos = player.transform.position;
    }
}
