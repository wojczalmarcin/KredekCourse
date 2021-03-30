using AutoMapper;
using MarcinWojczalUniveristyFacultyEF.ViewModels;
using MarcinWojczalUniversityFacultyEF.Models.Entities;


namespace MarcinWojczalUniveristyFacultyEF.Infrastructure
{
    /// <summary>
    /// Klasa odpowiedzialna za mapowanie modeli widoków
    /// </summary>
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            //Tworzenie mapy dla tabeli Workplaces
            CreateMap<Workplace, WorkplaceViewModel>();

            //Tworzenie mapy dla tabeli Addresses
            CreateMap<Address, AddressViewModel>();

            //Tworzenie mapy dla tabeli Students
            CreateMap<Student, StudentViewModel>()

               .ForMember(b => b.FieldOfStudyName, opt => opt.MapFrom(src => src.FieldOfStudy.Name))
               .ForMember(b => b.StudyVintageYear, opt => opt.MapFrom(src => src.StudyVintage.Year));

            //Tworzenie mapy dla tabeli FieldsOfStudies
            CreateMap<FieldOfStudy, FieldOfStudyViewModel>()
              .ForMember(b => b.PatronsDegree, opt => opt.MapFrom(src => src.Worker.Degree))
              .ForMember(b => b.PatronsFirstName, opt => opt.MapFrom(src => src.Worker.FirstName))
              .ForMember(b => b.PatronsLastName, opt => opt.MapFrom(src => src.Worker.LastName));

            //Tworzenie mapy dla tabeli StudyVintages
            CreateMap<StudyVintage, StudyVintageViewModel>()
             .ForMember(b => b.PatronsFirstName, opt => opt.MapFrom(src => src.Student.FirstName))
             .ForMember(b => b.PatronsLastName, opt => opt.MapFrom(src => src.Student.LastName));

            //Tworzenie mapy dla tabeli SubjectGroups
            CreateMap<SubjectGroup, SubjectGroupViewModel>()
             .ForMember(b => b.SubjectName, opt => opt.MapFrom(src => src.Subject.Name))
             .ForMember(b => b.WorkersDegree, opt => opt.MapFrom(src => src.Worker.Degree))
             .ForMember(b => b.WorkersFirstName, opt => opt.MapFrom(src => src.Worker.FirstName))
             .ForMember(b => b.WorkersLastName, opt => opt.MapFrom(src => src.Worker.LastName));

            //Tworzenie mapy dla tabeli Subjects
            CreateMap<Subject, SubjectViewModel>()
             .ForMember(b => b.FieldOfStudyName, opt => opt.MapFrom(src => src.FieldOfStudy.Name));

            //Tworzenie mapy dla tabeli Workers
            CreateMap<Worker, WorkerViewModel>()
            .ForMember(b => b.WorkplaceName, opt => opt.MapFrom(src => src.Workplace.Name));
        }
      
    }
}
