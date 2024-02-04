using StandScene.Tutorial.Data;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class StepObserver_Start : TutorialStepObserver
{
    [SerializeField] 
    private string _title;
    
    [SerializeField] 
    private string _description;
    
    [SerializeField] 
    private Button _popUpCloseButton;
   
    private TutorialStartInfo _tutorialStartInfo;
    private Move _playerMove;
    private PlayerShoot _playerShoot;
   
    protected override void InitGame(DiContainer container, bool isStepPassed)
    {
        _playerMove = container.Resolve<Move>();
        _playerShoot = container.Resolve<PlayerShoot>();
        _tutorialStartInfo = container.Resolve<TutorialStartInfo>();
    }
    protected override void OnStartStep()
    {
        _tutorialStartInfo.SetLabName(_title);
        _tutorialStartInfo.SetDescription(_description);

        _playerMove.CanMove = false;
        _playerShoot.CanShoot = false;
        
        _popUpCloseButton.onClick.AddListener(FinishStepAndMoveNext);
    }

    protected override void OnFinishStep()
    {
        _playerMove.CanMove = true;
        _playerShoot.CanShoot = true;
        
        _popUpCloseButton.onClick.RemoveListener(MoveNext);
    }
}
