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
    public int enemyKilled;
    public int respawnTime;
    public GameObject[] players;
    public Text[] playerRespawnText;
    public GameObject GameOverUI;
    

    // Update is called once per frame
    void Update () {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            if (Score.Inst.score > PlayerPrefs.GetInt("Score"))
                PlayerPrefs.SetInt("Highscore", Score.Inst.score);
            PlayerPrefs.SetInt("Score", Score.Inst.score);
            PlayerPrefs.SetInt("BulletCount", bulletCount);
            PlayerPrefs.SetInt("EnemyCount", enemyKilled);
            EnemyManager.Instance.StopSpawn();
            StopAllCoroutines();
            if(GameObject.FindGameObjectWithTag("UI"))
                GameObject.FindGameObjectWithTag("UI").SetActive(false);
            Instantiate(GameOverUI);
            Destroy(this);
            //SceneManager.LoadScene("GameOver");
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
            playerRespawnText[PlayerId].text = "Respawn in "+i;
            yield return new WaitForSeconds(1f);
        }
        playerRespawnText[PlayerId].text = "";
        if(GameObject.Find("Player"+(PlayerId+1))== null)
            Instantiate(players[PlayerId]);
        yield return null;
    }
}
