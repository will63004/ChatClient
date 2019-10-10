using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Main.UIImplement.Login
{
    public class UILogin:MonoBehaviour
    {
        [SerializeField]
        private TMP_InputField playerID;
        [SerializeField]
        private TMP_InputField ip;
        [SerializeField]
        private Button login;

        public event Action OnClickLogin;
        public event Action<string> OnIpChanged;

        private void Awake()
        {
            login.onClick.AddListener(delegate 
            {                
                OnClickLogin?.Invoke();
            });

            ip.onValueChanged.AddListener((text) =>
            {
                OnIpChanged?.Invoke(text);
            });
        }

        private void OnDestroy()
        {
            login.onClick.RemoveAllListeners();

            ip.onValueChanged.RemoveAllListeners();
        }

        public void SetPlayerID(ulong id)
        {
            playerID.text = id.ToString();
        }
    }
}
