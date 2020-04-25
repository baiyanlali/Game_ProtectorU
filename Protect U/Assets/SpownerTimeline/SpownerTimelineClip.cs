using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class SpownerTimelineClip : PlayableAsset, ITimelineClipAsset
{
    public SpownerTimelineBehaviour template = new SpownerTimelineBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.None; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<SpownerTimelineBehaviour>.Create (graph, template);
        SpownerTimelineBehaviour clone = playable.GetBehaviour ();
        return playable;
    }
}
