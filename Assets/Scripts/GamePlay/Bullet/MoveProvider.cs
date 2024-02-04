using System;
using UnityEngine;
using Zenject;

[RequireComponent(typeof(Move))]
public class MoveProvider : MonoBehaviour
{
  [SerializeField] 
  private Move _bulletMove;
  [SerializeField] 
  private Vector3 _direction;
    
  public void Update()
  {
    _bulletMove.SetDirection(_direction);
  }

 
}
