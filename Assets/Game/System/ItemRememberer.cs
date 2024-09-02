using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRememberer : MonoBehaviour
{
    public int i = 0; //1 - цветок, 2 - патрон 3 - книга.
    public bool[] endings = new bool[4];
    public bool leftInLab = true;
    public void SetValue(int v) => i = v;
    public static ItemRememberer inst;
    private void Awake() {
        if (inst != null && inst != this) {
            Destroy(this);
        } else {
            inst = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
