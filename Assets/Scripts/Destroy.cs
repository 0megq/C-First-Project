﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
	public float lifetime;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, lifetime);
	}
}
