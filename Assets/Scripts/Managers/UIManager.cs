using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            //Destroy(gameObject);
        }
        Instance = this;     
    }



    public enum State { Main, InGame, Win, Lose };
    public State currentState;
    [Header("UI Panel")]
    [SerializeField] private GameObject mainMenuUIObj = null;
    [SerializeField] private GameObject gameplayUIObj = null;
    [SerializeField] private GameObject gameWinUIObj = null;
    [SerializeField] private GameObject gameLoseUIObj = null;
    [SerializeField] private GameObject storeUIObj = null;
    [SerializeField] private GameObject paywallObj = null;




    [Header("Text values")]
    [SerializeField] private Text gemCount;
    [SerializeField] private Text coinCount;
    [SerializeField] private Text xpLevel;


    [Header("Gameplay UI Panel")]
    [SerializeField] private FloatingJoystick movementJS = null;

    private int storeCharacterIndex = 0;
  

    private void Start()
    {
       

//        PlayerCharacterManager.Instance.EnablePlayerCharacter(storeCharacterIndex);
    }

  
    #region Public Functions


 
    public void UpdateState(State state)
    {
        switch (state)
        {
            case State.Main:
                mainMenuUIObj.SetActive(true);
                gameplayUIObj.SetActive(false);
                gameWinUIObj.SetActive(false);
                gameLoseUIObj.SetActive(false);
                break;
            case State.InGame:
                mainMenuUIObj.SetActive(false);
                gameplayUIObj.SetActive(true);
                gameWinUIObj.SetActive(false);
                gameLoseUIObj.SetActive(false);
                break;

            case State.Win:
                mainMenuUIObj.SetActive(false);
                gameplayUIObj.SetActive(false);
                gameWinUIObj.SetActive(true);
                gameLoseUIObj.SetActive(false);
             
                break;

            case State.Lose:
                mainMenuUIObj.SetActive(false);
                gameplayUIObj.SetActive(false);
                gameWinUIObj.SetActive(false);
                gameLoseUIObj.SetActive(true);
                break;
        }
    }

    #endregion

    #region Text updates

    public void UpdateGemCount(int value)
    {
        gemCount.text = "" + value;
    }

    public void UpdateCoinCount(int value)
    {
        coinCount.text = "" + value;
    }

    public void UpdateXP(int value)
    {
        xpLevel.text = "" + value;
    }
    #endregion

    #region Getter And Setter
    public FloatingJoystick GetMovementJS { get => movementJS; }
    #endregion




}
