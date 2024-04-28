using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Showtime : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    public void Onclick()
    {
        flowchart.SendFungusMessage("transp");
    }
}
