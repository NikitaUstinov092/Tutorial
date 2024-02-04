using Zenject;

public class StepObserver_LearnShoot : NavigateStepObserver
{
    private PlayerShoot _playerShoot;
    protected override void InitGame(DiContainer container, bool isStepPassed)
    {
        _playerShoot = container.Resolve<PlayerShoot>();
        base.InitGame(container, isStepPassed);
    }
    
    protected override void OnStartStep()
    {
        _playerShoot.OnBulletSpawned += FinishStepAndMoveNext;
        base.OnStartStep();
    }
    
    protected override void OnFinishStep()
    {
        _playerShoot.OnBulletSpawned -= FinishStepAndMoveNext;
        base.OnFinishStep();
    }
    public override void FinishGame()
    {
        _playerShoot.OnBulletSpawned -= FinishStepAndMoveNext;
        base.FinishGame();
    }
}
