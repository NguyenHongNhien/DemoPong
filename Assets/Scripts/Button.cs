using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        Application.LoadLevel("Pong");
    }

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }
    public void Close()
    {
        Application.LoadLevel("Main");
    }
}
