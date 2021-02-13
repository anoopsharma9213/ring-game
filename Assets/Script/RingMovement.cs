using UnityEngine;
using System.Collections;

public class RingMovement : MonoBehaviour
{

		bool destroyed = false;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				Vector3 temp = transform.position;

				if (temp.z <= 0.1f && temp.z >= - 0.1f) {
						if (name == "R(Clone)" && GameObject.Find ("Player_2").transform.position.z == 0) {
								Vector3 compare = GameObject.Find ("Player_2").transform.position;
								float x_max = transform.position.x + renderer.bounds.size.x * 0.5f;
								float x_min = transform.position.x - renderer.bounds.size.x * 0.5f;
								float y_max = transform.position.y + renderer.bounds.size.y * 0.5f;
								float y_min = transform.position.y - renderer.bounds.size.y * 0.5f;
								if (compare.x <= x_max && compare.x >= x_min && compare.y <= y_max && compare.y >= y_min) {
										PlayerMove.score++;
										DestroyImmediate (gameObject);
										destroyed = true;
								}
								/*float check = Mathf.Atan (compare.y / compare.x) * Mathf.Rad2Deg;
								float max;
								if (transform.rotation.eulerAngles.z >= 285) {
										max = transform.rotation.eulerAngles.z - 360.0f;
								} else {
										max = transform.rotation.eulerAngles.z + 5.0f;
								}
								float min = max - 20.0f;

								if (check >= min && check <= max) {
										PlayerMove.score++;
								}*/
						} else if (name == "G(Clone)" && GameObject.Find ("Player_1").transform.position.z == 0) {
								Vector3 compare = GameObject.Find ("Player_1").transform.position;
								float x_max = transform.position.x + renderer.bounds.size.x * 0.5f;
								float x_min = transform.position.x - renderer.bounds.size.x * 0.5f;
								float y_max = transform.position.y + renderer.bounds.size.y * 0.5f;
								float y_min = transform.position.y - renderer.bounds.size.y * 0.5f;
								if (compare.x <= x_max && compare.x >= x_min && compare.y <= y_max && compare.y >= y_min) {
										PlayerMove.score++;
										DestroyImmediate (gameObject);
										destroyed = true;
								}
								/*float check = Mathf.Atan (compare.y / compare.x) * Mathf.Rad2Deg + 180.0f;
								float max = transform.rotation.eulerAngles.z + 5.0f;
								float min = max - 20.0f;
				
								if (check >= min && check <= max) {
										PlayerMove.score++;
								}*/
						} else if (name == "W(Clone)" && GameObject.Find ("Player").transform.position.z == 0) {
								Vector3 compare = GameObject.Find ("Player").transform.position;
								float x_max = transform.position.x + renderer.bounds.size.x * 0.5f;
								float x_min = transform.position.x - renderer.bounds.size.x * 0.5f;
								float y_max = transform.position.y + renderer.bounds.size.y * 0.5f;
								float y_min = transform.position.y - renderer.bounds.size.y * 0.5f;
								if (compare.x <= x_max && compare.x >= x_min && compare.y <= y_max && compare.y >= y_min) {
										PlayerMove.score += 2;
										destroyed = true;
										DestroyImmediate (gameObject);
								}
								/*if ((transform.rotation.eulerAngles.z == 282.5f && GameObject.Find ("Player").transform.position.z == 0 && GameObject.Find ("Player").transform.position.y == 4.98f) ||
										(transform.rotation.eulerAngles.z == 102.5f && GameObject.Find ("Player").transform.position.z == 0 && GameObject.Find ("Player").transform.position.y == -4.98f)) {
										PlayerMove.score++;
								}*/
						}
				}
				if (destroyed == false) {
						temp.z -= 0.3f;
						transform.position = temp;

						if (transform.position.z <= -10) {
								DestroyImmediate (gameObject);
						}
				}
		}
}
