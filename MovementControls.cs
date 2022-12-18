using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assembly_CSharp
{
    public class MovementControls
    {
        float speedclone = 3;
        float moveSens = 1.25f;
        float runMult = 1.5f;

        public void MovementControlsForward(float forward, float speed)
        {
            if (Input.GetKey(KeyCode.W) && forward < 2)
            {
                forward += moveSens * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.S) && forward > -2)
            {
                forward -= moveSens * Time.deltaTime;
            }
            else
            {
                if (forward > 0)
                {
                    forward -= moveSens * Time.deltaTime * 3;
                }
                else if (forward < 0)
                {
                    forward += moveSens * Time.deltaTime * 3;
                }
            }

            if (forward > 1)
            {
                speed = speedclone + (speedclone * runMult - speedclone) * (forward - 1);
            }
        }

        public void MovementControlsSide()
        {

        }
    }
}
