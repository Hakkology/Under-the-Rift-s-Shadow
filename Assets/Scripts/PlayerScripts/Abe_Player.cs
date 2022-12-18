using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static IdentityScript;

public class Abe_Player: MonoBehaviour
{
    IdentityScript abe;

    // Start is called before the first frame update
    void Start()
    {
        //Individual properties of each NPC
        abe = GetComponent<IdentityScript>();
        abe.Name = "Abernethy";
        abe.LastName = "Mavr";
        abe.Origin = Race.Human;
        abe.IsAlive = true;
        abe.IsEnemy = false;
        abe.InCutscene = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

