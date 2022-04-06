
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class DataStruct : MonoBehaviour
{
   private const int amount = 1000000;
   private int[] m_Array;
   private List<int> m_List;
   private Dictionary<int, int> m_Dict;
   private HashSet<int> m_HashSet;
   private int temp;
   private int[] newArray;

   private void Start()
   {
      m_Array = new int[amount];
      m_List = new List<int>();
      m_Dict = new Dictionary<int, int>();
      m_HashSet = new HashSet<int>();
      
      AddArrayElement();
      AddDictElement();
      AddHashElement();
      AddListElement();
      
      newArray = new int[m_Array.Length - 1];
   }

   void AddArrayElement()
   {
      for (int i = 0; i < amount; i++)
      {
         m_Array[i] = Random.Range(10, 100);
      }
   }

   void AddListElement()
   {
      for (int i = 0; i < amount; i++)
      {
         m_List.Add(Random.Range(10, 100));
      }
   }

   void AddDictElement()
   {
      for (int i = 0; i < amount; i++)
      {
         m_Dict.Add(i, Random.Range(10, 100));
      }
   }

   void AddHashElement()
   {
      for (int i = 0; i < amount; i++)
      {
         m_HashSet.Add(i);
      }
   }
   
   void ReadArrayElement()
   {
      foreach (var element in m_Array)
      {
         temp = element;
      }
   }

   void ReadListElement()
   {
      foreach (var element in m_List)
      {
         temp = element;
      }
   }

   void ReadDictElement()
   {
      foreach (var element in m_Dict)
      {
         temp = element.Value;
      }
   }

   void ReadHashElement()
   {
      foreach (int i in m_HashSet)
      {
         temp = i;
      }
   }

   bool ArrayContains(int j)
   {
      foreach (var i in m_Array)
      {
         if (i == j)
         {
            return true;
         }
      }
      return false;
   }

   bool ListContains(int j)
   {
      return m_List.Contains(j);
   }

   bool DictContains(int j)
   {
      return m_Dict.ContainsValue(j);
   }

   bool HashContains(int j)
   {
      return m_HashSet.Contains(j);
   }

   void RemoveArrayElement(int j)
   {
      int k = 0;
      bool f = false;
      for (int i = 0; i < m_Array.Length; i++)
      {
         if (m_Array[i] == j && !f)
         {
            i++;
            f = true;
         }

         newArray[k] = m_Array[i];
         k++;
      }
   }

   void RemoveListElement(int j)
   {
      m_List.Remove(j);
   }

   void RemoveDictElement(int j)
   {
      m_Dict.Remove(j);
   }

   void RemoveHashElement(int j)
   {
      m_HashSet.Remove(j);
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         /*ReadArrayElement();
         ReadDictElement();
         ReadHashElement();
         ReadListElement();*/

         /*ArrayContains(Random.Range(10,100));
         ListContains(Random.Range(10, 100));
         DictContains(Random.Range(10, 100));
         HashContains(Random.Range(10, 100));*/
         
         RemoveArrayElement(Random.Range(10,100));
         RemoveListElement(Random.Range(10,100));
         RemoveDictElement(Random.Range(10,100));
         RemoveHashElement(Random.Range(10,100));
      }
   }
}
