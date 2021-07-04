using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailwayCart : MonoBehaviour
{
    [Header ("System attributes")]
    [SerializeField] private int level;
    [SerializeField] private float speed;
    [SerializeField] private int gemsRequired;
    [SerializeField] private int coinsRequired;

    [Header("Cart attributes")]
    [SerializeField] private bool isPlayerRiding;
    [SerializeField] private float waitTimeStation;

    private Transform currentRailRoad;
    private bool reachedStation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Station")
        {

        }

        if (collision.gameObject.tag == "RailRoad")
        {

        }
    }

    #region Public functions



    #endregion
}
