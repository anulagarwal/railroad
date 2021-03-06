using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationsHandler : MonoBehaviour
{
    #region Properties
    [Header("Components Reference")]
    [SerializeField] private Animator animator = null;
    [SerializeField] private ParticleSystem sparkPS = null;
    #endregion

    #region Getter And Setter
    public TreesHandler TreeToBeCutted { get; set; }

    public Animator GetAnimator { get => animator; }
    #endregion

    #region Animation Events Functions
    private void AnimEvent_AxeSwing()
    {
        TreeToBeCutted.DisableAllTree();
        PlayerSingleton.Instance.GetPlayerMovementHandler.PlayerState = PlayerAnimationState.Idle;
        LevelUIManager.Instance.SpawnScore(transform.position);
        GemManager.Instance.AddGems(1);
        SwitchAnimationState(PlayerAnimationState.Idle);
    }

    private void AnimEvent_Mining()
    {
        sparkPS.Play();
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
            case PlayerAnimationState.SwingAxe:
                animator.SetBool("b_Swing", true);
                break;
            case PlayerAnimationState.Mining:
                animator.SetBool("b_Mining", true);
                break;
            case PlayerAnimationState.Victory:
                animator.SetTrigger("t_Victory");
                break;
        }
    }
    #endregion
}
