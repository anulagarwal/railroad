using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
    [SerializeField] private int currentGoldCount;


    #region Singleton call
    public static GoldManager Instance = null;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;

    }
#endregion

    #region Monobehvaiour Functions
    // Start is called before the first frame update
    void Start()
    {
        currentGoldCount = 50;
    }


    #endregion


    #region Public functions

    public void ReduceGold(int value)
    {
        currentGoldCount -= value;
        LevelUIManager.Instance.UpdateCoinCount(currentGoldCount);

    }

    public void AddGems(int value)
    {
        currentGoldCount += value;
        LevelUIManager.Instance.UpdateCoinCount(currentGoldCount);
    }

    public void SetGems(int value)
    {
        currentGoldCount = value;
        LevelUIManager.Instance.UpdateCoinCount(currentGoldCount);

    }

    #endregion


    public int GetAvailableGold { get => currentGoldCount; }
}
