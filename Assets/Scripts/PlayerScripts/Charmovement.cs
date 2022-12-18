using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Charmovement : MonoBehaviour
{
    public Transform spellcastPoint;
    public GameObject FiremagicPower;

    Rigidbody rb;
    Animator anim;
    NavMeshAgent agent;
    IdentityScript abe;

    float forward, side;
    float speed = 1.5f;
    float speedclone = 1.5f;
    float moveSens = 1.25f;
    float runMult = 3f;
    float sens = 400;
    float delay = 1.25f;
    float spellcastDuration;
    int jumpForce = 75;

    public int mana = 0;
    public int HP = 100;

    bool isjump;
    bool isCastingSpell = false;

    // Start is called before the first frame update
    void Start()
    {
       spellcastDuration = delay;
       abe = GetComponent<IdentityScript>();
       rb = GetComponent<Rigidbody>();
       anim = GetComponent<Animator>();
       agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("animforward", forward);
        anim.SetFloat("animside", side);
        
        if (!abe.InCutscene)
        {
            transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
            transform.Rotate(0, Input.GetAxis("Mouse X") * sens * Time.deltaTime, 0);

            if (Input.GetKey(KeyCode.W) && forward < 2)
            {
                forward += moveSens * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.S) && forward > -2)
            {
                forward -= moveSens * Time.deltaTime;
            }
            else
            {
                forward = Mathf.Lerp(forward, 0, 0.3f);
            }

            //Lerp on movement based on forward/side values
            if (forward > 1)
            {
                speed = speedclone + (speedclone * runMult - speedclone) * (forward - 1);
            }

            //Movement side Controls
            if (Input.GetKey(KeyCode.D) && side < 2)
            {
                side += moveSens * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.A) && side > -2)
            {
                side -= moveSens * Time.deltaTime;
            }
            else
            {
                side = Mathf.Lerp(forward, 0, 0.3f);
            }

            //if (Input.GetKey(KeyCode.Space))
            //{
            //    rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //}
        }

        // Spellcasting script
        if (Input.GetKeyDown(KeyCode.F))
        {
            isCastingSpell = true;
            anim.SetBool("IsCastingSpell", true);
            spellcastDuration -= Time.deltaTime;
            if (spellcastDuration <= 0 && isCastingSpell == true)
            {
                Fireball();
                isCastingSpell = false;
                anim.SetBool("IsCastingSpell", false);
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKey(KeyCode.Space) && collision.gameObject.tag == "Ground")
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ManaCrystals")
        {
            Destroy(other.gameObject);
            mana = mana + 4;
        }
    }

    public void Fireball()
    {
         Instantiate(FiremagicPower, spellcastPoint.transform.position, transform.rotation);
    }


    
}
