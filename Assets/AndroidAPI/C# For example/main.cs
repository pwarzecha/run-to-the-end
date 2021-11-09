using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour
{

    public InputField toast;

    public void ToastEnter()
    {
        AndroidAPI.Toast(toast.text);
    }
    public void VibrateOn()
    {
        AndroidAPI.Vibration(300);
    }
    public void SetLantern()
    {

        bool ac = false;
        ac = !ac; 
        AndroidAPI.SetLantern(ac);
    }

}
