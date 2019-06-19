using FileManager.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Dao.Contracts.Dao
{
    public interface IAirportDao
    {
            Airport Add(Airport airport);

            Airport Get();

            IDictionary<Airport, List<Airport>> Airports();
       
    }
}
