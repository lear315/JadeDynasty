﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DashFire
{
    public class UserView : CharacterView
    {
        public void Destroy()
        {
            DestroyActor();
            Release();
        }

        private void Release()
        {

        }
    }
}