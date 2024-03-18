using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMove : MonoBehaviour
{
    int dir;

    void GoUp()
    {

    }

    void GoDown()
    {

    }

    void Update()
    {
        if (dir != 0)
        {
            if (dir == 1)
            {
                GoUp();
            }
            else
            {
                GoDown();
            }
        }
    }
}
