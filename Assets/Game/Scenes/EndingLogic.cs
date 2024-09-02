using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingLogic : MonoBehaviour
{
    public int id;
    public GameObject p, names;
    void Start()
    {
        p.SetActive(!ItemRememberer.inst.endings[id]);
        names.SetActive(ItemRememberer.inst.endings[id]);
    }
}
