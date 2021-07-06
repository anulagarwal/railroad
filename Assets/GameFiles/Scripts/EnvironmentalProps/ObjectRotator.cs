using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    #region Attributes
    [Header("Attributes")]
    [SerializeField] private float rotSpeed = 0f;
    [SerializeField] private Vector3 rotAxis = Vector3.zero;
    #endregion

    #region MonoBehaviour Functions
    private void Update()
    {
        transform.Rotate(rotAxis * Time.deltaTime * rotSpeed);
    }
    #endregion
}
