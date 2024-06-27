using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class BlockScript : MonoBehaviour
{
    public int score = 10;
    private BlockGame generator;

    private void Start()
    {
        generator = FindObjectOfType<BlockGame>();
    }

    //�Ȃɂ��ƂԂ������Ƃ��r���h�C�����\�b�h
    private void OnCollisionEnter(Collision collision)
    {
        if(Scora.instance!=null)
        {
            Scora.instance.ScoraManager(score);
        }
        else
        {
            //Debug.LogError("�C���X�^���X������܂���B");
        }
        generator.BlocklDestroyed();

        Destroy(gameObject);
    }
}
