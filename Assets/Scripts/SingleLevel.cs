using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SingleLevel : MonoBehaviour
{
    // [SerializeField] private bool unvac;
    // public Image unlockVac;
    private int currentStarsNum = 0;
    public int levelIndex;


    // private void Update()
    // {
    //     VacationUpdate();
    //     UpdateVacation();
    // }

    public void BackButton()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void PressStarsButton(int _starsNum)
    {
        currentStarsNum = _starsNum;

        if(currentStarsNum > PlayerPrefs.GetInt("Lv" + levelIndex))
        {
            PlayerPrefs.SetInt("Lv" + levelIndex, _starsNum);
        }

        //BackButton
        Debug.Log(PlayerPrefs.GetInt("Lv" + levelIndex, _starsNum));
    }

    // private void VacationUpdate(){
    //     if(!unvac){
    //         unlockVac.gameObject.SetActive(true);
    //     }
    //     else
    //     {
    //         unlockVac.gameObject.SetActive(false);
    //     }
    // }

    // private void UpdateVacation(){
    //     if (PlayerPrefs.GetInt("Lv" + levelIndex) > 2)
    //     {
    //         unvac = true;
    //     }
    // }

    public void Goto(string _LevelName)
    {
        SceneManager.LoadScene(_LevelName);
    }
}
