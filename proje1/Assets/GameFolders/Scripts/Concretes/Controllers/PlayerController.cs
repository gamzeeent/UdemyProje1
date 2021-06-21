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

        Fuel _fuel;

        bool _canForceUp;

        float _LeftRight;

        public float TurnSpeed => _TurnSpeed;
        public float Force => _force;

        private void Awake()
        {

            _input = new DefaultInput();
            _mover = new Mover(playerController:this );
            _rotator = new Rotator(playerController: this);
            _fuel = GetComponent<Fuel>();

        }
        private void Update()
        {
         
            if (_input.IsForceUp && ! _fuel.IsEmpty)
            {
                _canForceUp = true;

            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(increase: 0.01f);
            }

            _LeftRight = _input.LeftRight;

        }
        private void FixedUpdate()
        {
            if (_canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }

            _rotator.FixedTick(_LeftRight);

        }
    }

}
