using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	float speed = 0.3f;
	public TextMesh hud;
	public static int score = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

				if (Input.GetKey (KeyCode.Escape)) {
						Application.Quit ();
				}

				Vector3 temp = transform.position;
				/*if (Input.GetKey (KeyCode.LeftArrow)) {
						temp.x -= 0.08f;
				} else if (Input.GetKey (KeyCode.RightArrow)) {
						temp.x += 0.08f;
				}*/
				/*if (Input.GetKey (KeyCode.UpArrow)) {
						temp.y += 0.08f;
				} else if (Input.GetKey (KeyCode.DownArrow)) {
						temp.y -= 0.08f;
				}*/
				if (name == "Player_1") {
			//Debug.Log (renderer.bounds.size.ToString ());
			//Debug.Log ((Mathf.Atan(temp.y/temp.x)*Mathf.Rad2Deg+180.0f).ToString());
						//Debug.Log (transform.rotation.eulerAngles.ToString());
						hud.text = score.ToString ();

						/*if ((transform.position.y == 4.98f && GameObject.Find ("Player_2").transform.position.y == 4.98f) || (transform.position.y == -4.98f && GameObject.Find ("Player_2").transform.position.y == -4.98f)) {
								Vector3 change = GameObject.Find ("Player_2").transform.position;
								change.z = -20;
								GameObject.Find ("Player_2").transform.position = change;
								temp.z = -20;
								change = GameObject.Find ("Player").transform.position;
								change.z = 0;
								change.y = (temp.y == 4.98f) ? 4.98f : -4.98f;
								GameObject.Find ("Player").transform.position = change;
						} else if (temp.z == -20 && transform.position.y != 4.98f && transform.position.y != -4.98f) {
								Vector3 change = GameObject.Find ("Player_2").transform.position;
								change.z = 0;
								GameObject.Find ("Player_2").transform.position = change;
								temp.z = 0;
								change = GameObject.Find ("Player").transform.position;
								change.z = -20;
								GameObject.Find ("Player").transform.position = change;
						}*/
						if (Input.GetKey (KeyCode.UpArrow)) {
								temp.y += speed;
								if (temp.y > 4.98f) {
										temp.y = 4.98f;
								}
								temp.x = Mathf.Sqrt (25.0f - (temp.y * temp.y));
								
						} else if (Input.GetKey (KeyCode.DownArrow)) {
								temp.y -= speed;
								if (temp.y < -4.98f) {
										temp.y = -4.98f;
								}
								temp.x = Mathf.Sqrt (25.0f - (temp.y * temp.y));
						} else if (Input.GetKeyUp (KeyCode.Space)) {
								if (GameObject.Find ("Player").transform.position.z == -20.0f) {
										Vector3 change = GameObject.Find ("Player_2").transform.position;
										change.z = -20;
										GameObject.Find ("Player_2").transform.position = change;
										temp.z = -20;
										GameObject.Find ("Player").transform.position = new Vector3 (0, 0, 0);
								} else if (GameObject.Find ("Player").transform.position.z == 0) {
										Vector3 change = GameObject.Find ("Player_2").transform.position;
										change.z = 0;
										GameObject.Find ("Player_2").transform.position = change;
										temp.z = 0;
										change = GameObject.Find ("Player").transform.position;
										change.z = -20;
										GameObject.Find ("Player").transform.position = change;
								}
						}
				} else if (name == "Player_2") {
						//Debug.Log ((Mathf.Atan(temp.y/temp.x)*Mathf.Rad2Deg).ToString());
						if (Input.GetKey (KeyCode.W)) {
								temp.y += speed;
								if (temp.y > 4.98f) {
										temp.y = 4.98f;
								}
								temp.x = -Mathf.Sqrt (25.0f - (temp.y * temp.y));
						} else if (Input.GetKey (KeyCode.S)) {
								temp.y -= speed;
								if (temp.y < -4.98f) {
										temp.y = -4.98f;
								}
								temp.x = -Mathf.Sqrt (25.0f - (temp.y * temp.y));

						}
				} else if (name == "Player" && transform.position.z == 0) {
						if (Input.GetKey (KeyCode.UpArrow)) {
								temp.y += speed;
								if (temp.y > 1.5f) {
										temp.y = 1.5f;
								} else if (temp.y > Mathf.Sqrt (2.25f - (temp.x * temp.x))) {
										if (temp.x > 0) {
												temp.x -= speed;
										} else {
												temp.x += speed;
										}
								}
						} else if (Input.GetKey (KeyCode.DownArrow)) {
								temp.y -= speed;
								if (temp.y < -1.5f) {
										temp.y = -1.5f;
								} else if (temp.y < -Mathf.Sqrt (2.25f - (temp.x * temp.x))) {
										if (temp.x > 0) {
												temp.x -= speed;
										} else {
												temp.x += speed;
										}
								}
						} else if (Input.GetKey (KeyCode.RightArrow)) {
								temp.x += speed;
								if (temp.x > 1.5f) {
										temp.x = 1.5f;
								} else if (temp.x > Mathf.Sqrt (2.25f - (temp.y * temp.y))) {
										if (temp.y > 0) {
												temp.y -= speed;
										} else {
												temp.y += speed;
										}
								}
						} else if (Input.GetKey (KeyCode.LeftArrow)) {
								temp.x -= speed;
								if (temp.x < -1.5f) {
										temp.x = -1.5f;
								} else if (temp.x < -Mathf.Sqrt (2.25f - (temp.y * temp.y))) {
										if (temp.y > 0) {
												temp.y -= speed;
										} else {
												temp.y += speed;
										}
								}
						}
				}
				transform.position = temp;
	}
	
	/*void OnTriggerEnter(Collider col)
	{
		if (col.name == "W(Clone)" && name == "Player") {
						score++;
				} else if ((col.name == "G(Clone)" && name == "Player_1") || (col.name == "R(Clone)" && name == "Player_2")) {
						score++;
				}
		/*if (col.name == "W(Clone)" || col.name == "R(Clone)" || col.name == "G(Clone)") {
						Debug.Log (col.name);
				}*
	}*/

	/*void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log (col.name);
	}*/

	/*void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log (col.collider.name);
	}*/

	/*void OnCollisionEnter(Collision col)
	{
		Debug.Log (col.collider.name);
	}*/
}
