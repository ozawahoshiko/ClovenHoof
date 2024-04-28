using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class mobTalk : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    int mobmanCounter = 0;
    int mobsaqCounter = 0;
    // Start is called before the first frame update
    public void mobmantalk()
    {
        if (mobmanCounter > 8)
        {
            flowchart.SendFungusMessage("mobtalk3");
           
        }
        else if(mobmanCounter>2)
        {
            flowchart.SendFungusMessage("mobtalk2");
            mobmanCounter++;
        }
        else
        {
            flowchart.SendFungusMessage("mobtalk1");
            mobmanCounter++;
            Debug.Log("sssssss");
        }
        
    }

    public void mobsaqubastalk()
    {
        if (mobsaqCounter > 2)
        {
            flowchart.SendFungusMessage("saqtalk2");
        }
        else
        {
            flowchart.SendFungusMessage("saqtalk1");
            mobsaqCounter++;
        }

    }
    public void mobmantalk8()
    {
        flowchart.SendFungusMessage("mobtalk4");
    }
    public void mobsaqubastalk8()
    {
     
            flowchart.SendFungusMessage("saqtalk3");
     

    }

}
