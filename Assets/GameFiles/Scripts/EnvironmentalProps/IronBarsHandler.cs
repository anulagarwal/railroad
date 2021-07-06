using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBarsHandler : MonoBehaviour
{
    #region Properties
    [Header("Components Reference")]
    [SerializeField] private Animator animator = null;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        ScaleUp();
    }
    #endregion

    #region Public Core Functions
    public void ScaleUp()
    {
        animator.SetTrigger("t_ScaleUp");
    }

    public void ScaleDown()
    {
        animator.SetTrigger("t_ScaleDown");
    }
    #endregion
}
