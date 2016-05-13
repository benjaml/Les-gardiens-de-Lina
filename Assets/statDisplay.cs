using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class statDisplay : MonoBehaviour {

    public Text highscore;
    public Text score;
    public Text bulletFired;
    public Text enemyKilled;

    // Use this for initialization
    void Start () {
        highscore.text = PlayerPrefs.GetInt("Highscore").ToString();
        score.text = PlayerPrefs.GetInt("Score").ToString();
        bulletFired.text = PlayerPrefs.GetInt("BulletCount").ToString();
        enemyKilled.text = PlayerPrefs.GetInt("EnemyCount").ToString();
    }
	
}
