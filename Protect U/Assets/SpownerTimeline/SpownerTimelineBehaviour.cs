using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class SpownerTimelineBehaviour : PlayableBehaviour
{
    public int indexofSpowner;
    public GameObject bullet; 
  
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        base.ProcessFrame(playable, info, playerData);
        BulletSpownerManager trackBinding = playerData as BulletSpownerManager;
        
        trackBinding.spownerArr [indexofSpowner].spownBullet(bullet);
        //GameObject.Instantiate(bullet, trackBinding.spownerArr [indexofSpowner].transform.position, Quaternion.identity);
    }

   

}
