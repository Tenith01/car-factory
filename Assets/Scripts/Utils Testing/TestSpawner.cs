using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawner : MonoBehaviour
{
   [SerializeField] 
   private Transform Spawnpont;
   
   [SerializeField] 
   private GameObject prefab;

   private bool isSpawned = false;

   private GameObject instantiatedObject;
   public void SpawnMachine()
   {
      if (isSpawned == false)
      { 
         instantiatedObject = Instantiate(prefab, Spawnpont.position, Spawnpont.rotation);
         instantiatedObject.transform.parent = Spawnpont;
         isSpawned = true;
      }
      else
      {
         GameObject.Destroy(instantiatedObject);
         isSpawned = false;
      }
      
   }
}
