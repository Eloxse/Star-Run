using UnityEngine;

namespace _Scripts.Player
{
    public class PlayerInputs : MonoBehaviour
    {
        #region Variables
        public bool jump;
        public float horizontalMovement;
        #endregion

        #region Builtin Methods
        private void Update()
        {
            jump = Input.GetButtonDown("Jump");
            horizontalMovement = Input.GetAxis("Horizontal");
        }
        #endregion
    }
}