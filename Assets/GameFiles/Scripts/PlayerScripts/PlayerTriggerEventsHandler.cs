using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerEventsHandler : MonoBehaviour
{
    #region MonoBehaviour Functions
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tree")
        {
            PlayerSingleton.Instance.GetPlayerMovementHandler.PlayerState = PlayerAnimationState.SwimgAxe;
            PlayerSingleton.Instance.GetPlayerAnimationsHandler.SwitchAnimationState(PlayerAnimationState.SwimgAxe);
            PlayerSingleton.Instance.GetPlayerAnimationsHandler.TreeToBeCutted = other.gameObject.transform.parent.transform.GetComponent<TreesHandler>();
        }
    }
    #endregion
}
