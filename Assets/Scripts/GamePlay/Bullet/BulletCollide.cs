
using UnityEngine;

public class BulletCollide : MonoBehaviour
{
    [SerializeField]
    private float _damage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.TryGetComponent(out IDamage damage))
        {
            damage.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
