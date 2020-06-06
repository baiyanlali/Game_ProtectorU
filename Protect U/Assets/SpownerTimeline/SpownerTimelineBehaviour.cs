using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class SpownerTimelineBehaviour : PlayableBehaviour
{
    public int indexofSpowner;
    public GameObject bullet;
    public BulletSpownerManager trackBinding;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        base.ProcessFrame(playable, info, playerData);
        
        trackBinding = playerData as BulletSpownerManager;
        trackBinding.spownerArr [indexofSpowner].spownBullet(bullet);
        //GameObject.Instantiate(bullet, trackBinding.spownerArr [indexofSpowner].transform.position, Quaternion.identity);
    }

    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
        base.OnBehaviourPlay(playable, info);

        //if(!trackBinding)
        //Debug.Log("!!");
    }


}
