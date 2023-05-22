using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transisi_MainMenu : MonoBehaviour
{
    public Animator transition;
    public float transtitionTime = 1.2f;
    public GameObject Splash;

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

    IEnumerator LoadScene2(int levelIndex)
    {
        transition.SetTrigger("Gas");

        yield return new WaitForSeconds(transtitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
