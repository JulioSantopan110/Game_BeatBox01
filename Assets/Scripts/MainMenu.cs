using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private void Start()
    {
        AudioManager.Instance.StopMusic("Theme");
        AudioManager.Instance.PlayMusic("MainMenu");
    }

    public void SelectStage()
    {
        AudioManager.Instance.PlaySFX("Menu");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Setting()
    {
        AudioManager.Instance.PlaySFX("Menu");
        AudioManager.Instance.StopMusic("MainMenu");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Credit()
    {
        AudioManager.Instance.PlaySFX("Menu");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void PlayGame()
    {
        AudioManager.Instance.PlaySFX("Menu");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void QuitGame()
    {
        AudioManager.Instance.PlaySFX("Menu");
        Application.Quit();
        Debug.Log("QUIT!!");
    }

    // public GameObject Point;
  
    // private int SelectedButton = 1;
    // [SerializeField]
    // private int NumberOfButtons;

    // public Transform ButtonPosition1;
    // public Transform ButtonPosition2;
    // public Transform ButtonPosition3;
    // public Transform ButtonPosition4;
    // public Transform ButtonPosition5;

    
    // private void OnPlay()
    // {
    //     if (SelectedButton == 1)
    //     {
    //         // When the button with the pointer is clicked, this piece of script is activated
    //         SceneManager.LoadScene("Stage1");
    //     }
    //     else if (SelectedButton == 2)
    //     {
    //         // When the button with the pointer is clicked, this piece of script is activated
    //         SceneManager.LoadScene("SelectStage");
    //     }
    //     else if (SelectedButton == 3)
    //     {
    //         // When the button with the pointer is clicked, this piece of script is activated
    //         SceneManager.LoadScene("Setting");
    //     }
    //     else if (SelectedButton == 4)
    //     {
    //         // When the button with the pointer is clicked, this piece of script is activated
    //         SceneManager.LoadScene("Credit");
    //     }
    //     else if (SelectedButton == 5)
    //     {
    //         // When the button with the pointer is clicked, this piece of script is activated
    //         Application.Quit();
    //     }
    // }
    // private void OnButtonUp()
    // {
    //     // Checks if the pointer needs to move down or up, in this case the poiter moves up one button
    //     if (SelectedButton > 1)
    //     {
    //         SelectedButton -= 1;
    //     }
    //     MoveThePointer();
    //     return;
    // }
    // private void OnButtonDown()
    // {
    //     // Checks if the pointer needs to move down or up, in this case the poiter moves down one button
    //     if (SelectedButton < NumberOfButtons)
    //     {
    //         SelectedButton += 1;
    //     }
    //     MoveThePointer();
    //     return;
    // }
    // private void MoveThePointer()
    // {
    //     // Moves the pointer
    //     if (SelectedButton == 1)
    //     {
    //         Point.transform.position = ButtonPosition1.position;
    //     }
    //     else if (SelectedButton == 2)
    //     {
    //         Point.transform.position = ButtonPosition2.position;
    //     }
    //     else if (SelectedButton == 3)
    //     {
    //         Point.transform.position = ButtonPosition3.position;
    //     }
    //     else if (SelectedButton == 4)
    //     {
    //         Point.transform.position = ButtonPosition4.position;
    //     }
    //     else if (SelectedButton == 5)
    //     {
    //         Point.transform.position = ButtonPosition5.position;
    //     }
    // }
}
