using AutoMapper;
using Bonus.Data.DTOs;
using Bonus.Data.Models;

namespace Bonus.Core.Mappings
{
    public class MappingProfile : Profile {
        public MappingProfile() {
            // Add as many of these lines as you need to map your objects
            CreateMap<TransactionDTO, Transaction>();
        }
    }
}