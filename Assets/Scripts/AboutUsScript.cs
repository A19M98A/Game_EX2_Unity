using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutUsScript : MonoBehaviour
{
    public void Back()
    {
        Application.LoadLevel(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
