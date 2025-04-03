using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] private Animator myAnimationController;

    public GameObject obstacle;
    public Transform spawnPoint;
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiscoreText;
    public Button retryButton;
    public Button restart;
    public GameObject ClickToPlay;
    public ParticleSystem dust;
    
    public float initialGameSpeed;
    public float gameSpeedIncrease;
    public float gameSpeed { get; private set;}
    private float score;
    
    private PlayerController player;
    private PlayerController JumpEnabled;
    private Spawner spawner;

    private void Awake()
    {
        if (Instance == null){
            Instance = this;
        } else {
            DestroyImmediate(gameObject);
        }
        PlayerPrefs.SetFloat("hiscore",0);
    }
    private void OnDestroy()
    {
        if(Instance == this){
            Instance = null;
        }
    }

    public void NewGame()
    {
        dust.Play();
        gameSpeed = initialGameSpeed;
        ClickToPlay.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);

            enabled = true;
            myAnimationController.SetBool("Stop",false);
            player.gameObject.SetActive(true);
            spawner.gameObject.SetActive(true);
    }

    public void Restart()
    {
        Obstacle[] obstacles = FindObjectsOfType<Obstacle>();

        foreach (var obstacle in obstacles) {
            Destroy(obstacle.gameObject);
        }
        // clears the previous obstacles

        score = 0f;
        retryButton.gameObject.SetActive(false);

        ClickToPlay.gameObject.SetActive(true);
        restart.gameObject.SetActive(true);
    }
    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        spawner = FindObjectOfType<Spawner>();
        enabled = false;
        spawner.gameObject.SetActive(false);
        myAnimationController.SetBool("Stop",true);
        dust.Stop();

        Restart();
        UpdateHiscore();
    }

    public void GameOver()
    {
        gameSpeed = 0f;
        enabled = false;
        spawner.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(true);
        UpdateHiscore();
        myAnimationController.SetBool("Stop",true);
        dust.Stop();
    }
    
    private void Update()
    {
        gameSpeed -= gameSpeedIncrease * Time.deltaTime;
        score += -gameSpeed / 6 * Time.deltaTime;
        scoreText.text = Mathf.FloorToInt(score).ToString("D5");
    }

    private void UpdateHiscore()
    {
        float hiscore = PlayerPrefs.GetFloat("hiscore", 0);
        if (score > hiscore)
        {
            hiscore = score;
            PlayerPrefs.SetFloat("hiscore", hiscore);
        }
        hiscoreText.text = Mathf.FloorToInt(hiscore).ToString("D5");
    }
}
