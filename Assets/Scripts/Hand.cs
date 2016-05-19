using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Hand : MonoBehaviour {

    Transform parentController;
    new Rigidbody rigidbody;
    
    void Start () {
        //parentController = transform.parent;
        rigidbody = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        Vector3 toParentPos = parentController.position - transform.position;

        toParentPos = toParentPos / Time.fixedDeltaTime;

        rigidbody.velocity = toParentPos;

        Vector3 toParentRot = Quaternion.RotateTowards(transform.rotation, parentController.rotation, 0f).eulerAngles;

        rigidbody.angularVelocity = toParentRot;
    }

    public void SetTarget(Transform target) {
        parentController = target;
    }
}
