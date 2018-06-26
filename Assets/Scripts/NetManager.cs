using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class NetManager : NetworkManager
{
    private void Update()
    {
        
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(150, 50, 125, 50), "Start Server"))
            StartServer();
    }

    //Server Functions

    public override void OnStartServer()
    {
        base.OnStartServer();
        Debug.Log("Server has successfully started");
    }

    public override void OnServerConnect(NetworkConnection conn)
    {
        base.OnServerConnect(conn);
        Debug.Log("Client connected with ID: " + conn.connectionId);
    }


    // Client Functions

    public void connectAsClient()
    {
        StartClient();
    }
    
    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Client has connected. ID: " + conn.connectionId);
    }

   
}
