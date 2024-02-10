using System.Collections.Generic;
using UnityEngine;

namespace _Scripts.Gameplay
{
    public class GroundGenerator : MonoBehaviour
    {
        #region Variables
        [SerializeField] private List<GameObject> grounds;
        [SerializeField] private float spawnPosition = 20f;
        #endregion

        #region Builtin Methods
        private void Start()
        {
            SpawnGround(new Vector3(0, 0, spawnPosition));
        }
        #endregion

        #region Custom Methods
        private void SpawnGround(Vector3 _spawnPosittion)
        {
            int _groundID = Random.Range(0, grounds.Count);

            GameObject.Instantiate(grounds[_groundID], _spawnPosittion, Quaternion.identity);
        }
        #endregion
    }
}