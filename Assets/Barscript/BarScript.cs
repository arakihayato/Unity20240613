using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScript : MonoBehaviour
{
    public float speed = 10;
    Rigidbody myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //左右のキーを入力すると速度を変更して移動
        myRigidBody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //ボールが衝突したら効果音を鳴らす
        if (collision.gameObject.CompareTag("Ball"))
        {
            GetComponent<AudioSource>().Play();
        }
    }

}
