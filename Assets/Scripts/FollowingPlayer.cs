using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingPlayer : MonoBehaviour
{
    //datatype Transform used to store player reference in game
    public Transform PlayerPosition;
    public Vector3 FixingCameraPosition;
    void Update()
    {
        transform.position = PlayerPosition.position + FixingCameraPosition; //transform in small T used for this games's object only
    }
}
