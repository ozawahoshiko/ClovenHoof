using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class mummys8 : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    public void OnclickDad()
    {
        flowchart.SendFungusMessage("mummydad");
    }
    public void OnclickSon()
    {
        flowchart.SendFungusMessage("mummyson");
    }
}
