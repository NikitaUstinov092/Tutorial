using System;
using StandScene.Tutorial.Data;
using UnityEngine.PlayerLoop;
using Zenject;

namespace StandScene.Tutorial.PM
{
    public class WinLaboratoryWorkPM: IWinLaboratoryWorkPm, IInitializable, IDisposable
    {
        public event Action OnModelStateChanged;
        
        [Inject]
        private readonly TutorialWinInfo _winInfo;
      
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
            _winInfo.OnWinDataChanged += OnWinDataChanged;
        }
      
        public void Stop()
        {
            _winInfo.OnWinDataChanged -= OnWinDataChanged;
        }

        public string GetLevel()
        {
            return _winInfo.WinLabName;
        }

        private void OnWinDataChanged(string title)
        {
            OnModelStateChanged?.Invoke();
        }
    }

}