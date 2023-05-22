using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutor : MonoBehaviour
{

    public GameObject tutorMenu;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            tutorMenu.SetActive(false);
        }
    }

}
