using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Goal")
        {
            sfx.PlaySound("complete");
            WinCondition.winCondition.boxComplete.Add(gameObject.name);
            WinCondition.winCondition.checkWin();
        }
    }
}
