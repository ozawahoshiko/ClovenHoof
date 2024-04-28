using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish2 : MonoBehaviour
{
    [SerializeField] DishSpace2[] spaces2;
    Food food0, food1, food2, food3, food4;

    public AudioClip petya;
    AudioSource audioSource;

    public static Dish2 instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }
    //お皿のスペースにフード渡す
    public void OnclickSpace(int position2)
    {
        audioSource.PlayOneShot(petya);
        spaces2[position2].SetFood(PassFood());
    }
   
    //盛り付けからフード受け取って渡す
    public Food PassFood()
    {
        return moritukedai.instance.SetFood();

        //foodPosition = moritukedai.instance.ReturnFoodPosition();

    }



    //皿の内容受け取り
    public　void GetFood()
    {
        
        food0 = spaces2[0].CheckSpace();
        food1 = spaces2[1].CheckSpace();
        food2 = spaces2[2].CheckSpace();
        food3 = spaces2[3].CheckSpace();
        food4 = spaces2[4].CheckSpace();
    }


    //合格条件とチェック
    public bool CheckFoods(int f1,int f2,int f3, int f4, int f5)
    {
        GetFood();
       
        //Debug.Log("a"+ (int)food0.type + "b" + (int)food1.type + "c" + (int)food2.type + "d" + (int)food3.type + "e" + (int)food4.type);
        if (food0!=null&& food1 != null && food2 != null)
        {
            if (f1 == (int)food0.type && f2 == (int)food1.type &&
                f3 == (int)food2.type && f4 == (int)food3.type && f5 == (int)food4.type)
            {
                return true;
            }
            return false;
        }
        return false;

    }

}
