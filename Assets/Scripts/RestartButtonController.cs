using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RestartButtonController : MonoBehaviour
{
    // Start is called before the first frame update

    public UnityEvent gameRestart;

    public void ButtonClick()
    {
        gameRestart.Invoke();
    }

}
