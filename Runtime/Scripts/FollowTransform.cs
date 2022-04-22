using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace varjo.iksystem
{
    //TODO: Add ofsets for rotation and position
    internal class FollowTransform : MonoBehaviour
    {
        private Transform _target;

        public void Construct(Transform target)
        {
            _target = target;
        }

        void Update()
        {
            transform.position = _target.position;
            transform.rotation = _target.rotation;
        }
    }
}