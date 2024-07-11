using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class Scora : MonoBehaviour
{
    //クラスの唯一のインスタンスを保持するための静的な変数
    public static Scora instance;

    //スコアを表示するためのコンポーネントとトータルスコア
    private TextMeshProUGUI scoreText;
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
        Initialize();
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
        if (scoreText != null)
        {

            scoreText.text = "Score: " + totalScore.ToString();
        }
    }

    //トータルのスコア
    public int GetCurrentScore()
    {
        return totalScore;
    }

    //初期化
    public void Initialize()
    {
        //スコアのタグを取得し、スコアを初期化させる
        GameObject scoreTextObject = GameObject.FindWithTag("ScoreText");

        if (scoreTextObject != null)
        {
            scoreText = scoreTextObject.GetComponent<TextMeshProUGUI>();
            UpdateScoraText();
        }
    }
    //シーンが呼び出された時にイベントを登録
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //シーンがロードされた後再初期化
        StartCoroutine(InitializeAfterFrame());
    }

    private IEnumerator InitializeAfterFrame()
    {
        //フレームが終わるまで待つ
        yield return null;
        Initialize();
    }

    //イベントの解除
    private void OnDestroy()
    {
        //解除
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

}
