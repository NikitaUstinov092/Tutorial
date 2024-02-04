using System;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
   public event Action OnPlayerReachTrigger;
   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
         OnPlayerReachTrigger?.Invoke();
      }
   }
}
