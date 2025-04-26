using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour
{
    public GameObject rockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenRock", 3,1 );
    }
    //隕石を一秒に2回生成するためにInvokeRepeating関数を使用
    //InvokeRepeating(第一引数の関数を第二引数の秒数ごとに実行)

    // Update is called once per frame
    void GenRock()
    {
        Instantiate(rockPrefab, new Vector3(-6f + 10 * Random.value,6,0),Quaternion.identity);
    }
}
