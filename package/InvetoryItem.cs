using UnityEngine;
using System.Collections;

public class InvetoryItem : UIDragDropItem {
	private UISprite mysp;
	private int id;
	private string name;
	// Use this for initialization
	void Awake () {
		mysp = this.GetComponent<UISprite> ();
	}
	// Update is called once per frame
	public void SetId(int _Id){
		this.id = _Id;

	
	}
	void restpos(){
		this.transform.localPosition = Vector3.zero;
	}
	void Update () {
		mysp.spriteName = FilePrese.GetObjInfoByID (id).IconName;
	}
	protected override void OnDragDropRelease (GameObject surface)
	{
		base.OnDragDropRelease (surface);
		if (surface != null) {
			if (surface.tag == Tags.INVENTORY_ITEM) {
				InvetoryGird oldGrid = this.transform.parent.GetComponent<InvetoryGird> ();
				int id = oldGrid.Id;
				int num = oldGrid.Num;
				InvetoryGird newGrid = surface.transform.parent.GetComponent<InvetoryGird> ();
				oldGrid.SetId (newGrid.Id, newGrid.Num);
				newGrid.SetId (id, num);
				restpos ();
			} else if (surface.tag == Tags.INVENTORY_ITEM_GRID) {
				if (surface.transform.parent == this.transform.parent) {
					restpos ();
				} else {
					InvetoryGird oldGrid = this.transform.parent.GetComponent<InvetoryGird> ();
					InvetoryGird newGrid = surface.GetComponent<InvetoryGird> ();
					this.transform.parent = surface.transform;
					restpos ();
					newGrid.SetId (oldGrid.Id, oldGrid.Num);
					oldGrid.RestInfo ();
				}
			} else {
				restpos ();
			}
		} else {
			restpos ();
		}
	}
	public void OnHoverOver()
	{
		InventoryDes._instance.Show(id,this.transform.position);
	}
	public void OnHoverOut()
	{
		InventoryDes._instance.Hide();
	}
}
