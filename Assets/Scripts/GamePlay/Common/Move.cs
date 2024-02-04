using Sirenix.OdinInspector;
using UnityEngine;


public class Move : MonoBehaviour
{
    public bool CanMove = true;
    public float Speed;
    
    [SerializeField] 
    private Transform _target;
   
    [Button]
    public void SetDirection(Vector3 direction)
    {
        if(!CanMove)
            return;
        _target.transform.position += direction * Speed * Time.deltaTime;
    }
}
