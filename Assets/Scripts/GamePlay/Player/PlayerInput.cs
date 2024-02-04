using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
   public event Action<Vector3> Direction;
   public event Action OnFirePressed;

   [SerializeField] 
   private KeyCode _moveBack;
   
   [SerializeField] 
   private KeyCode _moveFront;
  
   [SerializeField] 
   private KeyCode _moveLeft;
  
   [SerializeField] 
   private KeyCode _moveRight;

   private void Update()
   {
       if (Input.GetMouseButtonDown(0))
       {
           OnFirePressed?.Invoke();
       }
       if (Input.GetKey(_moveBack))
       {
           Direction?.Invoke(new Vector3(0,0,-1));
           return;
       }
       if (Input.GetKey(_moveFront))
       {
           Direction?.Invoke(new Vector3(0,0,1));
           return;
       }
       if (Input.GetKey(_moveLeft))
       {
           Direction?.Invoke(new Vector3(-1,0,0));
           return;
       }
       if (Input.GetKey(_moveRight))
       {
           Direction?.Invoke(new Vector3(1,0,0));
       }
   }
}
