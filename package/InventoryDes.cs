using UnityEngine;
using System.Collections;

public class InventoryDes : MonoBehaviour {

	public static InventoryDes _instance;

	private UILabel label;
	void Awake()
	{
		_instance = this;
		label = this.GetComponentInChildren<UILabel>();
		this.gameObject.SetActive(false);
	}

	public void Show(int id,Vector3 pos)
	{
		this.gameObject.SetActive(true);
		this.transform.position = pos;
		ObjectInfo info = FilePrese.GetObjInfoByID(id);
		string des = "";
		switch (info.type)
		{ 
		case ObjectType.Drug:
			des = GetDrugDes(info);
			break;
		case ObjectType.Equip:
			break;
		case ObjectType.Mat:
			break;
		}
		label.text = des;
	}

	public void Hide()
	{
		this.gameObject.SetActive(false);
	}
	private string GetDrugDes(ObjectInfo info)
	{
		string s = "";
		s += "名称：" + info.Name + "\n";
		s += "回复Hp：" + info.hp + "\n";
		s += "回复Mp：" + info.mp + "\n";
		s += "出售价：" + info.priceSell + "\n";
		s += "购买价：" + info.priceBuy + "\n";
		return s;
	}
}
