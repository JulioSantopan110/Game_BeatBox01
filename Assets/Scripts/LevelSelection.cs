using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    
    [SerializeField] private bool unlocked;
    public Image unlockImage;
    public GameObject[] stars;

    public Sprite starSprite;

    public void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    private void Update()
    {
        UpdateLevelImage();
        UpdateLevelStatus();
    }

    private void UpdateLevelImage()
    {
        if(!unlocked){
            unlockImage.gameObject.SetActive(true);
            for(int i = 0; i < stars.Length; i++)
            {
                stars[i].gameObject.SetActive(false);
            }
        }
        else
        {
            unlockImage.gameObject.SetActive(false);
            for(int i = 0; i < stars.Length; i++)
            {
                stars[i].gameObject.SetActive(true);
            }

            for(int i = 0; i < PlayerPrefs.GetInt("Lv" + gameObject.name); i++)
            {
                stars[i].gameObject.GetComponent<Image>().sprite = starSprite;
            }
        }
    }

    private void UpdateLevelStatus(){
        int previosLevelNum = int.Parse(gameObject.name) - 1;
        if (PlayerPrefs.GetInt("Lv" + previosLevelNum) > 0)
        {
            unlocked = true;
        }
    }

    public void PressSelection(string _LevelName)
    {
        if(unlocked)
        {
            SceneManager.LoadScene(_LevelName);
        }
    }
}
