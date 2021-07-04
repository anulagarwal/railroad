using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreText : MonoBehaviour
{
    public float upSpeed;
    public float fadeSpeed;
    public float duration;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, duration);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * upSpeed * Time.deltaTime);
        GetComponentInChildren<TextMeshPro>().alpha -= fadeSpeed;
    }
}
