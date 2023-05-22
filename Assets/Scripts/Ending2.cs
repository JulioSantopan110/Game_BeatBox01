using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending2 : MonoBehaviour
{
    public Animator transition;
    
    void Start()
    {
        AudioManager.Instance.PlaySFX("End");
        StartCoroutine(Tamat());
    }

    IEnumerator Tamat()
    {
        yield return new WaitForSeconds(10f);
        transition.SetTrigger("Gas");
        AudioManager.Instance.PlaySFX("Start");
        StartCoroutine(GasTamat());
    }

    IEnumerator GasTamat()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("MainMenu");
    }
}
