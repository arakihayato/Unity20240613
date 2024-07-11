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
        this.scoreTextObject.GetComponent<TextMeshProUGUI>().text = "SCORE:" + SceneData.score;

        //GameOver
        if (SceneData.totalBlocks == 0)
        {
            this.gameResultObject.GetComponent<TextMeshProUGUI>().text = "GAME CLEAR";
            this.gameResultObject.GetComponent<TextMeshProUGUI>().color = Color.yellow;
        }
        else
        {
            this.gameResultObject.GetComponent<TextMeshProUGUI>().text = "GAME OVER";
            this.gameResultObject.GetComponent<TextMeshProUGUI>().color = Color.red;
        }
    }

    public void OnStartButtonPreseed()
    {
        GameManager.instance.ReturnToStart();
    }
}
