using System;

namespace StandScene.Tutorial.Data
{
    public class TutorialCompleteInfo
    {
        public event Action<string> OnWinDataChanged;
        public string WinLabName { get; private set; }

        public void SetInfo(string data)
        {
            WinLabName = data;
            OnWinDataChanged?.Invoke(WinLabName);
        }
    }
}