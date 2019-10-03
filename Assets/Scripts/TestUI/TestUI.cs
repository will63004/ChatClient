using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestUI:MonoBehaviour
{
    [SerializeField]
    private TMP_InputField playerID;
    [SerializeField]
    private Button login;

    private void Awake()
    {
        login.onClick.AddListener(onClickLogin);
    }

    private void onClickLogin()
    {
        ulong id = Convert.ToUInt64(playerID.text);

        TmpDI.Instance.Login.StartLogin(id);
    }
}
