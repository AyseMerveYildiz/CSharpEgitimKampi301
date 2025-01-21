using CSharpEgitimKampi301.DataAccessLAyer.Abstract;
using CSharpEgitimKampi301.DataAccessLAyer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLAyer.EntityFramework
{
    public class EfCustomerDal:GenericRepository<Customer>, ICustomerDal
    {
    }
}
