using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolSclipt : MonoBehaviour
{
    //ボールの移動の速さの指定
    public float speed = 5.0f;
    Rigidbody myRigidBody;
    //速さの最小値
    public float minSpeed = 5.0f;
    //速さの最大値
    public float maxSpeed = 10.0f;
    Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        //Righdbodyにアクセスして変数として保持しておく
        myRigidBody = GetComponent<Rigidbody>();
        //右斜め45度に進む
        myRigidBody.velocity = new Vector3(speed, speed, 0f);
        myTransform = transform;
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bar"))
        {
            //Barの位置を取得
            Vector3 barPos = collision.transform.position;
            //Ballの位置も取得
            Vector3 ballPos = myTransform.position;
            //Barから見たBallの方向を計算
            Vector3 direction = (ballPos - barPos).normalized;
            //速さの取得
            float speed = myRigidBody.velocity.magnitude;
            //速度を変更
            myRigidBody.velocity = direction * speed;
        }
    }




    // Update is called once per frame
    void Update()
    {

        //現在の速さを取得
        Vector3 velocity = myRigidBody.velocity;
        //速さ計算
        float clampSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);
        //速度の変更
        myRigidBody.velocity = velocity.normalized * clampSpeed;
    }
}
