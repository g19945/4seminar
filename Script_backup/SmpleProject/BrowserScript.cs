using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;
using System;
using change;

public class BrowserScript : MonoBehaviour
{

  private Browser browser;
  public GameObject Cube;
  public GameObject Furniture;

    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("Start");
      browser = GetComponent<Browser>();

      //ページ遷移時にコールバック関数を毎回登録するように指定
      Action<JSONNode> act = delegate { RegisterCallbakFunctions(); };
      browser.onLoad += act;
    }

    void RegisterCallbakFunctions()
    {
      ColorChange CCCube = Cube.GetComponent<ColorChange>();
      SoundScript sound = Cube.GetComponent<SoundScript>(); //ゾンビ声
      ColorChange CCFurniture = Furniture.GetComponent<ColorChange>();

      browser.RegisterFunction("horrorMouseOver", args => {
        Debug.Log("horrorMouseOver : recieve from BrowserScript.cs");

        CCCube.StartCoroutine("Transparent");
        sound.PlaySound();
        //CCFurniture.StartCoroutine("Opacity");

      }
      );

      browser.RegisterFunction("safeMouseOut", args => {
        Debug.Log("safeMouseOut : recieve from BrowserScript.cs");

        CCCube.StartCoroutine("Opacity");
        sound.StopSound();
        CCFurniture.StartCoroutine("OpacityandTransparent"); //画面を不透明から透明にしてheavenシーンに
      }
      );
    }
  }
