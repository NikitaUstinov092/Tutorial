using System;
using Zenject;

namespace GamePlay.Player
{
    public class PlayerAdapter: IInitializable, IDisposable
    {
        private PlayerInput _playerInput;
        private PlayerShoot _playerShoot;
        private Move _move;
        
        [Inject]
        private void Construct(PlayerInput playerInput, PlayerShoot playerShoot, Move move)
        {
            _playerInput = playerInput;
            _playerShoot = playerShoot;
            _move = move;
        }
        public void Initialize()
        {
            _playerInput.OnFirePressed += _playerShoot.Fire;
            _playerInput.Direction += _move.SetDirection;
        }

        public void Dispose()
        {
            _playerInput.OnFirePressed -= _playerShoot.Fire;
            _playerInput.Direction -= _move.SetDirection;
        }
    }
}