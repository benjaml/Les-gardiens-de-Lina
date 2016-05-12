using UnityEngine;
using UnityEngine.UI;
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
    public Text[] playerRespawnText;
    

    // Update is called once per frame
    void Update () {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            PlayerPrefs.SetInt("Score", Score.Inst.score);
            PlayerPrefs.SetInt("BulletCount", bulletCount);
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
            playerRespawnText[PlayerId].text = i.ToString();
            yield return new WaitForSeconds(1f);
        }
        playerRespawnText[PlayerId].text = "";
        Instantiate(players[PlayerId]);
        yield return null;
    }
}
