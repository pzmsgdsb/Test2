using UnityEngine;
using System.Collections;

public class InvetoryGird : MonoBehaviour {
	public int Id;
	public int Num;
	private ObjectInfo obj = null;
	private UILabel mylab;
	// Use this for initialization
	void Awake () {
		mylab = this.GetComponentInChildren<UILabel> ();
		SetId (Id,Num);
	}
	
	// Update is called once per frame
	public void SetId(int id,int num){
		Id = id;
		obj = FilePrese.GetObjInfoByID (id);
		InvetoryItem item = this.GetComponentInChildren<InvetoryItem> ();
		this.Num = num;
		mylab.text=this.Num+"   ";
		mylab.enabled = true;
		item.SetId (id);
	}
	public void Plusnum(int num=1){
		this.Num += num;
		mylab.text=this.Num+"   ";
	}
	public void RestInfo(){
		Id = 0;
		Num = 0;
		mylab.enabled = false;
	}
}
