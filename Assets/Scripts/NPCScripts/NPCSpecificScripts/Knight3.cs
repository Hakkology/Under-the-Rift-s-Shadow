using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static IdentityScript;

public class Knight3 : MonoBehaviour
{
    public GameObject player;
    IdentityScript knight3;

    // Start is called before the first frame update
    void Start()
    {
        List<string> knight3Dialogue = new List<string>(1);
        knight3Dialogue.Add("Abi içerde kristaller var bana da getirsene biraz...");

        //Individual properties of each NPC
        knight3 = GetComponent<IdentityScript>();
        knight3.Name = "Mümtaz";
        knight3.LastName = "Tufan";
        knight3.Dialogue = knight3Dialogue;
        knight3.Origin = Race.Human;
        knight3.IsAlive = true;
        knight3.IsEnemy = false;
        knight3.InCutscene = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
