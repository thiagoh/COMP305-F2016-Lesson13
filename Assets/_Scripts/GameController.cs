using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

  public Transform spawnPoint;
  public GameObject player;
  public GameObject coin;

  private static int MAX_COINS = 20;

  private List<GameObject> coinPool;

  // Use this for initialization
  void Start() {
    Instantiate(player);
    player.transform.position = spawnPoint.position;
    coinPool = new List<GameObject>();
    buildCoinPool();
  }
	
  // Update is called once per frame
  void Update() {
    placeCoins();
  }

  void buildCoinPool() {

    for (int i = 0; i < MAX_COINS; i++) {
    
      GameObject _coin = (GameObject)Instantiate(coin);
      _coin.SetActive(false);
      coinPool.Add(_coin);
    }
  }

  private void placeCoins() {

    foreach (GameObject _coin in coinPool) {
      if (!_coin.activeInHierarchy) {
        _coin.SetActive(true);
        _coin.transform.position = new Vector3(Random.Range(-20f, 20f), 20f, Random.Range(-20f, 20f));
      }
    }
  }
}
