using System.Collections;
using System.Collections.Generic;
using StandScene.Tutorial.Controllers;
using StandScene.Tutorial.View;
using UnityEngine;
using Zenject;

public class NavigateStepObserver : TutorialStepObserver
{
    [SerializeField] 
    private string _description;
    
    private TutorialStepInfo _tutorialStepInfo;
    private TutorialStepView _view;
    protected override void InitGame(DiContainer container, bool isStepPassed)
    {
        _tutorialStepInfo = container.Resolve<TutorialStepInfo>();
        _view = container.Resolve<TutorialStepView>();
    }
    
    protected override void OnStartStep()
    {
        _tutorialStepInfo.SetStepInfo(_description);
    }
        
    protected override void OnFinishStep()
    {
        _view.Hide();
    }
}
