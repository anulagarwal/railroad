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
    [SerializeField] private float feedRate;


    private int currentCoinsFed;
    private int currentGemsFed;
    private float feedStartTime;
    private bool isFeeding;

    [Header("Component References")]
    [SerializeField] private GameObject station;
    [SerializeField] private Transform spawnPos;

    #region Monobehaviour Functions


    // Start is called before the first frame update
    void Start()
    {
        coinsCount.text = coinsRequired +"";
        gemsCount.text = gemsRequired + "";

        if(coinsRequired == 0)
        {
            coinsCount.transform.parent.gameObject.SetActive(false);
        }
        if (gemsRequired == 0)
        {
            gemsCount.transform.parent.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            isFeeding = true;
            feedStartTime = Time.time;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (isFeeding)
        {
           if(feedStartTime + feedRate < Time.time)
            {
                feedStartTime = Time.time;
                if (gemsRequired > 0 && GemManager.Instance.GetAvailableGems >0)
                {
                    GemManager.Instance.ReduceGems(1);
                    gemsRequired--;
                    gemsCount.text = gemsRequired + "";
                }
                else
                {
                    gemsCount.transform.parent.gameObject.SetActive(false);

                }

                if (coinsRequired > 0 && GoldManager.Instance.GetAvailableGold > 0)
                {
                    GoldManager.Instance.ReduceGold(1);
                    coinsRequired--;
                    coinsCount.text = coinsRequired + "";
                }
                else 
                {
                    coinsCount.transform.parent.gameObject.SetActive(false);
                }

                if(coinsRequired ==0 && gemsRequired == 0)
                {
                    BuildStation();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isFeeding = false;
        }
    }


    #endregion

    #region Core functions
    public void BuildStation()
    {
        GameObject g = Instantiate(station, spawnPos.position, Quaternion.identity);
        //StationManager.Instance.AddStation(g.GetComponent<Station>());
        gameObject.SetActive(false);
    }
    #endregion
}
