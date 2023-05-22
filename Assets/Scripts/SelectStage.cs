using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectStage : MonoBehaviour
{
    public Animator transition;
    public float transtitionTime = 1.2f;
    public GameObject Splash;

    // private void Start()
    // {
    //     AudioManager.Instance.StopMusic("Theme");
    // }

    private void Awake()
    {
        Splash.SetActive(false);
        Time.timeScale = 1f;
    }

    public void LoadStage1()
    {
        Splash.SetActive(true);
        StartCoroutine(LoadScene2(SceneManager.GetActiveScene().buildIndex + 4));
        AudioManager.Instance.PlaySFX("Start");
    }
    public void LoadStage2()
    {
        Splash.SetActive(true);
        StartCoroutine(LoadScene2(SceneManager.GetActiveScene().buildIndex + 7));
        AudioManager.Instance.PlaySFX("Start");
    }
    public void LoadStage3()
    {
        Splash.SetActive(true);
        StartCoroutine(LoadScene2(SceneManager.GetActiveScene().buildIndex + 10));
        AudioManager.Instance.PlaySFX("Start");
    }
    public void LoadStage4()
    {
        Splash.SetActive(true);
        StartCoroutine(LoadScene2(SceneManager.GetActiveScene().buildIndex + 13));
        AudioManager.Instance.PlaySFX("Start");
    }
    public void LoadStage5()
    {
        Splash.SetActive(true);
        StartCoroutine(LoadScene2(SceneManager.GetActiveScene().buildIndex + 16));
        AudioManager.Instance.PlaySFX("Start");
    }

    public void LoadStageExtra()
    {
        Splash.SetActive(true);
        StartCoroutine(LoadScene2(SceneManager.GetActiveScene().buildIndex + 20));
        AudioManager.Instance.PlaySFX("Start");
    }

    IEnumerator LoadScene2(int levelIndex)
    {
        transition.SetTrigger("Gas");
        AudioManager.Instance.PlaySFX("Menu");
        yield return new WaitForSeconds(transtitionTime);

        SceneManager.LoadScene(levelIndex);
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

    // public GameObject Point;
    // private int SelectedButton = 1;
    // [SerializeField]
    // private int NumberOfButtons;

    // public Transform ButtonPosition1;
    // public Transform ButtonPosition2;
    // public Transform ButtonPosition3;
    // public Transform ButtonPosition4;
    // public Transform ButtonPosition5;
    // public Transform ButtonPosition6;

    
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
    //         SceneManager.LoadScene("Stage2");
    //     }
    //     else if (SelectedButton == 3)
    //     {
    //         // When the button with the pointer is clicked, this piece of script is activated
    //         SceneManager.LoadScene("Stage3");
    //     }
    //     else if (SelectedButton == 4)
    //     {
    //         // When the button with the pointer is clicked, this piece of script is activated
    //         SceneManager.LoadScene("Stage4");
    //     }
    //     else if (SelectedButton == 5)
    //     {
    //         // When the button with the pointer is clicked, this piece of script is activated
    //         SceneManager.LoadScene("Stage5");
    //     }
    //     else if (SelectedButton == 6)
    //     {
    //         // When the button with the pointer is clicked, this piece of script is activated
    //         SceneManager.LoadScene("Vacation1");
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
    //     else if (SelectedButton == 6)
    //     {
    //         Point.transform.position = ButtonPosition6.position;
    //     }
    // }
}
