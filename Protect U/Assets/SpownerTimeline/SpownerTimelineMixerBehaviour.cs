using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class SpownerTimelineMixerBehaviour : PlayableBehaviour
{
    // NOTE: This function is called at runtime and edit time.  Keep that in mind when setting the values of properties.
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        BulletSpownerManager trackBinding = playerData as BulletSpownerManager;

        if (!trackBinding)
            return;

        int inputCount = playable.GetInputCount ();

        float lastInputWeight = 0;
        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);
            ScriptPlayable<SpownerTimelineBehaviour> inputPlayable = (ScriptPlayable<SpownerTimelineBehaviour>)playable.GetInput(i);
            SpownerTimelineBehaviour input = inputPlayable.GetBehaviour ();
            
            // Use the above variables to process each frame of this playable.
            if (inputWeight > 0 &&lastInputWeight<=0)
                //
            lastInputWeight = inputWeight;
        }
    }
}
