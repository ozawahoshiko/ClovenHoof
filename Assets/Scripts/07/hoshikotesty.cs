
using UnityEngine;
using System.Text;
using UnityEngine.UI;
//using System.Text;

public class hoshikotesty : MonoBehaviour
{
    string secretword = null;
    [SerializeField] GameObject secretwords;
    public Fungus.Flowchart flowchart = null;
    public InputField inputfield;
    //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    //static Encoding shiftjisEnc = Encoding.GetEncoding("Shift_JIS");
    
   
    public void Start()
    {
        secretwords.SetActive(false);
    }

   public void hoshiko()
    {


        secretwords.SetActive(true);
       
    }

    //Ç¢Ç©Ç¬Ç¢Ç©
    //ëSäpÇ©Ç«Ç§Ç©
    /*
    public static bool isFullWitdh(string chkStr)
    {
        int chrByteNum = shiftjisEnc.GetByteCount(chkStr);
        bool isAllFullWidth = (chrByteNum == chkStr.Length * 2);
        return isAllFullWidth;
    }

    //ï∂éöêî
    public static int numFullWidth(string chkStr)
    {
        int chrByteNum = shiftjisEnc.GetByteCount(chkStr);
        int numFullWidth = chrByteNum - chkStr.Length;
        return numFullWidth;
    }*/
    public void CheckLine()
    {
        secretword = inputfield.text;
        
        //if (isFullWitdh(secretword) && numFullWidth(secretword) == 6)
      //  {
            Debug.Log(secretword);
            if (secretword == "Ç¢Ç≈ÇÊÇ†Ç≠Ç‹")
            {
                flowchart.SendFungusMessage("trueword");
                HideUsedItem.instance.HideUsedItems(53);
                HideUsedItem.instance.HideUsedItems(56);
                HideUsedItem.instance.HideUsedItems(57);
            }
            else
            {
                flowchart.SendFungusMessage("falseword");
            }

        /*}
        else
        {
            flowchart.SendFungusMessage("falseword");
        }*/

        secretwords.SetActive(false);
        //BlockBG.instance.HideBlock();
    }

}
