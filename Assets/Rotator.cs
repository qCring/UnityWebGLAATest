using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	
	void Update () {
		this.transform.Rotate (0f, 0f, 1f);
	}
}
