using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scora : MonoBehaviour
{
    GameObject scora;
    GameObject block;
    static int TotalScora = 0;
    static string BlockScript;
    // Start is called before the first frame update
    void Start()
    {
        this.scora = GameObject.Find("Scora");
        this.block = GameObject.Find("BlockPrefab");
    }

    public void Score(int scora)
    {
        TotalScora += scora;
    }

    // Update is called once per frame
    void Update()
    {
        this.scora.GetComponent<TextMeshProUGUI>().text = "SCORE:";
    }
}
