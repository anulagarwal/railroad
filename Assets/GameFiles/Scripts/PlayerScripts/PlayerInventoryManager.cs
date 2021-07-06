using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryManager : MonoBehaviour
{
    #region Properties
    public static PlayerInventoryManager Instance = null;
    #endregion

    #region MonoBehaviour Functions
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }

    private void Start()
    {
        ClearInventory();
    }
    #endregion

    #region Getter And Setter
    public int Wood { get; set; }

    public int Iron { get; set; }
    #endregion

    #region Private Core Functions
    private void ClearInventory()
    {
        Wood = 0;
        Iron = 0;
    }
    #endregion
}
