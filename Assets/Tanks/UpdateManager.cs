using DefaultNamespace;
using UnityEngine;

namespace Tanks
{
    public class UpdateManager : MonoBehaviour
    {
        private ITickable[] _tickables;
        private int _current;
        
        public void Initialize(int size)
        {
            if (size > 0)
            {
                _tickables = new ITickable[size];
            }
        }

        private void Update()
        {
            if (_tickables == null)
            {
                return;
            }
            foreach (var tickable in _tickables)
            {
                tickable?.Tick();
            }
        }

        public void Add(ITickable tickable)
        {
            _tickables[_current++] = tickable;
        }
    }
}