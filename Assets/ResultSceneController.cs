using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultSceneController : MonoBehaviour
{
    public GameObject scoreTextObject;
    public GameObject gameResultObject;
    // Start is called before the first frame update
    void Start()
    {
        scoreTextObject.GetComponent<TextMeshProUGUI>().text = "SCORE:" + SceneData.score;

        //GameOver
        if (SceneData.totalBlocks == 0)
        {
            gameResultObject.GetComponent<TextMeshProUGUI>().text = "GAME CLEAR";
            gameResultObject.GetComponent<TextMeshProUGUI>().color = Color.yellow;
        }
        else
        {
            gameResultObject.GetComponent<TextMeshProUGUI>().text = "GAME OVER";
            gameResultObject.GetComponent<TextMeshProUGUI>().color = Color.red;
        }
    }

    public void OnStartButtonPreseed()
    {
        GameManager.instance.ReturnToStart();
    }
}
