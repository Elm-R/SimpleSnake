﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake
{
    internal class Input
    {
        // detect user's input

        // load a list of the available keyboard buttons
         private static Hashtable keyTable = new Hashtable();   

        // check if a button is pressed

        public static bool KeyPressed (Keys key)
        {
            if (keyTable[key] == null) 
            {
                return false;
            
            }

            return (bool) keyTable[key];

        }


        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;


        }


    }
}
