using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerEventsHandler : MonoBehaviour
{
    #region MonoBehaviour Functions
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tree" && PlayerSingleton.Instance.GetPlayerMovementHandler.PlayerState != PlayerAnimationState.SwingAxe)
        {
            PlayerSingleton.Instance.GetPlayerMovementHandler.PlayerState = PlayerAnimationState.SwingAxe;
            PlayerSingleton.Instance.GetPlayerAnimationsHandler.SwitchAnimationState(PlayerAnimationState.SwingAxe);
            PlayerSingleton.Instance.GetPlayerAnimationsHandler.TreeToBeCutted = other.gameObject.transform.parent.transform.parent.transform.GetComponent<TreesHandler>();
        }
        else if (other.gameObject.tag == "WoodLogs")
        {
            other.gameObject.GetComponent<WoodLogsHandler>().ScaleDown();
        }
        else if (other.gameObject.tag == "IronMine" && PlayerSingleton.Instance.GetPlayerMovementHandler.PlayerState != PlayerAnimationState.Mining)
        {
            PlayerSingleton.Instance.GetPlayerMovementHandler.PlayerState = PlayerAnimationState.Mining;
            PlayerSingleton.Instance.GetPlayerAnimationsHandler.SwitchAnimationState(PlayerAnimationState.Mining);
        }

        if(other.gameObject.tag == "RailRoad")
        {
            RailRoadHandler rrh = other.gameObject.GetComponent<RailRoadHandler>();
            rrh.EnableTrack();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "IronMine" && PlayerSingleton.Instance.GetPlayerMovementHandler.PlayerState == PlayerAnimationState.Mining)
        {
            PlayerSingleton.Instance.GetPlayerMovementHandler.PlayerState = PlayerAnimationState.Idle;
            PlayerSingleton.Instance.GetPlayerAnimationsHandler.SwitchAnimationState(PlayerAnimationState.Idle);
        }
    }
    #endregion
}
