using RealEstate.Application.Interfaces.Properties;
using RealEstate.Application.Interfaces.UnitOfWork;
using RealEstate.Domain.Properties;

namespace RealEstate.Application.Services.Properties
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public PropertyService(IPropertyRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Property> Create(Property property)
        {
            property.Id = Guid.NewGuid();
            var entity = await _repository.Create(property);
            await _unitOfWork.Commit();
            return entity;
        }

        public async Task<Property> Delete(Property property)
        {
            var entity = _repository.Delete(property);
            await _unitOfWork.Commit();
            return entity;
        }

        public async Task<Property> Delete(Guid id)
        {
            var entity = await _repository.Delete(id);
            await _unitOfWork.Commit();
            return entity;
        }

        public Task<IEnumerable<Property>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Property> GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public async Task<Property> Update(Property property)
        {
            var entity = _repository.Update(property);
            await _unitOfWork.Commit();
            return entity;
        }
    }
}
