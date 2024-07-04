using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class Scora : MonoBehaviour
{
    //クラスの唯一のインスタンスを保持するための静的な変数
    public static Scora instance;
    int a = 0;

    //スコアを表示するためのコンポーネントとトータルスコア
    public GameObject ScoraText;
    public int totalScore = 0;
    //プライベートコンストラクタ
    private void Awake()
    {
        //インスタンスが存在しない場合はこのインスタンスを設定
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);//シーンをまたいでもインスタンスを保持
        }
        else
        {
            Destroy(gameObject);//すでにインスタンスが存在する場合は新しいインスタンスを破棄
        }
    }
    //反映されれためのメソッドを生成
    private void start()
    {
        UpdateScoraText();
    }

    //スコアを更新してTestコンポーネントに反映する
    public void ScoraManager(int scora)
    {
        totalScore += scora;
        //コンポーネントに表示する
        UpdateScoraText();
    }

    private void UpdateScoraText()
    {
        this.ScoraText.GetComponent<TextMeshProUGUI>().text = "Scora:" + totalScore.ToString();
    }

    //トータルのスコア
    public int GetCurrentScore()
    {
        return totalScore;
    }
}
