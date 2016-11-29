using UnityEngine;
using System.Collections;

public class menuController : MonoBehaviour {

	/// <summary>
	/// The left menu marker.
	/// </summary>
	public GameObject leftMenuMarker;

	/// <summary>
	/// The right menu marker.
	/// </summary>
	public GameObject rightMenuMarker;

	/// <summary>
	/// The model categories.
	/// </summary>
	public GameObject modelCategories;

	/// <summary>
	/// The action categories.
	/// </summary>
	public GameObject actionCategories;

	/// <summary>
	/// The setting categories.
	/// </summary>
	public GameObject settingCategories;

	/// <summary>
	/// The model interaction panel.
	/// </summary>
	public GameObject modelInteractionPanel;

	/// <summary>
	/// The file browser panel.
	/// </summary>
	public GameObject fileBrowserPanel;

	/// <summary>
	/// The skybox panel.
	/// </summary>
	public GameObject skyboxPanel;

	/// <summary>
	/// The lighting panel.
	/// </summary>
	public GameObject lightingPanel;

	/// <summary>
	/// The children.
	/// </summary>
	GameObject[] children;

	/// <summary>
	/// The left.
	/// </summary>
	bool left;
	/// <summary>
	/// The right.
	/// </summary>
	bool right;

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		left = true;
		right = false;

		children = new GameObject[7];

		children.SetValue (modelCategories, 0);
		children.SetValue (actionCategories, 1);
		children.SetValue (settingCategories, 2);
		children.SetValue (modelInteractionPanel, 3);
		children.SetValue (fileBrowserPanel, 4);
		children.SetValue (skyboxPanel, 5);
		children.SetValue (lightingPanel, 6);


	}
	
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
	}

	/// <summary>
	/// Moves the menu.
	/// </summary>
	public void MoveMenu () {

		// Check if the menu is on the left side of the ship...
		if (left) {
			// Move the menu to the rightMenuMarker's position and update rotation.
			transform.localPosition = rightMenuMarker.transform.localPosition;
			transform.localRotation = rightMenuMarker.transform.localRotation;

			// Update our booleans to reflect what side of the ship the menu is on.
			left = false;
			right = true;
		}
		// ... or if it's on the right side of the ship.
		else if (right) {
			// Move the menu to the rightMenuMarker's position and update rotation.
			transform.localPosition = leftMenuMarker.transform.localPosition;
			transform.localRotation = leftMenuMarker.transform.localRotation;

			// Update our booleans to reflect what side of the ship the menu is on.
			left = true;
			right = false;
		}

		for (int i = 0; i < children.Length; i++) {
			GameObject j = children[i];

			/* Debug.Log (j.name + "'s old localPosition: " + j.transform.localPosition); */
			Vector3 newPos = new Vector3 (
				-1 * j.transform.localPosition.x, 
				j.transform.localPosition.y, 
				j.transform.localPosition.z
			);

			j.transform.localPosition = newPos;
			/* Debug.Log (j.name + "'s new localPosition: " + j.transform.localPosition); */

			/* Debug.Log (j.name + "'s old localRotation: " + j.transform.localRotation); */
			Quaternion newRot = new Quaternion (
				j.transform.localRotation.x, 
				-1 * j.transform.localRotation.y, 
				j.transform.localRotation.z, 
				j.transform.localRotation.w
			);

			j.transform.localRotation = newRot;
			/* Debug.Log (j.name + "'s new localRotation: " + j.transform.localRotation); */
		}

	}
}
