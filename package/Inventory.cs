using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Inventory : MonoBehaviour {
	public static Inventory _instance;
	public TweenPosition tweenpos;
	public bool isShow = false;
	public List<InvetoryGird> ItemGridlist = new List<InvetoryGird> ();
	public GameObject item;
	public UILabel mylab;
	public int count=100;
	// Use this for initialization
	void Awake () {
		_instance = this;
		tweenpos= GetComponent<TweenPosition> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void show(){
		isShow = true;
		tweenpos.PlayForward ();
	}
	void hide(){
		isShow = false;
		tweenpos.PlayReverse ();
	}
	public void ChangePanl(){
		if (isShow) {
			hide ();
		} else {
			show ();
		}
	}
}
