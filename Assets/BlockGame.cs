using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.SceneManagement;
public class BlockGame : MonoBehaviour
{
    //ゲームオブジェクトの追加
    public GameObject blockPrefab;
    //スパン
    float span = 0.3f;
    int row =4;
    int col = 7;
    int BlockScaleX = 2;
    int BlockScaleY = 1;
    int totalBlocks = 0;
    // Start is called before the first frame update

    public AudioClip sound1;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //ブロックのポジション
        int px, py;
        px = -7;
        py = 5;
        int scoreDefult = 0;
        totalBlocks = row * col;
        //ブロックの配置
        for (int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                GameObject block = Instantiate(blockPrefab);
                block.transform.position=new Vector3(px+(j*(span+BlockScaleX)), py +(i * (span + BlockScaleY)), 0);
                block.tag = "Blocks";
            }
        }

        Scora.instance.ScoraManager(scoreDefult);
    }

    public void BlocklDestroyed()
    {
        totalBlocks--;
        SceneData.totalBlocks = totalBlocks;
        audioSource.PlayOneShot(sound1);
        if (totalBlocks <= 0)
        {
            GameManager.instance.EndGame(totalBlocks);
        }
    }
}
