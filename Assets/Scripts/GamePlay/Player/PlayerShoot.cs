using System;
using Sirenix.OdinInspector;
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

    private GameObject _bulletParent;

    [Button]
    public void Fire()
    {
        if(!CanShoot)
            return;

        if (_bulletParent == null)
            _bulletParent = new GameObject("Bullets");
        
        _diContainer.InstantiatePrefab(_bullet,_firePoint.position, Quaternion.identity, _bulletParent.transform);
        OnBulletSpawned?.Invoke();
    }
}
