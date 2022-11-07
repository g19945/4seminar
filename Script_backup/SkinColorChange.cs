using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

namespace change{

public class SkinColorChange : MonoBehaviour
{
  SkinnedMeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
      mesh = GetComponent<SkinnedMeshRenderer>();
    }

    public IEnumerator Transparent(){ //透明化
      for ( int i = 0 ; i < 51 ; i++ ){ //RGBの最大値が255で5ずつ増やしているので、255÷5=51　51回繰り返す
        mesh.material.color = mesh.material.color + new Color32(0,0,0,5);
        yield return new WaitForSeconds(0.001f);
      }
    }

    public IEnumerator Opacity(){ //不透明化
      for ( int i = 0 ; i < 51 ; i++ ){
        mesh.material.color = mesh.material.color - new Color32(0,0,0,5);
        yield return new WaitForSeconds(0.001f);
      }
    }
  }
}
