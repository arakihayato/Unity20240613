using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using static Unity.Collections.AllocatorManager;
public class GameManager : MonoBehaviour
{
    //唯一のインスタンスとして静的変数を生成
    public static GameManager instance;
    public void Awake()
    {
        if (instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //スタートゲームメソッド
    public void StartGame()
    {
        SceneData.score = 0;
        SceneManager.LoadScene("Game");
    }
    //ゲームメソッド
    public void EndGame(int Blocks)
    {
        //獲得したスコアとリザルト画面を生成
        SceneData.score = Scora.instance.GetCurrentScore();
        SceneData.totalBlocks = Blocks;
        SceneManager.LoadScene("Result");
    }
    //リスタートメソッド
}
