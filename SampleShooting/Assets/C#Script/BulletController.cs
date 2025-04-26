using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public GameObject explosionPrefab;

    public GameObject _ExplosionSound;

    public AudioClip sound1;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //_ExplosionSound = GetComponent<ExplosionSound>();
        //audioSource = GetComponent<AudioSource>();
        audioSource = GameObject.Find ("GameObject (3)").GetComponent<AudioSource>();
        Debug.Log("abc");
        Debug.Log(_ExplosionSound);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,01f,0);
        //translate関数を使い、球を毎フレーム0.2fずつy軸方向に動かす

        if(transform.position. y>5){
            Destroy(gameObject);
            //画面の外に弾が出た場合の措置　球を消す
        }
    }

    void OnTriggerEnter2D(Collider2D coll){

        GameObject.Find("Canvas").GetComponent<UIController>().AddScore();
        //UIcontrollerの中にあるAddScoreを呼び出す
        //衝突したときにスコアを更新する

        GameObject effect = Instantiate(explosionPrefab,transform.position,Quaternion.identity) as GameObject;
        Destroy(effect, 1.0f);
        //爆発エフェクトの追加

        Destroy(coll.gameObject);
        Destroy(gameObject);
        //衝突判定の実装4
        
        Debug.Log("爆発！");
        //GameObject.Find ("GameObject (3)").GetComponent<AudioSource>();
        audioSource.Play();
        //爆発音を鳴らす

        //Debug.Log(_ExplosionSound);
        //_ExplosionSound = new ExplosionSound();
        //_ExplosionSound.Sound();
        
    }
}
