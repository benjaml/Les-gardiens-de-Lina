using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

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

    public int score = 0;
    public int combo = 1;
    public float timeBetweenPoint;
    public int multiplicateurScore = 100;
    public Image comboImage;
    public Sprite[] comboSprite;

    float lastPoint;
    Text text;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = "Score " + score;
        if(combo != 1 && Time.time > lastPoint+timeBetweenPoint)
        {
            combo = 1;
            comboImage.enabled = false;
        }
        if(combo >1)
        {
            comboImage.sprite = comboSprite[combo-2];
        }
	}

    public void AddPoint(int enemySize )
    {
        if(Time.time < lastPoint+timeBetweenPoint)
        {
            comboImage.enabled = true;
            combo = Mathf.Min(combo+1,9);
            comboImage.transform.DOPunchScale(new Vector3(1f, 1f, 0f) * 0.3f, 0.1f, 5, 0.1f);
        }
        lastPoint = Time.time;
        text.transform.DOPunchScale(new Vector3(1f,1f,0f)*0.3f, 0.1f, 5, 0.1f);
        Invoke("ResetScale",0.1f);
        score += (enemySize * multiplicateurScore)*combo;
        text.text = score.ToString();
    }

    void ResetScale()
    {
        text.transform.localScale = Vector3.one;
        comboImage.transform.localScale = Vector3.one;
    }
}
