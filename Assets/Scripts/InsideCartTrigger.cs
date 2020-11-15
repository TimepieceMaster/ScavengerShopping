using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideCartTrigger : MonoBehaviour
{
	ObjectsInCarts objectsInAllCarts;
	List<UnityEngine.Collider> objectsInCart;

	private void Start()
	{
		objectsInAllCarts = FindObjectOfType<ObjectsInCarts>();
		objectsInCart = new List<UnityEngine.Collider>();
	}

	private void Update()
	{
		for (int i = 0; i < objectsInCart.Count; ++i)
		{
			if (!objectsInCart[i].enabled)
			{
				objectsInAllCarts.RemoveFromList(ObjectsInCarts.PreProcess(objectsInCart[i].gameObject.name));
				objectsInCart.RemoveAt(i);
				--i;
			}
		}
	}

	private static bool ColliderDisabled(UnityEngine.Collider c)
	{
		return !c.enabled;
	}

	private void OnTriggerEnter(UnityEngine.Collider other)
	{
		if (other != null)
		{
			objectsInCart.Add(other);
			objectsInAllCarts.AddToList(ObjectsInCarts.PreProcess(other.gameObject.name));
		}
	}

	private void OnTriggerExit(UnityEngine.Collider other)
	{
		if (other != null)
		{
			objectsInAllCarts.RemoveFromList(ObjectsInCarts.PreProcess(other.gameObject.name));
			objectsInCart.Remove(other);
		}
	}
}
