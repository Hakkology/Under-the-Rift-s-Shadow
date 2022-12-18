using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManagerHighlands : MonoBehaviour
{
    public GameObject Player;
    public TextMeshProUGUI PauseGameText, LoadGameText, HelpText, ExitGameText, ManaCount, HP;
    public GameObject pauseMenu, exitGameConfirm;
    public Charmovement charmovement;

    int hp;
    bool isGamePaused = false;
    int mana;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        exitGameConfirm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        mana = charmovement.mana;
        ManaCount.text = "Crystals: " + mana;
        hp = charmovement.HP;
        HP.text = "HP: " + hp;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isGamePaused = !isGamePaused;
        }

        IsGamePaused(isGamePaused);
    }

    public void IsGamePaused(bool isGamePaused)
    {
        if (!isGamePaused == false)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            exitGameConfirm.SetActive(false);
        }
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("UI");
    }

    public void ExitGameConfirm()
    {
        if (isGamePaused)
        {
            pauseMenu.SetActive(false);
            exitGameConfirm.SetActive(true);
        }
    }

    public void ExitGameUnConfirmed()
    {
        if (isGamePaused)
        {
            pauseMenu.SetActive(true);
            exitGameConfirm.SetActive(false);
        }
    }


}
