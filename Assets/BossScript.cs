using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

		Boss magic = new Boss();

		for (int i = 0; i <= 11; i++)
		{
			magic.Magic();
		}

	}
	


	public class Boss
	{
		private int mp = 53;

		public void Magic()
		{
			

			if (mp > 4)
			{
				mp -= 5;
				Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
			}
			else
			{
				Debug.Log("MPが足りないため魔法が使えない。");

			}
		}
	}
}