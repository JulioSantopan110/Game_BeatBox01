using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene1 : MonoBehaviour
{
    public Animator transition; 
    public GameObject cut1;
    public GameObject cut2;
    public GameObject cut3;
    public GameObject cut4;
    public GameObject cut5;
    public GameObject cut6;
    public GameObject cut7;
    public GameObject Splash;

    void Start()
    {
        cut2.SetActive(false);
        cut3.SetActive(false);
        cut4.SetActive(false);
        cut5.SetActive(false);
        cut6.SetActive(false);
        cut7.SetActive(false);
        StartCoroutine(HideSplash());
        AudioManager.Instance.PlaySFX("End");
    }

    public void Scene2()
    {
        AudioManager.Instance.PlaySFX("Chat");
        cut1.SetActive(false);
        cut2.SetActive(true);
        cut3.SetActive(false);
        cut4.SetActive(false);
        cut5.SetActive(false);
        cut6.SetActive(false);
        cut7.SetActive(false);
    }

    public void Scene3()
    {
        AudioManager.Instance.PlaySFX("Chat");
        cut1.SetActive(false);
        cut2.SetActive(false);
        cut3.SetActive(true);
        cut4.SetActive(false);
        cut5.SetActive(false);
        cut6.SetActive(false);
        cut7.SetActive(false);
    }

    public void Scene4()
    {
        AudioManager.Instance.PlaySFX("Chat");
        cut1.SetActive(false);
        cut2.SetActive(false);
        cut3.SetActive(false);
        cut4.SetActive(true);
        cut5.SetActive(false);
        cut6.SetActive(false);
        cut7.SetActive(false);
    }

    public void Scene5()
    {
        AudioManager.Instance.PlaySFX("Chat");
        cut1.SetActive(false);
        cut2.SetActive(false);
        cut3.SetActive(false);
        cut4.SetActive(false);
        cut5.SetActive(true);
        cut6.SetActive(false);
        cut7.SetActive(false);
    }

    public void Scene6()
    {
        AudioManager.Instance.PlaySFX("Chat");
        cut1.SetActive(false);
        cut2.SetActive(false);
        cut3.SetActive(false);
        cut4.SetActive(false);
        cut5.SetActive(false);
        cut6.SetActive(true);
        cut7.SetActive(false);
    }

    public void Scene7()
    {
        AudioManager.Instance.PlaySFX("Chat");
        cut1.SetActive(false);
        cut2.SetActive(false);
        cut3.SetActive(false);
        cut4.SetActive(false);
        cut5.SetActive(false);
        cut6.SetActive(false);
        cut7.SetActive(true);
    }

    public void NextStage()
    {
        Splash.SetActive(true);
        transition.SetTrigger("Gas");
        AudioManager.Instance.PlaySFX("Start");
        StartCoroutine(Next());
    }

    IEnumerator Next()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator HideSplash()
    {
        yield return new WaitForSeconds(0.75f);
        Splash.SetActive(false);
    }
}
