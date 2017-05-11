using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GameObject week;

	static Guild guild;
	int numWeeks;

	GameObject thisWeek;

	// Use this for initialization
	void Start () {
		guild = new Guild ();
		numWeeks = 0;
		nextTurn ();
	}

	public void nextTurn () {
		numWeeks++;
		thisWeek = Instantiate (week) as GameObject;
	} 
}
