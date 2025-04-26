using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ending : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //使いそうなやつ保存

        //int total_score = PlayerPrefs.GetInt("TOTAL SCORE",0);
        //TextMeshProUGUI gui = GetComponent<TextMeshProUGUI>();
        //gui.text = total_score.ToString();

        GameObject.Find("Canvas").GetComponent<UIController>().AddScore();
        //UIcontrollerの中にあるAddScoreを呼び出す
        //衝突したときにスコアを更新する
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
