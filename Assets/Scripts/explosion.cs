using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
	// Use this for initialization
	void Start () {
        Destroy(gameObject, 4.0f);
    }
}
