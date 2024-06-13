using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolSclipt : MonoBehaviour
{
    //ボールの移動の速さの指定
    public float speed = 5.0f;
    Rigidbody myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        //Righdbodyにアクセスして変数として保持しておく
        myRigidBody = GetComponent<Rigidbody>();
        //右斜め45度に進む
        myRigidBody.velocity = new Vector3(speed, speed, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
