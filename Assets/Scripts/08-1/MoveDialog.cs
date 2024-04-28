using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDialog : MonoBehaviour
{
    public void moveDialog()
    {
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.y += -640f;
        this.transform.localPosition = localpos;
    }
    public void moveDialog03()
    {
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.y += 600f;
        this.transform.localPosition = localpos;
    }
}
