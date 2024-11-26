using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Entities.VehicleType_SubTypes
{
    public class VehicleTypeRepository: IVehicleTypeRepository
    {
        private readonly IBaseRepository<VechileType> _baseRepository;
        public VehicleTypeRepository(IBaseRepository<VechileType> baseRepository )
        {
            _baseRepository = baseRepository;
        }


        public async 

    }
}
