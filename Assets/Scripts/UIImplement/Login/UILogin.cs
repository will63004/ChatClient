using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIImplement.Login
{
    public class UILogin:MonoBehaviour
    {
        [SerializeField]
        private TMP_InputField playerID;
        [SerializeField]
        private Button login;

        public event Action OnClickLogin;

        private void Awake()
        {
            login.onClick.AddListener(delegate 
            {
                OnClickLogin?.Invoke();
            });
        }

        public void SetPlayerID(ulong id)
        {
            playerID.text = id.ToString();
        }
    }
}
