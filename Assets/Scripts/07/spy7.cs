using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spy7 : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;

    public void TalkSpy()
    {


     flowchart.SendFungusMessage("spydi");
         
    }
}
