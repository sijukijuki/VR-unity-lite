using UnityEngine;
using System.Collections;

public class splash : MonoBehaviour {

	public float timer = 3;
	public void Update (){
		timer -= Time.deltaTime;
		if (timer > 0) {
			Debug.Log (timer);
		} else {
			Application.LoadLevel (1);
		}
	}
}