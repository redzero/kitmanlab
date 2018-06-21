using UnityEngine;



public class JsonHelper
{
    //public static T[] getJsonArray<T>(string json)
    //{
    //    string newJson = "{ \"positions\": " + json + "}";
    //    JSONArrayWrapper<T> wrapper = JsonUtility.FromJson<JSONArrayWrapper<T>>(newJson);
    //    return wrapper.positions;
    //}

    [System.Serializable]
    private class JSONArrayWrapper<T>{
        public T[] athletes;
        //public T[] positions;
    }

    public static T[] FromJson<T>(string json) {
        JSONArrayWrapper<T> wrapper = JsonUtility.FromJson<JSONArrayWrapper<T>>(json);
        return wrapper.athletes;
    }
}
