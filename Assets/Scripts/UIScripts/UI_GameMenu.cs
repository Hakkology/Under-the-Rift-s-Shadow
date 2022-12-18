using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_GameMenu : MonoBehaviour
{
    public TextMeshProUGUI NewGameText, LoadGameText, SettingsText, HelpText, ExitGameText;
    public TextMeshProUGUI GraphicsText, SoundText, ControlsText, BacktoMainMenuText;

    public GameObject MainMenu,SettingsMenu,MenuCanvas;


    // Start is called before the first frame update
    void Start()
    {
        
        MenuCanvas.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void StartButton()
    {
        SceneManager.LoadScene("Highlands");
    }

    public void SettingsButton()
    {
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }

    public void BacktoMainMenuButton()
    {
        MainMenu.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}
