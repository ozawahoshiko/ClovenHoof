using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class Stage00 : MonoBehaviour
{
    public GameObject scrpt1, scrpt2, scrpt3, scrpt4;
    public AudioClip thunder;
    AudioSource audioSource;
    // �����ɃC���X�y�N�^�[��ł��炩���ߕ����̃Z�b�g
    [SerializeField] private TimelineAsset timelines;
    //PlayableDirector�^�̕ϐ�director��錾
    private PlayableDirector director;
    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
        scrpt1.SetActive(true);
        scrpt2.SetActive(false);
        scrpt3.SetActive(false);
        scrpt4.SetActive(false);
    }

    public void gazouChange()
    {
        scrpt1.SetActive(false);
        scrpt2.SetActive(true);
    }
    public void gazouChange2()
    {
        scrpt2.SetActive(false);
        scrpt3.SetActive(true);
    }
    public void gazouChange3()
    {
        scrpt3.SetActive(false);
        scrpt4.SetActive(true);
        director.Play(timelines);
    }
    public void thunderSound()
    {
        audioSource.PlayOneShot(thunder);
    }


}
