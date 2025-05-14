using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{
    public int totalLevers = 3;
    private int flippedLevers = 0;

    public List<Animator> animators; // Drag your animators in here via Inspector
    public string triggerName = "Activate"; // Or use whatever your animation trigger is called

    public void LeverFlipped()
    {
        flippedLevers++;

        if (flippedLevers >= totalLevers)
        {
            foreach (Animator animator in animators)
            {
                animator.SetTrigger(triggerName);
            }
        }
    }
}
