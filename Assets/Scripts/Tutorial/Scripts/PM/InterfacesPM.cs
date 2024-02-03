using System;
public interface INavigateStepsPM: ITutorialPM
{
    event Action OnModelStateChanged;
    
    string GetStepReview();
}

public interface IWinLaboratoryWorkPm: ITutorialPM
{
    event Action OnModelStateChanged;
    string GetLevel();
}

public interface IStartLaboratoryWorkPm: ITutorialPM
{
    event Action OnModelStateChanged;
    string GetLabName();
    string GetDescription();
}

public interface ITutorialPM
{
    void Start();
    void Stop();
}