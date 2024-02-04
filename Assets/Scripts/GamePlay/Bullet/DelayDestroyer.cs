using UnityEngine;
using Zenject;

public class DelayDestroyer : MonoBehaviour, ITickable
{
    [SerializeField] 
    private float _delay = 3;
    void ITickable.Tick()
    {
        _delay -= Time.deltaTime;
        
        if (_delay <= 0)
        {
            Destroy(gameObject);
        }
    }
}
