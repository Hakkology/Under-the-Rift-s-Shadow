using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static IdentityScript;

public class Knight1 : MonoBehaviour
{
    public GameObject player;
    IdentityScript knight1;

    // Start is called before the first frame update
    void Start()
    {
        List<string> knight1Dialogue = new List<string>(2);
        knight1Dialogue.Add("You must be the new wizard. I hope you can clear out the mines.");
        knight1Dialogue.Add("Move along.");

        //Individual properties of each NPC
        knight1 = GetComponent<IdentityScript>();
        knight1.Name = "Timothy";
        knight1.LastName = "Kent";
        knight1.Dialogue = knight1Dialogue;
        knight1.Origin = Race.Human;
        knight1.IsAlive = true;
        knight1.IsEnemy = false;
        knight1.InCutscene = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

