using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolSclipt : MonoBehaviour
{
    //�{�[���̈ړ��̑����̎w��
    public float speed = 5.0f;
    Rigidbody myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        //Righdbody�ɃA�N�Z�X���ĕϐ��Ƃ��ĕێ����Ă���
        myRigidBody = GetComponent<Rigidbody>();
        //�E�΂�45�x�ɐi��
        myRigidBody.velocity = new Vector3(speed, speed, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
