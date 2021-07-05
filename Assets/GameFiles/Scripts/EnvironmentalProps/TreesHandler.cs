using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreesHandler : MonoBehaviour
{
    #region Properties
    [Header("Attributes")]
    [SerializeField] private float growthTime = 0f;

    [Header("Components Reference")]
    [SerializeField] private Animator animator = null;
    [SerializeField] private ParticleSystem treeBurstPS = null;
    [SerializeField] private List<GameObject> treeMeshObjs = new List<GameObject>();
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        SetupTree();
    }
    #endregion

    #region Private Core Functions
    private void SetupTree()
    {
        int index = Random.Range(0, treeMeshObjs.Count);
        treeMeshObjs[index].SetActive(true);
        animator.SetTrigger("t_ScaleUp");
    }
    #endregion

    #region Public Core Functions
    public void DisableAllTree()
    {
        treeBurstPS.Play();
        animator.SetTrigger("t_ScaleDown"); 
    }

    public void DisableAllTreeMeshes()
    {
        foreach (GameObject obj in treeMeshObjs)
        {
            obj.SetActive(false);
        }

        Invoke("Regrow", growthTime);
    }
    #endregion

    #region Invoke Functions
    private void Regrow()
    {
        SetupTree();
        CancelInvoke();
    }
    #endregion
}
