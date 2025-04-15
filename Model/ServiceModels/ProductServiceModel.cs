using Model.DomainModels;

namespace Model.ServiceModels;

public class ProductServiceModel
{
    public List<Product> SelectAll()
    {
        using (var context = new FinalProjectDbContext())
        {
            try
            {
                var people = context.Product.ToList();
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

    public void Post(Product product)
    {
        using (var context = new FinalProjectDbContext())
        {
            try
            {
                context.Product.Add(product);
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

    public void Edit(Product product)
    {
        using (var context = new FinalProjectDbContext())
        {
            try
            {
                var productFind = context.Product.Find(product.Code);
                if (productFind != null)
                {
                    productFind.Title = product.Title;
                    productFind.UnitPrice = product.UnitPrice;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new AggregateException("Error");
            }

        }


    }

    public void Delete(Product product)
    {
        using (var context = new FinalProjectDbContext())
        {
            try
            {
                context.Product.Remove(product);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new AggregateException("Error");
            }
        }
    }

}