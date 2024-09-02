using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolverCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(ItemRememberer.inst.i != 2) Destroy(gameObject);
    }
}
