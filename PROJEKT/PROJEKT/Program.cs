﻿using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml;
using PROJEKT.Classes;
using PROJEKT.Classes.Database.Objects;
using PROJEKT.Classes.Messages;
using PROJEKT.Classes.Exceptions;
using PROJEKT.Classes.System;

namespace PROJEKT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Log.CurrentLevel = Log.LevelEnum.DEB;


            using var _log = Log.DEB("Program", "Main");

            _log.PR_DEB("Początek aplikacji");


            if ((args?.Length ?? 0) < 1)
            {
                _log.PR_DEB("Brak argumentu uruchomieniowego! 1 - serwer, 2 - klient");

            }
            else
            {
                int.TryParse(args[0], out int _iMode);

                XmlStorageTypes.Register<Exception>();

                MessageFactory.Instance.Register<LoginMessage>();
                MessageFactory.Instance.Register<TextMessage>();

                switch (_iMode)
                {
                    case 1:
                        new TestServer().Run(); break;

                    case 2:
                        new TestClient().Run(); break;

                }

            }


        }
    }
}
