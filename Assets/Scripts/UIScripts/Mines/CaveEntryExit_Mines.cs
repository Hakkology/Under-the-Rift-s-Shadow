using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveEntryExit_Mines : MonoBehaviour
{
    public GameObject exitMinesConfirm, Player;
    Vector3 SpawnPosition = new Vector3(230, 3, 836);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider Entrance)
    {
        if (Entrance.gameObject == Player)
        {
            exitMinesConfirm.SetActive(true);
        }
    }

    public void ExitMinesUnConfirmed()
    {
        exitMinesConfirm.SetActive(false);
    }

    public void ExitMinesConfirmed()
    {
        SceneManager.LoadScene("Highlands");
        Instantiate(Player, SpawnPosition, Quaternion.identity);
    }
}
