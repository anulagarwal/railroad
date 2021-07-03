using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationManager : MonoBehaviour
{
    public static StationManager Instance = null;

    [SerializeField] List<Station> stations;


    #region Singleton Call
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;

    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddStation(Station station)
    {
        stations.Add(station);
    }

    public void RemoveStation(Station station)
    {
        stations.Remove(station);
    }
}
