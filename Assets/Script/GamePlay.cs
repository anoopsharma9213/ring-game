using UnityEngine;
using System.Collections;

public class GamePlay : MonoBehaviour {

	public GameObject Green, RedBlue, White, Back;
	int count;
	//Vector3 spawnpos;
	float spawntime = 2.0f;
	
	// Use this for initialization
	void Start () {
		Random.seed = 20;
		//spawnpos = new Vector3 (0, 0, 100);
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (count < 1) {
			spawnTerrain (Random.Range (1, 10));
			count++;
		} else {
			spawntime -= Time.deltaTime;
			if(spawntime < 0)
			{
				spawntime = 2.0f;
				count = 0;
			}
		}
		/*if (count < 1) {
			spawnTerrain (Random.Range (1, 10));
			Vector3 temp = Randomvec();
			spawnpos = new Vector3 (temp.x,temp.y, 100);
			count++;
		} else {
			spawntime -= Time.deltaTime;
			if(spawntime < 0)
			{
				spawntime = 2.0f;
				count = 0;
			}
		}*/
	}
	
	void spawnTerrain(int num)
	{
		Instantiate (Back, new Vector3(0,0,100), Quaternion.Euler (0, 0, 0));
		if (num >= 1 && num < 3) {
						Instantiate (White, new Vector3 (0, 0, 100), Quaternion.AngleAxis (-77.5f, new Vector3 (0, 0, 1)));
				} else if (num >= 3 && num < 5) {
						Instantiate (White, new Vector3 (0, 0, 100), Quaternion.AngleAxis (101.5f, new Vector3 (0, 0, 1)));
				} else if (num >= 5) {
						Instantiate (Green, new Vector3 (0, 0, 100), Quaternion.AngleAxis (Random.Range (-245.0f, -90.0f), new Vector3 (0, 0, 1)));
						Instantiate (RedBlue, new Vector3 (0, 0, 100), Quaternion.AngleAxis (Random.Range (-65.0f, 90.0f), new Vector3 (0, 0, 1)));
				}

		//Instantiate (Back, new Vector3(0,0,100), Quaternion.Euler (0, 0, 0));
		/*if (num >= 1 && num < 4) {
			Instantiate(Green,spawnpos,Quaternion.Euler(0,0,0));
		} else if (num >= 4 && num < 7) {
			Instantiate(RedBlue,spawnpos,Quaternion.Euler(0,0,0));
		} else if (num >= 7) {
			Instantiate(White,spawnpos,Quaternion.Euler(0,0,0));
		}*/
	}

	/*Vector3 Randomvec()
	{
		Vector3 temp = new Vector3 (0, 0, 0);

		do {
						temp.x = Random.Range (-8.0f, 8.0f);
						temp.y = Random.Range (-8.0f, 8.0f);
				} while(((temp.x*temp.x)+(temp.y*temp.y)) == 64);

		return temp;
	}*/
}
