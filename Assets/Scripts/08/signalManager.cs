using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signalManager : MonoBehaviour

{
    public Fungus.Flowchart flowchart = null;

    //うおおおお
    public void cutInVoice()
        {
            flowchart.SendFungusMessage("cutin");

    }
    //お客さん！
    public void cutInVoice2()
    {
        flowchart.SendFungusMessage("cutin2");

    }

    //黒背景終わり
    public void cutInVoice3()
    {
        flowchart.SendFungusMessage("cutin3");

    }


}
