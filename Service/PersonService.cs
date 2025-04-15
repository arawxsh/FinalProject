using Model.DomainModels;
using Model.ServiceModels;
using Service.Dtos;

namespace Service
{
    public class PersonService
    {
        private readonly PersonServiceModel _personServiceModel;

        public PersonService()
        {
            _personServiceModel = new PersonServiceModel();
        }

        public void Post(PostPersonDto postPersonDto)
        {
            var person = new Person()
            {
                FirstName = postPersonDto.FirstName,
                LastName = postPersonDto.LastName,
                NationalId = postPersonDto.NationalId
            };
            _personServiceModel.Post(person);
        }

        public List<Person> GetAll()
        {
            var persons = _personServiceModel.SelectAll();
            var getPersonDtos = new List<GetPersonDto>();
            foreach (var item in persons)
            {
                var gpd = new GetPersonDto()
                {
                    NationalId = item.NationalId,
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                };
                getPersonDtos.Add(gpd);
            }

            return persons;
        }

        public void Edit(EditPersonDto editPersonDto)
        {
            var person = new Person()
            {
                Id = editPersonDto.Id,
                FirstName = editPersonDto.FirstName,
                LastName = editPersonDto.LastName,
                NationalId = editPersonDto.NationalId,
            };
            _personServiceModel.Edit(person);
        }

        public void Delete(DeletePersonDto DeletePersonDto)
        {
            var person = new Person()
            {
                Id = DeletePersonDto.Id
            };
            _personServiceModel.Delete(person);
        }
    }
}
