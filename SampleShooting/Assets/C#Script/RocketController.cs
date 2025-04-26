using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class RocketController : MonoBehaviour
{
    public GameObject bulletPrefab;

    private SampleShooting sampleShooting_;

    public AudioClip sound1;
    AudioSource audioSource;
    //使用する音声ファイル

    // Start is called before the first frame update
    void Start()
    {
       sampleShooting_ = new SampleShooting();
        sampleShooting_.Enable();
        //inputsystem
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

         //if(sampleShooting_.Player.Move.triggered){
            //transform.Translate(0.02f,0,0);
        //}
        //0.02のところに正負をかけて自由に動かせるようにしたい
        //triggeredだと押したときにしか反応しないため、修正する

        //if(Input.GetKey (KeyCode.LeftArrow)){
            //transform.Translate(-0.02f,0,0);
        //}
        //keyが押されていた場合にtranslate関数を使いロケットの位置を左側へ移動させる
        //if(Input.GetKey(KeyCode.RightArrow)){
            //transform.Translate(0.02f,0,0);
        //}
        //前文同上　右側へ動かす

        if(sampleShooting_.Move.Left.IsPressed()){
            Debug.Log("左側へ移動");
            transform.Translate(-0.4f,0,0);
            //左側のキーが押されている
        }

        if(sampleShooting_.Move.Right.IsPressed()){
            Debug.Log("右側へ移動");
            transform.Translate(0.4f,0,0);
            //右側のキーが押されている
        }


         if(sampleShooting_.Player.Fire.triggered){
            Debug.Log("攻撃！");
            audioSource.PlayOneShot(sound1);
            Instantiate(bulletPrefab,transform.position,quaternion.identity);
         }
         //ボタンが押されたときに弾のprefabのインスタンスを作成
         //Prefabからインスタンスを作るためにInstantiate関数(第一因数(Prefab)、第二因数(生成位置)、第三因数(インスタンスの回転角))を使用
    }
}