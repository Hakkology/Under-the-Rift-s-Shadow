using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveEntryExit_Highlands : MonoBehaviour
{
    public GameObject enterMinesConfirm, Player;

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
            enterMinesConfirm.SetActive(true);
        }
    }

    public void EnterMinesUnConfirmed()
    {
        enterMinesConfirm.SetActive(false);
    }

    public void EnterMinesConfirmed()
    {
        SceneManager.LoadScene("KoboldMines");
    }
}
