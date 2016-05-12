using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {


    public static Score Inst = null;
   

    void Awake()
    {
        if (Inst == null)
        {
            Inst = this;
        }
        else if (Inst != this)
        {
            Destroy(this);
        }
        text = GetComponent<Text>();
        score = 0;
    }

    public int score;
    public int multiplicateurScore = 100;
    Text text;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = "Score" + score;
	}

    public void AddPoint(int enemySize )
    {
        score = score + enemySize * multiplicateurScore;
        text.text = score.ToString();
    }
}
