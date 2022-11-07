using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

namespace change{

public class SoundScript : MonoBehaviour
{
  AudioSource audioSource;

    void Start()
    {
      audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound() //音声再生
    {
      Debug.Log("Sound Play!!");
      audioSource.Play();
    }
    public void StopSound() //音声ストップ
    {
      audioSource.Stop();
    }
  }
}
