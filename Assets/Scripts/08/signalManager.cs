using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signalManager : MonoBehaviour

{
    public Fungus.Flowchart flowchart = null;

    //Ç§Ç®Ç®Ç®Ç®
    public void cutInVoice()
        {
            flowchart.SendFungusMessage("cutin");

    }
    //Ç®ãqÇ≥ÇÒÅI
    public void cutInVoice2()
    {
        flowchart.SendFungusMessage("cutin2");

    }

    //çïîwåièIÇÌÇË
    public void cutInVoice3()
    {
        flowchart.SendFungusMessage("cutin3");

    }


}
