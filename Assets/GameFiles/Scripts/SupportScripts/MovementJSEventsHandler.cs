using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovementJSEventsHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    #region Interface Functions
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerSingleton.Instance.GetPlayerAnimationsHandler.GetAnimator.SetBool("b_Mining", false);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
    }
    #endregion
}
