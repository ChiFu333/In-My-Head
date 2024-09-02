using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimIterator : MonoBehaviour
{
    public bool startFromAwake = true;
    [Serializable] public struct anim
    {
        public float time;
        public GameObject obj;
        public UnityEvent doSome;
    }
    public anim[] Anims;
    public UnityEvent animEnded;
    void Start()
    {
        if(startFromAwake) StartCoroutine(Iterate());
    }
    public void ForceIterate() => StartCoroutine(Iterate());

    public IEnumerator Iterate()
    {
        for(int i = 0; i < Anims.Length; i++)
        {
            for(int j = 0; j < Anims.Length; j++)
            {
                Anims[j].obj.SetActive(i == j);
            }
            Anims[i].doSome.Invoke();
            yield return new WaitForSeconds(Anims[i].time);
        }
        animEnded.Invoke();
    }
}