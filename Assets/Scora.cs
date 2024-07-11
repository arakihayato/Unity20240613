using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class Scora : MonoBehaviour
{
    //�N���X�̗B��̃C���X�^���X��ێ����邽�߂̐ÓI�ȕϐ�
    public static Scora instance;

    //�X�R�A��\�����邽�߂̃R���|�[�l���g�ƃg�[�^���X�R�A
    private TextMeshProUGUI scoreText;
    public int totalScore = 0;
    //�v���C�x�[�g�R���X�g���N�^
    private void Awake()
    {
        //�C���X�^���X�����݂��Ȃ��ꍇ�͂��̃C���X�^���X��ݒ�
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);//�V�[�����܂����ł��C���X�^���X��ێ�
            
        }
        else
        {
            Destroy(gameObject);//���łɃC���X�^���X�����݂���ꍇ�͐V�����C���X�^���X��j��
        }
    }
    //���f����ꂽ�߂̃��\�b�h�𐶐�
    private void start()
    {
        Initialize();
        UpdateScoraText();
    }

    //�X�R�A���X�V����Test�R���|�[�l���g�ɔ��f����
    public void ScoraManager(int scora)
    {
        totalScore += scora;
        //�R���|�[�l���g�ɕ\������
        UpdateScoraText();
    }

    private void UpdateScoraText()
    {
        if (scoreText != null)
        {

            scoreText.text = "Score: " + totalScore.ToString();
        }
    }

    //�g�[�^���̃X�R�A
    public int GetCurrentScore()
    {
        return totalScore;
    }

    //������
    public void Initialize()
    {
        //�X�R�A�̃^�O���擾���A�X�R�A��������������
        GameObject scoreTextObject = GameObject.FindWithTag("ScoreText");

        if (scoreTextObject != null)
        {
            scoreText = scoreTextObject.GetComponent<TextMeshProUGUI>();
            UpdateScoraText();
        }
    }
    //�V�[�����Ăяo���ꂽ���ɃC�x���g��o�^
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //�V�[�������[�h���ꂽ��ď�����
        StartCoroutine(InitializeAfterFrame());
    }

    private IEnumerator InitializeAfterFrame()
    {
        //�t���[�����I���܂ő҂�
        yield return null;
        Initialize();
    }

    //�C�x���g�̉���
    private void OnDestroy()
    {
        //����
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

}
