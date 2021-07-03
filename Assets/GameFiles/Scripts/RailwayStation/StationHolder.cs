using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StationHolder : MonoBehaviour
{
    [Header ("System Attributes")]
    [SerializeField] private int coinsRequired;
    [SerializeField] private int gemsRequired;
    [SerializeField] private TextMeshPro coinsCount;
    [SerializeField] private TextMeshPro gemsCount;
    
    private int currentCoinsFed;
    private int currentGemsFed;

    [Header("Component References")]
    [SerializeField] private GameObject station;
    [SerializeField] private Transform spawnPos;

    #region Monobehaviour Functions


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
        if(collision.gameObject.tag == "Player")
        {

        }
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
    #endregion

    #region Core functions
    public void BuildStation()
    {
        GameObject g = Instantiate(station, spawnPos.position, Quaternion.identity);
        StationManager.Instance.AddStation(g.GetComponent<Station>());
        Destroy(gameObject);
    }
    #endregion
}
