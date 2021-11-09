using UnityEngine;

public class AndroidAPI
{
    private const string class_toast = "com.apfu.androidapi.AndroidAPI";
    private static AndroidJavaClass javaClass = new AndroidJavaClass(class_toast);


    public string f;
    public static void Toast(string message)
    {
        if (javaClass != null)
        {
            javaClass.CallStatic("ShoToast", message);
        }
    }
    public static void Vibration(int time)
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("onVibrate", time);
        }
    }
    public static void StartApp(string packages)
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("StartApp", packages);
        }
    }
    public static void SetVolumeMusic(int value)
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("SetVoulemeMusic", value);
        }
    }
    public static void PermOnWRITE_EXTERNAL_STORAGE()
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("PermOnWRITE_EXTERNAL_STORAGE");
        }
    }
    public static void PermOnCamera()
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("PermOnCamera");
        }
    }
    public static void PermOnRead_Calender()
    {
        if (javaClass != null)
        {
            javaClass.CallStatic("PermOnRead_Calendar");
        }
    }
    public static void PermOnReadContacts()
    {
        if (javaClass != null)
        {
            javaClass.CallStatic("PermOnReadContacts");
        }
    }
    public static void PermOnGetAccount()
    {
        if (javaClass != null)
        {
            javaClass.CallStatic("PermOnGetAccount");
        }
    }
    public static void PermOnRecordAudio()
    {
        if (javaClass != null)
        {
            javaClass.CallStatic("PermOnRecordAudio");
        }
    }
    public static void PermOnCallPhoneo()
    {
        if (javaClass != null)
        {
            javaClass.CallStatic("PermOnCallPhone");
        }
    }
    public static void ToShare(string message)
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("ToShare", message);
        }
    }
    public static void SetBluetooth(bool active) 
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("SetBluetooth", active);
        }
    }
    public static void SetLantern(bool active)
    {
        if (javaClass != null)
        {
            javaClass.CallStatic("SetLantern", active);
        }
    }
    public static bool GetAppInstall(string app)
    {
        bool s = false;
        if (javaClass != null)
        {
            s = javaClass.CallStatic<bool>("getAppInstall", app);    
        }
        return s;
    }
    public static string GetManufacturePhone()
    {
        string man = null;
        if(javaClass != null)
        {
            man = javaClass.CallStatic<string>("GetManufacturePhone");
        }
        return man;
    }
    public static int GetSdkPhone()
    {
        int man = 0;
        if (javaClass != null)
        {
            man = javaClass.CallStatic<int>("GetSdkPhone");
        }
        return man;
    }
    public static string GetModelPhone()
    {
        string model = null;
        if(javaClass != null)
        {
            model = javaClass.CallStatic<string>("GetModelPhone");
        }
        return model;
    }
    public static string GetDisplayInfoPhone()
    {
        string info = null;
        if(javaClass != null)
        {
            info = javaClass.CallStatic<string>("GetDisplaySettingPhone");
        }
        return info;
    }
    public static void CallPhone(string num)
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("CallPhone", num);
        }
    }
    public static void OpenSettings()
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("OpenSettings");
        }
    }
    public static void OpenBluetoothSettings()
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("OpenBluetoothSettings");
        }
    }
    public static void OpenDisplaySettings()
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("OpenDisplaySettings");
        }
    }
    public static void OpenDeviceInfoSettings()
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("OpenDeviceInfoSettings");
        }
    }
    public static void OpenApplicationSettings()
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("OpenApplicationSettings");
        }
    }
    public static void OpenSoundsSettings()
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("OpenSoundsSettings");
        }
    }
    public static void OpenSite(string url)
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("GoOnSite", url);
        }
    }
    public static void OpenMap(string pos)
    {
        if(javaClass != null)
        {
            javaClass.CallStatic("GoOnMap", pos);
        }
    }
}
