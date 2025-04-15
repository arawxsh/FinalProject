using Model.DomainModels;

namespace Model.ServiceModels
{
    public class PersonServiceModel
    {
        public List<Person> SelectAll()
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    var people = context.Person.ToList();
                    return people;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }

        public void Post(Person person)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    context.Person.Add(person);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }

        public void Edit(Person person)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    var personFind = context.Person.Find(person.Id);
                    if (personFind != null)
                    {
                        personFind.FirstName= person.FirstName;
                        personFind.LastName= person.LastName;
                        personFind.NationalId = person.NationalId;
                        context.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    throw new AggregateException("Error");
                }
            
            }

            
        }

        public void Delete(Person person)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    context.Person.Remove(person);
                        context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new AggregateException("Error");
                }
            }
        }

    }
}
