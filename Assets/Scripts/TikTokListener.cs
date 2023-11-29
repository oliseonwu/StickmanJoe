using System;
using System.Collections.Generic;
using System.Linq;
using WebSocketSharp;
using UnityEngine;

public class TikTokListener : MonoBehaviour
{
    private WebSocket ws;
    public GiftBatchHandler giftBatchHandler;
    void Start()
    {
        ws = new WebSocket("ws://localhost:8080");

        ws.OnMessage +=  OnMessageReceived;
        ws.Connect();
        
    }

    void OnMessageReceived(object Serverws,  MessageEventArgs e)
    {
         String[] data = e.Data.Split(",");

        if (data[0].Trim().Equals("gift") )
        {
            if (data[2].Trim().Equals("Rose"))
            {
                Debug.Log("jjjjj");

            }
            UnityMainThreadDispatcher.Enqueue(()=>giftBatchHandler.addToGiftIdContainer(data[3], 1));
            
        }
        
        
        // {"type":"gift","uniqueId":"1rabbitcatcher","giftName":"Rose"}
    }

    
}
