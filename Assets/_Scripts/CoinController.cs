using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {
    
  public AudioSource coinSound;
  private WaitForSeconds waitTime = new WaitForSeconds(0.15f);
  // Use this for initialization
  void Start() {
		
  }
	
  // Update is called once per frame
  void Update() {
	    
    transform.Rotate(Vector3.forward * Time.deltaTime * 360);
  }

  void OnCollisionEnter(Collision other) {

    if (other.gameObject.CompareTag("Player")) {
      StartCoroutine(playCoinSound());
    }
  }

  // Coroutine
  IEnumerator playCoinSound() {
    coinSound.Play();
    yield return waitTime;
    gameObject.SetActive(false);
  }

}
