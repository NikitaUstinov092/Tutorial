using UnityEngine;
using Zenject;

public class StepObserver_LearnMove : NavigateStepObserver
{
    [SerializeField]
    private TutorialTrigger _tutorialTrigger;
    
    private Move _playerMove;
    private PlayerShoot _playerShoot;
    
    protected override void InitGame(DiContainer container, bool isStepPassed)
         {
             _playerMove =  container.Resolve<Move>();
             _playerShoot = container.Resolve<PlayerShoot>();
             
             base.InitGame(container, isStepPassed);
         }
    protected override void OnStartStep()
    {
        _playerMove.CanMove = true;
        _playerShoot.CanShoot = false;
        _tutorialTrigger.OnPlayerReachTrigger += FinishStepAndMoveNext;
        _tutorialTrigger.gameObject.SetActive(true);
        
        base.OnStartStep();
    }
    
    protected override void OnFinishStep()
    {
        _playerMove.CanMove = true;
        _playerShoot.CanShoot = true;
        _tutorialTrigger.OnPlayerReachTrigger -= FinishStepAndMoveNext;
        _tutorialTrigger.gameObject.SetActive(false);
        
        base.OnFinishStep();
    }
    public override void FinishGame()
    {
        _tutorialTrigger.OnPlayerReachTrigger -= FinishStepAndMoveNext;
        base.FinishGame();
    }
}
