using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model
{
    interface IRoomRepository
    {
        string getNormalizedRoomName(string roomName);
    }
}
