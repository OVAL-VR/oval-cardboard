using UnityEngine;
using System.Collections;

public class applicationController : MonoBehaviour {

	/// <summary>
	/// Quit this instance.
	/// </summary>
	public void Quit () {
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit ();
		#endif
	}
}
