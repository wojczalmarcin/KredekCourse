using AutoMapper;
using MarcinWojczalUniveristyFacultyEF.Infrastructure;
using MarcinWojczalUniversityFacultyEF.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Repositories
{
    public abstract class Repository
    {
        protected readonly DataBaseContext DbContext = new DataBaseContext();
        //zmienna konfiguracji mappera
        private static MapperConfiguration MapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperProfile()));
        //zmienna mappera
        protected readonly IMapper Mapper = MapperConfig.CreateMapper();
    }
}
