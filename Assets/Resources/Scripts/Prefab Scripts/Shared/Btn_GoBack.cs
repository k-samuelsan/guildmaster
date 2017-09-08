using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_GoBack : MonoBehaviour {

	void OnMouseDown() {
		GameObject parent = this.transform.parent.gameObject;
		parent.SetActive (false);
	}
}
