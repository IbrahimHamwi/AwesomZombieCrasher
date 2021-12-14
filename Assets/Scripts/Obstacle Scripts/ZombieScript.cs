using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    public GameObject bloodFXPrefab;
    public float speed = 1f;

    private Rigidbody myBody;

    private bool isAlive = true;
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
        speed = Random.Range(1f, 5f);
        isAlive = true;
    }
    void Update()
    {
        if (isAlive)
        {
            myBody.velocity = new Vector3(0f, 0f, -speed);

        }
        if (transform.position.y < -10)
        {
            gameObject.SetActive(false);
        }
    }
    void Die()
    {
        isAlive = false;

        myBody.velocity = Vector3.zero;
        GetComponent<Collider>().enabled = false;
        GetComponentInChildren<Animator>().Play("Idle");

        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        transform.localScale = new Vector3(1f, 1f, 0.2f);
        transform.position = new Vector3(transform.position.x, 0.2f, transform.position.z);
    }
    void DeactivateGameObject()
    {
        gameObject.SetActive(false);
    }
    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "Player" || target.gameObject.tag == "Bullet")
        {
            Instantiate(bloodFXPrefab, transform.position, Quaternion.identity);

            Invoke("DeactivateGameObject", 3f);
            //IncreaseScore

            Die();
        }
    }
}
