using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static IdentityScript;

public class Knight2 : MonoBehaviour
{
    public GameObject player;
    IdentityScript knight2;

    // Start is called before the first frame update
    void Start()
    {
        List<string> knight2Dialogue = new List<string>(2);
        knight2Dialogue.Add("Your kind is not welcome around here.");
        knight2Dialogue.Add("Go back to your tower.");

        //Individual properties of each NPC
        knight2 = GetComponent<IdentityScript>();
        knight2.Name = "Charlotte";
        knight2.LastName = "Perry";
        knight2.Origin = Race.Human;
        knight2.IsAlive = true;
        knight2.IsEnemy = false;
        knight2.InCutscene = false;
        knight2.Dialogue = knight2Dialogue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
