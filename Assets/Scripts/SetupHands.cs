using UnityEngine;
using System.Collections;

public class SetupHands : MonoBehaviour {

    public GameObject controllerLeftGO;
    public GameObject controllerRightGO;

    // Use this for initialization
    void Start () {
        // Get reference to controllers
        GameObject handGOResource = Resources.Load<GameObject>("Hand");
        GameObject handLeftGO = Instantiate<GameObject>(handGOResource);
        GameObject handRightGO = Instantiate<GameObject>(handGOResource);
        handLeftGO.transform.parent = controllerLeftGO.transform;
        handRightGO.transform.parent = controllerRightGO.transform;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
