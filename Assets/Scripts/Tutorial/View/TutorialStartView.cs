using TMPro;
using UnityEngine;
using Zenject;

namespace StandScene.Tutorial.View
{
    public class TutorialStartView: MonoBehaviour, ITutorialView
    {
        [SerializeField] private GameObject _popup;
        
        [SerializeField] private TextMeshProUGUI _name;
        
        [SerializeField] private TextMeshProUGUI _description;
        
        [Inject] private IStartLaboratoryWorkPm _pm;
        
        void ITutorialView.Start()
        {
            _pm.OnModelStateChanged += Show;
        }

        void ITutorialView.Stop()
        {
            _pm.OnModelStateChanged -= Show;
        }

        private void Show()
        {
            UpdateView();
            _popup.SetActive(true);
        }
        
        public void Hide()
        {
            _popup.SetActive(false);
        }
        
        private void UpdateView()
        {
            _name.text = _pm.GetLabName();
            _description.text = _pm.GetDescription();
        }
    }
}