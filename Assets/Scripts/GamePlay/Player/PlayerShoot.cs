using System;
using Sirenix.OdinInspector;
using Unity.Mathematics;
using UnityEngine;
using Zenject;

public class PlayerShoot : MonoBehaviour
{
    public event Action OnBulletSpawned;
    public bool CanShoot = true;
    
    [SerializeField] 
    private GameObject _bullet;
    
    [SerializeField] 
    private Transform _firePoint;

    [Inject]
    private DiContainer _diContainer;

    [Button]
    public void Fire()
    {
        if(!CanShoot)
            return;
        Instantiate(_bullet, _firePoint.position, quaternion.identity);
        // _diContainer.InstantiatePrefab(_bullet);
        // _diContainer.Inject(_bullet);
        OnBulletSpawned?.Invoke();
    }
}
