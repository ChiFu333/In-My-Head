using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Helper", menuName = "ScriptableObjects/Helper")]
public class HelpSO : ScriptableObject
{
    public void SetItemValue(int v)
    {
        ItemRememberer.inst.SetValue(v);
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void PlaySound(AudioClip clip)
    {
        AudioManager.inst.Play(clip);
    }
    public void StartMusic(AudioClip clip)
    {
        AudioManager.inst.PlayMusic(clip);
    }
    public void RemoveMusic(bool a)
    {
        if(a)
        {
            AudioManager.inst.SetMusicVolume(0);
        }
        else
        {
            AudioManager.inst.SetMusicVolume(1f);
        }
    }
    public void SetLabPos(bool left) => ItemRememberer.inst.leftInLab = left;
    public void SaveEnd(int id) => ItemRememberer.inst.endings[id-1] = true;
    public void loadBullet() => ItemRememberer.inst.i = 4;
    public void LoadBookEnd()
    {
        if(ItemRememberer.inst.i == 3)
        {
            LoadScene("IbuHomeGood");
        }
        else
        {
            LoadScene("IbuHomeBad");
        }
    }
    public void LoadRevEnd()
    {
        if(ItemRememberer.inst.i == 4)
        {
            LoadScene("RevolverGood1");
        }
        else
        {
            LoadScene("RevolverBad1");
        }
    }
}
