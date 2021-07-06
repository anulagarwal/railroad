using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMineHandler : MonoBehaviour
{
    #region Properties
    [Header("Components Reference")]
    [SerializeField] private Animator animator = null;
    [SerializeField] private GameObject ironBarsObj = null;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        SetupIronMine();
    }
    #endregion

    #region Public Core Functions
    public void SetupIronMine()
    {
        animator.SetTrigger("t_ScaleUp");
    }
    #endregion
}
