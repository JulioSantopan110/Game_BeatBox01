using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Box : MonoBehaviour
{
    public Animator transition;
    public bool m_OnCross;
    public bool m_OnExCross;
    public bool Move(Vector2 direction)
    {
        if (BoxBlocked(transform.position, direction))
        {
            print("Box Blocked");
            return false;
        }
        else
        {
            transform.Translate(direction);
            TestForOnCross();
            ExtraOnCross();
            return true;
        }
    }

    bool BoxBlocked(Vector3 position, Vector2 direction)
    {
        Vector2 newPos = new Vector2(position.x, position.y) + direction;
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
        foreach (var wall in walls)
        {
            if (wall.transform.position.x == newPos.x && wall.transform.position.y == newPos.y)
            {
                return true;
            }
        }
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        foreach (var box in boxes)
        {
            if (box.transform.position.x == newPos.x && box.transform.position.y == newPos.y)
            {
                return true;
            }
        }

        GameObject[] backdoors = GameObject.FindGameObjectsWithTag("BackDoor");
        foreach (var backdoor in backdoors)
        {
            if (backdoor.transform.position.x == newPos.x && backdoor.transform.position.y == newPos.y)
            {
                return true;
            }
        }

        return false;
    }

    void TestForOnCross()
    {
        GameObject[] crosses =GameObject.FindGameObjectsWithTag("Goal");
        foreach (var cross in crosses)
        {
            if(transform.position.x == cross.transform.position.x && transform.position.y == cross.transform.position.y)
            {
                GetComponent<SpriteRenderer>().color = Color.blue;
                m_OnCross = true;
                print("Goal");

                return;
            }
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        m_OnCross = false;
    }

    void ExtraOnCross()
    {
        GameObject[] excrosses =GameObject.FindGameObjectsWithTag("ExtraGoal");
        foreach (var excross in excrosses)
        {
            if(transform.position.x == excross.transform.position.x && transform.position.y == excross.transform.position.y)
            {
                GetComponent<SpriteRenderer>().color = Color.blue;
                m_OnExCross = true;
                print("Goal");

                return;
            }
        }
        m_OnExCross = false;
    }
}
