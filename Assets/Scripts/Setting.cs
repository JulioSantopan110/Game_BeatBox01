using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;

    private void Start()
    {
        AudioManager.Instance.PlayMusic("Theme");
        float slider1Value = PlayerPrefs.GetFloat("Slider1Value", 0.5f);
        float slider2Value = PlayerPrefs.GetFloat("Slider2Value", 0.5f);
        _musicSlider.value = slider1Value;
        _sfxSlider.value = slider2Value;

    }

    public void ToggleMusic()
    {
        AudioManager.Instance.ToggleMusic();
    }

    public void ToggleSFX()
    {
        AudioManager.Instance.ToggleSFX();
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

    public void Back()
    {
        AudioManager.Instance.PlaySFX("Menu");
        SceneManager.LoadScene("MainMenu");

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            AudioManager.Instance.PlaySFX("Menu");
            SceneManager.LoadScene("MainMenu");
        }

    }
}
