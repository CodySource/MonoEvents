using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CodySource
{
    public class OnFixedUpdate : MonoBehaviour
    {
        public UnityEvent onTrigger = new UnityEvent();
        private void FixedUpdate() => onTrigger?.Invoke();
    }
}