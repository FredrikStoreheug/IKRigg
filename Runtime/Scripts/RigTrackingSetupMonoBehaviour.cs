using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace varjo.iksystem
{
    internal class RigTrackingSetupMonoBehaviour : MonoBehaviour
    {
        //we dont want this really. this could be injected with a manager. 
        //or with an installer, but since this is up in the air ill leave it as a serialised field for now.
        [SerializeField] private FollowTransform _leftHand, _rightHand;
        [SerializeField] private Head _head;

        public void Construct(Transform rootParent, Transform headTarget, Transform LeftHandTarget, Transform RightHandTarget)
        {
            _leftHand.Construct(LeftHandTarget);
            _rightHand.Construct(RightHandTarget);
            _head.Construct(headTarget, rootParent);
        }
        
        

    }
}
