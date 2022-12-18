using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBook : MonoBehaviour
{
    public GameObject player;
    public GameObject spellbook;

    float selfrotationSpeed = 50;
    float rotationSpeed = 75;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(selfrotationSpeed, 0, 0) * Time.deltaTime);
        spellbook.transform.RotateAround(player.transform.position, new Vector3(0,1,0), rotationSpeed * Time.deltaTime);
    }
}
