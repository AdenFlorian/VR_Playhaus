using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Hand : MonoBehaviour {

    Transform parentController;
    new Rigidbody rigidbody;
    
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        DoPosition();
        DoRotation();
    }

    public void SetTarget(Transform target) {
        parentController = target;
    }

    private void DoPosition() {
        // Get vector from current position to parent's position
        Vector3 forceToParentPosition = parentController.position - transform.position;

        // Divide by fixed timestep (default is 0.2f)
        // so that we will get where we want to go in one step
        forceToParentPosition = forceToParentPosition / Time.fixedDeltaTime;

        // Subtract existing velocity
        forceToParentPosition = forceToParentPosition - rigidbody.velocity;

        // Add force as a VelocityChange, so it ignores mass, and effectively just sets our velocity
        rigidbody.AddForce(forceToParentPosition, ForceMode.VelocityChange);
    }

    private void DoRotation() {
        //Vector3 toParentRot = Quaternion.RotateTowards(transform.rotation, parentController.rotation, 0f).eulerAngles;

        //rigidbody.angularVelocity = toParentRot / Time.fixedDeltaTime;

        //Vector3 torqueToParentRotation = (Quaternion.Inverse(transform.rotation) * parentController.rotation).eulerAngles;
        //Vector3 torqueToParentRotation = Quaternion.RotateTowards(transform.rotation, parentController.rotation, 0f).eulerAngles;
        //Vector3 torqueToParentRotation = Quaternion.FromToRotation(transform.forward, parentController.forward).eulerAngles;

        //torqueToParentRotation = torqueToParentRotation / Time.fixedDeltaTime;
        //torqueToParentRotation = torqueToParentRotation - rigidbody.angularVelocity;

        //rigidbody.AddTorque(torqueToParentRotation, ForceMode.VelocityChange);

        //rigidbody.MoveRotation(Quaternion.FromToRotation(transform.position, parentController.position));



        //Vector3 x = Vector3.Cross(transform.forward.normalized, parentController.forward.normalized);
        //float theta = Mathf.Asin(x.magnitude);
        //Vector3 w = x.normalized * theta / Time.fixedDeltaTime;

        //Quaternion q = transform.rotation * rigidbody.inertiaTensorRotation;
        //Vector3 T = q * Vector3.Scale(rigidbody.inertiaTensor, (Quaternion.Inverse(q) * w));

        //rigidbody.AddTorque(T - rigidbody.angularVelocity, ForceMode.VelocityChange);


        //var x = Vector3.Cross(transform.forward.normalized, parentController.forward.normalized);
        //float theta = Mathf.Asin(x.magnitude);
        //var w = x.normalized * theta / Time.fixedDeltaTime;
        //var q = transform.rotation * rigidbody.inertiaTensorRotation;
        //var t = q * Vector3.Scale(rigidbody.inertiaTensor, Quaternion.Inverse(q) * w);
        //rigidbody.AddTorque(t - rigidbody.angularVelocity, ForceMode.Impulse);



        rigidbody.rotation = parentController.rotation;
    }
}
