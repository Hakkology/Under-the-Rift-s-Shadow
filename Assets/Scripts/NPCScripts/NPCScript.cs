using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public GameObject player;

    List<IdentityScript> identityScripts = new List<IdentityScript>();
    Animator animator;
    Rigidbody rigidBody;
    Outline outline;
    
    public bool isWalking;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        outline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        outline.enabled = false;

        if (isWalking == true)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }

    //NPC Look angle script
    void OnTriggerEnter(Collider other)
    {
        transform.rotation = Quaternion.LookRotation(player.transform.position);
    }

}
