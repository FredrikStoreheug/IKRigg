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

        public TrackingCharacterRigg(Transform rootparent, Transform headTarget, Transform leftArmTarget, Transform rightArmTarget)
        {
            _instance = GameObject.Instantiate<RigTrackingSetupMonoBehaviour>(Resources.Load<RigTrackingSetupMonoBehaviour>(_resourcePath));
            _instance.Construct(rootparent, headTarget, leftArmTarget, rightArmTarget); //if we use zenject, we can turn this script into an installer and work from there.

        }
    }
}


