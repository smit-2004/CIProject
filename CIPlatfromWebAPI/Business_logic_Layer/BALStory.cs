using Data_Access_Layer.Common;
using Data_Access_Layer.Repository.Entities;
using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic_Layer
{
    public class BALStory
    {
        private readonly DALStory _dalStory;
        public BALStory(DALStory dalStory)
        {
            _dalStory = dalStory;
        }
        public List<DropDown> GetMissionTitle()
        {
            return _dalStory.GetMissionTitle();
        }
        public string AddStory(Story story)
        {
            return _dalStory.AddStory(story);
        }
        public List<Story> ClientSideStoryList()
        {
            return _dalStory.ClientSideStoryList();
        }
        public Story StoryDetailById(int id)
        {
            return _dalStory.StoryDetailById(id);
        }
    }
}
