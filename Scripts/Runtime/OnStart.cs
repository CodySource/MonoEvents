using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CodySource
{
    public class OnStart : MonoBehaviour
    {
        public UnityEvent onTrigger = new UnityEvent();
        private void Start() => onTrigger?.Invoke();
    }
}