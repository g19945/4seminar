using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;
using System;
using change;

public class BrowserScript : MonoBehaviour
{

  private Browser browser;

//RoomObject
  public GameObject floorR; //floor オブジェクト化
  public GameObject floorL; //floor オブジェクト化
  public GameObject wallL; //wall オブジェクト化
  public GameObject wallR; //wall オブジェクト化
  public GameObject wallB; //wall オブジェクト化
  public GameObject ceiling; //ceiling オブジェクト化

//Ghoul

  public GameObject ghoul1; //Ghoul1 オブジェクト化
  public GameObject ghoul2; //Ghoul2 オブジェクト化
  public GameObject ghoul3; //Ghoul3 オブジェクト化
  public GameObject ghoul4; //Ghoul4 オブジェクト化
  public GameObject ghoul5; //Ghoul5 オブジェクト化
  public GameObject ghoul6; //Ghoul6 オブジェクト化
  public GameObject ghoul7; //Ghoul7 オブジェクト化
  public GameObject ghoul8; //Ghoul8 オブジェクト化
  public GameObject ghoul9; //Ghoul9 オブジェクト化
  public GameObject ghoul10; //Ghoul10 オブジェクト化

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
    //RoomObject
      ColorChange CCfloorR = floorR.GetComponent<ColorChange>(); //floor インスタンス化
      ColorChange CCfloorL = floorL.GetComponent<ColorChange>(); //floor インスタンス化
      ColorChange CCwallL = wallL.GetComponent<ColorChange>(); //wall インスタンス化
      ColorChange CCwallR = wallR.GetComponent<ColorChange>(); //wall インスタンス化
      ColorChange CCwallB = wallB.GetComponent<ColorChange>(); //wall インスタンス化
      ColorChange CCceiling = ceiling.GetComponent<ColorChange>(); //ceiling インスタンス化

    //Ghoul SkinColorChange
      SkinColorChange SCCghoul1 = ghoul1.GetComponent<SkinColorChange>(); //Ghoul1　インスタンス化
      SkinColorChange SCCghoul2 = ghoul2.GetComponent<SkinColorChange>(); //Ghoul2　インスタンス化
      SkinColorChange SCCghoul3 = ghoul3.GetComponent<SkinColorChange>(); //Ghoul3　インスタンス化
      SkinColorChange SCCghoul4 = ghoul4.GetComponent<SkinColorChange>(); //Ghoul4　インスタンス化
      SkinColorChange SCCghoul5 = ghoul5.GetComponent<SkinColorChange>(); //Ghoul5　インスタンス化
      SkinColorChange SCCghoul6 = ghoul6.GetComponent<SkinColorChange>(); //Ghoul6　インスタンス化
      SkinColorChange SCCghoul7 = ghoul7.GetComponent<SkinColorChange>(); //Ghoul7　インスタンス化
      SkinColorChange SCCghoul8 = ghoul8.GetComponent<SkinColorChange>(); //Ghoul8　インスタンス化
      SkinColorChange SCCghoul9 = ghoul9.GetComponent<SkinColorChange>(); //Ghoul9　インスタンス化
      SkinColorChange SCCghoul10 = ghoul10.GetComponent<SkinColorChange>(); //Ghoul10　インスタンス化

    //Ghoul Sound
      SoundScript SSghoul8 = ghoul8.GetComponent<SoundScript>(); //Ghoul1 インスタンス化

    //OnMouseOver「ホラー開始」
      browser.RegisterFunction("horrorMouseOver", args => {
        Debug.Log("horrorMouseOver : recieve from BrowserScript.cs");

        //RoomObject
          CCfloorR.StartCoroutine("Transparent"); //floor　透明から不透明に
          CCfloorL.StartCoroutine("Transparent"); //floor　透明から不透明に
          CCwallR.StartCoroutine("Transparent"); //wall　透明から不透明に
          CCwallL.StartCoroutine("Transparent"); //wall　透明から不透明に
          CCwallB.StartCoroutine("Transparent"); //wall　透明から不透明に
          CCceiling.StartCoroutine("Transparent"); //ceiling　透明から不透明に


        //Ghoul SkinColorChange
          SCCghoul1.StartCoroutine("Transparent"); //Ghoul1 透明から不透明に
          SCCghoul2.StartCoroutine("Transparent"); //Ghoul2 透明から不透明に
          SCCghoul3.StartCoroutine("Transparent"); //Ghoul3 透明から不透明に
          SCCghoul4.StartCoroutine("Transparent"); //Ghoul4 透明から不透明に
          SCCghoul5.StartCoroutine("Transparent"); //Ghoul5 透明から不透明に
          SCCghoul6.StartCoroutine("Transparent"); //Ghoul6 透明から不透明に
          SCCghoul7.StartCoroutine("Transparent"); //Ghoul7 透明から不透明に
          SCCghoul8.StartCoroutine("Transparent"); //Ghoul8 透明から不透明に
          SCCghoul9.StartCoroutine("Transparent"); //Ghoul9 透明から不透明に
          SCCghoul10.StartCoroutine("Transparent"); //Ghoul10 透明から不透明に

        //Ghoul Sound
          SSghoul8.PlaySound(); //Ghoul1 音声再生

        }
        );
      //OnMouseOut「ホームに戻る」
        browser.RegisterFunction("safeMouseOut", args => {
          Debug.Log("safeMouseOut : recieve from BrowserScript.cs");

          CCfloorR.StartCoroutine("Opacity"); //floor 不透明から透明に
          CCfloorL.StartCoroutine("Opacity"); //floor 不透明から透明に
          CCwallR.StartCoroutine("Opacity"); //wall 不透明から透明に
          CCwallL.StartCoroutine("Opacity"); //wall 不透明から透明に
          CCwallB.StartCoroutine("Opacity"); //wall 不透明から透明に
          CCceiling.StartCoroutine("Opacity"); //ceiling 不透明から透明に

        //Ghoul SkinColorChange
          SCCghoul1.StartCoroutine("Opacity"); //Ghoul1 不透明から透明に
          SCCghoul2.StartCoroutine("Opacity"); //Ghoul2 不透明から透明に
          SCCghoul3.StartCoroutine("Opacity"); //Ghoul3 不透明から透明に
          SCCghoul4.StartCoroutine("Opacity"); //Ghoul4 不透明から透明に
          SCCghoul5.StartCoroutine("Opacity"); //Ghoul5 不透明から透明に
          SCCghoul6.StartCoroutine("Opacity"); //Ghoul6 不透明から透明に
          SCCghoul7.StartCoroutine("Opacity"); //Ghoul7 不透明から透明に
          SCCghoul8.StartCoroutine("Opacity"); //Ghoul8 不透明から透明に
          SCCghoul9.StartCoroutine("Opacity"); //Ghoul9 不透明から透明に
          SCCghoul10.StartCoroutine("Opacity"); //Ghoul10 不透明から透明に

        //Ghoul Sound
          SSghoul8.StopSound(); //音声停止
        }
        );
    }
}
