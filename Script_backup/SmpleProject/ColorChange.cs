using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

namespace change{

public class ColorChange : MonoBehaviour
{
  MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
      mesh = GetComponent<MeshRenderer>();
    }

    public IEnumerator Transparent(){ //透明から不透明　だんだん見えてくる
      for ( int i = 0 ; i < 51 ; i++ ){ //RGBの最大値が255で5ずつ増やしているので、255÷5=51　51回繰り返す
        mesh.material.color = mesh.material.color + new Color32(0,0,0,5);
        yield return new WaitForSeconds(0.001f);
      }
    }

    public IEnumerator Opacity(){ //不透明から透明　だんだん見えなくなる
      for ( int i = 0 ; i < 51 ; i++ ){
        mesh.material.color = mesh.material.color - new Color32(0,0,0,5);
        yield return new WaitForSeconds(0.001f);
      }
    }

    public IEnumerator StopMotion(){
      Debug.Log("Opacity finished.");
      yield return new WaitForSeconds(10.0f);
      Debug.Log("Transparent Start.");
    }

    public IEnumerator OpacityandTransparent(){
      for ( int i = 0 ; i < 51 ; i++ ){
        mesh.material.color = mesh.material.color - new Color32(0,0,0,5);
        yield return new WaitForSeconds(0.001f);
      }
        yield return new WaitForSeconds(10.0f); //StopMotionメソッド入れても待ちは特に無く(ただデバッグログを10秒待つだけ)すぐに次のプログラム(不透明化)が始まっちゃう。
        for ( int i = 0 ; i < 51 ; i++ ){
        mesh.material.color = mesh.material.color + new Color32(0,0,0,5);
        yield return new WaitForSeconds(0.001f);
        }

    }
  }
}
