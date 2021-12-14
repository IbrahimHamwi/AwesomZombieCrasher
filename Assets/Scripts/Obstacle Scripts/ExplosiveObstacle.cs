using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveObstacle : MonoBehaviour
{
    public GameObject explosioPrefab;
    public int damage = 20;

    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "Player")
        {
            Instantiate(explosioPrefab, transform.position, Quaternion.identity);
            //Deal Damage
            gameObject.SetActive(false);
        }

        if (target.gameObject.tag == "Bullet")
        {
            Instantiate(explosioPrefab, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
