using EasyBook.Model;
using EasyBook.Repository;

namespace EasyBook.Services
{
    public class RoomServices
    {
        private MeetingRoomRepository _meetingREPO = null;

        public RoomServices(MeetingRoomRepository meetingREPO)
        {
            _meetingREPO = meetingREPO;
        }
        public void Add(MeetingRoom meeting)
        {
            _meetingREPO.AddMeeting(meeting);
        }
        public List<MeetingRoom> GetAll()
        {
            return _meetingREPO.GetAll();
        }
        public MeetingRoom Get(int id)
        {
            return _meetingREPO.Get(id);
        }


    }
}


