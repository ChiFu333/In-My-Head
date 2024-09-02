using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RiddleChecker : MonoBehaviour
{
    public ButtonLogic[] buttons;
    public UnityEvent Win;
    public void Check()
    {
        for(int i = 0; i < buttons.Length; i++)
        {
            if(!buttons[i].isReady)
            {
                return;
            }
        }
        Win.Invoke();
    }
}
