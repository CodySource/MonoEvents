using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CodySource
{
    public class OnUpdate : MonoBehaviour
    {
        public UnityEvent onTrigger = new UnityEvent();
        private void Update() => onTrigger?.Invoke();
    }
}