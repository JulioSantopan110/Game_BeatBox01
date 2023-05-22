using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public LevelBuilder m_LevelBuilder;
    // public GameObject m_WinPanel;
    private bool m_ReadyForInput;
    private Player m_Player;
    public Animator transition;
    public GameObject Splash;

    void Start()
    {
        // m_WinPanel.SetActive(false);
        //m_LevelBuilder.Build();
        m_Player = FindObjectOfType<Player>();
        AudioManager.Instance.PlayMusic("Theme");
        //ResetScene();
        Time.timeScale = 1f;
        PauseMenu.isPaused = false;
        AudioManager.Instance.PlaySFX("End");
        StartCoroutine(HideSplash());
    }


    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            moveInput.Normalize();
            if (moveInput.sqrMagnitude > 0.5)
            {
                if (m_ReadyForInput)
                {
                    m_ReadyForInput = false;
                    m_Player.Move(moveInput);
                    IsLevelComplete();
                    ExtraLevelComplete();
                    // m_WinPanel.SetActive(IsLevelComplete());
                }
            }
            else
            {
                m_ReadyForInput = true;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                StartCoroutine(DelayOneSecond());
            }
        }

    }

    // public void NextLevel()
    // {
    //     m_WinPanel.SetActive(false);
    //     //m_LevelBuilder.NextLevel();
    //     //StartCoroutine(ResetSceneASync());
    // }

    // public void ResetScene()
    // {
    //     StartCoroutine(ResetSceneASync());
    // }

    bool IsLevelComplete()
    {
        Box[] boxes =FindObjectsOfType<Box>();
        foreach (var box in boxes)
        {
            if (!box.m_OnCross) return false;
        }
        // Time.timeScale = 0f;
        Splash.SetActive(true);
        AudioManager.Instance.StopMusic("Theme");
        AudioManager.Instance.PlaySFX("Start");
        transition.SetTrigger("Gas");
        StartCoroutine(NextStage());
        return true;
    }

    bool ExtraLevelComplete()
    {
        Box[] boxes =FindObjectsOfType<Box>();
        foreach (var box in boxes)
        {
            if (!box.m_OnExCross) return false;
        }
        // Time.timeScale = 0f;
        Splash.SetActive(true);
        AudioManager.Instance.StopMusic("Theme");
        AudioManager.Instance.PlaySFX("Start");
        transition.SetTrigger("Gas");
        StartCoroutine(ExtraStage());
        return true;
    }

    // public void Reset()
    // {

    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    // }

    IEnumerator DelayOneSecond()
    {
        Splash.SetActive(true);
        transition.SetTrigger("Gas");
        AudioManager.Instance.PlaySFX("Start");
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator NextStage()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator ExtraStage()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("Vacation1");
    }

    IEnumerator HideSplash()
    {
        yield return new WaitForSeconds(0.75f);
        Splash.SetActive(false);
    }

    // IEnumerator ResetSceneASync()
    // {
    //     if (SceneManager.sceneCount > 1)
    //     {
    //         AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync("LevelScene");
    //         while (asyncUnload.isDone)
    //         {
    //             yield return null;
    //             Debug.Log("UnLoading...");
    //         }
    //         Debug.Log("Unload Done");
    //         Resources.UnloadUnusedAssets();
    //     }

    //     AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("LevelScene", LoadSceneMode.Additive);
    //     while (!asyncLoad.isDone)
    //     {
    //         yield return null;
    //         Debug.Log("Loading...");
    //     }
    //     SceneManager.SetActiveScene(SceneManager.GetSceneByName("LevelScene"));
    //     m_LevelBuilder.Build();
    //     m_Player = FindObjectOfType<Player>();
    //     Debug.Log("Level loaded");
    // }
}
