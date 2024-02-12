using UnityEngine;
using TMPro;

namespace _Scrpipt.Manager
{
    public class UIManager : MonoBehaviour
    {
        #region Variables
        //public static UI_Manager instance;

        //[SerializeField] private List<GameObject> _btn;

        [Header("Score")]
        [SerializeField] private TMP_Text txtScore;
        /*[SerializeField] private TMP_Text txtEndScoreW;
        [SerializeField] private TMP_Text txtEndScoreGO;*/

        /*[Header("Life")]
        [SerializeField] private GameObject heartPrefab;
        [SerializeField] private Transform heartParent;*/

        //private string _chara;

        /*private GameObject[] _hearts;
        private GameManager _gm;*/
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

        /*private void Start()
        {
            CreateHeart();

            _gm = GameManager.instance; 
        }*/
        #endregion

        #region Custom Methods
        /*private void CreateHeart()
        {
            _hearts = new GameObject[GameManager.instance.life];

            for (int i = 0; i < GameManager.instance.life; i++)
            {
                GameObject heart = Instantiate(heartPrefab, heartParent);
                _hearts[i] = heart;
            }
        }
        //Generate hearts from the heart prefab*/

        public void UpdateScoreText(int nbScore)
        {
            txtScore.text = nbScore.ToString();
        }
        //Update the text for the scoring

        /*public void UpdateEndScoreText(int nbEndScore)
        {
            txtEndScoreW.text = nbEndScore.ToString();
            txtEndScoreGO.text = nbEndScore.ToString();
        }
        //Update the text for the scoring at the end of the game*/

        /*public void UpdateLifeImage(int nbLife)
        {
            _hearts[nbLife].SetActive(false);
        }
        //Update life number left*/
        #endregion
    }
}