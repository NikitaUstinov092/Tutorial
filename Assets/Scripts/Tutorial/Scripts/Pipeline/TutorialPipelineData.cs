using System;
using Sirenix.OdinInspector;

[Serializable]
public struct TutorialPipelineData 
{
   [LabelText("Название лаб. работы")]
   public string TutorialTitle;
   
   public TutorialStepObserver[] TutorialStepsObservers;
   public TutorialCompleteObserver[] TutorialCompleteObservers;
   public TutorialList Steps;
}
