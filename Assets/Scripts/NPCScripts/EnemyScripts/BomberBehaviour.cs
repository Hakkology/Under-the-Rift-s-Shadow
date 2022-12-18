using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BomberBehaviour : MonoBehaviour
{
    // external factors
    public GameObject player;
    public GameObject explosionEffect;

    // internal factors
    Rigidbody rb;
    Animator anim;
    NavMeshAgent navMeshAgent;
    GameObject explosion;

    // variables
    float speed = 0.1f;
    private bool track = false;
    bool hasExploded;
    float delay = 1.25f;
    float radius = 4f;
    float countdown;
    float force = 25000;

    // Start is called before the first frame update
    void Start()
    {
        explosion = explosionEffect;
        hasExploded = false;
        countdown = delay;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //NPC Look angle script
        Vector3 playerPos = player.transform.position;
        Vector3 npcPos = transform.position;

        Vector3 delta = new Vector3(playerPos.x - npcPos.x, playerPos.y - npcPos.y, playerPos.z - npcPos.z);
        

        //NPC animation trigger script

        if (track == true)
        {
            anim.SetBool("walk", true);
            navMeshAgent.transform.rotation = Quaternion.LookRotation(delta);
            navMeshAgent.SetDestination(player.transform.position);
            speed += (float)(0.04 * Time.deltaTime);
        }

        // Distance between player and bomber
        if (Vector3.Distance(player.transform.position, transform.position) < 2f && hasExploded == false)
        {
            // animation and movement controls
            anim.SetBool("walk", false);
            anim.SetTrigger("attack01");
            navMeshAgent.SetDestination(transform.position);

            // countdown for the bomb
            countdown -= Time.deltaTime;
            if (countdown <= 0f && gameObject != null) // game object check
            {
                Instantiate(explosion, transform.position, transform.rotation);
                hasExploded = true;

                if (Vector3.Distance(player.transform.position, transform.position) < radius)
                {
                    player.GetComponent<Rigidbody>().AddExplosionForce(force, transform.position, radius);
                    player.GetComponent<Charmovement>().HP -= 50;
                }
                Destroy(gameObject);
            }

        }
    }

    void OnTriggerStay(Collider awareness)
    {
        //NPC tracking script
        if (awareness.gameObject == player)
        {
            track = true;
            
        }
    }



    

}
