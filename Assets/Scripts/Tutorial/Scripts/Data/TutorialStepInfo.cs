using System;

namespace StandScene.Tutorial.Controllers
{
    public class TutorialStepInfo
    {
        public event Action<string> OnStatAdded;
        public string CurrentStepData { get; private set; }

        public void SetStepInfo(string data)
        {
            CurrentStepData = data;
            OnStatAdded?.Invoke(CurrentStepData);
        }
    }
}