using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackColor(0.2655217f, 0.9716981f, 0.004583492f)]
[TrackClipType(typeof(SpownerTimelineClip))]
[TrackBindingType(typeof(BulletSpownerManager))]
public class SpownerTimelineTrack : TrackAsset
{
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
        return ScriptPlayable<SpownerTimelineMixerBehaviour>.Create (graph, inputCount);
    }
}
