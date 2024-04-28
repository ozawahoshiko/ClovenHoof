using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
[RequireComponent(typeof(PlayableDirector))]

public class ricoInBox : MonoBehaviour
{
    [SerializeField] Item.Name axe;
    public GameObject cutIn,box,hintmenu,arrows;

    // �����ɃC���X�y�N�^�[��ł��炩���ߕ����̃Z�b�g
    [SerializeField] private TimelineAsset timelines;
    //PlayableDirector�^�̕ϐ�director��錾
    private PlayableDirector director;
    void Start()
    {
        //�����I�u�W�F�N�g�ɕt���Ă���PlayableDirector�R���|�[�l���g���擾
        director = this.GetComponent<PlayableDirector>();
    }
    public void OnclickBox()
    {
        bool clear = ItemBox13.instance.TryUseItem(axe);
        if (clear)
        {
            restaurantbgm.instance.BGMstop();
            cutIn.SetActive(true);
            //�A�j���J�n
            director.Play(timelines);
            //HideUsedItem.instance.HideUsedItems(60);
            //HideUsedItem.instance.HideUsedItems(54);
            //HideUsedItem.instance.HideUsedItems(61);
            //�{�b�N�X�����B��
            box.SetActive(false);
            hintmenu.SetActive(false);
            arrows.SetActive(false);
        }

    }

}
