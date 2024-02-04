using UnityEngine;

public class DelayDestroyer : MonoBehaviour
{
    [SerializeField] 
    private float _delay = 3;
    
    public void Update()
    {
        _delay -= Time.deltaTime;
        if (_delay <= 0)
        {
            Destroy(gameObject);
        }
    }
}
