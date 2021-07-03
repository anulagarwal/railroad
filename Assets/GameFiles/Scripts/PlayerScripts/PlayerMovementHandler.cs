using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementHandler : MonoBehaviour
{
    #region Properties
    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 0f;
    [SerializeField] private float rotSpeed = 0f;

    [Header("Components Reference")]
    [SerializeField] private CharacterController characterController = null;

    private Vector3 movementDirection = Vector3.zero;
    private FloatingJoystick movementJS = null;
    private PlayerAnimationsHandler playerAnimationsHandler = null;
    #endregion

    #region Delegate Functions
    public delegate void MovementMechanism();

    public MovementMechanism movementMechanism;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        movementMechanism = null;
        movementJS = LevelUIManager.Instance.GetMovementJS;
        playerAnimationsHandler = PlayerSingleton.Instance.GetPlayerAnimationsHandler;

        EnablePlayerMovement();
    }

    private void Update()
    {
        if (movementMechanism != null)
        {
            movementMechanism();
        }   
    }
    #endregion

    #region Getter And Setter
    public PlayerAnimationState PlayerState { get; set; }
    #endregion

    #region Private Core Functions
    private void Movement()
    {
        if (PlayerState != PlayerAnimationState.SwingAxe)
        {
            movementDirection = new Vector3(movementJS.Horizontal, 0, movementJS.Vertical).normalized;
            if (movementDirection != Vector3.zero)
            {
                characterController.Move(movementDirection * Time.deltaTime * moveSpeed);

                Quaternion newRotation = Quaternion.LookRotation(movementDirection);
                transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, rotSpeed * Time.deltaTime);

                if (PlayerState != PlayerAnimationState.Run)
                {
                    PlayerState = PlayerAnimationState.Run;
                    PlayerSingleton.Instance.GetPlayerAnimationsHandler.SwitchAnimationState(PlayerAnimationState.Run);
                }
            }
            else
            {
                if (PlayerState != PlayerAnimationState.Idle)
                {
                    PlayerState = PlayerAnimationState.Idle;
                    PlayerSingleton.Instance.GetPlayerAnimationsHandler.SwitchAnimationState(PlayerAnimationState.Idle);
                }
            }
        }
    }
    #endregion

    #region Public Core Functions
    public void EnablePlayerMovement()
    {
        movementMechanism += Movement;
    }
    #endregion
}
