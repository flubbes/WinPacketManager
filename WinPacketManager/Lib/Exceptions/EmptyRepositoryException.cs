﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPacketManager.Lib.Objects;

namespace WinPacketManager.Lib.Exceptions
{
    public class EmptyRepositoryException : Exception
    {
        public EmptyRepositoryException(Repository rep)
        {
            this.Repository = rep;
        }

        public Repository Repository
        {
            get;
            private set;
        }
    }
}
