using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using uAdventure.Runner;

public class HideInventory : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InventoryManager.Instance.Show = false;
    }
}
