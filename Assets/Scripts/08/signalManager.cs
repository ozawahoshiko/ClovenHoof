using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signalManager : MonoBehaviour

{
    public Fungus.Flowchart flowchart = null;

    //����������
    public void cutInVoice()
        {
            flowchart.SendFungusMessage("cutin");

    }
    //���q����I
    public void cutInVoice2()
    {
        flowchart.SendFungusMessage("cutin2");

    }

    //���w�i�I���
    public void cutInVoice3()
    {
        flowchart.SendFungusMessage("cutin3");

    }


}
