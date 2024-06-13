using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public int Scora = 0;
    //なにかとぶつかったときビルドインメソッド
    private void OnCollisionEnter(Collision collision)
    {
        Scora += 100;
        Destroy(gameObject);
    }
}
