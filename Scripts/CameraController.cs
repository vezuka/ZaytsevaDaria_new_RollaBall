using UnityEngine;
using System.Data;

namespace RollaBall
{
    public class CameraController : MonoBehaviour
    {
        public Player Player;
        private Vector3 _offset;

        public float shakeDuration = 2f;
        public float shakeAmount = 0.7f;
        public float decreaseFactor = 0.5f;

        private Vector3 _originalPos;

        private void Start()
        {
            _offset = transform.position - Player.transform.position;
        }

        private void LateUpdate()
        {
            if (Player)
            {
                transform.position = Player.transform.position + _offset;
            }
            else
            {
                throw new DataException("Player not found");
            }
        }

        public void CameraShake()
        {

            _originalPos = _offset;

            if (shakeDuration > 0)
            {
                _offset = _originalPos + Random.insideUnitSphere * shakeAmount;

                shakeDuration -= Time.deltaTime * decreaseFactor;
            }
            else
            {
                shakeDuration = 0f;
                _offset = _originalPos;
            }
        }
    }
}