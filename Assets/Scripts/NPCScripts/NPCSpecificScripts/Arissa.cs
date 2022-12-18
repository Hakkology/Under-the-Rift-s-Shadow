using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static IdentityScript;

public class Arissa : MonoBehaviour
{
    public GameObject player;
    IdentityScript arissa;

    // Start is called before the first frame update
    void Start()
    {
        List<string> arissaDialogue = new List<string>(4);
        arissaDialogue.Add("It is good to see you made it here alive and well.");
        arissaDialogue.Add("As promised, you can find crystals inside the cave which you may use to harness your power.");
        arissaDialogue.Add("Just make sure to save the Miner's stuck inside.");
        arissaDialogue.Add("I shall remain here to protect the village from Kobolds.");

        //Individual properties of each NPC
        arissa = GetComponent<IdentityScript>();
        arissa.Name = "Arissa";
        arissa.LastName = "Mavr";
        arissa.Dialogue = arissaDialogue;
        arissa.Origin = Race.Elf;
        arissa.IsAlive = true;
        arissa.IsEnemy = false;
        arissa.InCutscene = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
