using AutoMapper;

namespace StudentAPI.Models
{
    public class MappingProfile: Profile
    {
        // Source and Target Model Mapping
        public MappingProfile()
        {
            CreateMap<Student,StudentMini>();
        }
    }
}
