using UnityEngine;
using System.Collections;



public class GameScript : MonoBehaviour
{

    public Transform level2Enemies;
    private bool level2Complete = true;
    public GameObject level2Rewards;
    public EnemySpawner enemySpawner;
    private int enemiesToSpawn = 3;
    private int waveCount = 1;
    private int waveToWin = 3;
    public AudioSource music;
    public AudioClip wavemusic;


    //Use this for initialization

    protected void Start()
    {

        level2Rewards.SetActive(false);
        music.Play();
        //spawnWave();
    }

    //Update is called once per frame


    protected void update()
    {



        if (level2Enemies.childCount == 0 && level2Complete)
        {
            level2Rewards.SetActive(true);
            //HUD.Message("All enemies destroyed");

        }

        if (enemySpawner.transform.childCount == 0 && EnemySpawner.activated && IsInvoking())
        {
            
            if (waveCount == 1)

            {
                music.clip = wavemusic;
                music.Play();

            }

            if (waveCount > waveToWin)
            {


                enemySpawner.gameObject.SetActive(false);
                    music.Stop();
            }
        
    }
            HUD.Message("Wave" + "" + waveCount);
            waveCount++;
            enemiesToSpawn = Random.Range(waveCount*1,waveCount*2);
            Invoke("spawnWave",2);

        }

    }

    //public void spawnWave()
    //{
        //for (int i = 0; i < enemiesToSpawn; i++)
      //  {
          //  enemyspawner.Invoke("Spawn", i);

      //  }


 

