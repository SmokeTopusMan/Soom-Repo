﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Security.Policy;

namespace Soom_server
{
    internal class Program
    {
        //public static Server server = new Server();

        static void Main(string[] args)
        {
            Console.WriteLine("Setting up server...."); 
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(Server._ip), Server._port);
            Server._serverSocket.Bind(ipEndPoint);
            Server._serverSocket.Listen(10);
            Console.WriteLine("Server is listening....");
            Socket clientSock = default(Socket);
            while (true)
            {
                clientSock = Server._serverSocket.Accept();
                Console.WriteLine("Client was accepted");
                Server.ClientJoined();
                Thread clientThread = new Thread(new ThreadStart(() => Server.HandleClient(new User(clientSock, Server._clientsNum)))); //Useful: if doesnt work: 1. before the loop do Program p = new Program; 2. replace after the => to p.HandleClient(sock, server._clientNum); 3. make the func HandleClient in Program
                clientThread.Start();
                Server.AddThread(clientThread);
            }
        }
    }
}
