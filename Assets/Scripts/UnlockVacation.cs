using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnlockVacation : MonoBehaviour
{
    [SerializeField] private bool vacation;
    public Image unlockVac;

    private void Update()
    {
        VacationUpdate();
        UpdateVacation();
    }

    private void VacationUpdate()
    {
        if(!vacation){
            unlockVac.gameObject.SetActive(true);
        }
        else
        {
            unlockVac.gameObject.SetActive(false);
        }
    }

    private void UpdateVacation(){
        int previosLevelNum = int.Parse(gameObject.name) - 1;
        if (PlayerPrefs.GetInt("Lv" + previosLevelNum) > 0)
        {
            vacation = true;
        }
    }

    public void Goto(string _LevelName)
    {
        if(vacation)
        {
            SceneManager.LoadScene(_LevelName);
        }
    }
}
