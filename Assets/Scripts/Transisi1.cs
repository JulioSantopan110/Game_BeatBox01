using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transisi1 : MonoBehaviour
{
    public Animator transition;
    public float transtitionTime = 1f;

    public void LoadNextLevel()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadScene(int levelIndex)
    {
        transition.SetTrigger("Gas");

        yield return new WaitForSeconds(transtitionTime);

        SceneManager.LoadScene(levelIndex);
    }    

}
