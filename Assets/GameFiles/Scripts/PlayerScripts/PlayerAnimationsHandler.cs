using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationsHandler : MonoBehaviour
{
    #region Properties
    [Header("Components Reference")]
    [SerializeField] private Animator animator = null;
    #endregion

    #region Getter And Setter
    public TreesHandler TreeToBeCutted { get; set; }
    #endregion

    #region Animation Events Functions
    private void AnimEvent_AxeSwing()
    {
        TreeToBeCutted.DisableAllTree();
        PlayerSingleton.Instance.GetPlayerMovementHandler.PlayerState = PlayerAnimationState.Idle;
    }
    #endregion

    #region Public Core Functions
    public void SwitchAnimationState(PlayerAnimationState state)
    {
        switch (state)
        {
            case PlayerAnimationState.Idle:
                animator.SetBool("b_Run", false);
                animator.SetBool("b_Swing", false);
                break;
            case PlayerAnimationState.Run:
                animator.SetBool("b_Run", true);
                animator.SetBool("b_Swing", false);
                break;
            case PlayerAnimationState.SwimgAxe:
                animator.SetBool("b_Swing", true);
                break;
            case PlayerAnimationState.Victory:
                animator.SetTrigger("t_Victory");
                break;
        }
    }
    #endregion
}
