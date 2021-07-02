using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollisionAndTriggerEventsHandler : MonoBehaviour
{
    #region Properties 
    [Header("Components Reference")]
    [SerializeField] private PlayerMovementHandler playerMovementHandler = null;

    [Header("Attributes Reference")]
    [SerializeField] private Vector3 bumpForce;

    #endregion

    #region MonoBehaviour Functions
    private void OnTriggerEnter(Collider other)
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" && playerMovementHandler)
        {
            playerMovementHandler.playerMovementType = PlayerMovementType.Running;
            playerMovementHandler.velocity.y = -2f;
        }
    }
    #endregion
}
