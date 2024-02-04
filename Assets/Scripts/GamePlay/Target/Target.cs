using UnityEngine;
using Zenject;

public class Target : MonoBehaviour, IDamage
{
    [Inject]
    private HitTargetCounter _hitTargetCounter;
    
    void IDamage.TakeDamage(float damage) //TO DO предполагается логика отнимания hp, пока сделал по простому
    {
        _hitTargetCounter.OnNewTargetHit();
        Destroy(gameObject);
    }
}

public interface IDamage
{
    void TakeDamage(float damage);
}
