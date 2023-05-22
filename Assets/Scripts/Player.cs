using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour{

    public Animator transition;
    public GameObject Splash;

    public bool Move(Vector2 direction){
        if (Mathf.Abs(direction.x) < 0.5)
        {
            print("Walk");
            AudioManager.Instance.PlaySFX("Walk");
            direction.x = 0;
        }
        else{
            print("Walk");
            AudioManager.Instance.PlaySFX("Walk");
            direction.y = 0;
        }
        direction.Normalize();
            if (Blocked(transform.position, direction))
            {
                return false;
            }
            else
            {
                transform.Translate(direction);
                return true;
            }
    }

    bool Blocked(Vector3 position, Vector2 direction)
    {
        Vector2 newPos = new Vector2(position.x, position.y) + direction;
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
        foreach (var wall in walls)
        {
            if (wall.transform.position.x == newPos.x && wall.transform.position.y == newPos.y)
            {
                print("Blocked");
                return true;
            }
        }
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        foreach (var box in boxes)
        {
            if (box.transform.position.x == newPos.x && box.transform.position.y ==newPos.y)
            {
                Box bx = box.GetComponent<Box>();
                if (bx && bx.Move(direction))
                {
                    print("Push");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        GameObject[] backdoors = GameObject.FindGameObjectsWithTag("BackDoor");
        foreach (var backdoor in backdoors)
        {
            if (backdoor.transform.position.x == newPos.x && backdoor.transform.position.y == newPos.y)
            {
                StartCoroutine(BackExtra());
                return true;
            }
        }

        GameObject[] doors1 = GameObject.FindGameObjectsWithTag("Door1");
        foreach (var door1 in doors1)
        {
            if (door1.transform.position.x == newPos.x && door1.transform.position.y == newPos.y)
            {
                StartCoroutine(Extra1());
                return true;
            }
        }

        GameObject[] doors2 = GameObject.FindGameObjectsWithTag("Door2");
        foreach (var door2 in doors2)
        {
            if (door2.transform.position.x == newPos.x && door2.transform.position.y == newPos.y)
            {
                StartCoroutine(Extra2());
                return true;
            }
        }

        GameObject[] doors3 = GameObject.FindGameObjectsWithTag("Door3");
        foreach (var door3 in doors3)
        {
            if (door3.transform.position.x == newPos.x && door3.transform.position.y == newPos.y)
            {
                StartCoroutine(Extra3());
                return true;
            }
        }

        GameObject[] doors4 = GameObject.FindGameObjectsWithTag("Door4");
        foreach (var door4 in doors4)
        {
            if (door4.transform.position.x == newPos.x && door4.transform.position.y == newPos.y)
            {
                StartCoroutine(Extra4());
                return true;
            }
        }

        GameObject[] doors5 = GameObject.FindGameObjectsWithTag("Door5");
        foreach (var door5 in doors5)
        {
            if (door5.transform.position.x == newPos.x && door5.transform.position.y == newPos.y)
            {
                StartCoroutine(Extra5());
                return true;
            }
        }
        return false;
    }

    IEnumerator BackExtra()
    {
        Splash.SetActive(true);
        transition.SetTrigger("Gas");
        AudioManager.Instance.PlaySFX("Start");
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("Vacation1");
    }

    IEnumerator Extra1()
    {
        Splash.SetActive(true);
        transition.SetTrigger("Gas");
        AudioManager.Instance.PlaySFX("Start");
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("FakeStage1");
    }
    IEnumerator Extra2()
    {
        Splash.SetActive(true);
        transition.SetTrigger("Gas");
        AudioManager.Instance.PlaySFX("Start");
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("FakeStage2");
    }
    IEnumerator Extra3()
    {
        Splash.SetActive(true);
        transition.SetTrigger("Gas");
        AudioManager.Instance.PlaySFX("Start");
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("FakeStage3");
    }
    IEnumerator Extra4()
    {
        Splash.SetActive(true);
        transition.SetTrigger("Gas");
        AudioManager.Instance.PlaySFX("Start");
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("FakeStage4");
    }
    IEnumerator Extra5()
    {
        Splash.SetActive(true);
        transition.SetTrigger("Gas");
        AudioManager.Instance.PlaySFX("Start");
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("FakeStage5");
    }
}
