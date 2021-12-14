using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float timer = 3f;
    void Start()
    {
        Invoke("DeactiveGameObject", timer);
    }
    void DeactiveGameObject()
    {
        gameObject.SetActive(false);
    }
}
