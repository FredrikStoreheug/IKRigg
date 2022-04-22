using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace varjo.iksystem
{
    //this will implement the facade that the software interactis with to get a tracking avatar
    public class TrackingCharacterRigg
    {
        private string _resourcePath = "PlayerCharacterIkRigg";
        private RigTrackingSetupMonoBehaviour _instance;

        public TrackingCharacterRigg(Transform headTarget, Transform leftArmTarget, Transform rightArmTarget)
        {
            RigTrackingSetupMonoBehaviour prefab = Resources.Load<RigTrackingSetupMonoBehaviour>(_resourcePath);
            _instance = GameObject.Instantiate<RigTrackingSetupMonoBehaviour>(prefab);
            _instance.Construct(headTarget, leftArmTarget, rightArmTarget);       
        }
    }
}


