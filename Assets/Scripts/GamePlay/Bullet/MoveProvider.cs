using UnityEngine;
using Zenject;

[RequireComponent(typeof(Move))]
public class MoveProvider : MonoBehaviour, ITickable
{
  [SerializeField] 
  private Move _bulletMove;
  
  [SerializeField] 
  private Vector3 _direction;
    
  void ITickable.Tick()
  {
    _bulletMove.SetDirection(_direction);
  }
}
