using System;

public class HitedTargetCounter
{
    public event Action OnAllTargetsHit;
    
    private const int HIT_TARGETS_COUNT_REQUIRED = 5;
    private int _currentHitCount;

    public void OnNewTargetHit()
    {
        if (HIT_TARGETS_COUNT_REQUIRED == ++_currentHitCount)
        {
            OnAllTargetsHit?.Invoke();
        }
    }
    
}
