using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPManager : MonoBehaviour
{
    [SerializeField] public int currentXP;
    [SerializeField] public int currentXPLevel;
    [SerializeField] List<XPLevel> xpLevel;

    #region Singleton Call

    public static XPManager Instance = null;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;

    }
    #endregion

    #region Monobehavior Functions
    // Start is called before the first frame update
    void Start()
    {
        
    }
    #endregion

    public void AddToXP(int value)
    {
        currentXP += value;

        foreach(XPLevel xpl in xpLevel)
        {
            if(currentXP < xpl.xpRequired)
            {
                currentXPLevel = xpl.xpLevel - 1;
                break;
            }
        }
    }

    public int GetCurrentXP { get => currentXP; }

}
