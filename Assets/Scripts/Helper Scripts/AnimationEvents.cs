using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    private PlayerController playerController;
    private Animator anim;
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void ResetShooting()
    {
        playerController.canShoot = true;
        anim.Play("Idle");
    }
}
