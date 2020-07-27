using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

		int[] array = new int[5];

		array[0] = 1;
		array[1] = 12;
		array[2] = 11;
		array[3] = 41;
		array[4] = 14;

		for (int i = 0; i < 5; i++)
		{
			Debug.Log(array[i]);
		}

	}

	// Update is called once per frame
	void Update()
	{

	}
}
