using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IdentityScript: MonoBehaviour
{
    public enum Race
    {
        Human,
        Elf,
        Dwarf,
        Halfling,
        Goblin,
        Kobold,
        Orc
    }

    public IdentityScript(string name, string lastName, Race race, bool isAlive, bool isEnemy, bool inCutscene, List<string> dialogue)
    {
        Name = name;
        LastName = lastName;
        Origin = race;
        IsAlive = isAlive;
        IsEnemy = isEnemy;
        InCutscene = inCutscene;
        Dialogue = dialogue;
    }

    public string Name { get; set; }
    public string LastName { get; set; }
    public Race Origin { get; set; }
    public bool IsAlive { get; set; }
    public bool IsEnemy { get; set; }
    public bool InCutscene { get; set; }
    public List<string> Dialogue { get; set; }



}
