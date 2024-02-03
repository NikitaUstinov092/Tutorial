using System;
using Zenject;

public class TutorialPmAdapter :  IInitializable, IDisposable
{
    private ITutorialPM[]  _tutorialPm;
    private TutorialManager _tutorialManager;
    
    [Inject]
    private void Construct(TutorialManager tutorialManager, ITutorialPM[] tutorialPm)
    {
        _tutorialPm = tutorialPm;
        _tutorialManager = tutorialManager;
    }
    void IInitializable.Initialize()
    {
        foreach (var pm in _tutorialPm)
        {
            _tutorialManager.OnSetUp += pm.Start;
        }
        
        foreach (var pm in _tutorialPm)
        {
            _tutorialManager.OnCompleted += pm.Stop;
        }
    }

    void IDisposable.Dispose()
    {
        foreach (var pm in _tutorialPm)
        {
            _tutorialManager.OnSetUp -= pm.Start;
        }
        
        foreach (var pm in _tutorialPm)
        {
            _tutorialManager.OnCompleted -= pm.Stop;
        }
    }
}
