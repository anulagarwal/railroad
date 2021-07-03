using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreesHandler : MonoBehaviour
{
    #region Properties
    [Header("Components Reference")]
    [SerializeField] private List<GameObject> treeMeshObjs = new List<GameObject>();
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        treeMeshObjs[Random.Range(0, treeMeshObjs.Count)].SetActive(true);    
    }
    #endregion

    #region Public Core Functions
    public void DisableAllTree()
    {
        foreach (GameObject obj in treeMeshObjs)
        {
            obj.SetActive(false);
        }
    }
    #endregion
}
