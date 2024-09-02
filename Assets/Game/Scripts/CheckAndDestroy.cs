using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAndDestroy : MonoBehaviour
{
    public int value;
    void Start()
    {
        
        if(ItemRememberer.inst != null && ItemRememberer.inst.i == value) Destroy(gameObject);
    }
}
