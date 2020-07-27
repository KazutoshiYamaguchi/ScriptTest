using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{




	// Use this for initialization
	void Start()
	{

		Boss magic = new Boss();

		magic.Magic();
		magic.Magic();
		magic.Magic();
		magic.Magic();
		magic.Magic();
		magic.Magic();
		magic.Magic();
		magic.Magic();
		magic.Magic();
		magic.Magic();
		magic.Magic();//11回目
	}

	// Update is called once per frame
	void Update()
	{

	}


	public class Boss
	{
		private int mp = 53;

		public void Magic()
		{
			mp -= 5;

			if (mp > 0)
			{

				Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
			}
			else
			{
				Debug.Log("MPが足りないため魔法が使えない。");

			}
		}
	}
}