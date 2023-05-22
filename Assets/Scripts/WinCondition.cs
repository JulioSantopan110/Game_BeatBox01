using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public static WinCondition winCondition;
    public GameObject[] boxes;
    private int Goal;
    public GameObject youwinPanel;
    public HashSet<string> boxComplete;
    
    private void Awake()
    {
        winCondition = this;
        youwinPanel.SetActive(false);
    }

    void Start()
    {
        boxComplete = new HashSet<string>();
        Goal = boxes.Length;
    }

    public void checkWin()
    {
        if (Goal == boxComplete.Count)
        {
            youwinPanel.SetActive(true);
        }
    }
}
