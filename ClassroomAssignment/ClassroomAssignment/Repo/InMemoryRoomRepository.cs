using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model.Repo
{
    class InMemoryRoomRepository : IRoomRepository
    {
        static InMemoryRoomRepository Instance;


        public static InMemoryRoomRepository getInstance()
        {
            if (Instance != null)
            {
                return Instance;
            }

            else return new InMemoryRoomRepository();
        }

        public string getNormalizedRoomName(string roomName)
        {
            throw new NotImplementedException();
        }
    }
}
