using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodLogsAnimationsHandler : MonoBehaviour
{
    #region Properties
    #endregion

    #region Animation Events Handler
    private void AnimEvent_ScaleDown()
    {
        PlayerInventoryManager.Instance.Wood++;
        Destroy(this.gameObject);
    }
    #endregion
}
