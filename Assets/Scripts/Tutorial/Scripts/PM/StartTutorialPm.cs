using System;
using StandScene.Tutorial.Data;
using Zenject;

namespace StandScene.Tutorial.PM
{
    public class StartTutorialPm: IStartTutorialPm, IInitializable, IDisposable
    {
        public event Action OnModelStateChanged;
        
        [Inject]
        private readonly TutorialStartInfo _labInfo;
        
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
            _labInfo.OnDescriptionChanged += OnDescriptionChanged;
            _labInfo.OnLabNameChanged += OnLabNameChanged;
        }
        public void Stop()
        {
            _labInfo.OnDescriptionChanged -= OnDescriptionChanged;
            _labInfo.OnLabNameChanged -= OnLabNameChanged;
        }

        public string GetLabName()
        {
            return _labInfo.LabName;
        }
        
        public string GetDescription()
        {
            return _labInfo.Description;
        }

        private void OnDescriptionChanged(string description)
        {
            OnModelStateChanged?.Invoke();
        }
        
        private void OnLabNameChanged(string description)
        {
            OnModelStateChanged?.Invoke();
        }
    }

}