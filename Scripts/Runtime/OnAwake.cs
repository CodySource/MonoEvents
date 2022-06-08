using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CodySource
{
    public class OnAwake : MonoBehaviour
    {
        public UnityEvent onTrigger = new UnityEvent();
        private void Awake() => onTrigger?.Invoke();
    }
}