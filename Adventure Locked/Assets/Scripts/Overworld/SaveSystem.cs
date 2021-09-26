
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveCaravan(CaravanMove caravan){
    	BinaryFormatter formatter = new BinaryFormatter();
    	string path = Application.persistentDataPath + "/caravan.two";
    	FileStream stream = new FileStream(path, FileMode.Create);

    	CaravanData data = new CaravanData(caravan);
    	formatter.Serialize(stream,data);
    	stream.Close();

    }

    public static CaravanData LoadCaravan(){
    	string path = Application.persistentDataPath + "/caravan.two";
    	if(File.Exists(path)){
    		Debug.Log("I'm in.");
    		BinaryFormatter formatter = new BinaryFormatter();
    		FileStream stream = new FileStream(path, FileMode.Open);

    		CaravanData data= formatter.Deserialize(stream) as CaravanData;

    		stream.Close();

    		return data;

    	}
    	else{
    		Debug.LogError("Save file not found in " + path);
    		return null;
    	}

    }
}
