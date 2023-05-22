using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    public Animator transition;
    
    void Start()
    {
        AudioManager.Instance.PlaySFX("End");
        StartCoroutine(IntroHeh());
    }

    IEnumerator IntroHeh()
    {
        yield return new WaitForSeconds(30f);
        transition.SetTrigger("Gas");
        AudioManager.Instance.PlaySFX("Start");
        StartCoroutine(NextStage());
    }

    IEnumerator NextStage()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
