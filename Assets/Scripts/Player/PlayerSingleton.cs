using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSingleton : MonoBehaviour
{
    #region Properties
    public static PlayerSingleton Instance = null;

    [Header("Components Reference")]
    [SerializeField] private CharacterAnimationHandler characterAnimationHandler = null;
    [SerializeField] internal GameObject label;
    [SerializeField] internal GameObject tray;



    [Header("Shift Speed")]
    [SerializeField] private float shiftSpeed;
    private bool isShifting;    

    #endregion

    #region MonoBehaviour Functions
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            //Destroy(gameObject);
        }
        Instance = this;
        label.SetActive(false);
        tray.SetActive(false);
    }

    private void Update()
    {
        
    }
    #endregion

    #region Public functions

    public void Lose()
    {
        GetComponent<PlayerMovementHandler>().enabled = false;
        characterAnimationHandler.SwitchCharacterAnimation(CharacterAnimationState.Defeat);
    }

    public void StartPlayer()
    {      
        GetComponent<PlayerMovementHandler>().enabled = true;
    }
  
    #endregion

    #region Getter And Setter
    public CharacterAnimationHandler GetCharacterAnimationHandler { get => characterAnimationHandler; }
    #endregion
}
