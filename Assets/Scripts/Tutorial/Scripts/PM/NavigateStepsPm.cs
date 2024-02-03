using System;
using StandScene.Tutorial.Controllers;
using Zenject;

namespace StandScene.Tutorial.PM
{
    public class NavigateStepsPm : INavigateStepsPM, IInitializable, IDisposable
    {
        public event Action OnModelStateChanged;
        
        [Inject] private readonly TutorialStepInfo _stepInfo;
      
        void IInitializable.Initialize()
        {
            Start();
        }

        void IDisposable.Dispose()
        {
            Stop();
        }
        public void Start()
        {
            _stepInfo.OnStatAdded += OnStepChanged;
        }
        public void Stop()
        {
            _stepInfo.OnStatAdded -= OnStepChanged;
        }

        public string GetStepReview()
        {
            return _stepInfo.CurrentStepData;
        }
        
        private void OnStepChanged(string info)
        {
            OnModelStateChanged?.Invoke();
        }
    }
}