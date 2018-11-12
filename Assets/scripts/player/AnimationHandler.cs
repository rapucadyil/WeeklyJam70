using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour {

	[SerializeField] private int dir;


	public void setDir(int newDir) {
		dir = newDir;
	}

	void Start () {
		dir = 1;
	}

	public void HandleAnimation(SpriteRenderer spr) {
		switch (dir) {
		case 1:
			spr.flipX = false;
			break;
		case -1:
			spr.flipX = true;
			break;
		}
	}

}
