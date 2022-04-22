using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace varjo.iksystem
{
    //TODO: we can lock the feet to the floor if we want, or move to a hovering upperbody for demos.
    internal class Head : MonoBehaviour
    {
        private Transform _headTracking;
        private Transform _ikRigRoot;
        private Vector3 _positionOffset, _rotationOffset;
        private Vector3 _headBodyOffset;

        public void Construct(Transform headTracking, Transform ikRoot)
        {
            _headTracking = headTracking;
            _ikRigRoot = ikRoot;
        }

        // Update is called once per frame
        private void Start()
        {
            _headBodyOffset = transform.position - _ikRigRoot.position;
        }

        void Update()
        {
            _ikRigRoot.position = transform.position - _headBodyOffset;
            _ikRigRoot.forward = Vector3.ProjectOnPlane(_headTracking.forward, Vector3.up).normalized;

            transform.position = _headTracking.TransformPoint(_positionOffset);
            transform.rotation = _headTracking.rotation * Quaternion.Euler(_rotationOffset);
        }
    }
}