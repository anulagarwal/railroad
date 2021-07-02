using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using MoreMountains.NiceVibrations;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance = null;
    [Header("Component References")]
    [SerializeField] private PlayerMovementHandler player;
    [SerializeField] private PlayerCharacterManager pcm;
    [SerializeField] private GameObject confetti;
    [SerializeField] private GameObject mainCam;
    [SerializeField] private GameObject endCam;
    [SerializeField] private Transform endStackPos;
    [SerializeField] private Animator chef;
    [SerializeField] private GameObject awesomeText;


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

    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
    }
    public void Win()
    {
        
    }

    public void Lose()
    {
        
    }

    public void StartLevel()
    {
       
    }

 

    public int GetSelectedCharacterIndex(int id)
    {
        return PlayerPrefs.GetInt("character", 0);
    }
    public int GetSelectedSweetIndex(int id)
    {
        return PlayerPrefs.GetInt("sweet", 0);
    }
    #region Scene Handlers

  

    #endregion
}
