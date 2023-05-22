using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject settingMenu;
    public static bool isPaused;
    public Slider _musicSlider, _sfxSlider;

    void Start()
    {
        pauseMenu.SetActive(false);
        settingMenu.SetActive(false);
        float slider1Value = PlayerPrefs.GetFloat("Slider1Value", 0.5f);
        float slider2Value = PlayerPrefs.GetFloat("Slider2Value", 0.5f);
        _musicSlider.value = slider1Value;
        _sfxSlider.value = slider2Value;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                btn_Resume();
            }
            else
            {
                btn_PauseGame();
            }
        }

    }

    public void MusicVolume()
    {
        AudioManager.Instance.MusicVolume(_musicSlider.value);
        float slider1Value = PlayerPrefs.GetFloat("Slider1Value", 0.5f);
        _musicSlider.value = slider1Value;
    }

    public void SFXVolume()
    {
        AudioManager.Instance.SFXVolume(_sfxSlider.value);
        float slider2Value = PlayerPrefs.GetFloat("Slider2Value", 0.5f);
        _sfxSlider.value = slider2Value;
    }

    public void btn_PauseGame()
    {
        AudioManager.Instance.PauseMusic("Theme");
        AudioManager.Instance.PlaySFX("Menu");
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void btn_Resume()
    {
        AudioManager.Instance.UnPauseMusic("Theme");
        AudioManager.Instance.PlaySFX("Menu");
        pauseMenu.SetActive(false);
        settingMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void btn_SelectStage()
    {
        AudioManager.Instance.PlaySFX("Menu");
        SceneManager.LoadScene("SelectStage");
        AudioManager.Instance.PlayMusic("MainMenu");
    }

    public void btn_Setting()
    {
        AudioManager.Instance.PlaySFX("Menu");
        AudioManager.Instance.PlayMusic("Theme");
        settingMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void btn_mainMenu()
    {
        AudioManager.Instance.PlaySFX("Menu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        AudioManager.Instance.PlaySFX("Menu");
        Application.Quit();
        Debug.Log("QUIT");
    }

        public void Back()
    {
        AudioManager.Instance.PlaySFX("Menu");
        AudioManager.Instance.PauseMusic("Theme"); 
        settingMenu.SetActive(false);
        pauseMenu.SetActive(true);

    }

}
