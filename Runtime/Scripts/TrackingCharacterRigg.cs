using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace varjo.iksystem
{
    //this will implement the facade that the software interactis with to get a tracking avatar
    public class TrackingCharacterRigg
    {
        //We need somethign to get this thing
        //can use scriptable object, then we need one for each package when we want to load. 
        private RigTrackingSetupMonoBehaviour _resourcePrefab;
        private RigTrackingSetupMonoBehaviour _instance;

        TrackingCharacterRigg(Transform rootparent, Transform headTarget, Transform leftArmTarget, Transform rightArmTarget)
        {
            _instance = GameObject.Instantiate<RigTrackingSetupMonoBehaviour>(_resourcePrefab);
            _instance.Construct(rootparent, headTarget, leftArmTarget, rightArmTarget); //if we use zenject, we can turn this script into an installer and work from there.

        }
    }
}


