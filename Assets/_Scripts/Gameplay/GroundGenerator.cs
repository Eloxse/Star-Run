using System.Collections.Generic;
using UnityEngine;

namespace _Scripts.Gameplay
{
    public class GroundGenerator : MonoBehaviour
    {
        #region Variables
        [Header("Ground spawner")]
        [SerializeField] private List<GameObject> grounds;
        [SerializeField] private float spawnGround = 40f;
        #endregion

        #region Builtin Methods
        private void Start()
        {
            SpawnGround(new Vector3(0, 0, spawnGround));
        }
        #endregion

        #region Custom Methods
        private void SpawnGround(Vector3 _spawnPosittion)
        {
            int _groundID = Random.Range(0, grounds.Count);

            GameObject.Instantiate(grounds[_groundID], _spawnPosittion, Quaternion.identity);
        }
        //Choose a random ground prefab, and spawn

        private void OnTriggerEnter(Collider other)
        {
            if(other.transform.tag == "Ground")
            {
                SpawnGround(new Vector3(0, 0, spawnGround));
            }
        }
        #endregion
    }
}