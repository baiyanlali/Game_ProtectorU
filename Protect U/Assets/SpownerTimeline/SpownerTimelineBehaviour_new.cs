using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// A behaviour that is attached to a playable
public class SpownerTimelineBehaviour_new : BasicPlayableBehaviour
{
    
    BulletSpownerManager spownerManager;
    public int indexofSpowner;
    public GameObject bullet;
    // Called when the owning graph starts playing
    public override void OnGraphStart(Playable playable)
    {
        spownerManager = GameObject.Find("SpownerManager").GetComponent<BulletSpownerManager>();
        //Debug.Log("OnGraphStart");
    }

    // Called when the owning graph stops playing
    public override void OnGraphStop(Playable playable)
    {
        
    }

    // Called when the state of the playable is set to Play
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
        //Debug.Log("OnBehaviourPlay");
        
        spownerManager.spownerArr [indexofSpowner].spownBullet(bullet);
    }

    // Called when the state of the playable is set to Paused
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
        
    }

    // Called each frame while the state is set to Play
    public override void PrepareFrame(Playable playable, FrameData info)
    {
        //Debug.Log("PrepareFrame");
        
    }
}
