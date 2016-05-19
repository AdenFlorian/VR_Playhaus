using UnityEngine;
using System.Collections;

public class SetupHands : MonoBehaviour {

    public GameObject controllerLeftGO;
    public GameObject controllerRightGO;
    public GameObject handPrefab;

    // Use this for initialization
    void Start () {
        // Get reference to controllers
        GameObject handLeftGO = Instantiate<GameObject>(handPrefab);
        GameObject handRightGO = Instantiate<GameObject>(handPrefab);
        //handLeftGO.transform.parent = controllerLeftGO.transform;
        //handRightGO.transform.parent = controllerRightGO.transform;
        handLeftGO.transform.position = controllerLeftGO.transform.position;
        handRightGO.transform.position = controllerRightGO.transform.position;
        handLeftGO.GetComponent<Hand>().SetTarget(controllerLeftGO.transform);
        handRightGO.GetComponent<Hand>().SetTarget(controllerRightGO.transform);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
