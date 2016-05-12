using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    public static PlayerManager instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(this);
    }

    public int bulletCount;
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }


    public void RespawnPlayer(int playerId)
    {

    }
}
