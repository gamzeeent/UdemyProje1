using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using proje1.Inputs;
using proje1.Movements;


namespace proje1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _TurnSpeed = 10f;

        [SerializeField] float _force = 55f;

        DefaultInput _input;

        Mover _mover;

        Rotator _rotator;

        bool _isForceUp;

        float _LeftRight;

        public float TurnSpeed => _TurnSpeed;
        public float Force => _force;

        private void Awake()
        {

            _input = new DefaultInput();
            _mover = new Mover(playerController:this );
            _rotator = new Rotator(playerController: this);
        }
        private void Update()
        {
            Debug.Log(_input.IsForceUp);
            if (_input.IsForceUp)
            {
                _isForceUp = true;

            }
            else
            {
                _isForceUp = false;
            }

            _LeftRight = _input.LeftRight;

        }
        private void FixedUpdate()
        {
            if (_isForceUp)
            {

                _mover.FixedTick();
            }

            _rotator.FixedTick(_LeftRight);

        }
    }

}
