using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MummySon : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
   

    public void OnclickSon()
    {
       
            flowchart.SendFungusMessage("mummyson");
           
    }

   
}
