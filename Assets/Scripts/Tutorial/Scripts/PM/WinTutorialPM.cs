using System;
using StandScene.Tutorial.Data;
using Zenject;

namespace StandScene.Tutorial.PM
{
    public class WinTutorialPM: IEndTutorialPm, IInitializable, IDisposable
    {
        public event Action OnModelStateChanged;
        
        [Inject]
        private readonly TutorialCompleteInfo _completeInfo;
      
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
            _completeInfo.OnWinDataChanged += OnCompleteDataChanged;
        }
      
        public void Stop()
        {
            _completeInfo.OnWinDataChanged -= OnCompleteDataChanged;
        }

        public string GetLevel()
        {
            return _completeInfo.WinLabName;
        }

        private void OnCompleteDataChanged(string title)
        {
            OnModelStateChanged?.Invoke();
        }
    }

}