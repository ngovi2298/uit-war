﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uit_war
{
    [Serializable]
    public class SocketData
    {
        private int command;

        public int Command
        {
            get { return command; }
            set { command = value; }
        }

        private Point point;

        public Point Point
        {
            get { return point; }
            set { point = value; }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public CurrentTrop Current { get => current; set => current = value; }

        private CurrentTrop current;
        //public SocketData(int command, string message, Point point)
        //{
        //    this.Command = command;
        //    this.Point = point;
        //    this.Message = message;
        //}
        public SocketData(int command,CurrentTrop currentTrop,Point point)
        {
            this.command = command;
            this.Current = currentTrop;
            this.point = point;
        }
    }

    public enum SocketCommand
    {
        SEND_POINT,
        NOTIFY,
        NEW_GAME,
        UNDO,
        END_GAME,
        QUIT
    }
}
