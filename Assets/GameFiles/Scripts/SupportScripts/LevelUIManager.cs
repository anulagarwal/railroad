using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelUIManager : MonoBehaviour
{
    #region Properties
    public static LevelUIManager Instance = null;


    public enum State { Main, InGame, Win, Lose };
    public State currentState;

    [Header("UI Panel")]
    [SerializeField] private GameObject mainMenuUIObj = null;
    [SerializeField] private GameObject gameplayUIObj = null;
    [SerializeField] private GameObject gameWinUIObj = null;
    [SerializeField] private GameObject gameLoseUIObj = null;

    [Header("References")]
    [SerializeField] private GameObject scoreText;


    [Header("Text values")]
    [SerializeField] private Text gemCount;
    [SerializeField] private Text coinCount;
    [SerializeField] private Text xpLevel;


    [Header("Gameplay UI Panel Setup")]
    [SerializeField] private FloatingJoystick movementJS = null;
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
    #endregion
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

    public void SpawnScore(Vector3 pos)
    {
        Instantiate(scoreText, pos, Quaternion.identity);
    }
    #region Getter And Setter
    public FloatingJoystick GetMovementJS { get => movementJS; }
    #endregion
}
