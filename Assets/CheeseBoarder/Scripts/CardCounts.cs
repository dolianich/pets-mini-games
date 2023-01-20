using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCounts : MonoBehaviour
{
   int number;

   static CardCounts instance;

   void Awake() 
   {
        ManageSingleton();
   }

   void ManageSingleton()
   {
        if(instance !=null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        
        }

        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
   }

   public int GetNumber()
   {
        return number;
   }

   public void ModifyCounts(int value)
   {
        number++;
        Debug.Log(number);

   }

   public void ResetNumber()
   {
        number = 0;
   }

}
