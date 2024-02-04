using Zenject;

public class StepObserver_ReachAllTargets : NavigateStepObserver
{
    private HitTargetCounter _hitTargetCounter;
    protected override void InitGame(DiContainer container, bool isStepPassed)
    {
        _hitTargetCounter = container.Resolve<HitTargetCounter>();
        base.InitGame(container, isStepPassed);
    }
    
    protected override void OnStartStep()
    {
        _hitTargetCounter.OnAllTargetsHit += FinishStepAndMoveNext;
        base.OnStartStep();
    }
    
    protected override void OnFinishStep()
    {
        _hitTargetCounter.OnAllTargetsHit -= FinishStepAndMoveNext;
        base.OnFinishStep();
    }
    public override void FinishGame()
    {
        _hitTargetCounter.OnAllTargetsHit -= FinishStepAndMoveNext;
        base.FinishGame();
    }
}
