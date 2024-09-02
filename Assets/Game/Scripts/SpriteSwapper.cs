using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSwapper : MonoBehaviour
{
    [SerializeField] private static float timeToSwap = 0.8f;
    public Sprite[] sprites = new Sprite[2];
    private Image SR;
    void Start()
    {
        SR = GetComponent<Image>();
        StartCoroutine(Swapper());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Swapper()
    {
        SR.sprite = sprites[0];
        yield return new WaitForSeconds(timeToSwap);
        SR.sprite = sprites[1];
        yield return new WaitForSeconds(timeToSwap);
        StartCoroutine(Swapper());
    }
}
