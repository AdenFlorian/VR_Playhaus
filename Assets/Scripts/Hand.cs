using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour {

    Transform parentController;

    // Use this for initialization
    void Start () {
        parentController = transform.parent;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = parentController.position;
	}
}
