using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public Animator transition;
    public GameObject Splash;

    [SerializeField] Text countdownText;

    public float countdown = 90f;

    private void Start()
    {
        InvokeRepeating("CountdownTime", 1f, 1f); // menjalankan pengulangan setiap 1 detik
    }

    private void CountdownTime()
    {
        countdown--;
        countdown -= 1 * Time.deltaTime;
        countdownText.text = countdown.ToString ("0");
        // Debug.Log("Countdown: " + countdown);

        if (countdown <= 6f)
        {
            countdownText.color = Color.red;
        }

        if (countdown <= 0f)
        {
            CancelInvoke("CountdownTime"); // menghentikan pengulangan ketika countdown mencapai 0
            Debug.Log("Waktu habis!");
            AudioManager.Instance.PlaySFX("Start");
            Splash.SetActive(true);
            transition.SetTrigger("Gas");
            StartCoroutine(DelayOneSecond());
        }
    }

    IEnumerator DelayOneSecond()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
