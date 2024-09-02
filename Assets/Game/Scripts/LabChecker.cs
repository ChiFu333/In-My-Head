using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabChecker : MonoBehaviour
{
    public bool left;
    void Start()
    {
        if(ItemRememberer.inst.leftInLab != left) Destroy(gameObject);
    }
}
