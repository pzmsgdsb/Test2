using UnityEngine;
using System.Collections;

public enum ObjectType{
	Drug,
	Equip,
	Mat
} 
public class ObjectInfo {
	public int ID;
	public string Name;
	public string IconName;
	public ObjectType type;
	public int hp;
	public int mp;
	public int priceSell;
	public int priceBuy;
}
