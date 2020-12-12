﻿using System;
using System.Collections.Generic;
using System.Text;
using PROJEKT.Classes;

namespace PROJEKT.Interfaces
{
    public interface INetworkAction
    {
        public enum State
        {
            Connecting = 0x0001,
            Connected  = 0x0002,
            Sending    = 0x0010,
            Sent       = 0x0011,
            Receiving  = 0x0020,
            Received   = 0x0021,
            Listening  = 0x0030,
            Established= 0x0031,
            Error      = 0x0100
        }

        void StateChanged(State a_eState, StateObject a_oStateObject = null);
    }
}
