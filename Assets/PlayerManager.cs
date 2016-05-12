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
    public int respawnTime;
    public GameObject[] players;

    // Update is called once per frame
    void Update () {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }


    public void RespawnPlayer(int playerId)
    {
        StartCoroutine(Respawn(playerId-1));
    }

    IEnumerator Respawn(int PlayerId)
    {
        for(int i = respawnTime;i>0;i--)
        {
            yield return new WaitForSeconds(1f);
            // update player text Timer
        }
        Instantiate(players[PlayerId]);
        yield return null;
    }
}
