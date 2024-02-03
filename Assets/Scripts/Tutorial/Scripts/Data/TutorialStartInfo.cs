using System;

namespace StandScene.Tutorial.Data
{
    public class TutorialStartInfo
    {
        public event Action<string> OnDescriptionChanged;
        public event Action<string> OnLabNameChanged;
        public string LabName { get; private set; }
        public string Description { get; private set; }

        public void SetLabName(string name)
        {
            LabName = name;
            OnLabNameChanged?.Invoke(LabName);
        }
        
        public void SetDescription(string description)
        {
            Description = description;
            OnDescriptionChanged?.Invoke(Description);
        }
        
    }
}