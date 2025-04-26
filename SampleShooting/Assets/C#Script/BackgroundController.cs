using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-0.3f,0);
        if(transform.position.y < -4.9f){
            transform.position = new Vector3(0,4.9f,0);
            //毎フレーム下方向に-0.02移動
            //背景画像の座標が一定以上小さくなった時に、元の位置に戻す
        }
    }
}
