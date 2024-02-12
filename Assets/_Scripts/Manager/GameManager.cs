using _Scrpipt.Manager;
using UnityEngine;

namespace _Script.Manager
{
    public class GameManager : MonoBehaviour
    {
        #region Variables
        //public static GameManager instance;

        /*[Header("Manager")]
        [SerializeField] private AudioSource ambientSound;*/

        /*[Header("Life")]
        public int life = 3;
        [SerializeField] private AudioSource loseLifeSound;*/

        [Header("Score")]
        [SerializeField] private int scoreValue = 1;
        //[SerializeField] private AudioSource scoreSound;

        /*[Header("Game Over")]
        [SerializeField] private GameObject gameOverUI;
        [SerializeField] private GameObject clockSound;
        [SerializeField] private AudioSource gameOverSound;*/

        /*[Header("Win")]
        [SerializeField] private GameObject winUI;
        [SerializeField] private AudioSource winSound;*/

        private UIManager _ui;

        //private bool _isLosed;
        public int _score;
        #endregion

        #region Builtin Methods
        /*private void Awake()
        {
            if(instance != null)
            {
                Destroy(gameObject);
            }

            instance = this;
        }*/

        private void Start()
        {
            _ui = GetComponent<UIManager>();

            /*if (ambientSound)
            {
                ambientSound.Play();
            }*/
        }

        /*private void Update()
        {
            NoMoreLife();
        }*/
        #endregion

        #region Custom Methods
        public void AddScore()
        {
            Debug.Log("ee");
            _score += scoreValue;

            _ui.UpdateScoreText(_score);
            /*_ui.UpdateEndScoreText(_score);
            scoreSound.Play();*/
        }
        //Increment the scoring and call the function to update the text

        /*public void RemoveLife()
        {
            life -= 1;

            _ui.UpdateLifeImage(life);
            loseLifeSound.Play();
        }
        //Decrement life count*/

        /*private void NoMoreLife()
        {
            if(life <= 0 && !_isLosed)
            {
                _isLosed = true;

                GameOver();
            }
        }
        //Active the game over function, when life count equal to 0*/

        /*public void GameOver()
        {
            clockSound.SetActive(false);
            userInterface.SetActive(false);
            panJoke.SetActive(false);
            gameOverSound.Play();

            gameOverUI.SetActive(true);
        }
        //Display the game over screen*/

        /*public void Win()
        {
            userInterface.SetActive(false);
            panJoke.SetActive(false);
            winSound.Play();

            winUI.SetActive(true);
        }
        //Display win screen*/
        #endregion
    }
}
