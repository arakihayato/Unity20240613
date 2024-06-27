using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class GameOverSclipt : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (GameManager.instance == null)
        {
            GameManager.instance = FindAnyObjectByType<GameOverSclipt>();
        }
        int blocks = SceneData.totalBlocks;
        GameManager.instance.EndGame(blocks);
        Destroy(collision.gameObject);
    }
}
