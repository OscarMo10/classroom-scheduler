using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model.Repo
{
    class InMemoryRoomRepository : IRoomRepository
    {
        private static InMemoryRoomRepository instance;

        private static void initInstance()
        {
            instance = new InMemoryRoomRepository();
           
        }

        public static InMemoryRoomRepository getInstance()
        {
            return instance;
        }        

        public string getNormalizedRoomName(string roomName)
        {
            throw new NotImplementedException();
        }
    }
}
