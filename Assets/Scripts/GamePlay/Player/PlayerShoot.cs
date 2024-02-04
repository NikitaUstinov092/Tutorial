using Sirenix.OdinInspector;
using Unity.Mathematics;
using UnityEngine;
using Zenject;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] 
    private GameObject _bullet;
    
    [SerializeField] 
    private Transform _firePoint;
    

    [Button]
    public void Fire()
    {
        Instantiate(_bullet, _firePoint.position, quaternion.identity);
    }
}
