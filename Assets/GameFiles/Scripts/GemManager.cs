using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemManager : MonoBehaviour
{
    [SerializeField] private int currentGemCount;

    #region Singleton Call

    public static GemManager Instance = null;

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
        currentGemCount = 50;
    }


    #endregion


    #region Public functions

    public void ReduceGems(int value)
    {
        currentGemCount -= value;
        LevelUIManager.Instance.UpdateGemCount(currentGemCount);

    }

    public void AddGems(int value)
    {
        currentGemCount += value;
        LevelUIManager.Instance.UpdateGemCount(currentGemCount);
    }

    public void SetGems(int value)
    {
        currentGemCount = value;
        LevelUIManager.Instance.UpdateGemCount(currentGemCount);

    }

    #endregion


    public int GetAvailableGems { get => currentGemCount; }

}
