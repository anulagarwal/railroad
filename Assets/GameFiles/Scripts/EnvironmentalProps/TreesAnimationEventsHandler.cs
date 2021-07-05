using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreesAnimationEventsHandler : MonoBehaviour
{//
    #region Properties
    [Header("Components Reference")]
    [SerializeField] private TreesHandler treesHandler = null;
    #endregion

    #region Animation Events Functions
    private void AnimEvent_ScaleDown()
    {
        treesHandler.DisableAllTreeMeshes();
    }
    #endregion
}
