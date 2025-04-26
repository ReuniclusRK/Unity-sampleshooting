using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;
    // Start is called before the first frame update
    void Start()
    {
        this.fallSpeed = 0.2f + 0.2f * Random.value;
        this.rotSpeed = 0.5f + 3f * Random.value;
        //岩の落下スピードをランダムにする
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);
        //岩が回転しながら落下するようにtranslate関数とRotate関数使用

        if(transform.position.y < -5.5f){
           //GameObject.Find ("Canvas").GetComponent<UIController> ().GameOver ();            //画面端を超えたかどうか判定

            Destroy(gameObject);
            //画面を出た場合に自身を破壊する
        }
    }
}
