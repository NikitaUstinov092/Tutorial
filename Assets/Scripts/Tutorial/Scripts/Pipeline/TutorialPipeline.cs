using Sirenix.OdinInspector;
using UnityEngine;

public class TutorialPipeline : MonoBehaviour
{
   [ListDrawerSettings(ShowIndexLabels = true, CustomAddFunction = "CustomAddTutorial")]
   public TutorialPipelineData[] Tutorials;

   private TutorialPipelineData CustomAddTutorial()
   {
      // Этот метод будет вызван при добавлении нового элемента в массив
      return new TutorialPipelineData();
   }
}
