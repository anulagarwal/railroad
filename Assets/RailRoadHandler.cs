using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailRoadHandler : MonoBehaviour
{
    public MeshRenderer mr;
    public bool isTrackEnabled;
    public void EnableTrack()
    {
        isTrackEnabled = true;
        //mr.enabled = true;
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
