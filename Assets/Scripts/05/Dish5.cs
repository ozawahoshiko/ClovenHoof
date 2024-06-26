using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish5 : MonoBehaviour
{
    [SerializeField] DishSpace5[] spaces;
    Food food0, food1, food2, food3;
    public static Dish5 instance;
    public AudioClip petya;
    AudioSource audioSource;
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
        spaces[position2].SetFood(PassFood());
    }

    //盛り付けからフード受け取って渡す
    public Food PassFood()
    {
        return moritukedai.instance.SetFood();

        //foodPosition = moritukedai.instance.ReturnFoodPosition();

    }



    //皿の内容受け取り
    public void GetFood()
    {
        
        food0 = spaces[0].CheckSpace();
        food1 = spaces[1].CheckSpace();
        food2 = spaces[2].CheckSpace();
        food3 = spaces[3].CheckSpace();
        
    }


    //合格条件とチェック
    public bool CheckFoods5(int f1, int f2, int f3, int f4)
    {
        
        GetFood();

        if (food0 != null && food1 != null && food2 != null)
        {
            if (f1 == (int)food0.type && f2 == (int)food1.type &&
                f3 == (int)food2.type && f4 == (int)food3.type)
            {
                return true;
            }
            return false;
        }
        return false;
        
        
    }
  

   

}
