using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideCartTrigger : MonoBehaviour
{
	List<UnityEngine.Collider> objectsInCart;

	private void Start()
	{
		objectsInCart = new List<UnityEngine.Collider>();
	}

	private void Update()
	{
		objectsInCart.RemoveAll(ColliderDisabled);
	}

	private static bool ColliderDisabled(UnityEngine.Collider c)
	{
		return !c.enabled;
	}

	private void OnTriggerEnter(UnityEngine.Collider other)
	{
		objectsInCart.Add(other);
	}

	private void OnTriggerExit(UnityEngine.Collider other)
	{
		objectsInCart.Remove(other);
	}
}
